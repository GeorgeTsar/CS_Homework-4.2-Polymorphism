using CS_Homework_4_2;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Homework_4_2
{
    abstract class Device
    {
        protected string name { get; set; }
        protected string sound { get; set; }
        protected string desc { get; set; }
        public Device() : this(null, null, null) { }
        public Device(string n, string s, string d)
        {
            name = n;
            sound = s;
            desc = d;
        }
        public abstract void Show();
        public abstract void Sound();
        public abstract void Desc();
    }

    sealed class Teapot : Device
    {
        public Teapot(string n, string s, string d) : base(n, s, d) { }
        public override void Show()
        {
            Console.WriteLine("\nНазвание устройства: {0}", name);
        }
        public override void Sound()
        {
            Console.WriteLine("\nЗвук устройства: {0}", sound);
        }
        public override void Desc()
        {
            Console.WriteLine("\nОписание устройства: {0}", desc);
        }
    }
    sealed class Microwave : Device
    {
        public Microwave(string n, string s, string d) : base(n, s, d) { }
        public override void Show()
        {
            Console.WriteLine("\nНазвание устройства: {0}", name);
        }
        public override void Sound()
        {
            Console.WriteLine("\nЗвук устройства: {0}", sound);
        }
        public override void Desc()
        {
            Console.WriteLine("\nОписание устройства: {0}", desc);
        }
    }
    sealed class Auto : Device
    {
        public Auto(string n, string s, string d) : base(n, s, d) { }
        public override void Show()
        {
            Console.WriteLine("\nНазвание устройства: {0}", name);
        }
        public override void Sound()
        {
            Console.WriteLine("\nЗвук устройства: {0}", sound);
        }
        public override void Desc()
        {
            Console.WriteLine("\nОписание устройства: {0}", desc);
        }
    }
    sealed class Steamship : Device
    {
        public Steamship(string n, string s, string d) : base(n, s, d) { }
        public override void Show()
        {
            Console.WriteLine("\nНазвание устройства: {0}", name);
        }
        public override void Sound()
        {
            Console.WriteLine("\nЗвук устройства: {0}", sound);
        }
        public override void Desc()
        {
            Console.WriteLine("\nОписание устройства: {0}", desc);
        }
    }
}
