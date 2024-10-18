using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_10_11.Model
{
    class ItemModel
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public bool IsChecked { get; set; }

        public ItemModel(string name, string url, bool isChecked)
        {
            Name = name;
            Url = url;
            IsChecked = isChecked;
        }

        public ItemModel()
        {
        }

    }
}
