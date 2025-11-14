using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08096 - .
/// </summary>
public class F08096 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// H$TBLN.
        /// </summary>
        public const string H_TBLN = "H$TBLN";

        /// <summary>
        /// H$DL01.
        /// </summary>
        public const string H_DL01 = "H$DL01";

        /// <summary>
        /// H$DC.
        /// </summary>
        public const string H_DC = "H$DC";

        /// <summary>
        /// H$DL02.
        /// </summary>
        public const string H_DL02 = "H$DL02";

        /// <summary>
        /// H$DL03.
        /// </summary>
        public const string H_DL03 = "H$DL03";

        /// <summary>
        /// H$DL04.
        /// </summary>
        public const string H_DL04 = "H$DL04";

        /// <summary>
        /// H$DL05.
        /// </summary>
        public const string H_DL05 = "H$DL05";

        /// <summary>
        /// H$TBLT.
        /// </summary>
        public const string H_TBLT = "H$TBLT";

        /// <summary>
        /// H$SY.
        /// </summary>
        public const string H_SY = "H$SY";

        /// <summary>
        /// H$RT.
        /// </summary>
        public const string H_RT = "H$RT";
    }

    /// <inheritdoc />
    public override string TableName => "F08096";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("H$TBLN", "H$TBLN", JdeDataType.Numeric, null, true, true),
        new JdeField("H$DL01", "H$DL01", JdeDataType.String, 60),
        new JdeField("H$DC", "H$DC", JdeDataType.String, 80),
        new JdeField("H$DL02", "H$DL02", JdeDataType.String, 60),
        new JdeField("H$DL03", "H$DL03", JdeDataType.String, 60),
        new JdeField("H$DL04", "H$DL04", JdeDataType.String, 60),
        new JdeField("H$DL05", "H$DL05", JdeDataType.String, 60),
        new JdeField("H$TBLT", "H$TBLT", JdeDataType.String, 2),
        new JdeField("H$SY", "H$SY", JdeDataType.String, 8),
        new JdeField("H$RT", "H$RT", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08096_0", "Primary Key on H$TBLN", new[] { "H$TBLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08096_2", "Index on H$DC", new[] { "H$DC" })
    };
}
