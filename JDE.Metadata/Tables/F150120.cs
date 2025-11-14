using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F150120 - .
/// </summary>
public class F150120 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NWTEXR.
        /// </summary>
        public const string NWTEXR = "NWTEXR";

        /// <summary>
        /// NWDL01.
        /// </summary>
        public const string NWDL01 = "NWDL01";

        /// <summary>
        /// NWURAB.
        /// </summary>
        public const string NWURAB = "NWURAB";

        /// <summary>
        /// NWURAT.
        /// </summary>
        public const string NWURAT = "NWURAT";

        /// <summary>
        /// NWURCD.
        /// </summary>
        public const string NWURCD = "NWURCD";

        /// <summary>
        /// NWURDT.
        /// </summary>
        public const string NWURDT = "NWURDT";

        /// <summary>
        /// NWURRF.
        /// </summary>
        public const string NWURRF = "NWURRF";

        /// <summary>
        /// NWUPMJ.
        /// </summary>
        public const string NWUPMJ = "NWUPMJ";

        /// <summary>
        /// NWUPMT.
        /// </summary>
        public const string NWUPMT = "NWUPMT";

        /// <summary>
        /// NWUSER.
        /// </summary>
        public const string NWUSER = "NWUSER";

        /// <summary>
        /// NWTORG.
        /// </summary>
        public const string NWTORG = "NWTORG";

        /// <summary>
        /// NWPID.
        /// </summary>
        public const string NWPID = "NWPID";

        /// <summary>
        /// NWENTJ.
        /// </summary>
        public const string NWENTJ = "NWENTJ";

        /// <summary>
        /// NWJOBN.
        /// </summary>
        public const string NWJOBN = "NWJOBN";

        /// <summary>
        /// NWSFDM.
        /// </summary>
        public const string NWSFDM = "NWSFDM";

        /// <summary>
        /// NWARTY.
        /// </summary>
        public const string NWARTY = "NWARTY";

        /// <summary>
        /// NWARDEFID.
        /// </summary>
        public const string NWARDEFID = "NWARDEFID";
    }

    /// <inheritdoc />
    public override string TableName => "F150120";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NWTEXR", "NWTEXR", JdeDataType.String, 20, true, true),
        new JdeField("NWDL01", "NWDL01", JdeDataType.String, 60),
        new JdeField("NWURAB", "NWURAB", JdeDataType.Numeric),
        new JdeField("NWURAT", "NWURAT", JdeDataType.Numeric),
        new JdeField("NWURCD", "NWURCD", JdeDataType.String, 4),
        new JdeField("NWURDT", "NWURDT", JdeDataType.Numeric),
        new JdeField("NWURRF", "NWURRF", JdeDataType.String, 30),
        new JdeField("NWUPMJ", "NWUPMJ", JdeDataType.Numeric),
        new JdeField("NWUPMT", "NWUPMT", JdeDataType.Numeric),
        new JdeField("NWUSER", "NWUSER", JdeDataType.String, 20),
        new JdeField("NWTORG", "NWTORG", JdeDataType.String, 20),
        new JdeField("NWPID", "NWPID", JdeDataType.String, 20),
        new JdeField("NWENTJ", "NWENTJ", JdeDataType.Numeric),
        new JdeField("NWJOBN", "NWJOBN", JdeDataType.String, 20),
        new JdeField("NWSFDM", "NWSFDM", JdeDataType.String, 2),
        new JdeField("NWARTY", "NWARTY", JdeDataType.String, 6),
        new JdeField("NWARDEFID", "NWARDEFID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F150120_0", "Primary Key on NWTEXR", new[] { "NWTEXR" }, isUnique: true, isPrimaryKey: true)
    };
}
