using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0408 - .
/// </summary>
public class F74U0408 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LRDOCO.
        /// </summary>
        public const string LRDOCO = "LRDOCO";

        /// <summary>
        /// LRDCTO.
        /// </summary>
        public const string LRDCTO = "LRDCTO";

        /// <summary>
        /// LRKCOO.
        /// </summary>
        public const string LRKCOO = "LRKCOO";

        /// <summary>
        /// LRSFXO.
        /// </summary>
        public const string LRSFXO = "LRSFXO";

        /// <summary>
        /// LRLNID.
        /// </summary>
        public const string LRLNID = "LRLNID";

        /// <summary>
        /// LREV01.
        /// </summary>
        public const string LREV01 = "LREV01";

        /// <summary>
        /// LR74URLN.
        /// </summary>
        public const string LR74URLN = "LR74URLN";

        /// <summary>
        /// LRUKAPNM.
        /// </summary>
        public const string LRUKAPNM = "LRUKAPNM";

        /// <summary>
        /// LRAA.
        /// </summary>
        public const string LRAA = "LRAA";

        /// <summary>
        /// LR74UPRET.
        /// </summary>
        public const string LR74UPRET = "LR74UPRET";

        /// <summary>
        /// LRRTNG.
        /// </summary>
        public const string LRRTNG = "LRRTNG";

        /// <summary>
        /// LR74UPCC4.
        /// </summary>
        public const string LR74UPCC4 = "LR74UPCC4";

        /// <summary>
        /// LR74UPCC5.
        /// </summary>
        public const string LR74UPCC5 = "LR74UPCC5";

        /// <summary>
        /// LR74UPCC6.
        /// </summary>
        public const string LR74UPCC6 = "LR74UPCC6";

        /// <summary>
        /// LRURAT.
        /// </summary>
        public const string LRURAT = "LRURAT";

        /// <summary>
        /// LRURCD.
        /// </summary>
        public const string LRURCD = "LRURCD";

        /// <summary>
        /// LRURDT.
        /// </summary>
        public const string LRURDT = "LRURDT";

        /// <summary>
        /// LRURAB.
        /// </summary>
        public const string LRURAB = "LRURAB";

        /// <summary>
        /// LRURRF.
        /// </summary>
        public const string LRURRF = "LRURRF";

        /// <summary>
        /// LRPID.
        /// </summary>
        public const string LRPID = "LRPID";

        /// <summary>
        /// LRJOBN.
        /// </summary>
        public const string LRJOBN = "LRJOBN";

        /// <summary>
        /// LRUSER.
        /// </summary>
        public const string LRUSER = "LRUSER";

        /// <summary>
        /// LRUPMT.
        /// </summary>
        public const string LRUPMT = "LRUPMT";

        /// <summary>
        /// LRUPMJ.
        /// </summary>
        public const string LRUPMJ = "LRUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F74U0408";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LRDOCO", "LRDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("LRDCTO", "LRDCTO", JdeDataType.String, 4, true, true),
        new JdeField("LRKCOO", "LRKCOO", JdeDataType.String, 10, true, true),
        new JdeField("LRSFXO", "LRSFXO", JdeDataType.String, 6, true, true),
        new JdeField("LRLNID", "LRLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("LREV01", "LREV01", JdeDataType.String, 2, true, true),
        new JdeField("LR74URLN", "LR74URLN", JdeDataType.Numeric, null, true, true),
        new JdeField("LRUKAPNM", "LRUKAPNM", JdeDataType.Numeric, null, true, true),
        new JdeField("LRAA", "LRAA", JdeDataType.Numeric),
        new JdeField("LR74UPRET", "LR74UPRET", JdeDataType.Numeric),
        new JdeField("LRRTNG", "LRRTNG", JdeDataType.Numeric),
        new JdeField("LR74UPCC4", "LR74UPCC4", JdeDataType.String, 20),
        new JdeField("LR74UPCC5", "LR74UPCC5", JdeDataType.Numeric),
        new JdeField("LR74UPCC6", "LR74UPCC6", JdeDataType.String, 6),
        new JdeField("LRURAT", "LRURAT", JdeDataType.Numeric),
        new JdeField("LRURCD", "LRURCD", JdeDataType.String, 4),
        new JdeField("LRURDT", "LRURDT", JdeDataType.Numeric),
        new JdeField("LRURAB", "LRURAB", JdeDataType.Numeric),
        new JdeField("LRURRF", "LRURRF", JdeDataType.String, 30),
        new JdeField("LRPID", "LRPID", JdeDataType.String, 20),
        new JdeField("LRJOBN", "LRJOBN", JdeDataType.String, 20),
        new JdeField("LRUSER", "LRUSER", JdeDataType.String, 20),
        new JdeField("LRUPMT", "LRUPMT", JdeDataType.Numeric),
        new JdeField("LRUPMJ", "LRUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0408_0", "Primary Key on LRDOCO, LRDCTO, LRKCOO, LRSFXO, LRLNID, LREV01, LRUKAPNM, LR74URLN", new[] { "LRDOCO", "LRDCTO", "LRKCOO", "LRSFXO", "LRLNID", "LREV01", "LRUKAPNM", "LR74URLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74U0408_2", "Index on LRDOCO, LRDCTO, LRKCOO, LREV01, LRUKAPNM", new[] { "LRDOCO", "LRDCTO", "LRKCOO", "LREV01", "LRUKAPNM" }),
        new JdeIndex("F74U0408_3", "Index on LRDOCO, LRDCTO, LRKCOO, LRSFXO, LRLNID, LREV01, LRUKAPNM", new[] { "LRDOCO", "LRDCTO", "LRKCOO", "LRSFXO", "LRLNID", "LREV01", "LRUKAPNM" })
    };
}
