using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF31K11 - .
/// </summary>
public class FF31K11 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PIFSCID.
        /// </summary>
        public const string PIFSCID = "PIFSCID";

        /// <summary>
        /// PIDFMCU.
        /// </summary>
        public const string PIDFMCU = "PIDFMCU";

        /// <summary>
        /// PIPMAPID.
        /// </summary>
        public const string PIPMAPID = "PIPMAPID";

        /// <summary>
        /// PIDFITM.
        /// </summary>
        public const string PIDFITM = "PIDFITM";

        /// <summary>
        /// PIDEPVOL.
        /// </summary>
        public const string PIDEPVOL = "PIDEPVOL";

        /// <summary>
        /// PIINDVOL.
        /// </summary>
        public const string PIINDVOL = "PIINDVOL";

        /// <summary>
        /// PIUOM.
        /// </summary>
        public const string PIUOM = "PIUOM";

        /// <summary>
        /// PIOKCF.
        /// </summary>
        public const string PIOKCF = "PIOKCF";

        /// <summary>
        /// PIOIDQ.
        /// </summary>
        public const string PIOIDQ = "PIOIDQ";

        /// <summary>
        /// PIKNOREP.
        /// </summary>
        public const string PIKNOREP = "PIKNOREP";

        /// <summary>
        /// PIURCD.
        /// </summary>
        public const string PIURCD = "PIURCD";

        /// <summary>
        /// PIURRF.
        /// </summary>
        public const string PIURRF = "PIURRF";

        /// <summary>
        /// PIURDT.
        /// </summary>
        public const string PIURDT = "PIURDT";

        /// <summary>
        /// PIURAT.
        /// </summary>
        public const string PIURAT = "PIURAT";

        /// <summary>
        /// PIURAB.
        /// </summary>
        public const string PIURAB = "PIURAB";

        /// <summary>
        /// PITORG.
        /// </summary>
        public const string PITORG = "PITORG";

        /// <summary>
        /// PIPID.
        /// </summary>
        public const string PIPID = "PIPID";

        /// <summary>
        /// PIUSER.
        /// </summary>
        public const string PIUSER = "PIUSER";

        /// <summary>
        /// PIJOBN.
        /// </summary>
        public const string PIJOBN = "PIJOBN";

        /// <summary>
        /// PIUUPMJ.
        /// </summary>
        public const string PIUUPMJ = "PIUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF31K11";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PIFSCID", "PIFSCID", JdeDataType.Numeric, null, true, true),
        new JdeField("PIDFMCU", "PIDFMCU", JdeDataType.String, 24, true, true),
        new JdeField("PIPMAPID", "PIPMAPID", JdeDataType.Numeric, null, true, true),
        new JdeField("PIDFITM", "PIDFITM", JdeDataType.Numeric, null, true, true),
        new JdeField("PIDEPVOL", "PIDEPVOL", JdeDataType.Numeric),
        new JdeField("PIINDVOL", "PIINDVOL", JdeDataType.Numeric),
        new JdeField("PIUOM", "PIUOM", JdeDataType.String, 4),
        new JdeField("PIOKCF", "PIOKCF", JdeDataType.String, 2),
        new JdeField("PIOIDQ", "PIOIDQ", JdeDataType.Numeric),
        new JdeField("PIKNOREP", "PIKNOREP", JdeDataType.String, 2),
        new JdeField("PIURCD", "PIURCD", JdeDataType.String, 4),
        new JdeField("PIURRF", "PIURRF", JdeDataType.String, 30),
        new JdeField("PIURDT", "PIURDT", JdeDataType.Numeric),
        new JdeField("PIURAT", "PIURAT", JdeDataType.Numeric),
        new JdeField("PIURAB", "PIURAB", JdeDataType.Numeric),
        new JdeField("PITORG", "PITORG", JdeDataType.String, 20),
        new JdeField("PIPID", "PIPID", JdeDataType.String, 20),
        new JdeField("PIUSER", "PIUSER", JdeDataType.String, 20),
        new JdeField("PIJOBN", "PIJOBN", JdeDataType.String, 20),
        new JdeField("PIUUPMJ", "PIUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF31K11_0", "Primary Key on PIFSCID, PIDFMCU, PIPMAPID, PIDFITM", new[] { "PIFSCID", "PIDFMCU", "PIPMAPID", "PIDFITM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF31K11_2", "Index on PIFSCID, PIDFMCU, PIDFITM", new[] { "PIFSCID", "PIDFMCU", "PIDFITM" })
    };
}
