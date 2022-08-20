using _6_7_8.Commands;
using _6_7_8.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_7_8.VM
{
    public class ViewModelBase
    {
      
        public DeleteElementCommand DeleteElementCommand { get; private set; }
        public EditElementCommand EditElementCommand { get; private set; }

        ObservableCollection<Product> _list;

        public ViewModelBase(ObservableCollection<Product> list)
        {
            _list = list;
           
            DeleteElementCommand = new DeleteElementCommand(DeleteElement);
            EditElementCommand = new EditElementCommand(EditElement);
        }

    

        private void DeleteElement(Product el)
        {
            _list.Remove(el);
            MainWindow.productsController.list.Remove(el);
            MainWindow.productsController.Save();
        }

        private void EditElement(Product el)
        {
            EditWindow addWin = new EditWindow(el);
            addWin.ShowDialog();

            if (addWin.GetData() != null)
            {
                _list.Remove(el);
                _list.Add(addWin.GetData());
                MainWindow.productsController.list.Remove(el);
                MainWindow.productsController.list.Add(addWin.GetData() );
                MainWindow.productsController.Save();


            }
        }
    }
}
