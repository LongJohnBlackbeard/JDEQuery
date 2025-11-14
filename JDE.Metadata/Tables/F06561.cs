using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06561 - .
/// </summary>
public class F06561 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y9FOA#.
        /// </summary>
        public const string Y9FOA_ = "Y9FOA#";

        /// <summary>
        /// Y9DOCM.
        /// </summary>
        public const string Y9DOCM = "Y9DOCM";

        /// <summary>
        /// Y9NPAY.
        /// </summary>
        public const string Y9NPAY = "Y9NPAY";

        /// <summary>
        /// Y9CKD.
        /// </summary>
        public const string Y9CKD = "Y9CKD";

        /// <summary>
        /// Y9ALPH.
        /// </summary>
        public const string Y9ALPH = "Y9ALPH";

        /// <summary>
        /// Y9ICC.
        /// </summary>
        public const string Y9ICC = "Y9ICC";
    }

    /// <inheritdoc />
    public override string TableName => "F06561";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y9FOA#", "Y9FOA#", JdeDataType.String, 34, true, true),
        new JdeField("Y9DOCM", "Y9DOCM", JdeDataType.Numeric, null, true, true),
        new JdeField("Y9NPAY", "Y9NPAY", JdeDataType.Numeric),
        new JdeField("Y9CKD", "Y9CKD", JdeDataType.Numeric),
        new JdeField("Y9ALPH", "Y9ALPH", JdeDataType.String, 80),
        new JdeField("Y9ICC", "Y9ICC", JdeDataType.String, 2, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06561_0", "Primary Key on Y9FOA#, Y9DOCM, Y9ICC", new[] { "Y9FOA#", "Y9DOCM", "Y9ICC" }, isUnique: true, isPrimaryKey: true)
    };
}
