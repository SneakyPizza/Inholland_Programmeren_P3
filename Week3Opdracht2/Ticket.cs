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

        private int[] _ages = new int[] {0,6,9,12,16};

        public Ticket(string name, int roomNum, DateTime starttime, decimal price, int minAge)
        {
            Name = name;
            RoomNum = roomNum;
            Starttime = starttime;
            Price = price;
            MinAge = minAge;
        }

        public string Name { get => _name; set { if (value != null && value.Length > 1) { _name = value; } else { throw new FormatException("Invalid name: " + value); } } }
        public int RoomNum { get => _roomNum; set { if (value <= 5) { _roomNum = value; } else { throw new ArgumentOutOfRangeException("Invalid cinema room:" + value); } } }
        public DateTime Starttime { get => _starttime; set { if (value <= DateTime.Now || !((value.Minute % 30) == 0)) { throw new ArgumentOutOfRangeException("Invalid start time " + value); } else { _starttime = value; } } }
        public decimal Price { get => _price; set => _price = value; }
        public int MinAge { get => _minAge; set { if (_ages.Contains(value)) { _minAge = value; } else { throw new ArgumentOutOfRangeException("Invalid minimum age:" + value); } } }
        public bool Discount { get { if(Starttime.DayOfWeek == DayOfWeek.Monday || Starttime.DayOfWeek == DayOfWeek.Tuesday) { return true; } return false; } }
    }
}
