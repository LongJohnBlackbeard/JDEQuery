using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F79A77 - .
/// </summary>
public class F79A77 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCCO.
        /// </summary>
        public const string CCCO = "CCCO";

        /// <summary>
        /// CCBEFD.
        /// </summary>
        public const string CCBEFD = "CCBEFD";

        /// <summary>
        /// CCEEFD.
        /// </summary>
        public const string CCEEFD = "CCEEFD";

        /// <summary>
        /// CCDTPN.
        /// </summary>
        public const string CCDTPN = "CCDTPN";

        /// <summary>
        /// CC79AGPBU.
        /// </summary>
        public const string CC79AGPBU = "CC79AGPBU";

        /// <summary>
        /// CCPID.
        /// </summary>
        public const string CCPID = "CCPID";

        /// <summary>
        /// CCUSER.
        /// </summary>
        public const string CCUSER = "CCUSER";

        /// <summary>
        /// CCJOBN.
        /// </summary>
        public const string CCJOBN = "CCJOBN";

        /// <summary>
        /// CCUPMJ.
        /// </summary>
        public const string CCUPMJ = "CCUPMJ";

        /// <summary>
        /// CCTDAY.
        /// </summary>
        public const string CCTDAY = "CCTDAY";

        /// <summary>
        /// CC79AGABYN.
        /// </summary>
        public const string CC79AGABYN = "CC79AGABYN";

        /// <summary>
        /// CC79AGCYN.
        /// </summary>
        public const string CC79AGCYN = "CC79AGCYN";

        /// <summary>
        /// CC79AGCPN.
        /// </summary>
        public const string CC79AGCPN = "CC79AGCPN";

        /// <summary>
        /// CC79AGCYR.
        /// </summary>
        public const string CC79AGCYR = "CC79AGCYR";

        /// <summary>
        /// CC79AGCDJ.
        /// </summary>
        public const string CC79AGCDJ = "CC79AGCDJ";

        /// <summary>
        /// CC79AGCRIT.
        /// </summary>
        public const string CC79AGCRIT = "CC79AGCRIT";
    }

    /// <inheritdoc />
    public override string TableName => "F79A77";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCCO", "CCCO", JdeDataType.String, 10, true, true),
        new JdeField("CCBEFD", "CCBEFD", JdeDataType.Numeric, null, true, true),
        new JdeField("CCEEFD", "CCEEFD", JdeDataType.Numeric, null, true, true),
        new JdeField("CCDTPN", "CCDTPN", JdeDataType.String, 2),
        new JdeField("CC79AGPBU", "CC79AGPBU", JdeDataType.String, 2),
        new JdeField("CCPID", "CCPID", JdeDataType.String, 20),
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20),
        new JdeField("CCJOBN", "CCJOBN", JdeDataType.String, 20),
        new JdeField("CCUPMJ", "CCUPMJ", JdeDataType.Numeric),
        new JdeField("CCTDAY", "CCTDAY", JdeDataType.Numeric),
        new JdeField("CC79AGABYN", "CC79AGABYN", JdeDataType.String, 2),
        new JdeField("CC79AGCYN", "CC79AGCYN", JdeDataType.String, 2),
        new JdeField("CC79AGCPN", "CC79AGCPN", JdeDataType.Numeric),
        new JdeField("CC79AGCYR", "CC79AGCYR", JdeDataType.String, 4),
        new JdeField("CC79AGCDJ", "CC79AGCDJ", JdeDataType.Numeric),
        new JdeField("CC79AGCRIT", "CC79AGCRIT", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F79A77_0", "Primary Key on CCCO, CCBEFD, CCEEFD", new[] { "CCCO", "CCBEFD", "CCEEFD" }, isUnique: true, isPrimaryKey: true)
    };
}
