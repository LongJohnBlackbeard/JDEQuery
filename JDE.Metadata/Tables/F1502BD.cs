using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1502BD - .
/// </summary>
public class F1502BD : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NFDOCO.
        /// </summary>
        public const string NFDOCO = "NFDOCO";

        /// <summary>
        /// NFLNID.
        /// </summary>
        public const string NFLNID = "NFLNID";

        /// <summary>
        /// NFLNGP.
        /// </summary>
        public const string NFLNGP = "NFLNGP";

        /// <summary>
        /// NFRMK.
        /// </summary>
        public const string NFRMK = "NFRMK";

        /// <summary>
        /// NFUSER.
        /// </summary>
        public const string NFUSER = "NFUSER";

        /// <summary>
        /// NFPID.
        /// </summary>
        public const string NFPID = "NFPID";

        /// <summary>
        /// NFUPMJ.
        /// </summary>
        public const string NFUPMJ = "NFUPMJ";

        /// <summary>
        /// NFUPMT.
        /// </summary>
        public const string NFUPMT = "NFUPMT";

        /// <summary>
        /// NFJOBN.
        /// </summary>
        public const string NFJOBN = "NFJOBN";

        /// <summary>
        /// NFTORG.
        /// </summary>
        public const string NFTORG = "NFTORG";

        /// <summary>
        /// NFENTJ.
        /// </summary>
        public const string NFENTJ = "NFENTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F1502BD";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NFDOCO", "NFDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("NFLNID", "NFLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("NFLNGP", "NFLNGP", JdeDataType.String, 4, true, true),
        new JdeField("NFRMK", "NFRMK", JdeDataType.String, 60),
        new JdeField("NFUSER", "NFUSER", JdeDataType.String, 20),
        new JdeField("NFPID", "NFPID", JdeDataType.String, 20),
        new JdeField("NFUPMJ", "NFUPMJ", JdeDataType.Numeric),
        new JdeField("NFUPMT", "NFUPMT", JdeDataType.Numeric),
        new JdeField("NFJOBN", "NFJOBN", JdeDataType.String, 20),
        new JdeField("NFTORG", "NFTORG", JdeDataType.String, 20),
        new JdeField("NFENTJ", "NFENTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1502BD_0", "Primary Key on NFDOCO, NFLNID, NFLNGP", new[] { "NFDOCO", "NFLNID", "NFLNGP" }, isUnique: true, isPrimaryKey: true)
    };
}
