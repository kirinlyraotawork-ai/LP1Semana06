using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Humanizer;
using System.Globalization;
using testing;

namespace testing
{
    public enum Toughness
    {
        Easy,
        Medium,
        Hard
    }
}

namespace testing
{
    public class Level
    {
        private int numRooms;
        private Toughness difficulty;
        private Enemy[] rooms;

        public Level(int numRooms, Toughness difficulty)
        {
            this.numRooms = numRooms;
            this.difficulty = difficulty;
            this.rooms = new Enemy[numRooms];
        }


        public void SetEnemyInRoom(int roomIndex, Enemy enemy)
        {
            if (roomIndex >= 0 && roomIndex < numRooms)
            {
                rooms[roomIndex] = enemy;
            }
        }


        public int GetNumRooms()
        {
            return numRooms;
        }


        public Toughness GetToughness()
        {
            return difficulty;
        }


        public int GetNumEnemies()
        {
            int count = 0;
            foreach (Enemy enemy in rooms)
            {
                if (enemy!= null)
                {
                    count++;
                }
            }
            return count;
        }


        public void PrintEnemies()
        {

            CultureInfo ingles = new CultureInfo("en-US");
            for (int i = 0; i < rooms.Length; i++)
            {
                if (rooms[i] != null)
                {
                    string roomNumber = i.ToString().ToOrdinalWords(ingles).Transform(To.TitleCase);
                    Console.WriteLine($"{roomNumber} room: {rooms[i].GetName()}");
                }
            }
        }

        


    }
}