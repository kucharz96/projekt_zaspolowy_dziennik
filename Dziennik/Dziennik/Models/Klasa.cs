﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dziennik.Models
{
    public enum klasa
    {
        kl1,kl2,kl3
    }
    public class Klasa
    {
        
        public int? KlasaID { get; set; }
        
        public int? NauczycielID { get; set; }
        public string nazwa { get; set; }
      
        public klasa? level { get; set; }

        public virtual Nauczyciel Nauczyciel{ get; set; }
        public virtual ICollection<PrzedmiotKlasaNauczyciel> Link { get; set; }
        public virtual ICollection<Uczen> Uczniowie { get; set; }
        
        public virtual ICollection<Lekcja> Lekcje { get; set; }
        public virtual ICollection<Plik> Pliki{ get; set; }
        public virtual ICollection<Test> Testy { get; set; }

    }
}