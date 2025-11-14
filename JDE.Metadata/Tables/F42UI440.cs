using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42UI440 - .
/// </summary>
public class F42UI440 : JdeTable
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
        /// CSLITM.
        /// </summary>
        public const string CSLITM = "CSLITM";

        /// <summary>
        /// CSAITM.
        /// </summary>
        public const string CSAITM = "CSAITM";

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
        /// CSUNCS.
        /// </summary>
        public const string CSUNCS = "CSUNCS";

        /// <summary>
        /// CSPCTM.
        /// </summary>
        public const string CSPCTM = "CSPCTM";

        /// <summary>
        /// CSBSC.
        /// </summary>
        public const string CSBSC = "CSBSC";

        /// <summary>
        /// CSEFTJ.
        /// </summary>
        public const string CSEFTJ = "CSEFTJ";

        /// <summary>
        /// CSEXDJ.
        /// </summary>
        public const string CSEXDJ = "CSEXDJ";

        /// <summary>
        /// CSDUPITM.
        /// </summary>
        public const string CSDUPITM = "CSDUPITM";

        /// <summary>
        /// CSMEI.
        /// </summary>
        public const string CSMEI = "CSMEI";

        /// <summary>
        /// CSJOBS.
        /// </summary>
        public const string CSJOBS = "CSJOBS";

        /// <summary>
        /// CSCTID.
        /// </summary>
        public const string CSCTID = "CSCTID";
    }

    /// <inheritdoc />
    public override string TableName => "F42UI440";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CSITM", "CSITM", JdeDataType.Numeric, null, true, true),
        new JdeField("CSLITM", "CSLITM", JdeDataType.String, 50),
        new JdeField("CSAITM", "CSAITM", JdeDataType.String, 50),
        new JdeField("CSQTYU", "CSQTYU", JdeDataType.Numeric),
        new JdeField("CSUOM", "CSUOM", JdeDataType.String, 4),
        new JdeField("CSUPRC", "CSUPRC", JdeDataType.Numeric),
        new JdeField("CSUNCS", "CSUNCS", JdeDataType.Numeric),
        new JdeField("CSPCTM", "CSPCTM", JdeDataType.Numeric),
        new JdeField("CSBSC", "CSBSC", JdeDataType.String, 20, true, true),
        new JdeField("CSEFTJ", "CSEFTJ", JdeDataType.Numeric),
        new JdeField("CSEXDJ", "CSEXDJ", JdeDataType.Numeric),
        new JdeField("CSDUPITM", "CSDUPITM", JdeDataType.String, 2),
        new JdeField("CSMEI", "CSMEI", JdeDataType.String, 2),
        new JdeField("CSJOBS", "CSJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("CSCTID", "CSCTID", JdeDataType.String, 30, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42UI440_0", "Primary Key on CSBSC, CSITM, CSJOBS, CSCTID", new[] { "CSBSC", "CSITM", "CSJOBS", "CSCTID" }, isUnique: true, isPrimaryKey: true)
    };
}
