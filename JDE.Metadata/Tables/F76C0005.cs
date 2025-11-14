using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76C0005 - .
/// </summary>
public class F76C0005 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TXTXA1.
        /// </summary>
        public const string TXTXA1 = "TXTXA1";

        /// <summary>
        /// TX76CTX1.
        /// </summary>
        public const string TX76CTX1 = "TX76CTX1";

        /// <summary>
        /// TX76CTX2.
        /// </summary>
        public const string TX76CTX2 = "TX76CTX2";

        /// <summary>
        /// TXUSER.
        /// </summary>
        public const string TXUSER = "TXUSER";

        /// <summary>
        /// TXPID.
        /// </summary>
        public const string TXPID = "TXPID";

        /// <summary>
        /// TXJOBN.
        /// </summary>
        public const string TXJOBN = "TXJOBN";

        /// <summary>
        /// TXUPMJ.
        /// </summary>
        public const string TXUPMJ = "TXUPMJ";

        /// <summary>
        /// TXUPMT.
        /// </summary>
        public const string TXUPMT = "TXUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76C0005";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TXTXA1", "TXTXA1", JdeDataType.String, 20, true, true),
        new JdeField("TX76CTX1", "TX76CTX1", JdeDataType.String, 20, true, true),
        new JdeField("TX76CTX2", "TX76CTX2", JdeDataType.String, 20),
        new JdeField("TXUSER", "TXUSER", JdeDataType.String, 20),
        new JdeField("TXPID", "TXPID", JdeDataType.String, 20),
        new JdeField("TXJOBN", "TXJOBN", JdeDataType.String, 20),
        new JdeField("TXUPMJ", "TXUPMJ", JdeDataType.Numeric),
        new JdeField("TXUPMT", "TXUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76C0005_0", "Primary Key on TXTXA1, TX76CTX1", new[] { "TXTXA1", "TX76CTX1" }, isUnique: true, isPrimaryKey: true)
    };
}
