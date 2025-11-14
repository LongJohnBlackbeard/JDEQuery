using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40095 - .
/// </summary>
public class F40095 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DLTERM.
        /// </summary>
        public const string DLTERM = "DLTERM";

        /// <summary>
        /// DLMCU.
        /// </summary>
        public const string DLMCU = "DLMCU";

        /// <summary>
        /// DLPPSQ.
        /// </summary>
        public const string DLPPSQ = "DLPPSQ";

        /// <summary>
        /// DLPIVQ.
        /// </summary>
        public const string DLPIVQ = "DLPIVQ";

        /// <summary>
        /// DLPPOQ.
        /// </summary>
        public const string DLPPOQ = "DLPPOQ";

        /// <summary>
        /// DLARTG.
        /// </summary>
        public const string DLARTG = "DLARTG";

        /// <summary>
        /// DLBLMCU.
        /// </summary>
        public const string DLBLMCU = "DLBLMCU";

        /// <summary>
        /// DLGRMCU.
        /// </summary>
        public const string DLGRMCU = "DLGRMCU";
    }

    /// <inheritdoc />
    public override string TableName => "F40095";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DLTERM", "DLTERM", JdeDataType.String, 20, true, true),
        new JdeField("DLMCU", "DLMCU", JdeDataType.String, 24),
        new JdeField("DLPPSQ", "DLPPSQ", JdeDataType.String, 20),
        new JdeField("DLPIVQ", "DLPIVQ", JdeDataType.String, 20),
        new JdeField("DLPPOQ", "DLPPOQ", JdeDataType.String, 20),
        new JdeField("DLARTG", "DLARTG", JdeDataType.String, 24),
        new JdeField("DLBLMCU", "DLBLMCU", JdeDataType.String, 24),
        new JdeField("DLGRMCU", "DLGRMCU", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40095_0", "Primary Key on DLTERM", new[] { "DLTERM" }, isUnique: true, isPrimaryKey: true)
    };
}
