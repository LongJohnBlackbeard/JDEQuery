using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15141 - .
/// </summary>
public class F15141 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NCMCUS.
        /// </summary>
        public const string NCMCUS = "NCMCUS";

        /// <summary>
        /// NCMCU.
        /// </summary>
        public const string NCMCU = "NCMCU";

        /// <summary>
        /// NCFLOR.
        /// </summary>
        public const string NCFLOR = "NCFLOR";

        /// <summary>
        /// NCUNIT.
        /// </summary>
        public const string NCUNIT = "NCUNIT";

        /// <summary>
        /// NCCENTYR.
        /// </summary>
        public const string NCCENTYR = "NCCENTYR";

        /// <summary>
        /// NCMT.
        /// </summary>
        public const string NCMT = "NCMT";

        /// <summary>
        /// NCGLOA.
        /// </summary>
        public const string NCGLOA = "NCGLOA";

        /// <summary>
        /// NCGOCF.
        /// </summary>
        public const string NCGOCF = "NCGOCF";

        /// <summary>
        /// NCGLAA.
        /// </summary>
        public const string NCGLAA = "NCGLAA";

        /// <summary>
        /// NCGLCF.
        /// </summary>
        public const string NCGLCF = "NCGLCF";

        /// <summary>
        /// NCDYOC.
        /// </summary>
        public const string NCDYOC = "NCDYOC";

        /// <summary>
        /// NCUM.
        /// </summary>
        public const string NCUM = "NCUM";

        /// <summary>
        /// NCARTY.
        /// </summary>
        public const string NCARTY = "NCARTY";

        /// <summary>
        /// NCAM01.
        /// </summary>
        public const string NCAM01 = "NCAM01";

        /// <summary>
        /// NCGLMD.
        /// </summary>
        public const string NCGLMD = "NCGLMD";

        /// <summary>
        /// NCDOCO.
        /// </summary>
        public const string NCDOCO = "NCDOCO";

        /// <summary>
        /// NCURCD.
        /// </summary>
        public const string NCURCD = "NCURCD";

        /// <summary>
        /// NCURDT.
        /// </summary>
        public const string NCURDT = "NCURDT";

        /// <summary>
        /// NCURAT.
        /// </summary>
        public const string NCURAT = "NCURAT";

        /// <summary>
        /// NCURAB.
        /// </summary>
        public const string NCURAB = "NCURAB";

        /// <summary>
        /// NCURRF.
        /// </summary>
        public const string NCURRF = "NCURRF";

        /// <summary>
        /// NCUSER.
        /// </summary>
        public const string NCUSER = "NCUSER";

        /// <summary>
        /// NCPID.
        /// </summary>
        public const string NCPID = "NCPID";

        /// <summary>
        /// NCJOBN.
        /// </summary>
        public const string NCJOBN = "NCJOBN";

        /// <summary>
        /// NCUPMJ.
        /// </summary>
        public const string NCUPMJ = "NCUPMJ";

        /// <summary>
        /// NCUPMT.
        /// </summary>
        public const string NCUPMT = "NCUPMT";

        /// <summary>
        /// NCARDEFID.
        /// </summary>
        public const string NCARDEFID = "NCARDEFID";

        /// <summary>
        /// NCGLOAU.
        /// </summary>
        public const string NCGLOAU = "NCGLOAU";

        /// <summary>
        /// NCGLAAU.
        /// </summary>
        public const string NCGLAAU = "NCGLAAU";
    }

    /// <inheritdoc />
    public override string TableName => "F15141";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NCMCUS", "NCMCUS", JdeDataType.String, 24, true, true),
        new JdeField("NCMCU", "NCMCU", JdeDataType.String, 24, true, true),
        new JdeField("NCFLOR", "NCFLOR", JdeDataType.String, 8),
        new JdeField("NCUNIT", "NCUNIT", JdeDataType.String, 16, true, true),
        new JdeField("NCCENTYR", "NCCENTYR", JdeDataType.Numeric, null, true, true),
        new JdeField("NCMT", "NCMT", JdeDataType.Numeric, null, true, true),
        new JdeField("NCGLOA", "NCGLOA", JdeDataType.Numeric),
        new JdeField("NCGOCF", "NCGOCF", JdeDataType.String, 2),
        new JdeField("NCGLAA", "NCGLAA", JdeDataType.Numeric),
        new JdeField("NCGLCF", "NCGLCF", JdeDataType.String, 2),
        new JdeField("NCDYOC", "NCDYOC", JdeDataType.Numeric),
        new JdeField("NCUM", "NCUM", JdeDataType.String, 4),
        new JdeField("NCARTY", "NCARTY", JdeDataType.String, 6),
        new JdeField("NCAM01", "NCAM01", JdeDataType.String, 6),
        new JdeField("NCGLMD", "NCGLMD", JdeDataType.String, 2, true, true),
        new JdeField("NCDOCO", "NCDOCO", JdeDataType.Numeric),
        new JdeField("NCURCD", "NCURCD", JdeDataType.String, 4),
        new JdeField("NCURDT", "NCURDT", JdeDataType.Numeric),
        new JdeField("NCURAT", "NCURAT", JdeDataType.Numeric),
        new JdeField("NCURAB", "NCURAB", JdeDataType.Numeric),
        new JdeField("NCURRF", "NCURRF", JdeDataType.String, 30),
        new JdeField("NCUSER", "NCUSER", JdeDataType.String, 20),
        new JdeField("NCPID", "NCPID", JdeDataType.String, 20),
        new JdeField("NCJOBN", "NCJOBN", JdeDataType.String, 20),
        new JdeField("NCUPMJ", "NCUPMJ", JdeDataType.Numeric),
        new JdeField("NCUPMT", "NCUPMT", JdeDataType.Numeric),
        new JdeField("NCARDEFID", "NCARDEFID", JdeDataType.String, 20, true, true),
        new JdeField("NCGLOAU", "NCGLOAU", JdeDataType.Numeric),
        new JdeField("NCGLAAU", "NCGLAAU", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15141_0", "Primary Key on NCMCUS, NCMCU, NCUNIT, NCCENTYR, NCMT, NCGLMD, NCARDEFID", new[] { "NCMCUS", "NCMCU", "NCUNIT", "NCCENTYR", "NCMT", "NCGLMD", "NCARDEFID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F15141_2", "Index on NCMCUS, NCUNIT, NCCENTYR, NCMT, NCGLMD, NCARDEFID", new[] { "NCMCUS", "NCUNIT", "NCCENTYR", "NCMT", "NCGLMD", "NCARDEFID" }),
        new JdeIndex("F15141_3", "Index on NCMCU, NCUNIT, NCCENTYR, NCMT, NCGLMD, NCARDEFID", new[] { "NCMCU", "NCUNIT", "NCCENTYR", "NCMT", "NCGLMD", "NCARDEFID" })
    };
}
