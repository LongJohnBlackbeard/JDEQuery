using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I322D - .
/// </summary>
public class F75I322D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QCKCO.
        /// </summary>
        public const string QCKCO = "QCKCO";

        /// <summary>
        /// QCDCT.
        /// </summary>
        public const string QCDCT = "QCDCT";

        /// <summary>
        /// QCDOC.
        /// </summary>
        public const string QCDOC = "QCDOC";

        /// <summary>
        /// QCYEXU.
        /// </summary>
        public const string QCYEXU = "QCYEXU";

        /// <summary>
        /// QCYCHN.
        /// </summary>
        public const string QCYCHN = "QCYCHN";

        /// <summary>
        /// QCASVL.
        /// </summary>
        public const string QCASVL = "QCASVL";

        /// <summary>
        /// QCYEXA.
        /// </summary>
        public const string QCYEXA = "QCYEXA";
    }

    /// <inheritdoc />
    public override string TableName => "F75I322D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QCKCO", "QCKCO", JdeDataType.String, 10, true, true),
        new JdeField("QCDCT", "QCDCT", JdeDataType.String, 4, true, true),
        new JdeField("QCDOC", "QCDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("QCYEXU", "QCYEXU", JdeDataType.Numeric),
        new JdeField("QCYCHN", "QCYCHN", JdeDataType.String, 40, true, true),
        new JdeField("QCASVL", "QCASVL", JdeDataType.Numeric),
        new JdeField("QCYEXA", "QCYEXA", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I322D_0", "Primary Key on QCKCO, QCDCT, QCDOC, QCYCHN", new[] { "QCKCO", "QCDCT", "QCDOC", "QCYCHN" }, isUnique: true, isPrimaryKey: true)
    };
}
