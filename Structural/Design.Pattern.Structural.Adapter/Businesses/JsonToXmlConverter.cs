﻿using System.IO;
using System.Xml;
using Design.Pattern.Structural.Adapter.Interfaces;
using Newtonsoft.Json;

namespace Design.Pattern.Structural.Adapter.Businesses
{
    public class JsonToXmlConverter : IConverter
    {
        private readonly string _json;
        public JsonToXmlConverter(string json)
        {
            var jsonString = JsonConvert.DeserializeObject<object>(File.ReadAllText(json));
            _json = jsonString.ToString();
        }

        public string ConvertData()
        {
            return JsonConvert.DeserializeXNode(_json, string.Empty).ToString();
        }
    }
}
