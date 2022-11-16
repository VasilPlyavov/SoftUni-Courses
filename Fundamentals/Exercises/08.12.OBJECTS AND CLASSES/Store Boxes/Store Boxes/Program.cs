using System;
using System.Collections.Generic;
using System.Linq;
namespace Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Start entering: ");
            List<Box> boxes = new List<Box>();
            string input = Console.ReadLine();
            while ( input !="end")
            {
                string[] inputinfo = input.Split(" ");
                string serialNumber = inputinfo[0];
                string itemName = inputinfo[1];
                int quantity = int.Parse(inputinfo[2]);
                decimal itemPrice = decimal.Parse(inputinfo[3]);

                Item item = new Item();
                item.Name = itemName;
                item.Price = itemPrice;

                Box box = new Box();
                box.SerialNumber = serialNumber;
                box.ItemQuantity = quantity;
                box.Item = item;
                boxes.Add(box);

                input = Console.ReadLine();
            }
           
            foreach ( var currentBox in boxes.OrderByDescending(x=> x.PriceBox))
            {
                Console.WriteLine(currentBox.SerialNumber);
                Console.WriteLine($"---{currentBox.Item.Name} - {currentBox.Item.Price:F2} {currentBox.ItemQuantity} \n-- {currentBox.PriceBox}");


            }
        }
    }
}
