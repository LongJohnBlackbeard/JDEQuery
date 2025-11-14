using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4277720 - .
/// </summary>
public class F4277720 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AHALLRNME.
        /// </summary>
        public const string AHALLRNME = "AHALLRNME";

        /// <summary>
        /// AHALLDESC.
        /// </summary>
        public const string AHALLDESC = "AHALLDESC";

        /// <summary>
        /// AHURCD.
        /// </summary>
        public const string AHURCD = "AHURCD";

        /// <summary>
        /// AHURAT.
        /// </summary>
        public const string AHURAT = "AHURAT";

        /// <summary>
        /// AHURRF.
        /// </summary>
        public const string AHURRF = "AHURRF";

        /// <summary>
        /// AHURAB.
        /// </summary>
        public const string AHURAB = "AHURAB";

        /// <summary>
        /// AHURDT.
        /// </summary>
        public const string AHURDT = "AHURDT";

        /// <summary>
        /// AHUSER.
        /// </summary>
        public const string AHUSER = "AHUSER";

        /// <summary>
        /// AHPID.
        /// </summary>
        public const string AHPID = "AHPID";

        /// <summary>
        /// AHUPMJ.
        /// </summary>
        public const string AHUPMJ = "AHUPMJ";

        /// <summary>
        /// AHTDAY.
        /// </summary>
        public const string AHTDAY = "AHTDAY";

        /// <summary>
        /// AHUTIME.
        /// </summary>
        public const string AHUTIME = "AHUTIME";

        /// <summary>
        /// AHCTID.
        /// </summary>
        public const string AHCTID = "AHCTID";
    }

    /// <inheritdoc />
    public override string TableName => "F4277720";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AHALLRNME", "AHALLRNME", JdeDataType.String, 30, true, true),
        new JdeField("AHALLDESC", "AHALLDESC", JdeDataType.String, 60),
        new JdeField("AHURCD", "AHURCD", JdeDataType.String, 4),
        new JdeField("AHURAT", "AHURAT", JdeDataType.Numeric),
        new JdeField("AHURRF", "AHURRF", JdeDataType.String, 30),
        new JdeField("AHURAB", "AHURAB", JdeDataType.Numeric),
        new JdeField("AHURDT", "AHURDT", JdeDataType.Numeric),
        new JdeField("AHUSER", "AHUSER", JdeDataType.String, 20),
        new JdeField("AHPID", "AHPID", JdeDataType.String, 20),
        new JdeField("AHUPMJ", "AHUPMJ", JdeDataType.Numeric),
        new JdeField("AHTDAY", "AHTDAY", JdeDataType.Numeric),
        new JdeField("AHUTIME", "AHUTIME", JdeDataType.Date),
        new JdeField("AHCTID", "AHCTID", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4277720_0", "Primary Key on AHALLRNME", new[] { "AHALLRNME" }, isUnique: true, isPrimaryKey: true)
    };
}
