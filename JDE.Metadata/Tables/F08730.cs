using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08730 - .
/// </summary>
public class F08730 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SSSTCTY.
        /// </summary>
        public const string SSSTCTY = "SSSTCTY";

        /// <summary>
        /// SSAPPTY.
        /// </summary>
        public const string SSAPPTY = "SSAPPTY";

        /// <summary>
        /// SSUPMJ.
        /// </summary>
        public const string SSUPMJ = "SSUPMJ";

        /// <summary>
        /// SSUPMT.
        /// </summary>
        public const string SSUPMT = "SSUPMT";

        /// <summary>
        /// SSUSER.
        /// </summary>
        public const string SSUSER = "SSUSER";

        /// <summary>
        /// SSPID.
        /// </summary>
        public const string SSPID = "SSPID";

        /// <summary>
        /// SSJOBN.
        /// </summary>
        public const string SSJOBN = "SSJOBN";

        /// <summary>
        /// SSOBNM.
        /// </summary>
        public const string SSOBNM = "SSOBNM";

        /// <summary>
        /// SSFCTNM.
        /// </summary>
        public const string SSFCTNM = "SSFCTNM";
    }

    /// <inheritdoc />
    public override string TableName => "F08730";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SSSTCTY", "SSSTCTY", JdeDataType.String, 16, true, true),
        new JdeField("SSAPPTY", "SSAPPTY", JdeDataType.String, 8),
        new JdeField("SSUPMJ", "SSUPMJ", JdeDataType.Numeric),
        new JdeField("SSUPMT", "SSUPMT", JdeDataType.Numeric),
        new JdeField("SSUSER", "SSUSER", JdeDataType.String, 20),
        new JdeField("SSPID", "SSPID", JdeDataType.String, 20),
        new JdeField("SSJOBN", "SSJOBN", JdeDataType.String, 20),
        new JdeField("SSOBNM", "SSOBNM", JdeDataType.String, 20),
        new JdeField("SSFCTNM", "SSFCTNM", JdeDataType.String, 64)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08730_0", "Primary Key on SSSTCTY", new[] { "SSSTCTY" }, isUnique: true, isPrimaryKey: true)
    };
}
