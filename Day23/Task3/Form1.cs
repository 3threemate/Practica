namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Центр цветка
            using (SolidBrush centerBrush = new SolidBrush(Color.Yellow))
            {
                g.FillEllipse(centerBrush, 175, 175, 50, 50);
            }

            // Лепестки цветка
            using (SolidBrush petalBrush = new SolidBrush(Color.Pink))
            {
                g.FillEllipse(petalBrush, 175, 95, 50, 80); // Верхний лепесток
                g.FillEllipse(petalBrush, 175, 225, 50, 80); // Нижний лепесток
                g.FillEllipse(petalBrush, 95, 175, 80, 50); // Левый лепесток
                g.FillEllipse(petalBrush, 225, 175, 80, 50); // Правый лепесток
            }

            // Контур центра цветка
            using (Pen centerPen = new Pen(Color.Goldenrod, 2))
            {
                g.DrawEllipse(centerPen, 175, 175, 50, 50);
            }


        }


    }
}