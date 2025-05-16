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

            // ����� ������
            using (SolidBrush centerBrush = new SolidBrush(Color.Yellow))
            {
                g.FillEllipse(centerBrush, 175, 175, 50, 50);
            }

            // �������� ������
            using (SolidBrush petalBrush = new SolidBrush(Color.Pink))
            {
                g.FillEllipse(petalBrush, 175, 95, 50, 80); // ������� ��������
                g.FillEllipse(petalBrush, 175, 225, 50, 80); // ������ ��������
                g.FillEllipse(petalBrush, 95, 175, 80, 50); // ����� ��������
                g.FillEllipse(petalBrush, 225, 175, 80, 50); // ������ ��������
            }

            // ������ ������ ������
            using (Pen centerPen = new Pen(Color.Goldenrod, 2))
            {
                g.DrawEllipse(centerPen, 175, 175, 50, 50);
            }


        }


    }
}