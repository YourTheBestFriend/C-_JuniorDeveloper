using System;
using System.Collections.Generic;
using System.Text;

namespace delegatesobitia
{
    class ServiceSubscriber
    {
        string alreadySigned = "Вы уже подписаны на данную услугу";
        string subscribe = "Вы подписались на услугу";
       
        public delegate void GetMessage(string s);
        public event GetMessage OnSubscribe;
        public event GetMessage OnAlreadySigned;
        public event GetMessage OnInvalid;
        NewsOperator catalog;
        public ServiceSubscriber(NewsOperator catalog)
        {
            this.catalog = catalog;
        }
        public void Subscribe()
        {
            Console.WriteLine("Выберите услугу: \n1 - новости\n2 - погода\n3 - спорт\n4 - происшествия\n5 - юмор");
            try
            {
                int p = Convert.ToInt32(Console.ReadLine());
                switch (p)
                {
                    case 1:
                        if (catalog.NewsStatus)
                        {
                            OnAlreadySigned(alreadySigned);
                        }
                        else
                        {
                            catalog.NewsStatus = true;
                            OnSubscribe(subscribe + " новости");
                        }
                        break;
                    case 2:
                        if (catalog.WeatherStatus)
                        {
                            OnAlreadySigned(alreadySigned);
                        }
                        else
                        {
                            catalog.WeatherStatus = true;
                            OnSubscribe(subscribe + " погода");
                        }
                        break;
                    case 3:
                        if (catalog.SportStatus)
                        {
                            OnAlreadySigned(alreadySigned);
                        }
                        else
                        {
                            catalog.SportStatus = true;
                            OnSubscribe(subscribe + " спорт");
                        }
                        break;
                    case 4:
                        if (catalog.incidentsStatus)
                        {
                            OnAlreadySigned(alreadySigned);
                        }
                        else
                        {
                            catalog.incidentsStatus = true;
                            OnSubscribe(subscribe + " происшествия");
                        }
                        break;
                    case 5:
                        if (catalog.humorStatus)
                        {
                            OnAlreadySigned(alreadySigned);
                        }
                        else
                        {
                            catalog.humorStatus = true;
                            OnSubscribe(subscribe + " юмор");
                        }
                        break;
                    default:
                        OnInvalid("Данной услуги не существует");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
