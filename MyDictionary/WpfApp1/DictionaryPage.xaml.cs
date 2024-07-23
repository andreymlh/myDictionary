﻿using System;
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

namespace MyDictinary.App
{
    /// <summary>
    /// Логика взаимодействия для DictionaryPage.xaml
    /// </summary>
    public partial class DictionaryPage : Page
    {
        private DictionaryViewModel translationViewModel;

        public DictionaryPage()
        {
            InitializeComponent();
        }

        public DictionaryPage(DictionaryViewModel translationViewModel)
        {
            this.translationViewModel = translationViewModel;
        }
    }
}
