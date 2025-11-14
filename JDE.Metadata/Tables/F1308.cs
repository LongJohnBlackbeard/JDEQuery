using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1308 - .
/// </summary>
public class F1308 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// F0NUMB.
        /// </summary>
        public const string F0NUMB = "F0NUMB";

        /// <summary>
        /// F0AAID.
        /// </summary>
        public const string F0AAID = "F0AAID";

        /// <summary>
        /// F0SRVT.
        /// </summary>
        public const string F0SRVT = "F0SRVT";

        /// <summary>
        /// F0DOCO.
        /// </summary>
        public const string F0DOCO = "F0DOCO";

        /// <summary>
        /// F0EQR1.
        /// </summary>
        public const string F0EQR1 = "F0EQR1";

        /// <summary>
        /// F0EQR2.
        /// </summary>
        public const string F0EQR2 = "F0EQR2";

        /// <summary>
        /// F0EQR3.
        /// </summary>
        public const string F0EQR3 = "F0EQR3";
    }

    /// <inheritdoc />
    public override string TableName => "F1308";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("F0NUMB", "F0NUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("F0AAID", "F0AAID", JdeDataType.Numeric, null, true, true),
        new JdeField("F0SRVT", "F0SRVT", JdeDataType.String, 16, true, true),
        new JdeField("F0DOCO", "F0DOCO", JdeDataType.Numeric),
        new JdeField("F0EQR1", "F0EQR1", JdeDataType.String, 2),
        new JdeField("F0EQR2", "F0EQR2", JdeDataType.String, 2),
        new JdeField("F0EQR3", "F0EQR3", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1308_0", "Primary Key on F0NUMB, F0SRVT, F0AAID", new[] { "F0NUMB", "F0SRVT", "F0AAID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1308_2", "Index on F0AAID, F0SRVT", new[] { "F0AAID", "F0SRVT" })
    };
}
