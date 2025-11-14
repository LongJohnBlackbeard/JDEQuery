using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1205P - .
/// </summary>
public class F1205P : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FTNUMB.
        /// </summary>
        public const string FTNUMB = "FTNUMB";

        /// <summary>
        /// FTALPH.
        /// </summary>
        public const string FTALPH = "FTALPH";

        /// <summary>
        /// FTEXPL.
        /// </summary>
        public const string FTEXPL = "FTEXPL";

        /// <summary>
        /// FTDTE.
        /// </summary>
        public const string FTDTE = "FTDTE";

        /// <summary>
        /// FTDTE#.
        /// </summary>
        public const string FTDTE_ = "FTDTE#";

        /// <summary>
        /// FTTDAY.
        /// </summary>
        public const string FTTDAY = "FTTDAY";

        /// <summary>
        /// FTTDT.
        /// </summary>
        public const string FTTDT = "FTTDT";

        /// <summary>
        /// FTMOH.
        /// </summary>
        public const string FTMOH = "FTMOH";

        /// <summary>
        /// FTEMT.
        /// </summary>
        public const string FTEMT = "FTEMT";

        /// <summary>
        /// FTITST.
        /// </summary>
        public const string FTITST = "FTITST";

        /// <summary>
        /// FTUSER.
        /// </summary>
        public const string FTUSER = "FTUSER";

        /// <summary>
        /// FTLCT.
        /// </summary>
        public const string FTLCT = "FTLCT";

        /// <summary>
        /// FTPID.
        /// </summary>
        public const string FTPID = "FTPID";

        /// <summary>
        /// FTDSVJ.
        /// </summary>
        public const string FTDSVJ = "FTDSVJ";

        /// <summary>
        /// FTASPU.
        /// </summary>
        public const string FTASPU = "FTASPU";

        /// <summary>
        /// FTASSU.
        /// </summary>
        public const string FTASSU = "FTASSU";

        /// <summary>
        /// FTASD.
        /// </summary>
        public const string FTASD = "FTASD";

        /// <summary>
        /// FTAALM.
        /// </summary>
        public const string FTAALM = "FTAALM";

        /// <summary>
        /// FTAALP.
        /// </summary>
        public const string FTAALP = "FTAALP";

        /// <summary>
        /// FTAALS.
        /// </summary>
        public const string FTAALS = "FTAALS";

        /// <summary>
        /// FTAALD.
        /// </summary>
        public const string FTAALD = "FTAALD";

        /// <summary>
        /// FTCMM.
        /// </summary>
        public const string FTCMM = "FTCMM";

        /// <summary>
        /// FTCMPU.
        /// </summary>
        public const string FTCMPU = "FTCMPU";

        /// <summary>
        /// FTCMSU.
        /// </summary>
        public const string FTCMSU = "FTCMSU";

        /// <summary>
        /// FTCMDY.
        /// </summary>
        public const string FTCMDY = "FTCMDY";

        /// <summary>
        /// FTDTEJ.
        /// </summary>
        public const string FTDTEJ = "FTDTEJ";

        /// <summary>
        /// FTJOBN.
        /// </summary>
        public const string FTJOBN = "FTJOBN";

        /// <summary>
        /// FTUPMT.
        /// </summary>
        public const string FTUPMT = "FTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1205P";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FTNUMB", "FTNUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("FTALPH", "FTALPH", JdeDataType.String, 80),
        new JdeField("FTEXPL", "FTEXPL", JdeDataType.String, 2400),
        new JdeField("FTDTE", "FTDTE", JdeDataType.Numeric),
        new JdeField("FTDTE#", "FTDTE#", JdeDataType.Numeric),
        new JdeField("FTTDAY", "FTTDAY", JdeDataType.Numeric, null, true, true),
        new JdeField("FTTDT", "FTTDT", JdeDataType.Numeric),
        new JdeField("FTMOH", "FTMOH", JdeDataType.Numeric),
        new JdeField("FTEMT", "FTEMT", JdeDataType.String, 2),
        new JdeField("FTITST", "FTITST", JdeDataType.String, 2),
        new JdeField("FTUSER", "FTUSER", JdeDataType.String, 20),
        new JdeField("FTLCT", "FTLCT", JdeDataType.Numeric),
        new JdeField("FTPID", "FTPID", JdeDataType.String, 20),
        new JdeField("FTDSVJ", "FTDSVJ", JdeDataType.Numeric),
        new JdeField("FTASPU", "FTASPU", JdeDataType.Numeric),
        new JdeField("FTASSU", "FTASSU", JdeDataType.Numeric),
        new JdeField("FTASD", "FTASD", JdeDataType.Numeric),
        new JdeField("FTAALM", "FTAALM", JdeDataType.Numeric),
        new JdeField("FTAALP", "FTAALP", JdeDataType.Numeric),
        new JdeField("FTAALS", "FTAALS", JdeDataType.Numeric),
        new JdeField("FTAALD", "FTAALD", JdeDataType.Numeric),
        new JdeField("FTCMM", "FTCMM", JdeDataType.String, 2),
        new JdeField("FTCMPU", "FTCMPU", JdeDataType.String, 2),
        new JdeField("FTCMSU", "FTCMSU", JdeDataType.String, 2),
        new JdeField("FTCMDY", "FTCMDY", JdeDataType.String, 2),
        new JdeField("FTDTEJ", "FTDTEJ", JdeDataType.Numeric, null, true, true),
        new JdeField("FTJOBN", "FTJOBN", JdeDataType.String, 20),
        new JdeField("FTUPMT", "FTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1205P_0", "Primary Key on FTNUMB, FTDTEJ, FTTDAY", new[] { "FTNUMB", "FTDTEJ", "FTTDAY" }, isUnique: true, isPrimaryKey: true)
    };
}
