using System;

namespace OOPTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerHealth = 100;
            float playerSpeed = 10f;
            Player player = new Player("Alex", playerHealth, playerSpeed);

            player.ShowInfo();
        }
    }

    class Player
    {
        private string _name;
        private int _health;
        private float _speed;

        public Player(string name, int health, float speed)
        {
            _name = name;
            _health = health;
            _speed = speed;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Игрок - {_name} , Здоровье - {_health} , Скорость {_speed}");
        }
    }
}
