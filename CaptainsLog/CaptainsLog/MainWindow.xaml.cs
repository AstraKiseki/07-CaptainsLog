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
using CaptainsLog.Core;
using System.Collections.ObjectModel;

namespace CaptainsLog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ObservableCollection<LogEntry> logEntries;

        public MainWindow()
        {
            InitializeComponent();
            logEntries = new ObservableCollection<LogEntry>();
            LogEntries.ItemsSource = logEntries;
        }

        private void AddEntry_Click(object sender, RoutedEventArgs e)
        {
            // your event handler, created for you by Visual Studio
            // instantiate an  instance of DetailWindow
            TextWindow detailWindow = new TextWindow();

            // it's not enough to instantiate, let's actually open the window.
            detailWindow.Show();

        }

        private void EditEntry_Click(object sender, RoutedEventArgs e)
        {
            // for editing entries
        }

        private void DeleteEntry_Click(object sender, RoutedEventArgs e)
        {
            // for deleting entries, need to figure out how to select an entry...

            Input 

        }

    }
    }


