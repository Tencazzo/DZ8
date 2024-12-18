using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodichka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 9.1-9.3");
            using (BankAccount account = new BankAccount(AccountType.Savings))
            {
                account.Deposit(1000);
                account.Withdraw(500);
                account.Withdraw(200);

                Console.WriteLine($"Баланс счета: {account.Balance}");
            }


                Console.WriteLine("Домашнее задание 9.1");
                Console.WriteLine("Обновленная песня");

                var songs = new List<Song>
        {
            new Song("Песня 'Дождь'", "Автор - Дождливый"),
            new Song("Песня 'Восход'", "Автор - Восход"),
            new Song("Песня 'Торнадо'", "Автор - Тор"),
            new Song("Песня 'Туман'", "Автор - Тумаков")
        };

                PrintSongs(songs);

                var isEqual = songs[0].Equals(songs[1]);
                Console.WriteLine(isEqual
                    ? "Первая и вторая песни в списке равны."
                    : "Первая и вторая песни в списке не равны.");

                var mySong = new Song();
                Console.WriteLine("Создана mySong с названием: " + mySong);

                Console.WriteLine("Нажмите любую клавишу для выхода.");
                Console.ReadKey();
            }

            static void PrintSongs(List<Song> songs)
            {
                foreach (var song in songs)
                {
                    Console.WriteLine("Название: " + song);
                }
            }
        }
    }
