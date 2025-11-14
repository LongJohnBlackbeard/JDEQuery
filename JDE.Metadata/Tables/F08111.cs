using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08111 - .
/// </summary>
public class F08111 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HQMCU.
        /// </summary>
        public const string HQMCU = "HQMCU";

        /// <summary>
        /// HQPOS.
        /// </summary>
        public const string HQPOS = "HQPOS";

        /// <summary>
        /// HQAN8.
        /// </summary>
        public const string HQAN8 = "HQAN8";

        /// <summary>
        /// HQEFTS.
        /// </summary>
        public const string HQEFTS = "HQEFTS";

        /// <summary>
        /// HQEFST.
        /// </summary>
        public const string HQEFST = "HQEFST";

        /// <summary>
        /// HQACTT.
        /// </summary>
        public const string HQACTT = "HQACTT";

        /// <summary>
        /// HQREQN.
        /// </summary>
        public const string HQREQN = "HQREQN";

        /// <summary>
        /// HQJBCD.
        /// </summary>
        public const string HQJBCD = "HQJBCD";

        /// <summary>
        /// HQJBST.
        /// </summary>
        public const string HQJBST = "HQJBST";

        /// <summary>
        /// HQSAL.
        /// </summary>
        public const string HQSAL = "HQSAL";

        /// <summary>
        /// HQFTE.
        /// </summary>
        public const string HQFTE = "HQFTE";

        /// <summary>
        /// HQHRW.
        /// </summary>
        public const string HQHRW = "HQHRW";

        /// <summary>
        /// HQRMK.
        /// </summary>
        public const string HQRMK = "HQRMK";

        /// <summary>
        /// HQTYB.
        /// </summary>
        public const string HQTYB = "HQTYB";

        /// <summary>
        /// HQUSER.
        /// </summary>
        public const string HQUSER = "HQUSER";

        /// <summary>
        /// HQPID.
        /// </summary>
        public const string HQPID = "HQPID";

        /// <summary>
        /// HQUPMJ.
        /// </summary>
        public const string HQUPMJ = "HQUPMJ";

        /// <summary>
        /// HQJOBN.
        /// </summary>
        public const string HQJOBN = "HQJOBN";

        /// <summary>
        /// HQHMCU.
        /// </summary>
        public const string HQHMCU = "HQHMCU";

        /// <summary>
        /// HQTMDY.
        /// </summary>
        public const string HQTMDY = "HQTMDY";
    }

    /// <inheritdoc />
    public override string TableName => "F08111";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HQMCU", "HQMCU", JdeDataType.String, 24),
        new JdeField("HQPOS", "HQPOS", JdeDataType.String, 16, true, true),
        new JdeField("HQAN8", "HQAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("HQEFTS", "HQEFTS", JdeDataType.Numeric, null, true, true),
        new JdeField("HQEFST", "HQEFST", JdeDataType.Numeric),
        new JdeField("HQACTT", "HQACTT", JdeDataType.String, 2),
        new JdeField("HQREQN", "HQREQN", JdeDataType.Numeric),
        new JdeField("HQJBCD", "HQJBCD", JdeDataType.String, 12),
        new JdeField("HQJBST", "HQJBST", JdeDataType.String, 8),
        new JdeField("HQSAL", "HQSAL", JdeDataType.Numeric),
        new JdeField("HQFTE", "HQFTE", JdeDataType.Numeric),
        new JdeField("HQHRW", "HQHRW", JdeDataType.Numeric),
        new JdeField("HQRMK", "HQRMK", JdeDataType.String, 60),
        new JdeField("HQTYB", "HQTYB", JdeDataType.String, 8),
        new JdeField("HQUSER", "HQUSER", JdeDataType.String, 20),
        new JdeField("HQPID", "HQPID", JdeDataType.String, 20),
        new JdeField("HQUPMJ", "HQUPMJ", JdeDataType.Numeric),
        new JdeField("HQJOBN", "HQJOBN", JdeDataType.String, 20),
        new JdeField("HQHMCU", "HQHMCU", JdeDataType.String, 24, true, true),
        new JdeField("HQTMDY", "HQTMDY", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08111_0", "Primary Key on HQHMCU, HQPOS, HQAN8, HQEFTS, HQTMDY", new[] { "HQHMCU", "HQPOS", "HQAN8", "HQEFTS", "HQTMDY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08111_10", "Index on HQAN8, HQEFTS, HQACTT", new[] { "HQAN8", "HQEFTS", "HQACTT" }),
        new JdeIndex("F08111_11", "Index on HQACTT, HQAN8, SYS_NC00021$", new[] { "HQACTT", "HQAN8", "SYS_NC00021$" }),
        new JdeIndex("F08111_2", "Index on HQAN8, SYS_NC00021$, SYS_NC00022$", new[] { "HQAN8", "SYS_NC00021$", "SYS_NC00022$" }),
        new JdeIndex("F08111_3", "Index on HQPOS, SYS_NC00021$, SYS_NC00022$", new[] { "HQPOS", "SYS_NC00021$", "SYS_NC00022$" }),
        new JdeIndex("F08111_6", "Index on HQHMCU, HQPOS, HQACTT, HQEFTS, HQTMDY", new[] { "HQHMCU", "HQPOS", "HQACTT", "HQEFTS", "HQTMDY" }),
        new JdeIndex("F08111_7", "Index on HQPOS, HQHMCU, HQAN8", new[] { "HQPOS", "HQHMCU", "HQAN8" }),
        new JdeIndex("F08111_8", "Index on HQHMCU, HQPOS, HQEFTS", new[] { "HQHMCU", "HQPOS", "HQEFTS" }),
        new JdeIndex("F08111_9", "Index on HQHMCU, HQPOS, HQAN8, HQACTT", new[] { "HQHMCU", "HQPOS", "HQAN8", "HQACTT" })
    };
}
