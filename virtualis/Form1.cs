using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace virtualis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public abstract class ős
        {
            public int x;
            public int y;
            public ős(int a, int b)
            {
                x = a; y = b;
            }
            public abstract double terulet();
            public abstract double kerulet();
        }
        public class tegla : ős
        {
            public int a;
            public int b;
            public tegla(int x, int y, int szel, int esz) : base(x, y)
            {
                a = szel; b = esz;
            }
            public override double kerulet()
            {   // Téglalap kerülete: (a + b) • 2
                return (a + b) * 2;
            }


            public override double terulet()
            {   // Téglalap területe: a • b
                return a * b;
            }
        }
        interface Iterulet 
        { 
            void terulet(int a, int b); 
        }
        public class szamol : Iterulet
        {
            public int x, y, r;
           

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            tegla kukac = new tegla(11, 11, 13, 13);
            kukac.kerulet();
            kukac.terulet();

        }
    }
}
