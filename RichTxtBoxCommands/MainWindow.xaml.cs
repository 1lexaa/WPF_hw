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

namespace RichTxtBoxCommands
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
        private void RedColor(object sender, ExecutedRoutedEventArgs e)
        {
            if (!RTB.Selection.IsEmpty)
            {
                RTB.Selection.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Red);
            }
        }

        private void GreenColor(object sender, ExecutedRoutedEventArgs e)
        {
            if (!RTB.Selection.IsEmpty)
            {
                RTB.Selection.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Green);
            }
        }

        private void BlueColor(object sender, ExecutedRoutedEventArgs e)
        {
            if (!RTB.Selection.IsEmpty)
            {
                RTB.Selection.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Blue);
            }
        }

        private void Bold(object sender, ExecutedRoutedEventArgs e)
        {
            if (!RTB.Selection.IsEmpty)
            {
                RTB.Selection.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Bold);
            }
        }

        private void Italic(object sender, ExecutedRoutedEventArgs e)
        {
            if (!RTB.Selection.IsEmpty)
            {
                RTB.Selection.ApplyPropertyValue(TextElement.FontStyleProperty, FontStyles.Italic);
            }
        }

        private void Underline(object sender, ExecutedRoutedEventArgs e)
        {
            if (!RTB.Selection.IsEmpty)
            {
                RTB.Selection.ApplyPropertyValue(TextDecoration.PenProperty, TextDecorations.Underline);
            }
        }

        private void Clear(object sender, ExecutedRoutedEventArgs e)
        {
            if (!RTB.Selection.IsEmpty)
            {
                RTB.Selection.Text = "";
            }
        }

        private void Font15(object sender, ExecutedRoutedEventArgs e)
        {
            if (!RTB.Selection.IsEmpty)
            {
                RTB.Selection.ApplyPropertyValue(TextElement.FontSizeProperty, 15.0);
            }
        }

        private void Font30(object sender, ExecutedRoutedEventArgs e)
        {
            if (!RTB.Selection.IsEmpty)
            {
                RTB.Selection.ApplyPropertyValue(TextElement.FontSizeProperty, 30.0);
            }
        }
    }


    public static class RTBCommands
    {
        static RTBCommands()
        {
            bold = new RoutedCommand("bold", typeof(RTBCommands));
            italic = new RoutedCommand("italic", typeof(RTBCommands));
            underline = new RoutedCommand("underline", typeof(RTBCommands));
            clear = new RoutedCommand("clear", typeof(RTBCommands));
            font15 = new RoutedCommand("font15", typeof(RTBCommands));
            font30 = new RoutedCommand("font30", typeof(RTBCommands));
            RedColor = new RoutedCommand("RedColor", typeof(RTBCommands));
            GreenColor = new RoutedCommand("GreenColor", typeof(RTBCommands));
            BlueColor = new RoutedCommand("BlueColor", typeof(RTBCommands));
        }
        public static RoutedCommand bold { get; set; }
        public static RoutedCommand italic { get; set; }
        public static RoutedCommand underline { get; set; }
        public static RoutedCommand clear { get; set; }
        public static RoutedCommand font15 { get; set; }
        public static RoutedCommand font30 { get; set; }
        public static RoutedCommand RedColor { get; set; }
        public static RoutedCommand GreenColor { get; set; }
        public static RoutedCommand BlueColor { get; set; }
    }
}

