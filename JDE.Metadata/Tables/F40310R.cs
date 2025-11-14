using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40310R - .
/// </summary>
public class F40310R : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LBUKID.
        /// </summary>
        public const string LBUKID = "LBUKID";

        /// <summary>
        /// LBREFC.
        /// </summary>
        public const string LBREFC = "LBREFC";

        /// <summary>
        /// LBAN8.
        /// </summary>
        public const string LBAN8 = "LBAN8";

        /// <summary>
        /// LBCS10.
        /// </summary>
        public const string LBCS10 = "LBCS10";

        /// <summary>
        /// LBITM.
        /// </summary>
        public const string LBITM = "LBITM";

        /// <summary>
        /// LBIT10.
        /// </summary>
        public const string LBIT10 = "LBIT10";

        /// <summary>
        /// LBEFTJ.
        /// </summary>
        public const string LBEFTJ = "LBEFTJ";

        /// <summary>
        /// LBEXDJ.
        /// </summary>
        public const string LBEXDJ = "LBEXDJ";

        /// <summary>
        /// LBMNQ.
        /// </summary>
        public const string LBMNQ = "LBMNQ";

        /// <summary>
        /// LBMXQ.
        /// </summary>
        public const string LBMXQ = "LBMXQ";

        /// <summary>
        /// LBUOM.
        /// </summary>
        public const string LBUOM = "LBUOM";

        /// <summary>
        /// LBTXID.
        /// </summary>
        public const string LBTXID = "LBTXID";

        /// <summary>
        /// LBSTPR.
        /// </summary>
        public const string LBSTPR = "LBSTPR";

        /// <summary>
        /// LBLOB.
        /// </summary>
        public const string LBLOB = "LBLOB";

        /// <summary>
        /// LBURCD.
        /// </summary>
        public const string LBURCD = "LBURCD";

        /// <summary>
        /// LBURDT.
        /// </summary>
        public const string LBURDT = "LBURDT";

        /// <summary>
        /// LBURAT.
        /// </summary>
        public const string LBURAT = "LBURAT";

        /// <summary>
        /// LBURAB.
        /// </summary>
        public const string LBURAB = "LBURAB";

        /// <summary>
        /// LBURRF.
        /// </summary>
        public const string LBURRF = "LBURRF";

        /// <summary>
        /// LBUSER.
        /// </summary>
        public const string LBUSER = "LBUSER";

        /// <summary>
        /// LBPID.
        /// </summary>
        public const string LBPID = "LBPID";

        /// <summary>
        /// LBJOBN.
        /// </summary>
        public const string LBJOBN = "LBJOBN";

        /// <summary>
        /// LBUPMJ.
        /// </summary>
        public const string LBUPMJ = "LBUPMJ";

        /// <summary>
        /// LBTDAY.
        /// </summary>
        public const string LBTDAY = "LBTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40310R";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LBUKID", "LBUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("LBREFC", "LBREFC", JdeDataType.Numeric),
        new JdeField("LBAN8", "LBAN8", JdeDataType.Numeric),
        new JdeField("LBCS10", "LBCS10", JdeDataType.String, 16),
        new JdeField("LBITM", "LBITM", JdeDataType.Numeric),
        new JdeField("LBIT10", "LBIT10", JdeDataType.String, 16),
        new JdeField("LBEFTJ", "LBEFTJ", JdeDataType.Numeric),
        new JdeField("LBEXDJ", "LBEXDJ", JdeDataType.Numeric),
        new JdeField("LBMNQ", "LBMNQ", JdeDataType.Numeric),
        new JdeField("LBMXQ", "LBMXQ", JdeDataType.Numeric),
        new JdeField("LBUOM", "LBUOM", JdeDataType.String, 4),
        new JdeField("LBTXID", "LBTXID", JdeDataType.Numeric),
        new JdeField("LBSTPR", "LBSTPR", JdeDataType.String, 2),
        new JdeField("LBLOB", "LBLOB", JdeDataType.String, 6),
        new JdeField("LBURCD", "LBURCD", JdeDataType.String, 4),
        new JdeField("LBURDT", "LBURDT", JdeDataType.Numeric),
        new JdeField("LBURAT", "LBURAT", JdeDataType.Numeric),
        new JdeField("LBURAB", "LBURAB", JdeDataType.Numeric),
        new JdeField("LBURRF", "LBURRF", JdeDataType.String, 30),
        new JdeField("LBUSER", "LBUSER", JdeDataType.String, 20),
        new JdeField("LBPID", "LBPID", JdeDataType.String, 20),
        new JdeField("LBJOBN", "LBJOBN", JdeDataType.String, 20),
        new JdeField("LBUPMJ", "LBUPMJ", JdeDataType.Numeric),
        new JdeField("LBTDAY", "LBTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40310R_0", "Primary Key on LBUKID", new[] { "LBUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40310R_2", "Index on LBAN8, LBCS10, LBITM, LBIT10, LBEXDJ, LBMXQ, LBUOM, LBLOB, LBUPMJ, LBTDAY", new[] { "LBAN8", "LBCS10", "LBITM", "LBIT10", "LBEXDJ", "LBMXQ", "LBUOM", "LBLOB", "LBUPMJ", "LBTDAY" })
    };
}
