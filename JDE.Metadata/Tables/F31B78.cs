using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B78 - .
/// </summary>
public class F31B78 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WSWCFGID.
        /// </summary>
        public const string WSWCFGID = "WSWCFGID";

        /// <summary>
        /// WSLNID.
        /// </summary>
        public const string WSLNID = "WSLNID";

        /// <summary>
        /// WSWISSC.
        /// </summary>
        public const string WSWISSC = "WSWISSC";

        /// <summary>
        /// WSWLVAL.
        /// </summary>
        public const string WSWLVAL = "WSWLVAL";

        /// <summary>
        /// WSWCFTF.
        /// </summary>
        public const string WSWCFTF = "WSWCFTF";

        /// <summary>
        /// WSURCD.
        /// </summary>
        public const string WSURCD = "WSURCD";

        /// <summary>
        /// WSURDT.
        /// </summary>
        public const string WSURDT = "WSURDT";

        /// <summary>
        /// WSURAT.
        /// </summary>
        public const string WSURAT = "WSURAT";

        /// <summary>
        /// WSURAB.
        /// </summary>
        public const string WSURAB = "WSURAB";

        /// <summary>
        /// WSURRF.
        /// </summary>
        public const string WSURRF = "WSURRF";

        /// <summary>
        /// WSUSER.
        /// </summary>
        public const string WSUSER = "WSUSER";

        /// <summary>
        /// WSPID.
        /// </summary>
        public const string WSPID = "WSPID";

        /// <summary>
        /// WSJOBN.
        /// </summary>
        public const string WSJOBN = "WSJOBN";

        /// <summary>
        /// WSUPMJ.
        /// </summary>
        public const string WSUPMJ = "WSUPMJ";

        /// <summary>
        /// WSTDAY.
        /// </summary>
        public const string WSTDAY = "WSTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F31B78";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WSWCFGID", "WSWCFGID", JdeDataType.Numeric, null, true, true),
        new JdeField("WSLNID", "WSLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("WSWISSC", "WSWISSC", JdeDataType.String, 12),
        new JdeField("WSWLVAL", "WSWLVAL", JdeDataType.String, 2),
        new JdeField("WSWCFTF", "WSWCFTF", JdeDataType.String, 2),
        new JdeField("WSURCD", "WSURCD", JdeDataType.String, 4),
        new JdeField("WSURDT", "WSURDT", JdeDataType.Numeric),
        new JdeField("WSURAT", "WSURAT", JdeDataType.Numeric),
        new JdeField("WSURAB", "WSURAB", JdeDataType.Numeric),
        new JdeField("WSURRF", "WSURRF", JdeDataType.String, 30),
        new JdeField("WSUSER", "WSUSER", JdeDataType.String, 20),
        new JdeField("WSPID", "WSPID", JdeDataType.String, 20),
        new JdeField("WSJOBN", "WSJOBN", JdeDataType.String, 20),
        new JdeField("WSUPMJ", "WSUPMJ", JdeDataType.Numeric),
        new JdeField("WSTDAY", "WSTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B78_0", "Primary Key on WSWCFGID, WSLNID", new[] { "WSWCFGID", "WSLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B78_2", "Index on WSWCFGID, WSWISSC", new[] { "WSWCFGID", "WSWISSC" })
    };
}
