using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F00421 - .
/// </summary>
public class F00421 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RSBASIST.
        /// </summary>
        public const string RSBASIST = "RSBASIST";

        /// <summary>
        /// RSASOD.
        /// </summary>
        public const string RSASOD = "RSASOD";

        /// <summary>
        /// RSBASISC.
        /// </summary>
        public const string RSBASISC = "RSBASISC";

        /// <summary>
        /// RSDESTC.
        /// </summary>
        public const string RSDESTC = "RSDESTC";

        /// <summary>
        /// RSSEQLN.
        /// </summary>
        public const string RSSEQLN = "RSSEQLN";

        /// <summary>
        /// RSENFORCE.
        /// </summary>
        public const string RSENFORCE = "RSENFORCE";

        /// <summary>
        /// RSDESC.
        /// </summary>
        public const string RSDESC = "RSDESC";

        /// <summary>
        /// RSDESTT.
        /// </summary>
        public const string RSDESTT = "RSDESTT";

        /// <summary>
        /// RSUKID.
        /// </summary>
        public const string RSUKID = "RSUKID";

        /// <summary>
        /// RSUSER.
        /// </summary>
        public const string RSUSER = "RSUSER";

        /// <summary>
        /// RSPID.
        /// </summary>
        public const string RSPID = "RSPID";

        /// <summary>
        /// RSJOBN.
        /// </summary>
        public const string RSJOBN = "RSJOBN";

        /// <summary>
        /// RSUPMJ.
        /// </summary>
        public const string RSUPMJ = "RSUPMJ";

        /// <summary>
        /// RSUPMT.
        /// </summary>
        public const string RSUPMT = "RSUPMT";

        /// <summary>
        /// RSBLANKA.
        /// </summary>
        public const string RSBLANKA = "RSBLANKA";
    }

    /// <inheritdoc />
    public override string TableName => "F00421";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RSBASIST", "RSBASIST", JdeDataType.String, 30, true, true),
        new JdeField("RSASOD", "RSASOD", JdeDataType.Numeric, null, true, true),
        new JdeField("RSBASISC", "RSBASISC", JdeDataType.String, 30, true, true),
        new JdeField("RSDESTC", "RSDESTC", JdeDataType.String, 30, true, true),
        new JdeField("RSSEQLN", "RSSEQLN", JdeDataType.Numeric),
        new JdeField("RSENFORCE", "RSENFORCE", JdeDataType.String, 2),
        new JdeField("RSDESC", "RSDESC", JdeDataType.String, 60),
        new JdeField("RSDESTT", "RSDESTT", JdeDataType.String, 30),
        new JdeField("RSUKID", "RSUKID", JdeDataType.Numeric),
        new JdeField("RSUSER", "RSUSER", JdeDataType.String, 20),
        new JdeField("RSPID", "RSPID", JdeDataType.String, 20),
        new JdeField("RSJOBN", "RSJOBN", JdeDataType.String, 20),
        new JdeField("RSUPMJ", "RSUPMJ", JdeDataType.Numeric),
        new JdeField("RSUPMT", "RSUPMT", JdeDataType.Numeric),
        new JdeField("RSBLANKA", "RSBLANKA", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F00421_0", "Primary Key on RSBASIST, RSASOD, RSBASISC, RSDESTC", new[] { "RSBASIST", "RSASOD", "RSBASISC", "RSDESTC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F00421_3", "Unique Index on RSUKID", new[] { "RSUKID" }, isUnique: true),
        new JdeIndex("F00421_4", "Index on RSBASIST, SYS_NC00016$, RSSEQLN", new[] { "RSBASIST", "SYS_NC00016$", "RSSEQLN" })
    };
}
