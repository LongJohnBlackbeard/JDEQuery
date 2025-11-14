using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA140 - .
/// </summary>
public class F90CA140 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TYTERRID.
        /// </summary>
        public const string TYTERRID = "TYTERRID";

        /// <summary>
        /// TYDESC.
        /// </summary>
        public const string TYDESC = "TYDESC";

        /// <summary>
        /// TYBLGID.
        /// </summary>
        public const string TYBLGID = "TYBLGID";

        /// <summary>
        /// TYTERRLVL.
        /// </summary>
        public const string TYTERRLVL = "TYTERRLVL";

        /// <summary>
        /// TYHSCHLD.
        /// </summary>
        public const string TYHSCHLD = "TYHSCHLD";

        /// <summary>
        /// TYENTDBY.
        /// </summary>
        public const string TYENTDBY = "TYENTDBY";

        /// <summary>
        /// TYEDATE.
        /// </summary>
        public const string TYEDATE = "TYEDATE";

        /// <summary>
        /// TYUSER.
        /// </summary>
        public const string TYUSER = "TYUSER";

        /// <summary>
        /// TYUDTTM.
        /// </summary>
        public const string TYUDTTM = "TYUDTTM";

        /// <summary>
        /// TYEXVAR0.
        /// </summary>
        public const string TYEXVAR0 = "TYEXVAR0";

        /// <summary>
        /// TYEXVAR1.
        /// </summary>
        public const string TYEXVAR1 = "TYEXVAR1";

        /// <summary>
        /// TYEXVAR2.
        /// </summary>
        public const string TYEXVAR2 = "TYEXVAR2";

        /// <summary>
        /// TYEXVAR3.
        /// </summary>
        public const string TYEXVAR3 = "TYEXVAR3";

        /// <summary>
        /// TYEXVAR4.
        /// </summary>
        public const string TYEXVAR4 = "TYEXVAR4";

        /// <summary>
        /// TYEXVAR5.
        /// </summary>
        public const string TYEXVAR5 = "TYEXVAR5";

        /// <summary>
        /// TYEXVAR6.
        /// </summary>
        public const string TYEXVAR6 = "TYEXVAR6";

        /// <summary>
        /// TYEXVAR7.
        /// </summary>
        public const string TYEXVAR7 = "TYEXVAR7";

        /// <summary>
        /// TYEXNM0.
        /// </summary>
        public const string TYEXNM0 = "TYEXNM0";

        /// <summary>
        /// TYEXNM1.
        /// </summary>
        public const string TYEXNM1 = "TYEXNM1";

        /// <summary>
        /// TYEXNM2.
        /// </summary>
        public const string TYEXNM2 = "TYEXNM2";

        /// <summary>
        /// TYEXNMP0.
        /// </summary>
        public const string TYEXNMP0 = "TYEXNMP0";

        /// <summary>
        /// TYEXNMP1.
        /// </summary>
        public const string TYEXNMP1 = "TYEXNMP1";

        /// <summary>
        /// TYEXNMP2.
        /// </summary>
        public const string TYEXNMP2 = "TYEXNMP2";

        /// <summary>
        /// TYEXDT0.
        /// </summary>
        public const string TYEXDT0 = "TYEXDT0";

        /// <summary>
        /// TYEXDT1.
        /// </summary>
        public const string TYEXDT1 = "TYEXDT1";

        /// <summary>
        /// TYEXDT2.
        /// </summary>
        public const string TYEXDT2 = "TYEXDT2";

        /// <summary>
        /// TYSTSUDT.
        /// </summary>
        public const string TYSTSUDT = "TYSTSUDT";

        /// <summary>
        /// TYACTIND.
        /// </summary>
        public const string TYACTIND = "TYACTIND";

        /// <summary>
        /// TYPID.
        /// </summary>
        public const string TYPID = "TYPID";

        /// <summary>
        /// TYVID.
        /// </summary>
        public const string TYVID = "TYVID";

        /// <summary>
        /// TYMKEY.
        /// </summary>
        public const string TYMKEY = "TYMKEY";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA140";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TYTERRID", "TYTERRID", JdeDataType.Numeric, null, true, true),
        new JdeField("TYDESC", "TYDESC", JdeDataType.String, 60),
        new JdeField("TYBLGID", "TYBLGID", JdeDataType.Numeric),
        new JdeField("TYTERRLVL", "TYTERRLVL", JdeDataType.Numeric),
        new JdeField("TYHSCHLD", "TYHSCHLD", JdeDataType.String, 2),
        new JdeField("TYENTDBY", "TYENTDBY", JdeDataType.Numeric),
        new JdeField("TYEDATE", "TYEDATE", JdeDataType.Date),
        new JdeField("TYUSER", "TYUSER", JdeDataType.String, 20),
        new JdeField("TYUDTTM", "TYUDTTM", JdeDataType.Date),
        new JdeField("TYEXVAR0", "TYEXVAR0", JdeDataType.String, 510),
        new JdeField("TYEXVAR1", "TYEXVAR1", JdeDataType.String, 510),
        new JdeField("TYEXVAR2", "TYEXVAR2", JdeDataType.String, 510),
        new JdeField("TYEXVAR3", "TYEXVAR3", JdeDataType.String, 510),
        new JdeField("TYEXVAR4", "TYEXVAR4", JdeDataType.String, 100),
        new JdeField("TYEXVAR5", "TYEXVAR5", JdeDataType.String, 100),
        new JdeField("TYEXVAR6", "TYEXVAR6", JdeDataType.String, 100),
        new JdeField("TYEXVAR7", "TYEXVAR7", JdeDataType.String, 100),
        new JdeField("TYEXNM0", "TYEXNM0", JdeDataType.Numeric),
        new JdeField("TYEXNM1", "TYEXNM1", JdeDataType.Numeric),
        new JdeField("TYEXNM2", "TYEXNM2", JdeDataType.Numeric),
        new JdeField("TYEXNMP0", "TYEXNMP0", JdeDataType.Numeric),
        new JdeField("TYEXNMP1", "TYEXNMP1", JdeDataType.Numeric),
        new JdeField("TYEXNMP2", "TYEXNMP2", JdeDataType.Numeric),
        new JdeField("TYEXDT0", "TYEXDT0", JdeDataType.Date),
        new JdeField("TYEXDT1", "TYEXDT1", JdeDataType.Date),
        new JdeField("TYEXDT2", "TYEXDT2", JdeDataType.Date),
        new JdeField("TYSTSUDT", "TYSTSUDT", JdeDataType.Date),
        new JdeField("TYACTIND", "TYACTIND", JdeDataType.String, 2),
        new JdeField("TYPID", "TYPID", JdeDataType.String, 20),
        new JdeField("TYVID", "TYVID", JdeDataType.String, 20),
        new JdeField("TYMKEY", "TYMKEY", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA140_0", "Primary Key on TYTERRID", new[] { "TYTERRID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CA140_2", "Index on TYBLGID", new[] { "TYBLGID" })
    };
}
