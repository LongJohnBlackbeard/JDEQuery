using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F98TC03 - .
/// </summary>
public class F98TC03 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TNMCU.
        /// </summary>
        public const string TNMCU = "TNMCU";

        /// <summary>
        /// TNITM.
        /// </summary>
        public const string TNITM = "TNITM";

        /// <summary>
        /// TNLOCN.
        /// </summary>
        public const string TNLOCN = "TNLOCN";

        /// <summary>
        /// TNLOTN.
        /// </summary>
        public const string TNLOTN = "TNLOTN";

        /// <summary>
        /// TNCSDJ.
        /// </summary>
        public const string TNCSDJ = "TNCSDJ";

        /// <summary>
        /// TNDLR.
        /// </summary>
        public const string TNDLR = "TNDLR";
    }

    /// <inheritdoc />
    public override string TableName => "F98TC03";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TNMCU", "TNMCU", JdeDataType.String, 24, true, true),
        new JdeField("TNITM", "TNITM", JdeDataType.Numeric, null, true, true),
        new JdeField("TNLOCN", "TNLOCN", JdeDataType.String, 40, true, true),
        new JdeField("TNLOTN", "TNLOTN", JdeDataType.String, 60, true, true),
        new JdeField("TNCSDJ", "TNCSDJ", JdeDataType.Numeric),
        new JdeField("TNDLR", "TNDLR", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F98TC03_0", "Primary Key on TNMCU, TNITM, TNLOCN, TNLOTN", new[] { "TNMCU", "TNITM", "TNLOCN", "TNLOTN" }, isUnique: true, isPrimaryKey: true)
    };
}
