using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74030HA - .
/// </summary>
public class F74030HA : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// STAPVR.
        /// </summary>
        public const string STAPVR = "STAPVR";

        /// <summary>
        /// STICU.
        /// </summary>
        public const string STICU = "STICU";

        /// <summary>
        /// STESEQ.
        /// </summary>
        public const string STESEQ = "STESEQ";

        /// <summary>
        /// STDGJ.
        /// </summary>
        public const string STDGJ = "STDGJ";
    }

    /// <inheritdoc />
    public override string TableName => "F74030HA";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("STAPVR", "STAPVR", JdeDataType.String, 20, true, true),
        new JdeField("STICU", "STICU", JdeDataType.Numeric),
        new JdeField("STESEQ", "STESEQ", JdeDataType.Numeric),
        new JdeField("STDGJ", "STDGJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74030HA_0", "Primary Key on STAPVR", new[] { "STAPVR" }, isUnique: true, isPrimaryKey: true)
    };
}
