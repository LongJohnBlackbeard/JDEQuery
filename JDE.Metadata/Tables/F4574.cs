using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4574 - .
/// </summary>
public class F4574 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KRUKID.
        /// </summary>
        public const string KRUKID = "KRUKID";

        /// <summary>
        /// KRKTPE.
        /// </summary>
        public const string KRKTPE = "KRKTPE";

        /// <summary>
        /// KRAPPRACT.
        /// </summary>
        public const string KRAPPRACT = "KRAPPRACT";

        /// <summary>
        /// KRACTN.
        /// </summary>
        public const string KRACTN = "KRACTN";

        /// <summary>
        /// KRITM.
        /// </summary>
        public const string KRITM = "KRITM";

        /// <summary>
        /// KRLITM.
        /// </summary>
        public const string KRLITM = "KRLITM";

        /// <summary>
        /// KRAITM.
        /// </summary>
        public const string KRAITM = "KRAITM";

        /// <summary>
        /// KRMCU.
        /// </summary>
        public const string KRMCU = "KRMCU";

        /// <summary>
        /// KRLOCN.
        /// </summary>
        public const string KRLOCN = "KRLOCN";

        /// <summary>
        /// KRLOTN.
        /// </summary>
        public const string KRLOTN = "KRLOTN";

        /// <summary>
        /// KRLOTG.
        /// </summary>
        public const string KRLOTG = "KRLOTG";

        /// <summary>
        /// KRFRMP.
        /// </summary>
        public const string KRFRMP = "KRFRMP";

        /// <summary>
        /// KRAN8.
        /// </summary>
        public const string KRAN8 = "KRAN8";

        /// <summary>
        /// KRIGID.
        /// </summary>
        public const string KRIGID = "KRIGID";

        /// <summary>
        /// KRCGID.
        /// </summary>
        public const string KRCGID = "KRCGID";

        /// <summary>
        /// KRCRCD.
        /// </summary>
        public const string KRCRCD = "KRCRCD";

        /// <summary>
        /// KRUOM.
        /// </summary>
        public const string KRUOM = "KRUOM";

        /// <summary>
        /// KREFTJ.
        /// </summary>
        public const string KREFTJ = "KREFTJ";

        /// <summary>
        /// KREXDJ.
        /// </summary>
        public const string KREXDJ = "KREXDJ";

        /// <summary>
        /// KRAST.
        /// </summary>
        public const string KRAST = "KRAST";

        /// <summary>
        /// KRATID.
        /// </summary>
        public const string KRATID = "KRATID";

        /// <summary>
        /// KRITMR.
        /// </summary>
        public const string KRITMR = "KRITMR";

        /// <summary>
        /// KRFRMN.
        /// </summary>
        public const string KRFRMN = "KRFRMN";

        /// <summary>
        /// KRVBT.
        /// </summary>
        public const string KRVBT = "KRVBT";

        /// <summary>
        /// KRRTF4.
        /// </summary>
        public const string KRRTF4 = "KRRTF4";

        /// <summary>
        /// KRTHRV.
        /// </summary>
        public const string KRTHRV = "KRTHRV";

        /// <summary>
        /// KRCATN.
        /// </summary>
        public const string KRCATN = "KRCATN";

        /// <summary>
        /// KRDMCT.
        /// </summary>
        public const string KRDMCT = "KRDMCT";

        /// <summary>
        /// KRCRDJ.
        /// </summary>
        public const string KRCRDJ = "KRCRDJ";

        /// <summary>
        /// KRTMCR.
        /// </summary>
        public const string KRTMCR = "KRTMCR";

        /// <summary>
        /// KRDMCS.
        /// </summary>
        public const string KRDMCS = "KRDMCS";

        /// <summary>
        /// KRAGSQ.
        /// </summary>
        public const string KRAGSQ = "KRAGSQ";

        /// <summary>
        /// KRXR01.
        /// </summary>
        public const string KRXR01 = "KRXR01";

        /// <summary>
        /// KRXR02.
        /// </summary>
        public const string KRXR02 = "KRXR02";

        /// <summary>
        /// KRXR03.
        /// </summary>
        public const string KRXR03 = "KRXR03";

        /// <summary>
        /// KRXR04.
        /// </summary>
        public const string KRXR04 = "KRXR04";

        /// <summary>
        /// KRXR05.
        /// </summary>
        public const string KRXR05 = "KRXR05";

        /// <summary>
        /// KRXR06.
        /// </summary>
        public const string KRXR06 = "KRXR06";

        /// <summary>
        /// KRXR07.
        /// </summary>
        public const string KRXR07 = "KRXR07";

        /// <summary>
        /// KRXR08.
        /// </summary>
        public const string KRXR08 = "KRXR08";

        /// <summary>
        /// KRXR09.
        /// </summary>
        public const string KRXR09 = "KRXR09";

        /// <summary>
        /// KRXR10.
        /// </summary>
        public const string KRXR10 = "KRXR10";

        /// <summary>
        /// KRXR11.
        /// </summary>
        public const string KRXR11 = "KRXR11";

        /// <summary>
        /// KRXR12.
        /// </summary>
        public const string KRXR12 = "KRXR12";

        /// <summary>
        /// KRXR13.
        /// </summary>
        public const string KRXR13 = "KRXR13";

        /// <summary>
        /// KRXR14.
        /// </summary>
        public const string KRXR14 = "KRXR14";

        /// <summary>
        /// KRXR15.
        /// </summary>
        public const string KRXR15 = "KRXR15";

        /// <summary>
        /// KRBFAF.
        /// </summary>
        public const string KRBFAF = "KRBFAF";

        /// <summary>
        /// KRDENT.
        /// </summary>
        public const string KRDENT = "KRDENT";

        /// <summary>
        /// KRRQDJ.
        /// </summary>
        public const string KRRQDJ = "KRRQDJ";

        /// <summary>
        /// KRAPRD.
        /// </summary>
        public const string KRAPRD = "KRAPRD";

        /// <summary>
        /// KRASN.
        /// </summary>
        public const string KRASN = "KRASN";

        /// <summary>
        /// KROSEQ.
        /// </summary>
        public const string KROSEQ = "KROSEQ";

        /// <summary>
        /// KRDOCO.
        /// </summary>
        public const string KRDOCO = "KRDOCO";

        /// <summary>
        /// KRDCTO.
        /// </summary>
        public const string KRDCTO = "KRDCTO";

        /// <summary>
        /// KRKCOO.
        /// </summary>
        public const string KRKCOO = "KRKCOO";

        /// <summary>
        /// KRSFXO.
        /// </summary>
        public const string KRSFXO = "KRSFXO";

        /// <summary>
        /// KRLNID.
        /// </summary>
        public const string KRLNID = "KRLNID";

        /// <summary>
        /// KRUPRC.
        /// </summary>
        public const string KRUPRC = "KRUPRC";

        /// <summary>
        /// KRACRD.
        /// </summary>
        public const string KRACRD = "KRACRD";

        /// <summary>
        /// KRLEDG.
        /// </summary>
        public const string KRLEDG = "KRLEDG";

        /// <summary>
        /// KRFVTR.
        /// </summary>
        public const string KRFVTR = "KRFVTR";

        /// <summary>
        /// KROGID.
        /// </summary>
        public const string KROGID = "KROGID";

        /// <summary>
        /// KRMNQ.
        /// </summary>
        public const string KRMNQ = "KRMNQ";

        /// <summary>
        /// KRUORG.
        /// </summary>
        public const string KRUORG = "KRUORG";

        /// <summary>
        /// KRANO.
        /// </summary>
        public const string KRANO = "KRANO";

        /// <summary>
        /// KRDTX1.
        /// </summary>
        public const string KRDTX1 = "KRDTX1";

        /// <summary>
        /// KRDTX2.
        /// </summary>
        public const string KRDTX2 = "KRDTX2";

        /// <summary>
        /// KRPRFR.
        /// </summary>
        public const string KRPRFR = "KRPRFR";

        /// <summary>
        /// KRHYID.
        /// </summary>
        public const string KRHYID = "KRHYID";

        /// <summary>
        /// KRTQTY.
        /// </summary>
        public const string KRTQTY = "KRTQTY";

        /// <summary>
        /// KRTAMT.
        /// </summary>
        public const string KRTAMT = "KRTAMT";

        /// <summary>
        /// KROBJ.
        /// </summary>
        public const string KROBJ = "KROBJ";

        /// <summary>
        /// KRSUB.
        /// </summary>
        public const string KRSUB = "KRSUB";

        /// <summary>
        /// KRPDP.
        /// </summary>
        public const string KRPDP = "KRPDP";

        /// <summary>
        /// KRCO.
        /// </summary>
        public const string KRCO = "KRCO";

        /// <summary>
        /// KRSEQ.
        /// </summary>
        public const string KRSEQ = "KRSEQ";

        /// <summary>
        /// KRPSR.
        /// </summary>
        public const string KRPSR = "KRPSR";

        /// <summary>
        /// KRPSRY.
        /// </summary>
        public const string KRPSRY = "KRPSRY";

        /// <summary>
        /// KRDTO.
        /// </summary>
        public const string KRDTO = "KRDTO";

        /// <summary>
        /// KRGPTY.
        /// </summary>
        public const string KRGPTY = "KRGPTY";

        /// <summary>
        /// KRGPC.
        /// </summary>
        public const string KRGPC = "KRGPC";

        /// <summary>
        /// KRCPGP.
        /// </summary>
        public const string KRCPGP = "KRCPGP";

        /// <summary>
        /// KRCGP1.
        /// </summary>
        public const string KRCGP1 = "KRCGP1";

        /// <summary>
        /// KRCGP2.
        /// </summary>
        public const string KRCGP2 = "KRCGP2";

        /// <summary>
        /// KRCGP3.
        /// </summary>
        public const string KRCGP3 = "KRCGP3";

        /// <summary>
        /// KRCGP4.
        /// </summary>
        public const string KRCGP4 = "KRCGP4";

        /// <summary>
        /// KRPRGR.
        /// </summary>
        public const string KRPRGR = "KRPRGR";

        /// <summary>
        /// KRIGP1.
        /// </summary>
        public const string KRIGP1 = "KRIGP1";

        /// <summary>
        /// KRIGP2.
        /// </summary>
        public const string KRIGP2 = "KRIGP2";

        /// <summary>
        /// KRIGP3.
        /// </summary>
        public const string KRIGP3 = "KRIGP3";

        /// <summary>
        /// KRIGP4.
        /// </summary>
        public const string KRIGP4 = "KRIGP4";

        /// <summary>
        /// KRJOBN.
        /// </summary>
        public const string KRJOBN = "KRJOBN";

        /// <summary>
        /// KRUSER.
        /// </summary>
        public const string KRUSER = "KRUSER";

        /// <summary>
        /// KRPID.
        /// </summary>
        public const string KRPID = "KRPID";

        /// <summary>
        /// KRTDAY.
        /// </summary>
        public const string KRTDAY = "KRTDAY";

        /// <summary>
        /// KRUPMJ.
        /// </summary>
        public const string KRUPMJ = "KRUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F4574";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KRUKID", "KRUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("KRKTPE", "KRKTPE", JdeDataType.String, 2),
        new JdeField("KRAPPRACT", "KRAPPRACT", JdeDataType.String, 2),
        new JdeField("KRACTN", "KRACTN", JdeDataType.String, 2),
        new JdeField("KRITM", "KRITM", JdeDataType.Numeric),
        new JdeField("KRLITM", "KRLITM", JdeDataType.String, 50),
        new JdeField("KRAITM", "KRAITM", JdeDataType.String, 50),
        new JdeField("KRMCU", "KRMCU", JdeDataType.String, 24),
        new JdeField("KRLOCN", "KRLOCN", JdeDataType.String, 40),
        new JdeField("KRLOTN", "KRLOTN", JdeDataType.String, 60),
        new JdeField("KRLOTG", "KRLOTG", JdeDataType.String, 6),
        new JdeField("KRFRMP", "KRFRMP", JdeDataType.Numeric),
        new JdeField("KRAN8", "KRAN8", JdeDataType.Numeric),
        new JdeField("KRIGID", "KRIGID", JdeDataType.Numeric),
        new JdeField("KRCGID", "KRCGID", JdeDataType.Numeric),
        new JdeField("KRCRCD", "KRCRCD", JdeDataType.String, 6),
        new JdeField("KRUOM", "KRUOM", JdeDataType.String, 4),
        new JdeField("KREFTJ", "KREFTJ", JdeDataType.Numeric),
        new JdeField("KREXDJ", "KREXDJ", JdeDataType.Numeric),
        new JdeField("KRAST", "KRAST", JdeDataType.String, 16),
        new JdeField("KRATID", "KRATID", JdeDataType.Numeric),
        new JdeField("KRITMR", "KRITMR", JdeDataType.Numeric),
        new JdeField("KRFRMN", "KRFRMN", JdeDataType.String, 20),
        new JdeField("KRVBT", "KRVBT", JdeDataType.String, 20),
        new JdeField("KRRTF4", "KRRTF4", JdeDataType.String, 16),
        new JdeField("KRTHRV", "KRTHRV", JdeDataType.Numeric),
        new JdeField("KRCATN", "KRCATN", JdeDataType.String, 16),
        new JdeField("KRDMCT", "KRDMCT", JdeDataType.String, 24),
        new JdeField("KRCRDJ", "KRCRDJ", JdeDataType.Numeric),
        new JdeField("KRTMCR", "KRTMCR", JdeDataType.Numeric),
        new JdeField("KRDMCS", "KRDMCS", JdeDataType.Numeric),
        new JdeField("KRAGSQ", "KRAGSQ", JdeDataType.Numeric),
        new JdeField("KRXR01", "KRXR01", JdeDataType.String, 2),
        new JdeField("KRXR02", "KRXR02", JdeDataType.String, 2),
        new JdeField("KRXR03", "KRXR03", JdeDataType.String, 2),
        new JdeField("KRXR04", "KRXR04", JdeDataType.String, 2),
        new JdeField("KRXR05", "KRXR05", JdeDataType.String, 2),
        new JdeField("KRXR06", "KRXR06", JdeDataType.String, 20),
        new JdeField("KRXR07", "KRXR07", JdeDataType.String, 20),
        new JdeField("KRXR08", "KRXR08", JdeDataType.String, 20),
        new JdeField("KRXR09", "KRXR09", JdeDataType.String, 20),
        new JdeField("KRXR10", "KRXR10", JdeDataType.String, 20),
        new JdeField("KRXR11", "KRXR11", JdeDataType.Numeric),
        new JdeField("KRXR12", "KRXR12", JdeDataType.Numeric),
        new JdeField("KRXR13", "KRXR13", JdeDataType.Numeric),
        new JdeField("KRXR14", "KRXR14", JdeDataType.Numeric),
        new JdeField("KRXR15", "KRXR15", JdeDataType.Numeric),
        new JdeField("KRBFAF", "KRBFAF", JdeDataType.String, 2, true, true),
        new JdeField("KRDENT", "KRDENT", JdeDataType.Numeric),
        new JdeField("KRRQDJ", "KRRQDJ", JdeDataType.Numeric),
        new JdeField("KRAPRD", "KRAPRD", JdeDataType.Numeric),
        new JdeField("KRASN", "KRASN", JdeDataType.String, 16),
        new JdeField("KROSEQ", "KROSEQ", JdeDataType.Numeric),
        new JdeField("KRDOCO", "KRDOCO", JdeDataType.Numeric),
        new JdeField("KRDCTO", "KRDCTO", JdeDataType.String, 4),
        new JdeField("KRKCOO", "KRKCOO", JdeDataType.String, 10),
        new JdeField("KRSFXO", "KRSFXO", JdeDataType.String, 6),
        new JdeField("KRLNID", "KRLNID", JdeDataType.Numeric),
        new JdeField("KRUPRC", "KRUPRC", JdeDataType.Numeric),
        new JdeField("KRACRD", "KRACRD", JdeDataType.Numeric),
        new JdeField("KRLEDG", "KRLEDG", JdeDataType.String, 4),
        new JdeField("KRFVTR", "KRFVTR", JdeDataType.Numeric),
        new JdeField("KROGID", "KROGID", JdeDataType.Numeric),
        new JdeField("KRMNQ", "KRMNQ", JdeDataType.Numeric),
        new JdeField("KRUORG", "KRUORG", JdeDataType.Numeric),
        new JdeField("KRANO", "KRANO", JdeDataType.Numeric),
        new JdeField("KRDTX1", "KRDTX1", JdeDataType.String, 150),
        new JdeField("KRDTX2", "KRDTX2", JdeDataType.String, 150),
        new JdeField("KRPRFR", "KRPRFR", JdeDataType.String, 4),
        new JdeField("KRHYID", "KRHYID", JdeDataType.String, 20),
        new JdeField("KRTQTY", "KRTQTY", JdeDataType.Numeric),
        new JdeField("KRTAMT", "KRTAMT", JdeDataType.Numeric),
        new JdeField("KROBJ", "KROBJ", JdeDataType.String, 12),
        new JdeField("KRSUB", "KRSUB", JdeDataType.String, 16),
        new JdeField("KRPDP", "KRPDP", JdeDataType.String, 6),
        new JdeField("KRCO", "KRCO", JdeDataType.String, 10),
        new JdeField("KRSEQ", "KRSEQ", JdeDataType.Numeric),
        new JdeField("KRPSR", "KRPSR", JdeDataType.String, 24),
        new JdeField("KRPSRY", "KRPSRY", JdeDataType.String, 4),
        new JdeField("KRDTO", "KRDTO", JdeDataType.String, 2),
        new JdeField("KRGPTY", "KRGPTY", JdeDataType.String, 2),
        new JdeField("KRGPC", "KRGPC", JdeDataType.String, 16),
        new JdeField("KRCPGP", "KRCPGP", JdeDataType.String, 16),
        new JdeField("KRCGP1", "KRCGP1", JdeDataType.String, 6),
        new JdeField("KRCGP2", "KRCGP2", JdeDataType.String, 6),
        new JdeField("KRCGP3", "KRCGP3", JdeDataType.String, 6),
        new JdeField("KRCGP4", "KRCGP4", JdeDataType.String, 6),
        new JdeField("KRPRGR", "KRPRGR", JdeDataType.String, 16),
        new JdeField("KRIGP1", "KRIGP1", JdeDataType.String, 12),
        new JdeField("KRIGP2", "KRIGP2", JdeDataType.String, 12),
        new JdeField("KRIGP3", "KRIGP3", JdeDataType.String, 12),
        new JdeField("KRIGP4", "KRIGP4", JdeDataType.String, 12),
        new JdeField("KRJOBN", "KRJOBN", JdeDataType.String, 20),
        new JdeField("KRUSER", "KRUSER", JdeDataType.String, 20),
        new JdeField("KRPID", "KRPID", JdeDataType.String, 20),
        new JdeField("KRTDAY", "KRTDAY", JdeDataType.Numeric),
        new JdeField("KRUPMJ", "KRUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4574_0", "Primary Key on KRUKID, KRBFAF", new[] { "KRUKID", "KRBFAF" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4574_2", "Index on KRKTPE, KRITM, KRMCU, KRLOCN, KRLOTN, KRAN8, KRIGID, KRCGID, KRLOTG, KRFRMP, KRCRCD, KRUOM, KREXDJ, SYS_NC00098$, SYS_NC00099$", new[] { "KRKTPE", "KRITM", "KRMCU", "KRLOCN", "KRLOTN", "KRAN8", "KRIGID", "KRCGID", "KRLOTG", "KRFRMP", "KRCRCD", "KRUOM", "KREXDJ", "SYS_NC00098$", "SYS_NC00099$" }),
        new JdeIndex("F4574_3", "Index on KRKTPE, KRAST, SYS_NC00098$, SYS_NC00099$", new[] { "KRKTPE", "KRAST", "SYS_NC00098$", "SYS_NC00099$" }),
        new JdeIndex("F4574_4", "Index on KRKTPE, KRAST, KRITM, KRAN8, KRIGID, KRCGID, KROGID, KRCRCD, KRUOM, KRMNQ, KREXDJ, SYS_NC00098$, SYS_NC00099$", new[] { "KRKTPE", "KRAST", "KRITM", "KRAN8", "KRIGID", "KRCGID", "KROGID", "KRCRCD", "KRUOM", "KRMNQ", "KREXDJ", "SYS_NC00098$", "SYS_NC00099$" }),
        new JdeIndex("F4574_5", "Index on KRKTPE, KRAST, KRATID, KRLITM, SYS_NC00098$, SYS_NC00099$", new[] { "KRKTPE", "KRAST", "KRATID", "KRLITM", "SYS_NC00098$", "SYS_NC00099$" }),
        new JdeIndex("F4574_6", "Index on KRKTPE, KRVBT, SYS_NC00100$, SYS_NC00098$, SYS_NC00099$", new[] { "KRKTPE", "KRVBT", "SYS_NC00100$", "SYS_NC00098$", "SYS_NC00099$" }),
        new JdeIndex("F4574_7", "Index on KRKTPE, KRFRMN, SYS_NC00098$, SYS_NC00099$", new[] { "KRKTPE", "KRFRMN", "SYS_NC00098$", "SYS_NC00099$" }),
        new JdeIndex("F4574_8", "Index on KRKTPE, KRAST, KRAN8, KRITM, KRIGID, KRCGID, KREFTJ, KRTHRV, SYS_NC00098$, SYS_NC00099$", new[] { "KRKTPE", "KRAST", "KRAN8", "KRITM", "KRIGID", "KRCGID", "KREFTJ", "KRTHRV", "SYS_NC00098$", "SYS_NC00099$" })
    };
}
