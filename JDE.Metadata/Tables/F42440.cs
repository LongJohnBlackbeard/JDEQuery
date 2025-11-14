using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42440 - .
/// </summary>
public class F42440 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CSITM.
        /// </summary>
        public const string CSITM = "CSITM";

        /// <summary>
        /// CSAITM.
        /// </summary>
        public const string CSAITM = "CSAITM";

        /// <summary>
        /// CSLITM.
        /// </summary>
        public const string CSLITM = "CSLITM";

        /// <summary>
        /// CSQTYU.
        /// </summary>
        public const string CSQTYU = "CSQTYU";

        /// <summary>
        /// CSUOM.
        /// </summary>
        public const string CSUOM = "CSUOM";

        /// <summary>
        /// CSUPRC.
        /// </summary>
        public const string CSUPRC = "CSUPRC";

        /// <summary>
        /// CSBSC.
        /// </summary>
        public const string CSBSC = "CSBSC";

        /// <summary>
        /// CSPCTM.
        /// </summary>
        public const string CSPCTM = "CSPCTM";

        /// <summary>
        /// CSEFTJ.
        /// </summary>
        public const string CSEFTJ = "CSEFTJ";

        /// <summary>
        /// CSEXDJ.
        /// </summary>
        public const string CSEXDJ = "CSEXDJ";

        /// <summary>
        /// CSMEI.
        /// </summary>
        public const string CSMEI = "CSMEI";
    }

    /// <inheritdoc />
    public override string TableName => "F42440";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CSITM", "CSITM", JdeDataType.Numeric, null, true, true),
        new JdeField("CSAITM", "CSAITM", JdeDataType.String, 50),
        new JdeField("CSLITM", "CSLITM", JdeDataType.String, 50),
        new JdeField("CSQTYU", "CSQTYU", JdeDataType.Numeric),
        new JdeField("CSUOM", "CSUOM", JdeDataType.String, 4),
        new JdeField("CSUPRC", "CSUPRC", JdeDataType.Numeric),
        new JdeField("CSBSC", "CSBSC", JdeDataType.String, 20, true, true),
        new JdeField("CSPCTM", "CSPCTM", JdeDataType.Numeric),
        new JdeField("CSEFTJ", "CSEFTJ", JdeDataType.Numeric),
        new JdeField("CSEXDJ", "CSEXDJ", JdeDataType.Numeric),
        new JdeField("CSMEI", "CSMEI", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42440_0", "Primary Key on CSBSC, CSITM", new[] { "CSBSC", "CSITM" }, isUnique: true, isPrimaryKey: true)
    };
}
