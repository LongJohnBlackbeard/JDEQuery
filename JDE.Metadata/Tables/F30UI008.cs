using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F30UI008 - .
/// </summary>
public class F30UI008 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IJJOBS.
        /// </summary>
        public const string IJJOBS = "IJJOBS";

        /// <summary>
        /// IJCTID.
        /// </summary>
        public const string IJCTID = "IJCTID";

        /// <summary>
        /// IJMCU.
        /// </summary>
        public const string IJMCU = "IJMCU";

        /// <summary>
        /// IJITM.
        /// </summary>
        public const string IJITM = "IJITM";

        /// <summary>
        /// IJUM.
        /// </summary>
        public const string IJUM = "IJUM";

        /// <summary>
        /// IJMMCU.
        /// </summary>
        public const string IJMMCU = "IJMMCU";

        /// <summary>
        /// IJUOM.
        /// </summary>
        public const string IJUOM = "IJUOM";

        /// <summary>
        /// IJSTKT.
        /// </summary>
        public const string IJSTKT = "IJSTKT";

        /// <summary>
        /// IJCMCU.
        /// </summary>
        public const string IJCMCU = "IJCMCU";

        /// <summary>
        /// IJUMD0.
        /// </summary>
        public const string IJUMD0 = "IJUMD0";

        /// <summary>
        /// IJPRT1.
        /// </summary>
        public const string IJPRT1 = "IJPRT1";

        /// <summary>
        /// IJLITM.
        /// </summary>
        public const string IJLITM = "IJLITM";

        /// <summary>
        /// IJAITM.
        /// </summary>
        public const string IJAITM = "IJAITM";

        /// <summary>
        /// IJDSC1.
        /// </summary>
        public const string IJDSC1 = "IJDSC1";

        /// <summary>
        /// IJEFFF.
        /// </summary>
        public const string IJEFFF = "IJEFFF";

        /// <summary>
        /// IJEFFT.
        /// </summary>
        public const string IJEFFT = "IJEFFT";

        /// <summary>
        /// IJQNTY.
        /// </summary>
        public const string IJQNTY = "IJQNTY";

        /// <summary>
        /// IJQNTE1.
        /// </summary>
        public const string IJQNTE1 = "IJQNTE1";

        /// <summary>
        /// IJQNTY1.
        /// </summary>
        public const string IJQNTY1 = "IJQNTY1";
    }

    /// <inheritdoc />
    public override string TableName => "F30UI008";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IJJOBS", "IJJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("IJCTID", "IJCTID", JdeDataType.String, 30, true, true),
        new JdeField("IJMCU", "IJMCU", JdeDataType.String, 24, true, true),
        new JdeField("IJITM", "IJITM", JdeDataType.Numeric, null, true, true),
        new JdeField("IJUM", "IJUM", JdeDataType.String, 4, true, true),
        new JdeField("IJMMCU", "IJMMCU", JdeDataType.String, 24),
        new JdeField("IJUOM", "IJUOM", JdeDataType.String, 4),
        new JdeField("IJSTKT", "IJSTKT", JdeDataType.String, 2),
        new JdeField("IJCMCU", "IJCMCU", JdeDataType.String, 24),
        new JdeField("IJUMD0", "IJUMD0", JdeDataType.String, 4),
        new JdeField("IJPRT1", "IJPRT1", JdeDataType.String, 2),
        new JdeField("IJLITM", "IJLITM", JdeDataType.String, 50),
        new JdeField("IJAITM", "IJAITM", JdeDataType.String, 50),
        new JdeField("IJDSC1", "IJDSC1", JdeDataType.String, 60),
        new JdeField("IJEFFF", "IJEFFF", JdeDataType.Numeric),
        new JdeField("IJEFFT", "IJEFFT", JdeDataType.Numeric),
        new JdeField("IJQNTY", "IJQNTY", JdeDataType.Numeric),
        new JdeField("IJQNTE1", "IJQNTE1", JdeDataType.Numeric),
        new JdeField("IJQNTY1", "IJQNTY1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F30UI008_0", "Primary Key on IJJOBS, IJCTID, IJMCU, IJITM, IJUM", new[] { "IJJOBS", "IJCTID", "IJMCU", "IJITM", "IJUM" }, isUnique: true, isPrimaryKey: true)
    };
}
