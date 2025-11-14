using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1305 - .
/// </summary>
public class F1305 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FVCO.
        /// </summary>
        public const string FVCO = "FVCO";

        /// <summary>
        /// FVMCUZ.
        /// </summary>
        public const string FVMCUZ = "FVMCUZ";

        /// <summary>
        /// FVRTGR.
        /// </summary>
        public const string FVRTGR = "FVRTGR";

        /// <summary>
        /// FVNUMB.
        /// </summary>
        public const string FVNUMB = "FVNUMB";

        /// <summary>
        /// FVROS.
        /// </summary>
        public const string FVROS = "FVROS";

        /// <summary>
        /// FVMCU.
        /// </summary>
        public const string FVMCU = "FVMCU";

        /// <summary>
        /// FVOBJ.
        /// </summary>
        public const string FVOBJ = "FVOBJ";

        /// <summary>
        /// FVSUB.
        /// </summary>
        public const string FVSUB = "FVSUB";

        /// <summary>
        /// FVSBL.
        /// </summary>
        public const string FVSBL = "FVSBL";

        /// <summary>
        /// FVSBLT.
        /// </summary>
        public const string FVSBLT = "FVSBLT";
    }

    /// <inheritdoc />
    public override string TableName => "F1305";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FVCO", "FVCO", JdeDataType.String, 10, true, true),
        new JdeField("FVMCUZ", "FVMCUZ", JdeDataType.String, 24, true, true),
        new JdeField("FVRTGR", "FVRTGR", JdeDataType.String, 6, true, true),
        new JdeField("FVNUMB", "FVNUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("FVROS", "FVROS", JdeDataType.String, 2),
        new JdeField("FVMCU", "FVMCU", JdeDataType.String, 24),
        new JdeField("FVOBJ", "FVOBJ", JdeDataType.String, 12),
        new JdeField("FVSUB", "FVSUB", JdeDataType.String, 16),
        new JdeField("FVSBL", "FVSBL", JdeDataType.String, 16),
        new JdeField("FVSBLT", "FVSBLT", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1305_0", "Primary Key on FVCO, FVMCUZ, FVRTGR, FVNUMB", new[] { "FVCO", "FVMCUZ", "FVRTGR", "FVNUMB" }, isUnique: true, isPrimaryKey: true)
    };
}
