using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiotrKoleczeklab1
{
    public partial class FormMain : Form
    {
        // licznik, który inkrementujemy
        int incrementNumber;
        // zmienna do zmiany głównej etykiety
        int incrementerLabel;
        // zmienna licznikowa do zmiany koloru tła
        int incrementerColor;
        public FormMain()
        {
            InitializeComponent();
            // zmienna do inkrementacji liczby w TextLabel
            incrementNumber = 1;
            incrementerLabel = 2;
            incrementerColor = 0;
        }

        /// <summary>
        /// Funkcja zamykająca okienko programu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            //Zamknięcie okna programu
            Close();
        }

        /// <summary>
        /// Zmiana kolorów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChange_Click(object sender, EventArgs e)
        {
            // zwiększamy licznik, który przy operacji modulo pozwoli nam na wykonywanie pewnych instrukcji
            incrementerColor++;
            // jeśli licznik jest podzielny przez 2
            if (incrementerColor % 2 == 0)
            {
                // zmiana koloru tła na kolor Cyan
                this.BackColor = Color.Cyan;
                // przycisk zamknięcia programu = kolor limonkowy
                this.buttonClose.BackColor = Color.Lime;
                // przycisk do zmiany kolorów = kolor kasztanowy
                this.buttonChange.BackColor = Color.Maroon;
            }
            else
            {
                // zmiana koloru tła na kolor Magenta
                this.BackColor = Color.Magenta;
                // przycisk zamknięcia programu = kolor ciemno-niebieski
                this.buttonClose.BackColor = Color.MidnightBlue;
                // przycisk do zmiany kolorów = kolor kremowy
                this.buttonChange.BackColor = Color.Moccasin;
            }
        }

        private void text1_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Metoda odpowiedzialna za inkrementację liczby podczas kliknięcia w przycisk "Zwiększ liczbę"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMore_Click(object sender, EventArgs e)
        {
            // inkrementacja liczby
            incrementNumber++;
            // wrzucenie tej liczby do textboxa
            text1.Text = incrementNumber + "";
            // odpalenie MessageBoxa i pokazanie licznika
            MessageBox.Show(incrementNumber.ToString());
        }
        /// <summary>
        /// Gdy załaduje się okno przekazuję do textboxa odpowiedzialnego za inkrementację liczby licznik
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            text1.Text = incrementNumber + "";
            textMultiply.Text = incrementerLabel + "";
        }
        /// <summary>
        /// Gdy kliknie się dwa razy na etykietę następuje zmiana nazwy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_Click(object sender, EventArgs e)
        {
            // zwiększenie licznika
            incrementerLabel++;
            if (incrementerLabel % 2 == 0)
            {
                label1.Text = "Kiotr Połeczek";
            }
            else label1.Text = "Piotr Kołeczek";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            // pomocnicze liczby, które pobieramy z dwóch textboxów
            int a, b;
            // pobranie pierwszej liczby z textboxa
            a = int.Parse(text1.Text);
            // pobranie drugiej liczby
            b = int.Parse(textMultiply.Text);
            textMultiply.Text = a * b + "";
        }

        private void textMultiply_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            // przypisanie interwału w milisekundach
            timerStart.Interval = 1000;
            timerStart.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timerStart.Stop();
        }

        private void timerStart_Tick(object sender, EventArgs e)
        {
            // przy każdym cyklu czasomierza inkrementacja liczby licznikowej
            incrementNumber++;
            text1.Text = incrementNumber + "";
            // wywołanie metody odpowiedzialnej za zmianę koloru tła
            buttonChange_Click(sender, e);
        }
    }
}

// 0 Dokończ program

// 1 Wykaż się kreatywnością - utwórz symulację przedsiębiorstwa/imperium (xd),
// w którym co najmniej 5 zasobów w jednostce czasu będą się zmieniały
// zrób warunki gdy się np. skończą pieniądze, za mało surowców naturalnych posidasz itd...
// w programie zamieść zdarzenia losowe (negatywne, np. katastrofy)
// implementacja pictureboxów/graphs

// deadline do poniedziałku wieczór 00:00

// zadanie domowe wyślij na gita!