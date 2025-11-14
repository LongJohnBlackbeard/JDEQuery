using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B66B - .
/// </summary>
public class F31B66B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AOMCU.
        /// </summary>
        public const string AOMCU = "AOMCU";

        /// <summary>
        /// AOWISSC.
        /// </summary>
        public const string AOWISSC = "AOWISSC";

        /// <summary>
        /// AOWLN.
        /// </summary>
        public const string AOWLN = "AOWLN";

        /// <summary>
        /// AOWASDE1.
        /// </summary>
        public const string AOWASDE1 = "AOWASDE1";

        /// <summary>
        /// AOBEGDATE.
        /// </summary>
        public const string AOBEGDATE = "AOBEGDATE";

        /// <summary>
        /// AOENDDJ.
        /// </summary>
        public const string AOENDDJ = "AOENDDJ";

        /// <summary>
        /// AOWENDQTY.
        /// </summary>
        public const string AOWENDQTY = "AOWENDQTY";

        /// <summary>
        /// AOWVUM.
        /// </summary>
        public const string AOWVUM = "AOWVUM";

        /// <summary>
        /// AOWENDAMT.
        /// </summary>
        public const string AOWENDAMT = "AOWENDAMT";

        /// <summary>
        /// AOURCD.
        /// </summary>
        public const string AOURCD = "AOURCD";

        /// <summary>
        /// AOURAT.
        /// </summary>
        public const string AOURAT = "AOURAT";

        /// <summary>
        /// AOURRF.
        /// </summary>
        public const string AOURRF = "AOURRF";

        /// <summary>
        /// AOURAB.
        /// </summary>
        public const string AOURAB = "AOURAB";

        /// <summary>
        /// AOURDT.
        /// </summary>
        public const string AOURDT = "AOURDT";

        /// <summary>
        /// AOUSER.
        /// </summary>
        public const string AOUSER = "AOUSER";

        /// <summary>
        /// AOPID.
        /// </summary>
        public const string AOPID = "AOPID";

        /// <summary>
        /// AOUPMJ.
        /// </summary>
        public const string AOUPMJ = "AOUPMJ";

        /// <summary>
        /// AOTDAY.
        /// </summary>
        public const string AOTDAY = "AOTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F31B66B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AOMCU", "AOMCU", JdeDataType.String, 24, true, true),
        new JdeField("AOWISSC", "AOWISSC", JdeDataType.String, 12, true, true),
        new JdeField("AOWLN", "AOWLN", JdeDataType.Numeric, null, true, true),
        new JdeField("AOWASDE1", "AOWASDE1", JdeDataType.Numeric, null, true, true),
        new JdeField("AOBEGDATE", "AOBEGDATE", JdeDataType.Numeric),
        new JdeField("AOENDDJ", "AOENDDJ", JdeDataType.Numeric),
        new JdeField("AOWENDQTY", "AOWENDQTY", JdeDataType.Numeric),
        new JdeField("AOWVUM", "AOWVUM", JdeDataType.String, 6),
        new JdeField("AOWENDAMT", "AOWENDAMT", JdeDataType.Numeric),
        new JdeField("AOURCD", "AOURCD", JdeDataType.String, 4),
        new JdeField("AOURAT", "AOURAT", JdeDataType.Numeric),
        new JdeField("AOURRF", "AOURRF", JdeDataType.String, 30),
        new JdeField("AOURAB", "AOURAB", JdeDataType.Numeric),
        new JdeField("AOURDT", "AOURDT", JdeDataType.Numeric),
        new JdeField("AOUSER", "AOUSER", JdeDataType.String, 20),
        new JdeField("AOPID", "AOPID", JdeDataType.String, 20),
        new JdeField("AOUPMJ", "AOUPMJ", JdeDataType.Numeric),
        new JdeField("AOTDAY", "AOTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B66B_0", "Primary Key on AOMCU, AOWISSC, AOWLN, AOWASDE1", new[] { "AOMCU", "AOWISSC", "AOWLN", "AOWASDE1" }, isUnique: true, isPrimaryKey: true)
    };
}
