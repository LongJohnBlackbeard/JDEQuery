using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D280 - .
/// </summary>
public class F80D280 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AGPRDJ.
        /// </summary>
        public const string AGPRDJ = "AGPRDJ";

        /// <summary>
        /// AGMCU.
        /// </summary>
        public const string AGMCU = "AGMCU";

        /// <summary>
        /// AGAMTIN.
        /// </summary>
        public const string AGAMTIN = "AGAMTIN";

        /// <summary>
        /// AGAMTRV.
        /// </summary>
        public const string AGAMTRV = "AGAMTRV";

        /// <summary>
        /// AGCNTIN.
        /// </summary>
        public const string AGCNTIN = "AGCNTIN";

        /// <summary>
        /// AGCNTRC.
        /// </summary>
        public const string AGCNTRC = "AGCNTRC";

        /// <summary>
        /// AGUSER.
        /// </summary>
        public const string AGUSER = "AGUSER";

        /// <summary>
        /// AGPID.
        /// </summary>
        public const string AGPID = "AGPID";

        /// <summary>
        /// AGMKEY.
        /// </summary>
        public const string AGMKEY = "AGMKEY";

        /// <summary>
        /// AGUTIME.
        /// </summary>
        public const string AGUTIME = "AGUTIME";

        /// <summary>
        /// AGURCD.
        /// </summary>
        public const string AGURCD = "AGURCD";

        /// <summary>
        /// AGURDT.
        /// </summary>
        public const string AGURDT = "AGURDT";

        /// <summary>
        /// AGURAT.
        /// </summary>
        public const string AGURAT = "AGURAT";

        /// <summary>
        /// AGURAB.
        /// </summary>
        public const string AGURAB = "AGURAB";

        /// <summary>
        /// AGURRF.
        /// </summary>
        public const string AGURRF = "AGURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F80D280";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AGPRDJ", "AGPRDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("AGMCU", "AGMCU", JdeDataType.String, 24, true, true),
        new JdeField("AGAMTIN", "AGAMTIN", JdeDataType.Numeric),
        new JdeField("AGAMTRV", "AGAMTRV", JdeDataType.Numeric),
        new JdeField("AGCNTIN", "AGCNTIN", JdeDataType.Numeric),
        new JdeField("AGCNTRC", "AGCNTRC", JdeDataType.Numeric),
        new JdeField("AGUSER", "AGUSER", JdeDataType.String, 20),
        new JdeField("AGPID", "AGPID", JdeDataType.String, 20),
        new JdeField("AGMKEY", "AGMKEY", JdeDataType.String, 30),
        new JdeField("AGUTIME", "AGUTIME", JdeDataType.Date),
        new JdeField("AGURCD", "AGURCD", JdeDataType.String, 4),
        new JdeField("AGURDT", "AGURDT", JdeDataType.Numeric),
        new JdeField("AGURAT", "AGURAT", JdeDataType.Numeric),
        new JdeField("AGURAB", "AGURAB", JdeDataType.Numeric),
        new JdeField("AGURRF", "AGURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D280_0", "Primary Key on AGPRDJ, AGMCU", new[] { "AGPRDJ", "AGMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
