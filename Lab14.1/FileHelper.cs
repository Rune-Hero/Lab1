using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Lab14._1
{
    [Serializable]
    static class FileHelper
    {
        public static void SaveToJson(ComponentCollection components, string path)
        {
            try
            {
                string data = JsonSerializer.Serialize(components, new JsonSerializerOptions
                {
                    WriteIndented = true,
                    IncludeFields = true
                });

                File.WriteAllText(path, data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка під час збереження у JSON: " + ex.Message);
            }
        }

        public static void SaveToXML(ComponentCollection components, string path)
        {

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ComponentCollection));
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                xmlSerializer.Serialize(fs, components);
            }
        }

        public static void SaveToDat(ComponentCollection components, string path)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                bf.Serialize(fs, components);
            }
        }

        public static void SaveToTxt(ComponentCollection components, string path)
        {
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                foreach (var component in components.GetAll())
                {
                    sw.WriteLine($"{component.Name};{component.SerialNumber};{component.Manufacturer};{component.Country};{component.Price}");
                }
            }
            
        }

        public static ComponentCollection LoadFromJson(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("Файл не знайдено.");
                return default;
            }
            string data = File.ReadAllText(path);
            return JsonSerializer.Deserialize<ComponentCollection>(data);
        }

        public static ComponentCollection LoadFromXML(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("Файл не знайдено.");
                return default;
            }
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ComponentCollection));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                return (ComponentCollection)xmlSerializer.Deserialize(fs);
            }
        }

        public static ComponentCollection LoadFromDat(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("Файл не знайдено.");
                return default;
            }
            ComponentCollection newCollection = new ComponentCollection();
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                newCollection = (ComponentCollection)bf.Deserialize(fs);
                return newCollection;
            }
        }

        public static ComponentCollection LoadFromTxt(string path)
        {
            //if (!File.Exists(path))
            //{
            //    Console.WriteLine("Файл не знайдено.");
            //    return default;
            //}

            ComponentCollection newComponentCollection = new ComponentCollection();

            var lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                var parts = line.Split(';');
                if (parts.Length != 5)
                {
                    Console.WriteLine($"Пропущено рядок: {line}");
                    continue;
                }

                string name = parts[0];
                string serial = parts[1];
                string manufacturer = parts[2];
                string country = parts[3];

                if (double.TryParse(parts[4], NumberStyles.Any, CultureInfo.InvariantCulture, out double price))
                {
                    try
                    {
                        var pc = new PC_Component(name, serial, manufacturer, country, price);
                        newComponentCollection.Add(pc);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Не додано {serial}: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine($"Невірна ціна в рядку: {line}");
                }
            }
            Console.WriteLine($"Дані успішно отримані.");
            return newComponentCollection;
        }
    }
}
