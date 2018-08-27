using System;
using System.Collections.Generic;

namespace lightning_exercise
{

    public class Person

    {
        protected string _firstName;

        protected string _lastName;

        public string NamePrinter { get => $"{_firstName} {_lastName}"; }
    }
}