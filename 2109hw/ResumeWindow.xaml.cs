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
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _2109hw
{
    /// <summary>
    /// Interaction logic for ResumeWindow.xaml
    /// </summary>
    public partial class ResumeWindow : Window
    {
        private ResumeObject resume;

        public ResumeWindow(ResumeObject resume)
        {
            this.resume = resume;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            BlockName.Text = resume.Name;
            BlockOccupation.Text = resume.Occupation;
            BlockCity.Text = resume.City;
            BlockContacts.Text = resume.Contacts;
            BlockLanguages.Text = resume.Languages;
            BlockSkills.Text = resume.Skills;
            BlockAboutMe.Text = resume.AboutMe;
            BlockEducation.Text = resume.Education;
            BlockExperience.Text = resume.Experience;
            BlockGitHub.Text = resume.GitHub;
            BlockLinkedIn.Text = resume.LinkedIn;
            Bitmap bitmap = new Bitmap(resume.PhotoPath);
            ImageSource imageSource = Imaging.CreateBitmapSourceFromHBitmap(
                bitmap.GetHbitmap(),
                IntPtr.Zero,
                Int32Rect.Empty,
                BitmapSizeOptions.FromEmptyOptions());
            Image.Source = imageSource;
        }
    }
}
