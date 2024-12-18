using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ8
{
    namespace TaskManager
    {
        // Класс участника команды
        public class Person
        {
            public string Name { get; private set; }

            // Конструктор
            public Person(string name)
            {
                Name = name;
            }
        }
    }

}
