using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49614 - .
/// </summary>
public class F49614 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TSVMCU.
        /// </summary>
        public const string TSVMCU = "TSVMCU";

        /// <summary>
        /// TSLDNM.
        /// </summary>
        public const string TSLDNM = "TSLDNM";

        /// <summary>
        /// TSJBCD.
        /// </summary>
        public const string TSJBCD = "TSJBCD";

        /// <summary>
        /// TSSTFN.
        /// </summary>
        public const string TSSTFN = "TSSTFN";

        /// <summary>
        /// TSURCD.
        /// </summary>
        public const string TSURCD = "TSURCD";

        /// <summary>
        /// TSURDT.
        /// </summary>
        public const string TSURDT = "TSURDT";

        /// <summary>
        /// TSURAT.
        /// </summary>
        public const string TSURAT = "TSURAT";

        /// <summary>
        /// TSURAB.
        /// </summary>
        public const string TSURAB = "TSURAB";

        /// <summary>
        /// TSURRF.
        /// </summary>
        public const string TSURRF = "TSURRF";

        /// <summary>
        /// TSUSER.
        /// </summary>
        public const string TSUSER = "TSUSER";

        /// <summary>
        /// TSPID.
        /// </summary>
        public const string TSPID = "TSPID";

        /// <summary>
        /// TSJOBN.
        /// </summary>
        public const string TSJOBN = "TSJOBN";

        /// <summary>
        /// TSUPMJ.
        /// </summary>
        public const string TSUPMJ = "TSUPMJ";

        /// <summary>
        /// TSTDAY.
        /// </summary>
        public const string TSTDAY = "TSTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F49614";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TSVMCU", "TSVMCU", JdeDataType.String, 24, true, true),
        new JdeField("TSLDNM", "TSLDNM", JdeDataType.Numeric, null, true, true),
        new JdeField("TSJBCD", "TSJBCD", JdeDataType.String, 12, true, true),
        new JdeField("TSSTFN", "TSSTFN", JdeDataType.Numeric, null, true, true),
        new JdeField("TSURCD", "TSURCD", JdeDataType.String, 4),
        new JdeField("TSURDT", "TSURDT", JdeDataType.Numeric),
        new JdeField("TSURAT", "TSURAT", JdeDataType.Numeric),
        new JdeField("TSURAB", "TSURAB", JdeDataType.Numeric),
        new JdeField("TSURRF", "TSURRF", JdeDataType.String, 30),
        new JdeField("TSUSER", "TSUSER", JdeDataType.String, 20),
        new JdeField("TSPID", "TSPID", JdeDataType.String, 20),
        new JdeField("TSJOBN", "TSJOBN", JdeDataType.String, 20),
        new JdeField("TSUPMJ", "TSUPMJ", JdeDataType.Numeric),
        new JdeField("TSTDAY", "TSTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49614_0", "Primary Key on TSVMCU, TSLDNM, TSJBCD, TSSTFN", new[] { "TSVMCU", "TSLDNM", "TSJBCD", "TSSTFN" }, isUnique: true, isPrimaryKey: true)
    };
}
