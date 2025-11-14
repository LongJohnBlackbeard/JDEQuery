using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47191 - .
/// </summary>
public class F47191 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AHEDTY.
        /// </summary>
        public const string AHEDTY = "AHEDTY";

        /// <summary>
        /// AHEDSQ.
        /// </summary>
        public const string AHEDSQ = "AHEDSQ";

        /// <summary>
        /// AHEKCO.
        /// </summary>
        public const string AHEKCO = "AHEKCO";

        /// <summary>
        /// AHEDOC.
        /// </summary>
        public const string AHEDOC = "AHEDOC";

        /// <summary>
        /// AHEDCT.
        /// </summary>
        public const string AHEDCT = "AHEDCT";

        /// <summary>
        /// AHEDLN.
        /// </summary>
        public const string AHEDLN = "AHEDLN";

        /// <summary>
        /// AHEDST.
        /// </summary>
        public const string AHEDST = "AHEDST";

        /// <summary>
        /// AHEDFT.
        /// </summary>
        public const string AHEDFT = "AHEDFT";

        /// <summary>
        /// AHEDDT.
        /// </summary>
        public const string AHEDDT = "AHEDDT";

        /// <summary>
        /// AHEDITM.
        /// </summary>
        public const string AHEDITM = "AHEDITM";

        /// <summary>
        /// AHEDER.
        /// </summary>
        public const string AHEDER = "AHEDER";

        /// <summary>
        /// AHEDDL.
        /// </summary>
        public const string AHEDDL = "AHEDDL";

        /// <summary>
        /// AHEDSP.
        /// </summary>
        public const string AHEDSP = "AHEDSP";

        /// <summary>
        /// AHEDBT.
        /// </summary>
        public const string AHEDBT = "AHEDBT";

        /// <summary>
        /// AHTPUR.
        /// </summary>
        public const string AHTPUR = "AHTPUR";

        /// <summary>
        /// AHACKREFNO.
        /// </summary>
        public const string AHACKREFNO = "AHACKREFNO";

        /// <summary>
        /// AHEDTA.
        /// </summary>
        public const string AHEDTA = "AHEDTA";

        /// <summary>
        /// AHMSGMATCH.
        /// </summary>
        public const string AHMSGMATCH = "AHMSGMATCH";

        /// <summary>
        /// AHCSTREFNO.
        /// </summary>
        public const string AHCSTREFNO = "AHCSTREFNO";

        /// <summary>
        /// AHDOCO.
        /// </summary>
        public const string AHDOCO = "AHDOCO";

        /// <summary>
        /// AHSHPN.
        /// </summary>
        public const string AHSHPN = "AHSHPN";

        /// <summary>
        /// AHBOLNO.
        /// </summary>
        public const string AHBOLNO = "AHBOLNO";

        /// <summary>
        /// AHAN8.
        /// </summary>
        public const string AHAN8 = "AHAN8";

        /// <summary>
        /// AHSHAN.
        /// </summary>
        public const string AHSHAN = "AHSHAN";

        /// <summary>
        /// AHMCU.
        /// </summary>
        public const string AHMCU = "AHMCU";

        /// <summary>
        /// AHCITM.
        /// </summary>
        public const string AHCITM = "AHCITM";

        /// <summary>
        /// AHURCV.
        /// </summary>
        public const string AHURCV = "AHURCV";

        /// <summary>
        /// AHURTN.
        /// </summary>
        public const string AHURTN = "AHURTN";

        /// <summary>
        /// AHUIQ1.
        /// </summary>
        public const string AHUIQ1 = "AHUIQ1";

        /// <summary>
        /// AHADDJ.
        /// </summary>
        public const string AHADDJ = "AHADDJ";

        /// <summary>
        /// AHADTM.
        /// </summary>
        public const string AHADTM = "AHADTM";

        /// <summary>
        /// AHASNSHPTC.
        /// </summary>
        public const string AHASNSHPTC = "AHASNSHPTC";

        /// <summary>
        /// AHDIVJ.
        /// </summary>
        public const string AHDIVJ = "AHDIVJ";

        /// <summary>
        /// AHINVTM.
        /// </summary>
        public const string AHINVTM = "AHINVTM";

        /// <summary>
        /// AHINVTC.
        /// </summary>
        public const string AHINVTC = "AHINVTC";

        /// <summary>
        /// AHEDIPCDJ.
        /// </summary>
        public const string AHEDIPCDJ = "AHEDIPCDJ";

        /// <summary>
        /// AHEDIPCTM.
        /// </summary>
        public const string AHEDIPCTM = "AHEDIPCTM";

        /// <summary>
        /// AHEDIPCTC.
        /// </summary>
        public const string AHEDIPCTC = "AHEDIPCTC";

        /// <summary>
        /// AHCUMS.
        /// </summary>
        public const string AHCUMS = "AHCUMS";

        /// <summary>
        /// AHQNTOW.
        /// </summary>
        public const string AHQNTOW = "AHQNTOW";

        /// <summary>
        /// AHTOT1.
        /// </summary>
        public const string AHTOT1 = "AHTOT1";

        /// <summary>
        /// AHUOM.
        /// </summary>
        public const string AHUOM = "AHUOM";

        /// <summary>
        /// AHACKCODE.
        /// </summary>
        public const string AHACKCODE = "AHACKCODE";

        /// <summary>
        /// AHTRNM.
        /// </summary>
        public const string AHTRNM = "AHTRNM";

        /// <summary>
        /// AHICI.
        /// </summary>
        public const string AHICI = "AHICI";

        /// <summary>
        /// AHICR.
        /// </summary>
        public const string AHICR = "AHICR";

        /// <summary>
        /// AHERSNCD1.
        /// </summary>
        public const string AHERSNCD1 = "AHERSNCD1";

        /// <summary>
        /// AHERSNCD2.
        /// </summary>
        public const string AHERSNCD2 = "AHERSNCD2";

        /// <summary>
        /// AHERSNCD3.
        /// </summary>
        public const string AHERSNCD3 = "AHERSNCD3";

        /// <summary>
        /// AHERSNCD4.
        /// </summary>
        public const string AHERSNCD4 = "AHERSNCD4";

        /// <summary>
        /// AHERSNCD5.
        /// </summary>
        public const string AHERSNCD5 = "AHERSNCD5";

        /// <summary>
        /// AHUSER.
        /// </summary>
        public const string AHUSER = "AHUSER";

        /// <summary>
        /// AHPID.
        /// </summary>
        public const string AHPID = "AHPID";

        /// <summary>
        /// AHJOBN.
        /// </summary>
        public const string AHJOBN = "AHJOBN";

        /// <summary>
        /// AHUPMJ.
        /// </summary>
        public const string AHUPMJ = "AHUPMJ";

        /// <summary>
        /// AHTDAY.
        /// </summary>
        public const string AHTDAY = "AHTDAY";

        /// <summary>
        /// AHGAN8.
        /// </summary>
        public const string AHGAN8 = "AHGAN8";

        /// <summary>
        /// AHGSHAN.
        /// </summary>
        public const string AHGSHAN = "AHGSHAN";
    }

    /// <inheritdoc />
    public override string TableName => "F47191";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AHEDTY", "AHEDTY", JdeDataType.String, 2),
        new JdeField("AHEDSQ", "AHEDSQ", JdeDataType.Numeric),
        new JdeField("AHEKCO", "AHEKCO", JdeDataType.String, 10, true, true),
        new JdeField("AHEDOC", "AHEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("AHEDCT", "AHEDCT", JdeDataType.String, 4, true, true),
        new JdeField("AHEDLN", "AHEDLN", JdeDataType.Numeric),
        new JdeField("AHEDST", "AHEDST", JdeDataType.String, 12),
        new JdeField("AHEDFT", "AHEDFT", JdeDataType.String, 20),
        new JdeField("AHEDDT", "AHEDDT", JdeDataType.Numeric),
        new JdeField("AHEDITM", "AHEDITM", JdeDataType.Numeric),
        new JdeField("AHEDER", "AHEDER", JdeDataType.String, 2),
        new JdeField("AHEDDL", "AHEDDL", JdeDataType.Numeric),
        new JdeField("AHEDSP", "AHEDSP", JdeDataType.String, 2),
        new JdeField("AHEDBT", "AHEDBT", JdeDataType.String, 30),
        new JdeField("AHTPUR", "AHTPUR", JdeDataType.String, 4),
        new JdeField("AHACKREFNO", "AHACKREFNO", JdeDataType.String, 28),
        new JdeField("AHEDTA", "AHEDTA", JdeDataType.String, 12),
        new JdeField("AHMSGMATCH", "AHMSGMATCH", JdeDataType.String, 2),
        new JdeField("AHCSTREFNO", "AHCSTREFNO", JdeDataType.String, 60),
        new JdeField("AHDOCO", "AHDOCO", JdeDataType.Numeric),
        new JdeField("AHSHPN", "AHSHPN", JdeDataType.Numeric),
        new JdeField("AHBOLNO", "AHBOLNO", JdeDataType.String, 40),
        new JdeField("AHAN8", "AHAN8", JdeDataType.Numeric),
        new JdeField("AHSHAN", "AHSHAN", JdeDataType.Numeric),
        new JdeField("AHMCU", "AHMCU", JdeDataType.String, 24),
        new JdeField("AHCITM", "AHCITM", JdeDataType.String, 50),
        new JdeField("AHURCV", "AHURCV", JdeDataType.Numeric),
        new JdeField("AHURTN", "AHURTN", JdeDataType.Numeric),
        new JdeField("AHUIQ1", "AHUIQ1", JdeDataType.Numeric),
        new JdeField("AHADDJ", "AHADDJ", JdeDataType.Numeric),
        new JdeField("AHADTM", "AHADTM", JdeDataType.Numeric),
        new JdeField("AHASNSHPTC", "AHASNSHPTC", JdeDataType.String, 4),
        new JdeField("AHDIVJ", "AHDIVJ", JdeDataType.Numeric),
        new JdeField("AHINVTM", "AHINVTM", JdeDataType.Numeric),
        new JdeField("AHINVTC", "AHINVTC", JdeDataType.String, 4),
        new JdeField("AHEDIPCDJ", "AHEDIPCDJ", JdeDataType.Numeric),
        new JdeField("AHEDIPCTM", "AHEDIPCTM", JdeDataType.Numeric),
        new JdeField("AHEDIPCTC", "AHEDIPCTC", JdeDataType.String, 4),
        new JdeField("AHCUMS", "AHCUMS", JdeDataType.Numeric),
        new JdeField("AHQNTOW", "AHQNTOW", JdeDataType.Numeric),
        new JdeField("AHTOT1", "AHTOT1", JdeDataType.Numeric),
        new JdeField("AHUOM", "AHUOM", JdeDataType.String, 4),
        new JdeField("AHACKCODE", "AHACKCODE", JdeDataType.String, 6),
        new JdeField("AHTRNM", "AHTRNM", JdeDataType.String, 30),
        new JdeField("AHICI", "AHICI", JdeDataType.String, 30),
        new JdeField("AHICR", "AHICR", JdeDataType.String, 30),
        new JdeField("AHERSNCD1", "AHERSNCD1", JdeDataType.String, 6),
        new JdeField("AHERSNCD2", "AHERSNCD2", JdeDataType.String, 6),
        new JdeField("AHERSNCD3", "AHERSNCD3", JdeDataType.String, 6),
        new JdeField("AHERSNCD4", "AHERSNCD4", JdeDataType.String, 6),
        new JdeField("AHERSNCD5", "AHERSNCD5", JdeDataType.String, 6),
        new JdeField("AHUSER", "AHUSER", JdeDataType.String, 20),
        new JdeField("AHPID", "AHPID", JdeDataType.String, 20),
        new JdeField("AHJOBN", "AHJOBN", JdeDataType.String, 20),
        new JdeField("AHUPMJ", "AHUPMJ", JdeDataType.Numeric),
        new JdeField("AHTDAY", "AHTDAY", JdeDataType.Numeric),
        new JdeField("AHGAN8", "AHGAN8", JdeDataType.Numeric),
        new JdeField("AHGSHAN", "AHGSHAN", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47191_0", "Primary Key on AHEKCO, AHEDOC, AHEDCT", new[] { "AHEKCO", "AHEDOC", "AHEDCT" }, isUnique: true, isPrimaryKey: true)
    };
}
