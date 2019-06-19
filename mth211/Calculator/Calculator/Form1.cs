using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            foreach (var groupBox in this.Controls.OfType<GroupBox>())
            {
                foreach (var numeric in groupBox.Controls.OfType<NumericUpDown>())
                    SetDefaults(numeric);
            }
        }

        void SetDefaults(NumericUpDown numeric)
        {
            if (numeric != null)
            {
                numeric.Maximum = long.MaxValue;
                numeric.Minimum = 1;
                numeric.Value = 1;
            }
        }

        long Factorial(int x)
        {
            long total=1;
            for (var i = 1; i <= x; i++)
                total *= i;

            return total;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var n = Convert.ToInt32(Perm_N.Value);
            var r = Convert.ToInt32(Perm_R.Value);

            Perm_P.Value = Formulas.Permutations(n,r);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var n = Convert.ToInt32(Comb_N.Value);
            var r = Convert.ToInt32(Combine_R.Value);

            Combine_C.Value = Formulas.Combinations(n,r,Comb_Repeats.Checked);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var n = Convert.ToInt32(Factorial_N.Value);

            factorial_answer.Value = Factorial(n);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName="http://wasntnate.com",
                    UseShellExecute=true
                }
            }.Start();
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            var list = new List<int>();
            var i = 0;
            while(++i<int.MaxValue)
            {
                var sqrt = Math.Sqrt(i * 2);
                var cube = Math.Pow(i*3 , 1.0/3.0);

                
                var sqm = false;
                var cm = false;
                if (sqrt == Math.Floor(sqrt))
                {
                    sqm = true;
                }
                if(cube == Math.Floor(cube))
                {
                    cm=true;
                }

                if (sqm && cm)
                {
                    Debugger.Break();
                }

            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            var N = Convert.ToInt32(Factors_N.Value);

            var list = Factors(N);

            FactorsResult.Text = string.Join(", ", (from x in list
                                                    select x.ToString()).ToArray());
        }

        List<int> Factors(int N)
        {
            var list = new List<int>();
            for (var i = 1; i <= N; i++)
            {
                var r = (N * 1.0) / (i * 1.0);
                if (Math.Floor(r) == r)
                {
                    list.Add(i);
                }
            }
            return list;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            var a = Convert.ToInt32(GCD_A.Value);
            var b = Convert.ToInt32(GCD_B.Value);

            var f_a = Factors(a);
            var f_b = Factors(b);

            var intersect = f_a.Intersect(f_b);

            GCD_R.Text = string.Join(", ", (from x in intersect
                                            orderby x
                                            select x.ToString()).ToArray());

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var obj = Convert.ToInt32(Stirling_Obj.Value);
            var buckets = Convert.ToInt32(ster_Bucket.Value);

            stirling_result.Text = Formulas.Stirling(obj, buckets).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var count=int.MaxValue;
            var perfectCubes = new List<int>();
            var perfectSquares = new List<int>();

            var list = new List<int>();

            for (var i = 1; i < count; i++)
            {
                var x = i * i;
                perfectSquares.Add(x);
                perfectCubes.Add(x * i);
            }

            perfectSquares.Sort();
            perfectCubes.Sort();

            for (var i = 1; i < count; i++)
            {
                var alpha=false;
                var beta=false;
                if (perfectSquares.Contains(2 * i))
                    alpha = true;
                if (perfectCubes.Contains(3 * i))
                    beta = true;

                if (alpha && beta)
                {
                    list.Add(i);
                }
            }
        }

        
    }
}
