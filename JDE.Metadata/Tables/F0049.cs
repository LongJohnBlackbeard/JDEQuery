using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0049 - .
/// </summary>
public class F0049 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CAFUNCC.
        /// </summary>
        public const string CAFUNCC = "CAFUNCC";

        /// <summary>
        /// CACFUNCD.
        /// </summary>
        public const string CACFUNCD = "CACFUNCD";

        /// <summary>
        /// CACFCNM.
        /// </summary>
        public const string CACFCNM = "CACFCNM";

        /// <summary>
        /// CAIVSEQ.
        /// </summary>
        public const string CAIVSEQ = "CAIVSEQ";

        /// <summary>
        /// CAFUNACT.
        /// </summary>
        public const string CAFUNACT = "CAFUNACT";

        /// <summary>
        /// CACFGGC.
        /// </summary>
        public const string CACFGGC = "CACFGGC";

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
        /// CAMKEY.
        /// </summary>
        public const string CAMKEY = "CAMKEY";

        /// <summary>
        /// CAPID.
        /// </summary>
        public const string CAPID = "CAPID";

        /// <summary>
        /// CAUUPMJ.
        /// </summary>
        public const string CAUUPMJ = "CAUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F0049";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CAFUNCC", "CAFUNCC", JdeDataType.String, 20, true, true),
        new JdeField("CACFUNCD", "CACFUNCD", JdeDataType.String, 60, true, true),
        new JdeField("CACFCNM", "CACFCNM", JdeDataType.String, 64, true, true),
        new JdeField("CAIVSEQ", "CAIVSEQ", JdeDataType.Numeric),
        new JdeField("CAFUNACT", "CAFUNACT", JdeDataType.Numeric),
        new JdeField("CACFGGC", "CACFGGC", JdeDataType.String, 20),
        new JdeField("CAURCD", "CAURCD", JdeDataType.String, 4),
        new JdeField("CAURDT", "CAURDT", JdeDataType.Numeric),
        new JdeField("CAURAT", "CAURAT", JdeDataType.Numeric),
        new JdeField("CAURAB", "CAURAB", JdeDataType.Numeric),
        new JdeField("CAURRF", "CAURRF", JdeDataType.String, 30),
        new JdeField("CAUSER", "CAUSER", JdeDataType.String, 20),
        new JdeField("CAMKEY", "CAMKEY", JdeDataType.String, 30),
        new JdeField("CAPID", "CAPID", JdeDataType.String, 20),
        new JdeField("CAUUPMJ", "CAUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0049_0", "Primary Key on CAFUNCC, CACFUNCD, CACFCNM", new[] { "CAFUNCC", "CACFUNCD", "CACFCNM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0049_2", "Index on CAFUNCC, CACFUNCD, CAFUNACT, CAIVSEQ", new[] { "CAFUNCC", "CACFUNCD", "CAFUNACT", "CAIVSEQ" })
    };
}
