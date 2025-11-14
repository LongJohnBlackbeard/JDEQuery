using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H711P - .
/// </summary>
public class F44H711P : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TPDOCO.
        /// </summary>
        public const string TPDOCO = "TPDOCO";

        /// <summary>
        /// TPDCT.
        /// </summary>
        public const string TPDCT = "TPDCT";

        /// <summary>
        /// TPKCOO.
        /// </summary>
        public const string TPKCOO = "TPKCOO";

        /// <summary>
        /// TPSFXO.
        /// </summary>
        public const string TPSFXO = "TPSFXO";

        /// <summary>
        /// TPLNID.
        /// </summary>
        public const string TPLNID = "TPLNID";

        /// <summary>
        /// TPAN8.
        /// </summary>
        public const string TPAN8 = "TPAN8";

        /// <summary>
        /// TPHBAREA.
        /// </summary>
        public const string TPHBAREA = "TPHBAREA";

        /// <summary>
        /// TPHBMCUS.
        /// </summary>
        public const string TPHBMCUS = "TPHBMCUS";

        /// <summary>
        /// TPHBLOT.
        /// </summary>
        public const string TPHBLOT = "TPHBLOT";

        /// <summary>
        /// TPOMCU.
        /// </summary>
        public const string TPOMCU = "TPOMCU";

        /// <summary>
        /// TPCPHASE.
        /// </summary>
        public const string TPCPHASE = "TPCPHASE";

        /// <summary>
        /// TPOBJ.
        /// </summary>
        public const string TPOBJ = "TPOBJ";

        /// <summary>
        /// TPSUB.
        /// </summary>
        public const string TPSUB = "TPSUB";

        /// <summary>
        /// TPOPTION.
        /// </summary>
        public const string TPOPTION = "TPOPTION";

        /// <summary>
        /// TPDGL.
        /// </summary>
        public const string TPDGL = "TPDGL";

        /// <summary>
        /// TPUORG.
        /// </summary>
        public const string TPUORG = "TPUORG";

        /// <summary>
        /// TPPRRC.
        /// </summary>
        public const string TPPRRC = "TPPRRC";

        /// <summary>
        /// TPAEXP.
        /// </summary>
        public const string TPAEXP = "TPAEXP";

        /// <summary>
        /// TPITM.
        /// </summary>
        public const string TPITM = "TPITM";

        /// <summary>
        /// TPLITM.
        /// </summary>
        public const string TPLITM = "TPLITM";

        /// <summary>
        /// TPAITM.
        /// </summary>
        public const string TPAITM = "TPAITM";

        /// <summary>
        /// TPUOM.
        /// </summary>
        public const string TPUOM = "TPUOM";

        /// <summary>
        /// TPOORN.
        /// </summary>
        public const string TPOORN = "TPOORN";

        /// <summary>
        /// TPOCTO.
        /// </summary>
        public const string TPOCTO = "TPOCTO";

        /// <summary>
        /// TPOKCO.
        /// </summary>
        public const string TPOKCO = "TPOKCO";

        /// <summary>
        /// TPOGNO.
        /// </summary>
        public const string TPOGNO = "TPOGNO";

        /// <summary>
        /// TPOSFX.
        /// </summary>
        public const string TPOSFX = "TPOSFX";

        /// <summary>
        /// TPDESC.
        /// </summary>
        public const string TPDESC = "TPDESC";

        /// <summary>
        /// TPVR01.
        /// </summary>
        public const string TPVR01 = "TPVR01";

        /// <summary>
        /// TPVR02.
        /// </summary>
        public const string TPVR02 = "TPVR02";

        /// <summary>
        /// TPDSC1.
        /// </summary>
        public const string TPDSC1 = "TPDSC1";

        /// <summary>
        /// TPDSC2.
        /// </summary>
        public const string TPDSC2 = "TPDSC2";

        /// <summary>
        /// TPTX.
        /// </summary>
        public const string TPTX = "TPTX";

        /// <summary>
        /// TPEXR1.
        /// </summary>
        public const string TPEXR1 = "TPEXR1";

        /// <summary>
        /// TPTXA1.
        /// </summary>
        public const string TPTXA1 = "TPTXA1";

        /// <summary>
        /// TPANBY.
        /// </summary>
        public const string TPANBY = "TPANBY";

        /// <summary>
        /// TPPDP1.
        /// </summary>
        public const string TPPDP1 = "TPPDP1";

        /// <summary>
        /// TPPDP2.
        /// </summary>
        public const string TPPDP2 = "TPPDP2";

        /// <summary>
        /// TPPDP3.
        /// </summary>
        public const string TPPDP3 = "TPPDP3";

        /// <summary>
        /// TPPDP4.
        /// </summary>
        public const string TPPDP4 = "TPPDP4";

        /// <summary>
        /// TPPDP5.
        /// </summary>
        public const string TPPDP5 = "TPPDP5";

        /// <summary>
        /// TPF1T.
        /// </summary>
        public const string TPF1T = "TPF1T";

        /// <summary>
        /// TPF2T.
        /// </summary>
        public const string TPF2T = "TPF2T";

        /// <summary>
        /// TPF3T.
        /// </summary>
        public const string TPF3T = "TPF3T";

        /// <summary>
        /// TPHBST1.
        /// </summary>
        public const string TPHBST1 = "TPHBST1";

        /// <summary>
        /// TPHBST2.
        /// </summary>
        public const string TPHBST2 = "TPHBST2";

        /// <summary>
        /// TPHBST3.
        /// </summary>
        public const string TPHBST3 = "TPHBST3";

        /// <summary>
        /// TPHBST4.
        /// </summary>
        public const string TPHBST4 = "TPHBST4";

        /// <summary>
        /// TPHBST5.
        /// </summary>
        public const string TPHBST5 = "TPHBST5";

        /// <summary>
        /// TPCRTU.
        /// </summary>
        public const string TPCRTU = "TPCRTU";

        /// <summary>
        /// TPCRTJ.
        /// </summary>
        public const string TPCRTJ = "TPCRTJ";

        /// <summary>
        /// TPCRTT.
        /// </summary>
        public const string TPCRTT = "TPCRTT";

        /// <summary>
        /// TPWRKSTNID.
        /// </summary>
        public const string TPWRKSTNID = "TPWRKSTNID";

        /// <summary>
        /// TPHBOPID.
        /// </summary>
        public const string TPHBOPID = "TPHBOPID";

        /// <summary>
        /// TPUPMB.
        /// </summary>
        public const string TPUPMB = "TPUPMB";

        /// <summary>
        /// TPUPMJ.
        /// </summary>
        public const string TPUPMJ = "TPUPMJ";

        /// <summary>
        /// TPUPMT.
        /// </summary>
        public const string TPUPMT = "TPUPMT";

        /// <summary>
        /// TPJOBN.
        /// </summary>
        public const string TPJOBN = "TPJOBN";

        /// <summary>
        /// TPPID.
        /// </summary>
        public const string TPPID = "TPPID";
    }

    /// <inheritdoc />
    public override string TableName => "F44H711P";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TPDOCO", "TPDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("TPDCT", "TPDCT", JdeDataType.String, 4, true, true),
        new JdeField("TPKCOO", "TPKCOO", JdeDataType.String, 10, true, true),
        new JdeField("TPSFXO", "TPSFXO", JdeDataType.String, 6, true, true),
        new JdeField("TPLNID", "TPLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("TPAN8", "TPAN8", JdeDataType.Numeric),
        new JdeField("TPHBAREA", "TPHBAREA", JdeDataType.String, 6),
        new JdeField("TPHBMCUS", "TPHBMCUS", JdeDataType.String, 24),
        new JdeField("TPHBLOT", "TPHBLOT", JdeDataType.String, 8),
        new JdeField("TPOMCU", "TPOMCU", JdeDataType.String, 24),
        new JdeField("TPCPHASE", "TPCPHASE", JdeDataType.String, 6),
        new JdeField("TPOBJ", "TPOBJ", JdeDataType.String, 12),
        new JdeField("TPSUB", "TPSUB", JdeDataType.String, 16),
        new JdeField("TPOPTION", "TPOPTION", JdeDataType.String, 16),
        new JdeField("TPDGL", "TPDGL", JdeDataType.Numeric),
        new JdeField("TPUORG", "TPUORG", JdeDataType.Numeric),
        new JdeField("TPPRRC", "TPPRRC", JdeDataType.Numeric),
        new JdeField("TPAEXP", "TPAEXP", JdeDataType.Numeric),
        new JdeField("TPITM", "TPITM", JdeDataType.Numeric),
        new JdeField("TPLITM", "TPLITM", JdeDataType.String, 50),
        new JdeField("TPAITM", "TPAITM", JdeDataType.String, 50),
        new JdeField("TPUOM", "TPUOM", JdeDataType.String, 4),
        new JdeField("TPOORN", "TPOORN", JdeDataType.String, 16),
        new JdeField("TPOCTO", "TPOCTO", JdeDataType.String, 4),
        new JdeField("TPOKCO", "TPOKCO", JdeDataType.String, 10),
        new JdeField("TPOGNO", "TPOGNO", JdeDataType.Numeric),
        new JdeField("TPOSFX", "TPOSFX", JdeDataType.String, 6),
        new JdeField("TPDESC", "TPDESC", JdeDataType.String, 60),
        new JdeField("TPVR01", "TPVR01", JdeDataType.String, 50),
        new JdeField("TPVR02", "TPVR02", JdeDataType.String, 50),
        new JdeField("TPDSC1", "TPDSC1", JdeDataType.String, 60),
        new JdeField("TPDSC2", "TPDSC2", JdeDataType.String, 60),
        new JdeField("TPTX", "TPTX", JdeDataType.String, 2),
        new JdeField("TPEXR1", "TPEXR1", JdeDataType.String, 4),
        new JdeField("TPTXA1", "TPTXA1", JdeDataType.String, 20),
        new JdeField("TPANBY", "TPANBY", JdeDataType.Numeric),
        new JdeField("TPPDP1", "TPPDP1", JdeDataType.String, 6),
        new JdeField("TPPDP2", "TPPDP2", JdeDataType.String, 6),
        new JdeField("TPPDP3", "TPPDP3", JdeDataType.String, 6),
        new JdeField("TPPDP4", "TPPDP4", JdeDataType.String, 6),
        new JdeField("TPPDP5", "TPPDP5", JdeDataType.String, 6),
        new JdeField("TPF1T", "TPF1T", JdeDataType.String, 60),
        new JdeField("TPF2T", "TPF2T", JdeDataType.String, 60),
        new JdeField("TPF3T", "TPF3T", JdeDataType.String, 60),
        new JdeField("TPHBST1", "TPHBST1", JdeDataType.String, 2),
        new JdeField("TPHBST2", "TPHBST2", JdeDataType.String, 2),
        new JdeField("TPHBST3", "TPHBST3", JdeDataType.String, 2),
        new JdeField("TPHBST4", "TPHBST4", JdeDataType.String, 2),
        new JdeField("TPHBST5", "TPHBST5", JdeDataType.String, 2),
        new JdeField("TPCRTU", "TPCRTU", JdeDataType.String, 20),
        new JdeField("TPCRTJ", "TPCRTJ", JdeDataType.Numeric),
        new JdeField("TPCRTT", "TPCRTT", JdeDataType.Numeric),
        new JdeField("TPWRKSTNID", "TPWRKSTNID", JdeDataType.String, 20),
        new JdeField("TPHBOPID", "TPHBOPID", JdeDataType.String, 20),
        new JdeField("TPUPMB", "TPUPMB", JdeDataType.String, 20),
        new JdeField("TPUPMJ", "TPUPMJ", JdeDataType.Numeric),
        new JdeField("TPUPMT", "TPUPMT", JdeDataType.Numeric),
        new JdeField("TPJOBN", "TPJOBN", JdeDataType.String, 20),
        new JdeField("TPPID", "TPPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H711P_0", "Primary Key on TPDOCO, TPDCT, TPKCOO, TPSFXO, TPLNID", new[] { "TPDOCO", "TPDCT", "TPKCOO", "TPSFXO", "TPLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F44H711P_2", "Index on TPDOCO, TPDCT, TPKCOO, TPSFXO, SYS_NC00060$", new[] { "TPDOCO", "TPDCT", "TPKCOO", "TPSFXO", "SYS_NC00060$" }),
        new JdeIndex("F44H711P_3", "Index on TPDOCO, TPDCT, TPKCOO", new[] { "TPDOCO", "TPDCT", "TPKCOO" })
    };
}
