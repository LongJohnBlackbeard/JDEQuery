using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B0700 - .
/// </summary>
public class F31B0700 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SMSPECID.
        /// </summary>
        public const string SMSPECID = "SMSPECID";

        /// <summary>
        /// SMSPECNM.
        /// </summary>
        public const string SMSPECNM = "SMSPECNM";

        /// <summary>
        /// SMSPECDS.
        /// </summary>
        public const string SMSPECDS = "SMSPECDS";

        /// <summary>
        /// SMURAB.
        /// </summary>
        public const string SMURAB = "SMURAB";

        /// <summary>
        /// SMURAT.
        /// </summary>
        public const string SMURAT = "SMURAT";

        /// <summary>
        /// SMURCD.
        /// </summary>
        public const string SMURCD = "SMURCD";

        /// <summary>
        /// SMURDT.
        /// </summary>
        public const string SMURDT = "SMURDT";

        /// <summary>
        /// SMURRF.
        /// </summary>
        public const string SMURRF = "SMURRF";

        /// <summary>
        /// SMJOBN.
        /// </summary>
        public const string SMJOBN = "SMJOBN";

        /// <summary>
        /// SMPID.
        /// </summary>
        public const string SMPID = "SMPID";

        /// <summary>
        /// SMTDAY.
        /// </summary>
        public const string SMTDAY = "SMTDAY";

        /// <summary>
        /// SMUPMJ.
        /// </summary>
        public const string SMUPMJ = "SMUPMJ";

        /// <summary>
        /// SMUSER.
        /// </summary>
        public const string SMUSER = "SMUSER";

        /// <summary>
        /// SMWAB.
        /// </summary>
        public const string SMWAB = "SMWAB";

        /// <summary>
        /// SMWCD.
        /// </summary>
        public const string SMWCD = "SMWCD";

        /// <summary>
        /// SMWMDT.
        /// </summary>
        public const string SMWMDT = "SMWMDT";

        /// <summary>
        /// SMWNUM.
        /// </summary>
        public const string SMWNUM = "SMWNUM";

        /// <summary>
        /// SMWRF.
        /// </summary>
        public const string SMWRF = "SMWRF";
    }

    /// <inheritdoc />
    public override string TableName => "F31B0700";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SMSPECID", "SMSPECID", JdeDataType.Numeric, null, true, true),
        new JdeField("SMSPECNM", "SMSPECNM", JdeDataType.String, 24),
        new JdeField("SMSPECDS", "SMSPECDS", JdeDataType.String, 60),
        new JdeField("SMURAB", "SMURAB", JdeDataType.Numeric),
        new JdeField("SMURAT", "SMURAT", JdeDataType.Numeric),
        new JdeField("SMURCD", "SMURCD", JdeDataType.String, 4),
        new JdeField("SMURDT", "SMURDT", JdeDataType.Numeric),
        new JdeField("SMURRF", "SMURRF", JdeDataType.String, 30),
        new JdeField("SMJOBN", "SMJOBN", JdeDataType.String, 20),
        new JdeField("SMPID", "SMPID", JdeDataType.String, 20),
        new JdeField("SMTDAY", "SMTDAY", JdeDataType.Numeric),
        new JdeField("SMUPMJ", "SMUPMJ", JdeDataType.Numeric),
        new JdeField("SMUSER", "SMUSER", JdeDataType.String, 20),
        new JdeField("SMWAB", "SMWAB", JdeDataType.Numeric),
        new JdeField("SMWCD", "SMWCD", JdeDataType.String, 6),
        new JdeField("SMWMDT", "SMWMDT", JdeDataType.Numeric),
        new JdeField("SMWNUM", "SMWNUM", JdeDataType.Numeric),
        new JdeField("SMWRF", "SMWRF", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B0700_0", "Primary Key on SMSPECID", new[] { "SMSPECID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B0700_3", "Index on SMSPECNM, SMSPECID", new[] { "SMSPECNM", "SMSPECID" })
    };
}
