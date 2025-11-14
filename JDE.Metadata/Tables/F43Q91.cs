using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43Q91 - .
/// </summary>
public class F43Q91 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BRAN8.
        /// </summary>
        public const string BRAN8 = "BRAN8";

        /// <summary>
        /// BRCRRP.
        /// </summary>
        public const string BRCRRP = "BRCRRP";

        /// <summary>
        /// BRCRCA.
        /// </summary>
        public const string BRCRCA = "BRCRCA";

        /// <summary>
        /// BRTRAP.
        /// </summary>
        public const string BRTRAP = "BRTRAP";

        /// <summary>
        /// BRTAX.
        /// </summary>
        public const string BRTAX = "BRTAX";

        /// <summary>
        /// BRTAXC.
        /// </summary>
        public const string BRTAXC = "BRTAXC";

        /// <summary>
        /// BRTX2.
        /// </summary>
        public const string BRTX2 = "BRTX2";

        /// <summary>
        /// BRPYIN.
        /// </summary>
        public const string BRPYIN = "BRPYIN";

        /// <summary>
        /// BREDPM.
        /// </summary>
        public const string BREDPM = "BREDPM";

        /// <summary>
        /// BREDII.
        /// </summary>
        public const string BREDII = "BREDII";

        /// <summary>
        /// BREDQD.
        /// </summary>
        public const string BREDQD = "BREDQD";

        /// <summary>
        /// BREDAD.
        /// </summary>
        public const string BREDAD = "BREDAD";

        /// <summary>
        /// BRMINO.
        /// </summary>
        public const string BRMINO = "BRMINO";

        /// <summary>
        /// BRMAXO.
        /// </summary>
        public const string BRMAXO = "BRMAXO";

        /// <summary>
        /// BRVUMD.
        /// </summary>
        public const string BRVUMD = "BRVUMD";

        /// <summary>
        /// BRWUMD.
        /// </summary>
        public const string BRWUMD = "BRWUMD";

        /// <summary>
        /// BRFRTH.
        /// </summary>
        public const string BRFRTH = "BRFRTH";

        /// <summary>
        /// BRDEL1.
        /// </summary>
        public const string BRDEL1 = "BRDEL1";

        /// <summary>
        /// BRDAYEXPIR.
        /// </summary>
        public const string BRDAYEXPIR = "BRDAYEXPIR";

        /// <summary>
        /// BRDAYSDUE.
        /// </summary>
        public const string BRDAYSDUE = "BRDAYSDUE";

        /// <summary>
        /// BRDAYAWARD.
        /// </summary>
        public const string BRDAYAWARD = "BRDAYAWARD";

        /// <summary>
        /// BRDAYOUTB.
        /// </summary>
        public const string BRDAYOUTB = "BRDAYOUTB";

        /// <summary>
        /// BRURCD.
        /// </summary>
        public const string BRURCD = "BRURCD";

        /// <summary>
        /// BRURDT.
        /// </summary>
        public const string BRURDT = "BRURDT";

        /// <summary>
        /// BRURAT.
        /// </summary>
        public const string BRURAT = "BRURAT";

        /// <summary>
        /// BRURAB.
        /// </summary>
        public const string BRURAB = "BRURAB";

        /// <summary>
        /// BRURRF.
        /// </summary>
        public const string BRURRF = "BRURRF";

        /// <summary>
        /// BRTORG.
        /// </summary>
        public const string BRTORG = "BRTORG";

        /// <summary>
        /// BRUSER.
        /// </summary>
        public const string BRUSER = "BRUSER";

        /// <summary>
        /// BRPID.
        /// </summary>
        public const string BRPID = "BRPID";

        /// <summary>
        /// BRJOBN.
        /// </summary>
        public const string BRJOBN = "BRJOBN";

        /// <summary>
        /// BRUPMJ.
        /// </summary>
        public const string BRUPMJ = "BRUPMJ";

        /// <summary>
        /// BRTDAY.
        /// </summary>
        public const string BRTDAY = "BRTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F43Q91";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BRAN8", "BRAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("BRCRRP", "BRCRRP", JdeDataType.String, 6),
        new JdeField("BRCRCA", "BRCRCA", JdeDataType.String, 6),
        new JdeField("BRTRAP", "BRTRAP", JdeDataType.String, 6),
        new JdeField("BRTAX", "BRTAX", JdeDataType.String, 40),
        new JdeField("BRTAXC", "BRTAXC", JdeDataType.String, 2),
        new JdeField("BRTX2", "BRTX2", JdeDataType.String, 40),
        new JdeField("BRPYIN", "BRPYIN", JdeDataType.String, 2),
        new JdeField("BREDPM", "BREDPM", JdeDataType.String, 2),
        new JdeField("BREDII", "BREDII", JdeDataType.String, 2),
        new JdeField("BREDQD", "BREDQD", JdeDataType.Numeric),
        new JdeField("BREDAD", "BREDAD", JdeDataType.Numeric),
        new JdeField("BRMINO", "BRMINO", JdeDataType.Numeric),
        new JdeField("BRMAXO", "BRMAXO", JdeDataType.Numeric),
        new JdeField("BRVUMD", "BRVUMD", JdeDataType.String, 4),
        new JdeField("BRWUMD", "BRWUMD", JdeDataType.String, 4),
        new JdeField("BRFRTH", "BRFRTH", JdeDataType.String, 6),
        new JdeField("BRDEL1", "BRDEL1", JdeDataType.String, 60),
        new JdeField("BRDAYEXPIR", "BRDAYEXPIR", JdeDataType.Numeric),
        new JdeField("BRDAYSDUE", "BRDAYSDUE", JdeDataType.Numeric),
        new JdeField("BRDAYAWARD", "BRDAYAWARD", JdeDataType.Numeric),
        new JdeField("BRDAYOUTB", "BRDAYOUTB", JdeDataType.Numeric),
        new JdeField("BRURCD", "BRURCD", JdeDataType.String, 4),
        new JdeField("BRURDT", "BRURDT", JdeDataType.Numeric),
        new JdeField("BRURAT", "BRURAT", JdeDataType.Numeric),
        new JdeField("BRURAB", "BRURAB", JdeDataType.Numeric),
        new JdeField("BRURRF", "BRURRF", JdeDataType.String, 30),
        new JdeField("BRTORG", "BRTORG", JdeDataType.String, 20),
        new JdeField("BRUSER", "BRUSER", JdeDataType.String, 20),
        new JdeField("BRPID", "BRPID", JdeDataType.String, 20),
        new JdeField("BRJOBN", "BRJOBN", JdeDataType.String, 20),
        new JdeField("BRUPMJ", "BRUPMJ", JdeDataType.Numeric),
        new JdeField("BRTDAY", "BRTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43Q91_0", "Primary Key on BRAN8", new[] { "BRAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
