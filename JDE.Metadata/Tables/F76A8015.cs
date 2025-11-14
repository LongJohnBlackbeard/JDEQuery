using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A8015 - .
/// </summary>
public class F76A8015 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PWAN8.
        /// </summary>
        public const string PWAN8 = "PWAN8";

        /// <summary>
        /// PWKCO.
        /// </summary>
        public const string PWKCO = "PWKCO";

        /// <summary>
        /// PWDCT.
        /// </summary>
        public const string PWDCT = "PWDCT";

        /// <summary>
        /// PWDOC.
        /// </summary>
        public const string PWDOC = "PWDOC";

        /// <summary>
        /// PWAOP.
        /// </summary>
        public const string PWAOP = "PWAOP";
    }

    /// <inheritdoc />
    public override string TableName => "F76A8015";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PWAN8", "PWAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PWKCO", "PWKCO", JdeDataType.String, 10, true, true),
        new JdeField("PWDCT", "PWDCT", JdeDataType.String, 4, true, true),
        new JdeField("PWDOC", "PWDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("PWAOP", "PWAOP", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A8015_0", "Primary Key on PWAN8, PWKCO, PWDCT, PWDOC", new[] { "PWAN8", "PWKCO", "PWDCT", "PWDOC" }, isUnique: true, isPrimaryKey: true)
    };
}
