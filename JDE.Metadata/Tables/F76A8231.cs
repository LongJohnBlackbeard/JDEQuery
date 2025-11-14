using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A8231 - .
/// </summary>
public class F76A8231 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// C2AACA.
        /// </summary>
        public const string C2AACA = "C2AACA";

        /// <summary>
        /// C2AARS.
        /// </summary>
        public const string C2AARS = "C2AARS";

        /// <summary>
        /// C2CTID.
        /// </summary>
        public const string C2CTID = "C2CTID";

        /// <summary>
        /// C2USER.
        /// </summary>
        public const string C2USER = "C2USER";

        /// <summary>
        /// C2UPMJ.
        /// </summary>
        public const string C2UPMJ = "C2UPMJ";

        /// <summary>
        /// C2UPMT.
        /// </summary>
        public const string C2UPMT = "C2UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76A8231";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("C2AACA", "C2AACA", JdeDataType.String, 6, true, true),
        new JdeField("C2AARS", "C2AARS", JdeDataType.String, 6, true, true),
        new JdeField("C2CTID", "C2CTID", JdeDataType.String, 30),
        new JdeField("C2USER", "C2USER", JdeDataType.String, 20),
        new JdeField("C2UPMJ", "C2UPMJ", JdeDataType.Numeric),
        new JdeField("C2UPMT", "C2UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A8231_0", "Primary Key on C2AACA, C2AARS", new[] { "C2AACA", "C2AARS" }, isUnique: true, isPrimaryKey: true)
    };
}
