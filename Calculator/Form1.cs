using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_Click1(object sender, EventArgs e)
        {
            string _stringOne = buttonOne.Text;
            double _doubleOne = Convert.ToDouble(_stringOne);
            textBox_Result.Text = textBox_Result.Text + _doubleOne;
        }

        private void Button_Click2(object sender, EventArgs e)
        {
            string _stringTwo = buttonTwo.Text;
            double _doubleTwo = Convert.ToDouble(_stringTwo);
            textBox_Result.Text = textBox_Result.Text + _doubleTwo;
        }

        private void Button_Click3(object sender, EventArgs e)
        {
            string _stringThree = buttonThree.Text;
            double _doubleThree = Convert.ToDouble(_stringThree);
            textBox_Result.Text = textBox_Result.Text + _doubleThree;
        }

        private void Button_Click4(object sender, EventArgs e)
        {
            string _stringFour = buttonFour.Text;
            double _doubleFour = Convert.ToDouble(_stringFour);
            textBox_Result.Text = textBox_Result.Text + _doubleFour;
        }

        private void Button_Click5(object sender, EventArgs e)
        {
            string _stringFive = buttonFive.Text;
            double _doubleFive = Convert.ToDouble(_stringFive);
            textBox_Result.Text = textBox_Result.Text + _doubleFive;
        }

        private void Button_Click6(object sender, EventArgs e)
        {
            string _stringSix = buttonSix.Text;
            double _doubleSix = Convert.ToDouble(_stringSix);
            textBox_Result.Text = textBox_Result.Text + _doubleSix;
        }

        private void Button_Click7(object sender, EventArgs e)
        {
            string _stringSeven = buttonSeven.Text;
            double _doubleSeven = Convert.ToDouble(_stringSeven);
            textBox_Result.Text = textBox_Result.Text + _doubleSeven;
        }

        private void Button_Click8(object sender, EventArgs e)
        {
            string _stringEight = buttonEight.Text;
            double _doubleEight = Convert.ToDouble(_stringEight);
            textBox_Result.Text = textBox_Result.Text + _doubleEight;
        }

        private void Button_Click9(object sender, EventArgs e)
        {
            string _stringNine = buttonNine.Text;
            double _doubleNine = Convert.ToDouble(_stringNine);
            textBox_Result.Text = textBox_Result.Text + _doubleNine;
        }

        private void Button_Click0(object sender, EventArgs e)
        {
            string _stringNull = buttonNull.Text;
            double _doubleNull = Convert.ToDouble(_stringNull);
            textBox_Result.Text = textBox_Result.Text + _doubleNull;
        }

        private void Button_RemoveAll(object sender, EventArgs e)
        {
            string _stringNull = buttonNull.Text;
            double _doubleNull = Convert.ToDouble(_stringNull);
            textBox_Result.Text = textBox_Result.Text + _doubleNull;
        }

        private void ButtonRemoveAll(object sender, EventArgs e)
        {
            textBox_Result.Clear();
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            string _stringDot = button_dot.Text;
            char _charDot = Convert.ToChar(_stringDot);
            textBox_Result.Text = textBox_Result.Text + _charDot;
        }
    }
}
