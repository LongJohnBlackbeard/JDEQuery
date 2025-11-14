using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40333 - .
/// </summary>
public class F40333 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CAAN8.
        /// </summary>
        public const string CAAN8 = "CAAN8";

        /// <summary>
        /// CACS33.
        /// </summary>
        public const string CACS33 = "CACS33";

        /// <summary>
        /// CAITM.
        /// </summary>
        public const string CAITM = "CAITM";

        /// <summary>
        /// CAIT83.
        /// </summary>
        public const string CAIT83 = "CAIT83";

        /// <summary>
        /// CAEFTJ.
        /// </summary>
        public const string CAEFTJ = "CAEFTJ";

        /// <summary>
        /// CAEXDJ.
        /// </summary>
        public const string CAEXDJ = "CAEXDJ";

        /// <summary>
        /// CAMNQ.
        /// </summary>
        public const string CAMNQ = "CAMNQ";

        /// <summary>
        /// CAMXQ.
        /// </summary>
        public const string CAMXQ = "CAMXQ";

        /// <summary>
        /// CAUOM.
        /// </summary>
        public const string CAUOM = "CAUOM";

        /// <summary>
        /// CATXID.
        /// </summary>
        public const string CATXID = "CATXID";

        /// <summary>
        /// CASTPR.
        /// </summary>
        public const string CASTPR = "CASTPR";

        /// <summary>
        /// CAOSEQ.
        /// </summary>
        public const string CAOSEQ = "CAOSEQ";

        /// <summary>
        /// CAMCU.
        /// </summary>
        public const string CAMCU = "CAMCU";

        /// <summary>
        /// CAORGN.
        /// </summary>
        public const string CAORGN = "CAORGN";

        /// <summary>
        /// CAMOT.
        /// </summary>
        public const string CAMOT = "CAMOT";

        /// <summary>
        /// CACTY1.
        /// </summary>
        public const string CACTY1 = "CACTY1";

        /// <summary>
        /// CAADDS.
        /// </summary>
        public const string CAADDS = "CAADDS";

        /// <summary>
        /// CAZON.
        /// </summary>
        public const string CAZON = "CAZON";

        /// <summary>
        /// CAZTO.
        /// </summary>
        public const string CAZTO = "CAZTO";

        /// <summary>
        /// CAZTH.
        /// </summary>
        public const string CAZTH = "CAZTH";

        /// <summary>
        /// CAFRTH.
        /// </summary>
        public const string CAFRTH = "CAFRTH";

        /// <summary>
        /// CACTR.
        /// </summary>
        public const string CACTR = "CACTR";

        /// <summary>
        /// CAILEL.
        /// </summary>
        public const string CAILEL = "CAILEL";

        /// <summary>
        /// CACAR1.
        /// </summary>
        public const string CACAR1 = "CACAR1";

        /// <summary>
        /// CACAR2.
        /// </summary>
        public const string CACAR2 = "CACAR2";

        /// <summary>
        /// CACAR3.
        /// </summary>
        public const string CACAR3 = "CACAR3";

        /// <summary>
        /// CAURCD.
        /// </summary>
        public const string CAURCD = "CAURCD";

        /// <summary>
        /// CAURDT.
        /// </summary>
        public const string CAURDT = "CAURDT";

        /// <summary>
        /// CAURAT.
        /// </summary>
        public const string CAURAT = "CAURAT";

        /// <summary>
        /// CAURAB.
        /// </summary>
        public const string CAURAB = "CAURAB";

        /// <summary>
        /// CAURRF.
        /// </summary>
        public const string CAURRF = "CAURRF";

        /// <summary>
        /// CAUSER.
        /// </summary>
        public const string CAUSER = "CAUSER";

        /// <summary>
        /// CAPID.
        /// </summary>
        public const string CAPID = "CAPID";

        /// <summary>
        /// CAJOBN.
        /// </summary>
        public const string CAJOBN = "CAJOBN";

        /// <summary>
        /// CAUPMJ.
        /// </summary>
        public const string CAUPMJ = "CAUPMJ";

        /// <summary>
        /// CATDAY.
        /// </summary>
        public const string CATDAY = "CATDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40333";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CAAN8", "CAAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CACS33", "CACS33", JdeDataType.String, 16, true, true),
        new JdeField("CAITM", "CAITM", JdeDataType.Numeric, null, true, true),
        new JdeField("CAIT83", "CAIT83", JdeDataType.String, 16, true, true),
        new JdeField("CAEFTJ", "CAEFTJ", JdeDataType.Numeric),
        new JdeField("CAEXDJ", "CAEXDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("CAMNQ", "CAMNQ", JdeDataType.Numeric),
        new JdeField("CAMXQ", "CAMXQ", JdeDataType.Numeric, null, true, true),
        new JdeField("CAUOM", "CAUOM", JdeDataType.String, 4, true, true),
        new JdeField("CATXID", "CATXID", JdeDataType.Numeric),
        new JdeField("CASTPR", "CASTPR", JdeDataType.String, 2),
        new JdeField("CAOSEQ", "CAOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("CAMCU", "CAMCU", JdeDataType.String, 24),
        new JdeField("CAORGN", "CAORGN", JdeDataType.Numeric),
        new JdeField("CAMOT", "CAMOT", JdeDataType.String, 6),
        new JdeField("CACTY1", "CACTY1", JdeDataType.String, 50),
        new JdeField("CAADDS", "CAADDS", JdeDataType.String, 6),
        new JdeField("CAZON", "CAZON", JdeDataType.String, 6),
        new JdeField("CAZTO", "CAZTO", JdeDataType.String, 24),
        new JdeField("CAZTH", "CAZTH", JdeDataType.String, 24),
        new JdeField("CAFRTH", "CAFRTH", JdeDataType.String, 6),
        new JdeField("CACTR", "CACTR", JdeDataType.String, 6),
        new JdeField("CAILEL", "CAILEL", JdeDataType.String, 2),
        new JdeField("CACAR1", "CACAR1", JdeDataType.Numeric),
        new JdeField("CACAR2", "CACAR2", JdeDataType.Numeric),
        new JdeField("CACAR3", "CACAR3", JdeDataType.Numeric),
        new JdeField("CAURCD", "CAURCD", JdeDataType.String, 4),
        new JdeField("CAURDT", "CAURDT", JdeDataType.Numeric),
        new JdeField("CAURAT", "CAURAT", JdeDataType.Numeric),
        new JdeField("CAURAB", "CAURAB", JdeDataType.Numeric),
        new JdeField("CAURRF", "CAURRF", JdeDataType.String, 30),
        new JdeField("CAUSER", "CAUSER", JdeDataType.String, 20),
        new JdeField("CAPID", "CAPID", JdeDataType.String, 20),
        new JdeField("CAJOBN", "CAJOBN", JdeDataType.String, 20),
        new JdeField("CAUPMJ", "CAUPMJ", JdeDataType.Numeric),
        new JdeField("CATDAY", "CATDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40333_0", "Primary Key on CAAN8, CACS33, CAITM, CAIT83, CAEXDJ, CAMXQ, CAUOM, CAOSEQ", new[] { "CAAN8", "CACS33", "CAITM", "CAIT83", "CAEXDJ", "CAMXQ", "CAUOM", "CAOSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40333_2", "Index on CAAN8, CACS33, CAITM, CAIT83", new[] { "CAAN8", "CACS33", "CAITM", "CAIT83" })
    };
}
