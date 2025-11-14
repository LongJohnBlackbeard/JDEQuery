using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74S408 - .
/// </summary>
public class F74S408 : JdeTable
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
        /// TAS740107.
        /// </summary>
        public const string TAS740107 = "TAS740107";

        /// <summary>
        /// TAS740108.
        /// </summary>
        public const string TAS740108 = "TAS740108";

        /// <summary>
        /// TAS740109.
        /// </summary>
        public const string TAS740109 = "TAS740109";

        /// <summary>
        /// TAS740114.
        /// </summary>
        public const string TAS740114 = "TAS740114";

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

        /// <summary>
        /// TAS74TER.
        /// </summary>
        public const string TAS74TER = "TAS74TER";

        /// <summary>
        /// TAS74NSTT.
        /// </summary>
        public const string TAS74NSTT = "TAS74NSTT";
    }

    /// <inheritdoc />
    public override string TableName => "F74S408";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TATXA1", "TATXA1", JdeDataType.String, 20, true, true),
        new JdeField("TAITM", "TAITM", JdeDataType.Numeric, null, true, true),
        new JdeField("TAEFDJ", "TAEFDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("TAS740107", "TAS740107", JdeDataType.String, 2),
        new JdeField("TAS740108", "TAS740108", JdeDataType.String, 2),
        new JdeField("TAS740109", "TAS740109", JdeDataType.String, 2),
        new JdeField("TAS740114", "TAS740114", JdeDataType.String, 2),
        new JdeField("TAUSER", "TAUSER", JdeDataType.String, 20),
        new JdeField("TAPID", "TAPID", JdeDataType.String, 20),
        new JdeField("TAUPMJ", "TAUPMJ", JdeDataType.Numeric),
        new JdeField("TAUPMT", "TAUPMT", JdeDataType.Numeric),
        new JdeField("TAJOBN", "TAJOBN", JdeDataType.String, 20),
        new JdeField("TAS74TER", "TAS74TER", JdeDataType.String, 40),
        new JdeField("TAS74NSTT", "TAS74NSTT", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74S408_0", "Primary Key on TATXA1, TAITM, TAEFDJ", new[] { "TATXA1", "TAITM", "TAEFDJ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74S408_2", "Index on TAS740107, TAS740108, TAS740109, TAS740114", new[] { "TAS740107", "TAS740108", "TAS740109", "TAS740114" })
    };
}
