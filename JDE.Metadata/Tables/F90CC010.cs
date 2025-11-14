using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CC010 - .
/// </summary>
public class F90CC010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CECAMPEVTID.
        /// </summary>
        public const string CECAMPEVTID = "CECAMPEVTID";

        /// <summary>
        /// CECAMPEVCMID.
        /// </summary>
        public const string CECAMPEVCMID = "CECAMPEVCMID";

        /// <summary>
        /// CECEACTCST.
        /// </summary>
        public const string CECEACTCST = "CECEACTCST";

        /// <summary>
        /// CECECVCRCD1.
        /// </summary>
        public const string CECECVCRCD1 = "CECECVCRCD1";

        /// <summary>
        /// CECEBEGDT.
        /// </summary>
        public const string CECEBEGDT = "CECEBEGDT";

        /// <summary>
        /// CECEENDDT.
        /// </summary>
        public const string CECEENDDT = "CECEENDDT";

        /// <summary>
        /// CECEBUDAMT.
        /// </summary>
        public const string CECEBUDAMT = "CECEBUDAMT";

        /// <summary>
        /// CECECVCRCD.
        /// </summary>
        public const string CECECVCRCD = "CECECVCRCD";

        /// <summary>
        /// CECEEMPAN8.
        /// </summary>
        public const string CECEEMPAN8 = "CECEEMPAN8";

        /// <summary>
        /// CECEENTBY.
        /// </summary>
        public const string CECEENTBY = "CECEENTBY";

        /// <summary>
        /// CECEMODBY.
        /// </summary>
        public const string CECEMODBY = "CECEMODBY";

        /// <summary>
        /// CECEENTDT.
        /// </summary>
        public const string CECEENTDT = "CECEENTDT";

        /// <summary>
        /// CECEMODDT.
        /// </summary>
        public const string CECEMODDT = "CECEMODDT";

        /// <summary>
        /// CECEIMGURL.
        /// </summary>
        public const string CECEIMGURL = "CECEIMGURL";

        /// <summary>
        /// CECENAME.
        /// </summary>
        public const string CECENAME = "CECENAME";

        /// <summary>
        /// CECEPRADDID.
        /// </summary>
        public const string CECEPRADDID = "CECEPRADDID";

        /// <summary>
        /// CECEPUBFLG.
        /// </summary>
        public const string CECEPUBFLG = "CECEPUBFLG";

        /// <summary>
        /// CECETRGNUM.
        /// </summary>
        public const string CECETRGNUM = "CECETRGNUM";

        /// <summary>
        /// CECETYPE.
        /// </summary>
        public const string CECETYPE = "CECETYPE";

        /// <summary>
        /// CECEURL.
        /// </summary>
        public const string CECEURL = "CECEURL";

        /// <summary>
        /// CECEURLSTR.
        /// </summary>
        public const string CECEURLSTR = "CECEURLSTR";

        /// <summary>
        /// CESTSUDT.
        /// </summary>
        public const string CESTSUDT = "CESTSUDT";

        /// <summary>
        /// CEACTIND.
        /// </summary>
        public const string CEACTIND = "CEACTIND";

        /// <summary>
        /// CEEXVAR0.
        /// </summary>
        public const string CEEXVAR0 = "CEEXVAR0";

        /// <summary>
        /// CEEXVAR1.
        /// </summary>
        public const string CEEXVAR1 = "CEEXVAR1";

        /// <summary>
        /// CEEXVAR2.
        /// </summary>
        public const string CEEXVAR2 = "CEEXVAR2";

        /// <summary>
        /// CEEXVAR3.
        /// </summary>
        public const string CEEXVAR3 = "CEEXVAR3";

        /// <summary>
        /// CEEXVAR4.
        /// </summary>
        public const string CEEXVAR4 = "CEEXVAR4";

        /// <summary>
        /// CEEXVAR5.
        /// </summary>
        public const string CEEXVAR5 = "CEEXVAR5";

        /// <summary>
        /// CEEXVAR6.
        /// </summary>
        public const string CEEXVAR6 = "CEEXVAR6";

        /// <summary>
        /// CEEXVAR7.
        /// </summary>
        public const string CEEXVAR7 = "CEEXVAR7";

        /// <summary>
        /// CEEXNM0.
        /// </summary>
        public const string CEEXNM0 = "CEEXNM0";

        /// <summary>
        /// CEEXNM1.
        /// </summary>
        public const string CEEXNM1 = "CEEXNM1";

        /// <summary>
        /// CEEXNM2.
        /// </summary>
        public const string CEEXNM2 = "CEEXNM2";

        /// <summary>
        /// CEEXNMP0.
        /// </summary>
        public const string CEEXNMP0 = "CEEXNMP0";

        /// <summary>
        /// CEEXNMP1.
        /// </summary>
        public const string CEEXNMP1 = "CEEXNMP1";

        /// <summary>
        /// CEEXNMP2.
        /// </summary>
        public const string CEEXNMP2 = "CEEXNMP2";

        /// <summary>
        /// CEEXDT0.
        /// </summary>
        public const string CEEXDT0 = "CEEXDT0";

        /// <summary>
        /// CEEXDT1.
        /// </summary>
        public const string CEEXDT1 = "CEEXDT1";

        /// <summary>
        /// CEEXDT2.
        /// </summary>
        public const string CEEXDT2 = "CEEXDT2";
    }

    /// <inheritdoc />
    public override string TableName => "F90CC010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CECAMPEVTID", "CECAMPEVTID", JdeDataType.Numeric, null, true, true),
        new JdeField("CECAMPEVCMID", "CECAMPEVCMID", JdeDataType.Numeric),
        new JdeField("CECEACTCST", "CECEACTCST", JdeDataType.Numeric),
        new JdeField("CECECVCRCD1", "CECECVCRCD1", JdeDataType.String, 6),
        new JdeField("CECEBEGDT", "CECEBEGDT", JdeDataType.Date),
        new JdeField("CECEENDDT", "CECEENDDT", JdeDataType.Date),
        new JdeField("CECEBUDAMT", "CECEBUDAMT", JdeDataType.Numeric),
        new JdeField("CECECVCRCD", "CECECVCRCD", JdeDataType.String, 6),
        new JdeField("CECEEMPAN8", "CECEEMPAN8", JdeDataType.Numeric),
        new JdeField("CECEENTBY", "CECEENTBY", JdeDataType.Numeric),
        new JdeField("CECEMODBY", "CECEMODBY", JdeDataType.Numeric),
        new JdeField("CECEENTDT", "CECEENTDT", JdeDataType.Date),
        new JdeField("CECEMODDT", "CECEMODDT", JdeDataType.Date),
        new JdeField("CECEIMGURL", "CECEIMGURL", JdeDataType.String, 510),
        new JdeField("CECENAME", "CECENAME", JdeDataType.String, 100),
        new JdeField("CECEPRADDID", "CECEPRADDID", JdeDataType.Numeric),
        new JdeField("CECEPUBFLG", "CECEPUBFLG", JdeDataType.String, 2),
        new JdeField("CECETRGNUM", "CECETRGNUM", JdeDataType.Numeric),
        new JdeField("CECETYPE", "CECETYPE", JdeDataType.String, 10),
        new JdeField("CECEURL", "CECEURL", JdeDataType.String, 510),
        new JdeField("CECEURLSTR", "CECEURLSTR", JdeDataType.String, 510),
        new JdeField("CESTSUDT", "CESTSUDT", JdeDataType.Date),
        new JdeField("CEACTIND", "CEACTIND", JdeDataType.String, 2),
        new JdeField("CEEXVAR0", "CEEXVAR0", JdeDataType.String, 510),
        new JdeField("CEEXVAR1", "CEEXVAR1", JdeDataType.String, 510),
        new JdeField("CEEXVAR2", "CEEXVAR2", JdeDataType.String, 510),
        new JdeField("CEEXVAR3", "CEEXVAR3", JdeDataType.String, 510),
        new JdeField("CEEXVAR4", "CEEXVAR4", JdeDataType.String, 100),
        new JdeField("CEEXVAR5", "CEEXVAR5", JdeDataType.String, 100),
        new JdeField("CEEXVAR6", "CEEXVAR6", JdeDataType.String, 100),
        new JdeField("CEEXVAR7", "CEEXVAR7", JdeDataType.String, 100),
        new JdeField("CEEXNM0", "CEEXNM0", JdeDataType.Numeric),
        new JdeField("CEEXNM1", "CEEXNM1", JdeDataType.Numeric),
        new JdeField("CEEXNM2", "CEEXNM2", JdeDataType.Numeric),
        new JdeField("CEEXNMP0", "CEEXNMP0", JdeDataType.Numeric),
        new JdeField("CEEXNMP1", "CEEXNMP1", JdeDataType.Numeric),
        new JdeField("CEEXNMP2", "CEEXNMP2", JdeDataType.Numeric),
        new JdeField("CEEXDT0", "CEEXDT0", JdeDataType.Date),
        new JdeField("CEEXDT1", "CEEXDT1", JdeDataType.Date),
        new JdeField("CEEXDT2", "CEEXDT2", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CC010_0", "Primary Key on CECAMPEVTID", new[] { "CECAMPEVTID" }, isUnique: true, isPrimaryKey: true)
    };
}
