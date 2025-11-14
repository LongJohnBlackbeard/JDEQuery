using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40306 - .
/// </summary>
public class F40306 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SRAN8.
        /// </summary>
        public const string SRAN8 = "SRAN8";

        /// <summary>
        /// SRCS06.
        /// </summary>
        public const string SRCS06 = "SRCS06";

        /// <summary>
        /// SRITM.
        /// </summary>
        public const string SRITM = "SRITM";

        /// <summary>
        /// SRIT06.
        /// </summary>
        public const string SRIT06 = "SRIT06";

        /// <summary>
        /// SREFTJ.
        /// </summary>
        public const string SREFTJ = "SREFTJ";

        /// <summary>
        /// SREXDJ.
        /// </summary>
        public const string SREXDJ = "SREXDJ";

        /// <summary>
        /// SRMNQ.
        /// </summary>
        public const string SRMNQ = "SRMNQ";

        /// <summary>
        /// SRMXQ.
        /// </summary>
        public const string SRMXQ = "SRMXQ";

        /// <summary>
        /// SRUOM.
        /// </summary>
        public const string SRUOM = "SRUOM";

        /// <summary>
        /// SRTXID.
        /// </summary>
        public const string SRTXID = "SRTXID";

        /// <summary>
        /// SRSTPR.
        /// </summary>
        public const string SRSTPR = "SRSTPR";

        /// <summary>
        /// SROSEQ.
        /// </summary>
        public const string SROSEQ = "SROSEQ";

        /// <summary>
        /// SRMCU.
        /// </summary>
        public const string SRMCU = "SRMCU";

        /// <summary>
        /// SRMOT.
        /// </summary>
        public const string SRMOT = "SRMOT";

        /// <summary>
        /// SRROUT.
        /// </summary>
        public const string SRROUT = "SRROUT";

        /// <summary>
        /// SRCARS.
        /// </summary>
        public const string SRCARS = "SRCARS";

        /// <summary>
        /// SRPCFL.
        /// </summary>
        public const string SRPCFL = "SRPCFL";

        /// <summary>
        /// SRURCD.
        /// </summary>
        public const string SRURCD = "SRURCD";

        /// <summary>
        /// SRURDT.
        /// </summary>
        public const string SRURDT = "SRURDT";

        /// <summary>
        /// SRURAT.
        /// </summary>
        public const string SRURAT = "SRURAT";

        /// <summary>
        /// SRURAB.
        /// </summary>
        public const string SRURAB = "SRURAB";

        /// <summary>
        /// SRURRF.
        /// </summary>
        public const string SRURRF = "SRURRF";

        /// <summary>
        /// SRUSER.
        /// </summary>
        public const string SRUSER = "SRUSER";

        /// <summary>
        /// SRPID.
        /// </summary>
        public const string SRPID = "SRPID";

        /// <summary>
        /// SRJOBN.
        /// </summary>
        public const string SRJOBN = "SRJOBN";

        /// <summary>
        /// SRUPMJ.
        /// </summary>
        public const string SRUPMJ = "SRUPMJ";

        /// <summary>
        /// SRTDAY.
        /// </summary>
        public const string SRTDAY = "SRTDAY";

        /// <summary>
        /// SRSBCK.
        /// </summary>
        public const string SRSBCK = "SRSBCK";

        /// <summary>
        /// SREDCK.
        /// </summary>
        public const string SREDCK = "SREDCK";

        /// <summary>
        /// SRCMDM.
        /// </summary>
        public const string SRCMDM = "SRCMDM";

        /// <summary>
        /// SRBBCK.
        /// </summary>
        public const string SRBBCK = "SRBBCK";
    }

    /// <inheritdoc />
    public override string TableName => "F40306";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SRAN8", "SRAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("SRCS06", "SRCS06", JdeDataType.String, 16, true, true),
        new JdeField("SRITM", "SRITM", JdeDataType.Numeric, null, true, true),
        new JdeField("SRIT06", "SRIT06", JdeDataType.String, 16, true, true),
        new JdeField("SREFTJ", "SREFTJ", JdeDataType.Numeric),
        new JdeField("SREXDJ", "SREXDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("SRMNQ", "SRMNQ", JdeDataType.Numeric),
        new JdeField("SRMXQ", "SRMXQ", JdeDataType.Numeric, null, true, true),
        new JdeField("SRUOM", "SRUOM", JdeDataType.String, 4, true, true),
        new JdeField("SRTXID", "SRTXID", JdeDataType.Numeric),
        new JdeField("SRSTPR", "SRSTPR", JdeDataType.String, 2),
        new JdeField("SROSEQ", "SROSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("SRMCU", "SRMCU", JdeDataType.String, 24),
        new JdeField("SRMOT", "SRMOT", JdeDataType.String, 6),
        new JdeField("SRROUT", "SRROUT", JdeDataType.String, 6),
        new JdeField("SRCARS", "SRCARS", JdeDataType.Numeric),
        new JdeField("SRPCFL", "SRPCFL", JdeDataType.Numeric),
        new JdeField("SRURCD", "SRURCD", JdeDataType.String, 4),
        new JdeField("SRURDT", "SRURDT", JdeDataType.Numeric),
        new JdeField("SRURAT", "SRURAT", JdeDataType.Numeric),
        new JdeField("SRURAB", "SRURAB", JdeDataType.Numeric),
        new JdeField("SRURRF", "SRURRF", JdeDataType.String, 30),
        new JdeField("SRUSER", "SRUSER", JdeDataType.String, 20),
        new JdeField("SRPID", "SRPID", JdeDataType.String, 20),
        new JdeField("SRJOBN", "SRJOBN", JdeDataType.String, 20),
        new JdeField("SRUPMJ", "SRUPMJ", JdeDataType.Numeric),
        new JdeField("SRTDAY", "SRTDAY", JdeDataType.Numeric),
        new JdeField("SRSBCK", "SRSBCK", JdeDataType.String, 2),
        new JdeField("SREDCK", "SREDCK", JdeDataType.String, 2),
        new JdeField("SRCMDM", "SRCMDM", JdeDataType.String, 2),
        new JdeField("SRBBCK", "SRBBCK", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40306_0", "Primary Key on SRAN8, SRCS06, SRITM, SRIT06, SREXDJ, SRUOM, SRMXQ, SROSEQ", new[] { "SRAN8", "SRCS06", "SRITM", "SRIT06", "SREXDJ", "SRUOM", "SRMXQ", "SROSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
