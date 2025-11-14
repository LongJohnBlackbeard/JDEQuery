using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09617 - .
/// </summary>
public class F09617 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GMBKSTID.
        /// </summary>
        public const string GMBKSTID = "GMBKSTID";

        /// <summary>
        /// GMSTMD.
        /// </summary>
        public const string GMSTMD = "GMSTMD";

        /// <summary>
        /// GMBSTN.
        /// </summary>
        public const string GMBSTN = "GMBSTN";

        /// <summary>
        /// GMGLBA.
        /// </summary>
        public const string GMGLBA = "GMGLBA";

        /// <summary>
        /// GMLIN.
        /// </summary>
        public const string GMLIN = "GMLIN";

        /// <summary>
        /// GMBSSEQ.
        /// </summary>
        public const string GMBSSEQ = "GMBSSEQ";

        /// <summary>
        /// GMSTLIN.
        /// </summary>
        public const string GMSTLIN = "GMSTLIN";

        /// <summary>
        /// GMRECCODE.
        /// </summary>
        public const string GMRECCODE = "GMRECCODE";

        /// <summary>
        /// GMANI.
        /// </summary>
        public const string GMANI = "GMANI";

        /// <summary>
        /// GMSTRN.
        /// </summary>
        public const string GMSTRN = "GMSTRN";

        /// <summary>
        /// GMCO.
        /// </summary>
        public const string GMCO = "GMCO";

        /// <summary>
        /// GMDEBE.
        /// </summary>
        public const string GMDEBE = "GMDEBE";

        /// <summary>
        /// GMCREE.
        /// </summary>
        public const string GMCREE = "GMCREE";

        /// <summary>
        /// GMCRCD.
        /// </summary>
        public const string GMCRCD = "GMCRCD";

        /// <summary>
        /// GMFDEB.
        /// </summary>
        public const string GMFDEB = "GMFDEB";

        /// <summary>
        /// GMFCRE.
        /// </summary>
        public const string GMFCRE = "GMFCRE";

        /// <summary>
        /// GMSTAM.
        /// </summary>
        public const string GMSTAM = "GMSTAM";

        /// <summary>
        /// GMCTAM.
        /// </summary>
        public const string GMCTAM = "GMCTAM";

        /// <summary>
        /// GMATXA.
        /// </summary>
        public const string GMATXA = "GMATXA";

        /// <summary>
        /// GMCTXA.
        /// </summary>
        public const string GMCTXA = "GMCTXA";

        /// <summary>
        /// GMEXR1.
        /// </summary>
        public const string GMEXR1 = "GMEXR1";

        /// <summary>
        /// GMTXA1.
        /// </summary>
        public const string GMTXA1 = "GMTXA1";

        /// <summary>
        /// GMRMK.
        /// </summary>
        public const string GMRMK = "GMRMK";

        /// <summary>
        /// GMCUSTSUP.
        /// </summary>
        public const string GMCUSTSUP = "GMCUSTSUP";

        /// <summary>
        /// GMCSTSPFLG.
        /// </summary>
        public const string GMCSTSPFLG = "GMCSTSPFLG";

        /// <summary>
        /// GMAN8.
        /// </summary>
        public const string GMAN8 = "GMAN8";

        /// <summary>
        /// GMKCO.
        /// </summary>
        public const string GMKCO = "GMKCO";

        /// <summary>
        /// GMDOC.
        /// </summary>
        public const string GMDOC = "GMDOC";

        /// <summary>
        /// GMDCT.
        /// </summary>
        public const string GMDCT = "GMDCT";

        /// <summary>
        /// GMSFX.
        /// </summary>
        public const string GMSFX = "GMSFX";

        /// <summary>
        /// GMDOCM.
        /// </summary>
        public const string GMDOCM = "GMDOCM";

        /// <summary>
        /// GMDGJ.
        /// </summary>
        public const string GMDGJ = "GMDGJ";

        /// <summary>
        /// GMDCTM.
        /// </summary>
        public const string GMDCTM = "GMDCTM";

        /// <summary>
        /// GMVLDT.
        /// </summary>
        public const string GMVLDT = "GMVLDT";

        /// <summary>
        /// GMOVDT.
        /// </summary>
        public const string GMOVDT = "GMOVDT";

        /// <summary>
        /// GMDMTJ.
        /// </summary>
        public const string GMDMTJ = "GMDMTJ";

        /// <summary>
        /// GMDMT.
        /// </summary>
        public const string GMDMT = "GMDMT";

        /// <summary>
        /// GMSBL.
        /// </summary>
        public const string GMSBL = "GMSBL";

        /// <summary>
        /// GMSBLT.
        /// </summary>
        public const string GMSBLT = "GMSBLT";

        /// <summary>
        /// GMR1.
        /// </summary>
        public const string GMR1 = "GMR1";

        /// <summary>
        /// GMR1O.
        /// </summary>
        public const string GMR1O = "GMR1O";

        /// <summary>
        /// GMABRF.
        /// </summary>
        public const string GMABRF = "GMABRF";

        /// <summary>
        /// GMSSTC.
        /// </summary>
        public const string GMSSTC = "GMSSTC";

        /// <summary>
        /// GMREASCODE.
        /// </summary>
        public const string GMREASCODE = "GMREASCODE";

        /// <summary>
        /// GMPYID.
        /// </summary>
        public const string GMPYID = "GMPYID";

        /// <summary>
        /// GMTRANT.
        /// </summary>
        public const string GMTRANT = "GMTRANT";

        /// <summary>
        /// GMSUBF9.
        /// </summary>
        public const string GMSUBF9 = "GMSUBF9";

        /// <summary>
        /// GMINFO1.
        /// </summary>
        public const string GMINFO1 = "GMINFO1";

        /// <summary>
        /// GMUSER.
        /// </summary>
        public const string GMUSER = "GMUSER";

        /// <summary>
        /// GMPID.
        /// </summary>
        public const string GMPID = "GMPID";

        /// <summary>
        /// GMJOBN.
        /// </summary>
        public const string GMJOBN = "GMJOBN";

        /// <summary>
        /// GMUPMJ.
        /// </summary>
        public const string GMUPMJ = "GMUPMJ";

        /// <summary>
        /// GMUPMT.
        /// </summary>
        public const string GMUPMT = "GMUPMT";

        /// <summary>
        /// GMCKNU.
        /// </summary>
        public const string GMCKNU = "GMCKNU";
    }

    /// <inheritdoc />
    public override string TableName => "F09617";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GMBKSTID", "GMBKSTID", JdeDataType.Numeric, null, true, true),
        new JdeField("GMSTMD", "GMSTMD", JdeDataType.Numeric),
        new JdeField("GMBSTN", "GMBSTN", JdeDataType.Numeric),
        new JdeField("GMGLBA", "GMGLBA", JdeDataType.String, 16),
        new JdeField("GMLIN", "GMLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("GMBSSEQ", "GMBSSEQ", JdeDataType.Numeric),
        new JdeField("GMSTLIN", "GMSTLIN", JdeDataType.Numeric),
        new JdeField("GMRECCODE", "GMRECCODE", JdeDataType.String, 2),
        new JdeField("GMANI", "GMANI", JdeDataType.String, 58),
        new JdeField("GMSTRN", "GMSTRN", JdeDataType.String, 6),
        new JdeField("GMCO", "GMCO", JdeDataType.String, 10),
        new JdeField("GMDEBE", "GMDEBE", JdeDataType.Numeric),
        new JdeField("GMCREE", "GMCREE", JdeDataType.Numeric),
        new JdeField("GMCRCD", "GMCRCD", JdeDataType.String, 6),
        new JdeField("GMFDEB", "GMFDEB", JdeDataType.Numeric),
        new JdeField("GMFCRE", "GMFCRE", JdeDataType.Numeric),
        new JdeField("GMSTAM", "GMSTAM", JdeDataType.Numeric),
        new JdeField("GMCTAM", "GMCTAM", JdeDataType.Numeric),
        new JdeField("GMATXA", "GMATXA", JdeDataType.Numeric),
        new JdeField("GMCTXA", "GMCTXA", JdeDataType.Numeric),
        new JdeField("GMEXR1", "GMEXR1", JdeDataType.String, 4),
        new JdeField("GMTXA1", "GMTXA1", JdeDataType.String, 20),
        new JdeField("GMRMK", "GMRMK", JdeDataType.String, 60),
        new JdeField("GMCUSTSUP", "GMCUSTSUP", JdeDataType.Numeric),
        new JdeField("GMCSTSPFLG", "GMCSTSPFLG", JdeDataType.String, 2),
        new JdeField("GMAN8", "GMAN8", JdeDataType.Numeric),
        new JdeField("GMKCO", "GMKCO", JdeDataType.String, 10),
        new JdeField("GMDOC", "GMDOC", JdeDataType.Numeric),
        new JdeField("GMDCT", "GMDCT", JdeDataType.String, 4),
        new JdeField("GMSFX", "GMSFX", JdeDataType.String, 6),
        new JdeField("GMDOCM", "GMDOCM", JdeDataType.Numeric),
        new JdeField("GMDGJ", "GMDGJ", JdeDataType.Numeric),
        new JdeField("GMDCTM", "GMDCTM", JdeDataType.String, 4),
        new JdeField("GMVLDT", "GMVLDT", JdeDataType.Numeric),
        new JdeField("GMOVDT", "GMOVDT", JdeDataType.Numeric),
        new JdeField("GMDMTJ", "GMDMTJ", JdeDataType.Numeric),
        new JdeField("GMDMT", "GMDMT", JdeDataType.Numeric),
        new JdeField("GMSBL", "GMSBL", JdeDataType.String, 16),
        new JdeField("GMSBLT", "GMSBLT", JdeDataType.String, 2),
        new JdeField("GMR1", "GMR1", JdeDataType.String, 16),
        new JdeField("GMR1O", "GMR1O", JdeDataType.String, 16),
        new JdeField("GMABRF", "GMABRF", JdeDataType.String, 2),
        new JdeField("GMSSTC", "GMSSTC", JdeDataType.String, 2),
        new JdeField("GMREASCODE", "GMREASCODE", JdeDataType.String, 6),
        new JdeField("GMPYID", "GMPYID", JdeDataType.Numeric),
        new JdeField("GMTRANT", "GMTRANT", JdeDataType.String, 8),
        new JdeField("GMSUBF9", "GMSUBF9", JdeDataType.String, 68),
        new JdeField("GMINFO1", "GMINFO1", JdeDataType.String, 780),
        new JdeField("GMUSER", "GMUSER", JdeDataType.String, 20),
        new JdeField("GMPID", "GMPID", JdeDataType.String, 20),
        new JdeField("GMJOBN", "GMJOBN", JdeDataType.String, 20),
        new JdeField("GMUPMJ", "GMUPMJ", JdeDataType.Numeric),
        new JdeField("GMUPMT", "GMUPMT", JdeDataType.Numeric),
        new JdeField("GMCKNU", "GMCKNU", JdeDataType.String, 50)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09617_0", "Primary Key on GMBKSTID, GMLIN", new[] { "GMBKSTID", "GMLIN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09617_2", "Unique Index on GMBSTN, GMGLBA, GMSTMD, GMLIN", new[] { "GMBSTN", "GMGLBA", "GMSTMD", "GMLIN" }, isUnique: true),
        new JdeIndex("F09617_3", "Index on SYS_NC00055$, SYS_NC00056$", new[] { "SYS_NC00055$", "SYS_NC00056$" }),
        new JdeIndex("F09617_4", "Index on GMBKSTID, GMRECCODE, GMSTRN", new[] { "GMBKSTID", "GMRECCODE", "GMSTRN" })
    };
}
