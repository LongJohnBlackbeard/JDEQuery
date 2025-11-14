using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F54HS15 - .
/// </summary>
public class F54HS15 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SUHSIIRT.
        /// </summary>
        public const string SUHSIIRT = "SUHSIIRT";

        /// <summary>
        /// SUHSIGP.
        /// </summary>
        public const string SUHSIGP = "SUHSIGP";

        /// <summary>
        /// SUHSIFN.
        /// </summary>
        public const string SUHSIFN = "SUHSIFN";

        /// <summary>
        /// SUHSIFD.
        /// </summary>
        public const string SUHSIFD = "SUHSIFD";

        /// <summary>
        /// SUHSITY.
        /// </summary>
        public const string SUHSITY = "SUHSITY";

        /// <summary>
        /// SUHSIDTS.
        /// </summary>
        public const string SUHSIDTS = "SUHSIDTS";

        /// <summary>
        /// SUCDEC.
        /// </summary>
        public const string SUCDEC = "SUCDEC";

        /// <summary>
        /// SUHSIJY.
        /// </summary>
        public const string SUHSIJY = "SUHSIJY";

        /// <summary>
        /// SUSY.
        /// </summary>
        public const string SUSY = "SUSY";

        /// <summary>
        /// SURT.
        /// </summary>
        public const string SURT = "SURT";

        /// <summary>
        /// SUHSIRF.
        /// </summary>
        public const string SUHSIRF = "SUHSIRF";

        /// <summary>
        /// SUHSITB.
        /// </summary>
        public const string SUHSITB = "SUHSITB";

        /// <summary>
        /// SUUSER.
        /// </summary>
        public const string SUUSER = "SUUSER";

        /// <summary>
        /// SUPID.
        /// </summary>
        public const string SUPID = "SUPID";

        /// <summary>
        /// SUUPMJ.
        /// </summary>
        public const string SUUPMJ = "SUUPMJ";

        /// <summary>
        /// SUUPMT.
        /// </summary>
        public const string SUUPMT = "SUUPMT";

        /// <summary>
        /// SUMKEY.
        /// </summary>
        public const string SUMKEY = "SUMKEY";

        /// <summary>
        /// SUENTJ.
        /// </summary>
        public const string SUENTJ = "SUENTJ";

        /// <summary>
        /// SUTORG.
        /// </summary>
        public const string SUTORG = "SUTORG";
    }

    /// <inheritdoc />
    public override string TableName => "F54HS15";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SUHSIIRT", "SUHSIIRT", JdeDataType.String, 6, true, true),
        new JdeField("SUHSIGP", "SUHSIGP", JdeDataType.String, 20, true, true),
        new JdeField("SUHSIFN", "SUHSIFN", JdeDataType.Numeric, null, true, true),
        new JdeField("SUHSIFD", "SUHSIFD", JdeDataType.String, 100),
        new JdeField("SUHSITY", "SUHSITY", JdeDataType.String, 2),
        new JdeField("SUHSIDTS", "SUHSIDTS", JdeDataType.Numeric),
        new JdeField("SUCDEC", "SUCDEC", JdeDataType.String, 2),
        new JdeField("SUHSIJY", "SUHSIJY", JdeDataType.String, 2),
        new JdeField("SUSY", "SUSY", JdeDataType.String, 8),
        new JdeField("SURT", "SURT", JdeDataType.String, 4),
        new JdeField("SUHSIRF", "SUHSIRF", JdeDataType.String, 2),
        new JdeField("SUHSITB", "SUHSITB", JdeDataType.String, 20),
        new JdeField("SUUSER", "SUUSER", JdeDataType.String, 20),
        new JdeField("SUPID", "SUPID", JdeDataType.String, 20),
        new JdeField("SUUPMJ", "SUUPMJ", JdeDataType.Numeric),
        new JdeField("SUUPMT", "SUUPMT", JdeDataType.Numeric),
        new JdeField("SUMKEY", "SUMKEY", JdeDataType.String, 30),
        new JdeField("SUENTJ", "SUENTJ", JdeDataType.Numeric),
        new JdeField("SUTORG", "SUTORG", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F54HS15_0", "Primary Key on SUHSIIRT, SUHSIGP, SUHSIFN", new[] { "SUHSIIRT", "SUHSIGP", "SUHSIFN" }, isUnique: true, isPrimaryKey: true)
    };
}
