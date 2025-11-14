using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4201UR - .
/// </summary>
public class F4201UR : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SHKCOO.
        /// </summary>
        public const string SHKCOO = "SHKCOO";

        /// <summary>
        /// SHDOCO.
        /// </summary>
        public const string SHDOCO = "SHDOCO";

        /// <summary>
        /// SHDCTO.
        /// </summary>
        public const string SHDCTO = "SHDCTO";

        /// <summary>
        /// SHEXVAR0.
        /// </summary>
        public const string SHEXVAR0 = "SHEXVAR0";

        /// <summary>
        /// SHEXVAR1.
        /// </summary>
        public const string SHEXVAR1 = "SHEXVAR1";

        /// <summary>
        /// SHEXVAR4.
        /// </summary>
        public const string SHEXVAR4 = "SHEXVAR4";

        /// <summary>
        /// SHEXVAR5.
        /// </summary>
        public const string SHEXVAR5 = "SHEXVAR5";

        /// <summary>
        /// SHEXVAR6.
        /// </summary>
        public const string SHEXVAR6 = "SHEXVAR6";

        /// <summary>
        /// SHEXVAR7.
        /// </summary>
        public const string SHEXVAR7 = "SHEXVAR7";

        /// <summary>
        /// SHEXVAR12.
        /// </summary>
        public const string SHEXVAR12 = "SHEXVAR12";

        /// <summary>
        /// SHEXVAR13.
        /// </summary>
        public const string SHEXVAR13 = "SHEXVAR13";

        /// <summary>
        /// SHEXNM0.
        /// </summary>
        public const string SHEXNM0 = "SHEXNM0";

        /// <summary>
        /// SHEXNM1.
        /// </summary>
        public const string SHEXNM1 = "SHEXNM1";

        /// <summary>
        /// SHEXNM2.
        /// </summary>
        public const string SHEXNM2 = "SHEXNM2";

        /// <summary>
        /// SHEXNMP0.
        /// </summary>
        public const string SHEXNMP0 = "SHEXNMP0";

        /// <summary>
        /// SHEXNMP1.
        /// </summary>
        public const string SHEXNMP1 = "SHEXNMP1";

        /// <summary>
        /// SHEXNMP2.
        /// </summary>
        public const string SHEXNMP2 = "SHEXNMP2";

        /// <summary>
        /// SHEXDT0.
        /// </summary>
        public const string SHEXDT0 = "SHEXDT0";

        /// <summary>
        /// SHEXDT1.
        /// </summary>
        public const string SHEXDT1 = "SHEXDT1";

        /// <summary>
        /// SHEXDT2.
        /// </summary>
        public const string SHEXDT2 = "SHEXDT2";

        /// <summary>
        /// SHSTSUDT.
        /// </summary>
        public const string SHSTSUDT = "SHSTSUDT";

        /// <summary>
        /// SHACTIND.
        /// </summary>
        public const string SHACTIND = "SHACTIND";

        /// <summary>
        /// SHUSER.
        /// </summary>
        public const string SHUSER = "SHUSER";

        /// <summary>
        /// SHPID.
        /// </summary>
        public const string SHPID = "SHPID";

        /// <summary>
        /// SHVID.
        /// </summary>
        public const string SHVID = "SHVID";

        /// <summary>
        /// SHMKEY.
        /// </summary>
        public const string SHMKEY = "SHMKEY";

        /// <summary>
        /// SHUDTTM.
        /// </summary>
        public const string SHUDTTM = "SHUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F4201UR";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SHKCOO", "SHKCOO", JdeDataType.String, 10, true, true),
        new JdeField("SHDOCO", "SHDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SHDCTO", "SHDCTO", JdeDataType.String, 4, true, true),
        new JdeField("SHEXVAR0", "SHEXVAR0", JdeDataType.String, 510),
        new JdeField("SHEXVAR1", "SHEXVAR1", JdeDataType.String, 510),
        new JdeField("SHEXVAR4", "SHEXVAR4", JdeDataType.String, 100),
        new JdeField("SHEXVAR5", "SHEXVAR5", JdeDataType.String, 100),
        new JdeField("SHEXVAR6", "SHEXVAR6", JdeDataType.String, 100),
        new JdeField("SHEXVAR7", "SHEXVAR7", JdeDataType.String, 100),
        new JdeField("SHEXVAR12", "SHEXVAR12", JdeDataType.String, 50),
        new JdeField("SHEXVAR13", "SHEXVAR13", JdeDataType.String, 50),
        new JdeField("SHEXNM0", "SHEXNM0", JdeDataType.Numeric),
        new JdeField("SHEXNM1", "SHEXNM1", JdeDataType.Numeric),
        new JdeField("SHEXNM2", "SHEXNM2", JdeDataType.Numeric),
        new JdeField("SHEXNMP0", "SHEXNMP0", JdeDataType.Numeric),
        new JdeField("SHEXNMP1", "SHEXNMP1", JdeDataType.Numeric),
        new JdeField("SHEXNMP2", "SHEXNMP2", JdeDataType.Numeric),
        new JdeField("SHEXDT0", "SHEXDT0", JdeDataType.Date),
        new JdeField("SHEXDT1", "SHEXDT1", JdeDataType.Date),
        new JdeField("SHEXDT2", "SHEXDT2", JdeDataType.Date),
        new JdeField("SHSTSUDT", "SHSTSUDT", JdeDataType.Date),
        new JdeField("SHACTIND", "SHACTIND", JdeDataType.String, 2),
        new JdeField("SHUSER", "SHUSER", JdeDataType.String, 20),
        new JdeField("SHPID", "SHPID", JdeDataType.String, 20),
        new JdeField("SHVID", "SHVID", JdeDataType.String, 20),
        new JdeField("SHMKEY", "SHMKEY", JdeDataType.String, 30),
        new JdeField("SHUDTTM", "SHUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4201UR_0", "Primary Key on SHKCOO, SHDOCO, SHDCTO", new[] { "SHKCOO", "SHDOCO", "SHDCTO" }, isUnique: true, isPrimaryKey: true)
    };
}
