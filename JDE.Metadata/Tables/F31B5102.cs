using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B5102 - .
/// </summary>
public class F31B5102 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WCMMCU.
        /// </summary>
        public const string WCMMCU = "WCMMCU";

        /// <summary>
        /// WCPRTNO.
        /// </summary>
        public const string WCPRTNO = "WCPRTNO";

        /// <summary>
        /// WCSCTN.
        /// </summary>
        public const string WCSCTN = "WCSCTN";

        /// <summary>
        /// WC702LNR.
        /// </summary>
        public const string WC702LNR = "WC702LNR";

        /// <summary>
        /// WCWDSC2.
        /// </summary>
        public const string WCWDSC2 = "WCWDSC2";

        /// <summary>
        /// WCMATYP.
        /// </summary>
        public const string WCMATYP = "WCMATYP";

        /// <summary>
        /// WCCLMN.
        /// </summary>
        public const string WCCLMN = "WCCLMN";

        /// <summary>
        /// WCWCOPCD.
        /// </summary>
        public const string WCWCOPCD = "WCWCOPCD";

        /// <summary>
        /// WCLOTV.
        /// </summary>
        public const string WCLOTV = "WCLOTV";

        /// <summary>
        /// WCUSER.
        /// </summary>
        public const string WCUSER = "WCUSER";

        /// <summary>
        /// WCPID.
        /// </summary>
        public const string WCPID = "WCPID";

        /// <summary>
        /// WCJOBN.
        /// </summary>
        public const string WCJOBN = "WCJOBN";

        /// <summary>
        /// WCUPMJ.
        /// </summary>
        public const string WCUPMJ = "WCUPMJ";

        /// <summary>
        /// WCTDAY.
        /// </summary>
        public const string WCTDAY = "WCTDAY";

        /// <summary>
        /// WCURCD.
        /// </summary>
        public const string WCURCD = "WCURCD";

        /// <summary>
        /// WCURAB.
        /// </summary>
        public const string WCURAB = "WCURAB";

        /// <summary>
        /// WCURAT.
        /// </summary>
        public const string WCURAT = "WCURAT";

        /// <summary>
        /// WCURDT.
        /// </summary>
        public const string WCURDT = "WCURDT";

        /// <summary>
        /// WCURRF.
        /// </summary>
        public const string WCURRF = "WCURRF";

        /// <summary>
        /// WCFFU3.
        /// </summary>
        public const string WCFFU3 = "WCFFU3";

        /// <summary>
        /// WCFFU5.
        /// </summary>
        public const string WCFFU5 = "WCFFU5";

        /// <summary>
        /// WCFFU6.
        /// </summary>
        public const string WCFFU6 = "WCFFU6";

        /// <summary>
        /// WCFFU4.
        /// </summary>
        public const string WCFFU4 = "WCFFU4";

        /// <summary>
        /// WCFFU7.
        /// </summary>
        public const string WCFFU7 = "WCFFU7";

        /// <summary>
        /// WCFFU8.
        /// </summary>
        public const string WCFFU8 = "WCFFU8";

        /// <summary>
        /// WCTFUDJ.
        /// </summary>
        public const string WCTFUDJ = "WCTFUDJ";

        /// <summary>
        /// WCTFUDJ2.
        /// </summary>
        public const string WCTFUDJ2 = "WCTFUDJ2";

        /// <summary>
        /// WCTFUDJ3.
        /// </summary>
        public const string WCTFUDJ3 = "WCTFUDJ3";
    }

    /// <inheritdoc />
    public override string TableName => "F31B5102";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WCMMCU", "WCMMCU", JdeDataType.String, 24, true, true),
        new JdeField("WCPRTNO", "WCPRTNO", JdeDataType.Numeric, null, true, true),
        new JdeField("WCSCTN", "WCSCTN", JdeDataType.String, 2, true, true),
        new JdeField("WC702LNR", "WC702LNR", JdeDataType.Numeric, null, true, true),
        new JdeField("WCWDSC2", "WCWDSC2", JdeDataType.String, 100),
        new JdeField("WCMATYP", "WCMATYP", JdeDataType.String, 8, true, true),
        new JdeField("WCCLMN", "WCCLMN", JdeDataType.String, 60, true, true),
        new JdeField("WCWCOPCD", "WCWCOPCD", JdeDataType.String, 20, true, true),
        new JdeField("WCLOTV", "WCLOTV", JdeDataType.String, 60, true, true),
        new JdeField("WCUSER", "WCUSER", JdeDataType.String, 20),
        new JdeField("WCPID", "WCPID", JdeDataType.String, 20),
        new JdeField("WCJOBN", "WCJOBN", JdeDataType.String, 20),
        new JdeField("WCUPMJ", "WCUPMJ", JdeDataType.Numeric),
        new JdeField("WCTDAY", "WCTDAY", JdeDataType.Numeric),
        new JdeField("WCURCD", "WCURCD", JdeDataType.String, 4),
        new JdeField("WCURAB", "WCURAB", JdeDataType.Numeric),
        new JdeField("WCURAT", "WCURAT", JdeDataType.Numeric),
        new JdeField("WCURDT", "WCURDT", JdeDataType.Numeric),
        new JdeField("WCURRF", "WCURRF", JdeDataType.String, 30),
        new JdeField("WCFFU3", "WCFFU3", JdeDataType.String, 20),
        new JdeField("WCFFU5", "WCFFU5", JdeDataType.String, 20),
        new JdeField("WCFFU6", "WCFFU6", JdeDataType.String, 20),
        new JdeField("WCFFU4", "WCFFU4", JdeDataType.Numeric),
        new JdeField("WCFFU7", "WCFFU7", JdeDataType.Numeric),
        new JdeField("WCFFU8", "WCFFU8", JdeDataType.Numeric),
        new JdeField("WCTFUDJ", "WCTFUDJ", JdeDataType.Numeric),
        new JdeField("WCTFUDJ2", "WCTFUDJ2", JdeDataType.Numeric),
        new JdeField("WCTFUDJ3", "WCTFUDJ3", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B5102_0", "Primary Key on WCMMCU, WCPRTNO, WCSCTN, WC702LNR, WCCLMN, WCLOTV, WCMATYP, WCWCOPCD", new[] { "WCMMCU", "WCPRTNO", "WCSCTN", "WC702LNR", "WCCLMN", "WCLOTV", "WCMATYP", "WCWCOPCD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B5102_2", "Index on WCMMCU, WCPRTNO, WCSCTN, WC702LNR, WCCLMN", new[] { "WCMMCU", "WCPRTNO", "WCSCTN", "WC702LNR", "WCCLMN" })
    };
}
