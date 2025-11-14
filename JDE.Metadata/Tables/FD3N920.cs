using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FD3N920 - .
/// </summary>
public class FD3N920 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PQGS2A.
        /// </summary>
        public const string PQGS2A = "PQGS2A";

        /// <summary>
        /// PQRCT1.
        /// </summary>
        public const string PQRCT1 = "PQRCT1";

        /// <summary>
        /// PQSE01.
        /// </summary>
        public const string PQSE01 = "PQSE01";

        /// <summary>
        /// PQRNUM.
        /// </summary>
        public const string PQRNUM = "PQRNUM";

        /// <summary>
        /// PQGS2B.
        /// </summary>
        public const string PQGS2B = "PQGS2B";

        /// <summary>
        /// PQCRPT.
        /// </summary>
        public const string PQCRPT = "PQCRPT";

        /// <summary>
        /// PQUFD1.
        /// </summary>
        public const string PQUFD1 = "PQUFD1";

        /// <summary>
        /// PQGS2C.
        /// </summary>
        public const string PQGS2C = "PQGS2C";
    }

    /// <inheritdoc />
    public override string TableName => "FD3N920";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PQGS2A", "PQGS2A", JdeDataType.String, 40, true, true),
        new JdeField("PQRCT1", "PQRCT1", JdeDataType.Numeric, null, true, true),
        new JdeField("PQSE01", "PQSE01", JdeDataType.Numeric),
        new JdeField("PQRNUM", "PQRNUM", JdeDataType.Numeric),
        new JdeField("PQGS2B", "PQGS2B", JdeDataType.String, 40),
        new JdeField("PQCRPT", "PQCRPT", JdeDataType.Numeric),
        new JdeField("PQUFD1", "PQUFD1", JdeDataType.String, 500),
        new JdeField("PQGS2C", "PQGS2C", JdeDataType.String, 40)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FD3N920_0", "Primary Key on PQGS2A, PQRCT1", new[] { "PQGS2A", "PQRCT1" }, isUnique: true, isPrimaryKey: true)
    };
}
