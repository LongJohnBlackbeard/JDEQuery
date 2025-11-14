using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L702 - .
/// </summary>
public class FF30L702 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PHPHID.
        /// </summary>
        public const string PHPHID = "PHPHID";

        /// <summary>
        /// PHPHNA.
        /// </summary>
        public const string PHPHNA = "PHPHNA";

        /// <summary>
        /// PHPADSC.
        /// </summary>
        public const string PHPADSC = "PHPADSC";

        /// <summary>
        /// PHPHTY.
        /// </summary>
        public const string PHPHTY = "PHPHTY";

        /// <summary>
        /// PHFSCID.
        /// </summary>
        public const string PHFSCID = "PHFSCID";

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
    public override string TableName => "FF30L702";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PHPHID", "PHPHID", JdeDataType.Numeric, null, true, true),
        new JdeField("PHPHNA", "PHPHNA", JdeDataType.String, 60),
        new JdeField("PHPADSC", "PHPADSC", JdeDataType.String, 60),
        new JdeField("PHPHTY", "PHPHTY", JdeDataType.String, 4),
        new JdeField("PHFSCID", "PHFSCID", JdeDataType.Numeric),
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
        new JdeIndex("FF30L702_0", "Primary Key on PHPHID", new[] { "PHPHID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L702_2", "Unique Index on PHFSCID, PHPHTY, PHPHNA", new[] { "PHFSCID", "PHPHTY", "PHPHNA" }, isUnique: true),
        new JdeIndex("FF30L702_3", "Unique Index on PHFSCID, PHPHNA", new[] { "PHFSCID", "PHPHNA" }, isUnique: true)
    };
}
