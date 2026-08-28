using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fighting_game
{
    [Serializable]

    public class Player
    {
        private string userName;
        private int score;
        private int skin;
      
        private int rounds;

        public Player(string un, int sc, int sk, int ro)
        {
            userName = un;
            score = sc; 
            skin = sk;
            
            rounds = ro;
        }

        public Player()
        {
            userName = "";
            score = 0;
            skin = 0;
          

        }
        public String Name
        {
            get { return userName; }
            set { userName = value; }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public int Skin
        {
            get { return skin; }
            set { skin = value; }
        }

        public int Rounds
        {
            get { return rounds; }
            set { rounds = value; }
        }
    }
}
