using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R012 - .
/// </summary>
public class F74R012 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CDK74LECO.
        /// </summary>
        public const string CDK74LECO = "CDK74LECO";

        /// <summary>
        /// CDFY.
        /// </summary>
        public const string CDFY = "CDFY";

        /// <summary>
        /// CDCTRY.
        /// </summary>
        public const string CDCTRY = "CDCTRY";

        /// <summary>
        /// CDR74DTCD.
        /// </summary>
        public const string CDR74DTCD = "CDR74DTCD";

        /// <summary>
        /// CDK74ISPL.
        /// </summary>
        public const string CDK74ISPL = "CDK74ISPL";

        /// <summary>
        /// CDAID.
        /// </summary>
        public const string CDAID = "CDAID";

        /// <summary>
        /// CDCRCD.
        /// </summary>
        public const string CDCRCD = "CDCRCD";

        /// <summary>
        /// CDN001.
        /// </summary>
        public const string CDN001 = "CDN001";

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
        /// CDUPMT.
        /// </summary>
        public const string CDUPMT = "CDUPMT";

        /// <summary>
        /// CDJOBN.
        /// </summary>
        public const string CDJOBN = "CDJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74R012";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CDK74LECO", "CDK74LECO", JdeDataType.String, 10, true, true),
        new JdeField("CDFY", "CDFY", JdeDataType.Numeric, null, true, true),
        new JdeField("CDCTRY", "CDCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("CDR74DTCD", "CDR74DTCD", JdeDataType.String, 4, true, true),
        new JdeField("CDK74ISPL", "CDK74ISPL", JdeDataType.String, 30, true, true),
        new JdeField("CDAID", "CDAID", JdeDataType.String, 16, true, true),
        new JdeField("CDCRCD", "CDCRCD", JdeDataType.String, 6, true, true),
        new JdeField("CDN001", "CDN001", JdeDataType.Numeric),
        new JdeField("CDUSER", "CDUSER", JdeDataType.String, 20),
        new JdeField("CDPID", "CDPID", JdeDataType.String, 20),
        new JdeField("CDUPMJ", "CDUPMJ", JdeDataType.Numeric),
        new JdeField("CDUPMT", "CDUPMT", JdeDataType.Numeric),
        new JdeField("CDJOBN", "CDJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R012_0", "Primary Key on CDK74LECO, CDFY, CDCTRY, CDR74DTCD, CDK74ISPL, CDAID, CDCRCD", new[] { "CDK74LECO", "CDFY", "CDCTRY", "CDR74DTCD", "CDK74ISPL", "CDAID", "CDCRCD" }, isUnique: true, isPrimaryKey: true)
    };
}
