using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B08 - .
/// </summary>
public class F03B08 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RDCO.
        /// </summary>
        public const string RDCO = "RDCO";

        /// <summary>
        /// RDCTRY.
        /// </summary>
        public const string RDCTRY = "RDCTRY";

        /// <summary>
        /// RDFY.
        /// </summary>
        public const string RDFY = "RDFY";

        /// <summary>
        /// RDPN.
        /// </summary>
        public const string RDPN = "RDPN";

        /// <summary>
        /// RDDTBG.
        /// </summary>
        public const string RDDTBG = "RDDTBG";

        /// <summary>
        /// RDDTEN.
        /// </summary>
        public const string RDDTEN = "RDDTEN";

        /// <summary>
        /// RDCURY.
        /// </summary>
        public const string RDCURY = "RDCURY";

        /// <summary>
        /// RDDAYP.
        /// </summary>
        public const string RDDAYP = "RDDAYP";

        /// <summary>
        /// RDUSER.
        /// </summary>
        public const string RDUSER = "RDUSER";

        /// <summary>
        /// RDPID.
        /// </summary>
        public const string RDPID = "RDPID";

        /// <summary>
        /// RDUPMJ.
        /// </summary>
        public const string RDUPMJ = "RDUPMJ";

        /// <summary>
        /// RDUPMT.
        /// </summary>
        public const string RDUPMT = "RDUPMT";

        /// <summary>
        /// RDJOBN.
        /// </summary>
        public const string RDJOBN = "RDJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F03B08";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RDCO", "RDCO", JdeDataType.String, 10, true, true),
        new JdeField("RDCTRY", "RDCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("RDFY", "RDFY", JdeDataType.Numeric, null, true, true),
        new JdeField("RDPN", "RDPN", JdeDataType.Numeric, null, true, true),
        new JdeField("RDDTBG", "RDDTBG", JdeDataType.Numeric),
        new JdeField("RDDTEN", "RDDTEN", JdeDataType.Numeric),
        new JdeField("RDCURY", "RDCURY", JdeDataType.String, 2),
        new JdeField("RDDAYP", "RDDAYP", JdeDataType.Numeric),
        new JdeField("RDUSER", "RDUSER", JdeDataType.String, 20),
        new JdeField("RDPID", "RDPID", JdeDataType.String, 20),
        new JdeField("RDUPMJ", "RDUPMJ", JdeDataType.Numeric),
        new JdeField("RDUPMT", "RDUPMT", JdeDataType.Numeric),
        new JdeField("RDJOBN", "RDJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B08_0", "Primary Key on RDCO, RDCTRY, RDFY, RDPN", new[] { "RDCO", "RDCTRY", "RDFY", "RDPN" }, isUnique: true, isPrimaryKey: true)
    };
}
