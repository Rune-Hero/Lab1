using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab14._1
{
    [Serializable]
    [XmlRoot("ComponentCollection")]
    public class ComponentCollection
    {
        [XmlElement("PC_Component")]
        public List<PC_Component> Components { get; set; } = new List<PC_Component>();

        public ComponentCollection() { }

        public bool Add(PC_Component component)
        {
            if (Components.Any(c => c.SerialNumber == component.SerialNumber))
                return false; 

            Components.Add(component);
            return true;
        }

        public bool Remove(string serialNumber)
        {
            var item = Components.FirstOrDefault(c => c.SerialNumber == serialNumber);
            if (item != null)
            {
                Components.Remove(item);
                return true;
            }
            return false;
        }

        public IEnumerable<PC_Component> GetAll()
        {
            return Components;
        }

        public void SortBySerailNumber(bool ascending = true)
        {
            if (ascending)
            {
                Components = Components.OrderBy(c => c.SerialNumber).ToList();
            }
            else
            {
                Components = Components.OrderByDescending(c => c.SerialNumber).ToList(); 
            }
        }

    }
}