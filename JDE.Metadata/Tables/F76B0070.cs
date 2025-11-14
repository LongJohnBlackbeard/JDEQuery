using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0070 - .
/// </summary>
public class F76B0070 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HBGPBT.
        /// </summary>
        public const string HBGPBT = "HBGPBT";

        /// <summary>
        /// HBGPTN.
        /// </summary>
        public const string HBGPTN = "HBGPTN";

        /// <summary>
        /// HBGPUS.
        /// </summary>
        public const string HBGPUS = "HBGPUS";

        /// <summary>
        /// HBGPSP.
        /// </summary>
        public const string HBGPSP = "HBGPSP";

        /// <summary>
        /// HBTAX.
        /// </summary>
        public const string HBTAX = "HBTAX";

        /// <summary>
        /// HBB76HACD.
        /// </summary>
        public const string HBB76HACD = "HBB76HACD";

        /// <summary>
        /// HBB76RPCD.
        /// </summary>
        public const string HBB76RPCD = "HBB76RPCD";

        /// <summary>
        /// HBB76VAIND.
        /// </summary>
        public const string HBB76VAIND = "HBB76VAIND";

        /// <summary>
        /// HBB76RPDT.
        /// </summary>
        public const string HBB76RPDT = "HBB76RPDT";

        /// <summary>
        /// HBB76VADT.
        /// </summary>
        public const string HBB76VADT = "HBB76VADT";

        /// <summary>
        /// HBB76NUM.
        /// </summary>
        public const string HBB76NUM = "HBB76NUM";

        /// <summary>
        /// HBB76AA.
        /// </summary>
        public const string HBB76AA = "HBB76AA";

        /// <summary>
        /// HBB76REF.
        /// </summary>
        public const string HBB76REF = "HBB76REF";

        /// <summary>
        /// HBB76COD.
        /// </summary>
        public const string HBB76COD = "HBB76COD";

        /// <summary>
        /// HBB76DATE.
        /// </summary>
        public const string HBB76DATE = "HBB76DATE";

        /// <summary>
        /// HBUSER.
        /// </summary>
        public const string HBUSER = "HBUSER";

        /// <summary>
        /// HBJOBN.
        /// </summary>
        public const string HBJOBN = "HBJOBN";

        /// <summary>
        /// HBPID.
        /// </summary>
        public const string HBPID = "HBPID";

        /// <summary>
        /// HBUPMJ.
        /// </summary>
        public const string HBUPMJ = "HBUPMJ";

        /// <summary>
        /// HBUPMT.
        /// </summary>
        public const string HBUPMT = "HBUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B0070";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HBGPBT", "HBGPBT", JdeDataType.Numeric, null, true, true),
        new JdeField("HBGPTN", "HBGPTN", JdeDataType.String, 28, true, true),
        new JdeField("HBGPUS", "HBGPUS", JdeDataType.String, 20),
        new JdeField("HBGPSP", "HBGPSP", JdeDataType.String, 2),
        new JdeField("HBTAX", "HBTAX", JdeDataType.String, 40),
        new JdeField("HBB76HACD", "HBB76HACD", JdeDataType.String, 94),
        new JdeField("HBB76RPCD", "HBB76RPCD", JdeDataType.String, 72),
        new JdeField("HBB76VAIND", "HBB76VAIND", JdeDataType.String, 40),
        new JdeField("HBB76RPDT", "HBB76RPDT", JdeDataType.String, 40),
        new JdeField("HBB76VADT", "HBB76VADT", JdeDataType.String, 40),
        new JdeField("HBB76NUM", "HBB76NUM", JdeDataType.Numeric),
        new JdeField("HBB76AA", "HBB76AA", JdeDataType.Numeric),
        new JdeField("HBB76REF", "HBB76REF", JdeDataType.String, 30),
        new JdeField("HBB76COD", "HBB76COD", JdeDataType.String, 4),
        new JdeField("HBB76DATE", "HBB76DATE", JdeDataType.Numeric),
        new JdeField("HBUSER", "HBUSER", JdeDataType.String, 20),
        new JdeField("HBJOBN", "HBJOBN", JdeDataType.String, 20),
        new JdeField("HBPID", "HBPID", JdeDataType.String, 20),
        new JdeField("HBUPMJ", "HBUPMJ", JdeDataType.Numeric),
        new JdeField("HBUPMT", "HBUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0070_0", "Primary Key on HBGPBT, HBGPTN", new[] { "HBGPBT", "HBGPTN" }, isUnique: true, isPrimaryKey: true)
    };
}
