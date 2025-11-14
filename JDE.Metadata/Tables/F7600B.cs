using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7600B - .
/// </summary>
public class F7600B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NIFCO.
        /// </summary>
        public const string NIFCO = "NIFCO";

        /// <summary>
        /// NIBSER.
        /// </summary>
        public const string NIBSER = "NIBSER";

        /// <summary>
        /// NIDCT.
        /// </summary>
        public const string NIDCT = "NIDCT";

        /// <summary>
        /// NIBNNF.
        /// </summary>
        public const string NIBNNF = "NIBNNF";

        /// <summary>
        /// NIBMXL.
        /// </summary>
        public const string NIBMXL = "NIBMXL";

        /// <summary>
        /// NIMAXO.
        /// </summary>
        public const string NIMAXO = "NIMAXO";

        /// <summary>
        /// NIBMSL.
        /// </summary>
        public const string NIBMSL = "NIBMSL";

        /// <summary>
        /// NIBRTL.
        /// </summary>
        public const string NIBRTL = "NIBRTL";

        /// <summary>
        /// NIKCO.
        /// </summary>
        public const string NIKCO = "NIKCO";

        /// <summary>
        /// NITORG.
        /// </summary>
        public const string NITORG = "NITORG";

        /// <summary>
        /// NIUSER.
        /// </summary>
        public const string NIUSER = "NIUSER";

        /// <summary>
        /// NIPID.
        /// </summary>
        public const string NIPID = "NIPID";

        /// <summary>
        /// NIJOBN.
        /// </summary>
        public const string NIJOBN = "NIJOBN";

        /// <summary>
        /// NIUPMJ.
        /// </summary>
        public const string NIUPMJ = "NIUPMJ";

        /// <summary>
        /// NITDAY.
        /// </summary>
        public const string NITDAY = "NITDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F7600B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NIFCO", "NIFCO", JdeDataType.String, 10, true, true),
        new JdeField("NIBSER", "NIBSER", JdeDataType.String, 4, true, true),
        new JdeField("NIDCT", "NIDCT", JdeDataType.String, 4, true, true),
        new JdeField("NIBNNF", "NIBNNF", JdeDataType.Numeric),
        new JdeField("NIBMXL", "NIBMXL", JdeDataType.Numeric),
        new JdeField("NIMAXO", "NIMAXO", JdeDataType.Numeric),
        new JdeField("NIBMSL", "NIBMSL", JdeDataType.Numeric),
        new JdeField("NIBRTL", "NIBRTL", JdeDataType.Numeric),
        new JdeField("NIKCO", "NIKCO", JdeDataType.String, 10),
        new JdeField("NITORG", "NITORG", JdeDataType.String, 20),
        new JdeField("NIUSER", "NIUSER", JdeDataType.String, 20),
        new JdeField("NIPID", "NIPID", JdeDataType.String, 20),
        new JdeField("NIJOBN", "NIJOBN", JdeDataType.String, 20),
        new JdeField("NIUPMJ", "NIUPMJ", JdeDataType.Numeric),
        new JdeField("NITDAY", "NITDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7600B_0", "Primary Key on NIFCO, NIBSER, NIDCT", new[] { "NIFCO", "NIBSER", "NIDCT" }, isUnique: true, isPrimaryKey: true)
    };
}
