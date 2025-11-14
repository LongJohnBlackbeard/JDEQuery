using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0530 - .
/// </summary>
public class F76B0530 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HBJOBS.
        /// </summary>
        public const string HBJOBS = "HBJOBS";

        /// <summary>
        /// HBB76BLSQ.
        /// </summary>
        public const string HBB76BLSQ = "HBB76BLSQ";

        /// <summary>
        /// HBB76BLCK.
        /// </summary>
        public const string HBB76BLCK = "HBB76BLCK";

        /// <summary>
        /// HBDSC1.
        /// </summary>
        public const string HBDSC1 = "HBDSC1";

        /// <summary>
        /// HBFTRC.
        /// </summary>
        public const string HBFTRC = "HBFTRC";

        /// <summary>
        /// HBB76BSTB9.
        /// </summary>
        public const string HBB76BSTB9 = "HBB76BSTB9";

        /// <summary>
        /// HBURRF.
        /// </summary>
        public const string HBURRF = "HBURRF";

        /// <summary>
        /// HBURAT.
        /// </summary>
        public const string HBURAT = "HBURAT";

        /// <summary>
        /// HBURCD.
        /// </summary>
        public const string HBURCD = "HBURCD";

        /// <summary>
        /// HBURDT.
        /// </summary>
        public const string HBURDT = "HBURDT";

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
    public override string TableName => "F76B0530";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HBJOBS", "HBJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("HBB76BLSQ", "HBB76BLSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("HBB76BLCK", "HBB76BLCK", JdeDataType.String, 2, true, true),
        new JdeField("HBDSC1", "HBDSC1", JdeDataType.String, 60),
        new JdeField("HBFTRC", "HBFTRC", JdeDataType.String, 2),
        new JdeField("HBB76BSTB9", "HBB76BSTB9", JdeDataType.String, 2),
        new JdeField("HBURRF", "HBURRF", JdeDataType.String, 30),
        new JdeField("HBURAT", "HBURAT", JdeDataType.Numeric),
        new JdeField("HBURCD", "HBURCD", JdeDataType.String, 4),
        new JdeField("HBURDT", "HBURDT", JdeDataType.Numeric),
        new JdeField("HBUSER", "HBUSER", JdeDataType.String, 20),
        new JdeField("HBPID", "HBPID", JdeDataType.String, 20),
        new JdeField("HBJOBN", "HBJOBN", JdeDataType.String, 20),
        new JdeField("HBUPMJ", "HBUPMJ", JdeDataType.Numeric),
        new JdeField("HBUPMT", "HBUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0530_0", "Primary Key on HBJOBS, HBB76BLSQ, HBB76BLCK", new[] { "HBJOBS", "HBB76BLSQ", "HBB76BLCK" }, isUnique: true, isPrimaryKey: true)
    };
}
