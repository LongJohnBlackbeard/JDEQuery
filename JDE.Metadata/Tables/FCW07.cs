using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW07 - .
/// </summary>
public class FCW07 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CDC9COLL.
        /// </summary>
        public const string CDC9COLL = "CDC9COLL";

        /// <summary>
        /// CDC9SEAC.
        /// </summary>
        public const string CDC9SEAC = "CDC9SEAC";

        /// <summary>
        /// CDC9SEAY.
        /// </summary>
        public const string CDC9SEAY = "CDC9SEAY";

        /// <summary>
        /// CDC9LVNO.
        /// </summary>
        public const string CDC9LVNO = "CDC9LVNO";

        /// <summary>
        /// CDC9LVL1.
        /// </summary>
        public const string CDC9LVL1 = "CDC9LVL1";

        /// <summary>
        /// CDC9LVL2.
        /// </summary>
        public const string CDC9LVL2 = "CDC9LVL2";

        /// <summary>
        /// CDC9LVL3.
        /// </summary>
        public const string CDC9LVL3 = "CDC9LVL3";

        /// <summary>
        /// CDC9LVL4.
        /// </summary>
        public const string CDC9LVL4 = "CDC9LVL4";

        /// <summary>
        /// CDC9LVL5.
        /// </summary>
        public const string CDC9LVL5 = "CDC9LVL5";

        /// <summary>
        /// CDC9ITM.
        /// </summary>
        public const string CDC9ITM = "CDC9ITM";

        /// <summary>
        /// CDC9FSKU.
        /// </summary>
        public const string CDC9FSKU = "CDC9FSKU";

        /// <summary>
        /// CDC9LVN2.
        /// </summary>
        public const string CDC9LVN2 = "CDC9LVN2";
    }

    /// <inheritdoc />
    public override string TableName => "FCW07";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CDC9COLL", "CDC9COLL", JdeDataType.String, 20, true, true),
        new JdeField("CDC9SEAC", "CDC9SEAC", JdeDataType.String, 4, true, true),
        new JdeField("CDC9SEAY", "CDC9SEAY", JdeDataType.String, 8, true, true),
        new JdeField("CDC9LVNO", "CDC9LVNO", JdeDataType.Numeric, null, true, true),
        new JdeField("CDC9LVL1", "CDC9LVL1", JdeDataType.String, 12, true, true),
        new JdeField("CDC9LVL2", "CDC9LVL2", JdeDataType.String, 12, true, true),
        new JdeField("CDC9LVL3", "CDC9LVL3", JdeDataType.String, 12, true, true),
        new JdeField("CDC9LVL4", "CDC9LVL4", JdeDataType.String, 12, true, true),
        new JdeField("CDC9LVL5", "CDC9LVL5", JdeDataType.String, 12, true, true),
        new JdeField("CDC9ITM", "CDC9ITM", JdeDataType.Numeric, null, true, true),
        new JdeField("CDC9FSKU", "CDC9FSKU", JdeDataType.String, 2),
        new JdeField("CDC9LVN2", "CDC9LVN2", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW07_0", "Primary Key on CDC9COLL, CDC9SEAC, CDC9SEAY, CDC9LVNO, CDC9LVL1, CDC9LVL2, CDC9LVL3, CDC9LVL4, CDC9LVL5, CDC9ITM", new[] { "CDC9COLL", "CDC9SEAC", "CDC9SEAY", "CDC9LVNO", "CDC9LVL1", "CDC9LVL2", "CDC9LVL3", "CDC9LVL4", "CDC9LVL5", "CDC9ITM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FCW07_2", "Index on CDC9COLL, CDC9SEAC, CDC9SEAY, CDC9ITM", new[] { "CDC9COLL", "CDC9SEAC", "CDC9SEAY", "CDC9ITM" }),
        new JdeIndex("FCW07_3", "Index on CDC9COLL", new[] { "CDC9COLL" })
    };
}
