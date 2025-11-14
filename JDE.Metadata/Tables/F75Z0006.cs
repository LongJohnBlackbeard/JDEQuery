using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75Z0006 - .
/// </summary>
public class F75Z0006 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Z6AN8.
        /// </summary>
        public const string Z6AN8 = "Z6AN8";

        /// <summary>
        /// Z6PRTR.
        /// </summary>
        public const string Z6PRTR = "Z6PRTR";

        /// <summary>
        /// Z6PDBA.
        /// </summary>
        public const string Z6PDBA = "Z6PDBA";

        /// <summary>
        /// Z6AA02.
        /// </summary>
        public const string Z6AA02 = "Z6AA02";

        /// <summary>
        /// Z6PHRW.
        /// </summary>
        public const string Z6PHRW = "Z6PHRW";

        /// <summary>
        /// Z6PHRT.
        /// </summary>
        public const string Z6PHRT = "Z6PHRT";

        /// <summary>
        /// Z6AVGGER.
        /// </summary>
        public const string Z6AVGGER = "Z6AVGGER";

        /// <summary>
        /// Z6NDBA.
        /// </summary>
        public const string Z6NDBA = "Z6NDBA";

        /// <summary>
        /// Z6HRWO.
        /// </summary>
        public const string Z6HRWO = "Z6HRWO";

        /// <summary>
        /// Z6SHRT.
        /// </summary>
        public const string Z6SHRT = "Z6SHRT";

        /// <summary>
        /// Z6AYST.
        /// </summary>
        public const string Z6AYST = "Z6AYST";

        /// <summary>
        /// Z6USER.
        /// </summary>
        public const string Z6USER = "Z6USER";

        /// <summary>
        /// Z6UPMJ.
        /// </summary>
        public const string Z6UPMJ = "Z6UPMJ";

        /// <summary>
        /// Z6UPMT.
        /// </summary>
        public const string Z6UPMT = "Z6UPMT";

        /// <summary>
        /// Z6PID.
        /// </summary>
        public const string Z6PID = "Z6PID";

        /// <summary>
        /// Z6JOBN.
        /// </summary>
        public const string Z6JOBN = "Z6JOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F75Z0006";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Z6AN8", "Z6AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("Z6PRTR", "Z6PRTR", JdeDataType.Numeric, null, true, true),
        new JdeField("Z6PDBA", "Z6PDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("Z6AA02", "Z6AA02", JdeDataType.String, 4),
        new JdeField("Z6PHRW", "Z6PHRW", JdeDataType.Numeric),
        new JdeField("Z6PHRT", "Z6PHRT", JdeDataType.Numeric),
        new JdeField("Z6AVGGER", "Z6AVGGER", JdeDataType.Numeric),
        new JdeField("Z6NDBA", "Z6NDBA", JdeDataType.Numeric),
        new JdeField("Z6HRWO", "Z6HRWO", JdeDataType.Numeric),
        new JdeField("Z6SHRT", "Z6SHRT", JdeDataType.Numeric),
        new JdeField("Z6AYST", "Z6AYST", JdeDataType.String, 2),
        new JdeField("Z6USER", "Z6USER", JdeDataType.String, 20),
        new JdeField("Z6UPMJ", "Z6UPMJ", JdeDataType.Numeric),
        new JdeField("Z6UPMT", "Z6UPMT", JdeDataType.Numeric),
        new JdeField("Z6PID", "Z6PID", JdeDataType.String, 20),
        new JdeField("Z6JOBN", "Z6JOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75Z0006_0", "Primary Key on Z6AN8, Z6PRTR, Z6PDBA", new[] { "Z6AN8", "Z6PRTR", "Z6PDBA" }, isUnique: true, isPrimaryKey: true)
    };
}
