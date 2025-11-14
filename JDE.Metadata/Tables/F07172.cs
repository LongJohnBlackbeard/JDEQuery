using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07172 - .
/// </summary>
public class F07172 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YDDTEY.
        /// </summary>
        public const string YDDTEY = "YDDTEY";

        /// <summary>
        /// YDPFRQ.
        /// </summary>
        public const string YDPFRQ = "YDPFRQ";

        /// <summary>
        /// YDMXIP.
        /// </summary>
        public const string YDMXIP = "YDMXIP";

        /// <summary>
        /// YDMIPY.
        /// </summary>
        public const string YDMIPY = "YDMIPY";

        /// <summary>
        /// YDPHRW.
        /// </summary>
        public const string YDPHRW = "YDPHRW";
    }

    /// <inheritdoc />
    public override string TableName => "F07172";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YDDTEY", "YDDTEY", JdeDataType.Numeric, null, true, true),
        new JdeField("YDPFRQ", "YDPFRQ", JdeDataType.String, 2, true, true),
        new JdeField("YDMXIP", "YDMXIP", JdeDataType.Numeric),
        new JdeField("YDMIPY", "YDMIPY", JdeDataType.Numeric),
        new JdeField("YDPHRW", "YDPHRW", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07172_0", "Primary Key on YDDTEY, YDPFRQ", new[] { "YDDTEY", "YDPFRQ" }, isUnique: true, isPrimaryKey: true)
    };
}
