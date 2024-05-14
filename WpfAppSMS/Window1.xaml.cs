using SMSLibrary.Models;
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
using System.Windows.Shapes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WpfAppSMS
{
    public partial class Window1 : Window
    {
        private readonly SmsContext dbContext;

        public Window1(string username)
        {
            InitializeComponent();
            dbContext = new SmsContext();
            PopulateUserData(username);
            PopulateEnrolledCourses();
            var student = dbContext.Students.Find(username);
            PopulateCoursesData();
        }

        private void PopulateUserData(string username)
        {
            var user = dbContext.Students.FirstOrDefault(u => u.StudentId == username);
            if (user != null)
            {
                studentIdBlc.Text = user.StudentId;
                firstNameBlc.Text = user.FirstName;
                lastNameBlc.Text = user.LastName;
                programBlc.Text = user.Program;
            }
            else
            {
                MessageBox.Show("User not found!");
            }
        }
        private void PopulateCoursesData()
        {
            var courses = dbContext.Courses.ToList();
            dataGridCourses.ItemsSource = courses;
        }
        private void enrollBtn_Click(object sender, RoutedEventArgs e)
        {
            var selectedCourse = dataGridCourses.SelectedItem as Course;

            if (selectedCourse != null)
            {
                string studentId = studentIdBlc.Text;

                var existingStudent = dbContext.Students.FirstOrDefault(s => s.StudentId == studentId);

                var existingCourse = dbContext.Courses.FirstOrDefault(c => c.CourseCode == selectedCourse.CourseCode);

                existingStudent.CourseCodes.Add(existingCourse);
                dbContext.SaveChanges();
                MessageBox.Show("Course enrolled successfully!");
                PopulateEnrolledCourses();
            }
        }
        private void PopulateEnrolledCourses()
        {
            string studentId = studentIdBlc.Text;
            var student = dbContext.Students.FirstOrDefault(s => s.StudentId == studentId);

            if (student != null)
            {
                foreach (var course in student.CourseCodes)
                {
                    var courseCode = course.CourseCode;
                    var courseTitle = dbContext.Courses.FirstOrDefault(c => c.CourseCode == courseCode)?.CourseTitle;

                    listBoxCourses.Items.Add($"{courseCode}-{courseTitle}");
                }
            }
        }
    }
}
