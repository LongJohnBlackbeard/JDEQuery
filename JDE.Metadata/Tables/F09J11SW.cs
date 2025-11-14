using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09J11SW - .
/// </summary>
public class F09J11SW : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FWUKID.
        /// </summary>
        public const string FWUKID = "FWUKID";

        /// <summary>
        /// FWCRCD.
        /// </summary>
        public const string FWCRCD = "FWCRCD";

        /// <summary>
        /// FWAA.
        /// </summary>
        public const string FWAA = "FWAA";

        /// <summary>
        /// FWJVACR.
        /// </summary>
        public const string FWJVACR = "FWJVACR";
    }

    /// <inheritdoc />
    public override string TableName => "F09J11SW";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FWUKID", "FWUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("FWCRCD", "FWCRCD", JdeDataType.String, 6, true, true),
        new JdeField("FWAA", "FWAA", JdeDataType.Numeric),
        new JdeField("FWJVACR", "FWJVACR", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09J11SW_0", "Primary Key on FWUKID, FWCRCD", new[] { "FWUKID", "FWCRCD" }, isUnique: true, isPrimaryKey: true)
    };
}
