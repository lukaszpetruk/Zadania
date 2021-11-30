using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cwiczenie12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        interface IClown
        {
            string FunnyThingIHave { get; }
            void Honk();
        }
        interface IScaryClown : IClown
        {
            string ScaryThingIHave { get; }
            void ScareLittleChildren();
        }
        class FunnyFunny : IClown
        {
            public FunnyFunny(string funnyThingIHave)
            {
                this.funnyThingIHave = funnyThingIHave;
            }
            private string funnyThingIHave;
            public string FunnyThingIHave
            {
                get { return "Cześć dziaciaki! Mam " + funnyThingIHave; }
            }
            public void Honk()
            {
                Console.WriteLine(this.FunnyThingIHave);
            }
        }
        class ScaryScary : FunnyFunny, IScaryClown
        {
            public ScaryScary(string funnyThingIHave, int numberOfScaryThings)
                : base(funnyThingIHave)
            {
                this.numberOfScaryThings = numberOfScaryThings;
            }
            private int numberOfScaryThings;
            public string ScaryThingIHave
            {
                get { return "Mam " + numberOfScaryThings + " pająków"; }
            }
            public void ScareLittleChildren()
            {
                Console.WriteLine("Buu! Mam cię!");
            }
        }
        static void Main(string[] args)
        {
            ScaryScary fingersTheClown = new ScaryScary("Duże buty", 35);
            FunnyFunny someFunnyClown = fingersTheClown;
            IScaryClown someOtherScaryClown = someFunnyClown as ScaryScary;
            someOtherScaryClown.Honk();
            Console.ReadKey();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
