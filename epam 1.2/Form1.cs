using System;
using System.Windows.Forms;
using Deveel.Math;

namespace epam_1._2
{
	public partial class Form1 : Form
	{
		public string operators;
		public string number1;
		public bool number2;

		public Form1()
		{
			InitializeComponent();
		}
		
		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(Char.IsDigit(e.KeyChar)))
			{
				if (e.KeyChar != (char)Keys.Back)
				{
					e.Handled = true;
				}
			}
		}

		// number
		private void button17_Click(object sender, EventArgs e)
		{
			if (number2)
			{
				number2 = false;
				textBox1.Text = "0";
			}

			Button number = (Button)sender;
			if (textBox1.Text == "0")
				textBox1.Text = number.Text;
			else
				textBox1.Text = textBox1.Text + number.Text;
		}

		//clean
		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
		}

		//operators "+, -, *, /"
		private void button4_Click(object sender, EventArgs e)
		{
			Button sign = (Button)sender;
			operators = sign.Text;
			number1 = textBox1.Text;
			number2 = true;

			if (number2)
			{
				number2 = false;
				textBox1.Text = "";
			}
		}

		//operators "="
		private void button19_Click(object sender, EventArgs e)
		{
			
			BigDecimal action1, action2, result = 0;
			action1 = BigDecimal.Parse(number1);
			action2 = BigDecimal.Parse(textBox1.Text);
			if (operators == "+")
				result = action1 + action2;
			if (operators == "-")
				result = action1 - action2;
			if (operators == "*")
				result = action1 * action2;
			if (operators == "/")
				result = action1 / action2;

			operators = "=";
			number2 = true;
			textBox1.Text = result.ToString();
		}

		//point
		private void button18_Click(object sender, EventArgs e)
		{
			if (!textBox1.Text.Contains("."))
				textBox1.Text = textBox1.Text + ".";
		}

		//backspace
		private void button2_Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
		}
	}
}
