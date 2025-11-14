using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA120 - .
/// </summary>
public class F90CA120 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IGCIG.
        /// </summary>
        public const string IGCIG = "IGCIG";

        /// <summary>
        /// IGBLGID.
        /// </summary>
        public const string IGBLGID = "IGBLGID";

        /// <summary>
        /// IGCIGLVL.
        /// </summary>
        public const string IGCIGLVL = "IGCIGLVL";

        /// <summary>
        /// IGHSCHLD.
        /// </summary>
        public const string IGHSCHLD = "IGHSCHLD";

        /// <summary>
        /// IGENTDBY.
        /// </summary>
        public const string IGENTDBY = "IGENTDBY";

        /// <summary>
        /// IGEDATE.
        /// </summary>
        public const string IGEDATE = "IGEDATE";

        /// <summary>
        /// IGCIGNAME.
        /// </summary>
        public const string IGCIGNAME = "IGCIGNAME";

        /// <summary>
        /// IGEXVAR0.
        /// </summary>
        public const string IGEXVAR0 = "IGEXVAR0";

        /// <summary>
        /// IGEXVAR1.
        /// </summary>
        public const string IGEXVAR1 = "IGEXVAR1";

        /// <summary>
        /// IGEXVAR2.
        /// </summary>
        public const string IGEXVAR2 = "IGEXVAR2";

        /// <summary>
        /// IGEXVAR3.
        /// </summary>
        public const string IGEXVAR3 = "IGEXVAR3";

        /// <summary>
        /// IGEXVAR4.
        /// </summary>
        public const string IGEXVAR4 = "IGEXVAR4";

        /// <summary>
        /// IGEXVAR5.
        /// </summary>
        public const string IGEXVAR5 = "IGEXVAR5";

        /// <summary>
        /// IGEXVAR6.
        /// </summary>
        public const string IGEXVAR6 = "IGEXVAR6";

        /// <summary>
        /// IGEXVAR7.
        /// </summary>
        public const string IGEXVAR7 = "IGEXVAR7";

        /// <summary>
        /// IGEXNM0.
        /// </summary>
        public const string IGEXNM0 = "IGEXNM0";

        /// <summary>
        /// IGEXNM1.
        /// </summary>
        public const string IGEXNM1 = "IGEXNM1";

        /// <summary>
        /// IGEXNM2.
        /// </summary>
        public const string IGEXNM2 = "IGEXNM2";

        /// <summary>
        /// IGEXNMP0.
        /// </summary>
        public const string IGEXNMP0 = "IGEXNMP0";

        /// <summary>
        /// IGEXNMP1.
        /// </summary>
        public const string IGEXNMP1 = "IGEXNMP1";

        /// <summary>
        /// IGEXNMP2.
        /// </summary>
        public const string IGEXNMP2 = "IGEXNMP2";

        /// <summary>
        /// IGEXDT0.
        /// </summary>
        public const string IGEXDT0 = "IGEXDT0";

        /// <summary>
        /// IGEXDT1.
        /// </summary>
        public const string IGEXDT1 = "IGEXDT1";

        /// <summary>
        /// IGEXDT2.
        /// </summary>
        public const string IGEXDT2 = "IGEXDT2";

        /// <summary>
        /// IGSTSUDT.
        /// </summary>
        public const string IGSTSUDT = "IGSTSUDT";

        /// <summary>
        /// IGACTIND.
        /// </summary>
        public const string IGACTIND = "IGACTIND";

        /// <summary>
        /// IGVID.
        /// </summary>
        public const string IGVID = "IGVID";

        /// <summary>
        /// IGUDTTM.
        /// </summary>
        public const string IGUDTTM = "IGUDTTM";

        /// <summary>
        /// IGUSER.
        /// </summary>
        public const string IGUSER = "IGUSER";

        /// <summary>
        /// IGMKEY.
        /// </summary>
        public const string IGMKEY = "IGMKEY";

        /// <summary>
        /// IGPID.
        /// </summary>
        public const string IGPID = "IGPID";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA120";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IGCIG", "IGCIG", JdeDataType.Numeric, null, true, true),
        new JdeField("IGBLGID", "IGBLGID", JdeDataType.Numeric),
        new JdeField("IGCIGLVL", "IGCIGLVL", JdeDataType.Numeric),
        new JdeField("IGHSCHLD", "IGHSCHLD", JdeDataType.String, 2),
        new JdeField("IGENTDBY", "IGENTDBY", JdeDataType.Numeric),
        new JdeField("IGEDATE", "IGEDATE", JdeDataType.Date),
        new JdeField("IGCIGNAME", "IGCIGNAME", JdeDataType.String, 100),
        new JdeField("IGEXVAR0", "IGEXVAR0", JdeDataType.String, 510),
        new JdeField("IGEXVAR1", "IGEXVAR1", JdeDataType.String, 510),
        new JdeField("IGEXVAR2", "IGEXVAR2", JdeDataType.String, 510),
        new JdeField("IGEXVAR3", "IGEXVAR3", JdeDataType.String, 510),
        new JdeField("IGEXVAR4", "IGEXVAR4", JdeDataType.String, 100),
        new JdeField("IGEXVAR5", "IGEXVAR5", JdeDataType.String, 100),
        new JdeField("IGEXVAR6", "IGEXVAR6", JdeDataType.String, 100),
        new JdeField("IGEXVAR7", "IGEXVAR7", JdeDataType.String, 100),
        new JdeField("IGEXNM0", "IGEXNM0", JdeDataType.Numeric),
        new JdeField("IGEXNM1", "IGEXNM1", JdeDataType.Numeric),
        new JdeField("IGEXNM2", "IGEXNM2", JdeDataType.Numeric),
        new JdeField("IGEXNMP0", "IGEXNMP0", JdeDataType.Numeric),
        new JdeField("IGEXNMP1", "IGEXNMP1", JdeDataType.Numeric),
        new JdeField("IGEXNMP2", "IGEXNMP2", JdeDataType.Numeric),
        new JdeField("IGEXDT0", "IGEXDT0", JdeDataType.Date),
        new JdeField("IGEXDT1", "IGEXDT1", JdeDataType.Date),
        new JdeField("IGEXDT2", "IGEXDT2", JdeDataType.Date),
        new JdeField("IGSTSUDT", "IGSTSUDT", JdeDataType.Date),
        new JdeField("IGACTIND", "IGACTIND", JdeDataType.String, 2),
        new JdeField("IGVID", "IGVID", JdeDataType.String, 20),
        new JdeField("IGUDTTM", "IGUDTTM", JdeDataType.Date),
        new JdeField("IGUSER", "IGUSER", JdeDataType.String, 20),
        new JdeField("IGMKEY", "IGMKEY", JdeDataType.String, 30),
        new JdeField("IGPID", "IGPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA120_0", "Primary Key on IGCIG", new[] { "IGCIG" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CA120_2", "Index on IGBLGID", new[] { "IGBLGID" })
    };
}
