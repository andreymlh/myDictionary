using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary.Core
{
    /// <summary>
    /// Класс перевода. 
    /// Содержит два слова - одно, которое нужно перевести, 
    /// второе, которое является переводом.
    /// </summary>
    public class Translation
    {
        public Translation(int id, string firstWord = "", string secondWord = "")
        {
            Id = id;
            FirstWord = firstWord;
            SecondWord = secondWord;
        }

        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        public int Id { get; set; }

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
            return Id + "|" + FirstWord + " - " + SecondWord;
        }
    }
}
