using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74Y315 - .
/// </summary>
public class F74Y315 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RIKCO.
        /// </summary>
        public const string RIKCO = "RIKCO";

        /// <summary>
        /// RIDCT.
        /// </summary>
        public const string RIDCT = "RIDCT";

        /// <summary>
        /// RIDOC.
        /// </summary>
        public const string RIDOC = "RIDOC";

        /// <summary>
        /// RISFX.
        /// </summary>
        public const string RISFX = "RISFX";

        /// <summary>
        /// RIOKCO.
        /// </summary>
        public const string RIOKCO = "RIOKCO";

        /// <summary>
        /// RIODCT.
        /// </summary>
        public const string RIODCT = "RIODCT";

        /// <summary>
        /// RIODOC.
        /// </summary>
        public const string RIODOC = "RIODOC";
    }

    /// <inheritdoc />
    public override string TableName => "F74Y315";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RIKCO", "RIKCO", JdeDataType.String, 10, true, true),
        new JdeField("RIDCT", "RIDCT", JdeDataType.String, 4, true, true),
        new JdeField("RIDOC", "RIDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("RISFX", "RISFX", JdeDataType.String, 6, true, true),
        new JdeField("RIOKCO", "RIOKCO", JdeDataType.String, 10, true, true),
        new JdeField("RIODCT", "RIODCT", JdeDataType.String, 4, true, true),
        new JdeField("RIODOC", "RIODOC", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74Y315_0", "Primary Key on RIKCO, RIDCT, RIDOC, RISFX, RIOKCO, RIODCT, RIODOC", new[] { "RIKCO", "RIDCT", "RIDOC", "RISFX", "RIOKCO", "RIODCT", "RIODOC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74Y315_2", "Index on RIOKCO, RIODCT, RIODOC", new[] { "RIOKCO", "RIODCT", "RIODOC" })
    };
}
