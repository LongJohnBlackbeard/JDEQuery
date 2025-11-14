using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F98610 - .
/// </summary>
public class F98610 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DBOBNM.
        /// </summary>
        public const string DBOBNM = "DBOBNM";

        /// <summary>
        /// DBAPPLID.
        /// </summary>
        public const string DBAPPLID = "DBAPPLID";

        /// <summary>
        /// DBVERS.
        /// </summary>
        public const string DBVERS = "DBVERS";

        /// <summary>
        /// DBDL01.
        /// </summary>
        public const string DBDL01 = "DBDL01";

        /// <summary>
        /// DBVERSNID.
        /// </summary>
        public const string DBVERSNID = "DBVERSNID";

        /// <summary>
        /// DBMD.
        /// </summary>
        public const string DBMD = "DBMD";

        /// <summary>
        /// DBFUNO.
        /// </summary>
        public const string DBFUNO = "DBFUNO";
    }

    /// <inheritdoc />
    public override string TableName => "F98610";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DBOBNM", "DBOBNM", JdeDataType.String, 20, true, true),
        new JdeField("DBAPPLID", "DBAPPLID", JdeDataType.Numeric),
        new JdeField("DBVERS", "DBVERS", JdeDataType.String, 20, true, true),
        new JdeField("DBDL01", "DBDL01", JdeDataType.String, 60),
        new JdeField("DBVERSNID", "DBVERSNID", JdeDataType.Numeric),
        new JdeField("DBMD", "DBMD", JdeDataType.String, 120),
        new JdeField("DBFUNO", "DBFUNO", JdeDataType.String, 8)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F98610_0", "Primary Key on DBOBNM, DBVERS", new[] { "DBOBNM", "DBVERS" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F98610_1", "Index on DBAPPLID, DBVERSNID", new[] { "DBAPPLID", "DBVERSNID" })
    };
}
