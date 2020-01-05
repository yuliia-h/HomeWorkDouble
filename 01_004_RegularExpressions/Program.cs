using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01_006_RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //попытаемся определить, встречается ли в заданном тексте слово собака
            //RegexOptions.IgnoreCase - означает, что регулярное выражение применяется без учета регистра символов.
            Regex r = new Regex("собака", RegexOptions.IgnoreCase);
            string text1 = "Кот в доме, собака в конуре.";
            string text2 = "Котик в доме, собачка в конуре.";
            Console.WriteLine(r.IsMatch(text1));
            Console.WriteLine(r.IsMatch(text2));
            Console.WriteLine(new string('`', 20));

            //Можно использовать конструкцию выбора из нескольких элементов. 
            //Варианты выбора перечисляются через вертикальную черту. 
            //Например, попытаемся определить, встречается ли в 
            //заданном тексте слов собака или кот
            Regex r2 = new Regex("собака|кот", RegexOptions.IgnoreCase);
            string text12 = "Кот в доме, собака в конуре.";
            string text22 = "Котик в доме, собачка в конуре.";
            Console.WriteLine(r.IsMatch(text12));
            Console.WriteLine(r.IsMatch(text22));
            Console.WriteLine(new string('`', 20));

            //Попытаемся определить, есть ли в заданных строках номера 
            //телефона в формате xx-xx-xx или xxx-xx-xx:
            Regex r3 = new Regex(@"\d{2,3}(-\d\d){2}");
            string text13 = "tel:123-45-67";
            string text23 = "tel:no";
            string text33 = "tel:12-34-56";
            Console.WriteLine(r3.IsMatch(text13));
            Console.WriteLine(r3.IsMatch(text23));
            Console.WriteLine(r3.IsMatch(text33));
            Console.WriteLine(new string('`', 20));

            //Измените программу так, чтобы можно было определить, 
            //содержится в тексте дата в формате дд.мм.гг.            
            //Regex r4 = new Regex(@"(0?[1-9]|[12][0-9]|3[01])([\.\\\/-])(0?[1-9]|1[012])\2(((19|20)\d\d)|(\d\d))");
            //Regex r4 = new Regex(@"\d{2}\D\d{2}\D\d{2,4}");
            Regex r4 = new Regex(@"\d{2}\.\d{2}\.\d{2,4}");
            string text14 = "05.10.19";
            string text24 = "06.07.2019";
            string text34 = "11.h7,2019";
            Console.WriteLine(r4.IsMatch(text14));
            Console.WriteLine(r4.IsMatch(text24));
            Console.WriteLine(r4.IsMatch(text34));
            Console.WriteLine(new string('`', 20));

            //Метод Match класса Regex не просто определяет, содержится ли текст, 
            //соответствующий шаблону, а возвращает объект класса Match - 
            //последовательность фрагментов текста, совпавших с шаблоном. 
            //Следующий пример позволяет найти все номера телефонов в указанном фрагменте текста:
            Regex r5 = new Regex(@"\d{2,3}(-\d\d){2}");
            string text5 = @"Контакты в Москве tel:123-45-67, 123-34-56; fax:123-56-45
                  Контакты в Саратове tel:12-34-56; fax:12-56-45";
            Match tel = r5.Match(text5);
            while (tel.Success)
            {
                Console.WriteLine(tel);
                tel = tel.NextMatch();
            }
            Console.WriteLine(new string('`', 20));

            //Следующий пример позволяет подсчитать сумму целых чисел, встречающихся в тексте
            Regex r6 = new Regex(@"[-+]?\d+");
            string text6 = @"5*10=50 -80/40=-2";
            Match teg = r6.Match(text6);
            int sum = 0;
            while (teg.Success)
            {
                Console.WriteLine(teg);
                sum += int.Parse(teg.ToString());
                teg = teg.NextMatch();
                Console.WriteLine("sum= " + sum);
            }
            Console.WriteLine(new string('`', 20));

            //. Измените программу так, чтобы на экран 
            //дополнительно выводилось количество найденных чисел.
            Regex r7 = new Regex(@"[-+]?\d+");
            string text7 = @"5*10=50 -80/40=-2";
            Match teg2 = r6.Match(text7);
            int sum2 = 0;
            int count = 0;
            while (teg2.Success)
            {
                Console.WriteLine(teg2);
                sum2 += int.Parse(teg2.ToString());
                teg2 = teg2.NextMatch();
                Console.WriteLine("sum= " + sum2);
                count++;
            }
            Console.WriteLine("Count numbers = " + count);
            Console.WriteLine(new string('`', 20));

            //Метод Matches класса Regex возвращает объект класса
            //MatchCollection - коллекцию всех фрагментов заданной строки, 
            //совпавших с шаблоном. При этом метод Matches многократно 
            //запускает метод Match, каждый раз начиная поиск с того места, 
            //на котором закончился предыдущий поиск.
            string text8 = @"5*10=50 -80/40=-2";
            Regex theReg = new Regex(@"[-+]?\d+");
            MatchCollection theMatches = theReg.Matches(text8);
            foreach(Match theMatch in theMatches)
            {
                Console.Write("{0} ", theMatch.ToString());
            }
            Console.WriteLine();
            Console.WriteLine(new string('`', 20));

            //Изменение номеров телефонов:
            string text9 = @"Контакты в Москве tel:123-45-67, 123-34-56; fax:123-56-45. 
                             Контакты в Саратове tel:12-34-56; fax:11-56-45";
            Console.WriteLine("Старые данные\n" + text9);
            string newText = Regex.Replace(text9, "123-", "890-");
            Console.WriteLine("Новые данные\n" + newText);
            Console.WriteLine(new string('`', 20));

            //Измените программу так, чтобы шестизначные номера заменялись 
            //на семизначные добавлением 0 после первых двух цифр. Например, 
            //номер 12-34-56 заменился бы на 120-34-56.***not work***
            string text10 = @"Контакты в Москве tel:123-45-67, 123-34-56; fax:123-56-45. 
                             Контакты в Саратове tel:12-34-56; fax:11-56-45";
            Console.WriteLine("Старые данные\n" + text10);
            string newText2 = Regex.Replace(text10, @"\d{2}(-\d\d){2}", @"\d\d\0");
            
            Console.WriteLine("Новые данные\n" + newText2);
            Console.WriteLine(new string('`', 20));

            //Удаление всех номеров телефонов из текста
            string text11 = @"Контакты в Москве tel:123-45-67, 123-34-56; fax:123-56-45. 
                Контакты в Саратове tel:12-34-56; fax:12-56-45";
            Console.WriteLine("Старые данные\n" + text11);
            string newText3 = Regex.Replace(text11, @"\d{2,3}(-\d\d){2}", "");
            Console.WriteLine("Новые данные\n" + newText3);
            Console.WriteLine(new string('`', 20));

            //Измените программу так, чтобы из текста удалялись слова tel и fax 
            //(если после данных слов стоят двоеточия, то их тоже следует удалить).
            string text122 = @"Контакты в Москве tel:123-45-67, 123-34-56; fax:123-56-45. 
                Контакты в Саратове tel:12-34-56; fax:12-56-45";
            Console.WriteLine("Старые данные\n" + text122);
            string newText4 = Regex.Replace(text122, "tel|fax|:", "");
            Console.WriteLine("Новые данные\n" + newText4);
            Console.WriteLine(new string('`', 20));

            //Разбиение исходного текста на фрагменты
            string text15 = @"Контакты в Москве tel:123-45-67, 123-34-56; fax:123-56-45. 
                                Контакты в Саратове tel:12-34-56; fax:12-56-45";
            string[] newText5 = Regex.Split(text15, "[ ,.:;]+");
            foreach (string a in newText5)
                Console.WriteLine(a);
            Console.WriteLine(new string('`', 20));
            Console.WriteLine(new string('`', 20));
            //*************Practicum************************************


            Console.ReadKey();
        }
    }
}
