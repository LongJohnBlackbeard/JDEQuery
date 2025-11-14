using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A8230 - .
/// </summary>
public class F76A8230 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// C1ATXC.
        /// </summary>
        public const string C1ATXC = "C1ATXC";

        /// <summary>
        /// C1AARS.
        /// </summary>
        public const string C1AARS = "C1AARS";

        /// <summary>
        /// C1AACA.
        /// </summary>
        public const string C1AACA = "C1AACA";

        /// <summary>
        /// C1EFTJ.
        /// </summary>
        public const string C1EFTJ = "C1EFTJ";

        /// <summary>
        /// C1EFDJ.
        /// </summary>
        public const string C1EFDJ = "C1EFDJ";

        /// <summary>
        /// C1TXR1.
        /// </summary>
        public const string C1TXR1 = "C1TXR1";

        /// <summary>
        /// C1AN8.
        /// </summary>
        public const string C1AN8 = "C1AN8";

        /// <summary>
        /// C1ITM.
        /// </summary>
        public const string C1ITM = "C1ITM";

        /// <summary>
        /// C1AC20.
        /// </summary>
        public const string C1AC20 = "C1AC20";

        /// <summary>
        /// C1SRP0.
        /// </summary>
        public const string C1SRP0 = "C1SRP0";

        /// <summary>
        /// C1AUMT.
        /// </summary>
        public const string C1AUMT = "C1AUMT";

        /// <summary>
        /// C1UOM.
        /// </summary>
        public const string C1UOM = "C1UOM";

        /// <summary>
        /// C1GFL1.
        /// </summary>
        public const string C1GFL1 = "C1GFL1";

        /// <summary>
        /// C1CTID.
        /// </summary>
        public const string C1CTID = "C1CTID";

        /// <summary>
        /// C1USER.
        /// </summary>
        public const string C1USER = "C1USER";

        /// <summary>
        /// C1UPMJ.
        /// </summary>
        public const string C1UPMJ = "C1UPMJ";

        /// <summary>
        /// C1UPMT.
        /// </summary>
        public const string C1UPMT = "C1UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76A8230";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("C1ATXC", "C1ATXC", JdeDataType.String, 20, true, true),
        new JdeField("C1AARS", "C1AARS", JdeDataType.String, 6, true, true),
        new JdeField("C1AACA", "C1AACA", JdeDataType.String, 6, true, true),
        new JdeField("C1EFTJ", "C1EFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("C1EFDJ", "C1EFDJ", JdeDataType.Numeric),
        new JdeField("C1TXR1", "C1TXR1", JdeDataType.Numeric),
        new JdeField("C1AN8", "C1AN8", JdeDataType.Numeric),
        new JdeField("C1ITM", "C1ITM", JdeDataType.Numeric),
        new JdeField("C1AC20", "C1AC20", JdeDataType.String, 6),
        new JdeField("C1SRP0", "C1SRP0", JdeDataType.String, 12),
        new JdeField("C1AUMT", "C1AUMT", JdeDataType.Numeric),
        new JdeField("C1UOM", "C1UOM", JdeDataType.String, 4),
        new JdeField("C1GFL1", "C1GFL1", JdeDataType.String, 2),
        new JdeField("C1CTID", "C1CTID", JdeDataType.String, 30),
        new JdeField("C1USER", "C1USER", JdeDataType.String, 20),
        new JdeField("C1UPMJ", "C1UPMJ", JdeDataType.Numeric),
        new JdeField("C1UPMT", "C1UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A8230_0", "Primary Key on C1ATXC, C1AARS, C1AACA, C1EFTJ", new[] { "C1ATXC", "C1AARS", "C1AACA", "C1EFTJ" }, isUnique: true, isPrimaryKey: true)
    };
}
