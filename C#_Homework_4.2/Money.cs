using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CS_Homework_4_2
{
    abstract class Money  // abstract - по умолчанию internal
    {
        protected int whole { get; set; }
        protected int fract { get; set; }

        public Money() : this(0, 0) { }
        public Money(int w, int f)
        {
            whole = w;
            fract = f;
        }

        public override string ToString()
        {
            return whole.ToString() + "," + fract.ToString();
        }
    }

    sealed class Product : Money
    {
        public string Name { get; set; }

        public Product() : this(null, 0, 0) { }

        public Product(string n, int w, int f) : base(w, f)
        {
            Console.WriteLine("Конструктор класса Product");
            Name = n;
        }

        public int Sale (Product a, int b)
        {
            a.whole = (a.whole - b);
            return a.whole;
        }
        public string ToString()
        {
            return "Цена: " + whole.ToString() + "," + fract.ToString();
        }
    }
}

