using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1512 - .
/// </summary>
public class F1512 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NAGLC.
        /// </summary>
        public const string NAGLC = "NAGLC";

        /// <summary>
        /// NAMCU.
        /// </summary>
        public const string NAMCU = "NAMCU";

        /// <summary>
        /// NADL01.
        /// </summary>
        public const string NADL01 = "NADL01";

        /// <summary>
        /// NAGRPC.
        /// </summary>
        public const string NAGRPC = "NAGRPC";

        /// <summary>
        /// NATNAR.
        /// </summary>
        public const string NATNAR = "NATNAR";

        /// <summary>
        /// NALTFE.
        /// </summary>
        public const string NALTFE = "NALTFE";

        /// <summary>
        /// NAMGFE.
        /// </summary>
        public const string NAMGFE = "NAMGFE";

        /// <summary>
        /// NAPRAP.
        /// </summary>
        public const string NAPRAP = "NAPRAP";

        /// <summary>
        /// NAAPPC.
        /// </summary>
        public const string NAAPPC = "NAAPPC";

        /// <summary>
        /// NAALLW.
        /// </summary>
        public const string NAALLW = "NAALLW";

        /// <summary>
        /// NACONS.
        /// </summary>
        public const string NACONS = "NACONS";

        /// <summary>
        /// NAAUTS.
        /// </summary>
        public const string NAAUTS = "NAAUTS";

        /// <summary>
        /// NASPCD.
        /// </summary>
        public const string NASPCD = "NASPCD";

        /// <summary>
        /// NASECG.
        /// </summary>
        public const string NASECG = "NASECG";

        /// <summary>
        /// NAGRPU.
        /// </summary>
        public const string NAGRPU = "NAGRPU";

        /// <summary>
        /// NABRAJ.
        /// </summary>
        public const string NABRAJ = "NABRAJ";

        /// <summary>
        /// NASTAX.
        /// </summary>
        public const string NASTAX = "NASTAX";

        /// <summary>
        /// NAAPLY.
        /// </summary>
        public const string NAAPLY = "NAAPLY";

        /// <summary>
        /// NACMNT.
        /// </summary>
        public const string NACMNT = "NACMNT";

        /// <summary>
        /// NAADEP.
        /// </summary>
        public const string NAADEP = "NAADEP";

        /// <summary>
        /// NACLSS.
        /// </summary>
        public const string NACLSS = "NACLSS";

        /// <summary>
        /// NAADJR.
        /// </summary>
        public const string NAADJR = "NAADJR";

        /// <summary>
        /// NAJOBN.
        /// </summary>
        public const string NAJOBN = "NAJOBN";

        /// <summary>
        /// NAUSER.
        /// </summary>
        public const string NAUSER = "NAUSER";

        /// <summary>
        /// NAPID.
        /// </summary>
        public const string NAPID = "NAPID";

        /// <summary>
        /// NAUPMJ.
        /// </summary>
        public const string NAUPMJ = "NAUPMJ";

        /// <summary>
        /// NATBL.
        /// </summary>
        public const string NATBL = "NATBL";

        /// <summary>
        /// NAMGTF.
        /// </summary>
        public const string NAMGTF = "NAMGTF";

        /// <summary>
        /// NAICST.
        /// </summary>
        public const string NAICST = "NAICST";

        /// <summary>
        /// NARNTC.
        /// </summary>
        public const string NARNTC = "NARNTC";

        /// <summary>
        /// NAPJCC.
        /// </summary>
        public const string NAPJCC = "NAPJCC";

        /// <summary>
        /// NAUPMT.
        /// </summary>
        public const string NAUPMT = "NAUPMT";

        /// <summary>
        /// NALAFF.
        /// </summary>
        public const string NALAFF = "NALAFF";

        /// <summary>
        /// NALELL.
        /// </summary>
        public const string NALELL = "NALELL";

        /// <summary>
        /// NALEROUA.
        /// </summary>
        public const string NALEROUA = "NALEROUA";
    }

    /// <inheritdoc />
    public override string TableName => "F1512";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NAGLC", "NAGLC", JdeDataType.String, 8, true, true),
        new JdeField("NAMCU", "NAMCU", JdeDataType.String, 24, true, true),
        new JdeField("NADL01", "NADL01", JdeDataType.String, 60),
        new JdeField("NAGRPC", "NAGRPC", JdeDataType.String, 2),
        new JdeField("NATNAR", "NATNAR", JdeDataType.String, 2),
        new JdeField("NALTFE", "NALTFE", JdeDataType.String, 2),
        new JdeField("NAMGFE", "NAMGFE", JdeDataType.String, 2),
        new JdeField("NAPRAP", "NAPRAP", JdeDataType.Numeric),
        new JdeField("NAAPPC", "NAAPPC", JdeDataType.String, 2),
        new JdeField("NAALLW", "NAALLW", JdeDataType.String, 2),
        new JdeField("NACONS", "NACONS", JdeDataType.String, 2),
        new JdeField("NAAUTS", "NAAUTS", JdeDataType.String, 2),
        new JdeField("NASPCD", "NASPCD", JdeDataType.String, 2),
        new JdeField("NASECG", "NASECG", JdeDataType.String, 2),
        new JdeField("NAGRPU", "NAGRPU", JdeDataType.String, 2),
        new JdeField("NABRAJ", "NABRAJ", JdeDataType.String, 2),
        new JdeField("NASTAX", "NASTAX", JdeDataType.String, 2),
        new JdeField("NAAPLY", "NAAPLY", JdeDataType.String, 8),
        new JdeField("NACMNT", "NACMNT", JdeDataType.String, 2),
        new JdeField("NAADEP", "NAADEP", JdeDataType.String, 2),
        new JdeField("NACLSS", "NACLSS", JdeDataType.String, 6),
        new JdeField("NAADJR", "NAADJR", JdeDataType.String, 4),
        new JdeField("NAJOBN", "NAJOBN", JdeDataType.String, 20),
        new JdeField("NAUSER", "NAUSER", JdeDataType.String, 20),
        new JdeField("NAPID", "NAPID", JdeDataType.String, 20),
        new JdeField("NAUPMJ", "NAUPMJ", JdeDataType.Numeric),
        new JdeField("NATBL", "NATBL", JdeDataType.String, 6),
        new JdeField("NAMGTF", "NAMGTF", JdeDataType.String, 2),
        new JdeField("NAICST", "NAICST", JdeDataType.String, 2),
        new JdeField("NARNTC", "NARNTC", JdeDataType.String, 2),
        new JdeField("NAPJCC", "NAPJCC", JdeDataType.Numeric),
        new JdeField("NAUPMT", "NAUPMT", JdeDataType.Numeric),
        new JdeField("NALAFF", "NALAFF", JdeDataType.String, 2),
        new JdeField("NALELL", "NALELL", JdeDataType.String, 2),
        new JdeField("NALEROUA", "NALEROUA", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1512_0", "Primary Key on NAGLC, NAMCU", new[] { "NAGLC", "NAMCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1512_2", "Index on NACLSS, NAAPPC, NAMCU", new[] { "NACLSS", "NAAPPC", "NAMCU" }),
        new JdeIndex("F1512_3", "Index on NAMCU", new[] { "NAMCU" }),
        new JdeIndex("F1512_4", "Index on NAPJCC", new[] { "NAPJCC" })
    };
}
