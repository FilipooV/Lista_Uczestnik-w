using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liczba_uczestników.Model_danych
{
    public class Pobieranie_danych
    {
        //Bedziemy pobierac dane
        public List<Osoba> Lista_osob { get; set; }

        //Konstrukutor
        public Pobieranie_danych()
        {
            Lista_osob = new List<Osoba>();

        }
        public void Pobieranie_z_danych()
        {
            string s_connection = @"Data Source = uczestnicy.db";
            SqliteConnection connection = new SqliteConnection(s_connection);
            connection.Open();

            var command = connection.CreateCommand();
            string sql = "select id, Imie, Nazwisko, Data_Urodzenia, Srednia_ocen, Poziom_Angielski " + "from Osoba;";


            command.CommandText = sql;
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(reader.GetOrdinal("Id"));
                string name = reader.GetString(reader.GetOrdinal("Imie"));
                string second_name = reader.GetString(reader.GetOrdinal("Nazwisko"));
                DateTime dt_U = reader.GetDateTime(reader.GetOrdinal("Data_urodzenia"));
                decimal avg_grade = reader.GetDecimal(reader.GetOrdinal("Srednia_ocen"));
                string level_eng = reader.GetString(reader.GetOrdinal("Poziom_Angielski"));
                Lista_osob.Add(new Osoba(id, name, second_name,dt_U, avg_grade, level_eng));
            }
            connection.Close();
            connection.Dispose();

        }
    }
}
