using System;

namespace Klasser
{
    public class Player
    {
        private string name;
        public Player(string playerName){
            name = playerName;
        }
        public string GetName(){
            return name;
        }
    }
}
