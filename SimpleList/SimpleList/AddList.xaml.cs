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

namespace SimpleList
{
    /// <summary>
    /// Interaction logic for AddList.xaml
    /// </summary>
    public partial class AddList : Window
    {
        public AddList()
        {
            InitializeComponent();
           
        }

        
        // declare HashSet to prevent duplications
        HashSet<string> partyN = new HashSet<string>();
       
        // return the user to the MainWindow
        private void GoHome_Click(object sender, RoutedEventArgs e)
        {
           
            this.Hide();
            MainWindow form1 = new MainWindow();
            form1.ShowDialog();
        }

        // add names
        private void AddPerson_Click_1(object sender, RoutedEventArgs e)
        {

            // prevent empty input from being added to HashSet 
            if (String.IsNullOrEmpty(this.addName.Text))
            {
                MessageBox.Show("Empty input! Please try again."); 
            }
            else
            {
                partyN.Add(addName.Text);   // add name to HashSet
                addName.Clear(); // clear text box
            }
            
            }

        // show names
        private void ShowPeople_Click(object sender, RoutedEventArgs e)
        {
            List<string> allNames = partyN.ToList<string>(); // convert HashSet index to List to display properly
         
            // display the names in listBox
            for (int i = 0; i < allNames.Count; i++)
            {
                myNames.Items.Add(allNames.ElementAt(i));
            }
        }

        
        private void ResetList_Click(object sender, RoutedEventArgs e)
        {
            myNames.Items.Clear(); // clears the display of the list
        }

        private void RemoveLastG_Click(object sender, RoutedEventArgs e)
        {
            partyN.Clear(); // clear data from HashSet
            myNames.Items.Clear(); // clear display of the list
        }
    }

       
    }

