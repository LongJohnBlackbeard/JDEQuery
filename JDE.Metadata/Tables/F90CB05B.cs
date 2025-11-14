using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CB05B - .
/// </summary>
public class F90CB05B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ONSDVRID.
        /// </summary>
        public const string ONSDVRID = "ONSDVRID";

        /// <summary>
        /// ONSDCTGY.
        /// </summary>
        public const string ONSDCTGY = "ONSDCTGY";

        /// <summary>
        /// ONSDIMP.
        /// </summary>
        public const string ONSDIMP = "ONSDIMP";

        /// <summary>
        /// ONOPPID.
        /// </summary>
        public const string ONOPPID = "ONOPPID";

        /// <summary>
        /// ONSMEID.
        /// </summary>
        public const string ONSMEID = "ONSMEID";

        /// <summary>
        /// ONDSCRP3.
        /// </summary>
        public const string ONDSCRP3 = "ONDSCRP3";

        /// <summary>
        /// ONSDORG.
        /// </summary>
        public const string ONSDORG = "ONSDORG";

        /// <summary>
        /// ONUSRRSP.
        /// </summary>
        public const string ONUSRRSP = "ONUSRRSP";

        /// <summary>
        /// ONENTDBY.
        /// </summary>
        public const string ONENTDBY = "ONENTDBY";

        /// <summary>
        /// ONEDATE.
        /// </summary>
        public const string ONEDATE = "ONEDATE";

        /// <summary>
        /// ONEXVAR0.
        /// </summary>
        public const string ONEXVAR0 = "ONEXVAR0";

        /// <summary>
        /// ONEXVAR1.
        /// </summary>
        public const string ONEXVAR1 = "ONEXVAR1";

        /// <summary>
        /// ONEXVAR2.
        /// </summary>
        public const string ONEXVAR2 = "ONEXVAR2";

        /// <summary>
        /// ONEXVAR3.
        /// </summary>
        public const string ONEXVAR3 = "ONEXVAR3";

        /// <summary>
        /// ONEXVAR4.
        /// </summary>
        public const string ONEXVAR4 = "ONEXVAR4";

        /// <summary>
        /// ONEXVAR5.
        /// </summary>
        public const string ONEXVAR5 = "ONEXVAR5";

        /// <summary>
        /// ONEXVAR6.
        /// </summary>
        public const string ONEXVAR6 = "ONEXVAR6";

        /// <summary>
        /// ONEXVAR7.
        /// </summary>
        public const string ONEXVAR7 = "ONEXVAR7";

        /// <summary>
        /// ONEXNM0.
        /// </summary>
        public const string ONEXNM0 = "ONEXNM0";

        /// <summary>
        /// ONEXNM1.
        /// </summary>
        public const string ONEXNM1 = "ONEXNM1";

        /// <summary>
        /// ONEXNM2.
        /// </summary>
        public const string ONEXNM2 = "ONEXNM2";

        /// <summary>
        /// ONEXNMP0.
        /// </summary>
        public const string ONEXNMP0 = "ONEXNMP0";

        /// <summary>
        /// ONEXNMP1.
        /// </summary>
        public const string ONEXNMP1 = "ONEXNMP1";

        /// <summary>
        /// ONEXNMP2.
        /// </summary>
        public const string ONEXNMP2 = "ONEXNMP2";

        /// <summary>
        /// ONEXDT0.
        /// </summary>
        public const string ONEXDT0 = "ONEXDT0";

        /// <summary>
        /// ONEXDT1.
        /// </summary>
        public const string ONEXDT1 = "ONEXDT1";

        /// <summary>
        /// ONEXDT2.
        /// </summary>
        public const string ONEXDT2 = "ONEXDT2";

        /// <summary>
        /// ONSTSUDT.
        /// </summary>
        public const string ONSTSUDT = "ONSTSUDT";

        /// <summary>
        /// ONACTIND.
        /// </summary>
        public const string ONACTIND = "ONACTIND";

        /// <summary>
        /// ONUSER.
        /// </summary>
        public const string ONUSER = "ONUSER";

        /// <summary>
        /// ONPID.
        /// </summary>
        public const string ONPID = "ONPID";

        /// <summary>
        /// ONVID.
        /// </summary>
        public const string ONVID = "ONVID";

        /// <summary>
        /// ONMKEY.
        /// </summary>
        public const string ONMKEY = "ONMKEY";

        /// <summary>
        /// ONUDTTM.
        /// </summary>
        public const string ONUDTTM = "ONUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CB05B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ONSDVRID", "ONSDVRID", JdeDataType.Numeric, null, true, true),
        new JdeField("ONSDCTGY", "ONSDCTGY", JdeDataType.String, 10),
        new JdeField("ONSDIMP", "ONSDIMP", JdeDataType.String, 10),
        new JdeField("ONOPPID", "ONOPPID", JdeDataType.Numeric),
        new JdeField("ONSMEID", "ONSMEID", JdeDataType.Numeric),
        new JdeField("ONDSCRP3", "ONDSCRP3", JdeDataType.String, 510),
        new JdeField("ONSDORG", "ONSDORG", JdeDataType.String, 150),
        new JdeField("ONUSRRSP", "ONUSRRSP", JdeDataType.String, 3000),
        new JdeField("ONENTDBY", "ONENTDBY", JdeDataType.Numeric),
        new JdeField("ONEDATE", "ONEDATE", JdeDataType.Date),
        new JdeField("ONEXVAR0", "ONEXVAR0", JdeDataType.String, 510),
        new JdeField("ONEXVAR1", "ONEXVAR1", JdeDataType.String, 510),
        new JdeField("ONEXVAR2", "ONEXVAR2", JdeDataType.String, 510),
        new JdeField("ONEXVAR3", "ONEXVAR3", JdeDataType.String, 510),
        new JdeField("ONEXVAR4", "ONEXVAR4", JdeDataType.String, 100),
        new JdeField("ONEXVAR5", "ONEXVAR5", JdeDataType.String, 100),
        new JdeField("ONEXVAR6", "ONEXVAR6", JdeDataType.String, 100),
        new JdeField("ONEXVAR7", "ONEXVAR7", JdeDataType.String, 100),
        new JdeField("ONEXNM0", "ONEXNM0", JdeDataType.Numeric),
        new JdeField("ONEXNM1", "ONEXNM1", JdeDataType.Numeric),
        new JdeField("ONEXNM2", "ONEXNM2", JdeDataType.Numeric),
        new JdeField("ONEXNMP0", "ONEXNMP0", JdeDataType.Numeric),
        new JdeField("ONEXNMP1", "ONEXNMP1", JdeDataType.Numeric),
        new JdeField("ONEXNMP2", "ONEXNMP2", JdeDataType.Numeric),
        new JdeField("ONEXDT0", "ONEXDT0", JdeDataType.Date),
        new JdeField("ONEXDT1", "ONEXDT1", JdeDataType.Date),
        new JdeField("ONEXDT2", "ONEXDT2", JdeDataType.Date),
        new JdeField("ONSTSUDT", "ONSTSUDT", JdeDataType.Date),
        new JdeField("ONACTIND", "ONACTIND", JdeDataType.String, 2),
        new JdeField("ONUSER", "ONUSER", JdeDataType.String, 20),
        new JdeField("ONPID", "ONPID", JdeDataType.String, 20),
        new JdeField("ONVID", "ONVID", JdeDataType.String, 20),
        new JdeField("ONMKEY", "ONMKEY", JdeDataType.String, 30),
        new JdeField("ONUDTTM", "ONUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CB05B_0", "Primary Key on ONSDVRID", new[] { "ONSDVRID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CB05B_2", "Index on ONSMEID", new[] { "ONSMEID" }),
        new JdeIndex("F90CB05B_3", "Index on ONOPPID", new[] { "ONOPPID" })
    };
}
