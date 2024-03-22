using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGameFriday
{
    public class GameLevel
    {
        
        private int numEnemies = 0;
        private int numRooms = 0;
        private Difficulty level;
        private string[] rooms;

        //private enum Difficulty Easy;
        
        public GameLevel(int numRooms, Difficulty level)
        {
            this.level = level;
            this.numRooms = numRooms;
            rooms = new string[numRooms];
            
        }
        public Difficulty GetDifficulty()
        {

            return level;
        }
        public int GetNumRooms()
        {

            return numRooms;
        }
        public int GetNumEnemies()
        {

            return numEnemies;
        }
        public void SetEnemyInRoom(int room, Enemy enemy)
        {

            rooms[room] = enemy.GetName();
            numEnemies++;
        }
        public void PrintEnemies()
        {
            for (int i = 0; i < rooms.Length; i++ )
            {
                if(!string.IsNullOrEmpty(rooms[i]))
                {
                    //continue;
                   Console.WriteLine($"Room {i}: {rooms[i]}"); 
                }
                
            
            }

        }
    }
}