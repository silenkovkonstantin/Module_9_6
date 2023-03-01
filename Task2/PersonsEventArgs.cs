using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class PersonsEventArgs
    {
        public byte Num { get; } // Число введенное пользователем

        public PersonsEventArgs(byte num)
        {
            Num = num;
        }

    }
}
