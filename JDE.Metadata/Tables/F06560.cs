using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06560 - .
/// </summary>
public class F06560 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y8FOA#.
        /// </summary>
        public const string Y8FOA_ = "Y8FOA#";

        /// <summary>
        /// Y8DOCM.
        /// </summary>
        public const string Y8DOCM = "Y8DOCM";

        /// <summary>
        /// Y8NPAY.
        /// </summary>
        public const string Y8NPAY = "Y8NPAY";

        /// <summary>
        /// Y8CKD.
        /// </summary>
        public const string Y8CKD = "Y8CKD";

        /// <summary>
        /// Y8ALPH.
        /// </summary>
        public const string Y8ALPH = "Y8ALPH";

        /// <summary>
        /// Y8ICC.
        /// </summary>
        public const string Y8ICC = "Y8ICC";
    }

    /// <inheritdoc />
    public override string TableName => "F06560";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y8FOA#", "Y8FOA#", JdeDataType.String, 34, true, true),
        new JdeField("Y8DOCM", "Y8DOCM", JdeDataType.Numeric, null, true, true),
        new JdeField("Y8NPAY", "Y8NPAY", JdeDataType.Numeric),
        new JdeField("Y8CKD", "Y8CKD", JdeDataType.Numeric),
        new JdeField("Y8ALPH", "Y8ALPH", JdeDataType.String, 80),
        new JdeField("Y8ICC", "Y8ICC", JdeDataType.String, 2, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06560_0", "Primary Key on Y8FOA#, Y8DOCM, Y8ICC", new[] { "Y8FOA#", "Y8DOCM", "Y8ICC" }, isUnique: true, isPrimaryKey: true)
    };
}
