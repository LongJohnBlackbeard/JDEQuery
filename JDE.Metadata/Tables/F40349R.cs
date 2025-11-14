using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40349R - .
/// </summary>
public class F40349R : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RVUKID.
        /// </summary>
        public const string RVUKID = "RVUKID";

        /// <summary>
        /// RVREFC.
        /// </summary>
        public const string RVREFC = "RVREFC";

        /// <summary>
        /// RVAN8.
        /// </summary>
        public const string RVAN8 = "RVAN8";

        /// <summary>
        /// RVCS49.
        /// </summary>
        public const string RVCS49 = "RVCS49";

        /// <summary>
        /// RVITM.
        /// </summary>
        public const string RVITM = "RVITM";

        /// <summary>
        /// RVIT49.
        /// </summary>
        public const string RVIT49 = "RVIT49";

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

        /// <summary>
        /// RVSLSM.
        /// </summary>
        public const string RVSLSM = "RVSLSM";

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
    }

    /// <inheritdoc />
    public override string TableName => "F40349R";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RVUKID", "RVUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("RVREFC", "RVREFC", JdeDataType.Numeric),
        new JdeField("RVAN8", "RVAN8", JdeDataType.Numeric),
        new JdeField("RVCS49", "RVCS49", JdeDataType.String, 16),
        new JdeField("RVITM", "RVITM", JdeDataType.Numeric),
        new JdeField("RVIT49", "RVIT49", JdeDataType.String, 16),
        new JdeField("RVEFTJ", "RVEFTJ", JdeDataType.Numeric),
        new JdeField("RVEXDJ", "RVEXDJ", JdeDataType.Numeric),
        new JdeField("RVMNQ", "RVMNQ", JdeDataType.Numeric),
        new JdeField("RVMXQ", "RVMXQ", JdeDataType.Numeric),
        new JdeField("RVUOM", "RVUOM", JdeDataType.String, 4),
        new JdeField("RVTXID", "RVTXID", JdeDataType.Numeric),
        new JdeField("RVSTPR", "RVSTPR", JdeDataType.String, 2),
        new JdeField("RVOSEQ", "RVOSEQ", JdeDataType.Numeric),
        new JdeField("RVMCU", "RVMCU", JdeDataType.String, 24),
        new JdeField("RVLOB", "RVLOB", JdeDataType.String, 6),
        new JdeField("RVSLSM", "RVSLSM", JdeDataType.Numeric),
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
        new JdeField("RVTDAY", "RVTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40349R_0", "Primary Key on RVUKID", new[] { "RVUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40349R_2", "Index on RVAN8, RVCS49, RVITM, RVIT49, RVEXDJ, RVMXQ, RVUOM, RVEMCU, RVUPMJ, RVTDAY", new[] { "RVAN8", "RVCS49", "RVITM", "RVIT49", "RVEXDJ", "RVMXQ", "RVUOM", "RVEMCU", "RVUPMJ", "RVTDAY" })
    };
}
