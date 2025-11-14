using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F81A01C - .
/// </summary>
public class F81A01C : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PCFPID.
        /// </summary>
        public const string PCFPID = "PCFPID";

        /// <summary>
        /// PCLDSN.
        /// </summary>
        public const string PCLDSN = "PCLDSN";

        /// <summary>
        /// PCINT01.
        /// </summary>
        public const string PCINT01 = "PCINT01";
    }

    /// <inheritdoc />
    public override string TableName => "F81A01C";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PCFPID", "PCFPID", JdeDataType.String, 20, true, true),
        new JdeField("PCLDSN", "PCLDSN", JdeDataType.String, 20, true, true),
        new JdeField("PCINT01", "PCINT01", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F81A01C_0", "Primary Key on PCLDSN, PCFPID", new[] { "PCLDSN", "PCFPID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F81A01C_2", "Index on PCFPID", new[] { "PCFPID" })
    };
}
