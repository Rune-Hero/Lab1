using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14._1
{
    [Serializable]
    public class PC_Component
    {
        private static HashSet<string> serialNumbers = new HashSet<string>();

        private string name;
        private string serialNumber;
        private string manufacturer;
        private string country;
        private double price;

        public PC_Component(string name, string serialNumber, string manufacturer, string country, double price)
        {
            //if (serialNumbers.Contains(serialNumber))
            //{
            //    Console.WriteLine($"Серійний номер '{serialNumber}' вже використано. Об'єкт не буде створено.");
            //    return;
            //}

            Name = name;
            SerialNumber = serialNumber;
            serialNumbers.Add(serialNumber);

            Manufacturer = manufacturer;
            Country = country;
            Price = price;
        }

        public PC_Component()
        {
            Name = "Невідомо";
            SerialNumber = GenerateUniqueSerialNumber();
            Manufacturer = "Невідомо";
            Country = "Невідомо";
            Price = 0;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    name = "Невідомо";
                }
            }
        }

        public string SerialNumber
        {
            get
            {
                return serialNumber;
            }
            set
            {
                serialNumber = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    manufacturer = value;
                }
                else
                {
                    manufacturer = "Невідомо";
                }
            }
        }
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    country = value;
                }
                else
                {
                    country = "Невідомо";
                }
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value >= 0)
                {
                    price = value;
                }
                else
                {
                    throw new ArgumentException("Ціна не може бути від’ємною.");
                }
            }

        }

        //public string Description()
        //{
        //    return "Назва: " + Name + " Серійний номер: " + SerialNumber + " Виробник: " + Manufacturer + " Країна: " + Country + " Ціна: " + Price;
        //}

        private static Random random = new Random();
        private string GenerateUniqueSerialNumber()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string serial;

            do
            {
                serial = new string(Enumerable.Repeat(chars, 8)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
            } while (serialNumbers.Contains(serial));

            return serial;
        }
    }
}
