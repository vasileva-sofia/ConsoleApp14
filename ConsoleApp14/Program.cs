//using System;

//public class Book
//{
//    private string _name;
//    private string _author;
//    private int _pages;
//    private string _genre;
//    private int _year;
//    private bool _mayRealese;

//    public Book(string name, string author, int pages, string genre, int year, bool mayRealese = true)
//    {
//        _author = author;
//        _name = name;
//        _pages = pages;
//        _genre = genre;
//        _year = year;
//        _mayRealese = mayRealese;
//    }

//    public string Name
//    {
//        get { return _name; }
//        set
//        {
//            if (string.IsNullOrWhiteSpace(value))
//            {
//                Console.WriteLine("Ошибка: Название книги не может быть пустым");
//            }
//            else
//            {
//                _name = value;
//            }
//        }
//    }
//    public string Author
//    {
//        get { return _author; }
//        set
//        {
//            if (string.IsNullOrWhiteSpace(value))
//            {
//                Console.WriteLine("Ошибка: Автор не может быть пустым");
//            }
//            else
//            {
//                _author = value;
//            }
//        }
//    }
//    public int Pages
//    {
//        get { return _pages; }
//        set
//        {
//            if (value <= 0)
//            {
//                Console.WriteLine("Ошибка: Количество страниц должно быть положительным числом.");
//            }
//            else
//            {
//                _pages = value;
//            }
//        }
//    }
//    public string Genre
//    {
//        get { return _genre; }
//        set
//        {
//            if (string.IsNullOrWhiteSpace(value))
//            {
//                Console.WriteLine("Ошибка: Жанр не может быть пустым");
//            }
//            else
//            {
//                _genre = value;
//            }
//        }
//    }
//    public int Year
//    {
//        get { return _year; }
//        set
//        {
//            if (value >= 1450 && value <= DateTime.Now.Year)
//            {
//                Console.WriteLine($"Ошибка: Год выпуска должен быть положительным и не позднее текущего");
//            }
//            else
//            {
//                _year = value;
//            }
//        }
//    }
//    public bool mayRealese
//    {
//        get { return _mayRealese; }
//        set
//        {
//            _mayRealese = value;
//        }
//    }

//    public void Knh()
//    {
//        Console.WriteLine($"Название: {Name}");
//        Console.WriteLine($"Автор: {Author}");
//        Console.WriteLine($"Страниц: {Pages}");
//        Console.WriteLine($"жанр: {Genre}");
//        Console.WriteLine($"год выпуска: {Year}");
//        Console.WriteLine($"Доступна: {mayRealese}");
//    }

//    public class Program
//    {
//        static List<Book> _allbooks = new List<Book>()
//      {
//          new Book("Война и мир", "Лев Толстой", 1225, "Роман-эпопея", 1869),
//          new Book("Маленький принц", "Антуан де Сент-Экзюпери", 96, "Сказка", 1943),
//          new Book("Преступление и наказание", "Фёдор Достоевский", 528, "Роман", 1866),
//          new Book("Гарри Поттер и Философский камень", "Джоан Роулинг", 223, "Фэнтези", 1997)
//      };
//        static void Main(string[] args)
//        {
//            Console.WriteLine("---это библиотека---");

//            Console.WriteLine("выберете дейстие");
//            Console.WriteLine("1.посмотреть список доступных книг" +
//                "\n2.взять книгу" +
//                "\n3.вернуть книгу" +
//                "\n4.посмотреть список прочитанных книг" +
//                "\n5.посмотреть список книг на руках");
//            int choice = Convert.ToInt32(Console.ReadLine());
//            switch (choice)
//            {
//                case 1:
//                    Booksinlibrary();
//                    break;
//                    //case 2:
//                    //    Msefasef();
//                    //    break;
//                    //case 3:
//                    //    Msefasef();
//                    //    break;
//                    //case 4:
//                    //    Msefasef();
//                    //    break;
//                    //case 5:
//                    //    Msefasef();
//                    //    break;

//            }
//            static void Booksinlibrary()
//            {
//                Console.WriteLine("\n--- Список доступных книг ---");
//                bool bbb = false;

//                for (int i = 0; i < _allbooks.Count; i++)
//                {
//                    if (_allbooks[i].mayRealese)
//                    {
//                        Console.WriteLine($"{i + 1} {_allbooks[i].Name} - {_allbooks[i].Author} ({_allbooks[i].Year}) {_allbooks[i].Genre}");//////////////!!!!!!!!!!!!
//                        bbb = true;
//                    }
//                }

//                if (!bbb)
//                {
//                    Console.WriteLine("Все книги сейчас недоступны.");
//                }
//            }
//        }
//        static void Takebook()
//        {
//            Console.WriteLine("\n---выберете книгу, которую вы хотите взять");

//        }

//    }
//}
using System;
using System.Collections.Generic;

public class Book
{
    private string _name;
    private string _author;
    private int _pages;
    private string _genre;
    private int _year;
    private bool _mayRealese;

    public Book(string name, string author, int pages, string genre, int year, bool mayRealese = true)
    {
        _author = author;
        _name = name;
        _pages = pages;
        _genre = genre;
        _year = year;
        _mayRealese = mayRealese;
    }

