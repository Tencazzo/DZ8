using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ8
{
        // Класс представляющий проект
        public class Project
        {
            public string Title { get; private set; }
            public DateTime Deadline { get; private set; }
            public Person ProjectManager { get; private set; }
            public Person TeamLead { get; private set; }
            public List<Task> Tasks { get; private set; }
            public ProjectStatus Status { get; private set; }

        // Конструктор
        public Project(string title, Person projectManager, Person teamLead)
            {
                Title = title;
                ProjectManager = projectManager;
                TeamLead = teamLead;
                Tasks = new List<Task>();
                Status = ProjectStatus.Draft;
            }

            //Срок выполнения
            public void SetDeadline(DateTime deadline)
            {
                Deadline = deadline;
            }

            // Добавляет задачу в проект если статус Черновик
            public void AddTask(string title, Person assignee)
            {
                if (Status == ProjectStatus.Draft)
                {
                    var task = new Task(title, assignee, this);
                    Tasks.Add(task);
                }
                else
                {
                    Console.WriteLine("Невозможно добавить задачи, когда проект не в статусе 'Черновик'.");
                }
            }

            // Меняет статус проекта на Активный
            public void Start()
            {
                Status = ProjectStatus.Active;
            }

            // Проверяет выполнены ли все задачи проекта
            public bool IsCompleted() => Tasks.TrueForAll(t => t.Status == TaskStatus.Completed);

            // Закрывает проект если все задачи выполнены
            public void Close()
            {
                if (IsCompleted())
                {
                    Status = ProjectStatus.Closed;
                    Console.WriteLine("Проект теперь закрыт.");
                }
                else
                {
                    Console.WriteLine("Невозможно закрыть проект. Не все задачи выполнены.");
                }
            }
        }
}
