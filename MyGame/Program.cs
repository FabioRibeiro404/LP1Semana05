using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = args[0];
            int numEnemies = int.Parse(str);
            string[] enemyGroup = new string[numEnemies]; 

            //Guarda nomes dos inimigos
            for (int i = 0; i < enemyGroup.Length; i++)
            {
                int enemies = 1;
                Console.Write($"Nome do inimigo {enemies}: ");
                enemyGroup[i] = Console.ReadLine();
            }
            
            //Pega nos nomes e cria o inimigo
            for (int j = 0; j < enemyGroup.Length; j++)
            {
                Enemy name = new Enemy(enemyGroup[j]);
                name.PickupPowerUp(30, PowerUp.Shield);
                name.PickupPowerUp(40, PowerUp.Health);
                name.TakeDamage(50);

                Console.WriteLine($"{name.GetName()} {name.GetHealth()} {name.GetShield()}");
                Console.WriteLine($"Total PowerUps: {name.GetTotalPowerUps()}");
            }
        }
    }
}
