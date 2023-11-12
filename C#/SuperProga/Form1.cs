namespace SuperProga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "бутон1";
            button1.BackColor = System.Drawing.Color.Chocolate;
            double d = 5.5;
            d = 505;
            button1.Text = d.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "ТЫК";
            int number1 = 1201;
            var number2 = 1201;
            string number3 = "1201";
            var number4 = "1201";
            double number5 = 1201.1201;
            var number6 = 1201.1201;
            // var - удобен, но может запутать тебя самого.


        }

        public void Method1()
        {

        }

        string Method2()
        {
            return "Good morning!";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = Method2();
            label1.BackColor = button1.BackColor;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = System.Drawing.Color.ForestGreen;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number = 26;
            // Конкатенация (Вспоминаем Python)
            string str = "Возраст" + ": ";
            string result = str + number;
            // Интерполяция
            result = $"Мне {number -5 +5}";
            button2.Text = result;
        }

        private void label1_MouseEnter_1(object sender, EventArgs e)
        {
            label1.ForeColor = System.Drawing.Color.ForestGreen;
        }
    }
}