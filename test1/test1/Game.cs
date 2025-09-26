using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    public class Game
    {
        public string Code {  get; set; }
        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }

        public decimal coeff1 { get; set; }
        public decimal coeffX { get; set; }
        public decimal coeff2 { get; set; }

        public Game(string code, Team homeTeam, Team awayTeam, decimal coeff1, decimal coeffX, decimal coeff2)
        {
            this.Code = code;
            this.HomeTeam = homeTeam;
           this. AwayTeam = awayTeam;
            this.coeff1 = coeff1;
            this.coeffX = coeffX;
            this.coeff2 = coeff2;
        }

        public override string ToString()
        {
            return String.Format("{0} ( {1} - {2} )", Code, HomeTeam, AwayTeam);
        }
    }
}
