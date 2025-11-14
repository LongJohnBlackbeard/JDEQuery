using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74W300 - .
/// </summary>
public class F74W300 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RUUKID.
        /// </summary>
        public const string RUUKID = "RUUKID";

        /// <summary>
        /// RURC5.
        /// </summary>
        public const string RURC5 = "RURC5";

        /// <summary>
        /// RUPYID.
        /// </summary>
        public const string RUPYID = "RUPYID";

        /// <summary>
        /// RUMN5D0.
        /// </summary>
        public const string RUMN5D0 = "RUMN5D0";
    }

    /// <inheritdoc />
    public override string TableName => "F74W300";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RUUKID", "RUUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("RURC5", "RURC5", JdeDataType.Numeric, null, true, true),
        new JdeField("RUPYID", "RUPYID", JdeDataType.Numeric),
        new JdeField("RUMN5D0", "RUMN5D0", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74W300_0", "Primary Key on RUUKID, RURC5", new[] { "RUUKID", "RURC5" }, isUnique: true, isPrimaryKey: true)
    };
}
