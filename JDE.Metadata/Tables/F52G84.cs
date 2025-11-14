using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F52G84 - .
/// </summary>
public class F52G84 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CSPCTN.
        /// </summary>
        public const string CSPCTN = "CSPCTN";

        /// <summary>
        /// CSSTLSEQ.
        /// </summary>
        public const string CSSTLSEQ = "CSSTLSEQ";

        /// <summary>
        /// CSIPSTYLE.
        /// </summary>
        public const string CSIPSTYLE = "CSIPSTYLE";

        /// <summary>
        /// CSUSER.
        /// </summary>
        public const string CSUSER = "CSUSER";

        /// <summary>
        /// CSPID.
        /// </summary>
        public const string CSPID = "CSPID";

        /// <summary>
        /// CSMKEY.
        /// </summary>
        public const string CSMKEY = "CSMKEY";

        /// <summary>
        /// CSUPMJ.
        /// </summary>
        public const string CSUPMJ = "CSUPMJ";

        /// <summary>
        /// CSUPMT.
        /// </summary>
        public const string CSUPMT = "CSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F52G84";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CSPCTN", "CSPCTN", JdeDataType.Numeric, null, true, true),
        new JdeField("CSSTLSEQ", "CSSTLSEQ", JdeDataType.Numeric),
        new JdeField("CSIPSTYLE", "CSIPSTYLE", JdeDataType.String, 20, true, true),
        new JdeField("CSUSER", "CSUSER", JdeDataType.String, 20),
        new JdeField("CSPID", "CSPID", JdeDataType.String, 20),
        new JdeField("CSMKEY", "CSMKEY", JdeDataType.String, 30),
        new JdeField("CSUPMJ", "CSUPMJ", JdeDataType.Numeric),
        new JdeField("CSUPMT", "CSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F52G84_0", "Primary Key on CSPCTN, CSIPSTYLE", new[] { "CSPCTN", "CSIPSTYLE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F52G84_2", "Index on CSPCTN, SYS_NC00009$", new[] { "CSPCTN", "SYS_NC00009$" }),
        new JdeIndex("F52G84_3", "Index on CSPCTN, CSSTLSEQ", new[] { "CSPCTN", "CSSTLSEQ" })
    };
}
