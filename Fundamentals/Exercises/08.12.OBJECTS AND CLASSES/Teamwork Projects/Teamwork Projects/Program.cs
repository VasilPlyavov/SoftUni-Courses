using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamCount = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();  //list v koito da dyrjim vsichki otbori(ime,syzdatel i member )

            for (int i = 0; i < teamCount; i++)//
            {
                string[] newTeam = Console.ReadLine().Split("-");//tekushtiqt otbor
                string creatorName = newTeam[0];//imeto na choveka koito iska da go syzdade
                string teamName = newTeam[1];//imeto na otbora

                Team team = new Team(teamName, creatorName);//syzdavame otbora;

                bool isTeamNameExist = teams.Select(x => x.TeamName).Contains(teamName);  //proverqvame v koleciqta na teams syshtestvuva;
               
                bool isCreatorNameExist = teams.Select(x => x.CreatorName).Contains(creatorName);//proverqvame dali imeto e syzdadeno veche


                if (!isTeamNameExist)//ako otbora syshtestvuva
                {
                    if (!isCreatorNameExist)//ako tazi proverka e false togava se izpylnqva 
                    {
                        teams.Add(team);
                        Console.WriteLine($"Team {teamName} has been created by {creatorName}!.");
                    }
                    else
                    {
                        Console.WriteLine($"{creatorName} cannot create another team!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
            }
            string teamMembers = Console.ReadLine();
            while (teamMembers != "end of assignment")
            {

                string[] cmdArg = teamMembers.Split("->").ToArray(); //vzimame si inputa;
                string newUser = cmdArg[0];
                string teamName = cmdArg[1];

                bool isTeamExist = teams.Select(x => x.TeamName).Contains(teamName);
                bool isCreatorExist = teams.Select(x => x.CreatorName).Contains(newUser);
                bool isMemberExist = teams.Select(x => x.Members).Any(x => x.Contains(newUser));

                if (!isTeamExist)//proverqvame tiima v koito iskame da dobavim dali syshtstvuva
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (isCreatorExist || isMemberExist)
                {
                    Console.WriteLine($"Member {newUser} cannot join team {teamName}!");
                }
                else
                {
                    int index = teams.FindIndex(x => x.TeamName == teamName);
                    teams[index].Members.Add(newUser);
                }


                teamMembers = Console.ReadLine();
            }


            Team[] teamsToDisband = teams.OrderBy(x => x.TeamName)
                .Where(x => x.Members.Count == 0)
                .ToArray();//syzdavem masiv za diskfalificiranite 

            Team[] fullTeam = teams.OrderByDescending(x => x.Members.Count)
                    .ThenBy(x => x.TeamName)
                    .Where(x => x.Members.Count > 0)
                    .ToArray();

            StringBuilder sb = new StringBuilder();//izglejda kato masiv v koito moje da se dobavqt stringove
            foreach (Team team in fullTeam)
            {
                sb.AppendLine($"{team.TeamName}");
                sb.AppendLine($"- {team.CreatorName}");

                foreach (var member in team.Members.OrderBy(x=>x))
                {
                    sb.AppendLine($"-- {member}");
                }
            }
            sb.AppendLine($"Teams to disband:");
            foreach (Team item in teamsToDisband)
            {
                sb.AppendLine(item.TeamName);
            }
            Console.WriteLine(sb.ToString());
        }
    }
    class Team
    {
        public Team(string teamName, string creatorName)//syzdavame constructor;
        {
            TeamName = teamName;
            CreatorName = creatorName;
            Members = new List<string>();//koleciqta e veche syzdadena;
        }
        public string TeamName { get; set; }
        public string CreatorName { get; set; }
        public List<string> Members { get; set; }//syzdavame kolekciq zaradi imenata ot input

    }

}
