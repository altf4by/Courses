using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class DynamicArray
    {
        int[] _array;
        public int Сount { get; private set; }

        public DynamicArray()
        {
            _array = new int[4];
        }

        public DynamicArray(int size)
        {
            _array = new int[size];
        }

        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < Сount)
                    return _array[index];
                else
                {
                    Console.WriteLine($"{index} - Incorrect index");
                    return int.MaxValue;
                }

            }
            set
            {
                if (index >= 0 && index < _array.Length)
                    _array[index] = value;
            }
        }

        public void Add(int value)
        {
            if (_array.Length == Сount)
            {
                int[] temp = new int[_array.Length * 2];
                Array.Copy(_array, temp, _array.Length);
                _array = temp;
            }
            _array[Сount] = value;

            Сount++;
        }

        public void AddRange(params int[] addedArray)
        {
            if ((Сount + addedArray.Length) > _array.Length)
            {
                int newSize = _array.Length;
                while ((addedArray.Length + Сount) > newSize)
                    newSize *= 2;

                Array.Resize(ref _array, newSize);
            }
            addedArray.CopyTo(_array, Сount);
            Сount += addedArray.Length;

            //foreach (var cell in addedArray)
            //{
            //    _array[counter] = addedArray[i];
            //    i++;
            //    counter++;
            //}
            //2-nd variant of copying...
            //addedArray.CopyTo(_array, counter);
            //counter += addedArray.Length;
        }

        public void Insert(int value, int index)
        {
            if (index >= 0 && index < _array.Length && Сount < _array.Length)
            {
                int[] tempArr = new int[Сount - index];
                Array.Copy(_array, index, tempArr, 0,tempArr.Length);
                _array[index] = value;
                AddRange(tempArr);              
            }
            else Console.WriteLine("Index have to be in the range of the Counter");
        }
        public void RemoveAt(int index)
        {
            if (index >= 0 && index < _array.Length && Сount < _array.Length)
            {
                int[] tempArr = new int[Сount - index-1];
                Array.Copy(_array, index+1, tempArr, 0, tempArr.Length);
                Сount = index;
                AddRange(tempArr);
            }
        }

        public void BubbleSort(bool typeOfSort)
        {
            int temp = 0;
            bool isEnterAllowed = true;

            int length = _array.Length;
            while (isEnterAllowed)
            {
                isEnterAllowed = false;
                for (int i = 1; i < length; i++)
                {
                    if (typeOfSort? (_array[i - 1] > _array[i]):(_array[i - 1] < _array[i]))
                    {
                        temp = _array[i - 1];
                        _array[i - 1] = _array[i];
                        _array[i] = temp;
                        isEnterAllowed = true;
                    }
                }
                length--;
            }
        }
        public void Clear()
        {
            Array.Clear(_array, 0, _array.Length);
        }
    }
}
