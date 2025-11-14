using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46029 - .
/// </summary>
public class F46029 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LPSRUL.
        /// </summary>
        public const string LPSRUL = "LPSRUL";

        /// <summary>
        /// LPSEQ.
        /// </summary>
        public const string LPSEQ = "LPSEQ";

        /// <summary>
        /// LPMCU.
        /// </summary>
        public const string LPMCU = "LPMCU";

        /// <summary>
        /// LPLOCN.
        /// </summary>
        public const string LPLOCN = "LPLOCN";

        /// <summary>
        /// LPBSLN.
        /// </summary>
        public const string LPBSLN = "LPBSLN";

        /// <summary>
        /// LPDISN.
        /// </summary>
        public const string LPDISN = "LPDISN";

        /// <summary>
        /// LPWSQP.
        /// </summary>
        public const string LPWSQP = "LPWSQP";

        /// <summary>
        /// LPWSQQ.
        /// </summary>
        public const string LPWSQQ = "LPWSQQ";

        /// <summary>
        /// LPURAT.
        /// </summary>
        public const string LPURAT = "LPURAT";

        /// <summary>
        /// LPURAB.
        /// </summary>
        public const string LPURAB = "LPURAB";

        /// <summary>
        /// LPURRF.
        /// </summary>
        public const string LPURRF = "LPURRF";

        /// <summary>
        /// LPUSER.
        /// </summary>
        public const string LPUSER = "LPUSER";

        /// <summary>
        /// LPPID.
        /// </summary>
        public const string LPPID = "LPPID";

        /// <summary>
        /// LPJOBN.
        /// </summary>
        public const string LPJOBN = "LPJOBN";

        /// <summary>
        /// LPUPMJ.
        /// </summary>
        public const string LPUPMJ = "LPUPMJ";

        /// <summary>
        /// LPTDAY.
        /// </summary>
        public const string LPTDAY = "LPTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F46029";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LPSRUL", "LPSRUL", JdeDataType.String, 12, true, true),
        new JdeField("LPSEQ", "LPSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("LPMCU", "LPMCU", JdeDataType.String, 24, true, true),
        new JdeField("LPLOCN", "LPLOCN", JdeDataType.String, 40, true, true),
        new JdeField("LPBSLN", "LPBSLN", JdeDataType.String, 40, true, true),
        new JdeField("LPDISN", "LPDISN", JdeDataType.Numeric),
        new JdeField("LPWSQP", "LPWSQP", JdeDataType.Numeric),
        new JdeField("LPWSQQ", "LPWSQQ", JdeDataType.Numeric),
        new JdeField("LPURAT", "LPURAT", JdeDataType.Numeric),
        new JdeField("LPURAB", "LPURAB", JdeDataType.Numeric),
        new JdeField("LPURRF", "LPURRF", JdeDataType.String, 30),
        new JdeField("LPUSER", "LPUSER", JdeDataType.String, 20),
        new JdeField("LPPID", "LPPID", JdeDataType.String, 20),
        new JdeField("LPJOBN", "LPJOBN", JdeDataType.String, 20),
        new JdeField("LPUPMJ", "LPUPMJ", JdeDataType.Numeric),
        new JdeField("LPTDAY", "LPTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46029_0", "Primary Key on LPMCU, LPLOCN, LPBSLN, LPSRUL, LPSEQ", new[] { "LPMCU", "LPLOCN", "LPBSLN", "LPSRUL", "LPSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F46029_3", "Index on LPMCU, LPBSLN, LPSRUL, LPSEQ, LPDISN, LPWSQP, LPLOCN", new[] { "LPMCU", "LPBSLN", "LPSRUL", "LPSEQ", "LPDISN", "LPWSQP", "LPLOCN" }),
        new JdeIndex("F46029_4", "Index on LPMCU, LPSRUL", new[] { "LPMCU", "LPSRUL" })
    };
}
