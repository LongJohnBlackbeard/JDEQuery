using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46095T - .
/// </summary>
public class F46095T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TDMCU.
        /// </summary>
        public const string TDMCU = "TDMCU";

        /// <summary>
        /// TDPUTP.
        /// </summary>
        public const string TDPUTP = "TDPUTP";

        /// <summary>
        /// TDMPUT.
        /// </summary>
        public const string TDMPUT = "TDMPUT";

        /// <summary>
        /// TDMPIK.
        /// </summary>
        public const string TDMPIK = "TDMPIK";

        /// <summary>
        /// TDMRPL.
        /// </summary>
        public const string TDMRPL = "TDMRPL";

        /// <summary>
        /// TDSEQ.
        /// </summary>
        public const string TDSEQ = "TDSEQ";

        /// <summary>
        /// TDLPSEQ.
        /// </summary>
        public const string TDLPSEQ = "TDLPSEQ";

        /// <summary>
        /// TDURAT.
        /// </summary>
        public const string TDURAT = "TDURAT";

        /// <summary>
        /// TDURCD.
        /// </summary>
        public const string TDURCD = "TDURCD";

        /// <summary>
        /// TDURDT.
        /// </summary>
        public const string TDURDT = "TDURDT";

        /// <summary>
        /// TDURAB.
        /// </summary>
        public const string TDURAB = "TDURAB";

        /// <summary>
        /// TDURRF.
        /// </summary>
        public const string TDURRF = "TDURRF";

        /// <summary>
        /// TDUSER.
        /// </summary>
        public const string TDUSER = "TDUSER";

        /// <summary>
        /// TDPID.
        /// </summary>
        public const string TDPID = "TDPID";

        /// <summary>
        /// TDJOBN.
        /// </summary>
        public const string TDJOBN = "TDJOBN";

        /// <summary>
        /// TDUPMJ.
        /// </summary>
        public const string TDUPMJ = "TDUPMJ";

        /// <summary>
        /// TDTDAY.
        /// </summary>
        public const string TDTDAY = "TDTDAY";

        /// <summary>
        /// TDCHARF1.
        /// </summary>
        public const string TDCHARF1 = "TDCHARF1";

        /// <summary>
        /// TDCHARF2.
        /// </summary>
        public const string TDCHARF2 = "TDCHARF2";

        /// <summary>
        /// TDINT01F1.
        /// </summary>
        public const string TDINT01F1 = "TDINT01F1";

        /// <summary>
        /// TDLPNPF.
        /// </summary>
        public const string TDLPNPF = "TDLPNPF";

        /// <summary>
        /// TDMIFUC1.
        /// </summary>
        public const string TDMIFUC1 = "TDMIFUC1";

        /// <summary>
        /// TDMIFUC2.
        /// </summary>
        public const string TDMIFUC2 = "TDMIFUC2";

        /// <summary>
        /// TDMIFUS1.
        /// </summary>
        public const string TDMIFUS1 = "TDMIFUS1";

        /// <summary>
        /// TDMIFUS2.
        /// </summary>
        public const string TDMIFUS2 = "TDMIFUS2";

        /// <summary>
        /// TDMIFUN1.
        /// </summary>
        public const string TDMIFUN1 = "TDMIFUN1";
    }

    /// <inheritdoc />
    public override string TableName => "F46095T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TDMCU", "TDMCU", JdeDataType.String, 24, true, true),
        new JdeField("TDPUTP", "TDPUTP", JdeDataType.String, 2, true, true),
        new JdeField("TDMPUT", "TDMPUT", JdeDataType.String, 12, true, true),
        new JdeField("TDMPIK", "TDMPIK", JdeDataType.String, 12, true, true),
        new JdeField("TDMRPL", "TDMRPL", JdeDataType.String, 12, true, true),
        new JdeField("TDSEQ", "TDSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("TDLPSEQ", "TDLPSEQ", JdeDataType.String, 2),
        new JdeField("TDURAT", "TDURAT", JdeDataType.Numeric),
        new JdeField("TDURCD", "TDURCD", JdeDataType.String, 4),
        new JdeField("TDURDT", "TDURDT", JdeDataType.Numeric),
        new JdeField("TDURAB", "TDURAB", JdeDataType.Numeric),
        new JdeField("TDURRF", "TDURRF", JdeDataType.String, 30),
        new JdeField("TDUSER", "TDUSER", JdeDataType.String, 20),
        new JdeField("TDPID", "TDPID", JdeDataType.String, 20),
        new JdeField("TDJOBN", "TDJOBN", JdeDataType.String, 20),
        new JdeField("TDUPMJ", "TDUPMJ", JdeDataType.Numeric),
        new JdeField("TDTDAY", "TDTDAY", JdeDataType.Numeric),
        new JdeField("TDCHARF1", "TDCHARF1", JdeDataType.String, 2),
        new JdeField("TDCHARF2", "TDCHARF2", JdeDataType.String, 2),
        new JdeField("TDINT01F1", "TDINT01F1", JdeDataType.Numeric),
        new JdeField("TDLPNPF", "TDLPNPF", JdeDataType.String, 2),
        new JdeField("TDMIFUC1", "TDMIFUC1", JdeDataType.String, 2),
        new JdeField("TDMIFUC2", "TDMIFUC2", JdeDataType.String, 2),
        new JdeField("TDMIFUS1", "TDMIFUS1", JdeDataType.String, 4),
        new JdeField("TDMIFUS2", "TDMIFUS2", JdeDataType.String, 80),
        new JdeField("TDMIFUN1", "TDMIFUN1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46095T_0", "Primary Key on TDMCU, TDPUTP, TDMPUT, TDMPIK, TDMRPL, TDSEQ", new[] { "TDMCU", "TDPUTP", "TDMPUT", "TDMPIK", "TDMRPL", "TDSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
