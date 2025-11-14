using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B117 - .
/// </summary>
public class F31B117 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CDWCCID.
        /// </summary>
        public const string CDWCCID = "CDWCCID";

        /// <summary>
        /// CDWPA.
        /// </summary>
        public const string CDWPA = "CDWPA";

        /// <summary>
        /// CDTEMPUOM.
        /// </summary>
        public const string CDTEMPUOM = "CDTEMPUOM";

        /// <summary>
        /// CDWTEMP.
        /// </summary>
        public const string CDWTEMP = "CDWTEMP";

        /// <summary>
        /// CDCACR2.
        /// </summary>
        public const string CDCACR2 = "CDCACR2";

        /// <summary>
        /// CDURAB.
        /// </summary>
        public const string CDURAB = "CDURAB";

        /// <summary>
        /// CDURAT.
        /// </summary>
        public const string CDURAT = "CDURAT";

        /// <summary>
        /// CDURCD.
        /// </summary>
        public const string CDURCD = "CDURCD";

        /// <summary>
        /// CDURDT.
        /// </summary>
        public const string CDURDT = "CDURDT";

        /// <summary>
        /// CDURRF.
        /// </summary>
        public const string CDURRF = "CDURRF";

        /// <summary>
        /// CDWAB.
        /// </summary>
        public const string CDWAB = "CDWAB";

        /// <summary>
        /// CDWNUM.
        /// </summary>
        public const string CDWNUM = "CDWNUM";

        /// <summary>
        /// CDWCD.
        /// </summary>
        public const string CDWCD = "CDWCD";

        /// <summary>
        /// CDWMDT.
        /// </summary>
        public const string CDWMDT = "CDWMDT";

        /// <summary>
        /// CDWRF.
        /// </summary>
        public const string CDWRF = "CDWRF";

        /// <summary>
        /// CDUSER.
        /// </summary>
        public const string CDUSER = "CDUSER";

        /// <summary>
        /// CDUPMJ.
        /// </summary>
        public const string CDUPMJ = "CDUPMJ";

        /// <summary>
        /// CDUPMT.
        /// </summary>
        public const string CDUPMT = "CDUPMT";

        /// <summary>
        /// CDJOBN.
        /// </summary>
        public const string CDJOBN = "CDJOBN";

        /// <summary>
        /// CDMKEY.
        /// </summary>
        public const string CDMKEY = "CDMKEY";

        /// <summary>
        /// CDPID.
        /// </summary>
        public const string CDPID = "CDPID";
    }

    /// <inheritdoc />
    public override string TableName => "F31B117";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CDWCCID", "CDWCCID", JdeDataType.Numeric, null, true, true),
        new JdeField("CDWPA", "CDWPA", JdeDataType.Numeric, null, true, true),
        new JdeField("CDTEMPUOM", "CDTEMPUOM", JdeDataType.String, 4, true, true),
        new JdeField("CDWTEMP", "CDWTEMP", JdeDataType.Numeric, null, true, true),
        new JdeField("CDCACR2", "CDCACR2", JdeDataType.Numeric),
        new JdeField("CDURAB", "CDURAB", JdeDataType.Numeric),
        new JdeField("CDURAT", "CDURAT", JdeDataType.Numeric),
        new JdeField("CDURCD", "CDURCD", JdeDataType.String, 4),
        new JdeField("CDURDT", "CDURDT", JdeDataType.Numeric),
        new JdeField("CDURRF", "CDURRF", JdeDataType.String, 30),
        new JdeField("CDWAB", "CDWAB", JdeDataType.Numeric),
        new JdeField("CDWNUM", "CDWNUM", JdeDataType.Numeric),
        new JdeField("CDWCD", "CDWCD", JdeDataType.String, 6),
        new JdeField("CDWMDT", "CDWMDT", JdeDataType.Numeric),
        new JdeField("CDWRF", "CDWRF", JdeDataType.String, 60),
        new JdeField("CDUSER", "CDUSER", JdeDataType.String, 20),
        new JdeField("CDUPMJ", "CDUPMJ", JdeDataType.Numeric),
        new JdeField("CDUPMT", "CDUPMT", JdeDataType.Numeric),
        new JdeField("CDJOBN", "CDJOBN", JdeDataType.String, 20),
        new JdeField("CDMKEY", "CDMKEY", JdeDataType.String, 30),
        new JdeField("CDPID", "CDPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B117_0", "Primary Key on CDWCCID, CDWPA, CDTEMPUOM, CDWTEMP", new[] { "CDWCCID", "CDWPA", "CDTEMPUOM", "CDWTEMP" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B117_3", "Index on CDWCCID, CDWPA", new[] { "CDWCCID", "CDWPA" })
    };
}
