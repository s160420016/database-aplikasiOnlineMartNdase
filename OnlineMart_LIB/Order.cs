﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Order
    {
        private string id;
        private DateTime tanggal_waktu;
        private string alamat_tujuan;
        private float ongkos_kirim;
        private float total_bayar;
        private Cabang cabang;
        private Kurir kurir;
        private Konsumen konsumen;
        private Promo promo;
        private string status;
        private MetodePembayaran metodePembayaran;
        private List<BarangOrder> listBarangOrder;

        public Order()
        {
            Id = "";
            Tanggal_Waktu = DateTime.Now;
            Alamat_Tujuan = "";
            Ongkos_Kirim = 0;
            Total_Bayar = 0;
            Cabang = null;
            Kurir = null;
            Konsumen = null;
            Promo = null;
            Status = "";
            MetodePembayaran = null;
            ListBarangOrder = new List<BarangOrder>();
        }

        public Order(string id, DateTime tanggal_waktu, string alamat_tujuan, float ongkos_kirim, float total_bayar, 
            Cabang cabang, Kurir kurir, Konsumen konsumen, Promo promo, string status, MetodePembayaran metodePembayaran)
        {
            Id = id;
            Tanggal_Waktu = tanggal_waktu;
            Alamat_Tujuan = alamat_tujuan;
            Ongkos_Kirim = ongkos_kirim;
            Total_Bayar = total_bayar;
            Cabang = cabang;
            Kurir = kurir;
            Konsumen = konsumen;
            Promo = promo;
            Status = status;
            MetodePembayaran = metodePembayaran;
            ListBarangOrder = new List<BarangOrder>();
        }

        public string Id { get => id; set => id = value; }
        public DateTime Tanggal_Waktu { get => tanggal_waktu; set => tanggal_waktu = value; }
        public string Alamat_Tujuan { get => alamat_tujuan; set => alamat_tujuan = value; }
        public float Ongkos_Kirim { get => ongkos_kirim; set => ongkos_kirim = value; }
        public float Total_Bayar { get => total_bayar; set => total_bayar = value; }
        public Cabang Cabang { get => cabang; set => cabang = value; }
        public Kurir Kurir { get => kurir; set => kurir = value; }
        public Konsumen Konsumen { get => konsumen; set => konsumen = value; }
        public Promo Promo { get => promo; set => promo = value; }
        public string Status { get => status; set => status = value; }
        public MetodePembayaran MetodePembayaran { get => metodePembayaran; set => metodePembayaran = value; }
        public List<BarangOrder> ListBarangOrder { get => listBarangOrder; private set => listBarangOrder = value; }

        public static string GenerateNoOrder()
        {
            string sql = "select RIGHT(id, 3) as NoOrder" +
                " from orders " +
                " where Date(tanggal_waktu) = Date(CURRENT_DATE)" +
                " order by id DESC limit 1";
            
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            string hasilNoOrder = "";
            if (hasil.Read() == true)
            {
                if (hasil.GetValue(0).ToString() != "")
                {
                    int noOrders = int.Parse(hasil.GetValue(0).ToString()) + 1;
                    Console.WriteLine(hasil.GetValue(0).ToString());
                    hasilNoOrder = DateTime.Now.Year +
                                  DateTime.Now.Month.ToString().PadLeft(2, '0') +
                                  DateTime.Now.Day.ToString().PadLeft(2, '0') +
                                  noOrders.ToString().PadLeft(3, '0');
                }
            }
            else
            {
                hasilNoOrder = DateTime.Now.Year +
                              DateTime.Now.Month.ToString().PadLeft(2, '0') +
                              DateTime.Now.Day.ToString().PadLeft(2, '0') +
                              "001";
            }

            return hasilNoOrder;
        }

        public static void CreateData(Order order)
        {
            string sql1 = "insert into orders(id, tanggal_waktu, alamat_tujuan, ongkos_kirim, total_bayar, cabangs_id, drivers_id, pelanggans_id, promo_id, status, metode_pembayaran_id) "
                + "values('" + order.Id + "','" + order.Tanggal_Waktu.ToString("yyyy-MM-dd hh:mm:ss") + "','"
                + order.Alamat_Tujuan + "'," + order.Ongkos_Kirim + ",'" + order.Total_Bayar.ToString("####") + "'," + order.Cabang.Id + ","
                + order.Kurir.Id + "," + order.Konsumen.Id + "," ;

            if (order.promo is null)
                sql1 += 0;
            else
                sql1 += order.Promo.Id;

            sql1 += ",'Pesanan Diproses',"
                + order.MetodePembayaran.Id + ")";

            if (Koneksi.JalankanPerintahDML(sql1) != 0)
            {
                foreach (BarangOrder barangOrder in order.ListBarangOrder)
                {
                    string sql2 = "insert into barangs_orders(barangs_id, orders_id, jumlah, harga) "
                        + "values (" + barangOrder.Barang.Id + "," + order.Id + "," + barangOrder.Jumlah + ","
                        + barangOrder.Harga + ")";

                    if (Koneksi.JalankanPerintahDML(sql2) != 0)
                    {
                        StokBarang.UpdateStok("penjualan",
                            new StokBarang(order.Cabang, barangOrder.Barang, barangOrder.Jumlah));
                    }
                }
            }
        }

        public void TambahDetilBarang(Barang barang, int jumlah, float harga)
        {
            ListBarangOrder.Add(new BarangOrder(barang, jumlah, harga));
        }

        public static List<Order> ReadData(string kriteria, string konsumenID)
        {
            string sql;
                sql = "select o.id, o.tanggal_waktu, o.alamat_tujuan, o.ongkos_kirim, o.total_bayar, c.nama, d.nama, " +
                    "p.id, p.nama, o.status, mp.nama from orders as o " +
                    "inner join cabangs as c on o.cabangs_id = c.id " +
                    "inner join drivers as d on o.drivers_id = d.id " +
                    "inner join promos as p on o.promo_id = p.id " +
                    "inner join metode_pembayarans as mp on o.metode_pembayaran_id = mp.id " +
                    "where o.pelanggans_id = '" + konsumenID + "'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<Order> listOrder = new List<Order>();

            while (hasil.Read() == true)
            {
                Order o = new Order();
                o.Id = hasil.GetString(0);
                o.Tanggal_Waktu = DateTime.Parse(hasil.GetString(1));
                o.Alamat_Tujuan = hasil.GetString(2);
                o.Ongkos_Kirim = float.Parse(hasil.GetString(3));
                o.Total_Bayar = float.Parse(hasil.GetString(4));

                Cabang c = new Cabang();
                c.Nama = hasil.GetString(5);

                Kurir ku = new Kurir();
                ku.Nama = hasil.GetString(6);

                Promo p = new Promo();
                p.Id = int.Parse(hasil.GetString(7));
                p.Nama = hasil.GetString(8);

                o.Status = hasil.GetString(9);

                MetodePembayaran mp = new MetodePembayaran();
                mp.Nama = hasil.GetString(10);

                o.Cabang = c;
                o.Kurir = ku;
                o.Promo = p;
                o.MetodePembayaran = mp;

                listOrder.Add(o);
            }
            return listOrder;
        }
    }
}
