using System.Xml.Serialization;

namespace DesignPatterns2.Cap8
{
    public class GeradorXml
    {
        public string GeraXml(object obejct)
        {
            XmlSerializer serializer = new XmlSerializer(obejct.GetType());
            StringWriter stringWriter = new StringWriter();
            serializer.Serialize(stringWriter, obejct);

            return stringWriter.ToString();
        }
    }
}
