using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1307P - .
/// </summary>
public class F1307P : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// F1NUMR.
        /// </summary>
        public const string F1NUMR = "F1NUMR";

        /// <summary>
        /// F1TREC.
        /// </summary>
        public const string F1TREC = "F1TREC";

        /// <summary>
        /// F1EFTB.
        /// </summary>
        public const string F1EFTB = "F1EFTB";

        /// <summary>
        /// F1BEGT.
        /// </summary>
        public const string F1BEGT = "F1BEGT";

        /// <summary>
        /// F1EWST.
        /// </summary>
        public const string F1EWST = "F1EWST";

        /// <summary>
        /// F1DOCO.
        /// </summary>
        public const string F1DOCO = "F1DOCO";

        /// <summary>
        /// F1EFTE.
        /// </summary>
        public const string F1EFTE = "F1EFTE";

        /// <summary>
        /// F1ENDT.
        /// </summary>
        public const string F1ENDT = "F1ENDT";

        /// <summary>
        /// F1STHR.
        /// </summary>
        public const string F1STHR = "F1STHR";

        /// <summary>
        /// F1CUMH.
        /// </summary>
        public const string F1CUMH = "F1CUMH";

        /// <summary>
        /// F1LFR.
        /// </summary>
        public const string F1LFR = "F1LFR";

        /// <summary>
        /// F1LHR.
        /// </summary>
        public const string F1LHR = "F1LHR";

        /// <summary>
        /// F1LMR.
        /// </summary>
        public const string F1LMR = "F1LMR";

        /// <summary>
        /// F1RMK.
        /// </summary>
        public const string F1RMK = "F1RMK";

        /// <summary>
        /// F1USER.
        /// </summary>
        public const string F1USER = "F1USER";

        /// <summary>
        /// F1PID.
        /// </summary>
        public const string F1PID = "F1PID";

        /// <summary>
        /// F1JOBN.
        /// </summary>
        public const string F1JOBN = "F1JOBN";

        /// <summary>
        /// F1UPMJ.
        /// </summary>
        public const string F1UPMJ = "F1UPMJ";

        /// <summary>
        /// F1UPMT.
        /// </summary>
        public const string F1UPMT = "F1UPMT";

        /// <summary>
        /// F1LM4R.
        /// </summary>
        public const string F1LM4R = "F1LM4R";

        /// <summary>
        /// F1LM5R.
        /// </summary>
        public const string F1LM5R = "F1LM5R";

        /// <summary>
        /// F1LM6R.
        /// </summary>
        public const string F1LM6R = "F1LM6R";
    }

    /// <inheritdoc />
    public override string TableName => "F1307P";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("F1NUMR", "F1NUMR", JdeDataType.Numeric, null, true, true),
        new JdeField("F1TREC", "F1TREC", JdeDataType.String, 2, true, true),
        new JdeField("F1EFTB", "F1EFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("F1BEGT", "F1BEGT", JdeDataType.Numeric, null, true, true),
        new JdeField("F1EWST", "F1EWST", JdeDataType.String, 4, true, true),
        new JdeField("F1DOCO", "F1DOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("F1EFTE", "F1EFTE", JdeDataType.Numeric),
        new JdeField("F1ENDT", "F1ENDT", JdeDataType.Numeric),
        new JdeField("F1STHR", "F1STHR", JdeDataType.Numeric),
        new JdeField("F1CUMH", "F1CUMH", JdeDataType.Numeric),
        new JdeField("F1LFR", "F1LFR", JdeDataType.Numeric),
        new JdeField("F1LHR", "F1LHR", JdeDataType.Numeric),
        new JdeField("F1LMR", "F1LMR", JdeDataType.Numeric),
        new JdeField("F1RMK", "F1RMK", JdeDataType.String, 60),
        new JdeField("F1USER", "F1USER", JdeDataType.String, 20),
        new JdeField("F1PID", "F1PID", JdeDataType.String, 20),
        new JdeField("F1JOBN", "F1JOBN", JdeDataType.String, 20),
        new JdeField("F1UPMJ", "F1UPMJ", JdeDataType.Numeric),
        new JdeField("F1UPMT", "F1UPMT", JdeDataType.Numeric),
        new JdeField("F1LM4R", "F1LM4R", JdeDataType.Numeric),
        new JdeField("F1LM5R", "F1LM5R", JdeDataType.Numeric),
        new JdeField("F1LM6R", "F1LM6R", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1307P_0", "Primary Key on F1TREC, F1NUMR, F1EFTB, F1BEGT, F1EWST, F1DOCO", new[] { "F1TREC", "F1NUMR", "F1EFTB", "F1BEGT", "F1EWST", "F1DOCO" }, isUnique: true, isPrimaryKey: true)
    };
}
