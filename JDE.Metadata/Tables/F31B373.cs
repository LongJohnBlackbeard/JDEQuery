using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B373 - .
/// </summary>
public class F31B373 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GDGOAREA.
        /// </summary>
        public const string GDGOAREA = "GDGOAREA";

        /// <summary>
        /// GDDGOAREA.
        /// </summary>
        public const string GDDGOAREA = "GDDGOAREA";
    }

    /// <inheritdoc />
    public override string TableName => "F31B373";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GDGOAREA", "GDGOAREA", JdeDataType.String, 8, true, true),
        new JdeField("GDDGOAREA", "GDDGOAREA", JdeDataType.String, 8, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B373_0", "Primary Key on GDGOAREA, GDDGOAREA", new[] { "GDGOAREA", "GDDGOAREA" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B373_3", "Index on GDDGOAREA", new[] { "GDDGOAREA" }),
        new JdeIndex("F31B373_4", "Index on GDGOAREA", new[] { "GDGOAREA" })
    };
}
