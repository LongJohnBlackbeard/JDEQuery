using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B941 - .
/// </summary>
public class F76B941 : JdeTable
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
        /// HBB76BLCK.
        /// </summary>
        public const string HBB76BLCK = "HBB76BLCK";

        /// <summary>
        /// HBFTRC.
        /// </summary>
        public const string HBFTRC = "HBFTRC";

        /// <summary>
        /// HBB76BLST.
        /// </summary>
        public const string HBB76BLST = "HBB76BLST";

        /// <summary>
        /// HBB76BLSQ.
        /// </summary>
        public const string HBB76BLSQ = "HBB76BLSQ";

        /// <summary>
        /// HBDSC1.
        /// </summary>
        public const string HBDSC1 = "HBDSC1";

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
    public override string TableName => "F76B941";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HBJOBS", "HBJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("HBB76BLCK", "HBB76BLCK", JdeDataType.String, 2, true, true),
        new JdeField("HBFTRC", "HBFTRC", JdeDataType.String, 2),
        new JdeField("HBB76BLST", "HBB76BLST", JdeDataType.String, 2),
        new JdeField("HBB76BLSQ", "HBB76BLSQ", JdeDataType.Numeric),
        new JdeField("HBDSC1", "HBDSC1", JdeDataType.String, 60),
        new JdeField("HBUSER", "HBUSER", JdeDataType.String, 20),
        new JdeField("HBPID", "HBPID", JdeDataType.String, 20),
        new JdeField("HBJOBN", "HBJOBN", JdeDataType.String, 20),
        new JdeField("HBUPMJ", "HBUPMJ", JdeDataType.Numeric),
        new JdeField("HBUPMT", "HBUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B941_0", "Primary Key on HBJOBS, HBB76BLCK", new[] { "HBJOBS", "HBB76BLCK" }, isUnique: true, isPrimaryKey: true)
    };
}
