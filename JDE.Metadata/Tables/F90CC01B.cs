using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CC01B - .
/// </summary>
public class F90CC01B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCCCEVTID.
        /// </summary>
        public const string CCCCEVTID = "CCCCEVTID";

        /// <summary>
        /// CCCAMPEVTID.
        /// </summary>
        public const string CCCAMPEVTID = "CCCAMPEVTID";

        /// <summary>
        /// CCCCDTINCR.
        /// </summary>
        public const string CCCCDTINCR = "CCCCDTINCR";

        /// <summary>
        /// CCCCPAIDTO.
        /// </summary>
        public const string CCCCPAIDTO = "CCCCPAIDTO";

        /// <summary>
        /// CCCCMEMO.
        /// </summary>
        public const string CCCCMEMO = "CCCCMEMO";

        /// <summary>
        /// CCCCAMT.
        /// </summary>
        public const string CCCCAMT = "CCCCAMT";

        /// <summary>
        /// CCCCCVCRCD.
        /// </summary>
        public const string CCCCCVCRCD = "CCCCCVCRCD";

        /// <summary>
        /// CCCEENTBY.
        /// </summary>
        public const string CCCEENTBY = "CCCEENTBY";

        /// <summary>
        /// CCCEMODBY.
        /// </summary>
        public const string CCCEMODBY = "CCCEMODBY";

        /// <summary>
        /// CCCEMODDT.
        /// </summary>
        public const string CCCEMODDT = "CCCEMODDT";

        /// <summary>
        /// CCCEENTDT.
        /// </summary>
        public const string CCCEENTDT = "CCCEENTDT";

        /// <summary>
        /// CCACTIND.
        /// </summary>
        public const string CCACTIND = "CCACTIND";

        /// <summary>
        /// CCSTSUDT.
        /// </summary>
        public const string CCSTSUDT = "CCSTSUDT";

        /// <summary>
        /// CCEXVAR0.
        /// </summary>
        public const string CCEXVAR0 = "CCEXVAR0";

        /// <summary>
        /// CCEXVAR1.
        /// </summary>
        public const string CCEXVAR1 = "CCEXVAR1";

        /// <summary>
        /// CCEXVAR2.
        /// </summary>
        public const string CCEXVAR2 = "CCEXVAR2";

        /// <summary>
        /// CCEXVAR3.
        /// </summary>
        public const string CCEXVAR3 = "CCEXVAR3";

        /// <summary>
        /// CCEXVAR4.
        /// </summary>
        public const string CCEXVAR4 = "CCEXVAR4";

        /// <summary>
        /// CCEXVAR5.
        /// </summary>
        public const string CCEXVAR5 = "CCEXVAR5";

        /// <summary>
        /// CCEXVAR6.
        /// </summary>
        public const string CCEXVAR6 = "CCEXVAR6";

        /// <summary>
        /// CCEXVAR7.
        /// </summary>
        public const string CCEXVAR7 = "CCEXVAR7";

        /// <summary>
        /// CCEXNM0.
        /// </summary>
        public const string CCEXNM0 = "CCEXNM0";

        /// <summary>
        /// CCEXNM1.
        /// </summary>
        public const string CCEXNM1 = "CCEXNM1";

        /// <summary>
        /// CCEXNM2.
        /// </summary>
        public const string CCEXNM2 = "CCEXNM2";

        /// <summary>
        /// CCEXNMP0.
        /// </summary>
        public const string CCEXNMP0 = "CCEXNMP0";

        /// <summary>
        /// CCEXNMP1.
        /// </summary>
        public const string CCEXNMP1 = "CCEXNMP1";

        /// <summary>
        /// CCEXNMP2.
        /// </summary>
        public const string CCEXNMP2 = "CCEXNMP2";

        /// <summary>
        /// CCEXDT0.
        /// </summary>
        public const string CCEXDT0 = "CCEXDT0";

        /// <summary>
        /// CCEXDT1.
        /// </summary>
        public const string CCEXDT1 = "CCEXDT1";

        /// <summary>
        /// CCEXDT2.
        /// </summary>
        public const string CCEXDT2 = "CCEXDT2";
    }

    /// <inheritdoc />
    public override string TableName => "F90CC01B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCCCEVTID", "CCCCEVTID", JdeDataType.Numeric, null, true, true),
        new JdeField("CCCAMPEVTID", "CCCAMPEVTID", JdeDataType.Numeric),
        new JdeField("CCCCDTINCR", "CCCCDTINCR", JdeDataType.Date),
        new JdeField("CCCCPAIDTO", "CCCCPAIDTO", JdeDataType.String, 100),
        new JdeField("CCCCMEMO", "CCCCMEMO", JdeDataType.String, 100),
        new JdeField("CCCCAMT", "CCCCAMT", JdeDataType.Numeric),
        new JdeField("CCCCCVCRCD", "CCCCCVCRCD", JdeDataType.String, 6),
        new JdeField("CCCEENTBY", "CCCEENTBY", JdeDataType.Numeric),
        new JdeField("CCCEMODBY", "CCCEMODBY", JdeDataType.Numeric),
        new JdeField("CCCEMODDT", "CCCEMODDT", JdeDataType.Date),
        new JdeField("CCCEENTDT", "CCCEENTDT", JdeDataType.Date),
        new JdeField("CCACTIND", "CCACTIND", JdeDataType.String, 2),
        new JdeField("CCSTSUDT", "CCSTSUDT", JdeDataType.Date),
        new JdeField("CCEXVAR0", "CCEXVAR0", JdeDataType.String, 510),
        new JdeField("CCEXVAR1", "CCEXVAR1", JdeDataType.String, 510),
        new JdeField("CCEXVAR2", "CCEXVAR2", JdeDataType.String, 510),
        new JdeField("CCEXVAR3", "CCEXVAR3", JdeDataType.String, 510),
        new JdeField("CCEXVAR4", "CCEXVAR4", JdeDataType.String, 100),
        new JdeField("CCEXVAR5", "CCEXVAR5", JdeDataType.String, 100),
        new JdeField("CCEXVAR6", "CCEXVAR6", JdeDataType.String, 100),
        new JdeField("CCEXVAR7", "CCEXVAR7", JdeDataType.String, 100),
        new JdeField("CCEXNM0", "CCEXNM0", JdeDataType.Numeric),
        new JdeField("CCEXNM1", "CCEXNM1", JdeDataType.Numeric),
        new JdeField("CCEXNM2", "CCEXNM2", JdeDataType.Numeric),
        new JdeField("CCEXNMP0", "CCEXNMP0", JdeDataType.Numeric),
        new JdeField("CCEXNMP1", "CCEXNMP1", JdeDataType.Numeric),
        new JdeField("CCEXNMP2", "CCEXNMP2", JdeDataType.Numeric),
        new JdeField("CCEXDT0", "CCEXDT0", JdeDataType.Date),
        new JdeField("CCEXDT1", "CCEXDT1", JdeDataType.Date),
        new JdeField("CCEXDT2", "CCEXDT2", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CC01B_0", "Primary Key on CCCCEVTID", new[] { "CCCCEVTID" }, isUnique: true, isPrimaryKey: true)
    };
}
