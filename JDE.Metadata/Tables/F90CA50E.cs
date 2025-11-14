using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA50E - .
/// </summary>
public class F90CA50E : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EMEMAILID.
        /// </summary>
        public const string EMEMAILID = "EMEMAILID";

        /// <summary>
        /// EMEMAL.
        /// </summary>
        public const string EMEMAL = "EMEMAL";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA50E";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EMEMAILID", "EMEMAILID", JdeDataType.Numeric, null, true, true),
        new JdeField("EMEMAL", "EMEMAL", JdeDataType.String, 512, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA50E_0", "Primary Key on EMEMAILID, EMEMAL", new[] { "EMEMAILID", "EMEMAL" }, isUnique: true, isPrimaryKey: true)
    };
}
