using CollectionViewDemo.Models;
using System.Collections.Generic;

namespace CollectionViewDemo.Data
{
    public static class ItemData
    {
        public static IList<Item> Items { get; private set; }

        static ItemData()
        {
            Items = new List<Item>();

            Items.Add(new Item
            {
                Name="Jorge Guerrero",
                Company="Geojorg CO",
                Age = "34"
            });

            Items.Add(new Item
            {
                Name = "Andres Montes",
                Company = "Umbrella Corp.",
                Age = "30"
            });

            Items.Add(new Item
            {
                Name = "Hella Ilch",
                Company = "Asgard CO.",
                Age = "27"
            });

            Items.Add(new Item
            {
                Name = "Jorge Ilch",
                Company = "Asgard CO.",
                Age = "27"
            });

            Items.Add(new Item
            {
                Name = "Jorel",
                Company = "Asgard CO.",
                Age = "27"
            });

        }
    }
}
