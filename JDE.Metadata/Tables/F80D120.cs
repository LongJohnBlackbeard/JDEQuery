using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D120 - .
/// </summary>
public class F80D120 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SVICU.
        /// </summary>
        public const string SVICU = "SVICU";

        /// <summary>
        /// SVSODVID.
        /// </summary>
        public const string SVSODVID = "SVSODVID";

        /// <summary>
        /// SVDBT.
        /// </summary>
        public const string SVDBT = "SVDBT";

        /// <summary>
        /// SVPRCSID.
        /// </summary>
        public const string SVPRCSID = "SVPRCSID";

        /// <summary>
        /// SVGRID.
        /// </summary>
        public const string SVGRID = "SVGRID";

        /// <summary>
        /// SVAPPNID.
        /// </summary>
        public const string SVAPPNID = "SVAPPNID";

        /// <summary>
        /// SVUSER.
        /// </summary>
        public const string SVUSER = "SVUSER";

        /// <summary>
        /// SVTOROLE.
        /// </summary>
        public const string SVTOROLE = "SVTOROLE";

        /// <summary>
        /// SVLL.
        /// </summary>
        public const string SVLL = "SVLL";

        /// <summary>
        /// SVALPH.
        /// </summary>
        public const string SVALPH = "SVALPH";

        /// <summary>
        /// SVMUSE.
        /// </summary>
        public const string SVMUSE = "SVMUSE";

        /// <summary>
        /// SVPID.
        /// </summary>
        public const string SVPID = "SVPID";

        /// <summary>
        /// SVMKEY.
        /// </summary>
        public const string SVMKEY = "SVMKEY";

        /// <summary>
        /// SVUPMJ.
        /// </summary>
        public const string SVUPMJ = "SVUPMJ";

        /// <summary>
        /// SVUPMT.
        /// </summary>
        public const string SVUPMT = "SVUPMT";

        /// <summary>
        /// SVURCD.
        /// </summary>
        public const string SVURCD = "SVURCD";

        /// <summary>
        /// SVURDT.
        /// </summary>
        public const string SVURDT = "SVURDT";

        /// <summary>
        /// SVURAB.
        /// </summary>
        public const string SVURAB = "SVURAB";

        /// <summary>
        /// SVURRF.
        /// </summary>
        public const string SVURRF = "SVURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F80D120";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SVICU", "SVICU", JdeDataType.Numeric, null, true, true),
        new JdeField("SVSODVID", "SVSODVID", JdeDataType.Numeric, null, true, true),
        new JdeField("SVDBT", "SVDBT", JdeDataType.Numeric),
        new JdeField("SVPRCSID", "SVPRCSID", JdeDataType.String, 40),
        new JdeField("SVGRID", "SVGRID", JdeDataType.String, 40),
        new JdeField("SVAPPNID", "SVAPPNID", JdeDataType.String, 20),
        new JdeField("SVUSER", "SVUSER", JdeDataType.String, 20),
        new JdeField("SVTOROLE", "SVTOROLE", JdeDataType.String, 30),
        new JdeField("SVLL", "SVLL", JdeDataType.String, 20),
        new JdeField("SVALPH", "SVALPH", JdeDataType.String, 80),
        new JdeField("SVMUSE", "SVMUSE", JdeDataType.String, 20),
        new JdeField("SVPID", "SVPID", JdeDataType.String, 20),
        new JdeField("SVMKEY", "SVMKEY", JdeDataType.String, 30),
        new JdeField("SVUPMJ", "SVUPMJ", JdeDataType.Numeric),
        new JdeField("SVUPMT", "SVUPMT", JdeDataType.Numeric),
        new JdeField("SVURCD", "SVURCD", JdeDataType.String, 4),
        new JdeField("SVURDT", "SVURDT", JdeDataType.Numeric),
        new JdeField("SVURAB", "SVURAB", JdeDataType.Numeric),
        new JdeField("SVURRF", "SVURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D120_0", "Primary Key on SVICU, SVSODVID", new[] { "SVICU", "SVSODVID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F80D120_2", "Index on SVDBT, SVICU", new[] { "SVDBT", "SVICU" }),
        new JdeIndex("F80D120_3", "Index on SVUSER, SVTOROLE, SVPRCSID, SVGRID, SVAPPNID", new[] { "SVUSER", "SVTOROLE", "SVPRCSID", "SVGRID", "SVAPPNID" })
    };
}
