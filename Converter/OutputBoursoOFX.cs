using System.ComponentModel;
using System.Xml.Serialization;

namespace Converter;



public class OutputBoursoOFX
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class OFX
    {

        private OFXSIGNONMSGSRSV1 sIGNONMSGSRSV1Field;

        private OFXBANKMSGSRSV1 bANKMSGSRSV1Field;

        /// <remarks/>
        public OFXSIGNONMSGSRSV1 SIGNONMSGSRSV1
        {
            get
            {
                return this.sIGNONMSGSRSV1Field;
            }
            set
            {
                this.sIGNONMSGSRSV1Field = value;
            }
        }

        /// <remarks/>
        public OFXBANKMSGSRSV1 BANKMSGSRSV1
        {
            get
            {
                return this.bANKMSGSRSV1Field;
            }
            set
            {
                this.bANKMSGSRSV1Field = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class OFXBANKMSGSRSV1
    {

        private OFXBANKMSGSRSV1STMTTRNRS[] sTMTTRNRSField;

        /// <remarks/>
        [XmlElement("STMTTRNRS")]
        public OFXBANKMSGSRSV1STMTTRNRS[] STMTTRNRS
        {
            get
            {
                return this.sTMTTRNRSField;
            }
            set
            {
                this.sTMTTRNRSField = value;
            }
        }
    }


}