    public string Name
    {
        get { return _name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Ошибка: Название книги не может быть пустым");
            }
            else
            {
                _name = value;
            }
        }
    }
    public string Author
    {
        get { return _author; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Ошибка: Автор не может быть пустым");
            }
            else
            {
                _author = value;
            }
        }
    }
    public int Pages
    {
        get { return _pages; }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Ошибка: Количество страниц должно быть положительным числом.");
            }
            else
            {
                _pages = value;
            }
        }
    }
    public string Genre
    {
        get { return _genre; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Ошибка: Жанр не может быть пустым");
            }
            else
            {
                _genre = value;
            }
        }
    }
    public int Year
    {
        get { return _year; }
        set
        {
            if (value >= 1450 && value <= DateTime.Now.Year)
            {
                Console.WriteLine($"Ошибка: Год выпуска должен быть положительным и не позднее текущего");
            }
            else
            {
                _year = value;
            }
        }
    }
    public bool mayRealese
    {
        get { return _mayRealese; }
        set
        {
            _mayRealese = value;
        }
    }

    public void Knh()
    {
        Console.WriteLine($"Название: {Name}");
        Console.WriteLine($"Автор: {Author}");
        Console.WriteLine($"Страниц: {Pages}");
        Console.WriteLine($"жанр: {Genre}");
        Console.WriteLine($"год выпуска: {Year}");
    }
}

public class Program
{
    static List<Book> _allbooks = new List<Book>()
    {
        new Book("Война и мир", "Лев Толстой", 1225, "Роман-эпопея", 1869),
        new Book("Маленький принц", "Антуан де Сент-Экзюпери", 96, "Сказка", 1943),
        new Book("Преступление и наказание", "Фёдор Достоевский", 528, "Роман", 1866),
        new Book("Гарри Поттер и Философский камень", "Джоан Роулинг", 223, "Фэнтези", 1997)
    };

    static List<string> _readBooks = new List<string>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n---это библиотека---");
            Console.WriteLine("выберете дейстие");
            Console.WriteLine("1.посмотреть список доступных книг" +
                "\n2.взять книгу" +
                "\n3.вернуть книгу" +
                "\n4.посмотреть список прочитанных книг" +
                "\n5.посмотреть список книг на руках" +
                "\n6.выход");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Booksinlibrary();
                    break;
                case 2:
                    Takebook();
                    break;
                case 3:
                    Returnbook();
                    break;
                case 4:
                    ShowReadBooks();
                    break;
                case 5:
                    ShowBooksOnHand();
                    break;
                case 6:
                    Console.WriteLine("Выход из программы");
                    return;
                default:
                    Console.WriteLine("Неверный выбор");
                    break;
            }
        }
    }

    static void Booksinlibrary()
    {
        Console.WriteLine("\n--- Список доступных книг ---");
        bool bbb = false;

        for (int i = 0; i < _allbooks.Count; i++)
        {
            if (_allbooks[i].mayRealese)
            {
                Console.WriteLine($"{i + 1}. {_allbooks[i].Name} - {_allbooks[i].Author} ({_allbooks[i].Year}) {_allbooks[i].Genre}");
                bbb = true;
            }
        }

        if (!bbb)
        {
            Console.WriteLine("Все книги сейчас недоступны.");
        }
    }

    static void Takebook()
    {
        Console.WriteLine("\n--- Доступные книги ---");
        List<int> availableIndices = new List<int>();

        for (int i = 0; i < _allbooks.Count; i++)
        {
            if (_allbooks[i].mayRealese)
            {
                availableIndices.Add(i);
                Console.WriteLine($"{availableIndices.Count}. {_allbooks[i].Name} - {_allbooks[i].Author}");
            }
        }

        if (availableIndices.Count == 0)
        {
            Console.WriteLine("Нет доступных книг для взятия.");
            return;
        }

        Console.Write("Введите номер книги, которую хотите взять: ");
        int choice = Convert.ToInt32(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < availableIndices.Count)
        {
            int bookIndex = availableIndices[choice];
            _allbooks[bookIndex].mayRealese = false;
            Console.WriteLine($"Вы взяли книгу: {_allbooks[bookIndex].Name}");
        }
        else
        {
            Console.WriteLine("Неверный номер.");
        }
    }

    static void Returnbook()
    {
        Console.WriteLine("\n--- Книги на руках ---");
        List<int> takenIndices = new List<int>();

        for (int i = 0; i < _allbooks.Count; i++)
        {
            if (!_allbooks[i].mayRealese)
            {
                takenIndices.Add(i);
                Console.WriteLine($"{takenIndices.Count}. {_allbooks[i].Name} - {_allbooks[i].Author}");
            }
        }

        if (takenIndices.Count == 0)
        {
            Console.WriteLine("У вас нет книг на руках.");
            return;
        }

        Console.Write("Введите номер книги, которую хотите вернуть: ");
        int choice = Convert.ToInt32(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < takenIndices.Count)
        {
            int bookIndex = takenIndices[choice];
            _allbooks[bookIndex].mayRealese = true;

            if (!_readBooks.Contains(_allbooks[bookIndex].Name))
            {
                _readBooks.Add(_allbooks[bookIndex].Name);
            }

            Console.WriteLine($"Вы вернули книгу: {_allbooks[bookIndex].Name}");
        }
        else
        {
            Console.WriteLine("Неверный номер.");
        }
    }

    static void ShowReadBooks()
    {
        Console.WriteLine("\n--- Список прочитанных книг ---");

        if (_readBooks.Count == 0)
        {
            Console.WriteLine("Вы еще не прочитали ни одной книги.");
        }
        else
        {
            for (int i = 0; i < _readBooks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_readBooks[i]}");
            }
        }
    }

    static void ShowBooksOnHand()
    {
        Console.WriteLine("\n--- Список книг на руках ---");
        bool found = false;

        for (int i = 0; i < _allbooks.Count; i++)
        {
            if (!_allbooks[i].mayRealese)
            {
                Console.WriteLine($"{i + 1}. {_allbooks[i].Name} - {_allbooks[i].Author}");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("У вас нет книг на руках.");
        }
    }
}