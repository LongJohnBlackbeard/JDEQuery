using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75T030 - .
/// </summary>
public class F75T030 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GHDOC.
        /// </summary>
        public const string GHDOC = "GHDOC";

        /// <summary>
        /// GHDCT.
        /// </summary>
        public const string GHDCT = "GHDCT";

        /// <summary>
        /// GHKCO.
        /// </summary>
        public const string GHKCO = "GHKCO";

        /// <summary>
        /// GHDGJ.
        /// </summary>
        public const string GHDGJ = "GHDGJ";

        /// <summary>
        /// GHDIVJ.
        /// </summary>
        public const string GHDIVJ = "GHDIVJ";

        /// <summary>
        /// GH75TEGDT.
        /// </summary>
        public const string GH75TEGDT = "GH75TEGDT";

        /// <summary>
        /// GH75TEGMD.
        /// </summary>
        public const string GH75TEGMD = "GH75TEGMD";

        /// <summary>
        /// GH75TEGNO.
        /// </summary>
        public const string GH75TEGNO = "GH75TEGNO";

        /// <summary>
        /// GH75TCCMK.
        /// </summary>
        public const string GH75TCCMK = "GH75TCCMK";

        /// <summary>
        /// GH75TEGTT.
        /// </summary>
        public const string GH75TEGTT = "GH75TEGTT";

        /// <summary>
        /// GH75TGFC.
        /// </summary>
        public const string GH75TGFC = "GH75TGFC";

        /// <summary>
        /// GH75TOEGD.
        /// </summary>
        public const string GH75TOEGD = "GH75TOEGD";

        /// <summary>
        /// GH75TOEGN.
        /// </summary>
        public const string GH75TOEGN = "GH75TOEGN";

        /// <summary>
        /// GH75TSAN8.
        /// </summary>
        public const string GH75TSAN8 = "GH75TSAN8";

        /// <summary>
        /// GH75TSBAN.
        /// </summary>
        public const string GH75TSBAN = "GH75TSBAN";

        /// <summary>
        /// GH75TBAN8.
        /// </summary>
        public const string GH75TBAN8 = "GH75TBAN8";

        /// <summary>
        /// GH75TBBAN.
        /// </summary>
        public const string GH75TBBAN = "GH75TBBAN";

        /// <summary>
        /// GH75TBPIC.
        /// </summary>
        public const string GH75TBPIC = "GH75TBPIC";

        /// <summary>
        /// GH75TBTAN8.
        /// </summary>
        public const string GH75TBTAN8 = "GH75TBTAN8";

        /// <summary>
        /// GH75TSTAN8.
        /// </summary>
        public const string GH75TSTAN8 = "GH75TSTAN8";

        /// <summary>
        /// GH75TCMNO.
        /// </summary>
        public const string GH75TCMNO = "GH75TCMNO";

        /// <summary>
        /// GH75TSMJD.
        /// </summary>
        public const string GH75TSMJD = "GH75TSMJD";

        /// <summary>
        /// GH75TSMJT.
        /// </summary>
        public const string GH75TSMJT = "GH75TSMJT";

        /// <summary>
        /// GH75TSTSY.
        /// </summary>
        public const string GH75TSTSY = "GH75TSTSY";

        /// <summary>
        /// GHOKCO.
        /// </summary>
        public const string GHOKCO = "GHOKCO";

        /// <summary>
        /// GHODCT.
        /// </summary>
        public const string GHODCT = "GHODCT";

        /// <summary>
        /// GHODOC.
        /// </summary>
        public const string GHODOC = "GHODOC";

        /// <summary>
        /// GH75TODIVJ.
        /// </summary>
        public const string GH75TODIVJ = "GH75TODIVJ";

        /// <summary>
        /// GHUSER.
        /// </summary>
        public const string GHUSER = "GHUSER";

        /// <summary>
        /// GHPID.
        /// </summary>
        public const string GHPID = "GHPID";

        /// <summary>
        /// GHJOBN.
        /// </summary>
        public const string GHJOBN = "GHJOBN";

        /// <summary>
        /// GHUPMJ.
        /// </summary>
        public const string GHUPMJ = "GHUPMJ";

        /// <summary>
        /// GHUPMT.
        /// </summary>
        public const string GHUPMT = "GHUPMT";

        /// <summary>
        /// GHYFUTDT.
        /// </summary>
        public const string GHYFUTDT = "GHYFUTDT";

        /// <summary>
        /// GHFFU4.
        /// </summary>
        public const string GHFFU4 = "GHFFU4";

        /// <summary>
        /// GHFUT3.
        /// </summary>
        public const string GHFUT3 = "GHFUT3";

        /// <summary>
        /// GHX2.
        /// </summary>
        public const string GHX2 = "GHX2";

        /// <summary>
        /// GHFUTCH1.
        /// </summary>
        public const string GHFUTCH1 = "GHFUTCH1";
    }

    /// <inheritdoc />
    public override string TableName => "F75T030";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GHDOC", "GHDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("GHDCT", "GHDCT", JdeDataType.String, 4, true, true),
        new JdeField("GHKCO", "GHKCO", JdeDataType.String, 10, true, true),
        new JdeField("GHDGJ", "GHDGJ", JdeDataType.Numeric),
        new JdeField("GHDIVJ", "GHDIVJ", JdeDataType.Numeric),
        new JdeField("GH75TEGDT", "GH75TEGDT", JdeDataType.Numeric),
        new JdeField("GH75TEGMD", "GH75TEGMD", JdeDataType.String, 60),
        new JdeField("GH75TEGNO", "GH75TEGNO", JdeDataType.String, 20),
        new JdeField("GH75TCCMK", "GH75TCCMK", JdeDataType.String, 2),
        new JdeField("GH75TEGTT", "GH75TEGTT", JdeDataType.String, 4),
        new JdeField("GH75TGFC", "GH75TGFC", JdeDataType.String, 4),
        new JdeField("GH75TOEGD", "GH75TOEGD", JdeDataType.Numeric),
        new JdeField("GH75TOEGN", "GH75TOEGN", JdeDataType.String, 20),
        new JdeField("GH75TSAN8", "GH75TSAN8", JdeDataType.Numeric),
        new JdeField("GH75TSBAN", "GH75TSBAN", JdeDataType.String, 20),
        new JdeField("GH75TBAN8", "GH75TBAN8", JdeDataType.Numeric),
        new JdeField("GH75TBBAN", "GH75TBBAN", JdeDataType.String, 20),
        new JdeField("GH75TBPIC", "GH75TBPIC", JdeDataType.Numeric),
        new JdeField("GH75TBTAN8", "GH75TBTAN8", JdeDataType.Numeric),
        new JdeField("GH75TSTAN8", "GH75TSTAN8", JdeDataType.Numeric),
        new JdeField("GH75TCMNO", "GH75TCMNO", JdeDataType.String, 32),
        new JdeField("GH75TSMJD", "GH75TSMJD", JdeDataType.Numeric),
        new JdeField("GH75TSMJT", "GH75TSMJT", JdeDataType.Numeric),
        new JdeField("GH75TSTSY", "GH75TSTSY", JdeDataType.String, 8),
        new JdeField("GHOKCO", "GHOKCO", JdeDataType.String, 10),
        new JdeField("GHODCT", "GHODCT", JdeDataType.String, 4),
        new JdeField("GHODOC", "GHODOC", JdeDataType.Numeric),
        new JdeField("GH75TODIVJ", "GH75TODIVJ", JdeDataType.Numeric),
        new JdeField("GHUSER", "GHUSER", JdeDataType.String, 20),
        new JdeField("GHPID", "GHPID", JdeDataType.String, 20),
        new JdeField("GHJOBN", "GHJOBN", JdeDataType.String, 20),
        new JdeField("GHUPMJ", "GHUPMJ", JdeDataType.Numeric),
        new JdeField("GHUPMT", "GHUPMT", JdeDataType.Numeric),
        new JdeField("GHYFUTDT", "GHYFUTDT", JdeDataType.Numeric),
        new JdeField("GHFFU4", "GHFFU4", JdeDataType.Numeric),
        new JdeField("GHFUT3", "GHFUT3", JdeDataType.String, 60),
        new JdeField("GHX2", "GHX2", JdeDataType.String, 2),
        new JdeField("GHFUTCH1", "GHFUTCH1", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75T030_0", "Primary Key on GHDOC, GHDCT, GHKCO", new[] { "GHDOC", "GHDCT", "GHKCO" }, isUnique: true, isPrimaryKey: true)
    };
}
