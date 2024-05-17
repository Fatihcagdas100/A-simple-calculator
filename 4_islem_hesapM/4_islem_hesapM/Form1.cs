namespace _4_islem_hesapM
{
    public partial class Form1 : Form
    {
        string islem = "";
        double sayi1;
        double sayi2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button12_Click(object sender, EventArgs e)//   +
        {
            if (double.TryParse(textBox1.Text, out sayi1))
            {
                sayi1 = Convert.ToDouble(textBox1.Text);
                islem = "+";
                textBox1.Clear();
            }
            else
                textBox1.Text = "Geçersiz bir sayý girdiniz!";
            
        }

        private void button13_Click(object sender, EventArgs e)//   -
        {
            if (double.TryParse(textBox1.Text, out sayi1))
            {
                sayi1 = Convert.ToDouble(textBox1.Text);
                islem = "-";
                textBox1.Clear();
            }
            else
                textBox1.Text = "Geçersiz bir sayý girdiniz!";
        }

        private void button14_Click(object sender, EventArgs e)//   *
        {
            if (double.TryParse(textBox1.Text, out sayi1))
            {
                sayi1 = Convert.ToDouble(textBox1.Text);
                islem = "*";
                textBox1.Clear();
            }
            else
                textBox1.Text = "Geçersiz bir sayý girdiniz!";
        }

        private void button15_Click(object sender, EventArgs e)//   /
        {
            if (double.TryParse(textBox1.Text, out sayi1))
            {
                sayi1 = Convert.ToDouble(textBox1.Text);
                islem = "/";
                textBox1.Clear();
            }
            else
                textBox1.Text = "Geçersiz bir sayý girdiniz!";
        }

        private void button11_Click(object sender, EventArgs e)//   =
        {
            if(textBox1.Text != "")
            {
                sayi2 = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
            }

            if (sayi2 == 0) // 0 a bölünme hatasý
                textBox1.Text = "Belirsiz!";
            else
            {
                switch (islem)
                {
                    case "+":
                        double toplam = sayi1 + sayi2;
                        textBox1.Text = toplam.ToString();
                        break;
                    case "-":
                        double fark = sayi1 - sayi2;
                        textBox1.Text = fark.ToString();
                        break;
                    case "*":
                        double carpim = sayi1 * sayi2;
                        textBox1.Text = carpim.ToString();
                        break;
                    case "/":
                        double bolum = sayi1 / sayi2;
                        textBox1.Text = bolum.ToString();
                        break;
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
