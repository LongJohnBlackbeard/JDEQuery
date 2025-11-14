using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15L403 - .
/// </summary>
public class F15L403 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SHDOCO.
        /// </summary>
        public const string SHDOCO = "SHDOCO";

        /// <summary>
        /// SHLSVR.
        /// </summary>
        public const string SHLSVR = "SHLSVR";

        /// <summary>
        /// SHEPCL.
        /// </summary>
        public const string SHEPCL = "SHEPCL";

        /// <summary>
        /// SHBCI.
        /// </summary>
        public const string SHBCI = "SHBCI";

        /// <summary>
        /// SHAID.
        /// </summary>
        public const string SHAID = "SHAID";

        /// <summary>
        /// SHMCU.
        /// </summary>
        public const string SHMCU = "SHMCU";

        /// <summary>
        /// SHRVNB.
        /// </summary>
        public const string SHRVNB = "SHRVNB";

        /// <summary>
        /// SHMCU2.
        /// </summary>
        public const string SHMCU2 = "SHMCU2";

        /// <summary>
        /// SHOBJ.
        /// </summary>
        public const string SHOBJ = "SHOBJ";

        /// <summary>
        /// SHSUB.
        /// </summary>
        public const string SHSUB = "SHSUB";

        /// <summary>
        /// SHSBL.
        /// </summary>
        public const string SHSBL = "SHSBL";

        /// <summary>
        /// SHSBLT.
        /// </summary>
        public const string SHSBLT = "SHSBLT";

        /// <summary>
        /// SHGUBSEX.
        /// </summary>
        public const string SHGUBSEX = "SHGUBSEX";

        /// <summary>
        /// SHSTGU.
        /// </summary>
        public const string SHSTGU = "SHSTGU";

        /// <summary>
        /// SHVPCTGU.
        /// </summary>
        public const string SHVPCTGU = "SHVPCTGU";

        /// <summary>
        /// SHOCTYPE.
        /// </summary>
        public const string SHOCTYPE = "SHOCTYPE";

        /// <summary>
        /// SHGUBSVA.
        /// </summary>
        public const string SHGUBSVA = "SHGUBSVA";

        /// <summary>
        /// SHGPCT.
        /// </summary>
        public const string SHGPCT = "SHGPCT";

        /// <summary>
        /// SHGUOCPC.
        /// </summary>
        public const string SHGUOCPC = "SHGUOCPC";

        /// <summary>
        /// SHGUFCTR.
        /// </summary>
        public const string SHGUFCTR = "SHGUFCTR";

        /// <summary>
        /// SHGUVARA.
        /// </summary>
        public const string SHGUVARA = "SHGUVARA";

        /// <summary>
        /// SHGUFIXA.
        /// </summary>
        public const string SHGUFIXA = "SHGUFIXA";

        /// <summary>
        /// SHGUACCT.
        /// </summary>
        public const string SHGUACCT = "SHGUACCT";

        /// <summary>
        /// SHGUAADJ.
        /// </summary>
        public const string SHGUAADJ = "SHGUAADJ";

        /// <summary>
        /// SHCRCD.
        /// </summary>
        public const string SHCRCD = "SHCRCD";

        /// <summary>
        /// SHGUPRF.
        /// </summary>
        public const string SHGUPRF = "SHGUPRF";

        /// <summary>
        /// SHEFTB.
        /// </summary>
        public const string SHEFTB = "SHEFTB";

        /// <summary>
        /// SHEFTE.
        /// </summary>
        public const string SHEFTE = "SHEFTE";

        /// <summary>
        /// SHUSER.
        /// </summary>
        public const string SHUSER = "SHUSER";

        /// <summary>
        /// SHPID.
        /// </summary>
        public const string SHPID = "SHPID";

        /// <summary>
        /// SHMKEY.
        /// </summary>
        public const string SHMKEY = "SHMKEY";

        /// <summary>
        /// SHUPMJ.
        /// </summary>
        public const string SHUPMJ = "SHUPMJ";

        /// <summary>
        /// SHUPMT.
        /// </summary>
        public const string SHUPMT = "SHUPMT";

        /// <summary>
        /// SHTORG.
        /// </summary>
        public const string SHTORG = "SHTORG";

        /// <summary>
        /// SHENTJ.
        /// </summary>
        public const string SHENTJ = "SHENTJ";

        /// <summary>
        /// SHCENTYR.
        /// </summary>
        public const string SHCENTYR = "SHCENTYR";

        /// <summary>
        /// SHUNIT.
        /// </summary>
        public const string SHUNIT = "SHUNIT";

        /// <summary>
        /// SHEPRD.
        /// </summary>
        public const string SHEPRD = "SHEPRD";

        /// <summary>
        /// SHSEQ.
        /// </summary>
        public const string SHSEQ = "SHSEQ";

        /// <summary>
        /// SHPN.
        /// </summary>
        public const string SHPN = "SHPN";

        /// <summary>
        /// SHGUAALT.
        /// </summary>
        public const string SHGUAALT = "SHGUAALT";
    }

    /// <inheritdoc />
    public override string TableName => "F15L403";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SHDOCO", "SHDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SHLSVR", "SHLSVR", JdeDataType.Numeric, null, true, true),
        new JdeField("SHEPCL", "SHEPCL", JdeDataType.String, 8),
        new JdeField("SHBCI", "SHBCI", JdeDataType.Numeric, null, true, true),
        new JdeField("SHAID", "SHAID", JdeDataType.String, 16, true, true),
        new JdeField("SHMCU", "SHMCU", JdeDataType.String, 24, true, true),
        new JdeField("SHRVNB", "SHRVNB", JdeDataType.Numeric, null, true, true),
        new JdeField("SHMCU2", "SHMCU2", JdeDataType.String, 24),
        new JdeField("SHOBJ", "SHOBJ", JdeDataType.String, 12),
        new JdeField("SHSUB", "SHSUB", JdeDataType.String, 16),
        new JdeField("SHSBL", "SHSBL", JdeDataType.String, 16, true, true),
        new JdeField("SHSBLT", "SHSBLT", JdeDataType.String, 2, true, true),
        new JdeField("SHGUBSEX", "SHGUBSEX", JdeDataType.Numeric),
        new JdeField("SHSTGU", "SHSTGU", JdeDataType.String, 2),
        new JdeField("SHVPCTGU", "SHVPCTGU", JdeDataType.Numeric),
        new JdeField("SHOCTYPE", "SHOCTYPE", JdeDataType.String, 2),
        new JdeField("SHGUBSVA", "SHGUBSVA", JdeDataType.Numeric),
        new JdeField("SHGPCT", "SHGPCT", JdeDataType.Numeric),
        new JdeField("SHGUOCPC", "SHGUOCPC", JdeDataType.Numeric),
        new JdeField("SHGUFCTR", "SHGUFCTR", JdeDataType.Numeric),
        new JdeField("SHGUVARA", "SHGUVARA", JdeDataType.Numeric),
        new JdeField("SHGUFIXA", "SHGUFIXA", JdeDataType.Numeric),
        new JdeField("SHGUACCT", "SHGUACCT", JdeDataType.Numeric),
        new JdeField("SHGUAADJ", "SHGUAADJ", JdeDataType.Numeric),
        new JdeField("SHCRCD", "SHCRCD", JdeDataType.String, 6),
        new JdeField("SHGUPRF", "SHGUPRF", JdeDataType.Numeric),
        new JdeField("SHEFTB", "SHEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("SHEFTE", "SHEFTE", JdeDataType.Numeric, null, true, true),
        new JdeField("SHUSER", "SHUSER", JdeDataType.String, 20),
        new JdeField("SHPID", "SHPID", JdeDataType.String, 20),
        new JdeField("SHMKEY", "SHMKEY", JdeDataType.String, 30),
        new JdeField("SHUPMJ", "SHUPMJ", JdeDataType.Numeric),
        new JdeField("SHUPMT", "SHUPMT", JdeDataType.Numeric),
        new JdeField("SHTORG", "SHTORG", JdeDataType.String, 20),
        new JdeField("SHENTJ", "SHENTJ", JdeDataType.Numeric),
        new JdeField("SHCENTYR", "SHCENTYR", JdeDataType.Numeric, null, true, true),
        new JdeField("SHUNIT", "SHUNIT", JdeDataType.String, 16, true, true),
        new JdeField("SHEPRD", "SHEPRD", JdeDataType.String, 20, true, true),
        new JdeField("SHSEQ", "SHSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("SHPN", "SHPN", JdeDataType.Numeric, null, true, true),
        new JdeField("SHGUAALT", "SHGUAALT", JdeDataType.String, 2, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15L403_0", "Primary Key on SHMCU, SHRVNB, SHUNIT, SHDOCO, SHLSVR, SHBCI, SHEPRD, SHSEQ, SHAID, SHSBL, SHSBLT, SHEFTB, SHEFTE, SHCENTYR, SHPN, SHGUAALT", new[] { "SHMCU", "SHRVNB", "SHUNIT", "SHDOCO", "SHLSVR", "SHBCI", "SHEPRD", "SHSEQ", "SHAID", "SHSBL", "SHSBLT", "SHEFTB", "SHEFTE", "SHCENTYR", "SHPN", "SHGUAALT" }, isUnique: true, isPrimaryKey: true)
    };
}
