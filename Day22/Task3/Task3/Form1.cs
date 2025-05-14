using System.Text;

namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double x0 = double.Parse(textBoxX0.Text);
            double xk = double.Parse(textBoxXk.Text);
            double dx = double.Parse(textBoxDx.Text);
            double a = double.Parse(textBoxA.Text);
            double b = double.Parse(textBoxB.Text);

            StringBuilder results = new StringBuilder();
            results.AppendLine("x\t\ty(x)");

            for (double x = x0; x <= xk; x += dx)
            {
                double y = Math.Pow(10, 1) * a * Math.Pow(x, 3) * Math.Tan(a - b * x);
                results.AppendLine($"{x:F2}\t{y:F10}");
            }

            textBoxResults.Text = results.ToString();
        }
    }
}
