using System;
using System.Collections.Generic;

namespace problem12
{
    internal class HTMLElementClass
    {
        public class HTMLElemt
        {
            public string Type { get; set; }
            public string Value { get; set; }

            public virtual void Render()
            {
                Console.WriteLine($"<{Type}>{Value}</{Type}>");
            }
        }
        public class ImageElement : HTMLElemt
        {
            public string Src { get; set; }

            public ImageElement()
            {
                Type = "img";
            }

            public override void Render()
            {
                Console.WriteLine($"<img src=\"{Src}\">");
            }
        }
        public class TextElement : HTMLElemt
        {
            public int FontSize { get; set; }
            public string FontColor { get; set; }

            public override void Render()
            {
                Console.WriteLine($"<{Type} fontSize=\"{FontSize}\" color=\"{FontColor}\">{Value}</{Type}>");
            }
        }
        public class H1Element : TextElement
        {
            public H1Element()
            {
                Type = "H1";
            }
        }

        public class H2Element : TextElement
        {
            public H2Element()
            {
                Type = "H2";
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<HTMLElementClass.HTMLElemt> elements = new List<HTMLElementClass.HTMLElemt>();
            elements.Add(new HTMLElementClass.ImageElement() { Src = "https://example.com/image.jpg" });
            elements.Add(new HTMLElementClass.H1Element() { Value = "Heading 1", FontSize = 16, FontColor = "#556" });
            elements.Add(new HTMLElementClass.H2Element() { Value = "Heading 2", FontSize = 14, FontColor = "#333" });

            foreach (var element in elements)
            {
                element.Render();
            }
            Console.ReadLine();
        }
    }
}