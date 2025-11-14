using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15423 - .
/// </summary>
public class F15423 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TDCO.
        /// </summary>
        public const string TDCO = "TDCO";

        /// <summary>
        /// TDRRCFD.
        /// </summary>
        public const string TDRRCFD = "TDRRCFD";

        /// <summary>
        /// TDRRPCD.
        /// </summary>
        public const string TDRRPCD = "TDRRPCD";

        /// <summary>
        /// TDUPMJ.
        /// </summary>
        public const string TDUPMJ = "TDUPMJ";

        /// <summary>
        /// TDUPMT.
        /// </summary>
        public const string TDUPMT = "TDUPMT";

        /// <summary>
        /// TDMKEY.
        /// </summary>
        public const string TDMKEY = "TDMKEY";

        /// <summary>
        /// TDUSER.
        /// </summary>
        public const string TDUSER = "TDUSER";

        /// <summary>
        /// TDPID.
        /// </summary>
        public const string TDPID = "TDPID";
    }

    /// <inheritdoc />
    public override string TableName => "F15423";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TDCO", "TDCO", JdeDataType.String, 10, true, true),
        new JdeField("TDRRCFD", "TDRRCFD", JdeDataType.String, 2),
        new JdeField("TDRRPCD", "TDRRPCD", JdeDataType.String, 2),
        new JdeField("TDUPMJ", "TDUPMJ", JdeDataType.Numeric),
        new JdeField("TDUPMT", "TDUPMT", JdeDataType.Numeric),
        new JdeField("TDMKEY", "TDMKEY", JdeDataType.String, 30),
        new JdeField("TDUSER", "TDUSER", JdeDataType.String, 20),
        new JdeField("TDPID", "TDPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15423_0", "Primary Key on TDCO", new[] { "TDCO" }, isUnique: true, isPrimaryKey: true)
    };
}
