using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_odevi
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        public static Random rndm = new Random();//resimlerin rastgele gelmesi için random nesnesi oluşturuldu.
        int saniye = 60;//oyun 60 saniyeye bağlı oynandığından saniye diye bir değişken tanımlayıp değer atadım.
        organikAtikKutusu orgnk = new organikAtikKutusu();//bütün atık kutu classları için nesne oluşturup bilgileri kullanılabilecek duruma getirdim.
        metalAtikKutusu MetalAtıkKutusu = new metalAtikKutusu();
        camAtikKutusu CamAtikKutusu = new camAtikKutusu();
        kagitAtikKutusu KagitAtikKutusu = new kagitAtikKutusu();

        domates dmts = new domates();//bütün atık sınıfları için nesne oluşturup bilgileri kullanalabilecek duruma getirdim. 
        salatalik sltlk = new salatalik();
        gazete gzte = new gazete();
        dergi Dergi = new dergi();
        camBardak CamBardak = new camBardak();
        camSise CamSise = new camSise();
        salcaKutusu SalcaKutusu = new salcaKutusu();
        kolaKutusu KolaKutusu = new kolaKutusu();





        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;//sayacımızı çalışabilir duruma getirdik.
            timer1.Interval = 1000;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.ImageIndex = rndm.Next(0, 8);//yeni oyun butonuna basıldığında tüm butonlar çalışabilir hale getirildi ve listboxların progressbarların ve labellerin temizlenmesi sağlandı.
            timer1.Enabled = true;
            buttonCAM.Enabled = true;
            buttonCAMBOSALT.Enabled = true;
            buttonKAGIT.Enabled = true;
            buttonKAGITBOSALT.Enabled = true;
            buttonMETAL.Enabled = true;
            buttonMETALBOSALT.Enabled = true;
            buttonorganik.Enabled = true;
            buttonORGNKBOSALT.Enabled = true;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            progressBarCAM.Value = 0;
            progressBarKAGIT.Value = 0;
            progressBarORGNK.Value = 0;
            progressBarMETAL.Value = 0;
            label1.Text = Convert.ToString(saniye = 60);//yeni oyun butonuna basıldığında süre 60 saniyeden başlayarak geriye doğru akar.
            label4.Text = Convert.ToString(sonuc=0);
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye--;//saniyenin 60 tan başlayıp geriye doğru akması ve bu akan zamanın labele yazılması sağlandı
            label1.Text = saniye.ToString();
            if(saniye==0)//saniye 0 olunca yani oyun bitince tüm butonlar devre dışı bırakıldı.
            {
                timer1.Enabled = false;
                buttonCAM.Enabled = false;
                buttonCAMBOSALT.Enabled = false;
                buttonKAGIT.Enabled = false;
                buttonKAGITBOSALT.Enabled = false;
                buttonMETAL.Enabled = false;
                buttonMETALBOSALT.Enabled = false;
                buttonorganik.Enabled = false;
                buttonORGNKBOSALT.Enabled = false;
            }
           
            
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.ImageIndex = rndm.Next(0, 8);//labele resimlerin rastgele gelmesi sağlandı.
        }
        int sonuc = 0;//toplanılan puna için oluşturuldu ve ilk değer 0 olarak atandı.
       
        private void button2_Click(object sender, EventArgs e)
        {
           
            
                if (progressBarORGNK.Value < orgnk.Kapasite)//eğer progressbar kapasitesi organik atık kutusunun kapasitesinden küçük ise 
                {
                    if (label5.ImageIndex == 6)//eğer gelen resimin index i 6 ise
                    {
                        label5.ImageIndex = rndm.Next(0, 8);//organik atık butonuna basıldığında tekrar rastgele atık gelir.
                        progressBarORGNK.Step =sltlk.hacim;//progressbar atık hacmi kadar dolar.
                        progressBarORGNK.PerformStep();
                        listBox1.Items.Add("Salatalık(120)");//listboxa  atığın adı ve hacmi yazdırılır.
                        label4.Text = Convert.ToString(sonuc += sltlk.hacim);//sonuc labeline atık hacmi kadar puan eklenir.
                        label4.Text = Convert.ToString(sonuc);//eklenen puan sonuc labeline yazdırılır.

                    }

                    else if (label5.ImageIndex == 4)
                    {
                        label5.ImageIndex = rndm.Next(0, 8);
                        progressBarORGNK.Step = dmts.hacim;
                        progressBarORGNK.PerformStep();
                        listBox1.Items.Add("Domates(150)");
                        label4.Text = Convert.ToString(sonuc += dmts.hacim);
                        label4.Text = Convert.ToString(sonuc);
                    }

                }
               
            

        }

        private void progressBarORGNK_Click(object sender, EventArgs e)
        {
            progressBarORGNK.Maximum = orgnk.Kapasite;//progressbarın maximum kapasitelerini ait oldukları atık kutularının maximum kapasitelere eşitledik.
        }

        private void buttonORGNKBOSALT_Click(object sender, EventArgs e)
        {
            if (progressBarORGNK.Value > orgnk.DoluHacim)//organik atık kutusu kapasitesin %75 i dolu ise atık almaz ve boşalt butonu çalışır.
            {
                label4.Text = Convert.ToString(sonuc += orgnk.BoşaltmaPuanı);//boşalt butonuna tıklandığında her  atık kutusu için belirlenen puan kadar puan sonuca eklenir.
                label1.Text = Convert.ToString(saniye = saniye += 3);//her boşalt butonuna tıklandığında süreye 3 saniye eklenir.
                listBox1.Items.Clear();//boşalt butonuna tıklandığında listboxlar temizlenir proggresbar sıfırlanır.
                progressBarORGNK.Value = 0;
                buttonorganik.Enabled = true;//bu butonlar tekrardan kullanıma açılır.
                progressBarORGNK.Enabled = true;
                
            }
        }
        //yukarıda anlatılanların hepsi aşşağıda da uygulanmıştır.
        private void buttonKAGIT_Click(object sender, EventArgs e)
        {
            
            
                if (progressBarKAGIT.Value < KagitAtikKutusu.Kapasite)
                {
                    if (label5.ImageIndex == 3)
                    {
                        label5.ImageIndex = rndm.Next(0, 8);
                        progressBarKAGIT.Step =  Dergi.hacim;
                        progressBarKAGIT.PerformStep();
                        listBox2.Items.Add("Dergi(200)");
                        label4.Text = Convert.ToString(sonuc += Dergi.hacim);
                        label4.Text = Convert.ToString(sonuc);

                    }

                    else if (label5.ImageIndex == 5)
                    {
                        label5.ImageIndex = rndm.Next(0, 8);
                        progressBarKAGIT.Step =gzte.hacim;
                        progressBarKAGIT.PerformStep();
                        listBox2.Items.Add("Gazete(250)");
                        label4.Text = Convert.ToString(sonuc += gzte.hacim);
                        label4.Text = Convert.ToString(sonuc);
                    }

                }
              
            
        }

        private void buttonKAGITBOSALT_Click(object sender, EventArgs e)
        {
            if (progressBarKAGIT.Value > KagitAtikKutusu.DoluHacim)
            {
                label4.Text = Convert.ToString(sonuc+=KagitAtikKutusu.BoşaltmaPuanı);
                label1.Text = Convert.ToString(saniye = saniye += 3);
                listBox2.Items.Clear();
                progressBarKAGIT.Value=0;
                buttonKAGIT.Enabled = true;
                progressBarKAGIT.Enabled = true;
            }
        }

        private void buttonCAM_Click(object sender, EventArgs e)
        {
            
            
                if (progressBarCAM.Value < CamAtikKutusu.Kapasite)
                {
                    if (label5.ImageIndex == 0)
                    {
                        label5.ImageIndex = rndm.Next(0, 8);
                        progressBarCAM.Step = CamBardak.hacim;
                        progressBarCAM.PerformStep();
                        listBox3.Items.Add("Cam Bardak(250)");
                        label4.Text = Convert.ToString(sonuc += CamBardak.hacim);
                        label4.Text = Convert.ToString(sonuc);

                    }

                    else if (label5.ImageIndex == 1)
                    {
                        label5.ImageIndex = rndm.Next(0, 8);
                        progressBarCAM.Step = CamSise.hacim;
                        progressBarCAM.PerformStep();
                        listBox3.Items.Add("Cam Şişe(600)");
                        label4.Text = Convert.ToString(sonuc += CamSise.hacim);
                        label4.Text = Convert.ToString(sonuc);
                    }

                }
              
            
        }

        private void buttonCAMBOSALT_Click(object sender, EventArgs e)
        {
            if (progressBarCAM.Value > CamAtikKutusu.DoluHacim)
            {
                label4.Text = Convert.ToString(sonuc += CamAtikKutusu.DoluHacim);
                label1.Text = Convert.ToString(saniye = saniye += 3);
                listBox3.Items.Clear();
                progressBarCAM.Value = 0;
                buttonCAM.Enabled = true;
                progressBarCAM.Enabled = true;
            }
        }

        private void buttonMETAL_Click(object sender, EventArgs e)
        {
            
            
                if (progressBarMETAL.Value < MetalAtıkKutusu.Kapasite)
                {
                    if (label5.ImageIndex == 7)
                    {
                        label5.ImageIndex = rndm.Next(0, 8);
                        progressBarMETAL.Step = SalcaKutusu.hacim;
                        progressBarMETAL.PerformStep();
                        listBox4.Items.Add("Salca Kutusu(550)");
                        label4.Text = Convert.ToString(sonuc += SalcaKutusu.hacim);
                        label4.Text = Convert.ToString(sonuc);

                    }

                    else if (label5.ImageIndex == 2)
                    {
                        label5.ImageIndex = rndm.Next(0, 8);
                        progressBarMETAL.Step = KolaKutusu.hacim;
                        progressBarMETAL.PerformStep();
                        listBox4.Items.Add("Kola Kutusu(350)");
                        label4.Text = Convert.ToString(sonuc += KolaKutusu.hacim);
                        label4.Text = Convert.ToString(sonuc);
                    }

                }
               
        }

        private void buttonMETALBOSALT_Click(object sender, EventArgs e)
        {
            if (progressBarMETAL.Value > MetalAtıkKutusu.DoluHacim)
            {
                label4.Text = Convert.ToString(sonuc += MetalAtıkKutusu.BoşaltmaPuanı);
                label1.Text = Convert.ToString(saniye = saniye += 3);
                listBox4.Items.Clear();
                progressBarMETAL.Value = 0;
                buttonMETAL.Enabled = true;
                progressBarMETAL.Enabled = true;
            }
        }

        private void progressBarKAGIT_Click(object sender, EventArgs e)
        {
            progressBarKAGIT.Maximum = KagitAtikKutusu.Kapasite;
        }

        private void progressBarCAM_Click(object sender, EventArgs e)
        {
            progressBarCAM.Maximum = CamAtikKutusu.Kapasite;
        }

        private void progressBarMETAL_Click(object sender, EventArgs e)
        {
            progressBarMETAL.Maximum = MetalAtıkKutusu.Kapasite;
        }

        private void CIKISBTTN_Click(object sender, EventArgs e)
        {
            this.Close();//çıkış butonu oyundan çıkmamızı sağlar.
            Application.Exit();
        }
    }
    
}
