using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15L141 - .
/// </summary>
public class F15L141 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GLMCUS.
        /// </summary>
        public const string GLMCUS = "GLMCUS";

        /// <summary>
        /// GLMCU.
        /// </summary>
        public const string GLMCU = "GLMCU";

        /// <summary>
        /// GLRVNB.
        /// </summary>
        public const string GLRVNB = "GLRVNB";

        /// <summary>
        /// GLFLOR.
        /// </summary>
        public const string GLFLOR = "GLFLOR";

        /// <summary>
        /// GLUNIT.
        /// </summary>
        public const string GLUNIT = "GLUNIT";

        /// <summary>
        /// GLCENTYR.
        /// </summary>
        public const string GLCENTYR = "GLCENTYR";

        /// <summary>
        /// GLMT.
        /// </summary>
        public const string GLMT = "GLMT";

        /// <summary>
        /// GLGLOA.
        /// </summary>
        public const string GLGLOA = "GLGLOA";

        /// <summary>
        /// GLGOCF.
        /// </summary>
        public const string GLGOCF = "GLGOCF";

        /// <summary>
        /// GLGLAA.
        /// </summary>
        public const string GLGLAA = "GLGLAA";

        /// <summary>
        /// GLGLCF.
        /// </summary>
        public const string GLGLCF = "GLGLCF";

        /// <summary>
        /// GLDYOC.
        /// </summary>
        public const string GLDYOC = "GLDYOC";

        /// <summary>
        /// GLUM.
        /// </summary>
        public const string GLUM = "GLUM";

        /// <summary>
        /// GLARTY.
        /// </summary>
        public const string GLARTY = "GLARTY";

        /// <summary>
        /// GLAM01.
        /// </summary>
        public const string GLAM01 = "GLAM01";

        /// <summary>
        /// GLGLMD.
        /// </summary>
        public const string GLGLMD = "GLGLMD";

        /// <summary>
        /// GLDOCO.
        /// </summary>
        public const string GLDOCO = "GLDOCO";

        /// <summary>
        /// GLURCD.
        /// </summary>
        public const string GLURCD = "GLURCD";

        /// <summary>
        /// GLURDT.
        /// </summary>
        public const string GLURDT = "GLURDT";

        /// <summary>
        /// GLURAT.
        /// </summary>
        public const string GLURAT = "GLURAT";

        /// <summary>
        /// GLURAB.
        /// </summary>
        public const string GLURAB = "GLURAB";

        /// <summary>
        /// GLURRF.
        /// </summary>
        public const string GLURRF = "GLURRF";

        /// <summary>
        /// GLUSER.
        /// </summary>
        public const string GLUSER = "GLUSER";

        /// <summary>
        /// GLPID.
        /// </summary>
        public const string GLPID = "GLPID";

        /// <summary>
        /// GLJOBN.
        /// </summary>
        public const string GLJOBN = "GLJOBN";

        /// <summary>
        /// GLUPMJ.
        /// </summary>
        public const string GLUPMJ = "GLUPMJ";

        /// <summary>
        /// GLUPMT.
        /// </summary>
        public const string GLUPMT = "GLUPMT";

        /// <summary>
        /// GLTORG.
        /// </summary>
        public const string GLTORG = "GLTORG";

        /// <summary>
        /// GLENTJ.
        /// </summary>
        public const string GLENTJ = "GLENTJ";

        /// <summary>
        /// GLARDEFID.
        /// </summary>
        public const string GLARDEFID = "GLARDEFID";

        /// <summary>
        /// GLGLOAU.
        /// </summary>
        public const string GLGLOAU = "GLGLOAU";

        /// <summary>
        /// GLGLAAU.
        /// </summary>
        public const string GLGLAAU = "GLGLAAU";
    }

    /// <inheritdoc />
    public override string TableName => "F15L141";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GLMCUS", "GLMCUS", JdeDataType.String, 24, true, true),
        new JdeField("GLMCU", "GLMCU", JdeDataType.String, 24, true, true),
        new JdeField("GLRVNB", "GLRVNB", JdeDataType.Numeric, null, true, true),
        new JdeField("GLFLOR", "GLFLOR", JdeDataType.String, 8),
        new JdeField("GLUNIT", "GLUNIT", JdeDataType.String, 16, true, true),
        new JdeField("GLCENTYR", "GLCENTYR", JdeDataType.Numeric, null, true, true),
        new JdeField("GLMT", "GLMT", JdeDataType.Numeric, null, true, true),
        new JdeField("GLGLOA", "GLGLOA", JdeDataType.Numeric),
        new JdeField("GLGOCF", "GLGOCF", JdeDataType.String, 2),
        new JdeField("GLGLAA", "GLGLAA", JdeDataType.Numeric),
        new JdeField("GLGLCF", "GLGLCF", JdeDataType.String, 2),
        new JdeField("GLDYOC", "GLDYOC", JdeDataType.Numeric),
        new JdeField("GLUM", "GLUM", JdeDataType.String, 4),
        new JdeField("GLARTY", "GLARTY", JdeDataType.String, 6),
        new JdeField("GLAM01", "GLAM01", JdeDataType.String, 6),
        new JdeField("GLGLMD", "GLGLMD", JdeDataType.String, 2, true, true),
        new JdeField("GLDOCO", "GLDOCO", JdeDataType.Numeric),
        new JdeField("GLURCD", "GLURCD", JdeDataType.String, 4),
        new JdeField("GLURDT", "GLURDT", JdeDataType.Numeric),
        new JdeField("GLURAT", "GLURAT", JdeDataType.Numeric),
        new JdeField("GLURAB", "GLURAB", JdeDataType.Numeric),
        new JdeField("GLURRF", "GLURRF", JdeDataType.String, 30),
        new JdeField("GLUSER", "GLUSER", JdeDataType.String, 20),
        new JdeField("GLPID", "GLPID", JdeDataType.String, 20),
        new JdeField("GLJOBN", "GLJOBN", JdeDataType.String, 20),
        new JdeField("GLUPMJ", "GLUPMJ", JdeDataType.Numeric),
        new JdeField("GLUPMT", "GLUPMT", JdeDataType.Numeric),
        new JdeField("GLTORG", "GLTORG", JdeDataType.String, 20),
        new JdeField("GLENTJ", "GLENTJ", JdeDataType.Numeric),
        new JdeField("GLARDEFID", "GLARDEFID", JdeDataType.String, 20, true, true),
        new JdeField("GLGLOAU", "GLGLOAU", JdeDataType.Numeric),
        new JdeField("GLGLAAU", "GLGLAAU", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15L141_0", "Primary Key on GLMCUS, GLMCU, GLRVNB, GLUNIT, GLCENTYR, GLMT, GLGLMD, GLARDEFID", new[] { "GLMCUS", "GLMCU", "GLRVNB", "GLUNIT", "GLCENTYR", "GLMT", "GLGLMD", "GLARDEFID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F15L141_2", "Index on GLMCUS, GLRVNB, GLUNIT, GLCENTYR, GLMT, GLGLMD, GLARDEFID", new[] { "GLMCUS", "GLRVNB", "GLUNIT", "GLCENTYR", "GLMT", "GLGLMD", "GLARDEFID" }),
        new JdeIndex("F15L141_3", "Index on GLMCU, GLRVNB, GLUNIT, GLCENTYR, GLMT, GLGLMD, GLARDEFID", new[] { "GLMCU", "GLRVNB", "GLUNIT", "GLCENTYR", "GLMT", "GLGLMD", "GLARDEFID" })
    };
}
