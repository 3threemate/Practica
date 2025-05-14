using System.Globalization;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void X_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {

            try
            {
                double x = double.Parse(textBoxX.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
                double y = double.Parse(textBoxY.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
                double z = double.Parse(textBoxZ.Text.Replace(',', '.'), CultureInfo.InvariantCulture);

                double part1 = Math.Abs(Math.Cos(x) - Math.Cos(y));
                double exponent = 1 + 2 * Math.Pow(Math.Sin(y), 2);
                double power = Math.Pow(part1, exponent);

                double poly = 1 + z + (Math.Pow(z, 2) / 2) + (Math.Pow(z, 3) / 3) + (Math.Pow(z, 4) / 4);
                double w = power * poly;

                string result = "Практика день 22 Почебыт\r\n";
                result += $"X = {x}\r\n";
                result += $"Y = {y}\r\n";
                result += $"Z = {z}\r\n";
                result += $"Результат U = {w}";

                textBoxResult.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода данных: " + ex.Message);
            
        }

        }

        private void textBoxX_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
