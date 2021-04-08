using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePickerOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnfark_Click(object sender, EventArgs e)
        {
            DateTime baslangic = Convert.ToDateTime(dtpbaslangic.Text); // Tarih ile işlem yapacağamız için DateTime Kullanıyoruz 
            DateTime bitis = Convert.ToDateTime(dtpbitis.Text);

            TimeSpan sonuc = bitis - baslangic; // TimeSpan Sınıfı İki Tarih arası farkı hesaplar

            lblYıl.Text = Math.Round(sonuc.TotalDays / 365, 4).ToString(); // total günü 365,4 bölüp math.Round ile yuvarlayıp lblYıl a aktardık 
            lblAy.Text = Math.Round(sonuc.TotalDays / 30).ToString();
            lblGün.Text = Math.Round(sonuc.TotalDays,2).ToString();
            lblSaat.Text = Math.Round(sonuc.TotalHours).ToString();
            lblDakika.Text = Math.Round(sonuc.TotalMinutes).ToString();

    }
    }
}
