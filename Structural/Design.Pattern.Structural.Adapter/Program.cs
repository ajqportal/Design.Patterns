using System;
using Design.Pattern.Structural.Adapter.Adapters;
using Design.Pattern.Structural.Adapter.Businesses;
using Design.Pattern.Structural.Adapter.Interfaces;

namespace Design.Pattern.Structural.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Converting Json to Xml");
            var adapter1 = new JsonXmlAdapter(new JsonToXmlConverter("Files/test.json"));
            Console.WriteLine(adapter1.GetConvertedData());
            Console.WriteLine("Done...\n\n");

            Console.WriteLine("Converting Xml to Json");
            var adapter2 = new JsonXmlAdapter(new XmlToJsonConverter("Files/test.xml"));
            Console.WriteLine(adapter2.GetConvertedData());
            Console.WriteLine("Done...\n\n");
        }
    }
}
