using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace Converter;

/// <remarks/>
[Serializable()]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public partial class OFXSIGNONMSGSRSV1
{

    public static OFXSIGNONMSGSRSV1 CreateDefault()
    {
        return new OFXSIGNONMSGSRSV1
        {
            SONRS = new OFXSIGNONMSGSRSV1SONRS
            {
                STATUS = new OFXSIGNONMSGSRSV1SONRSSTATUS
                {
                    CODE = 0,
                    SEVERITY = "INFO"
                },
                DTSERVER = uint.Parse(DateTime.Now.ToString("yyyyMMdd")),
                LANGUAGE = "ENG"
            }
        };
    }

    private OFXSIGNONMSGSRSV1SONRS sONRSField;

    /// <remarks/>
    public OFXSIGNONMSGSRSV1SONRS SONRS
    {
        get
        {
            return this.sONRSField;
        }
        set
        {
            this.sONRSField = value;
        }
    }
}

/// <remarks/>
[Serializable()]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public partial class OFXSIGNONMSGSRSV1SONRS
{

    private OFXSIGNONMSGSRSV1SONRSSTATUS sTATUSField;

    private uint dTSERVERField;

    private string lANGUAGEField;

    /// <remarks/>
    public OFXSIGNONMSGSRSV1SONRSSTATUS STATUS
    {
        get
        {
            return this.sTATUSField;
        }
        set
        {
            this.sTATUSField = value;
        }
    }

    /// <remarks/>
    public uint DTSERVER
    {
        get
        {
            return this.dTSERVERField;
        }
        set
        {
            this.dTSERVERField = value;
        }
    }

    /// <remarks/>
    public string LANGUAGE
    {
        get
        {
            return this.lANGUAGEField;
        }
        set
        {
            this.lANGUAGEField = value;
        }
    }
}

/// <remarks/>
[Serializable()]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public partial class OFXSIGNONMSGSRSV1SONRSSTATUS
{

    private byte cODEField;

    private string sEVERITYField;

    /// <remarks/>
    public byte CODE
    {
        get
        {
            return this.cODEField;
        }
        set
        {
            this.cODEField = value;
        }
    }

    /// <remarks/>
    public string SEVERITY
    {
        get
        {
            return this.sEVERITYField;
        }
        set
        {
            this.sEVERITYField = value;
        }
    }
}

/// <remarks/>
[Serializable()]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public partial class OFXBANKMSGSRSV1STMTTRNRS
{

    private string tRNUIDField;

    private OFXBANKMSGSRSV1STMTTRNRSSTATUS sTATUSField;

    private OFXBANKMSGSRSV1STMTTRNRSSTMTRS[] sTMTRSField;

    /// <remarks/>
    public string TRNUID
    {
        get
        {
            return this.tRNUIDField;
        }
        set
        {
            this.tRNUIDField = value;
        }
    }

    /// <remarks/>
    public OFXBANKMSGSRSV1STMTTRNRSSTATUS STATUS
    {
        get
        {
            return this.sTATUSField;
        }
        set
        {
            this.sTATUSField = value;
        }
    }

    /// <remarks/>
    [XmlElement("STMTRS")]
    public OFXBANKMSGSRSV1STMTTRNRSSTMTRS[] STMTRS
    {
        get
        {
            return this.sTMTRSField;
        }
        set
        {
            this.sTMTRSField = value;
        }
    }
}

/// <remarks/>
[Serializable()]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public partial class OFXBANKMSGSRSV1STMTTRNRSSTATUS
{

    private byte cODEField;

    private string sEVERITYField;

    /// <remarks/>
    public byte CODE
    {
        get
        {
            return this.cODEField;
        }
        set
        {
            this.cODEField = value;
        }
    }

    /// <remarks/>
    public string SEVERITY
    {
        get
        {
            return this.sEVERITYField;
        }
        set
        {
            this.sEVERITYField = value;
        }
    }
}

/// <remarks/>
[Serializable()]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public partial class OFXBANKMSGSRSV1STMTTRNRSSTMTRS
{

    private string cURDEFField;

    private OFXBANKMSGSRSV1STMTTRNRSSTMTRSBANKACCTFROM bANKACCTFROMField;

    private OFXBANKMSGSRSV1STMTTRNRSSTMTRSBANKTRANLIST bANKTRANLISTField;

    private OFXBANKMSGSRSV1STMTTRNRSSTMTRSLEDGERBAL lEDGERBALField;

    /// <remarks/>
    public string CURDEF
    {
        get
        {
            return this.cURDEFField;
        }
        set
        {
            this.cURDEFField = value;
        }
    }

    /// <remarks/>
    public OFXBANKMSGSRSV1STMTTRNRSSTMTRSBANKACCTFROM BANKACCTFROM
    {
        get
        {
            return this.bANKACCTFROMField;
        }
        set
        {
            this.bANKACCTFROMField = value;
        }
    }

    /// <remarks/>
    public OFXBANKMSGSRSV1STMTTRNRSSTMTRSBANKTRANLIST BANKTRANLIST
    {
        get
        {
            return this.bANKTRANLISTField;
        }
        set
        {
            this.bANKTRANLISTField = value;
        }
    }

    /// <remarks/>
    public OFXBANKMSGSRSV1STMTTRNRSSTMTRSLEDGERBAL LEDGERBAL
    {
        get
        {
            return this.lEDGERBALField;
        }
        set
        {
            this.lEDGERBALField = value;
        }
    }
}

