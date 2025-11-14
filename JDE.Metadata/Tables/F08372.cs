using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08372 - .
/// </summary>
public class F08372 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BMAN8.
        /// </summary>
        public const string BMAN8 = "BMAN8";

        /// <summary>
        /// BMPLAN.
        /// </summary>
        public const string BMPLAN = "BMPLAN";

        /// <summary>
        /// BMSEQ.
        /// </summary>
        public const string BMSEQ = "BMSEQ";

        /// <summary>
        /// BMFOA#.
        /// </summary>
        public const string BMFOA_ = "BMFOA#";

        /// <summary>
        /// BMIFO#.
        /// </summary>
        public const string BMIFO_ = "BMIFO#";

        /// <summary>
        /// BMPSDT.
        /// </summary>
        public const string BMPSDT = "BMPSDT";

        /// <summary>
        /// BMPTDT.
        /// </summary>
        public const string BMPTDT = "BMPTDT";

        /// <summary>
        /// BMTCOD.
        /// </summary>
        public const string BMTCOD = "BMTCOD";

        /// <summary>
        /// BMBDM.
        /// </summary>
        public const string BMBDM = "BMBDM";

        /// <summary>
        /// BMADPN.
        /// </summary>
        public const string BMADPN = "BMADPN";

        /// <summary>
        /// BMPREN.
        /// </summary>
        public const string BMPREN = "BMPREN";

        /// <summary>
        /// BMFPCD.
        /// </summary>
        public const string BMFPCD = "BMFPCD";

        /// <summary>
        /// BMGPA.
        /// </summary>
        public const string BMGPA = "BMGPA";

        /// <summary>
        /// BMPID.
        /// </summary>
        public const string BMPID = "BMPID";

        /// <summary>
        /// BMPYCB.
        /// </summary>
        public const string BMPYCB = "BMPYCB";

        /// <summary>
        /// BMUSER.
        /// </summary>
        public const string BMUSER = "BMUSER";

        /// <summary>
        /// BMJOBN.
        /// </summary>
        public const string BMJOBN = "BMJOBN";

        /// <summary>
        /// BMUPMJ.
        /// </summary>
        public const string BMUPMJ = "BMUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F08372";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BMAN8", "BMAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("BMPLAN", "BMPLAN", JdeDataType.String, 16, true, true),
        new JdeField("BMSEQ", "BMSEQ", JdeDataType.Numeric),
        new JdeField("BMFOA#", "BMFOA#", JdeDataType.String, 34),
        new JdeField("BMIFO#", "BMIFO#", JdeDataType.String, 18),
        new JdeField("BMPSDT", "BMPSDT", JdeDataType.Numeric),
        new JdeField("BMPTDT", "BMPTDT", JdeDataType.Numeric),
        new JdeField("BMTCOD", "BMTCOD", JdeDataType.String, 4),
        new JdeField("BMBDM", "BMBDM", JdeDataType.String, 2),
        new JdeField("BMADPN", "BMADPN", JdeDataType.String, 2),
        new JdeField("BMPREN", "BMPREN", JdeDataType.String, 4),
        new JdeField("BMFPCD", "BMFPCD", JdeDataType.String, 2),
        new JdeField("BMGPA", "BMGPA", JdeDataType.Numeric),
        new JdeField("BMPID", "BMPID", JdeDataType.String, 20),
        new JdeField("BMPYCB", "BMPYCB", JdeDataType.Numeric),
        new JdeField("BMUSER", "BMUSER", JdeDataType.String, 20),
        new JdeField("BMJOBN", "BMJOBN", JdeDataType.String, 20),
        new JdeField("BMUPMJ", "BMUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08372_0", "Primary Key on BMAN8, BMPLAN", new[] { "BMAN8", "BMPLAN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08372_2", "Index on BMAN8, BMPLAN, BMFOA#", new[] { "BMAN8", "BMPLAN", "BMFOA#" })
    };
}
