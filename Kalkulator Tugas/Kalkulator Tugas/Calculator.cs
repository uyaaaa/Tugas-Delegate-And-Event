using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_Tugas
{
    public partial class Calculator : Form
    {
        // deklarasi tipe data untuk event OnCreate dan OnUpdate
        public delegate void Create(int operasi, int a, int b,int hasil);
        // deklarasi event ketika terjadi proses input data baru
        public event Create onCreate;
       
        public Calculator()
        {
            InitializeComponent();
        }
       

        private void btnProses_Click(object sender, EventArgs e)
        {
           
            string operasi = comboBox1.SelectedItem.ToString();
            int a = Convert.ToInt32(txtNilaiA.Text);
            int b = Convert.ToInt32(txtNilaiB.Text);
            int hasil;

            switch (comboBox1.SelectedIndex)
            {
                
                case 0:
                    hasil = a + b;
                    break;
                case 1:
                    hasil = a - b;
                    break;
                case 2:
                    hasil = a * b;
                    break;
                case 3:
                    hasil = a / b;
                    break;
                default:
                    hasil = 0;
                    break;
            }
            this.onCreate(comboBox1.SelectedIndex, a, b, hasil);
        }
    }
}
