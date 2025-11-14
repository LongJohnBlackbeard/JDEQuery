using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA08E - .
/// </summary>
public class F90CA08E : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UECUPRID.
        /// </summary>
        public const string UECUPRID = "UECUPRID";

        /// <summary>
        /// UEANSWID.
        /// </summary>
        public const string UEANSWID = "UEANSWID";

        /// <summary>
        /// UECUAN8.
        /// </summary>
        public const string UECUAN8 = "UECUAN8";

        /// <summary>
        /// UEPRCDE.
        /// </summary>
        public const string UEPRCDE = "UEPRCDE";

        /// <summary>
        /// UETXTANS.
        /// </summary>
        public const string UETXTANS = "UETXTANS";

        /// <summary>
        /// UEEXVAR0.
        /// </summary>
        public const string UEEXVAR0 = "UEEXVAR0";

        /// <summary>
        /// UEEXVAR1.
        /// </summary>
        public const string UEEXVAR1 = "UEEXVAR1";

        /// <summary>
        /// UEEXVAR4.
        /// </summary>
        public const string UEEXVAR4 = "UEEXVAR4";

        /// <summary>
        /// UEEXVAR5.
        /// </summary>
        public const string UEEXVAR5 = "UEEXVAR5";

        /// <summary>
        /// UEEXVAR6.
        /// </summary>
        public const string UEEXVAR6 = "UEEXVAR6";

        /// <summary>
        /// UEEXVAR7.
        /// </summary>
        public const string UEEXVAR7 = "UEEXVAR7";

        /// <summary>
        /// UEEXVAR12.
        /// </summary>
        public const string UEEXVAR12 = "UEEXVAR12";

        /// <summary>
        /// UEEXVAR13.
        /// </summary>
        public const string UEEXVAR13 = "UEEXVAR13";

        /// <summary>
        /// UEEXNM0.
        /// </summary>
        public const string UEEXNM0 = "UEEXNM0";

        /// <summary>
        /// UEEXNM1.
        /// </summary>
        public const string UEEXNM1 = "UEEXNM1";

        /// <summary>
        /// UEEXNM2.
        /// </summary>
        public const string UEEXNM2 = "UEEXNM2";

        /// <summary>
        /// UEEXNMP0.
        /// </summary>
        public const string UEEXNMP0 = "UEEXNMP0";

        /// <summary>
        /// UEEXNMP1.
        /// </summary>
        public const string UEEXNMP1 = "UEEXNMP1";

        /// <summary>
        /// UEEXNMP2.
        /// </summary>
        public const string UEEXNMP2 = "UEEXNMP2";

        /// <summary>
        /// UEEXDT0.
        /// </summary>
        public const string UEEXDT0 = "UEEXDT0";

        /// <summary>
        /// UEEXDT1.
        /// </summary>
        public const string UEEXDT1 = "UEEXDT1";

        /// <summary>
        /// UEEXDT2.
        /// </summary>
        public const string UEEXDT2 = "UEEXDT2";

        /// <summary>
        /// UESTSUDT.
        /// </summary>
        public const string UESTSUDT = "UESTSUDT";

        /// <summary>
        /// UEACTIND.
        /// </summary>
        public const string UEACTIND = "UEACTIND";

        /// <summary>
        /// UEUSER.
        /// </summary>
        public const string UEUSER = "UEUSER";

        /// <summary>
        /// UEPID.
        /// </summary>
        public const string UEPID = "UEPID";

        /// <summary>
        /// UEVID.
        /// </summary>
        public const string UEVID = "UEVID";

        /// <summary>
        /// UEMKEY.
        /// </summary>
        public const string UEMKEY = "UEMKEY";

        /// <summary>
        /// UEUDTTM.
        /// </summary>
        public const string UEUDTTM = "UEUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA08E";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UECUPRID", "UECUPRID", JdeDataType.Numeric, null, true, true),
        new JdeField("UEANSWID", "UEANSWID", JdeDataType.Numeric),
        new JdeField("UECUAN8", "UECUAN8", JdeDataType.Numeric),
        new JdeField("UEPRCDE", "UEPRCDE", JdeDataType.String, 30),
        new JdeField("UETXTANS", "UETXTANS", JdeDataType.String, 200),
        new JdeField("UEEXVAR0", "UEEXVAR0", JdeDataType.String, 510),
        new JdeField("UEEXVAR1", "UEEXVAR1", JdeDataType.String, 510),
        new JdeField("UEEXVAR4", "UEEXVAR4", JdeDataType.String, 100),
        new JdeField("UEEXVAR5", "UEEXVAR5", JdeDataType.String, 100),
        new JdeField("UEEXVAR6", "UEEXVAR6", JdeDataType.String, 100),
        new JdeField("UEEXVAR7", "UEEXVAR7", JdeDataType.String, 100),
        new JdeField("UEEXVAR12", "UEEXVAR12", JdeDataType.String, 50),
        new JdeField("UEEXVAR13", "UEEXVAR13", JdeDataType.String, 50),
        new JdeField("UEEXNM0", "UEEXNM0", JdeDataType.Numeric),
        new JdeField("UEEXNM1", "UEEXNM1", JdeDataType.Numeric),
        new JdeField("UEEXNM2", "UEEXNM2", JdeDataType.Numeric),
        new JdeField("UEEXNMP0", "UEEXNMP0", JdeDataType.Numeric),
        new JdeField("UEEXNMP1", "UEEXNMP1", JdeDataType.Numeric),
        new JdeField("UEEXNMP2", "UEEXNMP2", JdeDataType.Numeric),
        new JdeField("UEEXDT0", "UEEXDT0", JdeDataType.Date),
        new JdeField("UEEXDT1", "UEEXDT1", JdeDataType.Date),
        new JdeField("UEEXDT2", "UEEXDT2", JdeDataType.Date),
        new JdeField("UESTSUDT", "UESTSUDT", JdeDataType.Date),
        new JdeField("UEACTIND", "UEACTIND", JdeDataType.String, 2),
        new JdeField("UEUSER", "UEUSER", JdeDataType.String, 20),
        new JdeField("UEPID", "UEPID", JdeDataType.String, 20),
        new JdeField("UEVID", "UEVID", JdeDataType.String, 20),
        new JdeField("UEMKEY", "UEMKEY", JdeDataType.String, 30),
        new JdeField("UEUDTTM", "UEUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA08E_0", "Primary Key on UECUPRID", new[] { "UECUPRID" }, isUnique: true, isPrimaryKey: true)
    };
}
