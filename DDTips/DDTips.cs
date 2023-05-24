using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace DDTips
{
    public partial class DDTips : Form
    {
        Random rnd = new Random();

        private bool maxScreen = false;

        private string path = "C:\\users\\dart1\\Desktop\\D&D.txt";
        string[] curio;

        public DDTips()
        {
            InitializeComponent();
            if (File.Exists(path))
            {
                curio = File.ReadAllLines(path);
                MostraCurio();
            }
            else
                MessageBox.Show("File non trovato!");


            //textBox1.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //textBox1.BackColor = Color.Transparent;
        }

        private void btn_Massimizza_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            btn_Massimizza.Visible = false;
            maxScreen = true;
            timer1.Enabled = true;
        }

        private void btn_Massimizza_KeyDown(object sender, KeyEventArgs e)
        {
            if (maxScreen && e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                btn_Massimizza.Visible = true;
                maxScreen = false;
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MostraCurio();          
        }

        private bool ControllaSpazio(char carattere)
        {
            bool ris;

            if (carattere == ' ')
                ris = true;
            else
                ris = false;

            return ris;
        }

        private bool ControllaChar(char carattere)
        {
            bool ris;

            if (carattere == '?' || carattere == ')' || carattere == '!' || carattere == '.')
                ris = true;
            else
                ris = false;

            return ris;
        }

        private string InserisciACapo(string riga, int index, int i)
        {
            while (!ControllaSpazio(riga[index + i]) && !ControllaChar(riga[index + i]))
            {
                i++;
            }

            return riga.Insert(index + i, "\n");
        }

        private void MostraCurio()
        {
            string tmp = curio[rnd.Next(0, curio.Length)];
            string riga = tmp;

            bool fatto = false;

            int index = 35;
            int i = 0;

            while (!fatto)
            {
                if (tmp.Length < index)
                {
                    lb_Curiosita.Text = riga;
                    fatto = true;
                }
                else
                {
                    riga = InserisciACapo(riga, index, i);
                    index += 35;
                }
            }
        }
    }
}
