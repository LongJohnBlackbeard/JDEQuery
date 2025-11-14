using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48091B - .
/// </summary>
public class F48091B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BTSTYL.
        /// </summary>
        public const string BTSTYL = "BTSTYL";

        /// <summary>
        /// BTPID.
        /// </summary>
        public const string BTPID = "BTPID";

        /// <summary>
        /// BTMKEY.
        /// </summary>
        public const string BTMKEY = "BTMKEY";

        /// <summary>
        /// BTUSER.
        /// </summary>
        public const string BTUSER = "BTUSER";

        /// <summary>
        /// BTUPMJ.
        /// </summary>
        public const string BTUPMJ = "BTUPMJ";

        /// <summary>
        /// BTUPMT.
        /// </summary>
        public const string BTUPMT = "BTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F48091B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BTSTYL", "BTSTYL", JdeDataType.String, 4, true, true),
        new JdeField("BTPID", "BTPID", JdeDataType.String, 20),
        new JdeField("BTMKEY", "BTMKEY", JdeDataType.String, 30),
        new JdeField("BTUSER", "BTUSER", JdeDataType.String, 20),
        new JdeField("BTUPMJ", "BTUPMJ", JdeDataType.Numeric),
        new JdeField("BTUPMT", "BTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48091B_0", "Primary Key on BTSTYL", new[] { "BTSTYL" }, isUnique: true, isPrimaryKey: true)
    };
}
