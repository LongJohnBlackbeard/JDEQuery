using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31PUI02 - .
/// </summary>
public class F31PUI02 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RRPID.
        /// </summary>
        public const string RRPID = "RRPID";

        /// <summary>
        /// RRUSER.
        /// </summary>
        public const string RRUSER = "RRUSER";

        /// <summary>
        /// RRDOCO.
        /// </summary>
        public const string RRDOCO = "RRDOCO";

        /// <summary>
        /// RRPRJM.
        /// </summary>
        public const string RRPRJM = "RRPRJM";

        /// <summary>
        /// RRALP1.
        /// </summary>
        public const string RRALP1 = "RRALP1";
    }

    /// <inheritdoc />
    public override string TableName => "F31PUI02";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RRPID", "RRPID", JdeDataType.String, 20),
        new JdeField("RRUSER", "RRUSER", JdeDataType.String, 20),
        new JdeField("RRDOCO", "RRDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("RRPRJM", "RRPRJM", JdeDataType.Numeric, null, true, true),
        new JdeField("RRALP1", "RRALP1", JdeDataType.String, 80)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31PUI02_0", "Primary Key on RRPRJM, RRDOCO", new[] { "RRPRJM", "RRDOCO" }, isUnique: true, isPrimaryKey: true)
    };
}
