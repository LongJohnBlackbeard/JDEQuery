using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F007032W - .
/// </summary>
public class F007032W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OBUSER.
        /// </summary>
        public const string OBUSER = "OBUSER";

        /// <summary>
        /// OBUKID.
        /// </summary>
        public const string OBUKID = "OBUKID";

        /// <summary>
        /// OBICU.
        /// </summary>
        public const string OBICU = "OBICU";

        /// <summary>
        /// OBICUT.
        /// </summary>
        public const string OBICUT = "OBICUT";

        /// <summary>
        /// OBIST.
        /// </summary>
        public const string OBIST = "OBIST";

        /// <summary>
        /// OBDICJ.
        /// </summary>
        public const string OBDICJ = "OBDICJ";

        /// <summary>
        /// OBAA.
        /// </summary>
        public const string OBAA = "OBAA";
    }

    /// <inheritdoc />
    public override string TableName => "F007032W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OBUSER", "OBUSER", JdeDataType.String, 20, true, true),
        new JdeField("OBUKID", "OBUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("OBICU", "OBICU", JdeDataType.Numeric, null, true, true),
        new JdeField("OBICUT", "OBICUT", JdeDataType.String, 4, true, true),
        new JdeField("OBIST", "OBIST", JdeDataType.String, 2),
        new JdeField("OBDICJ", "OBDICJ", JdeDataType.Numeric),
        new JdeField("OBAA", "OBAA", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F007032W_0", "Primary Key on OBUSER, OBUKID, OBICU, OBICUT", new[] { "OBUSER", "OBUKID", "OBICU", "OBICUT" }, isUnique: true, isPrimaryKey: true)
    };
}
