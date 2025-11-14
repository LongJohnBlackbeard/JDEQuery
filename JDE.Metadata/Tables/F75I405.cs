using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I405 - .
/// </summary>
public class F75I405 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DPYMNTH.
        /// </summary>
        public const string DPYMNTH = "DPYMNTH";

        /// <summary>
        /// DPYMNTH1.
        /// </summary>
        public const string DPYMNTH1 = "DPYMNTH1";

        /// <summary>
        /// DPDYR.
        /// </summary>
        public const string DPDYR = "DPDYR";

        /// <summary>
        /// DPMCU.
        /// </summary>
        public const string DPMCU = "DPMCU";

        /// <summary>
        /// DPI75CGAP.
        /// </summary>
        public const string DPI75CGAP = "DPI75CGAP";

        /// <summary>
        /// DPI75CGNP.
        /// </summary>
        public const string DPI75CGNP = "DPI75CGNP";

        /// <summary>
        /// DPI75CGAF.
        /// </summary>
        public const string DPI75CGAF = "DPI75CGAF";

        /// <summary>
        /// DPI75PCAP.
        /// </summary>
        public const string DPI75PCAP = "DPI75PCAP";

        /// <summary>
        /// DPI75PCNP.
        /// </summary>
        public const string DPI75PCNP = "DPI75PCNP";

        /// <summary>
        /// DPI75PCAF.
        /// </summary>
        public const string DPI75PCAF = "DPI75PCAF";

        /// <summary>
        /// DPI75STAP.
        /// </summary>
        public const string DPI75STAP = "DPI75STAP";

        /// <summary>
        /// DPI75STNP.
        /// </summary>
        public const string DPI75STNP = "DPI75STNP";

        /// <summary>
        /// DPI75STAF.
        /// </summary>
        public const string DPI75STAF = "DPI75STAF";

        /// <summary>
        /// DPI75SOAP.
        /// </summary>
        public const string DPI75SOAP = "DPI75SOAP";

        /// <summary>
        /// DPI75SONP.
        /// </summary>
        public const string DPI75SONP = "DPI75SONP";

        /// <summary>
        /// DPI75SOAF.
        /// </summary>
        public const string DPI75SOAF = "DPI75SOAF";

        /// <summary>
        /// DPI75COFL.
        /// </summary>
        public const string DPI75COFL = "DPI75COFL";

        /// <summary>
        /// DPUSER.
        /// </summary>
        public const string DPUSER = "DPUSER";

        /// <summary>
        /// DPPID.
        /// </summary>
        public const string DPPID = "DPPID";

        /// <summary>
        /// DPJOBN.
        /// </summary>
        public const string DPJOBN = "DPJOBN";

        /// <summary>
        /// DPUPMJ.
        /// </summary>
        public const string DPUPMJ = "DPUPMJ";

        /// <summary>
        /// DPUPMT.
        /// </summary>
        public const string DPUPMT = "DPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75I405";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DPYMNTH", "DPYMNTH", JdeDataType.String, 4, true, true),
        new JdeField("DPYMNTH1", "DPYMNTH1", JdeDataType.String, 4),
        new JdeField("DPDYR", "DPDYR", JdeDataType.Numeric, null, true, true),
        new JdeField("DPMCU", "DPMCU", JdeDataType.String, 24, true, true),
        new JdeField("DPI75CGAP", "DPI75CGAP", JdeDataType.Numeric),
        new JdeField("DPI75CGNP", "DPI75CGNP", JdeDataType.Numeric),
        new JdeField("DPI75CGAF", "DPI75CGAF", JdeDataType.Numeric),
        new JdeField("DPI75PCAP", "DPI75PCAP", JdeDataType.Numeric),
        new JdeField("DPI75PCNP", "DPI75PCNP", JdeDataType.Numeric),
        new JdeField("DPI75PCAF", "DPI75PCAF", JdeDataType.Numeric),
        new JdeField("DPI75STAP", "DPI75STAP", JdeDataType.Numeric),
        new JdeField("DPI75STNP", "DPI75STNP", JdeDataType.Numeric),
        new JdeField("DPI75STAF", "DPI75STAF", JdeDataType.Numeric),
        new JdeField("DPI75SOAP", "DPI75SOAP", JdeDataType.Numeric),
        new JdeField("DPI75SONP", "DPI75SONP", JdeDataType.Numeric),
        new JdeField("DPI75SOAF", "DPI75SOAF", JdeDataType.Numeric),
        new JdeField("DPI75COFL", "DPI75COFL", JdeDataType.String, 2),
        new JdeField("DPUSER", "DPUSER", JdeDataType.String, 20),
        new JdeField("DPPID", "DPPID", JdeDataType.String, 20),
        new JdeField("DPJOBN", "DPJOBN", JdeDataType.String, 20),
        new JdeField("DPUPMJ", "DPUPMJ", JdeDataType.Numeric),
        new JdeField("DPUPMT", "DPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I405_0", "Primary Key on DPMCU, DPDYR, DPYMNTH", new[] { "DPMCU", "DPDYR", "DPYMNTH" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I405_2", "Index on DPYMNTH1, DPYMNTH", new[] { "DPYMNTH1", "DPYMNTH" })
    };
}
