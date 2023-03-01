using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task2
{
    class Persons
    {
        public delegate void PersonsHandler(Persons sender, PersonsEventArgs e);
        public event PersonsHandler? Notify;

        public byte Num { get; private set; }

        public List<string> Surnames { get; set; }

        public Persons(List<string> surnames) => Surnames = surnames;

        public void SetNumber(byte num)
        {
            if (num != 1 && num != 2)
                throw new ArgumentNonDigitalException("Введенное значение не является цифрой 1 или 2");
            Num = num;
            Notify?.Invoke(this, new PersonsEventArgs(num));
        }

    }
}
