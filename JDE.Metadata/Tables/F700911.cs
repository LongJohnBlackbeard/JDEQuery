using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F700911 - .
/// </summary>
public class F700911 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GAKCO.
        /// </summary>
        public const string GAKCO = "GAKCO";

        /// <summary>
        /// GADCT.
        /// </summary>
        public const string GADCT = "GADCT";

        /// <summary>
        /// GADOC.
        /// </summary>
        public const string GADOC = "GADOC";

        /// <summary>
        /// GADGJ.
        /// </summary>
        public const string GADGJ = "GADGJ";

        /// <summary>
        /// GAJELN.
        /// </summary>
        public const string GAJELN = "GAJELN";

        /// <summary>
        /// GAEXTL.
        /// </summary>
        public const string GAEXTL = "GAEXTL";

        /// <summary>
        /// GALT.
        /// </summary>
        public const string GALT = "GALT";

        /// <summary>
        /// GAK70IT.
        /// </summary>
        public const string GAK70IT = "GAK70IT";

        /// <summary>
        /// GAK70SER.
        /// </summary>
        public const string GAK70SER = "GAK70SER";

        /// <summary>
        /// GAK70ENUM.
        /// </summary>
        public const string GAK70ENUM = "GAK70ENUM";

        /// <summary>
        /// GAASLN.
        /// </summary>
        public const string GAASLN = "GAASLN";

        /// <summary>
        /// GAAN8.
        /// </summary>
        public const string GAAN8 = "GAAN8";

        /// <summary>
        /// GAUSER.
        /// </summary>
        public const string GAUSER = "GAUSER";

        /// <summary>
        /// GAPID.
        /// </summary>
        public const string GAPID = "GAPID";

        /// <summary>
        /// GAJOBN.
        /// </summary>
        public const string GAJOBN = "GAJOBN";

        /// <summary>
        /// GAUPMJ.
        /// </summary>
        public const string GAUPMJ = "GAUPMJ";

        /// <summary>
        /// GATDAY.
        /// </summary>
        public const string GATDAY = "GATDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F700911";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GAKCO", "GAKCO", JdeDataType.String, 10, true, true),
        new JdeField("GADCT", "GADCT", JdeDataType.String, 4, true, true),
        new JdeField("GADOC", "GADOC", JdeDataType.Numeric, null, true, true),
        new JdeField("GADGJ", "GADGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("GAJELN", "GAJELN", JdeDataType.Numeric, null, true, true),
        new JdeField("GAEXTL", "GAEXTL", JdeDataType.String, 4, true, true),
        new JdeField("GALT", "GALT", JdeDataType.String, 4, true, true),
        new JdeField("GAK70IT", "GAK70IT", JdeDataType.String, 4),
        new JdeField("GAK70SER", "GAK70SER", JdeDataType.String, 40),
        new JdeField("GAK70ENUM", "GAK70ENUM", JdeDataType.String, 72),
        new JdeField("GAASLN", "GAASLN", JdeDataType.Numeric, null, true, true),
        new JdeField("GAAN8", "GAAN8", JdeDataType.Numeric),
        new JdeField("GAUSER", "GAUSER", JdeDataType.String, 20),
        new JdeField("GAPID", "GAPID", JdeDataType.String, 20),
        new JdeField("GAJOBN", "GAJOBN", JdeDataType.String, 20),
        new JdeField("GAUPMJ", "GAUPMJ", JdeDataType.Numeric),
        new JdeField("GATDAY", "GATDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F700911_0", "Primary Key on GADCT, GADOC, GAKCO, GADGJ, GAJELN, GALT, GAEXTL, GAASLN", new[] { "GADCT", "GADOC", "GAKCO", "GADGJ", "GAJELN", "GALT", "GAEXTL", "GAASLN" }, isUnique: true, isPrimaryKey: true)
    };
}
