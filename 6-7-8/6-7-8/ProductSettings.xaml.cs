using _6_7_8.Models;
using _6_7_8.VM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Resources;

namespace _6_7_8
{
    /// <summary>
    /// Логика взаимодействия для ProductSettings.xaml
    /// </summary>
    public partial class ProductSettings : Window
    {
        Product selectedElement = null;
        List<Product> list;
        ObservableCollection<Product> obs = new ObservableCollection<Product>();
        public ProductSettings()
        {
            InitializeComponent();
            list = MainWindow.productsController.list;
            foreach (Product el in list)
            {
                obs.Add(el);
            }

            listBox.ItemsSource = obs;
            DataContext = new ViewModelBase(obs);
            obs.CollectionChanged += (sender, args) =>
            {
                DeleteElementButton.IsEnabled = false;
                EditElementButton.IsEnabled = false;
            };
            StreamResourceInfo sri = Application.GetResourceStream(
            new Uri("Pictures/rock.cur", UriKind.Relative));
            Cursor customCursor = new Cursor(sri.Stream);
            this.Cursor = customCursor;
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                selectedElement = (Product)listBox.SelectedItem;

                EditElementButton.IsEnabled = true;
                DeleteElementButton.IsEnabled = true;
            }
        }
    }
}
