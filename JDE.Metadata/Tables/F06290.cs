using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06290 - .
/// </summary>
public class F06290 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YRPRJE.
        /// </summary>
        public const string YRPRJE = "YRPRJE";

        /// <summary>
        /// YRCO.
        /// </summary>
        public const string YRCO = "YRCO";

        /// <summary>
        /// YRDCT.
        /// </summary>
        public const string YRDCT = "YRDCT";

        /// <summary>
        /// YRMCU.
        /// </summary>
        public const string YRMCU = "YRMCU";

        /// <summary>
        /// YROBJ.
        /// </summary>
        public const string YROBJ = "YROBJ";

        /// <summary>
        /// YRSUB.
        /// </summary>
        public const string YRSUB = "YRSUB";

        /// <summary>
        /// YRSBL.
        /// </summary>
        public const string YRSBL = "YRSBL";

        /// <summary>
        /// YRSBLT.
        /// </summary>
        public const string YRSBLT = "YRSBLT";

        /// <summary>
        /// YRWR01.
        /// </summary>
        public const string YRWR01 = "YRWR01";

        /// <summary>
        /// YRGPA.
        /// </summary>
        public const string YRGPA = "YRGPA";

        /// <summary>
        /// YRPHRW.
        /// </summary>
        public const string YRPHRW = "YRPHRW";

        /// <summary>
        /// YRCTRY.
        /// </summary>
        public const string YRCTRY = "YRCTRY";

        /// <summary>
        /// YRFY.
        /// </summary>
        public const string YRFY = "YRFY";

        /// <summary>
        /// YRPN.
        /// </summary>
        public const string YRPN = "YRPN";

        /// <summary>
        /// YRDGJ.
        /// </summary>
        public const string YRDGJ = "YRDGJ";

        /// <summary>
        /// YRAN8.
        /// </summary>
        public const string YRAN8 = "YRAN8";

        /// <summary>
        /// YREQCG.
        /// </summary>
        public const string YREQCG = "YREQCG";

        /// <summary>
        /// YRJBCD.
        /// </summary>
        public const string YRJBCD = "YRJBCD";

        /// <summary>
        /// YRJBST.
        /// </summary>
        public const string YRJBST = "YRJBST";

        /// <summary>
        /// YREXR.
        /// </summary>
        public const string YREXR = "YREXR";

        /// <summary>
        /// YRPDBA.
        /// </summary>
        public const string YRPDBA = "YRPDBA";

        /// <summary>
        /// YRHMCO.
        /// </summary>
        public const string YRHMCO = "YRHMCO";

        /// <summary>
        /// YRANI.
        /// </summary>
        public const string YRANI = "YRANI";
    }

    /// <inheritdoc />
    public override string TableName => "F06290";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YRPRJE", "YRPRJE", JdeDataType.String, 4),
        new JdeField("YRCO", "YRCO", JdeDataType.String, 10, true, true),
        new JdeField("YRDCT", "YRDCT", JdeDataType.String, 4, true, true),
        new JdeField("YRMCU", "YRMCU", JdeDataType.String, 24),
        new JdeField("YROBJ", "YROBJ", JdeDataType.String, 12),
        new JdeField("YRSUB", "YRSUB", JdeDataType.String, 16),
        new JdeField("YRSBL", "YRSBL", JdeDataType.String, 16),
        new JdeField("YRSBLT", "YRSBLT", JdeDataType.String, 2),
        new JdeField("YRWR01", "YRWR01", JdeDataType.String, 8),
        new JdeField("YRGPA", "YRGPA", JdeDataType.Numeric),
        new JdeField("YRPHRW", "YRPHRW", JdeDataType.Numeric),
        new JdeField("YRCTRY", "YRCTRY", JdeDataType.Numeric),
        new JdeField("YRFY", "YRFY", JdeDataType.Numeric),
        new JdeField("YRPN", "YRPN", JdeDataType.Numeric, null, true, true),
        new JdeField("YRDGJ", "YRDGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("YRAN8", "YRAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YREQCG", "YREQCG", JdeDataType.String, 18),
        new JdeField("YRJBCD", "YRJBCD", JdeDataType.String, 12),
        new JdeField("YRJBST", "YRJBST", JdeDataType.String, 8),
        new JdeField("YREXR", "YREXR", JdeDataType.String, 60),
        new JdeField("YRPDBA", "YRPDBA", JdeDataType.Numeric),
        new JdeField("YRHMCO", "YRHMCO", JdeDataType.String, 10),
        new JdeField("YRANI", "YRANI", JdeDataType.String, 58)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06290_0", "Primary Key on YRAN8, YRDCT, YRPN, YRDGJ, YRCO", new[] { "YRAN8", "YRDCT", "YRPN", "YRDGJ", "YRCO" }, isUnique: true, isPrimaryKey: true)
    };
}
