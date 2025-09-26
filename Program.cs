using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            List<FootballTeam> FootballTeams = new List<FootballTeam>();
        }
    }
}
