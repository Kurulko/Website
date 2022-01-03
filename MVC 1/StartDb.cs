using MVC_1.Models.Abstract;
using MVC_1.Models.Abstract.Schedule;
using MVC_1.Models.Database;
using MVC_1.Models.Deadline;
using MVC_1.Models.Rating;
using MVC_1.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_1
{
    public static class StartDb
    {
        public static void Initialize(IBTSMContext context)
        {
            if (!context.People.Any() || !context.Students.Any() ||
                !context.HighMathScores.Any() || !context.OTKScores.Any()
                || !context.PhilosophyScores.Any() || !context.KompBazaScores.Any()
                || !context.MetrologiaScores.Any())
            {
                int countOfStudents = 17;

                Person[] people = {
                    new Person() { Age = 18, OnBudget = true, OnStepa = false, Pseudonym = "Экс", Email = "chura.mediatek.59@gmail.com" },
                    new Person() { Age = 18, OnBudget = true, OnStepa = false, Pseudonym = "-", Email = "derkachivan2003@gmail.com" },
                    new Person() { Age = 18, OnBudget = true, OnStepa = false, Pseudonym = "Жулик", Email = "zhulikax@gmail.com" },
                    new Person() { Age = 18, OnBudget = true, OnStepa = true, Pseudonym = "На деревi", Email = "alsachokal@gmail.com" },
                    new Person() { Age = 18, OnBudget = true, OnStepa = false, Pseudonym = "Криптоинвестор", Email = "igoresco25@gmail.com" },
                    new Person() { Age = 19, OnBudget = true, OnStepa = true, Pseudonym = "Биткоинмэн", Email = "borismakitski@gmail.com" },
                    new Person() { Age = 21, OnBudget = true, OnStepa = true, Pseudonym = "Прогер", Email = "stefanmartinuk@gmail.com" },
                    new Person() { Age = 18, OnBudget = true, OnStepa = true, Pseudonym = "Ьатя", Email = "kurul300013@gmail.com" },
                    new Person() { Age = 18, OnBudget = true, OnStepa = false, Pseudonym = "-", Email = "maxpyro97@gmail.com" },
                    new Person() { Age = 18, OnBudget = true, OnStepa = false, Pseudonym = "-", Email = "sasha200201123456@gmail.com" },
                    new Person() { Age = 18, OnBudget = false, OnStepa = false, Pseudonym = "Блефмэн", Email = "ryzhko76@gmail.com" },
                    new Person() { Age = 18, OnBudget = true, OnStepa = false, Pseudonym = "ГДЗмэн", Email = "suhyi.dmitriy@gmail.com" },
                    new Person() { Age = 18, OnBudget = true, OnStepa = false, Pseudonym = "Битмейкер", Email = "4059529@gmail.com" },
                    new Person() { Age = 18, OnBudget = true, OnStepa = false, Pseudonym = "-", Email = "volodar.f@gmail.com" },
                    new Person() { Age = 18, OnBudget = true, OnStepa = true, Pseudonym = "Машина", Email = "Mihaforever102@gmail.com" },
                    new Person() { Age = 18, OnBudget = true, OnStepa = false, Pseudonym = "Beerмэн", Email = "antonio233619@gmail.com" },
                    new Person() { Age = 19, OnBudget = true, OnStepa = false, Pseudonym = "ДОТЕР", Email = "yaroclav.208@gmail.com" }
                };
                foreach (Person person in people)
                {
                    context.People.Add(person);
                    context.SaveChanges();
                }


                HighMath[] highMaths = new HighMath[countOfStudents];
                OTK[] oTKs = new OTK[countOfStudents];
                Philosophy[] philosophies = new Philosophy[countOfStudents];
                KompBaza[] kompBazas = new KompBaza[countOfStudents];
                Metrologia[] metrologias = new Metrologia[countOfStudents];

                for (int i = 0; i < countOfStudents; i++)
                {
                    highMaths[i] = new HighMath { SR = $"{i}" };
                    oTKs[i] = new OTK { DZ = $"{i}", KR = $"{i}", Laba = $"{i}" };
                    philosophies[i] = new Philosophy { Seminar = $"{i}" };
                    kompBazas[i] = new KompBaza { KR = $"{i}", Laba = $"{i}" };
                    metrologias[i] = new Metrologia { DZ = $"{i}", KR = $"{i}", Laba = $"{i}" };
                }

                for (int i = 0; i < countOfStudents; i++)
                {
                    context.HighMathScores.Add(highMaths[i]);
                    context.OTKScores.Add(oTKs[i]);
                    context.PhilosophyScores.Add(philosophies[i]);
                    context.KompBazaScores.Add(kompBazas[i]);
                    context.MetrologiaScores.Add(metrologias[i]);

                    context.SaveChanges();
                }


                Student[] students = {
                    new Student() { FirstName = "Олександр", LastName = "Гуменюк"  ,Person = people[0], HighMath = highMaths[0], OTK = oTKs[0], Philosophy = philosophies[0], KompBaza = kompBazas[0], Metrologia = metrologias[0]},
                    new Student() { FirstName = "Іван", LastName = "Деркач"        ,Person = people[1], HighMath = highMaths[1], OTK = oTKs[1], Philosophy = philosophies[1], KompBaza = kompBazas[1], Metrologia = metrologias[1]},
                    new Student() { FirstName = "Євгеній", LastName = "Жулінський" ,Person = people[2], HighMath = highMaths[2], OTK = oTKs[2], Philosophy = philosophies[2], KompBaza = kompBazas[2], Metrologia = metrologias[2]},
                    new Student() { FirstName = "Олександр", LastName = "Іванчук"  ,Person = people[3], HighMath = highMaths[3], OTK = oTKs[3], Philosophy = philosophies[3], KompBaza = kompBazas[3], Metrologia = metrologias[3]},
                    new Student() { FirstName = "Ігор", LastName = "Картель"       ,Person = people[4], HighMath = highMaths[4], OTK = oTKs[4], Philosophy = philosophies[4], KompBaza = kompBazas[4], Metrologia = metrologias[4]},
                    new Student() { FirstName = "Борис", LastName = "Макицький"    ,Person = people[5], HighMath = highMaths[5], OTK = oTKs[5], Philosophy = philosophies[5], KompBaza = kompBazas[5], Metrologia = metrologias[5]},
                    new Student() { FirstName = "Стефан", LastName = "Мартинюк"    ,Person = people[6], HighMath = highMaths[6], OTK = oTKs[6], Philosophy = philosophies[6], KompBaza = kompBazas[6], Metrologia = metrologias[6]},
                    new Student() { FirstName = "Кирил", LastName = "Мостовий"     ,Person = people[7], HighMath = highMaths[7], OTK = oTKs[7], Philosophy = philosophies[7], KompBaza = kompBazas[7], Metrologia = metrologias[7]},
                    new Student() { FirstName = "Максим", LastName = "Пирожков"    ,Person = people[8], HighMath = highMaths[8], OTK = oTKs[8], Philosophy = philosophies[8], KompBaza = kompBazas[8], Metrologia = metrologias[8]},
                    new Student() { FirstName = "Олександр", LastName = "Речун"    ,Person = people[9], HighMath = highMaths[9], OTK = oTKs[9], Philosophy = philosophies[9], KompBaza = kompBazas[9], Metrologia = metrologias[9]},
                    new Student() { FirstName = "Дмитро", LastName = "Рижко"       ,Person = people[10], HighMath = highMaths[10], OTK = oTKs[10], Philosophy = philosophies[10], KompBaza = kompBazas[10], Metrologia = metrologias[10]},
                    new Student() { FirstName = "Дмитро", LastName = "Сухий"       ,Person = people[11], HighMath = highMaths[11], OTK = oTKs[11], Philosophy = philosophies[11], KompBaza = kompBazas[11], Metrologia = metrologias[11]},
                    new Student() { FirstName = "Олександр", LastName = "Ткаченко" ,Person = people[12], HighMath = highMaths[12], OTK = oTKs[12], Philosophy = philosophies[12], KompBaza = kompBazas[12], Metrologia = metrologias[12]},
                    new Student() { FirstName = "Володар", LastName = "Фалюш"      ,Person = people[13], HighMath = highMaths[13], OTK = oTKs[13], Philosophy = philosophies[13], KompBaza = kompBazas[13], Metrologia = metrologias[13]},
                    new Student() { FirstName = "Михайло", LastName = "Хлоп'янець" ,Person = people[14], HighMath = highMaths[14], OTK = oTKs[14], Philosophy = philosophies[14], KompBaza = kompBazas[14], Metrologia = metrologias[14]},
                    new Student() { FirstName = "Антоніо", LastName = "Цимпу"      ,Person = people[15], HighMath = highMaths[15], OTK = oTKs[15], Philosophy = philosophies[15], KompBaza = kompBazas[15], Metrologia = metrologias[15]},
                    new Student() { FirstName = "Ярослав", LastName = "Ясінський"  ,Person = people[16], HighMath = highMaths[16], OTK = oTKs[16], Philosophy = philosophies[16], KompBaza = kompBazas[16], Metrologia = metrologias[16]}
                };
                foreach (Student student in students)
                {
                    context.Students.Add(student);
                    context.SaveChanges();
                }
            }

            if (!context.News.Any())
            {
                News[] news = new News[17];

                for (int i = 0; i < news.Length; i++)
                {
                    news[i] = new News { Message = $"Some message bla bla #{i}", NameArticle = $"Name #{i}" };
                }

                foreach (var item in news)
                {
                    context.News.Add(item);
                    context.SaveChanges();
                }
            }

            if (!context.Links.Any())
            {
                Place[] places = {
                    new Place() { NameTeacher = "Масютка", NameSubject = "Матеша", Link = "https://meet.google.com/yvt-qdvz-yjp?hs=224" },
                    new Place() { NameTeacher = "Фесенко", NameSubject = "ОТК Лекция", Link = "https://us04web.zoom.us/j/7357075849?pwd=c2hJekVaY21yTnpwUldpMUgwYXo2QT09" },
                    new Place() { NameTeacher = "Коломиец", NameSubject = "ОТК Семинар", Link = "https://us02web.zoom.us/j/3154148397?pwd=ZjBlZjNGejVGVFZIZzkvWWRnamhVZz09" },
                    new Place() { NameTeacher = "Кельник", NameSubject = "Метрология Лекция", Link = "https://us02web.zoom.us/j/83479049763?pwd=ejF1SE81ZDQxdEsyY1UxQ2RUNmI5dz09" },
                    new Place() { NameTeacher = "Богданов", NameSubject = "Метрология лаьа", Link = "http://google.com" },
                    new Place() { NameTeacher = "Загороднюк", NameSubject = "Философия", Link = "https://meet.google.com/hpu-efmg-fde" },
                    new Place() { NameTeacher = "Ьорецкий", NameSubject = "Комп ьаза", Link = "https://meet.google.com/jtk-wpws-qvw?hs=224" },
                    new Place() { NameTeacher = "Аспирант", NameSubject = "Комп ьаза лаьа", Link = "https://discord.com" },
                    new Place() { NameTeacher = "NoName", NameSubject = "Zero", Link = "https://meet.google.com/jtk-wpws-qvw?hs=224" }
                };

                foreach (Place place in places)
                {
                    context.Links.Add(place);
                    context.SaveChanges();
                }
            }
            if (!context.Time.Any())
            {
                Timer[] timers = {
                    new Timer() { StartHours = 8, StartMinutes = 40, EndHours = 10, EndMinutes = 15 },
                    new Timer() { StartHours = 10, StartMinutes = 35, EndHours = 12, EndMinutes = 10 },
                    new Timer() { StartHours = 12, StartMinutes = 20, EndHours = 13, EndMinutes = 55 },
                    new Timer() { StartHours = 14, StartMinutes = 5, EndHours = 15, EndMinutes = 40 }
                };

                foreach (var item in timers)
                {
                    context.Time.Add(item);
                    context.SaveChanges();
                }
            }
            if (!context.DeadLines.Any())
            {
                Homework[] homeworks = new Homework[5];

                for (int i = 0; i < homeworks.Length; i++)
                {
                    homeworks[i] = new Homework { LastTime = "Today", Task = $"{i}^2 = ?", Link = "https://www.google.com" };
                }

                foreach (Homework homework in homeworks)
                {
                    context.Homeworks.Add(homework);
                    context.SaveChanges();
                }


                DeadLine[] deadLines = new DeadLine[homeworks.Length];

                for (int i = 0; i < deadLines.Length; i++)
                {
                    deadLines[i] = new DeadLine
                    {
                        Homework = homeworks[i],
                        NameSubject = $"Subject #{i}"
                    };
                }

                foreach (var item in deadLines)
                {
                    context.DeadLines.Add(item);
                    context.SaveChanges();
                }
            }
        }
    }
}
