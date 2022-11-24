using System;
using System.Linq;
using System.Collections.Generic;
namespace projects
{
    class Team
    {
        public string TeamName { get; set; }
        public string CreatorName { get; set; }
        public List<string> Members { get; set; }
        public Team()
        {
            Members = new List<string>();
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            List<Team> listTeams = new List<Team>();

            while (!input.Equals("end of assignment"))
            {
                if (input.Contains('-') && (!input.Contains('>')))
                {
                    var creatorAndTeamName = input.Split('-').ToArray();
                    if (listTeams.Any(x => x.TeamName == creatorAndTeamName[1]))
                    {
                        Console.WriteLine("Team {0} was already created!", creatorAndTeamName[1]);
                    }
                    else if (listTeams.Any(x => x.CreatorName == creatorAndTeamName[0]) || listTeams.Any(x => x.Members.Contains(creatorAndTeamName[0])))
                    {
                        Console.WriteLine("{0} cannot create another team!", creatorAndTeamName[0]);
                    }
                    else
                    {
                        Team currentTeam = new Team();
                        currentTeam.CreatorName = creatorAndTeamName[0];
                        currentTeam.TeamName = creatorAndTeamName[1];
                        listTeams.Add(currentTeam);
                        Console.WriteLine("Team {0} has been created by {1}!", currentTeam.TeamName, currentTeam.CreatorName);
                    }
                    input = Console.ReadLine();
                    continue;
                }
                else
                {
                    var memberAndTeamName = input.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    if (listTeams.Any(x => x.TeamName == memberAndTeamName[1]))
                    {
                        if (listTeams.Any(x => x.Members.Contains(memberAndTeamName[0])) || listTeams.Any(x => x.CreatorName.Contains(memberAndTeamName[0])))
                        {
                            Console.WriteLine("Member {0} cannot join team {1}!", memberAndTeamName[0], memberAndTeamName[1]);
                            input = Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            foreach (var team in listTeams)
                            {
                                if (team.TeamName.Contains(memberAndTeamName[1]))
                                {
                                    team.Members.Add(memberAndTeamName[0]);
                                    input = Console.ReadLine();
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Team {0} does not exist!", memberAndTeamName[1]);
                        input = Console.ReadLine();
                        continue;
                    }
                }
            }
            var printList = listTeams.OrderByDescending(x => x.Members.Count).ThenBy(a => a.TeamName);
            foreach (var team in printList)
            {
                if (team.Members.Count > 0)
                {
                    Console.WriteLine(team.TeamName);
                    Console.WriteLine("- {0}", team.CreatorName);
                    for (int i = 0; i < team.Members.Count; i++)
                    {
                        Console.WriteLine("-- {0}", team.Members[i]);
                    }
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (var team in listTeams.OrderBy(a => a.TeamName))
            {
                if (team.Members.Count == 0)
                {
                    Console.WriteLine(team.TeamName);
                }
            }
        }
    }

}
