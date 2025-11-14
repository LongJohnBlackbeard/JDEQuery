using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B57OW - .
/// </summary>
public class F03B57OW : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// REPGM.
        /// </summary>
        public const string REPGM = "REPGM";

        /// <summary>
        /// READCN.
        /// </summary>
        public const string READCN = "READCN";

        /// <summary>
        /// RELNID.
        /// </summary>
        public const string RELNID = "RELNID";

        /// <summary>
        /// REFNAM.
        /// </summary>
        public const string REFNAM = "REFNAM";

        /// <summary>
        /// REAPTA.
        /// </summary>
        public const string REAPTA = "REAPTA";
    }

    /// <inheritdoc />
    public override string TableName => "F03B57OW";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("REPGM", "REPGM", JdeDataType.String, 20, true, true),
        new JdeField("READCN", "READCN", JdeDataType.Numeric, null, true, true),
        new JdeField("RELNID", "RELNID", JdeDataType.Numeric, null, true, true),
        new JdeField("REFNAM", "REFNAM", JdeDataType.String, 20),
        new JdeField("REAPTA", "REAPTA", JdeDataType.String, 3000)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B57OW_0", "Primary Key on REPGM, READCN, RELNID", new[] { "REPGM", "READCN", "RELNID" }, isUnique: true, isPrimaryKey: true)
    };
}
