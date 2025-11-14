using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F5192 - .
/// </summary>
public class F5192 : JdeTable
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

        /// <summary>
        /// JCFMLA.
        /// </summary>
        public const string JCFMLA = "JCFMLA";

        /// <summary>
        /// JCDCML.
        /// </summary>
        public const string JCDCML = "JCDCML";

        /// <summary>
        /// JCEC.
        /// </summary>
        public const string JCEC = "JCEC";

        /// <summary>
        /// JCMLTP.
        /// </summary>
        public const string JCMLTP = "JCMLTP";

        /// <summary>
        /// JCDITM.
        /// </summary>
        public const string JCDITM = "JCDITM";

        /// <summary>
        /// JCSQAD.
        /// </summary>
        public const string JCSQAD = "JCSQAD";
    }

    /// <inheritdoc />
    public override string TableName => "F5192";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JCRECC", "JCRECC", JdeDataType.String, 4, true, true),
        new JdeField("JCCOLN", "JCCOLN", JdeDataType.String, 8, true, true),
        new JdeField("JCDL01", "JCDL01", JdeDataType.String, 60),
        new JdeField("JCCLH1", "JCCLH1", JdeDataType.String, 22),
        new JdeField("JCCLH2", "JCCLH2", JdeDataType.String, 22),
        new JdeField("JCFMLA", "JCFMLA", JdeDataType.String, 80),
        new JdeField("JCDCML", "JCDCML", JdeDataType.Numeric),
        new JdeField("JCEC", "JCEC", JdeDataType.String, 2),
        new JdeField("JCMLTP", "JCMLTP", JdeDataType.Numeric),
        new JdeField("JCDITM", "JCDITM", JdeDataType.String, 20),
        new JdeField("JCSQAD", "JCSQAD", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F5192_0", "Primary Key on JCRECC, JCCOLN", new[] { "JCRECC", "JCCOLN" }, isUnique: true, isPrimaryKey: true)
    };
}
