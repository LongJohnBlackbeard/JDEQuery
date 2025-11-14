using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A8030 - .
/// </summary>
public class F76A8030 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MTATXC.
        /// </summary>
        public const string MTATXC = "MTATXC";

        /// <summary>
        /// MTEFTJ.
        /// </summary>
        public const string MTEFTJ = "MTEFTJ";

        /// <summary>
        /// MTEFDJ.
        /// </summary>
        public const string MTEFDJ = "MTEFDJ";

        /// <summary>
        /// MTAMIA.
        /// </summary>
        public const string MTAMIA = "MTAMIA";

        /// <summary>
        /// MTEV01.
        /// </summary>
        public const string MTEV01 = "MTEV01";

        /// <summary>
        /// MTEV02.
        /// </summary>
        public const string MTEV02 = "MTEV02";

        /// <summary>
        /// MTEV03.
        /// </summary>
        public const string MTEV03 = "MTEV03";

        /// <summary>
        /// MTMATH01.
        /// </summary>
        public const string MTMATH01 = "MTMATH01";

        /// <summary>
        /// MTMATH02.
        /// </summary>
        public const string MTMATH02 = "MTMATH02";

        /// <summary>
        /// MTMATH03.
        /// </summary>
        public const string MTMATH03 = "MTMATH03";

        /// <summary>
        /// MTURDT.
        /// </summary>
        public const string MTURDT = "MTURDT";

        /// <summary>
        /// MTURDAT01.
        /// </summary>
        public const string MTURDAT01 = "MTURDAT01";

        /// <summary>
        /// MTURDAT02.
        /// </summary>
        public const string MTURDAT02 = "MTURDAT02";

        /// <summary>
        /// MTUSER.
        /// </summary>
        public const string MTUSER = "MTUSER";

        /// <summary>
        /// MTPID.
        /// </summary>
        public const string MTPID = "MTPID";

        /// <summary>
        /// MTTDAY.
        /// </summary>
        public const string MTTDAY = "MTTDAY";

        /// <summary>
        /// MTUPMT.
        /// </summary>
        public const string MTUPMT = "MTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76A8030";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MTATXC", "MTATXC", JdeDataType.String, 20, true, true),
        new JdeField("MTEFTJ", "MTEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("MTEFDJ", "MTEFDJ", JdeDataType.Numeric),
        new JdeField("MTAMIA", "MTAMIA", JdeDataType.Numeric),
        new JdeField("MTEV01", "MTEV01", JdeDataType.String, 2),
        new JdeField("MTEV02", "MTEV02", JdeDataType.String, 2),
        new JdeField("MTEV03", "MTEV03", JdeDataType.String, 2),
        new JdeField("MTMATH01", "MTMATH01", JdeDataType.Numeric),
        new JdeField("MTMATH02", "MTMATH02", JdeDataType.Numeric),
        new JdeField("MTMATH03", "MTMATH03", JdeDataType.Numeric),
        new JdeField("MTURDT", "MTURDT", JdeDataType.Numeric),
        new JdeField("MTURDAT01", "MTURDAT01", JdeDataType.Numeric),
        new JdeField("MTURDAT02", "MTURDAT02", JdeDataType.Numeric),
        new JdeField("MTUSER", "MTUSER", JdeDataType.String, 20),
        new JdeField("MTPID", "MTPID", JdeDataType.String, 20),
        new JdeField("MTTDAY", "MTTDAY", JdeDataType.Numeric),
        new JdeField("MTUPMT", "MTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A8030_0", "Primary Key on MTATXC, MTEFTJ", new[] { "MTATXC", "MTEFTJ" }, isUnique: true, isPrimaryKey: true)
    };
}
