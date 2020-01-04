using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_HomeTasks_01_3_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            try
            {
                Menu:
                Console.Clear();
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Select task number: 1-19 ");
                Console.WriteLine("1.Дан порядковый номер месяца, вывести на экран количество месяцев оставшихся до конца года.\n" +
                    "2.Вводится символ масти карты(первая буква), определить название масти.\n"+
                    "4.Дан номер карты k(6 k 14), определить достоинство карты.Достоинства\n" +
                    "определяются по следующему правилу: туз - 14, король - 13, дама - 12, валет - 11, десятка - 10, …, шестерка - 6.\n" +
                    "5.Дан номер масти m(1 m 4) и номер достоинства карты k(6 k 14).Определить полное название соответствующей карты в виде дама пик, шестерка бубен и т.д.\n" +
                    "7.С 1 января 1990 года по некоторый день прошло m месяцев, определить название текущего месяца.\n" +
                    "8.С некоторой даты по настоящий день прошло n дней, найти неизвестную дату.\n" +
                    "11.С 1 января 1990 года по некоторый день прошло m месяцев и n дней, определить название текущего месяца.\n" +
                    "12.Дано расписание приемных часов врача. Вывести на экран приемные часы врача в заданный день недели(расписание придумать самостоятельно).\n" +
                    "13.Проведен тест, оцениваемый в целочисленный баллах от нуля до ста. Вывести на экран оценку тестируемого в зависимости от набранного количества баллов: от 90 до 100 - отлично от 70 до 89 - хорошо, от 50 до 69 - удовлетворительно, менее 50 - неудовлетворительно;.\n" +
                    "14.Дан год.Вывести на экран название животного, символизирующего заданный год по восточному календарю.\n" +
                    "15.Дан возраст человека мужского пола в годах. Вывести на экран возрастную категорию: до года -младенец, от года до 11 лет - ребенок, от 12 до 15 лет - подросток, от 16 до 25 лет - юноша, от 26 до 70 лет - мужчина, более 70 лет - старик.\n" +
                    "16.Дан пол человека: м - мужчина, ж - женщина.Вывести на экран возможные мужские и женские имена в зависимости от введенного пола.\n" +
                    "17.Дан признак транспортного средства: a - автомобиль, в - велосипед, м - мотоцикл, с - самолет, п - поезд.Вывести на экран максимальную скорость транспортного средства в зависимости от введенного признака.\n" +
                    "18.Дан номер телевизионного канала.Вывести на экран наиболее популярные программы заданного канала.\n" +
                    "19.Дан признак геометрической фигуры на плоскости: к - круг, п - прямоугольник, т - треугольник.Вывести на экран периметр и площадь заданной фигуры(данные, необходимые для расчетов, запросить у пользователя).");
                Console.Write("\n\tEnter task number: ");
                string s = Console.ReadLine();
                int number;
                bool result=Int32.TryParse(s, out number);

                switch (number)
                {                    
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Введите порядковый номер месяца: ");
                        int number_month = int.Parse(Console.ReadLine());
                        switch (number_month)
                        {
                            case 1: Console.WriteLine("До конца года осталось 11 месяцев"); break;
                            case 2: Console.WriteLine("До конца года осталось 10 месяцев"); break;
                            case 3: Console.WriteLine("До конца года осталось 9 месяцев"); break;
                            case 4: Console.WriteLine("До конца года осталось 8 месяцев"); break;
                            case 5: Console.WriteLine("До конца года осталось 7 месяцев"); break;
                            case 6: Console.WriteLine("До конца года осталось 6 месяцев"); break;
                            case 7: Console.WriteLine("До конца года осталось 5 месяцев"); break;
                            case 8: Console.WriteLine("До конца года осталось 4 месяцев"); break;
                            case 9: Console.WriteLine("До конца года осталось 3 месяцев"); break;
                            case 10: Console.WriteLine("До конца года осталось 2 месяцев"); break;
                            case 11: Console.WriteLine("До конца года осталось 1 месяцев"); break;
                            case 12: Console.WriteLine("До конца года осталось 0 месяцев"); break;
                            default: Console.WriteLine("Такого месяца нет"); break;
                        };
                        Console.ReadLine();
                        goto Menu;
                        

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Даны четыре масти: пик, треф, бубна, чирва ");
                        Console.WriteLine("Введите первую букву масти: ");
                        char mast = char.Parse(Console.ReadLine());
                        switch (mast)
                        {
                            case 'п':
                                Console.Write("пик");
                                break;
                            case 'т':
                                Console.Write("треф");
                                break;
                            case 'б':
                                Console.Write("бубна");
                                break;
                            case 'ч':
                                Console.Write("чирва");
                                break;
                            default:
                                Console.WriteLine("Неправильно");
                                break;
                        }
                        Console.ReadLine();
                        goto Menu;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Введите номер карты: 6-14 ");
                        int numberKart = int.Parse(Console.ReadLine());
                        Console.Write("Ваша карта - ");
                        switch (numberKart)
                        {
                            case 14: Console.WriteLine("Туз"); break;
                            case 13: Console.WriteLine("Король"); break;
                            case 12: Console.WriteLine("Дама"); break;
                            case 11: Console.WriteLine("Валет"); break;
                            case 10: Console.WriteLine("Десятка"); break;
                            case 9: Console.WriteLine("Девятка"); break;
                            case 8: Console.WriteLine("Восьмерка"); break;
                            case 7: Console.WriteLine("Семерка"); break;
                            case 6: Console.WriteLine("Шестерка"); break;

                            default: Console.WriteLine("Вы ввели неверный номер!"); break;
                        };
                        Console.ReadLine();
                        goto Menu;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("Введите номер карты: 6-14 и масть карты - первую букву");
                        numberKart = int.Parse(Console.ReadLine());
                        mast = char.Parse(Console.ReadLine());
                        Console.Write("Ваша карта - ");
                        switch (numberKart)
                        {
                            case 0:
                                switch (mast)
                                {
                                    case 'п':
                                        Console.Write("пик");
                                        break;
                                    case 'т':
                                        Console.Write("треф");
                                        break;
                                    case 'б':
                                        Console.Write("бубна");
                                        break;
                                    case 'ч':
                                        Console.Write("чирва");
                                        break;
                                    default:
                                        Console.WriteLine("Неправильно");
                                        break;
                                }
                                break;
                            case 14: Console.Write("Туз "); goto case 0;
                            case 13: Console.Write("Король "); goto case 0;
                            case 12: Console.Write("Дама "); goto case 0;
                            case 11: Console.Write("Валет "); goto case 0;
                            case 10: Console.Write("Десятка "); goto case 0;
                            case 9: Console.Write("Девятка "); goto case 0;
                            case 8: Console.Write("Восьмерка "); goto case 0;
                            case 7: Console.Write("Семерка "); goto case 0;
                            case 6: Console.Write("Шестерка "); goto case 0;

                            default: Console.WriteLine("Вы ввели неверный номер!"); break;
                        };
                        Console.ReadLine();                       
                        goto Menu;

                    case 6:
                        Console.Clear();
                        Console.WriteLine("Извините, такой задачи нет, выберите другую задачу");                        
                        Console.ReadLine();
                        goto Menu;

                    case 7:
                        Console.Clear();
                        Console.WriteLine("Введите колличество месяцев прошедших после 01 января 1990 года: ");
                        int numberToWeek = int.Parse(Console.ReadLine());
                        int nameWeek = (numberToWeek % 12) + 1;
                        Console.Write("Текущий месяц =  ");
                        switch (nameWeek)
                        {
                            case 1: Console.WriteLine("январь"); break;
                            case 2: Console.WriteLine("февраль"); break;
                            case 3: Console.WriteLine("март"); break;
                            case 4: Console.WriteLine("апрель"); break;
                            case 5: Console.WriteLine("май"); break;
                            case 6: Console.WriteLine("июнь"); break;
                            case 7: Console.WriteLine("июль"); break;
                            case 8: Console.WriteLine("август"); break;
                            case 9: Console.WriteLine("сентябрь"); break;
                            case 10: Console.WriteLine("октябрь"); break;
                            case 11: Console.WriteLine("ноябрь"); break;
                            case 12: Console.WriteLine("декабрь"); break;
                        };
                        Console.ReadLine();                        
                        goto Menu;

                    case 8:
                        Console.Clear();
                        DateTime date = DateTime.Now;
                        Console.WriteLine("Введите колличество прошедших дней: ");
                        int dayPast = int.Parse(Console.ReadLine());
                        Console.WriteLine(date.ToShortDateString());
                        DateTime datePast = date.AddDays(-dayPast);
                        Console.WriteLine("Неизвестная дата = {0}", datePast.ToShortDateString());

                        Console.ReadLine();                        
                        goto Menu;

                    case 11:
                        Console.Clear();
                        Console.Write("Введите колличество прошедших месяцев: ");
                        int months = int.Parse(Console.ReadLine());
                        Console.Write("Введите колличество прошедших дней: ");
                        int days = int.Parse(Console.ReadLine());
                        DateTime date1 = new DateTime(1990, 01, 01);
                        DateTime date2 = new DateTime();
                        date2 = date1.AddMonths(months);
                        Console.WriteLine($"После 01.01.1990 прошло {months} месяцев и {days} дней, текущий месяц " + date2.AddDays(days).ToString("MMMM"));
                        Console.ReadLine();                        
                        goto Menu;


                    case 12:
                        Console.Clear();
                        Console.WriteLine("Введите порядковый номер недели приема врача: 1-2-3-4-5 ");
                        int numberDayWeek = int.Parse(Console.ReadLine());
                        switch (numberDayWeek)
                        {
                            case 1: Console.WriteLine("Приемные часы врача в понедельник: 8:00 - 13:00 "); break;
                            case 2: Console.WriteLine("Приемные часы врача во вторник: 11:00 - 16:00 "); break;
                            case 3: Console.WriteLine("Приемные часы врача в среду: 9:00 - 14:00 "); break;
                            case 4: Console.WriteLine("Приемные часы врача в четверг: 12:00 - 16:00 "); break;
                            case 5: Console.WriteLine("Приемные часы врача в пятницу: 8:00 - 9:00 "); break;

                            default: Console.WriteLine("В этот день недели врач не работает!"); break;
                        };
                        Console.ReadLine();                        
                        goto Menu;

                    case 13:
                        Console.Clear();
                        Console.WriteLine("Введите ваш бал: 0-100 ");
                        int numberBall = int.Parse(Console.ReadLine());
                        int testBall = 0;
                        if (numberBall >= 90) testBall = '1';
                        else if (numberBall > 70 && numberBall <= 89) testBall = '2';
                        else if (numberBall > 50 && numberBall <= 69) testBall = '3';
                        else if (numberBall < 50) testBall = '4';
                        switch (testBall)
                        {
                            case '1': Console.WriteLine("Ваша оценка - отлично "); break;
                            case '2': Console.WriteLine("Ваша оценка - хорошо "); break;
                            case '3': Console.WriteLine("Ваша оценка - удовлетворительно "); break;
                            case '4': Console.WriteLine("Ваша оценка - неудовлетворительно "); break;
                        };
                        Console.ReadLine();                        
                        goto Menu;

                    case 14:
                        Console.Clear();
                        Console.WriteLine("Введите год ");
                        int numberYear = int.Parse(Console.ReadLine());
                        int nameYear = ((numberYear - 1924) % 12) + 1;
                        Console.Write("Вы родились в год ");
                        switch (nameYear)
                        {
                            case 1: Console.WriteLine("крысы"); break;
                            case 2: Console.WriteLine("быка"); break;
                            case 3: Console.WriteLine("тигра"); break;
                            case 4: Console.WriteLine("кролика"); break;
                            case 5: Console.WriteLine("дракона"); break;
                            case 6: Console.WriteLine("змеи"); break;
                            case 7: Console.WriteLine("лошади"); break;
                            case 8: Console.WriteLine("козы"); break;
                            case 9: Console.WriteLine("обезьяны"); break;
                            case 10: Console.WriteLine("петуха"); break;
                            case 11: Console.WriteLine("собаки"); break;
                            case 12: Console.WriteLine("свиньи"); break;
                        };
                        Console.ReadLine();                        
                        goto Menu;

                    case 15:
                        Console.Clear();
                        Console.WriteLine("Введите ваш возраст ");
                        int numberAge = int.Parse(Console.ReadLine());
                        int resAge = 0;
                        if (numberAge < 1) resAge = '1';
                        else if (numberAge >= 1 && numberAge <= 11) resAge = '2';
                        else if (numberAge >= 12 && numberAge <= 15) resAge = '3';
                        else if (numberAge >= 16 && numberAge <= 25) resAge = '4';
                        else if (numberAge >= 26 && numberAge <= 70) resAge = '5';
                        else if (numberAge > 70) resAge = '6';
                        Console.Write("Возрастная категория - ");
                        switch (resAge)
                        {
                            case '1': Console.WriteLine("младенец "); break;
                            case '2': Console.WriteLine("ребенок "); break;
                            case '3': Console.WriteLine("подросток "); break;
                            case '4': Console.WriteLine("юноша "); break;
                            case '5': Console.WriteLine("мужчина "); break;
                            case '6': Console.WriteLine("старик "); break;
                        };
                        Console.ReadLine();
                        goto Menu;

                    case 16:
                        Console.Clear();
                        Console.WriteLine("Введите ваш пол: м-мужчина, ж-женщина ");
                        char numberGender = char.Parse(Console.ReadLine());
                        Console.Write("Имена - ");
                        switch (numberGender)
                        {
                            case 'м': Console.WriteLine("Иван Игнатий Игорь Илья Иннокентий Ираклий Ириней Исидор Иулиан"); break;
                            case 'ж': Console.WriteLine(" Евдокия Евлалия Евпраксия Екатерина Елена Елизавета Епистима Ермиония "); break;
                            default: Console.WriteLine("Неверный символ!"); break;
                        };
                        Console.ReadLine();
                        goto Menu;

                    case 17:
                        Console.Clear();
                        Console.WriteLine("Введите признак транспортного средства: a - автомобиль, в - велосипед, м - мотоцикл, с - самолет, п - поезд ");
                        char numberVehicle = char.Parse(Console.ReadLine());
                        Console.Write("Максимальная скорость транспортного средства - ");
                        switch (numberVehicle)
                        {
                            case 'а': Console.WriteLine("автомобиля - 457,4 км/ч."); break;
                            case 'в': Console.WriteLine("велосипеда - 268 км/час."); break;
                            case 'м': Console.WriteLine("мотоцикла - 300 км/час."); break;
                            case 'с': Console.WriteLine("самолета - 2570 км/ч."); break;
                            case 'п': Console.WriteLine("поезда - 574,8 км/ч."); break;
                            default: Console.WriteLine("Неверный символ!"); break;
                        };
                        Console.ReadLine();
                        goto Menu;

                    case 18:
                        Console.Clear();
                        int numberChannel;
                        Console.WriteLine("Введите номер канала: 1-2-3-4-5 ");
                        numberChannel = int.Parse(Console.ReadLine());
                        Console.Write("Популярные программы заданного канала - ");
                        switch (numberChannel)
                        {
                            case 1: Console.WriteLine("Пусть говорят"); break;
                            case 2: Console.WriteLine("Вечерний ургант"); break;
                            case 3: Console.WriteLine("Голос"); break;
                            case 4: Console.WriteLine("На самом деле"); break;
                            case 5: Console.WriteLine("Время"); break;

                            default: Console.WriteLine("Введен неправильный номер канала!"); break;
                        };
                        Console.ReadLine();
                        goto Menu;

                    case 19:
                        Console.Clear();
                        int numberFigure;
                        Console.WriteLine("Введите признак геометрической фигуры на плоскости: к - круг, п - прямоугольник, т - треугольник");
                        numberFigure = char.Parse(Console.ReadLine());
                        double a, b, c, p = 3.14, per = 0.0, area = 0.0;
                        switch (numberFigure)
                        {
                            case 'к':
                                Console.Write("Введите радиус круга");
                                a = int.Parse(Console.ReadLine());
                                area = p * Math.Pow(a, 2);
                                Console.Write("Периметр и площадь заданной фигуры - ");
                                Console.WriteLine("P = -, S = {0} ", area);
                                break;

                            case 'п':
                                Console.Write("Введите стороны прямоугольника: а, б ");
                                a = int.Parse(Console.ReadLine());
                                b = int.Parse(Console.ReadLine());
                                per = 2 * (a + b);
                                area = a * b;
                                Console.Write("Периметр и площадь заданной фигуры - ");
                                Console.WriteLine("P = {0}, S = {1} ", per, area);
                                break;

                            case 'т':
                                Console.Write("Введите стороны треугольника: а, б, с");
                                a = int.Parse(Console.ReadLine());
                                b = int.Parse(Console.ReadLine());
                                c = int.Parse(Console.ReadLine());
                                per = a + b + c;
                                double pPer = (per * 1.0 / 2);
                                area = Math.Sqrt((pPer * (pPer - a) * (pPer - b) * (pPer - c)));
                                Console.Write("Периметр и площадь заданной фигуры - ");
                                Console.WriteLine("P = {0}, S = {1} ", per, area);
                                break;

                            default: Console.WriteLine("Введен неправильный символ!"); break;
                        };
                        Console.ReadLine();
                        goto Menu;

                    default: Console.WriteLine("This number is not right!!!"); break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат!!!");
                return;
            }
            finally
            {
                Console.WriteLine("Finally");
            }
            Console.ReadKey();
        }
    }
}
