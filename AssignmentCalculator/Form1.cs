using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Penambahan(int a, int b)
        {
            return a + b;
        }

        private int Pengurangan(int a, int b)
        {
            return a - b;
        }

        private int Perkalian(int a, int b)
        {
            return a * b;
        }

        private int Pembagian(int a, int b)
        {
            return a / b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            var b = 0;
            if (Number1.Text == "")
            {
                a = 0;
            }
            else { a = int.Parse(Number1.Text); }

            if (Number2.Text == "")
            { b = 0; }
            else
            { b = Convert.ToInt32(Number2.Text); }

            if (Operation.Text == "Penambahan")
            { Hasil.Text = Convert.ToString(Penambahan(a, b)); }

            else if (Operation.Text == "Pengurangan")
            { Hasil.Text = Convert.ToString(Pengurangan(a, b)); }

            else if (Operation.Text == "Perkalian")
            { Hasil.Text = Convert.ToString(Perkalian(a, b)); }

            else if (Operation.Text == "Pembagian")
            { Hasil.Text = Convert.ToString(Pembagian(a, b)); }

            else
            { Hasil.Text = "Operasi tidak tersedia"; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Number1.Text = "";
            Number2.Text = "";
            Operation.Text = "";
            Hasil.Text = "";
        }
    }
}
