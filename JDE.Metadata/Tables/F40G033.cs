using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40G033 - .
/// </summary>
public class F40G033 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CHWVID.
        /// </summary>
        public const string CHWVID = "CHWVID";

        /// <summary>
        /// CHHELNID.
        /// </summary>
        public const string CHHELNID = "CHHELNID";

        /// <summary>
        /// CHUPLNMAT.
        /// </summary>
        public const string CHUPLNMAT = "CHUPLNMAT";

        /// <summary>
        /// CHCURREST.
        /// </summary>
        public const string CHCURREST = "CHCURREST";

        /// <summary>
        /// CHURCD.
        /// </summary>
        public const string CHURCD = "CHURCD";

        /// <summary>
        /// CHURDT.
        /// </summary>
        public const string CHURDT = "CHURDT";

        /// <summary>
        /// CHURRF.
        /// </summary>
        public const string CHURRF = "CHURRF";

        /// <summary>
        /// CHURAB.
        /// </summary>
        public const string CHURAB = "CHURAB";

        /// <summary>
        /// CHURAT.
        /// </summary>
        public const string CHURAT = "CHURAT";

        /// <summary>
        /// CHUSER.
        /// </summary>
        public const string CHUSER = "CHUSER";

        /// <summary>
        /// CHPID.
        /// </summary>
        public const string CHPID = "CHPID";

        /// <summary>
        /// CHJOBN.
        /// </summary>
        public const string CHJOBN = "CHJOBN";

        /// <summary>
        /// CHTORG.
        /// </summary>
        public const string CHTORG = "CHTORG";

        /// <summary>
        /// CHUUPMJ.
        /// </summary>
        public const string CHUUPMJ = "CHUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F40G033";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CHWVID", "CHWVID", JdeDataType.Numeric, null, true, true),
        new JdeField("CHHELNID", "CHHELNID", JdeDataType.Numeric, null, true, true),
        new JdeField("CHUPLNMAT", "CHUPLNMAT", JdeDataType.Date),
        new JdeField("CHCURREST", "CHCURREST", JdeDataType.Numeric),
        new JdeField("CHURCD", "CHURCD", JdeDataType.String, 4),
        new JdeField("CHURDT", "CHURDT", JdeDataType.Numeric),
        new JdeField("CHURRF", "CHURRF", JdeDataType.String, 30),
        new JdeField("CHURAB", "CHURAB", JdeDataType.Numeric),
        new JdeField("CHURAT", "CHURAT", JdeDataType.Numeric),
        new JdeField("CHUSER", "CHUSER", JdeDataType.String, 20),
        new JdeField("CHPID", "CHPID", JdeDataType.String, 20),
        new JdeField("CHJOBN", "CHJOBN", JdeDataType.String, 20),
        new JdeField("CHTORG", "CHTORG", JdeDataType.String, 20),
        new JdeField("CHUUPMJ", "CHUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40G033_0", "Primary Key on CHWVID, CHHELNID", new[] { "CHWVID", "CHHELNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40G033_2", "Index on CHWVID, CHUPLNMAT", new[] { "CHWVID", "CHUPLNMAT" })
    };
}
