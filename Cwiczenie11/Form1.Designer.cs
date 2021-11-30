
namespace Cwiczenie11
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
            this.workerBeeJob = new System.Windows.Forms.ComboBox();
            this.assignJob = new System.Windows.Forms.Button();
            this.shifts = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nextShift = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // workerBeeJob
            // 
            this.workerBeeJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerBeeJob.FormattingEnabled = true;
            this.workerBeeJob.Items.AddRange(new object[] {
            "Zbieranie nektaru",
            "Pielęgnacja jaj",
            "Utrzymywanie ula ",
            "Wytwarzanie miodu",
            "Patrol z żądłami",
            "Nauczanie pszczółek"});
            this.workerBeeJob.Location = new System.Drawing.Point(6, 60);
            this.workerBeeJob.Name = "workerBeeJob";
            this.workerBeeJob.Size = new System.Drawing.Size(172, 23);
            this.workerBeeJob.TabIndex = 0;
            // 
            // assignJob
            // 
            this.assignJob.Location = new System.Drawing.Point(6, 89);
            this.assignJob.Name = "assignJob";
            this.assignJob.Size = new System.Drawing.Size(316, 23);
            this.assignJob.TabIndex = 1;
            this.assignJob.Text = "Przypisz tę pracę pszczole";
            this.assignJob.UseVisualStyleBackColor = true;
            this.assignJob.Click += new System.EventHandler(this.assignJob_Click);
            // 
            // shifts
            // 
            this.shifts.Location = new System.Drawing.Point(202, 60);
            this.shifts.Name = "shifts";
            this.shifts.Size = new System.Drawing.Size(120, 23);
            this.shifts.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.workerBeeJob);
            this.groupBox1.Controls.Add(this.assignJob);
            this.groupBox1.Controls.Add(this.shifts);
            this.groupBox1.Location = new System.Drawing.Point(36, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 136);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Przydział prac robotnicom";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(202, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 16);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Zmiany";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(6, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 16);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Zadanie robotnicy";
            // 
            // nextShift
            // 
            this.nextShift.Font = new System.Drawing.Font("Arial Black", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nextShift.Location = new System.Drawing.Point(457, 26);
            this.nextShift.Name = "nextShift";
            this.nextShift.Size = new System.Drawing.Size(200, 136);
            this.nextShift.TabIndex = 4;
            this.nextShift.Text = "Przepracuj następną zmianę";
            this.nextShift.UseVisualStyleBackColor = true;
            this.nextShift.Click += new System.EventHandler(this.nextShift_Click);
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(36, 179);
            this.report.Multiline = true;
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(621, 232);
            this.report.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.report);
            this.Controls.Add(this.nextShift);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox workerBeeJob;
        private System.Windows.Forms.Button assignJob;
        private System.Windows.Forms.NumericUpDown shifts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button nextShift;
        private System.Windows.Forms.TextBox report;
    }
}

