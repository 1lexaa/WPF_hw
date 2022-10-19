using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace MVVM_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            examination = true;

        }

        bool examination = false;

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (examination)
                Rectangle_Panel.Fill = new SolidColorBrush(Color.FromArgb((byte)VMColor.Color_A, (byte)VMColor.Color_R, (byte)VMColor.Color_G, (byte)VMColor.Color_B));
        }
    }


    public class ColorsPalette
    {
        public int A { get; set; }
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
    }


    public class ColorsPaletteIVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private ColorsPalette? _colors;

        public ColorsPaletteIVM()
        {
            _colors = new ColorsPalette { A = 100, R = 18, G = 300, B = 245 };
        }

        public int Color_A
        {
            get { return _colors!.A; }
            set
            {
                _colors!.A = value;
                OnPropertyChanged("Color_A");
            }
        }
        public int Color_R
        {
            get { return _colors!.R; }
            set
            {
                _colors!.R = value;
                OnPropertyChanged("Color_R");
            }
        }
        public int Color_G
        {
            get { return _colors!.G; }
            set
            {
                _colors!.G = value;
                OnPropertyChanged("Color_G");
            }
        }
        public int Color_B
        {
            get { return _colors!.B; }
            set
            {
                _colors!.B = value;
                OnPropertyChanged("Color_B");
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                this.PropertyChanged(this, e);
            }
        }
    }
}

