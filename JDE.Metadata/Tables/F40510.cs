using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40510 - .
/// </summary>
public class F40510 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UCUNSPSC.
        /// </summary>
        public const string UCUNSPSC = "UCUNSPSC";

        /// <summary>
        /// UCUNSPSCDS.
        /// </summary>
        public const string UCUNSPSCDS = "UCUNSPSCDS";

        /// <summary>
        /// UCDFTUNSP.
        /// </summary>
        public const string UCDFTUNSP = "UCDFTUNSP";

        /// <summary>
        /// UCCMDCDE.
        /// </summary>
        public const string UCCMDCDE = "UCCMDCDE";

        /// <summary>
        /// UCUSER.
        /// </summary>
        public const string UCUSER = "UCUSER";

        /// <summary>
        /// UCPID.
        /// </summary>
        public const string UCPID = "UCPID";

        /// <summary>
        /// UCJOBN.
        /// </summary>
        public const string UCJOBN = "UCJOBN";

        /// <summary>
        /// UCUPMT.
        /// </summary>
        public const string UCUPMT = "UCUPMT";

        /// <summary>
        /// UCUPMJ.
        /// </summary>
        public const string UCUPMJ = "UCUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F40510";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UCUNSPSC", "UCUNSPSC", JdeDataType.String, 16, true, true),
        new JdeField("UCUNSPSCDS", "UCUNSPSCDS", JdeDataType.String, 80),
        new JdeField("UCDFTUNSP", "UCDFTUNSP", JdeDataType.String, 2),
        new JdeField("UCCMDCDE", "UCCMDCDE", JdeDataType.String, 30),
        new JdeField("UCUSER", "UCUSER", JdeDataType.String, 20),
        new JdeField("UCPID", "UCPID", JdeDataType.String, 20),
        new JdeField("UCJOBN", "UCJOBN", JdeDataType.String, 20),
        new JdeField("UCUPMT", "UCUPMT", JdeDataType.Numeric),
        new JdeField("UCUPMJ", "UCUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40510_0", "Primary Key on UCUNSPSC", new[] { "UCUNSPSC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40510_2", "Index on UCCMDCDE, UCDFTUNSP", new[] { "UCCMDCDE", "UCDFTUNSP" })
    };
}
