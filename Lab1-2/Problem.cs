using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    public class Problem
    {
        public int NumberOfItems { get; set; }
        public int Seed { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();
        
        public Problem (int numberOfItems, int seed)
        {
            this.NumberOfItems = numberOfItems;
            this.Seed = seed;

            Random random = new Random(Seed);

            for (int i = 0; i < NumberOfItems; i++)
            {
                int randomWeight = random.Next(1,21);
                int randomValue = random.Next(1, 21);

                Item currentItem = new Item(randomWeight, randomValue, i);
                Items.Add(currentItem);
            }
        }

        public Result Solve(int capacity)
        {
            Result result = new Result();
            List<Item> sortedItems = Items;
            sortedItems.Sort((x, y) => (y.Value / y.Weight).CompareTo(x.Value / x.Weight));

            int currentCapacity = 0;

            for (int i = 0; i < NumberOfItems; i++)
            {
                int currentWeight = sortedItems[i].Weight;
                int currentValue = sortedItems[i].Value;
                int currentIndex = sortedItems[i].Index;

                if ((currentWeight + currentCapacity) <= capacity)
                {
                    result.SelectedItems.Add(currentIndex);
                    result.TotalWeight += currentWeight;
                    result.TotalValue += currentValue;

                    currentCapacity += currentWeight;
                }
            }

            return result;
        }

        public override string ToString()
        {
            string stringRepresentation = "";

            for (int i = 0; i < NumberOfItems; i++)
            {
                stringRepresentation += $"n: {i}  v: {Items[i].Value}  w: {Items[i].Weight} \n";
            }

            return stringRepresentation;
        }
    }
}
