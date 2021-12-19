using System;
using System.Collections.Generic;
using System.Text.RegularExpressions; // Для регулярок 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace исключения_2_class
{
    class SpravochSystem
    {
        // Список Рейсов
        private List<Reis> listReis = new List<Reis>(6);
        // Совойство
        public List<Reis> ListReis
        {
            get => listReis;
            set { listReis = value; }
        }
        // Чисто принимаю список
        public SpravochSystem(List<Reis> listReis)
        {
            if (listReis.Count < 6)
            {
                this.listReis = listReis;
            }
            else
            {
                throw new IndexOutOfRangeException("Список рейсов не может состоять более чем из 5 рейсов");
            }
             
        }
        // Либо сами рейсы и записываю в список
        public SpravochSystem(params Reis[] x)
        {
            if (x.Length < 6)
            {
                for (int i = 0; i < x.Length; i++)
                {
                    listReis.Add(x[i]);
                }
            }
            else
            {
                throw new IndexOutOfRangeException("Список рейсов не может состоять более чем из 5 рейсов");
            }
        }
        // функция которая выводит доступные рейсы до введенного времени 
        public void printReisTime(int time, string punktNaznash_)
        {
            int hour, minute, reserve_time;
            // Я решил сделать так
            // time = 22:12
            // hour = time[0] * 10 + time[1]
            // minunute time[3] * 10 + time[4]
            // привожу все к минутам (время прибытия - время отбытия < time) // time принимается в минутах

            for (int i = 0; i < listReis.Count; i++)
            {
                try
                {
                    Regex rg1 = new Regex(@"\w*((0\d|1\d|2[0-3]):([0-5][0-9])(.*?)?)");
                    if (rg1.IsMatch(listReis[i].Otbitia) && rg1.IsMatch(listReis[i].Pribitia))
                    {
                        // Если подходит пункт назначения
                        if (listReis[i].PlaceNaznach == punktNaznash_)
                        {
                            // Отбытия 
                            hour = Int32.Parse(listReis[i].Otbitia[0].ToString()) * 10 + Int32.Parse(listReis[i].Otbitia[1].ToString());
                            minute = Int32.Parse(listReis[i].Otbitia[3].ToString()) * 10 + Int32.Parse(listReis[i].Otbitia[4].ToString());
                            reserve_time = minute + hour * 60;

                            //Прибытия
                            hour = Int32.Parse(listReis[i].Pribitia[0].ToString()) * 10 + Int32.Parse(listReis[i].Pribitia[1].ToString());
                            minute = Int32.Parse(listReis[i].Pribitia[3].ToString()) * 10 + Int32.Parse(listReis[i].Pribitia[4].ToString());
                            minute += hour * 60; // Тут уже минуты прибытия

                            // (время прибытия - время отбытия)
                            reserve_time = (minute - reserve_time);

                            // Console.WriteLine($"listReis[{i}].PlaceNaznach ==== minuts {reserve_time}"); // это для проверки

                            // Проверяю
                            if (reserve_time < time) // time принимается в минутах
                            {
                                Console.WriteLine(listReis[i]); // Там переопределенный ToStrign и выведет значения
                            }
                        }
                    }
                    else
                    {
                        throw new SpravochSystemException("Вы ввели не коректную строку со временем");
                    }
                }
                catch (SpravochSystemException ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                }
            }
        }
    }
}
