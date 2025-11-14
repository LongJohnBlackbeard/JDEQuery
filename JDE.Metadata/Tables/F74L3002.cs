using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74L3002 - .
/// </summary>
public class F74L3002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ETKCO.
        /// </summary>
        public const string ETKCO = "ETKCO";

        /// <summary>
        /// ETDCT.
        /// </summary>
        public const string ETDCT = "ETDCT";

        /// <summary>
        /// ETDOC.
        /// </summary>
        public const string ETDOC = "ETDOC";

        /// <summary>
        /// ETK74FLEN.
        /// </summary>
        public const string ETK74FLEN = "ETK74FLEN";

        /// <summary>
        /// ETL74LECO.
        /// </summary>
        public const string ETL74LECO = "ETL74LECO";

        /// <summary>
        /// ETL74TRANS.
        /// </summary>
        public const string ETL74TRANS = "ETL74TRANS";

        /// <summary>
        /// ETL74ADCID.
        /// </summary>
        public const string ETL74ADCID = "ETL74ADCID";

        /// <summary>
        /// ETUKID.
        /// </summary>
        public const string ETUKID = "ETUKID";

        /// <summary>
        /// ETUSER.
        /// </summary>
        public const string ETUSER = "ETUSER";

        /// <summary>
        /// ETPID.
        /// </summary>
        public const string ETPID = "ETPID";

        /// <summary>
        /// ETJOBN.
        /// </summary>
        public const string ETJOBN = "ETJOBN";

        /// <summary>
        /// ETUPMJ.
        /// </summary>
        public const string ETUPMJ = "ETUPMJ";

        /// <summary>
        /// ETUPMT.
        /// </summary>
        public const string ETUPMT = "ETUPMT";

        /// <summary>
        /// ETYFUTDT.
        /// </summary>
        public const string ETYFUTDT = "ETYFUTDT";

        /// <summary>
        /// ETFUT6.
        /// </summary>
        public const string ETFUT6 = "ETFUT6";

        /// <summary>
        /// ETFUTCH1.
        /// </summary>
        public const string ETFUTCH1 = "ETFUTCH1";

        /// <summary>
        /// ETFFG1.
        /// </summary>
        public const string ETFFG1 = "ETFFG1";

        /// <summary>
        /// ETFFU4.
        /// </summary>
        public const string ETFFU4 = "ETFFU4";

        /// <summary>
        /// ETK74SED.
        /// </summary>
        public const string ETK74SED = "ETK74SED";

        /// <summary>
        /// ETAN8.
        /// </summary>
        public const string ETAN8 = "ETAN8";

        /// <summary>
        /// ETL74JPD.
        /// </summary>
        public const string ETL74JPD = "ETL74JPD";

        /// <summary>
        /// ETL74MD.
        /// </summary>
        public const string ETL74MD = "ETL74MD";
    }

    /// <inheritdoc />
    public override string TableName => "F74L3002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ETKCO", "ETKCO", JdeDataType.String, 10, true, true),
        new JdeField("ETDCT", "ETDCT", JdeDataType.String, 4, true, true),
        new JdeField("ETDOC", "ETDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("ETK74FLEN", "ETK74FLEN", JdeDataType.String, 50),
        new JdeField("ETL74LECO", "ETL74LECO", JdeDataType.String, 10),
        new JdeField("ETL74TRANS", "ETL74TRANS", JdeDataType.String, 2),
        new JdeField("ETL74ADCID", "ETL74ADCID", JdeDataType.String, 400),
        new JdeField("ETUKID", "ETUKID", JdeDataType.Numeric),
        new JdeField("ETUSER", "ETUSER", JdeDataType.String, 20),
        new JdeField("ETPID", "ETPID", JdeDataType.String, 20),
        new JdeField("ETJOBN", "ETJOBN", JdeDataType.String, 20),
        new JdeField("ETUPMJ", "ETUPMJ", JdeDataType.Numeric),
        new JdeField("ETUPMT", "ETUPMT", JdeDataType.Numeric),
        new JdeField("ETYFUTDT", "ETYFUTDT", JdeDataType.Numeric),
        new JdeField("ETFUT6", "ETFUT6", JdeDataType.String, 60),
        new JdeField("ETFUTCH1", "ETFUTCH1", JdeDataType.String, 2),
        new JdeField("ETFFG1", "ETFFG1", JdeDataType.String, 2),
        new JdeField("ETFFU4", "ETFFU4", JdeDataType.Numeric),
        new JdeField("ETK74SED", "ETK74SED", JdeDataType.Numeric),
        new JdeField("ETAN8", "ETAN8", JdeDataType.Numeric),
        new JdeField("ETL74JPD", "ETL74JPD", JdeDataType.Numeric),
        new JdeField("ETL74MD", "ETL74MD", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74L3002_0", "Primary Key on ETKCO, ETDCT, ETDOC", new[] { "ETKCO", "ETDCT", "ETDOC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74L3002_2", "Index on ETL74LECO, ETK74FLEN", new[] { "ETL74LECO", "ETK74FLEN" })
    };
}
