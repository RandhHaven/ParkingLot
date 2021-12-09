namespace ParkingLot.Core.ApiHelpers
{
    using System.IO;
    using System.Xml.Serialization;
    using System.Xml;

    public class Serializer
    {
        public T Deserialize<T>(string input)
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));

            using (StringReader sr = new StringReader(input))
            {
                return (T)ser.Deserialize(sr);
            }
        }

        public string Serialize<T>(T ObjectToSerialize)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.OmitXmlDeclaration = true;
            XmlSerializer xsSubmit = new XmlSerializer(ObjectToSerialize.GetType());
            using (StringWriter sw = new StringWriter())
            using (XmlWriter writer = XmlWriter.Create(sw, settings))
            {
                // removes namespace
                var xmlns = new XmlSerializerNamespaces();
                xmlns.Add(string.Empty, string.Empty);

                xsSubmit.Serialize(writer, ObjectToSerialize, xmlns);
                return sw.ToString();
            }
        }
    }
}