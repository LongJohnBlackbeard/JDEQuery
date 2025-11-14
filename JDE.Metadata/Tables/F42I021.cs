using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42I021 - .
/// </summary>
public class F42I021 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OQDMCT.
        /// </summary>
        public const string OQDMCT = "OQDMCT";

        /// <summary>
        /// OQDMCS.
        /// </summary>
        public const string OQDMCS = "OQDMCS";

        /// <summary>
        /// OQSEQ.
        /// </summary>
        public const string OQSEQ = "OQSEQ";

        /// <summary>
        /// OQAGTP.
        /// </summary>
        public const string OQAGTP = "OQAGTP";

        /// <summary>
        /// OQDMSC.
        /// </summary>
        public const string OQDMSC = "OQDMSC";

        /// <summary>
        /// OQUOMA.
        /// </summary>
        public const string OQUOMA = "OQUOMA";

        /// <summary>
        /// OQAN8.
        /// </summary>
        public const string OQAN8 = "OQAN8";

        /// <summary>
        /// OQSHAN.
        /// </summary>
        public const string OQSHAN = "OQSHAN";

        /// <summary>
        /// OQMCU.
        /// </summary>
        public const string OQMCU = "OQMCU";

        /// <summary>
        /// OQITM.
        /// </summary>
        public const string OQITM = "OQITM";

        /// <summary>
        /// OQLITM.
        /// </summary>
        public const string OQLITM = "OQLITM";

        /// <summary>
        /// OQUOM1.
        /// </summary>
        public const string OQUOM1 = "OQUOM1";

        /// <summary>
        /// OQUOM2.
        /// </summary>
        public const string OQUOM2 = "OQUOM2";

        /// <summary>
        /// OQOLTY.
        /// </summary>
        public const string OQOLTY = "OQOLTY";

        /// <summary>
        /// OQLOCN.
        /// </summary>
        public const string OQLOCN = "OQLOCN";

        /// <summary>
        /// OQLOTN.
        /// </summary>
        public const string OQLOTN = "OQLOTN";

        /// <summary>
        /// OQAGQOH.
        /// </summary>
        public const string OQAGQOH = "OQAGQOH";

        /// <summary>
        /// OQSGQOH.
        /// </summary>
        public const string OQSGQOH = "OQSGQOH";

        /// <summary>
        /// OQAGQCOM.
        /// </summary>
        public const string OQAGQCOM = "OQAGQCOM";

        /// <summary>
        /// OQSGQCOM.
        /// </summary>
        public const string OQSGQCOM = "OQSGQCOM";

        /// <summary>
        /// OQAGQIN.
        /// </summary>
        public const string OQAGQIN = "OQAGQIN";

        /// <summary>
        /// OQSGQIN.
        /// </summary>
        public const string OQSGQIN = "OQSGQIN";

        /// <summary>
        /// OQAGQTR.
        /// </summary>
        public const string OQAGQTR = "OQAGQTR";

        /// <summary>
        /// OQSGQTR.
        /// </summary>
        public const string OQSGQTR = "OQSGQTR";

        /// <summary>
        /// OQAGQOR.
        /// </summary>
        public const string OQAGQOR = "OQAGQOR";

        /// <summary>
        /// OQSGQOR.
        /// </summary>
        public const string OQSGQOR = "OQSGQOR";

        /// <summary>
        /// OQAGRQTY.
        /// </summary>
        public const string OQAGRQTY = "OQAGRQTY";

        /// <summary>
        /// OQSGRQTY.
        /// </summary>
        public const string OQSGRQTY = "OQSGRQTY";

        /// <summary>
        /// OQAGWQTY.
        /// </summary>
        public const string OQAGWQTY = "OQAGWQTY";

        /// <summary>
        /// OQSGWQTY.
        /// </summary>
        public const string OQSGWQTY = "OQSGWQTY";

        /// <summary>
        /// OQCONQTY.
        /// </summary>
        public const string OQCONQTY = "OQCONQTY";

        /// <summary>
        /// OQSCONQTY.
        /// </summary>
        public const string OQSCONQTY = "OQSCONQTY";

        /// <summary>
        /// OQACKDT.
        /// </summary>
        public const string OQACKDT = "OQACKDT";

        /// <summary>
        /// OQRCVDT.
        /// </summary>
        public const string OQRCVDT = "OQRCVDT";

        /// <summary>
        /// OQCONDT.
        /// </summary>
        public const string OQCONDT = "OQCONDT";

        /// <summary>
        /// OQCONRDT.
        /// </summary>
        public const string OQCONRDT = "OQCONRDT";

        /// <summary>
        /// OQAGTCT.
        /// </summary>
        public const string OQAGTCT = "OQAGTCT";

        /// <summary>
        /// OQOIPR.
        /// </summary>
        public const string OQOIPR = "OQOIPR";

        /// <summary>
        /// OQPRSEQ.
        /// </summary>
        public const string OQPRSEQ = "OQPRSEQ";

        /// <summary>
        /// OQPID.
        /// </summary>
        public const string OQPID = "OQPID";

        /// <summary>
        /// OQJOBN.
        /// </summary>
        public const string OQJOBN = "OQJOBN";

        /// <summary>
        /// OQUSER.
        /// </summary>
        public const string OQUSER = "OQUSER";

        /// <summary>
        /// OQUPMJ.
        /// </summary>
        public const string OQUPMJ = "OQUPMJ";

        /// <summary>
        /// OQTDAY.
        /// </summary>
        public const string OQTDAY = "OQTDAY";

        /// <summary>
        /// OQFUC1.
        /// </summary>
        public const string OQFUC1 = "OQFUC1";

        /// <summary>
        /// OQFUC2.
        /// </summary>
        public const string OQFUC2 = "OQFUC2";

        /// <summary>
        /// OQFUC3.
        /// </summary>
        public const string OQFUC3 = "OQFUC3";

        /// <summary>
        /// OQFUN4.
        /// </summary>
        public const string OQFUN4 = "OQFUN4";

        /// <summary>
        /// OQFUN5.
        /// </summary>
        public const string OQFUN5 = "OQFUN5";

        /// <summary>
        /// OQFUN6.
        /// </summary>
        public const string OQFUN6 = "OQFUN6";

        /// <summary>
        /// OQFUS1.
        /// </summary>
        public const string OQFUS1 = "OQFUS1";

        /// <summary>
        /// OQFUS2.
        /// </summary>
        public const string OQFUS2 = "OQFUS2";

        /// <summary>
        /// OQFUS3.
        /// </summary>
        public const string OQFUS3 = "OQFUS3";

        /// <summary>
        /// OQFUDT8.
        /// </summary>
        public const string OQFUDT8 = "OQFUDT8";

        /// <summary>
        /// OQFUDT19.
        /// </summary>
        public const string OQFUDT19 = "OQFUDT19";

        /// <summary>
        /// OQFUDT29.
        /// </summary>
        public const string OQFUDT29 = "OQFUDT29";

        /// <summary>
        /// OQURAT.
        /// </summary>
        public const string OQURAT = "OQURAT";

        /// <summary>
        /// OQURCD.
        /// </summary>
        public const string OQURCD = "OQURCD";

        /// <summary>
        /// OQURDT.
        /// </summary>
        public const string OQURDT = "OQURDT";

        /// <summary>
        /// OQURAB.
        /// </summary>
        public const string OQURAB = "OQURAB";

        /// <summary>
        /// OQURRF.
        /// </summary>
        public const string OQURRF = "OQURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F42I021";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OQDMCT", "OQDMCT", JdeDataType.String, 24, true, true),
        new JdeField("OQDMCS", "OQDMCS", JdeDataType.Numeric, null, true, true),
        new JdeField("OQSEQ", "OQSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("OQAGTP", "OQAGTP", JdeDataType.String, 6),
        new JdeField("OQDMSC", "OQDMSC", JdeDataType.String, 2),
        new JdeField("OQUOMA", "OQUOMA", JdeDataType.String, 4),
        new JdeField("OQAN8", "OQAN8", JdeDataType.Numeric),
        new JdeField("OQSHAN", "OQSHAN", JdeDataType.Numeric, null, true, true),
        new JdeField("OQMCU", "OQMCU", JdeDataType.String, 24),
        new JdeField("OQITM", "OQITM", JdeDataType.Numeric),
        new JdeField("OQLITM", "OQLITM", JdeDataType.String, 50),
        new JdeField("OQUOM1", "OQUOM1", JdeDataType.String, 4),
        new JdeField("OQUOM2", "OQUOM2", JdeDataType.String, 4),
        new JdeField("OQOLTY", "OQOLTY", JdeDataType.String, 6),
        new JdeField("OQLOCN", "OQLOCN", JdeDataType.String, 40, true, true),
        new JdeField("OQLOTN", "OQLOTN", JdeDataType.String, 60, true, true),
        new JdeField("OQAGQOH", "OQAGQOH", JdeDataType.Numeric),
        new JdeField("OQSGQOH", "OQSGQOH", JdeDataType.Numeric),
        new JdeField("OQAGQCOM", "OQAGQCOM", JdeDataType.Numeric),
        new JdeField("OQSGQCOM", "OQSGQCOM", JdeDataType.Numeric),
        new JdeField("OQAGQIN", "OQAGQIN", JdeDataType.Numeric),
        new JdeField("OQSGQIN", "OQSGQIN", JdeDataType.Numeric),
        new JdeField("OQAGQTR", "OQAGQTR", JdeDataType.Numeric),
        new JdeField("OQSGQTR", "OQSGQTR", JdeDataType.Numeric),
        new JdeField("OQAGQOR", "OQAGQOR", JdeDataType.Numeric),
        new JdeField("OQSGQOR", "OQSGQOR", JdeDataType.Numeric),
        new JdeField("OQAGRQTY", "OQAGRQTY", JdeDataType.Numeric),
        new JdeField("OQSGRQTY", "OQSGRQTY", JdeDataType.Numeric),
        new JdeField("OQAGWQTY", "OQAGWQTY", JdeDataType.Numeric),
        new JdeField("OQSGWQTY", "OQSGWQTY", JdeDataType.Numeric),
        new JdeField("OQCONQTY", "OQCONQTY", JdeDataType.Numeric),
        new JdeField("OQSCONQTY", "OQSCONQTY", JdeDataType.Numeric),
        new JdeField("OQACKDT", "OQACKDT", JdeDataType.Numeric),
        new JdeField("OQRCVDT", "OQRCVDT", JdeDataType.Numeric),
        new JdeField("OQCONDT", "OQCONDT", JdeDataType.Numeric),
        new JdeField("OQCONRDT", "OQCONRDT", JdeDataType.Numeric),
        new JdeField("OQAGTCT", "OQAGTCT", JdeDataType.Numeric),
        new JdeField("OQOIPR", "OQOIPR", JdeDataType.String, 16),
        new JdeField("OQPRSEQ", "OQPRSEQ", JdeDataType.Numeric),
        new JdeField("OQPID", "OQPID", JdeDataType.String, 20),
        new JdeField("OQJOBN", "OQJOBN", JdeDataType.String, 20),
        new JdeField("OQUSER", "OQUSER", JdeDataType.String, 20),
        new JdeField("OQUPMJ", "OQUPMJ", JdeDataType.Numeric),
        new JdeField("OQTDAY", "OQTDAY", JdeDataType.Numeric),
        new JdeField("OQFUC1", "OQFUC1", JdeDataType.String, 2),
        new JdeField("OQFUC2", "OQFUC2", JdeDataType.String, 2),
        new JdeField("OQFUC3", "OQFUC3", JdeDataType.String, 2),
        new JdeField("OQFUN4", "OQFUN4", JdeDataType.Numeric),
        new JdeField("OQFUN5", "OQFUN5", JdeDataType.Numeric),
        new JdeField("OQFUN6", "OQFUN6", JdeDataType.Numeric),
        new JdeField("OQFUS1", "OQFUS1", JdeDataType.String, 100),
        new JdeField("OQFUS2", "OQFUS2", JdeDataType.String, 100),
        new JdeField("OQFUS3", "OQFUS3", JdeDataType.String, 100),
        new JdeField("OQFUDT8", "OQFUDT8", JdeDataType.Numeric),
        new JdeField("OQFUDT19", "OQFUDT19", JdeDataType.Numeric),
        new JdeField("OQFUDT29", "OQFUDT29", JdeDataType.Numeric),
        new JdeField("OQURAT", "OQURAT", JdeDataType.Numeric),
        new JdeField("OQURCD", "OQURCD", JdeDataType.String, 4),
        new JdeField("OQURDT", "OQURDT", JdeDataType.Numeric),
        new JdeField("OQURAB", "OQURAB", JdeDataType.Numeric),
        new JdeField("OQURRF", "OQURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42I021_0", "Primary Key on OQDMCT, OQDMCS, OQSEQ, OQSHAN, OQLOCN, OQLOTN", new[] { "OQDMCT", "OQDMCS", "OQSEQ", "OQSHAN", "OQLOCN", "OQLOTN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F42I021_2", "Index on OQDMCT, OQDMCS, OQSEQ", new[] { "OQDMCT", "OQDMCS", "OQSEQ" }),
        new JdeIndex("F42I021_3", "Index on OQDMCT, OQDMCS, OQSEQ, OQOLTY", new[] { "OQDMCT", "OQDMCS", "OQSEQ", "OQOLTY" })
    };
}
