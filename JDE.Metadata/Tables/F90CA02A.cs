using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA02A - .
/// </summary>
public class F90CA02A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TANOTID.
        /// </summary>
        public const string TANOTID = "TANOTID";

        /// <summary>
        /// TAPSAN8.
        /// </summary>
        public const string TAPSAN8 = "TAPSAN8";

        /// <summary>
        /// TAALERTF.
        /// </summary>
        public const string TAALERTF = "TAALERTF";

        /// <summary>
        /// TAEMAILF.
        /// </summary>
        public const string TAEMAILF = "TAEMAILF";

        /// <summary>
        /// TAPOPUPF.
        /// </summary>
        public const string TAPOPUPF = "TAPOPUPF";

        /// <summary>
        /// TANONEF.
        /// </summary>
        public const string TANONEF = "TANONEF";

        /// <summary>
        /// TAEXVAR0.
        /// </summary>
        public const string TAEXVAR0 = "TAEXVAR0";

        /// <summary>
        /// TAEXVAR1.
        /// </summary>
        public const string TAEXVAR1 = "TAEXVAR1";

        /// <summary>
        /// TAEXVAR4.
        /// </summary>
        public const string TAEXVAR4 = "TAEXVAR4";

        /// <summary>
        /// TAEXVAR5.
        /// </summary>
        public const string TAEXVAR5 = "TAEXVAR5";

        /// <summary>
        /// TAEXVAR6.
        /// </summary>
        public const string TAEXVAR6 = "TAEXVAR6";

        /// <summary>
        /// TAEXVAR7.
        /// </summary>
        public const string TAEXVAR7 = "TAEXVAR7";

        /// <summary>
        /// TAEXVAR12.
        /// </summary>
        public const string TAEXVAR12 = "TAEXVAR12";

        /// <summary>
        /// TAEXVAR13.
        /// </summary>
        public const string TAEXVAR13 = "TAEXVAR13";

        /// <summary>
        /// TAEXNM0.
        /// </summary>
        public const string TAEXNM0 = "TAEXNM0";

        /// <summary>
        /// TAEXNM1.
        /// </summary>
        public const string TAEXNM1 = "TAEXNM1";

        /// <summary>
        /// TAEXNM2.
        /// </summary>
        public const string TAEXNM2 = "TAEXNM2";

        /// <summary>
        /// TAEXNMP0.
        /// </summary>
        public const string TAEXNMP0 = "TAEXNMP0";

        /// <summary>
        /// TAEXNMP1.
        /// </summary>
        public const string TAEXNMP1 = "TAEXNMP1";

        /// <summary>
        /// TAEXNMP2.
        /// </summary>
        public const string TAEXNMP2 = "TAEXNMP2";

        /// <summary>
        /// TAEXDT0.
        /// </summary>
        public const string TAEXDT0 = "TAEXDT0";

        /// <summary>
        /// TAEXDT1.
        /// </summary>
        public const string TAEXDT1 = "TAEXDT1";

        /// <summary>
        /// TAEXDT2.
        /// </summary>
        public const string TAEXDT2 = "TAEXDT2";

        /// <summary>
        /// TASTSUDT.
        /// </summary>
        public const string TASTSUDT = "TASTSUDT";

        /// <summary>
        /// TAACTIND.
        /// </summary>
        public const string TAACTIND = "TAACTIND";

        /// <summary>
        /// TAUSER.
        /// </summary>
        public const string TAUSER = "TAUSER";

        /// <summary>
        /// TAPID.
        /// </summary>
        public const string TAPID = "TAPID";

        /// <summary>
        /// TAVID.
        /// </summary>
        public const string TAVID = "TAVID";

        /// <summary>
        /// TAMKEY.
        /// </summary>
        public const string TAMKEY = "TAMKEY";

        /// <summary>
        /// TAUDTTM.
        /// </summary>
        public const string TAUDTTM = "TAUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA02A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TANOTID", "TANOTID", JdeDataType.Numeric, null, true, true),
        new JdeField("TAPSAN8", "TAPSAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("TAALERTF", "TAALERTF", JdeDataType.String, 2),
        new JdeField("TAEMAILF", "TAEMAILF", JdeDataType.String, 2),
        new JdeField("TAPOPUPF", "TAPOPUPF", JdeDataType.String, 2),
        new JdeField("TANONEF", "TANONEF", JdeDataType.String, 2),
        new JdeField("TAEXVAR0", "TAEXVAR0", JdeDataType.String, 510),
        new JdeField("TAEXVAR1", "TAEXVAR1", JdeDataType.String, 510),
        new JdeField("TAEXVAR4", "TAEXVAR4", JdeDataType.String, 100),
        new JdeField("TAEXVAR5", "TAEXVAR5", JdeDataType.String, 100),
        new JdeField("TAEXVAR6", "TAEXVAR6", JdeDataType.String, 100),
        new JdeField("TAEXVAR7", "TAEXVAR7", JdeDataType.String, 100),
        new JdeField("TAEXVAR12", "TAEXVAR12", JdeDataType.String, 50),
        new JdeField("TAEXVAR13", "TAEXVAR13", JdeDataType.String, 50),
        new JdeField("TAEXNM0", "TAEXNM0", JdeDataType.Numeric),
        new JdeField("TAEXNM1", "TAEXNM1", JdeDataType.Numeric),
        new JdeField("TAEXNM2", "TAEXNM2", JdeDataType.Numeric),
        new JdeField("TAEXNMP0", "TAEXNMP0", JdeDataType.Numeric),
        new JdeField("TAEXNMP1", "TAEXNMP1", JdeDataType.Numeric),
        new JdeField("TAEXNMP2", "TAEXNMP2", JdeDataType.Numeric),
        new JdeField("TAEXDT0", "TAEXDT0", JdeDataType.Date),
        new JdeField("TAEXDT1", "TAEXDT1", JdeDataType.Date),
        new JdeField("TAEXDT2", "TAEXDT2", JdeDataType.Date),
        new JdeField("TASTSUDT", "TASTSUDT", JdeDataType.Date),
        new JdeField("TAACTIND", "TAACTIND", JdeDataType.String, 2),
        new JdeField("TAUSER", "TAUSER", JdeDataType.String, 20),
        new JdeField("TAPID", "TAPID", JdeDataType.String, 20),
        new JdeField("TAVID", "TAVID", JdeDataType.String, 20),
        new JdeField("TAMKEY", "TAMKEY", JdeDataType.String, 30),
        new JdeField("TAUDTTM", "TAUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA02A_0", "Primary Key on TANOTID, TAPSAN8", new[] { "TANOTID", "TAPSAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
