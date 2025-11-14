using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4801ST1 - .
/// </summary>
public class F4801ST1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WADOCO.
        /// </summary>
        public const string WADOCO = "WADOCO";

        /// <summary>
        /// WATSKTP.
        /// </summary>
        public const string WATSKTP = "WATSKTP";

        /// <summary>
        /// WABILLA.
        /// </summary>
        public const string WABILLA = "WABILLA";

        /// <summary>
        /// WALODL.
        /// </summary>
        public const string WALODL = "WALODL";

        /// <summary>
        /// WABILLC.
        /// </summary>
        public const string WABILLC = "WABILLC";
    }

    /// <inheritdoc />
    public override string TableName => "F4801ST1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WADOCO", "WADOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("WATSKTP", "WATSKTP", JdeDataType.String, 2),
        new JdeField("WABILLA", "WABILLA", JdeDataType.String, 2),
        new JdeField("WALODL", "WALODL", JdeDataType.String, 2),
        new JdeField("WABILLC", "WABILLC", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4801ST1_0", "Primary Key on WADOCO", new[] { "WADOCO" }, isUnique: true, isPrimaryKey: true)
    };
}
