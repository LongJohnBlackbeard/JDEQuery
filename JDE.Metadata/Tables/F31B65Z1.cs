using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B65Z1 - .
/// </summary>
public class F31B65Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SZEDUS.
        /// </summary>
        public const string SZEDUS = "SZEDUS";

        /// <summary>
        /// SZEDBT.
        /// </summary>
        public const string SZEDBT = "SZEDBT";

        /// <summary>
        /// SZEDTN.
        /// </summary>
        public const string SZEDTN = "SZEDTN";

        /// <summary>
        /// SZEDLN.
        /// </summary>
        public const string SZEDLN = "SZEDLN";

        /// <summary>
        /// SZEDCT.
        /// </summary>
        public const string SZEDCT = "SZEDCT";

        /// <summary>
        /// SZTYTN.
        /// </summary>
        public const string SZTYTN = "SZTYTN";

        /// <summary>
        /// SZEDFT.
        /// </summary>
        public const string SZEDFT = "SZEDFT";

        /// <summary>
        /// SZEDDT.
        /// </summary>
        public const string SZEDDT = "SZEDDT";

        /// <summary>
        /// SZDRIN.
        /// </summary>
        public const string SZDRIN = "SZDRIN";

        /// <summary>
        /// SZEDDL.
        /// </summary>
        public const string SZEDDL = "SZEDDL";

        /// <summary>
        /// SZEDSP.
        /// </summary>
        public const string SZEDSP = "SZEDSP";

        /// <summary>
        /// SZPNID.
        /// </summary>
        public const string SZPNID = "SZPNID";

        /// <summary>
        /// SZTNAC.
        /// </summary>
        public const string SZTNAC = "SZTNAC";

        /// <summary>
        /// SZWAPRN.
        /// </summary>
        public const string SZWAPRN = "SZWAPRN";

        /// <summary>
        /// SZWAWOR.
        /// </summary>
        public const string SZWAWOR = "SZWAWOR";

        /// <summary>
        /// SZWDOCO.
        /// </summary>
        public const string SZWDOCO = "SZWDOCO";

        /// <summary>
        /// SZWOPID.
        /// </summary>
        public const string SZWOPID = "SZWOPID";

        /// <summary>
        /// SZWOPN.
        /// </summary>
        public const string SZWOPN = "SZWOPN";

        /// <summary>
        /// SZWCRTR.
        /// </summary>
        public const string SZWCRTR = "SZWCRTR";

        /// <summary>
        /// SZWCOPCD.
        /// </summary>
        public const string SZWCOPCD = "SZWCOPCD";

        /// <summary>
        /// SZWALOP.
        /// </summary>
        public const string SZWALOP = "SZWALOP";

        /// <summary>
        /// SZWOPDSC.
        /// </summary>
        public const string SZWOPDSC = "SZWOPDSC";

        /// <summary>
        /// SZWSD.
        /// </summary>
        public const string SZWSD = "SZWSD";

        /// <summary>
        /// SZMMCU.
        /// </summary>
        public const string SZMMCU = "SZMMCU";

        /// <summary>
        /// SZWASJDT.
        /// </summary>
        public const string SZWASJDT = "SZWASJDT";

        /// <summary>
        /// SZWWAST.
        /// </summary>
        public const string SZWWAST = "SZWWAST";

        /// <summary>
        /// SZWWASTZ.
        /// </summary>
        public const string SZWWASTZ = "SZWWASTZ";

        /// <summary>
        /// SZWAEJDT.
        /// </summary>
        public const string SZWAEJDT = "SZWAEJDT";

        /// <summary>
        /// SZWWAET.
        /// </summary>
        public const string SZWWAET = "SZWWAET";

        /// <summary>
        /// SZWWAETZ.
        /// </summary>
        public const string SZWWAETZ = "SZWWAETZ";

        /// <summary>
        /// SZWADUR.
        /// </summary>
        public const string SZWADUR = "SZWADUR";

        /// <summary>
        /// SZWRDOCO.
        /// </summary>
        public const string SZWRDOCO = "SZWRDOCO";

        /// <summary>
        /// SZBLSCD.
        /// </summary>
        public const string SZBLSCD = "SZBLSCD";

        /// <summary>
        /// SZVINTAG.
        /// </summary>
        public const string SZVINTAG = "SZVINTAG";

        /// <summary>
        /// SZFRVNUM.
        /// </summary>
        public const string SZFRVNUM = "SZFRVNUM";

        /// <summary>
        /// SZTOVNUM.
        /// </summary>
        public const string SZTOVNUM = "SZTOVNUM";

        /// <summary>
        /// SZWAM.
        /// </summary>
        public const string SZWAM = "SZWAM";

        /// <summary>
        /// SZWACTVLMV.
        /// </summary>
        public const string SZWACTVLMV = "SZWACTVLMV";

        /// <summary>
        /// SZWACTUOM.
        /// </summary>
        public const string SZWACTUOM = "SZWACTUOM";

        /// <summary>
        /// SZWFBAQFLG.
        /// </summary>
        public const string SZWFBAQFLG = "SZWFBAQFLG";

        /// <summary>
        /// SZWFBAQTY.
        /// </summary>
        public const string SZWFBAQTY = "SZWFBAQTY";

        /// <summary>
        /// SZWFBAUOM.
        /// </summary>
        public const string SZWFBAUOM = "SZWFBAUOM";

        /// <summary>
        /// SZWFAAQFLG.
        /// </summary>
        public const string SZWFAAQFLG = "SZWFAAQFLG";

        /// <summary>
        /// SZWFAAQTY.
        /// </summary>
        public const string SZWFAAQTY = "SZWFAAQTY";

        /// <summary>
        /// SZWFAAUOM.
        /// </summary>
        public const string SZWFAAUOM = "SZWFAAUOM";

        /// <summary>
        /// SZWTBAQFLG.
        /// </summary>
        public const string SZWTBAQFLG = "SZWTBAQFLG";

        /// <summary>
        /// SZWTBAQTY.
        /// </summary>
        public const string SZWTBAQTY = "SZWTBAQTY";

        /// <summary>
        /// SZWTBAUOM.
        /// </summary>
        public const string SZWTBAUOM = "SZWTBAUOM";

        /// <summary>
        /// SZWTAAQFLG.
        /// </summary>
        public const string SZWTAAQFLG = "SZWTAAQFLG";

        /// <summary>
        /// SZWTAAQTY.
        /// </summary>
        public const string SZWTAAQTY = "SZWTAAQTY";

        /// <summary>
        /// SZWTAAUOM.
        /// </summary>
        public const string SZWTAAUOM = "SZWTAAUOM";

        /// <summary>
        /// SZWADDLITM.
        /// </summary>
        public const string SZWADDLITM = "SZWADDLITM";

        /// <summary>
        /// SZADDQTY.
        /// </summary>
        public const string SZADDQTY = "SZADDQTY";

        /// <summary>
        /// SZADTUOM.
        /// </summary>
        public const string SZADTUOM = "SZADTUOM";

        /// <summary>
        /// SZWADDLOTN.
        /// </summary>
        public const string SZWADDLOTN = "SZWADDLOTN";

        /// <summary>
        /// SZWADDLOCN.
        /// </summary>
        public const string SZWADDLOCN = "SZWADDLOCN";

        /// <summary>
        /// SZWADDMCU.
        /// </summary>
        public const string SZWADDMCU = "SZWADDMCU";

        /// <summary>
        /// SZWFRMAT.
        /// </summary>
        public const string SZWFRMAT = "SZWFRMAT";

        /// <summary>
        /// SZWTRMAT.
        /// </summary>
        public const string SZWTRMAT = "SZWTRMAT";

        /// <summary>
        /// SZWFAWS.
        /// </summary>
        public const string SZWFAWS = "SZWFAWS";

        /// <summary>
        /// SZWTAWS.
        /// </summary>
        public const string SZWTAWS = "SZWTAWS";

        /// <summary>
        /// SZWFAABID.
        /// </summary>
        public const string SZWFAABID = "SZWFAABID";

        /// <summary>
        /// SZWTAABID.
        /// </summary>
        public const string SZWTAABID = "SZWTAABID";

        /// <summary>
        /// SZWFABID.
        /// </summary>
        public const string SZWFABID = "SZWFABID";

        /// <summary>
        /// SZWTABID.
        /// </summary>
        public const string SZWTABID = "SZWTABID";

        /// <summary>
        /// SZWFAEUR.
        /// </summary>
        public const string SZWFAEUR = "SZWFAEUR";

        /// <summary>
        /// SZWTAEUR.
        /// </summary>
        public const string SZWTAEUR = "SZWTAEUR";

        /// <summary>
        /// SZWFVBTTYP.
        /// </summary>
        public const string SZWFVBTTYP = "SZWFVBTTYP";

        /// <summary>
        /// SZWFCAPTYP.
        /// </summary>
        public const string SZWFCAPTYP = "SZWFCAPTYP";

        /// <summary>
        /// SZWTVBTTYP.
        /// </summary>
        public const string SZWTVBTTYP = "SZWTVBTTYP";

        /// <summary>
        /// SZWTCAPTYP.
        /// </summary>
        public const string SZWTCAPTYP = "SZWTCAPTYP";

        /// <summary>
        /// SZWH1.
        /// </summary>
        public const string SZWH1 = "SZWH1";

        /// <summary>
        /// SZWH2.
        /// </summary>
        public const string SZWH2 = "SZWH2";

        /// <summary>
        /// SZWH3.
        /// </summary>
        public const string SZWH3 = "SZWH3";

        /// <summary>
        /// SZWH4.
        /// </summary>
        public const string SZWH4 = "SZWH4";

        /// <summary>
        /// SZWH5.
        /// </summary>
        public const string SZWH5 = "SZWH5";

        /// <summary>
        /// SZWOFACO.
        /// </summary>
        public const string SZWOFACO = "SZWOFACO";

        /// <summary>
        /// SZWOFACC.
        /// </summary>
        public const string SZWOFACC = "SZWOFACC";

        /// <summary>
        /// SZWOFACM.
        /// </summary>
        public const string SZWOFACM = "SZWOFACM";

        /// <summary>
        /// SZWOFACT.
        /// </summary>
        public const string SZWOFACT = "SZWOFACT";

        /// <summary>
        /// SZWOTACO.
        /// </summary>
        public const string SZWOTACO = "SZWOTACO";

        /// <summary>
        /// SZWOTACC.
        /// </summary>
        public const string SZWOTACC = "SZWOTACC";

        /// <summary>
        /// SZWOTACM.
        /// </summary>
        public const string SZWOTACM = "SZWOTACM";

        /// <summary>
        /// SZWOTACT.
        /// </summary>
        public const string SZWOTACT = "SZWOTACT";

        /// <summary>
        /// SZURCD.
        /// </summary>
        public const string SZURCD = "SZURCD";

        /// <summary>
        /// SZURDT.
        /// </summary>
        public const string SZURDT = "SZURDT";

        /// <summary>
        /// SZURAT.
        /// </summary>
        public const string SZURAT = "SZURAT";

        /// <summary>
        /// SZURRF.
        /// </summary>
        public const string SZURRF = "SZURRF";

        /// <summary>
        /// SZURAB.
        /// </summary>
        public const string SZURAB = "SZURAB";

        /// <summary>
        /// SZUSER.
        /// </summary>
        public const string SZUSER = "SZUSER";

        /// <summary>
        /// SZPID.
        /// </summary>
        public const string SZPID = "SZPID";

        /// <summary>
        /// SZJOBN.
        /// </summary>
        public const string SZJOBN = "SZJOBN";

        /// <summary>
        /// SZUPMJ.
        /// </summary>
        public const string SZUPMJ = "SZUPMJ";

        /// <summary>
        /// SZTDAY.
        /// </summary>
        public const string SZTDAY = "SZTDAY";

        /// <summary>
        /// SZHARPER.
        /// </summary>
        public const string SZHARPER = "SZHARPER";

        /// <summary>
        /// SZHARSFX.
        /// </summary>
        public const string SZHARSFX = "SZHARSFX";

        /// <summary>
        /// SZWCRSPLF.
        /// </summary>
        public const string SZWCRSPLF = "SZWCRSPLF";

        /// <summary>
        /// SZWV2VLNID.
        /// </summary>
        public const string SZWV2VLNID = "SZWV2VLNID";

        /// <summary>
        /// SZPRCPTF.
        /// </summary>
        public const string SZPRCPTF = "SZPRCPTF";
    }

    /// <inheritdoc />
    public override string TableName => "F31B65Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SZEDUS", "SZEDUS", JdeDataType.String, 20, true, true),
        new JdeField("SZEDBT", "SZEDBT", JdeDataType.String, 30, true, true),
        new JdeField("SZEDTN", "SZEDTN", JdeDataType.String, 44, true, true),
        new JdeField("SZEDLN", "SZEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("SZEDCT", "SZEDCT", JdeDataType.String, 4),
        new JdeField("SZTYTN", "SZTYTN", JdeDataType.String, 16),
        new JdeField("SZEDFT", "SZEDFT", JdeDataType.String, 20),
        new JdeField("SZEDDT", "SZEDDT", JdeDataType.Numeric),
        new JdeField("SZDRIN", "SZDRIN", JdeDataType.String, 2),
        new JdeField("SZEDDL", "SZEDDL", JdeDataType.Numeric),
        new JdeField("SZEDSP", "SZEDSP", JdeDataType.String, 2),
        new JdeField("SZPNID", "SZPNID", JdeDataType.String, 30),
        new JdeField("SZTNAC", "SZTNAC", JdeDataType.String, 4),
        new JdeField("SZWAPRN", "SZWAPRN", JdeDataType.String, 40),
        new JdeField("SZWAWOR", "SZWAWOR", JdeDataType.String, 40),
        new JdeField("SZWDOCO", "SZWDOCO", JdeDataType.Numeric),
        new JdeField("SZWOPID", "SZWOPID", JdeDataType.Numeric),
        new JdeField("SZWOPN", "SZWOPN", JdeDataType.Numeric),
        new JdeField("SZWCRTR", "SZWCRTR", JdeDataType.Numeric),
        new JdeField("SZWCOPCD", "SZWCOPCD", JdeDataType.String, 20),
        new JdeField("SZWALOP", "SZWALOP", JdeDataType.String, 40),
        new JdeField("SZWOPDSC", "SZWOPDSC", JdeDataType.String, 60),
        new JdeField("SZWSD", "SZWSD", JdeDataType.String, 60),
        new JdeField("SZMMCU", "SZMMCU", JdeDataType.String, 24),
        new JdeField("SZWASJDT", "SZWASJDT", JdeDataType.Numeric),
        new JdeField("SZWWAST", "SZWWAST", JdeDataType.Numeric),
        new JdeField("SZWWASTZ", "SZWWASTZ", JdeDataType.String, 6),
        new JdeField("SZWAEJDT", "SZWAEJDT", JdeDataType.Numeric),
        new JdeField("SZWWAET", "SZWWAET", JdeDataType.Numeric),
        new JdeField("SZWWAETZ", "SZWWAETZ", JdeDataType.String, 6),
        new JdeField("SZWADUR", "SZWADUR", JdeDataType.Numeric),
        new JdeField("SZWRDOCO", "SZWRDOCO", JdeDataType.Numeric),
        new JdeField("SZBLSCD", "SZBLSCD", JdeDataType.String, 20),
        new JdeField("SZVINTAG", "SZVINTAG", JdeDataType.Numeric),
        new JdeField("SZFRVNUM", "SZFRVNUM", JdeDataType.String, 60),
        new JdeField("SZTOVNUM", "SZTOVNUM", JdeDataType.String, 60),
        new JdeField("SZWAM", "SZWAM", JdeDataType.String, 2),
        new JdeField("SZWACTVLMV", "SZWACTVLMV", JdeDataType.Numeric),
        new JdeField("SZWACTUOM", "SZWACTUOM", JdeDataType.String, 6),
        new JdeField("SZWFBAQFLG", "SZWFBAQFLG", JdeDataType.String, 2),
        new JdeField("SZWFBAQTY", "SZWFBAQTY", JdeDataType.Numeric),
        new JdeField("SZWFBAUOM", "SZWFBAUOM", JdeDataType.String, 6),
        new JdeField("SZWFAAQFLG", "SZWFAAQFLG", JdeDataType.String, 2),
        new JdeField("SZWFAAQTY", "SZWFAAQTY", JdeDataType.Numeric),
        new JdeField("SZWFAAUOM", "SZWFAAUOM", JdeDataType.String, 6),
        new JdeField("SZWTBAQFLG", "SZWTBAQFLG", JdeDataType.String, 2),
        new JdeField("SZWTBAQTY", "SZWTBAQTY", JdeDataType.Numeric),
        new JdeField("SZWTBAUOM", "SZWTBAUOM", JdeDataType.String, 6),
        new JdeField("SZWTAAQFLG", "SZWTAAQFLG", JdeDataType.String, 2),
        new JdeField("SZWTAAQTY", "SZWTAAQTY", JdeDataType.Numeric),
        new JdeField("SZWTAAUOM", "SZWTAAUOM", JdeDataType.String, 6),
        new JdeField("SZWADDLITM", "SZWADDLITM", JdeDataType.String, 50),
        new JdeField("SZADDQTY", "SZADDQTY", JdeDataType.Numeric),
        new JdeField("SZADTUOM", "SZADTUOM", JdeDataType.String, 4),
        new JdeField("SZWADDLOTN", "SZWADDLOTN", JdeDataType.String, 60),
        new JdeField("SZWADDLOCN", "SZWADDLOCN", JdeDataType.String, 40),
        new JdeField("SZWADDMCU", "SZWADDMCU", JdeDataType.String, 24),
        new JdeField("SZWFRMAT", "SZWFRMAT", JdeDataType.String, 8),
        new JdeField("SZWTRMAT", "SZWTRMAT", JdeDataType.String, 8),
        new JdeField("SZWFAWS", "SZWFAWS", JdeDataType.String, 12),
        new JdeField("SZWTAWS", "SZWTAWS", JdeDataType.String, 12),
        new JdeField("SZWFAABID", "SZWFAABID", JdeDataType.String, 60),
        new JdeField("SZWTAABID", "SZWTAABID", JdeDataType.String, 60),
        new JdeField("SZWFABID", "SZWFABID", JdeDataType.String, 60),
        new JdeField("SZWTABID", "SZWTABID", JdeDataType.String, 60),
        new JdeField("SZWFAEUR", "SZWFAEUR", JdeDataType.String, 20),
        new JdeField("SZWTAEUR", "SZWTAEUR", JdeDataType.String, 20),
        new JdeField("SZWFVBTTYP", "SZWFVBTTYP", JdeDataType.String, 8),
        new JdeField("SZWFCAPTYP", "SZWFCAPTYP", JdeDataType.String, 2),
        new JdeField("SZWTVBTTYP", "SZWTVBTTYP", JdeDataType.String, 8),
        new JdeField("SZWTCAPTYP", "SZWTCAPTYP", JdeDataType.String, 2),
        new JdeField("SZWH1", "SZWH1", JdeDataType.String, 20),
        new JdeField("SZWH2", "SZWH2", JdeDataType.String, 20),
        new JdeField("SZWH3", "SZWH3", JdeDataType.String, 20),
        new JdeField("SZWH4", "SZWH4", JdeDataType.String, 20),
        new JdeField("SZWH5", "SZWH5", JdeDataType.String, 20),
        new JdeField("SZWOFACO", "SZWOFACO", JdeDataType.String, 2),
        new JdeField("SZWOFACC", "SZWOFACC", JdeDataType.String, 12),
        new JdeField("SZWOFACM", "SZWOFACM", JdeDataType.String, 400),
        new JdeField("SZWOFACT", "SZWOFACT", JdeDataType.String, 60),
        new JdeField("SZWOTACO", "SZWOTACO", JdeDataType.String, 2),
        new JdeField("SZWOTACC", "SZWOTACC", JdeDataType.String, 12),
        new JdeField("SZWOTACM", "SZWOTACM", JdeDataType.String, 400),
        new JdeField("SZWOTACT", "SZWOTACT", JdeDataType.String, 60),
        new JdeField("SZURCD", "SZURCD", JdeDataType.String, 4),
        new JdeField("SZURDT", "SZURDT", JdeDataType.Numeric),
        new JdeField("SZURAT", "SZURAT", JdeDataType.Numeric),
        new JdeField("SZURRF", "SZURRF", JdeDataType.String, 30),
        new JdeField("SZURAB", "SZURAB", JdeDataType.Numeric),
        new JdeField("SZUSER", "SZUSER", JdeDataType.String, 20),
        new JdeField("SZPID", "SZPID", JdeDataType.String, 20),
        new JdeField("SZJOBN", "SZJOBN", JdeDataType.String, 20),
        new JdeField("SZUPMJ", "SZUPMJ", JdeDataType.Numeric),
        new JdeField("SZTDAY", "SZTDAY", JdeDataType.Numeric),
        new JdeField("SZHARPER", "SZHARPER", JdeDataType.String, 12),
        new JdeField("SZHARSFX", "SZHARSFX", JdeDataType.String, 20),
        new JdeField("SZWCRSPLF", "SZWCRSPLF", JdeDataType.String, 2),
        new JdeField("SZWV2VLNID", "SZWV2VLNID", JdeDataType.Numeric),
        new JdeField("SZPRCPTF", "SZPRCPTF", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B65Z1_0", "Primary Key on SZEDUS, SZEDBT, SZEDTN, SZEDLN", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B65Z1_11", "Index on SZEDUS, SZEDBT, SZEDTN", new[] { "SZEDUS", "SZEDBT", "SZEDTN" }),
        new JdeIndex("F31B65Z1_13", "Index on SZEDBT, SZEDTN, SZWAWOR, SZWAPRN", new[] { "SZEDBT", "SZEDTN", "SZWAWOR", "SZWAPRN" }),
        new JdeIndex("F31B65Z1_14", "Index on SZEDUS, SZEDBT, SZEDTN, SYS_NC00100$", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SYS_NC00100$" }),
        new JdeIndex("F31B65Z1_15", "Index on SZWAWOR, SZWAPRN, SZEDLN", new[] { "SZWAWOR", "SZWAPRN", "SZEDLN" }),
        new JdeIndex("F31B65Z1_16", "Index on SZWAPRN, SZEDLN, SZFRVNUM, SZWV2VLNID", new[] { "SZWAPRN", "SZEDLN", "SZFRVNUM", "SZWV2VLNID" }),
        new JdeIndex("F31B65Z1_8", "Index on SZEDUS, SZEDBT, SZEDTN, SZEDSP", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDSP" }),
        new JdeIndex("F31B65Z1_9", "Index on SZEDUS, SZEDBT, SZEDSP", new[] { "SZEDUS", "SZEDBT", "SZEDSP" })
    };
}
