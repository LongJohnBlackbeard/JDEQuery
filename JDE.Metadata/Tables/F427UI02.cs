using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F427UI02 - .
/// </summary>
public class F427UI02 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZXJOBS.
        /// </summary>
        public const string ZXJOBS = "ZXJOBS";

        /// <summary>
        /// ZXKCOO.
        /// </summary>
        public const string ZXKCOO = "ZXKCOO";

        /// <summary>
        /// ZXDOCO.
        /// </summary>
        public const string ZXDOCO = "ZXDOCO";

        /// <summary>
        /// ZXDCTO.
        /// </summary>
        public const string ZXDCTO = "ZXDCTO";

        /// <summary>
        /// ZXLNID.
        /// </summary>
        public const string ZXLNID = "ZXLNID";

        /// <summary>
        /// ZXITM.
        /// </summary>
        public const string ZXITM = "ZXITM";

        /// <summary>
        /// ZXMCU.
        /// </summary>
        public const string ZXMCU = "ZXMCU";

        /// <summary>
        /// ZXRCCT.
        /// </summary>
        public const string ZXRCCT = "ZXRCCT";

        /// <summary>
        /// ZXFULPID.
        /// </summary>
        public const string ZXFULPID = "ZXFULPID";

        /// <summary>
        /// ZXVC30A.
        /// </summary>
        public const string ZXVC30A = "ZXVC30A";

        /// <summary>
        /// ZXURCD.
        /// </summary>
        public const string ZXURCD = "ZXURCD";

        /// <summary>
        /// ZXURDT.
        /// </summary>
        public const string ZXURDT = "ZXURDT";

        /// <summary>
        /// ZXURAT.
        /// </summary>
        public const string ZXURAT = "ZXURAT";

        /// <summary>
        /// ZXURAB.
        /// </summary>
        public const string ZXURAB = "ZXURAB";

        /// <summary>
        /// ZXURRF.
        /// </summary>
        public const string ZXURRF = "ZXURRF";

        /// <summary>
        /// ZXUSER.
        /// </summary>
        public const string ZXUSER = "ZXUSER";

        /// <summary>
        /// ZXPID.
        /// </summary>
        public const string ZXPID = "ZXPID";

        /// <summary>
        /// ZXJOBN.
        /// </summary>
        public const string ZXJOBN = "ZXJOBN";

        /// <summary>
        /// ZXUPMJ.
        /// </summary>
        public const string ZXUPMJ = "ZXUPMJ";

        /// <summary>
        /// ZXTDAY.
        /// </summary>
        public const string ZXTDAY = "ZXTDAY";

        /// <summary>
        /// ZXUTIME.
        /// </summary>
        public const string ZXUTIME = "ZXUTIME";
    }

    /// <inheritdoc />
    public override string TableName => "F427UI02";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZXJOBS", "ZXJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("ZXKCOO", "ZXKCOO", JdeDataType.String, 10, true, true),
        new JdeField("ZXDOCO", "ZXDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("ZXDCTO", "ZXDCTO", JdeDataType.String, 4, true, true),
        new JdeField("ZXLNID", "ZXLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("ZXITM", "ZXITM", JdeDataType.Numeric),
        new JdeField("ZXMCU", "ZXMCU", JdeDataType.String, 24),
        new JdeField("ZXRCCT", "ZXRCCT", JdeDataType.Numeric),
        new JdeField("ZXFULPID", "ZXFULPID", JdeDataType.Numeric),
        new JdeField("ZXVC30A", "ZXVC30A", JdeDataType.String, 60),
        new JdeField("ZXURCD", "ZXURCD", JdeDataType.String, 4),
        new JdeField("ZXURDT", "ZXURDT", JdeDataType.Numeric),
        new JdeField("ZXURAT", "ZXURAT", JdeDataType.Numeric),
        new JdeField("ZXURAB", "ZXURAB", JdeDataType.Numeric),
        new JdeField("ZXURRF", "ZXURRF", JdeDataType.String, 30),
        new JdeField("ZXUSER", "ZXUSER", JdeDataType.String, 20),
        new JdeField("ZXPID", "ZXPID", JdeDataType.String, 20),
        new JdeField("ZXJOBN", "ZXJOBN", JdeDataType.String, 20),
        new JdeField("ZXUPMJ", "ZXUPMJ", JdeDataType.Numeric),
        new JdeField("ZXTDAY", "ZXTDAY", JdeDataType.Numeric),
        new JdeField("ZXUTIME", "ZXUTIME", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F427UI02_0", "Primary Key on ZXJOBS, ZXKCOO, ZXDOCO, ZXDCTO, ZXLNID", new[] { "ZXJOBS", "ZXKCOO", "ZXDOCO", "ZXDCTO", "ZXLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F427UI02_2", "Index on ZXJOBS, ZXITM, ZXMCU", new[] { "ZXJOBS", "ZXITM", "ZXMCU" }),
        new JdeIndex("F427UI02_3", "Index on ZXJOBS, ZXRCCT, ZXITM, ZXMCU", new[] { "ZXJOBS", "ZXRCCT", "ZXITM", "ZXMCU" }),
        new JdeIndex("F427UI02_4", "Index on ZXJOBS, ZXFULPID", new[] { "ZXJOBS", "ZXFULPID" }),
        new JdeIndex("F427UI02_5", "Index on ZXJOBS, ZXKCOO, ZXDOCO, ZXDCTO, ZXFULPID", new[] { "ZXJOBS", "ZXKCOO", "ZXDOCO", "ZXDCTO", "ZXFULPID" })
    };
}
