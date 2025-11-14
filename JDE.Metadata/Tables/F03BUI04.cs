using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03BUI04 - .
/// </summary>
public class F03BUI04 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// W3PSEL.
        /// </summary>
        public const string W3PSEL = "W3PSEL";

        /// <summary>
        /// W3ANI.
        /// </summary>
        public const string W3ANI = "W3ANI";

        /// <summary>
        /// W3ITEM.
        /// </summary>
        public const string W3ITEM = "W3ITEM";

        /// <summary>
        /// W3CO.
        /// </summary>
        public const string W3CO = "W3CO";

        /// <summary>
        /// W3AG.
        /// </summary>
        public const string W3AG = "W3AG";

        /// <summary>
        /// W3AA.
        /// </summary>
        public const string W3AA = "W3AA";

        /// <summary>
        /// W3DTAI.
        /// </summary>
        public const string W3DTAI = "W3DTAI";

        /// <summary>
        /// W3CRCD.
        /// </summary>
        public const string W3CRCD = "W3CRCD";

        /// <summary>
        /// W3FY.
        /// </summary>
        public const string W3FY = "W3FY";

        /// <summary>
        /// W3CTRY.
        /// </summary>
        public const string W3CTRY = "W3CTRY";
    }

    /// <inheritdoc />
    public override string TableName => "F03BUI04";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("W3PSEL", "W3PSEL", JdeDataType.Numeric, null, true, true),
        new JdeField("W3ANI", "W3ANI", JdeDataType.String, 58, true, true),
        new JdeField("W3ITEM", "W3ITEM", JdeDataType.String, 12, true, true),
        new JdeField("W3CO", "W3CO", JdeDataType.String, 10, true, true),
        new JdeField("W3AG", "W3AG", JdeDataType.Numeric),
        new JdeField("W3AA", "W3AA", JdeDataType.Numeric),
        new JdeField("W3DTAI", "W3DTAI", JdeDataType.String, 20),
        new JdeField("W3CRCD", "W3CRCD", JdeDataType.String, 6, true, true),
        new JdeField("W3FY", "W3FY", JdeDataType.Numeric, null, true, true),
        new JdeField("W3CTRY", "W3CTRY", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03BUI04_0", "Primary Key on W3PSEL, W3ANI, W3ITEM, W3CO, W3CRCD, W3FY, W3CTRY", new[] { "W3PSEL", "W3ANI", "W3ITEM", "W3CO", "W3CRCD", "W3FY", "W3CTRY" }, isUnique: true, isPrimaryKey: true)
    };
}
