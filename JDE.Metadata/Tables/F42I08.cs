using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42I08 - .
/// </summary>
public class F42I08 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PRCONBN.
        /// </summary>
        public const string PRCONBN = "PRCONBN";

        /// <summary>
        /// PRDMCT.
        /// </summary>
        public const string PRDMCT = "PRDMCT";

        /// <summary>
        /// PRDMCS.
        /// </summary>
        public const string PRDMCS = "PRDMCS";

        /// <summary>
        /// PRSEQ.
        /// </summary>
        public const string PRSEQ = "PRSEQ";

        /// <summary>
        /// PRCMAN.
        /// </summary>
        public const string PRCMAN = "PRCMAN";

        /// <summary>
        /// PRITM.
        /// </summary>
        public const string PRITM = "PRITM";

        /// <summary>
        /// PRLITM.
        /// </summary>
        public const string PRLITM = "PRLITM";

        /// <summary>
        /// PRAN8.
        /// </summary>
        public const string PRAN8 = "PRAN8";

        /// <summary>
        /// PRSHAN.
        /// </summary>
        public const string PRSHAN = "PRSHAN";

        /// <summary>
        /// PRMCU.
        /// </summary>
        public const string PRMCU = "PRMCU";

        /// <summary>
        /// PRLOCN.
        /// </summary>
        public const string PRLOCN = "PRLOCN";

        /// <summary>
        /// PRLOTN.
        /// </summary>
        public const string PRLOTN = "PRLOTN";

        /// <summary>
        /// PRCONSDT.
        /// </summary>
        public const string PRCONSDT = "PRCONSDT";

        /// <summary>
        /// PRRCONDATE.
        /// </summary>
        public const string PRRCONDATE = "PRRCONDATE";

        /// <summary>
        /// PRPOCUST.
        /// </summary>
        public const string PRPOCUST = "PRPOCUST";

        /// <summary>
        /// PROVPRFLG.
        /// </summary>
        public const string PROVPRFLG = "PROVPRFLG";

        /// <summary>
        /// PROPRC1.
        /// </summary>
        public const string PROPRC1 = "PROPRC1";

        /// <summary>
        /// PROVCRCD.
        /// </summary>
        public const string PROVCRCD = "PROVCRCD";

        /// <summary>
        /// PROVRQFLG.
        /// </summary>
        public const string PROVRQFLG = "PROVRQFLG";

        /// <summary>
        /// PRREPLQTY.
        /// </summary>
        public const string PRREPLQTY = "PRREPLQTY";

        /// <summary>
        /// PRREUOM1.
        /// </summary>
        public const string PRREUOM1 = "PRREUOM1";

        /// <summary>
        /// PRRESQTY.
        /// </summary>
        public const string PRRESQTY = "PRRESQTY";

        /// <summary>
        /// PRREPLFLG.
        /// </summary>
        public const string PRREPLFLG = "PRREPLFLG";

        /// <summary>
        /// PRBILLFLG.
        /// </summary>
        public const string PRBILLFLG = "PRBILLFLG";

        /// <summary>
        /// PRPRCAPRDT.
        /// </summary>
        public const string PRPRCAPRDT = "PRPRCAPRDT";

        /// <summary>
        /// PRQTYAPRDT.
        /// </summary>
        public const string PRQTYAPRDT = "PRQTYAPRDT";

        /// <summary>
        /// PRCONSMDE.
        /// </summary>
        public const string PRCONSMDE = "PRCONSMDE";

        /// <summary>
        /// PRUSER.
        /// </summary>
        public const string PRUSER = "PRUSER";

        /// <summary>
        /// PRPID.
        /// </summary>
        public const string PRPID = "PRPID";

        /// <summary>
        /// PRJOBN.
        /// </summary>
        public const string PRJOBN = "PRJOBN";

        /// <summary>
        /// PRUPMJ.
        /// </summary>
        public const string PRUPMJ = "PRUPMJ";

        /// <summary>
        /// PRRFC5.
        /// </summary>
        public const string PRRFC5 = "PRRFC5";

        /// <summary>
        /// PRRFC6.
        /// </summary>
        public const string PRRFC6 = "PRRFC6";

        /// <summary>
        /// PRRFC7.
        /// </summary>
        public const string PRRFC7 = "PRRFC7";

        /// <summary>
        /// PRRFC8.
        /// </summary>
        public const string PRRFC8 = "PRRFC8";

        /// <summary>
        /// PRTDAY.
        /// </summary>
        public const string PRTDAY = "PRTDAY";

        /// <summary>
        /// PRFUCHAR22.
        /// </summary>
        public const string PRFUCHAR22 = "PRFUCHAR22";

        /// <summary>
        /// PRFUCHAR23.
        /// </summary>
        public const string PRFUCHAR23 = "PRFUCHAR23";

        /// <summary>
        /// PRFUCHAR24.
        /// </summary>
        public const string PRFUCHAR24 = "PRFUCHAR24";

        /// <summary>
        /// PRFUTNUM10.
        /// </summary>
        public const string PRFUTNUM10 = "PRFUTNUM10";

        /// <summary>
        /// PRFUTNUM11.
        /// </summary>
        public const string PRFUTNUM11 = "PRFUTNUM11";

        /// <summary>
        /// PRFUTNUM12.
        /// </summary>
        public const string PRFUTNUM12 = "PRFUTNUM12";

        /// <summary>
        /// PRFSTR4.
        /// </summary>
        public const string PRFSTR4 = "PRFSTR4";

        /// <summary>
        /// PRFSTR5.
        /// </summary>
        public const string PRFSTR5 = "PRFSTR5";

        /// <summary>
        /// PRFSTR6.
        /// </summary>
        public const string PRFSTR6 = "PRFSTR6";

        /// <summary>
        /// PRFUDT31.
        /// </summary>
        public const string PRFUDT31 = "PRFUDT31";

        /// <summary>
        /// PRFUDT15.
        /// </summary>
        public const string PRFUDT15 = "PRFUDT15";

        /// <summary>
        /// PRFUDT25.
        /// </summary>
        public const string PRFUDT25 = "PRFUDT25";

        /// <summary>
        /// PRURAT.
        /// </summary>
        public const string PRURAT = "PRURAT";

        /// <summary>
        /// PRURCD.
        /// </summary>
        public const string PRURCD = "PRURCD";

        /// <summary>
        /// PRURDT.
        /// </summary>
        public const string PRURDT = "PRURDT";

        /// <summary>
        /// PRURAB.
        /// </summary>
        public const string PRURAB = "PRURAB";

        /// <summary>
        /// PRURRF.
        /// </summary>
        public const string PRURRF = "PRURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F42I08";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PRCONBN", "PRCONBN", JdeDataType.Numeric, null, true, true),
        new JdeField("PRDMCT", "PRDMCT", JdeDataType.String, 24, true, true),
        new JdeField("PRDMCS", "PRDMCS", JdeDataType.Numeric, null, true, true),
        new JdeField("PRSEQ", "PRSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("PRCMAN", "PRCMAN", JdeDataType.Numeric),
        new JdeField("PRITM", "PRITM", JdeDataType.Numeric),
        new JdeField("PRLITM", "PRLITM", JdeDataType.String, 50),
        new JdeField("PRAN8", "PRAN8", JdeDataType.Numeric),
        new JdeField("PRSHAN", "PRSHAN", JdeDataType.Numeric),
        new JdeField("PRMCU", "PRMCU", JdeDataType.String, 24),
        new JdeField("PRLOCN", "PRLOCN", JdeDataType.String, 40),
        new JdeField("PRLOTN", "PRLOTN", JdeDataType.String, 60, true, true),
        new JdeField("PRCONSDT", "PRCONSDT", JdeDataType.Numeric),
        new JdeField("PRRCONDATE", "PRRCONDATE", JdeDataType.Numeric),
        new JdeField("PRPOCUST", "PRPOCUST", JdeDataType.String, 50),
        new JdeField("PROVPRFLG", "PROVPRFLG", JdeDataType.String, 2),
        new JdeField("PROPRC1", "PROPRC1", JdeDataType.Numeric),
        new JdeField("PROVCRCD", "PROVCRCD", JdeDataType.String, 6),
        new JdeField("PROVRQFLG", "PROVRQFLG", JdeDataType.String, 2),
        new JdeField("PRREPLQTY", "PRREPLQTY", JdeDataType.Numeric),
        new JdeField("PRREUOM1", "PRREUOM1", JdeDataType.String, 4),
        new JdeField("PRRESQTY", "PRRESQTY", JdeDataType.Numeric),
        new JdeField("PRREPLFLG", "PRREPLFLG", JdeDataType.String, 2),
        new JdeField("PRBILLFLG", "PRBILLFLG", JdeDataType.String, 2),
        new JdeField("PRPRCAPRDT", "PRPRCAPRDT", JdeDataType.Date),
        new JdeField("PRQTYAPRDT", "PRQTYAPRDT", JdeDataType.Date),
        new JdeField("PRCONSMDE", "PRCONSMDE", JdeDataType.String, 2),
        new JdeField("PRUSER", "PRUSER", JdeDataType.String, 20),
        new JdeField("PRPID", "PRPID", JdeDataType.String, 20),
        new JdeField("PRJOBN", "PRJOBN", JdeDataType.String, 20),
        new JdeField("PRUPMJ", "PRUPMJ", JdeDataType.Numeric),
        new JdeField("PRRFC5", "PRRFC5", JdeDataType.String, 50),
        new JdeField("PRRFC6", "PRRFC6", JdeDataType.String, 50),
        new JdeField("PRRFC7", "PRRFC7", JdeDataType.String, 50),
        new JdeField("PRRFC8", "PRRFC8", JdeDataType.String, 50),
        new JdeField("PRTDAY", "PRTDAY", JdeDataType.Numeric),
        new JdeField("PRFUCHAR22", "PRFUCHAR22", JdeDataType.String, 2),
        new JdeField("PRFUCHAR23", "PRFUCHAR23", JdeDataType.String, 2),
        new JdeField("PRFUCHAR24", "PRFUCHAR24", JdeDataType.String, 2),
        new JdeField("PRFUTNUM10", "PRFUTNUM10", JdeDataType.Numeric),
        new JdeField("PRFUTNUM11", "PRFUTNUM11", JdeDataType.Numeric),
        new JdeField("PRFUTNUM12", "PRFUTNUM12", JdeDataType.Numeric),
        new JdeField("PRFSTR4", "PRFSTR4", JdeDataType.String, 100),
        new JdeField("PRFSTR5", "PRFSTR5", JdeDataType.String, 100),
        new JdeField("PRFSTR6", "PRFSTR6", JdeDataType.String, 100),
        new JdeField("PRFUDT31", "PRFUDT31", JdeDataType.Numeric),
        new JdeField("PRFUDT15", "PRFUDT15", JdeDataType.Numeric),
        new JdeField("PRFUDT25", "PRFUDT25", JdeDataType.Numeric),
        new JdeField("PRURAT", "PRURAT", JdeDataType.Numeric),
        new JdeField("PRURCD", "PRURCD", JdeDataType.String, 4),
        new JdeField("PRURDT", "PRURDT", JdeDataType.Numeric),
        new JdeField("PRURAB", "PRURAB", JdeDataType.Numeric),
        new JdeField("PRURRF", "PRURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42I08_0", "Primary Key on PRCONBN, PRDMCT, PRDMCS, PRSEQ, PRLOTN", new[] { "PRCONBN", "PRDMCT", "PRDMCS", "PRSEQ", "PRLOTN" }, isUnique: true, isPrimaryKey: true)
    };
}
