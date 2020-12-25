//Morkulev_DV_IU6-76_DZ_Part_1
using System;


namespace Morkulev_DZ
{
    public class Compositor
    {
        public string Name, Surname;

        public Compositor() //конструктор по умолчанию
        { 
            Name = " - "; 
            Surname = " - ";
            Console.WriteLine("Имя: {0}\nФамилия: {1}\n", Name, Surname);
        }
        public Compositor(string name,string surname) //конструктор по умолчанию
        {
            Name = name;
            Surname = surname;
            Console.WriteLine("Имя: {0}\nФамилия: {1}\n", Name, Surname);
        }
        public string Represent()
        {
            string author = Name + ' ' + Surname;
            return author;
        }
    }
    public class Album
    {
        public string Name;
        public int Year;

        public Album() //конструктор по умолчанию
        {
            Name = " - ";
            Year =  0;
            Console.WriteLine("Название: {0}\nГод: {1}\n", Name, Year);
        }
        public Album(string name, int year)
        {
            Name = name;
            Year = year;
            Console.WriteLine("Название: {0}\nГод: {1}\n", Name, year);
        }
        public string Represent()
        {
            string album = Name + " Год: " + Year.ToString();
            return album;
        }
    }
    public class Song
    {
        public string Name, Genre;
        public int Year;
        public Compositor Author,Author1,Author2;
        public Album Album;
        public Song() //конструктор по умолчанию
        {
            Name = " - ";
            Genre = " - ";
            Year = 0;
            Console.WriteLine("Название: {0}\nЖанр: {1}\nГод: {2}\n", Name, Genre,"Неизвесто");
        }
        public Song(string name,string genre, int year) //композитор неизвестен
        {
            Name = name;
            Genre = genre;
            Year = year;
            Console.WriteLine("Название: {0}\nЖанр: {1}\nГод: {2}\n", Name, Genre, Year);
        }
        public Song(string name, string genre, int year, Compositor author) //один композитор
        {
            Name = name;
            Genre = genre;
            Year = year;
            Author = author;
            Console.WriteLine("Название: {0}\nЖанр: {1}\nГод: {2}\nАвтор: {3}\n", Name, Genre, Year, Author.Represent());

      }
        public Song(string name, string genre, int year, Compositor author1, Compositor author2)//два композитора
        {
            Name = name;
            Genre = genre;
            Year = year;
            Author1 = author1;
            Author2 = author2;
            Console.WriteLine("Название: {0}\nЖанр: {1}\nГод: {2}\nАвторs: {3}, {4}\n", Name, Genre, Year, Author1.Represent(), Author2.Represent());

        }
        public Song(string name, string genre, int year, Compositor author, Compositor author1, Compositor author2)//три композитора
        {
            Name = name;
            Genre = genre;
            Year = year;
            Author = author;
            Author1 = author1;
            Author2 = author2;
            Console.WriteLine("Название: {0}\nЖанр: {1}\nГод: {2}\nАвторs: {3}, {4}, {5}\n", Name, Genre, Year, Author.Represent(), Author1.Represent(), Author2.Represent());

        }
        //с албомом
        public Song(string name, string genre, int year,Album album) //нет композитора
        {
            Name = name;
            Genre = genre;
            Year = year;
            Album = album;
            Console.WriteLine("Название: {0}\nЖанр: {1}\nГод: {2}\nАльбом: {3}\n", Name, Genre, Year, Album.Represent()); ;
        }
        public Song(string name, string genre, int year, Compositor author, Album album) //композитор
        {
            Name = name;
            Genre = genre;
            Year = year;
            Author = author;
            Album = album;
            Console.WriteLine("Название: {0}\nЖанр: {1}\nГод: {2}\nАвтор: {3}\nАльбом: {4}\n", Name, Genre, Year, Author.Represent(), Album.Represent());

        }
        public Song(string name, string genre, int year, Compositor author1, Compositor author2, Album album)//два композитора
        {
            Name = name;
            Genre = genre;
            Year = year;
            Author1 = author1;
            Author2 = author2;
            Album = album;
            Console.WriteLine("Название: {0}\nЖанр: {1}\nГод: {2}\nАвторs: {3}, {4}\nАльбом: {5}\n", Name, Genre, Year, Author1.Represent(), Author2.Represent(), Album.Represent());

        }
        public Song(string name, string genre, int year, Compositor author, Compositor author1, Compositor author2, Album album)//три композитора
        {
            Name = name;
            Genre = genre;
            Year = year;
            Author = author;
            Author1 = author1;
            Author2 = author2;
            Album = album;
            Console.WriteLine("Название: {0}\nЖанр: {1}\nГод: {2}\nАвторs: {3}, {4}, {5}\nАльбом: {6}\n", Name, Genre, Year, Author.Represent(), Author1.Represent(), Author2.Represent(), Album.Represent());

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Compositor SW = new Compositor("Slava", "Marlow");
            Compositor MD = new Compositor("Maraq", "DJ'a");
            Compositor MB = new Compositor("Metro", "Boomin");
            Compositor CB = new Compositor("Cake", "Boy");
            Compositor RJ = new Compositor("Ronny", "J");
            Album LD = new Album("Legendary Dust",2020);
            Song DF = new  Song("Domofon","Rap",2020,SW, MD, MB, LD);
            Song HA = new Song("Heart Attack","Rap/Rock", 2018, RJ);
            Album SH20 = new Album("SHANSON HITS 2020",2020);
            Song ZC = new  Song("Zolotaya Couple","Shanson",2020,SW, MD, MB, SH20);

           Console.ReadKey();
        }
    }
}
