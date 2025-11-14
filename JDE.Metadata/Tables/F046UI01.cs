using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F046UI01 - .
/// </summary>
public class F046UI01 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CVCO.
        /// </summary>
        public const string CVCO = "CVCO";

        /// <summary>
        /// CVCBNP.
        /// </summary>
        public const string CVCBNP = "CVCBNP";

        /// <summary>
        /// CVAN8.
        /// </summary>
        public const string CVAN8 = "CVAN8";

        /// <summary>
        /// CVCBNR.
        /// </summary>
        public const string CVCBNR = "CVCBNR";

        /// <summary>
        /// CVJOBS.
        /// </summary>
        public const string CVJOBS = "CVJOBS";

        /// <summary>
        /// CVCTID.
        /// </summary>
        public const string CVCTID = "CVCTID";
    }

    /// <inheritdoc />
    public override string TableName => "F046UI01";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CVCO", "CVCO", JdeDataType.String, 10, true, true),
        new JdeField("CVCBNP", "CVCBNP", JdeDataType.String, 30, true, true),
        new JdeField("CVAN8", "CVAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CVCBNR", "CVCBNR", JdeDataType.String, 30, true, true),
        new JdeField("CVJOBS", "CVJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("CVCTID", "CVCTID", JdeDataType.String, 30, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F046UI01_0", "Primary Key on CVCO, CVCBNP, CVAN8, CVCBNR, CVJOBS, CVCTID", new[] { "CVCO", "CVCBNP", "CVAN8", "CVCBNR", "CVJOBS", "CVCTID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F046UI01_4", "Index on CVCO, CVJOBS, CVCTID", new[] { "CVCO", "CVJOBS", "CVCTID" }),
        new JdeIndex("F046UI01_5", "Index on CVCBNP, CVJOBS, CVCTID", new[] { "CVCBNP", "CVJOBS", "CVCTID" }),
        new JdeIndex("F046UI01_6", "Index on CVAN8, CVJOBS, CVCTID", new[] { "CVAN8", "CVJOBS", "CVCTID" }),
        new JdeIndex("F046UI01_7", "Index on CVCBNR, CVJOBS, CVCTID", new[] { "CVCBNR", "CVJOBS", "CVCTID" })
    };
}
