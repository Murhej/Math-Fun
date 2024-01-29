namespace Fraction_Cal
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
            this.PerformOperation = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.RadioButton();
            this.Multiply = new System.Windows.Forms.RadioButton();
            this.Subtract = new System.Windows.Forms.RadioButton();
            this.Divi = new System.Windows.Forms.RadioButton();
            this.Ltop = new System.Windows.Forms.TextBox();
            this.Lbottom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RBottom = new System.Windows.Forms.TextBox();
            this.RTop = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ResultBottom = new System.Windows.Forms.TextBox();
            this.ResultTop = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PerformOperation
            // 
            this.PerformOperation.Location = new System.Drawing.Point(82, 345);
            this.PerformOperation.Name = "PerformOperation";
            this.PerformOperation.Size = new System.Drawing.Size(344, 80);
            this.PerformOperation.TabIndex = 0;
            this.PerformOperation.Text = "Calcaulte";
            this.PerformOperation.UseVisualStyleBackColor = true;
            this.PerformOperation.Click += new System.EventHandler(this.PerformOperation_Click);
            // 
            // Add
            // 
            this.Add.AutoSize = true;
            this.Add.Location = new System.Drawing.Point(140, 110);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(33, 19);
            this.Add.TabIndex = 1;
            this.Add.TabStop = true;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.CheckedChanged += new System.EventHandler(this.Add_CheckedChanged);
            // 
            // Multiply
            // 
            this.Multiply.AutoSize = true;
            this.Multiply.Location = new System.Drawing.Point(140, 186);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(30, 19);
            this.Multiply.TabIndex = 2;
            this.Multiply.TabStop = true;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.CheckedChanged += new System.EventHandler(this.Multiply_CheckedChanged);
            // 
            // Subtract
            // 
            this.Subtract.AutoSize = true;
            this.Subtract.Location = new System.Drawing.Point(140, 143);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(30, 19);
            this.Subtract.TabIndex = 3;
            this.Subtract.TabStop = true;
            this.Subtract.Text = "-";
            this.Subtract.UseVisualStyleBackColor = true;
            this.Subtract.CheckedChanged += new System.EventHandler(this.Subtract_CheckedChanged);
            // 
            // Divi
            // 
            this.Divi.AutoSize = true;
            this.Divi.Location = new System.Drawing.Point(143, 223);
            this.Divi.Name = "Divi";
            this.Divi.Size = new System.Drawing.Size(30, 19);
            this.Divi.TabIndex = 4;
            this.Divi.TabStop = true;
            this.Divi.Text = "/";
            this.Divi.UseVisualStyleBackColor = true;
            this.Divi.CheckedChanged += new System.EventHandler(this.Divi_CheckedChanged);
            // 
            // Ltop
            // 
            this.Ltop.Location = new System.Drawing.Point(25, 176);
            this.Ltop.Name = "Ltop";
            this.Ltop.Size = new System.Drawing.Size(35, 23);
            this.Ltop.TabIndex = 5;
            this.Ltop.TextChanged += new System.EventHandler(this.Ltop_TextChanged);
            // 
            // Lbottom
            // 
            this.Lbottom.Location = new System.Drawing.Point(82, 176);
            this.Lbottom.Name = "Lbottom";
            this.Lbottom.Size = new System.Drawing.Size(35, 23);
            this.Lbottom.TabIndex = 6;
            this.Lbottom.TextChanged += new System.EventHandler(this.Lbottom_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "First";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Second";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "/";
            // 
            // RBottom
            // 
            this.RBottom.Location = new System.Drawing.Point(271, 176);
            this.RBottom.Name = "RBottom";
            this.RBottom.Size = new System.Drawing.Size(35, 23);
            this.RBottom.TabIndex = 10;
            this.RBottom.TextChanged += new System.EventHandler(this.RBottom_TextChanged);
            // 
            // RTop
            // 
            this.RTop.Location = new System.Drawing.Point(214, 176);
            this.RTop.Name = "RTop";
            this.RTop.Size = new System.Drawing.Size(35, 23);
            this.RTop.TabIndex = 9;
            this.RTop.TextChanged += new System.EventHandler(this.RTop_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Result";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "/";
            // 
            // ResultBottom
            // 
            this.ResultBottom.Location = new System.Drawing.Point(457, 176);
            this.ResultBottom.Name = "ResultBottom";
            this.ResultBottom.Size = new System.Drawing.Size(35, 23);
            this.ResultBottom.TabIndex = 14;
            // 
            // ResultTop
            // 
            this.ResultTop.Location = new System.Drawing.Point(400, 176);
            this.ResultTop.Name = "ResultTop";
            this.ResultTop.Size = new System.Drawing.Size(35, 23);
            this.ResultTop.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(354, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ResultBottom);
            this.Controls.Add(this.ResultTop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RBottom);
            this.Controls.Add(this.RTop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbottom);
            this.Controls.Add(this.Ltop);
            this.Controls.Add(this.Divi);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.PerformOperation);
            this.Name = "Form1";
            this.Text = "Fraction Cal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button PerformOperation;
        private RadioButton Add;
        private RadioButton Multiply;
        private RadioButton Subtract;
        private RadioButton Divi;
        private TextBox Ltop;
        private TextBox Lbottom;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox RBottom;
        private TextBox RTop;
        private Label label5;
        private Label label6;
        private TextBox ResultBottom;
        private TextBox ResultTop;
        private Label label7;
    }
}