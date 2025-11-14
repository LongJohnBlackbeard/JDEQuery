using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CB030 - .
/// </summary>
public class F90CB030 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ADADRSID.
        /// </summary>
        public const string ADADRSID = "ADADRSID";

        /// <summary>
        /// ADTPE.
        /// </summary>
        public const string ADTPE = "ADTPE";

        /// <summary>
        /// ADADDR1.
        /// </summary>
        public const string ADADDR1 = "ADADDR1";

        /// <summary>
        /// ADADDR2.
        /// </summary>
        public const string ADADDR2 = "ADADDR2";

        /// <summary>
        /// ADADDR3.
        /// </summary>
        public const string ADADDR3 = "ADADDR3";

        /// <summary>
        /// ADADDR4.
        /// </summary>
        public const string ADADDR4 = "ADADDR4";

        /// <summary>
        /// ADCIY.
        /// </summary>
        public const string ADCIY = "ADCIY";

        /// <summary>
        /// ADSATE.
        /// </summary>
        public const string ADSATE = "ADSATE";

        /// <summary>
        /// ADZCODE.
        /// </summary>
        public const string ADZCODE = "ADZCODE";

        /// <summary>
        /// ADCNY.
        /// </summary>
        public const string ADCNY = "ADCNY";

        /// <summary>
        /// ADCONTY.
        /// </summary>
        public const string ADCONTY = "ADCONTY";

        /// <summary>
        /// ADPMADF.
        /// </summary>
        public const string ADPMADF = "ADPMADF";

        /// <summary>
        /// ADENTDBY.
        /// </summary>
        public const string ADENTDBY = "ADENTDBY";

        /// <summary>
        /// ADEDATE.
        /// </summary>
        public const string ADEDATE = "ADEDATE";

        /// <summary>
        /// ADEXVAR0.
        /// </summary>
        public const string ADEXVAR0 = "ADEXVAR0";

        /// <summary>
        /// ADEXVAR1.
        /// </summary>
        public const string ADEXVAR1 = "ADEXVAR1";

        /// <summary>
        /// ADEXVAR2.
        /// </summary>
        public const string ADEXVAR2 = "ADEXVAR2";

        /// <summary>
        /// ADEXVAR3.
        /// </summary>
        public const string ADEXVAR3 = "ADEXVAR3";

        /// <summary>
        /// ADEXVAR4.
        /// </summary>
        public const string ADEXVAR4 = "ADEXVAR4";

        /// <summary>
        /// ADEXVAR5.
        /// </summary>
        public const string ADEXVAR5 = "ADEXVAR5";

        /// <summary>
        /// ADEXVAR6.
        /// </summary>
        public const string ADEXVAR6 = "ADEXVAR6";

        /// <summary>
        /// ADEXVAR7.
        /// </summary>
        public const string ADEXVAR7 = "ADEXVAR7";

        /// <summary>
        /// ADEXNM0.
        /// </summary>
        public const string ADEXNM0 = "ADEXNM0";

        /// <summary>
        /// ADEXNM1.
        /// </summary>
        public const string ADEXNM1 = "ADEXNM1";

        /// <summary>
        /// ADEXNM2.
        /// </summary>
        public const string ADEXNM2 = "ADEXNM2";

        /// <summary>
        /// ADEXNMP0.
        /// </summary>
        public const string ADEXNMP0 = "ADEXNMP0";

        /// <summary>
        /// ADEXNMP1.
        /// </summary>
        public const string ADEXNMP1 = "ADEXNMP1";

        /// <summary>
        /// ADEXNMP2.
        /// </summary>
        public const string ADEXNMP2 = "ADEXNMP2";

        /// <summary>
        /// ADEXDT0.
        /// </summary>
        public const string ADEXDT0 = "ADEXDT0";

        /// <summary>
        /// ADEXDT1.
        /// </summary>
        public const string ADEXDT1 = "ADEXDT1";

        /// <summary>
        /// ADEXDT2.
        /// </summary>
        public const string ADEXDT2 = "ADEXDT2";

        /// <summary>
        /// ADSTSUDT.
        /// </summary>
        public const string ADSTSUDT = "ADSTSUDT";

        /// <summary>
        /// ADACTIND.
        /// </summary>
        public const string ADACTIND = "ADACTIND";

        /// <summary>
        /// ADUSER.
        /// </summary>
        public const string ADUSER = "ADUSER";

        /// <summary>
        /// ADPID.
        /// </summary>
        public const string ADPID = "ADPID";

        /// <summary>
        /// ADVID.
        /// </summary>
        public const string ADVID = "ADVID";

        /// <summary>
        /// ADMKEY.
        /// </summary>
        public const string ADMKEY = "ADMKEY";

        /// <summary>
        /// ADUDTTM.
        /// </summary>
        public const string ADUDTTM = "ADUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CB030";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ADADRSID", "ADADRSID", JdeDataType.Numeric, null, true, true),
        new JdeField("ADTPE", "ADTPE", JdeDataType.String, 10),
        new JdeField("ADADDR1", "ADADDR1", JdeDataType.String, 80),
        new JdeField("ADADDR2", "ADADDR2", JdeDataType.String, 80),
        new JdeField("ADADDR3", "ADADDR3", JdeDataType.String, 80),
        new JdeField("ADADDR4", "ADADDR4", JdeDataType.String, 80),
        new JdeField("ADCIY", "ADCIY", JdeDataType.String, 50),
        new JdeField("ADSATE", "ADSATE", JdeDataType.String, 6),
        new JdeField("ADZCODE", "ADZCODE", JdeDataType.String, 24),
        new JdeField("ADCNY", "ADCNY", JdeDataType.String, 50),
        new JdeField("ADCONTY", "ADCONTY", JdeDataType.String, 6),
        new JdeField("ADPMADF", "ADPMADF", JdeDataType.String, 2),
        new JdeField("ADENTDBY", "ADENTDBY", JdeDataType.Numeric),
        new JdeField("ADEDATE", "ADEDATE", JdeDataType.Date),
        new JdeField("ADEXVAR0", "ADEXVAR0", JdeDataType.String, 510),
        new JdeField("ADEXVAR1", "ADEXVAR1", JdeDataType.String, 510),
        new JdeField("ADEXVAR2", "ADEXVAR2", JdeDataType.String, 510),
        new JdeField("ADEXVAR3", "ADEXVAR3", JdeDataType.String, 510),
        new JdeField("ADEXVAR4", "ADEXVAR4", JdeDataType.String, 100),
        new JdeField("ADEXVAR5", "ADEXVAR5", JdeDataType.String, 100),
        new JdeField("ADEXVAR6", "ADEXVAR6", JdeDataType.String, 100),
        new JdeField("ADEXVAR7", "ADEXVAR7", JdeDataType.String, 100),
        new JdeField("ADEXNM0", "ADEXNM0", JdeDataType.Numeric),
        new JdeField("ADEXNM1", "ADEXNM1", JdeDataType.Numeric),
        new JdeField("ADEXNM2", "ADEXNM2", JdeDataType.Numeric),
        new JdeField("ADEXNMP0", "ADEXNMP0", JdeDataType.Numeric),
        new JdeField("ADEXNMP1", "ADEXNMP1", JdeDataType.Numeric),
        new JdeField("ADEXNMP2", "ADEXNMP2", JdeDataType.Numeric),
        new JdeField("ADEXDT0", "ADEXDT0", JdeDataType.Date),
        new JdeField("ADEXDT1", "ADEXDT1", JdeDataType.Date),
        new JdeField("ADEXDT2", "ADEXDT2", JdeDataType.Date),
        new JdeField("ADSTSUDT", "ADSTSUDT", JdeDataType.Date),
        new JdeField("ADACTIND", "ADACTIND", JdeDataType.String, 2),
        new JdeField("ADUSER", "ADUSER", JdeDataType.String, 20),
        new JdeField("ADPID", "ADPID", JdeDataType.String, 20),
        new JdeField("ADVID", "ADVID", JdeDataType.String, 20),
        new JdeField("ADMKEY", "ADMKEY", JdeDataType.String, 30),
        new JdeField("ADUDTTM", "ADUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CB030_0", "Primary Key on ADADRSID", new[] { "ADADRSID" }, isUnique: true, isPrimaryKey: true)
    };
}
