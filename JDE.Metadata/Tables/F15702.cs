using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15702 - .
/// </summary>
public class F15702 : JdeTable
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
        /// NFMCUS.
        /// </summary>
        public const string NFMCUS = "NFMCUS";

        /// <summary>
        /// NFMCU.
        /// </summary>
        public const string NFMCU = "NFMCU";

        /// <summary>
        /// NFFLOR.
        /// </summary>
        public const string NFFLOR = "NFFLOR";

        /// <summary>
        /// NFUNIT.
        /// </summary>
        public const string NFUNIT = "NFUNIT";

        /// <summary>
        /// NFDL01.
        /// </summary>
        public const string NFDL01 = "NFDL01";

        /// <summary>
        /// NFRNTA.
        /// </summary>
        public const string NFRNTA = "NFRNTA";

        /// <summary>
        /// NFHIER.
        /// </summary>
        public const string NFHIER = "NFHIER";

        /// <summary>
        /// NFLSVR.
        /// </summary>
        public const string NFLSVR = "NFLSVR";

        /// <summary>
        /// NFURCD.
        /// </summary>
        public const string NFURCD = "NFURCD";

        /// <summary>
        /// NFURDT.
        /// </summary>
        public const string NFURDT = "NFURDT";

        /// <summary>
        /// NFURAT.
        /// </summary>
        public const string NFURAT = "NFURAT";

        /// <summary>
        /// NFURAB.
        /// </summary>
        public const string NFURAB = "NFURAB";

        /// <summary>
        /// NFURRF.
        /// </summary>
        public const string NFURRF = "NFURRF";

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
        /// NFENTJ.
        /// </summary>
        public const string NFENTJ = "NFENTJ";

        /// <summary>
        /// NFTORG.
        /// </summary>
        public const string NFTORG = "NFTORG";
    }

    /// <inheritdoc />
    public override string TableName => "F15702";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NFDOCO", "NFDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("NFAN8", "NFAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("NFCLNO", "NFCLNO", JdeDataType.Numeric, null, true, true),
        new JdeField("NFDNUM", "NFDNUM", JdeDataType.Numeric, null, true, true),
        new JdeField("NFMCUS", "NFMCUS", JdeDataType.String, 24),
        new JdeField("NFMCU", "NFMCU", JdeDataType.String, 24),
        new JdeField("NFFLOR", "NFFLOR", JdeDataType.String, 8),
        new JdeField("NFUNIT", "NFUNIT", JdeDataType.String, 16),
        new JdeField("NFDL01", "NFDL01", JdeDataType.String, 60),
        new JdeField("NFRNTA", "NFRNTA", JdeDataType.Numeric),
        new JdeField("NFHIER", "NFHIER", JdeDataType.String, 20),
        new JdeField("NFLSVR", "NFLSVR", JdeDataType.Numeric),
        new JdeField("NFURCD", "NFURCD", JdeDataType.String, 4),
        new JdeField("NFURDT", "NFURDT", JdeDataType.Numeric),
        new JdeField("NFURAT", "NFURAT", JdeDataType.Numeric),
        new JdeField("NFURAB", "NFURAB", JdeDataType.Numeric),
        new JdeField("NFURRF", "NFURRF", JdeDataType.String, 30),
        new JdeField("NFUSER", "NFUSER", JdeDataType.String, 20),
        new JdeField("NFPID", "NFPID", JdeDataType.String, 20),
        new JdeField("NFUPMJ", "NFUPMJ", JdeDataType.Numeric),
        new JdeField("NFUPMT", "NFUPMT", JdeDataType.Numeric),
        new JdeField("NFJOBN", "NFJOBN", JdeDataType.String, 20),
        new JdeField("NFENTJ", "NFENTJ", JdeDataType.Numeric),
        new JdeField("NFTORG", "NFTORG", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15702_0", "Primary Key on NFDOCO, NFAN8, NFCLNO, NFDNUM", new[] { "NFDOCO", "NFAN8", "NFCLNO", "NFDNUM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F15702_2", "Index on NFDOCO, NFAN8, NFCLNO, NFLSVR", new[] { "NFDOCO", "NFAN8", "NFCLNO", "NFLSVR" })
    };
}
