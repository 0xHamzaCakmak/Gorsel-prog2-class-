using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        TicariTableAdapters.stokTableAdapter stokadapter;
        Ticari ticari;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //clas yardımı ile daha kısa şekilde kullanıma imkan saglandı.
            //form load oldugunda stok tablosundaki bilgileri daragride yukleyen program
            ticari = new Ticari();
            stokadapter = new TicariTableAdapters.stokTableAdapter();
            stokadapter.Fill(ticari.stok);
            dataGridView1.DataSource = ticari.stok;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //yazılan komutu görmek icin
            MessageBox.Show(stokadapter.Adapter.DeleteCommand.CommandText); 
        }
    }
}
