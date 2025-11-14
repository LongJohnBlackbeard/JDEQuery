using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46L001 - .
/// </summary>
public class F46L001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CLMCU.
        /// </summary>
        public const string CLMCU = "CLMCU";

        /// <summary>
        /// CLLPNM.
        /// </summary>
        public const string CLLPNM = "CLLPNM";

        /// <summary>
        /// CLASYP.
        /// </summary>
        public const string CLASYP = "CLASYP";

        /// <summary>
        /// CLASYN.
        /// </summary>
        public const string CLASYN = "CLASYN";

        /// <summary>
        /// CLLPNG.
        /// </summary>
        public const string CLLPNG = "CLLPNG";

        /// <summary>
        /// CLLPSC.
        /// </summary>
        public const string CLLPSC = "CLLPSC";

        /// <summary>
        /// CLEQTY.
        /// </summary>
        public const string CLEQTY = "CLEQTY";

        /// <summary>
        /// CLURCD.
        /// </summary>
        public const string CLURCD = "CLURCD";

        /// <summary>
        /// CLURDT.
        /// </summary>
        public const string CLURDT = "CLURDT";

        /// <summary>
        /// CLURAB.
        /// </summary>
        public const string CLURAB = "CLURAB";

        /// <summary>
        /// CLURRF.
        /// </summary>
        public const string CLURRF = "CLURRF";

        /// <summary>
        /// CLUSER.
        /// </summary>
        public const string CLUSER = "CLUSER";

        /// <summary>
        /// CLPID.
        /// </summary>
        public const string CLPID = "CLPID";

        /// <summary>
        /// CLMKEY.
        /// </summary>
        public const string CLMKEY = "CLMKEY";

        /// <summary>
        /// CLUPMJ.
        /// </summary>
        public const string CLUPMJ = "CLUPMJ";

        /// <summary>
        /// CLTDAY.
        /// </summary>
        public const string CLTDAY = "CLTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F46L001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CLMCU", "CLMCU", JdeDataType.String, 24, true, true),
        new JdeField("CLLPNM", "CLLPNM", JdeDataType.String, 2),
        new JdeField("CLASYP", "CLASYP", JdeDataType.String, 2),
        new JdeField("CLASYN", "CLASYN", JdeDataType.String, 2),
        new JdeField("CLLPNG", "CLLPNG", JdeDataType.String, 4),
        new JdeField("CLLPSC", "CLLPSC", JdeDataType.String, 10),
        new JdeField("CLEQTY", "CLEQTY", JdeDataType.String, 10),
        new JdeField("CLURCD", "CLURCD", JdeDataType.String, 4),
        new JdeField("CLURDT", "CLURDT", JdeDataType.Numeric),
        new JdeField("CLURAB", "CLURAB", JdeDataType.Numeric),
        new JdeField("CLURRF", "CLURRF", JdeDataType.String, 30),
        new JdeField("CLUSER", "CLUSER", JdeDataType.String, 20),
        new JdeField("CLPID", "CLPID", JdeDataType.String, 20),
        new JdeField("CLMKEY", "CLMKEY", JdeDataType.String, 30),
        new JdeField("CLUPMJ", "CLUPMJ", JdeDataType.Numeric),
        new JdeField("CLTDAY", "CLTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46L001_0", "Primary Key on CLMCU", new[] { "CLMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
