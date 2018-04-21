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

namespace SimpleList
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

        // exit program
        private void CloseMe_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }
        // override to shutdown program
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }

        // start list
        private void MakeGList_Click(object sender, RoutedEventArgs e)
        {
            this.Hide(); // hide MainWindow
            AddList form2 = new AddList();
            form2.ShowDialog(); // direct user to AddList form

        }

      
    }
}
