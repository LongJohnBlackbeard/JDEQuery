using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I811 - .
/// </summary>
public class F75I811 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GRUKID.
        /// </summary>
        public const string GRUKID = "GRUKID";

        /// <summary>
        /// GRI75GSTU.
        /// </summary>
        public const string GRI75GSTU = "GRI75GSTU";

        /// <summary>
        /// GRYMNTH.
        /// </summary>
        public const string GRYMNTH = "GRYMNTH";

        /// <summary>
        /// GRYLYR.
        /// </summary>
        public const string GRYLYR = "GRYLYR";

        /// <summary>
        /// GRYVEROF.
        /// </summary>
        public const string GRYVEROF = "GRYVEROF";

        /// <summary>
        /// GRI75GSTNP.
        /// </summary>
        public const string GRI75GSTNP = "GRI75GSTNP";

        /// <summary>
        /// GRI75GSTDN.
        /// </summary>
        public const string GRI75GSTDN = "GRI75GSTDN";

        /// <summary>
        /// GRUSER.
        /// </summary>
        public const string GRUSER = "GRUSER";

        /// <summary>
        /// GRPID.
        /// </summary>
        public const string GRPID = "GRPID";

        /// <summary>
        /// GRJOBN.
        /// </summary>
        public const string GRJOBN = "GRJOBN";

        /// <summary>
        /// GRUPMJ.
        /// </summary>
        public const string GRUPMJ = "GRUPMJ";

        /// <summary>
        /// GRUPMT.
        /// </summary>
        public const string GRUPMT = "GRUPMT";

        /// <summary>
        /// GRYFUTDT1.
        /// </summary>
        public const string GRYFUTDT1 = "GRYFUTDT1";

        /// <summary>
        /// GRFUT6.
        /// </summary>
        public const string GRFUT6 = "GRFUT6";

        /// <summary>
        /// GRYT04.
        /// </summary>
        public const string GRYT04 = "GRYT04";

        /// <summary>
        /// GRYFLAG.
        /// </summary>
        public const string GRYFLAG = "GRYFLAG";
    }

    /// <inheritdoc />
    public override string TableName => "F75I811";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GRUKID", "GRUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("GRI75GSTU", "GRI75GSTU", JdeDataType.Numeric),
        new JdeField("GRYMNTH", "GRYMNTH", JdeDataType.String, 4),
        new JdeField("GRYLYR", "GRYLYR", JdeDataType.Numeric),
        new JdeField("GRYVEROF", "GRYVEROF", JdeDataType.String, 80),
        new JdeField("GRI75GSTNP", "GRI75GSTNP", JdeDataType.String, 50),
        new JdeField("GRI75GSTDN", "GRI75GSTDN", JdeDataType.String, 30),
        new JdeField("GRUSER", "GRUSER", JdeDataType.String, 20),
        new JdeField("GRPID", "GRPID", JdeDataType.String, 20),
        new JdeField("GRJOBN", "GRJOBN", JdeDataType.String, 20),
        new JdeField("GRUPMJ", "GRUPMJ", JdeDataType.Numeric),
        new JdeField("GRUPMT", "GRUPMT", JdeDataType.Numeric),
        new JdeField("GRYFUTDT1", "GRYFUTDT1", JdeDataType.Numeric),
        new JdeField("GRFUT6", "GRFUT6", JdeDataType.String, 60),
        new JdeField("GRYT04", "GRYT04", JdeDataType.String, 2),
        new JdeField("GRYFLAG", "GRYFLAG", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I811_0", "Primary Key on GRUKID", new[] { "GRUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I811_2", "Unique Index on GRI75GSTU, GRYMNTH, GRYLYR", new[] { "GRI75GSTU", "GRYMNTH", "GRYLYR" }, isUnique: true)
    };
}
