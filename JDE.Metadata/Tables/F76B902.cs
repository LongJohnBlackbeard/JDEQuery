using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B902 - .
/// </summary>
public class F76B902 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BCUKID.
        /// </summary>
        public const string BCUKID = "BCUKID";

        /// <summary>
        /// BCDGJ.
        /// </summary>
        public const string BCDGJ = "BCDGJ";

        /// <summary>
        /// BCMCU.
        /// </summary>
        public const string BCMCU = "BCMCU";

        /// <summary>
        /// BCOBJ.
        /// </summary>
        public const string BCOBJ = "BCOBJ";

        /// <summary>
        /// BCSUB.
        /// </summary>
        public const string BCSUB = "BCSUB";

        /// <summary>
        /// BCSBL.
        /// </summary>
        public const string BCSBL = "BCSBL";

        /// <summary>
        /// BCSBLT.
        /// </summary>
        public const string BCSBLT = "BCSBLT";

        /// <summary>
        /// BCBGBL.
        /// </summary>
        public const string BCBGBL = "BCBGBL";

        /// <summary>
        /// BCCDC1.
        /// </summary>
        public const string BCCDC1 = "BCCDC1";

        /// <summary>
        /// BCTDEB.
        /// </summary>
        public const string BCTDEB = "BCTDEB";

        /// <summary>
        /// BCTCRE.
        /// </summary>
        public const string BCTCRE = "BCTCRE";

        /// <summary>
        /// BCENBL.
        /// </summary>
        public const string BCENBL = "BCENBL";

        /// <summary>
        /// BCCDC2.
        /// </summary>
        public const string BCCDC2 = "BCCDC2";

        /// <summary>
        /// BCCO.
        /// </summary>
        public const string BCCO = "BCCO";

        /// <summary>
        /// BCLT.
        /// </summary>
        public const string BCLT = "BCLT";

        /// <summary>
        /// BCRDOR.
        /// </summary>
        public const string BCRDOR = "BCRDOR";

        /// <summary>
        /// BCTORG.
        /// </summary>
        public const string BCTORG = "BCTORG";

        /// <summary>
        /// BCUSER.
        /// </summary>
        public const string BCUSER = "BCUSER";

        /// <summary>
        /// BCPID.
        /// </summary>
        public const string BCPID = "BCPID";

        /// <summary>
        /// BCJOBN.
        /// </summary>
        public const string BCJOBN = "BCJOBN";

        /// <summary>
        /// BCUPMJ.
        /// </summary>
        public const string BCUPMJ = "BCUPMJ";

        /// <summary>
        /// BCUPMT.
        /// </summary>
        public const string BCUPMT = "BCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B902";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BCUKID", "BCUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("BCDGJ", "BCDGJ", JdeDataType.Numeric),
        new JdeField("BCMCU", "BCMCU", JdeDataType.String, 24),
        new JdeField("BCOBJ", "BCOBJ", JdeDataType.String, 12),
        new JdeField("BCSUB", "BCSUB", JdeDataType.String, 16),
        new JdeField("BCSBL", "BCSBL", JdeDataType.String, 16),
        new JdeField("BCSBLT", "BCSBLT", JdeDataType.String, 2),
        new JdeField("BCBGBL", "BCBGBL", JdeDataType.Numeric),
        new JdeField("BCCDC1", "BCCDC1", JdeDataType.String, 2),
        new JdeField("BCTDEB", "BCTDEB", JdeDataType.Numeric),
        new JdeField("BCTCRE", "BCTCRE", JdeDataType.Numeric),
        new JdeField("BCENBL", "BCENBL", JdeDataType.Numeric),
        new JdeField("BCCDC2", "BCCDC2", JdeDataType.String, 2),
        new JdeField("BCCO", "BCCO", JdeDataType.String, 10),
        new JdeField("BCLT", "BCLT", JdeDataType.String, 4),
        new JdeField("BCRDOR", "BCRDOR", JdeDataType.String, 2),
        new JdeField("BCTORG", "BCTORG", JdeDataType.String, 20),
        new JdeField("BCUSER", "BCUSER", JdeDataType.String, 20),
        new JdeField("BCPID", "BCPID", JdeDataType.String, 20),
        new JdeField("BCJOBN", "BCJOBN", JdeDataType.String, 20),
        new JdeField("BCUPMJ", "BCUPMJ", JdeDataType.Numeric),
        new JdeField("BCUPMT", "BCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B902_0", "Primary Key on BCUKID", new[] { "BCUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B902_2", "Unique Index on BCDGJ, BCMCU, BCOBJ, BCSUB, BCSBL, BCSBLT, BCLT", new[] { "BCDGJ", "BCMCU", "BCOBJ", "BCSUB", "BCSBL", "BCSBLT", "BCLT" }, isUnique: true)
    };
}
