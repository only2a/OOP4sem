using _6_7_8.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _6_7_8
{
    /// <summary>
    /// Логика взаимодействия для EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        private Product newElement = null;
        private string imgPath = "";

        public Product GetData()
        {
            return newElement;
        }
        public EditWindow(Product editel=null)
        {
            InitializeComponent();

            if (editel != null)
            {
                newElement = editel;
                this.Title = "Edit panel";

                SetInformationOfEditedElem();
            }
        }

        private void SetInformationOfEditedElem()
        {
            ProductName.Text = newElement.shortName;
            ProductType.Text = newElement.typeOfProduct;

            foreach(RadioButton el in ScreenSize.Items)
            {
                if (el.Content.ToString() == newElement.screenSize)
                {
                    el.IsChecked = true;
                }
            }

            ScreenType.Text = newElement.screenType;

            foreach (RadioButton el in CPU.Items)
            {
                if (el.Content.ToString() == newElement.cpu)
                {
                    el.IsChecked = true;
                }
            }
            sliderValue.Content = newElement.RAM;
            graphicsCard.Text = newElement.graphicsCardModel;
            foreach (CheckBox el in storage.Items)
            {
                foreach (var el2 in newElement.storageCapacity)
                {
                    if (el.Content.ToString() == el2)
                    {
                        el.IsChecked = true;
                    }
                }
            }
            NumberOfSIM.Text = newElement.numberOfSIM;
            OS.Text = newElement.operatingSystem;
            CamRes.Text = newElement.cameraResolutions;
            imgPath = newElement.imgPath;
            price.Text = newElement.price;
            discription.Text = newElement.discription;
            
        }

        private void sldr_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider s = (Slider)sender;
            sliderValue.Content = Math.Round(s.Value);
            sliderValue.Content += "ГБ";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Add_btn_Click(object sender, RoutedEventArgs e)
        {
            Params.shortName = ProductName.Text;
            Params.typeOfProduct = ProductType.Text;
            foreach (var el in ScreenSize.Items)
            {
                RadioButton p = (RadioButton)el;
                if (p.IsChecked == true) Params.screenSize = p.Content.ToString();
            }

            Params.screenType = ScreenType.Text;

            foreach (var el in CPU.Items)
            {
                RadioButton p = (RadioButton)el;
                if (p.IsChecked == true) Params.cpu = p.Content.ToString();
            }
            Params.RAM = Math.Round(sldr.Value).ToString();
            Params.graphicsCardModel = graphicsCard.Text;

            foreach (var el in storage.Items)
            {
                CheckBox p = (CheckBox)el;
                if (p.IsChecked == true) Params.storageCapacity.Add(p.Content.ToString());
            }
            Params.discription = discription.Text;
            Params.price = price.Text;
            Params.numberOfSIM = NumberOfSIM.Text;
            Params.cameraResolutions = CamRes.Text;
            Params.operatingSystem = OS.Text;
            Params.imgstr = imgPath;
            MessageBox.Show("Товар добавлен", "Добавление");


            Product product = new Product();
            if (ProductType.Text == "Ноутбук" || ProductType.Text == "Laptop")
            {
                Product p = new Product(Params.typeOfProduct, Params.shortName, Params.screenSize, Params.screenType, Params.cpu, Params.RAM, Params.graphicsCardModel, Params.storageCapacity, Params.discription, Params.price, Params.imgstr);
                product = p;
            }
            else if (ProductType.Text == "Мобильный телефон" || ProductType.Text == "Smartphone")
            {
                Product p = new Product(Params.typeOfProduct, Params.shortName, Params.screenSize, Params.screenType, Params.numberOfSIM, Params.operatingSystem, Params.cameraResolutions, Params.cpu, Params.RAM, Params.storageCapacity, Params.discription, Params.price, Params.imgstr);
                product = p;
            }
            //ProductsController productsController = new ProductsController();
            newElement = product;



            this.Close();
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            if (Regex.IsMatch(filename, $".jpg|.jfif|.jpg|.png"))
            {

                imgPath = filename;
            }
            else
            {
                MessageBox.Show("Неверный формат файла!");
            }
        }
    }
}
