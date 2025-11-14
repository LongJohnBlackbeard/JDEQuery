using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA10A - .
/// </summary>
public class F90CA10A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IHITMHID.
        /// </summary>
        public const string IHITMHID = "IHITMHID";

        /// <summary>
        /// IHITMCD.
        /// </summary>
        public const string IHITMCD = "IHITMCD";

        /// <summary>
        /// IHBLGID.
        /// </summary>
        public const string IHBLGID = "IHBLGID";

        /// <summary>
        /// IHITMLVL.
        /// </summary>
        public const string IHITMLVL = "IHITMLVL";

        /// <summary>
        /// IHHSCHLD.
        /// </summary>
        public const string IHHSCHLD = "IHHSCHLD";

        /// <summary>
        /// IHENTDBY.
        /// </summary>
        public const string IHENTDBY = "IHENTDBY";

        /// <summary>
        /// IHEDATE.
        /// </summary>
        public const string IHEDATE = "IHEDATE";

        /// <summary>
        /// IHMODB.
        /// </summary>
        public const string IHMODB = "IHMODB";

        /// <summary>
        /// IHMDATE.
        /// </summary>
        public const string IHMDATE = "IHMDATE";

        /// <summary>
        /// IHITDESC.
        /// </summary>
        public const string IHITDESC = "IHITDESC";

        /// <summary>
        /// IHITMURL.
        /// </summary>
        public const string IHITMURL = "IHITMURL";

        /// <summary>
        /// IHEXVAR0.
        /// </summary>
        public const string IHEXVAR0 = "IHEXVAR0";

        /// <summary>
        /// IHEXVAR1.
        /// </summary>
        public const string IHEXVAR1 = "IHEXVAR1";

        /// <summary>
        /// IHEXVAR4.
        /// </summary>
        public const string IHEXVAR4 = "IHEXVAR4";

        /// <summary>
        /// IHEXVAR5.
        /// </summary>
        public const string IHEXVAR5 = "IHEXVAR5";

        /// <summary>
        /// IHEXVAR6.
        /// </summary>
        public const string IHEXVAR6 = "IHEXVAR6";

        /// <summary>
        /// IHEXVAR7.
        /// </summary>
        public const string IHEXVAR7 = "IHEXVAR7";

        /// <summary>
        /// IHEXVAR12.
        /// </summary>
        public const string IHEXVAR12 = "IHEXVAR12";

        /// <summary>
        /// IHEXVAR13.
        /// </summary>
        public const string IHEXVAR13 = "IHEXVAR13";

        /// <summary>
        /// IHEXNM0.
        /// </summary>
        public const string IHEXNM0 = "IHEXNM0";

        /// <summary>
        /// IHEXNM1.
        /// </summary>
        public const string IHEXNM1 = "IHEXNM1";

        /// <summary>
        /// IHEXNM2.
        /// </summary>
        public const string IHEXNM2 = "IHEXNM2";

        /// <summary>
        /// IHEXNMP0.
        /// </summary>
        public const string IHEXNMP0 = "IHEXNMP0";

        /// <summary>
        /// IHEXNMP1.
        /// </summary>
        public const string IHEXNMP1 = "IHEXNMP1";

        /// <summary>
        /// IHEXNMP2.
        /// </summary>
        public const string IHEXNMP2 = "IHEXNMP2";

        /// <summary>
        /// IHEXDT0.
        /// </summary>
        public const string IHEXDT0 = "IHEXDT0";

        /// <summary>
        /// IHEXDT1.
        /// </summary>
        public const string IHEXDT1 = "IHEXDT1";

        /// <summary>
        /// IHEXDT2.
        /// </summary>
        public const string IHEXDT2 = "IHEXDT2";

        /// <summary>
        /// IHSTSUDT.
        /// </summary>
        public const string IHSTSUDT = "IHSTSUDT";

        /// <summary>
        /// IHACTIND.
        /// </summary>
        public const string IHACTIND = "IHACTIND";

        /// <summary>
        /// IHUSER.
        /// </summary>
        public const string IHUSER = "IHUSER";

        /// <summary>
        /// IHPID.
        /// </summary>
        public const string IHPID = "IHPID";

        /// <summary>
        /// IHVID.
        /// </summary>
        public const string IHVID = "IHVID";

        /// <summary>
        /// IHMKEY.
        /// </summary>
        public const string IHMKEY = "IHMKEY";

        /// <summary>
        /// IHUDTTM.
        /// </summary>
        public const string IHUDTTM = "IHUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA10A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IHITMHID", "IHITMHID", JdeDataType.Numeric, null, true, true),
        new JdeField("IHITMCD", "IHITMCD", JdeDataType.String, 60),
        new JdeField("IHBLGID", "IHBLGID", JdeDataType.Numeric),
        new JdeField("IHITMLVL", "IHITMLVL", JdeDataType.Numeric),
        new JdeField("IHHSCHLD", "IHHSCHLD", JdeDataType.String, 2),
        new JdeField("IHENTDBY", "IHENTDBY", JdeDataType.Numeric),
        new JdeField("IHEDATE", "IHEDATE", JdeDataType.Date),
        new JdeField("IHMODB", "IHMODB", JdeDataType.Numeric),
        new JdeField("IHMDATE", "IHMDATE", JdeDataType.Date),
        new JdeField("IHITDESC", "IHITDESC", JdeDataType.String, 100),
        new JdeField("IHITMURL", "IHITMURL", JdeDataType.String, 510),
        new JdeField("IHEXVAR0", "IHEXVAR0", JdeDataType.String, 510),
        new JdeField("IHEXVAR1", "IHEXVAR1", JdeDataType.String, 510),
        new JdeField("IHEXVAR4", "IHEXVAR4", JdeDataType.String, 100),
        new JdeField("IHEXVAR5", "IHEXVAR5", JdeDataType.String, 100),
        new JdeField("IHEXVAR6", "IHEXVAR6", JdeDataType.String, 100),
        new JdeField("IHEXVAR7", "IHEXVAR7", JdeDataType.String, 100),
        new JdeField("IHEXVAR12", "IHEXVAR12", JdeDataType.String, 50),
        new JdeField("IHEXVAR13", "IHEXVAR13", JdeDataType.String, 50),
        new JdeField("IHEXNM0", "IHEXNM0", JdeDataType.Numeric),
        new JdeField("IHEXNM1", "IHEXNM1", JdeDataType.Numeric),
        new JdeField("IHEXNM2", "IHEXNM2", JdeDataType.Numeric),
        new JdeField("IHEXNMP0", "IHEXNMP0", JdeDataType.Numeric),
        new JdeField("IHEXNMP1", "IHEXNMP1", JdeDataType.Numeric),
        new JdeField("IHEXNMP2", "IHEXNMP2", JdeDataType.Numeric),
        new JdeField("IHEXDT0", "IHEXDT0", JdeDataType.Date),
        new JdeField("IHEXDT1", "IHEXDT1", JdeDataType.Date),
        new JdeField("IHEXDT2", "IHEXDT2", JdeDataType.Date),
        new JdeField("IHSTSUDT", "IHSTSUDT", JdeDataType.Date),
        new JdeField("IHACTIND", "IHACTIND", JdeDataType.String, 2),
        new JdeField("IHUSER", "IHUSER", JdeDataType.String, 20),
        new JdeField("IHPID", "IHPID", JdeDataType.String, 20),
        new JdeField("IHVID", "IHVID", JdeDataType.String, 20),
        new JdeField("IHMKEY", "IHMKEY", JdeDataType.String, 30),
        new JdeField("IHUDTTM", "IHUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA10A_0", "Primary Key on IHITMHID", new[] { "IHITMHID" }, isUnique: true, isPrimaryKey: true)
    };
}
