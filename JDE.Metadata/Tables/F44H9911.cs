using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H9911 - .
/// </summary>
public class F44H9911 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MSHBRLTPC.
        /// </summary>
        public const string MSHBRLTPC = "MSHBRLTPC";

        /// <summary>
        /// MSHBMSID.
        /// </summary>
        public const string MSHBMSID = "MSHBMSID";

        /// <summary>
        /// MSCONLST.
        /// </summary>
        public const string MSCONLST = "MSCONLST";
    }

    /// <inheritdoc />
    public override string TableName => "F44H9911";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MSHBRLTPC", "MSHBRLTPC", JdeDataType.String, 6, true, true),
        new JdeField("MSHBMSID", "MSHBMSID", JdeDataType.String, 8, true, true),
        new JdeField("MSCONLST", "MSCONLST", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H9911_0", "Primary Key on MSHBRLTPC, MSHBMSID", new[] { "MSHBRLTPC", "MSHBMSID" }, isUnique: true, isPrimaryKey: true)
    };
}
