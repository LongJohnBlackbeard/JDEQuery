using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0701731 - .
/// </summary>
public class F0701731 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YCTARA.
        /// </summary>
        public const string YCTARA = "YCTARA";

        /// <summary>
        /// YCPTAX.
        /// </summary>
        public const string YCPTAX = "YCPTAX";

        /// <summary>
        /// YCVTFC.
        /// </summary>
        public const string YCVTFC = "YCVTFC";

        /// <summary>
        /// YCDESC.
        /// </summary>
        public const string YCDESC = "YCDESC";

        /// <summary>
        /// YCEV01.
        /// </summary>
        public const string YCEV01 = "YCEV01";

        /// <summary>
        /// YCP01.
        /// </summary>
        public const string YCP01 = "YCP01";

        /// <summary>
        /// YCP02.
        /// </summary>
        public const string YCP02 = "YCP02";

        /// <summary>
        /// YCP03.
        /// </summary>
        public const string YCP03 = "YCP03";

        /// <summary>
        /// YCP04.
        /// </summary>
        public const string YCP04 = "YCP04";

        /// <summary>
        /// YCP05.
        /// </summary>
        public const string YCP05 = "YCP05";

        /// <summary>
        /// YCUPMJ.
        /// </summary>
        public const string YCUPMJ = "YCUPMJ";

        /// <summary>
        /// YCPID.
        /// </summary>
        public const string YCPID = "YCPID";

        /// <summary>
        /// YCUSER.
        /// </summary>
        public const string YCUSER = "YCUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F0701731";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YCTARA", "YCTARA", JdeDataType.String, 20, true, true),
        new JdeField("YCPTAX", "YCPTAX", JdeDataType.String, 4, true, true),
        new JdeField("YCVTFC", "YCVTFC", JdeDataType.String, 8, true, true),
        new JdeField("YCDESC", "YCDESC", JdeDataType.String, 60),
        new JdeField("YCEV01", "YCEV01", JdeDataType.String, 2),
        new JdeField("YCP01", "YCP01", JdeDataType.String, 6),
        new JdeField("YCP02", "YCP02", JdeDataType.String, 6),
        new JdeField("YCP03", "YCP03", JdeDataType.String, 6),
        new JdeField("YCP04", "YCP04", JdeDataType.String, 6),
        new JdeField("YCP05", "YCP05", JdeDataType.String, 6),
        new JdeField("YCUPMJ", "YCUPMJ", JdeDataType.Numeric),
        new JdeField("YCPID", "YCPID", JdeDataType.String, 20),
        new JdeField("YCUSER", "YCUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0701731_0", "Primary Key on YCTARA, YCPTAX, YCVTFC", new[] { "YCTARA", "YCPTAX", "YCVTFC" }, isUnique: true, isPrimaryKey: true)
    };
}
