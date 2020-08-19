/*
 * Landon Buell
 * Multibody Simulation
 * Main Window
 * 18 August 2020
 */

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

namespace MultibodySimulation
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

        private void btnMenuEditSystem_Click(object sender, RoutedEventArgs e)
        {
            // Open "Edit System" Page

        }

        private void btnMenuSystemDetails_Click(object sender, RoutedEventArgs e)
        {
            // Open "System Details" Page
        }

        private void btnMenuUnitSystems_Click(object sender, RoutedEventArgs e)
        {
            // Open "Unit Systems Menu" page
        }

        private void btnMenuSaveSystem_Click(object sender, RoutedEventArgs e)
        {
            // Open "Save System Menu" page 
        }

        private void btnMenuLoadSystem_Click(object sender, RoutedEventArgs e)
        {
            // Open "Load System Menu" page 
        }

        private void MoveSelector (object btnMenu)
        {
            // Move "movable selector" to Button
            

        }

        
    }
}
