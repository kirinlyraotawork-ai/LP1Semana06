using System;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int numberEnemies = int.Parse(args[0]);
            Enemy[] enemyArray = new Enemy[numberEnemies]; 
            
            for (int i=0; i < numberEnemies;i++ )
            {
                Console.Write($"Nome do inimigo {i+1}: ");
                string input = Console.ReadLine();
                enemyArray[i] = new Enemy(input);
            }

            foreach (Enemy j in enemyArray)
            {   
                Console.WriteLine($"{j.GetName()} {j.GetHealth()} {j.GetShield()}");
            }

            Enemy enemyTest = new Enemy("test");
            
            enemyTest.PickPowerUp(PowerUp.Shield, 15);
            Console.WriteLine($"{enemyTest.GetName()} {enemyTest.GetHealth()} {enemyTest.GetShield()}");
            enemyTest.TakeDamage(30);
            Console.WriteLine($"{enemyTest.GetName()} {enemyTest.GetHealth()} {enemyTest.GetShield()}");
            enemyTest.PickPowerUp(PowerUp.Health, 70);
            Console.WriteLine($"{enemyTest.GetName()} {enemyTest.GetHealth()} {enemyTest.GetShield()}");
        }
    }

}
