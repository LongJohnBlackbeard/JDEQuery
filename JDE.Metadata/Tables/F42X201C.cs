using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42X201C - .
/// </summary>
public class F42X201C : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PD42XPSIM.
        /// </summary>
        public const string PD42XPSIM = "PD42XPSIM";

        /// <summary>
        /// PD42XSCEN.
        /// </summary>
        public const string PD42XSCEN = "PD42XSCEN";

        /// <summary>
        /// PD42XREV.
        /// </summary>
        public const string PD42XREV = "PD42XREV";

        /// <summary>
        /// PD42XCHART.
        /// </summary>
        public const string PD42XCHART = "PD42XCHART";

        /// <summary>
        /// PDSTRDTJ.
        /// </summary>
        public const string PDSTRDTJ = "PDSTRDTJ";

        /// <summary>
        /// PD42XVAL1.
        /// </summary>
        public const string PD42XVAL1 = "PD42XVAL1";

        /// <summary>
        /// PD42XVAL2.
        /// </summary>
        public const string PD42XVAL2 = "PD42XVAL2";
    }

    /// <inheritdoc />
    public override string TableName => "F42X201C";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PD42XPSIM", "PD42XPSIM", JdeDataType.String, 80, true, true),
        new JdeField("PD42XSCEN", "PD42XSCEN", JdeDataType.Numeric, null, true, true),
        new JdeField("PD42XREV", "PD42XREV", JdeDataType.Numeric, null, true, true),
        new JdeField("PD42XCHART", "PD42XCHART", JdeDataType.Numeric, null, true, true),
        new JdeField("PDSTRDTJ", "PDSTRDTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("PD42XVAL1", "PD42XVAL1", JdeDataType.Numeric),
        new JdeField("PD42XVAL2", "PD42XVAL2", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42X201C_0", "Primary Key on PD42XPSIM, PD42XSCEN, PD42XREV, PD42XCHART, PDSTRDTJ", new[] { "PD42XPSIM", "PD42XSCEN", "PD42XREV", "PD42XCHART", "PDSTRDTJ" }, isUnique: true, isPrimaryKey: true)
    };
}
