
namespace Ksiegowosc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.workers = new System.Windows.Forms.Label();
            this.addWorker = new System.Windows.Forms.Button();
            this.editWorker = new System.Windows.Forms.Button();
            this.deleteWorker = new System.Windows.Forms.Button();
            this.costBox = new System.Windows.Forms.GroupBox();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.workersCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.costNumeric = new System.Windows.Forms.NumericUpDown();
            this.costSet = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.costButton = new System.Windows.Forms.Button();
            this.when = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.workerName = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.results = new System.Windows.Forms.RichTextBox();
            this.bilans = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.balanceNumeric = new System.Windows.Forms.NumericUpDown();
            this.balanceAfter = new System.Windows.Forms.Label();
            this.costBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workersCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // workers
            // 
            this.workers.AutoSize = true;
            this.workers.Location = new System.Drawing.Point(12, 68);
            this.workers.Name = "workers";
            this.workers.Size = new System.Drawing.Size(68, 15);
            this.workers.TabIndex = 0;
            this.workers.Text = "Pracownicy";
            this.workers.Click += new System.EventHandler(this.workers_Click);
            // 
            // addWorker
            // 
            this.addWorker.Location = new System.Drawing.Point(13, 41);
            this.addWorker.Name = "addWorker";
            this.addWorker.Size = new System.Drawing.Size(186, 23);
            this.addWorker.TabIndex = 2;
            this.addWorker.Text = "Dodaj pracownika";
            this.addWorker.UseVisualStyleBackColor = true;
            this.addWorker.Click += new System.EventHandler(this.addWorker_Click);
            // 
            // editWorker
            // 
            this.editWorker.Location = new System.Drawing.Point(13, 382);
            this.editWorker.Name = "editWorker";
            this.editWorker.Size = new System.Drawing.Size(185, 23);
            this.editWorker.TabIndex = 3;
            this.editWorker.Text = "Edytuj";
            this.editWorker.UseVisualStyleBackColor = true;
            // 
            // deleteWorker
            // 
            this.deleteWorker.Location = new System.Drawing.Point(13, 412);
            this.deleteWorker.Name = "deleteWorker";
            this.deleteWorker.Size = new System.Drawing.Size(185, 23);
            this.deleteWorker.TabIndex = 4;
            this.deleteWorker.Text = "Usuń";
            this.deleteWorker.UseVisualStyleBackColor = true;
            // 
            // costBox
            // 
            this.costBox.Controls.Add(this.totalCostLabel);
            this.costBox.Controls.Add(this.label5);
            this.costBox.Controls.Add(this.label4);
            this.costBox.Controls.Add(this.workersCount);
            this.costBox.Controls.Add(this.label3);
            this.costBox.Controls.Add(this.costNumeric);
            this.costBox.Controls.Add(this.costSet);
            this.costBox.Controls.Add(this.dateLabel);
            this.costBox.Controls.Add(this.label1);
            this.costBox.Controls.Add(this.costButton);
            this.costBox.Controls.Add(this.when);
            this.costBox.Location = new System.Drawing.Point(519, 32);
            this.costBox.Name = "costBox";
            this.costBox.Size = new System.Drawing.Size(269, 343);
            this.costBox.TabIndex = 5;
            this.costBox.TabStop = false;
            this.costBox.Text = "Koszta";
            this.costBox.Enter += new System.EventHandler(this.costsBox_Enter);
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalCostLabel.Location = new System.Drawing.Point(7, 151);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(19, 21);
            this.totalCostLabel.TabIndex = 10;
            this.totalCostLabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Całkowity koszt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ilu pracowników";
            // 
            // workersCount
            // 
            this.workersCount.Location = new System.Drawing.Point(6, 102);
            this.workersCount.Name = "workersCount";
            this.workersCount.Size = new System.Drawing.Size(120, 23);
            this.workersCount.TabIndex = 7;
            this.workersCount.ValueChanged += new System.EventHandler(this.workersCount_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ile wynoszą opłaty";
            // 
            // costNumeric
            // 
            this.costNumeric.Location = new System.Drawing.Point(7, 54);
            this.costNumeric.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.costNumeric.Name = "costNumeric";
            this.costNumeric.Size = new System.Drawing.Size(120, 23);
            this.costNumeric.TabIndex = 5;
            this.costNumeric.ValueChanged += new System.EventHandler(this.costNumeric_ValueChanged);
            // 
            // costSet
            // 
            this.costSet.Location = new System.Drawing.Point(7, 251);
            this.costSet.Name = "costSet";
            this.costSet.Size = new System.Drawing.Size(256, 23);
            this.costSet.TabIndex = 4;
            this.costSet.Text = "Ustaw";
            this.costSet.UseVisualStyleBackColor = true;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(7, 203);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(155, 15);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "Wybierz kiedy pokryć koszty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(116, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lub";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // costButton
            // 
            this.costButton.Location = new System.Drawing.Point(6, 301);
            this.costButton.Name = "costButton";
            this.costButton.Size = new System.Drawing.Size(257, 23);
            this.costButton.TabIndex = 1;
            this.costButton.Text = "Pokryj koszty teraz";
            this.costButton.UseVisualStyleBackColor = true;
            this.costButton.Click += new System.EventHandler(this.costButton_Click);
            // 
            // when
            // 
            this.when.Location = new System.Drawing.Point(7, 221);
            this.when.Name = "when";
            this.when.Size = new System.Drawing.Size(257, 23);
            this.when.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 2500;
            // 
            // workerName
            // 
            this.workerName.Location = new System.Drawing.Point(14, 12);
            this.workerName.Name = "workerName";
            this.workerName.Size = new System.Drawing.Size(185, 23);
            this.workerName.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // results
            // 
            this.results.Location = new System.Drawing.Point(12, 86);
            this.results.Name = "results";
            this.results.ReadOnly = true;
            this.results.Size = new System.Drawing.Size(185, 289);
            this.results.TabIndex = 7;
            this.results.Text = "";
            this.results.TextChanged += new System.EventHandler(this.results_TextChanged_1);
            // 
            // bilans
            // 
            this.bilans.AutoSize = true;
            this.bilans.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bilans.Location = new System.Drawing.Point(239, 12);
            this.bilans.Name = "bilans";
            this.bilans.Size = new System.Drawing.Size(71, 25);
            this.bilans.TabIndex = 8;
            this.bilans.Text = "Bilans: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(239, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Przyszły: ";
            // 
            // balanceNumeric
            // 
            this.balanceNumeric.Location = new System.Drawing.Point(316, 14);
            this.balanceNumeric.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.balanceNumeric.Name = "balanceNumeric";
            this.balanceNumeric.Size = new System.Drawing.Size(120, 23);
            this.balanceNumeric.TabIndex = 11;
            // 
            // balanceAfter
            // 
            this.balanceAfter.AutoSize = true;
            this.balanceAfter.Location = new System.Drawing.Point(319, 54);
            this.balanceAfter.Name = "balanceAfter";
            this.balanceAfter.Size = new System.Drawing.Size(85, 15);
            this.balanceAfter.TabIndex = 12;
            this.balanceAfter.Text = "Future Balance";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.balanceAfter);
            this.Controls.Add(this.balanceNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bilans);
            this.Controls.Add(this.results);
            this.Controls.Add(this.workerName);
            this.Controls.Add(this.costBox);
            this.Controls.Add(this.deleteWorker);
            this.Controls.Add(this.editWorker);
            this.Controls.Add(this.addWorker);
            this.Controls.Add(this.workers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.costBox.ResumeLayout(false);
            this.costBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workersCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label workers;
        private System.Windows.Forms.Button addWorker;
        private System.Windows.Forms.Button editWorker;
        private System.Windows.Forms.Button deleteWorker;
        private System.Windows.Forms.GroupBox costBox;
        private System.Windows.Forms.Button costButton;
        private System.Windows.Forms.DateTimePicker when;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox workerName;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox results;
        private System.Windows.Forms.Button costSet;
        private System.Windows.Forms.Label bilans;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown costNumeric;
        private System.Windows.Forms.NumericUpDown balanceNumeric;
        private System.Windows.Forms.Label balanceAfter;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown workersCount;
    }
}

