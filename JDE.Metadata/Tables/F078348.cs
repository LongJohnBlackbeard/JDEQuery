using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F078348 - .
/// </summary>
public class F078348 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YWSUIREC.
        /// </summary>
        public const string YWSUIREC = "YWSUIREC";

        /// <summary>
        /// YWUKID.
        /// </summary>
        public const string YWUKID = "YWUKID";

        /// <summary>
        /// YWVERS.
        /// </summary>
        public const string YWVERS = "YWVERS";

        /// <summary>
        /// YWUPMJ.
        /// </summary>
        public const string YWUPMJ = "YWUPMJ";

        /// <summary>
        /// YWUPMT.
        /// </summary>
        public const string YWUPMT = "YWUPMT";

        /// <summary>
        /// YWPID.
        /// </summary>
        public const string YWPID = "YWPID";

        /// <summary>
        /// YWJOBN.
        /// </summary>
        public const string YWJOBN = "YWJOBN";

        /// <summary>
        /// YWUSER.
        /// </summary>
        public const string YWUSER = "YWUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F078348";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YWSUIREC", "YWSUIREC", JdeDataType.String, 552),
        new JdeField("YWUKID", "YWUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("YWVERS", "YWVERS", JdeDataType.String, 20),
        new JdeField("YWUPMJ", "YWUPMJ", JdeDataType.Numeric),
        new JdeField("YWUPMT", "YWUPMT", JdeDataType.Numeric),
        new JdeField("YWPID", "YWPID", JdeDataType.String, 20),
        new JdeField("YWJOBN", "YWJOBN", JdeDataType.String, 20),
        new JdeField("YWUSER", "YWUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F078348_0", "Primary Key on YWUKID", new[] { "YWUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
