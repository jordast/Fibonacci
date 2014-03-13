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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Int32 fibCounter = 0;
            
            lbxResult.Items.Clear();

            try
            {
                fibCounter = Convert.ToInt32(txtCount.Text);
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
                for (int i = 1; i <= fibCounter; i++)
                {
                    lbxResult.Items.Add(fibunacci(i));
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                  
        }
        
        private Int32 fibunacci(Int32 value)
        {
            if (value == 1 || value == 2) return 1;
            else return fibunacci(value - 1) + fibunacci(value - 2);
        }
    }
}
