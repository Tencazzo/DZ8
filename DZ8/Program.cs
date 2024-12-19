using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ8
{
    //Сделал пояснения для каждого метода и класса чтобы было понятнее 
        public class Program
        {
        public static void Main(string[] args)
        {
            Person manager = new Person("Камиль");
            Person teamLead = new Person("Эмиль");
            Person developer1 = new Person("Сергей");
            Person developer2 = new Person("Алексей");
            Person developer3 = new Person("Ирина");
            Person developer4 = new Person("Ольга");
            Person developer5 = new Person("Дмитрий");
            Person developer6 = new Person("Елена");
            Person tester1 = new Person("Анна");
            Person tester2 = new Person("Максим");
            Person tester3 = new Person("Юлия");

            // Создаем проект
            Project project = new Project("Разработка нового приложения", manager, teamLead);
            project.SetDeadline(DateTime.Now.AddMonths(1));
            project.Start();

            // Добавляем задачи
            project.AddTask("Создание макета", developer1);
            project.AddTask("Разработка бэкенда", developer2);
            project.AddTask("Тестирование приложения", tester1);
            project.AddTask("Создание документации", developer3);
            project.AddTask("Настройка окружения", developer4);
            project.AddTask("Разработка фронтенда", developer5);
            project.AddTask("Интеграция с API", developer6);
            project.AddTask("Разработка пользовательских тестов", tester2);
            project.AddTask("Оптимизация производительности", developer1);
            project.AddTask("Подготовка к релизу", tester3);

            // Выполняем задачи
            Task task1 = project.Tasks[0];
            task1.Take(developer1);
            }
        }
}
