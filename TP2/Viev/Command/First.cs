using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TP2.Viev.Command
{
    public class First:Not
    {
      private  int[] commands = new int[10];
        private int a;
        private string grea;
        public string vis { get; set; }
        public string Color0 { get; set; }
        public string Color1 { get; set; }
        public string Color2 { get; set; }
        public string Color3 { get; set; }
        public string Color4 { get; set; }
        public string Color5 { get; set; }
        public string Color6 { get; set; }
        public string Color7 { get; set; }
        public string Color8 { get; set; }
        public string Color9 { get; set; }
        public string Color10 { get; set; }
        public Second Coo0 { get; private set; }
        public Second Coo1 { get; private set; }
        public Second Coo2 { get; private set; }
        public Second Coo3 { get; private set; }
        public Second Coo4 { get; private set; }
        public Second Coo5 { get; private set; }
        public Second Coo6 { get; private set; }
        public Second Coo7 { get; private set; }
        public Second Coo8 { get; private set; }
        public Second Coo9 { get; private set; }
        public Second Coo10 { get; private set; }
        public Second Adder { get; private set; }
        public First()
        {
            Coo0 = new Second(Changecolor0);
            Coo1 = new Second(Changecolor1);
            Coo2 = new Second(Changecolor2);
            Coo3 = new Second(Changecolor3);
            Coo4 = new Second(Changecolor4);
            Coo5 = new Second(Changecolor5);
            Coo6 = new Second(Changecolor6);
            Coo7 = new Second(Changecolor7);
            Coo8 = new Second(Changecolor8);
            Coo9 = new Second(Changecolor9);
            Adder = new Second(white);
        }
        public void Changecolor0()
        {
            a = 0;
            Color0="DarkSalmon";
            onepropretychanged("Color0");
           
        }
        public void Changecolor1()
        {
            a = 1;
            Color1 = "DarkSalmon";
           
            onepropretychanged("Color1");
        }
        public void Changecolor2()
        {
            a = 2;
            Color2 = "DarkSalmon";
            
            onepropretychanged("Color2");
        }
        public void Changecolor3()
        {
            a = 3;
            Color3 = "DarkSalmon";
           
            onepropretychanged("Color3");
        }
        public void Changecolor4()
        {
            a = 4;
            Color4 = "DarkSalmon";
            
            onepropretychanged("Color4");
        }
        public void Changecolor5()
        {
            a = 5;
            Color5 = "DarkSalmon";
            
            onepropretychanged("Color5");
        }
        public void Changecolor6()
        {
            a = 6;
            Color6= "DarkSalmon";
            
            onepropretychanged("Color6");
        }
        public void Changecolor7()
        {
            a = 7;
            Color7 = "DarkSalmon";
           
            onepropretychanged("Color7");
        }
        public void Changecolor8()
        {
            a = 8;
            Color8 = "DarkSalmon";
            
            onepropretychanged("Color8");
        }
        public void Changecolor9()
        {
            a = 9;
           
            Color9 = "DarkSalmon";
            
            onepropretychanged("Color9");
        }
        private void white()
        {
             commands[a]++;
            string  g= "Great"+a;
            MessageBox.Show(g);
           
            Great0 ="Collapsed";
            onepropretychanged(g);

        }
        public string Great0
        {get;set;}
    }
}  

