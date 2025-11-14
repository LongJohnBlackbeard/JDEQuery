using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1570 - .
/// </summary>
public class F1570 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NDDOCO.
        /// </summary>
        public const string NDDOCO = "NDDOCO";

        /// <summary>
        /// NDAN8.
        /// </summary>
        public const string NDAN8 = "NDAN8";

        /// <summary>
        /// NDCLNO.
        /// </summary>
        public const string NDCLNO = "NDCLNO";

        /// <summary>
        /// NDLSVR.
        /// </summary>
        public const string NDLSVR = "NDLSVR";

        /// <summary>
        /// NDOPTY.
        /// </summary>
        public const string NDOPTY = "NDOPTY";

        /// <summary>
        /// NDODET.
        /// </summary>
        public const string NDODET = "NDODET";

        /// <summary>
        /// NDOSTA.
        /// </summary>
        public const string NDOSTA = "NDOSTA";

        /// <summary>
        /// NDEFTB.
        /// </summary>
        public const string NDEFTB = "NDEFTB";

        /// <summary>
        /// NDEFTE.
        /// </summary>
        public const string NDEFTE = "NDEFTE";

        /// <summary>
        /// NDTKDT.
        /// </summary>
        public const string NDTKDT = "NDTKDT";

        /// <summary>
        /// NDDNOT.
        /// </summary>
        public const string NDDNOT = "NDDNOT";

        /// <summary>
        /// NDRNOT.
        /// </summary>
        public const string NDRNOT = "NDRNOT";

        /// <summary>
        /// NDRDOC.
        /// </summary>
        public const string NDRDOC = "NDRDOC";

        /// <summary>
        /// NDURCD.
        /// </summary>
        public const string NDURCD = "NDURCD";

        /// <summary>
        /// NDURDT.
        /// </summary>
        public const string NDURDT = "NDURDT";

        /// <summary>
        /// NDURAT.
        /// </summary>
        public const string NDURAT = "NDURAT";

        /// <summary>
        /// NDURAB.
        /// </summary>
        public const string NDURAB = "NDURAB";

        /// <summary>
        /// NDURRF.
        /// </summary>
        public const string NDURRF = "NDURRF";

        /// <summary>
        /// NDUSER.
        /// </summary>
        public const string NDUSER = "NDUSER";

        /// <summary>
        /// NDPID.
        /// </summary>
        public const string NDPID = "NDPID";

        /// <summary>
        /// NDUPMJ.
        /// </summary>
        public const string NDUPMJ = "NDUPMJ";

        /// <summary>
        /// NDUPMT.
        /// </summary>
        public const string NDUPMT = "NDUPMT";

        /// <summary>
        /// NDJOBN.
        /// </summary>
        public const string NDJOBN = "NDJOBN";

        /// <summary>
        /// NDENTJ.
        /// </summary>
        public const string NDENTJ = "NDENTJ";

        /// <summary>
        /// NDTORG.
        /// </summary>
        public const string NDTORG = "NDTORG";
    }

    /// <inheritdoc />
    public override string TableName => "F1570";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NDDOCO", "NDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("NDAN8", "NDAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("NDCLNO", "NDCLNO", JdeDataType.Numeric, null, true, true),
        new JdeField("NDLSVR", "NDLSVR", JdeDataType.Numeric),
        new JdeField("NDOPTY", "NDOPTY", JdeDataType.String, 8),
        new JdeField("NDODET", "NDODET", JdeDataType.String, 20),
        new JdeField("NDOSTA", "NDOSTA", JdeDataType.String, 2),
        new JdeField("NDEFTB", "NDEFTB", JdeDataType.Numeric),
        new JdeField("NDEFTE", "NDEFTE", JdeDataType.Numeric),
        new JdeField("NDTKDT", "NDTKDT", JdeDataType.Numeric),
        new JdeField("NDDNOT", "NDDNOT", JdeDataType.Numeric),
        new JdeField("NDRNOT", "NDRNOT", JdeDataType.String, 20),
        new JdeField("NDRDOC", "NDRDOC", JdeDataType.String, 100),
        new JdeField("NDURCD", "NDURCD", JdeDataType.String, 4),
        new JdeField("NDURDT", "NDURDT", JdeDataType.Numeric),
        new JdeField("NDURAT", "NDURAT", JdeDataType.Numeric),
        new JdeField("NDURAB", "NDURAB", JdeDataType.Numeric),
        new JdeField("NDURRF", "NDURRF", JdeDataType.String, 30),
        new JdeField("NDUSER", "NDUSER", JdeDataType.String, 20),
        new JdeField("NDPID", "NDPID", JdeDataType.String, 20),
        new JdeField("NDUPMJ", "NDUPMJ", JdeDataType.Numeric),
        new JdeField("NDUPMT", "NDUPMT", JdeDataType.Numeric),
        new JdeField("NDJOBN", "NDJOBN", JdeDataType.String, 20),
        new JdeField("NDENTJ", "NDENTJ", JdeDataType.Numeric),
        new JdeField("NDTORG", "NDTORG", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1570_0", "Primary Key on NDDOCO, NDAN8, NDCLNO", new[] { "NDDOCO", "NDAN8", "NDCLNO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1570_2", "Index on NDDOCO, NDLSVR", new[] { "NDDOCO", "NDLSVR" })
    };
}
