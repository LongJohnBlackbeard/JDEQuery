using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B911 - .
/// </summary>
public class F76B911 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BDUKID.
        /// </summary>
        public const string BDUKID = "BDUKID";

        /// <summary>
        /// BDDGJ.
        /// </summary>
        public const string BDDGJ = "BDDGJ";

        /// <summary>
        /// BDMCU.
        /// </summary>
        public const string BDMCU = "BDMCU";

        /// <summary>
        /// BDOBJ.
        /// </summary>
        public const string BDOBJ = "BDOBJ";

        /// <summary>
        /// BDSUB.
        /// </summary>
        public const string BDSUB = "BDSUB";

        /// <summary>
        /// BDSBL.
        /// </summary>
        public const string BDSBL = "BDSBL";

        /// <summary>
        /// BDSBLT.
        /// </summary>
        public const string BDSBLT = "BDSBLT";

        /// <summary>
        /// BDOFAC.
        /// </summary>
        public const string BDOFAC = "BDOFAC";

        /// <summary>
        /// BDAA.
        /// </summary>
        public const string BDAA = "BDAA";

        /// <summary>
        /// BDCDC1.
        /// </summary>
        public const string BDCDC1 = "BDCDC1";

        /// <summary>
        /// BDICU.
        /// </summary>
        public const string BDICU = "BDICU";

        /// <summary>
        /// BDKCO.
        /// </summary>
        public const string BDKCO = "BDKCO";

        /// <summary>
        /// BDDCT.
        /// </summary>
        public const string BDDCT = "BDDCT";

        /// <summary>
        /// BDDOC.
        /// </summary>
        public const string BDDOC = "BDDOC";

        /// <summary>
        /// BDJELN.
        /// </summary>
        public const string BDJELN = "BDJELN";

        /// <summary>
        /// BDEXR.
        /// </summary>
        public const string BDEXR = "BDEXR";

        /// <summary>
        /// BDEXA.
        /// </summary>
        public const string BDEXA = "BDEXA";

        /// <summary>
        /// BDCO.
        /// </summary>
        public const string BDCO = "BDCO";

        /// <summary>
        /// BDEXTL.
        /// </summary>
        public const string BDEXTL = "BDEXTL";

        /// <summary>
        /// BDLT.
        /// </summary>
        public const string BDLT = "BDLT";

        /// <summary>
        /// BDRDOR.
        /// </summary>
        public const string BDRDOR = "BDRDOR";

        /// <summary>
        /// BDTORG.
        /// </summary>
        public const string BDTORG = "BDTORG";

        /// <summary>
        /// BDUSER.
        /// </summary>
        public const string BDUSER = "BDUSER";

        /// <summary>
        /// BDPID.
        /// </summary>
        public const string BDPID = "BDPID";

        /// <summary>
        /// BDJOBN.
        /// </summary>
        public const string BDJOBN = "BDJOBN";

        /// <summary>
        /// BDUPMJ.
        /// </summary>
        public const string BDUPMJ = "BDUPMJ";

        /// <summary>
        /// BDUPMT.
        /// </summary>
        public const string BDUPMT = "BDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B911";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BDUKID", "BDUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("BDDGJ", "BDDGJ", JdeDataType.Numeric),
        new JdeField("BDMCU", "BDMCU", JdeDataType.String, 24),
        new JdeField("BDOBJ", "BDOBJ", JdeDataType.String, 12),
        new JdeField("BDSUB", "BDSUB", JdeDataType.String, 16),
        new JdeField("BDSBL", "BDSBL", JdeDataType.String, 16),
        new JdeField("BDSBLT", "BDSBLT", JdeDataType.String, 2),
        new JdeField("BDOFAC", "BDOFAC", JdeDataType.String, 70),
        new JdeField("BDAA", "BDAA", JdeDataType.Numeric),
        new JdeField("BDCDC1", "BDCDC1", JdeDataType.String, 2),
        new JdeField("BDICU", "BDICU", JdeDataType.Numeric),
        new JdeField("BDKCO", "BDKCO", JdeDataType.String, 10),
        new JdeField("BDDCT", "BDDCT", JdeDataType.String, 4),
        new JdeField("BDDOC", "BDDOC", JdeDataType.Numeric),
        new JdeField("BDJELN", "BDJELN", JdeDataType.Numeric),
        new JdeField("BDEXR", "BDEXR", JdeDataType.String, 60),
        new JdeField("BDEXA", "BDEXA", JdeDataType.String, 60),
        new JdeField("BDCO", "BDCO", JdeDataType.String, 10),
        new JdeField("BDEXTL", "BDEXTL", JdeDataType.String, 4),
        new JdeField("BDLT", "BDLT", JdeDataType.String, 4),
        new JdeField("BDRDOR", "BDRDOR", JdeDataType.String, 2),
        new JdeField("BDTORG", "BDTORG", JdeDataType.String, 20),
        new JdeField("BDUSER", "BDUSER", JdeDataType.String, 20),
        new JdeField("BDPID", "BDPID", JdeDataType.String, 20),
        new JdeField("BDJOBN", "BDJOBN", JdeDataType.String, 20),
        new JdeField("BDUPMJ", "BDUPMJ", JdeDataType.Numeric),
        new JdeField("BDUPMT", "BDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B911_0", "Primary Key on BDUKID", new[] { "BDUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B911_2", "Unique Index on BDDGJ, BDKCO, BDDCT, BDDOC, BDJELN, BDEXTL, BDLT", new[] { "BDDGJ", "BDKCO", "BDDCT", "BDDOC", "BDJELN", "BDEXTL", "BDLT" }, isUnique: true)
    };
}
