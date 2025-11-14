using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F9801OLD - .
/// </summary>
public class F9801OLD : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AAAN8.
        /// </summary>
        public const string AAAN8 = "AAAN8";

        /// <summary>
        /// AAALPH.
        /// </summary>
        public const string AAALPH = "AAALPH";

        /// <summary>
        /// AAADD0.
        /// </summary>
        public const string AAADD0 = "AAADD0";

        /// <summary>
        /// AAADD1.
        /// </summary>
        public const string AAADD1 = "AAADD1";

        /// <summary>
        /// AAADDS.
        /// </summary>
        public const string AAADDS = "AAADDS";

        /// <summary>
        /// AACTY1.
        /// </summary>
        public const string AACTY1 = "AACTY1";

        /// <summary>
        /// AAAR1.
        /// </summary>
        public const string AAAR1 = "AAAR1";

        /// <summary>
        /// AAPH1.
        /// </summary>
        public const string AAPH1 = "AAPH1";

        /// <summary>
        /// AADL01.
        /// </summary>
        public const string AADL01 = "AADL01";

        /// <summary>
        /// AADL02.
        /// </summary>
        public const string AADL02 = "AADL02";

        /// <summary>
        /// AADL03.
        /// </summary>
        public const string AADL03 = "AADL03";
    }

    /// <inheritdoc />
    public override string TableName => "F9801OLD";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AAAN8", "AAAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("AAALPH", "AAALPH", JdeDataType.String, 80),
        new JdeField("AAADD0", "AAADD0", JdeDataType.String, 80),
        new JdeField("AAADD1", "AAADD1", JdeDataType.String, 80),
        new JdeField("AAADDS", "AAADDS", JdeDataType.String, 6),
        new JdeField("AACTY1", "AACTY1", JdeDataType.String, 50),
        new JdeField("AAAR1", "AAAR1", JdeDataType.String, 12),
        new JdeField("AAPH1", "AAPH1", JdeDataType.String, 40),
        new JdeField("AADL01", "AADL01", JdeDataType.String, 60),
        new JdeField("AADL02", "AADL02", JdeDataType.String, 60),
        new JdeField("AADL03", "AADL03", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F9801OLD_0", "Primary Key on AAAN8", new[] { "AAAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
