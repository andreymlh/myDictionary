using MyDictionary.Core.Data;
using MyDictionary.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary.Core.Service
{
    public class CategoryService
    {
        
        private CategoryDataSource _dataSource;
        private List<Category> _categoryList = new List<Category>();
        public CategoryService(CategoryDataSource dataSource)
        {
            _dataSource = dataSource;
            _categoryList = _dataSource.Get() ?? new List<Category>();
        }
        /// <summary>
        /// Получить все фильмы
        /// </summary>
        /// <returns></returns>
        public List<Category> GetAll()
        {
            return _categoryList;
        }
        /// <summary>
        /// Получить фильм по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор фильма</param>
        /// <returns>null в случае, если фильм не найден</returns>
        public Category Get(int id)
        {
            foreach (Category Category in _categoryList)
                if(Category.ItemId == id)
                    return Category;
            return null;
        }
        /// <summary>
        /// Добавить новый фильм
        /// </summary>
        /// <param name="Category"></param>
        public void Create(Category Category)
        {
            _categoryList.Add(Category);
            _dataSource.Write(_categoryList);
        }
        /// <summary>
        /// Удалить фильм по идентификатору
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            foreach (Category Category in _categoryList)
                if (Category.ItemId == id)
                {
                    _categoryList.Remove(Category);
                    break;
                }
            _dataSource.Write(_categoryList);
        }
        /// <summary>
        /// Обновить фильм
        /// </summary>
        /// <param name="Category"></param>
        public void Update(Category Category)
        {
            for (int i = 0; i < _categoryList.Count; i++)
                if (Category.ItemId == _categoryList[i].ItemId)
                    _categoryList[i] = Category;
            _dataSource.Write(_categoryList);
        }
    }
}
