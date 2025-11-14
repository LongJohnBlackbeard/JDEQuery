using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43211 - .
/// </summary>
public class F43211 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SSMCU.
        /// </summary>
        public const string SSMCU = "SSMCU";

        /// <summary>
        /// SSITM.
        /// </summary>
        public const string SSITM = "SSITM";

        /// <summary>
        /// SSLITM.
        /// </summary>
        public const string SSLITM = "SSLITM";

        /// <summary>
        /// SSAITM.
        /// </summary>
        public const string SSAITM = "SSAITM";

        /// <summary>
        /// SSAN8.
        /// </summary>
        public const string SSAN8 = "SSAN8";

        /// <summary>
        /// SSVSPC.
        /// </summary>
        public const string SSVSPC = "SSVSPC";

        /// <summary>
        /// SSEFFF.
        /// </summary>
        public const string SSEFFF = "SSEFFF";

        /// <summary>
        /// SSEFFT.
        /// </summary>
        public const string SSEFFT = "SSEFFT";

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
        /// SSUPMJ.
        /// </summary>
        public const string SSUPMJ = "SSUPMJ";

        /// <summary>
        /// SSUPMT.
        /// </summary>
        public const string SSUPMT = "SSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F43211";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SSMCU", "SSMCU", JdeDataType.String, 24, true, true),
        new JdeField("SSITM", "SSITM", JdeDataType.Numeric, null, true, true),
        new JdeField("SSLITM", "SSLITM", JdeDataType.String, 50),
        new JdeField("SSAITM", "SSAITM", JdeDataType.String, 50),
        new JdeField("SSAN8", "SSAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("SSVSPC", "SSVSPC", JdeDataType.Numeric),
        new JdeField("SSEFFF", "SSEFFF", JdeDataType.Numeric, null, true, true),
        new JdeField("SSEFFT", "SSEFFT", JdeDataType.Numeric),
        new JdeField("SSUSER", "SSUSER", JdeDataType.String, 20),
        new JdeField("SSPID", "SSPID", JdeDataType.String, 20),
        new JdeField("SSJOBN", "SSJOBN", JdeDataType.String, 20),
        new JdeField("SSUPMJ", "SSUPMJ", JdeDataType.Numeric),
        new JdeField("SSUPMT", "SSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43211_0", "Primary Key on SSMCU, SSITM, SSEFFF, SSAN8", new[] { "SSMCU", "SSITM", "SSEFFF", "SSAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
