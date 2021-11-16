using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Czwiczenie18
{
    public partial class Form1 : Form
    {
        public enum Flapjack
        {
            Chrupkiego,
            Wilgotnego,
            Rumianego,
            Bananowego
        }
        public Form1()
        {
            InitializeComponent();
        }

        private Queue<Lumberjack> breakfastLline = new Queue<Lumberjack>();
        

        private void nextLumberjack_Click(object sender, EventArgs e)
        {
            if (breakfastLline.Count == 0) return;
            Lumberjack nextLumberjack = breakfastLline.Dequeue();
            nextLumberjack.EatFlapjacks();
            nextInLine.Text = "";
            RedrawList();
            
        }

        private void addLumberjack_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(name.Text)) return;
            breakfastLline.Enqueue(new Lumberjack(name.Text));
            name.Text = "";
            RedrawList();
        }
        private void RedrawList()
        {
            int number = 1;
            line.Items.Clear();
            foreach (Lumberjack lumberjack in breakfastLline)
            {
                line.Items.Add(number + ". " + lumberjack.Name);
                number++;
            }
            if (breakfastLline.Count == 0)
            {
                groupBox1.Enabled = false;
                nextInLine.Text = "";
            }
            else
            {
                groupBox1.Enabled = true;
                Lumberjack currentLumberjack = breakfastLline.Peek();
                nextInLine.Text = currentLumberjack.Name + " ma " + currentLumberjack.FlapjackCount + " naleśników";
            }
        }
        class Lumberjack
        {
            private string name;
            public string Name { get { return name; } }
            private Stack<Flapjack> meal;
            public Lumberjack(string name)
            {
                this.name = name;
                meal = new Stack<Flapjack>();
            }
            public int FlapjackCount { get { return meal.Count; } }
            public void TakeFlapjacks(Flapjack food, int HowMany)
            {
                for (int i = 0; i < HowMany; i++)
                {
                    meal.Push(food);
                }
            }
            public void EatFlapjacks()
            {
                Console.WriteLine(Name + " je naleśniki");
                while (meal.Count > 0)
                {
                    Console.WriteLine(name + " zjadł " + meal.Pop().ToString().ToLower() + " naleśnika");
                }
            }
        }
    }
}
