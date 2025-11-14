using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FD3N925 - .
/// </summary>
public class FD3N925 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EHGS2A.
        /// </summary>
        public const string EHGS2A = "EHGS2A";

        /// <summary>
        /// EHRCT1.
        /// </summary>
        public const string EHRCT1 = "EHRCT1";

        /// <summary>
        /// EHSE01.
        /// </summary>
        public const string EHSE01 = "EHSE01";

        /// <summary>
        /// EHRNUM.
        /// </summary>
        public const string EHRNUM = "EHRNUM";

        /// <summary>
        /// EHGS2B.
        /// </summary>
        public const string EHGS2B = "EHGS2B";

        /// <summary>
        /// EHCRPT.
        /// </summary>
        public const string EHCRPT = "EHCRPT";

        /// <summary>
        /// EHUFD1.
        /// </summary>
        public const string EHUFD1 = "EHUFD1";

        /// <summary>
        /// EHUFD2.
        /// </summary>
        public const string EHUFD2 = "EHUFD2";
    }

    /// <inheritdoc />
    public override string TableName => "FD3N925";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EHGS2A", "EHGS2A", JdeDataType.String, 40, true, true),
        new JdeField("EHRCT1", "EHRCT1", JdeDataType.Numeric, null, true, true),
        new JdeField("EHSE01", "EHSE01", JdeDataType.Numeric),
        new JdeField("EHRNUM", "EHRNUM", JdeDataType.Numeric),
        new JdeField("EHGS2B", "EHGS2B", JdeDataType.String, 40),
        new JdeField("EHCRPT", "EHCRPT", JdeDataType.Numeric),
        new JdeField("EHUFD1", "EHUFD1", JdeDataType.String, 500),
        new JdeField("EHUFD2", "EHUFD2", JdeDataType.String, 500)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FD3N925_0", "Primary Key on EHGS2A, EHRCT1", new[] { "EHGS2A", "EHRCT1" }, isUnique: true, isPrimaryKey: true)
    };
}
