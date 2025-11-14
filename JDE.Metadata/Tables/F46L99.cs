using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46L99 - .
/// </summary>
public class F46L99 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LMUKID.
        /// </summary>
        public const string LMUKID = "LMUKID";

        /// <summary>
        /// LMLPNU.
        /// </summary>
        public const string LMLPNU = "LMLPNU";

        /// <summary>
        /// LMLPNDC.
        /// </summary>
        public const string LMLPNDC = "LMLPNDC";

        /// <summary>
        /// LMPLPNU.
        /// </summary>
        public const string LMPLPNU = "LMPLPNU";

        /// <summary>
        /// LMMCU.
        /// </summary>
        public const string LMMCU = "LMMCU";

        /// <summary>
        /// LMLOCN.
        /// </summary>
        public const string LMLOCN = "LMLOCN";

        /// <summary>
        /// LMITM.
        /// </summary>
        public const string LMITM = "LMITM";

        /// <summary>
        /// LMITM2.
        /// </summary>
        public const string LMITM2 = "LMITM2";

        /// <summary>
        /// LMLOTN.
        /// </summary>
        public const string LMLOTN = "LMLOTN";

        /// <summary>
        /// LMMMEJ.
        /// </summary>
        public const string LMMMEJ = "LMMMEJ";

        /// <summary>
        /// LMDOCO.
        /// </summary>
        public const string LMDOCO = "LMDOCO";

        /// <summary>
        /// LMDCTO.
        /// </summary>
        public const string LMDCTO = "LMDCTO";

        /// <summary>
        /// LMKCOO.
        /// </summary>
        public const string LMKCOO = "LMKCOO";

        /// <summary>
        /// LMLNID.
        /// </summary>
        public const string LMLNID = "LMLNID";

        /// <summary>
        /// LMSFXO.
        /// </summary>
        public const string LMSFXO = "LMSFXO";

        /// <summary>
        /// LMSNTY.
        /// </summary>
        public const string LMSNTY = "LMSNTY";

        /// <summary>
        /// LMRFIDF.
        /// </summary>
        public const string LMRFIDF = "LMRFIDF";

        /// <summary>
        /// LMGCUB.
        /// </summary>
        public const string LMGCUB = "LMGCUB";

        /// <summary>
        /// LMMAXLPV.
        /// </summary>
        public const string LMMAXLPV = "LMMAXLPV";

        /// <summary>
        /// LMVUMD.
        /// </summary>
        public const string LMVUMD = "LMVUMD";

        /// <summary>
        /// LMMAXW.
        /// </summary>
        public const string LMMAXW = "LMMAXW";

        /// <summary>
        /// LMOVWER.
        /// </summary>
        public const string LMOVWER = "LMOVWER";

        /// <summary>
        /// LMCTEWT.
        /// </summary>
        public const string LMCTEWT = "LMCTEWT";

        /// <summary>
        /// LMGWEI.
        /// </summary>
        public const string LMGWEI = "LMGWEI";

        /// <summary>
        /// LMUWUM.
        /// </summary>
        public const string LMUWUM = "LMUWUM";

        /// <summary>
        /// LMGWID.
        /// </summary>
        public const string LMGWID = "LMGWID";

        /// <summary>
        /// LMGHET.
        /// </summary>
        public const string LMGHET = "LMGHET";

        /// <summary>
        /// LMGDEP.
        /// </summary>
        public const string LMGDEP = "LMGDEP";

        /// <summary>
        /// LMWIUM.
        /// </summary>
        public const string LMWIUM = "LMWIUM";

        /// <summary>
        /// LMEQTY.
        /// </summary>
        public const string LMEQTY = "LMEQTY";

        /// <summary>
        /// LMCTUOM.
        /// </summary>
        public const string LMCTUOM = "LMCTUOM";

        /// <summary>
        /// LMCPRGP1.
        /// </summary>
        public const string LMCPRGP1 = "LMCPRGP1";

        /// <summary>
        /// LMCPRGP2.
        /// </summary>
        public const string LMCPRGP2 = "LMCPRGP2";

        /// <summary>
        /// LMCPRGP3.
        /// </summary>
        public const string LMCPRGP3 = "LMCPRGP3";

        /// <summary>
        /// LMLPSC.
        /// </summary>
        public const string LMLPSC = "LMLPSC";

        /// <summary>
        /// LMLPNRC.
        /// </summary>
        public const string LMLPNRC = "LMLPNRC";

        /// <summary>
        /// LMTQTY.
        /// </summary>
        public const string LMTQTY = "LMTQTY";

        /// <summary>
        /// LMUOM.
        /// </summary>
        public const string LMUOM = "LMUOM";

        /// <summary>
        /// LMPQOH.
        /// </summary>
        public const string LMPQOH = "LMPQOH";

        /// <summary>
        /// LMUOM1.
        /// </summary>
        public const string LMUOM1 = "LMUOM1";

        /// <summary>
        /// LMDQTY.
        /// </summary>
        public const string LMDQTY = "LMDQTY";

        /// <summary>
        /// LMUOM2.
        /// </summary>
        public const string LMUOM2 = "LMUOM2";

        /// <summary>
        /// LMCMTYP.
        /// </summary>
        public const string LMCMTYP = "LMCMTYP";

        /// <summary>
        /// LMQCOM.
        /// </summary>
        public const string LMQCOM = "LMQCOM";

        /// <summary>
        /// LMUOMC.
        /// </summary>
        public const string LMUOMC = "LMUOMC";

        /// <summary>
        /// LMUSER.
        /// </summary>
        public const string LMUSER = "LMUSER";

        /// <summary>
        /// LMPID.
        /// </summary>
        public const string LMPID = "LMPID";

        /// <summary>
        /// LMMKEY.
        /// </summary>
        public const string LMMKEY = "LMMKEY";

        /// <summary>
        /// LMURCD.
        /// </summary>
        public const string LMURCD = "LMURCD";

        /// <summary>
        /// LMURDT.
        /// </summary>
        public const string LMURDT = "LMURDT";

        /// <summary>
        /// LMURAB.
        /// </summary>
        public const string LMURAB = "LMURAB";

        /// <summary>
        /// LMURRF.
        /// </summary>
        public const string LMURRF = "LMURRF";

        /// <summary>
        /// LMTDAY.
        /// </summary>
        public const string LMTDAY = "LMTDAY";

        /// <summary>
        /// LMUPMJ.
        /// </summary>
        public const string LMUPMJ = "LMUPMJ";

        /// <summary>
        /// LMRCDJ.
        /// </summary>
        public const string LMRCDJ = "LMRCDJ";

        /// <summary>
        /// LMSVRNAME.
        /// </summary>
        public const string LMSVRNAME = "LMSVRNAME";

        /// <summary>
        /// LMSHPN.
        /// </summary>
        public const string LMSHPN = "LMSHPN";

        /// <summary>
        /// LMLPTT.
        /// </summary>
        public const string LMLPTT = "LMLPTT";

        /// <summary>
        /// LMAURCH1.
        /// </summary>
        public const string LMAURCH1 = "LMAURCH1";

        /// <summary>
        /// LMAURCH2.
        /// </summary>
        public const string LMAURCH2 = "LMAURCH2";

        /// <summary>
        /// LMAURMN1.
        /// </summary>
        public const string LMAURMN1 = "LMAURMN1";

        /// <summary>
        /// LMAURMN2.
        /// </summary>
        public const string LMAURMN2 = "LMAURMN2";

        /// <summary>
        /// LMAURST1.
        /// </summary>
        public const string LMAURST1 = "LMAURST1";

        /// <summary>
        /// LMAURST2.
        /// </summary>
        public const string LMAURST2 = "LMAURST2";

        /// <summary>
        /// LMAURST3.
        /// </summary>
        public const string LMAURST3 = "LMAURST3";

        /// <summary>
        /// LMAURST4.
        /// </summary>
        public const string LMAURST4 = "LMAURST4";

        /// <summary>
        /// LMAURST5.
        /// </summary>
        public const string LMAURST5 = "LMAURST5";

        /// <summary>
        /// LMAURST6.
        /// </summary>
        public const string LMAURST6 = "LMAURST6";

        /// <summary>
        /// LMAURST7.
        /// </summary>
        public const string LMAURST7 = "LMAURST7";

        /// <summary>
        /// LMPARTLPN.
        /// </summary>
        public const string LMPARTLPN = "LMPARTLPN";

        /// <summary>
        /// LMELPN.
        /// </summary>
        public const string LMELPN = "LMELPN";

        /// <summary>
        /// LMCQLPN.
        /// </summary>
        public const string LMCQLPN = "LMCQLPN";

        /// <summary>
        /// LMMILPN.
        /// </summary>
        public const string LMMILPN = "LMMILPN";

        /// <summary>
        /// LMMLLPN.
        /// </summary>
        public const string LMMLLPN = "LMMLLPN";

        /// <summary>
        /// LMLMFUC1.
        /// </summary>
        public const string LMLMFUC1 = "LMLMFUC1";

        /// <summary>
        /// LMLMFUC2.
        /// </summary>
        public const string LMLMFUC2 = "LMLMFUC2";

        /// <summary>
        /// LMLMFUC3.
        /// </summary>
        public const string LMLMFUC3 = "LMLMFUC3";

        /// <summary>
        /// LMLMFUS1.
        /// </summary>
        public const string LMLMFUS1 = "LMLMFUS1";

        /// <summary>
        /// LMLMFUS2.
        /// </summary>
        public const string LMLMFUS2 = "LMLMFUS2";

        /// <summary>
        /// LMLMFUS3.
        /// </summary>
        public const string LMLMFUS3 = "LMLMFUS3";

        /// <summary>
        /// LMLMFUN1.
        /// </summary>
        public const string LMLMFUN1 = "LMLMFUN1";

        /// <summary>
        /// LMLMFUN2.
        /// </summary>
        public const string LMLMFUN2 = "LMLMFUN2";

        /// <summary>
        /// LMLMFUN3.
        /// </summary>
        public const string LMLMFUN3 = "LMLMFUN3";

        /// <summary>
        /// LMLMFUD1.
        /// </summary>
        public const string LMLMFUD1 = "LMLMFUD1";

        /// <summary>
        /// LMURAT.
        /// </summary>
        public const string LMURAT = "LMURAT";
    }

    /// <inheritdoc />
    public override string TableName => "F46L99";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LMUKID", "LMUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("LMLPNU", "LMLPNU", JdeDataType.String, 80),
        new JdeField("LMLPNDC", "LMLPNDC", JdeDataType.Date),
        new JdeField("LMPLPNU", "LMPLPNU", JdeDataType.String, 80),
        new JdeField("LMMCU", "LMMCU", JdeDataType.String, 24),
        new JdeField("LMLOCN", "LMLOCN", JdeDataType.String, 40),
        new JdeField("LMITM", "LMITM", JdeDataType.Numeric),
        new JdeField("LMITM2", "LMITM2", JdeDataType.String, 52),
        new JdeField("LMLOTN", "LMLOTN", JdeDataType.String, 60),
        new JdeField("LMMMEJ", "LMMMEJ", JdeDataType.Numeric),
        new JdeField("LMDOCO", "LMDOCO", JdeDataType.Numeric),
        new JdeField("LMDCTO", "LMDCTO", JdeDataType.String, 4),
        new JdeField("LMKCOO", "LMKCOO", JdeDataType.String, 10),
        new JdeField("LMLNID", "LMLNID", JdeDataType.Numeric),
        new JdeField("LMSFXO", "LMSFXO", JdeDataType.String, 6),
        new JdeField("LMSNTY", "LMSNTY", JdeDataType.String, 10),
        new JdeField("LMRFIDF", "LMRFIDF", JdeDataType.String, 2),
        new JdeField("LMGCUB", "LMGCUB", JdeDataType.Numeric),
        new JdeField("LMMAXLPV", "LMMAXLPV", JdeDataType.Numeric),
        new JdeField("LMVUMD", "LMVUMD", JdeDataType.String, 4),
        new JdeField("LMMAXW", "LMMAXW", JdeDataType.Numeric),
        new JdeField("LMOVWER", "LMOVWER", JdeDataType.Numeric),
        new JdeField("LMCTEWT", "LMCTEWT", JdeDataType.Numeric),
        new JdeField("LMGWEI", "LMGWEI", JdeDataType.Numeric),
        new JdeField("LMUWUM", "LMUWUM", JdeDataType.String, 4),
        new JdeField("LMGWID", "LMGWID", JdeDataType.Numeric),
        new JdeField("LMGHET", "LMGHET", JdeDataType.Numeric),
        new JdeField("LMGDEP", "LMGDEP", JdeDataType.Numeric),
        new JdeField("LMWIUM", "LMWIUM", JdeDataType.String, 4),
        new JdeField("LMEQTY", "LMEQTY", JdeDataType.String, 10),
        new JdeField("LMCTUOM", "LMCTUOM", JdeDataType.String, 4),
        new JdeField("LMCPRGP1", "LMCPRGP1", JdeDataType.String, 12),
        new JdeField("LMCPRGP2", "LMCPRGP2", JdeDataType.String, 12),
        new JdeField("LMCPRGP3", "LMCPRGP3", JdeDataType.String, 12),
        new JdeField("LMLPSC", "LMLPSC", JdeDataType.String, 10),
        new JdeField("LMLPNRC", "LMLPNRC", JdeDataType.String, 20),
        new JdeField("LMTQTY", "LMTQTY", JdeDataType.Numeric),
        new JdeField("LMUOM", "LMUOM", JdeDataType.String, 4),
        new JdeField("LMPQOH", "LMPQOH", JdeDataType.Numeric),
        new JdeField("LMUOM1", "LMUOM1", JdeDataType.String, 4),
        new JdeField("LMDQTY", "LMDQTY", JdeDataType.Numeric),
        new JdeField("LMUOM2", "LMUOM2", JdeDataType.String, 4),
        new JdeField("LMCMTYP", "LMCMTYP", JdeDataType.String, 4),
        new JdeField("LMQCOM", "LMQCOM", JdeDataType.Numeric),
        new JdeField("LMUOMC", "LMUOMC", JdeDataType.String, 4),
        new JdeField("LMUSER", "LMUSER", JdeDataType.String, 20),
        new JdeField("LMPID", "LMPID", JdeDataType.String, 20),
        new JdeField("LMMKEY", "LMMKEY", JdeDataType.String, 30),
        new JdeField("LMURCD", "LMURCD", JdeDataType.String, 4),
        new JdeField("LMURDT", "LMURDT", JdeDataType.Numeric),
        new JdeField("LMURAB", "LMURAB", JdeDataType.Numeric),
        new JdeField("LMURRF", "LMURRF", JdeDataType.String, 30),
        new JdeField("LMTDAY", "LMTDAY", JdeDataType.Numeric),
        new JdeField("LMUPMJ", "LMUPMJ", JdeDataType.Numeric),
        new JdeField("LMRCDJ", "LMRCDJ", JdeDataType.Numeric),
        new JdeField("LMSVRNAME", "LMSVRNAME", JdeDataType.String, 30),
        new JdeField("LMSHPN", "LMSHPN", JdeDataType.Numeric),
        new JdeField("LMLPTT", "LMLPTT", JdeDataType.String, 10),
        new JdeField("LMAURCH1", "LMAURCH1", JdeDataType.String, 2),
        new JdeField("LMAURCH2", "LMAURCH2", JdeDataType.String, 2),
        new JdeField("LMAURMN1", "LMAURMN1", JdeDataType.Numeric),
        new JdeField("LMAURMN2", "LMAURMN2", JdeDataType.Numeric),
        new JdeField("LMAURST1", "LMAURST1", JdeDataType.String, 10),
        new JdeField("LMAURST2", "LMAURST2", JdeDataType.String, 10),
        new JdeField("LMAURST3", "LMAURST3", JdeDataType.String, 30),
        new JdeField("LMAURST4", "LMAURST4", JdeDataType.String, 30),
        new JdeField("LMAURST5", "LMAURST5", JdeDataType.String, 30),
        new JdeField("LMAURST6", "LMAURST6", JdeDataType.String, 30),
        new JdeField("LMAURST7", "LMAURST7", JdeDataType.String, 60),
        new JdeField("LMPARTLPN", "LMPARTLPN", JdeDataType.String, 2),
        new JdeField("LMELPN", "LMELPN", JdeDataType.String, 2),
        new JdeField("LMCQLPN", "LMCQLPN", JdeDataType.String, 2),
        new JdeField("LMMILPN", "LMMILPN", JdeDataType.String, 2),
        new JdeField("LMMLLPN", "LMMLLPN", JdeDataType.String, 2),
        new JdeField("LMLMFUC1", "LMLMFUC1", JdeDataType.String, 2),
        new JdeField("LMLMFUC2", "LMLMFUC2", JdeDataType.String, 2),
        new JdeField("LMLMFUC3", "LMLMFUC3", JdeDataType.String, 2),
        new JdeField("LMLMFUS1", "LMLMFUS1", JdeDataType.String, 4),
        new JdeField("LMLMFUS2", "LMLMFUS2", JdeDataType.String, 80),
        new JdeField("LMLMFUS3", "LMLMFUS3", JdeDataType.String, 100),
        new JdeField("LMLMFUN1", "LMLMFUN1", JdeDataType.Numeric),
        new JdeField("LMLMFUN2", "LMLMFUN2", JdeDataType.Numeric),
        new JdeField("LMLMFUN3", "LMLMFUN3", JdeDataType.Numeric),
        new JdeField("LMLMFUD1", "LMLMFUD1", JdeDataType.Numeric),
        new JdeField("LMURAT", "LMURAT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46L99_0", "Primary Key on LMUKID", new[] { "LMUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F46L99_2", "Index on SYS_NC00086$, LMLPNU", new[] { "SYS_NC00086$", "LMLPNU" }),
        new JdeIndex("F46L99_3", "Index on LMLPNU, LMLPTT", new[] { "LMLPNU", "LMLPTT" }),
        new JdeIndex("F46L99_4", "Index on LMLPNU, SYS_NC00087$", new[] { "LMLPNU", "SYS_NC00087$" })
    };
}
