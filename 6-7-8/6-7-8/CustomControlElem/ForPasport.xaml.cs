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

namespace _6_7_8.CustomControlElem
{
    /// <summary>
    /// Логика взаимодействия для ForPasport.xaml
    /// </summary>
    public partial class ForPasport : UserControl
    {
        Pasport pasport = new Pasport();
        public ForPasport()
        {
            InitializeComponent();
            DataContext = new Pasport();
        }

    }

}
