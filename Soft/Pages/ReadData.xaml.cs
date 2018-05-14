using Archetypes;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows;
using Data;

namespace Soft
{
    /// <summary>
    /// Interaction logic for ReadData.xaml
    /// </summary>
    public partial class ReadData : Page
    {
        public static List<Property> Locks { get; set; } = Data.Read.Technical.Locks.GetAll();
        public static List<Property> Handednesses { get; set; } = Data.Read.Technical.Handednesses.GetAll();
        public ReadData()
        {
            InitializeComponent();
        }

        private void ReadDataButton_Click(object sender, RoutedEventArgs e)
        {
            overallDataGrid.ItemsSource = Data.Read.Orders.Doors.GetAllByProjId(ProjIdTextBox.Text);
        }
    }
}
