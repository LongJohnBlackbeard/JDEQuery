using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4858 - .
/// </summary>
public class F4858 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// F7INVF.
        /// </summary>
        public const string F7INVF = "F7INVF";

        /// <summary>
        /// F7INTY.
        /// </summary>
        public const string F7INTY = "F7INTY";

        /// <summary>
        /// F7TYKY.
        /// </summary>
        public const string F7TYKY = "F7TYKY";

        /// <summary>
        /// F7TKEY.
        /// </summary>
        public const string F7TKEY = "F7TKEY";

        /// <summary>
        /// F7USER.
        /// </summary>
        public const string F7USER = "F7USER";

        /// <summary>
        /// F7PID.
        /// </summary>
        public const string F7PID = "F7PID";

        /// <summary>
        /// F7JOBN.
        /// </summary>
        public const string F7JOBN = "F7JOBN";

        /// <summary>
        /// F7UPMJ.
        /// </summary>
        public const string F7UPMJ = "F7UPMJ";

        /// <summary>
        /// F7UPMT.
        /// </summary>
        public const string F7UPMT = "F7UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F4858";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("F7INVF", "F7INVF", JdeDataType.String, 20, true, true),
        new JdeField("F7INTY", "F7INTY", JdeDataType.String, 2, true, true),
        new JdeField("F7TYKY", "F7TYKY", JdeDataType.String, 2, true, true),
        new JdeField("F7TKEY", "F7TKEY", JdeDataType.String, 24, true, true),
        new JdeField("F7USER", "F7USER", JdeDataType.String, 20),
        new JdeField("F7PID", "F7PID", JdeDataType.String, 20),
        new JdeField("F7JOBN", "F7JOBN", JdeDataType.String, 20),
        new JdeField("F7UPMJ", "F7UPMJ", JdeDataType.Numeric),
        new JdeField("F7UPMT", "F7UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4858_0", "Primary Key on F7INVF, F7INTY, F7TYKY, F7TKEY", new[] { "F7INVF", "F7INTY", "F7TYKY", "F7TKEY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4858_2", "Index on F7TYKY, F7TKEY", new[] { "F7TYKY", "F7TKEY" })
    };
}
