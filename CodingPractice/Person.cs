using Microsoft.VisualBasic;
using System;

namespace case1
{
    class Person
    {
        private string _name;

        public string Name { get { return _name; } set { _name = value; } }
    }
}

namespace case2
{
    class Person
    {
        private int _birthYear;

        public string Name { get; set; }
        public int BirthYear
        {
            set
            {
                if(value >= 1900)
                {
                    this._birthYear = value;
                }
            }
        }
        public int Age { get { return DateTime.Now.Year - this._birthYear; } }
    }
}