using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0401Z1 - .
/// </summary>
public class F0401Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VOEDUS.
        /// </summary>
        public const string VOEDUS = "VOEDUS";

        /// <summary>
        /// VOEDBT.
        /// </summary>
        public const string VOEDBT = "VOEDBT";

        /// <summary>
        /// VOEDTN.
        /// </summary>
        public const string VOEDTN = "VOEDTN";

        /// <summary>
        /// VOEDLN.
        /// </summary>
        public const string VOEDLN = "VOEDLN";

        /// <summary>
        /// VOEDCT.
        /// </summary>
        public const string VOEDCT = "VOEDCT";

        /// <summary>
        /// VOTYTN.
        /// </summary>
        public const string VOTYTN = "VOTYTN";

        /// <summary>
        /// VOEDFT.
        /// </summary>
        public const string VOEDFT = "VOEDFT";

        /// <summary>
        /// VOEDDT.
        /// </summary>
        public const string VOEDDT = "VOEDDT";

        /// <summary>
        /// VODRIN.
        /// </summary>
        public const string VODRIN = "VODRIN";

        /// <summary>
        /// VOEDDL.
        /// </summary>
        public const string VOEDDL = "VOEDDL";

        /// <summary>
        /// VOEDSP.
        /// </summary>
        public const string VOEDSP = "VOEDSP";

        /// <summary>
        /// VOPNID.
        /// </summary>
        public const string VOPNID = "VOPNID";

        /// <summary>
        /// VOTNAC.
        /// </summary>
        public const string VOTNAC = "VOTNAC";

        /// <summary>
        /// VOAN8.
        /// </summary>
        public const string VOAN8 = "VOAN8";

        /// <summary>
        /// VOAPC.
        /// </summary>
        public const string VOAPC = "VOAPC";

        /// <summary>
        /// VOMCUP.
        /// </summary>
        public const string VOMCUP = "VOMCUP";

        /// <summary>
        /// VOOBAP.
        /// </summary>
        public const string VOOBAP = "VOOBAP";

        /// <summary>
        /// VOAIDP.
        /// </summary>
        public const string VOAIDP = "VOAIDP";

        /// <summary>
        /// VOKCOP.
        /// </summary>
        public const string VOKCOP = "VOKCOP";

        /// <summary>
        /// VODCAP.
        /// </summary>
        public const string VODCAP = "VODCAP";

        /// <summary>
        /// VODTAP.
        /// </summary>
        public const string VODTAP = "VODTAP";

        /// <summary>
        /// VOCRRP.
        /// </summary>
        public const string VOCRRP = "VOCRRP";

        /// <summary>
        /// VOTXA2.
        /// </summary>
        public const string VOTXA2 = "VOTXA2";

        /// <summary>
        /// VOEXR2.
        /// </summary>
        public const string VOEXR2 = "VOEXR2";

        /// <summary>
        /// VOHDPY.
        /// </summary>
        public const string VOHDPY = "VOHDPY";

        /// <summary>
        /// VOTXA3.
        /// </summary>
        public const string VOTXA3 = "VOTXA3";

        /// <summary>
        /// VOEXR3.
        /// </summary>
        public const string VOEXR3 = "VOEXR3";

        /// <summary>
        /// VOTAWH.
        /// </summary>
        public const string VOTAWH = "VOTAWH";

        /// <summary>
        /// VOPCWH.
        /// </summary>
        public const string VOPCWH = "VOPCWH";

        /// <summary>
        /// VOTRAP.
        /// </summary>
        public const string VOTRAP = "VOTRAP";

        /// <summary>
        /// VOSCK.
        /// </summary>
        public const string VOSCK = "VOSCK";

        /// <summary>
        /// VOPYIN.
        /// </summary>
        public const string VOPYIN = "VOPYIN";

        /// <summary>
        /// VOSNTO.
        /// </summary>
        public const string VOSNTO = "VOSNTO";

        /// <summary>
        /// VOPLST.
        /// </summary>
        public const string VOPLST = "VOPLST";

        /// <summary>
        /// VOAB1.
        /// </summary>
        public const string VOAB1 = "VOAB1";

        /// <summary>
        /// VOFLD.
        /// </summary>
        public const string VOFLD = "VOFLD";

        /// <summary>
        /// VOSQNL.
        /// </summary>
        public const string VOSQNL = "VOSQNL";

        /// <summary>
        /// VOCRCA.
        /// </summary>
        public const string VOCRCA = "VOCRCA";

        /// <summary>
        /// VOAYPD.
        /// </summary>
        public const string VOAYPD = "VOAYPD";

        /// <summary>
        /// VOAPPD.
        /// </summary>
        public const string VOAPPD = "VOAPPD";

        /// <summary>
        /// VOABAM.
        /// </summary>
        public const string VOABAM = "VOABAM";

        /// <summary>
        /// VOABA1.
        /// </summary>
        public const string VOABA1 = "VOABA1";

        /// <summary>
        /// VOAPRC.
        /// </summary>
        public const string VOAPRC = "VOAPRC";

        /// <summary>
        /// VOMINO.
        /// </summary>
        public const string VOMINO = "VOMINO";

        /// <summary>
        /// VOMAXO.
        /// </summary>
        public const string VOMAXO = "VOMAXO";

        /// <summary>
        /// VOAN8R.
        /// </summary>
        public const string VOAN8R = "VOAN8R";

        /// <summary>
        /// VOBADT.
        /// </summary>
        public const string VOBADT = "VOBADT";

        /// <summary>
        /// VOCPGP.
        /// </summary>
        public const string VOCPGP = "VOCPGP";

        /// <summary>
        /// VOORTP.
        /// </summary>
        public const string VOORTP = "VOORTP";

        /// <summary>
        /// VOINMG.
        /// </summary>
        public const string VOINMG = "VOINMG";

        /// <summary>
        /// VOHOLD.
        /// </summary>
        public const string VOHOLD = "VOHOLD";

        /// <summary>
        /// VOROUT.
        /// </summary>
        public const string VOROUT = "VOROUT";

        /// <summary>
        /// VOSTOP.
        /// </summary>
        public const string VOSTOP = "VOSTOP";

        /// <summary>
        /// VOZON.
        /// </summary>
        public const string VOZON = "VOZON";

        /// <summary>
        /// VOANCR.
        /// </summary>
        public const string VOANCR = "VOANCR";

        /// <summary>
        /// VOCARS.
        /// </summary>
        public const string VOCARS = "VOCARS";

        /// <summary>
        /// VODEL1.
        /// </summary>
        public const string VODEL1 = "VODEL1";

        /// <summary>
        /// VODEL2.
        /// </summary>
        public const string VODEL2 = "VODEL2";

        /// <summary>
        /// VOLTDT.
        /// </summary>
        public const string VOLTDT = "VOLTDT";

        /// <summary>
        /// VOFRTH.
        /// </summary>
        public const string VOFRTH = "VOFRTH";

        /// <summary>
        /// VOINVC.
        /// </summary>
        public const string VOINVC = "VOINVC";

        /// <summary>
        /// VOWUMD.
        /// </summary>
        public const string VOWUMD = "VOWUMD";

        /// <summary>
        /// VOVUMD.
        /// </summary>
        public const string VOVUMD = "VOVUMD";

        /// <summary>
        /// VOPRP5.
        /// </summary>
        public const string VOPRP5 = "VOPRP5";

        /// <summary>
        /// VOEDPM.
        /// </summary>
        public const string VOEDPM = "VOEDPM";

        /// <summary>
        /// VOEDCI.
        /// </summary>
        public const string VOEDCI = "VOEDCI";

        /// <summary>
        /// VOEDII.
        /// </summary>
        public const string VOEDII = "VOEDII";

        /// <summary>
        /// VOEDQD.
        /// </summary>
        public const string VOEDQD = "VOEDQD";

        /// <summary>
        /// VOEDAD.
        /// </summary>
        public const string VOEDAD = "VOEDAD";

        /// <summary>
        /// VOEDF1.
        /// </summary>
        public const string VOEDF1 = "VOEDF1";

        /// <summary>
        /// VOEDF2.
        /// </summary>
        public const string VOEDF2 = "VOEDF2";

        /// <summary>
        /// VOVI01.
        /// </summary>
        public const string VOVI01 = "VOVI01";

        /// <summary>
        /// VOVI02.
        /// </summary>
        public const string VOVI02 = "VOVI02";

        /// <summary>
        /// VOVI03.
        /// </summary>
        public const string VOVI03 = "VOVI03";

        /// <summary>
        /// VOVI04.
        /// </summary>
        public const string VOVI04 = "VOVI04";

        /// <summary>
        /// VOVI05.
        /// </summary>
        public const string VOVI05 = "VOVI05";

        /// <summary>
        /// VOMNSC.
        /// </summary>
        public const string VOMNSC = "VOMNSC";

        /// <summary>
        /// VOATO.
        /// </summary>
        public const string VOATO = "VOATO";

        /// <summary>
        /// VORVNT.
        /// </summary>
        public const string VORVNT = "VORVNT";

        /// <summary>
        /// VOASN.
        /// </summary>
        public const string VOASN = "VOASN";

        /// <summary>
        /// VOCRMD.
        /// </summary>
        public const string VOCRMD = "VOCRMD";

        /// <summary>
        /// VOAVCH.
        /// </summary>
        public const string VOAVCH = "VOAVCH";

        /// <summary>
        /// VOURCD.
        /// </summary>
        public const string VOURCD = "VOURCD";

        /// <summary>
        /// VOURDT.
        /// </summary>
        public const string VOURDT = "VOURDT";

        /// <summary>
        /// VOURAT.
        /// </summary>
        public const string VOURAT = "VOURAT";

        /// <summary>
        /// VOURAB.
        /// </summary>
        public const string VOURAB = "VOURAB";

        /// <summary>
        /// VOURRF.
        /// </summary>
        public const string VOURRF = "VOURRF";

        /// <summary>
        /// VOTORG.
        /// </summary>
        public const string VOTORG = "VOTORG";

        /// <summary>
        /// VOUSER.
        /// </summary>
        public const string VOUSER = "VOUSER";

        /// <summary>
        /// VOPID.
        /// </summary>
        public const string VOPID = "VOPID";

        /// <summary>
        /// VOJOBN.
        /// </summary>
        public const string VOJOBN = "VOJOBN";

        /// <summary>
        /// VOUPMJ.
        /// </summary>
        public const string VOUPMJ = "VOUPMJ";

        /// <summary>
        /// VOUPMT.
        /// </summary>
        public const string VOUPMT = "VOUPMT";

        /// <summary>
        /// VOTDAY.
        /// </summary>
        public const string VOTDAY = "VOTDAY";

        /// <summary>
        /// VOATRL.
        /// </summary>
        public const string VOATRL = "VOATRL";
    }

    /// <inheritdoc />
    public override string TableName => "F0401Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VOEDUS", "VOEDUS", JdeDataType.String, 20, true, true),
        new JdeField("VOEDBT", "VOEDBT", JdeDataType.String, 30, true, true),
        new JdeField("VOEDTN", "VOEDTN", JdeDataType.String, 44, true, true),
        new JdeField("VOEDLN", "VOEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("VOEDCT", "VOEDCT", JdeDataType.String, 4),
        new JdeField("VOTYTN", "VOTYTN", JdeDataType.String, 16),
        new JdeField("VOEDFT", "VOEDFT", JdeDataType.String, 20),
        new JdeField("VOEDDT", "VOEDDT", JdeDataType.Numeric),
        new JdeField("VODRIN", "VODRIN", JdeDataType.String, 2),
        new JdeField("VOEDDL", "VOEDDL", JdeDataType.Numeric),
        new JdeField("VOEDSP", "VOEDSP", JdeDataType.String, 2),
        new JdeField("VOPNID", "VOPNID", JdeDataType.String, 30),
        new JdeField("VOTNAC", "VOTNAC", JdeDataType.String, 4),
        new JdeField("VOAN8", "VOAN8", JdeDataType.Numeric),
        new JdeField("VOAPC", "VOAPC", JdeDataType.String, 8),
        new JdeField("VOMCUP", "VOMCUP", JdeDataType.String, 24),
        new JdeField("VOOBAP", "VOOBAP", JdeDataType.String, 12),
        new JdeField("VOAIDP", "VOAIDP", JdeDataType.String, 16),
        new JdeField("VOKCOP", "VOKCOP", JdeDataType.String, 10),
        new JdeField("VODCAP", "VODCAP", JdeDataType.Numeric),
        new JdeField("VODTAP", "VODTAP", JdeDataType.String, 4),
        new JdeField("VOCRRP", "VOCRRP", JdeDataType.String, 6),
        new JdeField("VOTXA2", "VOTXA2", JdeDataType.String, 20),
        new JdeField("VOEXR2", "VOEXR2", JdeDataType.String, 4),
        new JdeField("VOHDPY", "VOHDPY", JdeDataType.String, 2),
        new JdeField("VOTXA3", "VOTXA3", JdeDataType.String, 20),
        new JdeField("VOEXR3", "VOEXR3", JdeDataType.String, 4),
        new JdeField("VOTAWH", "VOTAWH", JdeDataType.Numeric),
        new JdeField("VOPCWH", "VOPCWH", JdeDataType.Numeric),
        new JdeField("VOTRAP", "VOTRAP", JdeDataType.String, 6),
        new JdeField("VOSCK", "VOSCK", JdeDataType.String, 2),
        new JdeField("VOPYIN", "VOPYIN", JdeDataType.String, 2),
        new JdeField("VOSNTO", "VOSNTO", JdeDataType.Numeric),
        new JdeField("VOPLST", "VOPLST", JdeDataType.String, 2),
        new JdeField("VOAB1", "VOAB1", JdeDataType.String, 2),
        new JdeField("VOFLD", "VOFLD", JdeDataType.Numeric),
        new JdeField("VOSQNL", "VOSQNL", JdeDataType.String, 2),
        new JdeField("VOCRCA", "VOCRCA", JdeDataType.String, 6),
        new JdeField("VOAYPD", "VOAYPD", JdeDataType.Numeric),
        new JdeField("VOAPPD", "VOAPPD", JdeDataType.Numeric),
        new JdeField("VOABAM", "VOABAM", JdeDataType.Numeric),
        new JdeField("VOABA1", "VOABA1", JdeDataType.Numeric),
        new JdeField("VOAPRC", "VOAPRC", JdeDataType.Numeric),
        new JdeField("VOMINO", "VOMINO", JdeDataType.Numeric),
        new JdeField("VOMAXO", "VOMAXO", JdeDataType.Numeric),
        new JdeField("VOAN8R", "VOAN8R", JdeDataType.Numeric),
        new JdeField("VOBADT", "VOBADT", JdeDataType.String, 2),
        new JdeField("VOCPGP", "VOCPGP", JdeDataType.String, 16),
        new JdeField("VOORTP", "VOORTP", JdeDataType.String, 16),
        new JdeField("VOINMG", "VOINMG", JdeDataType.String, 20),
        new JdeField("VOHOLD", "VOHOLD", JdeDataType.String, 4),
        new JdeField("VOROUT", "VOROUT", JdeDataType.String, 6),
        new JdeField("VOSTOP", "VOSTOP", JdeDataType.String, 6),
        new JdeField("VOZON", "VOZON", JdeDataType.String, 6),
        new JdeField("VOANCR", "VOANCR", JdeDataType.Numeric),
        new JdeField("VOCARS", "VOCARS", JdeDataType.Numeric),
        new JdeField("VODEL1", "VODEL1", JdeDataType.String, 60),
        new JdeField("VODEL2", "VODEL2", JdeDataType.String, 60),
        new JdeField("VOLTDT", "VOLTDT", JdeDataType.Numeric),
        new JdeField("VOFRTH", "VOFRTH", JdeDataType.String, 6),
        new JdeField("VOINVC", "VOINVC", JdeDataType.Numeric),
        new JdeField("VOWUMD", "VOWUMD", JdeDataType.String, 4),
        new JdeField("VOVUMD", "VOVUMD", JdeDataType.String, 4),
        new JdeField("VOPRP5", "VOPRP5", JdeDataType.String, 6),
        new JdeField("VOEDPM", "VOEDPM", JdeDataType.String, 2),
        new JdeField("VOEDCI", "VOEDCI", JdeDataType.String, 2),
        new JdeField("VOEDII", "VOEDII", JdeDataType.String, 2),
        new JdeField("VOEDQD", "VOEDQD", JdeDataType.Numeric),
        new JdeField("VOEDAD", "VOEDAD", JdeDataType.Numeric),
        new JdeField("VOEDF1", "VOEDF1", JdeDataType.String, 2),
        new JdeField("VOEDF2", "VOEDF2", JdeDataType.String, 2),
        new JdeField("VOVI01", "VOVI01", JdeDataType.String, 2),
        new JdeField("VOVI02", "VOVI02", JdeDataType.String, 2),
        new JdeField("VOVI03", "VOVI03", JdeDataType.String, 2),
        new JdeField("VOVI04", "VOVI04", JdeDataType.String, 2),
        new JdeField("VOVI05", "VOVI05", JdeDataType.String, 2),
        new JdeField("VOMNSC", "VOMNSC", JdeDataType.String, 2),
        new JdeField("VOATO", "VOATO", JdeDataType.String, 2),
        new JdeField("VORVNT", "VORVNT", JdeDataType.String, 2),
        new JdeField("VOASN", "VOASN", JdeDataType.String, 16),
        new JdeField("VOCRMD", "VOCRMD", JdeDataType.String, 2),
        new JdeField("VOAVCH", "VOAVCH", JdeDataType.String, 2),
        new JdeField("VOURCD", "VOURCD", JdeDataType.String, 4),
        new JdeField("VOURDT", "VOURDT", JdeDataType.Numeric),
        new JdeField("VOURAT", "VOURAT", JdeDataType.Numeric),
        new JdeField("VOURAB", "VOURAB", JdeDataType.Numeric),
        new JdeField("VOURRF", "VOURRF", JdeDataType.String, 30),
        new JdeField("VOTORG", "VOTORG", JdeDataType.String, 20),
        new JdeField("VOUSER", "VOUSER", JdeDataType.String, 20),
        new JdeField("VOPID", "VOPID", JdeDataType.String, 20),
        new JdeField("VOJOBN", "VOJOBN", JdeDataType.String, 20),
        new JdeField("VOUPMJ", "VOUPMJ", JdeDataType.Numeric),
        new JdeField("VOUPMT", "VOUPMT", JdeDataType.Numeric),
        new JdeField("VOTDAY", "VOTDAY", JdeDataType.Numeric),
        new JdeField("VOATRL", "VOATRL", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0401Z1_0", "Primary Key on VOEDUS, VOEDBT, VOEDTN, VOEDLN", new[] { "VOEDUS", "VOEDBT", "VOEDTN", "VOEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
