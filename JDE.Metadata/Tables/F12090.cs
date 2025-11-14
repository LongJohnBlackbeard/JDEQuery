using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F12090 - .
/// </summary>
public class F12090 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// F2TYDD.
        /// </summary>
        public const string F2TYDD = "F2TYDD";

        /// <summary>
        /// F2DSPM.
        /// </summary>
        public const string F2DSPM = "F2DSPM";

        /// <summary>
        /// F2DL01.
        /// </summary>
        public const string F2DL01 = "F2DL01";

        /// <summary>
        /// F2SY.
        /// </summary>
        public const string F2SY = "F2SY";

        /// <summary>
        /// F2RT.
        /// </summary>
        public const string F2RT = "F2RT";

        /// <summary>
        /// F2GDC1.
        /// </summary>
        public const string F2GDC1 = "F2GDC1";

        /// <summary>
        /// F2GDC2.
        /// </summary>
        public const string F2GDC2 = "F2GDC2";

        /// <summary>
        /// F2GDC3.
        /// </summary>
        public const string F2GDC3 = "F2GDC3";

        /// <summary>
        /// F2GDC4.
        /// </summary>
        public const string F2GDC4 = "F2GDC4";

        /// <summary>
        /// F2WSCH.
        /// </summary>
        public const string F2WSCH = "F2WSCH";
    }

    /// <inheritdoc />
    public override string TableName => "F12090";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("F2TYDD", "F2TYDD", JdeDataType.String, 4, true, true),
        new JdeField("F2DSPM", "F2DSPM", JdeDataType.String, 2),
        new JdeField("F2DL01", "F2DL01", JdeDataType.String, 60),
        new JdeField("F2SY", "F2SY", JdeDataType.String, 8),
        new JdeField("F2RT", "F2RT", JdeDataType.String, 4),
        new JdeField("F2GDC1", "F2GDC1", JdeDataType.String, 20),
        new JdeField("F2GDC2", "F2GDC2", JdeDataType.String, 20),
        new JdeField("F2GDC3", "F2GDC3", JdeDataType.String, 60),
        new JdeField("F2GDC4", "F2GDC4", JdeDataType.String, 60),
        new JdeField("F2WSCH", "F2WSCH", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F12090_0", "Primary Key on F2TYDD", new[] { "F2TYDD" }, isUnique: true, isPrimaryKey: true)
    };
}
