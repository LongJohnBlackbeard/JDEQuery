using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09J22 - .
/// </summary>
public class F09J22 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JHCO.
        /// </summary>
        public const string JHCO = "JHCO";

        /// <summary>
        /// JHJVNAME.
        /// </summary>
        public const string JHJVNAME = "JHJVNAME";

        /// <summary>
        /// JHMCUS.
        /// </summary>
        public const string JHMCUS = "JHMCUS";

        /// <summary>
        /// JHMCU.
        /// </summary>
        public const string JHMCU = "JHMCU";

        /// <summary>
        /// JHOBJ.
        /// </summary>
        public const string JHOBJ = "JHOBJ";

        /// <summary>
        /// JHSUB.
        /// </summary>
        public const string JHSUB = "JHSUB";

        /// <summary>
        /// JHOBJT.
        /// </summary>
        public const string JHOBJT = "JHOBJT";

        /// <summary>
        /// JHSUBT.
        /// </summary>
        public const string JHSUBT = "JHSUBT";

        /// <summary>
        /// JHJVDOI.
        /// </summary>
        public const string JHJVDOI = "JHJVDOI";

        /// <summary>
        /// JHJVRAF.
        /// </summary>
        public const string JHJVRAF = "JHJVRAF";

        /// <summary>
        /// JHTORG.
        /// </summary>
        public const string JHTORG = "JHTORG";

        /// <summary>
        /// JHENTJ.
        /// </summary>
        public const string JHENTJ = "JHENTJ";

        /// <summary>
        /// JHUSER.
        /// </summary>
        public const string JHUSER = "JHUSER";

        /// <summary>
        /// JHUPMJ.
        /// </summary>
        public const string JHUPMJ = "JHUPMJ";

        /// <summary>
        /// JHUPMT.
        /// </summary>
        public const string JHUPMT = "JHUPMT";

        /// <summary>
        /// JHPID.
        /// </summary>
        public const string JHPID = "JHPID";

        /// <summary>
        /// JHMKEY.
        /// </summary>
        public const string JHMKEY = "JHMKEY";

        /// <summary>
        /// JHURAB.
        /// </summary>
        public const string JHURAB = "JHURAB";

        /// <summary>
        /// JHURCD.
        /// </summary>
        public const string JHURCD = "JHURCD";

        /// <summary>
        /// JHURAT.
        /// </summary>
        public const string JHURAT = "JHURAT";

        /// <summary>
        /// JHURDT.
        /// </summary>
        public const string JHURDT = "JHURDT";

        /// <summary>
        /// JHURRF.
        /// </summary>
        public const string JHURRF = "JHURRF";

        /// <summary>
        /// JHJVRNU1.
        /// </summary>
        public const string JHJVRNU1 = "JHJVRNU1";

        /// <summary>
        /// JHJVRNU2.
        /// </summary>
        public const string JHJVRNU2 = "JHJVRNU2";

        /// <summary>
        /// JHJVRNU3.
        /// </summary>
        public const string JHJVRNU3 = "JHJVRNU3";

        /// <summary>
        /// JHJVRST1.
        /// </summary>
        public const string JHJVRST1 = "JHJVRST1";

        /// <summary>
        /// JHJVRST2.
        /// </summary>
        public const string JHJVRST2 = "JHJVRST2";

        /// <summary>
        /// JHJVRST3.
        /// </summary>
        public const string JHJVRST3 = "JHJVRST3";

        /// <summary>
        /// JHJVRCH1.
        /// </summary>
        public const string JHJVRCH1 = "JHJVRCH1";

        /// <summary>
        /// JHJVRCH2.
        /// </summary>
        public const string JHJVRCH2 = "JHJVRCH2";

        /// <summary>
        /// JHJVRCH3.
        /// </summary>
        public const string JHJVRCH3 = "JHJVRCH3";

        /// <summary>
        /// JHJVRDT1.
        /// </summary>
        public const string JHJVRDT1 = "JHJVRDT1";

        /// <summary>
        /// JHJVRDT2.
        /// </summary>
        public const string JHJVRDT2 = "JHJVRDT2";

        /// <summary>
        /// JHJVRDT3.
        /// </summary>
        public const string JHJVRDT3 = "JHJVRDT3";

        /// <summary>
        /// JHJVDBTP.
        /// </summary>
        public const string JHJVDBTP = "JHJVDBTP";

        /// <summary>
        /// JHJVDBTIBU.
        /// </summary>
        public const string JHJVDBTIBU = "JHJVDBTIBU";
    }

    /// <inheritdoc />
    public override string TableName => "F09J22";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JHCO", "JHCO", JdeDataType.String, 10, true, true),
        new JdeField("JHJVNAME", "JHJVNAME", JdeDataType.String, 40, true, true),
        new JdeField("JHMCUS", "JHMCUS", JdeDataType.String, 24, true, true),
        new JdeField("JHMCU", "JHMCU", JdeDataType.String, 24, true, true),
        new JdeField("JHOBJ", "JHOBJ", JdeDataType.String, 12, true, true),
        new JdeField("JHSUB", "JHSUB", JdeDataType.String, 16, true, true),
        new JdeField("JHOBJT", "JHOBJT", JdeDataType.String, 12),
        new JdeField("JHSUBT", "JHSUBT", JdeDataType.String, 16),
        new JdeField("JHJVDOI", "JHJVDOI", JdeDataType.String, 40),
        new JdeField("JHJVRAF", "JHJVRAF", JdeDataType.String, 2),
        new JdeField("JHTORG", "JHTORG", JdeDataType.String, 20),
        new JdeField("JHENTJ", "JHENTJ", JdeDataType.Numeric),
        new JdeField("JHUSER", "JHUSER", JdeDataType.String, 20),
        new JdeField("JHUPMJ", "JHUPMJ", JdeDataType.Numeric),
        new JdeField("JHUPMT", "JHUPMT", JdeDataType.Numeric),
        new JdeField("JHPID", "JHPID", JdeDataType.String, 20),
        new JdeField("JHMKEY", "JHMKEY", JdeDataType.String, 30),
        new JdeField("JHURAB", "JHURAB", JdeDataType.Numeric),
        new JdeField("JHURCD", "JHURCD", JdeDataType.String, 4),
        new JdeField("JHURAT", "JHURAT", JdeDataType.Numeric),
        new JdeField("JHURDT", "JHURDT", JdeDataType.Numeric),
        new JdeField("JHURRF", "JHURRF", JdeDataType.String, 30),
        new JdeField("JHJVRNU1", "JHJVRNU1", JdeDataType.Numeric),
        new JdeField("JHJVRNU2", "JHJVRNU2", JdeDataType.Numeric),
        new JdeField("JHJVRNU3", "JHJVRNU3", JdeDataType.Numeric),
        new JdeField("JHJVRST1", "JHJVRST1", JdeDataType.String, 160),
        new JdeField("JHJVRST2", "JHJVRST2", JdeDataType.String, 160),
        new JdeField("JHJVRST3", "JHJVRST3", JdeDataType.String, 160),
        new JdeField("JHJVRCH1", "JHJVRCH1", JdeDataType.String, 2),
        new JdeField("JHJVRCH2", "JHJVRCH2", JdeDataType.String, 2),
        new JdeField("JHJVRCH3", "JHJVRCH3", JdeDataType.String, 2),
        new JdeField("JHJVRDT1", "JHJVRDT1", JdeDataType.Numeric),
        new JdeField("JHJVRDT2", "JHJVRDT2", JdeDataType.Numeric),
        new JdeField("JHJVRDT3", "JHJVRDT3", JdeDataType.Numeric),
        new JdeField("JHJVDBTP", "JHJVDBTP", JdeDataType.Numeric),
        new JdeField("JHJVDBTIBU", "JHJVDBTIBU", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09J22_0", "Primary Key on JHCO, JHJVNAME, JHMCUS, JHMCU, JHOBJ, JHSUB", new[] { "JHCO", "JHJVNAME", "JHMCUS", "JHMCU", "JHOBJ", "JHSUB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09J22_2", "Index on JHJVDOI", new[] { "JHJVDOI" })
    };
}
