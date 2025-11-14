using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F52G21 - .
/// </summary>
public class F52G21 : JdeTable
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
        /// LRMCU.
        /// </summary>
        public const string LRMCU = "LRMCU";

        /// <summary>
        /// LRJBCD.
        /// </summary>
        public const string LRJBCD = "LRJBCD";

        /// <summary>
        /// LRAN8.
        /// </summary>
        public const string LRAN8 = "LRAN8";

        /// <summary>
        /// LREFTB.
        /// </summary>
        public const string LREFTB = "LREFTB";

        /// <summary>
        /// LREFTE.
        /// </summary>
        public const string LREFTE = "LREFTE";

        /// <summary>
        /// LROBJ.
        /// </summary>
        public const string LROBJ = "LROBJ";

        /// <summary>
        /// LROBJT.
        /// </summary>
        public const string LROBJT = "LROBJT";

        /// <summary>
        /// LRSUB.
        /// </summary>
        public const string LRSUB = "LRSUB";

        /// <summary>
        /// LRSUBT.
        /// </summary>
        public const string LRSUBT = "LRSUBT";

        /// <summary>
        /// LRHMCU.
        /// </summary>
        public const string LRHMCU = "LRHMCU";

        /// <summary>
        /// LRJBST.
        /// </summary>
        public const string LRJBST = "LRJBST";

        /// <summary>
        /// LRRP12.
        /// </summary>
        public const string LRRP12 = "LRRP12";

        /// <summary>
        /// LRUKID.
        /// </summary>
        public const string LRUKID = "LRUKID";

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
        /// LRUPMJ.
        /// </summary>
        public const string LRUPMJ = "LRUPMJ";

        /// <summary>
        /// LRUPMT.
        /// </summary>
        public const string LRUPMT = "LRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F52G21";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LRDOCO", "LRDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("LRDCTO", "LRDCTO", JdeDataType.String, 4, true, true),
        new JdeField("LRKCOO", "LRKCOO", JdeDataType.String, 10, true, true),
        new JdeField("LRMCU", "LRMCU", JdeDataType.String, 24, true, true),
        new JdeField("LRJBCD", "LRJBCD", JdeDataType.String, 12, true, true),
        new JdeField("LRAN8", "LRAN8", JdeDataType.Numeric),
        new JdeField("LREFTB", "LREFTB", JdeDataType.Numeric),
        new JdeField("LREFTE", "LREFTE", JdeDataType.Numeric),
        new JdeField("LROBJ", "LROBJ", JdeDataType.String, 12),
        new JdeField("LROBJT", "LROBJT", JdeDataType.String, 12),
        new JdeField("LRSUB", "LRSUB", JdeDataType.String, 16),
        new JdeField("LRSUBT", "LRSUBT", JdeDataType.String, 16),
        new JdeField("LRHMCU", "LRHMCU", JdeDataType.String, 24),
        new JdeField("LRJBST", "LRJBST", JdeDataType.String, 8),
        new JdeField("LRRP12", "LRRP12", JdeDataType.String, 6),
        new JdeField("LRUKID", "LRUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("LRPID", "LRPID", JdeDataType.String, 20),
        new JdeField("LRJOBN", "LRJOBN", JdeDataType.String, 20),
        new JdeField("LRUSER", "LRUSER", JdeDataType.String, 20),
        new JdeField("LRUPMJ", "LRUPMJ", JdeDataType.Numeric),
        new JdeField("LRUPMT", "LRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F52G21_0", "Primary Key on LRDOCO, LRDCTO, LRKCOO, LRMCU, LRJBCD, LRUKID", new[] { "LRDOCO", "LRDCTO", "LRKCOO", "LRMCU", "LRJBCD", "LRUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F52G21_2", "Index on LRDOCO, LRDCTO, LRKCOO", new[] { "LRDOCO", "LRDCTO", "LRKCOO" }),
        new JdeIndex("F52G21_3", "Index on LRMCU", new[] { "LRMCU" }),
        new JdeIndex("F52G21_4", "Index on LRUKID", new[] { "LRUKID" }),
        new JdeIndex("F52G21_5", "Index on LRDOCO, LRDCTO, LRKCOO, LRMCU, LRAN8, LRJBST, LRHMCU, LRRP12", new[] { "LRDOCO", "LRDCTO", "LRKCOO", "LRMCU", "LRAN8", "LRJBST", "LRHMCU", "LRRP12" }),
        new JdeIndex("F52G21_6", "Index on LRDOCO, LRDCTO, LRKCOO, LRMCU, SYS_NC00022$", new[] { "LRDOCO", "LRDCTO", "LRKCOO", "LRMCU", "SYS_NC00022$" })
    };
}
