using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Обобщения
{
    public class StackFixed<T>
    {
        private int _currentSize; // текущий размер стека
        private T[] _dataArray; // данные стека
        private int _stackMaxSize; //максимальное количество элементов в стеке
                                   // конструктор
        public StackFixed(int stackMaxSize)
        {
            _dataArray = new T[stackMaxSize];
            _currentSize = 0;
            _stackMaxSize = stackMaxSize;
        }

        // метод для получения размера стека
        public int Size()
        {
            return _currentSize;
        }

        // добавление нового элемента
        public void Push(T item)
        {
            // если текущий размер равен максимальному, то смещаем стек на одну позицию
            // при этом первый элемент удаляется
            if (_currentSize == _stackMaxSize)
            {
                RebuildData();
            }

            _dataArray[_currentSize] = item;
            _currentSize++;
        }

        // чтение главного элемента стека без удаления
        public T Peek()
        {
            // если данных нет, выбрасываем исключение
            if (Size() == 0)
            {
                throw new Exception("Stack is empty");
            }

            return _dataArray[_currentSize - 1];
        }

        // извлечение элемента
        public T Pop()
        {
            var item = Peek();
            _currentSize--;
            return item;
        }

        // очистка стека
        public void Clear()
        {
            _dataArray = new T[_stackMaxSize];
            _currentSize = 0;
        }

        private void RebuildData()
        {
            var newData = new T[_stackMaxSize];
            for (var i = 1; i < _dataArray.Length; i++)
            {
                newData[i - 1] = _dataArray[i];
            }

            _dataArray = newData;
            _currentSize = _stackMaxSize - 1;
        }
    }
}
