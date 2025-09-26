using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp3
{
    class FootballTeam
    {
        public string Name { get; set; } //Название команд
        public string Coach { get; set; } //Тренер команды
        public int Points { get; set; } //Количество набранных очков
        public int Place { get; set; } //Текущее место

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // создаем коллекцию объектов FootballTeam
            List<FootballTeam> teams = new List<FootballTeam>();

            // заносим объекты в коллекцию
            teams.Add(new FootballTeam()
            {
                Name = "Метеор",
                Coach = "Иванов",
                Points = 12,
                Place = 10
            });
            teams.Add(new FootballTeam()
            {
                Name = "Вымпел",
                Coach = "Петров",
                Points = 16,
                Place = 7
            });
            teams.Add(new FootballTeam()
            {
                Name = "Комета",
                Coach = "Сидоров",
                Points = 25,
                Place = 1
            });
            teams.Add(new FootballTeam()
            {
                Name = "Арсенал",
                Coach = "Григорьев",
                Points = 22,
                Place = 4
            });
            teams.Add(new FootballTeam()
            {
                Name = "Буровик",
                Coach = "Дорогин",
                Points = 18,
                Place = 6
            });

            Show(teams, "Начальное содержание");

            // вставляем перед объектом с Названием = Комета новый объект
            int cometIndex = teams.FindIndex(t => t.Name == "Комета");
            if (cometIndex != -1)
            {
                teams.Insert(cometIndex, new FootballTeam()
                {
                    Name = "Звезда",
                    Coach = "Тетерин",
                    Points = 14,
                    Place = 9
                });
            }
            Show(teams, "Вставлена команда Звезда перед Кометой");

        }
        static void Show(List<FootballTeam> col, string comment)
        {
            Console.Write("//////////////");
            Console.Write(" " + comment + " ");
            Console.WriteLine("//////////////");
            // цикл по объектам коллекции
            foreach (FootballTeam team in col)
            {
                Console.Write($"Индекс = {col.IndexOf(team)}; ");
                Console.WriteLine($"Команда: {team.Name}, Тренер: {team.Coach}, Очки: {team.Points}, Место: {team.Place}");
            }
            Console.WriteLine();
        }

    }
}
