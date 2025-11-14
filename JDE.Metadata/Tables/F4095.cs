using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4095 - .
/// </summary>
public class F4095 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MLANUM.
        /// </summary>
        public const string MLANUM = "MLANUM";

        /// <summary>
        /// MLCO.
        /// </summary>
        public const string MLCO = "MLCO";

        /// <summary>
        /// MLDCTO.
        /// </summary>
        public const string MLDCTO = "MLDCTO";

        /// <summary>
        /// MLDCT.
        /// </summary>
        public const string MLDCT = "MLDCT";

        /// <summary>
        /// MLGLPT.
        /// </summary>
        public const string MLGLPT = "MLGLPT";

        /// <summary>
        /// MLCOST.
        /// </summary>
        public const string MLCOST = "MLCOST";

        /// <summary>
        /// MLMCU.
        /// </summary>
        public const string MLMCU = "MLMCU";

        /// <summary>
        /// MLOBJ.
        /// </summary>
        public const string MLOBJ = "MLOBJ";

        /// <summary>
        /// MLSUB.
        /// </summary>
        public const string MLSUB = "MLSUB";
    }

    /// <inheritdoc />
    public override string TableName => "F4095";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MLANUM", "MLANUM", JdeDataType.Numeric, null, true, true),
        new JdeField("MLCO", "MLCO", JdeDataType.String, 10, true, true),
        new JdeField("MLDCTO", "MLDCTO", JdeDataType.String, 4, true, true),
        new JdeField("MLDCT", "MLDCT", JdeDataType.String, 4, true, true),
        new JdeField("MLGLPT", "MLGLPT", JdeDataType.String, 8, true, true),
        new JdeField("MLCOST", "MLCOST", JdeDataType.String, 6, true, true),
        new JdeField("MLMCU", "MLMCU", JdeDataType.String, 24),
        new JdeField("MLOBJ", "MLOBJ", JdeDataType.String, 12),
        new JdeField("MLSUB", "MLSUB", JdeDataType.String, 16)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4095_0", "Primary Key on MLANUM, MLCO, MLDCTO, MLDCT, MLGLPT, MLCOST", new[] { "MLANUM", "MLCO", "MLDCTO", "MLDCT", "MLGLPT", "MLCOST" }, isUnique: true, isPrimaryKey: true)
    };
}
