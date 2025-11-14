using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75A0010 - .
/// </summary>
public class F75A0010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// A0AN8.
        /// </summary>
        public const string A0AN8 = "A0AN8";

        /// <summary>
        /// A0DST.
        /// </summary>
        public const string A0DST = "A0DST";

        /// <summary>
        /// A0DT.
        /// </summary>
        public const string A0DT = "A0DT";

        /// <summary>
        /// A0OWTRS.
        /// </summary>
        public const string A0OWTRS = "A0OWTRS";

        /// <summary>
        /// A0TERTYP.
        /// </summary>
        public const string A0TERTYP = "A0TERTYP";

        /// <summary>
        /// A0SKLFLG.
        /// </summary>
        public const string A0SKLFLG = "A0SKLFLG";

        /// <summary>
        /// A0LSLFLG.
        /// </summary>
        public const string A0LSLFLG = "A0LSLFLG";

        /// <summary>
        /// A0ETPFLG.
        /// </summary>
        public const string A0ETPFLG = "A0ETPFLG";

        /// <summary>
        /// A0NTERPAY.
        /// </summary>
        public const string A0NTERPAY = "A0NTERPAY";

        /// <summary>
        /// A0PERNOT.
        /// </summary>
        public const string A0PERNOT = "A0PERNOT";

        /// <summary>
        /// A0STDGPAY.
        /// </summary>
        public const string A0STDGPAY = "A0STDGPAY";

        /// <summary>
        /// A0GRSSEV.
        /// </summary>
        public const string A0GRSSEV = "A0GRSSEV";

        /// <summary>
        /// A0INCAMT.
        /// </summary>
        public const string A0INCAMT = "A0INCAMT";

        /// <summary>
        /// A0COMYSER.
        /// </summary>
        public const string A0COMYSER = "A0COMYSER";

        /// <summary>
        /// A0REDUAMT.
        /// </summary>
        public const string A0REDUAMT = "A0REDUAMT";

        /// <summary>
        /// A0REDUTRH.
        /// </summary>
        public const string A0REDUTRH = "A0REDUTRH";

        /// <summary>
        /// A0TAXREDU.
        /// </summary>
        public const string A0TAXREDU = "A0TAXREDU";

        /// <summary>
        /// A0ULLHRS.
        /// </summary>
        public const string A0ULLHRS = "A0ULLHRS";

        /// <summary>
        /// A0ULLVAL.
        /// </summary>
        public const string A0ULLVAL = "A0ULLVAL";

        /// <summary>
        /// A0ALBHRS.
        /// </summary>
        public const string A0ALBHRS = "A0ALBHRS";

        /// <summary>
        /// A0ALBVAL.
        /// </summary>
        public const string A0ALBVAL = "A0ALBVAL";

        /// <summary>
        /// A0ALBTAX.
        /// </summary>
        public const string A0ALBTAX = "A0ALBTAX";

        /// <summary>
        /// A0USKHRS.
        /// </summary>
        public const string A0USKHRS = "A0USKHRS";

        /// <summary>
        /// A0USKVAL.
        /// </summary>
        public const string A0USKVAL = "A0USKVAL";

        /// <summary>
        /// A0URDOHR.
        /// </summary>
        public const string A0URDOHR = "A0URDOHR";

        /// <summary>
        /// A0URDOVL.
        /// </summary>
        public const string A0URDOVL = "A0URDOVL";

        /// <summary>
        /// A0BD1HRS.
        /// </summary>
        public const string A0BD1HRS = "A0BD1HRS";

        /// <summary>
        /// A0BD1VAL.
        /// </summary>
        public const string A0BD1VAL = "A0BD1VAL";

        /// <summary>
        /// A0BD1TAX.
        /// </summary>
        public const string A0BD1TAX = "A0BD1TAX";

        /// <summary>
        /// A0BD2HRS.
        /// </summary>
        public const string A0BD2HRS = "A0BD2HRS";

        /// <summary>
        /// A0BD2VAL.
        /// </summary>
        public const string A0BD2VAL = "A0BD2VAL";

        /// <summary>
        /// A0BD2TAX.
        /// </summary>
        public const string A0BD2TAX = "A0BD2TAX";

        /// <summary>
        /// A0BD3HRS.
        /// </summary>
        public const string A0BD3HRS = "A0BD3HRS";

        /// <summary>
        /// A0BD3VAL.
        /// </summary>
        public const string A0BD3VAL = "A0BD3VAL";

        /// <summary>
        /// A0BD3TAX.
        /// </summary>
        public const string A0BD3TAX = "A0BD3TAX";

        /// <summary>
        /// A0BD4HRS.
        /// </summary>
        public const string A0BD4HRS = "A0BD4HRS";

        /// <summary>
        /// A0BD4VAL.
        /// </summary>
        public const string A0BD4VAL = "A0BD4VAL";

        /// <summary>
        /// A0BD4TAX.
        /// </summary>
        public const string A0BD4TAX = "A0BD4TAX";

        /// <summary>
        /// A0PR83DAY.
        /// </summary>
        public const string A0PR83DAY = "A0PR83DAY";

        /// <summary>
        /// A0PT83DAY.
        /// </summary>
        public const string A0PT83DAY = "A0PT83DAY";

        /// <summary>
        /// A0PR83VAL.
        /// </summary>
        public const string A0PR83VAL = "A0PR83VAL";

        /// <summary>
        /// A0PT83VAL.
        /// </summary>
        public const string A0PT83VAL = "A0PT83VAL";

        /// <summary>
        /// A0ASSAMT.
        /// </summary>
        public const string A0ASSAMT = "A0ASSAMT";

        /// <summary>
        /// A0ROLAMT.
        /// </summary>
        public const string A0ROLAMT = "A0ROLAMT";

        /// <summary>
        /// A0ETPTAX.
        /// </summary>
        public const string A0ETPTAX = "A0ETPTAX";

        /// <summary>
        /// A0ETPPAY.
        /// </summary>
        public const string A0ETPPAY = "A0ETPPAY";

        /// <summary>
        /// A0PAYFLG.
        /// </summary>
        public const string A0PAYFLG = "A0PAYFLG";

        /// <summary>
        /// A0ATOFLG.
        /// </summary>
        public const string A0ATOFLG = "A0ATOFLG";

        /// <summary>
        /// A0RETDTE.
        /// </summary>
        public const string A0RETDTE = "A0RETDTE";

        /// <summary>
        /// A0INVCOMP.
        /// </summary>
        public const string A0INVCOMP = "A0INVCOMP";

        /// <summary>
        /// A0INVDAY.
        /// </summary>
        public const string A0INVDAY = "A0INVDAY";

        /// <summary>
        /// A0TAXFNO.
        /// </summary>
        public const string A0TAXFNO = "A0TAXFNO";

        /// <summary>
        /// A0ATTL.
        /// </summary>
        public const string A0ATTL = "A0ATTL";

        /// <summary>
        /// A0SRNM.
        /// </summary>
        public const string A0SRNM = "A0SRNM";

        /// <summary>
        /// A0GNNM.
        /// </summary>
        public const string A0GNNM = "A0GNNM";

        /// <summary>
        /// A0MDNM.
        /// </summary>
        public const string A0MDNM = "A0MDNM";

        /// <summary>
        /// A0ADD1.
        /// </summary>
        public const string A0ADD1 = "A0ADD1";

        /// <summary>
        /// A0ADD2.
        /// </summary>
        public const string A0ADD2 = "A0ADD2";

        /// <summary>
        /// A0CTY1.
        /// </summary>
        public const string A0CTY1 = "A0CTY1";

        /// <summary>
        /// A0ADDS.
        /// </summary>
        public const string A0ADDS = "A0ADDS";

        /// <summary>
        /// A0ADDZ.
        /// </summary>
        public const string A0ADDZ = "A0ADDZ";

        /// <summary>
        /// A0CTR.
        /// </summary>
        public const string A0CTR = "A0CTR";

        /// <summary>
        /// A0DOB.
        /// </summary>
        public const string A0DOB = "A0DOB";

        /// <summary>
        /// A0PAYTYP.
        /// </summary>
        public const string A0PAYTYP = "A0PAYTYP";

        /// <summary>
        /// A0ROLNME.
        /// </summary>
        public const string A0ROLNME = "A0ROLNME";

        /// <summary>
        /// A0ROLAD1.
        /// </summary>
        public const string A0ROLAD1 = "A0ROLAD1";

        /// <summary>
        /// A0ROLAD2.
        /// </summary>
        public const string A0ROLAD2 = "A0ROLAD2";

        /// <summary>
        /// A0ROLCTY.
        /// </summary>
        public const string A0ROLCTY = "A0ROLCTY";

        /// <summary>
        /// A0ROLSTE.
        /// </summary>
        public const string A0ROLSTE = "A0ROLSTE";

        /// <summary>
        /// A0ROLPOST.
        /// </summary>
        public const string A0ROLPOST = "A0ROLPOST";

        /// <summary>
        /// A0ROLCTR.
        /// </summary>
        public const string A0ROLCTR = "A0ROLCTR";

        /// <summary>
        /// A0APD.
        /// </summary>
        public const string A0APD = "A0APD";

        /// <summary>
        /// A0SPANO01.
        /// </summary>
        public const string A0SPANO01 = "A0SPANO01";

        /// <summary>
        /// A0SPANO02.
        /// </summary>
        public const string A0SPANO02 = "A0SPANO02";

        /// <summary>
        /// A0SPANO03.
        /// </summary>
        public const string A0SPANO03 = "A0SPANO03";

        /// <summary>
        /// A0SPAGR01.
        /// </summary>
        public const string A0SPAGR01 = "A0SPAGR01";

        /// <summary>
        /// A0SPATX01.
        /// </summary>
        public const string A0SPATX01 = "A0SPATX01";

        /// <summary>
        /// A0UPMJ.
        /// </summary>
        public const string A0UPMJ = "A0UPMJ";

        /// <summary>
        /// A0UPMT.
        /// </summary>
        public const string A0UPMT = "A0UPMT";

        /// <summary>
        /// A0PID.
        /// </summary>
        public const string A0PID = "A0PID";

        /// <summary>
        /// A0JOBN.
        /// </summary>
        public const string A0JOBN = "A0JOBN";

        /// <summary>
        /// A0ICU.
        /// </summary>
        public const string A0ICU = "A0ICU";

        /// <summary>
        /// A0CO.
        /// </summary>
        public const string A0CO = "A0CO";

        /// <summary>
        /// A0USER.
        /// </summary>
        public const string A0USER = "A0USER";

        /// <summary>
        /// A0CKDT.
        /// </summary>
        public const string A0CKDT = "A0CKDT";

        /// <summary>
        /// A0TRAM.
        /// </summary>
        public const string A0TRAM = "A0TRAM";

        /// <summary>
        /// A0PTPA.
        /// </summary>
        public const string A0PTPA = "A0PTPA";

        /// <summary>
        /// A0TGOL.
        /// </summary>
        public const string A0TGOL = "A0TGOL";

        /// <summary>
        /// A0TPLU.
        /// </summary>
        public const string A0TPLU = "A0TPLU";

        /// <summary>
        /// A0DTAM.
        /// </summary>
        public const string A0DTAM = "A0DTAM";

        /// <summary>
        /// A0PRAG.
        /// </summary>
        public const string A0PRAG = "A0PRAG";

        /// <summary>
        /// A0TRPA.
        /// </summary>
        public const string A0TRPA = "A0TRPA";

        /// <summary>
        /// A0PMTP.
        /// </summary>
        public const string A0PMTP = "A0PMTP";

        /// <summary>
        /// A0ORAM.
        /// </summary>
        public const string A0ORAM = "A0ORAM";

        /// <summary>
        /// A0NRAM.
        /// </summary>
        public const string A0NRAM = "A0NRAM";

        /// <summary>
        /// A0TRINVCMP.
        /// </summary>
        public const string A0TRINVCMP = "A0TRINVCMP";

        /// <summary>
        /// A0TPR83DAY.
        /// </summary>
        public const string A0TPR83DAY = "A0TPR83DAY";

        /// <summary>
        /// A0TPR83VAL.
        /// </summary>
        public const string A0TPR83VAL = "A0TPR83VAL";

        /// <summary>
        /// A0TPT83DAY.
        /// </summary>
        public const string A0TPT83DAY = "A0TPT83DAY";

        /// <summary>
        /// A0TPT83VAL.
        /// </summary>
        public const string A0TPT83VAL = "A0TPT83VAL";

        /// <summary>
        /// A0TRETPTAX.
        /// </summary>
        public const string A0TRETPTAX = "A0TRETPTAX";

        /// <summary>
        /// A0TRETPPAY.
        /// </summary>
        public const string A0TRETPPAY = "A0TRETPPAY";

        /// <summary>
        /// A0DNPI.
        /// </summary>
        public const string A0DNPI = "A0DNPI";

        /// <summary>
        /// A0SPADAUT1.
        /// </summary>
        public const string A0SPADAUT1 = "A0SPADAUT1";

        /// <summary>
        /// A0SPADAUT2.
        /// </summary>
        public const string A0SPADAUT2 = "A0SPADAUT2";

        /// <summary>
        /// A0SPADAUT3.
        /// </summary>
        public const string A0SPADAUT3 = "A0SPADAUT3";

        /// <summary>
        /// A0SPADAUT4.
        /// </summary>
        public const string A0SPADAUT4 = "A0SPADAUT4";

        /// <summary>
        /// A0SPAFAUT1.
        /// </summary>
        public const string A0SPAFAUT1 = "A0SPAFAUT1";

        /// <summary>
        /// A0SPAFAUT2.
        /// </summary>
        public const string A0SPAFAUT2 = "A0SPAFAUT2";

        /// <summary>
        /// A0SPAFAUT3.
        /// </summary>
        public const string A0SPAFAUT3 = "A0SPAFAUT3";

        /// <summary>
        /// A0SPAFAUT4.
        /// </summary>
        public const string A0SPAFAUT4 = "A0SPAFAUT4";

        /// <summary>
        /// A0SPASAUT1.
        /// </summary>
        public const string A0SPASAUT1 = "A0SPASAUT1";

        /// <summary>
        /// A0SPASAUT2.
        /// </summary>
        public const string A0SPASAUT2 = "A0SPASAUT2";

        /// <summary>
        /// A0SPASAUT3.
        /// </summary>
        public const string A0SPASAUT3 = "A0SPASAUT3";

        /// <summary>
        /// A0SPANAUT1.
        /// </summary>
        public const string A0SPANAUT1 = "A0SPANAUT1";

        /// <summary>
        /// A0SPANAUT2.
        /// </summary>
        public const string A0SPANAUT2 = "A0SPANAUT2";

        /// <summary>
        /// A0SPANAUT3.
        /// </summary>
        public const string A0SPANAUT3 = "A0SPANAUT3";

        /// <summary>
        /// A0SPANAUT4.
        /// </summary>
        public const string A0SPANAUT4 = "A0SPANAUT4";
    }

    /// <inheritdoc />
    public override string TableName => "F75A0010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("A0AN8", "A0AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("A0DST", "A0DST", JdeDataType.Numeric),
        new JdeField("A0DT", "A0DT", JdeDataType.Numeric, null, true, true),
        new JdeField("A0OWTRS", "A0OWTRS", JdeDataType.String, 6),
        new JdeField("A0TERTYP", "A0TERTYP", JdeDataType.String, 6),
        new JdeField("A0SKLFLG", "A0SKLFLG", JdeDataType.String, 2),
        new JdeField("A0LSLFLG", "A0LSLFLG", JdeDataType.String, 2),
        new JdeField("A0ETPFLG", "A0ETPFLG", JdeDataType.String, 2),
        new JdeField("A0NTERPAY", "A0NTERPAY", JdeDataType.Numeric),
        new JdeField("A0PERNOT", "A0PERNOT", JdeDataType.Numeric),
        new JdeField("A0STDGPAY", "A0STDGPAY", JdeDataType.Numeric),
        new JdeField("A0GRSSEV", "A0GRSSEV", JdeDataType.Numeric),
        new JdeField("A0INCAMT", "A0INCAMT", JdeDataType.Numeric),
        new JdeField("A0COMYSER", "A0COMYSER", JdeDataType.Numeric),
        new JdeField("A0REDUAMT", "A0REDUAMT", JdeDataType.Numeric),
        new JdeField("A0REDUTRH", "A0REDUTRH", JdeDataType.Numeric),
        new JdeField("A0TAXREDU", "A0TAXREDU", JdeDataType.Numeric),
        new JdeField("A0ULLHRS", "A0ULLHRS", JdeDataType.Numeric),
        new JdeField("A0ULLVAL", "A0ULLVAL", JdeDataType.Numeric),
        new JdeField("A0ALBHRS", "A0ALBHRS", JdeDataType.Numeric),
        new JdeField("A0ALBVAL", "A0ALBVAL", JdeDataType.Numeric),
        new JdeField("A0ALBTAX", "A0ALBTAX", JdeDataType.Numeric),
        new JdeField("A0USKHRS", "A0USKHRS", JdeDataType.Numeric),
        new JdeField("A0USKVAL", "A0USKVAL", JdeDataType.Numeric),
        new JdeField("A0URDOHR", "A0URDOHR", JdeDataType.Numeric),
        new JdeField("A0URDOVL", "A0URDOVL", JdeDataType.Numeric),
        new JdeField("A0BD1HRS", "A0BD1HRS", JdeDataType.Numeric),
        new JdeField("A0BD1VAL", "A0BD1VAL", JdeDataType.Numeric),
        new JdeField("A0BD1TAX", "A0BD1TAX", JdeDataType.Numeric),
        new JdeField("A0BD2HRS", "A0BD2HRS", JdeDataType.Numeric),
        new JdeField("A0BD2VAL", "A0BD2VAL", JdeDataType.Numeric),
        new JdeField("A0BD2TAX", "A0BD2TAX", JdeDataType.Numeric),
        new JdeField("A0BD3HRS", "A0BD3HRS", JdeDataType.Numeric),
        new JdeField("A0BD3VAL", "A0BD3VAL", JdeDataType.Numeric),
        new JdeField("A0BD3TAX", "A0BD3TAX", JdeDataType.Numeric),
        new JdeField("A0BD4HRS", "A0BD4HRS", JdeDataType.Numeric),
        new JdeField("A0BD4VAL", "A0BD4VAL", JdeDataType.Numeric),
        new JdeField("A0BD4TAX", "A0BD4TAX", JdeDataType.Numeric),
        new JdeField("A0PR83DAY", "A0PR83DAY", JdeDataType.Numeric),
        new JdeField("A0PT83DAY", "A0PT83DAY", JdeDataType.Numeric),
        new JdeField("A0PR83VAL", "A0PR83VAL", JdeDataType.Numeric),
        new JdeField("A0PT83VAL", "A0PT83VAL", JdeDataType.Numeric),
        new JdeField("A0ASSAMT", "A0ASSAMT", JdeDataType.Numeric),
        new JdeField("A0ROLAMT", "A0ROLAMT", JdeDataType.Numeric),
        new JdeField("A0ETPTAX", "A0ETPTAX", JdeDataType.Numeric),
        new JdeField("A0ETPPAY", "A0ETPPAY", JdeDataType.Numeric),
        new JdeField("A0PAYFLG", "A0PAYFLG", JdeDataType.String, 2),
        new JdeField("A0ATOFLG", "A0ATOFLG", JdeDataType.String, 2),
        new JdeField("A0RETDTE", "A0RETDTE", JdeDataType.Numeric),
        new JdeField("A0INVCOMP", "A0INVCOMP", JdeDataType.Numeric),
        new JdeField("A0INVDAY", "A0INVDAY", JdeDataType.Numeric),
        new JdeField("A0TAXFNO", "A0TAXFNO", JdeDataType.String, 22),
        new JdeField("A0ATTL", "A0ATTL", JdeDataType.String, 80),
        new JdeField("A0SRNM", "A0SRNM", JdeDataType.String, 50),
        new JdeField("A0GNNM", "A0GNNM", JdeDataType.String, 50),
        new JdeField("A0MDNM", "A0MDNM", JdeDataType.String, 50),
        new JdeField("A0ADD1", "A0ADD1", JdeDataType.String, 80),
        new JdeField("A0ADD2", "A0ADD2", JdeDataType.String, 80),
        new JdeField("A0CTY1", "A0CTY1", JdeDataType.String, 50),
        new JdeField("A0ADDS", "A0ADDS", JdeDataType.String, 6),
        new JdeField("A0ADDZ", "A0ADDZ", JdeDataType.String, 24),
        new JdeField("A0CTR", "A0CTR", JdeDataType.String, 6),
        new JdeField("A0DOB", "A0DOB", JdeDataType.Numeric),
        new JdeField("A0PAYTYP", "A0PAYTYP", JdeDataType.String, 4),
        new JdeField("A0ROLNME", "A0ROLNME", JdeDataType.String, 80),
        new JdeField("A0ROLAD1", "A0ROLAD1", JdeDataType.String, 80),
        new JdeField("A0ROLAD2", "A0ROLAD2", JdeDataType.String, 80),
        new JdeField("A0ROLCTY", "A0ROLCTY", JdeDataType.String, 50),
        new JdeField("A0ROLSTE", "A0ROLSTE", JdeDataType.String, 6),
        new JdeField("A0ROLPOST", "A0ROLPOST", JdeDataType.String, 24),
        new JdeField("A0ROLCTR", "A0ROLCTR", JdeDataType.String, 6),
        new JdeField("A0APD", "A0APD", JdeDataType.Numeric),
        new JdeField("A0SPANO01", "A0SPANO01", JdeDataType.Numeric),
        new JdeField("A0SPANO02", "A0SPANO02", JdeDataType.Numeric),
        new JdeField("A0SPANO03", "A0SPANO03", JdeDataType.Numeric),
        new JdeField("A0SPAGR01", "A0SPAGR01", JdeDataType.Numeric),
        new JdeField("A0SPATX01", "A0SPATX01", JdeDataType.Numeric),
        new JdeField("A0UPMJ", "A0UPMJ", JdeDataType.Numeric),
        new JdeField("A0UPMT", "A0UPMT", JdeDataType.Numeric),
        new JdeField("A0PID", "A0PID", JdeDataType.String, 20),
        new JdeField("A0JOBN", "A0JOBN", JdeDataType.String, 20),
        new JdeField("A0ICU", "A0ICU", JdeDataType.Numeric),
        new JdeField("A0CO", "A0CO", JdeDataType.String, 10),
        new JdeField("A0USER", "A0USER", JdeDataType.String, 20),
        new JdeField("A0CKDT", "A0CKDT", JdeDataType.Numeric),
        new JdeField("A0TRAM", "A0TRAM", JdeDataType.Numeric),
        new JdeField("A0PTPA", "A0PTPA", JdeDataType.Numeric),
        new JdeField("A0TGOL", "A0TGOL", JdeDataType.Numeric),
        new JdeField("A0TPLU", "A0TPLU", JdeDataType.Numeric),
        new JdeField("A0DTAM", "A0DTAM", JdeDataType.Numeric),
        new JdeField("A0PRAG", "A0PRAG", JdeDataType.String, 2),
        new JdeField("A0TRPA", "A0TRPA", JdeDataType.String, 2),
        new JdeField("A0PMTP", "A0PMTP", JdeDataType.String, 2),
        new JdeField("A0ORAM", "A0ORAM", JdeDataType.String, 2),
        new JdeField("A0NRAM", "A0NRAM", JdeDataType.String, 2),
        new JdeField("A0TRINVCMP", "A0TRINVCMP", JdeDataType.Numeric),
        new JdeField("A0TPR83DAY", "A0TPR83DAY", JdeDataType.Numeric),
        new JdeField("A0TPR83VAL", "A0TPR83VAL", JdeDataType.Numeric),
        new JdeField("A0TPT83DAY", "A0TPT83DAY", JdeDataType.Numeric),
        new JdeField("A0TPT83VAL", "A0TPT83VAL", JdeDataType.Numeric),
        new JdeField("A0TRETPTAX", "A0TRETPTAX", JdeDataType.Numeric),
        new JdeField("A0TRETPPAY", "A0TRETPPAY", JdeDataType.Numeric),
        new JdeField("A0DNPI", "A0DNPI", JdeDataType.String, 2),
        new JdeField("A0SPADAUT1", "A0SPADAUT1", JdeDataType.Numeric),
        new JdeField("A0SPADAUT2", "A0SPADAUT2", JdeDataType.Numeric),
        new JdeField("A0SPADAUT3", "A0SPADAUT3", JdeDataType.Numeric),
        new JdeField("A0SPADAUT4", "A0SPADAUT4", JdeDataType.Numeric),
        new JdeField("A0SPAFAUT1", "A0SPAFAUT1", JdeDataType.String, 2),
        new JdeField("A0SPAFAUT2", "A0SPAFAUT2", JdeDataType.String, 2),
        new JdeField("A0SPAFAUT3", "A0SPAFAUT3", JdeDataType.String, 2),
        new JdeField("A0SPAFAUT4", "A0SPAFAUT4", JdeDataType.String, 2),
        new JdeField("A0SPASAUT1", "A0SPASAUT1", JdeDataType.String, 60),
        new JdeField("A0SPASAUT2", "A0SPASAUT2", JdeDataType.String, 60),
        new JdeField("A0SPASAUT3", "A0SPASAUT3", JdeDataType.String, 60),
        new JdeField("A0SPANAUT1", "A0SPANAUT1", JdeDataType.Numeric),
        new JdeField("A0SPANAUT2", "A0SPANAUT2", JdeDataType.Numeric),
        new JdeField("A0SPANAUT3", "A0SPANAUT3", JdeDataType.Numeric),
        new JdeField("A0SPANAUT4", "A0SPANAUT4", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75A0010_0", "Primary Key on A0AN8, A0DT", new[] { "A0AN8", "A0DT" }, isUnique: true, isPrimaryKey: true)
    };
}
