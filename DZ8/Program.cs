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
                Person developer = new Person("Сергей");

                // Создаем проект
                Project project = new Project("Разработка нового приложения", manager, teamLead);
                project.SetDeadline(DateTime.Now.AddMonths(1));
                project.Start();

                // Добавляем задачи
                project.AddTask("Создание макета", developer);
                project.AddTask("Разработка бэкенда", developer);

                // Выполняем задачи
                Task task1 = project.Tasks[0];
                task1.Take(developer);
                task1.AddReport(new Report("Отчет по макету", "Макет завершен.", developer));

                // Проверяем
                if (project.IsCompleted())
                {
                    project.Close();
                }
                else
                {
                    Console.WriteLine("Проект еще не завершен.");
                }
            }
        }
}
