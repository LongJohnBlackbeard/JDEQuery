using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F34A70 - .
/// </summary>
public class F34A70 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OWITM.
        /// </summary>
        public const string OWITM = "OWITM";

        /// <summary>
        /// OWMCU.
        /// </summary>
        public const string OWMCU = "OWMCU";

        /// <summary>
        /// OWDRQJ.
        /// </summary>
        public const string OWDRQJ = "OWDRQJ";

        /// <summary>
        /// OWTRQT.
        /// </summary>
        public const string OWTRQT = "OWTRQT";

        /// <summary>
        /// OWSTRT.
        /// </summary>
        public const string OWSTRT = "OWSTRT";

        /// <summary>
        /// OWUNCD.
        /// </summary>
        public const string OWUNCD = "OWUNCD";

        /// <summary>
        /// OWEV01.
        /// </summary>
        public const string OWEV01 = "OWEV01";

        /// <summary>
        /// OWDOCO.
        /// </summary>
        public const string OWDOCO = "OWDOCO";
    }

    /// <inheritdoc />
    public override string TableName => "F34A70";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OWITM", "OWITM", JdeDataType.Numeric),
        new JdeField("OWMCU", "OWMCU", JdeDataType.String, 24),
        new JdeField("OWDRQJ", "OWDRQJ", JdeDataType.Numeric),
        new JdeField("OWTRQT", "OWTRQT", JdeDataType.Numeric),
        new JdeField("OWSTRT", "OWSTRT", JdeDataType.Numeric),
        new JdeField("OWUNCD", "OWUNCD", JdeDataType.String, 2),
        new JdeField("OWEV01", "OWEV01", JdeDataType.String, 2),
        new JdeField("OWDOCO", "OWDOCO", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F34A70_0", "Primary Key on OWDOCO", new[] { "OWDOCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F34A70_2", "Index on OWEV01", new[] { "OWEV01" })
    };
}
