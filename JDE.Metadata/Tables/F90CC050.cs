using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CC050 - .
/// </summary>
public class F90CC050 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CPCALLPLID.
        /// </summary>
        public const string CPCALLPLID = "CPCALLPLID";

        /// <summary>
        /// CPCALLPLNM.
        /// </summary>
        public const string CPCALLPLNM = "CPCALLPLNM";

        /// <summary>
        /// CPCALLPURP.
        /// </summary>
        public const string CPCALLPURP = "CPCALLPURP";

        /// <summary>
        /// CPCALLPREM.
        /// </summary>
        public const string CPCALLPREM = "CPCALLPREM";

        /// <summary>
        /// CPCLLACTID.
        /// </summary>
        public const string CPCLLACTID = "CPCLLACTID";

        /// <summary>
        /// CPSTSUDT.
        /// </summary>
        public const string CPSTSUDT = "CPSTSUDT";

        /// <summary>
        /// CPACTIND.
        /// </summary>
        public const string CPACTIND = "CPACTIND";

        /// <summary>
        /// CPEXVAR0.
        /// </summary>
        public const string CPEXVAR0 = "CPEXVAR0";

        /// <summary>
        /// CPEXVAR1.
        /// </summary>
        public const string CPEXVAR1 = "CPEXVAR1";

        /// <summary>
        /// CPEXVAR2.
        /// </summary>
        public const string CPEXVAR2 = "CPEXVAR2";

        /// <summary>
        /// CPEXVAR3.
        /// </summary>
        public const string CPEXVAR3 = "CPEXVAR3";

        /// <summary>
        /// CPEXVAR4.
        /// </summary>
        public const string CPEXVAR4 = "CPEXVAR4";

        /// <summary>
        /// CPEXVAR5.
        /// </summary>
        public const string CPEXVAR5 = "CPEXVAR5";

        /// <summary>
        /// CPEXVAR6.
        /// </summary>
        public const string CPEXVAR6 = "CPEXVAR6";

        /// <summary>
        /// CPEXVAR7.
        /// </summary>
        public const string CPEXVAR7 = "CPEXVAR7";

        /// <summary>
        /// CPEXDT0.
        /// </summary>
        public const string CPEXDT0 = "CPEXDT0";

        /// <summary>
        /// CPEXDT1.
        /// </summary>
        public const string CPEXDT1 = "CPEXDT1";

        /// <summary>
        /// CPEXDT2.
        /// </summary>
        public const string CPEXDT2 = "CPEXDT2";

        /// <summary>
        /// CPEXNM0.
        /// </summary>
        public const string CPEXNM0 = "CPEXNM0";

        /// <summary>
        /// CPEXNM1.
        /// </summary>
        public const string CPEXNM1 = "CPEXNM1";

        /// <summary>
        /// CPEXNM2.
        /// </summary>
        public const string CPEXNM2 = "CPEXNM2";

        /// <summary>
        /// CPEXNMP0.
        /// </summary>
        public const string CPEXNMP0 = "CPEXNMP0";

        /// <summary>
        /// CPEXNMP1.
        /// </summary>
        public const string CPEXNMP1 = "CPEXNMP1";

        /// <summary>
        /// CPEXNMP2.
        /// </summary>
        public const string CPEXNMP2 = "CPEXNMP2";
    }

    /// <inheritdoc />
    public override string TableName => "F90CC050";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CPCALLPLID", "CPCALLPLID", JdeDataType.Numeric, null, true, true),
        new JdeField("CPCALLPLNM", "CPCALLPLNM", JdeDataType.String, 100),
        new JdeField("CPCALLPURP", "CPCALLPURP", JdeDataType.String, 510),
        new JdeField("CPCALLPREM", "CPCALLPREM", JdeDataType.String, 510),
        new JdeField("CPCLLACTID", "CPCLLACTID", JdeDataType.Numeric),
        new JdeField("CPSTSUDT", "CPSTSUDT", JdeDataType.Date),
        new JdeField("CPACTIND", "CPACTIND", JdeDataType.String, 2),
        new JdeField("CPEXVAR0", "CPEXVAR0", JdeDataType.String, 510),
        new JdeField("CPEXVAR1", "CPEXVAR1", JdeDataType.String, 510),
        new JdeField("CPEXVAR2", "CPEXVAR2", JdeDataType.String, 510),
        new JdeField("CPEXVAR3", "CPEXVAR3", JdeDataType.String, 510),
        new JdeField("CPEXVAR4", "CPEXVAR4", JdeDataType.String, 100),
        new JdeField("CPEXVAR5", "CPEXVAR5", JdeDataType.String, 100),
        new JdeField("CPEXVAR6", "CPEXVAR6", JdeDataType.String, 100),
        new JdeField("CPEXVAR7", "CPEXVAR7", JdeDataType.String, 100),
        new JdeField("CPEXDT0", "CPEXDT0", JdeDataType.Date),
        new JdeField("CPEXDT1", "CPEXDT1", JdeDataType.Date),
        new JdeField("CPEXDT2", "CPEXDT2", JdeDataType.Date),
        new JdeField("CPEXNM0", "CPEXNM0", JdeDataType.Numeric),
        new JdeField("CPEXNM1", "CPEXNM1", JdeDataType.Numeric),
        new JdeField("CPEXNM2", "CPEXNM2", JdeDataType.Numeric),
        new JdeField("CPEXNMP0", "CPEXNMP0", JdeDataType.Numeric),
        new JdeField("CPEXNMP1", "CPEXNMP1", JdeDataType.Numeric),
        new JdeField("CPEXNMP2", "CPEXNMP2", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CC050_0", "Primary Key on CPCALLPLID", new[] { "CPCALLPLID" }, isUnique: true, isPrimaryKey: true)
    };
}
