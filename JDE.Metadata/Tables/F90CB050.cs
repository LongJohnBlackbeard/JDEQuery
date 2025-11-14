using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CB050 - .
/// </summary>
public class F90CB050 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SMSMEID.
        /// </summary>
        public const string SMSMEID = "SMSMEID";

        /// <summary>
        /// SMDSCRP.
        /// </summary>
        public const string SMDSCRP = "SMDSCRP";

        /// <summary>
        /// SMDFLTFG.
        /// </summary>
        public const string SMDFLTFG = "SMDFLTFG";

        /// <summary>
        /// SMENTDBY.
        /// </summary>
        public const string SMENTDBY = "SMENTDBY";

        /// <summary>
        /// SMEDATE.
        /// </summary>
        public const string SMEDATE = "SMEDATE";

        /// <summary>
        /// SMEXVAR0.
        /// </summary>
        public const string SMEXVAR0 = "SMEXVAR0";

        /// <summary>
        /// SMEXVAR2.
        /// </summary>
        public const string SMEXVAR2 = "SMEXVAR2";

        /// <summary>
        /// SMEXVAR1.
        /// </summary>
        public const string SMEXVAR1 = "SMEXVAR1";

        /// <summary>
        /// SMEXVAR3.
        /// </summary>
        public const string SMEXVAR3 = "SMEXVAR3";

        /// <summary>
        /// SMEXVAR4.
        /// </summary>
        public const string SMEXVAR4 = "SMEXVAR4";

        /// <summary>
        /// SMEXVAR5.
        /// </summary>
        public const string SMEXVAR5 = "SMEXVAR5";

        /// <summary>
        /// SMEXVAR6.
        /// </summary>
        public const string SMEXVAR6 = "SMEXVAR6";

        /// <summary>
        /// SMEXVAR7.
        /// </summary>
        public const string SMEXVAR7 = "SMEXVAR7";

        /// <summary>
        /// SMEXNM0.
        /// </summary>
        public const string SMEXNM0 = "SMEXNM0";

        /// <summary>
        /// SMEXNM1.
        /// </summary>
        public const string SMEXNM1 = "SMEXNM1";

        /// <summary>
        /// SMEXNM2.
        /// </summary>
        public const string SMEXNM2 = "SMEXNM2";

        /// <summary>
        /// SMEXNMP0.
        /// </summary>
        public const string SMEXNMP0 = "SMEXNMP0";

        /// <summary>
        /// SMEXNMP1.
        /// </summary>
        public const string SMEXNMP1 = "SMEXNMP1";

        /// <summary>
        /// SMEXNMP2.
        /// </summary>
        public const string SMEXNMP2 = "SMEXNMP2";

        /// <summary>
        /// SMEXDT0.
        /// </summary>
        public const string SMEXDT0 = "SMEXDT0";

        /// <summary>
        /// SMEXDT1.
        /// </summary>
        public const string SMEXDT1 = "SMEXDT1";

        /// <summary>
        /// SMEXDT2.
        /// </summary>
        public const string SMEXDT2 = "SMEXDT2";

        /// <summary>
        /// SMSTSUDT.
        /// </summary>
        public const string SMSTSUDT = "SMSTSUDT";

        /// <summary>
        /// SMACTIND.
        /// </summary>
        public const string SMACTIND = "SMACTIND";

        /// <summary>
        /// SMUSER.
        /// </summary>
        public const string SMUSER = "SMUSER";

        /// <summary>
        /// SMPID.
        /// </summary>
        public const string SMPID = "SMPID";

        /// <summary>
        /// SMVID.
        /// </summary>
        public const string SMVID = "SMVID";

        /// <summary>
        /// SMMKEY.
        /// </summary>
        public const string SMMKEY = "SMMKEY";

        /// <summary>
        /// SMUDTTM.
        /// </summary>
        public const string SMUDTTM = "SMUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CB050";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SMSMEID", "SMSMEID", JdeDataType.Numeric, null, true, true),
        new JdeField("SMDSCRP", "SMDSCRP", JdeDataType.String, 100),
        new JdeField("SMDFLTFG", "SMDFLTFG", JdeDataType.String, 2),
        new JdeField("SMENTDBY", "SMENTDBY", JdeDataType.Numeric),
        new JdeField("SMEDATE", "SMEDATE", JdeDataType.Date),
        new JdeField("SMEXVAR0", "SMEXVAR0", JdeDataType.String, 510),
        new JdeField("SMEXVAR2", "SMEXVAR2", JdeDataType.String, 510),
        new JdeField("SMEXVAR1", "SMEXVAR1", JdeDataType.String, 510),
        new JdeField("SMEXVAR3", "SMEXVAR3", JdeDataType.String, 510),
        new JdeField("SMEXVAR4", "SMEXVAR4", JdeDataType.String, 100),
        new JdeField("SMEXVAR5", "SMEXVAR5", JdeDataType.String, 100),
        new JdeField("SMEXVAR6", "SMEXVAR6", JdeDataType.String, 100),
        new JdeField("SMEXVAR7", "SMEXVAR7", JdeDataType.String, 100),
        new JdeField("SMEXNM0", "SMEXNM0", JdeDataType.Numeric),
        new JdeField("SMEXNM1", "SMEXNM1", JdeDataType.Numeric),
        new JdeField("SMEXNM2", "SMEXNM2", JdeDataType.Numeric),
        new JdeField("SMEXNMP0", "SMEXNMP0", JdeDataType.Numeric),
        new JdeField("SMEXNMP1", "SMEXNMP1", JdeDataType.Numeric),
        new JdeField("SMEXNMP2", "SMEXNMP2", JdeDataType.Numeric),
        new JdeField("SMEXDT0", "SMEXDT0", JdeDataType.Date),
        new JdeField("SMEXDT1", "SMEXDT1", JdeDataType.Date),
        new JdeField("SMEXDT2", "SMEXDT2", JdeDataType.Date),
        new JdeField("SMSTSUDT", "SMSTSUDT", JdeDataType.Date),
        new JdeField("SMACTIND", "SMACTIND", JdeDataType.String, 2),
        new JdeField("SMUSER", "SMUSER", JdeDataType.String, 20),
        new JdeField("SMPID", "SMPID", JdeDataType.String, 20),
        new JdeField("SMVID", "SMVID", JdeDataType.String, 20),
        new JdeField("SMMKEY", "SMMKEY", JdeDataType.String, 30),
        new JdeField("SMUDTTM", "SMUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CB050_0", "Primary Key on SMSMEID", new[] { "SMSMEID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CB050_3", "Index on SMDFLTFG", new[] { "SMDFLTFG" }),
        new JdeIndex("F90CB050_4", "Index on SMACTIND, SMDSCRP, SMSMEID", new[] { "SMACTIND", "SMDSCRP", "SMSMEID" })
    };
}
