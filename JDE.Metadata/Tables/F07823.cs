using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07823 - .
/// </summary>
public class F07823 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YFIDYE.
        /// </summary>
        public const string YFIDYE = "YFIDYE";

        /// <summary>
        /// YFDTEY.
        /// </summary>
        public const string YFDTEY = "YFDTEY";

        /// <summary>
        /// YFFRMY.
        /// </summary>
        public const string YFFRMY = "YFFRMY";

        /// <summary>
        /// YFSEQ.
        /// </summary>
        public const string YFSEQ = "YFSEQ";

        /// <summary>
        /// YFRTID.
        /// </summary>
        public const string YFRTID = "YFRTID";

        /// <summary>
        /// YFRTVE.
        /// </summary>
        public const string YFRTVE = "YFRTVE";

        /// <summary>
        /// YFDL01.
        /// </summary>
        public const string YFDL01 = "YFDL01";

        /// <summary>
        /// YFW2P1.
        /// </summary>
        public const string YFW2P1 = "YFW2P1";

        /// <summary>
        /// YFSL.
        /// </summary>
        public const string YFSL = "YFSL";

        /// <summary>
        /// YFUPMJ.
        /// </summary>
        public const string YFUPMJ = "YFUPMJ";

        /// <summary>
        /// YFUPMT.
        /// </summary>
        public const string YFUPMT = "YFUPMT";

        /// <summary>
        /// YFPID.
        /// </summary>
        public const string YFPID = "YFPID";

        /// <summary>
        /// YFJOBN.
        /// </summary>
        public const string YFJOBN = "YFJOBN";

        /// <summary>
        /// YFUSER.
        /// </summary>
        public const string YFUSER = "YFUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F07823";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YFIDYE", "YFIDYE", JdeDataType.String, 20, true, true),
        new JdeField("YFDTEY", "YFDTEY", JdeDataType.Numeric, null, true, true),
        new JdeField("YFFRMY", "YFFRMY", JdeDataType.String, 2, true, true),
        new JdeField("YFSEQ", "YFSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("YFRTID", "YFRTID", JdeDataType.String, 20, true, true),
        new JdeField("YFRTVE", "YFRTVE", JdeDataType.String, 20, true, true),
        new JdeField("YFDL01", "YFDL01", JdeDataType.String, 60),
        new JdeField("YFW2P1", "YFW2P1", JdeDataType.Numeric),
        new JdeField("YFSL", "YFSL", JdeDataType.String, 40),
        new JdeField("YFUPMJ", "YFUPMJ", JdeDataType.Numeric),
        new JdeField("YFUPMT", "YFUPMT", JdeDataType.Numeric),
        new JdeField("YFPID", "YFPID", JdeDataType.String, 20),
        new JdeField("YFJOBN", "YFJOBN", JdeDataType.String, 20),
        new JdeField("YFUSER", "YFUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07823_0", "Primary Key on YFIDYE, YFDTEY, YFFRMY, YFSEQ, YFRTID, YFRTVE", new[] { "YFIDYE", "YFDTEY", "YFFRMY", "YFSEQ", "YFRTID", "YFRTVE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F07823_2", "Index on YFIDYE, YFDTEY, YFFRMY, YFRTID, YFRTVE", new[] { "YFIDYE", "YFDTEY", "YFFRMY", "YFRTID", "YFRTVE" })
    };
}
