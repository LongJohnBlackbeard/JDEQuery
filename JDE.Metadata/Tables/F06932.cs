using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06932 - .
/// </summary>
public class F06932 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// J4JBCD.
        /// </summary>
        public const string J4JBCD = "J4JBCD";

        /// <summary>
        /// J4JBST.
        /// </summary>
        public const string J4JBST = "J4JBST";

        /// <summary>
        /// J4UN.
        /// </summary>
        public const string J4UN = "J4UN";

        /// <summary>
        /// J4MCU.
        /// </summary>
        public const string J4MCU = "J4MCU";

        /// <summary>
        /// J4SHFT.
        /// </summary>
        public const string J4SHFT = "J4SHFT";

        /// <summary>
        /// J4PPYF.
        /// </summary>
        public const string J4PPYF = "J4PPYF";

        /// <summary>
        /// J4PPYT.
        /// </summary>
        public const string J4PPYT = "J4PPYT";
    }

    /// <inheritdoc />
    public override string TableName => "F06932";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("J4JBCD", "J4JBCD", JdeDataType.String, 12, true, true),
        new JdeField("J4JBST", "J4JBST", JdeDataType.String, 8, true, true),
        new JdeField("J4UN", "J4UN", JdeDataType.String, 12, true, true),
        new JdeField("J4MCU", "J4MCU", JdeDataType.String, 24, true, true),
        new JdeField("J4SHFT", "J4SHFT", JdeDataType.String, 2, true, true),
        new JdeField("J4PPYF", "J4PPYF", JdeDataType.Numeric, null, true, true),
        new JdeField("J4PPYT", "J4PPYT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06932_0", "Primary Key on J4JBCD, J4JBST, J4UN, J4MCU, J4SHFT, J4PPYF", new[] { "J4JBCD", "J4JBST", "J4UN", "J4MCU", "J4SHFT", "J4PPYF" }, isUnique: true, isPrimaryKey: true)
    };
}
