using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F00143 - .
/// </summary>
public class F00143 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// L5DDRL.
        /// </summary>
        public const string L5DDRL = "L5DDRL";

        /// <summary>
        /// L5FMDY.
        /// </summary>
        public const string L5FMDY = "L5FMDY";

        /// <summary>
        /// L5TODY.
        /// </summary>
        public const string L5TODY = "L5TODY";

        /// <summary>
        /// L5DADD.
        /// </summary>
        public const string L5DADD = "L5DADD";

        /// <summary>
        /// L5DYFX.
        /// </summary>
        public const string L5DYFX = "L5DYFX";

        /// <summary>
        /// L5MADD.
        /// </summary>
        public const string L5MADD = "L5MADD";
    }

    /// <inheritdoc />
    public override string TableName => "F00143";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("L5DDRL", "L5DDRL", JdeDataType.String, 10, true, true),
        new JdeField("L5FMDY", "L5FMDY", JdeDataType.Numeric, null, true, true),
        new JdeField("L5TODY", "L5TODY", JdeDataType.Numeric),
        new JdeField("L5DADD", "L5DADD", JdeDataType.Numeric),
        new JdeField("L5DYFX", "L5DYFX", JdeDataType.Numeric),
        new JdeField("L5MADD", "L5MADD", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F00143_0", "Primary Key on L5DDRL, L5FMDY", new[] { "L5DDRL", "L5FMDY" }, isUnique: true, isPrimaryKey: true)
    };
}
