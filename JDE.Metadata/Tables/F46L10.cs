using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46L10 - .
/// </summary>
public class F46L10 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LMLPNU.
        /// </summary>
        public const string LMLPNU = "LMLPNU";

        /// <summary>
        /// LMPLPNU.
        /// </summary>
        public const string LMPLPNU = "LMPLPNU";

        /// <summary>
        /// LMMCU.
        /// </summary>
        public const string LMMCU = "LMMCU";

        /// <summary>
        /// LMEQTY.
        /// </summary>
        public const string LMEQTY = "LMEQTY";

        /// <summary>
        /// LMLOCN.
        /// </summary>
        public const string LMLOCN = "LMLOCN";

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
        /// LMGWEI.
        /// </summary>
        public const string LMGWEI = "LMGWEI";

        /// <summary>
        /// LMMAXW.
        /// </summary>
        public const string LMMAXW = "LMMAXW";

        /// <summary>
        /// LMCTEWT.
        /// </summary>
        public const string LMCTEWT = "LMCTEWT";

        /// <summary>
        /// LMOVWER.
        /// </summary>
        public const string LMOVWER = "LMOVWER";

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
        /// LMUSER.
        /// </summary>
        public const string LMUSER = "LMUSER";

        /// <summary>
        /// LMPID.
        /// </summary>
        public const string LMPID = "LMPID";

        /// <summary>
        /// LMSVRNAME.
        /// </summary>
        public const string LMSVRNAME = "LMSVRNAME";

        /// <summary>
        /// LMMKEY.
        /// </summary>
        public const string LMMKEY = "LMMKEY";

        /// <summary>
        /// LMLPNDC.
        /// </summary>
        public const string LMLPNDC = "LMLPNDC";

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
        /// LMURAT.
        /// </summary>
        public const string LMURAT = "LMURAT";

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
    }

    /// <inheritdoc />
    public override string TableName => "F46L10";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LMLPNU", "LMLPNU", JdeDataType.String, 80, true, true),
        new JdeField("LMPLPNU", "LMPLPNU", JdeDataType.String, 80),
        new JdeField("LMMCU", "LMMCU", JdeDataType.String, 24),
        new JdeField("LMEQTY", "LMEQTY", JdeDataType.String, 10),
        new JdeField("LMLOCN", "LMLOCN", JdeDataType.String, 40),
        new JdeField("LMSNTY", "LMSNTY", JdeDataType.String, 10),
        new JdeField("LMRFIDF", "LMRFIDF", JdeDataType.String, 2),
        new JdeField("LMGCUB", "LMGCUB", JdeDataType.Numeric),
        new JdeField("LMMAXLPV", "LMMAXLPV", JdeDataType.Numeric),
        new JdeField("LMVUMD", "LMVUMD", JdeDataType.String, 4),
        new JdeField("LMGWEI", "LMGWEI", JdeDataType.Numeric),
        new JdeField("LMMAXW", "LMMAXW", JdeDataType.Numeric),
        new JdeField("LMCTEWT", "LMCTEWT", JdeDataType.Numeric),
        new JdeField("LMOVWER", "LMOVWER", JdeDataType.Numeric),
        new JdeField("LMUWUM", "LMUWUM", JdeDataType.String, 4),
        new JdeField("LMGWID", "LMGWID", JdeDataType.Numeric),
        new JdeField("LMGHET", "LMGHET", JdeDataType.Numeric),
        new JdeField("LMGDEP", "LMGDEP", JdeDataType.Numeric),
        new JdeField("LMWIUM", "LMWIUM", JdeDataType.String, 4),
        new JdeField("LMCTUOM", "LMCTUOM", JdeDataType.String, 4),
        new JdeField("LMCPRGP1", "LMCPRGP1", JdeDataType.String, 12),
        new JdeField("LMCPRGP2", "LMCPRGP2", JdeDataType.String, 12),
        new JdeField("LMCPRGP3", "LMCPRGP3", JdeDataType.String, 12),
        new JdeField("LMLPSC", "LMLPSC", JdeDataType.String, 10),
        new JdeField("LMLPNRC", "LMLPNRC", JdeDataType.String, 20),
        new JdeField("LMUSER", "LMUSER", JdeDataType.String, 20),
        new JdeField("LMPID", "LMPID", JdeDataType.String, 20),
        new JdeField("LMSVRNAME", "LMSVRNAME", JdeDataType.String, 30),
        new JdeField("LMMKEY", "LMMKEY", JdeDataType.String, 30),
        new JdeField("LMLPNDC", "LMLPNDC", JdeDataType.Date),
        new JdeField("LMURCD", "LMURCD", JdeDataType.String, 4),
        new JdeField("LMURDT", "LMURDT", JdeDataType.Numeric),
        new JdeField("LMURAB", "LMURAB", JdeDataType.Numeric),
        new JdeField("LMURRF", "LMURRF", JdeDataType.String, 30),
        new JdeField("LMURAT", "LMURAT", JdeDataType.Numeric),
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
        new JdeField("LMLMFUD1", "LMLMFUD1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46L10_0", "Primary Key on LMLPNU", new[] { "LMLPNU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F46L10_2", "Index on LMPLPNU", new[] { "LMPLPNU" }),
        new JdeIndex("F46L10_3", "Index on LMPLPNU, LMMCU, LMLOCN", new[] { "LMPLPNU", "LMMCU", "LMLOCN" }),
        new JdeIndex("F46L10_4", "Index on LMMCU, LMLOCN", new[] { "LMMCU", "LMLOCN" })
    };
}
