using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ8
{
        // Класс представляющий задачу
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

            // Назначает задачу исполнителю и меняет статус на "В работе"
            public void Take(Person person)
            {
                Assignee = person;
                Status = TaskStatus.InProgress;
            }

            // Добавляет отчет к задаче и меняет статус на "На проверке"
            public void AddReport(Report report)
            {
                Reports.Add(report);
                Status = TaskStatus.UnderReview;
            }
        }
}
