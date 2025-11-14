using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76C1201 - .
/// </summary>
public class F76C1201 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ACCO.
        /// </summary>
        public const string ACCO = "ACCO";

        /// <summary>
        /// ACAMCU.
        /// </summary>
        public const string ACAMCU = "ACAMCU";

        /// <summary>
        /// ACAOBJ.
        /// </summary>
        public const string ACAOBJ = "ACAOBJ";

        /// <summary>
        /// ACASUB.
        /// </summary>
        public const string ACASUB = "ACASUB";

        /// <summary>
        /// ACMCU.
        /// </summary>
        public const string ACMCU = "ACMCU";

        /// <summary>
        /// ACOBJ.
        /// </summary>
        public const string ACOBJ = "ACOBJ";

        /// <summary>
        /// ACSUB.
        /// </summary>
        public const string ACSUB = "ACSUB";

        /// <summary>
        /// ACMCU2.
        /// </summary>
        public const string ACMCU2 = "ACMCU2";

        /// <summary>
        /// ACDOBJ.
        /// </summary>
        public const string ACDOBJ = "ACDOBJ";

        /// <summary>
        /// ACDSUB.
        /// </summary>
        public const string ACDSUB = "ACDSUB";
    }

    /// <inheritdoc />
    public override string TableName => "F76C1201";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ACCO", "ACCO", JdeDataType.String, 10, true, true),
        new JdeField("ACAMCU", "ACAMCU", JdeDataType.String, 24, true, true),
        new JdeField("ACAOBJ", "ACAOBJ", JdeDataType.String, 12, true, true),
        new JdeField("ACASUB", "ACASUB", JdeDataType.String, 16, true, true),
        new JdeField("ACMCU", "ACMCU", JdeDataType.String, 24),
        new JdeField("ACOBJ", "ACOBJ", JdeDataType.String, 12),
        new JdeField("ACSUB", "ACSUB", JdeDataType.String, 16),
        new JdeField("ACMCU2", "ACMCU2", JdeDataType.String, 24),
        new JdeField("ACDOBJ", "ACDOBJ", JdeDataType.String, 12),
        new JdeField("ACDSUB", "ACDSUB", JdeDataType.String, 16)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76C1201_0", "Primary Key on ACCO, ACAMCU, ACAOBJ, ACASUB", new[] { "ACCO", "ACAMCU", "ACAOBJ", "ACASUB" }, isUnique: true, isPrimaryKey: true)
    };
}
