using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace Ćwiczenie_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        ObservableCollection<Items> boxes = new ObservableCollection<Items>

        {
            new Items() { Status = "Progres", IsChecked = true,  Waga = 50}
        };

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = boxes;
            StatusListSection.DataContext = boxes;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int statusWeight = Int32.Parse(StatusWeightText.Text);
            if (statusWeight < 0)
            {
                statusWeight = 0;
            }
            if (statusWeight > 100)
            {
                statusWeight = 100;
            }
            string isActive = (bool)IsActiveChkBox.IsChecked ? "On" : "Off";
            boxes.Add(new Items() { Status = StatusNameText.Text, IsChecked = IsActive, Waga = statusWeight });
        }

    }
}

