﻿using System.Xml;
using Design.Patterns.Structural.Adapter.Interfaces;
using Newtonsoft.Json;

namespace Design.Patterns.Structural.Adapter.Businesses
{
    public class XmlToJsonConverter : IConverter
    {
        private readonly string _xml;
        private XmlDocument _doc;
        public XmlToJsonConverter(string xml)
        {
            _xml = xml;
            _doc = new XmlDocument();
            _doc.Load(_xml);
        }

        public string ConvertData()
        {
            return JsonConvert.SerializeXmlNode(_doc);
        }
    }
}
