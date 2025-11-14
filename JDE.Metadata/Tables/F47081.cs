using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47081 - .
/// </summary>
public class F47081 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FVEDTY.
        /// </summary>
        public const string FVEDTY = "FVEDTY";

        /// <summary>
        /// FVEDSQ.
        /// </summary>
        public const string FVEDSQ = "FVEDSQ";

        /// <summary>
        /// FVEKCO.
        /// </summary>
        public const string FVEKCO = "FVEKCO";

        /// <summary>
        /// FVEDOC.
        /// </summary>
        public const string FVEDOC = "FVEDOC";

        /// <summary>
        /// FVEDCT.
        /// </summary>
        public const string FVEDCT = "FVEDCT";

        /// <summary>
        /// FVEDLN.
        /// </summary>
        public const string FVEDLN = "FVEDLN";

        /// <summary>
        /// FVEDST.
        /// </summary>
        public const string FVEDST = "FVEDST";

        /// <summary>
        /// FVEDFT.
        /// </summary>
        public const string FVEDFT = "FVEDFT";

        /// <summary>
        /// FVEDDT.
        /// </summary>
        public const string FVEDDT = "FVEDDT";

        /// <summary>
        /// FVEDER.
        /// </summary>
        public const string FVEDER = "FVEDER";

        /// <summary>
        /// FVEDDL.
        /// </summary>
        public const string FVEDDL = "FVEDDL";

        /// <summary>
        /// FVEDSP.
        /// </summary>
        public const string FVEDSP = "FVEDSP";

        /// <summary>
        /// FVEDBT.
        /// </summary>
        public const string FVEDBT = "FVEDBT";

        /// <summary>
        /// FVPNID.
        /// </summary>
        public const string FVPNID = "FVPNID";

        /// <summary>
        /// FVTPUR.
        /// </summary>
        public const string FVTPUR = "FVTPUR";

        /// <summary>
        /// FVSCCD.
        /// </summary>
        public const string FVSCCD = "FVSCCD";

        /// <summary>
        /// FVCATN.
        /// </summary>
        public const string FVCATN = "FVCATN";

        /// <summary>
        /// FVAN8.
        /// </summary>
        public const string FVAN8 = "FVAN8";

        /// <summary>
        /// FVALPH.
        /// </summary>
        public const string FVALPH = "FVALPH";

        /// <summary>
        /// FVADD1.
        /// </summary>
        public const string FVADD1 = "FVADD1";

        /// <summary>
        /// FVADD2.
        /// </summary>
        public const string FVADD2 = "FVADD2";

        /// <summary>
        /// FVADD3.
        /// </summary>
        public const string FVADD3 = "FVADD3";

        /// <summary>
        /// FVADD4.
        /// </summary>
        public const string FVADD4 = "FVADD4";

        /// <summary>
        /// FVADD5.
        /// </summary>
        public const string FVADD5 = "FVADD5";

        /// <summary>
        /// FVADD6.
        /// </summary>
        public const string FVADD6 = "FVADD6";

        /// <summary>
        /// FVADDS.
        /// </summary>
        public const string FVADDS = "FVADDS";

        /// <summary>
        /// FVADDZ.
        /// </summary>
        public const string FVADDZ = "FVADDZ";

        /// <summary>
        /// FVSHAN.
        /// </summary>
        public const string FVSHAN = "FVSHAN";

        /// <summary>
        /// FVCTR.
        /// </summary>
        public const string FVCTR = "FVCTR";

        /// <summary>
        /// FVCRCD.
        /// </summary>
        public const string FVCRCD = "FVCRCD";

        /// <summary>
        /// FVCRR.
        /// </summary>
        public const string FVCRR = "FVCRR";

        /// <summary>
        /// FVURCD.
        /// </summary>
        public const string FVURCD = "FVURCD";

        /// <summary>
        /// FVURDT.
        /// </summary>
        public const string FVURDT = "FVURDT";

        /// <summary>
        /// FVURAT.
        /// </summary>
        public const string FVURAT = "FVURAT";

        /// <summary>
        /// FVURAB.
        /// </summary>
        public const string FVURAB = "FVURAB";

        /// <summary>
        /// FVURRF.
        /// </summary>
        public const string FVURRF = "FVURRF";

        /// <summary>
        /// FVTORG.
        /// </summary>
        public const string FVTORG = "FVTORG";

        /// <summary>
        /// FVUSER.
        /// </summary>
        public const string FVUSER = "FVUSER";

        /// <summary>
        /// FVPID.
        /// </summary>
        public const string FVPID = "FVPID";

        /// <summary>
        /// FVJOBN.
        /// </summary>
        public const string FVJOBN = "FVJOBN";

        /// <summary>
        /// FVUPMJ.
        /// </summary>
        public const string FVUPMJ = "FVUPMJ";

        /// <summary>
        /// FVTDAY.
        /// </summary>
        public const string FVTDAY = "FVTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F47081";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FVEDTY", "FVEDTY", JdeDataType.String, 2),
        new JdeField("FVEDSQ", "FVEDSQ", JdeDataType.Numeric),
        new JdeField("FVEKCO", "FVEKCO", JdeDataType.String, 10, true, true),
        new JdeField("FVEDOC", "FVEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("FVEDCT", "FVEDCT", JdeDataType.String, 4, true, true),
        new JdeField("FVEDLN", "FVEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("FVEDST", "FVEDST", JdeDataType.String, 12),
        new JdeField("FVEDFT", "FVEDFT", JdeDataType.String, 20),
        new JdeField("FVEDDT", "FVEDDT", JdeDataType.Numeric),
        new JdeField("FVEDER", "FVEDER", JdeDataType.String, 2),
        new JdeField("FVEDDL", "FVEDDL", JdeDataType.Numeric),
        new JdeField("FVEDSP", "FVEDSP", JdeDataType.String, 2),
        new JdeField("FVEDBT", "FVEDBT", JdeDataType.String, 30),
        new JdeField("FVPNID", "FVPNID", JdeDataType.String, 30),
        new JdeField("FVTPUR", "FVTPUR", JdeDataType.String, 4),
        new JdeField("FVSCCD", "FVSCCD", JdeDataType.String, 4),
        new JdeField("FVCATN", "FVCATN", JdeDataType.String, 16),
        new JdeField("FVAN8", "FVAN8", JdeDataType.Numeric),
        new JdeField("FVALPH", "FVALPH", JdeDataType.String, 80),
        new JdeField("FVADD1", "FVADD1", JdeDataType.String, 80),
        new JdeField("FVADD2", "FVADD2", JdeDataType.String, 80),
        new JdeField("FVADD3", "FVADD3", JdeDataType.String, 80),
        new JdeField("FVADD4", "FVADD4", JdeDataType.String, 80),
        new JdeField("FVADD5", "FVADD5", JdeDataType.String, 80),
        new JdeField("FVADD6", "FVADD6", JdeDataType.String, 80),
        new JdeField("FVADDS", "FVADDS", JdeDataType.String, 6),
        new JdeField("FVADDZ", "FVADDZ", JdeDataType.String, 24),
        new JdeField("FVSHAN", "FVSHAN", JdeDataType.Numeric),
        new JdeField("FVCTR", "FVCTR", JdeDataType.String, 6),
        new JdeField("FVCRCD", "FVCRCD", JdeDataType.String, 6),
        new JdeField("FVCRR", "FVCRR", JdeDataType.Numeric),
        new JdeField("FVURCD", "FVURCD", JdeDataType.String, 4),
        new JdeField("FVURDT", "FVURDT", JdeDataType.Numeric),
        new JdeField("FVURAT", "FVURAT", JdeDataType.Numeric),
        new JdeField("FVURAB", "FVURAB", JdeDataType.Numeric),
        new JdeField("FVURRF", "FVURRF", JdeDataType.String, 30),
        new JdeField("FVTORG", "FVTORG", JdeDataType.String, 20),
        new JdeField("FVUSER", "FVUSER", JdeDataType.String, 20),
        new JdeField("FVPID", "FVPID", JdeDataType.String, 20),
        new JdeField("FVJOBN", "FVJOBN", JdeDataType.String, 20),
        new JdeField("FVUPMJ", "FVUPMJ", JdeDataType.Numeric),
        new JdeField("FVTDAY", "FVTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47081_0", "Primary Key on FVEDOC, FVEKCO, FVEDCT, FVEDLN", new[] { "FVEDOC", "FVEKCO", "FVEDCT", "FVEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
