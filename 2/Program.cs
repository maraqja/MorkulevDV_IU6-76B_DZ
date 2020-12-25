//Morkulev_DV_IU6-76_DZ_Part_2
using System;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Morkulev_DZ
{
    public class Compositor
    {
        public string Name { get; set; }
        public string Surname {get; set;}

    }
    public class Album
    {
        public string Name { get; set; }
        public int Year { get; set; }

    }
    public class Song
    {
        public string Name { get; set; }
        public string Gener { get; set; }
        public int Year { get; set; }
        public Compositor[] Authors { get; set; }
        public Album Album_s { get; set; }

}
    class Program
    {
        static void Main(string[] args)
        {

            Compositor BBT = new Compositor
            {
                Name = "Tape",
                Surname = "Na Babkah"

            };
            Compositor GF = new Compositor
            {
                Name = "Gone",
                Surname = "Fludd "

            };
            Album MCH = new Album
            {
                Name = "MegaChuits",
                Year = 2019,
            };
            Song FD = new Song
            {
                Name = "FrameData",
                Year = 2019,
                Gener = "Rap",
                Authors = new Compositor[] { BBT, GF },
                Album_s = MCH

            };

            
            string json = JsonSerializer.Serialize<Song>(FD);
            Console.WriteLine(json);
            Console.ReadKey();
        }
    }
}
