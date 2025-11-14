using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F70UI001 - .
/// </summary>
public class F70UI001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WACO.
        /// </summary>
        public const string WACO = "WACO";

        /// <summary>
        /// WAFY.
        /// </summary>
        public const string WAFY = "WAFY";

        /// <summary>
        /// WAPN.
        /// </summary>
        public const string WAPN = "WAPN";

        /// <summary>
        /// WADOC.
        /// </summary>
        public const string WADOC = "WADOC";

        /// <summary>
        /// WADCT.
        /// </summary>
        public const string WADCT = "WADCT";

        /// <summary>
        /// WADGJ.
        /// </summary>
        public const string WADGJ = "WADGJ";

        /// <summary>
        /// WAEXA.
        /// </summary>
        public const string WAEXA = "WAEXA";

        /// <summary>
        /// WAEXR.
        /// </summary>
        public const string WAEXR = "WAEXR";

        /// <summary>
        /// WASBL.
        /// </summary>
        public const string WASBL = "WASBL";

        /// <summary>
        /// WASBLT.
        /// </summary>
        public const string WASBLT = "WASBLT";

        /// <summary>
        /// WALT.
        /// </summary>
        public const string WALT = "WALT";

        /// <summary>
        /// WAPOST.
        /// </summary>
        public const string WAPOST = "WAPOST";

        /// <summary>
        /// WABGBL.
        /// </summary>
        public const string WABGBL = "WABGBL";

        /// <summary>
        /// WACREE.
        /// </summary>
        public const string WACREE = "WACREE";

        /// <summary>
        /// WADEBE.
        /// </summary>
        public const string WADEBE = "WADEBE";

        /// <summary>
        /// WAOBJ.
        /// </summary>
        public const string WAOBJ = "WAOBJ";

        /// <summary>
        /// WASUB.
        /// </summary>
        public const string WASUB = "WASUB";

        /// <summary>
        /// WAR2.
        /// </summary>
        public const string WAR2 = "WAR2";

        /// <summary>
        /// WARCND.
        /// </summary>
        public const string WARCND = "WARCND";

        /// <summary>
        /// WARE.
        /// </summary>
        public const string WARE = "WARE";

        /// <summary>
        /// WAICU.
        /// </summary>
        public const string WAICU = "WAICU";

        /// <summary>
        /// WAICUT.
        /// </summary>
        public const string WAICUT = "WAICUT";

        /// <summary>
        /// WAMCU.
        /// </summary>
        public const string WAMCU = "WAMCU";

        /// <summary>
        /// WAREG#.
        /// </summary>
        public const string WAREG_ = "WAREG#";

        /// <summary>
        /// WACRCD.
        /// </summary>
        public const string WACRCD = "WACRCD";

        /// <summary>
        /// WANNBR.
        /// </summary>
        public const string WANNBR = "WANNBR";

        /// <summary>
        /// WAWCCV.
        /// </summary>
        public const string WAWCCV = "WAWCCV";

        /// <summary>
        /// WAUSER.
        /// </summary>
        public const string WAUSER = "WAUSER";

        /// <summary>
        /// WAMACH.
        /// </summary>
        public const string WAMACH = "WAMACH";

        /// <summary>
        /// WAJOBS.
        /// </summary>
        public const string WAJOBS = "WAJOBS";
    }

    /// <inheritdoc />
    public override string TableName => "F70UI001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WACO", "WACO", JdeDataType.String, 10),
        new JdeField("WAFY", "WAFY", JdeDataType.Numeric),
        new JdeField("WAPN", "WAPN", JdeDataType.Numeric),
        new JdeField("WADOC", "WADOC", JdeDataType.Numeric),
        new JdeField("WADCT", "WADCT", JdeDataType.String, 4),
        new JdeField("WADGJ", "WADGJ", JdeDataType.Numeric),
        new JdeField("WAEXA", "WAEXA", JdeDataType.String, 60),
        new JdeField("WAEXR", "WAEXR", JdeDataType.String, 60),
        new JdeField("WASBL", "WASBL", JdeDataType.String, 16),
        new JdeField("WASBLT", "WASBLT", JdeDataType.String, 2),
        new JdeField("WALT", "WALT", JdeDataType.String, 4),
        new JdeField("WAPOST", "WAPOST", JdeDataType.String, 2),
        new JdeField("WABGBL", "WABGBL", JdeDataType.Numeric),
        new JdeField("WACREE", "WACREE", JdeDataType.Numeric),
        new JdeField("WADEBE", "WADEBE", JdeDataType.Numeric),
        new JdeField("WAOBJ", "WAOBJ", JdeDataType.String, 12),
        new JdeField("WASUB", "WASUB", JdeDataType.String, 16),
        new JdeField("WAR2", "WAR2", JdeDataType.String, 16),
        new JdeField("WARCND", "WARCND", JdeDataType.String, 2),
        new JdeField("WARE", "WARE", JdeDataType.String, 2),
        new JdeField("WAICU", "WAICU", JdeDataType.Numeric),
        new JdeField("WAICUT", "WAICUT", JdeDataType.String, 4),
        new JdeField("WAMCU", "WAMCU", JdeDataType.String, 24),
        new JdeField("WAREG#", "WAREG#", JdeDataType.Numeric),
        new JdeField("WACRCD", "WACRCD", JdeDataType.String, 6),
        new JdeField("WANNBR", "WANNBR", JdeDataType.Numeric, null, true, true),
        new JdeField("WAWCCV", "WAWCCV", JdeDataType.String, 20),
        new JdeField("WAUSER", "WAUSER", JdeDataType.String, 20, true, true),
        new JdeField("WAMACH", "WAMACH", JdeDataType.String, 24, true, true),
        new JdeField("WAJOBS", "WAJOBS", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F70UI001_0", "Primary Key on WAUSER, WAMACH, WAJOBS, WANNBR", new[] { "WAUSER", "WAMACH", "WAJOBS", "WANNBR" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F70UI001_2", "Index on WAUSER, WAMACH, WAJOBS", new[] { "WAUSER", "WAMACH", "WAJOBS" })
    };
}
