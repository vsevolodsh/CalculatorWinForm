namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public double a, b;
        public int typeOfOperation = 0;
        public bool sign = true;

        #region Обработчики событий нажатий кнопок цифр
        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ',';
        }

        #endregion

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            typeOfOperation = 1;
            label1.Text = a.ToString() + " + ";
            textBox1.Clear();
            sign = true;
        }

        private void buttonSubstr_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            typeOfOperation = 2;
            label1.Text = a.ToString() + " - ";
            textBox1.Clear();
            sign = true;
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            typeOfOperation = 3;
            label1.Text = a.ToString() + " * ";
            textBox1.Clear();
            sign = true;
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            typeOfOperation = 4;
            label1.Text = a.ToString() + " / ";
            textBox1.Clear();
            sign = true;
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            double res = result();
            if (res is not double.NaN)
            {
                label1.Text += b.ToString() + " = ";
                textBox1.Text = res.ToString();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            a = b = typeOfOperation = 0;
            textBox1.Clear();
            label1.Text = "";
        }

        public double result()
        {
            switch (typeOfOperation)
            {
                case 1:
                    b = double.Parse(textBox1.Text);
                    return a + b;
                    break;
                case 2:
                    b = double.Parse(textBox1.Text);
                    return a - b;
                    break;
                case 3:
                    b = double.Parse(textBox1.Text);
                    return a * b;
                    break;
                case 4:
                    b = double.Parse(textBox1.Text);
                    return a / b;
                    break;
                default:
                    return double.NaN;
                    break;
            }

        }
    }
}