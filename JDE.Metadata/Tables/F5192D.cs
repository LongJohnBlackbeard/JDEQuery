using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F5192D - .
/// </summary>
public class F5192D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JCRECC.
        /// </summary>
        public const string JCRECC = "JCRECC";

        /// <summary>
        /// JCCOLN.
        /// </summary>
        public const string JCCOLN = "JCCOLN";

        /// <summary>
        /// JCLNGP.
        /// </summary>
        public const string JCLNGP = "JCLNGP";

        /// <summary>
        /// JCDL01.
        /// </summary>
        public const string JCDL01 = "JCDL01";

        /// <summary>
        /// JCCLH1.
        /// </summary>
        public const string JCCLH1 = "JCCLH1";

        /// <summary>
        /// JCCLH2.
        /// </summary>
        public const string JCCLH2 = "JCCLH2";
    }

    /// <inheritdoc />
    public override string TableName => "F5192D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JCRECC", "JCRECC", JdeDataType.String, 4, true, true),
        new JdeField("JCCOLN", "JCCOLN", JdeDataType.String, 8, true, true),
        new JdeField("JCLNGP", "JCLNGP", JdeDataType.String, 4, true, true),
        new JdeField("JCDL01", "JCDL01", JdeDataType.String, 60),
        new JdeField("JCCLH1", "JCCLH1", JdeDataType.String, 22),
        new JdeField("JCCLH2", "JCCLH2", JdeDataType.String, 22)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F5192D_0", "Primary Key on JCRECC, JCCOLN, JCLNGP", new[] { "JCRECC", "JCCOLN", "JCLNGP" }, isUnique: true, isPrimaryKey: true)
    };
}
