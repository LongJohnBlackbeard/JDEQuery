using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H511H - .
/// </summary>
public class F44H511H : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OHHBMCUS.
        /// </summary>
        public const string OHHBMCUS = "OHHBMCUS";

        /// <summary>
        /// OHHBLOT.
        /// </summary>
        public const string OHHBLOT = "OHHBLOT";

        /// <summary>
        /// OHOPKID.
        /// </summary>
        public const string OHOPKID = "OHOPKID";

        /// <summary>
        /// OHOPTION.
        /// </summary>
        public const string OHOPTION = "OHOPTION";

        /// <summary>
        /// OHOHSEQ.
        /// </summary>
        public const string OHOHSEQ = "OHOHSEQ";

        /// <summary>
        /// OHHBAREA.
        /// </summary>
        public const string OHHBAREA = "OHHBAREA";

        /// <summary>
        /// OHCSPR.
        /// </summary>
        public const string OHCSPR = "OHCSPR";

        /// <summary>
        /// OHOPTEXA.
        /// </summary>
        public const string OHOPTEXA = "OHOPTEXA";

        /// <summary>
        /// OHDTKN.
        /// </summary>
        public const string OHDTKN = "OHDTKN";

        /// <summary>
        /// OHSTDSLPR.
        /// </summary>
        public const string OHSTDSLPR = "OHSTDSLPR";

        /// <summary>
        /// OHSTDEXA.
        /// </summary>
        public const string OHSTDEXA = "OHSTDEXA";

        /// <summary>
        /// OHOSCQTY.
        /// </summary>
        public const string OHOSCQTY = "OHOSCQTY";

        /// <summary>
        /// OHTPQ.
        /// </summary>
        public const string OHTPQ = "OHTPQ";

        /// <summary>
        /// OHOSPQTY.
        /// </summary>
        public const string OHOSPQTY = "OHOSPQTY";

        /// <summary>
        /// OHREVQTP.
        /// </summary>
        public const string OHREVQTP = "OHREVQTP";

        /// <summary>
        /// OHDSC1.
        /// </summary>
        public const string OHDSC1 = "OHDSC1";

        /// <summary>
        /// OHDSC2.
        /// </summary>
        public const string OHDSC2 = "OHDSC2";

        /// <summary>
        /// OHSKT.
        /// </summary>
        public const string OHSKT = "OHSKT";

        /// <summary>
        /// OHCSSEQ.
        /// </summary>
        public const string OHCSSEQ = "OHCSSEQ";

        /// <summary>
        /// OHCNACT.
        /// </summary>
        public const string OHCNACT = "OHCNACT";

        /// <summary>
        /// OHOPTYP.
        /// </summary>
        public const string OHOPTYP = "OHOPTYP";

        /// <summary>
        /// OHDTSEL.
        /// </summary>
        public const string OHDTSEL = "OHDTSEL";

        /// <summary>
        /// OHDCG.
        /// </summary>
        public const string OHDCG = "OHDCG";

        /// <summary>
        /// OHPKGVA.
        /// </summary>
        public const string OHPKGVA = "OHPKGVA";

        /// <summary>
        /// OHOSELCD1.
        /// </summary>
        public const string OHOSELCD1 = "OHOSELCD1";

        /// <summary>
        /// OHOSELCD2.
        /// </summary>
        public const string OHOSELCD2 = "OHOSELCD2";

        /// <summary>
        /// OHOPKG.
        /// </summary>
        public const string OHOPKG = "OHOPKG";

        /// <summary>
        /// OHHBST1.
        /// </summary>
        public const string OHHBST1 = "OHHBST1";

        /// <summary>
        /// OHHBST2.
        /// </summary>
        public const string OHHBST2 = "OHHBST2";

        /// <summary>
        /// OHHBST3.
        /// </summary>
        public const string OHHBST3 = "OHHBST3";

        /// <summary>
        /// OHHBST4.
        /// </summary>
        public const string OHHBST4 = "OHHBST4";

        /// <summary>
        /// OHHBST5.
        /// </summary>
        public const string OHHBST5 = "OHHBST5";

        /// <summary>
        /// OHVARRSN.
        /// </summary>
        public const string OHVARRSN = "OHVARRSN";

        /// <summary>
        /// OHCRTU.
        /// </summary>
        public const string OHCRTU = "OHCRTU";

        /// <summary>
        /// OHCRTJ.
        /// </summary>
        public const string OHCRTJ = "OHCRTJ";

        /// <summary>
        /// OHCRTT.
        /// </summary>
        public const string OHCRTT = "OHCRTT";

        /// <summary>
        /// OHWRKSTNID.
        /// </summary>
        public const string OHWRKSTNID = "OHWRKSTNID";

        /// <summary>
        /// OHHBOPID.
        /// </summary>
        public const string OHHBOPID = "OHHBOPID";

        /// <summary>
        /// OHUPMB.
        /// </summary>
        public const string OHUPMB = "OHUPMB";

        /// <summary>
        /// OHUPMJ.
        /// </summary>
        public const string OHUPMJ = "OHUPMJ";

        /// <summary>
        /// OHUPMT.
        /// </summary>
        public const string OHUPMT = "OHUPMT";

        /// <summary>
        /// OHJOBN.
        /// </summary>
        public const string OHJOBN = "OHJOBN";

        /// <summary>
        /// OHPID.
        /// </summary>
        public const string OHPID = "OHPID";
    }

    /// <inheritdoc />
    public override string TableName => "F44H511H";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OHHBMCUS", "OHHBMCUS", JdeDataType.String, 24, true, true),
        new JdeField("OHHBLOT", "OHHBLOT", JdeDataType.String, 8, true, true),
        new JdeField("OHOPKID", "OHOPKID", JdeDataType.String, 16, true, true),
        new JdeField("OHOPTION", "OHOPTION", JdeDataType.String, 16, true, true),
        new JdeField("OHOHSEQ", "OHOHSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("OHHBAREA", "OHHBAREA", JdeDataType.String, 6),
        new JdeField("OHCSPR", "OHCSPR", JdeDataType.Numeric),
        new JdeField("OHOPTEXA", "OHOPTEXA", JdeDataType.Numeric),
        new JdeField("OHDTKN", "OHDTKN", JdeDataType.Numeric),
        new JdeField("OHSTDSLPR", "OHSTDSLPR", JdeDataType.Numeric),
        new JdeField("OHSTDEXA", "OHSTDEXA", JdeDataType.Numeric),
        new JdeField("OHOSCQTY", "OHOSCQTY", JdeDataType.Numeric),
        new JdeField("OHTPQ", "OHTPQ", JdeDataType.Numeric),
        new JdeField("OHOSPQTY", "OHOSPQTY", JdeDataType.Numeric),
        new JdeField("OHREVQTP", "OHREVQTP", JdeDataType.Numeric),
        new JdeField("OHDSC1", "OHDSC1", JdeDataType.String, 60),
        new JdeField("OHDSC2", "OHDSC2", JdeDataType.String, 60),
        new JdeField("OHSKT", "OHSKT", JdeDataType.String, 16),
        new JdeField("OHCSSEQ", "OHCSSEQ", JdeDataType.String, 6),
        new JdeField("OHCNACT", "OHCNACT", JdeDataType.String, 6),
        new JdeField("OHOPTYP", "OHOPTYP", JdeDataType.String, 6),
        new JdeField("OHDTSEL", "OHDTSEL", JdeDataType.Numeric),
        new JdeField("OHDCG", "OHDCG", JdeDataType.Numeric),
        new JdeField("OHPKGVA", "OHPKGVA", JdeDataType.Numeric),
        new JdeField("OHOSELCD1", "OHOSELCD1", JdeDataType.String, 6),
        new JdeField("OHOSELCD2", "OHOSELCD2", JdeDataType.String, 6),
        new JdeField("OHOPKG", "OHOPKG", JdeDataType.String, 2),
        new JdeField("OHHBST1", "OHHBST1", JdeDataType.String, 2),
        new JdeField("OHHBST2", "OHHBST2", JdeDataType.String, 2),
        new JdeField("OHHBST3", "OHHBST3", JdeDataType.String, 2),
        new JdeField("OHHBST4", "OHHBST4", JdeDataType.String, 2),
        new JdeField("OHHBST5", "OHHBST5", JdeDataType.String, 2),
        new JdeField("OHVARRSN", "OHVARRSN", JdeDataType.String, 6),
        new JdeField("OHCRTU", "OHCRTU", JdeDataType.String, 20),
        new JdeField("OHCRTJ", "OHCRTJ", JdeDataType.Numeric),
        new JdeField("OHCRTT", "OHCRTT", JdeDataType.Numeric),
        new JdeField("OHWRKSTNID", "OHWRKSTNID", JdeDataType.String, 20),
        new JdeField("OHHBOPID", "OHHBOPID", JdeDataType.String, 20),
        new JdeField("OHUPMB", "OHUPMB", JdeDataType.String, 20),
        new JdeField("OHUPMJ", "OHUPMJ", JdeDataType.Numeric),
        new JdeField("OHUPMT", "OHUPMT", JdeDataType.Numeric),
        new JdeField("OHJOBN", "OHJOBN", JdeDataType.String, 20),
        new JdeField("OHPID", "OHPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H511H_0", "Primary Key on OHHBMCUS, OHHBLOT, OHOPKID, OHOPTION, OHOHSEQ", new[] { "OHHBMCUS", "OHHBLOT", "OHOPKID", "OHOPTION", "OHOHSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
