using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;
        private static int collection;
        
        public Enemy(string name, float health)
        {
            
            SetName(name);
            SetHealth(health);
            shield = 0;
            collection = 0;
            
        }

        public string GetName()
        {
            return name;
        }

        public void Print()
        {
            Console.WriteLine($"{GetName()} {GetHealth()} {GetShield()}");
        }
        public void TakeDamage(float damage)
        {
            shield -= damage;
            if(shield<0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health<0) health=0;
            }
        
        }
        

        public float GetHealth()
        {
            return health;
        }
        public float GetShield()
        {
            return shield;
        }

        public void SetName(string newName)
        {
            if (newName.Length > 8)
            {
                name = newName.Substring(0,8);
            }
            else
            {
                name=newName;
            }
        }

        public void SetHealth(float newhealth)
        {
            health = newhealth;
        }

        public void PickPowerUp(PowerUp powerup,float number)
        {
            if (powerup == PowerUp.Health)
            {
                if (health + number >100)
                {
                    health = 100;
                }
                else
                {
                    health = health + number;
                }

            collection++;
            }
            else if (powerup == PowerUp.Shield)
            {
                if (shield + number >100)
                {
                    shield = 100;
                }
                else
                {
                    shield += number;
                }
            collection++;
            }


        }

        public static int TotalNumberPickupsPicked()
        {
            return collection;
        }
    }
}