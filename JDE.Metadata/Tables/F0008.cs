using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0008 - .
/// </summary>
public class F0008 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CDDTPN.
        /// </summary>
        public const string CDDTPN = "CDDTPN";

        /// <summary>
        /// CDFY.
        /// </summary>
        public const string CDFY = "CDFY";

        /// <summary>
        /// CDDFYJ.
        /// </summary>
        public const string CDDFYJ = "CDDFYJ";

        /// <summary>
        /// CDFQ.
        /// </summary>
        public const string CDFQ = "CDFQ";

        /// <summary>
        /// CDD01J.
        /// </summary>
        public const string CDD01J = "CDD01J";

        /// <summary>
        /// CDD02J.
        /// </summary>
        public const string CDD02J = "CDD02J";

        /// <summary>
        /// CDD03J.
        /// </summary>
        public const string CDD03J = "CDD03J";

        /// <summary>
        /// CDD04J.
        /// </summary>
        public const string CDD04J = "CDD04J";

        /// <summary>
        /// CDD05J.
        /// </summary>
        public const string CDD05J = "CDD05J";

        /// <summary>
        /// CDD06J.
        /// </summary>
        public const string CDD06J = "CDD06J";

        /// <summary>
        /// CDD07J.
        /// </summary>
        public const string CDD07J = "CDD07J";

        /// <summary>
        /// CDD08J.
        /// </summary>
        public const string CDD08J = "CDD08J";

        /// <summary>
        /// CDD09J.
        /// </summary>
        public const string CDD09J = "CDD09J";

        /// <summary>
        /// CDD10J.
        /// </summary>
        public const string CDD10J = "CDD10J";

        /// <summary>
        /// CDD11J.
        /// </summary>
        public const string CDD11J = "CDD11J";

        /// <summary>
        /// CDD12J.
        /// </summary>
        public const string CDD12J = "CDD12J";

        /// <summary>
        /// CDD13J.
        /// </summary>
        public const string CDD13J = "CDD13J";

        /// <summary>
        /// CDD14J.
        /// </summary>
        public const string CDD14J = "CDD14J";

        /// <summary>
        /// CDPNT.
        /// </summary>
        public const string CDPNT = "CDPNT";

        /// <summary>
        /// CDUSER.
        /// </summary>
        public const string CDUSER = "CDUSER";

        /// <summary>
        /// CDPID.
        /// </summary>
        public const string CDPID = "CDPID";

        /// <summary>
        /// CDUPMJ.
        /// </summary>
        public const string CDUPMJ = "CDUPMJ";

        /// <summary>
        /// CDJOBN.
        /// </summary>
        public const string CDJOBN = "CDJOBN";

        /// <summary>
        /// CDUPMT.
        /// </summary>
        public const string CDUPMT = "CDUPMT";

        /// <summary>
        /// CDCTRY.
        /// </summary>
        public const string CDCTRY = "CDCTRY";
    }

    /// <inheritdoc />
    public override string TableName => "F0008";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CDDTPN", "CDDTPN", JdeDataType.String, 2, true, true),
        new JdeField("CDFY", "CDFY", JdeDataType.Numeric),
        new JdeField("CDDFYJ", "CDDFYJ", JdeDataType.Numeric, null, true, true),
        new JdeField("CDFQ", "CDFQ", JdeDataType.String, 8, true, true),
        new JdeField("CDD01J", "CDD01J", JdeDataType.Numeric),
        new JdeField("CDD02J", "CDD02J", JdeDataType.Numeric),
        new JdeField("CDD03J", "CDD03J", JdeDataType.Numeric),
        new JdeField("CDD04J", "CDD04J", JdeDataType.Numeric),
        new JdeField("CDD05J", "CDD05J", JdeDataType.Numeric),
        new JdeField("CDD06J", "CDD06J", JdeDataType.Numeric),
        new JdeField("CDD07J", "CDD07J", JdeDataType.Numeric),
        new JdeField("CDD08J", "CDD08J", JdeDataType.Numeric),
        new JdeField("CDD09J", "CDD09J", JdeDataType.Numeric),
        new JdeField("CDD10J", "CDD10J", JdeDataType.Numeric),
        new JdeField("CDD11J", "CDD11J", JdeDataType.Numeric),
        new JdeField("CDD12J", "CDD12J", JdeDataType.Numeric),
        new JdeField("CDD13J", "CDD13J", JdeDataType.Numeric),
        new JdeField("CDD14J", "CDD14J", JdeDataType.Numeric),
        new JdeField("CDPNT", "CDPNT", JdeDataType.String, 2),
        new JdeField("CDUSER", "CDUSER", JdeDataType.String, 20),
        new JdeField("CDPID", "CDPID", JdeDataType.String, 20),
        new JdeField("CDUPMJ", "CDUPMJ", JdeDataType.Numeric),
        new JdeField("CDJOBN", "CDJOBN", JdeDataType.String, 20),
        new JdeField("CDUPMT", "CDUPMT", JdeDataType.Numeric),
        new JdeField("CDCTRY", "CDCTRY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0008_0", "Primary Key on CDDTPN, CDDFYJ, CDFQ", new[] { "CDDTPN", "CDDFYJ", "CDFQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0008_2", "Index on CDFY, CDDTPN", new[] { "CDFY", "CDDTPN" })
    };
}
