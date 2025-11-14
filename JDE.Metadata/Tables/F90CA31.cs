using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA31 - .
/// </summary>
public class F90CA31 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EXACTIVID.
        /// </summary>
        public const string EXACTIVID = "EXACTIVID";

        /// <summary>
        /// EXACTAC.
        /// </summary>
        public const string EXACTAC = "EXACTAC";

        /// <summary>
        /// EXACTPT.
        /// </summary>
        public const string EXACTPT = "EXACTPT";

        /// <summary>
        /// EXACTCT.
        /// </summary>
        public const string EXACTCT = "EXACTCT";

        /// <summary>
        /// EXACTPC.
        /// </summary>
        public const string EXACTPC = "EXACTPC";

        /// <summary>
        /// EXEXVAR0.
        /// </summary>
        public const string EXEXVAR0 = "EXEXVAR0";

        /// <summary>
        /// EXEXVAR1.
        /// </summary>
        public const string EXEXVAR1 = "EXEXVAR1";

        /// <summary>
        /// EXEXVAR2.
        /// </summary>
        public const string EXEXVAR2 = "EXEXVAR2";

        /// <summary>
        /// EXEXVAR3.
        /// </summary>
        public const string EXEXVAR3 = "EXEXVAR3";

        /// <summary>
        /// EXEXVAR4.
        /// </summary>
        public const string EXEXVAR4 = "EXEXVAR4";

        /// <summary>
        /// EXEXVAR5.
        /// </summary>
        public const string EXEXVAR5 = "EXEXVAR5";

        /// <summary>
        /// EXEXVAR6.
        /// </summary>
        public const string EXEXVAR6 = "EXEXVAR6";

        /// <summary>
        /// EXEXVAR7.
        /// </summary>
        public const string EXEXVAR7 = "EXEXVAR7";

        /// <summary>
        /// EXEXVAR8.
        /// </summary>
        public const string EXEXVAR8 = "EXEXVAR8";

        /// <summary>
        /// EXEXVAR9.
        /// </summary>
        public const string EXEXVAR9 = "EXEXVAR9";

        /// <summary>
        /// EXEXVAR10.
        /// </summary>
        public const string EXEXVAR10 = "EXEXVAR10";

        /// <summary>
        /// EXEXVAR11.
        /// </summary>
        public const string EXEXVAR11 = "EXEXVAR11";

        /// <summary>
        /// EXEXVAR12.
        /// </summary>
        public const string EXEXVAR12 = "EXEXVAR12";

        /// <summary>
        /// EXEXVAR13.
        /// </summary>
        public const string EXEXVAR13 = "EXEXVAR13";

        /// <summary>
        /// EXEXVAR14.
        /// </summary>
        public const string EXEXVAR14 = "EXEXVAR14";

        /// <summary>
        /// EXEXNM0.
        /// </summary>
        public const string EXEXNM0 = "EXEXNM0";

        /// <summary>
        /// EXEXNM1.
        /// </summary>
        public const string EXEXNM1 = "EXEXNM1";

        /// <summary>
        /// EXEXNM2.
        /// </summary>
        public const string EXEXNM2 = "EXEXNM2";

        /// <summary>
        /// EXEXNM3.
        /// </summary>
        public const string EXEXNM3 = "EXEXNM3";

        /// <summary>
        /// EXEXNM4.
        /// </summary>
        public const string EXEXNM4 = "EXEXNM4";

        /// <summary>
        /// EXEXNMP0.
        /// </summary>
        public const string EXEXNMP0 = "EXEXNMP0";

        /// <summary>
        /// EXEXNMP1.
        /// </summary>
        public const string EXEXNMP1 = "EXEXNMP1";

        /// <summary>
        /// EXEXNMP2.
        /// </summary>
        public const string EXEXNMP2 = "EXEXNMP2";

        /// <summary>
        /// EXEXNMP3.
        /// </summary>
        public const string EXEXNMP3 = "EXEXNMP3";

        /// <summary>
        /// EXEXNMP4.
        /// </summary>
        public const string EXEXNMP4 = "EXEXNMP4";

        /// <summary>
        /// EXEXDT0.
        /// </summary>
        public const string EXEXDT0 = "EXEXDT0";

        /// <summary>
        /// EXEXDT1.
        /// </summary>
        public const string EXEXDT1 = "EXEXDT1";

        /// <summary>
        /// EXEXDT2.
        /// </summary>
        public const string EXEXDT2 = "EXEXDT2";

        /// <summary>
        /// EXEXDT3.
        /// </summary>
        public const string EXEXDT3 = "EXEXDT3";

        /// <summary>
        /// EXEXDT4.
        /// </summary>
        public const string EXEXDT4 = "EXEXDT4";

        /// <summary>
        /// EXACTIND.
        /// </summary>
        public const string EXACTIND = "EXACTIND";

        /// <summary>
        /// EXUDTTM.
        /// </summary>
        public const string EXUDTTM = "EXUDTTM";

        /// <summary>
        /// EXSTSUDT.
        /// </summary>
        public const string EXSTSUDT = "EXSTSUDT";

        /// <summary>
        /// EXEDATE.
        /// </summary>
        public const string EXEDATE = "EXEDATE";

        /// <summary>
        /// EXENTDBY.
        /// </summary>
        public const string EXENTDBY = "EXENTDBY";

        /// <summary>
        /// EXMKEY.
        /// </summary>
        public const string EXMKEY = "EXMKEY";

        /// <summary>
        /// EXUSER.
        /// </summary>
        public const string EXUSER = "EXUSER";

        /// <summary>
        /// EXPID.
        /// </summary>
        public const string EXPID = "EXPID";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA31";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EXACTIVID", "EXACTIVID", JdeDataType.String, 72, true, true),
        new JdeField("EXACTAC", "EXACTAC", JdeDataType.Numeric),
        new JdeField("EXACTPT", "EXACTPT", JdeDataType.Numeric),
        new JdeField("EXACTCT", "EXACTCT", JdeDataType.Numeric),
        new JdeField("EXACTPC", "EXACTPC", JdeDataType.Numeric),
        new JdeField("EXEXVAR0", "EXEXVAR0", JdeDataType.String, 510),
        new JdeField("EXEXVAR1", "EXEXVAR1", JdeDataType.String, 510),
        new JdeField("EXEXVAR2", "EXEXVAR2", JdeDataType.String, 510),
        new JdeField("EXEXVAR3", "EXEXVAR3", JdeDataType.String, 510),
        new JdeField("EXEXVAR4", "EXEXVAR4", JdeDataType.String, 100),
        new JdeField("EXEXVAR5", "EXEXVAR5", JdeDataType.String, 100),
        new JdeField("EXEXVAR6", "EXEXVAR6", JdeDataType.String, 100),
        new JdeField("EXEXVAR7", "EXEXVAR7", JdeDataType.String, 100),
        new JdeField("EXEXVAR8", "EXEXVAR8", JdeDataType.String, 100),
        new JdeField("EXEXVAR9", "EXEXVAR9", JdeDataType.String, 100),
        new JdeField("EXEXVAR10", "EXEXVAR10", JdeDataType.String, 100),
        new JdeField("EXEXVAR11", "EXEXVAR11", JdeDataType.String, 100),
        new JdeField("EXEXVAR12", "EXEXVAR12", JdeDataType.String, 50),
        new JdeField("EXEXVAR13", "EXEXVAR13", JdeDataType.String, 50),
        new JdeField("EXEXVAR14", "EXEXVAR14", JdeDataType.String, 50),
        new JdeField("EXEXNM0", "EXEXNM0", JdeDataType.Numeric),
        new JdeField("EXEXNM1", "EXEXNM1", JdeDataType.Numeric),
        new JdeField("EXEXNM2", "EXEXNM2", JdeDataType.Numeric),
        new JdeField("EXEXNM3", "EXEXNM3", JdeDataType.Numeric),
        new JdeField("EXEXNM4", "EXEXNM4", JdeDataType.Numeric),
        new JdeField("EXEXNMP0", "EXEXNMP0", JdeDataType.Numeric),
        new JdeField("EXEXNMP1", "EXEXNMP1", JdeDataType.Numeric),
        new JdeField("EXEXNMP2", "EXEXNMP2", JdeDataType.Numeric),
        new JdeField("EXEXNMP3", "EXEXNMP3", JdeDataType.Numeric),
        new JdeField("EXEXNMP4", "EXEXNMP4", JdeDataType.Numeric),
        new JdeField("EXEXDT0", "EXEXDT0", JdeDataType.Date),
        new JdeField("EXEXDT1", "EXEXDT1", JdeDataType.Date),
        new JdeField("EXEXDT2", "EXEXDT2", JdeDataType.Date),
        new JdeField("EXEXDT3", "EXEXDT3", JdeDataType.Date),
        new JdeField("EXEXDT4", "EXEXDT4", JdeDataType.Date),
        new JdeField("EXACTIND", "EXACTIND", JdeDataType.String, 2),
        new JdeField("EXUDTTM", "EXUDTTM", JdeDataType.Date),
        new JdeField("EXSTSUDT", "EXSTSUDT", JdeDataType.Date),
        new JdeField("EXEDATE", "EXEDATE", JdeDataType.Date),
        new JdeField("EXENTDBY", "EXENTDBY", JdeDataType.Numeric),
        new JdeField("EXMKEY", "EXMKEY", JdeDataType.String, 30),
        new JdeField("EXUSER", "EXUSER", JdeDataType.String, 20),
        new JdeField("EXPID", "EXPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA31_0", "Primary Key on EXACTIVID", new[] { "EXACTIVID" }, isUnique: true, isPrimaryKey: true)
    };
}
