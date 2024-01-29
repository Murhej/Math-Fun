namespace Calculator
{
    partial class Calculator
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
            this.AC = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NegtiveAndPostive = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Percentage = new System.Windows.Forms.Button();
            this.Multply = new System.Windows.Forms.Button();
            this.Integer_Nine = new System.Windows.Forms.Button();
            this.Integer_Eight = new System.Windows.Forms.Button();
            this.Integer_Seven = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.Integer_Six = new System.Windows.Forms.Button();
            this.Integer_Five = new System.Windows.Forms.Button();
            this.Integer_Four = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Integer_Three = new System.Windows.Forms.Button();
            this.Integer_Second = new System.Windows.Forms.Button();
            this.Integer_One = new System.Windows.Forms.Button();
            this.Interger_Zero = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.Dot = new System.Windows.Forms.Button();
            this.CalculatorContanier = new System.Windows.Forms.GroupBox();
            this.CalculatorContanier.SuspendLayout();
            this.SuspendLayout();
            // 
            // AC
            // 
            this.AC.BackColor = System.Drawing.Color.Silver;
            this.AC.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AC.Location = new System.Drawing.Point(27, 111);
            this.AC.Name = "AC";
            this.AC.Size = new System.Drawing.Size(79, 67);
            this.AC.TabIndex = 0;
            this.AC.Text = "AC";
            this.AC.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Location = new System.Drawing.Point(27, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(331, 79);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NegtiveAndPostive
            // 
            this.NegtiveAndPostive.BackColor = System.Drawing.Color.Silver;
            this.NegtiveAndPostive.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NegtiveAndPostive.Location = new System.Drawing.Point(112, 111);
            this.NegtiveAndPostive.Name = "NegtiveAndPostive";
            this.NegtiveAndPostive.Size = new System.Drawing.Size(79, 67);
            this.NegtiveAndPostive.TabIndex = 2;
            this.NegtiveAndPostive.Text = "+/-";
            this.NegtiveAndPostive.UseVisualStyleBackColor = false;
            // 
            // Divide
            // 
            this.Divide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Divide.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Divide.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Divide.Location = new System.Drawing.Point(279, 111);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(79, 67);
            this.Divide.TabIndex = 4;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = false;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // Percentage
            // 
            this.Percentage.BackColor = System.Drawing.Color.Silver;
            this.Percentage.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Percentage.Location = new System.Drawing.Point(197, 111);
            this.Percentage.Name = "Percentage";
            this.Percentage.Size = new System.Drawing.Size(75, 67);
            this.Percentage.TabIndex = 3;
            this.Percentage.Text = "%";
            this.Percentage.UseVisualStyleBackColor = false;
            // 
            // Multply
            // 
            this.Multply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Multply.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Multply.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Multply.Location = new System.Drawing.Point(280, 183);
            this.Multply.Name = "Multply";
            this.Multply.Size = new System.Drawing.Size(79, 67);
            this.Multply.TabIndex = 8;
            this.Multply.Text = "x";
            this.Multply.UseVisualStyleBackColor = false;
            this.Multply.Click += new System.EventHandler(this.Multply_Click);
            // 
            // Integer_Nine
            // 
            this.Integer_Nine.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Integer_Nine.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Integer_Nine.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Integer_Nine.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Integer_Nine.Location = new System.Drawing.Point(198, 183);
            this.Integer_Nine.Name = "Integer_Nine";
            this.Integer_Nine.Size = new System.Drawing.Size(75, 67);
            this.Integer_Nine.TabIndex = 7;
            this.Integer_Nine.Text = "9";
            this.Integer_Nine.UseVisualStyleBackColor = false;
            this.Integer_Nine.Click += new System.EventHandler(this.Integer_Nine_Click);
            // 
            // Integer_Eight
            // 
            this.Integer_Eight.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Integer_Eight.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Integer_Eight.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Integer_Eight.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Integer_Eight.Location = new System.Drawing.Point(113, 183);
            this.Integer_Eight.Name = "Integer_Eight";
            this.Integer_Eight.Size = new System.Drawing.Size(79, 67);
            this.Integer_Eight.TabIndex = 6;
            this.Integer_Eight.Text = "8";
            this.Integer_Eight.UseVisualStyleBackColor = false;
            this.Integer_Eight.Click += new System.EventHandler(this.Integer_Eight_Click);
            // 
            // Integer_Seven
            // 
            this.Integer_Seven.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Integer_Seven.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Integer_Seven.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Integer_Seven.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Integer_Seven.Location = new System.Drawing.Point(27, 183);
            this.Integer_Seven.Name = "Integer_Seven";
            this.Integer_Seven.Size = new System.Drawing.Size(79, 67);
            this.Integer_Seven.TabIndex = 5;
            this.Integer_Seven.Text = "7";
            this.Integer_Seven.UseVisualStyleBackColor = false;
            this.Integer_Seven.Click += new System.EventHandler(this.Integer_Seven_Click);
            // 
            // Subtract
            // 
            this.Subtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Subtract.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Subtract.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Subtract.Location = new System.Drawing.Point(280, 255);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(79, 67);
            this.Subtract.TabIndex = 12;
            this.Subtract.Text = "-";
            this.Subtract.UseVisualStyleBackColor = false;
            this.Subtract.Click += new System.EventHandler(this.Subtract_Click);
            // 
            // Integer_Six
            // 
            this.Integer_Six.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Integer_Six.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Integer_Six.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Integer_Six.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Integer_Six.Location = new System.Drawing.Point(198, 255);
            this.Integer_Six.Name = "Integer_Six";
            this.Integer_Six.Size = new System.Drawing.Size(75, 67);
            this.Integer_Six.TabIndex = 11;
            this.Integer_Six.Text = "6";
            this.Integer_Six.UseVisualStyleBackColor = false;
            this.Integer_Six.Click += new System.EventHandler(this.Integer_Six_Click);
            // 
            // Integer_Five
            // 
            this.Integer_Five.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Integer_Five.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Integer_Five.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Integer_Five.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Integer_Five.Location = new System.Drawing.Point(113, 255);
            this.Integer_Five.Name = "Integer_Five";
            this.Integer_Five.Size = new System.Drawing.Size(79, 67);
            this.Integer_Five.TabIndex = 10;
            this.Integer_Five.Text = "5";
            this.Integer_Five.UseVisualStyleBackColor = false;
            this.Integer_Five.Click += new System.EventHandler(this.Integer_Five_Click);
            // 
            // Integer_Four
            // 
            this.Integer_Four.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Integer_Four.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Integer_Four.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Integer_Four.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Integer_Four.Location = new System.Drawing.Point(27, 255);
            this.Integer_Four.Name = "Integer_Four";
            this.Integer_Four.Size = new System.Drawing.Size(79, 67);
            this.Integer_Four.TabIndex = 9;
            this.Integer_Four.Text = "4";
            this.Integer_Four.UseVisualStyleBackColor = false;
            this.Integer_Four.Click += new System.EventHandler(this.Integer_Four_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Add.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Add.Location = new System.Drawing.Point(280, 327);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(79, 67);
            this.Add.TabIndex = 16;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Integer_Three
            // 
            this.Integer_Three.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Integer_Three.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Integer_Three.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Integer_Three.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Integer_Three.Location = new System.Drawing.Point(198, 327);
            this.Integer_Three.Name = "Integer_Three";
            this.Integer_Three.Size = new System.Drawing.Size(75, 67);
            this.Integer_Three.TabIndex = 15;
            this.Integer_Three.Text = "3";
            this.Integer_Three.UseVisualStyleBackColor = false;
            this.Integer_Three.Click += new System.EventHandler(this.Integer_Three_Click);
            // 
            // Integer_Second
            // 
            this.Integer_Second.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Integer_Second.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Integer_Second.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Integer_Second.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Integer_Second.Location = new System.Drawing.Point(113, 327);
            this.Integer_Second.Name = "Integer_Second";
            this.Integer_Second.Size = new System.Drawing.Size(79, 67);
            this.Integer_Second.TabIndex = 14;
            this.Integer_Second.Text = "2";
            this.Integer_Second.UseVisualStyleBackColor = false;
            this.Integer_Second.Click += new System.EventHandler(this.Integer_Second_Click);
            // 
            // Integer_One
            // 
            this.Integer_One.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Integer_One.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Integer_One.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Integer_One.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Integer_One.Location = new System.Drawing.Point(27, 327);
            this.Integer_One.Name = "Integer_One";
            this.Integer_One.Size = new System.Drawing.Size(79, 67);
            this.Integer_One.TabIndex = 13;
            this.Integer_One.Text = "1";
            this.Integer_One.UseVisualStyleBackColor = false;
            this.Integer_One.Click += new System.EventHandler(this.Integer_One_Click);
            // 
            // Interger_Zero
            // 
            this.Interger_Zero.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Interger_Zero.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Interger_Zero.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Interger_Zero.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Interger_Zero.Location = new System.Drawing.Point(27, 399);
            this.Interger_Zero.Name = "Interger_Zero";
            this.Interger_Zero.Size = new System.Drawing.Size(163, 67);
            this.Interger_Zero.TabIndex = 17;
            this.Interger_Zero.Text = "0";
            this.Interger_Zero.UseVisualStyleBackColor = false;
            this.Interger_Zero.Click += new System.EventHandler(this.Interger_Zero_Click);
            // 
            // Equal
            // 
            this.Equal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Equal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Equal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Equal.Location = new System.Drawing.Point(280, 399);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(79, 67);
            this.Equal.TabIndex = 19;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = false;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // Dot
            // 
            this.Dot.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Dot.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Dot.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Dot.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Dot.Location = new System.Drawing.Point(198, 399);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(75, 67);
            this.Dot.TabIndex = 18;
            this.Dot.Text = ".";
            this.Dot.UseVisualStyleBackColor = false;
            this.Dot.Click += new System.EventHandler(this.Dot_Click);
            // 
            // CalculatorContanier
            // 
            this.CalculatorContanier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculatorContanier.AutoSize = true;
            this.CalculatorContanier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CalculatorContanier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CalculatorContanier.Controls.Add(this.Integer_Eight);
            this.CalculatorContanier.Controls.Add(this.Equal);
            this.CalculatorContanier.Controls.Add(this.AC);
            this.CalculatorContanier.Controls.Add(this.Dot);
            this.CalculatorContanier.Controls.Add(this.textBox1);
            this.CalculatorContanier.Controls.Add(this.Interger_Zero);
            this.CalculatorContanier.Controls.Add(this.NegtiveAndPostive);
            this.CalculatorContanier.Controls.Add(this.Add);
            this.CalculatorContanier.Controls.Add(this.Percentage);
            this.CalculatorContanier.Controls.Add(this.Integer_Three);
            this.CalculatorContanier.Controls.Add(this.Divide);
            this.CalculatorContanier.Controls.Add(this.Integer_Second);
            this.CalculatorContanier.Controls.Add(this.Integer_Seven);
            this.CalculatorContanier.Controls.Add(this.Integer_One);
            this.CalculatorContanier.Controls.Add(this.Integer_Nine);
            this.CalculatorContanier.Controls.Add(this.Subtract);
            this.CalculatorContanier.Controls.Add(this.Multply);
            this.CalculatorContanier.Controls.Add(this.Integer_Six);
            this.CalculatorContanier.Controls.Add(this.Integer_Four);
            this.CalculatorContanier.Controls.Add(this.Integer_Five);
            this.CalculatorContanier.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.CalculatorContanier.Location = new System.Drawing.Point(3, 15);
            this.CalculatorContanier.Name = "CalculatorContanier";
            this.CalculatorContanier.Size = new System.Drawing.Size(365, 492);
            this.CalculatorContanier.TabIndex = 20;
            this.CalculatorContanier.TabStop = false;
            this.CalculatorContanier.Text = "Calculator";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(374, 519);
            this.Controls.Add(this.CalculatorContanier);
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.CalculatorContanier.ResumeLayout(false);
            this.CalculatorContanier.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button AC;
        private TextBox textBox1;
        private Button NegtiveAndPostive;
        private Button Divide;
        private Button Percentage;
        private Button Multply;
        private Button Integer_Nine;
        private Button Integer_Eight;
        private Button Integer_Seven;
        private Button Subtract;
        private Button Integer_Six;
        private Button Integer_Five;
        private Button Integer_Four;
        private Button Add;
        private Button Integer_Three;
        private Button Integer_Second;
        private Button Integer_One;
        private Button Equal;
        private Button Dot;
        private Button Integer_Zero;
        private Button Interger_Zero;
        private GroupBox CalculatorContanier;
    }
}