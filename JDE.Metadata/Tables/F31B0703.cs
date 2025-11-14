using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B0703 - .
/// </summary>
public class F31B0703 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WSEURID.
        /// </summary>
        public const string WSEURID = "WSEURID";

        /// <summary>
        /// WSSPECID.
        /// </summary>
        public const string WSSPECID = "WSSPECID";

        /// <summary>
        /// WSSEQNUMB.
        /// </summary>
        public const string WSSEQNUMB = "WSSEQNUMB";

        /// <summary>
        /// WSWISSC.
        /// </summary>
        public const string WSWISSC = "WSWISSC";

        /// <summary>
        /// WSURAB.
        /// </summary>
        public const string WSURAB = "WSURAB";

        /// <summary>
        /// WSURAT.
        /// </summary>
        public const string WSURAT = "WSURAT";

        /// <summary>
        /// WSURCD.
        /// </summary>
        public const string WSURCD = "WSURCD";

        /// <summary>
        /// WSURDT.
        /// </summary>
        public const string WSURDT = "WSURDT";

        /// <summary>
        /// WSURRF.
        /// </summary>
        public const string WSURRF = "WSURRF";

        /// <summary>
        /// WSJOBN.
        /// </summary>
        public const string WSJOBN = "WSJOBN";

        /// <summary>
        /// WSPID.
        /// </summary>
        public const string WSPID = "WSPID";

        /// <summary>
        /// WSTDAY.
        /// </summary>
        public const string WSTDAY = "WSTDAY";

        /// <summary>
        /// WSUPMJ.
        /// </summary>
        public const string WSUPMJ = "WSUPMJ";

        /// <summary>
        /// WSUSER.
        /// </summary>
        public const string WSUSER = "WSUSER";

        /// <summary>
        /// WSWAB.
        /// </summary>
        public const string WSWAB = "WSWAB";

        /// <summary>
        /// WSWCD.
        /// </summary>
        public const string WSWCD = "WSWCD";

        /// <summary>
        /// WSWMDT.
        /// </summary>
        public const string WSWMDT = "WSWMDT";

        /// <summary>
        /// WSWNUM.
        /// </summary>
        public const string WSWNUM = "WSWNUM";

        /// <summary>
        /// WSWRF.
        /// </summary>
        public const string WSWRF = "WSWRF";
    }

    /// <inheritdoc />
    public override string TableName => "F31B0703";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WSEURID", "WSEURID", JdeDataType.Numeric, null, true, true),
        new JdeField("WSSPECID", "WSSPECID", JdeDataType.Numeric, null, true, true),
        new JdeField("WSSEQNUMB", "WSSEQNUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("WSWISSC", "WSWISSC", JdeDataType.String, 12),
        new JdeField("WSURAB", "WSURAB", JdeDataType.Numeric),
        new JdeField("WSURAT", "WSURAT", JdeDataType.Numeric),
        new JdeField("WSURCD", "WSURCD", JdeDataType.String, 4),
        new JdeField("WSURDT", "WSURDT", JdeDataType.Numeric),
        new JdeField("WSURRF", "WSURRF", JdeDataType.String, 30),
        new JdeField("WSJOBN", "WSJOBN", JdeDataType.String, 20),
        new JdeField("WSPID", "WSPID", JdeDataType.String, 20),
        new JdeField("WSTDAY", "WSTDAY", JdeDataType.Numeric),
        new JdeField("WSUPMJ", "WSUPMJ", JdeDataType.Numeric),
        new JdeField("WSUSER", "WSUSER", JdeDataType.String, 20),
        new JdeField("WSWAB", "WSWAB", JdeDataType.Numeric),
        new JdeField("WSWCD", "WSWCD", JdeDataType.String, 6),
        new JdeField("WSWMDT", "WSWMDT", JdeDataType.Numeric),
        new JdeField("WSWNUM", "WSWNUM", JdeDataType.Numeric),
        new JdeField("WSWRF", "WSWRF", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B0703_0", "Primary Key on WSEURID, WSSPECID, WSSEQNUMB", new[] { "WSEURID", "WSSPECID", "WSSEQNUMB" }, isUnique: true, isPrimaryKey: true)
    };
}
