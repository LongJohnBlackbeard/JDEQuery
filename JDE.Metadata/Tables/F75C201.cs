using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75C201 - .
/// </summary>
public class F75C201 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MMNUMB.
        /// </summary>
        public const string MMNUMB = "MMNUMB";

        /// <summary>
        /// MMC75MODMT.
        /// </summary>
        public const string MMC75MODMT = "MMC75MODMT";

        /// <summary>
        /// MMASID.
        /// </summary>
        public const string MMASID = "MMASID";

        /// <summary>
        /// MMAID.
        /// </summary>
        public const string MMAID = "MMAID";

        /// <summary>
        /// MMANIC.
        /// </summary>
        public const string MMANIC = "MMANIC";

        /// <summary>
        /// MMMCU.
        /// </summary>
        public const string MMMCU = "MMMCU";

        /// <summary>
        /// MMOBJ.
        /// </summary>
        public const string MMOBJ = "MMOBJ";

        /// <summary>
        /// MMSUB.
        /// </summary>
        public const string MMSUB = "MMSUB";

        /// <summary>
        /// MMFUTMATH1.
        /// </summary>
        public const string MMFUTMATH1 = "MMFUTMATH1";

        /// <summary>
        /// MMFUTSTR1.
        /// </summary>
        public const string MMFUTSTR1 = "MMFUTSTR1";

        /// <summary>
        /// MMFUTSTR2.
        /// </summary>
        public const string MMFUTSTR2 = "MMFUTSTR2";

        /// <summary>
        /// MMFUTDATE1.
        /// </summary>
        public const string MMFUTDATE1 = "MMFUTDATE1";

        /// <summary>
        /// MMFUTUO1.
        /// </summary>
        public const string MMFUTUO1 = "MMFUTUO1";

        /// <summary>
        /// MMUSER.
        /// </summary>
        public const string MMUSER = "MMUSER";

        /// <summary>
        /// MMPID.
        /// </summary>
        public const string MMPID = "MMPID";

        /// <summary>
        /// MMJOBN.
        /// </summary>
        public const string MMJOBN = "MMJOBN";

        /// <summary>
        /// MMUPMJ.
        /// </summary>
        public const string MMUPMJ = "MMUPMJ";

        /// <summary>
        /// MMUPMT.
        /// </summary>
        public const string MMUPMT = "MMUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75C201";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MMNUMB", "MMNUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("MMC75MODMT", "MMC75MODMT", JdeDataType.String, 4, true, true),
        new JdeField("MMASID", "MMASID", JdeDataType.String, 50),
        new JdeField("MMAID", "MMAID", JdeDataType.String, 16),
        new JdeField("MMANIC", "MMANIC", JdeDataType.String, 58),
        new JdeField("MMMCU", "MMMCU", JdeDataType.String, 24),
        new JdeField("MMOBJ", "MMOBJ", JdeDataType.String, 12),
        new JdeField("MMSUB", "MMSUB", JdeDataType.String, 16),
        new JdeField("MMFUTMATH1", "MMFUTMATH1", JdeDataType.Numeric),
        new JdeField("MMFUTSTR1", "MMFUTSTR1", JdeDataType.String, 100),
        new JdeField("MMFUTSTR2", "MMFUTSTR2", JdeDataType.String, 100),
        new JdeField("MMFUTDATE1", "MMFUTDATE1", JdeDataType.Numeric),
        new JdeField("MMFUTUO1", "MMFUTUO1", JdeDataType.String, 2),
        new JdeField("MMUSER", "MMUSER", JdeDataType.String, 20),
        new JdeField("MMPID", "MMPID", JdeDataType.String, 20),
        new JdeField("MMJOBN", "MMJOBN", JdeDataType.String, 20),
        new JdeField("MMUPMJ", "MMUPMJ", JdeDataType.Numeric),
        new JdeField("MMUPMT", "MMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75C201_0", "Primary Key on MMNUMB, MMC75MODMT", new[] { "MMNUMB", "MMC75MODMT" }, isUnique: true, isPrimaryKey: true)
    };
}
