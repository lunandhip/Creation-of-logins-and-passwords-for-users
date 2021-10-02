using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; //Для усыпления потока


    class Boss
    {
        static void Main()
        {
            Console.Title = "Это сделал Hyla!   v1.8";
            for (int index1 = 0; index1 < 100; ++index1) // Чтобы програма не закрывалась после выполнения
            {
                Console.WriteLine("Генерировать пароли - Enter");
                Console.WriteLine("Создать пользака - Вводи ФИО");
                string fame1 = Console.ReadLine(); // Вбираем фамилию либо энтер дял паролей
                Console.WriteLine();
                if (fame1 == "") // Генерация паролей
                {
                    bool exit = false; // Чтобы выйти из цикла генерации паролей
                    while (!exit)
                    {
                        if (fame1 == "1")
                        {
                            exit = true;
                        }
                        else
                        {
                            for (int t = 0; t < 5; t++)
                            {
                                double a = t % 2;
                                if (a == 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                }
                                string Pass = Password.MagicZone(); // Обращаемся к генератору паролей
                                Console.WriteLine(Pass); // Выводим пароль
                                Console.ResetColor();
                                Thread.Sleep(5); //Подмораживаем поток чтобы сгенить новый пароль
                                Console.WriteLine(); // Разрыв между паролем
                            }
                            Console.WriteLine("================================");
                            Console.WriteLine("Еще-Enter,Выход-1;");
                            fame1 = Console.ReadLine();
                        } // Генерация 5 паролей
                    }

                } //Генерация пароля
                else if (fame1 == "Hyla")
                {
                    Hyla Frog = new Hyla();
                    Frog.show();
                } // Блок Hyla
                else// Генерация пользака
                {
                string[] NUserFIO = fame1.Split(' '); // Превращаем логин в массив
                        
                string fame = NUserFIO[0].ToLower(); // Делаем фамилию в нижний регистр
                string name = NUserFIO[1].ToLower(); // Делаем имя в нижний регистр
                    Console.WriteLine("Город(1-Крас,2-Астр,3-Соч,4-Таг,5-Арм)");
                    string email = ""; // шобы записать мыло
                    bool genlog = false; // Чтобы снова обрашивать на город

                    while (!genlog)
                    {
                        string Cities = Console.ReadLine(); ///вводим город
                        if (Cities == "1")
                        {
                            email = "@krasnodar.2gis.ru";
                            genlog = true;
                        }
                        else if (Cities == "2")
                        {
                            email = "@astrakhan.2gis.ru";
                            genlog = true;
                        }
                        else if (Cities == "3")
                        {
                            email = "@sochi.2gis.ru";
                            genlog = true;
                        }
                        else if (Cities == "4")
                        {
                            email = "@taganrog.2gis.ru";
                            genlog = true;
                        }
                        else if (Cities == "5")
                        {
                            email = "@armv.2gis.ru";
                            genlog = true;
                        }
                        else // Нуливой блок чтобы не падать в необрабатываемую ошибку
                        {

                        }
                    }
                    Translit translit = new Translit(); // При помощи словаря который ниже преводим все в другие буквы
                    string ENfame = translit.MagicZone(fame); // полуфамилия
                    string ENname = translit.MagicZone(name); // полулогин
                    
                    string subENname = "."; // Нужна для разделителя
                    ENname = ENname.Insert(2, subENname); // Вставляем точку после второго знака

                    var login = ENname.Remove(ENname.IndexOf('.'));
                    string loginemail = login + "." + ENfame + email;
                    login = login + "." + ENfame;

                    Console.WriteLine("***");
                    Console.WriteLine("");
                    string Pass = Password.MagicZone();


                    Console.WriteLine(login + "\t" + "\t" + "\t" + Pass); //Выводим на экран имя английскими буквами
                    Console.WriteLine(loginemail + "\t" + Pass);
                    Console.WriteLine("");
                    Console.WriteLine("***");
                } // Генерация пользака
            }
        }
    }