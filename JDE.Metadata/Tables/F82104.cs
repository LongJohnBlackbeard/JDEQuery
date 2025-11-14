using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F82104 - .
/// </summary>
public class F82104 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// A2QRYG.
        /// </summary>
        public const string A2QRYG = "A2QRYG";

        /// <summary>
        /// A2QRYN.
        /// </summary>
        public const string A2QRYN = "A2QRYN";

        /// <summary>
        /// A2OFD.
        /// </summary>
        public const string A2OFD = "A2OFD";

        /// <summary>
        /// A2OFDI.
        /// </summary>
        public const string A2OFDI = "A2OFDI";

        /// <summary>
        /// A2SQNB.
        /// </summary>
        public const string A2SQNB = "A2SQNB";

        /// <summary>
        /// A2OFDC.
        /// </summary>
        public const string A2OFDC = "A2OFDC";
    }

    /// <inheritdoc />
    public override string TableName => "F82104";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("A2QRYG", "A2QRYG", JdeDataType.String, 20, true, true),
        new JdeField("A2QRYN", "A2QRYN", JdeDataType.String, 20, true, true),
        new JdeField("A2OFD", "A2OFD", JdeDataType.String, 20, true, true),
        new JdeField("A2OFDI", "A2OFDI", JdeDataType.Numeric, null, true, true),
        new JdeField("A2SQNB", "A2SQNB", JdeDataType.Numeric, null, true, true),
        new JdeField("A2OFDC", "A2OFDC", JdeDataType.String, 120)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F82104_0", "Primary Key on A2QRYG, A2QRYN, A2OFD, A2OFDI, A2SQNB", new[] { "A2QRYG", "A2QRYN", "A2OFD", "A2OFDI", "A2SQNB" }, isUnique: true, isPrimaryKey: true)
    };
}
