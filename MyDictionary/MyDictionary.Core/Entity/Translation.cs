using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary.Core.Entity
{
    /// <summary>
    /// Класс перевода. 
    /// Содержит два слова - одно, которое нужно перевести, 
    /// второе, которое является переводом.
    /// </summary>
    public class Translation
    {

        public static int _id_counter = 0;

        public Translation(string firstWord = "", string secondWord = "")
        {
            ItemId = _id_counter++;
            FirstWord = firstWord;
            SecondWord = secondWord;
        }

        [JsonProperty("ItemId")]
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        public int ItemId { get; set; }

        public int CategoryId { get; set; }

        /// <summary>
        /// Слово для перевода
        /// </summary>
        public string FirstWord { get; set; }

        /// <summary>
        /// Перевод
        /// </summary>
        public string SecondWord { get; set; }

        public override string ToString()
        {
            return ItemId + "|" + FirstWord + " - " + SecondWord;
        }
    }
}
