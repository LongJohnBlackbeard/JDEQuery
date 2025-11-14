using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F10UI007 - .
/// </summary>
public class F10UI007 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MCOSNM.
        /// </summary>
        public const string MCOSNM = "MCOSNM";

        /// <summary>
        /// MCDL01.
        /// </summary>
        public const string MCDL01 = "MCDL01";

        /// <summary>
        /// MCSEQL.
        /// </summary>
        public const string MCSEQL = "MCSEQL";

        /// <summary>
        /// MCOD01.
        /// </summary>
        public const string MCOD01 = "MCOD01";

        /// <summary>
        /// MCUPMJ.
        /// </summary>
        public const string MCUPMJ = "MCUPMJ";

        /// <summary>
        /// MCUPMT.
        /// </summary>
        public const string MCUPMT = "MCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F10UI007";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MCOSNM", "MCOSNM", JdeDataType.String, 20, true, true),
        new JdeField("MCDL01", "MCDL01", JdeDataType.String, 60),
        new JdeField("MCSEQL", "MCSEQL", JdeDataType.String, 4, true, true),
        new JdeField("MCOD01", "MCOD01", JdeDataType.String, 80),
        new JdeField("MCUPMJ", "MCUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("MCUPMT", "MCUPMT", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F10UI007_0", "Primary Key on MCOSNM, MCSEQL, MCUPMJ, MCUPMT", new[] { "MCOSNM", "MCSEQL", "MCUPMJ", "MCUPMT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F10UI007_2", "Index on MCUPMJ, MCUPMT", new[] { "MCUPMJ", "MCUPMT" })
    };
}
