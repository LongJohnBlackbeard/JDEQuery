using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I845 - .
/// </summary>
public class F75I845 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SCUKID.
        /// </summary>
        public const string SCUKID = "SCUKID";

        /// <summary>
        /// SCADDS.
        /// </summary>
        public const string SCADDS = "SCADDS";

        /// <summary>
        /// SCI75IPOS.
        /// </summary>
        public const string SCI75IPOS = "SCI75IPOS";

        /// <summary>
        /// SCDL01.
        /// </summary>
        public const string SCDL01 = "SCDL01";

        /// <summary>
        /// SCUSER.
        /// </summary>
        public const string SCUSER = "SCUSER";

        /// <summary>
        /// SCPID.
        /// </summary>
        public const string SCPID = "SCPID";

        /// <summary>
        /// SCJOBN.
        /// </summary>
        public const string SCJOBN = "SCJOBN";

        /// <summary>
        /// SCUPMJ.
        /// </summary>
        public const string SCUPMJ = "SCUPMJ";

        /// <summary>
        /// SCUPMT.
        /// </summary>
        public const string SCUPMT = "SCUPMT";

        /// <summary>
        /// SCYFUTDT1.
        /// </summary>
        public const string SCYFUTDT1 = "SCYFUTDT1";

        /// <summary>
        /// SCFUT6.
        /// </summary>
        public const string SCFUT6 = "SCFUT6";

        /// <summary>
        /// SCYT04.
        /// </summary>
        public const string SCYT04 = "SCYT04";

        /// <summary>
        /// SCYFLAG.
        /// </summary>
        public const string SCYFLAG = "SCYFLAG";
    }

    /// <inheritdoc />
    public override string TableName => "F75I845";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SCUKID", "SCUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("SCADDS", "SCADDS", JdeDataType.String, 6),
        new JdeField("SCI75IPOS", "SCI75IPOS", JdeDataType.String, 4),
        new JdeField("SCDL01", "SCDL01", JdeDataType.String, 60),
        new JdeField("SCUSER", "SCUSER", JdeDataType.String, 20),
        new JdeField("SCPID", "SCPID", JdeDataType.String, 20),
        new JdeField("SCJOBN", "SCJOBN", JdeDataType.String, 20),
        new JdeField("SCUPMJ", "SCUPMJ", JdeDataType.Numeric),
        new JdeField("SCUPMT", "SCUPMT", JdeDataType.Numeric),
        new JdeField("SCYFUTDT1", "SCYFUTDT1", JdeDataType.Numeric),
        new JdeField("SCFUT6", "SCFUT6", JdeDataType.String, 60),
        new JdeField("SCYT04", "SCYT04", JdeDataType.String, 2),
        new JdeField("SCYFLAG", "SCYFLAG", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I845_0", "Primary Key on SCUKID", new[] { "SCUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I845_2", "Index on SCADDS", new[] { "SCADDS" })
    };
}
