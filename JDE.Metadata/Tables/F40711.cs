using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40711 - .
/// </summary>
public class F40711 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PDPA04.
        /// </summary>
        public const string PDPA04 = "PDPA04";

        /// <summary>
        /// PDRCTY.
        /// </summary>
        public const string PDRCTY = "PDRCTY";

        /// <summary>
        /// PDAPTYPE.
        /// </summary>
        public const string PDAPTYPE = "PDAPTYPE";

        /// <summary>
        /// PDSEQ.
        /// </summary>
        public const string PDSEQ = "PDSEQ";

        /// <summary>
        /// PDDTAI.
        /// </summary>
        public const string PDDTAI = "PDDTAI";

        /// <summary>
        /// PDRQR.
        /// </summary>
        public const string PDRQR = "PDRQR";

        /// <summary>
        /// PDASAI.
        /// </summary>
        public const string PDASAI = "PDASAI";

        /// <summary>
        /// PDDSPOS.
        /// </summary>
        public const string PDDSPOS = "PDDSPOS";

        /// <summary>
        /// PDUSER.
        /// </summary>
        public const string PDUSER = "PDUSER";

        /// <summary>
        /// PDPID.
        /// </summary>
        public const string PDPID = "PDPID";

        /// <summary>
        /// PDJOBN.
        /// </summary>
        public const string PDJOBN = "PDJOBN";

        /// <summary>
        /// PDUPMJ.
        /// </summary>
        public const string PDUPMJ = "PDUPMJ";

        /// <summary>
        /// PDTDAY.
        /// </summary>
        public const string PDTDAY = "PDTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40711";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PDPA04", "PDPA04", JdeDataType.String, 2, true, true),
        new JdeField("PDRCTY", "PDRCTY", JdeDataType.String, 2, true, true),
        new JdeField("PDAPTYPE", "PDAPTYPE", JdeDataType.String, 4, true, true),
        new JdeField("PDSEQ", "PDSEQ", JdeDataType.Numeric),
        new JdeField("PDDTAI", "PDDTAI", JdeDataType.String, 20, true, true),
        new JdeField("PDRQR", "PDRQR", JdeDataType.String, 2),
        new JdeField("PDASAI", "PDASAI", JdeDataType.String, 2),
        new JdeField("PDDSPOS", "PDDSPOS", JdeDataType.Numeric),
        new JdeField("PDUSER", "PDUSER", JdeDataType.String, 20),
        new JdeField("PDPID", "PDPID", JdeDataType.String, 20),
        new JdeField("PDJOBN", "PDJOBN", JdeDataType.String, 20),
        new JdeField("PDUPMJ", "PDUPMJ", JdeDataType.Numeric),
        new JdeField("PDTDAY", "PDTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40711_0", "Primary Key on PDPA04, PDRCTY, PDAPTYPE, PDDTAI", new[] { "PDPA04", "PDRCTY", "PDAPTYPE", "PDDTAI" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40711_2", "Index on PDPA04, PDRCTY, PDAPTYPE, PDSEQ, PDDTAI", new[] { "PDPA04", "PDRCTY", "PDAPTYPE", "PDSEQ", "PDDTAI" })
    };
}
