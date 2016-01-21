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
using CaptainsLog.Core;


namespace CaptainsLog
{
    /// <summary>
    /// Interaction logic for TextWindow.xaml
    /// </summary>
    public partial class TextWindow : Window
    {

        public TextWindow()
        {
            InitializeComponent();
            // collect the input from the user
            // validate the info (did they add enough text)
            // add to grid

        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string text = textBox.Text;

            LogEntry log = new LogEntry();
            string title = Title.Text;

            log.Id = MainWindow.logEntries.Count + 1;
            log.Title = title;
            log.Text = text;
            log.EntryDate = DateTime.Now;

           MainWindow.logEntries.Add(log);
            Close();
        }
    }
}

