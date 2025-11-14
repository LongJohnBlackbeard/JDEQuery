using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4117 - .
/// </summary>
public class F4117 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PRITM.
        /// </summary>
        public const string PRITM = "PRITM";

        /// <summary>
        /// PRPRODM.
        /// </summary>
        public const string PRPRODM = "PRPRODM";

        /// <summary>
        /// PRPRODF.
        /// </summary>
        public const string PRPRODF = "PRPRODF";

        /// <summary>
        /// PRMCUZ.
        /// </summary>
        public const string PRMCUZ = "PRMCUZ";

        /// <summary>
        /// PRDCD1.
        /// </summary>
        public const string PRDCD1 = "PRDCD1";

        /// <summary>
        /// PRDCD2.
        /// </summary>
        public const string PRDCD2 = "PRDCD2";

        /// <summary>
        /// PRDCD3.
        /// </summary>
        public const string PRDCD3 = "PRDCD3";

        /// <summary>
        /// PRDCD4.
        /// </summary>
        public const string PRDCD4 = "PRDCD4";

        /// <summary>
        /// PRDCD5.
        /// </summary>
        public const string PRDCD5 = "PRDCD5";

        /// <summary>
        /// PRCRTU.
        /// </summary>
        public const string PRCRTU = "PRCRTU";

        /// <summary>
        /// PRUSER.
        /// </summary>
        public const string PRUSER = "PRUSER";

        /// <summary>
        /// PRPID.
        /// </summary>
        public const string PRPID = "PRPID";

        /// <summary>
        /// PRJOBN.
        /// </summary>
        public const string PRJOBN = "PRJOBN";

        /// <summary>
        /// PRUPMJ.
        /// </summary>
        public const string PRUPMJ = "PRUPMJ";

        /// <summary>
        /// PRUPMT.
        /// </summary>
        public const string PRUPMT = "PRUPMT";

        /// <summary>
        /// PRRTRND.
        /// </summary>
        public const string PRRTRND = "PRRTRND";

        /// <summary>
        /// PRRPRBL.
        /// </summary>
        public const string PRRPRBL = "PRRPRBL";

        /// <summary>
        /// PRCCOST.
        /// </summary>
        public const string PRCCOST = "PRCCOST";

        /// <summary>
        /// PRRETPOL.
        /// </summary>
        public const string PRRETPOL = "PRRETPOL";

        /// <summary>
        /// PRSRYN.
        /// </summary>
        public const string PRSRYN = "PRSRYN";

        /// <summary>
        /// PRIBYN.
        /// </summary>
        public const string PRIBYN = "PRIBYN";

        /// <summary>
        /// PRVMRS33.
        /// </summary>
        public const string PRVMRS33 = "PRVMRS33";
    }

    /// <inheritdoc />
    public override string TableName => "F4117";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PRITM", "PRITM", JdeDataType.Numeric, null, true, true),
        new JdeField("PRPRODM", "PRPRODM", JdeDataType.String, 16),
        new JdeField("PRPRODF", "PRPRODF", JdeDataType.String, 16),
        new JdeField("PRMCUZ", "PRMCUZ", JdeDataType.String, 24),
        new JdeField("PRDCD1", "PRDCD1", JdeDataType.String, 6),
        new JdeField("PRDCD2", "PRDCD2", JdeDataType.String, 6),
        new JdeField("PRDCD3", "PRDCD3", JdeDataType.String, 6),
        new JdeField("PRDCD4", "PRDCD4", JdeDataType.String, 6),
        new JdeField("PRDCD5", "PRDCD5", JdeDataType.String, 6),
        new JdeField("PRCRTU", "PRCRTU", JdeDataType.String, 20),
        new JdeField("PRUSER", "PRUSER", JdeDataType.String, 20),
        new JdeField("PRPID", "PRPID", JdeDataType.String, 20),
        new JdeField("PRJOBN", "PRJOBN", JdeDataType.String, 20),
        new JdeField("PRUPMJ", "PRUPMJ", JdeDataType.Numeric),
        new JdeField("PRUPMT", "PRUPMT", JdeDataType.Numeric),
        new JdeField("PRRTRND", "PRRTRND", JdeDataType.String, 2),
        new JdeField("PRRPRBL", "PRRPRBL", JdeDataType.String, 2),
        new JdeField("PRCCOST", "PRCCOST", JdeDataType.String, 6),
        new JdeField("PRRETPOL", "PRRETPOL", JdeDataType.String, 2),
        new JdeField("PRSRYN", "PRSRYN", JdeDataType.String, 2),
        new JdeField("PRIBYN", "PRIBYN", JdeDataType.String, 2),
        new JdeField("PRVMRS33", "PRVMRS33", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4117_0", "Primary Key on PRITM", new[] { "PRITM" }, isUnique: true, isPrimaryKey: true)
    };
}
