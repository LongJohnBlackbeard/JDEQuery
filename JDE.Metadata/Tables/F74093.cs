using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74093 - .
/// </summary>
public class F74093 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HCCO.
        /// </summary>
        public const string HCCO = "HCCO";

        /// <summary>
        /// HCMCU.
        /// </summary>
        public const string HCMCU = "HCMCU";

        /// <summary>
        /// HCOBJ.
        /// </summary>
        public const string HCOBJ = "HCOBJ";

        /// <summary>
        /// HCSUB.
        /// </summary>
        public const string HCSUB = "HCSUB";

        /// <summary>
        /// HCDCTO.
        /// </summary>
        public const string HCDCTO = "HCDCTO";

        /// <summary>
        /// HCDOCO.
        /// </summary>
        public const string HCDOCO = "HCDOCO";

        /// <summary>
        /// HCSFXO.
        /// </summary>
        public const string HCSFXO = "HCSFXO";

        /// <summary>
        /// HCLNID.
        /// </summary>
        public const string HCLNID = "HCLNID";

        /// <summary>
        /// HCAN8.
        /// </summary>
        public const string HCAN8 = "HCAN8";

        /// <summary>
        /// HCECST.
        /// </summary>
        public const string HCECST = "HCECST";

        /// <summary>
        /// HCAEXP.
        /// </summary>
        public const string HCAEXP = "HCAEXP";

        /// <summary>
        /// HCATXN.
        /// </summary>
        public const string HCATXN = "HCATXN";

        /// <summary>
        /// HCATXA.
        /// </summary>
        public const string HCATXA = "HCATXA";

        /// <summary>
        /// HCSTAM.
        /// </summary>
        public const string HCSTAM = "HCSTAM";

        /// <summary>
        /// HCTXA1.
        /// </summary>
        public const string HCTXA1 = "HCTXA1";

        /// <summary>
        /// HCEXR1.
        /// </summary>
        public const string HCEXR1 = "HCEXR1";

        /// <summary>
        /// HCEXR2.
        /// </summary>
        public const string HCEXR2 = "HCEXR2";

        /// <summary>
        /// HCTRDJ.
        /// </summary>
        public const string HCTRDJ = "HCTRDJ";

        /// <summary>
        /// HCDGL.
        /// </summary>
        public const string HCDGL = "HCDGL";

        /// <summary>
        /// HCDSVJ.
        /// </summary>
        public const string HCDSVJ = "HCDSVJ";

        /// <summary>
        /// HCTX.
        /// </summary>
        public const string HCTX = "HCTX";

        /// <summary>
        /// HCITM.
        /// </summary>
        public const string HCITM = "HCITM";

        /// <summary>
        /// HCLITM.
        /// </summary>
        public const string HCLITM = "HCLITM";

        /// <summary>
        /// HCAITM.
        /// </summary>
        public const string HCAITM = "HCAITM";

        /// <summary>
        /// HCLNTY.
        /// </summary>
        public const string HCLNTY = "HCLNTY";

        /// <summary>
        /// HCUORG.
        /// </summary>
        public const string HCUORG = "HCUORG";

        /// <summary>
        /// HCUOM.
        /// </summary>
        public const string HCUOM = "HCUOM";

        /// <summary>
        /// HCFVTY.
        /// </summary>
        public const string HCFVTY = "HCFVTY";

        /// <summary>
        /// HCTA1.
        /// </summary>
        public const string HCTA1 = "HCTA1";

        /// <summary>
        /// HCTXR1.
        /// </summary>
        public const string HCTXR1 = "HCTXR1";

        /// <summary>
        /// HCTA2.
        /// </summary>
        public const string HCTA2 = "HCTA2";

        /// <summary>
        /// HCTXR2.
        /// </summary>
        public const string HCTXR2 = "HCTXR2";

        /// <summary>
        /// HCTA3.
        /// </summary>
        public const string HCTA3 = "HCTA3";

        /// <summary>
        /// HCTXR3.
        /// </summary>
        public const string HCTXR3 = "HCTXR3";

        /// <summary>
        /// HCTA4.
        /// </summary>
        public const string HCTA4 = "HCTA4";

        /// <summary>
        /// HCTXR4.
        /// </summary>
        public const string HCTXR4 = "HCTXR4";

        /// <summary>
        /// HCTA5.
        /// </summary>
        public const string HCTA5 = "HCTA5";

        /// <summary>
        /// HCTXR5.
        /// </summary>
        public const string HCTXR5 = "HCTXR5";

        /// <summary>
        /// HCSTA1.
        /// </summary>
        public const string HCSTA1 = "HCSTA1";

        /// <summary>
        /// HCSTA2.
        /// </summary>
        public const string HCSTA2 = "HCSTA2";

        /// <summary>
        /// HCSTA3.
        /// </summary>
        public const string HCSTA3 = "HCSTA3";

        /// <summary>
        /// HCSTA4.
        /// </summary>
        public const string HCSTA4 = "HCSTA4";

        /// <summary>
        /// HCSTA5.
        /// </summary>
        public const string HCSTA5 = "HCSTA5";

        /// <summary>
        /// HCPRT1.
        /// </summary>
        public const string HCPRT1 = "HCPRT1";

        /// <summary>
        /// HCOVTX.
        /// </summary>
        public const string HCOVTX = "HCOVTX";

        /// <summary>
        /// HCTXVA.
        /// </summary>
        public const string HCTXVA = "HCTXVA";

        /// <summary>
        /// HCTXVR.
        /// </summary>
        public const string HCTXVR = "HCTXVR";

        /// <summary>
        /// HCPOST.
        /// </summary>
        public const string HCPOST = "HCPOST";

        /// <summary>
        /// HCICU.
        /// </summary>
        public const string HCICU = "HCICU";

        /// <summary>
        /// HCICUT.
        /// </summary>
        public const string HCICUT = "HCICUT";

        /// <summary>
        /// HCGDVL.
        /// </summary>
        public const string HCGDVL = "HCGDVL";

        /// <summary>
        /// HCCRCD.
        /// </summary>
        public const string HCCRCD = "HCCRCD";

        /// <summary>
        /// HCCRR.
        /// </summary>
        public const string HCCRR = "HCCRR";

        /// <summary>
        /// HCSQNO.
        /// </summary>
        public const string HCSQNO = "HCSQNO";

        /// <summary>
        /// HCAG.
        /// </summary>
        public const string HCAG = "HCAG";

        /// <summary>
        /// HCUPMJ.
        /// </summary>
        public const string HCUPMJ = "HCUPMJ";

        /// <summary>
        /// HCUPMT.
        /// </summary>
        public const string HCUPMT = "HCUPMT";

        /// <summary>
        /// HCPID.
        /// </summary>
        public const string HCPID = "HCPID";

        /// <summary>
        /// HCUSER.
        /// </summary>
        public const string HCUSER = "HCUSER";

        /// <summary>
        /// HCJOBN.
        /// </summary>
        public const string HCJOBN = "HCJOBN";

        /// <summary>
        /// HCAPD.
        /// </summary>
        public const string HCAPD = "HCAPD";

        /// <summary>
        /// HCTAXE.
        /// </summary>
        public const string HCTAXE = "HCTAXE";

        /// <summary>
        /// HCDOC.
        /// </summary>
        public const string HCDOC = "HCDOC";

        /// <summary>
        /// HCKCOO.
        /// </summary>
        public const string HCKCOO = "HCKCOO";

        /// <summary>
        /// HCITRG.
        /// </summary>
        public const string HCITRG = "HCITRG";

        /// <summary>
        /// HCTCRG.
        /// </summary>
        public const string HCTCRG = "HCTCRG";

        /// <summary>
        /// HCBCRC.
        /// </summary>
        public const string HCBCRC = "HCBCRC";

        /// <summary>
        /// HCNRTA.
        /// </summary>
        public const string HCNRTA = "HCNRTA";
    }

    /// <inheritdoc />
    public override string TableName => "F74093";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HCCO", "HCCO", JdeDataType.String, 10),
        new JdeField("HCMCU", "HCMCU", JdeDataType.String, 24),
        new JdeField("HCOBJ", "HCOBJ", JdeDataType.String, 12),
        new JdeField("HCSUB", "HCSUB", JdeDataType.String, 16),
        new JdeField("HCDCTO", "HCDCTO", JdeDataType.String, 4),
        new JdeField("HCDOCO", "HCDOCO", JdeDataType.Numeric),
        new JdeField("HCSFXO", "HCSFXO", JdeDataType.String, 6),
        new JdeField("HCLNID", "HCLNID", JdeDataType.Numeric),
        new JdeField("HCAN8", "HCAN8", JdeDataType.Numeric),
        new JdeField("HCECST", "HCECST", JdeDataType.Numeric),
        new JdeField("HCAEXP", "HCAEXP", JdeDataType.Numeric),
        new JdeField("HCATXN", "HCATXN", JdeDataType.Numeric),
        new JdeField("HCATXA", "HCATXA", JdeDataType.Numeric),
        new JdeField("HCSTAM", "HCSTAM", JdeDataType.Numeric),
        new JdeField("HCTXA1", "HCTXA1", JdeDataType.String, 20, true, true),
        new JdeField("HCEXR1", "HCEXR1", JdeDataType.String, 4),
        new JdeField("HCEXR2", "HCEXR2", JdeDataType.String, 4),
        new JdeField("HCTRDJ", "HCTRDJ", JdeDataType.Numeric),
        new JdeField("HCDGL", "HCDGL", JdeDataType.Numeric, null, true, true),
        new JdeField("HCDSVJ", "HCDSVJ", JdeDataType.Numeric),
        new JdeField("HCTX", "HCTX", JdeDataType.String, 2),
        new JdeField("HCITM", "HCITM", JdeDataType.Numeric, null, true, true),
        new JdeField("HCLITM", "HCLITM", JdeDataType.String, 50),
        new JdeField("HCAITM", "HCAITM", JdeDataType.String, 50),
        new JdeField("HCLNTY", "HCLNTY", JdeDataType.String, 4),
        new JdeField("HCUORG", "HCUORG", JdeDataType.Numeric),
        new JdeField("HCUOM", "HCUOM", JdeDataType.String, 4),
        new JdeField("HCFVTY", "HCFVTY", JdeDataType.String, 2),
        new JdeField("HCTA1", "HCTA1", JdeDataType.Numeric),
        new JdeField("HCTXR1", "HCTXR1", JdeDataType.Numeric),
        new JdeField("HCTA2", "HCTA2", JdeDataType.Numeric),
        new JdeField("HCTXR2", "HCTXR2", JdeDataType.Numeric),
        new JdeField("HCTA3", "HCTA3", JdeDataType.Numeric),
        new JdeField("HCTXR3", "HCTXR3", JdeDataType.Numeric),
        new JdeField("HCTA4", "HCTA4", JdeDataType.Numeric),
        new JdeField("HCTXR4", "HCTXR4", JdeDataType.Numeric),
        new JdeField("HCTA5", "HCTA5", JdeDataType.Numeric),
        new JdeField("HCTXR5", "HCTXR5", JdeDataType.Numeric),
        new JdeField("HCSTA1", "HCSTA1", JdeDataType.Numeric),
        new JdeField("HCSTA2", "HCSTA2", JdeDataType.Numeric),
        new JdeField("HCSTA3", "HCSTA3", JdeDataType.Numeric),
        new JdeField("HCSTA4", "HCSTA4", JdeDataType.Numeric),
        new JdeField("HCSTA5", "HCSTA5", JdeDataType.Numeric),
        new JdeField("HCPRT1", "HCPRT1", JdeDataType.String, 2),
        new JdeField("HCOVTX", "HCOVTX", JdeDataType.String, 2),
        new JdeField("HCTXVA", "HCTXVA", JdeDataType.Numeric),
        new JdeField("HCTXVR", "HCTXVR", JdeDataType.Numeric),
        new JdeField("HCPOST", "HCPOST", JdeDataType.String, 2),
        new JdeField("HCICU", "HCICU", JdeDataType.Numeric),
        new JdeField("HCICUT", "HCICUT", JdeDataType.String, 4),
        new JdeField("HCGDVL", "HCGDVL", JdeDataType.Numeric),
        new JdeField("HCCRCD", "HCCRCD", JdeDataType.String, 6),
        new JdeField("HCCRR", "HCCRR", JdeDataType.Numeric),
        new JdeField("HCSQNO", "HCSQNO", JdeDataType.Numeric),
        new JdeField("HCAG", "HCAG", JdeDataType.Numeric),
        new JdeField("HCUPMJ", "HCUPMJ", JdeDataType.Numeric),
        new JdeField("HCUPMT", "HCUPMT", JdeDataType.Numeric),
        new JdeField("HCPID", "HCPID", JdeDataType.String, 20),
        new JdeField("HCUSER", "HCUSER", JdeDataType.String, 20),
        new JdeField("HCJOBN", "HCJOBN", JdeDataType.String, 20),
        new JdeField("HCAPD", "HCAPD", JdeDataType.Numeric),
        new JdeField("HCTAXE", "HCTAXE", JdeDataType.Numeric),
        new JdeField("HCDOC", "HCDOC", JdeDataType.Numeric),
        new JdeField("HCKCOO", "HCKCOO", JdeDataType.String, 10),
        new JdeField("HCITRG", "HCITRG", JdeDataType.String, 4, true, true),
        new JdeField("HCTCRG", "HCTCRG", JdeDataType.String, 4, true, true),
        new JdeField("HCBCRC", "HCBCRC", JdeDataType.String, 6),
        new JdeField("HCNRTA", "HCNRTA", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74093_0", "Primary Key on HCTCRG, HCITRG, HCTXA1, HCITM, HCDGL", new[] { "HCTCRG", "HCITRG", "HCTXA1", "HCITM", "HCDGL" }, isUnique: true, isPrimaryKey: true)
    };
}
