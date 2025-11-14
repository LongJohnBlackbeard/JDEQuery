using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F00422 - .
/// </summary>
public class F00422 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RBUKID.
        /// </summary>
        public const string RBUKID = "RBUKID";

        /// <summary>
        /// RBBASIST.
        /// </summary>
        public const string RBBASIST = "RBBASIST";

        /// <summary>
        /// RBBASISC.
        /// </summary>
        public const string RBBASISC = "RBBASISC";

        /// <summary>
        /// RBDESTC.
        /// </summary>
        public const string RBDESTC = "RBDESTC";

        /// <summary>
        /// RBBASISVS.
        /// </summary>
        public const string RBBASISVS = "RBBASISVS";

        /// <summary>
        /// RBBASISVN.
        /// </summary>
        public const string RBBASISVN = "RBBASISVN";

        /// <summary>
        /// RBASOD.
        /// </summary>
        public const string RBASOD = "RBASOD";

        /// <summary>
        /// RBDESTVS.
        /// </summary>
        public const string RBDESTVS = "RBDESTVS";

        /// <summary>
        /// RBDESTVN.
        /// </summary>
        public const string RBDESTVN = "RBDESTVN";

        /// <summary>
        /// RBDESTT.
        /// </summary>
        public const string RBDESTT = "RBDESTT";

        /// <summary>
        /// RBUSER.
        /// </summary>
        public const string RBUSER = "RBUSER";

        /// <summary>
        /// RBPID.
        /// </summary>
        public const string RBPID = "RBPID";

        /// <summary>
        /// RBJOBN.
        /// </summary>
        public const string RBJOBN = "RBJOBN";

        /// <summary>
        /// RBUPMJ.
        /// </summary>
        public const string RBUPMJ = "RBUPMJ";

        /// <summary>
        /// RBUPMT.
        /// </summary>
        public const string RBUPMT = "RBUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F00422";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RBUKID", "RBUKID", JdeDataType.Numeric),
        new JdeField("RBBASIST", "RBBASIST", JdeDataType.String, 30, true, true),
        new JdeField("RBBASISC", "RBBASISC", JdeDataType.String, 30, true, true),
        new JdeField("RBDESTC", "RBDESTC", JdeDataType.String, 30, true, true),
        new JdeField("RBBASISVS", "RBBASISVS", JdeDataType.String, 80, true, true),
        new JdeField("RBBASISVN", "RBBASISVN", JdeDataType.Numeric, null, true, true),
        new JdeField("RBASOD", "RBASOD", JdeDataType.Numeric, null, true, true),
        new JdeField("RBDESTVS", "RBDESTVS", JdeDataType.String, 80),
        new JdeField("RBDESTVN", "RBDESTVN", JdeDataType.Numeric),
        new JdeField("RBDESTT", "RBDESTT", JdeDataType.String, 30),
        new JdeField("RBUSER", "RBUSER", JdeDataType.String, 20),
        new JdeField("RBPID", "RBPID", JdeDataType.String, 20),
        new JdeField("RBJOBN", "RBJOBN", JdeDataType.String, 20),
        new JdeField("RBUPMJ", "RBUPMJ", JdeDataType.Numeric),
        new JdeField("RBUPMT", "RBUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F00422_0", "Primary Key on RBBASIST, RBBASISC, RBDESTC, RBBASISVS, RBBASISVN, RBASOD", new[] { "RBBASIST", "RBBASISC", "RBDESTC", "RBBASISVS", "RBBASISVN", "RBASOD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F00422_4", "Index on RBUKID", new[] { "RBUKID" }),
        new JdeIndex("F00422_5", "Index on RBBASIST, RBBASISC, RBDESTC, RBBASISVS, SYS_NC00016$", new[] { "RBBASIST", "RBBASISC", "RBDESTC", "RBBASISVS", "SYS_NC00016$" }),
        new JdeIndex("F00422_6", "Index on RBBASIST, RBBASISC, RBDESTC, RBBASISVN, SYS_NC00016$", new[] { "RBBASIST", "RBBASISC", "RBDESTC", "RBBASISVN", "SYS_NC00016$" }),
        new JdeIndex("F00422_7", "Index on RBBASIST, RBBASISC, RBDESTC, SYS_NC00016$", new[] { "RBBASIST", "RBBASISC", "RBDESTC", "SYS_NC00016$" })
    };
}
