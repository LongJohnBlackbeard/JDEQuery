using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R9030 - .
/// </summary>
public class F74R9030 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BSR74REPN.
        /// </summary>
        public const string BSR74REPN = "BSR74REPN";

        /// <summary>
        /// BSR74SECT.
        /// </summary>
        public const string BSR74SECT = "BSR74SECT";

        /// <summary>
        /// BSR74RROW.
        /// </summary>
        public const string BSR74RROW = "BSR74RROW";

        /// <summary>
        /// BSD240.
        /// </summary>
        public const string BSD240 = "BSD240";

        /// <summary>
        /// BSR74CODE.
        /// </summary>
        public const string BSR74CODE = "BSR74CODE";

        /// <summary>
        /// BSAA.
        /// </summary>
        public const string BSAA = "BSAA";

        /// <summary>
        /// BSAA1.
        /// </summary>
        public const string BSAA1 = "BSAA1";

        /// <summary>
        /// BSURAB.
        /// </summary>
        public const string BSURAB = "BSURAB";

        /// <summary>
        /// BSURAT.
        /// </summary>
        public const string BSURAT = "BSURAT";

        /// <summary>
        /// BSURDT.
        /// </summary>
        public const string BSURDT = "BSURDT";

        /// <summary>
        /// BSURCD.
        /// </summary>
        public const string BSURCD = "BSURCD";

        /// <summary>
        /// BSURRF.
        /// </summary>
        public const string BSURRF = "BSURRF";

        /// <summary>
        /// BSUSER.
        /// </summary>
        public const string BSUSER = "BSUSER";

        /// <summary>
        /// BSPID.
        /// </summary>
        public const string BSPID = "BSPID";

        /// <summary>
        /// BSJOBN.
        /// </summary>
        public const string BSJOBN = "BSJOBN";

        /// <summary>
        /// BSUPMJ.
        /// </summary>
        public const string BSUPMJ = "BSUPMJ";

        /// <summary>
        /// BSUPMT.
        /// </summary>
        public const string BSUPMT = "BSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74R9030";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BSR74REPN", "BSR74REPN", JdeDataType.String, 40, true, true),
        new JdeField("BSR74SECT", "BSR74SECT", JdeDataType.String, 4, true, true),
        new JdeField("BSR74RROW", "BSR74RROW", JdeDataType.String, 8, true, true),
        new JdeField("BSD240", "BSD240", JdeDataType.String, 480),
        new JdeField("BSR74CODE", "BSR74CODE", JdeDataType.String, 8),
        new JdeField("BSAA", "BSAA", JdeDataType.Numeric),
        new JdeField("BSAA1", "BSAA1", JdeDataType.Numeric),
        new JdeField("BSURAB", "BSURAB", JdeDataType.Numeric),
        new JdeField("BSURAT", "BSURAT", JdeDataType.Numeric),
        new JdeField("BSURDT", "BSURDT", JdeDataType.Numeric),
        new JdeField("BSURCD", "BSURCD", JdeDataType.String, 4),
        new JdeField("BSURRF", "BSURRF", JdeDataType.String, 30),
        new JdeField("BSUSER", "BSUSER", JdeDataType.String, 20),
        new JdeField("BSPID", "BSPID", JdeDataType.String, 20),
        new JdeField("BSJOBN", "BSJOBN", JdeDataType.String, 20),
        new JdeField("BSUPMJ", "BSUPMJ", JdeDataType.Numeric),
        new JdeField("BSUPMT", "BSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R9030_0", "Primary Key on BSR74REPN, BSR74SECT, BSR74RROW", new[] { "BSR74REPN", "BSR74SECT", "BSR74RROW" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74R9030_2", "Index on BSR74CODE", new[] { "BSR74CODE" })
    };
}
