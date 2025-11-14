using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R0001 - .
/// </summary>
public class F74R0001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QAY74RCRCD.
        /// </summary>
        public const string QAY74RCRCD = "QAY74RCRCD";

        /// <summary>
        /// QALAN.
        /// </summary>
        public const string QALAN = "QALAN";

        /// <summary>
        /// QAY74RCRUS.
        /// </summary>
        public const string QAY74RCRUS = "QAY74RCRUS";

        /// <summary>
        /// QAY74RDECL.
        /// </summary>
        public const string QAY74RDECL = "QAY74RDECL";

        /// <summary>
        /// QAY74RV001.
        /// </summary>
        public const string QAY74RV001 = "QAY74RV001";

        /// <summary>
        /// QAY74RV002.
        /// </summary>
        public const string QAY74RV002 = "QAY74RV002";

        /// <summary>
        /// QAY74RV003.
        /// </summary>
        public const string QAY74RV003 = "QAY74RV003";

        /// <summary>
        /// QAY74RV004.
        /// </summary>
        public const string QAY74RV004 = "QAY74RV004";

        /// <summary>
        /// QAY74RV005.
        /// </summary>
        public const string QAY74RV005 = "QAY74RV005";

        /// <summary>
        /// QAY74RV006.
        /// </summary>
        public const string QAY74RV006 = "QAY74RV006";

        /// <summary>
        /// QAY74RV007.
        /// </summary>
        public const string QAY74RV007 = "QAY74RV007";

        /// <summary>
        /// QAY74RV008.
        /// </summary>
        public const string QAY74RV008 = "QAY74RV008";

        /// <summary>
        /// QAY74RV009.
        /// </summary>
        public const string QAY74RV009 = "QAY74RV009";

        /// <summary>
        /// QAY74RV010.
        /// </summary>
        public const string QAY74RV010 = "QAY74RV010";

        /// <summary>
        /// QAY74RSD.
        /// </summary>
        public const string QAY74RSD = "QAY74RSD";
    }

    /// <inheritdoc />
    public override string TableName => "F74R0001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QAY74RCRCD", "QAY74RCRCD", JdeDataType.String, 20, true, true),
        new JdeField("QALAN", "QALAN", JdeDataType.String, 4, true, true),
        new JdeField("QAY74RCRUS", "QAY74RCRUS", JdeDataType.String, 2, true, true),
        new JdeField("QAY74RDECL", "QAY74RDECL", JdeDataType.Numeric, null, true, true),
        new JdeField("QAY74RV001", "QAY74RV001", JdeDataType.String, 60),
        new JdeField("QAY74RV002", "QAY74RV002", JdeDataType.String, 60),
        new JdeField("QAY74RV003", "QAY74RV003", JdeDataType.String, 60),
        new JdeField("QAY74RV004", "QAY74RV004", JdeDataType.String, 60),
        new JdeField("QAY74RV005", "QAY74RV005", JdeDataType.String, 60),
        new JdeField("QAY74RV006", "QAY74RV006", JdeDataType.String, 60),
        new JdeField("QAY74RV007", "QAY74RV007", JdeDataType.String, 60),
        new JdeField("QAY74RV008", "QAY74RV008", JdeDataType.String, 60),
        new JdeField("QAY74RV009", "QAY74RV009", JdeDataType.String, 60),
        new JdeField("QAY74RV010", "QAY74RV010", JdeDataType.String, 60),
        new JdeField("QAY74RSD", "QAY74RSD", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R0001_0", "Primary Key on QAY74RCRCD, QALAN, QAY74RCRUS, QAY74RDECL", new[] { "QAY74RCRCD", "QALAN", "QAY74RCRUS", "QAY74RDECL" }, isUnique: true, isPrimaryKey: true)
    };
}
