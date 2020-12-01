using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBox
{
    class TextBox
    {
        public ConsoleColor BackColor { get; set; }
        public ConsoleColor ForeColor { get; set; }
        public int Padding { get; set; }
        public string Text { get; set; }


        public TextBox()
        {
            BackColor = ConsoleColor.Magenta;
            ForeColor = ConsoleColor.DarkMagenta;
            Padding = 0;
            Text = " ";
        }

        public TextBox(ConsoleColor backcolor, ConsoleColor forecolor, int padding, string text)
        {
            BackColor = backcolor;
            ForeColor = forecolor;
            Padding = padding;
            Text = text;
            
        }

        public void DisplayText()
        {
            Console.BackgroundColor = BackColor;
            Console.ForegroundColor = ForeColor;
            Padding = 0;
            Text = Text.PadLeft(Padding);
            string Text2 = Text.PadRight(Text.Length + Padding);
            string Text3 = (Text + Text2);

            Console.WriteLine(Text3);
            return;
        }

    }
}
