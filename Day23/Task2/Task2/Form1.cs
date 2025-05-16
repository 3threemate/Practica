using System.Windows.Forms.DataVisualization.Charting;
using System;
using System.Windows.Forms;


namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeChart();
        }

        private void InitializeChart()
        {
            chart1.ChartAreas.Add(new ChartArea("MainArea"));

            chart1.ChartAreas[0].AxisX.Title = "X";
            chart1.ChartAreas[0].AxisY.Title = "Y";
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;

            chart1.Series.Add(new Series("sin(x)"));
            chart1.Series["sin(x)"].ChartType = SeriesChartType.Line;
            chart1.Series["sin(x)"].Color = System.Drawing.Color.Blue;
            chart1.Series["sin(x)"].BorderWidth = 2;

            chart1.Series.Add(new Series("cos(x)"));
            chart1.Series["cos(x)"].ChartType = SeriesChartType.Line;
            chart1.Series["cos(x)"].Color = System.Drawing.Color.Red;
            chart1.Series["cos(x)"].BorderWidth = 2;
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            try
            {
                double Xmin = double.Parse(textBoxXmin.Text);
                double Xmax = double.Parse(textBoxXmax.Text);
                double Step = double.Parse(textBoxStep.Text);

                if (Xmin >= Xmax)
                {
                    MessageBox.Show("Xmin должен быть меньше Xmax", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (Step <= 0)
                {
                    MessageBox.Show("Шаг должен быть положительным числом", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int count = (int)Math.Ceiling((Xmax - Xmin) / Step) + 1;

                double[] x = new double[count];

                double[] y1 = new double[count]; 
                double[] y2 = new double[count]; 

                for (int i = 0; i < count; i++)
                {
                    x[i] = Xmin + Step * i;

                    y1[i] = Math.Sin(x[i]);
                    y2[i] = Math.Cos(x[i]);
                }

                chart1.ChartAreas[0].AxisX.Minimum = Xmin;
                chart1.ChartAreas[0].AxisX.Maximum = Xmax;

                chart1.ChartAreas[0].AxisX.MajorGrid.Interval = Step;

                chart1.Series["sin(x)"].Points.Clear();
                chart1.Series["cos(x)"].Points.Clear();


                chart1.Series["sin(x)"].Points.DataBindXY(x, y1);
                chart1.Series["cos(x)"].Points.DataBindXY(x, y2);
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}