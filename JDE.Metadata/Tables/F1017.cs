using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1017 - .
/// </summary>
public class F1017 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CSCNAM.
        /// </summary>
        public const string CSCNAM = "CSCNAM";

        /// <summary>
        /// CSSERK.
        /// </summary>
        public const string CSSERK = "CSSERK";

        /// <summary>
        /// CSOTPS.
        /// </summary>
        public const string CSOTPS = "CSOTPS";

        /// <summary>
        /// CSMCU1.
        /// </summary>
        public const string CSMCU1 = "CSMCU1";

        /// <summary>
        /// CSOTPA.
        /// </summary>
        public const string CSOTPA = "CSOTPA";

        /// <summary>
        /// CSLDA.
        /// </summary>
        public const string CSLDA = "CSLDA";

        /// <summary>
        /// CSSBLD.
        /// </summary>
        public const string CSSBLD = "CSSBLD";

        /// <summary>
        /// CSRNDG.
        /// </summary>
        public const string CSRNDG = "CSRNDG";

        /// <summary>
        /// CSCPTF.
        /// </summary>
        public const string CSCPTF = "CSCPTF";

        /// <summary>
        /// CSCPTV.
        /// </summary>
        public const string CSCPTV = "CSCPTV";

        /// <summary>
        /// CSFLT1.
        /// </summary>
        public const string CSFLT1 = "CSFLT1";

        /// <summary>
        /// CSFLT2.
        /// </summary>
        public const string CSFLT2 = "CSFLT2";

        /// <summary>
        /// CSFLT3.
        /// </summary>
        public const string CSFLT3 = "CSFLT3";

        /// <summary>
        /// CSABIN.
        /// </summary>
        public const string CSABIN = "CSABIN";
    }

    /// <inheritdoc />
    public override string TableName => "F1017";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CSCNAM", "CSCNAM", JdeDataType.String, 6, true, true),
        new JdeField("CSSERK", "CSSERK", JdeDataType.Numeric, null, true, true),
        new JdeField("CSOTPS", "CSOTPS", JdeDataType.String, 6),
        new JdeField("CSMCU1", "CSMCU1", JdeDataType.String, 24),
        new JdeField("CSOTPA", "CSOTPA", JdeDataType.String, 6),
        new JdeField("CSLDA", "CSLDA", JdeDataType.String, 2),
        new JdeField("CSSBLD", "CSSBLD", JdeDataType.String, 2),
        new JdeField("CSRNDG", "CSRNDG", JdeDataType.String, 2),
        new JdeField("CSCPTF", "CSCPTF", JdeDataType.String, 2),
        new JdeField("CSCPTV", "CSCPTV", JdeDataType.String, 2),
        new JdeField("CSFLT1", "CSFLT1", JdeDataType.String, 4),
        new JdeField("CSFLT2", "CSFLT2", JdeDataType.String, 4),
        new JdeField("CSFLT3", "CSFLT3", JdeDataType.String, 4),
        new JdeField("CSABIN", "CSABIN", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1017_0", "Primary Key on CSCNAM, CSSERK", new[] { "CSCNAM", "CSSERK" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1017_2", "Index on CSCNAM, CSOTPS, CSMCU1, CSOTPA, CSLDA", new[] { "CSCNAM", "CSOTPS", "CSMCU1", "CSOTPA", "CSLDA" })
    };
}
