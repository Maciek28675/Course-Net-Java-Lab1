using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    public class Item
    {
        public int Weight { get; private set; }
        public int Value { get; private set; }

        public int Index { get; private set; }

        public Item(int weight, int value, int index)
        {
            this.Weight = weight;
            this.Value = value;
            this.Index = index;
        }
    }
}
