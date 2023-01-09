using Liczba_uczestników.Model_danych;

namespace Liczba_uczestników
{
    public partial class Form1 : Form
    {
        Pobieranie_danych pobieranie_Danych;
        public Form1()
        {
            InitializeComponent();
            pobieranie_Danych = new Pobieranie_danych();
            pobieranie_Danych.Pobieranie_z_danych();
            Pokaz_dane();

        }
        public void Pokaz_dane()
        {
            textboxlist.Clear();
            foreach(Osoba osoba in pobieranie_Danych.Lista_osob)
            {
                textboxlist.Text += osoba.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pobieranie_Danych.Lista_osob.Sort();
            Pokaz_dane();
        }
    }
}