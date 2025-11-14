using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40320 - .
/// </summary>
public class F40320 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LPAN8.
        /// </summary>
        public const string LPAN8 = "LPAN8";

        /// <summary>
        /// LPCS20.
        /// </summary>
        public const string LPCS20 = "LPCS20";

        /// <summary>
        /// LPITM.
        /// </summary>
        public const string LPITM = "LPITM";

        /// <summary>
        /// LPIT20.
        /// </summary>
        public const string LPIT20 = "LPIT20";

        /// <summary>
        /// LPEFTJ.
        /// </summary>
        public const string LPEFTJ = "LPEFTJ";

        /// <summary>
        /// LPEXDJ.
        /// </summary>
        public const string LPEXDJ = "LPEXDJ";

        /// <summary>
        /// LPMNQ.
        /// </summary>
        public const string LPMNQ = "LPMNQ";

        /// <summary>
        /// LPMXQ.
        /// </summary>
        public const string LPMXQ = "LPMXQ";

        /// <summary>
        /// LPUOM.
        /// </summary>
        public const string LPUOM = "LPUOM";

        /// <summary>
        /// LPTXID.
        /// </summary>
        public const string LPTXID = "LPTXID";

        /// <summary>
        /// LPSTPR.
        /// </summary>
        public const string LPSTPR = "LPSTPR";

        /// <summary>
        /// LPSEQ.
        /// </summary>
        public const string LPSEQ = "LPSEQ";

        /// <summary>
        /// LPTYFL.
        /// </summary>
        public const string LPTYFL = "LPTYFL";

        /// <summary>
        /// LPMCU.
        /// </summary>
        public const string LPMCU = "LPMCU";

        /// <summary>
        /// LPLOCN.
        /// </summary>
        public const string LPLOCN = "LPLOCN";

        /// <summary>
        /// LPCARS.
        /// </summary>
        public const string LPCARS = "LPCARS";

        /// <summary>
        /// LPMOT.
        /// </summary>
        public const string LPMOT = "LPMOT";

        /// <summary>
        /// LPSHAN.
        /// </summary>
        public const string LPSHAN = "LPSHAN";

        /// <summary>
        /// LPDCTO.
        /// </summary>
        public const string LPDCTO = "LPDCTO";

        /// <summary>
        /// LPLNTY.
        /// </summary>
        public const string LPLNTY = "LPLNTY";

        /// <summary>
        /// LPMNCB.
        /// </summary>
        public const string LPMNCB = "LPMNCB";

        /// <summary>
        /// LPMXCB.
        /// </summary>
        public const string LPMXCB = "LPMXCB";

        /// <summary>
        /// LPCVUM.
        /// </summary>
        public const string LPCVUM = "LPCVUM";

        /// <summary>
        /// LPMNCI.
        /// </summary>
        public const string LPMNCI = "LPMNCI";

        /// <summary>
        /// LPMXCI.
        /// </summary>
        public const string LPMXCI = "LPMXCI";

        /// <summary>
        /// LPVUMD.
        /// </summary>
        public const string LPVUMD = "LPVUMD";

        /// <summary>
        /// LPMNWT.
        /// </summary>
        public const string LPMNWT = "LPMNWT";

        /// <summary>
        /// LPMXWT.
        /// </summary>
        public const string LPMXWT = "LPMXWT";

        /// <summary>
        /// LPWGTU.
        /// </summary>
        public const string LPWGTU = "LPWGTU";

        /// <summary>
        /// LPMNWI.
        /// </summary>
        public const string LPMNWI = "LPMNWI";

        /// <summary>
        /// LPMXWI.
        /// </summary>
        public const string LPMXWI = "LPMXWI";

        /// <summary>
        /// LPUWUM.
        /// </summary>
        public const string LPUWUM = "LPUWUM";

        /// <summary>
        /// LPPRP6.
        /// </summary>
        public const string LPPRP6 = "LPPRP6";

        /// <summary>
        /// LPEQTY.
        /// </summary>
        public const string LPEQTY = "LPEQTY";

        /// <summary>
        /// LPTIEF.
        /// </summary>
        public const string LPTIEF = "LPTIEF";

        /// <summary>
        /// LPTIEX.
        /// </summary>
        public const string LPTIEX = "LPTIEX";

        /// <summary>
        /// LPUSER.
        /// </summary>
        public const string LPUSER = "LPUSER";

        /// <summary>
        /// LPPID.
        /// </summary>
        public const string LPPID = "LPPID";

        /// <summary>
        /// LPJOBN.
        /// </summary>
        public const string LPJOBN = "LPJOBN";

        /// <summary>
        /// LPUPMJ.
        /// </summary>
        public const string LPUPMJ = "LPUPMJ";

        /// <summary>
        /// LPTDAY.
        /// </summary>
        public const string LPTDAY = "LPTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40320";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LPAN8", "LPAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("LPCS20", "LPCS20", JdeDataType.String, 16, true, true),
        new JdeField("LPITM", "LPITM", JdeDataType.Numeric, null, true, true),
        new JdeField("LPIT20", "LPIT20", JdeDataType.String, 16, true, true),
        new JdeField("LPEFTJ", "LPEFTJ", JdeDataType.Numeric),
        new JdeField("LPEXDJ", "LPEXDJ", JdeDataType.Numeric),
        new JdeField("LPMNQ", "LPMNQ", JdeDataType.Numeric),
        new JdeField("LPMXQ", "LPMXQ", JdeDataType.Numeric),
        new JdeField("LPUOM", "LPUOM", JdeDataType.String, 4),
        new JdeField("LPTXID", "LPTXID", JdeDataType.Numeric),
        new JdeField("LPSTPR", "LPSTPR", JdeDataType.String, 2),
        new JdeField("LPSEQ", "LPSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("LPTYFL", "LPTYFL", JdeDataType.String, 2, true, true),
        new JdeField("LPMCU", "LPMCU", JdeDataType.String, 24, true, true),
        new JdeField("LPLOCN", "LPLOCN", JdeDataType.String, 40, true, true),
        new JdeField("LPCARS", "LPCARS", JdeDataType.Numeric),
        new JdeField("LPMOT", "LPMOT", JdeDataType.String, 6),
        new JdeField("LPSHAN", "LPSHAN", JdeDataType.Numeric),
        new JdeField("LPDCTO", "LPDCTO", JdeDataType.String, 4),
        new JdeField("LPLNTY", "LPLNTY", JdeDataType.String, 4),
        new JdeField("LPMNCB", "LPMNCB", JdeDataType.Numeric),
        new JdeField("LPMXCB", "LPMXCB", JdeDataType.Numeric),
        new JdeField("LPCVUM", "LPCVUM", JdeDataType.String, 4),
        new JdeField("LPMNCI", "LPMNCI", JdeDataType.Numeric),
        new JdeField("LPMXCI", "LPMXCI", JdeDataType.Numeric),
        new JdeField("LPVUMD", "LPVUMD", JdeDataType.String, 4),
        new JdeField("LPMNWT", "LPMNWT", JdeDataType.Numeric),
        new JdeField("LPMXWT", "LPMXWT", JdeDataType.Numeric),
        new JdeField("LPWGTU", "LPWGTU", JdeDataType.String, 4),
        new JdeField("LPMNWI", "LPMNWI", JdeDataType.Numeric),
        new JdeField("LPMXWI", "LPMXWI", JdeDataType.Numeric),
        new JdeField("LPUWUM", "LPUWUM", JdeDataType.String, 4),
        new JdeField("LPPRP6", "LPPRP6", JdeDataType.String, 12),
        new JdeField("LPEQTY", "LPEQTY", JdeDataType.String, 10),
        new JdeField("LPTIEF", "LPTIEF", JdeDataType.Numeric),
        new JdeField("LPTIEX", "LPTIEX", JdeDataType.Numeric),
        new JdeField("LPUSER", "LPUSER", JdeDataType.String, 20),
        new JdeField("LPPID", "LPPID", JdeDataType.String, 20),
        new JdeField("LPJOBN", "LPJOBN", JdeDataType.String, 20),
        new JdeField("LPUPMJ", "LPUPMJ", JdeDataType.Numeric),
        new JdeField("LPTDAY", "LPTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40320_0", "Primary Key on LPAN8, LPCS20, LPITM, LPIT20, LPTYFL, LPMCU, LPSEQ, LPLOCN", new[] { "LPAN8", "LPCS20", "LPITM", "LPIT20", "LPTYFL", "LPMCU", "LPSEQ", "LPLOCN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40320_2", "Index on LPTYFL, LPMCU, LPLOCN, LPSTPR", new[] { "LPTYFL", "LPMCU", "LPLOCN", "LPSTPR" })
    };
}
