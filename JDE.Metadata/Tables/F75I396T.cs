using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I396T - .
/// </summary>
public class F75I396T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SESTRX.
        /// </summary>
        public const string SESTRX = "SESTRX";

        /// <summary>
        /// SEITMR.
        /// </summary>
        public const string SEITMR = "SEITMR";

        /// <summary>
        /// SEKIT.
        /// </summary>
        public const string SEKIT = "SEKIT";

        /// <summary>
        /// SEITM.
        /// </summary>
        public const string SEITM = "SEITM";

        /// <summary>
        /// SEKITA.
        /// </summary>
        public const string SEKITA = "SEKITA";

        /// <summary>
        /// SEKITL.
        /// </summary>
        public const string SEKITL = "SEKITL";

        /// <summary>
        /// SELITM.
        /// </summary>
        public const string SELITM = "SELITM";

        /// <summary>
        /// SEDL01.
        /// </summary>
        public const string SEDL01 = "SEDL01";

        /// <summary>
        /// SEDL02.
        /// </summary>
        public const string SEDL02 = "SEDL02";

        /// <summary>
        /// SEMMCU.
        /// </summary>
        public const string SEMMCU = "SEMMCU";

        /// <summary>
        /// SEFLG.
        /// </summary>
        public const string SEFLG = "SEFLG";

        /// <summary>
        /// SECMCU.
        /// </summary>
        public const string SECMCU = "SECMCU";

        /// <summary>
        /// SEACQT.
        /// </summary>
        public const string SEACQT = "SEACQT";

        /// <summary>
        /// SETRUM.
        /// </summary>
        public const string SETRUM = "SETRUM";

        /// <summary>
        /// SEUOM.
        /// </summary>
        public const string SEUOM = "SEUOM";

        /// <summary>
        /// SESTKT.
        /// </summary>
        public const string SESTKT = "SESTKT";

        /// <summary>
        /// SEAQTY.
        /// </summary>
        public const string SEAQTY = "SEAQTY";

        /// <summary>
        /// SETRQT.
        /// </summary>
        public const string SETRQT = "SETRQT";

        /// <summary>
        /// SEACLQ.
        /// </summary>
        public const string SEACLQ = "SEACLQ";

        /// <summary>
        /// SEQNTY.
        /// </summary>
        public const string SEQNTY = "SEQNTY";

        /// <summary>
        /// SEBQTY.
        /// </summary>
        public const string SEBQTY = "SEBQTY";

        /// <summary>
        /// SELOTN.
        /// </summary>
        public const string SELOTN = "SELOTN";

        /// <summary>
        /// SEYQTY.
        /// </summary>
        public const string SEYQTY = "SEYQTY";

        /// <summary>
        /// SECRAOW.
        /// </summary>
        public const string SECRAOW = "SECRAOW";

        /// <summary>
        /// SEUNCS.
        /// </summary>
        public const string SEUNCS = "SEUNCS";

        /// <summary>
        /// SEYCHN.
        /// </summary>
        public const string SEYCHN = "SEYCHN";

        /// <summary>
        /// SENCST.
        /// </summary>
        public const string SENCST = "SENCST";

        /// <summary>
        /// SEYEXU.
        /// </summary>
        public const string SEYEXU = "SEYEXU";

        /// <summary>
        /// SEMATH01.
        /// </summary>
        public const string SEMATH01 = "SEMATH01";

        /// <summary>
        /// SEMATH02.
        /// </summary>
        public const string SEMATH02 = "SEMATH02";

        /// <summary>
        /// SEMATH03.
        /// </summary>
        public const string SEMATH03 = "SEMATH03";

        /// <summary>
        /// SEMATH04.
        /// </summary>
        public const string SEMATH04 = "SEMATH04";

        /// <summary>
        /// SEMATH05.
        /// </summary>
        public const string SEMATH05 = "SEMATH05";

        /// <summary>
        /// SEYFUTDT1.
        /// </summary>
        public const string SEYFUTDT1 = "SEYFUTDT1";

        /// <summary>
        /// SEYFUTDT2.
        /// </summary>
        public const string SEYFUTDT2 = "SEYFUTDT2";

        /// <summary>
        /// SEYFUTDT3.
        /// </summary>
        public const string SEYFUTDT3 = "SEYFUTDT3";

        /// <summary>
        /// SEYFUTDT4.
        /// </summary>
        public const string SEYFUTDT4 = "SEYFUTDT4";

        /// <summary>
        /// SEYFUTDT5.
        /// </summary>
        public const string SEYFUTDT5 = "SEYFUTDT5";

        /// <summary>
        /// SEYFUSTR1.
        /// </summary>
        public const string SEYFUSTR1 = "SEYFUSTR1";

        /// <summary>
        /// SEYFUSTR2.
        /// </summary>
        public const string SEYFUSTR2 = "SEYFUSTR2";

        /// <summary>
        /// SEYFUSTR3.
        /// </summary>
        public const string SEYFUSTR3 = "SEYFUSTR3";

        /// <summary>
        /// SEYFUSTR4.
        /// </summary>
        public const string SEYFUSTR4 = "SEYFUSTR4";

        /// <summary>
        /// SEYT04.
        /// </summary>
        public const string SEYT04 = "SEYT04";

        /// <summary>
        /// SEYT05.
        /// </summary>
        public const string SEYT05 = "SEYT05";

        /// <summary>
        /// SEYT06.
        /// </summary>
        public const string SEYT06 = "SEYT06";

        /// <summary>
        /// SEYT07.
        /// </summary>
        public const string SEYT07 = "SEYT07";

        /// <summary>
        /// SEYT08.
        /// </summary>
        public const string SEYT08 = "SEYT08";

        /// <summary>
        /// SEFUAM.
        /// </summary>
        public const string SEFUAM = "SEFUAM";

        /// <summary>
        /// SEYFUQTY2.
        /// </summary>
        public const string SEYFUQTY2 = "SEYFUQTY2";

        /// <summary>
        /// SEYFUQTY3.
        /// </summary>
        public const string SEYFUQTY3 = "SEYFUQTY3";

        /// <summary>
        /// SEYFUQTY4.
        /// </summary>
        public const string SEYFUQTY4 = "SEYFUQTY4";

        /// <summary>
        /// SEUSER.
        /// </summary>
        public const string SEUSER = "SEUSER";

        /// <summary>
        /// SEJOBN.
        /// </summary>
        public const string SEJOBN = "SEJOBN";

        /// <summary>
        /// SEPID.
        /// </summary>
        public const string SEPID = "SEPID";

        /// <summary>
        /// SEUPMJ.
        /// </summary>
        public const string SEUPMJ = "SEUPMJ";

        /// <summary>
        /// SEUPMT.
        /// </summary>
        public const string SEUPMT = "SEUPMT";

        /// <summary>
        /// SEYTMQT.
        /// </summary>
        public const string SEYTMQT = "SEYTMQT";
    }

    /// <inheritdoc />
    public override string TableName => "F75I396T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SESTRX", "SESTRX", JdeDataType.Numeric, null, true, true),
        new JdeField("SEITMR", "SEITMR", JdeDataType.Numeric, null, true, true),
        new JdeField("SEKIT", "SEKIT", JdeDataType.Numeric, null, true, true),
        new JdeField("SEITM", "SEITM", JdeDataType.Numeric, null, true, true),
        new JdeField("SEKITA", "SEKITA", JdeDataType.String, 50),
        new JdeField("SEKITL", "SEKITL", JdeDataType.String, 50),
        new JdeField("SELITM", "SELITM", JdeDataType.String, 50),
        new JdeField("SEDL01", "SEDL01", JdeDataType.String, 60),
        new JdeField("SEDL02", "SEDL02", JdeDataType.String, 60),
        new JdeField("SEMMCU", "SEMMCU", JdeDataType.String, 24),
        new JdeField("SEFLG", "SEFLG", JdeDataType.String, 2),
        new JdeField("SECMCU", "SECMCU", JdeDataType.String, 24),
        new JdeField("SEACQT", "SEACQT", JdeDataType.Numeric),
        new JdeField("SETRUM", "SETRUM", JdeDataType.String, 4),
        new JdeField("SEUOM", "SEUOM", JdeDataType.String, 4),
        new JdeField("SESTKT", "SESTKT", JdeDataType.String, 2, true, true),
        new JdeField("SEAQTY", "SEAQTY", JdeDataType.Numeric),
        new JdeField("SETRQT", "SETRQT", JdeDataType.Numeric),
        new JdeField("SEACLQ", "SEACLQ", JdeDataType.Numeric),
        new JdeField("SEQNTY", "SEQNTY", JdeDataType.Numeric),
        new JdeField("SEBQTY", "SEBQTY", JdeDataType.Numeric),
        new JdeField("SELOTN", "SELOTN", JdeDataType.String, 60),
        new JdeField("SEYQTY", "SEYQTY", JdeDataType.Numeric),
        new JdeField("SECRAOW", "SECRAOW", JdeDataType.Numeric),
        new JdeField("SEUNCS", "SEUNCS", JdeDataType.Numeric),
        new JdeField("SEYCHN", "SEYCHN", JdeDataType.String, 40),
        new JdeField("SENCST", "SENCST", JdeDataType.Numeric),
        new JdeField("SEYEXU", "SEYEXU", JdeDataType.Numeric),
        new JdeField("SEMATH01", "SEMATH01", JdeDataType.Numeric),
        new JdeField("SEMATH02", "SEMATH02", JdeDataType.Numeric),
        new JdeField("SEMATH03", "SEMATH03", JdeDataType.Numeric),
        new JdeField("SEMATH04", "SEMATH04", JdeDataType.Numeric),
        new JdeField("SEMATH05", "SEMATH05", JdeDataType.Numeric),
        new JdeField("SEYFUTDT1", "SEYFUTDT1", JdeDataType.Numeric),
        new JdeField("SEYFUTDT2", "SEYFUTDT2", JdeDataType.Numeric),
        new JdeField("SEYFUTDT3", "SEYFUTDT3", JdeDataType.Numeric),
        new JdeField("SEYFUTDT4", "SEYFUTDT4", JdeDataType.Numeric),
        new JdeField("SEYFUTDT5", "SEYFUTDT5", JdeDataType.Numeric),
        new JdeField("SEYFUSTR1", "SEYFUSTR1", JdeDataType.String, 60),
        new JdeField("SEYFUSTR2", "SEYFUSTR2", JdeDataType.String, 60),
        new JdeField("SEYFUSTR3", "SEYFUSTR3", JdeDataType.String, 60),
        new JdeField("SEYFUSTR4", "SEYFUSTR4", JdeDataType.String, 60),
        new JdeField("SEYT04", "SEYT04", JdeDataType.String, 2),
        new JdeField("SEYT05", "SEYT05", JdeDataType.String, 2),
        new JdeField("SEYT06", "SEYT06", JdeDataType.String, 2),
        new JdeField("SEYT07", "SEYT07", JdeDataType.String, 2),
        new JdeField("SEYT08", "SEYT08", JdeDataType.String, 2),
        new JdeField("SEFUAM", "SEFUAM", JdeDataType.Numeric),
        new JdeField("SEYFUQTY2", "SEYFUQTY2", JdeDataType.Numeric),
        new JdeField("SEYFUQTY3", "SEYFUQTY3", JdeDataType.Numeric),
        new JdeField("SEYFUQTY4", "SEYFUQTY4", JdeDataType.Numeric),
        new JdeField("SEUSER", "SEUSER", JdeDataType.String, 20),
        new JdeField("SEJOBN", "SEJOBN", JdeDataType.String, 20),
        new JdeField("SEPID", "SEPID", JdeDataType.String, 20),
        new JdeField("SEUPMJ", "SEUPMJ", JdeDataType.Numeric),
        new JdeField("SEUPMT", "SEUPMT", JdeDataType.Numeric),
        new JdeField("SEYTMQT", "SEYTMQT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I396T_0", "Primary Key on SESTKT, SEITM, SEKIT, SEITMR, SESTRX", new[] { "SESTKT", "SEITM", "SEKIT", "SEITMR", "SESTRX" }, isUnique: true, isPrimaryKey: true)
    };
}
