using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B017 - .
/// </summary>
public class F76B017 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IAB76IDOC.
        /// </summary>
        public const string IAB76IDOC = "IAB76IDOC";

        /// <summary>
        /// IAB76IDCT.
        /// </summary>
        public const string IAB76IDCT = "IAB76IDCT";

        /// <summary>
        /// IAB76IADN.
        /// </summary>
        public const string IAB76IADN = "IAB76IADN";

        /// <summary>
        /// IAB76IISN.
        /// </summary>
        public const string IAB76IISN = "IAB76IISN";

        /// <summary>
        /// IAB76IFMC.
        /// </summary>
        public const string IAB76IFMC = "IAB76IFMC";

        /// <summary>
        /// IAB76IIDA.
        /// </summary>
        public const string IAB76IIDA = "IAB76IIDA";

        /// <summary>
        /// IAUSER.
        /// </summary>
        public const string IAUSER = "IAUSER";

        /// <summary>
        /// IAPID.
        /// </summary>
        public const string IAPID = "IAPID";

        /// <summary>
        /// IAJOBN.
        /// </summary>
        public const string IAJOBN = "IAJOBN";

        /// <summary>
        /// IAUPMJ.
        /// </summary>
        public const string IAUPMJ = "IAUPMJ";

        /// <summary>
        /// IAUPMT.
        /// </summary>
        public const string IAUPMT = "IAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B017";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IAB76IDOC", "IAB76IDOC", JdeDataType.String, 20, true, true),
        new JdeField("IAB76IDCT", "IAB76IDCT", JdeDataType.String, 6, true, true),
        new JdeField("IAB76IADN", "IAB76IADN", JdeDataType.Numeric, null, true, true),
        new JdeField("IAB76IISN", "IAB76IISN", JdeDataType.Numeric, null, true, true),
        new JdeField("IAB76IFMC", "IAB76IFMC", JdeDataType.String, 6),
        new JdeField("IAB76IIDA", "IAB76IIDA", JdeDataType.Numeric),
        new JdeField("IAUSER", "IAUSER", JdeDataType.String, 20),
        new JdeField("IAPID", "IAPID", JdeDataType.String, 20),
        new JdeField("IAJOBN", "IAJOBN", JdeDataType.String, 20),
        new JdeField("IAUPMJ", "IAUPMJ", JdeDataType.Numeric),
        new JdeField("IAUPMT", "IAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B017_0", "Primary Key on IAB76IDOC, IAB76IDCT, IAB76IADN, IAB76IISN", new[] { "IAB76IDOC", "IAB76IDCT", "IAB76IADN", "IAB76IISN" }, isUnique: true, isPrimaryKey: true)
    };
}
