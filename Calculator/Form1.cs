namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        double a, b;
        int typeOfOperation = 0;
        bool sign = true;

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

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + '+';
        }

        private void buttonSubstr_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '-';
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '*';
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '/';
        }
    }
}