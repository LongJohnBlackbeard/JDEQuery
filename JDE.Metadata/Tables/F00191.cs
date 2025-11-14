using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F00191 - .
/// </summary>
public class F00191 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CESY.
        /// </summary>
        public const string CESY = "CESY";

        /// <summary>
        /// CERT.
        /// </summary>
        public const string CERT = "CERT";

        /// <summary>
        /// CEKY.
        /// </summary>
        public const string CEKY = "CEKY";

        /// <summary>
        /// CEDL01.
        /// </summary>
        public const string CEDL01 = "CEDL01";

        /// <summary>
        /// CEDL02.
        /// </summary>
        public const string CEDL02 = "CEDL02";

        /// <summary>
        /// CERATE.
        /// </summary>
        public const string CERATE = "CERATE";
    }

    /// <inheritdoc />
    public override string TableName => "F00191";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CESY", "CESY", JdeDataType.String, 8, true, true),
        new JdeField("CERT", "CERT", JdeDataType.String, 4, true, true),
        new JdeField("CEKY", "CEKY", JdeDataType.String, 20, true, true),
        new JdeField("CEDL01", "CEDL01", JdeDataType.String, 60),
        new JdeField("CEDL02", "CEDL02", JdeDataType.String, 60),
        new JdeField("CERATE", "CERATE", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F00191_0", "Primary Key on CESY, CERT, CEKY", new[] { "CESY", "CERT", "CEKY" }, isUnique: true, isPrimaryKey: true)
    };
}
