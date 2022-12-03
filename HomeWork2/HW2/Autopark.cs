using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
   public class Autopark
    {
        private string _autoparkName;
        private List<Car> _autoparkList = new List<Car>();

        public Autopark(string autoparkName, List<Car> parks)
        {
            _autoparkName = autoparkName;
            _autoparkList = parks;
        }

        public override string ToString()
        {
            string result = " ";
            foreach (Car car in _autoparkList)
            {
                result += car.ToString();
            }

            return result;
        }

    }
}
