using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L010 - .
/// </summary>
public class FF30L010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SCFSCID.
        /// </summary>
        public const string SCFSCID = "SCFSCID";

        /// <summary>
        /// SCSCEDESC.
        /// </summary>
        public const string SCSCEDESC = "SCSCEDESC";

        /// <summary>
        /// SCSCUOM.
        /// </summary>
        public const string SCSCUOM = "SCSCUOM";

        /// <summary>
        /// SCACTSC.
        /// </summary>
        public const string SCACTSC = "SCACTSC";

        /// <summary>
        /// SCURCD.
        /// </summary>
        public const string SCURCD = "SCURCD";

        /// <summary>
        /// SCURDT.
        /// </summary>
        public const string SCURDT = "SCURDT";

        /// <summary>
        /// SCURAT.
        /// </summary>
        public const string SCURAT = "SCURAT";

        /// <summary>
        /// SCURAB.
        /// </summary>
        public const string SCURAB = "SCURAB";

        /// <summary>
        /// SCURRF.
        /// </summary>
        public const string SCURRF = "SCURRF";

        /// <summary>
        /// SCUSER.
        /// </summary>
        public const string SCUSER = "SCUSER";

        /// <summary>
        /// SCMKEY.
        /// </summary>
        public const string SCMKEY = "SCMKEY";

        /// <summary>
        /// SCPID.
        /// </summary>
        public const string SCPID = "SCPID";

        /// <summary>
        /// SCUUPMJ.
        /// </summary>
        public const string SCUUPMJ = "SCUUPMJ";

        /// <summary>
        /// SCDFINTG.
        /// </summary>
        public const string SCDFINTG = "SCDFINTG";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SCFSCID", "SCFSCID", JdeDataType.Numeric, null, true, true),
        new JdeField("SCSCEDESC", "SCSCEDESC", JdeDataType.String, 60),
        new JdeField("SCSCUOM", "SCSCUOM", JdeDataType.String, 6),
        new JdeField("SCACTSC", "SCACTSC", JdeDataType.String, 2),
        new JdeField("SCURCD", "SCURCD", JdeDataType.String, 4),
        new JdeField("SCURDT", "SCURDT", JdeDataType.Numeric),
        new JdeField("SCURAT", "SCURAT", JdeDataType.Numeric),
        new JdeField("SCURAB", "SCURAB", JdeDataType.Numeric),
        new JdeField("SCURRF", "SCURRF", JdeDataType.String, 30),
        new JdeField("SCUSER", "SCUSER", JdeDataType.String, 20),
        new JdeField("SCMKEY", "SCMKEY", JdeDataType.String, 30),
        new JdeField("SCPID", "SCPID", JdeDataType.String, 20),
        new JdeField("SCUUPMJ", "SCUUPMJ", JdeDataType.Date),
        new JdeField("SCDFINTG", "SCDFINTG", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L010_0", "Primary Key on SCFSCID", new[] { "SCFSCID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L010_2", "Index on SCACTSC", new[] { "SCACTSC" }),
        new JdeIndex("FF30L010_3", "Index on SCSCEDESC", new[] { "SCSCEDESC" })
    };
}
