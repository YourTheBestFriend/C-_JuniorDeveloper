using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace исключения_2_class
{
    class SpravochSystem
    {
        // Список Рейсов
        private List<Reis> listReis;
        // Совойство
        public List<Reis> ListReis
        {
            get => listReis;
            set { listReis = value; }
        }
        // Чисто принимаю список
        public SpravochSystem(List<Reis> listReis)
        {
            this.listReis = listReis;   
        }
        // Либо сами рейсы и записываю в список
        public SpravochSystem(params Reis[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                listReis.Add(x[i]);
            }
        }
        // функция которая выводит доступные рейсы до введенного времени
        int hour, minute, reserve_time;
        public void printReisTime(int time, string punktNaznash_)
        {
            // Я решил сделать так
            // time = 22:12
            // hour = time[0] * 10 + time[1]
            // minunute time[3] * 10 + time[4]
            // привожу все к минутам (время прибытия - время отбытия < time) // time принимается в минутах

            for (int i = 0; i < listReis.Count; i++)
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
        }
    }
}
