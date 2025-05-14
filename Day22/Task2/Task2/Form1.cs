namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtX.Clear();
            txtY.Clear();
            txtResults.Clear();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtX.Text);
            double y = double.Parse(txtY.Text);

            double result1 = Math.Pow(Sh(x), 2) + Math.Pow(y, 2) + Math.Sin(y) - x + y;
            double result2 = Math.Pow(Sh(x) - y, 2) + Math.Cos(y);
            double result3 = Math.Pow(y - Sh(x), 2) + Math.Tan(y) - x + y;

            txtResults.Text = $"Результаты:\n" +
                              $"При X = {x}\n" +
                              $"При Y = {y}\n" +
                              $"Z1 = {result1}\n" +
                              $"Z2 = {result2}\n" +
                              $"Z3 = {result3}";
        }

        private double Sh(double x)
        {
            // Выберите одну из функций: 
            // return Math.Sinh(x); // Гиперболический синус
            // return Math.Pow(x, 2); // Квадрат
            return Math.Exp(x); // Экспонента
        }
    }
}
