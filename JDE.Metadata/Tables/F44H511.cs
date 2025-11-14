using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H511 - .
/// </summary>
public class F44H511 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OSHBMCUS.
        /// </summary>
        public const string OSHBMCUS = "OSHBMCUS";

        /// <summary>
        /// OSHBLOT.
        /// </summary>
        public const string OSHBLOT = "OSHBLOT";

        /// <summary>
        /// OSOPKID.
        /// </summary>
        public const string OSOPKID = "OSOPKID";

        /// <summary>
        /// OSOPTION.
        /// </summary>
        public const string OSOPTION = "OSOPTION";

        /// <summary>
        /// OSHBAREA.
        /// </summary>
        public const string OSHBAREA = "OSHBAREA";

        /// <summary>
        /// OSCSPR.
        /// </summary>
        public const string OSCSPR = "OSCSPR";

        /// <summary>
        /// OSOPTEXA.
        /// </summary>
        public const string OSOPTEXA = "OSOPTEXA";

        /// <summary>
        /// OSDTKN.
        /// </summary>
        public const string OSDTKN = "OSDTKN";

        /// <summary>
        /// OSSTDSLPR.
        /// </summary>
        public const string OSSTDSLPR = "OSSTDSLPR";

        /// <summary>
        /// OSSTDEXA.
        /// </summary>
        public const string OSSTDEXA = "OSSTDEXA";

        /// <summary>
        /// OSOSCQTY.
        /// </summary>
        public const string OSOSCQTY = "OSOSCQTY";

        /// <summary>
        /// OSTPQ.
        /// </summary>
        public const string OSTPQ = "OSTPQ";

        /// <summary>
        /// OSOSPQTY.
        /// </summary>
        public const string OSOSPQTY = "OSOSPQTY";

        /// <summary>
        /// OSREVQTP.
        /// </summary>
        public const string OSREVQTP = "OSREVQTP";

        /// <summary>
        /// OSDSC1.
        /// </summary>
        public const string OSDSC1 = "OSDSC1";

        /// <summary>
        /// OSDSC2.
        /// </summary>
        public const string OSDSC2 = "OSDSC2";

        /// <summary>
        /// OSSKT.
        /// </summary>
        public const string OSSKT = "OSSKT";

        /// <summary>
        /// OSCSSEQ.
        /// </summary>
        public const string OSCSSEQ = "OSCSSEQ";

        /// <summary>
        /// OSCNACT.
        /// </summary>
        public const string OSCNACT = "OSCNACT";

        /// <summary>
        /// OSOPTYP.
        /// </summary>
        public const string OSOPTYP = "OSOPTYP";

        /// <summary>
        /// OSDTSEL.
        /// </summary>
        public const string OSDTSEL = "OSDTSEL";

        /// <summary>
        /// OSDCG.
        /// </summary>
        public const string OSDCG = "OSDCG";

        /// <summary>
        /// OSPKGVA.
        /// </summary>
        public const string OSPKGVA = "OSPKGVA";

        /// <summary>
        /// OSOSELCD1.
        /// </summary>
        public const string OSOSELCD1 = "OSOSELCD1";

        /// <summary>
        /// OSOSELCD2.
        /// </summary>
        public const string OSOSELCD2 = "OSOSELCD2";

        /// <summary>
        /// OSOPKG.
        /// </summary>
        public const string OSOPKG = "OSOPKG";

        /// <summary>
        /// OSHBST1.
        /// </summary>
        public const string OSHBST1 = "OSHBST1";

        /// <summary>
        /// OSHBST2.
        /// </summary>
        public const string OSHBST2 = "OSHBST2";

        /// <summary>
        /// OSHBST3.
        /// </summary>
        public const string OSHBST3 = "OSHBST3";

        /// <summary>
        /// OSHBST4.
        /// </summary>
        public const string OSHBST4 = "OSHBST4";

        /// <summary>
        /// OSHBST5.
        /// </summary>
        public const string OSHBST5 = "OSHBST5";

        /// <summary>
        /// OSCRTU.
        /// </summary>
        public const string OSCRTU = "OSCRTU";

        /// <summary>
        /// OSCRTJ.
        /// </summary>
        public const string OSCRTJ = "OSCRTJ";

        /// <summary>
        /// OSCRTT.
        /// </summary>
        public const string OSCRTT = "OSCRTT";

        /// <summary>
        /// OSWRKSTNID.
        /// </summary>
        public const string OSWRKSTNID = "OSWRKSTNID";

        /// <summary>
        /// OSHBOPID.
        /// </summary>
        public const string OSHBOPID = "OSHBOPID";

        /// <summary>
        /// OSUPMB.
        /// </summary>
        public const string OSUPMB = "OSUPMB";

        /// <summary>
        /// OSUPMJ.
        /// </summary>
        public const string OSUPMJ = "OSUPMJ";

        /// <summary>
        /// OSUPMT.
        /// </summary>
        public const string OSUPMT = "OSUPMT";

        /// <summary>
        /// OSJOBN.
        /// </summary>
        public const string OSJOBN = "OSJOBN";

        /// <summary>
        /// OSPID.
        /// </summary>
        public const string OSPID = "OSPID";
    }

    /// <inheritdoc />
    public override string TableName => "F44H511";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OSHBMCUS", "OSHBMCUS", JdeDataType.String, 24, true, true),
        new JdeField("OSHBLOT", "OSHBLOT", JdeDataType.String, 8, true, true),
        new JdeField("OSOPKID", "OSOPKID", JdeDataType.String, 16, true, true),
        new JdeField("OSOPTION", "OSOPTION", JdeDataType.String, 16, true, true),
        new JdeField("OSHBAREA", "OSHBAREA", JdeDataType.String, 6),
        new JdeField("OSCSPR", "OSCSPR", JdeDataType.Numeric),
        new JdeField("OSOPTEXA", "OSOPTEXA", JdeDataType.Numeric),
        new JdeField("OSDTKN", "OSDTKN", JdeDataType.Numeric),
        new JdeField("OSSTDSLPR", "OSSTDSLPR", JdeDataType.Numeric),
        new JdeField("OSSTDEXA", "OSSTDEXA", JdeDataType.Numeric),
        new JdeField("OSOSCQTY", "OSOSCQTY", JdeDataType.Numeric),
        new JdeField("OSTPQ", "OSTPQ", JdeDataType.Numeric),
        new JdeField("OSOSPQTY", "OSOSPQTY", JdeDataType.Numeric),
        new JdeField("OSREVQTP", "OSREVQTP", JdeDataType.Numeric),
        new JdeField("OSDSC1", "OSDSC1", JdeDataType.String, 60),
        new JdeField("OSDSC2", "OSDSC2", JdeDataType.String, 60),
        new JdeField("OSSKT", "OSSKT", JdeDataType.String, 16),
        new JdeField("OSCSSEQ", "OSCSSEQ", JdeDataType.String, 6),
        new JdeField("OSCNACT", "OSCNACT", JdeDataType.String, 6),
        new JdeField("OSOPTYP", "OSOPTYP", JdeDataType.String, 6),
        new JdeField("OSDTSEL", "OSDTSEL", JdeDataType.Numeric),
        new JdeField("OSDCG", "OSDCG", JdeDataType.Numeric),
        new JdeField("OSPKGVA", "OSPKGVA", JdeDataType.Numeric),
        new JdeField("OSOSELCD1", "OSOSELCD1", JdeDataType.String, 6),
        new JdeField("OSOSELCD2", "OSOSELCD2", JdeDataType.String, 6),
        new JdeField("OSOPKG", "OSOPKG", JdeDataType.String, 2),
        new JdeField("OSHBST1", "OSHBST1", JdeDataType.String, 2),
        new JdeField("OSHBST2", "OSHBST2", JdeDataType.String, 2),
        new JdeField("OSHBST3", "OSHBST3", JdeDataType.String, 2),
        new JdeField("OSHBST4", "OSHBST4", JdeDataType.String, 2),
        new JdeField("OSHBST5", "OSHBST5", JdeDataType.String, 2),
        new JdeField("OSCRTU", "OSCRTU", JdeDataType.String, 20),
        new JdeField("OSCRTJ", "OSCRTJ", JdeDataType.Numeric),
        new JdeField("OSCRTT", "OSCRTT", JdeDataType.Numeric),
        new JdeField("OSWRKSTNID", "OSWRKSTNID", JdeDataType.String, 20),
        new JdeField("OSHBOPID", "OSHBOPID", JdeDataType.String, 20),
        new JdeField("OSUPMB", "OSUPMB", JdeDataType.String, 20),
        new JdeField("OSUPMJ", "OSUPMJ", JdeDataType.Numeric),
        new JdeField("OSUPMT", "OSUPMT", JdeDataType.Numeric),
        new JdeField("OSJOBN", "OSJOBN", JdeDataType.String, 20),
        new JdeField("OSPID", "OSPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H511_0", "Primary Key on OSHBMCUS, OSHBLOT, OSOPKID, OSOPTION", new[] { "OSHBMCUS", "OSHBLOT", "OSOPKID", "OSOPTION" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F44H511_2", "Index on OSHBMCUS, OSOPKID, OSOPTION", new[] { "OSHBMCUS", "OSOPKID", "OSOPTION" }),
        new JdeIndex("F44H511_3", "Index on OSHBMCUS, OSOPTION", new[] { "OSHBMCUS", "OSOPTION" }),
        new JdeIndex("F44H511_4", "Index on OSHBMCUS, OSHBLOT, OSOPTYP, OSOPTION", new[] { "OSHBMCUS", "OSHBLOT", "OSOPTYP", "OSOPTION" }),
        new JdeIndex("F44H511_5", "Index on OSHBAREA, OSHBMCUS, OSOPKID, OSOPTION, OSHBLOT", new[] { "OSHBAREA", "OSHBMCUS", "OSOPKID", "OSOPTION", "OSHBLOT" }),
        new JdeIndex("F44H511_6", "Index on OSHBMCUS, OSHBAREA, OSHBLOT, OSOPTION", new[] { "OSHBMCUS", "OSHBAREA", "OSHBLOT", "OSOPTION" })
    };
}
