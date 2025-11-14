using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75J04SA - .
/// </summary>
public class F75J04SA : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// J4SPLTYP.
        /// </summary>
        public const string J4SPLTYP = "J4SPLTYP";

        /// <summary>
        /// J4SPLAMT.
        /// </summary>
        public const string J4SPLAMT = "J4SPLAMT";

        /// <summary>
        /// J4DL01.
        /// </summary>
        public const string J4DL01 = "J4DL01";
    }

    /// <inheritdoc />
    public override string TableName => "F75J04SA";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("J4SPLTYP", "J4SPLTYP", JdeDataType.String, 2, true, true),
        new JdeField("J4SPLAMT", "J4SPLAMT", JdeDataType.Numeric, null, true, true),
        new JdeField("J4DL01", "J4DL01", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75J04SA_0", "Primary Key on J4SPLTYP, J4SPLAMT", new[] { "J4SPLTYP", "J4SPLAMT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75J04SA_2", "Unique Index on J4SPLTYP, SYS_NC00004$", new[] { "J4SPLTYP", "SYS_NC00004$" }, isUnique: true)
    };
}
