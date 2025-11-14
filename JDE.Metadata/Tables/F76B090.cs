using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B090 - .
/// </summary>
public class F76B090 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NSDCT.
        /// </summary>
        public const string NSDCT = "NSDCT";

        /// <summary>
        /// NSB76EMTY.
        /// </summary>
        public const string NSB76EMTY = "NSB76EMTY";

        /// <summary>
        /// NSB76NFST.
        /// </summary>
        public const string NSB76NFST = "NSB76NFST";

        /// <summary>
        /// NSNXTR.
        /// </summary>
        public const string NSNXTR = "NSNXTR";

        /// <summary>
        /// NSUSER.
        /// </summary>
        public const string NSUSER = "NSUSER";

        /// <summary>
        /// NSPID.
        /// </summary>
        public const string NSPID = "NSPID";

        /// <summary>
        /// NSJOBN.
        /// </summary>
        public const string NSJOBN = "NSJOBN";

        /// <summary>
        /// NSUPMJ.
        /// </summary>
        public const string NSUPMJ = "NSUPMJ";

        /// <summary>
        /// NSUPMT.
        /// </summary>
        public const string NSUPMT = "NSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B090";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NSDCT", "NSDCT", JdeDataType.String, 4, true, true),
        new JdeField("NSB76EMTY", "NSB76EMTY", JdeDataType.String, 2, true, true),
        new JdeField("NSB76NFST", "NSB76NFST", JdeDataType.String, 2, true, true),
        new JdeField("NSNXTR", "NSNXTR", JdeDataType.String, 6),
        new JdeField("NSUSER", "NSUSER", JdeDataType.String, 20),
        new JdeField("NSPID", "NSPID", JdeDataType.String, 20),
        new JdeField("NSJOBN", "NSJOBN", JdeDataType.String, 20),
        new JdeField("NSUPMJ", "NSUPMJ", JdeDataType.Numeric),
        new JdeField("NSUPMT", "NSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B090_0", "Primary Key on NSDCT, NSB76EMTY, NSB76NFST", new[] { "NSDCT", "NSB76EMTY", "NSB76NFST" }, isUnique: true, isPrimaryKey: true)
    };
}
