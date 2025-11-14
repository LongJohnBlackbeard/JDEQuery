using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40071 - .
/// </summary>
public class F40071 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CUAN8.
        /// </summary>
        public const string CUAN8 = "CUAN8";

        /// <summary>
        /// CUPRFR.
        /// </summary>
        public const string CUPRFR = "CUPRFR";

        /// <summary>
        /// CUCSTP.
        /// </summary>
        public const string CUCSTP = "CUCSTP";

        /// <summary>
        /// CUURCD.
        /// </summary>
        public const string CUURCD = "CUURCD";

        /// <summary>
        /// CUURDT.
        /// </summary>
        public const string CUURDT = "CUURDT";

        /// <summary>
        /// CUURAT.
        /// </summary>
        public const string CUURAT = "CUURAT";

        /// <summary>
        /// CUURAB.
        /// </summary>
        public const string CUURAB = "CUURAB";

        /// <summary>
        /// CUURRF.
        /// </summary>
        public const string CUURRF = "CUURRF";

        /// <summary>
        /// CUUSER.
        /// </summary>
        public const string CUUSER = "CUUSER";

        /// <summary>
        /// CUPID.
        /// </summary>
        public const string CUPID = "CUPID";

        /// <summary>
        /// CUJOBN.
        /// </summary>
        public const string CUJOBN = "CUJOBN";

        /// <summary>
        /// CUUPMJ.
        /// </summary>
        public const string CUUPMJ = "CUUPMJ";

        /// <summary>
        /// CUTDAY.
        /// </summary>
        public const string CUTDAY = "CUTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40071";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CUAN8", "CUAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CUPRFR", "CUPRFR", JdeDataType.String, 4, true, true),
        new JdeField("CUCSTP", "CUCSTP", JdeDataType.String, 16),
        new JdeField("CUURCD", "CUURCD", JdeDataType.String, 4),
        new JdeField("CUURDT", "CUURDT", JdeDataType.Numeric),
        new JdeField("CUURAT", "CUURAT", JdeDataType.Numeric),
        new JdeField("CUURAB", "CUURAB", JdeDataType.Numeric),
        new JdeField("CUURRF", "CUURRF", JdeDataType.String, 30),
        new JdeField("CUUSER", "CUUSER", JdeDataType.String, 20),
        new JdeField("CUPID", "CUPID", JdeDataType.String, 20),
        new JdeField("CUJOBN", "CUJOBN", JdeDataType.String, 20),
        new JdeField("CUUPMJ", "CUUPMJ", JdeDataType.Numeric),
        new JdeField("CUTDAY", "CUTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40071_0", "Primary Key on CUAN8, CUPRFR", new[] { "CUAN8", "CUPRFR" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40071_2", "Index on CUAN8", new[] { "CUAN8" })
    };
}
