using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B025 - .
/// </summary>
public class F76B025 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SIB76LECO.
        /// </summary>
        public const string SIB76LECO = "SIB76LECO";

        /// <summary>
        /// SIAN8.
        /// </summary>
        public const string SIAN8 = "SIAN8";

        /// <summary>
        /// SIB76SICO.
        /// </summary>
        public const string SIB76SICO = "SIB76SICO";

        /// <summary>
        /// SIB76IDLR.
        /// </summary>
        public const string SIB76IDLR = "SIB76IDLR";

        /// <summary>
        /// SIUSER.
        /// </summary>
        public const string SIUSER = "SIUSER";

        /// <summary>
        /// SIPID.
        /// </summary>
        public const string SIPID = "SIPID";

        /// <summary>
        /// SIJOBN.
        /// </summary>
        public const string SIJOBN = "SIJOBN";

        /// <summary>
        /// SIUPMJ.
        /// </summary>
        public const string SIUPMJ = "SIUPMJ";

        /// <summary>
        /// SIUPMT.
        /// </summary>
        public const string SIUPMT = "SIUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B025";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SIB76LECO", "SIB76LECO", JdeDataType.String, 10, true, true),
        new JdeField("SIAN8", "SIAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("SIB76SICO", "SIB76SICO", JdeDataType.String, 6),
        new JdeField("SIB76IDLR", "SIB76IDLR", JdeDataType.String, 2),
        new JdeField("SIUSER", "SIUSER", JdeDataType.String, 20),
        new JdeField("SIPID", "SIPID", JdeDataType.String, 20),
        new JdeField("SIJOBN", "SIJOBN", JdeDataType.String, 20),
        new JdeField("SIUPMJ", "SIUPMJ", JdeDataType.Numeric),
        new JdeField("SIUPMT", "SIUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B025_0", "Primary Key on SIB76LECO, SIAN8", new[] { "SIB76LECO", "SIAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
