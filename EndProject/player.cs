using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playerandteam
{
    public class player
    {
        private int _PlayerID;

        public int PlayerID
        {
            get { return _PlayerID; }
            set { _PlayerID = value; }
        }

        private string _PlayerName;

        public string PlayerName
        {
            get { return _PlayerName; }
            set { _PlayerName = value; }
        }
        private int _PlayerAge;

        public int PlayerAge
        {
            get { return _PlayerAge; }
            set { _PlayerAge = value; }
        }
    }
}
