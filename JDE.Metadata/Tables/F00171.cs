using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F00171 - .
/// </summary>
public class F00171 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NCDTD.
        /// </summary>
        public const string NCDTD = "NCDTD";

        /// <summary>
        /// NCALPH.
        /// </summary>
        public const string NCALPH = "NCALPH";

        /// <summary>
        /// NCUPMJ.
        /// </summary>
        public const string NCUPMJ = "NCUPMJ";

        /// <summary>
        /// NCTDAY.
        /// </summary>
        public const string NCTDAY = "NCTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F00171";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NCDTD", "NCDTD", JdeDataType.String, 6, true, true),
        new JdeField("NCALPH", "NCALPH", JdeDataType.String, 80),
        new JdeField("NCUPMJ", "NCUPMJ", JdeDataType.Numeric),
        new JdeField("NCTDAY", "NCTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F00171_0", "Primary Key on NCDTD", new[] { "NCDTD" }, isUnique: true, isPrimaryKey: true)
    };
}
