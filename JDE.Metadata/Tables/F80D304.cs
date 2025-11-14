using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D304 - .
/// </summary>
public class F80D304 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VDVCID.
        /// </summary>
        public const string VDVCID = "VDVCID";

        /// <summary>
        /// VDLNID.
        /// </summary>
        public const string VDLNID = "VDLNID";

        /// <summary>
        /// VDHIID.
        /// </summary>
        public const string VDHIID = "VDHIID";

        /// <summary>
        /// VDXLIN.
        /// </summary>
        public const string VDXLIN = "VDXLIN";

        /// <summary>
        /// VDGBDA.
        /// </summary>
        public const string VDGBDA = "VDGBDA";

        /// <summary>
        /// VDDGB.
        /// </summary>
        public const string VDDGB = "VDDGB";

        /// <summary>
        /// VDTIDEN.
        /// </summary>
        public const string VDTIDEN = "VDTIDEN";

        /// <summary>
        /// VDURCD.
        /// </summary>
        public const string VDURCD = "VDURCD";

        /// <summary>
        /// VDURDT.
        /// </summary>
        public const string VDURDT = "VDURDT";

        /// <summary>
        /// VDURAT.
        /// </summary>
        public const string VDURAT = "VDURAT";

        /// <summary>
        /// VDURAB.
        /// </summary>
        public const string VDURAB = "VDURAB";

        /// <summary>
        /// VDURRF.
        /// </summary>
        public const string VDURRF = "VDURRF";

        /// <summary>
        /// VDUSER.
        /// </summary>
        public const string VDUSER = "VDUSER";

        /// <summary>
        /// VDMKEY.
        /// </summary>
        public const string VDMKEY = "VDMKEY";

        /// <summary>
        /// VDPID.
        /// </summary>
        public const string VDPID = "VDPID";

        /// <summary>
        /// VDUUPMJ.
        /// </summary>
        public const string VDUUPMJ = "VDUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F80D304";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VDVCID", "VDVCID", JdeDataType.Numeric, null, true, true),
        new JdeField("VDLNID", "VDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("VDHIID", "VDHIID", JdeDataType.Numeric),
        new JdeField("VDXLIN", "VDXLIN", JdeDataType.Numeric),
        new JdeField("VDGBDA", "VDGBDA", JdeDataType.String, 10),
        new JdeField("VDDGB", "VDDGB", JdeDataType.Numeric),
        new JdeField("VDTIDEN", "VDTIDEN", JdeDataType.Numeric),
        new JdeField("VDURCD", "VDURCD", JdeDataType.String, 4),
        new JdeField("VDURDT", "VDURDT", JdeDataType.Numeric),
        new JdeField("VDURAT", "VDURAT", JdeDataType.Numeric),
        new JdeField("VDURAB", "VDURAB", JdeDataType.Numeric),
        new JdeField("VDURRF", "VDURRF", JdeDataType.String, 30),
        new JdeField("VDUSER", "VDUSER", JdeDataType.String, 20),
        new JdeField("VDMKEY", "VDMKEY", JdeDataType.String, 30),
        new JdeField("VDPID", "VDPID", JdeDataType.String, 20),
        new JdeField("VDUUPMJ", "VDUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D304_0", "Primary Key on VDVCID, VDLNID", new[] { "VDVCID", "VDLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F80D304_2", "Unique Index on VDVCID, VDGBDA", new[] { "VDVCID", "VDGBDA" }, isUnique: true),
        new JdeIndex("F80D304_3", "Index on VDVCID, VDDGB", new[] { "VDVCID", "VDDGB" })
    };
}
