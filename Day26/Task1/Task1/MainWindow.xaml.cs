using System;
using System.IO;
using System.Windows;
using System.Xml;
using Microsoft.Win32;

namespace StudentGroupXML
{
    public partial class MainWindow : Window
    {
        private XmlDocument xmlDoc;
        private string currentFilePath;

        public MainWindow()
        {
            InitializeComponent();
            xmlDoc = new XmlDocument();
            UpdateButtonStates();
        }

        private void UpdateButtonStates()
        {
            bool hasDocument = xmlDoc.DocumentElement != null;
            btnSave.IsEnabled = hasDocument;
            btnAddStudent.IsEnabled = hasDocument;
        }

        private void btnCreateNew_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                xmlDoc = new XmlDocument();
                XmlDeclaration xmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
                xmlDoc.AppendChild(xmlDeclaration);

                XmlElement rootElement = xmlDoc.CreateElement("StudentGroup");
                xmlDoc.AppendChild(rootElement);

                AddSampleStudents(rootElement);

                DisplayXmlContent();
                currentFilePath = null;
                txtStatus.Text = "Создан новый документ";
                UpdateButtonStates();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании файла: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AddSampleStudents(XmlElement rootElement)
        {
            string[] lastNames = { "Иванов", "Петров", "Сидоров", "Кузнецов", "Смирнов", "Васильев", "Попов" };
            string[] firstNames = { "Алексей", "Дмитрий", "Сергей", "Андрей", "Михаил", "Иван", "Николай" };
            DateTime[] birthDates = {
                new DateTime(2000, 1, 15),
                new DateTime(1999, 5, 22),
                new DateTime(2001, 3, 8),
                new DateTime(2000, 7, 30),
                new DateTime(1999, 11, 12),
                new DateTime(2001, 9, 5),
                new DateTime(2000, 12, 25)
            };

            for (int i = 0; i < 7; i++)
            {
                AddStudentToXml(rootElement, lastNames[i], firstNames[i], birthDates[i]);
            }
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*",
                    Title = "Выберите XML файл со студенческой группой"
                };

                if (openFileDialog.ShowDialog() == true)
                {
                    xmlDoc.Load(openFileDialog.FileName);
                    currentFilePath = openFileDialog.FileName;
                    DisplayXmlContent();
                    txtStatus.Text = $"Загружен файл: {Path.GetFileName(currentFilePath)}";
                    UpdateButtonStates();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (currentFilePath == null)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*",
                        Title = "Сохранить XML файл"
                    };

                    if (saveFileDialog.ShowDialog() == true)
                    {
                        currentFilePath = saveFileDialog.FileName;
                    }
                    else
                    {
                        return;
                    }
                }

                xmlDoc.Save(currentFilePath);
                txtStatus.Text = $"Файл сохранен: {Path.GetFileName(currentFilePath)}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtLastName.Text) || string.IsNullOrWhiteSpace(txtFirstName.Text))
                {
                    MessageBox.Show("Пожалуйста, введите фамилию и имя студента", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                if (dpBirthDate.SelectedDate == null)
                {
                    MessageBox.Show("Пожалуйста, выберите дату рождения", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                XmlElement rootElement = xmlDoc.DocumentElement;
                AddStudentToXml(rootElement, txtLastName.Text, txtFirstName.Text, dpBirthDate.SelectedDate.Value);

                txtLastName.Text = "";
                txtFirstName.Text = "";
                dpBirthDate.SelectedDate = null;

                DisplayXmlContent();
                txtStatus.Text = "Студент добавлен";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении студента: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AddStudentToXml(XmlElement rootElement, string lastName, string firstName, DateTime birthDate)
        {
            XmlElement studentElement = xmlDoc.CreateElement("Student");
            rootElement.AppendChild(studentElement);

            XmlElement lastNameElement = xmlDoc.CreateElement("LastName");
            lastNameElement.InnerText = lastName;
            studentElement.AppendChild(lastNameElement);

            XmlElement firstNameElement = xmlDoc.CreateElement("FirstName");
            firstNameElement.InnerText = firstName;
            studentElement.AppendChild(firstNameElement);

            XmlElement birthDateElement = xmlDoc.CreateElement("BirthDate");
            birthDateElement.InnerText = birthDate.ToString("yyyy-MM-dd");
            studentElement.AppendChild(birthDateElement);
        }

        private void DisplayXmlContent()
        {
            if (xmlDoc.DocumentElement == null)
            {
                txtOutput.Text = "Документ не загружен";
                return;
            }

            using (StringWriter sw = new StringWriter())
            {
                using (XmlTextWriter tx = new XmlTextWriter(sw))
                {
                    tx.Formatting = Formatting.Indented;
                    xmlDoc.WriteTo(tx);
                    txtOutput.Text = sw.ToString();
                }
            }
        }
    }
}   