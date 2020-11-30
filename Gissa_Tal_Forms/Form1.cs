using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gissa_Tal_Forms
{
    public partial class Form1 : Form
    {
        public int tal;
        public int svar;
        public int försök = 0;
        public Random rng = new Random();
        
        
        public Form1()
        {
            InitializeComponent();
            tal = rng.Next(0, 101);
            label3.Text = "";
            label4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                svar = Convert.ToInt32(textBox1.Text);
            }
            catch(FormatException)
            {
            }
            
            if (svar < tal)
            {
                label3.Text = "För låg!";
                försök++;
            }
            else if (svar > tal)
            {
                label3.Text = "För högt!";
                försök++;
            }
            else
            {
                label3.Text = "Rätt!";
                label4.Text = "Det tog " + försök + "st försök";
            }

        }
    }
}
