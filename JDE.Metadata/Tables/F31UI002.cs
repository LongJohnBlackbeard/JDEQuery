using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31UI002 - .
/// </summary>
public class F31UI002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IGDOCO.
        /// </summary>
        public const string IGDOCO = "IGDOCO";

        /// <summary>
        /// IGITM.
        /// </summary>
        public const string IGITM = "IGITM";

        /// <summary>
        /// IGPART.
        /// </summary>
        public const string IGPART = "IGPART";

        /// <summary>
        /// IGCOST.
        /// </summary>
        public const string IGCOST = "IGCOST";

        /// <summary>
        /// IGOPUN.
        /// </summary>
        public const string IGOPUN = "IGOPUN";

        /// <summary>
        /// IGOPAT.
        /// </summary>
        public const string IGOPAT = "IGOPAT";

        /// <summary>
        /// IGPLUN.
        /// </summary>
        public const string IGPLUN = "IGPLUN";

        /// <summary>
        /// IGPLAT.
        /// </summary>
        public const string IGPLAT = "IGPLAT";

        /// <summary>
        /// IGCLUN.
        /// </summary>
        public const string IGCLUN = "IGCLUN";

        /// <summary>
        /// IGCLAT.
        /// </summary>
        public const string IGCLAT = "IGCLAT";

        /// <summary>
        /// IGCPUN.
        /// </summary>
        public const string IGCPUN = "IGCPUN";

        /// <summary>
        /// IGCPAT.
        /// </summary>
        public const string IGCPAT = "IGCPAT";

        /// <summary>
        /// IGSLUN.
        /// </summary>
        public const string IGSLUN = "IGSLUN";

        /// <summary>
        /// IGSLAT.
        /// </summary>
        public const string IGSLAT = "IGSLAT";

        /// <summary>
        /// IGSTDC.
        /// </summary>
        public const string IGSTDC = "IGSTDC";

        /// <summary>
        /// IGSOQS.
        /// </summary>
        public const string IGSOQS = "IGSOQS";

        /// <summary>
        /// IGUOM.
        /// </summary>
        public const string IGUOM = "IGUOM";

        /// <summary>
        /// IGJOBS.
        /// </summary>
        public const string IGJOBS = "IGJOBS";

        /// <summary>
        /// IGCPID.
        /// </summary>
        public const string IGCPID = "IGCPID";

        /// <summary>
        /// IGUSER.
        /// </summary>
        public const string IGUSER = "IGUSER";

        /// <summary>
        /// IGCTID.
        /// </summary>
        public const string IGCTID = "IGCTID";
    }

    /// <inheritdoc />
    public override string TableName => "F31UI002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IGDOCO", "IGDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("IGITM", "IGITM", JdeDataType.Numeric, null, true, true),
        new JdeField("IGPART", "IGPART", JdeDataType.String, 2, true, true),
        new JdeField("IGCOST", "IGCOST", JdeDataType.String, 6, true, true),
        new JdeField("IGOPUN", "IGOPUN", JdeDataType.Numeric),
        new JdeField("IGOPAT", "IGOPAT", JdeDataType.Numeric),
        new JdeField("IGPLUN", "IGPLUN", JdeDataType.Numeric),
        new JdeField("IGPLAT", "IGPLAT", JdeDataType.Numeric),
        new JdeField("IGCLUN", "IGCLUN", JdeDataType.Numeric),
        new JdeField("IGCLAT", "IGCLAT", JdeDataType.Numeric),
        new JdeField("IGCPUN", "IGCPUN", JdeDataType.Numeric),
        new JdeField("IGCPAT", "IGCPAT", JdeDataType.Numeric),
        new JdeField("IGSLUN", "IGSLUN", JdeDataType.Numeric),
        new JdeField("IGSLAT", "IGSLAT", JdeDataType.Numeric),
        new JdeField("IGSTDC", "IGSTDC", JdeDataType.Numeric),
        new JdeField("IGSOQS", "IGSOQS", JdeDataType.Numeric),
        new JdeField("IGUOM", "IGUOM", JdeDataType.String, 4),
        new JdeField("IGJOBS", "IGJOBS", JdeDataType.Numeric),
        new JdeField("IGCPID", "IGCPID", JdeDataType.String, 16),
        new JdeField("IGUSER", "IGUSER", JdeDataType.String, 20),
        new JdeField("IGCTID", "IGCTID", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31UI002_0", "Primary Key on IGDOCO, IGITM, IGPART, IGCOST", new[] { "IGDOCO", "IGITM", "IGPART", "IGCOST" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31UI002_2", "Index on IGJOBS", new[] { "IGJOBS" }),
        new JdeIndex("F31UI002_3", "Index on IGDOCO, IGCOST", new[] { "IGDOCO", "IGCOST" })
    };
}
