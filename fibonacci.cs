using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibunacci
{
    public partial class Fibunacci : Form
    {
        public Fibunacci()
        {
            InitializeComponent();
        }


        // --- btnCalculate_Click ---
        //
        // Hier wird die Ermittlung der Fibunacci Werte bis zu einer bestimmten 
        // Position in der Folge gestartet.
        // Die gesuchte Position wird über die Oberfläche eingegeben.
        // Die Ausgabe der ermittelten Werte erfolgt in einer Listbox
        //
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Int32 position = 0;
            
            lbxResult.Items.Clear();

            try
            {
                position = Convert.ToInt32(txtPosition.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Fehlerhafte Eingabe für die Anzahl der Ergebnisse");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            try
            {
                for (int i = 1; i <= position; i++)
                {
                    lbxResult.Items.Add(fibunacci(i));
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                  
        }
        
        // --- fibunacci ---
        //
        // Hier wird anhand der Übergebenen Position die entsprechende Zahl der 
        // Fibunacci-Folge ermittelt und zurück gegeben.
        // Die Ermittlung erfolgt durch den Rekursiven aufruf wie diser in der
        // Funktion der Fibunacci Folge festgelegt ist:
        //
        // f(n) = f(n-1) + f(n-2) 
        //
        // Das heißt der Gesuchte Wert ist die Summe der beiden vorherigen Werte.
        //
        // Da bei diesem Rekursiven Aufruf sämmtliche Vorgängerwerte ermittelt werden
        // müssen dauert die Ermittlung des Wertes um ein vielfaches länger, je höher
        // die gesuchte Stelle ist.
        //
        private Int32 fibunacci(Int32 value)
        {
            if (value == 1 || value == 2) return 1;
            else return fibunacci(value - 1) + fibunacci(value - 2);
        }
    }
}
