namespace lab01
{
    public partial class Form1 : Form
    {
        double input1 = 0;
        string all = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string number1 = this.num1.Text;
            string number2 = this.num2.Text;

            double dnumber1 = 0.0;
            double dnumber2 = 0.0;
            //Convert string to double
            dnumber1 = Double.Parse(number1);
            dnumber2 = Double.Parse(number2);
            //Convert double to string for display
            double result = (dnumber1 + dnumber2);
            this.answer.Text = result.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.n_input.Text = this.n_input.Text + "3";
            this.n_input2.Text = this.n_input2.Text + "3";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.n_input.Text = this.n_input.Text + "0";
            this.n_input2.Text = this.n_input2.Text + "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.n_input.Text = this.n_input.Text + "1";
            this.n_input2.Text = this.n_input2.Text + "1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.n_input.Text = this.n_input.Text + "2";
            this.n_input2.Text = this.n_input2.Text + "2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.n_input.Text = this.n_input.Text + "4";
            this.n_input2.Text = this.n_input2.Text + "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.n_input.Text = this.n_input.Text + "5";
            this.n_input2.Text = this.n_input2.Text + "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.n_input.Text = this.n_input.Text + "6";
            this.n_input2.Text = this.n_input2.Text + "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.n_input.Text = this.n_input.Text + "7";
            this.n_input2.Text = this.n_input2.Text + "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.n_input.Text = this.n_input.Text + "8";
            this.n_input2.Text = this.n_input2.Text + "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.n_input.Text = this.n_input.Text + "9";
            this.n_input2.Text = this.n_input2.Text + "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.input1 = double.Parse(this.n_input.Text);
            this.n_input.Text = "";
            this.all = "+";

            this.n_input2.Text = this.n_input2.Text + " + ";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.input1 = double.Parse(this.n_input.Text);
            this.n_input.Text = "";
            this.all = "-";

            this.n_input2.Text = this.n_input2.Text + " - ";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.input1 = double.Parse(this.n_input.Text);
            this.n_input.Text = "";
            this.all = "*";

            this.n_input2.Text = this.n_input2.Text + " x ";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.input1 = double.Parse(this.n_input.Text);
            this.n_input.Text = "";
            this.all = "/";

            this.n_input2.Text = this.n_input2.Text + " / ";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double input2 = double.Parse(this.n_input.Text);
            double result = 0;
            if (this.all == "+")
            {
                result = input1 + input2;
            }
            else if (this.all == "-")
            {
                result = input1 - input2;
            }
            else if (this.all == "*")
            {
                result = input1 * input2;
            }
            else if (this.all == "/")
            {
                result = input1 / input2;
            }
            this.n_input.Text = result.ToString("N0");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.n_input.Text = this.n_input.Text + ".";
            this.n_input2.Text = this.n_input2.Text + ".";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.n_input.Text = "";
            this.n_input2.Text = "";
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }
    }
}