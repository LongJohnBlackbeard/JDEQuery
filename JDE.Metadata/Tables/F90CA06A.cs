using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA06A - .
/// </summary>
public class F90CA06A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RACMAN8.
        /// </summary>
        public const string RACMAN8 = "RACMAN8";

        /// <summary>
        /// RASNMB.
        /// </summary>
        public const string RASNMB = "RASNMB";

        /// <summary>
        /// RAITDESC.
        /// </summary>
        public const string RAITDESC = "RAITDESC";

        /// <summary>
        /// RAITM.
        /// </summary>
        public const string RAITM = "RAITM";

        /// <summary>
        /// RAEXVAR0.
        /// </summary>
        public const string RAEXVAR0 = "RAEXVAR0";

        /// <summary>
        /// RAEXVAR1.
        /// </summary>
        public const string RAEXVAR1 = "RAEXVAR1";

        /// <summary>
        /// RAEXVAR4.
        /// </summary>
        public const string RAEXVAR4 = "RAEXVAR4";

        /// <summary>
        /// RAEXVAR5.
        /// </summary>
        public const string RAEXVAR5 = "RAEXVAR5";

        /// <summary>
        /// RAEXVAR6.
        /// </summary>
        public const string RAEXVAR6 = "RAEXVAR6";

        /// <summary>
        /// RAEXVAR7.
        /// </summary>
        public const string RAEXVAR7 = "RAEXVAR7";

        /// <summary>
        /// RAEXVAR12.
        /// </summary>
        public const string RAEXVAR12 = "RAEXVAR12";

        /// <summary>
        /// RAEXVAR13.
        /// </summary>
        public const string RAEXVAR13 = "RAEXVAR13";

        /// <summary>
        /// RAEXNM0.
        /// </summary>
        public const string RAEXNM0 = "RAEXNM0";

        /// <summary>
        /// RAEXNM1.
        /// </summary>
        public const string RAEXNM1 = "RAEXNM1";

        /// <summary>
        /// RAEXNM2.
        /// </summary>
        public const string RAEXNM2 = "RAEXNM2";

        /// <summary>
        /// RAEXNMP0.
        /// </summary>
        public const string RAEXNMP0 = "RAEXNMP0";

        /// <summary>
        /// RAEXNMP1.
        /// </summary>
        public const string RAEXNMP1 = "RAEXNMP1";

        /// <summary>
        /// RAEXNMP2.
        /// </summary>
        public const string RAEXNMP2 = "RAEXNMP2";

        /// <summary>
        /// RAEXDT0.
        /// </summary>
        public const string RAEXDT0 = "RAEXDT0";

        /// <summary>
        /// RAEXDT1.
        /// </summary>
        public const string RAEXDT1 = "RAEXDT1";

        /// <summary>
        /// RAEXDT2.
        /// </summary>
        public const string RAEXDT2 = "RAEXDT2";

        /// <summary>
        /// RASTSUDT.
        /// </summary>
        public const string RASTSUDT = "RASTSUDT";

        /// <summary>
        /// RAACTIND.
        /// </summary>
        public const string RAACTIND = "RAACTIND";

        /// <summary>
        /// RAUSER.
        /// </summary>
        public const string RAUSER = "RAUSER";

        /// <summary>
        /// RAPID.
        /// </summary>
        public const string RAPID = "RAPID";

        /// <summary>
        /// RAVID.
        /// </summary>
        public const string RAVID = "RAVID";

        /// <summary>
        /// RAMKEY.
        /// </summary>
        public const string RAMKEY = "RAMKEY";

        /// <summary>
        /// RAENTDBY.
        /// </summary>
        public const string RAENTDBY = "RAENTDBY";

        /// <summary>
        /// RAEDATE.
        /// </summary>
        public const string RAEDATE = "RAEDATE";

        /// <summary>
        /// RAUDTTM.
        /// </summary>
        public const string RAUDTTM = "RAUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA06A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RACMAN8", "RACMAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("RASNMB", "RASNMB", JdeDataType.Numeric, null, true, true),
        new JdeField("RAITDESC", "RAITDESC", JdeDataType.String, 100),
        new JdeField("RAITM", "RAITM", JdeDataType.Numeric),
        new JdeField("RAEXVAR0", "RAEXVAR0", JdeDataType.String, 510),
        new JdeField("RAEXVAR1", "RAEXVAR1", JdeDataType.String, 510),
        new JdeField("RAEXVAR4", "RAEXVAR4", JdeDataType.String, 100),
        new JdeField("RAEXVAR5", "RAEXVAR5", JdeDataType.String, 100),
        new JdeField("RAEXVAR6", "RAEXVAR6", JdeDataType.String, 100),
        new JdeField("RAEXVAR7", "RAEXVAR7", JdeDataType.String, 100),
        new JdeField("RAEXVAR12", "RAEXVAR12", JdeDataType.String, 50),
        new JdeField("RAEXVAR13", "RAEXVAR13", JdeDataType.String, 50),
        new JdeField("RAEXNM0", "RAEXNM0", JdeDataType.Numeric),
        new JdeField("RAEXNM1", "RAEXNM1", JdeDataType.Numeric),
        new JdeField("RAEXNM2", "RAEXNM2", JdeDataType.Numeric),
        new JdeField("RAEXNMP0", "RAEXNMP0", JdeDataType.Numeric),
        new JdeField("RAEXNMP1", "RAEXNMP1", JdeDataType.Numeric),
        new JdeField("RAEXNMP2", "RAEXNMP2", JdeDataType.Numeric),
        new JdeField("RAEXDT0", "RAEXDT0", JdeDataType.Date),
        new JdeField("RAEXDT1", "RAEXDT1", JdeDataType.Date),
        new JdeField("RAEXDT2", "RAEXDT2", JdeDataType.Date),
        new JdeField("RASTSUDT", "RASTSUDT", JdeDataType.Date),
        new JdeField("RAACTIND", "RAACTIND", JdeDataType.String, 2),
        new JdeField("RAUSER", "RAUSER", JdeDataType.String, 20),
        new JdeField("RAPID", "RAPID", JdeDataType.String, 20),
        new JdeField("RAVID", "RAVID", JdeDataType.String, 20),
        new JdeField("RAMKEY", "RAMKEY", JdeDataType.String, 30),
        new JdeField("RAENTDBY", "RAENTDBY", JdeDataType.Numeric),
        new JdeField("RAEDATE", "RAEDATE", JdeDataType.Date),
        new JdeField("RAUDTTM", "RAUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA06A_0", "Primary Key on RACMAN8, RASNMB", new[] { "RACMAN8", "RASNMB" }, isUnique: true, isPrimaryKey: true)
    };
}
