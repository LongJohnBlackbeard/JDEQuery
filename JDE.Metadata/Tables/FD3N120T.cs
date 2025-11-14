using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FD3N120T - .
/// </summary>
public class FD3N120T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FAJOBS.
        /// </summary>
        public const string FAJOBS = "FAJOBS";

        /// <summary>
        /// FANUMB.
        /// </summary>
        public const string FANUMB = "FANUMB";

        /// <summary>
        /// FAAPID.
        /// </summary>
        public const string FAAPID = "FAAPID";
    }

    /// <inheritdoc />
    public override string TableName => "FD3N120T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FAJOBS", "FAJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("FANUMB", "FANUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("FAAPID", "FAAPID", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FD3N120T_0", "Primary Key on FAJOBS, FANUMB", new[] { "FAJOBS", "FANUMB" }, isUnique: true, isPrimaryKey: true)
    };
}
