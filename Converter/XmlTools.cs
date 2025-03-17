using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Converter;

public static class XmlTools
{
    public static string ToXmlString<T>(this T input)
    {
        var ns = new XmlSerializerNamespaces();
        ns.Add("", "");
        var xs = new XmlSerializer(typeof(T));
        var sb = new StringBuilder();
        var xw = XmlWriter.Create(sb, new XmlWriterSettings
        {
            OmitXmlDeclaration = true,
            ConformanceLevel = ConformanceLevel.Auto,
            Indent = false
        });
        xs.Serialize(xw, input, ns);
        return sb.ToString().ReplaceLineEndings("\n");
    }
}