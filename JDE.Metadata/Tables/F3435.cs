using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3435 - .
/// </summary>
public class F3435 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MCITM.
        /// </summary>
        public const string MCITM = "MCITM";

        /// <summary>
        /// MCMCU.
        /// </summary>
        public const string MCMCU = "MCMCU";

        /// <summary>
        /// MCDOCO.
        /// </summary>
        public const string MCDOCO = "MCDOCO";

        /// <summary>
        /// MCDCTO.
        /// </summary>
        public const string MCDCTO = "MCDCTO";

        /// <summary>
        /// MCKCOO.
        /// </summary>
        public const string MCKCOO = "MCKCOO";

        /// <summary>
        /// MCSFXO.
        /// </summary>
        public const string MCSFXO = "MCSFXO";

        /// <summary>
        /// MCLNID.
        /// </summary>
        public const string MCLNID = "MCLNID";

        /// <summary>
        /// MCSTRT.
        /// </summary>
        public const string MCSTRT = "MCSTRT";

        /// <summary>
        /// MCAN8.
        /// </summary>
        public const string MCAN8 = "MCAN8";

        /// <summary>
        /// MCCMQTY.
        /// </summary>
        public const string MCCMQTY = "MCCMQTY";

        /// <summary>
        /// MCGENQJ.
        /// </summary>
        public const string MCGENQJ = "MCGENQJ";

        /// <summary>
        /// MCVENQJ.
        /// </summary>
        public const string MCVENQJ = "MCVENQJ";

        /// <summary>
        /// MCALSH.
        /// </summary>
        public const string MCALSH = "MCALSH";

        /// <summary>
        /// MCALDC.
        /// </summary>
        public const string MCALDC = "MCALDC";

        /// <summary>
        /// MCALNC.
        /// </summary>
        public const string MCALNC = "MCALNC";

        /// <summary>
        /// MCALQC.
        /// </summary>
        public const string MCALQC = "MCALQC";

        /// <summary>
        /// MCEDDT.
        /// </summary>
        public const string MCEDDT = "MCEDDT";

        /// <summary>
        /// MCURC1.
        /// </summary>
        public const string MCURC1 = "MCURC1";

        /// <summary>
        /// MCURDT.
        /// </summary>
        public const string MCURDT = "MCURDT";

        /// <summary>
        /// MCURAB.
        /// </summary>
        public const string MCURAB = "MCURAB";

        /// <summary>
        /// MCURAT.
        /// </summary>
        public const string MCURAT = "MCURAT";

        /// <summary>
        /// MCURRF.
        /// </summary>
        public const string MCURRF = "MCURRF";

        /// <summary>
        /// MCUSER.
        /// </summary>
        public const string MCUSER = "MCUSER";

        /// <summary>
        /// MCPID.
        /// </summary>
        public const string MCPID = "MCPID";

        /// <summary>
        /// MCWRKSTNID.
        /// </summary>
        public const string MCWRKSTNID = "MCWRKSTNID";

        /// <summary>
        /// MCUPMJ.
        /// </summary>
        public const string MCUPMJ = "MCUPMJ";

        /// <summary>
        /// MCTDAY.
        /// </summary>
        public const string MCTDAY = "MCTDAY";

        /// <summary>
        /// MCPMPN.
        /// </summary>
        public const string MCPMPN = "MCPMPN";

        /// <summary>
        /// MCPNS.
        /// </summary>
        public const string MCPNS = "MCPNS";
    }

    /// <inheritdoc />
    public override string TableName => "F3435";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MCITM", "MCITM", JdeDataType.Numeric),
        new JdeField("MCMCU", "MCMCU", JdeDataType.String, 24),
        new JdeField("MCDOCO", "MCDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("MCDCTO", "MCDCTO", JdeDataType.String, 4, true, true),
        new JdeField("MCKCOO", "MCKCOO", JdeDataType.String, 10, true, true),
        new JdeField("MCSFXO", "MCSFXO", JdeDataType.String, 6, true, true),
        new JdeField("MCLNID", "MCLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("MCSTRT", "MCSTRT", JdeDataType.Numeric, null, true, true),
        new JdeField("MCAN8", "MCAN8", JdeDataType.Numeric),
        new JdeField("MCCMQTY", "MCCMQTY", JdeDataType.Numeric),
        new JdeField("MCGENQJ", "MCGENQJ", JdeDataType.Numeric),
        new JdeField("MCVENQJ", "MCVENQJ", JdeDataType.Numeric),
        new JdeField("MCALSH", "MCALSH", JdeDataType.String, 2),
        new JdeField("MCALDC", "MCALDC", JdeDataType.String, 2),
        new JdeField("MCALNC", "MCALNC", JdeDataType.String, 2),
        new JdeField("MCALQC", "MCALQC", JdeDataType.String, 2),
        new JdeField("MCEDDT", "MCEDDT", JdeDataType.Numeric),
        new JdeField("MCURC1", "MCURC1", JdeDataType.String, 6),
        new JdeField("MCURDT", "MCURDT", JdeDataType.Numeric),
        new JdeField("MCURAB", "MCURAB", JdeDataType.Numeric),
        new JdeField("MCURAT", "MCURAT", JdeDataType.Numeric),
        new JdeField("MCURRF", "MCURRF", JdeDataType.String, 30),
        new JdeField("MCUSER", "MCUSER", JdeDataType.String, 20),
        new JdeField("MCPID", "MCPID", JdeDataType.String, 20),
        new JdeField("MCWRKSTNID", "MCWRKSTNID", JdeDataType.String, 20),
        new JdeField("MCUPMJ", "MCUPMJ", JdeDataType.Numeric),
        new JdeField("MCTDAY", "MCTDAY", JdeDataType.Numeric),
        new JdeField("MCPMPN", "MCPMPN", JdeDataType.String, 60),
        new JdeField("MCPNS", "MCPNS", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3435_0", "Primary Key on MCDOCO, MCDCTO, MCKCOO, MCSFXO, MCLNID, MCSTRT", new[] { "MCDOCO", "MCDCTO", "MCKCOO", "MCSFXO", "MCLNID", "MCSTRT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3435_2", "Index on MCITM, MCMCU, MCDOCO, MCDCTO, MCKCOO, MCSFXO, MCLNID, MCSTRT", new[] { "MCITM", "MCMCU", "MCDOCO", "MCDCTO", "MCKCOO", "MCSFXO", "MCLNID", "MCSTRT" })
    };
}
