using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CB040 - .
/// </summary>
public class F90CB040 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QLQL8.
        /// </summary>
        public const string QLQL8 = "QLQL8";

        /// <summary>
        /// QLALPH.
        /// </summary>
        public const string QLALPH = "QLALPH";

        /// <summary>
        /// QLQLOT.
        /// </summary>
        public const string QLQLOT = "QLQLOT";

        /// <summary>
        /// QLQLHT.
        /// </summary>
        public const string QLQLHT = "QLQLHT";

        /// <summary>
        /// QLUSER.
        /// </summary>
        public const string QLUSER = "QLUSER";

        /// <summary>
        /// QLJOBN.
        /// </summary>
        public const string QLJOBN = "QLJOBN";

        /// <summary>
        /// QLMKEY.
        /// </summary>
        public const string QLMKEY = "QLMKEY";

        /// <summary>
        /// QLPID.
        /// </summary>
        public const string QLPID = "QLPID";

        /// <summary>
        /// QLVID.
        /// </summary>
        public const string QLVID = "QLVID";

        /// <summary>
        /// QLUPMT.
        /// </summary>
        public const string QLUPMT = "QLUPMT";

        /// <summary>
        /// QLUPMJ.
        /// </summary>
        public const string QLUPMJ = "QLUPMJ";

        /// <summary>
        /// QLUDTTM.
        /// </summary>
        public const string QLUDTTM = "QLUDTTM";

        /// <summary>
        /// QLEXVAR0.
        /// </summary>
        public const string QLEXVAR0 = "QLEXVAR0";

        /// <summary>
        /// QLEXVAR1.
        /// </summary>
        public const string QLEXVAR1 = "QLEXVAR1";

        /// <summary>
        /// QLEXVAR10.
        /// </summary>
        public const string QLEXVAR10 = "QLEXVAR10";

        /// <summary>
        /// QLEXVAR11.
        /// </summary>
        public const string QLEXVAR11 = "QLEXVAR11";

        /// <summary>
        /// QLEXVAR4.
        /// </summary>
        public const string QLEXVAR4 = "QLEXVAR4";

        /// <summary>
        /// QLEXVAR5.
        /// </summary>
        public const string QLEXVAR5 = "QLEXVAR5";

        /// <summary>
        /// QLEXVAR12.
        /// </summary>
        public const string QLEXVAR12 = "QLEXVAR12";

        /// <summary>
        /// QLEXVAR13.
        /// </summary>
        public const string QLEXVAR13 = "QLEXVAR13";

        /// <summary>
        /// QLEDATE.
        /// </summary>
        public const string QLEDATE = "QLEDATE";

        /// <summary>
        /// QLMDATE.
        /// </summary>
        public const string QLMDATE = "QLMDATE";

        /// <summary>
        /// QLEXDT0.
        /// </summary>
        public const string QLEXDT0 = "QLEXDT0";

        /// <summary>
        /// QLEXDT1.
        /// </summary>
        public const string QLEXDT1 = "QLEXDT1";

        /// <summary>
        /// QLEXDT2.
        /// </summary>
        public const string QLEXDT2 = "QLEXDT2";

        /// <summary>
        /// QLSTSUDT.
        /// </summary>
        public const string QLSTSUDT = "QLSTSUDT";

        /// <summary>
        /// QLENTDBY.
        /// </summary>
        public const string QLENTDBY = "QLENTDBY";

        /// <summary>
        /// QLMODB.
        /// </summary>
        public const string QLMODB = "QLMODB";

        /// <summary>
        /// QLACTIND.
        /// </summary>
        public const string QLACTIND = "QLACTIND";

        /// <summary>
        /// QLEXNM0.
        /// </summary>
        public const string QLEXNM0 = "QLEXNM0";

        /// <summary>
        /// QLEXNM1.
        /// </summary>
        public const string QLEXNM1 = "QLEXNM1";

        /// <summary>
        /// QLEXNM2.
        /// </summary>
        public const string QLEXNM2 = "QLEXNM2";

        /// <summary>
        /// QLEXNMP0.
        /// </summary>
        public const string QLEXNMP0 = "QLEXNMP0";

        /// <summary>
        /// QLEXNMP1.
        /// </summary>
        public const string QLEXNMP1 = "QLEXNMP1";

        /// <summary>
        /// QLEXNMP2.
        /// </summary>
        public const string QLEXNMP2 = "QLEXNMP2";
    }

    /// <inheritdoc />
    public override string TableName => "F90CB040";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QLQL8", "QLQL8", JdeDataType.Numeric, null, true, true),
        new JdeField("QLALPH", "QLALPH", JdeDataType.String, 80),
        new JdeField("QLQLOT", "QLQLOT", JdeDataType.Numeric),
        new JdeField("QLQLHT", "QLQLHT", JdeDataType.Numeric),
        new JdeField("QLUSER", "QLUSER", JdeDataType.String, 20),
        new JdeField("QLJOBN", "QLJOBN", JdeDataType.String, 20),
        new JdeField("QLMKEY", "QLMKEY", JdeDataType.String, 30),
        new JdeField("QLPID", "QLPID", JdeDataType.String, 20),
        new JdeField("QLVID", "QLVID", JdeDataType.String, 20),
        new JdeField("QLUPMT", "QLUPMT", JdeDataType.Numeric),
        new JdeField("QLUPMJ", "QLUPMJ", JdeDataType.Numeric),
        new JdeField("QLUDTTM", "QLUDTTM", JdeDataType.Date),
        new JdeField("QLEXVAR0", "QLEXVAR0", JdeDataType.String, 510),
        new JdeField("QLEXVAR1", "QLEXVAR1", JdeDataType.String, 510),
        new JdeField("QLEXVAR10", "QLEXVAR10", JdeDataType.String, 100),
        new JdeField("QLEXVAR11", "QLEXVAR11", JdeDataType.String, 100),
        new JdeField("QLEXVAR4", "QLEXVAR4", JdeDataType.String, 100),
        new JdeField("QLEXVAR5", "QLEXVAR5", JdeDataType.String, 100),
        new JdeField("QLEXVAR12", "QLEXVAR12", JdeDataType.String, 50),
        new JdeField("QLEXVAR13", "QLEXVAR13", JdeDataType.String, 50),
        new JdeField("QLEDATE", "QLEDATE", JdeDataType.Date),
        new JdeField("QLMDATE", "QLMDATE", JdeDataType.Date),
        new JdeField("QLEXDT0", "QLEXDT0", JdeDataType.Date),
        new JdeField("QLEXDT1", "QLEXDT1", JdeDataType.Date),
        new JdeField("QLEXDT2", "QLEXDT2", JdeDataType.Date),
        new JdeField("QLSTSUDT", "QLSTSUDT", JdeDataType.Date),
        new JdeField("QLENTDBY", "QLENTDBY", JdeDataType.Numeric),
        new JdeField("QLMODB", "QLMODB", JdeDataType.Numeric),
        new JdeField("QLACTIND", "QLACTIND", JdeDataType.String, 2),
        new JdeField("QLEXNM0", "QLEXNM0", JdeDataType.Numeric),
        new JdeField("QLEXNM1", "QLEXNM1", JdeDataType.Numeric),
        new JdeField("QLEXNM2", "QLEXNM2", JdeDataType.Numeric),
        new JdeField("QLEXNMP0", "QLEXNMP0", JdeDataType.Numeric),
        new JdeField("QLEXNMP1", "QLEXNMP1", JdeDataType.Numeric),
        new JdeField("QLEXNMP2", "QLEXNMP2", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CB040_0", "Primary Key on QLQL8", new[] { "QLQL8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CB040_2", "Index on QLACTIND, QLALPH, QLQL8", new[] { "QLACTIND", "QLALPH", "QLQL8" })
    };
}
