using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1502WAB - .
/// </summary>
public class F1502WAB : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NFICU.
        /// </summary>
        public const string NFICU = "NFICU";

        /// <summary>
        /// NFDOCO.
        /// </summary>
        public const string NFDOCO = "NFDOCO";

        /// <summary>
        /// NFLSVR.
        /// </summary>
        public const string NFLSVR = "NFLSVR";

        /// <summary>
        /// NFLNID.
        /// </summary>
        public const string NFLNID = "NFLNID";

        /// <summary>
        /// NFGLC.
        /// </summary>
        public const string NFGLC = "NFGLC";

        /// <summary>
        /// NFAG.
        /// </summary>
        public const string NFAG = "NFAG";

        /// <summary>
        /// NFEFTB.
        /// </summary>
        public const string NFEFTB = "NFEFTB";

        /// <summary>
        /// NFEFTE.
        /// </summary>
        public const string NFEFTE = "NFEFTE";

        /// <summary>
        /// NFMCU.
        /// </summary>
        public const string NFMCU = "NFMCU";

        /// <summary>
        /// NFUNIT.
        /// </summary>
        public const string NFUNIT = "NFUNIT";

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
        /// NFCRCD.
        /// </summary>
        public const string NFCRCD = "NFCRCD";

        /// <summary>
        /// NFCRRM.
        /// </summary>
        public const string NFCRRM = "NFCRRM";
    }

    /// <inheritdoc />
    public override string TableName => "F1502WAB";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NFICU", "NFICU", JdeDataType.Numeric, null, true, true),
        new JdeField("NFDOCO", "NFDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("NFLSVR", "NFLSVR", JdeDataType.Numeric, null, true, true),
        new JdeField("NFLNID", "NFLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("NFGLC", "NFGLC", JdeDataType.String, 8),
        new JdeField("NFAG", "NFAG", JdeDataType.Numeric),
        new JdeField("NFEFTB", "NFEFTB", JdeDataType.Numeric),
        new JdeField("NFEFTE", "NFEFTE", JdeDataType.Numeric),
        new JdeField("NFMCU", "NFMCU", JdeDataType.String, 24, true, true),
        new JdeField("NFUNIT", "NFUNIT", JdeDataType.String, 16, true, true),
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
        new JdeField("NFCRCD", "NFCRCD", JdeDataType.String, 6),
        new JdeField("NFCRRM", "NFCRRM", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1502WAB_0", "Primary Key on NFICU, NFDOCO, NFLSVR, NFMCU, NFUNIT, NFLNID", new[] { "NFICU", "NFDOCO", "NFLSVR", "NFMCU", "NFUNIT", "NFLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
