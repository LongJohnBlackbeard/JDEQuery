using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B0701 - .
/// </summary>
public class F31B0701 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SDSPECID.
        /// </summary>
        public const string SDSPECID = "SDSPECID";

        /// <summary>
        /// SDSEQNUMB.
        /// </summary>
        public const string SDSEQNUMB = "SDSEQNUMB";

        /// <summary>
        /// SDNCID.
        /// </summary>
        public const string SDNCID = "SDNCID";

        /// <summary>
        /// SDTVALC.
        /// </summary>
        public const string SDTVALC = "SDTVALC";

        /// <summary>
        /// SDTVALS.
        /// </summary>
        public const string SDTVALS = "SDTVALS";

        /// <summary>
        /// SDTVALD.
        /// </summary>
        public const string SDTVALD = "SDTVALD";

        /// <summary>
        /// SDTVALN.
        /// </summary>
        public const string SDTVALN = "SDTVALN";

        /// <summary>
        /// SDNCRULE.
        /// </summary>
        public const string SDNCRULE = "SDNCRULE";

        /// <summary>
        /// SDHSERR.
        /// </summary>
        public const string SDHSERR = "SDHSERR";

        /// <summary>
        /// SDURAB.
        /// </summary>
        public const string SDURAB = "SDURAB";

        /// <summary>
        /// SDURAT.
        /// </summary>
        public const string SDURAT = "SDURAT";

        /// <summary>
        /// SDURCD.
        /// </summary>
        public const string SDURCD = "SDURCD";

        /// <summary>
        /// SDURDT.
        /// </summary>
        public const string SDURDT = "SDURDT";

        /// <summary>
        /// SDURRF.
        /// </summary>
        public const string SDURRF = "SDURRF";

        /// <summary>
        /// SDJOBN.
        /// </summary>
        public const string SDJOBN = "SDJOBN";

        /// <summary>
        /// SDPID.
        /// </summary>
        public const string SDPID = "SDPID";

        /// <summary>
        /// SDTDAY.
        /// </summary>
        public const string SDTDAY = "SDTDAY";

        /// <summary>
        /// SDUPMJ.
        /// </summary>
        public const string SDUPMJ = "SDUPMJ";

        /// <summary>
        /// SDUSER.
        /// </summary>
        public const string SDUSER = "SDUSER";

        /// <summary>
        /// SDWAB.
        /// </summary>
        public const string SDWAB = "SDWAB";

        /// <summary>
        /// SDWCD.
        /// </summary>
        public const string SDWCD = "SDWCD";

        /// <summary>
        /// SDWMDT.
        /// </summary>
        public const string SDWMDT = "SDWMDT";

        /// <summary>
        /// SDWNUM.
        /// </summary>
        public const string SDWNUM = "SDWNUM";

        /// <summary>
        /// SDWRF.
        /// </summary>
        public const string SDWRF = "SDWRF";
    }

    /// <inheritdoc />
    public override string TableName => "F31B0701";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SDSPECID", "SDSPECID", JdeDataType.Numeric, null, true, true),
        new JdeField("SDSEQNUMB", "SDSEQNUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("SDNCID", "SDNCID", JdeDataType.Numeric),
        new JdeField("SDTVALC", "SDTVALC", JdeDataType.String, 2),
        new JdeField("SDTVALS", "SDTVALS", JdeDataType.String, 40),
        new JdeField("SDTVALD", "SDTVALD", JdeDataType.Numeric),
        new JdeField("SDTVALN", "SDTVALN", JdeDataType.Numeric),
        new JdeField("SDNCRULE", "SDNCRULE", JdeDataType.String, 8),
        new JdeField("SDHSERR", "SDHSERR", JdeDataType.String, 2),
        new JdeField("SDURAB", "SDURAB", JdeDataType.Numeric),
        new JdeField("SDURAT", "SDURAT", JdeDataType.Numeric),
        new JdeField("SDURCD", "SDURCD", JdeDataType.String, 4),
        new JdeField("SDURDT", "SDURDT", JdeDataType.Numeric),
        new JdeField("SDURRF", "SDURRF", JdeDataType.String, 30),
        new JdeField("SDJOBN", "SDJOBN", JdeDataType.String, 20),
        new JdeField("SDPID", "SDPID", JdeDataType.String, 20),
        new JdeField("SDTDAY", "SDTDAY", JdeDataType.Numeric),
        new JdeField("SDUPMJ", "SDUPMJ", JdeDataType.Numeric),
        new JdeField("SDUSER", "SDUSER", JdeDataType.String, 20),
        new JdeField("SDWAB", "SDWAB", JdeDataType.Numeric),
        new JdeField("SDWCD", "SDWCD", JdeDataType.String, 6),
        new JdeField("SDWMDT", "SDWMDT", JdeDataType.Numeric),
        new JdeField("SDWNUM", "SDWNUM", JdeDataType.Numeric),
        new JdeField("SDWRF", "SDWRF", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B0701_0", "Primary Key on SDSPECID, SDSEQNUMB", new[] { "SDSPECID", "SDSEQNUMB" }, isUnique: true, isPrimaryKey: true)
    };
}
