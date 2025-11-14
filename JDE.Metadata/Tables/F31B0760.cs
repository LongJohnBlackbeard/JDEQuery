using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B0760 - .
/// </summary>
public class F31B0760 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CAEURID.
        /// </summary>
        public const string CAEURID = "CAEURID";

        /// <summary>
        /// CASEQNUMB.
        /// </summary>
        public const string CASEQNUMB = "CASEQNUMB";

        /// <summary>
        /// CAVARID.
        /// </summary>
        public const string CAVARID = "CAVARID";

        /// <summary>
        /// CACAFUM.
        /// </summary>
        public const string CACAFUM = "CACAFUM";

        /// <summary>
        /// CACATUM.
        /// </summary>
        public const string CACATUM = "CACATUM";

        /// <summary>
        /// CACACR.
        /// </summary>
        public const string CACACR = "CACACR";

        /// <summary>
        /// CAURAB.
        /// </summary>
        public const string CAURAB = "CAURAB";

        /// <summary>
        /// CAURAT.
        /// </summary>
        public const string CAURAT = "CAURAT";

        /// <summary>
        /// CAURCD.
        /// </summary>
        public const string CAURCD = "CAURCD";

        /// <summary>
        /// CAURDT.
        /// </summary>
        public const string CAURDT = "CAURDT";

        /// <summary>
        /// CAURRF.
        /// </summary>
        public const string CAURRF = "CAURRF";

        /// <summary>
        /// CAJOBN.
        /// </summary>
        public const string CAJOBN = "CAJOBN";

        /// <summary>
        /// CAPID.
        /// </summary>
        public const string CAPID = "CAPID";

        /// <summary>
        /// CATDAY.
        /// </summary>
        public const string CATDAY = "CATDAY";

        /// <summary>
        /// CAUPMJ.
        /// </summary>
        public const string CAUPMJ = "CAUPMJ";

        /// <summary>
        /// CAUSER.
        /// </summary>
        public const string CAUSER = "CAUSER";

        /// <summary>
        /// CAWAB.
        /// </summary>
        public const string CAWAB = "CAWAB";

        /// <summary>
        /// CAWCD.
        /// </summary>
        public const string CAWCD = "CAWCD";

        /// <summary>
        /// CAWMDT.
        /// </summary>
        public const string CAWMDT = "CAWMDT";

        /// <summary>
        /// CAWNUM.
        /// </summary>
        public const string CAWNUM = "CAWNUM";

        /// <summary>
        /// CAWRF.
        /// </summary>
        public const string CAWRF = "CAWRF";
    }

    /// <inheritdoc />
    public override string TableName => "F31B0760";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CAEURID", "CAEURID", JdeDataType.Numeric, null, true, true),
        new JdeField("CASEQNUMB", "CASEQNUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("CAVARID", "CAVARID", JdeDataType.Numeric),
        new JdeField("CACAFUM", "CACAFUM", JdeDataType.String, 4),
        new JdeField("CACATUM", "CACATUM", JdeDataType.String, 4),
        new JdeField("CACACR", "CACACR", JdeDataType.Numeric),
        new JdeField("CAURAB", "CAURAB", JdeDataType.Numeric),
        new JdeField("CAURAT", "CAURAT", JdeDataType.Numeric),
        new JdeField("CAURCD", "CAURCD", JdeDataType.String, 4),
        new JdeField("CAURDT", "CAURDT", JdeDataType.Numeric),
        new JdeField("CAURRF", "CAURRF", JdeDataType.String, 30),
        new JdeField("CAJOBN", "CAJOBN", JdeDataType.String, 20),
        new JdeField("CAPID", "CAPID", JdeDataType.String, 20),
        new JdeField("CATDAY", "CATDAY", JdeDataType.Numeric),
        new JdeField("CAUPMJ", "CAUPMJ", JdeDataType.Numeric),
        new JdeField("CAUSER", "CAUSER", JdeDataType.String, 20),
        new JdeField("CAWAB", "CAWAB", JdeDataType.Numeric),
        new JdeField("CAWCD", "CAWCD", JdeDataType.String, 6),
        new JdeField("CAWMDT", "CAWMDT", JdeDataType.Numeric),
        new JdeField("CAWNUM", "CAWNUM", JdeDataType.Numeric),
        new JdeField("CAWRF", "CAWRF", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B0760_0", "Primary Key on CAEURID, CASEQNUMB", new[] { "CAEURID", "CASEQNUMB" }, isUnique: true, isPrimaryKey: true)
    };
}
