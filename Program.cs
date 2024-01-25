using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Album main_floor = new Album();

            //add items
            main_floor.AddItem(new Item("The Crux", 2012));
            main_floor.AddItem(new Item("Chromatica", 2020));

            //Uses indexer to grab Year
            Console.WriteLine("The Crux by HURT was released in " + main_floor["The Crux"] +
                "and Chromatica by Lady Gaga in " + main_floor["Chromatica"] + ".");
            Console.ReadKey();


        }

    }
    class Album
    {
        List<Item> Items = new List<Item>();

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public double this[string  index]
        {
            get
            {
                foreach (Item item in Items)
                {
                    if (item.Name == index)
                    {
                        return item.Year;
                    }
                }
                //Used to signify there is not item
                return -1;
            }
            set
            {
                //you can use this to set a value much like setting a value in an attribute
            }
        }

    }
    //simple class to hold Item 
    class Item
    {
        public Item(string name, double year)
        {
            Name = name;
            Year = year;
        }

        public string Name { get; }
        public double Year { get; }
    }
}