using System;
using System.Collections.Generic;
using System.Text;

namespace delegatesobitia
{
    class NewsOperator
    {
        public delegate void GetMessage(string s);
        public event GetMessage OnAddNew;
        List<String> news = new List<string>();
        public bool NewsStatus = false;
        List<String> weather = new List<string>();
        public bool WeatherStatus = false;
        List<String> sport = new List<string>();
        public bool SportStatus = false;
        List<String> incidents = new List<string>();
        public bool incidentsStatus = false;
        List<String> humor = new List<string>();
        public bool humorStatus = false;
        public void AddNew(string n)
        {
            news.Add(n);
            if (NewsStatus)
            {
                OnAddNew(n);
            }  
        }
        public void AddWeather(string w)
        {
            weather.Add(w);
            if (WeatherStatus)
            {
                OnAddNew(w);
            }
        }
        public void AddSport(string s)
        {
            sport.Add(s);
            if (SportStatus)
            {
                OnAddNew(s);
            }
        }
        public void AddIncident(string i)
        {
            incidents.Add(i);
            if (incidentsStatus)
            {
                OnAddNew(i);
            }
        }
        public void AddHumor(string h)
        {
            humor.Add(h);
            if (humorStatus)
            {
                OnAddNew(h);
            }
        }
    }
}
