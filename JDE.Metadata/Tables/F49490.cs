using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49490 - .
/// </summary>
public class F49490 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TQSHPN.
        /// </summary>
        public const string TQSHPN = "TQSHPN";

        /// <summary>
        /// TQRSSN.
        /// </summary>
        public const string TQRSSN = "TQRSSN";

        /// <summary>
        /// TQDSET.
        /// </summary>
        public const string TQDSET = "TQDSET";

        /// <summary>
        /// TQDCCD.
        /// </summary>
        public const string TQDCCD = "TQDCCD";

        /// <summary>
        /// TQCARS.
        /// </summary>
        public const string TQCARS = "TQCARS";

        /// <summary>
        /// TQVMCU.
        /// </summary>
        public const string TQVMCU = "TQVMCU";

        /// <summary>
        /// TQLDNM.
        /// </summary>
        public const string TQLDNM = "TQLDNM";

        /// <summary>
        /// TQTRPL.
        /// </summary>
        public const string TQTRPL = "TQTRPL";

        /// <summary>
        /// TQSEQ.
        /// </summary>
        public const string TQSEQ = "TQSEQ";

        /// <summary>
        /// TQPIDU.
        /// </summary>
        public const string TQPIDU = "TQPIDU";

        /// <summary>
        /// TQDOCO.
        /// </summary>
        public const string TQDOCO = "TQDOCO";

        /// <summary>
        /// TQDCTO.
        /// </summary>
        public const string TQDCTO = "TQDCTO";

        /// <summary>
        /// TQKCOO.
        /// </summary>
        public const string TQKCOO = "TQKCOO";

        /// <summary>
        /// TQLNID.
        /// </summary>
        public const string TQLNID = "TQLNID";

        /// <summary>
        /// TQSRCO.
        /// </summary>
        public const string TQSRCO = "TQSRCO";

        /// <summary>
        /// TQSHAN.
        /// </summary>
        public const string TQSHAN = "TQSHAN";

        /// <summary>
        /// TQITM.
        /// </summary>
        public const string TQITM = "TQITM";

        /// <summary>
        /// TQURCD.
        /// </summary>
        public const string TQURCD = "TQURCD";

        /// <summary>
        /// TQURDT.
        /// </summary>
        public const string TQURDT = "TQURDT";

        /// <summary>
        /// TQURAT.
        /// </summary>
        public const string TQURAT = "TQURAT";

        /// <summary>
        /// TQURAB.
        /// </summary>
        public const string TQURAB = "TQURAB";

        /// <summary>
        /// TQURRF.
        /// </summary>
        public const string TQURRF = "TQURRF";

        /// <summary>
        /// TQUSER.
        /// </summary>
        public const string TQUSER = "TQUSER";

        /// <summary>
        /// TQPID.
        /// </summary>
        public const string TQPID = "TQPID";

        /// <summary>
        /// TQJOBN.
        /// </summary>
        public const string TQJOBN = "TQJOBN";

        /// <summary>
        /// TQUPMJ.
        /// </summary>
        public const string TQUPMJ = "TQUPMJ";

        /// <summary>
        /// TQTDAY.
        /// </summary>
        public const string TQTDAY = "TQTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F49490";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TQSHPN", "TQSHPN", JdeDataType.Numeric, null, true, true),
        new JdeField("TQRSSN", "TQRSSN", JdeDataType.Numeric, null, true, true),
        new JdeField("TQDSET", "TQDSET", JdeDataType.String, 6, true, true),
        new JdeField("TQDCCD", "TQDCCD", JdeDataType.String, 8, true, true),
        new JdeField("TQCARS", "TQCARS", JdeDataType.Numeric),
        new JdeField("TQVMCU", "TQVMCU", JdeDataType.String, 24),
        new JdeField("TQLDNM", "TQLDNM", JdeDataType.Numeric),
        new JdeField("TQTRPL", "TQTRPL", JdeDataType.Numeric),
        new JdeField("TQSEQ", "TQSEQ", JdeDataType.Numeric),
        new JdeField("TQPIDU", "TQPIDU", JdeDataType.String, 2),
        new JdeField("TQDOCO", "TQDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("TQDCTO", "TQDCTO", JdeDataType.String, 4, true, true),
        new JdeField("TQKCOO", "TQKCOO", JdeDataType.String, 10, true, true),
        new JdeField("TQLNID", "TQLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("TQSRCO", "TQSRCO", JdeDataType.String, 2),
        new JdeField("TQSHAN", "TQSHAN", JdeDataType.Numeric),
        new JdeField("TQITM", "TQITM", JdeDataType.Numeric),
        new JdeField("TQURCD", "TQURCD", JdeDataType.String, 4),
        new JdeField("TQURDT", "TQURDT", JdeDataType.Numeric),
        new JdeField("TQURAT", "TQURAT", JdeDataType.Numeric),
        new JdeField("TQURAB", "TQURAB", JdeDataType.Numeric),
        new JdeField("TQURRF", "TQURRF", JdeDataType.String, 30),
        new JdeField("TQUSER", "TQUSER", JdeDataType.String, 20),
        new JdeField("TQPID", "TQPID", JdeDataType.String, 20),
        new JdeField("TQJOBN", "TQJOBN", JdeDataType.String, 20),
        new JdeField("TQUPMJ", "TQUPMJ", JdeDataType.Numeric),
        new JdeField("TQTDAY", "TQTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49490_0", "Primary Key on TQSHPN, TQRSSN, TQDSET, TQDCCD, TQDOCO, TQDCTO, TQKCOO, TQLNID", new[] { "TQSHPN", "TQRSSN", "TQDSET", "TQDCCD", "TQDOCO", "TQDCTO", "TQKCOO", "TQLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F49490_2", "Index on TQSHPN, TQDOCO, TQDCTO, TQKCOO, TQLNID, TQPIDU", new[] { "TQSHPN", "TQDOCO", "TQDCTO", "TQKCOO", "TQLNID", "TQPIDU" }),
        new JdeIndex("F49490_3", "Index on TQSHPN, TQDOCO, TQDCTO, TQKCOO, TQLNID, TQDCCD", new[] { "TQSHPN", "TQDOCO", "TQDCTO", "TQKCOO", "TQLNID", "TQDCCD" }),
        new JdeIndex("F49490_4", "Index on TQVMCU, TQLDNM, TQDCCD", new[] { "TQVMCU", "TQLDNM", "TQDCCD" }),
        new JdeIndex("F49490_6", "Index on TQSHPN, TQRSSN, TQDCCD", new[] { "TQSHPN", "TQRSSN", "TQDCCD" })
    };
}
