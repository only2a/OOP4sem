using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Lab9_2
{
    class MynewButton :Button
    {   
        //создание маршрутизируемого события
        public static RoutedEvent MyButtonClickEvent;

        //статический конструктор, в котором регистрируется событие
        static MynewButton()
        {
            //регистрация события с помощью EventManager
            MyButtonClickEvent = EventManager.RegisterRoutedEvent("MyButtonClick",
                RoutingStrategy.Tunnel,
                typeof(RoutedEventHandler),
                typeof(MynewButton));

            //Параметры:
            //1. Имя события
            //2. Тип маршрута(поднимающийся, спускающийся,прямой)
            //3. тип делегата,который создаёт сигнатуру обработчика
            //4. класс,владеющий событием
        }

        // обёртка события
        public event RoutedEventHandler MyButtonClick
        {
            add { AddHandler(MyButtonClickEvent, value); }
            remove { RemoveHandler(MyButtonClickEvent, value); }
        }


        protected override void OnClick()
        {
            base.OnClick();

            RoutedEventArgs args = new RoutedEventArgs(MynewButton.MyButtonClickEvent, this);

            RaiseEvent(args);
        }

    }
}
