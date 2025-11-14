using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43E095 - .
/// </summary>
public class F43E095 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ACCMDCDE.
        /// </summary>
        public const string ACCMDCDE = "ACCMDCDE";

        /// <summary>
        /// ACMCU.
        /// </summary>
        public const string ACMCU = "ACMCU";

        /// <summary>
        /// ACALIM.
        /// </summary>
        public const string ACALIM = "ACALIM";

        /// <summary>
        /// ACYN.
        /// </summary>
        public const string ACYN = "ACYN";

        /// <summary>
        /// ACAPSD.
        /// </summary>
        public const string ACAPSD = "ACAPSD";

        /// <summary>
        /// ACRPER.
        /// </summary>
        public const string ACRPER = "ACRPER";

        /// <summary>
        /// ACOSTP.
        /// </summary>
        public const string ACOSTP = "ACOSTP";

        /// <summary>
        /// ACUSER.
        /// </summary>
        public const string ACUSER = "ACUSER";

        /// <summary>
        /// ACPID.
        /// </summary>
        public const string ACPID = "ACPID";

        /// <summary>
        /// ACJOBN.
        /// </summary>
        public const string ACJOBN = "ACJOBN";

        /// <summary>
        /// ACUPMJ.
        /// </summary>
        public const string ACUPMJ = "ACUPMJ";

        /// <summary>
        /// ACTDAY.
        /// </summary>
        public const string ACTDAY = "ACTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F43E095";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ACCMDCDE", "ACCMDCDE", JdeDataType.String, 30, true, true),
        new JdeField("ACMCU", "ACMCU", JdeDataType.String, 24, true, true),
        new JdeField("ACALIM", "ACALIM", JdeDataType.Numeric),
        new JdeField("ACYN", "ACYN", JdeDataType.String, 2),
        new JdeField("ACAPSD", "ACAPSD", JdeDataType.String, 2),
        new JdeField("ACRPER", "ACRPER", JdeDataType.Numeric),
        new JdeField("ACOSTP", "ACOSTP", JdeDataType.String, 6),
        new JdeField("ACUSER", "ACUSER", JdeDataType.String, 20),
        new JdeField("ACPID", "ACPID", JdeDataType.String, 20),
        new JdeField("ACJOBN", "ACJOBN", JdeDataType.String, 20),
        new JdeField("ACUPMJ", "ACUPMJ", JdeDataType.Numeric),
        new JdeField("ACTDAY", "ACTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43E095_0", "Primary Key on ACCMDCDE, ACMCU", new[] { "ACCMDCDE", "ACMCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43E095_2", "Index on ACCMDCDE", new[] { "ACCMDCDE" })
    };
}
