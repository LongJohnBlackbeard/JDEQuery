using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F760081A - .
/// </summary>
public class F760081A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// V6DGM.
        /// </summary>
        public const string V6DGM = "V6DGM";

        /// <summary>
        /// V6DGD.
        /// </summary>
        public const string V6DGD = "V6DGD";

        /// <summary>
        /// V6DI#.
        /// </summary>
        public const string V6DI_ = "V6DI#";

        /// <summary>
        /// V6DGY.
        /// </summary>
        public const string V6DGY = "V6DGY";

        /// <summary>
        /// V6ALGC.
        /// </summary>
        public const string V6ALGC = "V6ALGC";

        /// <summary>
        /// V6ADCT.
        /// </summary>
        public const string V6ADCT = "V6ADCT";

        /// <summary>
        /// V6TAX.
        /// </summary>
        public const string V6TAX = "V6TAX";

        /// <summary>
        /// V6AG.
        /// </summary>
        public const string V6AG = "V6AG";

        /// <summary>
        /// V6RP1.
        /// </summary>
        public const string V6RP1 = "V6RP1";
    }

    /// <inheritdoc />
    public override string TableName => "F760081A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("V6DGM", "V6DGM", JdeDataType.Numeric, null, true, true),
        new JdeField("V6DGD", "V6DGD", JdeDataType.Numeric, null, true, true),
        new JdeField("V6DI#", "V6DI#", JdeDataType.Numeric, null, true, true),
        new JdeField("V6DGY", "V6DGY", JdeDataType.Numeric, null, true, true),
        new JdeField("V6ALGC", "V6ALGC", JdeDataType.String, 6, true, true),
        new JdeField("V6ADCT", "V6ADCT", JdeDataType.String, 6, true, true),
        new JdeField("V6TAX", "V6TAX", JdeDataType.String, 40, true, true),
        new JdeField("V6AG", "V6AG", JdeDataType.Numeric),
        new JdeField("V6RP1", "V6RP1", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F760081A_0", "Primary Key on V6DGM, V6DGD, V6DI#, V6DGY, V6ALGC, V6ADCT, V6TAX", new[] { "V6DGM", "V6DGD", "V6DI#", "V6DGY", "V6ALGC", "V6ADCT", "V6TAX" }, isUnique: true, isPrimaryKey: true)
    };
}
