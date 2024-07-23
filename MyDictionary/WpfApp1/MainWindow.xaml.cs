using MyDictinary.App;
using MyDictionary.Core.Data;
using MyDictionary.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DictionaryViewModel translationViewModel = new DictionaryViewModel(new TranslationService(new TranslationDataSource()));
        private CategoryViewModel categoryViewModel = new CategoryViewModel(new CategoryService(new CategoryDataSource()));


        public MainWindow()
        {
            InitializeComponent();
        }

        private void BokingPage_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new CategoryAddPage(categoryViewModel);
        }

        private void CinemaListPage_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new DictionaryPage(translationViewModel);
        }
    }
}
