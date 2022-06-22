using System;
using System.Linq;
using System.Collections.Generic;
using suhihz;

class LinqExercise27
{
    static void Main(string[] args)
    {

        List<Tovar> tovarchik = new List<Tovar>
        {
           new Tovar {Id = 1, Name = "Печенье"},
           new Tovar {Id = 2, Name ="Шоколад"},
           new Tovar {Id = 3, Name ="Масло сливочное"},
           new Tovar {Id = 4, Name ="Масло подсолнечное"},
           new Tovar {Id = 5, Name ="Brade"}
        };

        List<Spisoc> spisoc = new List<Spisoc>
        {
           new Spisoc {number=0, Id = 1, Price = 60 },
           new Spisoc {number=1, Id = 2, Price = 90 },
           new Spisoc {number=2, Id = 3, Price = 120 },
           new Spisoc {number=3, Id = 3, Price = 120 },
           new Spisoc {number=4, Id = 4, Price = 200 },
           new Spisoc {number=5, Id = 4, Price = 200},
           new Spisoc {number=6, Id = 5, Price = 250 }
        };
        var spisochek = from p in spisoc
                     join i in tovarchik on p.Id equals i.Id into a
                     from b in a.DefaultIfEmpty()
                     select new
                     {
                         number = b.Id,
                        name = b.Name,
                         сena = p.Price
                     };
        Console.WriteLine("Название группы\nИндификатор\nтовара\tНазваниетовара\tЦена\tПокупка");
        Console.WriteLine("-------------------------------------------------------");
        foreach (var tovar in spisochek)
        {
            Console.WriteLine(tovar.number + "\t" + tovar.name + "\t" + tovar.сena);
        }
        Console.ReadKey();
    }
}


