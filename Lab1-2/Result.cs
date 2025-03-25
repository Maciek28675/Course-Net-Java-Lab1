using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    public class Result
    {
        public List<int> SelectedItems { get; set; } = new List<int>();
        public int TotalValue { get; set; } = 0;
        public int TotalWeight { get; set; } = 0;

        public override string ToString()
        {
            string itemsToPrint = "";

            foreach (var item in SelectedItems)
            {
                itemsToPrint += (item.ToString() + " ");
            }

            return $"Items: {itemsToPrint} \ntotal value: {TotalValue} \ntotal weight: {TotalWeight}";
        }
    }
}