/// <remarks/>
[Serializable()]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public partial class OFXBANKMSGSRSV1STMTTRNRSSTMTRSBANKACCTFROM
{

    private string bANKIDField;

    private ushort bRANCHIDField;

    private bool bRANCHIDFieldSpecified;

    private string aCCTIDField;

    private string aCCTTYPEField;

    /// <remarks/>
    public string BANKID
    {
        get
        {
            return this.bANKIDField.Substring(0, Math.Min(this.bANKIDField.Length, 5));
        }
        set
        {
            this.bANKIDField = value;
        }
    }

    /// <remarks/>
    public ushort BRANCHID
    {
        get
        {
            return this.bRANCHIDField;
        }
        set
        {
            this.bRANCHIDField = value;
        }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool BRANCHIDSpecified
    {
        get
        {
            return this.bRANCHIDFieldSpecified;
        }
        set
        {
            this.bRANCHIDFieldSpecified = value;
        }
    }

    /// <remarks/>
    public string ACCTID
    {
        get
        {
            return this.aCCTIDField;
        }
        set
        {
            this.aCCTIDField = value;
        }
    }

    /// <remarks/>
    public string ACCTTYPE
    {
        get
        {
            return "CHECKING";
        }
        set
        {
            this.aCCTTYPEField = value;
        }
    }
}

/// <remarks/>
[Serializable()]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public partial class OFXBANKMSGSRSV1STMTTRNRSSTMTRSBANKTRANLIST
{

    private ulong dTSTARTField;

    private ulong dTENDField;

    private OFXBANKMSGSRSV1STMTTRNRSSTMTRSBANKTRANLISTSTMTTRN[] sTMTTRNField;

    /// <remarks/>
    public ulong DTSTART
    {
        get
        {
            return this.dTSTARTField;
        }
        set
        {
            this.dTSTARTField = value;
        }
    }

    /// <remarks/>
    public ulong DTEND
    {
        get
        {
            return this.dTENDField;
        }
        set
        {
            this.dTENDField = value;
        }
    }

    /// <remarks/>
    [XmlElement("STMTTRN")]
    public OFXBANKMSGSRSV1STMTTRNRSSTMTRSBANKTRANLISTSTMTTRN[] STMTTRN
    {
        get
        {
            return this.sTMTTRNField;
        }
        set
        {
            this.sTMTTRNField = value;
        }
    }
}

/// <remarks/>
[Serializable()]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public partial class OFXBANKMSGSRSV1STMTTRNRSSTMTRSBANKTRANLISTSTMTTRN
{

    private string dtPostedField;
    private string FITIDField;
    private string NAMEField;
    private string TRNAMTField;
    private string TRNTYPEField;
    private string MEMOField;

    /// <remarks/>
    [XmlElement("TRNTYPE")]
    public string TRNTYPE
    {
        get
        {
            return this.TRNTYPEField;
        }
        set
        {
            this.TRNTYPEField = value;
        }
    }

    /// <remarks/>
    [XmlElement("DTPOSTED")]
    public string DTPOSTED
    {
        get
        {
            return this.dtPostedField;
        }
        set
        {
            this.dtPostedField = value;
        }
    }

    /// <remarks/>
    [XmlElement("TRNAMT")]
    public string TRNAMT
    {
        get
        {
            return this.TRNAMTField;
        }
        set
        {
            this.TRNAMTField = value;
        }
    }

    /// <remarks/>
    [XmlElement("FITID")]
    public string FITID
    {
        get
        {
            return this.FITIDField;
        }
        set
        {
            this.FITIDField = value;
        }
    }

    /// <remarks/>
    [XmlElement("NAME")]
    public string NAME
    {
        get
        {
            var temp = this.NAMEField.Replace("*", "");
            temp = SepaRegex().Replace(CardRegex().Replace(temp, "$1"), "$1");
            return temp[..Math.Min(temp.Length, 32)];
        }
        set
        {
            this.NAMEField = value;
        }
    }

    /// <remarks/>
    [XmlElement("MEMO")]
    public string MEMO
    {
        get
        {
            return this.NAMEField;
        }
        set
        {
            this.MEMOField = value;
        }
    }

    [GeneratedRegex(@"CARTE \d{2}\/\d{2}\/\d{2} (.*)")]
    private static partial Regex CardRegex();

    [GeneratedRegex(@"(?:PRLV|VIR) SEPA (.*)")]
    private static partial Regex SepaRegex();
}

/// <remarks/>
[Serializable()]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public partial class OFXBANKMSGSRSV1STMTTRNRSSTMTRSLEDGERBAL
{

    private string bALAMTField;
    private string dTASOFField;

    /// <remarks/>
    [XmlElement("BALAMT")]
    public string BALAMT
    {
        get
        {
            return this.bALAMTField;
        }
        set
        {
            this.bALAMTField = value;
        }
    }

    /// <remarks/>
    [XmlElement("DTASOF")]
    public string DTASOF
    {
        get
        {
            return this.dTASOFField;
        }
        set
        {
            this.dTASOFField = value;
        }
    }
}
