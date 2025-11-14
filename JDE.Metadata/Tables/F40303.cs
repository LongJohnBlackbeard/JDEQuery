using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40303 - .
/// </summary>
public class F40303 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RVAN8.
        /// </summary>
        public const string RVAN8 = "RVAN8";

        /// <summary>
        /// RVCS03.
        /// </summary>
        public const string RVCS03 = "RVCS03";

        /// <summary>
        /// RVITM.
        /// </summary>
        public const string RVITM = "RVITM";

        /// <summary>
        /// RVIT03.
        /// </summary>
        public const string RVIT03 = "RVIT03";

        /// <summary>
        /// RVEFTJ.
        /// </summary>
        public const string RVEFTJ = "RVEFTJ";

        /// <summary>
        /// RVEXDJ.
        /// </summary>
        public const string RVEXDJ = "RVEXDJ";

        /// <summary>
        /// RVMNQ.
        /// </summary>
        public const string RVMNQ = "RVMNQ";

        /// <summary>
        /// RVMXQ.
        /// </summary>
        public const string RVMXQ = "RVMXQ";

        /// <summary>
        /// RVUOM.
        /// </summary>
        public const string RVUOM = "RVUOM";

        /// <summary>
        /// RVTXID.
        /// </summary>
        public const string RVTXID = "RVTXID";

        /// <summary>
        /// RVSTPR.
        /// </summary>
        public const string RVSTPR = "RVSTPR";

        /// <summary>
        /// RVEMCU.
        /// </summary>
        public const string RVEMCU = "RVEMCU";

        /// <summary>
        /// RVURCD.
        /// </summary>
        public const string RVURCD = "RVURCD";

        /// <summary>
        /// RVURDT.
        /// </summary>
        public const string RVURDT = "RVURDT";

        /// <summary>
        /// RVURAT.
        /// </summary>
        public const string RVURAT = "RVURAT";

        /// <summary>
        /// RVURAB.
        /// </summary>
        public const string RVURAB = "RVURAB";

        /// <summary>
        /// RVURRF.
        /// </summary>
        public const string RVURRF = "RVURRF";

        /// <summary>
        /// RVUSER.
        /// </summary>
        public const string RVUSER = "RVUSER";

        /// <summary>
        /// RVPID.
        /// </summary>
        public const string RVPID = "RVPID";

        /// <summary>
        /// RVJOBN.
        /// </summary>
        public const string RVJOBN = "RVJOBN";

        /// <summary>
        /// RVUPMJ.
        /// </summary>
        public const string RVUPMJ = "RVUPMJ";

        /// <summary>
        /// RVTDAY.
        /// </summary>
        public const string RVTDAY = "RVTDAY";

        /// <summary>
        /// RVSLSM.
        /// </summary>
        public const string RVSLSM = "RVSLSM";

        /// <summary>
        /// RVOSEQ.
        /// </summary>
        public const string RVOSEQ = "RVOSEQ";

        /// <summary>
        /// RVMCU.
        /// </summary>
        public const string RVMCU = "RVMCU";

        /// <summary>
        /// RVLOB.
        /// </summary>
        public const string RVLOB = "RVLOB";
    }

    /// <inheritdoc />
    public override string TableName => "F40303";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RVAN8", "RVAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("RVCS03", "RVCS03", JdeDataType.String, 16, true, true),
        new JdeField("RVITM", "RVITM", JdeDataType.Numeric, null, true, true),
        new JdeField("RVIT03", "RVIT03", JdeDataType.String, 16, true, true),
        new JdeField("RVEFTJ", "RVEFTJ", JdeDataType.Numeric),
        new JdeField("RVEXDJ", "RVEXDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("RVMNQ", "RVMNQ", JdeDataType.Numeric),
        new JdeField("RVMXQ", "RVMXQ", JdeDataType.Numeric, null, true, true),
        new JdeField("RVUOM", "RVUOM", JdeDataType.String, 4, true, true),
        new JdeField("RVTXID", "RVTXID", JdeDataType.Numeric),
        new JdeField("RVSTPR", "RVSTPR", JdeDataType.String, 2),
        new JdeField("RVEMCU", "RVEMCU", JdeDataType.String, 24),
        new JdeField("RVURCD", "RVURCD", JdeDataType.String, 4),
        new JdeField("RVURDT", "RVURDT", JdeDataType.Numeric),
        new JdeField("RVURAT", "RVURAT", JdeDataType.Numeric),
        new JdeField("RVURAB", "RVURAB", JdeDataType.Numeric),
        new JdeField("RVURRF", "RVURRF", JdeDataType.String, 30),
        new JdeField("RVUSER", "RVUSER", JdeDataType.String, 20),
        new JdeField("RVPID", "RVPID", JdeDataType.String, 20),
        new JdeField("RVJOBN", "RVJOBN", JdeDataType.String, 20),
        new JdeField("RVUPMJ", "RVUPMJ", JdeDataType.Numeric),
        new JdeField("RVTDAY", "RVTDAY", JdeDataType.Numeric),
        new JdeField("RVSLSM", "RVSLSM", JdeDataType.Numeric),
        new JdeField("RVOSEQ", "RVOSEQ", JdeDataType.Numeric),
        new JdeField("RVMCU", "RVMCU", JdeDataType.String, 24),
        new JdeField("RVLOB", "RVLOB", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40303_0", "Primary Key on RVAN8, RVCS03, RVITM, RVIT03, RVEXDJ, RVUOM, RVMXQ", new[] { "RVAN8", "RVCS03", "RVITM", "RVIT03", "RVEXDJ", "RVUOM", "RVMXQ" }, isUnique: true, isPrimaryKey: true)
    };
}
