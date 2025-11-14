using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49T00 - .
/// </summary>
public class F49T00 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ICUKID.
        /// </summary>
        public const string ICUKID = "ICUKID";

        /// <summary>
        /// ICOTUSERID.
        /// </summary>
        public const string ICOTUSERID = "ICOTUSERID";

        /// <summary>
        /// ICOTPASSWD.
        /// </summary>
        public const string ICOTPASSWD = "ICOTPASSWD";

        /// <summary>
        /// ICOTTRANSN.
        /// </summary>
        public const string ICOTTRANSN = "ICOTTRANSN";

        /// <summary>
        /// ICDCT.
        /// </summary>
        public const string ICDCT = "ICDCT";

        /// <summary>
        /// ICURCD.
        /// </summary>
        public const string ICURCD = "ICURCD";

        /// <summary>
        /// ICURDT.
        /// </summary>
        public const string ICURDT = "ICURDT";

        /// <summary>
        /// ICURRF.
        /// </summary>
        public const string ICURRF = "ICURRF";

        /// <summary>
        /// ICURAT.
        /// </summary>
        public const string ICURAT = "ICURAT";

        /// <summary>
        /// ICURAB.
        /// </summary>
        public const string ICURAB = "ICURAB";

        /// <summary>
        /// ICPID.
        /// </summary>
        public const string ICPID = "ICPID";

        /// <summary>
        /// ICTORG.
        /// </summary>
        public const string ICTORG = "ICTORG";

        /// <summary>
        /// ICUSER.
        /// </summary>
        public const string ICUSER = "ICUSER";

        /// <summary>
        /// ICJOBN.
        /// </summary>
        public const string ICJOBN = "ICJOBN";

        /// <summary>
        /// ICUUPMJ.
        /// </summary>
        public const string ICUUPMJ = "ICUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F49T00";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ICUKID", "ICUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("ICOTUSERID", "ICOTUSERID", JdeDataType.String, 256),
        new JdeField("ICOTPASSWD", "ICOTPASSWD", JdeDataType.String, 256),
        new JdeField("ICOTTRANSN", "ICOTTRANSN", JdeDataType.Numeric),
        new JdeField("ICDCT", "ICDCT", JdeDataType.String, 4),
        new JdeField("ICURCD", "ICURCD", JdeDataType.String, 4),
        new JdeField("ICURDT", "ICURDT", JdeDataType.Numeric),
        new JdeField("ICURRF", "ICURRF", JdeDataType.String, 30),
        new JdeField("ICURAT", "ICURAT", JdeDataType.Numeric),
        new JdeField("ICURAB", "ICURAB", JdeDataType.Numeric),
        new JdeField("ICPID", "ICPID", JdeDataType.String, 20),
        new JdeField("ICTORG", "ICTORG", JdeDataType.String, 20),
        new JdeField("ICUSER", "ICUSER", JdeDataType.String, 20),
        new JdeField("ICJOBN", "ICJOBN", JdeDataType.String, 20),
        new JdeField("ICUUPMJ", "ICUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49T00_0", "Primary Key on ICUKID", new[] { "ICUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
