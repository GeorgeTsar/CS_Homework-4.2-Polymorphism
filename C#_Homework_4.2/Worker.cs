using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Homework_4_2
{
    abstract class Worker
    {
        public abstract void Print();
    }

    sealed class President : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Глава компании");
        }
    }
    sealed class Security : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Охрана порядка");
        }
    }
    sealed class Manager : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Управляющий среднего звена");
        }
    }
    sealed class Engineer : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Проектировщик");
        }
    }

}
