namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            if (listBoxStrings.SelectedItem == null)
            {
                lblResult.Text = "Выберите текст из списка";
                return;
            }

            string selectedString = listBoxStrings.SelectedItem.ToString();
            int punctuationCount = CountPunctuationMarks(selectedString);

            lblResult.Text = $"Количество знаков препинаний: {punctuationCount}";
        }

        private int CountPunctuationMarks(string input)
        {
            char[] punctuationMarks = { '.', ',', ';', ':', '!', '?', '-', '(', ')', '[', ']', '{', '}', '"', '\'' };

            return input.Count(c => punctuationMarks.Contains(c));
        }
    }
}
