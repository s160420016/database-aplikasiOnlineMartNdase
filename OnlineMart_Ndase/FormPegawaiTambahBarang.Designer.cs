﻿
namespace OnlineMart_Ndase
{
    partial class FormPegawaiTambahBarang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTambahBarang = new System.Windows.Forms.Panel();
            this.comboBoxCabang = new System.Windows.Forms.ComboBox();
            this.comboBoxKategori = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxHarga = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonBersihkan = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTambahBarang.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTambahBarang
            // 
            this.panelTambahBarang.BackColor = System.Drawing.Color.SeaShell;
            this.panelTambahBarang.Controls.Add(this.textBoxID);
            this.panelTambahBarang.Controls.Add(this.label2);
            this.panelTambahBarang.Controls.Add(this.comboBoxCabang);
            this.panelTambahBarang.Controls.Add(this.comboBoxKategori);
            this.panelTambahBarang.Controls.Add(this.label5);
            this.panelTambahBarang.Controls.Add(this.textBoxHarga);
            this.panelTambahBarang.Controls.Add(this.label4);
            this.panelTambahBarang.Controls.Add(this.textBoxNama);
            this.panelTambahBarang.Controls.Add(this.label6);
            this.panelTambahBarang.Controls.Add(this.label3);
            this.panelTambahBarang.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTambahBarang.Location = new System.Drawing.Point(18, 75);
            this.panelTambahBarang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTambahBarang.Name = "panelTambahBarang";
            this.panelTambahBarang.Size = new System.Drawing.Size(502, 271);
            this.panelTambahBarang.TabIndex = 1;
            // 
            // comboBoxCabang
            // 
            this.comboBoxCabang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCabang.FormattingEnabled = true;
            this.comboBoxCabang.Location = new System.Drawing.Point(150, 203);
            this.comboBoxCabang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxCabang.Name = "comboBoxCabang";
            this.comboBoxCabang.Size = new System.Drawing.Size(298, 32);
            this.comboBoxCabang.TabIndex = 11;
            // 
            // comboBoxKategori
            // 
            this.comboBoxKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKategori.FormattingEnabled = true;
            this.comboBoxKategori.Location = new System.Drawing.Point(150, 158);
            this.comboBoxKategori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxKategori.Name = "comboBoxKategori";
            this.comboBoxKategori.Size = new System.Drawing.Size(298, 32);
            this.comboBoxKategori.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 207);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cabang  :";
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.Location = new System.Drawing.Point(150, 113);
            this.textBoxHarga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.Size = new System.Drawing.Size(148, 31);
            this.textBoxHarga.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Harga :";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(150, 72);
            this.textBoxNama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(298, 31);
            this.textBoxNama.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nama :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kategori  :";
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonTambah.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonTambah.Location = new System.Drawing.Point(18, 356);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(150, 57);
            this.buttonTambah.TabIndex = 2;
            this.buttonTambah.Text = "&Tambah";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.OrangeRed;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "     Tambah Barang";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonKeluar.Location = new System.Drawing.Point(370, 356);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(150, 57);
            this.buttonKeluar.TabIndex = 4;
            this.buttonKeluar.Text = "&Keluar";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // buttonBersihkan
            // 
            this.buttonBersihkan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonBersihkan.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBersihkan.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonBersihkan.Location = new System.Drawing.Point(177, 356);
            this.buttonBersihkan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBersihkan.Name = "buttonBersihkan";
            this.buttonBersihkan.Size = new System.Drawing.Size(150, 57);
            this.buttonBersihkan.TabIndex = 8;
            this.buttonBersihkan.Text = "&Bersihkan";
            this.buttonBersihkan.UseVisualStyleBackColor = false;
            this.buttonBersihkan.Click += new System.EventHandler(this.buttonBersihkan_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(150, 31);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(298, 31);
            this.textBoxID.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "ID :";
            // 
            // FormPegawaiTambahBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 421);
            this.Controls.Add(this.buttonBersihkan);
            this.Controls.Add(this.panelTambahBarang);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPegawaiTambahBarang";
            this.Text = "Tambah Barang";
            this.Load += new System.EventHandler(this.FormPegawaiTambahBarang_Load);
            this.panelTambahBarang.ResumeLayout(false);
            this.panelTambahBarang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTambahBarang;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.TextBox textBoxHarga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonBersihkan;
        private System.Windows.Forms.ComboBox comboBoxCabang;
        private System.Windows.Forms.ComboBox comboBoxKategori;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label2;
    }
}