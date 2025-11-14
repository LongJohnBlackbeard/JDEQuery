using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H402 - .
/// </summary>
public class F44H402 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PKHBAREA.
        /// </summary>
        public const string PKHBAREA = "PKHBAREA";

        /// <summary>
        /// PKHBMCUS.
        /// </summary>
        public const string PKHBMCUS = "PKHBMCUS";

        /// <summary>
        /// PKCPHASE.
        /// </summary>
        public const string PKCPHASE = "PKCPHASE";

        /// <summary>
        /// PKHBPLAN.
        /// </summary>
        public const string PKHBPLAN = "PKHBPLAN";

        /// <summary>
        /// PKHBELEV.
        /// </summary>
        public const string PKHBELEV = "PKHBELEV";

        /// <summary>
        /// PKOPTION.
        /// </summary>
        public const string PKOPTION = "PKOPTION";

        /// <summary>
        /// PKOLNKT.
        /// </summary>
        public const string PKOLNKT = "PKOLNKT";

        /// <summary>
        /// PKOLNKG.
        /// </summary>
        public const string PKOLNKG = "PKOLNKG";

        /// <summary>
        /// PKOLNKN.
        /// </summary>
        public const string PKOLNKN = "PKOLNKN";

        /// <summary>
        /// PKOLNK2.
        /// </summary>
        public const string PKOLNK2 = "PKOLNK2";

        /// <summary>
        /// PKQT1.
        /// </summary>
        public const string PKQT1 = "PKQT1";

        /// <summary>
        /// PKRMK.
        /// </summary>
        public const string PKRMK = "PKRMK";

        /// <summary>
        /// PKOPPED.
        /// </summary>
        public const string PKOPPED = "PKOPPED";

        /// <summary>
        /// PKOPPXD.
        /// </summary>
        public const string PKOPPXD = "PKOPPXD";

        /// <summary>
        /// PKUSD1.
        /// </summary>
        public const string PKUSD1 = "PKUSD1";

        /// <summary>
        /// PKUSD2.
        /// </summary>
        public const string PKUSD2 = "PKUSD2";

        /// <summary>
        /// PKUSD3.
        /// </summary>
        public const string PKUSD3 = "PKUSD3";

        /// <summary>
        /// PKUAMT01.
        /// </summary>
        public const string PKUAMT01 = "PKUAMT01";

        /// <summary>
        /// PKUAMT02.
        /// </summary>
        public const string PKUAMT02 = "PKUAMT02";

        /// <summary>
        /// PKUAMT03.
        /// </summary>
        public const string PKUAMT03 = "PKUAMT03";

        /// <summary>
        /// PKUAMT04.
        /// </summary>
        public const string PKUAMT04 = "PKUAMT04";

        /// <summary>
        /// PKUAMT05.
        /// </summary>
        public const string PKUAMT05 = "PKUAMT05";

        /// <summary>
        /// PKF1A.
        /// </summary>
        public const string PKF1A = "PKF1A";

        /// <summary>
        /// PKF2A.
        /// </summary>
        public const string PKF2A = "PKF2A";

        /// <summary>
        /// PKF3A.
        /// </summary>
        public const string PKF3A = "PKF3A";

        /// <summary>
        /// PKF4A.
        /// </summary>
        public const string PKF4A = "PKF4A";

        /// <summary>
        /// PKF5A.
        /// </summary>
        public const string PKF5A = "PKF5A";

        /// <summary>
        /// PKCRTU.
        /// </summary>
        public const string PKCRTU = "PKCRTU";

        /// <summary>
        /// PKCRTJ.
        /// </summary>
        public const string PKCRTJ = "PKCRTJ";

        /// <summary>
        /// PKCRTT.
        /// </summary>
        public const string PKCRTT = "PKCRTT";

        /// <summary>
        /// PKWRKSTNID.
        /// </summary>
        public const string PKWRKSTNID = "PKWRKSTNID";

        /// <summary>
        /// PKHBOPID.
        /// </summary>
        public const string PKHBOPID = "PKHBOPID";

        /// <summary>
        /// PKUPMB.
        /// </summary>
        public const string PKUPMB = "PKUPMB";

        /// <summary>
        /// PKUPMJ.
        /// </summary>
        public const string PKUPMJ = "PKUPMJ";

        /// <summary>
        /// PKUPMT.
        /// </summary>
        public const string PKUPMT = "PKUPMT";

        /// <summary>
        /// PKJOBN.
        /// </summary>
        public const string PKJOBN = "PKJOBN";

        /// <summary>
        /// PKPID.
        /// </summary>
        public const string PKPID = "PKPID";
    }

    /// <inheritdoc />
    public override string TableName => "F44H402";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PKHBAREA", "PKHBAREA", JdeDataType.String, 6, true, true),
        new JdeField("PKHBMCUS", "PKHBMCUS", JdeDataType.String, 24, true, true),
        new JdeField("PKCPHASE", "PKCPHASE", JdeDataType.String, 6, true, true),
        new JdeField("PKHBPLAN", "PKHBPLAN", JdeDataType.String, 8, true, true),
        new JdeField("PKHBELEV", "PKHBELEV", JdeDataType.String, 6, true, true),
        new JdeField("PKOPTION", "PKOPTION", JdeDataType.String, 16, true, true),
        new JdeField("PKOLNKT", "PKOLNKT", JdeDataType.String, 6, true, true),
        new JdeField("PKOLNKG", "PKOLNKG", JdeDataType.String, 6, true, true),
        new JdeField("PKOLNKN", "PKOLNKN", JdeDataType.Numeric, null, true, true),
        new JdeField("PKOLNK2", "PKOLNK2", JdeDataType.String, 16),
        new JdeField("PKQT1", "PKQT1", JdeDataType.Numeric),
        new JdeField("PKRMK", "PKRMK", JdeDataType.String, 60),
        new JdeField("PKOPPED", "PKOPPED", JdeDataType.Numeric),
        new JdeField("PKOPPXD", "PKOPPXD", JdeDataType.Numeric),
        new JdeField("PKUSD1", "PKUSD1", JdeDataType.Numeric),
        new JdeField("PKUSD2", "PKUSD2", JdeDataType.Numeric),
        new JdeField("PKUSD3", "PKUSD3", JdeDataType.Numeric),
        new JdeField("PKUAMT01", "PKUAMT01", JdeDataType.Numeric),
        new JdeField("PKUAMT02", "PKUAMT02", JdeDataType.Numeric),
        new JdeField("PKUAMT03", "PKUAMT03", JdeDataType.Numeric),
        new JdeField("PKUAMT04", "PKUAMT04", JdeDataType.Numeric),
        new JdeField("PKUAMT05", "PKUAMT05", JdeDataType.Numeric),
        new JdeField("PKF1A", "PKF1A", JdeDataType.Numeric),
        new JdeField("PKF2A", "PKF2A", JdeDataType.Numeric),
        new JdeField("PKF3A", "PKF3A", JdeDataType.Numeric),
        new JdeField("PKF4A", "PKF4A", JdeDataType.Numeric),
        new JdeField("PKF5A", "PKF5A", JdeDataType.Numeric),
        new JdeField("PKCRTU", "PKCRTU", JdeDataType.String, 20),
        new JdeField("PKCRTJ", "PKCRTJ", JdeDataType.Numeric),
        new JdeField("PKCRTT", "PKCRTT", JdeDataType.Numeric),
        new JdeField("PKWRKSTNID", "PKWRKSTNID", JdeDataType.String, 20),
        new JdeField("PKHBOPID", "PKHBOPID", JdeDataType.String, 20),
        new JdeField("PKUPMB", "PKUPMB", JdeDataType.String, 20),
        new JdeField("PKUPMJ", "PKUPMJ", JdeDataType.Numeric),
        new JdeField("PKUPMT", "PKUPMT", JdeDataType.Numeric),
        new JdeField("PKJOBN", "PKJOBN", JdeDataType.String, 20),
        new JdeField("PKPID", "PKPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H402_0", "Primary Key on PKHBAREA, PKHBMCUS, PKCPHASE, PKHBPLAN, PKHBELEV, PKOPTION, PKOLNKT, PKOLNKG, PKOLNKN", new[] { "PKHBAREA", "PKHBMCUS", "PKCPHASE", "PKHBPLAN", "PKHBELEV", "PKOPTION", "PKOLNKT", "PKOLNKG", "PKOLNKN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F44H402_2", "Index on PKHBAREA, PKHBMCUS, PKCPHASE, PKHBPLAN, PKHBELEV, PKOPTION, PKOLNKT, PKOLNKG, PKOLNK2", new[] { "PKHBAREA", "PKHBMCUS", "PKCPHASE", "PKHBPLAN", "PKHBELEV", "PKOPTION", "PKOLNKT", "PKOLNKG", "PKOLNK2" })
    };
}
