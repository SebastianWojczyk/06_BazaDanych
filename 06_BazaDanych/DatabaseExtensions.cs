using System;

namespace _06_BazaDanych
{
    partial class Person
    {
        public override string ToString()
        {
            return string.Format("{0} (ur. {1})",
                                 Name,
                                 BDate.ToLongDateString());
        }

        public Person(string Name, DateTime BDate) : this()
        {
            this.Name = Name;
            this.BDate = BDate;
        }
    }
}