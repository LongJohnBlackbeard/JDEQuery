using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0730 - .
/// </summary>
public class F76B0730 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HBB76ATCT.
        /// </summary>
        public const string HBB76ATCT = "HBB76ATCT";

        /// <summary>
        /// HBB76BLCK.
        /// </summary>
        public const string HBB76BLCK = "HBB76BLCK";

        /// <summary>
        /// HBB76BLSQ.
        /// </summary>
        public const string HBB76BLSQ = "HBB76BLSQ";

        /// <summary>
        /// HBFTRC.
        /// </summary>
        public const string HBFTRC = "HBFTRC";

        /// <summary>
        /// HBDSC1.
        /// </summary>
        public const string HBDSC1 = "HBDSC1";

        /// <summary>
        /// HBURCD.
        /// </summary>
        public const string HBURCD = "HBURCD";

        /// <summary>
        /// HBURDT.
        /// </summary>
        public const string HBURDT = "HBURDT";

        /// <summary>
        /// HBURAT.
        /// </summary>
        public const string HBURAT = "HBURAT";

        /// <summary>
        /// HBURAB.
        /// </summary>
        public const string HBURAB = "HBURAB";

        /// <summary>
        /// HBURRF.
        /// </summary>
        public const string HBURRF = "HBURRF";

        /// <summary>
        /// HBUSER.
        /// </summary>
        public const string HBUSER = "HBUSER";

        /// <summary>
        /// HBPID.
        /// </summary>
        public const string HBPID = "HBPID";

        /// <summary>
        /// HBJOBN.
        /// </summary>
        public const string HBJOBN = "HBJOBN";

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
    public override string TableName => "F76B0730";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HBB76ATCT", "HBB76ATCT", JdeDataType.String, 4, true, true),
        new JdeField("HBB76BLCK", "HBB76BLCK", JdeDataType.String, 2, true, true),
        new JdeField("HBB76BLSQ", "HBB76BLSQ", JdeDataType.Numeric),
        new JdeField("HBFTRC", "HBFTRC", JdeDataType.String, 2),
        new JdeField("HBDSC1", "HBDSC1", JdeDataType.String, 60),
        new JdeField("HBURCD", "HBURCD", JdeDataType.String, 4),
        new JdeField("HBURDT", "HBURDT", JdeDataType.Numeric),
        new JdeField("HBURAT", "HBURAT", JdeDataType.Numeric),
        new JdeField("HBURAB", "HBURAB", JdeDataType.Numeric),
        new JdeField("HBURRF", "HBURRF", JdeDataType.String, 30),
        new JdeField("HBUSER", "HBUSER", JdeDataType.String, 20),
        new JdeField("HBPID", "HBPID", JdeDataType.String, 20),
        new JdeField("HBJOBN", "HBJOBN", JdeDataType.String, 20),
        new JdeField("HBUPMJ", "HBUPMJ", JdeDataType.Numeric),
        new JdeField("HBUPMT", "HBUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0730_0", "Primary Key on HBB76ATCT, HBB76BLCK", new[] { "HBB76ATCT", "HBB76BLCK" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B0730_2", "Index on HBB76ATCT, HBB76BLSQ, HBB76BLCK", new[] { "HBB76ATCT", "HBB76BLSQ", "HBB76BLCK" })
    };
}
