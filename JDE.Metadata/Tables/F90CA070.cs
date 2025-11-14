using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA070 - .
/// </summary>
public class F90CA070 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CTCNAN8.
        /// </summary>
        public const string CTCNAN8 = "CTCNAN8";

        /// <summary>
        /// CTCNLNID.
        /// </summary>
        public const string CTCNLNID = "CTCNLNID";

        /// <summary>
        /// CTDPTCD.
        /// </summary>
        public const string CTDPTCD = "CTDPTCD";

        /// <summary>
        /// CTPCONTC.
        /// </summary>
        public const string CTPCONTC = "CTPCONTC";

        /// <summary>
        /// CTRCLNID.
        /// </summary>
        public const string CTRCLNID = "CTRCLNID";

        /// <summary>
        /// CTPRAN8.
        /// </summary>
        public const string CTPRAN8 = "CTPRAN8";

        /// <summary>
        /// CTPRTLNID.
        /// </summary>
        public const string CTPRTLNID = "CTPRTLNID";

        /// <summary>
        /// CTEVTID.
        /// </summary>
        public const string CTEVTID = "CTEVTID";

        /// <summary>
        /// CTENTDBY.
        /// </summary>
        public const string CTENTDBY = "CTENTDBY";

        /// <summary>
        /// CTMODB.
        /// </summary>
        public const string CTMODB = "CTMODB";

        /// <summary>
        /// CTEDATE.
        /// </summary>
        public const string CTEDATE = "CTEDATE";

        /// <summary>
        /// CTMDATE.
        /// </summary>
        public const string CTMDATE = "CTMDATE";

        /// <summary>
        /// CTEXVAR0.
        /// </summary>
        public const string CTEXVAR0 = "CTEXVAR0";

        /// <summary>
        /// CTEXVAR1.
        /// </summary>
        public const string CTEXVAR1 = "CTEXVAR1";

        /// <summary>
        /// CTEXVAR2.
        /// </summary>
        public const string CTEXVAR2 = "CTEXVAR2";

        /// <summary>
        /// CTEXVAR3.
        /// </summary>
        public const string CTEXVAR3 = "CTEXVAR3";

        /// <summary>
        /// CTEXVAR4.
        /// </summary>
        public const string CTEXVAR4 = "CTEXVAR4";

        /// <summary>
        /// CTEXVAR5.
        /// </summary>
        public const string CTEXVAR5 = "CTEXVAR5";

        /// <summary>
        /// CTEXVAR6.
        /// </summary>
        public const string CTEXVAR6 = "CTEXVAR6";

        /// <summary>
        /// CTEXVAR7.
        /// </summary>
        public const string CTEXVAR7 = "CTEXVAR7";

        /// <summary>
        /// CTEXVAR8.
        /// </summary>
        public const string CTEXVAR8 = "CTEXVAR8";

        /// <summary>
        /// CTEXVAR9.
        /// </summary>
        public const string CTEXVAR9 = "CTEXVAR9";

        /// <summary>
        /// CTEXVAR10.
        /// </summary>
        public const string CTEXVAR10 = "CTEXVAR10";

        /// <summary>
        /// CTEXVAR11.
        /// </summary>
        public const string CTEXVAR11 = "CTEXVAR11";

        /// <summary>
        /// CTEXVAR12.
        /// </summary>
        public const string CTEXVAR12 = "CTEXVAR12";

        /// <summary>
        /// CTEXVAR13.
        /// </summary>
        public const string CTEXVAR13 = "CTEXVAR13";

        /// <summary>
        /// CTEXVAR14.
        /// </summary>
        public const string CTEXVAR14 = "CTEXVAR14";

        /// <summary>
        /// CTEXNM0.
        /// </summary>
        public const string CTEXNM0 = "CTEXNM0";

        /// <summary>
        /// CTEXNM1.
        /// </summary>
        public const string CTEXNM1 = "CTEXNM1";

        /// <summary>
        /// CTEXNM2.
        /// </summary>
        public const string CTEXNM2 = "CTEXNM2";

        /// <summary>
        /// CTEXNM3.
        /// </summary>
        public const string CTEXNM3 = "CTEXNM3";

        /// <summary>
        /// CTEXNM4.
        /// </summary>
        public const string CTEXNM4 = "CTEXNM4";

        /// <summary>
        /// CTEXNMP0.
        /// </summary>
        public const string CTEXNMP0 = "CTEXNMP0";

        /// <summary>
        /// CTEXNMP1.
        /// </summary>
        public const string CTEXNMP1 = "CTEXNMP1";

        /// <summary>
        /// CTEXNMP2.
        /// </summary>
        public const string CTEXNMP2 = "CTEXNMP2";

        /// <summary>
        /// CTEXNMP3.
        /// </summary>
        public const string CTEXNMP3 = "CTEXNMP3";

        /// <summary>
        /// CTEXNMP4.
        /// </summary>
        public const string CTEXNMP4 = "CTEXNMP4";

        /// <summary>
        /// CTEXDT0.
        /// </summary>
        public const string CTEXDT0 = "CTEXDT0";

        /// <summary>
        /// CTEXDT1.
        /// </summary>
        public const string CTEXDT1 = "CTEXDT1";

        /// <summary>
        /// CTEXDT2.
        /// </summary>
        public const string CTEXDT2 = "CTEXDT2";

        /// <summary>
        /// CTEXDT3.
        /// </summary>
        public const string CTEXDT3 = "CTEXDT3";

        /// <summary>
        /// CTEXDT4.
        /// </summary>
        public const string CTEXDT4 = "CTEXDT4";

        /// <summary>
        /// CTSTSUDT.
        /// </summary>
        public const string CTSTSUDT = "CTSTSUDT";

        /// <summary>
        /// CTACTIND.
        /// </summary>
        public const string CTACTIND = "CTACTIND";

        /// <summary>
        /// CTUSER.
        /// </summary>
        public const string CTUSER = "CTUSER";

        /// <summary>
        /// CTPID.
        /// </summary>
        public const string CTPID = "CTPID";

        /// <summary>
        /// CTVID.
        /// </summary>
        public const string CTVID = "CTVID";

        /// <summary>
        /// CTMKEY.
        /// </summary>
        public const string CTMKEY = "CTMKEY";

        /// <summary>
        /// CTUDTTM.
        /// </summary>
        public const string CTUDTTM = "CTUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA070";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CTCNAN8", "CTCNAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CTCNLNID", "CTCNLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("CTDPTCD", "CTDPTCD", JdeDataType.String, 10),
        new JdeField("CTPCONTC", "CTPCONTC", JdeDataType.String, 2),
        new JdeField("CTRCLNID", "CTRCLNID", JdeDataType.Numeric),
        new JdeField("CTPRAN8", "CTPRAN8", JdeDataType.Numeric),
        new JdeField("CTPRTLNID", "CTPRTLNID", JdeDataType.Numeric),
        new JdeField("CTEVTID", "CTEVTID", JdeDataType.Numeric),
        new JdeField("CTENTDBY", "CTENTDBY", JdeDataType.Numeric),
        new JdeField("CTMODB", "CTMODB", JdeDataType.Numeric),
        new JdeField("CTEDATE", "CTEDATE", JdeDataType.Date),
        new JdeField("CTMDATE", "CTMDATE", JdeDataType.Date),
        new JdeField("CTEXVAR0", "CTEXVAR0", JdeDataType.String, 510),
        new JdeField("CTEXVAR1", "CTEXVAR1", JdeDataType.String, 510),
        new JdeField("CTEXVAR2", "CTEXVAR2", JdeDataType.String, 510),
        new JdeField("CTEXVAR3", "CTEXVAR3", JdeDataType.String, 510),
        new JdeField("CTEXVAR4", "CTEXVAR4", JdeDataType.String, 100),
        new JdeField("CTEXVAR5", "CTEXVAR5", JdeDataType.String, 100),
        new JdeField("CTEXVAR6", "CTEXVAR6", JdeDataType.String, 100),
        new JdeField("CTEXVAR7", "CTEXVAR7", JdeDataType.String, 100),
        new JdeField("CTEXVAR8", "CTEXVAR8", JdeDataType.String, 100),
        new JdeField("CTEXVAR9", "CTEXVAR9", JdeDataType.String, 100),
        new JdeField("CTEXVAR10", "CTEXVAR10", JdeDataType.String, 100),
        new JdeField("CTEXVAR11", "CTEXVAR11", JdeDataType.String, 100),
        new JdeField("CTEXVAR12", "CTEXVAR12", JdeDataType.String, 50),
        new JdeField("CTEXVAR13", "CTEXVAR13", JdeDataType.String, 50),
        new JdeField("CTEXVAR14", "CTEXVAR14", JdeDataType.String, 50),
        new JdeField("CTEXNM0", "CTEXNM0", JdeDataType.Numeric),
        new JdeField("CTEXNM1", "CTEXNM1", JdeDataType.Numeric),
        new JdeField("CTEXNM2", "CTEXNM2", JdeDataType.Numeric),
        new JdeField("CTEXNM3", "CTEXNM3", JdeDataType.Numeric),
        new JdeField("CTEXNM4", "CTEXNM4", JdeDataType.Numeric),
        new JdeField("CTEXNMP0", "CTEXNMP0", JdeDataType.Numeric),
        new JdeField("CTEXNMP1", "CTEXNMP1", JdeDataType.Numeric),
        new JdeField("CTEXNMP2", "CTEXNMP2", JdeDataType.Numeric),
        new JdeField("CTEXNMP3", "CTEXNMP3", JdeDataType.Numeric),
        new JdeField("CTEXNMP4", "CTEXNMP4", JdeDataType.Numeric),
        new JdeField("CTEXDT0", "CTEXDT0", JdeDataType.Date),
        new JdeField("CTEXDT1", "CTEXDT1", JdeDataType.Date),
        new JdeField("CTEXDT2", "CTEXDT2", JdeDataType.Date),
        new JdeField("CTEXDT3", "CTEXDT3", JdeDataType.Date),
        new JdeField("CTEXDT4", "CTEXDT4", JdeDataType.Date),
        new JdeField("CTSTSUDT", "CTSTSUDT", JdeDataType.Date),
        new JdeField("CTACTIND", "CTACTIND", JdeDataType.String, 2),
        new JdeField("CTUSER", "CTUSER", JdeDataType.String, 20),
        new JdeField("CTPID", "CTPID", JdeDataType.String, 20),
        new JdeField("CTVID", "CTVID", JdeDataType.String, 20),
        new JdeField("CTMKEY", "CTMKEY", JdeDataType.String, 30),
        new JdeField("CTUDTTM", "CTUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA070_0", "Primary Key on CTCNAN8, CTCNLNID", new[] { "CTCNAN8", "CTCNLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
