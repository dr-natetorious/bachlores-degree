namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Perm_P = new System.Windows.Forms.NumericUpDown();
            this.Perm_R = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Perm_N = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Comb_Repeats = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Combine_C = new System.Windows.Forms.NumericUpDown();
            this.Combine_R = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Comb_N = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.factorial_answer = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Factorial_N = new System.Windows.Forms.NumericUpDown();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.FactorsResult = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.Factors_N = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.GCD_B = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.GCD_R = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.GCD_A = new System.Windows.Forms.NumericUpDown();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ster_Bucket = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.stirling_result = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.Stirling_Obj = new System.Windows.Forms.NumericUpDown();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Perm_P)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Perm_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Perm_N)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Combine_C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Combine_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Comb_N)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.factorial_answer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Factorial_N)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Factors_N)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCD_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCD_A)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ster_Bucket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stirling_Obj)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Perm_P);
            this.groupBox1.Controls.Add(this.Perm_R);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Perm_N);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permutations";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "P=";
            // 
            // Perm_P
            // 
            this.Perm_P.Location = new System.Drawing.Point(324, 22);
            this.Perm_P.Name = "Perm_P";
            this.Perm_P.Size = new System.Drawing.Size(120, 20);
            this.Perm_P.TabIndex = 4;
            // 
            // Perm_R
            // 
            this.Perm_R.Location = new System.Drawing.Point(63, 55);
            this.Perm_R.Name = "Perm_R";
            this.Perm_R.Size = new System.Drawing.Size(120, 20);
            this.Perm_R.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "R =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "N =";
            // 
            // Perm_N
            // 
            this.Perm_N.Location = new System.Drawing.Point(63, 23);
            this.Perm_N.Name = "Perm_N";
            this.Perm_N.Size = new System.Drawing.Size(120, 20);
            this.Perm_N.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Comb_Repeats);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Combine_C);
            this.groupBox2.Controls.Add(this.Combine_R);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Comb_N);
            this.groupBox2.Location = new System.Drawing.Point(13, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 123);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Combinations";
            // 
            // Comb_Repeats
            // 
            this.Comb_Repeats.AutoSize = true;
            this.Comb_Repeats.Location = new System.Drawing.Point(21, 83);
            this.Comb_Repeats.Name = "Comb_Repeats";
            this.Comb_Repeats.Size = new System.Drawing.Size(94, 17);
            this.Comb_Repeats.TabIndex = 7;
            this.Comb_Repeats.Text = "Allow Repeats";
            this.Comb_Repeats.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(369, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "C=";
            // 
            // Combine_C
            // 
            this.Combine_C.Location = new System.Drawing.Point(324, 22);
            this.Combine_C.Name = "Combine_C";
            this.Combine_C.Size = new System.Drawing.Size(120, 20);
            this.Combine_C.TabIndex = 4;
            // 
            // Combine_R
            // 
            this.Combine_R.Location = new System.Drawing.Point(63, 55);
            this.Combine_R.Name = "Combine_R";
            this.Combine_R.Size = new System.Drawing.Size(120, 20);
            this.Combine_R.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "R =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "N =";
            // 
            // Comb_N
            // 
            this.Comb_N.Location = new System.Drawing.Point(63, 23);
            this.Comb_N.Name = "Comb_N";
            this.Comb_N.Size = new System.Drawing.Size(120, 20);
            this.Comb_N.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.factorial_answer);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.Factorial_N);
            this.groupBox3.Location = new System.Drawing.Point(13, 262);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(492, 103);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Factorial";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(281, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Result";
            // 
            // factorial_answer
            // 
            this.factorial_answer.Location = new System.Drawing.Point(324, 33);
            this.factorial_answer.Name = "factorial_answer";
            this.factorial_answer.Size = new System.Drawing.Size(120, 20);
            this.factorial_answer.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(369, 59);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Calculate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "N =";
            // 
            // Factorial_N
            // 
            this.Factorial_N.Location = new System.Drawing.Point(63, 33);
            this.Factorial_N.Name = "Factorial_N";
            this.Factorial_N.Size = new System.Drawing.Size(120, 20);
            this.Factorial_N.TabIndex = 2;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(13, 375);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(194, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://wasntnate.com | Nate Bachmeier";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.FactorsResult);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.Factors_N);
            this.groupBox4.Location = new System.Drawing.Point(511, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(492, 114);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Factors";
            // 
            // FactorsResult
            // 
            this.FactorsResult.Location = new System.Drawing.Point(63, 58);
            this.FactorsResult.Multiline = true;
            this.FactorsResult.Name = "FactorsResult";
            this.FactorsResult.Size = new System.Drawing.Size(376, 50);
            this.FactorsResult.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(364, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Calculate";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "N =";
            // 
            // Factors_N
            // 
            this.Factors_N.Location = new System.Drawing.Point(63, 23);
            this.Factors_N.Name = "Factors_N";
            this.Factors_N.Size = new System.Drawing.Size(120, 20);
            this.Factors_N.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.GCD_B);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.GCD_R);
            this.groupBox5.Controls.Add(this.button5);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.GCD_A);
            this.groupBox5.Location = new System.Drawing.Point(511, 133);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(492, 123);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Greatest Common Denominator";
            // 
            // GCD_B
            // 
            this.GCD_B.Location = new System.Drawing.Point(63, 53);
            this.GCD_B.Name = "GCD_B";
            this.GCD_B.Size = new System.Drawing.Size(120, 20);
            this.GCD_B.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "B=";
            // 
            // GCD_R
            // 
            this.GCD_R.Location = new System.Drawing.Point(63, 83);
            this.GCD_R.Multiline = true;
            this.GCD_R.Name = "GCD_R";
            this.GCD_R.Size = new System.Drawing.Size(376, 25);
            this.GCD_R.TabIndex = 7;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(364, 20);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Calculate";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "A=";
            // 
            // GCD_A
            // 
            this.GCD_A.Location = new System.Drawing.Point(63, 23);
            this.GCD_A.Name = "GCD_A";
            this.GCD_A.Size = new System.Drawing.Size(120, 20);
            this.GCD_A.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.ster_Bucket);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.stirling_result);
            this.groupBox6.Controls.Add(this.button6);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.Stirling_Obj);
            this.groupBox6.Location = new System.Drawing.Point(511, 265);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(492, 123);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Stirling";
            // 
            // ster_Bucket
            // 
            this.ster_Bucket.Location = new System.Drawing.Point(63, 53);
            this.ster_Bucket.Name = "ster_Bucket";
            this.ster_Bucket.Size = new System.Drawing.Size(120, 20);
            this.ster_Bucket.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Buckets";
            // 
            // stirling_result
            // 
            this.stirling_result.Location = new System.Drawing.Point(63, 83);
            this.stirling_result.Multiline = true;
            this.stirling_result.Name = "stirling_result";
            this.stirling_result.Size = new System.Drawing.Size(376, 25);
            this.stirling_result.TabIndex = 7;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(364, 20);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Calculate";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Objs";
            // 
            // Stirling_Obj
            // 
            this.Stirling_Obj.Location = new System.Drawing.Point(63, 23);
            this.Stirling_Obj.Name = "Stirling_Obj";
            this.Stirling_Obj.Size = new System.Drawing.Size(120, 20);
            this.Stirling_Obj.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(760, 404);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 11;
            this.button7.Text = "Calculate";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 454);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Discrete Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Perm_P)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Perm_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Perm_N)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Combine_C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Combine_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Comb_N)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.factorial_answer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Factorial_N)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Factors_N)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCD_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCD_A)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ster_Bucket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stirling_Obj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Perm_P;
        private System.Windows.Forms.NumericUpDown Perm_R;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Perm_N;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Combine_C;
        private System.Windows.Forms.NumericUpDown Combine_R;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown Comb_N;
        private System.Windows.Forms.CheckBox Comb_Repeats;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown factorial_answer;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown Factorial_N;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox FactorsResult;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown Factors_N;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown GCD_B;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox GCD_R;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown GCD_A;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown ster_Bucket;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox stirling_result;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown Stirling_Obj;
        private System.Windows.Forms.Button button7;
    }
}

