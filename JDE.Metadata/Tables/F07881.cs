using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07881 - .
/// </summary>
public class F07881 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YFUKID.
        /// </summary>
        public const string YFUKID = "YFUKID";

        /// <summary>
        /// YFSUIREC.
        /// </summary>
        public const string YFSUIREC = "YFSUIREC";

        /// <summary>
        /// YFVERS.
        /// </summary>
        public const string YFVERS = "YFVERS";

        /// <summary>
        /// YFUPMJ.
        /// </summary>
        public const string YFUPMJ = "YFUPMJ";

        /// <summary>
        /// YFUPMT.
        /// </summary>
        public const string YFUPMT = "YFUPMT";

        /// <summary>
        /// YFPID.
        /// </summary>
        public const string YFPID = "YFPID";

        /// <summary>
        /// YFJOBN.
        /// </summary>
        public const string YFJOBN = "YFJOBN";

        /// <summary>
        /// YFUSER.
        /// </summary>
        public const string YFUSER = "YFUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F07881";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YFUKID", "YFUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("YFSUIREC", "YFSUIREC", JdeDataType.String, 552),
        new JdeField("YFVERS", "YFVERS", JdeDataType.String, 20),
        new JdeField("YFUPMJ", "YFUPMJ", JdeDataType.Numeric),
        new JdeField("YFUPMT", "YFUPMT", JdeDataType.Numeric),
        new JdeField("YFPID", "YFPID", JdeDataType.String, 20),
        new JdeField("YFJOBN", "YFJOBN", JdeDataType.String, 20),
        new JdeField("YFUSER", "YFUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07881_0", "Primary Key on YFUKID", new[] { "YFUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
