using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Threading.Tasks.Dataflow;

namespace Ksiegowosc
{
    public partial class Form1 : Form
    {
        int startingBalance;
        int endingBalance;
        int MIHave;
        int MIPay;
        int MAfter;
        int TotalCost;
        int CostPerPerson = 3500;
        int NumberOfWorkers;


        public Form1()
        {
            InitializeComponent();
        }
        private Workers currentWorker = new Workers();
        private string selectedFolder = "";
        private bool formChanged = false;
        private void costsBox_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void workers_Click(object sender, EventArgs e)
        {

        }
        private void results_TextChanged_1(object sender, EventArgs e)
        {
            string[] Array = System.IO.File.ReadAllLines(@"\\Zadania\\Ksiegowosc\\Pracownicy\\*.txt");
            foreach (string line in Array)
            {
           results.Text += line + Environment.NewLine;
            }            
        }
        


    private void addWorker_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(workerName.Text))
            {
                MessageBox.Show("Podaj nazwę pracownika", "Nie można zapisać pliku", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            saveFileDialog1.InitialDirectory = selectedFolder;
            saveFileDialog1.Filter = "Pliki tekstowe (*.txt) |*.txt|Wszystkie pliki (*.*)|*.*";
            saveFileDialog1.FileName = workerName.Text + ".txt";
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                currentWorker.Save(saveFileDialog1.FileName);
                UpdateForm(false);
            }
        }
        private bool CheckChanged()
        {
            if (formChanged)
            {
                DialogResult result = MessageBox.Show(
                    "Bieżący pracownik nie został zapisany. Czy kontynuować?", "Ostrzeżenie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    return false;
            }
            return true;
        }
        private void UpdateForm(bool changed)
        {
            if (!changed)
            {
                this.workerName.Text = currentWorker.workerName;
                this.results.Text = currentWorker.Results;
                if (!String.IsNullOrEmpty(currentWorker.sourcePath))
                this.Text = "Program do zarządzania kosztami";
            }
            else
                this.Text = "Program do księgowości*";
            this.formChanged = changed;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void costButton_Click(object sender, EventArgs e)
        {
            startingBalance = (int)balanceNumeric.Value;
            endingBalance = (int)costNumeric.Value;
            if (startingBalance >= endingBalance)
            {
                MIHave = endingBalance -= startingBalance;
                MAfter = MIPay -= MIHave;
                balanceAfter.Text = MAfter.ToString() + " zł";
                costButton.Click += new EventHandler(this.costButton_Click);
                costButton.Enabled = false;
            }
            else
            {
                MessageBox.Show("Nie masz wystarczająco środków.");
            }
        }
        private void costNumeric_ValueChanged(object sender, EventArgs e)
        {
            DisplayTotalCost();
        }
          private void workersCount_ValueChanged(object sender, EventArgs e)
        {
            NumberOfWorkers = (int)workersCount.Value;
            DisplayTotalCost();
        }
        private void DisplayTotalCost()
        {
            decimal TotalCost = (workersCount.Value * CostPerPerson + costNumeric.Value);
            totalCostLabel.Text = TotalCost.ToString() + " zł";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
