using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb1
{
    public class Game 
    {
        public double Point { get; }
        public string Opponent { get; }
        public Game(double point, string oUserName)
        { 
            Point = point;
            Opponent = oUserName;
        }
    }
}
