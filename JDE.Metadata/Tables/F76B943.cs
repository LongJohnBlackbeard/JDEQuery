using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B943 - .
/// </summary>
public class F76B943 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ODJOBS.
        /// </summary>
        public const string ODJOBS = "ODJOBS";

        /// <summary>
        /// ODB76BLCK.
        /// </summary>
        public const string ODB76BLCK = "ODB76BLCK";

        /// <summary>
        /// ODB76RESQ.
        /// </summary>
        public const string ODB76RESQ = "ODB76RESQ";

        /// <summary>
        /// ODB76BSEQ.
        /// </summary>
        public const string ODB76BSEQ = "ODB76BSEQ";

        /// <summary>
        /// ODB76RECD.
        /// </summary>
        public const string ODB76RECD = "ODB76RECD";

        /// <summary>
        /// ODGPTX.
        /// </summary>
        public const string ODGPTX = "ODGPTX";

        /// <summary>
        /// ODPN.
        /// </summary>
        public const string ODPN = "ODPN";

        /// <summary>
        /// ODUSER.
        /// </summary>
        public const string ODUSER = "ODUSER";

        /// <summary>
        /// ODPID.
        /// </summary>
        public const string ODPID = "ODPID";

        /// <summary>
        /// ODJOBN.
        /// </summary>
        public const string ODJOBN = "ODJOBN";

        /// <summary>
        /// ODUPMJ.
        /// </summary>
        public const string ODUPMJ = "ODUPMJ";

        /// <summary>
        /// ODUPMT.
        /// </summary>
        public const string ODUPMT = "ODUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B943";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ODJOBS", "ODJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("ODB76BLCK", "ODB76BLCK", JdeDataType.String, 2, true, true),
        new JdeField("ODB76RESQ", "ODB76RESQ", JdeDataType.Numeric, null, true, true),
        new JdeField("ODB76BSEQ", "ODB76BSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("ODB76RECD", "ODB76RECD", JdeDataType.String, 8),
        new JdeField("ODGPTX", "ODGPTX", JdeDataType.String, 3000),
        new JdeField("ODPN", "ODPN", JdeDataType.Numeric),
        new JdeField("ODUSER", "ODUSER", JdeDataType.String, 20),
        new JdeField("ODPID", "ODPID", JdeDataType.String, 20),
        new JdeField("ODJOBN", "ODJOBN", JdeDataType.String, 20),
        new JdeField("ODUPMJ", "ODUPMJ", JdeDataType.Numeric),
        new JdeField("ODUPMT", "ODUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B943_0", "Primary Key on ODJOBS, ODB76BLCK, ODB76RESQ, ODB76BSEQ", new[] { "ODJOBS", "ODB76BLCK", "ODB76RESQ", "ODB76BSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B943_2", "Index on ODJOBS, ODB76BLCK, ODB76RESQ, SYS_NC00013$", new[] { "ODJOBS", "ODB76BLCK", "ODB76RESQ", "SYS_NC00013$" }),
        new JdeIndex("F76B943_3", "Index on ODJOBS, ODB76RECD, ODPN", new[] { "ODJOBS", "ODB76RECD", "ODPN" })
    };
}
