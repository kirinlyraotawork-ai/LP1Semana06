using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyRogueLike
{
public enum PowerUp
{
    Health,
    Shield
}

public class Enemy
    {
        private string name;
        private float health;
        private float shield;
        private static int totalPowerUps = 0;

        public Enemy(string name)
        {
            SetName(name); 
            health = 100;
            shield = 0;
        }


        static Enemy()
        {
            totalPowerUps = 0;
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


        public void SetName(string newName)
        {
            name = newName;
        }


        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
        }

        public void PickupPowerUp(PowerUp power, float value)
        {
            switch (power)
            {
                case PowerUp.Health:
                    health = Math.Min(health + value, 100);
                    break;
                case PowerUp.Shield:
                    shield = Math.Min(shield + value, 100);
                    break;
            }
            totalPowerUps++;
        }

        public static int GetTotalPowerUps()
        {
            return totalPowerUps;
        }
    }
}
