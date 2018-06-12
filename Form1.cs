using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //加
        {
            string num1 = textBox2.Text;       //string类型
            string num2 = textBox3.Text;
            int num12 = Convert.ToInt32(num1);   //int
            int num22 = Convert.ToInt32(num2);
            int Result = (num12 + num22);     //int

            textBox1.Text = Convert.ToString(Result);  //输出结果
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e) //减
        {
            string num1 = textBox2.Text;
            string num2 = textBox3.Text;
            int num12 = Convert.ToInt32(num1);
            int num22 = Convert.ToInt32(num2);
            int Result = (num12 - num22);
            textBox1.Text = Convert.ToString(Result);
        }

        private void button3_Click(object sender, EventArgs e) //乘
        {
            string num1 = textBox2.Text;
            string num2 = textBox3.Text;
            int num12 = Convert.ToInt32(num1);
            int num22 = Convert.ToInt32(num2);
            int Result = (num12 * num22);

            textBox1.Text = Convert.ToString(Result);
        }

        private void button4_Click(object sender, EventArgs e) //除
        {
            string ERROR = "";
            string num1 = textBox2.Text;
            string num2 = textBox3.Text;
            double num12 = Convert.ToInt32(num1);
            double num22 = Convert.ToInt32(num2);
            double Result = (num12 / num22);
            if (textBox3.Text.Trim() == "0")
            {
                MessageBox.Show("除数不能为0");
                textBox1.Text = Convert.ToString(ERROR);//目的是让textBox1显示空白
            }
            else
            {
                textBox1.Text = Convert.ToString(Result);
            }
        }

        private void button5_Click(object sender, EventArgs e) //平方
        {
            string Empty = "";
            string num1 = textBox2.Text;
            try    //不转到catch直接崩溃
            {
                double num12 = Convert.ToDouble(num1); //double int崩溃 
                double Result = (num12 * num12); //^2
                textBox1.Text = Convert.ToString(Result);
            }

            catch
            {
                MessageBox.Show("无数值");
                textBox1.Text = Convert.ToString(Empty);//清空textBox1内容
            }

            if (textBox3.Text.Trim() != "")  //清空后显示 等同于上面的ERROR
            {
                textBox1.Text = Convert.ToString(Empty);  //清空
                textBox3.Text = Convert.ToString(Empty);  //清空
                MessageBox.Show("现步只需填写前面数值！");

            }
        }

        private void button6_Click(object sender, EventArgs e) //清屏
        {
            string Clear = "";
            textBox1.Text = Convert.ToString(Clear);
            textBox2.Text = Convert.ToString(Clear);
            textBox3.Text = Convert.ToString(Clear);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string Empty = "";
            string num1 = textBox2.Text;
            try    
            {
                double num12 = Convert.ToDouble(num1); 
                double Result = (num12 * num12 * num12); //^3
                textBox1.Text = Convert.ToString(Result);
            }

            catch
            {
                MessageBox.Show("无数值");
                textBox1.Text = Convert.ToString(Empty);
            }

            if (textBox3.Text.Trim() != "")  
            {
                textBox1.Text = Convert.ToString(Empty);
                textBox3.Text = Convert.ToString(Empty);
                MessageBox.Show("现步只需填写前面数值！");

            }
        }

       
    }
}
