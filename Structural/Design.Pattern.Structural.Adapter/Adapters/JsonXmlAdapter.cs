using Design.Patterns.Structural.Adapter.Businesses;
using Design.Patterns.Structural.Adapter.Interfaces;

namespace Design.Patterns.Structural.Adapter.Adapters
{
    public class JsonXmlAdapter : IDataConverter
    {
        private readonly IConverter _converter;

        public JsonXmlAdapter(IConverter converter)
        {
            _converter = converter;
        }

        public string GetConvertedData()
        {
            return _converter.ConvertData();
        }
    }
}
