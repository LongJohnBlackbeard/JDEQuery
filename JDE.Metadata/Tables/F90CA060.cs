using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA060 - .
/// </summary>
public class F90CA060 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RCCMAN8.
        /// </summary>
        public const string RCCMAN8 = "RCCMAN8";

        /// <summary>
        /// RCNUMEMP.
        /// </summary>
        public const string RCNUMEMP = "RCNUMEMP";

        /// <summary>
        /// RCANNREV.
        /// </summary>
        public const string RCANNREV = "RCANNREV";

        /// <summary>
        /// RCARCRCD.
        /// </summary>
        public const string RCARCRCD = "RCARCRCD";

        /// <summary>
        /// RCEXVAR0.
        /// </summary>
        public const string RCEXVAR0 = "RCEXVAR0";

        /// <summary>
        /// RCEXVAR1.
        /// </summary>
        public const string RCEXVAR1 = "RCEXVAR1";

        /// <summary>
        /// RCEXVAR4.
        /// </summary>
        public const string RCEXVAR4 = "RCEXVAR4";

        /// <summary>
        /// RCEXVAR5.
        /// </summary>
        public const string RCEXVAR5 = "RCEXVAR5";

        /// <summary>
        /// RCEXVAR6.
        /// </summary>
        public const string RCEXVAR6 = "RCEXVAR6";

        /// <summary>
        /// RCEXVAR7.
        /// </summary>
        public const string RCEXVAR7 = "RCEXVAR7";

        /// <summary>
        /// RCEXVAR12.
        /// </summary>
        public const string RCEXVAR12 = "RCEXVAR12";

        /// <summary>
        /// RCEXVAR13.
        /// </summary>
        public const string RCEXVAR13 = "RCEXVAR13";

        /// <summary>
        /// RCEXNM0.
        /// </summary>
        public const string RCEXNM0 = "RCEXNM0";

        /// <summary>
        /// RCEXNM1.
        /// </summary>
        public const string RCEXNM1 = "RCEXNM1";

        /// <summary>
        /// RCEXNM2.
        /// </summary>
        public const string RCEXNM2 = "RCEXNM2";

        /// <summary>
        /// RCEXNMP0.
        /// </summary>
        public const string RCEXNMP0 = "RCEXNMP0";

        /// <summary>
        /// RCEXNMP1.
        /// </summary>
        public const string RCEXNMP1 = "RCEXNMP1";

        /// <summary>
        /// RCEXNMP2.
        /// </summary>
        public const string RCEXNMP2 = "RCEXNMP2";

        /// <summary>
        /// RCEXDT0.
        /// </summary>
        public const string RCEXDT0 = "RCEXDT0";

        /// <summary>
        /// RCEXDT1.
        /// </summary>
        public const string RCEXDT1 = "RCEXDT1";

        /// <summary>
        /// RCEXDT2.
        /// </summary>
        public const string RCEXDT2 = "RCEXDT2";

        /// <summary>
        /// RCSTSUDT.
        /// </summary>
        public const string RCSTSUDT = "RCSTSUDT";

        /// <summary>
        /// RCACTIND.
        /// </summary>
        public const string RCACTIND = "RCACTIND";

        /// <summary>
        /// RCUSER.
        /// </summary>
        public const string RCUSER = "RCUSER";

        /// <summary>
        /// RCPID.
        /// </summary>
        public const string RCPID = "RCPID";

        /// <summary>
        /// RCVID.
        /// </summary>
        public const string RCVID = "RCVID";

        /// <summary>
        /// RCMKEY.
        /// </summary>
        public const string RCMKEY = "RCMKEY";

        /// <summary>
        /// RCEDATE.
        /// </summary>
        public const string RCEDATE = "RCEDATE";

        /// <summary>
        /// RCUDTTM.
        /// </summary>
        public const string RCUDTTM = "RCUDTTM";

        /// <summary>
        /// RCENTDBY.
        /// </summary>
        public const string RCENTDBY = "RCENTDBY";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA060";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RCCMAN8", "RCCMAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("RCNUMEMP", "RCNUMEMP", JdeDataType.Numeric),
        new JdeField("RCANNREV", "RCANNREV", JdeDataType.Numeric),
        new JdeField("RCARCRCD", "RCARCRCD", JdeDataType.String, 6),
        new JdeField("RCEXVAR0", "RCEXVAR0", JdeDataType.String, 510),
        new JdeField("RCEXVAR1", "RCEXVAR1", JdeDataType.String, 510),
        new JdeField("RCEXVAR4", "RCEXVAR4", JdeDataType.String, 100),
        new JdeField("RCEXVAR5", "RCEXVAR5", JdeDataType.String, 100),
        new JdeField("RCEXVAR6", "RCEXVAR6", JdeDataType.String, 100),
        new JdeField("RCEXVAR7", "RCEXVAR7", JdeDataType.String, 100),
        new JdeField("RCEXVAR12", "RCEXVAR12", JdeDataType.String, 50),
        new JdeField("RCEXVAR13", "RCEXVAR13", JdeDataType.String, 50),
        new JdeField("RCEXNM0", "RCEXNM0", JdeDataType.Numeric),
        new JdeField("RCEXNM1", "RCEXNM1", JdeDataType.Numeric),
        new JdeField("RCEXNM2", "RCEXNM2", JdeDataType.Numeric),
        new JdeField("RCEXNMP0", "RCEXNMP0", JdeDataType.Numeric),
        new JdeField("RCEXNMP1", "RCEXNMP1", JdeDataType.Numeric),
        new JdeField("RCEXNMP2", "RCEXNMP2", JdeDataType.Numeric),
        new JdeField("RCEXDT0", "RCEXDT0", JdeDataType.Date),
        new JdeField("RCEXDT1", "RCEXDT1", JdeDataType.Date),
        new JdeField("RCEXDT2", "RCEXDT2", JdeDataType.Date),
        new JdeField("RCSTSUDT", "RCSTSUDT", JdeDataType.Date),
        new JdeField("RCACTIND", "RCACTIND", JdeDataType.String, 2),
        new JdeField("RCUSER", "RCUSER", JdeDataType.String, 20),
        new JdeField("RCPID", "RCPID", JdeDataType.String, 20),
        new JdeField("RCVID", "RCVID", JdeDataType.String, 20),
        new JdeField("RCMKEY", "RCMKEY", JdeDataType.String, 30),
        new JdeField("RCEDATE", "RCEDATE", JdeDataType.Date),
        new JdeField("RCUDTTM", "RCUDTTM", JdeDataType.Date),
        new JdeField("RCENTDBY", "RCENTDBY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA060_0", "Primary Key on RCCMAN8", new[] { "RCCMAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
