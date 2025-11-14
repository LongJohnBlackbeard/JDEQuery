using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40070 - .
/// </summary>
public class F40070 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PFPRFR.
        /// </summary>
        public const string PFPRFR = "PFPRFR";

        /// <summary>
        /// PFENED.
        /// </summary>
        public const string PFENED = "PFENED";

        /// <summary>
        /// PFENQT.
        /// </summary>
        public const string PFENQT = "PFENQT";

        /// <summary>
        /// PFPCLS.
        /// </summary>
        public const string PFPCLS = "PFPCLS";

        /// <summary>
        /// PFOSEQ.
        /// </summary>
        public const string PFOSEQ = "PFOSEQ";

        /// <summary>
        /// PFURCD.
        /// </summary>
        public const string PFURCD = "PFURCD";

        /// <summary>
        /// PFURDT.
        /// </summary>
        public const string PFURDT = "PFURDT";

        /// <summary>
        /// PFURAT.
        /// </summary>
        public const string PFURAT = "PFURAT";

        /// <summary>
        /// PFURAB.
        /// </summary>
        public const string PFURAB = "PFURAB";

        /// <summary>
        /// PFURRF.
        /// </summary>
        public const string PFURRF = "PFURRF";

        /// <summary>
        /// PFUSER.
        /// </summary>
        public const string PFUSER = "PFUSER";

        /// <summary>
        /// PFPID.
        /// </summary>
        public const string PFPID = "PFPID";

        /// <summary>
        /// PFJOBN.
        /// </summary>
        public const string PFJOBN = "PFJOBN";

        /// <summary>
        /// PFUPMJ.
        /// </summary>
        public const string PFUPMJ = "PFUPMJ";

        /// <summary>
        /// PFTDAY.
        /// </summary>
        public const string PFTDAY = "PFTDAY";

        /// <summary>
        /// PFPRQR.
        /// </summary>
        public const string PFPRQR = "PFPRQR";

        /// <summary>
        /// PFADTV.
        /// </summary>
        public const string PFADTV = "PFADTV";
    }

    /// <inheritdoc />
    public override string TableName => "F40070";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PFPRFR", "PFPRFR", JdeDataType.String, 4, true, true),
        new JdeField("PFENED", "PFENED", JdeDataType.String, 2),
        new JdeField("PFENQT", "PFENQT", JdeDataType.String, 2),
        new JdeField("PFPCLS", "PFPCLS", JdeDataType.String, 4),
        new JdeField("PFOSEQ", "PFOSEQ", JdeDataType.Numeric),
        new JdeField("PFURCD", "PFURCD", JdeDataType.String, 4),
        new JdeField("PFURDT", "PFURDT", JdeDataType.Numeric),
        new JdeField("PFURAT", "PFURAT", JdeDataType.Numeric),
        new JdeField("PFURAB", "PFURAB", JdeDataType.Numeric),
        new JdeField("PFURRF", "PFURRF", JdeDataType.String, 30),
        new JdeField("PFUSER", "PFUSER", JdeDataType.String, 20),
        new JdeField("PFPID", "PFPID", JdeDataType.String, 20),
        new JdeField("PFJOBN", "PFJOBN", JdeDataType.String, 20),
        new JdeField("PFUPMJ", "PFUPMJ", JdeDataType.Numeric),
        new JdeField("PFTDAY", "PFTDAY", JdeDataType.Numeric),
        new JdeField("PFPRQR", "PFPRQR", JdeDataType.String, 2),
        new JdeField("PFADTV", "PFADTV", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40070_0", "Primary Key on PFPRFR", new[] { "PFPRFR" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40070_2", "Index on PFPCLS, PFOSEQ", new[] { "PFPCLS", "PFOSEQ" })
    };
}
