using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CC01C - .
/// </summary>
public class F90CC01C : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CACEAID.
        /// </summary>
        public const string CACEAID = "CACEAID";

        /// <summary>
        /// CACEATYPE.
        /// </summary>
        public const string CACEATYPE = "CACEATYPE";

        /// <summary>
        /// CAADDR1.
        /// </summary>
        public const string CAADDR1 = "CAADDR1";

        /// <summary>
        /// CAADDR2.
        /// </summary>
        public const string CAADDR2 = "CAADDR2";

        /// <summary>
        /// CAADDR3.
        /// </summary>
        public const string CAADDR3 = "CAADDR3";

        /// <summary>
        /// CAADDR4.
        /// </summary>
        public const string CAADDR4 = "CAADDR4";

        /// <summary>
        /// CACIY.
        /// </summary>
        public const string CACIY = "CACIY";

        /// <summary>
        /// CACEASDRSY.
        /// </summary>
        public const string CACEASDRSY = "CACEASDRSY";

        /// <summary>
        /// CACEASDRRT.
        /// </summary>
        public const string CACEASDRRT = "CACEASDRRT";

        /// <summary>
        /// CASATE.
        /// </summary>
        public const string CASATE = "CASATE";

        /// <summary>
        /// CAZCODE.
        /// </summary>
        public const string CAZCODE = "CAZCODE";

        /// <summary>
        /// CACEACDRSY.
        /// </summary>
        public const string CACEACDRSY = "CACEACDRSY";

        /// <summary>
        /// CACEACDRRT.
        /// </summary>
        public const string CACEACDRRT = "CACEACDRRT";

        /// <summary>
        /// CACONTY.
        /// </summary>
        public const string CACONTY = "CACONTY";

        /// <summary>
        /// CAPMADF.
        /// </summary>
        public const string CAPMADF = "CAPMADF";

        /// <summary>
        /// CAENTDBY.
        /// </summary>
        public const string CAENTDBY = "CAENTDBY";

        /// <summary>
        /// CAMODB.
        /// </summary>
        public const string CAMODB = "CAMODB";

        /// <summary>
        /// CAEDATE.
        /// </summary>
        public const string CAEDATE = "CAEDATE";

        /// <summary>
        /// CAMDATE.
        /// </summary>
        public const string CAMDATE = "CAMDATE";

        /// <summary>
        /// CAEXVAR0.
        /// </summary>
        public const string CAEXVAR0 = "CAEXVAR0";

        /// <summary>
        /// CAEXVAR1.
        /// </summary>
        public const string CAEXVAR1 = "CAEXVAR1";

        /// <summary>
        /// CAEXVAR2.
        /// </summary>
        public const string CAEXVAR2 = "CAEXVAR2";

        /// <summary>
        /// CAEXVAR3.
        /// </summary>
        public const string CAEXVAR3 = "CAEXVAR3";

        /// <summary>
        /// CAEXVAR4.
        /// </summary>
        public const string CAEXVAR4 = "CAEXVAR4";

        /// <summary>
        /// CAEXVAR5.
        /// </summary>
        public const string CAEXVAR5 = "CAEXVAR5";

        /// <summary>
        /// CAEXVAR6.
        /// </summary>
        public const string CAEXVAR6 = "CAEXVAR6";

        /// <summary>
        /// CAEXVAR7.
        /// </summary>
        public const string CAEXVAR7 = "CAEXVAR7";

        /// <summary>
        /// CAEXNM0.
        /// </summary>
        public const string CAEXNM0 = "CAEXNM0";

        /// <summary>
        /// CAEXNM1.
        /// </summary>
        public const string CAEXNM1 = "CAEXNM1";

        /// <summary>
        /// CAEXNM2.
        /// </summary>
        public const string CAEXNM2 = "CAEXNM2";

        /// <summary>
        /// CAEXNMP0.
        /// </summary>
        public const string CAEXNMP0 = "CAEXNMP0";

        /// <summary>
        /// CAEXNMP1.
        /// </summary>
        public const string CAEXNMP1 = "CAEXNMP1";

        /// <summary>
        /// CAEXNMP2.
        /// </summary>
        public const string CAEXNMP2 = "CAEXNMP2";

        /// <summary>
        /// CAEXDT0.
        /// </summary>
        public const string CAEXDT0 = "CAEXDT0";

        /// <summary>
        /// CAEXDT1.
        /// </summary>
        public const string CAEXDT1 = "CAEXDT1";

        /// <summary>
        /// CAEXDT2.
        /// </summary>
        public const string CAEXDT2 = "CAEXDT2";

        /// <summary>
        /// CASTSUDT.
        /// </summary>
        public const string CASTSUDT = "CASTSUDT";

        /// <summary>
        /// CAACTIND.
        /// </summary>
        public const string CAACTIND = "CAACTIND";
    }

    /// <inheritdoc />
    public override string TableName => "F90CC01C";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CACEAID", "CACEAID", JdeDataType.Numeric, null, true, true),
        new JdeField("CACEATYPE", "CACEATYPE", JdeDataType.String, 10),
        new JdeField("CAADDR1", "CAADDR1", JdeDataType.String, 80),
        new JdeField("CAADDR2", "CAADDR2", JdeDataType.String, 80),
        new JdeField("CAADDR3", "CAADDR3", JdeDataType.String, 80),
        new JdeField("CAADDR4", "CAADDR4", JdeDataType.String, 80),
        new JdeField("CACIY", "CACIY", JdeDataType.String, 50),
        new JdeField("CACEASDRSY", "CACEASDRSY", JdeDataType.String, 8),
        new JdeField("CACEASDRRT", "CACEASDRRT", JdeDataType.String, 4),
        new JdeField("CASATE", "CASATE", JdeDataType.String, 6),
        new JdeField("CAZCODE", "CAZCODE", JdeDataType.String, 24),
        new JdeField("CACEACDRSY", "CACEACDRSY", JdeDataType.String, 8),
        new JdeField("CACEACDRRT", "CACEACDRRT", JdeDataType.String, 4),
        new JdeField("CACONTY", "CACONTY", JdeDataType.String, 6),
        new JdeField("CAPMADF", "CAPMADF", JdeDataType.String, 2),
        new JdeField("CAENTDBY", "CAENTDBY", JdeDataType.Numeric),
        new JdeField("CAMODB", "CAMODB", JdeDataType.Numeric),
        new JdeField("CAEDATE", "CAEDATE", JdeDataType.Date),
        new JdeField("CAMDATE", "CAMDATE", JdeDataType.Date),
        new JdeField("CAEXVAR0", "CAEXVAR0", JdeDataType.String, 510),
        new JdeField("CAEXVAR1", "CAEXVAR1", JdeDataType.String, 510),
        new JdeField("CAEXVAR2", "CAEXVAR2", JdeDataType.String, 510),
        new JdeField("CAEXVAR3", "CAEXVAR3", JdeDataType.String, 510),
        new JdeField("CAEXVAR4", "CAEXVAR4", JdeDataType.String, 100),
        new JdeField("CAEXVAR5", "CAEXVAR5", JdeDataType.String, 100),
        new JdeField("CAEXVAR6", "CAEXVAR6", JdeDataType.String, 100),
        new JdeField("CAEXVAR7", "CAEXVAR7", JdeDataType.String, 100),
        new JdeField("CAEXNM0", "CAEXNM0", JdeDataType.Numeric),
        new JdeField("CAEXNM1", "CAEXNM1", JdeDataType.Numeric),
        new JdeField("CAEXNM2", "CAEXNM2", JdeDataType.Numeric),
        new JdeField("CAEXNMP0", "CAEXNMP0", JdeDataType.Numeric),
        new JdeField("CAEXNMP1", "CAEXNMP1", JdeDataType.Numeric),
        new JdeField("CAEXNMP2", "CAEXNMP2", JdeDataType.Numeric),
        new JdeField("CAEXDT0", "CAEXDT0", JdeDataType.Date),
        new JdeField("CAEXDT1", "CAEXDT1", JdeDataType.Date),
        new JdeField("CAEXDT2", "CAEXDT2", JdeDataType.Date),
        new JdeField("CASTSUDT", "CASTSUDT", JdeDataType.Date),
        new JdeField("CAACTIND", "CAACTIND", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CC01C_0", "Primary Key on CACEAID", new[] { "CACEAID" }, isUnique: true, isPrimaryKey: true)
    };
}
