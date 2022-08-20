using _6_7_8.Controllers;
using _6_7_8.CustomControlElem;
using _6_7_8.Models;
using _6_7_8.Patterns;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Resources;

namespace _6_7_8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ProductsController productsController = new ProductsController();
        public static string IMGPATH = "";
        private List<Product> searchList = new List<Product>();
        public MainWindow()
        {
            InitializeComponent();

            App.LanguageChanged += LanguageChanged;

            CultureInfo currLang = App.Language;

            //Заполняем меню смены языка:
            menuLanguage.Items.Clear();
            foreach (var lang in App.Languages)
            {
                MenuItem menuLang = new MenuItem();
                menuLang.Header = lang.DisplayName;
                menuLang.Tag = lang;
                menuLang.IsChecked = lang.Equals(currLang);
                menuLang.Click += ChangeLanguageClick;
                menuLang.IsChecked = false;
                menuLanguage.Items.Add(menuLang);
            }

            List<string> styles = new List<string> { "light", "dark" };
            // Style.Background = new SolidColorBrush(Colors.Black);
            Style.SelectionChanged += ThemeChange;
            Style.ItemsSource = styles;
            Style.SelectedItem = "light";



            StreamResourceInfo sri = Application.GetResourceStream(
             new Uri("Pictures/rock.cur", UriKind.Relative));
            Cursor customCursor = new Cursor(sri.Stream);
            this.Cursor = customCursor;
        }
        private void ThemeChange(object sender, SelectionChangedEventArgs e)
        {
            string style = Style.SelectedItem as string;
            // определяем путь к файлу ресурсов
            var uri = new Uri("Themes/" + style + ".xaml", UriKind.Relative);
            // загружаем словарь ресурсов
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            // очищаем коллекцию ресурсов приложения
            Application.Current.Resources.Clear();
            // добавляем загруженный словарь ресурсов
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }

        private void LanguageChanged(Object sender, EventArgs e)
        {
            CultureInfo currLang = App.Language;

            //Отмечаем нужный пункт смены языка как выбранный язык
            foreach (MenuItem i in menuLanguage.Items)
            {
                CultureInfo ci = i.Tag as CultureInfo;
                i.IsChecked = ci != null && ci.Equals(currLang);
            }
        }


        private void ChangeLanguageClick(Object sender, EventArgs e)
        {
            MenuItem mi = sender as MenuItem;
            if (mi != null)
            {
                CultureInfo lang = mi.Tag as CultureInfo;
                if (lang != null)
                {
                    App.Language = lang;
                }
            }
        }

        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {
            // Set tooltip visibility

            if (Tg_Btn.IsChecked == true)
            {
                tt_home.Visibility = Visibility.Collapsed;
                tt_contacts.Visibility = Visibility.Collapsed;
                tt_messages.Visibility = Visibility.Collapsed;
                tt_settings.Visibility = Visibility.Collapsed;
                tt_signout2.Visibility = Visibility.Collapsed;
            }
            else
            {
                tt_home.Visibility = Visibility.Visible;
                tt_contacts.Visibility = Visibility.Visible;
                tt_messages.Visibility = Visibility.Visible;
                tt_settings.Visibility = Visibility.Visible;
                tt_signout2.Visibility = Visibility.Visible;
            }
        }

        private void Tg_Btn_Unchecked(object sender, RoutedEventArgs e)
        {
            //img_bg.Opacity = 1;
            //Add.Opacity = 1;
            //Logo.Opacity = 1;
            //ProductList.Opacity = 1;
        }

        private void Tg_Btn_Checked(object sender, RoutedEventArgs e)
        {
            //img_bg.Opacity = 0.3;
            //Add.Opacity = 0.3;
            //Logo.Opacity = 0.3;
            //ProductList.Opacity = 0.3;
        }

        private void BG_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Tg_Btn.IsChecked = false;
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CustomCE.Visibility = Visibility.Visible;
            Authorization authorization = new Authorization();
            authorization.ShowDialog();
            if(Authorization.IsAdmin)
            {
                AdminElem0.Visibility = Visibility.Visible;
                AdminElem1.Visibility = Visibility.Visible;
            }

            FileInfo fileInf = new FileInfo(@"D:\2SEM\OOP\Labs\6-7-8\6-7-8\bin\Debug\products.json");
            if (fileInf.Length != 0) productsController.GetProducts();

            listBoxBasket.ItemsSource = Authorization.CurrentUser.boughtProducts;

            

        }


        private void CustomCE_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CustomCE.ChangeVisibility();
        }

        private void StackPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Settings settings = new Settings();
            settings.Owner = this;
            settings.ShowDialog();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider s = (Slider)sender;
            sliderValue.Content = Math.Round(s.Value);
            sliderValue.Content += "ГБ";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Add.Visibility = Visibility.Collapsed;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
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
            Params.imgstr = IMGPATH;
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

            product.ShowList();
            productsController.list.Add(product);

            productsController.Save();
            productsController.GetProducts();

            ProductName.Text = "Наименование товара";
            ProductType.Text = "";
            foreach (var el in ScreenSize.Items)
            {
                RadioButton p = (RadioButton)el;
                p.IsChecked = false;
            }
            ScreenType.Text = "";

            foreach (var el in CPU.Items)
            {
                RadioButton p = (RadioButton)el;
                p.IsChecked = false;
            }
            sldr.Value = 1;
            graphicsCard.Text = "";
            foreach (var el in storage.Items)
            {
                CheckBox p = (CheckBox)el;
                p.IsChecked = false;
            }
            discription.Text = "Описание";
            price.Text = "Цена";
            NumberOfSIM.Text = "Количество SIM";
            OS.Text = "Операционная система";
            CamRes.Text = "Разрешение камеры";

        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            if (Regex.IsMatch(filename, $".jpg|.jfif|.jpg|.png"))
            {

                IMGPATH = filename;
            }
            else
            {
                MessageBox.Show("Неверный формат файла!");
            }
        }

        private void StackPanel_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            Add.Visibility = Visibility.Visible;
        }

        private void TBoxSearxh_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filtration();
        }


        private void ListViewProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var findout = ListViewProduct.SelectedItem as Product;
            ProductManager productInfo = new ProductManager();
            if (findout != null)
            {
                if ((findout.typeOfProduct == "Ноутбук" || findout.typeOfProduct == "Laptop"))
                {
                    LaptopInformationBuilder productLaptopInfoBuilder = new LaptopInformationBuilder();
                    string outInfo = productInfo.BuildString(productLaptopInfoBuilder, findout).ToString();
                    MessageBox.Show(outInfo, "Полное описание");
                }
                if (findout.typeOfProduct == "Мобильный телефон" || findout.typeOfProduct == "Smartphone")
                {
                    PhoneInformationBuilder productPhoneInformation = new PhoneInformationBuilder();
                    string outInfo = productInfo.BuildString(productPhoneInformation, findout).ToString();
                    MessageBox.Show(outInfo, "Полное описание");
                }
            }
        }

        private void StackPanel_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            ProductList.Visibility = Visibility.Visible;
            FileInfo fileInf = new FileInfo(@"D:\2SEM\OOP\Labs\6-7-8\6-7-8\bin\Debug\products.json");
            if (fileInf.Length != 0) productsController.GetProducts();
            ListViewProduct.ItemsSource = productsController.list;
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ProductList.Visibility = Visibility.Collapsed;
            Add.Visibility = Visibility.Collapsed;
            BasketList.Visibility = Visibility.Collapsed;
        }

        private void Filtration()
        {
            var CurList = productsController.list;
            if (TBoxSearch.Text.Length > 0)
            {
                CurList = productsController.list.Where(x => x.shortName.Contains(TBoxSearch.Text)).ToList();
            }

            if (Rad1.IsChecked.Value)
            {
                CurList = CurList.Where(x => x.typeOfProduct == "Laptop" || x.typeOfProduct == "Ноутбук").ToList();
            }
            else if (Rad2.IsChecked.Value)
            {
                CurList = CurList.Where(x => x.typeOfProduct == "Smartphone" || x.typeOfProduct == "Ноутбук").ToList();
            }
            else if (Rad3.IsChecked.Value)
            {
                CurList = CurList.Where(x => x.typeOfProduct == "Smartphone" || x.typeOfProduct == "Смартфон" || x.typeOfProduct == "Ноутбук" || x.typeOfProduct == "Laptop").ToList();

            }


            if (SPrice.IsChecked.Value)
            {
                CurList = CurList.OrderBy(x => Convert.ToInt32(x.price)).ToList();
            }

            if (SRam.IsChecked.Value)
            {
                CurList = CurList.OrderBy(x =>Convert.ToInt32( x.RAM)).ToList();
            }

            ListViewProduct.ItemsSource = CurList;
        }

        private void Rad1_Checked(object sender, RoutedEventArgs e)
        {
            Filtration();
            
        }

        private void Rad2_Checked(object sender, RoutedEventArgs e)
        {
            Filtration();
           
        }

        private void Rad3_Checked(object sender, RoutedEventArgs e)
        {
            Filtration();
           
        }

        private void Rad1_Unchecked(object sender, RoutedEventArgs e)
        {
            Filtration();
        }

        private void Rad2_Unchecked(object sender, RoutedEventArgs e)
        {
            Filtration();
        }

        private void Rad3_Unchecked(object sender, RoutedEventArgs e)
        {
            Filtration();
        }

        private void SPrice_Unchecked(object sender, RoutedEventArgs e)
        {
            Filtration();
        }

        private void SPrice_Checked(object sender, RoutedEventArgs e)
        {
            Filtration();
        }

        private void SRam_Checked(object sender, RoutedEventArgs e)
        {
            Filtration();
        }

        private void SRam_Unchecked(object sender, RoutedEventArgs e)
        {
            Filtration();
        }

        private void StackPanel_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            BasketList.Visibility = Visibility.Visible;
            listBoxBasket.ItemsSource = Authorization.CurrentUser.boughtProducts;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Product boughtProduct = ListViewProduct.SelectedItem as Product;

            
            Authorization.CurrentUser.boughtProducts.Add(boughtProduct);
            listBoxBasket.ItemsSource = Authorization.CurrentUser.boughtProducts;
            MessageBox.Show("Товар добавлен в корзину", "Корзина");
        }

        private void Sign_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Authorization.IsAdmin)
            {
                AdminElem0.Visibility = Visibility.Hidden;
                AdminElem1.Visibility = Visibility.Hidden;
            }
            Authorization authorization = new Authorization();
            authorization.ShowDialog();
            if (Authorization.IsAdmin)
            {
                AdminElem0.Visibility = Visibility.Visible;
                AdminElem1.Visibility = Visibility.Visible;
            }

            listBoxBasket.ItemsSource = Authorization.CurrentUser.boughtProducts;
        }

   

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ProductName.Text = ParamsForRedoUndo.shortName;
            ProductType.Text = "";
            
            ProductType.Text = ParamsForRedoUndo.typeOfProduct;
            foreach (var el in ScreenSize.Items)
            {
                RadioButton p = (RadioButton)el;
                if (p.Content.ToString() == Params.screenSize)
                    p.IsChecked = true;
            }
            ScreenType.Text = ParamsForRedoUndo.screenType;

            foreach (var el in CPU.Items)
            {
                RadioButton p = (RadioButton)el;
                if (p.Content.ToString() == Params.cpu)
                    p.IsChecked = true;

            }
            sldr.Value = Convert.ToDouble(ParamsForRedoUndo.RAM);
            graphicsCard.Text = ParamsForRedoUndo.graphicsCardModel;
            foreach (var el in storage.Items)
            {
                CheckBox p = (CheckBox)el;
                foreach (var el2 in ParamsForRedoUndo.storageCapacity)
                {
                    if (p.Content.ToString() == el2)
                        p.IsChecked = true;
                }
            }
            discription.Text = ParamsForRedoUndo.discription;
            price.Text = ParamsForRedoUndo.price;
            NumberOfSIM.Text = ParamsForRedoUndo.numberOfSIM;
            OS.Text = ParamsForRedoUndo.operatingSystem;
            CamRes.Text = ParamsForRedoUndo.cameraResolutions;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            ParamsForRedoUndo.shortName = ProductName.Text;
            ParamsForRedoUndo.typeOfProduct = ProductType.Text;
            foreach (var el in ScreenSize.Items)
            {
                RadioButton p = (RadioButton)el;
                if (p.IsChecked == true) Params.screenSize = p.Content.ToString();
            }

            ParamsForRedoUndo.screenType = ScreenType.Text;

            foreach (var el in CPU.Items)
            {
                RadioButton p = (RadioButton)el;
                if (p.IsChecked == true) Params.cpu = p.Content.ToString();
            }
            ParamsForRedoUndo.RAM = Math.Round(sldr.Value).ToString();
            ParamsForRedoUndo.graphicsCardModel = graphicsCard.Text;

            foreach (var el in storage.Items)
            {
                CheckBox p = (CheckBox)el;
                if (p.IsChecked == true) Params.storageCapacity.Add(p.Content.ToString());
            }
            ParamsForRedoUndo.discription = discription.Text;
            ParamsForRedoUndo.price = price.Text;
            ParamsForRedoUndo.numberOfSIM = NumberOfSIM.Text;
            ParamsForRedoUndo.cameraResolutions = CamRes.Text;
            ParamsForRedoUndo.operatingSystem = OS.Text;


            ProductName.Text = "Наименование товара";
            ProductType.Text = "";
            foreach (var el in ScreenSize.Items)
            {
                RadioButton p = (RadioButton)el;
                p.IsChecked = false;
            }
            ScreenType.Text = "";

            foreach (var el in CPU.Items)
            {
                RadioButton p = (RadioButton)el;
                p.IsChecked = false;
            }
            sldr.Value = 1;
            graphicsCard.Text = "";
            foreach (var el in storage.Items)
            {
                CheckBox p = (CheckBox)el;
                p.IsChecked = false;
            }
            discription.Text = "Описание";
            price.Text = "Цена";
            NumberOfSIM.Text = "Количество SIM";
            OS.Text = "Операционная система";
            CamRes.Text = "Разрешение камеры";
        }
    }
}
