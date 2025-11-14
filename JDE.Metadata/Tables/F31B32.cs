using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B32 - .
/// </summary>
public class F31B32 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WSWISSC.
        /// </summary>
        public const string WSWISSC = "WSWISSC";

        /// <summary>
        /// WSDL01.
        /// </summary>
        public const string WSDL01 = "WSDL01";

        /// <summary>
        /// WSSCODE.
        /// </summary>
        public const string WSSCODE = "WSSCODE";

        /// <summary>
        /// WSWISCC1.
        /// </summary>
        public const string WSWISCC1 = "WSWISCC1";

        /// <summary>
        /// WSWISCC2.
        /// </summary>
        public const string WSWISCC2 = "WSWISCC2";

        /// <summary>
        /// WSWISCC3.
        /// </summary>
        public const string WSWISCC3 = "WSWISCC3";

        /// <summary>
        /// WSWISCC4.
        /// </summary>
        public const string WSWISCC4 = "WSWISCC4";

        /// <summary>
        /// WSWISCC5.
        /// </summary>
        public const string WSWISCC5 = "WSWISCC5";

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
        /// WSURRF.
        /// </summary>
        public const string WSURRF = "WSURRF";

        /// <summary>
        /// WSURAB.
        /// </summary>
        public const string WSURAB = "WSURAB";

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
        /// WSUPMT.
        /// </summary>
        public const string WSUPMT = "WSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F31B32";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WSWISSC", "WSWISSC", JdeDataType.String, 12, true, true),
        new JdeField("WSDL01", "WSDL01", JdeDataType.String, 60),
        new JdeField("WSSCODE", "WSSCODE", JdeDataType.String, 2),
        new JdeField("WSWISCC1", "WSWISCC1", JdeDataType.String, 6),
        new JdeField("WSWISCC2", "WSWISCC2", JdeDataType.String, 6),
        new JdeField("WSWISCC3", "WSWISCC3", JdeDataType.String, 6),
        new JdeField("WSWISCC4", "WSWISCC4", JdeDataType.String, 6),
        new JdeField("WSWISCC5", "WSWISCC5", JdeDataType.String, 6),
        new JdeField("WSURCD", "WSURCD", JdeDataType.String, 4),
        new JdeField("WSURDT", "WSURDT", JdeDataType.Numeric),
        new JdeField("WSURAT", "WSURAT", JdeDataType.Numeric),
        new JdeField("WSURRF", "WSURRF", JdeDataType.String, 30),
        new JdeField("WSURAB", "WSURAB", JdeDataType.Numeric),
        new JdeField("WSUSER", "WSUSER", JdeDataType.String, 20),
        new JdeField("WSPID", "WSPID", JdeDataType.String, 20),
        new JdeField("WSJOBN", "WSJOBN", JdeDataType.String, 20),
        new JdeField("WSUPMJ", "WSUPMJ", JdeDataType.Numeric),
        new JdeField("WSUPMT", "WSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B32_0", "Primary Key on WSWISSC", new[] { "WSWISSC" }, isUnique: true, isPrimaryKey: true)
    };
}
