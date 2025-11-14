using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0474N3 - .
/// </summary>
public class F0474N3 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QCAN8.
        /// </summary>
        public const string QCAN8 = "QCAN8";

        /// <summary>
        /// QCWELK.
        /// </summary>
        public const string QCWELK = "QCWELK";

        /// <summary>
        /// QCWIAK.
        /// </summary>
        public const string QCWIAK = "QCWIAK";

        /// <summary>
        /// QCWIBF.
        /// </summary>
        public const string QCWIBF = "QCWIBF";

        /// <summary>
        /// QCWIBM.
        /// </summary>
        public const string QCWIBM = "QCWIBM";

        /// <summary>
        /// QCWTEN.
        /// </summary>
        public const string QCWTEN = "QCWTEN";

        /// <summary>
        /// QCWPGU.
        /// </summary>
        public const string QCWPGU = "QCWPGU";

        /// <summary>
        /// QCWKON.
        /// </summary>
        public const string QCWKON = "QCWKON";

        /// <summary>
        /// QCWOTK.
        /// </summary>
        public const string QCWOTK = "QCWOTK";

        /// <summary>
        /// QCWTER.
        /// </summary>
        public const string QCWTER = "QCWTER";

        /// <summary>
        /// QCPYE.
        /// </summary>
        public const string QCPYE = "QCPYE";

        /// <summary>
        /// QCAA03.
        /// </summary>
        public const string QCAA03 = "QCAA03";

        /// <summary>
        /// QCWFIM.
        /// </summary>
        public const string QCWFIM = "QCWFIM";
    }

    /// <inheritdoc />
    public override string TableName => "F0474N3";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QCAN8", "QCAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("QCWELK", "QCWELK", JdeDataType.String, 2),
        new JdeField("QCWIAK", "QCWIAK", JdeDataType.String, 2),
        new JdeField("QCWIBF", "QCWIBF", JdeDataType.String, 2),
        new JdeField("QCWIBM", "QCWIBM", JdeDataType.String, 2),
        new JdeField("QCWTEN", "QCWTEN", JdeDataType.Numeric),
        new JdeField("QCWPGU", "QCWPGU", JdeDataType.String, 2),
        new JdeField("QCWKON", "QCWKON", JdeDataType.String, 10),
        new JdeField("QCWOTK", "QCWOTK", JdeDataType.String, 2),
        new JdeField("QCWTER", "QCWTER", JdeDataType.String, 12),
        new JdeField("QCPYE", "QCPYE", JdeDataType.Numeric),
        new JdeField("QCAA03", "QCAA03", JdeDataType.String, 6),
        new JdeField("QCWFIM", "QCWFIM", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0474N3_0", "Primary Key on QCAN8", new[] { "QCAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0474N3_2", "Unique Index on SYS_NC00014$", new[] { "SYS_NC00014$" }, isUnique: true)
    };
}
