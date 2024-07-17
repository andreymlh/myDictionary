using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDictionary.Core.Entity;

namespace MyDictionary.Core.Data
{
    /// <summary>
    /// Класс для доступа к данным о фильмах
    /// </summary>
    public class TranslationDataSource
    {
        /// <summary>
        /// Относительный путь к файлу, где хранятся данные
        /// </summary>
        private readonly string path = ".\\data.json";

        /// <summary>
        /// Метод чтения данных в формате JSON 
        /// и их десериализация
        /// </summary>
        /// <returns></returns>
        public List<Translation> Get()
        {
            if (File.Exists(path))
            {
                string data = File.ReadAllText(path);
                var tmp = DataSerializer.Deserialize<List<Translation>>(data) ?? [];
                Translation._id_counter = tmp.Count > 0 ? tmp.Select(x => x.ItemId).Max() + 1 : 0;
                return tmp;
            }
            return [];
        }

        /// <summary>
        /// Метод записи данных в формате JSON в файл
        /// </summary>
        /// <returns></returns>
        public void Write(List<Translation> data)
        {
            File.WriteAllText(path, DataSerializer.Serialize(data));
        }
    }
}
