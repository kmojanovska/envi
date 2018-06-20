using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envi
{
    public class Result
    {
        private string Username { get; set; }
        public int Score { get; set; }
        private string Hero { get; set; }

        public Result(string Username, int Score, string Hero)
        {
            this.Username = Username;
            this.Score = Score;
            this.Hero = Hero;
        }

        public override string ToString()
        {
            return String.Format("{0} scored {1} with {2}", Username, Score, Hero.ToUpper());
        }
    }
}
