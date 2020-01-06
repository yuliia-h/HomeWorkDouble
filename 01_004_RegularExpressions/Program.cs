using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace _01_006_RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
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
            //номер 12-34-56 заменился бы на 120-34-56.
            string text10 = @"Контакты в Москве tel:123-45-67, 123-34-56; fax:123-56-45. 
                             Контакты в Саратове tel:12-34-56; fax:11-56-45";
            Console.WriteLine("Старые данные\n" + text10);
            string newText2 = Regex.Replace(text10, "12-" ,"120-");
            newText2 = Regex.Replace(newText2, "11-", "110-");
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
            Console.WriteLine(new string('`', 50));
            Console.WriteLine(new string('`', 50));

            //*************Practicum************************************

            string str = "В морозную ночь лорд Пэджет приказал 10-му гусарскому " +
                "полку пройти через город Саагун, который был оккупирован " +
                "французской кавалерией, в то время как он с 15-м гусарским полком " +
                "обходил вокруг Саагуна, чтобы загнать французов в ловушку[5]. " +
                "К сожалению, генерал John Slade опоздал с выходом 10-го полка " +
                "(по некоторым источникам, он задержал своих гусаров длинной и " +
                "довольно нелепой речью, закончившейся словами: «Кровь и побоище! " +
                "Вперёд!»[6]); французская кавалерия узнала о находящейся поблизости " +
                "британской и беспрепятственно вышла из города на восток[7]. В лучах " +
                "рассвета французские полки, увидев 15-й гусарский полк на юге, " +
                "выстроились в две шеренги с 1-м временным шассёрским полком (под " +
                "командованием полковника Таше, родственника императрицы Жозефины — " +
                "хотя он, возможно, и не присутствовал поле битвы) впереди и с 8-м " +
                "драгунским позади них. Необычно, что французская кавалерия вместо " +
                "сабельной атаки выдержала залп оружия британских гусар, стоя на месте," +
                " в то время как французы сами пытались остановить неприятеля огнём из" +
                " карабинов[8].15 - й гусарский атаковал около 400 метров по заснеженной, " +
                "мёрзлой земле с криками «Эмсдорф и победа!» (Бой при Эмсдорфе был более " +
                "ранним сражением, произошедшим 16 июля 1760 года, в котором 15 - й полк " +
                "сыграл заметную роль). Было так холодно, что гусары надели свои ментики, " +
                "вместо того, чтобы просто накинуть их на плечи, и у многих поверх ментиков " +
                "были ещё и плащи.Свидетели также говорили о немеющих руках, едва способных " +
                "ухватить поводья и сабли.Столкновение между гусарами и шассёрами было ужасным; " +
                "как писал один британский офицер: «Люди и лошади были опрокинуты, и вопли ужаса, " +
                "смешанные с проклятьями, стонами и молитвами tel:123-45-67, 123-34-56; fax:123-56-45. "+
                " Контакты в Саратове tel:12-34-56; fax: 12-56-45, 256-458: 254-589, раздавались со всех сторон»[8]. " +
                "Британские гусары атаковали с такой скоростью, что пробились через шеренгу " +
                "шассёров до шеренги драгунов позади.Французские войска были разбиты, и они " +
                "устремились на восток, преследуемые англичанами. Многие французские кавалеристы " +
                "(хотя шассёры были в основном немецкого происхождения) были взяты в плен с весьма" +
                " 12.12.2018 12.15.1100 05.06.2019 00.12.2010 025 небольшими жертвами со стороны 15-го гусарского полка[9]. Два французских " +
                "подполковника были взяты в плен, а шассёрский полк, потерявший множество солдат, " +
                "захваченных в плен, перестали существовать как боевая единица[10]. Впрочем, не все " +
                "солдаты 15-го полка действовали одинаково успешно; сообщается, что один неуклюжий гусар" +
                " умудрился застрелить во время погони собственную лошадь[8]. Во время погони подошёл 10-й " +
                "гусарский полк, однако их приняли за французскую кавалерию.Из-за этого 15-й гусарский полк" +
                " прервал преследование, чтобы перестроиться[11]. 4.1e-3; 7.9e-9 ";

            //1.Определите, содержится ли в сообщении заданное слово.
            Regex regex = new Regex("Плечи");
            Console.WriteLine(regex.IsMatch(str));
            Console.WriteLine(new string('`', 20));

            //2.Выведите все слова заданной длины.
            Regex regex1 = new Regex(@"\b\w{12}\b");
            Match match = regex1.Match(str);
            while (match.Success)
            {
                Console.WriteLine(match);
                match = match.NextMatch();
            }
            Console.WriteLine(new string('`', 20));

            //3.Выведите на экран все слова сообщения, записанные с заглавной буквы.
            Regex regex2 = new Regex(@"\b[А-Я]\w*\b");
            //или @"[A-Z]\S*"
            foreach(var i in regex2.Matches(str))
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();

            //4.Удалите из сообщения все однобуквенные слова. 
            string strCopy = Regex.Replace(str, @"(\b[а-я]{1}\b)|(\b[А-Я]{1}\b)", "");
            Console.WriteLine("New text 4:\n" + strCopy);
            Console.WriteLine();

            //5.Удалите из сообщения все знаки препинания.
            strCopy = Regex.Replace(str, @"[,.!:;?]", "");
            Console.WriteLine("New text 5:\n" + strCopy);

            //6.Удалите из сообщения все русские слова.
            strCopy = Regex.Replace(str, @"(\b[а-я]+)|(\b[А-я]+)|(ё\w+)", "");
            Console.WriteLine("New text 6:\n" + strCopy);

            //7.Удалите из сообщения только те русские слова,которые начинаются на гласную букву.
            Regex regex3 = new Regex(@"(\b[аоуеиэйяюы][а-я]+)|(\b[АОУЕЭЙЮЯЫ][а-я]+)|(\b[аоуеиэйяю]ё\w+)");
            foreach (var i in regex3.Matches(str)) Console.Write(i + " ");
            strCopy = Regex.Replace(str, @"(\b[аоуеиэйяюы][а-я]+)|(\b[АОУЕЭЙЮЯЫ][а-я]+)|(\b[аоуеиэйяю]ё\w+)", "");
            Console.WriteLine("\nNew text 7:\n" + strCopy);

            //8.Заменить все английские слова на многоточие
            Regex regex4 = new Regex(@"([a-z]{1,})",RegexOptions.IgnoreCase);
            foreach (var i in regex4.Matches(str)) Console.Write(i + " ");
            strCopy = Regex.Replace(str, @"[a-z]{1,}", "...",RegexOptions.IgnoreCase);
            Console.WriteLine("\nNew text 8:\n" + strCopy);

            //9.Найти максимальное целое число, встречающееся в сообщении.
            Console.WriteLine("\nNew text 9:\n");
            Regex regex5 = new Regex(@"[-+]?\d+");
            foreach (var i in regex5.Matches(str)) Console.Write(i + " ");
            int number = 0;
            int number2 = 0;
            Match match1 = regex5.Match(str);
            while (match1.Success)
            {
                number = int.Parse(match1.ToString());
                if (number > number2) number2 = int.Parse(match1.ToString());
                match1 = match1.NextMatch();
            }
            Console.WriteLine("\nNumber more this text = " + number2);

            //10.Найти сумму всех имеющихся в тексте чисел (целых и вещественных, 
            //причем вещественное число может быть записано в экспоненциальной форме).            
            Console.WriteLine("\nNew text 10:\n");
            Regex regex6 = new Regex(@"[-+]?\d+(?:\.\d+)?(?:[eE][-+]?\d+)?");
            foreach (var i in regex6.Matches(str)) Console.Write(i + " ");
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-us");
            var matchec= Regex.Matches(str, @"[-+]?\d+(?:\.\d+)?(?:[eE][-+]?\d+)?");            
            double sumDouble = 0.0;           
            foreach (Match item in matchec)
            {
                sumDouble += double.Parse(item.Value);                
            }
            Console.WriteLine("\nSum = " + sumDouble);

            //11.В сообщении могут встречаться номера телефонов, записанные в 
            //формате xx-xx-xx, xxx-xxx или xxx-xx-xx. Вывести все номера телефонов, 
            //которые содержатся в сообщении.
            Console.WriteLine("\nTask 11:\n");
            //***not work****Regex regex7 = new Regex(@"(\d{2}\*\d{2}\*\d{2})|(\d{3}\*\d{3})|(\d{3}\*\d{2}\*\d{2})");
            Regex regex7 = new Regex(@"(\d{2,3}(-\d\d){2})|(\d{3}-\d{3})");
            Match match2 = regex7.Match(str);
            while (match2.Success)
            {
                Console.WriteLine(match2);
                match2 = match2.NextMatch();
            }

            //12.В сообщении может содержаться дата в формате дд.мм.гггг. В заданном
            //формате дд - целое число из диапазона от 1 до 31, мм - целое число из 
            //диапазона от 1 до 12, а гггг - целое число из диапазона от 1900 до 
            //2010 (если какая-то часть формата нарушена, то данная подстрока в 
            //качестве даты не рассматривается). Выведите на экран все даты,
            //которые относятся к текущему году.
            Console.WriteLine("\nTask 12:\n");
            //string test = " 32 02.12.12  08.15.2010 14.15.2010 10.06.2020 1 5 30 32 35";
            string test = "32";
            //Regex regex8 = new Regex(@"(0[1-9]|[1-9][0-9])\.[0-9][1-2]\.\d+");
            //Regex regex8 = new Regex(@"^([1-2]?[1-9]|[1-3][0-2])$/");
            //Regex regex8 = new Regex(@"^([1-9]|[1-9][1- 9] |[1][0][0])$");
            //Match match3 = regex8.Match(test);
            //while (match3.Success)
            //{
            //    Console.WriteLine(match3);
            //    match3 = match3.NextMatch();
            //}

            //13.В сообщении могут содержаться IP-адреса компьютеров в формате d.d.d.d, 
            //где d - целое число из диапазона от 0 до 255. Вывести все IP-адреса содержащиеся в тексте.
            Console.WriteLine("\nTask 13:\n");
            string test2 = " 255.255.255.255. 109.1.255.125. 1.1.1.1. 257.12.111.255.";
            //Regex regex9 = new Regex(@"[0-255]d+\.[0-255]d+\.[0-255]d+\.[0-255]d+\.");
            //Regex regex9 = new Regex(@"((1\d\d|2([0-5]\d|5[0-5])|\D\d\d?)\.?){4}$");
            //Regex regex9 = new Regex(@"((1\d\d|2([0-4]\d|5[0-5])|\d\d?)\.?){4}$");
            Regex regex9 = new Regex(@"((\d){1,3}\.){4}");
            //Regex regex9 = new Regex(@"((2[0-5][0-5]|1[0-9][0-9]|[1-9][0-9]|[0-9]\.?)){8}");
            //Regex regex9 = new Regex(@"((1\d\d|2([0-4]\d|5[0-5])|\d\d?)\.?){4}$");

            Match match4 = regex9.Match(test2);
            while (match4.Success)
            {
                Console.WriteLine(match4);
                match4 = match4.NextMatch();
            }


            Console.ReadKey();
        }
    }
}
