using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _2109hw
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
        List<ResumeObject> resumeList = new();


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            //ResumeObject resume = new();

            //resume.AboutMe = "about";
            //resume.Skills = "skills";
            //resume.Contacts = "contacts";
            //resume.Languages = "languages";
            //resume.City = "city";
            //resume.Education = "education";
            //resume.Occupation = "occupation";
            //resume.Experience = "experience";
            //resume.Name = "name";
            //resume.GitHub = "github";
            //resume.LinkedIn = "linkedIn";

            //resumeList.Add(resume);

            //var resumeJson = JsonSerializer.Serialize<List<ResumeObject>>(resumeList);

            //using (StreamWriter sw = new StreamWriter("ResumeArray.json"))
            //{
            //    sw.Write(resumeJson);
            //}

            using (var sr = new StreamReader("ResumeArray.json"))
            {
                resumeList = JsonSerializer.Deserialize<List<ResumeObject>>(sr.ReadToEnd());
            }

            ResumeObjects.ItemsSource = resumeList;



        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ResumeObject resume = new();

            resume.Name = TextAboutMe.Text;
            resume.Skills = TextSkills.Text;
            resume.Contacts = TextContacts.Text;
            resume.Languages = TextLanguages.Text;
            resume.City = TextCity.Text;
            resume.Education = TextEducation.Text;
            resume.Occupation = TextOccupation.Text;
            resume.Experience = TextExperience.Text;
            resume.Name = TextName.Text;
            resume.GitHub = TextGitHub.Text;
            resume.LinkedIn = TextLinkedIn.Text;
            resume.PhotoPath = TextPhoto.Text;

            resumeList.Add(resume);

            var resumeJson = JsonSerializer.Serialize<List<ResumeObject>>(resumeList);

            using (StreamWriter sw = new StreamWriter("ResumeArray.json"))
            {
                sw.Write(resumeJson);
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var selectedItem = ResumeObjects.SelectedItem as ResumeObject;
            if (selectedItem is not null)
            {
                new ResumeWindow(selectedItem).Show();
            }
            else
            {
                MessageBox.Show("Select item");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new();
            openFileDialog.ShowDialog();
            TextPhoto.Text = openFileDialog.FileName;

        }













    }
}
