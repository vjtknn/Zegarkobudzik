using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zegarek
{
    public partial class Form1 : Form
    {
        Timer t = new Timer();

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            t.Interval = 1;  
            t.Tick += new EventHandler(this.t_Tick);
            t.Start(); 
        } 
        private void t_Tick(object sender, EventArgs e)
        {

          
          
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            int ms = DateTime.Now.Millisecond;

            string time = "";

            if (hh > 6 && hh < 18)
            {
                label2.Text = "Dzień dobry";

                if (hh > 6 && hh < 9)
                {
                    label2.ForeColor = Color.Black;
                    label2.BackColor = Color.Cyan;
                }
                else if (hh > 9 && hh < 15)
                {
                    label2.ForeColor = Color.Black;
                    label2.BackColor = Color.Yellow;

                }
                else
                {
                    label2.ForeColor = Color.Black;
                    label2.BackColor = Color.Red;

                }
            }
            else
            {
                label2.Text = "Dobry wieczór";
                label2.ForeColor = Color.White;
                label2.BackColor = Color.Black;

            }

            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }
            time += ":";

            if (ms < 10)
            {
                time += "00" + ms;
            }
            else if (ms < 100)
            {
                time += "0" + ms;
            }
            else
            {
                time += ms;
            }

            label1.Text = time;
        }
    

        private void button1_Click_1(object sender, EventArgs e)
        {
            DateTime czas_aktual = DateTime.Now;
            DateTime czas_budzik = dateTimePicker.Value;

            if (czas_aktual.Hour == czas_budzik.Hour && czas_aktual.Minute == czas_budzik.Minute &&
                czas_aktual.Second == czas_budzik.Second)

            {
                MessageBox.Show("Budzik dzwoni");
            }
        }
    }

}
