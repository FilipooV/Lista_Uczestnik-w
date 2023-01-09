using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liczba_uczestników.Model_danych
{
    public class Osoba : IComparable<Osoba>
    {
        private int ID;
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public DateTime Data_Urodzenia { get; set; }
        public decimal Srednia_Ocen;
        public string Poziom_Angielski { get; set; }

        public Osoba()
        {
            
        }
        public Osoba(int iD, string imie, string nazwisko, DateTime data_Urodzenia, decimal srednia_Ocen, string poziom_Angielski)
        {
            ID = iD;
            Imie = imie;
            Nazwisko = nazwisko;
            Data_Urodzenia = data_Urodzenia;
            Srednia_Ocen = srednia_Ocen;
            Poziom_Angielski = poziom_Angielski;
        }

        public override string ToString()
        {
            return this.Imie + " " + this.Nazwisko + "\n" + "Data urodzenia " + this.Data_Urodzenia.ToString("D") + "" + "\n" + "Średnia ocen " + this.Srednia_Ocen.ToString("F2") + "\n" + "Poziom angielskiego " + this.Poziom_Angielski + "" +
                "n ";
        }

        public int CompareTo(Osoba? other)
        {
            if (other == null)
                return 1;
            if (ReferenceEquals(this, other)) 
                return 0;

            if (this.Srednia_Ocen < other.Srednia_Ocen)
                return -1;

            else if (this.Srednia_Ocen > other.Srednia_Ocen)
                return 0;
            else
                return 0;
        }
    }
}
