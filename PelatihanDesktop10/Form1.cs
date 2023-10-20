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
    public partial class Dutastore : Form
    {
        public string pilih = "";
        private Barang_Controller brgCtrl;
        private Kategori_Controller ktgCtrl;
        private Pelanggan_Controller plgCtrl;
        private Supplier_Controller supCtrl;
        public Dutastore()
        {
            brgCtrl = new Barang_Controller();
            ktgCtrl = new Kategori_Controller();
            plgCtrl = new Pelanggan_Controller();
            supCtrl = new Supplier_Controller();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPilih_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            pilih = button.Text;
            switch (pilih)
            {
                case "KATEGORI":
                    dataGridView1.DataSource = ktgCtrl.tampilKategori();
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    break;
                case "BARANG":
                    dataGridView1.DataSource = brgCtrl.tampilBarang();
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    break;
                case "PELANGGAN":
                    dataGridView1.DataSource = plgCtrl.tampilPelanggan();
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    break;
                case "SUPPLIER":
                    dataGridView1.DataSource = supCtrl.tampilSupplier();
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    break;
                default:
                    break;
            }
        }
    }
}
