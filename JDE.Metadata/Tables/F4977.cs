using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4977 - .
/// </summary>
public class F4977 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MRCARS.
        /// </summary>
        public const string MRCARS = "MRCARS";

        /// <summary>
        /// MRRTNM.
        /// </summary>
        public const string MRRTNM = "MRRTNM";

        /// <summary>
        /// MRCRCD.
        /// </summary>
        public const string MRCRCD = "MRCRCD";

        /// <summary>
        /// MRDCPS.
        /// </summary>
        public const string MRDCPS = "MRDCPS";

        /// <summary>
        /// MRBSCG.
        /// </summary>
        public const string MRBSCG = "MRBSCG";

        /// <summary>
        /// MRMNCG.
        /// </summary>
        public const string MRMNCG = "MRMNCG";

        /// <summary>
        /// MRMXCG.
        /// </summary>
        public const string MRMXCG = "MRMXCG";

        /// <summary>
        /// MRMPCG.
        /// </summary>
        public const string MRMPCG = "MRMPCG";

        /// <summary>
        /// MRMPCW.
        /// </summary>
        public const string MRMPCW = "MRMPCW";

        /// <summary>
        /// MRWTUM.
        /// </summary>
        public const string MRWTUM = "MRWTUM";

        /// <summary>
        /// MROSLN.
        /// </summary>
        public const string MROSLN = "MROSLN";

        /// <summary>
        /// MROSWD.
        /// </summary>
        public const string MROSWD = "MROSWD";

        /// <summary>
        /// MROSHT.
        /// </summary>
        public const string MROSHT = "MROSHT";

        /// <summary>
        /// MROSCG.
        /// </summary>
        public const string MROSCG = "MROSCG";

        /// <summary>
        /// MROSLG.
        /// </summary>
        public const string MROSLG = "MROSLG";

        /// <summary>
        /// MRLUOM.
        /// </summary>
        public const string MRLUOM = "MRLUOM";

        /// <summary>
        /// MROSCW.
        /// </summary>
        public const string MROSCW = "MROSCW";

        /// <summary>
        /// MROSMC.
        /// </summary>
        public const string MROSMC = "MROSMC";

        /// <summary>
        /// MREFTJ.
        /// </summary>
        public const string MREFTJ = "MREFTJ";

        /// <summary>
        /// MREXDJ.
        /// </summary>
        public const string MREXDJ = "MREXDJ";

        /// <summary>
        /// MRURCD.
        /// </summary>
        public const string MRURCD = "MRURCD";

        /// <summary>
        /// MRURDT.
        /// </summary>
        public const string MRURDT = "MRURDT";

        /// <summary>
        /// MRURAT.
        /// </summary>
        public const string MRURAT = "MRURAT";

        /// <summary>
        /// MRURAB.
        /// </summary>
        public const string MRURAB = "MRURAB";

        /// <summary>
        /// MRURRF.
        /// </summary>
        public const string MRURRF = "MRURRF";

        /// <summary>
        /// MRUSER.
        /// </summary>
        public const string MRUSER = "MRUSER";

        /// <summary>
        /// MRPID.
        /// </summary>
        public const string MRPID = "MRPID";

        /// <summary>
        /// MRJOBN.
        /// </summary>
        public const string MRJOBN = "MRJOBN";

        /// <summary>
        /// MRUPMJ.
        /// </summary>
        public const string MRUPMJ = "MRUPMJ";

        /// <summary>
        /// MRTDAY.
        /// </summary>
        public const string MRTDAY = "MRTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4977";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MRCARS", "MRCARS", JdeDataType.Numeric, null, true, true),
        new JdeField("MRRTNM", "MRRTNM", JdeDataType.String, 20, true, true),
        new JdeField("MRCRCD", "MRCRCD", JdeDataType.String, 6),
        new JdeField("MRDCPS", "MRDCPS", JdeDataType.Numeric),
        new JdeField("MRBSCG", "MRBSCG", JdeDataType.Numeric),
        new JdeField("MRMNCG", "MRMNCG", JdeDataType.Numeric),
        new JdeField("MRMXCG", "MRMXCG", JdeDataType.Numeric),
        new JdeField("MRMPCG", "MRMPCG", JdeDataType.Numeric),
        new JdeField("MRMPCW", "MRMPCW", JdeDataType.Numeric),
        new JdeField("MRWTUM", "MRWTUM", JdeDataType.String, 4),
        new JdeField("MROSLN", "MROSLN", JdeDataType.Numeric),
        new JdeField("MROSWD", "MROSWD", JdeDataType.Numeric),
        new JdeField("MROSHT", "MROSHT", JdeDataType.Numeric),
        new JdeField("MROSCG", "MROSCG", JdeDataType.Numeric),
        new JdeField("MROSLG", "MROSLG", JdeDataType.Numeric),
        new JdeField("MRLUOM", "MRLUOM", JdeDataType.String, 4),
        new JdeField("MROSCW", "MROSCW", JdeDataType.Numeric),
        new JdeField("MROSMC", "MROSMC", JdeDataType.Numeric),
        new JdeField("MREFTJ", "MREFTJ", JdeDataType.Numeric),
        new JdeField("MREXDJ", "MREXDJ", JdeDataType.Numeric),
        new JdeField("MRURCD", "MRURCD", JdeDataType.String, 4),
        new JdeField("MRURDT", "MRURDT", JdeDataType.Numeric),
        new JdeField("MRURAT", "MRURAT", JdeDataType.Numeric),
        new JdeField("MRURAB", "MRURAB", JdeDataType.Numeric),
        new JdeField("MRURRF", "MRURRF", JdeDataType.String, 30),
        new JdeField("MRUSER", "MRUSER", JdeDataType.String, 20),
        new JdeField("MRPID", "MRPID", JdeDataType.String, 20),
        new JdeField("MRJOBN", "MRJOBN", JdeDataType.String, 20),
        new JdeField("MRUPMJ", "MRUPMJ", JdeDataType.Numeric),
        new JdeField("MRTDAY", "MRTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4977_0", "Primary Key on MRCARS, MRRTNM", new[] { "MRCARS", "MRRTNM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4977_2", "Index on MRRTNM, MRCARS", new[] { "MRRTNM", "MRCARS" })
    };
}
