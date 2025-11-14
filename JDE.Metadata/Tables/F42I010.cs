using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42I010 - .
/// </summary>
public class F42I010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OHDMCT.
        /// </summary>
        public const string OHDMCT = "OHDMCT";

        /// <summary>
        /// OHDMCS.
        /// </summary>
        public const string OHDMCS = "OHDMCS";

        /// <summary>
        /// OHAGTP.
        /// </summary>
        public const string OHAGTP = "OHAGTP";

        /// <summary>
        /// OHPOCUST.
        /// </summary>
        public const string OHPOCUST = "OHPOCUST";

        /// <summary>
        /// OHAN8.
        /// </summary>
        public const string OHAN8 = "OHAN8";

        /// <summary>
        /// OHMLNM.
        /// </summary>
        public const string OHMLNM = "OHMLNM";

        /// <summary>
        /// OHACTON.
        /// </summary>
        public const string OHACTON = "OHACTON";

        /// <summary>
        /// OHSQNBR.
        /// </summary>
        public const string OHSQNBR = "OHSQNBR";

        /// <summary>
        /// OHRFC1.
        /// </summary>
        public const string OHRFC1 = "OHRFC1";

        /// <summary>
        /// OHRFC2.
        /// </summary>
        public const string OHRFC2 = "OHRFC2";

        /// <summary>
        /// OHRFC3.
        /// </summary>
        public const string OHRFC3 = "OHRFC3";

        /// <summary>
        /// OHRFC4.
        /// </summary>
        public const string OHRFC4 = "OHRFC4";

        /// <summary>
        /// OHUSER.
        /// </summary>
        public const string OHUSER = "OHUSER";

        /// <summary>
        /// OHPID.
        /// </summary>
        public const string OHPID = "OHPID";

        /// <summary>
        /// OHJOBN.
        /// </summary>
        public const string OHJOBN = "OHJOBN";

        /// <summary>
        /// OHUPMJ.
        /// </summary>
        public const string OHUPMJ = "OHUPMJ";

        /// <summary>
        /// OHTDAY.
        /// </summary>
        public const string OHTDAY = "OHTDAY";

        /// <summary>
        /// OHFUTCHAR9.
        /// </summary>
        public const string OHFUTCHAR9 = "OHFUTCHAR9";

        /// <summary>
        /// OHFUCHAR1.
        /// </summary>
        public const string OHFUCHAR1 = "OHFUCHAR1";

        /// <summary>
        /// OHFUCHAR2.
        /// </summary>
        public const string OHFUCHAR2 = "OHFUCHAR2";

        /// <summary>
        /// OHFUNUM7.
        /// </summary>
        public const string OHFUNUM7 = "OHFUNUM7";

        /// <summary>
        /// OHFUNUM8.
        /// </summary>
        public const string OHFUNUM8 = "OHFUNUM8";

        /// <summary>
        /// OHFUNUM9.
        /// </summary>
        public const string OHFUNUM9 = "OHFUNUM9";

        /// <summary>
        /// OHFUTSTR7.
        /// </summary>
        public const string OHFUTSTR7 = "OHFUTSTR7";

        /// <summary>
        /// OHFUTSTR8.
        /// </summary>
        public const string OHFUTSTR8 = "OHFUTSTR8";

        /// <summary>
        /// OHFUTSTR9.
        /// </summary>
        public const string OHFUTSTR9 = "OHFUTSTR9";

        /// <summary>
        /// OHFUDT3.
        /// </summary>
        public const string OHFUDT3 = "OHFUDT3";

        /// <summary>
        /// OHFUDT16.
        /// </summary>
        public const string OHFUDT16 = "OHFUDT16";

        /// <summary>
        /// OHFUDT26.
        /// </summary>
        public const string OHFUDT26 = "OHFUDT26";

        /// <summary>
        /// OHURAT.
        /// </summary>
        public const string OHURAT = "OHURAT";

        /// <summary>
        /// OHURCD.
        /// </summary>
        public const string OHURCD = "OHURCD";

        /// <summary>
        /// OHURDT.
        /// </summary>
        public const string OHURDT = "OHURDT";

        /// <summary>
        /// OHURAB.
        /// </summary>
        public const string OHURAB = "OHURAB";

        /// <summary>
        /// OHURRF.
        /// </summary>
        public const string OHURRF = "OHURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F42I010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OHDMCT", "OHDMCT", JdeDataType.String, 24, true, true),
        new JdeField("OHDMCS", "OHDMCS", JdeDataType.Numeric, null, true, true),
        new JdeField("OHAGTP", "OHAGTP", JdeDataType.String, 6),
        new JdeField("OHPOCUST", "OHPOCUST", JdeDataType.String, 50),
        new JdeField("OHAN8", "OHAN8", JdeDataType.Numeric),
        new JdeField("OHMLNM", "OHMLNM", JdeDataType.String, 80),
        new JdeField("OHACTON", "OHACTON", JdeDataType.String, 2),
        new JdeField("OHSQNBR", "OHSQNBR", JdeDataType.Numeric),
        new JdeField("OHRFC1", "OHRFC1", JdeDataType.String, 50),
        new JdeField("OHRFC2", "OHRFC2", JdeDataType.String, 50),
        new JdeField("OHRFC3", "OHRFC3", JdeDataType.String, 50),
        new JdeField("OHRFC4", "OHRFC4", JdeDataType.String, 50),
        new JdeField("OHUSER", "OHUSER", JdeDataType.String, 20),
        new JdeField("OHPID", "OHPID", JdeDataType.String, 20),
        new JdeField("OHJOBN", "OHJOBN", JdeDataType.String, 20),
        new JdeField("OHUPMJ", "OHUPMJ", JdeDataType.Numeric),
        new JdeField("OHTDAY", "OHTDAY", JdeDataType.Numeric),
        new JdeField("OHFUTCHAR9", "OHFUTCHAR9", JdeDataType.String, 2),
        new JdeField("OHFUCHAR1", "OHFUCHAR1", JdeDataType.String, 2),
        new JdeField("OHFUCHAR2", "OHFUCHAR2", JdeDataType.String, 2),
        new JdeField("OHFUNUM7", "OHFUNUM7", JdeDataType.Numeric),
        new JdeField("OHFUNUM8", "OHFUNUM8", JdeDataType.Numeric),
        new JdeField("OHFUNUM9", "OHFUNUM9", JdeDataType.Numeric),
        new JdeField("OHFUTSTR7", "OHFUTSTR7", JdeDataType.String, 100),
        new JdeField("OHFUTSTR8", "OHFUTSTR8", JdeDataType.String, 100),
        new JdeField("OHFUTSTR9", "OHFUTSTR9", JdeDataType.String, 100),
        new JdeField("OHFUDT3", "OHFUDT3", JdeDataType.Numeric),
        new JdeField("OHFUDT16", "OHFUDT16", JdeDataType.Numeric),
        new JdeField("OHFUDT26", "OHFUDT26", JdeDataType.Numeric),
        new JdeField("OHURAT", "OHURAT", JdeDataType.Numeric),
        new JdeField("OHURCD", "OHURCD", JdeDataType.String, 4),
        new JdeField("OHURDT", "OHURDT", JdeDataType.Numeric),
        new JdeField("OHURAB", "OHURAB", JdeDataType.Numeric),
        new JdeField("OHURRF", "OHURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42I010_0", "Primary Key on OHDMCT, OHDMCS", new[] { "OHDMCT", "OHDMCS" }, isUnique: true, isPrimaryKey: true)
    };
}
