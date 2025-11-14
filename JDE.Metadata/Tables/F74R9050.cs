using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R9050 - .
/// </summary>
public class F74R9050 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CFR74REPN.
        /// </summary>
        public const string CFR74REPN = "CFR74REPN";

        /// <summary>
        /// CFR74SECT.
        /// </summary>
        public const string CFR74SECT = "CFR74SECT";

        /// <summary>
        /// CFR74RROW.
        /// </summary>
        public const string CFR74RROW = "CFR74RROW";

        /// <summary>
        /// CFD240.
        /// </summary>
        public const string CFD240 = "CFD240";

        /// <summary>
        /// CFR74CODE.
        /// </summary>
        public const string CFR74CODE = "CFR74CODE";

        /// <summary>
        /// CFAA1.
        /// </summary>
        public const string CFAA1 = "CFAA1";

        /// <summary>
        /// CFAA2.
        /// </summary>
        public const string CFAA2 = "CFAA2";

        /// <summary>
        /// CFURAB.
        /// </summary>
        public const string CFURAB = "CFURAB";

        /// <summary>
        /// CFURAT.
        /// </summary>
        public const string CFURAT = "CFURAT";

        /// <summary>
        /// CFURDT.
        /// </summary>
        public const string CFURDT = "CFURDT";

        /// <summary>
        /// CFURCD.
        /// </summary>
        public const string CFURCD = "CFURCD";

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
        /// CFUPMT.
        /// </summary>
        public const string CFUPMT = "CFUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74R9050";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CFR74REPN", "CFR74REPN", JdeDataType.String, 40, true, true),
        new JdeField("CFR74SECT", "CFR74SECT", JdeDataType.String, 4, true, true),
        new JdeField("CFR74RROW", "CFR74RROW", JdeDataType.String, 8, true, true),
        new JdeField("CFD240", "CFD240", JdeDataType.String, 480),
        new JdeField("CFR74CODE", "CFR74CODE", JdeDataType.String, 8),
        new JdeField("CFAA1", "CFAA1", JdeDataType.Numeric),
        new JdeField("CFAA2", "CFAA2", JdeDataType.Numeric),
        new JdeField("CFURAB", "CFURAB", JdeDataType.Numeric),
        new JdeField("CFURAT", "CFURAT", JdeDataType.Numeric),
        new JdeField("CFURDT", "CFURDT", JdeDataType.Numeric),
        new JdeField("CFURCD", "CFURCD", JdeDataType.String, 4),
        new JdeField("CFURRF", "CFURRF", JdeDataType.String, 30),
        new JdeField("CFUSER", "CFUSER", JdeDataType.String, 20),
        new JdeField("CFPID", "CFPID", JdeDataType.String, 20),
        new JdeField("CFJOBN", "CFJOBN", JdeDataType.String, 20),
        new JdeField("CFUPMJ", "CFUPMJ", JdeDataType.Numeric),
        new JdeField("CFUPMT", "CFUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R9050_0", "Primary Key on CFR74REPN, CFR74SECT, CFR74RROW", new[] { "CFR74REPN", "CFR74SECT", "CFR74RROW" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74R9050_2", "Index on CFR74CODE", new[] { "CFR74CODE" })
    };
}
