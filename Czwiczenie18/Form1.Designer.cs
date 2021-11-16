
namespace Czwiczenie18
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.howMany = new System.Windows.Forms.NumericUpDown();
            this.nextLumberjack = new System.Windows.Forms.Button();
            this.nextInLine = new System.Windows.Forms.TextBox();
            this.addFlapjacks = new System.Windows.Forms.Button();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.browned = new System.Windows.Forms.RadioButton();
            this.soggy = new System.Windows.Forms.RadioButton();
            this.crispy = new System.Windows.Forms.RadioButton();
            this.line = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addLumberjack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.howMany)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.howMany);
            this.groupBox1.Controls.Add(this.nextLumberjack);
            this.groupBox1.Controls.Add(this.nextInLine);
            this.groupBox1.Controls.Add(this.addFlapjacks);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.browned);
            this.groupBox1.Controls.Add(this.soggy);
            this.groupBox1.Controls.Add(this.crispy);
            this.groupBox1.Location = new System.Drawing.Point(194, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 375);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nakarm drwala";
            // 
            // howMany
            // 
            this.howMany.Location = new System.Drawing.Point(7, 37);
            this.howMany.Name = "howMany";
            this.howMany.Size = new System.Drawing.Size(120, 23);
            this.howMany.TabIndex = 7;
            // 
            // nextLumberjack
            // 
            this.nextLumberjack.Location = new System.Drawing.Point(7, 323);
            this.nextLumberjack.Name = "nextLumberjack";
            this.nextLumberjack.Size = new System.Drawing.Size(187, 23);
            this.nextLumberjack.TabIndex = 6;
            this.nextLumberjack.Text = "Następny drwal";
            this.nextLumberjack.UseVisualStyleBackColor = true;
            this.nextLumberjack.Click += new System.EventHandler(this.nextLumberjack_Click);
            // 
            // nextInLine
            // 
            this.nextInLine.Location = new System.Drawing.Point(7, 220);
            this.nextInLine.Multiline = true;
            this.nextInLine.Name = "nextInLine";
            this.nextInLine.ReadOnly = true;
            this.nextInLine.Size = new System.Drawing.Size(187, 77);
            this.nextInLine.TabIndex = 5;
            // 
            // addFlapjacks
            // 
            this.addFlapjacks.Location = new System.Drawing.Point(6, 191);
            this.addFlapjacks.Name = "addFlapjacks";
            this.addFlapjacks.Size = new System.Drawing.Size(187, 23);
            this.addFlapjacks.TabIndex = 4;
            this.addFlapjacks.Text = "Dodaj naleśniki";
            this.addFlapjacks.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(7, 152);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(94, 19);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Bananowego";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // browned
            // 
            this.browned.AutoSize = true;
            this.browned.Location = new System.Drawing.Point(7, 126);
            this.browned.Name = "browned";
            this.browned.Size = new System.Drawing.Size(86, 19);
            this.browned.TabIndex = 2;
            this.browned.TabStop = true;
            this.browned.Text = "Rumianego";
            this.browned.UseVisualStyleBackColor = true;
            // 
            // soggy
            // 
            this.soggy.AutoSize = true;
            this.soggy.Location = new System.Drawing.Point(7, 100);
            this.soggy.Name = "soggy";
            this.soggy.Size = new System.Drawing.Size(87, 19);
            this.soggy.TabIndex = 1;
            this.soggy.TabStop = true;
            this.soggy.Text = "Wilgotnego";
            this.soggy.UseVisualStyleBackColor = true;
            // 
            // crispy
            // 
            this.crispy.AutoSize = true;
            this.crispy.Location = new System.Drawing.Point(7, 74);
            this.crispy.Name = "crispy";
            this.crispy.Size = new System.Drawing.Size(87, 19);
            this.crispy.TabIndex = 0;
            this.crispy.TabStop = true;
            this.crispy.Text = "Chrupkiego";
            this.crispy.UseVisualStyleBackColor = true;
            // 
            // line
            // 
            this.line.Location = new System.Drawing.Point(13, 97);
            this.line.Multiline = true;
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(175, 367);
            this.line.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kolejka do śniadania";
            // 
            // addLumberjack
            // 
            this.addLumberjack.Location = new System.Drawing.Point(13, 40);
            this.addLumberjack.Name = "addLumberjack";
            this.addLumberjack.Size = new System.Drawing.Size(282, 23);
            this.addLumberjack.TabIndex = 3;
            this.addLumberjack.Text = "Dodaj drwala";
            this.addLumberjack.UseVisualStyleBackColor = true;
            this.addLumberjack.Click += new System.EventHandler(this.addLumberjack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Imię drwala";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(114, 11);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(181, 23);
            this.name.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 476);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addLumberjack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.line);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.howMany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown howMany;
        private System.Windows.Forms.Button nextLumberjack;
        private System.Windows.Forms.TextBox nextInLine;
        private System.Windows.Forms.Button addFlapjacks;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton browned;
        private System.Windows.Forms.RadioButton soggy;
        private System.Windows.Forms.RadioButton crispy;
        private System.Windows.Forms.TextBox line;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addLumberjack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
    }
}

