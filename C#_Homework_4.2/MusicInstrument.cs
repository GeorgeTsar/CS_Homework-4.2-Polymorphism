using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Homework_4_2
{
    abstract class MusicInstrument
    {
        protected string name { get; set; }
        protected string sound { get; set; }
        protected string desc { get; set; }
        protected string history { get; set; }
        public MusicInstrument() : this(null, null, null, null) { }
        public MusicInstrument(string n, string s, string d, string h)
        {
            name = n;
            sound = s;
            desc = d;
            history = h;
        }
        public abstract void Show();
        public abstract void Sound();
        public abstract void Desc();
        public abstract void History();
    }

    sealed class Violin : MusicInstrument
    {
        public Violin(string n, string s, string d, string h) : base(n, s, d, h) { }
        public override void Show()
        {
            Console.WriteLine("\nНазвание инструмента: {0}", name);
        }
        public override void Sound()
        {
            Console.WriteLine("\nЗвук: {0}", sound);
        }
        public override void Desc()
        {
            Console.WriteLine("\nОписание инструмента: {0}", desc);
        }
        public override void History()
        {
            Console.WriteLine("\nИстория инструмента: {0}", desc);
        }
    }
    sealed class Trombone : MusicInstrument
    {
        public Trombone(string n, string s, string d, string h) : base(n, s, d, h) { }
        public override void Show()
        {
            Console.WriteLine("\nНазвание инструмента: {0}", name);
        }
        public override void Sound()
        {
            Console.WriteLine("\nЗвук: {0}", sound);
        }
        public override void Desc()
        {
            Console.WriteLine("\nОписание инструмента: {0}", desc);
        }
        public override void History()
        {
            Console.WriteLine("\nИстория инструмента: {0}", desc);
        }
    }

    sealed class Ukulele : MusicInstrument
    {
        public Ukulele(string n, string s, string d, string h) : base(n, s, d, h) { }
        public override void Show()
        {
            Console.WriteLine("\nНазвание инструмента: {0}", name);
        }
        public override void Sound()
        {
            Console.WriteLine("\nЗвук: {0}", sound);
        }
        public override void Desc()
        {
            Console.WriteLine("\nОписание инструмента: {0}", desc);
        }
        public override void History()
        {
            Console.WriteLine("\nИстория инструмента: {0}", desc);
        }
    }

    sealed class Violoncello : MusicInstrument
    {
        public Violoncello(string n, string s, string d, string h) : base(n, s, d, h) { }
        public override void Show()
        {
            Console.WriteLine("\nНазвание инструмента: {0}", name);
        }
        public override void Sound()
        {
            Console.WriteLine("\nЗвук: {0}", sound);
        }
        public override void Desc()
        {
            Console.WriteLine("\nОписание инструмента: {0}", desc);
        }
        public override void History()
        {
            Console.WriteLine("\nИстория инструмента: {0}", desc);
        }
    }
}
