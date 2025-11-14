using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA080 - .
/// </summary>
public class F90CA080 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UUCUAN8.
        /// </summary>
        public const string UUCUAN8 = "UUCUAN8";

        /// <summary>
        /// UUSNAME.
        /// </summary>
        public const string UUSNAME = "UUSNAME";

        /// <summary>
        /// UUARCRCD.
        /// </summary>
        public const string UUARCRCD = "UUARCRCD";

        /// <summary>
        /// UUENTDBY.
        /// </summary>
        public const string UUENTDBY = "UUENTDBY";

        /// <summary>
        /// UUMODB.
        /// </summary>
        public const string UUMODB = "UUMODB";

        /// <summary>
        /// UUEDATE.
        /// </summary>
        public const string UUEDATE = "UUEDATE";

        /// <summary>
        /// UUMDATE.
        /// </summary>
        public const string UUMDATE = "UUMDATE";

        /// <summary>
        /// UUEXVAR0.
        /// </summary>
        public const string UUEXVAR0 = "UUEXVAR0";

        /// <summary>
        /// UUEXVAR1.
        /// </summary>
        public const string UUEXVAR1 = "UUEXVAR1";

        /// <summary>
        /// UUEXVAR2.
        /// </summary>
        public const string UUEXVAR2 = "UUEXVAR2";

        /// <summary>
        /// UUEXVAR3.
        /// </summary>
        public const string UUEXVAR3 = "UUEXVAR3";

        /// <summary>
        /// UUEXVAR4.
        /// </summary>
        public const string UUEXVAR4 = "UUEXVAR4";

        /// <summary>
        /// UUEXVAR5.
        /// </summary>
        public const string UUEXVAR5 = "UUEXVAR5";

        /// <summary>
        /// UUEXVAR6.
        /// </summary>
        public const string UUEXVAR6 = "UUEXVAR6";

        /// <summary>
        /// UUEXVAR7.
        /// </summary>
        public const string UUEXVAR7 = "UUEXVAR7";

        /// <summary>
        /// UUEXVAR8.
        /// </summary>
        public const string UUEXVAR8 = "UUEXVAR8";

        /// <summary>
        /// UUEXVAR9.
        /// </summary>
        public const string UUEXVAR9 = "UUEXVAR9";

        /// <summary>
        /// UUEXVAR10.
        /// </summary>
        public const string UUEXVAR10 = "UUEXVAR10";

        /// <summary>
        /// UUEXVAR11.
        /// </summary>
        public const string UUEXVAR11 = "UUEXVAR11";

        /// <summary>
        /// UUEXVAR12.
        /// </summary>
        public const string UUEXVAR12 = "UUEXVAR12";

        /// <summary>
        /// UUEXVAR13.
        /// </summary>
        public const string UUEXVAR13 = "UUEXVAR13";

        /// <summary>
        /// UUEXVAR14.
        /// </summary>
        public const string UUEXVAR14 = "UUEXVAR14";

        /// <summary>
        /// UUEXNM0.
        /// </summary>
        public const string UUEXNM0 = "UUEXNM0";

        /// <summary>
        /// UUEXNM1.
        /// </summary>
        public const string UUEXNM1 = "UUEXNM1";

        /// <summary>
        /// UUEXNM2.
        /// </summary>
        public const string UUEXNM2 = "UUEXNM2";

        /// <summary>
        /// UUEXNM3.
        /// </summary>
        public const string UUEXNM3 = "UUEXNM3";

        /// <summary>
        /// UUEXNM4.
        /// </summary>
        public const string UUEXNM4 = "UUEXNM4";

        /// <summary>
        /// UUEXNMP0.
        /// </summary>
        public const string UUEXNMP0 = "UUEXNMP0";

        /// <summary>
        /// UUEXNMP1.
        /// </summary>
        public const string UUEXNMP1 = "UUEXNMP1";

        /// <summary>
        /// UUEXNMP2.
        /// </summary>
        public const string UUEXNMP2 = "UUEXNMP2";

        /// <summary>
        /// UUEXNMP3.
        /// </summary>
        public const string UUEXNMP3 = "UUEXNMP3";

        /// <summary>
        /// UUEXNMP4.
        /// </summary>
        public const string UUEXNMP4 = "UUEXNMP4";

        /// <summary>
        /// UUEXDT0.
        /// </summary>
        public const string UUEXDT0 = "UUEXDT0";

        /// <summary>
        /// UUEXDT1.
        /// </summary>
        public const string UUEXDT1 = "UUEXDT1";

        /// <summary>
        /// UUEXDT2.
        /// </summary>
        public const string UUEXDT2 = "UUEXDT2";

        /// <summary>
        /// UUEXDT3.
        /// </summary>
        public const string UUEXDT3 = "UUEXDT3";

        /// <summary>
        /// UUEXDT4.
        /// </summary>
        public const string UUEXDT4 = "UUEXDT4";

        /// <summary>
        /// UUSTSUDT.
        /// </summary>
        public const string UUSTSUDT = "UUSTSUDT";

        /// <summary>
        /// UUACTIND.
        /// </summary>
        public const string UUACTIND = "UUACTIND";

        /// <summary>
        /// UUUSER.
        /// </summary>
        public const string UUUSER = "UUUSER";

        /// <summary>
        /// UUPID.
        /// </summary>
        public const string UUPID = "UUPID";

        /// <summary>
        /// UUVID.
        /// </summary>
        public const string UUVID = "UUVID";

        /// <summary>
        /// UUMKEY.
        /// </summary>
        public const string UUMKEY = "UUMKEY";

        /// <summary>
        /// UUUDTTM.
        /// </summary>
        public const string UUUDTTM = "UUUDTTM";

        /// <summary>
        /// UUCO.
        /// </summary>
        public const string UUCO = "UUCO";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA080";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UUCUAN8", "UUCUAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("UUSNAME", "UUSNAME", JdeDataType.String, 40),
        new JdeField("UUARCRCD", "UUARCRCD", JdeDataType.String, 6),
        new JdeField("UUENTDBY", "UUENTDBY", JdeDataType.Numeric),
        new JdeField("UUMODB", "UUMODB", JdeDataType.Numeric),
        new JdeField("UUEDATE", "UUEDATE", JdeDataType.Date),
        new JdeField("UUMDATE", "UUMDATE", JdeDataType.Date),
        new JdeField("UUEXVAR0", "UUEXVAR0", JdeDataType.String, 510),
        new JdeField("UUEXVAR1", "UUEXVAR1", JdeDataType.String, 510),
        new JdeField("UUEXVAR2", "UUEXVAR2", JdeDataType.String, 510),
        new JdeField("UUEXVAR3", "UUEXVAR3", JdeDataType.String, 510),
        new JdeField("UUEXVAR4", "UUEXVAR4", JdeDataType.String, 100),
        new JdeField("UUEXVAR5", "UUEXVAR5", JdeDataType.String, 100),
        new JdeField("UUEXVAR6", "UUEXVAR6", JdeDataType.String, 100),
        new JdeField("UUEXVAR7", "UUEXVAR7", JdeDataType.String, 100),
        new JdeField("UUEXVAR8", "UUEXVAR8", JdeDataType.String, 100),
        new JdeField("UUEXVAR9", "UUEXVAR9", JdeDataType.String, 100),
        new JdeField("UUEXVAR10", "UUEXVAR10", JdeDataType.String, 100),
        new JdeField("UUEXVAR11", "UUEXVAR11", JdeDataType.String, 100),
        new JdeField("UUEXVAR12", "UUEXVAR12", JdeDataType.String, 50),
        new JdeField("UUEXVAR13", "UUEXVAR13", JdeDataType.String, 50),
        new JdeField("UUEXVAR14", "UUEXVAR14", JdeDataType.String, 50),
        new JdeField("UUEXNM0", "UUEXNM0", JdeDataType.Numeric),
        new JdeField("UUEXNM1", "UUEXNM1", JdeDataType.Numeric),
        new JdeField("UUEXNM2", "UUEXNM2", JdeDataType.Numeric),
        new JdeField("UUEXNM3", "UUEXNM3", JdeDataType.Numeric),
        new JdeField("UUEXNM4", "UUEXNM4", JdeDataType.Numeric),
        new JdeField("UUEXNMP0", "UUEXNMP0", JdeDataType.Numeric),
        new JdeField("UUEXNMP1", "UUEXNMP1", JdeDataType.Numeric),
        new JdeField("UUEXNMP2", "UUEXNMP2", JdeDataType.Numeric),
        new JdeField("UUEXNMP3", "UUEXNMP3", JdeDataType.Numeric),
        new JdeField("UUEXNMP4", "UUEXNMP4", JdeDataType.Numeric),
        new JdeField("UUEXDT0", "UUEXDT0", JdeDataType.Date),
        new JdeField("UUEXDT1", "UUEXDT1", JdeDataType.Date),
        new JdeField("UUEXDT2", "UUEXDT2", JdeDataType.Date),
        new JdeField("UUEXDT3", "UUEXDT3", JdeDataType.Date),
        new JdeField("UUEXDT4", "UUEXDT4", JdeDataType.Date),
        new JdeField("UUSTSUDT", "UUSTSUDT", JdeDataType.Date),
        new JdeField("UUACTIND", "UUACTIND", JdeDataType.String, 2),
        new JdeField("UUUSER", "UUUSER", JdeDataType.String, 20),
        new JdeField("UUPID", "UUPID", JdeDataType.String, 20),
        new JdeField("UUVID", "UUVID", JdeDataType.String, 20),
        new JdeField("UUMKEY", "UUMKEY", JdeDataType.String, 30),
        new JdeField("UUUDTTM", "UUUDTTM", JdeDataType.Date),
        new JdeField("UUCO", "UUCO", JdeDataType.String, 10, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA080_0", "Primary Key on UUCUAN8, UUCO", new[] { "UUCUAN8", "UUCO" }, isUnique: true, isPrimaryKey: true)
    };
}
