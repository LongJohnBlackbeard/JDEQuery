using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4015W - .
/// </summary>
public class F4015W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ODAN8.
        /// </summary>
        public const string ODAN8 = "ODAN8";

        /// <summary>
        /// ODORTP.
        /// </summary>
        public const string ODORTP = "ODORTP";

        /// <summary>
        /// ODDESC.
        /// </summary>
        public const string ODDESC = "ODDESC";
    }

    /// <inheritdoc />
    public override string TableName => "F4015W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ODAN8", "ODAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ODORTP", "ODORTP", JdeDataType.String, 16, true, true),
        new JdeField("ODDESC", "ODDESC", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4015W_0", "Primary Key on ODAN8, ODORTP", new[] { "ODAN8", "ODORTP" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4015W_2", "Index on ODAN8, ODDESC", new[] { "ODAN8", "ODDESC" })
    };
}
