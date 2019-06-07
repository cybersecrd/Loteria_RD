using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Loteria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        
        public void  loteriaNacionalQuiniela()
        {
           
            Random w = new Random();
            for (int k = 00; k < 1; k++)
            {
                int v = w.Next(00, 100);
                textBox1.Text = v.ToString();
            }
           
            
          
        }
        public void loteriaNacionalPale()
        {
            Random w = new Random();
            for (int k = 00; k < 2; k++)
            {
                int v = w.Next(00, 100);
                textBox5.Text = v.ToString();
            }
            Random w1 = new Random();
            for (int k = 00; k < 3; k++)
            {
                int v = w1.Next(00, 100);
                textBox6.Text = v.ToString();
            }
            
        }
        public void loteriaNacionalTripleta()
        {
            
            Random j = new Random();
            for (int m = 00; m < 4; m++)
            {
                int o = j.Next(00, 100);
                
              
                textBox33.Text = o.ToString();
            }
            Random ju = new Random();
            for (int tgu = 00; tgu < 5; tgu++)
            {
                int o = ju.Next(00, 100);

                textBox31.Text = o.ToString();
            }
            Random jue = new Random();
            for (int tgu = 00; tgu < 6; tgu++)
            {
                int o = jue.Next(00, 100);

                textBox32.Text = o.ToString();
            }
        }
        public void loteriaRealQuiniela()
        {
           
            Random jg = new Random();
            for (int tg = 00; tg < 7; tg++)
            {
                int o = jg.Next(00, 100);
              
                textBox10.Text = o.ToString();
            }
        }
        public void loteriaRealPale()
        {
            Random jue = new Random();
            for (int tgu = 00; tgu < 8; tgu++)
            {
                int o = jue.Next(00, 100);

                textBox9.Text = o.ToString();
            }
            Random juew = new Random();
            for (int tgu = 00; tgu < 9; tgu++)
            {
                int o = juew.Next(00, 100);

                textBox8.Text = o.ToString();
            }
        }
        public void loteriaRealTripleta()
        {
            Random jue = new Random();
            for (int tgu = 00; tgu < 10; tgu++)
            {
                int o = jue.Next(00, 100);

                textBox4.Text = o.ToString();
            }
            Random jw = new Random();
            for (int tgu = 00; tgu < 11; tgu++)
            {
                int o = jw.Next(00, 100);

                textBox3.Text = o.ToString();
            }
            Random juewe = new Random();
            for (int tgu = 00; tgu < 12; tgu++)
            {
                int o = juewe.Next(00, 100);

                textBox2.Text = o.ToString();
            }
        }
        public void Quiniela()
        {
            Random jue = new Random();
            for (int tgu = 00; tgu < 13; tgu++)
            {
                int o = jue.Next(00, 100);

                textBox19.Text = o.ToString();
            }
           
        }
        public void QuinielaPale()
        {
            Random jue = new Random();
            for (int tgu = 00; tgu < 14; tgu++)
            {
                int o = jue.Next(00, 100);

                textBox15.Text = o.ToString();
            }
            Random jze = new Random();
            for (int tgu = 00; tgu < 15; tgu++)
            {
                int o = jze.Next(00, 100);

                textBox14.Text = o.ToString();
            }
        }
        public void QuinielaTripleta()
        {
            Random jue = new Random();
            for (int tgu = 00; tgu < 16; tgu++)
            {
                int o = jue.Next(00, 100);

                textBox13.Text = o.ToString();
            }
            Random jze = new Random();
            for (int tgu = 00; tgu < 17; tgu++)
            {
                int o = jze.Next(00, 100);

                textBox12.Text = o.ToString();
            }
            Random jpe = new Random();
            for (int tgu = 00; tgu < 18; tgu++)
            {
                int o = jpe.Next(00, 100);

                textBox11.Text = o.ToString();
            }
        }
        public void Pega3Mas()
        {
            Random jue = new Random();
            for (int tgu = 00; tgu < 16; tgu++)
            {
                int o = jue.Next(00, 100);

                textBox18.Text = o.ToString();
            }
            Random jze = new Random();
            for (int tgu = 00; tgu < 17; tgu++)
            {
                int o = jze.Next(00, 100);

                textBox17.Text = o.ToString();
            }
            Random jpe = new Random();
            for (int tgu = 00; tgu < 18; tgu++)
            {
                int o = jpe.Next(00, 100);

                textBox16.Text = o.ToString();
            }
        }
        public void SuperPale()
        {
            Random jue = new Random();
            for (int tgu = 00; tgu < 19; tgu++)
            {
                int o = jue.Next(00, 100);

                textBox22.Text = o.ToString();
            }
            Random jze = new Random();
            for (int tgu = 00; tgu < 20; tgu++)
            {
                int o = jze.Next(00, 100);

                textBox21.Text = o.ToString();
            }
            Random jpe = new Random();
            for (int tgu = 00; tgu < 21; tgu++)
            {
                int o = jpe.Next(00, 100);

                textBox20.Text = o.ToString();
            }
        }
        public void Loto()
        {
            Random jue = new Random();
            for (int tgu = 00; tgu < 22; tgu++)
            {
                int o = jue.Next(00, 100);

                textBox30.Text = o.ToString();
            }
            Random jze = new Random();
            for (int tgu = 00; tgu < 23; tgu++)
            {
                int o = jze.Next(00, 100);

                textBox29.Text = o.ToString();
            }
            Random jpe = new Random();
            for (int tgu = 00; tgu < 24; tgu++)
            {
                int o = jpe.Next(00, 100);

                textBox28.Text = o.ToString();
            }
            Random jpwe = new Random();
            for (int tgu = 00; tgu < 25; tgu++)
            {
                int o = jpwe.Next(00, 100);

                textBox37.Text = o.ToString();
            }
            Random jpwde = new Random();
            for (int tgu = 00; tgu < 26; tgu++)
            {
                int o = jpwde.Next(00, 100);

                textBox38.Text = o.ToString();
            }
            Random jpwie = new Random();
            for (int tgu = 00; tgu < 27; tgu++)
            {
                int o = jpwie.Next(00, 100);

                textBox7.Text = o.ToString();
            }
        }
        public void LotoMas()
        {
            Random jue = new Random();
            for (int tgu = 00; tgu < 29; tgu++)
            {
                int o = jue.Next(00, 100);

                textBox34.Text = o.ToString();
            }
            Random jze = new Random();
            for (int tgu = 00; tgu < 30; tgu++)
            {
                int o = jze.Next(00, 100);

                textBox27.Text = o.ToString();
            }
            Random jpe = new Random();
            for (int tgu = 00; tgu < 31; tgu++)
            {
                int o = jpe.Next(00, 100);

                textBox26.Text = o.ToString();
            }
            Random jpwe = new Random();
            for (int tgu = 00; tgu < 32; tgu++)
            {
                int o = jpwe.Next(00, 100);

                textBox24.Text = o.ToString();
            }
            Random jpwde = new Random();
            for (int tgu = 00; tgu < 33; tgu++)
            {
                int o = jpwde.Next(00, 100);

                textBox23.Text = o.ToString();
            }
            Random jpwie = new Random();
            for (int tgu = 00; tgu < 34; tgu++)
            {
                int o = jpwie.Next(00, 100);

                textBox25.Text = o.ToString();
            }
            Random jpeie = new Random();
            for (int tgu = 00; tgu < 35; tgu++)
            {
                int o = jpeie.Next(00, 100);

                textBox35.Text = o.ToString();
            }
        }
        public void LotoPool()
        {
            Random jue = new Random();
            for (int tgu = 00; tgu < 36; tgu++)
            {
                int o = jue.Next(00, 100);

                textBox51.Text = o.ToString();
            }
            Random jze = new Random();
            for (int tgu = 00; tgu < 37; tgu++)
            {
                int o = jze.Next(00, 100);

                textBox50.Text = o.ToString();
            }
            Random jpe = new Random();
            for (int tgu = 00; tgu < 38; tgu++)
            {
                int o = jpe.Next(00, 100);

                textBox49.Text = o.ToString();
            }
            Random jp1e = new Random();
            for (int tgu = 00; tgu < 39; tgu++)
            {
                int o = jp1e.Next(00, 100);

                textBox47.Text = o.ToString();
            }
            Random jp1we = new Random();
            for (int tgu = 00; tgu < 40; tgu++)
            {
                int o = jp1we.Next(00, 100);

                textBox46.Text = o.ToString();
            }
            Random jp1pe = new Random();
            for (int tgu = 00; tgu < 41; tgu++)
            {
                int o = jp1pe.Next(00, 100);

                textBox48.Text = o.ToString();
            }
        }
        public void SuperLotoMas()
        {
            Random jue = new Random();
            for (int tgu = 00; tgu < 42; tgu++)
            {
                int o = jue.Next(00, 100);

                textBox44.Text = o.ToString();
            }
            Random jze = new Random();
            for (int tgu = 00; tgu < 43; tgu++)
            {
                int o = jze.Next(00, 100);

                textBox43.Text = o.ToString();
            }
            Random jpe = new Random();
            for (int tgu = 00; tgu < 44; tgu++)
            {
                int o = jpe.Next(00, 100);

                textBox42.Text = o.ToString();
            }
            Random jp1e = new Random();
            for (int tgu = 00; tgu < 45; tgu++)
            {
                int o = jp1e.Next(00, 100);

                textBox40.Text = o.ToString();
            }
            Random jp1we = new Random();
            for (int tgu = 00; tgu < 46; tgu++)
            {
                int o = jp1we.Next(00, 100);

                textBox39.Text = o.ToString();
            }
            Random jp1pe = new Random();
            for (int tgu = 00; tgu < 47; tgu++)
            {
                int o = jp1pe.Next(00, 100);

                textBox41.Text = o.ToString();
            }
            Random jppe = new Random();
            for (int tgu = 00; tgu < 48; tgu++)
            {
                int o = jppe.Next(00, 100);

                textBox36.Text = o.ToString();
            }
            Random jppes = new Random();
            for (int tgu = 00; tgu < 49; tgu++)
            {
                int o = jppes.Next(00, 100);

                textBox45.Text = o.ToString();
            }
        }
        public void SuperKinoTV()
        {
            Random jue = new Random();
            for (int tgu = 00; tgu < 50; tgu++)
            {
                int o = jue.Next(00, 100);

                textBox59.Text = o.ToString();
            }
            Random jze = new Random();
            for (int tgu = 00; tgu < 51; tgu++)
            {
                int o = jze.Next(00, 100);

                textBox58.Text = o.ToString();
            }
            Random jpe = new Random();
            for (int tgu = 00; tgu < 52; tgu++)
            {
                int o = jpe.Next(00, 100);

                textBox57.Text = o.ToString();
            }
            Random jp1e = new Random();
            for (int tgu = 00; tgu < 53; tgu++)
            {
                int o = jp1e.Next(00, 100);

                textBox55.Text = o.ToString();
            }
            Random jp1we = new Random();
            for (int tgu = 00; tgu < 54; tgu++)
            {
                int o = jp1we.Next(00, 100);

                textBox54.Text = o.ToString();
            }
            Random jp1pe = new Random();
            for (int tgu = 00; tgu < 55; tgu++)
            {
                int o = jp1pe.Next(00, 100);

                textBox56.Text = o.ToString();
            }
            Random jppe = new Random();
            for (int tgu = 00; tgu < 56; tgu++)
            {
                int o = jppe.Next(00, 100);

                textBox53.Text = o.ToString();
            }
            Random jppes = new Random();
            for (int tgu = 00; tgu < 57; tgu++)
            {
                int o = jppes.Next(00, 100);

                textBox52.Text = o.ToString();
            }
            Random jppus = new Random();
            for (int tgu = 00; tgu < 58; tgu++)
            {
                int o = jppus.Next(00, 100);

                textBox61.Text = o.ToString();
            }
            Random jppys = new Random();
            for (int tgu = 00; tgu < 59; tgu++)
            {
                int o = jppys.Next(00, 100);

                textBox60.Text = o.ToString();
            }
        }
        private void btbgenerar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Carga Correcta");
         loteriaNacionalQuiniela();
            loteriaNacionalPale();
            loteriaNacionalTripleta();
            loteriaRealQuiniela();
            loteriaRealPale();
            loteriaRealTripleta();
            Quiniela();
            QuinielaPale();
            QuinielaTripleta();
            Pega3Mas();
            SuperPale();
            Loto();
            LotoMas();
            LotoPool();
            SuperLotoMas();
            SuperKinoTV();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            textBox1.BackColor = Color.Lavender;
            textBox2.BackColor = Color.Lavender;
            textBox3.BackColor = Color.Lavender;
            textBox4.BackColor = Color.Lavender;
            textBox5.BackColor = Color.Lavender;
            textBox6.BackColor = Color.Lavender;
            textBox7.BackColor = Color.Lavender;
            textBox8.BackColor = Color.Lavender;
            textBox9.BackColor = Color.Lavender;
            textBox10.BackColor = Color.Lavender;
            textBox11.BackColor = Color.Lavender;
            textBox12.BackColor = Color.Lavender;
            textBox13.BackColor = Color.Lavender;
            textBox14.BackColor = Color.Lavender;
            textBox15.BackColor = Color.Lavender;
            textBox16.BackColor = Color.Lavender;
            textBox17.BackColor = Color.Lavender;
            textBox18.BackColor = Color.Lavender;
            textBox19.BackColor = Color.Lavender;
            textBox20.BackColor = Color.Lavender;
            textBox21.BackColor = Color.Lavender;
            textBox22.BackColor = Color.Lavender;
            textBox23.BackColor = Color.Lavender;
            textBox24.BackColor = Color.Lavender;
            textBox25.BackColor = Color.Lavender;
            textBox26.BackColor = Color.Lavender;
            textBox27.BackColor = Color.Lavender;
            textBox28.BackColor = Color.Lavender;
            textBox28.BackColor = Color.Lavender;
            textBox30.BackColor = Color.Lavender;
            textBox31.BackColor = Color.Lavender;
            textBox32.BackColor = Color.Lavender;
            textBox33.BackColor = Color.Lavender;
            textBox34.BackColor = Color.Lavender;
            textBox35.BackColor = Color.Lavender;
            textBox36.BackColor = Color.Lavender;
            textBox37.BackColor = Color.Lavender;
            textBox38.BackColor = Color.Lavender;
            textBox39.BackColor = Color.Lavender;
            textBox40.BackColor = Color.Lavender;
            textBox41.BackColor = Color.Lavender;
            textBox42.BackColor = Color.Lavender;
            textBox43.BackColor = Color.Lavender;
            textBox44.BackColor = Color.Lavender;
            textBox45.BackColor = Color.Lavender;
            textBox46.BackColor = Color.Lavender;
            textBox47.BackColor = Color.Lavender;
            textBox48.BackColor = Color.Lavender;
            textBox49.BackColor = Color.Lavender;
            textBox50.BackColor = Color.Lavender;
            textBox51.BackColor = Color.Lavender;
            textBox52.BackColor = Color.Lavender;
            textBox53.BackColor = Color.Lavender;
            textBox54.BackColor = Color.Lavender;
            textBox55.BackColor = Color.Lavender;
            textBox56.BackColor = Color.Lavender;
            textBox57.BackColor = Color.Lavender;
            textBox58.BackColor = Color.Lavender;
            textBox59.BackColor = Color.Lavender;
            textBox60.BackColor = Color.Lavender;
            textBox61.BackColor = Color.Lavender;
          
            
            loteriaNacionalQuiniela();
            loteriaNacionalPale();
            loteriaNacionalTripleta();
            loteriaRealQuiniela();
            loteriaRealPale();
            loteriaRealTripleta();
            Quiniela();
            QuinielaPale();
            QuinielaTripleta();
            Pega3Mas();
            SuperPale();
            Loto();
            LotoMas();
            LotoPool();
            SuperLotoMas();
            SuperKinoTV();
            


        }
        
        
        }
        

        
    }

