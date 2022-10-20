using System.Xml.Serialization;

namespace TextEngine.XML_Objects
{
    [XmlRoot("item")]
    public sealed class Item
    {
        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("price")]
        public string? Price { get; set; }

        [XmlElement("uom")]
        public string? UnitOfMeasurement { get; set; }
    }
}
