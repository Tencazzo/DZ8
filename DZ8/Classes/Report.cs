using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ8
{
        // Класс представляющий отчет
        public class Report
        {
            public string Title { get; private set; }
            public string Text { get; private set; }
            public Person Author { get; private set; }
            public DateTime SubmissionDate { get; private set; }

            // Конструктор
            public Report(string title, string text, Person author)
            {
                Title = title;
                Text = text;
                Author = author;
                SubmissionDate = DateTime.Now;
            }
        }
}
