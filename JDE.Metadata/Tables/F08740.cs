using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08740 - .
/// </summary>
public class F08740 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MRANPA.
        /// </summary>
        public const string MRANPA = "MRANPA";

        /// <summary>
        /// MRLSTN.
        /// </summary>
        public const string MRLSTN = "MRLSTN";

        /// <summary>
        /// MRCATID.
        /// </summary>
        public const string MRCATID = "MRCATID";

        /// <summary>
        /// MRRPTSEQ.
        /// </summary>
        public const string MRRPTSEQ = "MRRPTSEQ";

        /// <summary>
        /// MROBNM.
        /// </summary>
        public const string MROBNM = "MROBNM";

        /// <summary>
        /// MRVERS.
        /// </summary>
        public const string MRVERS = "MRVERS";

        /// <summary>
        /// MRDSS.
        /// </summary>
        public const string MRDSS = "MRDSS";

        /// <summary>
        /// MRRSEL.
        /// </summary>
        public const string MRRSEL = "MRRSEL";

        /// <summary>
        /// MRUPMJ.
        /// </summary>
        public const string MRUPMJ = "MRUPMJ";

        /// <summary>
        /// MRUPMT.
        /// </summary>
        public const string MRUPMT = "MRUPMT";

        /// <summary>
        /// MRUSER.
        /// </summary>
        public const string MRUSER = "MRUSER";

        /// <summary>
        /// MRPID.
        /// </summary>
        public const string MRPID = "MRPID";

        /// <summary>
        /// MRJOBN.
        /// </summary>
        public const string MRJOBN = "MRJOBN";

        /// <summary>
        /// MRMRDESC.
        /// </summary>
        public const string MRMRDESC = "MRMRDESC";
    }

    /// <inheritdoc />
    public override string TableName => "F08740";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MRANPA", "MRANPA", JdeDataType.Numeric, null, true, true),
        new JdeField("MRLSTN", "MRLSTN", JdeDataType.String, 40, true, true),
        new JdeField("MRCATID", "MRCATID", JdeDataType.String, 8, true, true),
        new JdeField("MRRPTSEQ", "MRRPTSEQ", JdeDataType.Numeric),
        new JdeField("MROBNM", "MROBNM", JdeDataType.String, 20, true, true),
        new JdeField("MRVERS", "MRVERS", JdeDataType.String, 20, true, true),
        new JdeField("MRDSS", "MRDSS", JdeDataType.String, 1000),
        new JdeField("MRRSEL", "MRRSEL", JdeDataType.String, 2),
        new JdeField("MRUPMJ", "MRUPMJ", JdeDataType.Numeric),
        new JdeField("MRUPMT", "MRUPMT", JdeDataType.Numeric),
        new JdeField("MRUSER", "MRUSER", JdeDataType.String, 20),
        new JdeField("MRPID", "MRPID", JdeDataType.String, 20),
        new JdeField("MRJOBN", "MRJOBN", JdeDataType.String, 20),
        new JdeField("MRMRDESC", "MRMRDESC", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08740_0", "Primary Key on MRANPA, MRLSTN, MROBNM, MRCATID, MRVERS", new[] { "MRANPA", "MRLSTN", "MROBNM", "MRCATID", "MRVERS" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08740_2", "Index on MRANPA, MRLSTN, MRRPTSEQ", new[] { "MRANPA", "MRLSTN", "MRRPTSEQ" }),
        new JdeIndex("F08740_3", "Index on MRANPA, MRLSTN, MRCATID, MROBNM", new[] { "MRANPA", "MRLSTN", "MRCATID", "MROBNM" })
    };
}
