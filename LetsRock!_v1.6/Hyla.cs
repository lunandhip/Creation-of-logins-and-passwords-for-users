﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  class Hyla
    {
        public void show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ква-Ква-Ква!");
            Console.WriteLine("14.02.2020");
            Console.WriteLine("v1.1 Поставил сначала фамилию потом имя.Присылают обычно в формате ФИО.");
            Console.WriteLine("v1.2 Добавил пояснения к городу для удобства");
            Console.WriteLine("v1.3 Убрал ненужное меню. Немого улучшил пояснения для города.Вроде бы решил вопрос с генерацией одинаковых паролей");
            Console.WriteLine("v1.4 Придумал новый генератор пароля.Он завязан на циклах.Цвет изменяется благодаря остатку от деления.В 1.3 \nпросахатил описание для пользователя выхода из генерации пароля.Вот, вернул.Я узнал про спецсимвол t.Теперь пароль на одинаковом удалении");
            Console.WriteLine("v1.5.1 Сделал такой же генератор для пользователя, нужно разобраться как положить это в отдельный класс.");
            Console.WriteLine("v1.6 Генератор паролей доведен до идеала. Он генерирует блоки маленьких букв добавляет на место 1-2 букву или цифру и наоборот на вторую тоже. Распихал часть программы по классам. Наконец-то!");
            Console.WriteLine("v1.7 Теперь генератор пароля выводит пароль на одной сточке с логином");
            Console.WriteLine("v1.8 Можно ввести просто ФИО. Я прикрутил сплитование в массив по пробелу. Считаю что это заслуживает новой версии");    

            Console.ResetColor();
        }
    }