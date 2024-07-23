using MyDictinary.App.Core;
using MyDictionary.Core.Service;

namespace WpfApp1
{
    public class CategoryViewModel : ObservableObject
    {
        private CategoryService categoryService;

        public CategoryViewModel(CategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
    }
}