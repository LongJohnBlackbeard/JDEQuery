using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B015 - .
/// </summary>
public class F76B015 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LSB76LECO.
        /// </summary>
        public const string LSB76LECO = "LSB76LECO";

        /// <summary>
        /// LSCO.
        /// </summary>
        public const string LSCO = "LSCO";

        /// <summary>
        /// LSB76PARF.
        /// </summary>
        public const string LSB76PARF = "LSB76PARF";

        /// <summary>
        /// LSB76CORE.
        /// </summary>
        public const string LSB76CORE = "LSB76CORE";

        /// <summary>
        /// LSB76CORF.
        /// </summary>
        public const string LSB76CORF = "LSB76CORF";

        /// <summary>
        /// LSB76CORT.
        /// </summary>
        public const string LSB76CORT = "LSB76CORT";

        /// <summary>
        /// LSB76AN8C.
        /// </summary>
        public const string LSB76AN8C = "LSB76AN8C";

        /// <summary>
        /// LSUSER.
        /// </summary>
        public const string LSUSER = "LSUSER";

        /// <summary>
        /// LSPID.
        /// </summary>
        public const string LSPID = "LSPID";

        /// <summary>
        /// LSJOBN.
        /// </summary>
        public const string LSJOBN = "LSJOBN";

        /// <summary>
        /// LSUPMJ.
        /// </summary>
        public const string LSUPMJ = "LSUPMJ";

        /// <summary>
        /// LSUPMT.
        /// </summary>
        public const string LSUPMT = "LSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B015";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LSB76LECO", "LSB76LECO", JdeDataType.String, 10, true, true),
        new JdeField("LSCO", "LSCO", JdeDataType.String, 10, true, true),
        new JdeField("LSB76PARF", "LSB76PARF", JdeDataType.String, 2),
        new JdeField("LSB76CORE", "LSB76CORE", JdeDataType.String, 8),
        new JdeField("LSB76CORF", "LSB76CORF", JdeDataType.Numeric),
        new JdeField("LSB76CORT", "LSB76CORT", JdeDataType.Numeric),
        new JdeField("LSB76AN8C", "LSB76AN8C", JdeDataType.Numeric),
        new JdeField("LSUSER", "LSUSER", JdeDataType.String, 20),
        new JdeField("LSPID", "LSPID", JdeDataType.String, 20),
        new JdeField("LSJOBN", "LSJOBN", JdeDataType.String, 20),
        new JdeField("LSUPMJ", "LSUPMJ", JdeDataType.Numeric),
        new JdeField("LSUPMT", "LSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B015_0", "Primary Key on LSB76LECO, LSCO", new[] { "LSB76LECO", "LSCO" }, isUnique: true, isPrimaryKey: true)
    };
}
