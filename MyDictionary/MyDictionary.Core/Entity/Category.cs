using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary.Core.Entity
{
    public class Category
    {
        [JsonProperty("ItemId")]
        public int ItemId { get; set; }
        public string Title { get; set; }

        public static int _id_counter = 0;

        public Category(string title = "")
        {
            ItemId = _id_counter++;
            Title = title;

        }

    }
}
