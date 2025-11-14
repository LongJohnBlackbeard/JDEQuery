using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4947 - .
/// </summary>
public class F4947 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// STSHPN.
        /// </summary>
        public const string STSHPN = "STSHPN";

        /// <summary>
        /// STRSSN.
        /// </summary>
        public const string STRSSN = "STRSSN";

        /// <summary>
        /// STOSEQ.
        /// </summary>
        public const string STOSEQ = "STOSEQ";

        /// <summary>
        /// STSSDT.
        /// </summary>
        public const string STSSDT = "STSSDT";

        /// <summary>
        /// STSSTM.
        /// </summary>
        public const string STSSTM = "STSSTM";

        /// <summary>
        /// STSSCD.
        /// </summary>
        public const string STSSCD = "STSSCD";

        /// <summary>
        /// STSSRS.
        /// </summary>
        public const string STSSRS = "STSSRS";

        /// <summary>
        /// STDESC.
        /// </summary>
        public const string STDESC = "STDESC";

        /// <summary>
        /// STREFQ.
        /// </summary>
        public const string STREFQ = "STREFQ";

        /// <summary>
        /// STREFN.
        /// </summary>
        public const string STREFN = "STREFN";

        /// <summary>
        /// STURCD.
        /// </summary>
        public const string STURCD = "STURCD";

        /// <summary>
        /// STURDT.
        /// </summary>
        public const string STURDT = "STURDT";

        /// <summary>
        /// STURAT.
        /// </summary>
        public const string STURAT = "STURAT";

        /// <summary>
        /// STURAB.
        /// </summary>
        public const string STURAB = "STURAB";

        /// <summary>
        /// STURRF.
        /// </summary>
        public const string STURRF = "STURRF";

        /// <summary>
        /// STUSER.
        /// </summary>
        public const string STUSER = "STUSER";

        /// <summary>
        /// STPID.
        /// </summary>
        public const string STPID = "STPID";

        /// <summary>
        /// STJOBN.
        /// </summary>
        public const string STJOBN = "STJOBN";

        /// <summary>
        /// STUPMJ.
        /// </summary>
        public const string STUPMJ = "STUPMJ";

        /// <summary>
        /// STTDAY.
        /// </summary>
        public const string STTDAY = "STTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4947";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("STSHPN", "STSHPN", JdeDataType.Numeric, null, true, true),
        new JdeField("STRSSN", "STRSSN", JdeDataType.Numeric, null, true, true),
        new JdeField("STOSEQ", "STOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("STSSDT", "STSSDT", JdeDataType.Numeric),
        new JdeField("STSSTM", "STSSTM", JdeDataType.Numeric),
        new JdeField("STSSCD", "STSSCD", JdeDataType.String, 6),
        new JdeField("STSSRS", "STSSRS", JdeDataType.String, 6),
        new JdeField("STDESC", "STDESC", JdeDataType.String, 60),
        new JdeField("STREFQ", "STREFQ", JdeDataType.String, 4),
        new JdeField("STREFN", "STREFN", JdeDataType.String, 60),
        new JdeField("STURCD", "STURCD", JdeDataType.String, 4),
        new JdeField("STURDT", "STURDT", JdeDataType.Numeric),
        new JdeField("STURAT", "STURAT", JdeDataType.Numeric),
        new JdeField("STURAB", "STURAB", JdeDataType.Numeric),
        new JdeField("STURRF", "STURRF", JdeDataType.String, 30),
        new JdeField("STUSER", "STUSER", JdeDataType.String, 20),
        new JdeField("STPID", "STPID", JdeDataType.String, 20),
        new JdeField("STJOBN", "STJOBN", JdeDataType.String, 20),
        new JdeField("STUPMJ", "STUPMJ", JdeDataType.Numeric),
        new JdeField("STTDAY", "STTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4947_0", "Primary Key on STSHPN, STRSSN, STOSEQ", new[] { "STSHPN", "STRSSN", "STOSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4947_2", "Index on STSHPN, STRSSN, SYS_NC00021$", new[] { "STSHPN", "STRSSN", "SYS_NC00021$" })
    };
}
