using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D215 - .
/// </summary>
public class F80D215 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BSPRDJ.
        /// </summary>
        public const string BSPRDJ = "BSPRDJ";

        /// <summary>
        /// BSITM.
        /// </summary>
        public const string BSITM = "BSITM";

        /// <summary>
        /// BSBSHDY.
        /// </summary>
        public const string BSBSHDY = "BSBSHDY";

        /// <summary>
        /// BSORDSH.
        /// </summary>
        public const string BSORDSH = "BSORDSH";

        /// <summary>
        /// BSUSER.
        /// </summary>
        public const string BSUSER = "BSUSER";

        /// <summary>
        /// BSPID.
        /// </summary>
        public const string BSPID = "BSPID";

        /// <summary>
        /// BSMKEY.
        /// </summary>
        public const string BSMKEY = "BSMKEY";

        /// <summary>
        /// BSUTIME.
        /// </summary>
        public const string BSUTIME = "BSUTIME";

        /// <summary>
        /// BSURCD.
        /// </summary>
        public const string BSURCD = "BSURCD";

        /// <summary>
        /// BSURDT.
        /// </summary>
        public const string BSURDT = "BSURDT";

        /// <summary>
        /// BSURAT.
        /// </summary>
        public const string BSURAT = "BSURAT";

        /// <summary>
        /// BSURAB.
        /// </summary>
        public const string BSURAB = "BSURAB";

        /// <summary>
        /// BSURRF.
        /// </summary>
        public const string BSURRF = "BSURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F80D215";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BSPRDJ", "BSPRDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("BSITM", "BSITM", JdeDataType.Numeric, null, true, true),
        new JdeField("BSBSHDY", "BSBSHDY", JdeDataType.Numeric),
        new JdeField("BSORDSH", "BSORDSH", JdeDataType.Numeric),
        new JdeField("BSUSER", "BSUSER", JdeDataType.String, 20),
        new JdeField("BSPID", "BSPID", JdeDataType.String, 20),
        new JdeField("BSMKEY", "BSMKEY", JdeDataType.String, 30),
        new JdeField("BSUTIME", "BSUTIME", JdeDataType.Date),
        new JdeField("BSURCD", "BSURCD", JdeDataType.String, 4),
        new JdeField("BSURDT", "BSURDT", JdeDataType.Numeric),
        new JdeField("BSURAT", "BSURAT", JdeDataType.Numeric),
        new JdeField("BSURAB", "BSURAB", JdeDataType.Numeric),
        new JdeField("BSURRF", "BSURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D215_0", "Primary Key on BSPRDJ, BSITM", new[] { "BSPRDJ", "BSITM" }, isUnique: true, isPrimaryKey: true)
    };
}
