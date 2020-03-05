using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Opdracht2
{
    class Ticket
    {
        private string _name;
        private int _roomNum;
        private DateTime _starttime;
        private decimal _price;
        private int _minAge;

        public Ticket(string name, int roomNum, DateTime starttime, decimal price, int minAge)
        {
            Name = name;
            RoomNum = roomNum;
            Starttime = starttime;
            Price = price;
            MinAge = minAge;
        }

        public string Name { get => _name; set { if (_name != null && _name.Length > 1) { _name = value; } } }
        public int RoomNum { get => _roomNum; set { if (_roomNum <= 5) { _roomNum = value; } else { throw new ArgumentOutOfRangeException("Invalid cinema room:" + value); } } }
        public DateTime Starttime { get => _starttime; set => _starttime = value; }
        public decimal Price { get => _price; set => _price = value; }
        public int MinAge { get => _minAge; set => _minAge = value; }
    }
}
