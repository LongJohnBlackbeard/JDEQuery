using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B79 - .
/// </summary>
public class F31B79 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DSWCFGID.
        /// </summary>
        public const string DSWCFGID = "DSWCFGID";

        /// <summary>
        /// DSLNID.
        /// </summary>
        public const string DSLNID = "DSLNID";

        /// <summary>
        /// DSSITEM.
        /// </summary>
        public const string DSSITEM = "DSSITEM";

        /// <summary>
        /// DSSVALUE.
        /// </summary>
        public const string DSSVALUE = "DSSVALUE";

        /// <summary>
        /// DSWSTYCF.
        /// </summary>
        public const string DSWSTYCF = "DSWSTYCF";

        /// <summary>
        /// DSWSTARF.
        /// </summary>
        public const string DSWSTARF = "DSWSTARF";

        /// <summary>
        /// DSWTIMER.
        /// </summary>
        public const string DSWTIMER = "DSWTIMER";

        /// <summary>
        /// DSURCD.
        /// </summary>
        public const string DSURCD = "DSURCD";

        /// <summary>
        /// DSURDT.
        /// </summary>
        public const string DSURDT = "DSURDT";

        /// <summary>
        /// DSURAT.
        /// </summary>
        public const string DSURAT = "DSURAT";

        /// <summary>
        /// DSURAB.
        /// </summary>
        public const string DSURAB = "DSURAB";

        /// <summary>
        /// DSURRF.
        /// </summary>
        public const string DSURRF = "DSURRF";

        /// <summary>
        /// DSUSER.
        /// </summary>
        public const string DSUSER = "DSUSER";

        /// <summary>
        /// DSPID.
        /// </summary>
        public const string DSPID = "DSPID";

        /// <summary>
        /// DSJOBN.
        /// </summary>
        public const string DSJOBN = "DSJOBN";

        /// <summary>
        /// DSUPMJ.
        /// </summary>
        public const string DSUPMJ = "DSUPMJ";

        /// <summary>
        /// DSTDAY.
        /// </summary>
        public const string DSTDAY = "DSTDAY";

        /// <summary>
        /// DSSTYLEDT.
        /// </summary>
        public const string DSSTYLEDT = "DSSTYLEDT";
    }

    /// <inheritdoc />
    public override string TableName => "F31B79";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DSWCFGID", "DSWCFGID", JdeDataType.Numeric, null, true, true),
        new JdeField("DSLNID", "DSLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("DSSITEM", "DSSITEM", JdeDataType.String, 24),
        new JdeField("DSSVALUE", "DSSVALUE", JdeDataType.Numeric),
        new JdeField("DSWSTYCF", "DSWSTYCF", JdeDataType.String, 2),
        new JdeField("DSWSTARF", "DSWSTARF", JdeDataType.String, 2),
        new JdeField("DSWTIMER", "DSWTIMER", JdeDataType.String, 2),
        new JdeField("DSURCD", "DSURCD", JdeDataType.String, 4),
        new JdeField("DSURDT", "DSURDT", JdeDataType.Numeric),
        new JdeField("DSURAT", "DSURAT", JdeDataType.Numeric),
        new JdeField("DSURAB", "DSURAB", JdeDataType.Numeric),
        new JdeField("DSURRF", "DSURRF", JdeDataType.String, 30),
        new JdeField("DSUSER", "DSUSER", JdeDataType.String, 20),
        new JdeField("DSPID", "DSPID", JdeDataType.String, 20),
        new JdeField("DSJOBN", "DSJOBN", JdeDataType.String, 20),
        new JdeField("DSUPMJ", "DSUPMJ", JdeDataType.Numeric),
        new JdeField("DSTDAY", "DSTDAY", JdeDataType.Numeric),
        new JdeField("DSSTYLEDT", "DSSTYLEDT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B79_0", "Primary Key on DSWCFGID, DSLNID", new[] { "DSWCFGID", "DSLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B79_2", "Index on DSWCFGID, DSWSTYCF", new[] { "DSWCFGID", "DSWSTYCF" })
    };
}
