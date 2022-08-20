using Lab3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public interface ICommand
    {
        string Execute();
        string Undo();
    }


    //Конкретная команда
    class DealCommand : ICommand
    {
        Product pr;
        public DealCommand(Product prSet)
        {
            pr = prSet;
        }

        public string Execute()
        {
           return pr.dealCompleted();
        }

        public string Undo()
        {
            return pr.dealNotCompleted();
        }
    }


    //class PRoduct - получатель 

    //Инициатор команды
    class Buyer
    {
        ICommand command;
        public Buyer() { }
        public void SetCommand(ICommand com)
        {
            command = com;
        }
        public string PressOk()
        {
           return command.Execute();
        }

        public string PressNo()
        {
            return command.Undo();
        }
    }



}
