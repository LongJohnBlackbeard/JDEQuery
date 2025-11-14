using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F5194 - .
/// </summary>
public class F5194 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JERECC.
        /// </summary>
        public const string JERECC = "JERECC";

        /// <summary>
        /// JEPATH.
        /// </summary>
        public const string JEPATH = "JEPATH";

        /// <summary>
        /// JEDL01.
        /// </summary>
        public const string JEDL01 = "JEDL01";

        /// <summary>
        /// JESEQ.
        /// </summary>
        public const string JESEQ = "JESEQ";

        /// <summary>
        /// JEFTNM.
        /// </summary>
        public const string JEFTNM = "JEFTNM";
    }

    /// <inheritdoc />
    public override string TableName => "F5194";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JERECC", "JERECC", JdeDataType.String, 4, true, true),
        new JdeField("JEPATH", "JEPATH", JdeDataType.String, 20, true, true),
        new JdeField("JEDL01", "JEDL01", JdeDataType.String, 60),
        new JdeField("JESEQ", "JESEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("JEFTNM", "JEFTNM", JdeDataType.String, 20, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F5194_0", "Primary Key on JERECC, JEPATH, JESEQ, JEFTNM", new[] { "JERECC", "JEPATH", "JESEQ", "JEFTNM" }, isUnique: true, isPrimaryKey: true)
    };
}
