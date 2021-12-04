﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineMart_LIB;

namespace OnlineMart_Ndase
{
    public partial class FormKonsumenRiwayatTransaksi : Form
    {
        FormUtama formUtama;

        private List<Order> listOrder = new List<Order>();

        public FormKonsumenRiwayatTransaksi()
        {
            InitializeComponent();
        }

        private void FormKonsumenRiwayatTransaksi_Load(object sender, EventArgs e)
        {
            formUtama = (FormUtama)this.MdiParent;

            FormatDataGrid();

            listOrder = Order.ReadData("", formUtama.ku.Id.ToString());

            TampilDataGrid();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormatDataGrid()
        {
            dataGridViewRiwayatTransaksi.Columns.Clear();

            dataGridViewRiwayatTransaksi.Columns.Add("id", "No. Order");
            dataGridViewRiwayatTransaksi.Columns.Add("nama", "Tanggal");
            dataGridViewRiwayatTransaksi.Columns.Add("total", "Total Bayar");
            dataGridViewRiwayatTransaksi.Columns.Add("cabang", "Nama Cabang");

            DataGridViewButtonColumn buttonColumnCek = new DataGridViewButtonColumn();
            buttonColumnCek.HeaderText = "Aksi";
            buttonColumnCek.Text = "Cek Pesanan";
            buttonColumnCek.Name = "btnUbahGrid";
            buttonColumnCek.UseColumnTextForButtonValue = true;
            dataGridViewRiwayatTransaksi.Columns.Add(buttonColumnCek);

            dataGridViewRiwayatTransaksi.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRiwayatTransaksi.Columns["nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRiwayatTransaksi.Columns["total"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRiwayatTransaksi.Columns["cabang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; 

            dataGridViewRiwayatTransaksi.AllowUserToAddRows = false;
            dataGridViewRiwayatTransaksi.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            dataGridViewRiwayatTransaksi.Rows.Clear();

            if (listOrder.Count > 0)
            {
                foreach (Order o in listOrder)
                {
                    dataGridViewRiwayatTransaksi.Rows.Add(o.Id, o.Tanggal_Waktu, o.Total_Bayar, o.Cabang.Nama);
                }
            }
            else
            {
                dataGridViewRiwayatTransaksi.DataSource = null;
            }
        }
    }
}
