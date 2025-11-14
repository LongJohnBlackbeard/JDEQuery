using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F051427 - .
/// </summary>
public class F051427 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IWWORDID.
        /// </summary>
        public const string IWWORDID = "IWWORDID";

        /// <summary>
        /// IWUSER.
        /// </summary>
        public const string IWUSER = "IWUSER";

        /// <summary>
        /// IWPID.
        /// </summary>
        public const string IWPID = "IWPID";

        /// <summary>
        /// IWMKEY.
        /// </summary>
        public const string IWMKEY = "IWMKEY";

        /// <summary>
        /// IWUPMJ.
        /// </summary>
        public const string IWUPMJ = "IWUPMJ";

        /// <summary>
        /// IWUPMT.
        /// </summary>
        public const string IWUPMT = "IWUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F051427";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IWWORDID", "IWWORDID", JdeDataType.Numeric, null, true, true),
        new JdeField("IWUSER", "IWUSER", JdeDataType.String, 20),
        new JdeField("IWPID", "IWPID", JdeDataType.String, 20),
        new JdeField("IWMKEY", "IWMKEY", JdeDataType.String, 30),
        new JdeField("IWUPMJ", "IWUPMJ", JdeDataType.Numeric),
        new JdeField("IWUPMT", "IWUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F051427_0", "Primary Key on IWWORDID", new[] { "IWWORDID" }, isUnique: true, isPrimaryKey: true)
    };
}
