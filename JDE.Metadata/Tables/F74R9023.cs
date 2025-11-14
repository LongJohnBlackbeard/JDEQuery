using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R9023 - .
/// </summary>
public class F74R9023 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// COR74REPN.
        /// </summary>
        public const string COR74REPN = "COR74REPN";

        /// <summary>
        /// COR74SECT.
        /// </summary>
        public const string COR74SECT = "COR74SECT";

        /// <summary>
        /// COR74RROW.
        /// </summary>
        public const string COR74RROW = "COR74RROW";

        /// <summary>
        /// COR74RCOL.
        /// </summary>
        public const string COR74RCOL = "COR74RCOL";

        /// <summary>
        /// COR74FORT.
        /// </summary>
        public const string COR74FORT = "COR74FORT";

        /// <summary>
        /// COR74FACT.
        /// </summary>
        public const string COR74FACT = "COR74FACT";

        /// <summary>
        /// COURAB.
        /// </summary>
        public const string COURAB = "COURAB";

        /// <summary>
        /// COURAT.
        /// </summary>
        public const string COURAT = "COURAT";

        /// <summary>
        /// COURCD.
        /// </summary>
        public const string COURCD = "COURCD";

        /// <summary>
        /// COURDT.
        /// </summary>
        public const string COURDT = "COURDT";

        /// <summary>
        /// COURRF.
        /// </summary>
        public const string COURRF = "COURRF";

        /// <summary>
        /// COUSER.
        /// </summary>
        public const string COUSER = "COUSER";

        /// <summary>
        /// COPID.
        /// </summary>
        public const string COPID = "COPID";

        /// <summary>
        /// COUPMJ.
        /// </summary>
        public const string COUPMJ = "COUPMJ";

        /// <summary>
        /// COUPMT.
        /// </summary>
        public const string COUPMT = "COUPMT";

        /// <summary>
        /// COJOBN.
        /// </summary>
        public const string COJOBN = "COJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74R9023";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("COR74REPN", "COR74REPN", JdeDataType.String, 40, true, true),
        new JdeField("COR74SECT", "COR74SECT", JdeDataType.String, 4, true, true),
        new JdeField("COR74RROW", "COR74RROW", JdeDataType.String, 8, true, true),
        new JdeField("COR74RCOL", "COR74RCOL", JdeDataType.String, 8, true, true),
        new JdeField("COR74FORT", "COR74FORT", JdeDataType.String, 6),
        new JdeField("COR74FACT", "COR74FACT", JdeDataType.String, 4),
        new JdeField("COURAB", "COURAB", JdeDataType.Numeric),
        new JdeField("COURAT", "COURAT", JdeDataType.Numeric),
        new JdeField("COURCD", "COURCD", JdeDataType.String, 4),
        new JdeField("COURDT", "COURDT", JdeDataType.Numeric),
        new JdeField("COURRF", "COURRF", JdeDataType.String, 30),
        new JdeField("COUSER", "COUSER", JdeDataType.String, 20),
        new JdeField("COPID", "COPID", JdeDataType.String, 20),
        new JdeField("COUPMJ", "COUPMJ", JdeDataType.Numeric),
        new JdeField("COUPMT", "COUPMT", JdeDataType.Numeric),
        new JdeField("COJOBN", "COJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R9023_0", "Primary Key on COR74REPN, COR74SECT, COR74RROW, COR74RCOL", new[] { "COR74REPN", "COR74SECT", "COR74RROW", "COR74RCOL" }, isUnique: true, isPrimaryKey: true)
    };
}
