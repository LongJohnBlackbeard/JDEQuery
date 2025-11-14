using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F5193 - .
/// </summary>
public class F5193 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JDRECC.
        /// </summary>
        public const string JDRECC = "JDRECC";

        /// <summary>
        /// JDFTNM.
        /// </summary>
        public const string JDFTNM = "JDFTNM";

        /// <summary>
        /// JDDL01.
        /// </summary>
        public const string JDDL01 = "JDDL01";

        /// <summary>
        /// JDCLM1.
        /// </summary>
        public const string JDCLM1 = "JDCLM1";

        /// <summary>
        /// JDCLM2.
        /// </summary>
        public const string JDCLM2 = "JDCLM2";

        /// <summary>
        /// JDCLM3.
        /// </summary>
        public const string JDCLM3 = "JDCLM3";

        /// <summary>
        /// JDCLM4.
        /// </summary>
        public const string JDCLM4 = "JDCLM4";
    }

    /// <inheritdoc />
    public override string TableName => "F5193";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JDRECC", "JDRECC", JdeDataType.String, 4, true, true),
        new JdeField("JDFTNM", "JDFTNM", JdeDataType.String, 20, true, true),
        new JdeField("JDDL01", "JDDL01", JdeDataType.String, 60),
        new JdeField("JDCLM1", "JDCLM1", JdeDataType.String, 8),
        new JdeField("JDCLM2", "JDCLM2", JdeDataType.String, 8),
        new JdeField("JDCLM3", "JDCLM3", JdeDataType.String, 8),
        new JdeField("JDCLM4", "JDCLM4", JdeDataType.String, 8)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F5193_0", "Primary Key on JDRECC, JDFTNM", new[] { "JDRECC", "JDFTNM" }, isUnique: true, isPrimaryKey: true)
    };
}
