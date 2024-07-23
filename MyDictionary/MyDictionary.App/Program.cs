// See https://aka.ms/new-console-template for more information
using MyDictionary.Core.Data;
using MyDictionary.Core.Entity;
//Инициализация списка объектами. Конструктор можно вызывать по разному
List<Translation> translations = new List<Translation>()
{
    new Translation("apple","яблоко"),
    new Translation("bear", "медведь"),
    new Translation("cat", "кошка"),
};

TranslationDataSource translationDataSource = new TranslationDataSource();
//Записываем список в файл
translationDataSource.Write(translations);
//Считываем список из файла и выводим на экран
Console.WriteLine(string.Join("\n", translationDataSource.Get()));