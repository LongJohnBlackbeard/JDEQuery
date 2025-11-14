using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A15 - .
/// </summary>
public class F76A15 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TETXA1.
        /// </summary>
        public const string TETXA1 = "TETXA1";

        /// <summary>
        /// TEKCO.
        /// </summary>
        public const string TEKCO = "TEKCO";

        /// <summary>
        /// TEMCU.
        /// </summary>
        public const string TEMCU = "TEMCU";

        /// <summary>
        /// TEEFTJ.
        /// </summary>
        public const string TEEFTJ = "TEEFTJ";

        /// <summary>
        /// TEEFDJ.
        /// </summary>
        public const string TEEFDJ = "TEEFDJ";
    }

    /// <inheritdoc />
    public override string TableName => "F76A15";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TETXA1", "TETXA1", JdeDataType.String, 20, true, true),
        new JdeField("TEKCO", "TEKCO", JdeDataType.String, 10, true, true),
        new JdeField("TEMCU", "TEMCU", JdeDataType.String, 24, true, true),
        new JdeField("TEEFTJ", "TEEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("TEEFDJ", "TEEFDJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A15_0", "Primary Key on TETXA1, TEKCO, TEMCU, TEEFTJ", new[] { "TETXA1", "TEKCO", "TEMCU", "TEEFTJ" }, isUnique: true, isPrimaryKey: true)
    };
}
