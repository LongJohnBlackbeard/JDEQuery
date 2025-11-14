using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40332 - .
/// </summary>
public class F40332 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CFAN8.
        /// </summary>
        public const string CFAN8 = "CFAN8";

        /// <summary>
        /// CFCS32.
        /// </summary>
        public const string CFCS32 = "CFCS32";

        /// <summary>
        /// CFITM.
        /// </summary>
        public const string CFITM = "CFITM";

        /// <summary>
        /// CFIT82.
        /// </summary>
        public const string CFIT82 = "CFIT82";

        /// <summary>
        /// CFEFTJ.
        /// </summary>
        public const string CFEFTJ = "CFEFTJ";

        /// <summary>
        /// CFEXDJ.
        /// </summary>
        public const string CFEXDJ = "CFEXDJ";

        /// <summary>
        /// CFMNQ.
        /// </summary>
        public const string CFMNQ = "CFMNQ";

        /// <summary>
        /// CFMXQ.
        /// </summary>
        public const string CFMXQ = "CFMXQ";

        /// <summary>
        /// CFUOM.
        /// </summary>
        public const string CFUOM = "CFUOM";

        /// <summary>
        /// CFTXID.
        /// </summary>
        public const string CFTXID = "CFTXID";

        /// <summary>
        /// CFSTPR.
        /// </summary>
        public const string CFSTPR = "CFSTPR";

        /// <summary>
        /// CFOSEQ.
        /// </summary>
        public const string CFOSEQ = "CFOSEQ";

        /// <summary>
        /// CFMCU.
        /// </summary>
        public const string CFMCU = "CFMCU";

        /// <summary>
        /// CFAEXP.
        /// </summary>
        public const string CFAEXP = "CFAEXP";

        /// <summary>
        /// CFAEXT.
        /// </summary>
        public const string CFAEXT = "CFAEXT";

        /// <summary>
        /// CFCRCD.
        /// </summary>
        public const string CFCRCD = "CFCRCD";

        /// <summary>
        /// CFFRSC.
        /// </summary>
        public const string CFFRSC = "CFFRSC";

        /// <summary>
        /// CFFRTH.
        /// </summary>
        public const string CFFRTH = "CFFRTH";

        /// <summary>
        /// CFRSLT.
        /// </summary>
        public const string CFRSLT = "CFRSLT";

        /// <summary>
        /// CFBFSD.
        /// </summary>
        public const string CFBFSD = "CFBFSD";

        /// <summary>
        /// CFDSTN.
        /// </summary>
        public const string CFDSTN = "CFDSTN";

        /// <summary>
        /// CFUMD1.
        /// </summary>
        public const string CFUMD1 = "CFUMD1";

        /// <summary>
        /// CFURCD.
        /// </summary>
        public const string CFURCD = "CFURCD";

        /// <summary>
        /// CFURDT.
        /// </summary>
        public const string CFURDT = "CFURDT";

        /// <summary>
        /// CFURAT.
        /// </summary>
        public const string CFURAT = "CFURAT";

        /// <summary>
        /// CFURAB.
        /// </summary>
        public const string CFURAB = "CFURAB";

        /// <summary>
        /// CFURRF.
        /// </summary>
        public const string CFURRF = "CFURRF";

        /// <summary>
        /// CFUSER.
        /// </summary>
        public const string CFUSER = "CFUSER";

        /// <summary>
        /// CFPID.
        /// </summary>
        public const string CFPID = "CFPID";

        /// <summary>
        /// CFJOBN.
        /// </summary>
        public const string CFJOBN = "CFJOBN";

        /// <summary>
        /// CFUPMJ.
        /// </summary>
        public const string CFUPMJ = "CFUPMJ";

        /// <summary>
        /// CFTDAY.
        /// </summary>
        public const string CFTDAY = "CFTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40332";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CFAN8", "CFAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CFCS32", "CFCS32", JdeDataType.String, 16, true, true),
        new JdeField("CFITM", "CFITM", JdeDataType.Numeric, null, true, true),
        new JdeField("CFIT82", "CFIT82", JdeDataType.String, 16, true, true),
        new JdeField("CFEFTJ", "CFEFTJ", JdeDataType.Numeric),
        new JdeField("CFEXDJ", "CFEXDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("CFMNQ", "CFMNQ", JdeDataType.Numeric),
        new JdeField("CFMXQ", "CFMXQ", JdeDataType.Numeric, null, true, true),
        new JdeField("CFUOM", "CFUOM", JdeDataType.String, 4, true, true),
        new JdeField("CFTXID", "CFTXID", JdeDataType.Numeric),
        new JdeField("CFSTPR", "CFSTPR", JdeDataType.String, 2),
        new JdeField("CFOSEQ", "CFOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("CFMCU", "CFMCU", JdeDataType.String, 24),
        new JdeField("CFAEXP", "CFAEXP", JdeDataType.Numeric),
        new JdeField("CFAEXT", "CFAEXT", JdeDataType.Numeric),
        new JdeField("CFCRCD", "CFCRCD", JdeDataType.String, 6),
        new JdeField("CFFRSC", "CFFRSC", JdeDataType.String, 16),
        new JdeField("CFFRTH", "CFFRTH", JdeDataType.String, 6),
        new JdeField("CFRSLT", "CFRSLT", JdeDataType.String, 2),
        new JdeField("CFBFSD", "CFBFSD", JdeDataType.String, 2),
        new JdeField("CFDSTN", "CFDSTN", JdeDataType.Numeric),
        new JdeField("CFUMD1", "CFUMD1", JdeDataType.String, 4),
        new JdeField("CFURCD", "CFURCD", JdeDataType.String, 4),
        new JdeField("CFURDT", "CFURDT", JdeDataType.Numeric),
        new JdeField("CFURAT", "CFURAT", JdeDataType.Numeric),
        new JdeField("CFURAB", "CFURAB", JdeDataType.Numeric),
        new JdeField("CFURRF", "CFURRF", JdeDataType.String, 30),
        new JdeField("CFUSER", "CFUSER", JdeDataType.String, 20),
        new JdeField("CFPID", "CFPID", JdeDataType.String, 20),
        new JdeField("CFJOBN", "CFJOBN", JdeDataType.String, 20),
        new JdeField("CFUPMJ", "CFUPMJ", JdeDataType.Numeric),
        new JdeField("CFTDAY", "CFTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40332_0", "Primary Key on CFAN8, CFCS32, CFITM, CFIT82, CFEXDJ, CFUOM, CFMXQ, CFOSEQ", new[] { "CFAN8", "CFCS32", "CFITM", "CFIT82", "CFEXDJ", "CFUOM", "CFMXQ", "CFOSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
