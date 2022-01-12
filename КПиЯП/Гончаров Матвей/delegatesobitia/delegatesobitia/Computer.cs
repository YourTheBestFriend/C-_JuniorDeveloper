using System;
using System.Collections.Generic;
using System.Text;

namespace delegatesobitia
{
    class Computer
    {
        public delegate void PushCaps(string message);
        public event PushCaps Notify;
        public void Push(string key)
        {
            if (key == "Double click")
            {
                Notify?.Invoke($"Нажата клавиша Double click");
            }
        }
    }
}
