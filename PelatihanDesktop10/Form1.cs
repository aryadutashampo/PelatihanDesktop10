using PelatihanDesktop10.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PelatihanDesktop10
{
    public partial class Form1 : Form
    {
        private Barang_Controller brgCtrl;
        public Form1()
        {
            brgCtrl = new Barang_Controller();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            segarkan();
        }

        public void segarkan()
        {
            dataGridView1.DataSource = brgCtrl.tampilBarang();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
