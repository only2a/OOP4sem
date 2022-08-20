using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Patterns
{
    class Singleton
    {
        private static Singleton form1Information;

        public Color BackgroundColor { get; private set; }
        public Font WindowFont { get; private set; }
        public Size WindowSize { get; private set; }

        private Singleton(Color color, Font font, Size size)
        {
            this.BackgroundColor = color;
            this.WindowFont = font;
            this.WindowSize = size;
        }

        public static Singleton getInstance(Color color, Font font, Size size)
        {
            if (form1Information == null)
                form1Information = new Singleton(color, font, size);
            return form1Information;
        }

        public override string ToString()
        {
            return "Цвет фона: " + this.BackgroundColor.Name + "\nШрифт: " + this.WindowFont.Name + "\nРазмер окна: " + this.WindowSize.Width + "x" + this.WindowSize.Height;
        }
    }
}
