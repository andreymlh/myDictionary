using MyDictinary.App.Core;
using MyDictionary.Core.Entity;
using MyDictionary.Core.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictinary.App
{
    public class MainViewModel : ObservableObject
    {

        private string _input = string.Empty;
        public string Input
        {
            get => _input; set
            {
                _input = value; OnPropertyChanged("Input");
            }
        }

        private string _secondInput = string.Empty;
        public string SecondInput
        {
            get => _secondInput; set
            {
                _secondInput = value; OnPropertyChanged("SecondInput");
            }
        }

        private ObservableCollection<Translation> _translationList = new ObservableCollection<Translation>();
        public ObservableCollection<Translation> TranslationList { get => _translationList; set { _translationList = value; OnPropertyChanged("TranslationList"); } }

        private TranslationService translationService;

        private Translation _selectedTranslation;
        public Translation SelectedTranslation
        {
            get => _selectedTranslation;
            set
            {
                _selectedTranslation = value;
                OnPropertyChanged("Selectedtranslation");
            }
        }

        public MainViewModel(TranslationService service)
        {
            translationService = service;
            TranslationList = new ObservableCollection<Translation>(translationService.GetAll());
        }


        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand(obj =>
                  {
                      translationService.Create(
                          new Translation(0, Input,SecondInput)
                          );
                      TranslationList = new ObservableCollection<Translation>(translationService.GetAll());
                  }));
            }
        }

        private RelayCommand deleteCommand;
        public RelayCommand DeleteCommand
        {
            get
            {
                return deleteCommand ??
                  (deleteCommand = new RelayCommand(obj =>
                  {
                      translationService.Delete(
                          SelectedTranslation.ItemId
                          );

                      TranslationList = new ObservableCollection<Translation>(translationService.GetAll());
                  }));
            }
        }
        //
        private RelayCommand editCommand;
        public RelayCommand EditCommand
        {
            get
            {
                return editCommand ??
                  (editCommand = new RelayCommand(obj =>
                  {
                      SelectedTranslation.Title = Input;
                      translationService.Update(
                          SelectedTranslation
                          );
                      TranslationList = new ObservableCollection<Translation>(translationService.GetAll());
                  }));
            }
        }

    }
}
