using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Der_Kran
{
    public partial class Der_Kran : Form
    {
        public Der_Kran()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        //
        // Haken Ausfahr 
        //
        private void btc_HakenAus_Click(object sender, EventArgs e)
        {        
            HakenControl(10);   //Verweis auf die Methode HakenControl
        }
        //
        // Haken Einfahr 
        //
        private void btc_HakenEin_Click(object sender, EventArgs e)
        {
            if (Haken.Height > 20)
                HakenControl(-10);  //Verweis auf die Methode HakenControl
            else MessageBox.Show("Der Haken kann nicht kürzer werden");
        }
        //
        // Ausleger Ausfahr 
        //
        private void btc_AuslegerAus_Click(object sender, EventArgs e)
        {
            int i = 10;     // i wird mit 10 deklariert
            AuslegerPanel.Width += i;   //Ausleger Weite wird mit 10 erweitert
            if (AuslegerPanel.Width > 10)   //Abfrage ob die Weite noch über 10 liegt
            {
                AuslegerPanel.Left -= i;    //Ausleger wird um 10 Pixel nach Links verschoben
                Haken.Left -= i;    //Haken wird um 10 Pixel nach Links verschoben
            }
        }
        //
        // Ausleger Einfahr 
        //
        private void btc_AuslegerEin_Click(object sender, EventArgs e)
        {
            if (AuslegerPanel.Width > 50)
            {
                int i = 10;  //i wird mit 10 deklariert
                AuslegerPanel.Width -= i;   //Ausleger wird um 10 Pixel verkürzt
                if (AuslegerPanel.Width != 0)   //Prüfung ob Auslegher nicht 0 ist
                {
                    AuslegerPanel.Left += i;    //Ausleger wird um 10 Pixel nach Rechts verschoben
                    Haken.Left += i;    //Haken wird um 10 Pixel nach Rechtss verschoben
                }
            }
            else MessageBox.Show("Der Ausleger kann nicht kürzer werden");
        }
        //
        // Kran Nach Rechts 
        //
        private void btc_KranRechts_Click(object sender, EventArgs e)
        {
            KranBewegung(10);   //Verweis auf die Kran Bewegungs Methode
        }
        //
        // Kran Nach Links
        //
        private void btc_KranLinks_Click(object sender, EventArgs e)
        {
            KranBewegung(-10);  //Verweis auf die Kran Bewegungs Methode
        }
        //
        // Kran Hals Einfahren
        //
        private void btc_KranHalsEinfahren_Click(object sender, EventArgs e)
        {
            if (KranHals.Height > 30)   //Abfrage ob der Kran Hals größer als 30 pixel ist 
            {
                KranHals.Height -= 10;  //Kran Hals wird um 10 Pixel verkürzt
                KranHals.Top += 10;     //Kran Hals wird um 10 Pixel nach unten geschoben
                KranHalsBewegung(10);   //Verweis auf die Kran Hals Bewegungs Methode
            }            
            else MessageBox.Show("Der Hals kann nicht noch kürzer");
            
        }
        //
        // Kran Hals Ausfahren
        //
        private void btc_KranHalsAusfahren_Click(object sender, EventArgs e)
        {
            if (KranHals.Height < 300)
            {
                KranHals.Height += 10;  //Kran Hals Höhe wird um 10 Pixel verlängert
                KranHals.Top -= 10;     // Kran Hals wird um 10 Pixel nach oben verschoben
                KranHalsBewegung(-10);  //Verweis auf die Kran Hals Bewegungs Methode
            }
            else MessageBox.Show("Der Hals kann nicht höher");
           
        }
        //
        // Kran Hals Methode
        //
        private void KranHalsBewegung(int i)
        {
            Haken.Top += i; //Haken wird um i verschoben
            AuslegerPanel.Top += i; //Ausleger wird um i verschoben                    
        }
        //
        // Kran Bewegung Methode
        //
        private void KranBewegung(int i)
        {
            Haken.Left += i;    //Haken wird um i nach Links oder Rechts verschoben
            AuslegerPanel.Left += i;    //Ausleger wird um i nach Links oder Rechts verschoben
            KranHals.Left += i; //Kran Hals wird um i nach Links oder Rechts verschoben
            Rumpf.Left += i;    //Rumpf wird um i nach Links oder Rechts verschoben
        }
        //
        // Haken Kontrollen Methode
        //
        private void HakenControl(int i)
        {
            Haken.Height += i;  //Haken wird um i in der der Höhe verlängert
        }                                    
    }
}
