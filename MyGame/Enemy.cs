using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;

        public Enemy(string name)
        {
            this.name = name;
            health = 100;
            shield = 0;
        }

        public string GetName()
        {
            return name;
        }

        public float GetHealth()
        {
            return health;
        }

        public float GetShield()
        {
            return shield;
        }

        public void TakeDamage(float damage)
        {
            shield -= damage;

            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if(health < 0)
                    health = 0;
            }
        }
        public string SetName(string name)
        {
            int lengthName = name.Length;
            if (lengthName > 9)
            {
                Console.WriteLine("Exceeded maximum length...");
                this.name = "";
            }
            else
            {
                this.name = name;
            }

            return name;
        }

        public void PickupPowerUp(float amount, PowerUp type)
        {
            
            if (type == PowerUp.Health)
            {
                health += amount;
            }
            if (type == PowerUp.Shield)
            {
                shield += amount;
            }
        }
    }
}