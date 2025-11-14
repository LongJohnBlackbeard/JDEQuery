using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B012 - .
/// </summary>
public class F76B012 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TSBNNF.
        /// </summary>
        public const string TSBNNF = "TSBNNF";

        /// <summary>
        /// TSBSER.
        /// </summary>
        public const string TSBSER = "TSBSER";

        /// <summary>
        /// TSN001.
        /// </summary>
        public const string TSN001 = "TSN001";

        /// <summary>
        /// TSDCT.
        /// </summary>
        public const string TSDCT = "TSDCT";

        /// <summary>
        /// TSUKID.
        /// </summary>
        public const string TSUKID = "TSUKID";

        /// <summary>
        /// TSB76TSIPI.
        /// </summary>
        public const string TSB76TSIPI = "TSB76TSIPI";

        /// <summary>
        /// TSB76TSPIS.
        /// </summary>
        public const string TSB76TSPIS = "TSB76TSPIS";

        /// <summary>
        /// TSB76TSCOF.
        /// </summary>
        public const string TSB76TSCOF = "TSB76TSCOF";

        /// <summary>
        /// TSUSER.
        /// </summary>
        public const string TSUSER = "TSUSER";

        /// <summary>
        /// TSPID.
        /// </summary>
        public const string TSPID = "TSPID";

        /// <summary>
        /// TSJOBN.
        /// </summary>
        public const string TSJOBN = "TSJOBN";

        /// <summary>
        /// TSUPMJ.
        /// </summary>
        public const string TSUPMJ = "TSUPMJ";

        /// <summary>
        /// TSTDAY.
        /// </summary>
        public const string TSTDAY = "TSTDAY";

        /// <summary>
        /// TS76BIPILF.
        /// </summary>
        public const string TS76BIPILF = "TS76BIPILF";
    }

    /// <inheritdoc />
    public override string TableName => "F76B012";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TSBNNF", "TSBNNF", JdeDataType.Numeric, null, true, true),
        new JdeField("TSBSER", "TSBSER", JdeDataType.String, 4, true, true),
        new JdeField("TSN001", "TSN001", JdeDataType.Numeric, null, true, true),
        new JdeField("TSDCT", "TSDCT", JdeDataType.String, 4, true, true),
        new JdeField("TSUKID", "TSUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("TSB76TSIPI", "TSB76TSIPI", JdeDataType.String, 6),
        new JdeField("TSB76TSPIS", "TSB76TSPIS", JdeDataType.String, 6),
        new JdeField("TSB76TSCOF", "TSB76TSCOF", JdeDataType.String, 6),
        new JdeField("TSUSER", "TSUSER", JdeDataType.String, 20),
        new JdeField("TSPID", "TSPID", JdeDataType.String, 20),
        new JdeField("TSJOBN", "TSJOBN", JdeDataType.String, 20),
        new JdeField("TSUPMJ", "TSUPMJ", JdeDataType.Numeric),
        new JdeField("TSTDAY", "TSTDAY", JdeDataType.Numeric),
        new JdeField("TS76BIPILF", "TS76BIPILF", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B012_0", "Primary Key on TSBNNF, TSBSER, TSN001, TSDCT, TSUKID", new[] { "TSBNNF", "TSBSER", "TSN001", "TSDCT", "TSUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
