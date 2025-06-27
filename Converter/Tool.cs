using System.Xml.Serialization;

namespace Converter
{
    public static class Tool
    {
        public static string ConvertToValidOfx(string sourceFilePath)
        {
            var content = File.ReadAllText(sourceFilePath);
            var header = "OFXHEADER:100\nDATA:OFXSGML\nVERSION:102\nSECURITY:NONE\nENCODING:USASCII\nCHARSET:1252\nCOMPRESSION:NONE\nOLDFILEUID:NONE\nNEWFILEUID:NONE\n";
            var ofx = content[content.IndexOf("<OFX>")..];

            Console.WriteLine(header);

            Console.WriteLine(ofx);

            Console.WriteLine("Converting OFX to XML...");

            var serializer = new XmlSerializer(typeof(InputBoursoOFX.OFX));

            var ofxContent = serializer.Deserialize(new StringReader(ofx)) as InputBoursoOFX.OFX;

            var accounts = ofxContent.BANKMSGSRSV1.STMTTRNRS.STMTRS;

            var separatedAccounts = new List<OFXBANKMSGSRSV1STMTTRNRS>();

            foreach (var account in accounts)
            {
                if (account.LEDGERBAL == null)
                {
                    account.LEDGERBAL = new OFXBANKMSGSRSV1STMTTRNRSSTMTRSLEDGERBAL
                    {
                        BALAMT = "0",
                        DTASOF = DateTime.Now.ToString("yyyyMMdd")
                    };
                }

                var separatedAccount = new OFXBANKMSGSRSV1STMTTRNRS
                {
                    STATUS = ofxContent.BANKMSGSRSV1.STMTTRNRS.STATUS,
                    STMTRS = [account],
                    TRNUID = account.BANKACCTFROM.ACCTID
                };
                separatedAccounts.Add(separatedAccount);
            }

            var output = new OutputBoursoOFX.OFX
            {
                SIGNONMSGSRSV1 = ofxContent.SIGNONMSGSRSV1 ?? OFXSIGNONMSGSRSV1.CreateDefault(),
                BANKMSGSRSV1 = new OutputBoursoOFX.OFXBANKMSGSRSV1 { STMTTRNRS = separatedAccounts.ToArray() }
            };

            var xml = output.ToXmlString();

            return header + xml;
        }
    }
}
