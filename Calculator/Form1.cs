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
        double _firstOperand;
        double _secondOperand;
        String _operationPerformed = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox_Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            string _stringDot = button_dot.Text;
            char _charDot = Convert.ToChar(_stringDot);
            textBox_Result.Text = textBox_Result.Text + _charDot;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0")
            {
                textBox_Result.Clear();
                Button_Active(sender, e);
            }
            else Button_Active(sender, e);
        }

        public void Button_Active(object sender, EventArgs e)
        {
            Button _button = (Button)sender;
            string _stringClick = _button.Text;
            Double _doubleClick = Convert.ToDouble(_stringClick);
            textBox_Result.Text = textBox_Result.Text + _doubleClick;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button _button = (Button)sender;
            _operationPerformed = _button.Text;
            label2.Text = textBox_Result.Text;
            label1.Text = _operationPerformed;
            textBox_Result.Text = "0";
        }

        private void ButtonRemoveAll(object sender, EventArgs e)
        {
            textBox_Result.Clear();
            textBox_Result.Text = "0";
            
        }

        private void ButtonRemoveRow(object sender, EventArgs e)
        {
            textBox_Result.Clear();
            textBox_Result.Text = "0";
        }

        private void Operation_Equels(object sender, EventArgs e)
        {
            _firstOperand = Convert.ToDouble(label2.Text);
            _secondOperand = Convert.ToDouble(textBox_Result.Text);

            switch (_operationPerformed)
            {
                case "+":
                    textBox_Result.Text = (_firstOperand + _secondOperand).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (_firstOperand - _secondOperand).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (_firstOperand * _secondOperand).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (_firstOperand / _secondOperand).ToString();
                    break;  
            }
        }
    }
}
