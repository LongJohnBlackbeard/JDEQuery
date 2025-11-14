using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A0440 - .
/// </summary>
public class F76A0440 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CDPYID.
        /// </summary>
        public const string CDPYID = "CDPYID";

        /// <summary>
        /// CDCKNU.
        /// </summary>
        public const string CDCKNU = "CDCKNU";

        /// <summary>
        /// CDTAXX.
        /// </summary>
        public const string CDTAXX = "CDTAXX";

        /// <summary>
        /// CDAPT.
        /// </summary>
        public const string CDAPT = "CDAPT";

        /// <summary>
        /// CDTAX.
        /// </summary>
        public const string CDTAX = "CDTAX";

        /// <summary>
        /// CDAG.
        /// </summary>
        public const string CDAG = "CDAG";

        /// <summary>
        /// CDFFU2.
        /// </summary>
        public const string CDFFU2 = "CDFFU2";

        /// <summary>
        /// CDCRCD.
        /// </summary>
        public const string CDCRCD = "CDCRCD";

        /// <summary>
        /// CDCRR.
        /// </summary>
        public const string CDCRR = "CDCRR";

        /// <summary>
        /// CDACR.
        /// </summary>
        public const string CDACR = "CDACR";

        /// <summary>
        /// CDUSER.
        /// </summary>
        public const string CDUSER = "CDUSER";

        /// <summary>
        /// CDPID.
        /// </summary>
        public const string CDPID = "CDPID";

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
    }

    /// <inheritdoc />
    public override string TableName => "F76A0440";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CDPYID", "CDPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("CDCKNU", "CDCKNU", JdeDataType.String, 50, true, true),
        new JdeField("CDTAXX", "CDTAXX", JdeDataType.String, 40, true, true),
        new JdeField("CDAPT", "CDAPT", JdeDataType.String, 4),
        new JdeField("CDTAX", "CDTAX", JdeDataType.String, 40),
        new JdeField("CDAG", "CDAG", JdeDataType.Numeric),
        new JdeField("CDFFU2", "CDFFU2", JdeDataType.String, 2),
        new JdeField("CDCRCD", "CDCRCD", JdeDataType.String, 6),
        new JdeField("CDCRR", "CDCRR", JdeDataType.Numeric),
        new JdeField("CDACR", "CDACR", JdeDataType.Numeric),
        new JdeField("CDUSER", "CDUSER", JdeDataType.String, 20),
        new JdeField("CDPID", "CDPID", JdeDataType.String, 20),
        new JdeField("CDUPMJ", "CDUPMJ", JdeDataType.Numeric),
        new JdeField("CDUPMT", "CDUPMT", JdeDataType.Numeric),
        new JdeField("CDJOBN", "CDJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A0440_0", "Primary Key on CDPYID, CDCKNU, CDTAXX", new[] { "CDPYID", "CDCKNU", "CDTAXX" }, isUnique: true, isPrimaryKey: true)
    };
}
