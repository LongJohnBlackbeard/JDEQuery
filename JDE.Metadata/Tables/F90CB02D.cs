using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CB02D - .
/// </summary>
public class F90CB02D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ODOPPID.
        /// </summary>
        public const string ODOPPID = "ODOPPID";

        /// <summary>
        /// ODAN8.
        /// </summary>
        public const string ODAN8 = "ODAN8";

        /// <summary>
        /// ODIDLN.
        /// </summary>
        public const string ODIDLN = "ODIDLN";

        /// <summary>
        /// ODSPLVL.
        /// </summary>
        public const string ODSPLVL = "ODSPLVL";

        /// <summary>
        /// ODSPTYP.
        /// </summary>
        public const string ODSPTYP = "ODSPTYP";

        /// <summary>
        /// ODENTDBY.
        /// </summary>
        public const string ODENTDBY = "ODENTDBY";

        /// <summary>
        /// ODEDATE.
        /// </summary>
        public const string ODEDATE = "ODEDATE";

        /// <summary>
        /// ODEXVAR0.
        /// </summary>
        public const string ODEXVAR0 = "ODEXVAR0";

        /// <summary>
        /// ODEXVAR1.
        /// </summary>
        public const string ODEXVAR1 = "ODEXVAR1";

        /// <summary>
        /// ODEXVAR4.
        /// </summary>
        public const string ODEXVAR4 = "ODEXVAR4";

        /// <summary>
        /// ODEXVAR5.
        /// </summary>
        public const string ODEXVAR5 = "ODEXVAR5";

        /// <summary>
        /// ODEXVAR6.
        /// </summary>
        public const string ODEXVAR6 = "ODEXVAR6";

        /// <summary>
        /// ODEXVAR7.
        /// </summary>
        public const string ODEXVAR7 = "ODEXVAR7";

        /// <summary>
        /// ODEXVAR12.
        /// </summary>
        public const string ODEXVAR12 = "ODEXVAR12";

        /// <summary>
        /// ODEXVAR13.
        /// </summary>
        public const string ODEXVAR13 = "ODEXVAR13";

        /// <summary>
        /// ODEXNM0.
        /// </summary>
        public const string ODEXNM0 = "ODEXNM0";

        /// <summary>
        /// ODEXNM1.
        /// </summary>
        public const string ODEXNM1 = "ODEXNM1";

        /// <summary>
        /// ODEXNM2.
        /// </summary>
        public const string ODEXNM2 = "ODEXNM2";

        /// <summary>
        /// ODEXNMP0.
        /// </summary>
        public const string ODEXNMP0 = "ODEXNMP0";

        /// <summary>
        /// ODEXNMP1.
        /// </summary>
        public const string ODEXNMP1 = "ODEXNMP1";

        /// <summary>
        /// ODEXNMP2.
        /// </summary>
        public const string ODEXNMP2 = "ODEXNMP2";

        /// <summary>
        /// ODEXDT0.
        /// </summary>
        public const string ODEXDT0 = "ODEXDT0";

        /// <summary>
        /// ODEXDT1.
        /// </summary>
        public const string ODEXDT1 = "ODEXDT1";

        /// <summary>
        /// ODEXDT2.
        /// </summary>
        public const string ODEXDT2 = "ODEXDT2";

        /// <summary>
        /// ODSTSUDT.
        /// </summary>
        public const string ODSTSUDT = "ODSTSUDT";

        /// <summary>
        /// ODACTIND.
        /// </summary>
        public const string ODACTIND = "ODACTIND";

        /// <summary>
        /// ODUSER.
        /// </summary>
        public const string ODUSER = "ODUSER";

        /// <summary>
        /// ODPID.
        /// </summary>
        public const string ODPID = "ODPID";

        /// <summary>
        /// ODVID.
        /// </summary>
        public const string ODVID = "ODVID";

        /// <summary>
        /// ODMKEY.
        /// </summary>
        public const string ODMKEY = "ODMKEY";

        /// <summary>
        /// ODUDTTM.
        /// </summary>
        public const string ODUDTTM = "ODUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CB02D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ODOPPID", "ODOPPID", JdeDataType.Numeric, null, true, true),
        new JdeField("ODAN8", "ODAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ODIDLN", "ODIDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("ODSPLVL", "ODSPLVL", JdeDataType.String, 10),
        new JdeField("ODSPTYP", "ODSPTYP", JdeDataType.String, 10),
        new JdeField("ODENTDBY", "ODENTDBY", JdeDataType.Numeric),
        new JdeField("ODEDATE", "ODEDATE", JdeDataType.Date),
        new JdeField("ODEXVAR0", "ODEXVAR0", JdeDataType.String, 510),
        new JdeField("ODEXVAR1", "ODEXVAR1", JdeDataType.String, 510),
        new JdeField("ODEXVAR4", "ODEXVAR4", JdeDataType.String, 100),
        new JdeField("ODEXVAR5", "ODEXVAR5", JdeDataType.String, 100),
        new JdeField("ODEXVAR6", "ODEXVAR6", JdeDataType.String, 100),
        new JdeField("ODEXVAR7", "ODEXVAR7", JdeDataType.String, 100),
        new JdeField("ODEXVAR12", "ODEXVAR12", JdeDataType.String, 50),
        new JdeField("ODEXVAR13", "ODEXVAR13", JdeDataType.String, 50),
        new JdeField("ODEXNM0", "ODEXNM0", JdeDataType.Numeric),
        new JdeField("ODEXNM1", "ODEXNM1", JdeDataType.Numeric),
        new JdeField("ODEXNM2", "ODEXNM2", JdeDataType.Numeric),
        new JdeField("ODEXNMP0", "ODEXNMP0", JdeDataType.Numeric),
        new JdeField("ODEXNMP1", "ODEXNMP1", JdeDataType.Numeric),
        new JdeField("ODEXNMP2", "ODEXNMP2", JdeDataType.Numeric),
        new JdeField("ODEXDT0", "ODEXDT0", JdeDataType.Date),
        new JdeField("ODEXDT1", "ODEXDT1", JdeDataType.Date),
        new JdeField("ODEXDT2", "ODEXDT2", JdeDataType.Date),
        new JdeField("ODSTSUDT", "ODSTSUDT", JdeDataType.Date),
        new JdeField("ODACTIND", "ODACTIND", JdeDataType.String, 2),
        new JdeField("ODUSER", "ODUSER", JdeDataType.String, 20),
        new JdeField("ODPID", "ODPID", JdeDataType.String, 20),
        new JdeField("ODVID", "ODVID", JdeDataType.String, 20),
        new JdeField("ODMKEY", "ODMKEY", JdeDataType.String, 30),
        new JdeField("ODUDTTM", "ODUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CB02D_0", "Primary Key on ODOPPID, ODAN8, ODIDLN", new[] { "ODOPPID", "ODAN8", "ODIDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
