using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ8
{
    public class Task
    {
        public string Title { get; private set; }
        public Person Initiator { get; private set; }
        public Person Assignee { get; private set; }
        public List<Report> Reports { get; private set; }
        public TaskStatus Status { get; private set; }

        // Конструктор
        public Task(string title, Person assignee, Project project)
        {
            Title = title;
            Assignee = assignee;
            Initiator = project.TeamLead;
            Reports = new List<Report>();
            Status = TaskStatus.Assigned;
        }

        // Назначает задачу исполнителю и меняет статус
        public void Take(Person person)
        {
            Assignee = person;
            Status = TaskStatus.InProgress;
        }

        // Добавляет отчет к задаче и меняет статусlj,fdbk 
        public void AddReport(Report report)
        {
            Reports.Add(report);
            Status = TaskStatus.UnderReview;
        }

        // Делегирует задачу другому участнику
        public void Delegate(Person newAssignee)
        {
            if (Status == TaskStatus.Assigned || Status == TaskStatus.InProgress)
            {
                Assignee = newAssignee;
                Console.WriteLine($"Задача '{Title}' делегирована {newAssignee.Name}.");
            }
            else
            {
                Console.WriteLine("Задачу нельзя делегировать, когда она находится в статусе 'На проверке' или 'Завершена'.");
            }
        }
    }
}
