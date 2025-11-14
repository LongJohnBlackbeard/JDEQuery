using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76C4008 - .
/// </summary>
public class F76C4008 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TATXA1.
        /// </summary>
        public const string TATXA1 = "TATXA1";

        /// <summary>
        /// TAITM.
        /// </summary>
        public const string TAITM = "TAITM";

        /// <summary>
        /// TAEFDJ.
        /// </summary>
        public const string TAEFDJ = "TAEFDJ";

        /// <summary>
        /// TA76CAEC.
        /// </summary>
        public const string TA76CAEC = "TA76CAEC";

        /// <summary>
        /// TAUSER.
        /// </summary>
        public const string TAUSER = "TAUSER";

        /// <summary>
        /// TAPID.
        /// </summary>
        public const string TAPID = "TAPID";

        /// <summary>
        /// TAUPMJ.
        /// </summary>
        public const string TAUPMJ = "TAUPMJ";

        /// <summary>
        /// TAUPMT.
        /// </summary>
        public const string TAUPMT = "TAUPMT";

        /// <summary>
        /// TAJOBN.
        /// </summary>
        public const string TAJOBN = "TAJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F76C4008";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TATXA1", "TATXA1", JdeDataType.String, 20, true, true),
        new JdeField("TAITM", "TAITM", JdeDataType.Numeric, null, true, true),
        new JdeField("TAEFDJ", "TAEFDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("TA76CAEC", "TA76CAEC", JdeDataType.String, 6),
        new JdeField("TAUSER", "TAUSER", JdeDataType.String, 20),
        new JdeField("TAPID", "TAPID", JdeDataType.String, 20),
        new JdeField("TAUPMJ", "TAUPMJ", JdeDataType.Numeric),
        new JdeField("TAUPMT", "TAUPMT", JdeDataType.Numeric),
        new JdeField("TAJOBN", "TAJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76C4008_0", "Primary Key on TATXA1, TAITM, TAEFDJ", new[] { "TATXA1", "TAITM", "TAEFDJ" }, isUnique: true, isPrimaryKey: true)
    };
}
