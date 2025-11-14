using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08505 - .
/// </summary>
public class F08505 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BSDTAGE.
        /// </summary>
        public const string BSDTAGE = "BSDTAGE";

        /// <summary>
        /// BSDTSAL.
        /// </summary>
        public const string BSDTSAL = "BSDTSAL";

        /// <summary>
        /// BSPRBTY.
        /// </summary>
        public const string BSPRBTY = "BSPRBTY";

        /// <summary>
        /// BSSCBTY.
        /// </summary>
        public const string BSSCBTY = "BSSCBTY";

        /// <summary>
        /// BSPID.
        /// </summary>
        public const string BSPID = "BSPID";

        /// <summary>
        /// BSUSER.
        /// </summary>
        public const string BSUSER = "BSUSER";

        /// <summary>
        /// BSJOBN.
        /// </summary>
        public const string BSJOBN = "BSJOBN";

        /// <summary>
        /// BSUPMJ.
        /// </summary>
        public const string BSUPMJ = "BSUPMJ";

        /// <summary>
        /// BSUPMT.
        /// </summary>
        public const string BSUPMT = "BSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08505";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BSDTAGE", "BSDTAGE", JdeDataType.Numeric),
        new JdeField("BSDTSAL", "BSDTSAL", JdeDataType.Numeric),
        new JdeField("BSPRBTY", "BSPRBTY", JdeDataType.String, 4),
        new JdeField("BSSCBTY", "BSSCBTY", JdeDataType.String, 4),
        new JdeField("BSPID", "BSPID", JdeDataType.String, 20, true, true),
        new JdeField("BSUSER", "BSUSER", JdeDataType.String, 20),
        new JdeField("BSJOBN", "BSJOBN", JdeDataType.String, 20),
        new JdeField("BSUPMJ", "BSUPMJ", JdeDataType.Numeric),
        new JdeField("BSUPMT", "BSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08505_0", "Primary Key on BSPID", new[] { "BSPID" }, isUnique: true, isPrimaryKey: true)
    };
}
