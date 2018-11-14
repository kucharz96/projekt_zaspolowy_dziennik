namespace Dziennik.Migrations
{
    using Dziennik.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Diagnostics;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Dziennik.DAL.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Dziennik.DAL.Context context)
        {
            var klasy = new List<Klasa>
            {
            new Klasa{nazwa = "A", level = klasa.kl1},
            new Klasa{nazwa = "B", level = klasa.kl2},
            new Klasa{nazwa = "C", level = klasa.kl3},

            };
            klasy.ForEach(s => context.Klasy.Add(s));
            context.SaveChanges();
            var nauczyciele = new List<Nauczyciel>
            {
             new Nauczyciel{imie = "Janusz", nazwisko = "Tracz", login = "kucharz97", haslo="1234",KlasaID =1},
             new Nauczyciel{imie = "Wies�aw", nazwisko = "Kozak", login = "kucharz98", haslo="1234",KlasaID =2},
             new Nauczyciel{imie = "Wiktor", nazwisko = "Jakowluk", login = "kucharz9", haslo="1234",KlasaID =3},
            };
            nauczyciele.ForEach(s => context.Nauczyciele.Add(s));
            context.SaveChanges();

          

            var lekcje = new List<Lekcja>
            {
            new Lekcja{KlasaID = 1,date = new DateTime(2008, 5, 1, 8, 30, 52)},
            new Lekcja{KlasaID = 2,date = new DateTime(2008, 5, 1, 8, 30, 52)},
            new Lekcja{KlasaID = 3,date = new DateTime(2008, 5, 1, 8, 30, 52)},
            };
            lekcje.ForEach(s => context.Lekcja.Add(s));
            context.SaveChanges();

            var rodzice = new List<Rodzic>
            {
            new Rodzic{imie = "Janusz", nazwisko = "Kucharski", login = "kucharz96", haslo="1234"},
            new Rodzic{imie = "Kamila", nazwisko = "Jarmoc", login = "elkamilaszczy", haslo="1234" },
            new Rodzic{imie = "Maria", nazwisko = "Krasucki", login = "rafonix", haslo="1234" },
            };
            rodzice.ForEach(s => context.Rodzice.Add(s));
            context.SaveChanges();

            var uczniowie = new List<Uczen>
            {
            new Uczen{imie = "Jan", nazwisko = "Kucharski", login = "kucharz96", haslo="1234",RodzicID=1,KlasaID = 1},
            new Uczen{imie = "Kamil", nazwisko = "Jarmoc", login = "elkamilaszczy", haslo="1234",RodzicID=2, KlasaID = 2},
            new Uczen{imie = "Marcin", nazwisko = "Krasucki", login = "rafonix", haslo="1234",RodzicID=3, KlasaID = 3 },
            };

            uczniowie.ForEach(s => context.Uczniowie.Add(s));
            context.SaveChanges();

            var administratorzy = new List<Administrator>
            {
            new Administrator{imie = "Jan", nazwisko = "Kowalski", login = "kucharz96", haslo="1234"},
            
            };

            administratorzy.ForEach(s => context.Administratorzy.Add(s));
            context.SaveChanges();



        }
    }
}
