using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15702D - .
/// </summary>
public class F15702D : JdeTable
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
        /// NFAN8.
        /// </summary>
        public const string NFAN8 = "NFAN8";

        /// <summary>
        /// NFCLNO.
        /// </summary>
        public const string NFCLNO = "NFCLNO";

        /// <summary>
        /// NFDNUM.
        /// </summary>
        public const string NFDNUM = "NFDNUM";

        /// <summary>
        /// NFLNGP.
        /// </summary>
        public const string NFLNGP = "NFLNGP";

        /// <summary>
        /// NFDL01.
        /// </summary>
        public const string NFDL01 = "NFDL01";

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
    public override string TableName => "F15702D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NFDOCO", "NFDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("NFAN8", "NFAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("NFCLNO", "NFCLNO", JdeDataType.Numeric, null, true, true),
        new JdeField("NFDNUM", "NFDNUM", JdeDataType.Numeric, null, true, true),
        new JdeField("NFLNGP", "NFLNGP", JdeDataType.String, 4, true, true),
        new JdeField("NFDL01", "NFDL01", JdeDataType.String, 60),
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
        new JdeIndex("F15702D_0", "Primary Key on NFDOCO, NFAN8, NFCLNO, NFDNUM, NFLNGP", new[] { "NFDOCO", "NFAN8", "NFCLNO", "NFDNUM", "NFLNGP" }, isUnique: true, isPrimaryKey: true)
    };
}
