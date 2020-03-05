using OzIMDB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OzIMDB
{
    public partial class Form1 : Form
    {
        string dbName = "OzImdbDb";
        SqlConnection con = new SqlConnection("server=.; database=master; uid=sa; pwd=123;");
        SqlCommand cmd;
        BindingList<Film> filmler;
        bool guncellemeAcik = false;
        public Form1()
        {
            con.Open();
            VeritabaniVarMi();
            InitializeComponent();
            FilmleriListele();
        }

        private void FilmleriListele()
        {
            guncellemeAcik = false;
            var cmd = new SqlCommand("SELECT * FROM Filmler", con);
            var dr = cmd.ExecuteReader();
            filmler = new BindingList<Film>();
            while (dr.Read())
            {

                filmler.Add(new Film
                {
                    Id = (int)dr["Id"],
                    FilmAd = (string)dr["FilmAd"],
                    Puan = dr["Puan"] as int?,
                    Foto = ConvertToImage(dr["Foto"] as byte[])
                });

            }
            dr.Close();
            lstFilm.DataSource = filmler;
            guncellemeAcik = true;
        }

        private void VeritabaniVarMi()
        {
            cmd = new SqlCommand($"SELECT DB_ID('{dbName}')", con);
            short? sonuc = cmd.ExecuteScalar() as short?; //AS = KASTETMEK DİĞERİNDEN FARKI NULL BIRAKIYOR

            if (sonuc == null)
            {
                cmd = new SqlCommand($"CREATE DATABASE {dbName}", con);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand($"USE {dbName};"
                    + @"CREATE TABLE Filmler
                    (
                        Id INT PRIMARY KEY IDENTITY,
                        FilmAd NVARCHAR(200) NOT NULL,
                        Puan INT NULL,
                        Foto VARBINARY(MAX) NULL
                    );
                    ", con);
                cmd.ExecuteNonQuery();
            }
            else
            {
                cmd = new SqlCommand($"USE {dbName};", con);
                cmd.ExecuteNonQuery(); //DEĞER DÖNDÜRMEYEN İSE EXECUTENONQUERY TEK DEĞERLER İÇİN EXECUTESCALAR
            }
            //BU KODLARDAKİ AMAÇ DATABASE İN BOŞ OLUP OLMADIĞINI KONTROL ETMEK
            //YOKSA YENİ BİR DATABASE OLUŞTURUYORUZ
        }

        private Image ConvertToImage(byte[] data)  //BYTE DİZİİNİ RESME DÖNÜŞTÜRME
        {
            if (data==null)
            {
                return null;
            }
            return ((Image)new ImageConverter().ConvertFrom(data));
        }

        private void btnYeniFilm_Click(object sender, EventArgs e)
        {
            int id=FilmEkle();
            FilmleriListele();
            lstFilm.SelectedValue = id;
        }

        private int FilmEkle()
        {
            var cmd = new SqlCommand("INSERT INTO Filmler(FilmAd) VALUES(N'Yeni Film');" +
                "SELECT SCOPE_IDENTITY();", con);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        private void lstFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFilm.SelectedIndex == -1)
                return;

            guncellemeAcik = false;
            Film film = (Film)lstFilm.SelectedItem;

            txtId.Text = film.Id.ToString();
            txtFilmAd.Text = film.FilmAd;

                        
            #region PUANGÖSTER

            if (film.Puan == null)
            {
                rbPuan.Checked = true;
            }
            else
            {
                /* foreach (Control control in gboPuan.Controls)
                 {
                     if (control is RadioButton 
                         && control.Tag!=null
                         && control.Tag.ToString() == film.Puan.ToString())
                     {
                         ((RadioButton)control).Checked=true;
                         break;
                     }
                 }*/ //Yöntem1
                RadioButton[] rbDizi = { rbPuan, rb1, rb2, rb3, rb4, rb5 };
                rbDizi[film.Puan.Value].Checked = true; //Yöntem2 
                
            }
            #endregion

            pboFoto.Image = film.Foto;
            guncellemeAcik = true;
        }

        private void txtFilmAd_TextChanged(object sender, EventArgs e)
        {
            guncelle();
        }

        private void guncelle()
        {
            if (guncellemeAcik && lstFilm.SelectedIndex>-1)
            {
                Film film = (Film)lstFilm.SelectedItem;
                film.FilmAd = txtFilmAd.Text;
                film.Puan = SeciliPuan();
                //Puan ve resim güncelle

                var cmd = new SqlCommand("Update filmler set FilmAd=@p1,Puan=@p2 WHERE Id=@p4", con);
                cmd.Parameters.AddWithValue("@p1", film.FilmAd);
                cmd.Parameters.AddWithValue("@p4", film.Id);
                cmd.Parameters.AddWithValue("@p2", (object)film.Puan ?? DBNull.Value); //ADO.NET NULL'I BU
                cmd.ExecuteNonQuery();
                filmler.ResetBindings();
            }
        }

        private int ? SeciliPuan()
        {
            RadioButton rb=null;

            foreach (Control control in gboPuan.Controls)
            {
                if (control is RadioButton)
                {
                    rb = (RadioButton)control;
                    if (rb.Checked)
                        break;
                }
            }
            return rb.Tag == null ? null as int? : Convert.ToInt32(rb.Tag);
        }

        private void rbPuan_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                guncelle();
            }
        }
    }
}
