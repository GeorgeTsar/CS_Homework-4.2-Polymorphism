using CS_Homework_4_2;
using System;
using System.Drawing;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;

class MainClass
{
    public static void Main()
    {

        Product obj1 = new("Сыр", 32, 50);
        Console.WriteLine(obj1.Name);
        Console.WriteLine(obj1.ToString());
        obj1.Sale(obj1, 2);
        Console.WriteLine(obj1.ToString());

        Console.WriteLine("--------------------------------------------------");

        Device d = null;
        Console.WriteLine("1. Чайник\n2. Микроволновка\n3. Автомобиль\n4. Пароход\n");
        Console.WriteLine("Ваш выбор: ");
        char s = (char)Console.Read();
        switch (s)
        {
            case '1':
                d = new Teapot("Чайник", "Звук пара", "Устройство для кипячения воды");
                d.Show();
                d.Sound();
                d.Desc();
                break;
            case '2':
                d = new Microwave("Микроволновка", "Звук микроволновки", "Устройство для разогревания пищи");
                d.Show();
                d.Sound();
                d.Desc();
                break;
            case '3':
                d = new Auto("Автомобиль", "Скрип колеса", "Устройство для передвижения по дорогам");
                d.Show();
                d.Sound();
                d.Desc();
                break;
            case '4':
                d = new Steamship("Пароход", "Звук трубы", "Устройство для передвижения по морям");
                d.Show();
                d.Sound();
                d.Desc();
                break;

            default:
                Console.WriteLine("Некорректный выбор!");
                return;
        }

        Console.WriteLine("--------------------------------------------------");

        MusicInstrument m = null;
        Console.WriteLine("1. Скрипка\n2. Тромбон\n3. Укулеле\n4. Виолончель\n");
        Console.WriteLine("Ваш выбор: ");
        char s2 = (char)Console.Read();
        switch (s2)
        {
            case '1':
                m = new Violin("Скрипка", "Звук скрипки", "Описание скрипки", "История скрипки");
                m.Show();
                m.Sound();
                m.Desc();
                m.History();
                break;
            case '2':
                m = new Trombone("Тромбон", "Звук тромбона", "Описание тромбона", "История тромбона");
                m.Show();
                m.Sound();
                m.Desc();
                m.History();
                break;
            case '3':
                m = new Ukulele("Укулеле", "Звук укулеле", "Описание укулеле", "История укулеле");
                m.Show();
                m.Sound();
                m.Desc();
                m.History();
                break;
            case '4':
                m = new Violoncello("Виолончель", "Звук виолончели", "Описание виолончели", "История виолончели");
                m.Show();
                m.Sound();
                m.Desc();
                m.History();
                break;

            default:
                Console.WriteLine("Некорректный выбор!");
                return;
        }

        Console.WriteLine("--------------------------------------------------");

        Worker w = null;
        Console.WriteLine("1. Президент\n2. Охранник\n3. Менеджер\n4. Инженер\n");
        Console.WriteLine("Ваш выбор: ");
        char s3 = (char)Console.Read();
        switch (s3)
        {
            case '1':
                w = new President();
                w.Print();
                break;
            case '2':
                w = new Security();
                w.Print();
                break;
            case '3':
                w = new Manager();
                w.Print();
                break;
            case '4':
                w = new Engineer();
                w.Print();
                break;

            default:
                Console.WriteLine("Некорректный выбор!");
                return;
        }
    }
}
