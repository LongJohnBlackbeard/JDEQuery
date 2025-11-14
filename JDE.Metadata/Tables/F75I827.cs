using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I827 - .
/// </summary>
public class F75I827 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AGPYID.
        /// </summary>
        public const string AGPYID = "AGPYID";

        /// <summary>
        /// AGRC5.
        /// </summary>
        public const string AGRC5 = "AGRC5";

        /// <summary>
        /// AGITM.
        /// </summary>
        public const string AGITM = "AGITM";

        /// <summary>
        /// AGCO.
        /// </summary>
        public const string AGCO = "AGCO";

        /// <summary>
        /// AGAN8.
        /// </summary>
        public const string AGAN8 = "AGAN8";

        /// <summary>
        /// AGMCU.
        /// </summary>
        public const string AGMCU = "AGMCU";

        /// <summary>
        /// AGCKNU.
        /// </summary>
        public const string AGCKNU = "AGCKNU";

        /// <summary>
        /// AGBCRC.
        /// </summary>
        public const string AGBCRC = "AGBCRC";

        /// <summary>
        /// AGCRR.
        /// </summary>
        public const string AGCRR = "AGCRR";

        /// <summary>
        /// AGLITM.
        /// </summary>
        public const string AGLITM = "AGLITM";

        /// <summary>
        /// AGI75CATTY.
        /// </summary>
        public const string AGI75CATTY = "AGI75CATTY";

        /// <summary>
        /// AGI75CATVL.
        /// </summary>
        public const string AGI75CATVL = "AGI75CATVL";

        /// <summary>
        /// AGAG.
        /// </summary>
        public const string AGAG = "AGAG";

        /// <summary>
        /// AGSTAM.
        /// </summary>
        public const string AGSTAM = "AGSTAM";

        /// <summary>
        /// AGATXA.
        /// </summary>
        public const string AGATXA = "AGATXA";

        /// <summary>
        /// AGI75IGSTR.
        /// </summary>
        public const string AGI75IGSTR = "AGI75IGSTR";

        /// <summary>
        /// AGI75IGSTA.
        /// </summary>
        public const string AGI75IGSTA = "AGI75IGSTA";

        /// <summary>
        /// AGI75IGSTO.
        /// </summary>
        public const string AGI75IGSTO = "AGI75IGSTO";

        /// <summary>
        /// AGI75CGSTR.
        /// </summary>
        public const string AGI75CGSTR = "AGI75CGSTR";

        /// <summary>
        /// AGI75CGSTA.
        /// </summary>
        public const string AGI75CGSTA = "AGI75CGSTA";

        /// <summary>
        /// AGI75CGSTO.
        /// </summary>
        public const string AGI75CGSTO = "AGI75CGSTO";

        /// <summary>
        /// AGI75SGSTR.
        /// </summary>
        public const string AGI75SGSTR = "AGI75SGSTR";

        /// <summary>
        /// AGI75SGSTA.
        /// </summary>
        public const string AGI75SGSTA = "AGI75SGSTA";

        /// <summary>
        /// AGI75SGSTO.
        /// </summary>
        public const string AGI75SGSTO = "AGI75SGSTO";

        /// <summary>
        /// AGI75ATX1R.
        /// </summary>
        public const string AGI75ATX1R = "AGI75ATX1R";

        /// <summary>
        /// AGI75ATX1A.
        /// </summary>
        public const string AGI75ATX1A = "AGI75ATX1A";

        /// <summary>
        /// AGI75ATX1O.
        /// </summary>
        public const string AGI75ATX1O = "AGI75ATX1O";

        /// <summary>
        /// AGI75ATX2R.
        /// </summary>
        public const string AGI75ATX2R = "AGI75ATX2R";

        /// <summary>
        /// AGI75ATX2A.
        /// </summary>
        public const string AGI75ATX2A = "AGI75ATX2A";

        /// <summary>
        /// AGI75ATX2O.
        /// </summary>
        public const string AGI75ATX2O = "AGI75ATX2O";

        /// <summary>
        /// AGI75ATX3R.
        /// </summary>
        public const string AGI75ATX3R = "AGI75ATX3R";

        /// <summary>
        /// AGI75ATX3A.
        /// </summary>
        public const string AGI75ATX3A = "AGI75ATX3A";

        /// <summary>
        /// AGI75ATX3O.
        /// </summary>
        public const string AGI75ATX3O = "AGI75ATX3O";

        /// <summary>
        /// AGUSER.
        /// </summary>
        public const string AGUSER = "AGUSER";

        /// <summary>
        /// AGPID.
        /// </summary>
        public const string AGPID = "AGPID";

        /// <summary>
        /// AGJOBN.
        /// </summary>
        public const string AGJOBN = "AGJOBN";

        /// <summary>
        /// AGUPMJ.
        /// </summary>
        public const string AGUPMJ = "AGUPMJ";

        /// <summary>
        /// AGUPMT.
        /// </summary>
        public const string AGUPMT = "AGUPMT";

        /// <summary>
        /// AGYFUTDT1.
        /// </summary>
        public const string AGYFUTDT1 = "AGYFUTDT1";

        /// <summary>
        /// AGFUT6.
        /// </summary>
        public const string AGFUT6 = "AGFUT6";

        /// <summary>
        /// AGYT04.
        /// </summary>
        public const string AGYT04 = "AGYT04";

        /// <summary>
        /// AGYFLAG.
        /// </summary>
        public const string AGYFLAG = "AGYFLAG";

        /// <summary>
        /// AGYNUM1.
        /// </summary>
        public const string AGYNUM1 = "AGYNUM1";

        /// <summary>
        /// AGICU.
        /// </summary>
        public const string AGICU = "AGICU";

        /// <summary>
        /// AGICUT.
        /// </summary>
        public const string AGICUT = "AGICUT";

        /// <summary>
        /// AGI75CESSA.
        /// </summary>
        public const string AGI75CESSA = "AGI75CESSA";

        /// <summary>
        /// AGI75CESSR.
        /// </summary>
        public const string AGI75CESSR = "AGI75CESSR";

        /// <summary>
        /// AGI75CESSO.
        /// </summary>
        public const string AGI75CESSO = "AGI75CESSO";

        /// <summary>
        /// AGI75AT4A.
        /// </summary>
        public const string AGI75AT4A = "AGI75AT4A";

        /// <summary>
        /// AGI75AT4R.
        /// </summary>
        public const string AGI75AT4R = "AGI75AT4R";

        /// <summary>
        /// AGI75AT4O.
        /// </summary>
        public const string AGI75AT4O = "AGI75AT4O";

        /// <summary>
        /// AGI75GSTRA.
        /// </summary>
        public const string AGI75GSTRA = "AGI75GSTRA";

        /// <summary>
        /// AGI75TRCAT.
        /// </summary>
        public const string AGI75TRCAT = "AGI75TRCAT";

        /// <summary>
        /// AGI75IPOS.
        /// </summary>
        public const string AGI75IPOS = "AGI75IPOS";

        /// <summary>
        /// AGI75GCATG.
        /// </summary>
        public const string AGI75GCATG = "AGI75GCATG";

        /// <summary>
        /// AGI75REMK.
        /// </summary>
        public const string AGI75REMK = "AGI75REMK";

        /// <summary>
        /// AGI75BDLU.
        /// </summary>
        public const string AGI75BDLU = "AGI75BDLU";
    }

    /// <inheritdoc />
    public override string TableName => "F75I827";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AGPYID", "AGPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("AGRC5", "AGRC5", JdeDataType.Numeric, null, true, true),
        new JdeField("AGITM", "AGITM", JdeDataType.Numeric, null, true, true),
        new JdeField("AGCO", "AGCO", JdeDataType.String, 10),
        new JdeField("AGAN8", "AGAN8", JdeDataType.Numeric),
        new JdeField("AGMCU", "AGMCU", JdeDataType.String, 24),
        new JdeField("AGCKNU", "AGCKNU", JdeDataType.String, 50),
        new JdeField("AGBCRC", "AGBCRC", JdeDataType.String, 6),
        new JdeField("AGCRR", "AGCRR", JdeDataType.Numeric),
        new JdeField("AGLITM", "AGLITM", JdeDataType.String, 50),
        new JdeField("AGI75CATTY", "AGI75CATTY", JdeDataType.String, 6),
        new JdeField("AGI75CATVL", "AGI75CATVL", JdeDataType.String, 40),
        new JdeField("AGAG", "AGAG", JdeDataType.Numeric),
        new JdeField("AGSTAM", "AGSTAM", JdeDataType.Numeric),
        new JdeField("AGATXA", "AGATXA", JdeDataType.Numeric),
        new JdeField("AGI75IGSTR", "AGI75IGSTR", JdeDataType.Numeric),
        new JdeField("AGI75IGSTA", "AGI75IGSTA", JdeDataType.Numeric),
        new JdeField("AGI75IGSTO", "AGI75IGSTO", JdeDataType.Numeric),
        new JdeField("AGI75CGSTR", "AGI75CGSTR", JdeDataType.Numeric),
        new JdeField("AGI75CGSTA", "AGI75CGSTA", JdeDataType.Numeric),
        new JdeField("AGI75CGSTO", "AGI75CGSTO", JdeDataType.Numeric),
        new JdeField("AGI75SGSTR", "AGI75SGSTR", JdeDataType.Numeric),
        new JdeField("AGI75SGSTA", "AGI75SGSTA", JdeDataType.Numeric),
        new JdeField("AGI75SGSTO", "AGI75SGSTO", JdeDataType.Numeric),
        new JdeField("AGI75ATX1R", "AGI75ATX1R", JdeDataType.Numeric),
        new JdeField("AGI75ATX1A", "AGI75ATX1A", JdeDataType.Numeric),
        new JdeField("AGI75ATX1O", "AGI75ATX1O", JdeDataType.Numeric),
        new JdeField("AGI75ATX2R", "AGI75ATX2R", JdeDataType.Numeric),
        new JdeField("AGI75ATX2A", "AGI75ATX2A", JdeDataType.Numeric),
        new JdeField("AGI75ATX2O", "AGI75ATX2O", JdeDataType.Numeric),
        new JdeField("AGI75ATX3R", "AGI75ATX3R", JdeDataType.Numeric),
        new JdeField("AGI75ATX3A", "AGI75ATX3A", JdeDataType.Numeric),
        new JdeField("AGI75ATX3O", "AGI75ATX3O", JdeDataType.Numeric),
        new JdeField("AGUSER", "AGUSER", JdeDataType.String, 20),
        new JdeField("AGPID", "AGPID", JdeDataType.String, 20),
        new JdeField("AGJOBN", "AGJOBN", JdeDataType.String, 20),
        new JdeField("AGUPMJ", "AGUPMJ", JdeDataType.Numeric),
        new JdeField("AGUPMT", "AGUPMT", JdeDataType.Numeric),
        new JdeField("AGYFUTDT1", "AGYFUTDT1", JdeDataType.Numeric),
        new JdeField("AGFUT6", "AGFUT6", JdeDataType.String, 60),
        new JdeField("AGYT04", "AGYT04", JdeDataType.String, 2),
        new JdeField("AGYFLAG", "AGYFLAG", JdeDataType.String, 2),
        new JdeField("AGYNUM1", "AGYNUM1", JdeDataType.Numeric),
        new JdeField("AGICU", "AGICU", JdeDataType.Numeric),
        new JdeField("AGICUT", "AGICUT", JdeDataType.String, 4),
        new JdeField("AGI75CESSA", "AGI75CESSA", JdeDataType.Numeric),
        new JdeField("AGI75CESSR", "AGI75CESSR", JdeDataType.Numeric),
        new JdeField("AGI75CESSO", "AGI75CESSO", JdeDataType.Numeric),
        new JdeField("AGI75AT4A", "AGI75AT4A", JdeDataType.Numeric),
        new JdeField("AGI75AT4R", "AGI75AT4R", JdeDataType.Numeric),
        new JdeField("AGI75AT4O", "AGI75AT4O", JdeDataType.Numeric),
        new JdeField("AGI75GSTRA", "AGI75GSTRA", JdeDataType.String, 4),
        new JdeField("AGI75TRCAT", "AGI75TRCAT", JdeDataType.String, 4),
        new JdeField("AGI75IPOS", "AGI75IPOS", JdeDataType.String, 4),
        new JdeField("AGI75GCATG", "AGI75GCATG", JdeDataType.String, 4),
        new JdeField("AGI75REMK", "AGI75REMK", JdeDataType.String, 60),
        new JdeField("AGI75BDLU", "AGI75BDLU", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I827_0", "Primary Key on AGPYID, AGRC5, AGITM", new[] { "AGPYID", "AGRC5", "AGITM" }, isUnique: true, isPrimaryKey: true)
    };
}
