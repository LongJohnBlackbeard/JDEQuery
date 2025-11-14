using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74405 - .
/// </summary>
public class F74405 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RCIRC1.
        /// </summary>
        public const string RCIRC1 = "RCIRC1";

        /// <summary>
        /// RCIRC2.
        /// </summary>
        public const string RCIRC2 = "RCIRC2";

        /// <summary>
        /// RCIRDE.
        /// </summary>
        public const string RCIRDE = "RCIRDE";

        /// <summary>
        /// RCIRDA.
        /// </summary>
        public const string RCIRDA = "RCIRDA";

        /// <summary>
        /// RCIRPC.
        /// </summary>
        public const string RCIRPC = "RCIRPC";

        /// <summary>
        /// RCIRPR.
        /// </summary>
        public const string RCIRPR = "RCIRPR";

        /// <summary>
        /// RCIRMO.
        /// </summary>
        public const string RCIRMO = "RCIRMO";

        /// <summary>
        /// RCCBR.
        /// </summary>
        public const string RCCBR = "RCCBR";

        /// <summary>
        /// RCIWTP.
        /// </summary>
        public const string RCIWTP = "RCIWTP";

        /// <summary>
        /// RCIWTT.
        /// </summary>
        public const string RCIWTT = "RCIWTT";

        /// <summary>
        /// RCIBFL.
        /// </summary>
        public const string RCIBFL = "RCIBFL";

        /// <summary>
        /// RCI74IRPR.
        /// </summary>
        public const string RCI74IRPR = "RCI74IRPR";
    }

    /// <inheritdoc />
    public override string TableName => "F74405";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RCIRC1", "RCIRC1", JdeDataType.String, 4, true, true),
        new JdeField("RCIRC2", "RCIRC2", JdeDataType.String, 16),
        new JdeField("RCIRDE", "RCIRDE", JdeDataType.String, 100),
        new JdeField("RCIRDA", "RCIRDA", JdeDataType.String, 20),
        new JdeField("RCIRPC", "RCIRPC", JdeDataType.Numeric),
        new JdeField("RCIRPR", "RCIRPR", JdeDataType.Numeric),
        new JdeField("RCIRMO", "RCIRMO", JdeDataType.String, 4),
        new JdeField("RCCBR", "RCCBR", JdeDataType.Numeric),
        new JdeField("RCIWTP", "RCIWTP", JdeDataType.Numeric),
        new JdeField("RCIWTT", "RCIWTT", JdeDataType.String, 2),
        new JdeField("RCIBFL", "RCIBFL", JdeDataType.String, 2),
        new JdeField("RCI74IRPR", "RCI74IRPR", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74405_0", "Primary Key on RCIRC1", new[] { "RCIRC1" }, isUnique: true, isPrimaryKey: true)
    };
}
