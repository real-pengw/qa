using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // --- Q1 Handlers ---

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            bool is18Plus = radioButton5.Checked;
            groupBox2.Enabled = !is18Plus;
            groupBox3.Enabled = !is18Plus && !radioButton10.Checked;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton2_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton3_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton4_CheckedChanged(object sender, EventArgs e) { }

        // --- Q2 Handlers ---

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Enabled = !radioButton10.Checked && !radioButton5.Checked;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton8_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton7_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton6_CheckedChanged(object sender, EventArgs e) { }

        // --- Q3 Handlers ---

        private void checkBox1_CheckedChanged(object sender, EventArgs e) { }
        private void checkBox2_CheckedChanged(object sender, EventArgs e) { }
        private void checkBox3_CheckedChanged(object sender, EventArgs e) { }
        private void checkBox4_CheckedChanged(object sender, EventArgs e) { }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = checkBox5.Checked;
        }

        // --- Final Output Handler ---

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            // 1. Q1 Format: "受訪對象年齡：X"
            if (radioButton1.Checked) sb.AppendLine("受訪對象年齡：<6");
            else if (radioButton2.Checked) sb.AppendLine("受訪對象年齡：6~10");
            else if (radioButton3.Checked) sb.AppendLine("受訪對象年齡：10~14");
            else if (radioButton4.Checked) sb.AppendLine("受訪對象年齡：14~18");
            else if (radioButton5.Checked) sb.AppendLine("受訪對象年齡：18+");

            // 2. Q2 Format: Header on top, value on next line
            if (groupBox2.Enabled)
            {
                sb.AppendLine("每日使用3C產品時數：");
                if (radioButton10.Checked) sb.AppendLine("不使用");
                else if (radioButton9.Checked) sb.AppendLine("二小時以內");
                else if (radioButton8.Checked) sb.AppendLine("2~4小時");
                else if (radioButton7.Checked) sb.AppendLine("4~6小時");
                else if (radioButton6.Checked) sb.AppendLine("6小時以上");
            }

            // 3. Q3 Format: Header once, checked items listed below
            if (groupBox3.Enabled)
            {
                sb.AppendLine("3C產品的使用行為：");
                if (checkBox1.Checked) sb.AppendLine("社群軟體");
                if (checkBox2.Checked) sb.AppendLine("課業需求");
                if (checkBox3.Checked) sb.AppendLine("線上遊戲");
                if (checkBox4.Checked) sb.AppendLine("線上影音");
                if (checkBox5.Checked && !string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    sb.AppendLine(textBox1.Text.Trim());
                }
            }

            MessageBox.Show(sb.ToString(), "問卷結果");
        }

        private void checkBox5_CheckedChanged_1(object sender, EventArgs e)
        {
        }

        private void checkBox5_CheckedChanged_2(object sender, EventArgs e)
        {
        }
    }
}