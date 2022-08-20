using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _6_7_8.CustomControlElem
{
    /// <summary>
    /// Логика взаимодействия для CustomControl.xaml
    /// </summary>
    public partial class CustomControl : UserControl
    {
        Task t;
        public CustomControl()
        {
            
            InitializeComponent();
        }
        [STAThread]
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

            DoubleAnimation doubleAnimation = new DoubleAnimation(1,0,new Duration(TimeSpan.FromSeconds(1)));
            Rectangle.BeginAnimation(OpacityProperty, doubleAnimation);



           
           
            
            
        }
        public void ChangeVisibility()
        {
            Thread.Sleep(1000);
            grid.Visibility = Visibility.Collapsed;
        }
    }
}
