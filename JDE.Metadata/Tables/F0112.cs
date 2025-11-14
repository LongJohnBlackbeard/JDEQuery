using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0112 - .
/// </summary>
public class F0112 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PTAN8.
        /// </summary>
        public const string PTAN8 = "PTAN8";

        /// <summary>
        /// PTALPH.
        /// </summary>
        public const string PTALPH = "PTALPH";

        /// <summary>
        /// PTATYP.
        /// </summary>
        public const string PTATYP = "PTATYP";

        /// <summary>
        /// PTRMK.
        /// </summary>
        public const string PTRMK = "PTRMK";

        /// <summary>
        /// PTPDO.
        /// </summary>
        public const string PTPDO = "PTPDO";

        /// <summary>
        /// PTPTO.
        /// </summary>
        public const string PTPTO = "PTPTO";

        /// <summary>
        /// PTPDI.
        /// </summary>
        public const string PTPDI = "PTPDI";

        /// <summary>
        /// PTPTI.
        /// </summary>
        public const string PTPTI = "PTPTI";

        /// <summary>
        /// PTENTT.
        /// </summary>
        public const string PTENTT = "PTENTT";

        /// <summary>
        /// PTUSER.
        /// </summary>
        public const string PTUSER = "PTUSER";

        /// <summary>
        /// PTPID.
        /// </summary>
        public const string PTPID = "PTPID";

        /// <summary>
        /// PTUPMJ.
        /// </summary>
        public const string PTUPMJ = "PTUPMJ";

        /// <summary>
        /// PTJOBN.
        /// </summary>
        public const string PTJOBN = "PTJOBN";

        /// <summary>
        /// PTUPMT.
        /// </summary>
        public const string PTUPMT = "PTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F0112";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PTAN8", "PTAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PTALPH", "PTALPH", JdeDataType.String, 80),
        new JdeField("PTATYP", "PTATYP", JdeDataType.String, 2),
        new JdeField("PTRMK", "PTRMK", JdeDataType.String, 60),
        new JdeField("PTPDO", "PTPDO", JdeDataType.Numeric, null, true, true),
        new JdeField("PTPTO", "PTPTO", JdeDataType.Numeric, null, true, true),
        new JdeField("PTPDI", "PTPDI", JdeDataType.Numeric),
        new JdeField("PTPTI", "PTPTI", JdeDataType.Numeric),
        new JdeField("PTENTT", "PTENTT", JdeDataType.Numeric),
        new JdeField("PTUSER", "PTUSER", JdeDataType.String, 20),
        new JdeField("PTPID", "PTPID", JdeDataType.String, 20),
        new JdeField("PTUPMJ", "PTUPMJ", JdeDataType.Numeric),
        new JdeField("PTJOBN", "PTJOBN", JdeDataType.String, 20),
        new JdeField("PTUPMT", "PTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0112_0", "Primary Key on PTAN8, PTPDO, PTPTO", new[] { "PTAN8", "PTPDO", "PTPTO" }, isUnique: true, isPrimaryKey: true)
    };
}
