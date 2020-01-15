using Design.Pattern.Structural.Adapter.Businesses;
using Design.Pattern.Structural.Adapter.Interfaces;

namespace Design.Pattern.Structural.Adapter.Adapters
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
