using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ConsoleApp1; // Assuming this namespace contains the Student class and StudentList class


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string value = "";
            List<Student> studentList = StudentList.Students(); // Students is a static method that returns a list of students from the StudentList class
            foreach (Student student in studentList)
            {
                value = value + student.ToString() + "\n";
            }
            TextBox1.Text = value;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                int StudentId = Int32.Parse(StudentID.Text);   // Parse the student ID from the TextBox
                List<Student> studentList = StudentList.Students(); // Students is a static method that returns a list of students from the StudentList class

                bool found = false;
                foreach (Student student in studentList)
                {
                    if (student.Id == StudentId) // Check if the ID matches
                    {
                        StudentID.Text = student.Id.ToString(); // Display the student's information, ToString() is used to convert the integer ID to a string
                        StudentName.Text = student.Name;
                        StudentUni.Text = student.University;
                        found = true;
                    }
                }
                if (!found)
                {
                    MessageBox.Show("Student not found");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Please enter a valid student ID");
                MessageBox.Show(exception.Message);
            }
        }



        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
    
}
