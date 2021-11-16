using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cwiczenie10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public class A
        {
            public int ivar = 7;
            public virtual string m1()
            {
                return "A m1, ";
            }
            public string m2()
            {
                return "A m2, ";
            }
            public virtual string m3()
            {
                return "A m3, ";
            }
        }
        public class B : A
        {
            public override string m1()
            {
                return "B m1, ";
            }
        }
        public class C : B
        {
            public override string m3()
            {
                return "C m3, " + (ivar + 6);
            }
        }
        public class Mixed5 {
            public static void Main(string[] args){
                A a = new A();
                B b = new B();
                C c = new C();
                A a2 = new C();
                string q = "";
                q += b.m1();
                q += c.m2();
                q += a.m3();
                System.Windows.Forms.MessageBox.Show(q);
            } 
        }
    }
}
