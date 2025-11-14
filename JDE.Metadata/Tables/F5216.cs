using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F5216 - .
/// </summary>
public class F5216 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// A6DOCO.
        /// </summary>
        public const string A6DOCO = "A6DOCO";

        /// <summary>
        /// A6DCTO.
        /// </summary>
        public const string A6DCTO = "A6DCTO";

        /// <summary>
        /// A6KCOO.
        /// </summary>
        public const string A6KCOO = "A6KCOO";

        /// <summary>
        /// A6COCH.
        /// </summary>
        public const string A6COCH = "A6COCH";

        /// <summary>
        /// A6LNID.
        /// </summary>
        public const string A6LNID = "A6LNID";

        /// <summary>
        /// A6EVNT.
        /// </summary>
        public const string A6EVNT = "A6EVNT";

        /// <summary>
        /// A6DL01.
        /// </summary>
        public const string A6DL01 = "A6DL01";

        /// <summary>
        /// A6SDSC.
        /// </summary>
        public const string A6SDSC = "A6SDSC";

        /// <summary>
        /// A6APER.
        /// </summary>
        public const string A6APER = "A6APER";

        /// <summary>
        /// A6PERS.
        /// </summary>
        public const string A6PERS = "A6PERS";

        /// <summary>
        /// A6AA.
        /// </summary>
        public const string A6AA = "A6AA";

        /// <summary>
        /// A6AA2.
        /// </summary>
        public const string A6AA2 = "A6AA2";

        /// <summary>
        /// A6CRCD.
        /// </summary>
        public const string A6CRCD = "A6CRCD";

        /// <summary>
        /// A6CRCF.
        /// </summary>
        public const string A6CRCF = "A6CRCF";

        /// <summary>
        /// A6CRRD.
        /// </summary>
        public const string A6CRRD = "A6CRRD";

        /// <summary>
        /// A6CRRM.
        /// </summary>
        public const string A6CRRM = "A6CRRM";

        /// <summary>
        /// A6CMFL.
        /// </summary>
        public const string A6CMFL = "A6CMFL";

        /// <summary>
        /// A6BILF.
        /// </summary>
        public const string A6BILF = "A6BILF";

        /// <summary>
        /// A6DECO.
        /// </summary>
        public const string A6DECO = "A6DECO";

        /// <summary>
        /// A6DTCO.
        /// </summary>
        public const string A6DTCO = "A6DTCO";

        /// <summary>
        /// A6DOCZ.
        /// </summary>
        public const string A6DOCZ = "A6DOCZ";

        /// <summary>
        /// A6DCTI.
        /// </summary>
        public const string A6DCTI = "A6DCTI";

        /// <summary>
        /// A6KCOI.
        /// </summary>
        public const string A6KCOI = "A6KCOI";

        /// <summary>
        /// A6ICU.
        /// </summary>
        public const string A6ICU = "A6ICU";

        /// <summary>
        /// A6ICUT.
        /// </summary>
        public const string A6ICUT = "A6ICUT";

        /// <summary>
        /// A6ICUJ.
        /// </summary>
        public const string A6ICUJ = "A6ICUJ";

        /// <summary>
        /// A6SEQ.
        /// </summary>
        public const string A6SEQ = "A6SEQ";

        /// <summary>
        /// A6LSSQ.
        /// </summary>
        public const string A6LSSQ = "A6LSSQ";

        /// <summary>
        /// A6USER.
        /// </summary>
        public const string A6USER = "A6USER";

        /// <summary>
        /// A6JOBN.
        /// </summary>
        public const string A6JOBN = "A6JOBN";

        /// <summary>
        /// A6UPMJ.
        /// </summary>
        public const string A6UPMJ = "A6UPMJ";

        /// <summary>
        /// A6PID.
        /// </summary>
        public const string A6PID = "A6PID";

        /// <summary>
        /// A6UPMT.
        /// </summary>
        public const string A6UPMT = "A6UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F5216";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("A6DOCO", "A6DOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("A6DCTO", "A6DCTO", JdeDataType.String, 4, true, true),
        new JdeField("A6KCOO", "A6KCOO", JdeDataType.String, 10, true, true),
        new JdeField("A6COCH", "A6COCH", JdeDataType.String, 6, true, true),
        new JdeField("A6LNID", "A6LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("A6EVNT", "A6EVNT", JdeDataType.String, 20, true, true),
        new JdeField("A6DL01", "A6DL01", JdeDataType.String, 60),
        new JdeField("A6SDSC", "A6SDSC", JdeDataType.String, 120),
        new JdeField("A6APER", "A6APER", JdeDataType.String, 2),
        new JdeField("A6PERS", "A6PERS", JdeDataType.Numeric),
        new JdeField("A6AA", "A6AA", JdeDataType.Numeric),
        new JdeField("A6AA2", "A6AA2", JdeDataType.Numeric),
        new JdeField("A6CRCD", "A6CRCD", JdeDataType.String, 6),
        new JdeField("A6CRCF", "A6CRCF", JdeDataType.String, 6),
        new JdeField("A6CRRD", "A6CRRD", JdeDataType.Numeric),
        new JdeField("A6CRRM", "A6CRRM", JdeDataType.String, 2),
        new JdeField("A6CMFL", "A6CMFL", JdeDataType.String, 2),
        new JdeField("A6BILF", "A6BILF", JdeDataType.String, 2),
        new JdeField("A6DECO", "A6DECO", JdeDataType.Numeric),
        new JdeField("A6DTCO", "A6DTCO", JdeDataType.Numeric),
        new JdeField("A6DOCZ", "A6DOCZ", JdeDataType.Numeric),
        new JdeField("A6DCTI", "A6DCTI", JdeDataType.String, 4),
        new JdeField("A6KCOI", "A6KCOI", JdeDataType.String, 10),
        new JdeField("A6ICU", "A6ICU", JdeDataType.Numeric),
        new JdeField("A6ICUT", "A6ICUT", JdeDataType.String, 4),
        new JdeField("A6ICUJ", "A6ICUJ", JdeDataType.Numeric),
        new JdeField("A6SEQ", "A6SEQ", JdeDataType.Numeric),
        new JdeField("A6LSSQ", "A6LSSQ", JdeDataType.String, 2),
        new JdeField("A6USER", "A6USER", JdeDataType.String, 20),
        new JdeField("A6JOBN", "A6JOBN", JdeDataType.String, 20),
        new JdeField("A6UPMJ", "A6UPMJ", JdeDataType.Numeric),
        new JdeField("A6PID", "A6PID", JdeDataType.String, 20),
        new JdeField("A6UPMT", "A6UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F5216_0", "Primary Key on A6DOCO, A6DCTO, A6KCOO, A6COCH, A6LNID, A6EVNT", new[] { "A6DOCO", "A6DCTO", "A6KCOO", "A6COCH", "A6LNID", "A6EVNT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F5216_10", "Index on A6DOCO, A6DCTO, A6KCOO", new[] { "A6DOCO", "A6DCTO", "A6KCOO" }),
        new JdeIndex("F5216_11", "Index on A6DOCO, A6DCTO, A6KCOO, A6COCH, A6LNID", new[] { "A6DOCO", "A6DCTO", "A6KCOO", "A6COCH", "A6LNID" }),
        new JdeIndex("F5216_12", "Index on SYS_NC00034$, SYS_NC00035$, A6DCTO, A6KCOO, A6COCH, A6LNID, A6EVNT", new[] { "SYS_NC00034$", "SYS_NC00035$", "A6DCTO", "A6KCOO", "A6COCH", "A6LNID", "A6EVNT" }),
        new JdeIndex("F5216_6", "Index on A6DOCO, A6DCTO, A6PERS, A6KCOO, A6COCH, A6LNID, A6SEQ", new[] { "A6DOCO", "A6DCTO", "A6PERS", "A6KCOO", "A6COCH", "A6LNID", "A6SEQ" }),
        new JdeIndex("F5216_7", "Index on A6ICU, A6ICUT, A6DOCZ, A6DCTI, A6KCOI", new[] { "A6ICU", "A6ICUT", "A6DOCZ", "A6DCTI", "A6KCOI" }),
        new JdeIndex("F5216_8", "Index on A6DOCO, A6DCTO, A6KCOO, A6COCH, A6LSSQ, A6LNID, A6BILF, A6CMFL", new[] { "A6DOCO", "A6DCTO", "A6KCOO", "A6COCH", "A6LSSQ", "A6LNID", "A6BILF", "A6CMFL" }),
        new JdeIndex("F5216_9", "Index on A6DOCO, A6DCTO, A6KCOO, A6COCH, A6LNID, A6PERS", new[] { "A6DOCO", "A6DCTO", "A6KCOO", "A6COCH", "A6LNID", "A6PERS" })
    };
}
