using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CB02J - .
/// </summary>
public class F90CB02J : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OJOPPID.
        /// </summary>
        public const string OJOPPID = "OJOPPID";

        /// <summary>
        /// OJSLCYID.
        /// </summary>
        public const string OJSLCYID = "OJSLCYID";

        /// <summary>
        /// OJOPSCID.
        /// </summary>
        public const string OJOPSCID = "OJOPSCID";

        /// <summary>
        /// OJSDATE.
        /// </summary>
        public const string OJSDATE = "OJSDATE";

        /// <summary>
        /// OJENTDBY.
        /// </summary>
        public const string OJENTDBY = "OJENTDBY";

        /// <summary>
        /// OJEDATE.
        /// </summary>
        public const string OJEDATE = "OJEDATE";

        /// <summary>
        /// OJEXVAR0.
        /// </summary>
        public const string OJEXVAR0 = "OJEXVAR0";

        /// <summary>
        /// OJEXVAR1.
        /// </summary>
        public const string OJEXVAR1 = "OJEXVAR1";

        /// <summary>
        /// OJEXVAR4.
        /// </summary>
        public const string OJEXVAR4 = "OJEXVAR4";

        /// <summary>
        /// OJEXVAR5.
        /// </summary>
        public const string OJEXVAR5 = "OJEXVAR5";

        /// <summary>
        /// OJEXVAR6.
        /// </summary>
        public const string OJEXVAR6 = "OJEXVAR6";

        /// <summary>
        /// OJEXVAR7.
        /// </summary>
        public const string OJEXVAR7 = "OJEXVAR7";

        /// <summary>
        /// OJEXVAR12.
        /// </summary>
        public const string OJEXVAR12 = "OJEXVAR12";

        /// <summary>
        /// OJEXVAR13.
        /// </summary>
        public const string OJEXVAR13 = "OJEXVAR13";

        /// <summary>
        /// OJEXNM0.
        /// </summary>
        public const string OJEXNM0 = "OJEXNM0";

        /// <summary>
        /// OJEXNM1.
        /// </summary>
        public const string OJEXNM1 = "OJEXNM1";

        /// <summary>
        /// OJEXNM2.
        /// </summary>
        public const string OJEXNM2 = "OJEXNM2";

        /// <summary>
        /// OJEXNMP0.
        /// </summary>
        public const string OJEXNMP0 = "OJEXNMP0";

        /// <summary>
        /// OJEXNMP1.
        /// </summary>
        public const string OJEXNMP1 = "OJEXNMP1";

        /// <summary>
        /// OJEXNMP2.
        /// </summary>
        public const string OJEXNMP2 = "OJEXNMP2";

        /// <summary>
        /// OJEXDT0.
        /// </summary>
        public const string OJEXDT0 = "OJEXDT0";

        /// <summary>
        /// OJEXDT1.
        /// </summary>
        public const string OJEXDT1 = "OJEXDT1";

        /// <summary>
        /// OJEXDT2.
        /// </summary>
        public const string OJEXDT2 = "OJEXDT2";

        /// <summary>
        /// OJSTSUDT.
        /// </summary>
        public const string OJSTSUDT = "OJSTSUDT";

        /// <summary>
        /// OJACTIND.
        /// </summary>
        public const string OJACTIND = "OJACTIND";

        /// <summary>
        /// OJUSER.
        /// </summary>
        public const string OJUSER = "OJUSER";

        /// <summary>
        /// OJPID.
        /// </summary>
        public const string OJPID = "OJPID";

        /// <summary>
        /// OJVID.
        /// </summary>
        public const string OJVID = "OJVID";

        /// <summary>
        /// OJMKEY.
        /// </summary>
        public const string OJMKEY = "OJMKEY";

        /// <summary>
        /// OJUDTTM.
        /// </summary>
        public const string OJUDTTM = "OJUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CB02J";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OJOPPID", "OJOPPID", JdeDataType.Numeric, null, true, true),
        new JdeField("OJSLCYID", "OJSLCYID", JdeDataType.Numeric, null, true, true),
        new JdeField("OJOPSCID", "OJOPSCID", JdeDataType.Numeric, null, true, true),
        new JdeField("OJSDATE", "OJSDATE", JdeDataType.Date),
        new JdeField("OJENTDBY", "OJENTDBY", JdeDataType.Numeric),
        new JdeField("OJEDATE", "OJEDATE", JdeDataType.Date),
        new JdeField("OJEXVAR0", "OJEXVAR0", JdeDataType.String, 510),
        new JdeField("OJEXVAR1", "OJEXVAR1", JdeDataType.String, 510),
        new JdeField("OJEXVAR4", "OJEXVAR4", JdeDataType.String, 100),
        new JdeField("OJEXVAR5", "OJEXVAR5", JdeDataType.String, 100),
        new JdeField("OJEXVAR6", "OJEXVAR6", JdeDataType.String, 100),
        new JdeField("OJEXVAR7", "OJEXVAR7", JdeDataType.String, 100),
        new JdeField("OJEXVAR12", "OJEXVAR12", JdeDataType.String, 50),
        new JdeField("OJEXVAR13", "OJEXVAR13", JdeDataType.String, 50),
        new JdeField("OJEXNM0", "OJEXNM0", JdeDataType.Numeric),
        new JdeField("OJEXNM1", "OJEXNM1", JdeDataType.Numeric),
        new JdeField("OJEXNM2", "OJEXNM2", JdeDataType.Numeric),
        new JdeField("OJEXNMP0", "OJEXNMP0", JdeDataType.Numeric),
        new JdeField("OJEXNMP1", "OJEXNMP1", JdeDataType.Numeric),
        new JdeField("OJEXNMP2", "OJEXNMP2", JdeDataType.Numeric),
        new JdeField("OJEXDT0", "OJEXDT0", JdeDataType.Date),
        new JdeField("OJEXDT1", "OJEXDT1", JdeDataType.Date),
        new JdeField("OJEXDT2", "OJEXDT2", JdeDataType.Date),
        new JdeField("OJSTSUDT", "OJSTSUDT", JdeDataType.Date),
        new JdeField("OJACTIND", "OJACTIND", JdeDataType.String, 2),
        new JdeField("OJUSER", "OJUSER", JdeDataType.String, 20),
        new JdeField("OJPID", "OJPID", JdeDataType.String, 20),
        new JdeField("OJVID", "OJVID", JdeDataType.String, 20),
        new JdeField("OJMKEY", "OJMKEY", JdeDataType.String, 30),
        new JdeField("OJUDTTM", "OJUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CB02J_0", "Primary Key on OJOPSCID, OJOPPID, OJSLCYID", new[] { "OJOPSCID", "OJOPPID", "OJSLCYID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CB02J_2", "Index on OJOPPID", new[] { "OJOPPID" }),
        new JdeIndex("F90CB02J_3", "Index on OJOPPID, OJSLCYID", new[] { "OJOPPID", "OJSLCYID" })
    };
}
