using CalculatorLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorUI
{
    public partial class MainForm : Form
    {
        ICalculator _calc;
        public MainForm(ICalculator calc)
        {
            InitializeComponent();
            Application.Idle += Application_Idle;
            _calc = calc;
        }

        void Application_Idle(object sender, EventArgs e)
        {
            bool isEmptyNumbers = String.IsNullOrEmpty(tb_FirstNumber.Text) || String.IsNullOrEmpty(tb_SecondNumber.Text);
            btn_Substraction.Enabled = !isEmptyNumbers;
            btn_Addition.Enabled = !isEmptyNumbers;
            btn_Multiplication.Enabled = !isEmptyNumbers;
            btn_Division.Enabled = !isEmptyNumbers;
        }

        private void btn_Addition_Click(object sender, EventArgs e)
        {
            tb_Result.Text = _calc.Addition(Convert.ToInt32(tb_FirstNumber.Text),Convert.ToInt32(tb_SecondNumber.Text)).ToString();
        }

        private void btn_Substraction_Click(object sender, EventArgs e)
        {
            tb_Result.Text = _calc.Substraction(Convert.ToInt32(tb_FirstNumber.Text), Convert.ToInt32(tb_SecondNumber.Text)).ToString();
        }

        private void btn_Multiplication_Click(object sender, EventArgs e)
        {
            tb_Result.Text = _calc.Multiplication(Convert.ToInt32(tb_FirstNumber.Text), Convert.ToInt32(tb_SecondNumber.Text)).ToString();
        }

        private void btn_Division_Click(object sender, EventArgs e)
        {
            try
            {
                tb_Result.Text = _calc.Division(Convert.ToInt32(tb_FirstNumber.Text), Convert.ToInt32(tb_SecondNumber.Text)).ToString();
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
