using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40R22 - .
/// </summary>
public class F40R22 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DWMCU.
        /// </summary>
        public const string DWMCU = "DWMCU";

        /// <summary>
        /// DWAN8.
        /// </summary>
        public const string DWAN8 = "DWAN8";

        /// <summary>
        /// DWSHAN.
        /// </summary>
        public const string DWSHAN = "DWSHAN";

        /// <summary>
        /// DWPROCNAME.
        /// </summary>
        public const string DWPROCNAME = "DWPROCNAME";

        /// <summary>
        /// DWURCD.
        /// </summary>
        public const string DWURCD = "DWURCD";

        /// <summary>
        /// DWURDT.
        /// </summary>
        public const string DWURDT = "DWURDT";

        /// <summary>
        /// DWURAT.
        /// </summary>
        public const string DWURAT = "DWURAT";

        /// <summary>
        /// DWURAB.
        /// </summary>
        public const string DWURAB = "DWURAB";

        /// <summary>
        /// DWURRF.
        /// </summary>
        public const string DWURRF = "DWURRF";

        /// <summary>
        /// DWUSER.
        /// </summary>
        public const string DWUSER = "DWUSER";

        /// <summary>
        /// DWPID.
        /// </summary>
        public const string DWPID = "DWPID";

        /// <summary>
        /// DWJOBN.
        /// </summary>
        public const string DWJOBN = "DWJOBN";

        /// <summary>
        /// DWUPMJ.
        /// </summary>
        public const string DWUPMJ = "DWUPMJ";

        /// <summary>
        /// DWTDAY.
        /// </summary>
        public const string DWTDAY = "DWTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40R22";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DWMCU", "DWMCU", JdeDataType.String, 24, true, true),
        new JdeField("DWAN8", "DWAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("DWSHAN", "DWSHAN", JdeDataType.Numeric, null, true, true),
        new JdeField("DWPROCNAME", "DWPROCNAME", JdeDataType.String, 20),
        new JdeField("DWURCD", "DWURCD", JdeDataType.String, 4),
        new JdeField("DWURDT", "DWURDT", JdeDataType.Numeric),
        new JdeField("DWURAT", "DWURAT", JdeDataType.Numeric),
        new JdeField("DWURAB", "DWURAB", JdeDataType.Numeric),
        new JdeField("DWURRF", "DWURRF", JdeDataType.String, 30),
        new JdeField("DWUSER", "DWUSER", JdeDataType.String, 20),
        new JdeField("DWPID", "DWPID", JdeDataType.String, 20),
        new JdeField("DWJOBN", "DWJOBN", JdeDataType.String, 20),
        new JdeField("DWUPMJ", "DWUPMJ", JdeDataType.Numeric),
        new JdeField("DWTDAY", "DWTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40R22_0", "Primary Key on DWMCU, DWAN8, DWSHAN", new[] { "DWMCU", "DWAN8", "DWSHAN" }, isUnique: true, isPrimaryKey: true)
    };
}
