using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A8002 - .
/// </summary>
public class F76A8002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// V3TAX.
        /// </summary>
        public const string V3TAX = "V3TAX";

        /// <summary>
        /// V3ALPH.
        /// </summary>
        public const string V3ALPH = "V3ALPH";

        /// <summary>
        /// V3ADD1.
        /// </summary>
        public const string V3ADD1 = "V3ADD1";

        /// <summary>
        /// V3CTY1.
        /// </summary>
        public const string V3CTY1 = "V3CTY1";

        /// <summary>
        /// V3ADDS.
        /// </summary>
        public const string V3ADDS = "V3ADDS";

        /// <summary>
        /// V3ADDZ.
        /// </summary>
        public const string V3ADDZ = "V3ADDZ";

        /// <summary>
        /// V3ADCT.
        /// </summary>
        public const string V3ADCT = "V3ADCT";

        /// <summary>
        /// V3AN8.
        /// </summary>
        public const string V3AN8 = "V3AN8";

        /// <summary>
        /// V3URCD.
        /// </summary>
        public const string V3URCD = "V3URCD";

        /// <summary>
        /// V3URDT.
        /// </summary>
        public const string V3URDT = "V3URDT";

        /// <summary>
        /// V3URAT.
        /// </summary>
        public const string V3URAT = "V3URAT";

        /// <summary>
        /// V3URAB.
        /// </summary>
        public const string V3URAB = "V3URAB";

        /// <summary>
        /// V3URRF.
        /// </summary>
        public const string V3URRF = "V3URRF";
    }

    /// <inheritdoc />
    public override string TableName => "F76A8002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("V3TAX", "V3TAX", JdeDataType.String, 40, true, true),
        new JdeField("V3ALPH", "V3ALPH", JdeDataType.String, 80),
        new JdeField("V3ADD1", "V3ADD1", JdeDataType.String, 80),
        new JdeField("V3CTY1", "V3CTY1", JdeDataType.String, 50),
        new JdeField("V3ADDS", "V3ADDS", JdeDataType.String, 6),
        new JdeField("V3ADDZ", "V3ADDZ", JdeDataType.String, 24),
        new JdeField("V3ADCT", "V3ADCT", JdeDataType.String, 6),
        new JdeField("V3AN8", "V3AN8", JdeDataType.Numeric),
        new JdeField("V3URCD", "V3URCD", JdeDataType.String, 4),
        new JdeField("V3URDT", "V3URDT", JdeDataType.Numeric),
        new JdeField("V3URAT", "V3URAT", JdeDataType.Numeric),
        new JdeField("V3URAB", "V3URAB", JdeDataType.Numeric),
        new JdeField("V3URRF", "V3URRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A8002_0", "Primary Key on V3TAX", new[] { "V3TAX" }, isUnique: true, isPrimaryKey: true)
    };
}
