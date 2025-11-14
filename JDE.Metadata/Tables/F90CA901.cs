using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA901 - .
/// </summary>
public class F90CA901 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PECPAN8.
        /// </summary>
        public const string PECPAN8 = "PECPAN8";

        /// <summary>
        /// PECPLNID.
        /// </summary>
        public const string PECPLNID = "PECPLNID";

        /// <summary>
        /// PECPSEQ.
        /// </summary>
        public const string PECPSEQ = "PECPSEQ";

        /// <summary>
        /// PEEXVAR0.
        /// </summary>
        public const string PEEXVAR0 = "PEEXVAR0";

        /// <summary>
        /// PEEXVAR1.
        /// </summary>
        public const string PEEXVAR1 = "PEEXVAR1";

        /// <summary>
        /// PEEXVAR4.
        /// </summary>
        public const string PEEXVAR4 = "PEEXVAR4";

        /// <summary>
        /// PEEXVAR5.
        /// </summary>
        public const string PEEXVAR5 = "PEEXVAR5";

        /// <summary>
        /// PEEXVAR6.
        /// </summary>
        public const string PEEXVAR6 = "PEEXVAR6";

        /// <summary>
        /// PEEXVAR7.
        /// </summary>
        public const string PEEXVAR7 = "PEEXVAR7";

        /// <summary>
        /// PEEXVAR12.
        /// </summary>
        public const string PEEXVAR12 = "PEEXVAR12";

        /// <summary>
        /// PEEXVAR13.
        /// </summary>
        public const string PEEXVAR13 = "PEEXVAR13";

        /// <summary>
        /// PEEXNM0.
        /// </summary>
        public const string PEEXNM0 = "PEEXNM0";

        /// <summary>
        /// PEEXNM1.
        /// </summary>
        public const string PEEXNM1 = "PEEXNM1";

        /// <summary>
        /// PEEXNM2.
        /// </summary>
        public const string PEEXNM2 = "PEEXNM2";

        /// <summary>
        /// PEEXNMP0.
        /// </summary>
        public const string PEEXNMP0 = "PEEXNMP0";

        /// <summary>
        /// PEEXNMP1.
        /// </summary>
        public const string PEEXNMP1 = "PEEXNMP1";

        /// <summary>
        /// PEEXNMP2.
        /// </summary>
        public const string PEEXNMP2 = "PEEXNMP2";

        /// <summary>
        /// PEEXDT0.
        /// </summary>
        public const string PEEXDT0 = "PEEXDT0";

        /// <summary>
        /// PEEXDT1.
        /// </summary>
        public const string PEEXDT1 = "PEEXDT1";

        /// <summary>
        /// PEEXDT2.
        /// </summary>
        public const string PEEXDT2 = "PEEXDT2";

        /// <summary>
        /// PESTSUDT.
        /// </summary>
        public const string PESTSUDT = "PESTSUDT";

        /// <summary>
        /// PEACTIND.
        /// </summary>
        public const string PEACTIND = "PEACTIND";

        /// <summary>
        /// PEUSER.
        /// </summary>
        public const string PEUSER = "PEUSER";

        /// <summary>
        /// PEPID.
        /// </summary>
        public const string PEPID = "PEPID";

        /// <summary>
        /// PEVID.
        /// </summary>
        public const string PEVID = "PEVID";

        /// <summary>
        /// PEMKEY.
        /// </summary>
        public const string PEMKEY = "PEMKEY";

        /// <summary>
        /// PEUDTTM.
        /// </summary>
        public const string PEUDTTM = "PEUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA901";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PECPAN8", "PECPAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PECPLNID", "PECPLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PECPSEQ", "PECPSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("PEEXVAR0", "PEEXVAR0", JdeDataType.String, 510),
        new JdeField("PEEXVAR1", "PEEXVAR1", JdeDataType.String, 510),
        new JdeField("PEEXVAR4", "PEEXVAR4", JdeDataType.String, 100),
        new JdeField("PEEXVAR5", "PEEXVAR5", JdeDataType.String, 100),
        new JdeField("PEEXVAR6", "PEEXVAR6", JdeDataType.String, 100),
        new JdeField("PEEXVAR7", "PEEXVAR7", JdeDataType.String, 100),
        new JdeField("PEEXVAR12", "PEEXVAR12", JdeDataType.String, 50),
        new JdeField("PEEXVAR13", "PEEXVAR13", JdeDataType.String, 50),
        new JdeField("PEEXNM0", "PEEXNM0", JdeDataType.Numeric),
        new JdeField("PEEXNM1", "PEEXNM1", JdeDataType.Numeric),
        new JdeField("PEEXNM2", "PEEXNM2", JdeDataType.Numeric),
        new JdeField("PEEXNMP0", "PEEXNMP0", JdeDataType.Numeric),
        new JdeField("PEEXNMP1", "PEEXNMP1", JdeDataType.Numeric),
        new JdeField("PEEXNMP2", "PEEXNMP2", JdeDataType.Numeric),
        new JdeField("PEEXDT0", "PEEXDT0", JdeDataType.Date),
        new JdeField("PEEXDT1", "PEEXDT1", JdeDataType.Date),
        new JdeField("PEEXDT2", "PEEXDT2", JdeDataType.Date),
        new JdeField("PESTSUDT", "PESTSUDT", JdeDataType.Date),
        new JdeField("PEACTIND", "PEACTIND", JdeDataType.String, 2),
        new JdeField("PEUSER", "PEUSER", JdeDataType.String, 20),
        new JdeField("PEPID", "PEPID", JdeDataType.String, 20),
        new JdeField("PEVID", "PEVID", JdeDataType.String, 20),
        new JdeField("PEMKEY", "PEMKEY", JdeDataType.String, 30),
        new JdeField("PEUDTTM", "PEUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA901_0", "Primary Key on PECPAN8, PECPLNID, PECPSEQ", new[] { "PECPAN8", "PECPLNID", "PECPSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
