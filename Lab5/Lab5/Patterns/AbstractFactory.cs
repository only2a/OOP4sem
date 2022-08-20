using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Patterns
{
    public abstract class AbstractFactory
    {
        public abstract Inspectorro CreateInspect();
    }

    public abstract class Inspectorro
    {
        public string message = default;
        public string checkedOrNo = default;
        public abstract void TakeExamination();
        public override string ToString()
        {
            return message + "▬" + checkedOrNo;
        }
    }

    class VerifiedTrue : Inspectorro
    {
        public override void TakeExamination()
        {
            this.checkedOrNo = "Проверка пройдена";
            this.message = "Товар допускается к продаже";
        }
    }
    class VerifiedFalse: Inspectorro
    {
        public override void TakeExamination()
        {
            this.checkedOrNo = "Проверка не пройдена";
            this.message = "Товар не допускается к продаже";
        }
    }
    class InspectedProductFactory : AbstractFactory
    {
        public override Inspectorro CreateInspect()
        {
            return new VerifiedTrue();
        }
    }
    class UntestedProductFactory : AbstractFactory
    {
        public override Inspectorro CreateInspect()
        {
            return new VerifiedFalse();
        }
    }
}
