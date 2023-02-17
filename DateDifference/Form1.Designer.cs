namespace DateDifference
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
            this.day1_numeric = new System.Windows.Forms.NumericUpDown();
            this.month1_numeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.year1_numeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.year2_numeric = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.month2_numeric = new System.Windows.Forms.NumericUpDown();
            this.day2_numeric = new System.Windows.Forms.NumericUpDown();
            this.getResult_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.day1_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.month1_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.year1_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.year2_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.month2_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.day2_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // day1_numeric
            // 
            this.day1_numeric.Location = new System.Drawing.Point(12, 27);
            this.day1_numeric.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.day1_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.day1_numeric.Name = "day1_numeric";
            this.day1_numeric.Size = new System.Drawing.Size(57, 23);
            this.day1_numeric.TabIndex = 0;
            this.day1_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.day1_numeric.Leave += new System.EventHandler(this.day1_numeric_Leave);
            // 
            // month1_numeric
            // 
            this.month1_numeric.Location = new System.Drawing.Point(75, 27);
            this.month1_numeric.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.month1_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.month1_numeric.Name = "month1_numeric";
            this.month1_numeric.Size = new System.Drawing.Size(57, 23);
            this.month1_numeric.TabIndex = 1;
            this.month1_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Day";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Month";
            // 
            // year1_numeric
            // 
            this.year1_numeric.Location = new System.Drawing.Point(138, 27);
            this.year1_numeric.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.year1_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.year1_numeric.Name = "year1_numeric";
            this.year1_numeric.Size = new System.Drawing.Size(75, 23);
            this.year1_numeric.TabIndex = 4;
            this.year1_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Year";
            // 
            // year2_numeric
            // 
            this.year2_numeric.Location = new System.Drawing.Point(138, 86);
            this.year2_numeric.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.year2_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.year2_numeric.Name = "year2_numeric";
            this.year2_numeric.Size = new System.Drawing.Size(75, 23);
            this.year2_numeric.TabIndex = 11;
            this.year2_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Month";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Day";
            // 
            // month2_numeric
            // 
            this.month2_numeric.Location = new System.Drawing.Point(75, 86);
            this.month2_numeric.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.month2_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.month2_numeric.Name = "month2_numeric";
            this.month2_numeric.Size = new System.Drawing.Size(57, 23);
            this.month2_numeric.TabIndex = 8;
            this.month2_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // day2_numeric
            // 
            this.day2_numeric.Location = new System.Drawing.Point(12, 86);
            this.day2_numeric.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.day2_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.day2_numeric.Name = "day2_numeric";
            this.day2_numeric.Size = new System.Drawing.Size(57, 23);
            this.day2_numeric.TabIndex = 7;
            this.day2_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.day2_numeric.Leave += new System.EventHandler(this.day2_numeric_Leave);
            // 
            // getResult_button
            // 
            this.getResult_button.Location = new System.Drawing.Point(118, 135);
            this.getResult_button.Name = "getResult_button";
            this.getResult_button.Size = new System.Drawing.Size(95, 23);
            this.getResult_button.TabIndex = 14;
            this.getResult_button.Text = "Get difference";
            this.getResult_button.UseVisualStyleBackColor = true;
            this.getResult_button.Click += new System.EventHandler(this.getResult_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 172);
            this.Controls.Add(this.getResult_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.year2_numeric);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.month2_numeric);
            this.Controls.Add(this.day2_numeric);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.year1_numeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.month1_numeric);
            this.Controls.Add(this.day1_numeric);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Date difference app";
            ((System.ComponentModel.ISupportInitialize)(this.day1_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.month1_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.year1_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.year2_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.month2_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.day2_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown day1_numeric;
        private NumericUpDown month1_numeric;
        private Label label1;
        private Label label2;
        private NumericUpDown year1_numeric;
        private Label label3;
        private Label label6;
        private NumericUpDown year2_numeric;
        private Label label7;
        private Label label8;
        private NumericUpDown month2_numeric;
        private NumericUpDown day2_numeric;
        private Button getResult_button;
    }
}