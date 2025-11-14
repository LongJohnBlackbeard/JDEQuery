using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FD3N120W - .
/// </summary>
public class FD3N120W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FANUMB.
        /// </summary>
        public const string FANUMB = "FANUMB";

        /// <summary>
        /// FAAPID.
        /// </summary>
        public const string FAAPID = "FAAPID";

        /// <summary>
        /// FALOC.
        /// </summary>
        public const string FALOC = "FALOC";

        /// <summary>
        /// FAARCQ.
        /// </summary>
        public const string FAARCQ = "FAARCQ";

        /// <summary>
        /// FAUSER.
        /// </summary>
        public const string FAUSER = "FAUSER";

        /// <summary>
        /// FAPID.
        /// </summary>
        public const string FAPID = "FAPID";

        /// <summary>
        /// FADEV.
        /// </summary>
        public const string FADEV = "FADEV";

        /// <summary>
        /// FADTE.
        /// </summary>
        public const string FADTE = "FADTE";

        /// <summary>
        /// FATME0.
        /// </summary>
        public const string FATME0 = "FATME0";
    }

    /// <inheritdoc />
    public override string TableName => "FD3N120W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FANUMB", "FANUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("FAAPID", "FAAPID", JdeDataType.String, 24),
        new JdeField("FALOC", "FALOC", JdeDataType.String, 24),
        new JdeField("FAARCQ", "FAARCQ", JdeDataType.Numeric),
        new JdeField("FAUSER", "FAUSER", JdeDataType.String, 20),
        new JdeField("FAPID", "FAPID", JdeDataType.String, 20),
        new JdeField("FADEV", "FADEV", JdeDataType.String, 20),
        new JdeField("FADTE", "FADTE", JdeDataType.Numeric),
        new JdeField("FATME0", "FATME0", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FD3N120W_0", "Primary Key on FANUMB", new[] { "FANUMB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FD3N120W_2", "Index on FAAPID, FALOC, FAUSER", new[] { "FAAPID", "FALOC", "FAUSER" })
    };
}
