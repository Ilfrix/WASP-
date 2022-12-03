using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    public class  Car
    {
        protected string _brand;
        protected int _power;
        protected int _date;

        public Car(string brand, int power, int date)
        {
            _brand = brand;
            _power = power;
            _date = date;
        }

        public override string ToString()
        {
            return _brand.ToString() + " " + _power.ToString() + " " + _date.ToString();
        }

    }



    public class PassengerCar : Car
    {
        private int _countOfPassengers;
        private Dictionary<string, int> _repairNote = new Dictionary<string, int>();
        public PassengerCar(string brand, int power, int date, int countOfPassengers) :base(brand, power, date)
        {
            _countOfPassengers = countOfPassengers;
        }

        public void AddToNote(string RepairedDetail, int date)
        {
            _repairNote.Add(RepairedDetail, date);
        }

        public int dateOfNote(string detailName)
        {
            return _repairNote[detailName];
        }
        
        public void PrintDict()
        {
            foreach (KeyValuePair<string, int> tmp in _repairNote)
            {
                Console.WriteLine($"Detail: {tmp.Key}  \t Year: {tmp.Value}");
            }
        }

        public override string ToString()
        {
            return base.ToString() + " " + _countOfPassengers.ToString();
        }

    }



    public class Truck : Car
    {
        private int _maxPowerLift;
        private string _NamePerson;
        private Dictionary<string, int> _Goods = new Dictionary<string, int>();
        public Truck(string brand, int power, int date, int maxPowerlift, string namePerson) : base(brand, power, date)
        {
            _NamePerson = namePerson;
            _maxPowerLift = maxPowerlift;
        }

        public void EditNamePerson(string name)
        {
            _NamePerson = name;
        }

        public void AddGoods(string cargoName, int weight)
        {
            _Goods.Add(cargoName, weight);
        }
        public void RemoveGoods(string cargoName)
        {
            _Goods.Remove(cargoName);
        }
        public void PrintDict()
        {
            foreach (KeyValuePair<string, int> tmp in _Goods)
            {
                Console.WriteLine($"Good: {tmp.Key}  \t Weight: {tmp.Value}");
            }
        }

        public override string ToString()
        {
            return base.ToString() + " " + _maxPowerLift.ToString() + " " + _NamePerson.ToString();
        }
    }

}
