using MyDictionary.Core.Data;
using MyDictionary.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary.Core.Service
{
    public class TranslationService
    {
        
        private TranslationDataSource _dataSource;
        private List<Translation> _translations = new List<Translation>();
        public TranslationService(TranslationDataSource dataSource)
        {
            _dataSource = dataSource;
            _translations = _dataSource.Get();
        }
        /// <summary>
        /// Получить все фильмы
        /// </summary>
        /// <returns></returns>
        public List<Translation> GetAll()
        {
            return _translations;
        }
        /// <summary>
        /// Получить фильм по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор фильма</param>
        /// <returns>null в случае, если фильм не найден</returns>
        public Translation Get(int id)
        {
            foreach (Translation translation in _translations)
                if(translation.ItemId == id)
                    return translation;
            return null;
        }
        /// <summary>
        /// Добавить новый фильм
        /// </summary>
        /// <param name="translation"></param>
        public void Create(Translation translation)
        {
            _translations.Add(translation);
            _dataSource.Write(_translations);
        }
        /// <summary>
        /// Удалить фильм по идентификатору
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            foreach (Translation translation in _translations)
                if (translation.ItemId == id)
                {
                    _translations.Remove(translation);
                    break;
                }
            _dataSource.Write(_translations);
        }
        /// <summary>
        /// Обновить фильм
        /// </summary>
        /// <param name="translation"></param>
        public void Update(Translation translation)
        {
            for (int i = 0; i < _translations.Count; i++)
                if (translation.ItemId == _translations[i].ItemId)
                    _translations[i] = translation;
            _dataSource.Write(_translations);
        }
    }
}
