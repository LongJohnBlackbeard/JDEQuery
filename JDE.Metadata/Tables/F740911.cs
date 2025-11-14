using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F740911 - .
/// </summary>
public class F740911 : JdeTable
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
        /// WAR021.
        /// </summary>
        public const string WAR021 = "WAR021";

        /// <summary>
        /// WAR022.
        /// </summary>
        public const string WAR022 = "WAR022";

        /// <summary>
        /// WAR023.
        /// </summary>
        public const string WAR023 = "WAR023";

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
        /// WAMCU.
        /// </summary>
        public const string WAMCU = "WAMCU";

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
        /// WAREG#.
        /// </summary>
        public const string WAREG_ = "WAREG#";

        /// <summary>
        /// WACRCD.
        /// </summary>
        public const string WACRCD = "WACRCD";
    }

    /// <inheritdoc />
    public override string TableName => "F740911";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WACO", "WACO", JdeDataType.String, 10, true, true),
        new JdeField("WAFY", "WAFY", JdeDataType.Numeric, null, true, true),
        new JdeField("WAPN", "WAPN", JdeDataType.Numeric, null, true, true),
        new JdeField("WAR021", "WAR021", JdeDataType.String, 20),
        new JdeField("WAR022", "WAR022", JdeDataType.String, 20),
        new JdeField("WAR023", "WAR023", JdeDataType.String, 20),
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
        new JdeField("WAMCU", "WAMCU", JdeDataType.String, 24),
        new JdeField("WARE", "WARE", JdeDataType.String, 2),
        new JdeField("WAICU", "WAICU", JdeDataType.Numeric),
        new JdeField("WAICUT", "WAICUT", JdeDataType.String, 4),
        new JdeField("WAREG#", "WAREG#", JdeDataType.Numeric),
        new JdeField("WACRCD", "WACRCD", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F740911_0", "Primary Key on WACO, WAFY, WAPN", new[] { "WACO", "WAFY", "WAPN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F740911_2", "Index on WACO", new[] { "WACO" })
    };
}
