using System.Xml;

namespace xml_test
{
    class Program
    {
        
        public static void Main()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("test.xml");
            XmlElement xRoot = xDoc.DocumentElement;

            // root tag
            XmlElement rootElem = xDoc.CreateElement("root");
            
            // child tags
            XmlElement userElem = xDoc.CreateElement("user");
            XmlElement companyElem = xDoc.CreateElement("company");
            
            // text
            XmlText userElemText = xDoc.CreateTextNode("Mattew");
            XmlText companyElemText = xDoc.CreateTextNode("ITCompany");

            companyElem.AppendChild(companyElemText);
            userElem.AppendChild(userElemText);

            userElem.AppendChild(companyElem);
            rootElem.AppendChild(userElem);
            xRoot.AppendChild(rootElem);

            xDoc.Save("test.xml");
            Console.ReadKey();
        }
    }
}
           