using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43093 - .
/// </summary>
public class F43093 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PEAN8.
        /// </summary>
        public const string PEAN8 = "PEAN8";

        /// <summary>
        /// PEITM.
        /// </summary>
        public const string PEITM = "PEITM";

        /// <summary>
        /// PELITM.
        /// </summary>
        public const string PELITM = "PELITM";

        /// <summary>
        /// PEAITM.
        /// </summary>
        public const string PEAITM = "PEAITM";

        /// <summary>
        /// PEMCU.
        /// </summary>
        public const string PEMCU = "PEMCU";

        /// <summary>
        /// PEQYFR.
        /// </summary>
        public const string PEQYFR = "PEQYFR";

        /// <summary>
        /// PESAMP.
        /// </summary>
        public const string PESAMP = "PESAMP";

        /// <summary>
        /// PEPNSP.
        /// </summary>
        public const string PEPNSP = "PEPNSP";

        /// <summary>
        /// PEQYAC.
        /// </summary>
        public const string PEQYAC = "PEQYAC";

        /// <summary>
        /// PEPNAC.
        /// </summary>
        public const string PEPNAC = "PEPNAC";
    }

    /// <inheritdoc />
    public override string TableName => "F43093";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PEAN8", "PEAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PEITM", "PEITM", JdeDataType.Numeric, null, true, true),
        new JdeField("PELITM", "PELITM", JdeDataType.String, 50),
        new JdeField("PEAITM", "PEAITM", JdeDataType.String, 50),
        new JdeField("PEMCU", "PEMCU", JdeDataType.String, 24, true, true),
        new JdeField("PEQYFR", "PEQYFR", JdeDataType.Numeric, null, true, true),
        new JdeField("PESAMP", "PESAMP", JdeDataType.Numeric),
        new JdeField("PEPNSP", "PEPNSP", JdeDataType.Numeric),
        new JdeField("PEQYAC", "PEQYAC", JdeDataType.Numeric),
        new JdeField("PEPNAC", "PEPNAC", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43093_0", "Primary Key on PEMCU, PEITM, PEAN8, PEQYFR", new[] { "PEMCU", "PEITM", "PEAN8", "PEQYFR" }, isUnique: true, isPrimaryKey: true)
    };
}
