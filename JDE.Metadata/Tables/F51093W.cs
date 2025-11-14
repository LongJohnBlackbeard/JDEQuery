using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F51093W - .
/// </summary>
public class F51093W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PAGENKEY.
        /// </summary>
        public const string PAGENKEY = "PAGENKEY";

        /// <summary>
        /// PAMCU.
        /// </summary>
        public const string PAMCU = "PAMCU";

        /// <summary>
        /// PADL01.
        /// </summary>
        public const string PADL01 = "PADL01";

        /// <summary>
        /// PAUSER.
        /// </summary>
        public const string PAUSER = "PAUSER";

        /// <summary>
        /// PAJOBN.
        /// </summary>
        public const string PAJOBN = "PAJOBN";

        /// <summary>
        /// PAUPMJ.
        /// </summary>
        public const string PAUPMJ = "PAUPMJ";

        /// <summary>
        /// PAUPMT.
        /// </summary>
        public const string PAUPMT = "PAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F51093W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PAGENKEY", "PAGENKEY", JdeDataType.String, 80, true, true),
        new JdeField("PAMCU", "PAMCU", JdeDataType.String, 24, true, true),
        new JdeField("PADL01", "PADL01", JdeDataType.String, 60),
        new JdeField("PAUSER", "PAUSER", JdeDataType.String, 20),
        new JdeField("PAJOBN", "PAJOBN", JdeDataType.String, 20),
        new JdeField("PAUPMJ", "PAUPMJ", JdeDataType.Numeric),
        new JdeField("PAUPMT", "PAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F51093W_0", "Primary Key on PAGENKEY, PAMCU", new[] { "PAGENKEY", "PAMCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F51093W_2", "Index on PAGENKEY", new[] { "PAGENKEY" })
    };
}
