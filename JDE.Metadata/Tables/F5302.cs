using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F5302 - .
/// </summary>
public class F5302 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DKMCU.
        /// </summary>
        public const string DKMCU = "DKMCU";

        /// <summary>
        /// DKCONO.
        /// </summary>
        public const string DKCONO = "DKCONO";

        /// <summary>
        /// DKLNID.
        /// </summary>
        public const string DKLNID = "DKLNID";

        /// <summary>
        /// DKTYRA.
        /// </summary>
        public const string DKTYRA = "DKTYRA";

        /// <summary>
        /// DKSTS3.
        /// </summary>
        public const string DKSTS3 = "DKSTS3";

        /// <summary>
        /// DKDGCG.
        /// </summary>
        public const string DKDGCG = "DKDGCG";

        /// <summary>
        /// DKDL01.
        /// </summary>
        public const string DKDL01 = "DKDL01";

        /// <summary>
        /// DKDL02.
        /// </summary>
        public const string DKDL02 = "DKDL02";

        /// <summary>
        /// DKREQB.
        /// </summary>
        public const string DKREQB = "DKREQB";

        /// <summary>
        /// DKRQBD.
        /// </summary>
        public const string DKRQBD = "DKRQBD";

        /// <summary>
        /// DKMCUS.
        /// </summary>
        public const string DKMCUS = "DKMCUS";

        /// <summary>
        /// DKSUB.
        /// </summary>
        public const string DKSUB = "DKSUB";

        /// <summary>
        /// DKOBJ.
        /// </summary>
        public const string DKOBJ = "DKOBJ";

        /// <summary>
        /// DKSBL.
        /// </summary>
        public const string DKSBL = "DKSBL";

        /// <summary>
        /// DKSBLT.
        /// </summary>
        public const string DKSBLT = "DKSBLT";

        /// <summary>
        /// DKUM.
        /// </summary>
        public const string DKUM = "DKUM";

        /// <summary>
        /// DKANOG.
        /// </summary>
        public const string DKANOG = "DKANOG";

        /// <summary>
        /// DKQTOG.
        /// </summary>
        public const string DKQTOG = "DKQTOG";

        /// <summary>
        /// DKUROG.
        /// </summary>
        public const string DKUROG = "DKUROG";

        /// <summary>
        /// DKDTOG.
        /// </summary>
        public const string DKDTOG = "DKDTOG";

        /// <summary>
        /// DKANQT.
        /// </summary>
        public const string DKANQT = "DKANQT";

        /// <summary>
        /// DKQTQT.
        /// </summary>
        public const string DKQTQT = "DKQTQT";

        /// <summary>
        /// DKURQT.
        /// </summary>
        public const string DKURQT = "DKURQT";

        /// <summary>
        /// DKDTQT.
        /// </summary>
        public const string DKDTQT = "DKDTQT";

        /// <summary>
        /// DKANFN.
        /// </summary>
        public const string DKANFN = "DKANFN";

        /// <summary>
        /// DKQTFN.
        /// </summary>
        public const string DKQTFN = "DKQTFN";

        /// <summary>
        /// DKURFN.
        /// </summary>
        public const string DKURFN = "DKURFN";

        /// <summary>
        /// DKDTFN.
        /// </summary>
        public const string DKDTFN = "DKDTFN";

        /// <summary>
        /// DKPRCE.
        /// </summary>
        public const string DKPRCE = "DKPRCE";

        /// <summary>
        /// DKTRMO.
        /// </summary>
        public const string DKTRMO = "DKTRMO";

        /// <summary>
        /// DKFUF2.
        /// </summary>
        public const string DKFUF2 = "DKFUF2";

        /// <summary>
        /// DKEXTD.
        /// </summary>
        public const string DKEXTD = "DKEXTD";

        /// <summary>
        /// DKRQDD.
        /// </summary>
        public const string DKRQDD = "DKRQDD";

        /// <summary>
        /// DKDOCO.
        /// </summary>
        public const string DKDOCO = "DKDOCO";

        /// <summary>
        /// DKDCTO.
        /// </summary>
        public const string DKDCTO = "DKDCTO";

        /// <summary>
        /// DKSFXO.
        /// </summary>
        public const string DKSFXO = "DKSFXO";

        /// <summary>
        /// DKLNCT.
        /// </summary>
        public const string DKLNCT = "DKLNCT";

        /// <summary>
        /// DKAN8V.
        /// </summary>
        public const string DKAN8V = "DKAN8V";

        /// <summary>
        /// DKR001.
        /// </summary>
        public const string DKR001 = "DKR001";

        /// <summary>
        /// DKPROC.
        /// </summary>
        public const string DKPROC = "DKPROC";

        /// <summary>
        /// DKOPIM.
        /// </summary>
        public const string DKOPIM = "DKOPIM";

        /// <summary>
        /// DKDL03.
        /// </summary>
        public const string DKDL03 = "DKDL03";

        /// <summary>
        /// DKAN8O.
        /// </summary>
        public const string DKAN8O = "DKAN8O";

        /// <summary>
        /// DKDOCM.
        /// </summary>
        public const string DKDOCM = "DKDOCM";

        /// <summary>
        /// DKDCTM.
        /// </summary>
        public const string DKDCTM = "DKDCTM";

        /// <summary>
        /// DKSFXM.
        /// </summary>
        public const string DKSFXM = "DKSFXM";

        /// <summary>
        /// DKUSER.
        /// </summary>
        public const string DKUSER = "DKUSER";

        /// <summary>
        /// DKPID.
        /// </summary>
        public const string DKPID = "DKPID";

        /// <summary>
        /// DKUPMJ.
        /// </summary>
        public const string DKUPMJ = "DKUPMJ";

        /// <summary>
        /// DKJOBN.
        /// </summary>
        public const string DKJOBN = "DKJOBN";

        /// <summary>
        /// DKUPMT.
        /// </summary>
        public const string DKUPMT = "DKUPMT";

        /// <summary>
        /// DKKCO.
        /// </summary>
        public const string DKKCO = "DKKCO";

        /// <summary>
        /// DKKCOO.
        /// </summary>
        public const string DKKCOO = "DKKCOO";
    }

    /// <inheritdoc />
    public override string TableName => "F5302";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DKMCU", "DKMCU", JdeDataType.String, 24, true, true),
        new JdeField("DKCONO", "DKCONO", JdeDataType.Numeric, null, true, true),
        new JdeField("DKLNID", "DKLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("DKTYRA", "DKTYRA", JdeDataType.String, 2, true, true),
        new JdeField("DKSTS3", "DKSTS3", JdeDataType.String, 2),
        new JdeField("DKDGCG", "DKDGCG", JdeDataType.Numeric),
        new JdeField("DKDL01", "DKDL01", JdeDataType.String, 60),
        new JdeField("DKDL02", "DKDL02", JdeDataType.String, 60),
        new JdeField("DKREQB", "DKREQB", JdeDataType.Numeric, null, true, true),
        new JdeField("DKRQBD", "DKRQBD", JdeDataType.Numeric),
        new JdeField("DKMCUS", "DKMCUS", JdeDataType.String, 24),
        new JdeField("DKSUB", "DKSUB", JdeDataType.String, 16),
        new JdeField("DKOBJ", "DKOBJ", JdeDataType.String, 12),
        new JdeField("DKSBL", "DKSBL", JdeDataType.String, 16),
        new JdeField("DKSBLT", "DKSBLT", JdeDataType.String, 2),
        new JdeField("DKUM", "DKUM", JdeDataType.String, 4),
        new JdeField("DKANOG", "DKANOG", JdeDataType.Numeric),
        new JdeField("DKQTOG", "DKQTOG", JdeDataType.Numeric),
        new JdeField("DKUROG", "DKUROG", JdeDataType.Numeric),
        new JdeField("DKDTOG", "DKDTOG", JdeDataType.Numeric),
        new JdeField("DKANQT", "DKANQT", JdeDataType.Numeric),
        new JdeField("DKQTQT", "DKQTQT", JdeDataType.Numeric),
        new JdeField("DKURQT", "DKURQT", JdeDataType.Numeric),
        new JdeField("DKDTQT", "DKDTQT", JdeDataType.Numeric),
        new JdeField("DKANFN", "DKANFN", JdeDataType.Numeric),
        new JdeField("DKQTFN", "DKQTFN", JdeDataType.Numeric),
        new JdeField("DKURFN", "DKURFN", JdeDataType.Numeric),
        new JdeField("DKDTFN", "DKDTFN", JdeDataType.Numeric),
        new JdeField("DKPRCE", "DKPRCE", JdeDataType.String, 2),
        new JdeField("DKTRMO", "DKTRMO", JdeDataType.String, 2),
        new JdeField("DKFUF2", "DKFUF2", JdeDataType.String, 2),
        new JdeField("DKEXTD", "DKEXTD", JdeDataType.Numeric),
        new JdeField("DKRQDD", "DKRQDD", JdeDataType.Numeric),
        new JdeField("DKDOCO", "DKDOCO", JdeDataType.Numeric),
        new JdeField("DKDCTO", "DKDCTO", JdeDataType.String, 4),
        new JdeField("DKSFXO", "DKSFXO", JdeDataType.String, 6),
        new JdeField("DKLNCT", "DKLNCT", JdeDataType.Numeric),
        new JdeField("DKAN8V", "DKAN8V", JdeDataType.Numeric),
        new JdeField("DKR001", "DKR001", JdeDataType.String, 6),
        new JdeField("DKPROC", "DKPROC", JdeDataType.String, 2),
        new JdeField("DKOPIM", "DKOPIM", JdeDataType.String, 30),
        new JdeField("DKDL03", "DKDL03", JdeDataType.String, 60),
        new JdeField("DKAN8O", "DKAN8O", JdeDataType.Numeric),
        new JdeField("DKDOCM", "DKDOCM", JdeDataType.Numeric),
        new JdeField("DKDCTM", "DKDCTM", JdeDataType.String, 4),
        new JdeField("DKSFXM", "DKSFXM", JdeDataType.String, 6),
        new JdeField("DKUSER", "DKUSER", JdeDataType.String, 20),
        new JdeField("DKPID", "DKPID", JdeDataType.String, 20),
        new JdeField("DKUPMJ", "DKUPMJ", JdeDataType.Numeric),
        new JdeField("DKJOBN", "DKJOBN", JdeDataType.String, 20),
        new JdeField("DKUPMT", "DKUPMT", JdeDataType.Numeric),
        new JdeField("DKKCO", "DKKCO", JdeDataType.String, 10),
        new JdeField("DKKCOO", "DKKCOO", JdeDataType.String, 10)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F5302_0", "Primary Key on DKMCU, DKCONO, DKLNID, DKTYRA, DKREQB", new[] { "DKMCU", "DKCONO", "DKLNID", "DKTYRA", "DKREQB" }, isUnique: true, isPrimaryKey: true)
    };
}
