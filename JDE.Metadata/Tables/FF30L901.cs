using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L901 - .
/// </summary>
public class FF30L901 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PHPMAPID.
        /// </summary>
        public const string PHPMAPID = "PHPMAPID";

        /// <summary>
        /// PHFSCID.
        /// </summary>
        public const string PHFSCID = "PHFSCID";

        /// <summary>
        /// PHPMAPN.
        /// </summary>
        public const string PHPMAPN = "PHPMAPN";

        /// <summary>
        /// PHDS01.
        /// </summary>
        public const string PHDS01 = "PHDS01";

        /// <summary>
        /// PHVOLID.
        /// </summary>
        public const string PHVOLID = "PHVOLID";

        /// <summary>
        /// PHVDN.
        /// </summary>
        public const string PHVDN = "PHVDN";

        /// <summary>
        /// PHDTYPE.
        /// </summary>
        public const string PHDTYPE = "PHDTYPE";

        /// <summary>
        /// PHDFLINE.
        /// </summary>
        public const string PHDFLINE = "PHDFLINE";

        /// <summary>
        /// PHURCD.
        /// </summary>
        public const string PHURCD = "PHURCD";

        /// <summary>
        /// PHURDT.
        /// </summary>
        public const string PHURDT = "PHURDT";

        /// <summary>
        /// PHURAT.
        /// </summary>
        public const string PHURAT = "PHURAT";

        /// <summary>
        /// PHURAB.
        /// </summary>
        public const string PHURAB = "PHURAB";

        /// <summary>
        /// PHURRF.
        /// </summary>
        public const string PHURRF = "PHURRF";

        /// <summary>
        /// PHUSER.
        /// </summary>
        public const string PHUSER = "PHUSER";

        /// <summary>
        /// PHPID.
        /// </summary>
        public const string PHPID = "PHPID";

        /// <summary>
        /// PHMKEY.
        /// </summary>
        public const string PHMKEY = "PHMKEY";

        /// <summary>
        /// PHUUPMJ.
        /// </summary>
        public const string PHUUPMJ = "PHUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L901";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PHPMAPID", "PHPMAPID", JdeDataType.Numeric, null, true, true),
        new JdeField("PHFSCID", "PHFSCID", JdeDataType.Numeric),
        new JdeField("PHPMAPN", "PHPMAPN", JdeDataType.String, 50),
        new JdeField("PHDS01", "PHDS01", JdeDataType.String, 160),
        new JdeField("PHVOLID", "PHVOLID", JdeDataType.Numeric),
        new JdeField("PHVDN", "PHVDN", JdeDataType.String, 60),
        new JdeField("PHDTYPE", "PHDTYPE", JdeDataType.String, 4),
        new JdeField("PHDFLINE", "PHDFLINE", JdeDataType.String, 24),
        new JdeField("PHURCD", "PHURCD", JdeDataType.String, 4),
        new JdeField("PHURDT", "PHURDT", JdeDataType.Numeric),
        new JdeField("PHURAT", "PHURAT", JdeDataType.Numeric),
        new JdeField("PHURAB", "PHURAB", JdeDataType.Numeric),
        new JdeField("PHURRF", "PHURRF", JdeDataType.String, 30),
        new JdeField("PHUSER", "PHUSER", JdeDataType.String, 20),
        new JdeField("PHPID", "PHPID", JdeDataType.String, 20),
        new JdeField("PHMKEY", "PHMKEY", JdeDataType.String, 30),
        new JdeField("PHUUPMJ", "PHUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L901_0", "Primary Key on PHPMAPID", new[] { "PHPMAPID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L901_2", "Index on PHFSCID, PHPMAPN", new[] { "PHFSCID", "PHPMAPN" })
    };
}
