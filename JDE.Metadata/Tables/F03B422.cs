using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B422 - .
/// </summary>
public class F03B422 : JdeTable
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
        /// TDCALDJ.
        /// </summary>
        public const string TDCALDJ = "TDCALDJ";

        /// <summary>
        /// TDCOMDJ.
        /// </summary>
        public const string TDCOMDJ = "TDCOMDJ";

        /// <summary>
        /// TDUPMJ.
        /// </summary>
        public const string TDUPMJ = "TDUPMJ";

        /// <summary>
        /// TDUPMT.
        /// </summary>
        public const string TDUPMT = "TDUPMT";

        /// <summary>
        /// TDUSER.
        /// </summary>
        public const string TDUSER = "TDUSER";

        /// <summary>
        /// TDJOBN.
        /// </summary>
        public const string TDJOBN = "TDJOBN";

        /// <summary>
        /// TDPID.
        /// </summary>
        public const string TDPID = "TDPID";
    }

    /// <inheritdoc />
    public override string TableName => "F03B422";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TDCO", "TDCO", JdeDataType.String, 10, true, true),
        new JdeField("TDCALDJ", "TDCALDJ", JdeDataType.String, 2),
        new JdeField("TDCOMDJ", "TDCOMDJ", JdeDataType.String, 2),
        new JdeField("TDUPMJ", "TDUPMJ", JdeDataType.Numeric),
        new JdeField("TDUPMT", "TDUPMT", JdeDataType.Numeric),
        new JdeField("TDUSER", "TDUSER", JdeDataType.String, 20),
        new JdeField("TDJOBN", "TDJOBN", JdeDataType.String, 20),
        new JdeField("TDPID", "TDPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B422_0", "Primary Key on TDCO", new[] { "TDCO" }, isUnique: true, isPrimaryKey: true)
    };
}
