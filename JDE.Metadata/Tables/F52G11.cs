using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F52G11 - .
/// </summary>
public class F52G11 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BDDCT.
        /// </summary>
        public const string BDDCT = "BDDCT";

        /// <summary>
        /// BDDOC.
        /// </summary>
        public const string BDDOC = "BDDOC";

        /// <summary>
        /// BDKCO.
        /// </summary>
        public const string BDKCO = "BDKCO";

        /// <summary>
        /// BDDGJ.
        /// </summary>
        public const string BDDGJ = "BDDGJ";

        /// <summary>
        /// BDJELN.
        /// </summary>
        public const string BDJELN = "BDJELN";

        /// <summary>
        /// BDLT.
        /// </summary>
        public const string BDLT = "BDLT";

        /// <summary>
        /// BDEXTL.
        /// </summary>
        public const string BDEXTL = "BDEXTL";

        /// <summary>
        /// BDBUCA.
        /// </summary>
        public const string BDBUCA = "BDBUCA";

        /// <summary>
        /// BDCO.
        /// </summary>
        public const string BDCO = "BDCO";

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
        /// BDANI.
        /// </summary>
        public const string BDANI = "BDANI";

        /// <summary>
        /// BDAID.
        /// </summary>
        public const string BDAID = "BDAID";

        /// <summary>
        /// BDPN.
        /// </summary>
        public const string BDPN = "BDPN";

        /// <summary>
        /// BDCTRY.
        /// </summary>
        public const string BDCTRY = "BDCTRY";

        /// <summary>
        /// BDFY.
        /// </summary>
        public const string BDFY = "BDFY";

        /// <summary>
        /// BDCRCD.
        /// </summary>
        public const string BDCRCD = "BDCRCD";

        /// <summary>
        /// BDU.
        /// </summary>
        public const string BDU = "BDU";

        /// <summary>
        /// BDAA.
        /// </summary>
        public const string BDAA = "BDAA";

        /// <summary>
        /// BDAA3.
        /// </summary>
        public const string BDAA3 = "BDAA3";

        /// <summary>
        /// BDITOL.
        /// </summary>
        public const string BDITOL = "BDITOL";

        /// <summary>
        /// BDBTOL.
        /// </summary>
        public const string BDBTOL = "BDBTOL";

        /// <summary>
        /// BDEXA.
        /// </summary>
        public const string BDEXA = "BDEXA";

        /// <summary>
        /// BDEXR.
        /// </summary>
        public const string BDEXR = "BDEXR";

        /// <summary>
        /// BDAN8.
        /// </summary>
        public const string BDAN8 = "BDAN8";

        /// <summary>
        /// BDAHBU.
        /// </summary>
        public const string BDAHBU = "BDAHBU";

        /// <summary>
        /// BDEPGC.
        /// </summary>
        public const string BDEPGC = "BDEPGC";

        /// <summary>
        /// BDJBCD.
        /// </summary>
        public const string BDJBCD = "BDJBCD";

        /// <summary>
        /// BDJBST.
        /// </summary>
        public const string BDJBST = "BDJBST";

        /// <summary>
        /// BDJPGC.
        /// </summary>
        public const string BDJPGC = "BDJPGC";

        /// <summary>
        /// BDSEGMID.
        /// </summary>
        public const string BDSEGMID = "BDSEGMID";

        /// <summary>
        /// BDPOOLID.
        /// </summary>
        public const string BDPOOLID = "BDPOOLID";

        /// <summary>
        /// BDDSVJ.
        /// </summary>
        public const string BDDSVJ = "BDDSVJ";

        /// <summary>
        /// BDBC.
        /// </summary>
        public const string BDBC = "BDBC";

        /// <summary>
        /// BDAID5.
        /// </summary>
        public const string BDAID5 = "BDAID5";

        /// <summary>
        /// BDAID6.
        /// </summary>
        public const string BDAID6 = "BDAID6";

        /// <summary>
        /// BDRAS.
        /// </summary>
        public const string BDRAS = "BDRAS";

        /// <summary>
        /// BDRAG.
        /// </summary>
        public const string BDRAG = "BDRAG";

        /// <summary>
        /// BDCTF4.
        /// </summary>
        public const string BDCTF4 = "BDCTF4";

        /// <summary>
        /// BDGPF1.
        /// </summary>
        public const string BDGPF1 = "BDGPF1";

        /// <summary>
        /// BDFFU3.
        /// </summary>
        public const string BDFFU3 = "BDFFU3";

        /// <summary>
        /// BDTXF1.
        /// </summary>
        public const string BDTXF1 = "BDTXF1";

        /// <summary>
        /// BDPID.
        /// </summary>
        public const string BDPID = "BDPID";

        /// <summary>
        /// BDMKEY.
        /// </summary>
        public const string BDMKEY = "BDMKEY";

        /// <summary>
        /// BDUSER.
        /// </summary>
        public const string BDUSER = "BDUSER";

        /// <summary>
        /// BDUPMJ.
        /// </summary>
        public const string BDUPMJ = "BDUPMJ";

        /// <summary>
        /// BDUPMT.
        /// </summary>
        public const string BDUPMT = "BDUPMT";

        /// <summary>
        /// BDSEQ.
        /// </summary>
        public const string BDSEQ = "BDSEQ";

        /// <summary>
        /// BDICU.
        /// </summary>
        public const string BDICU = "BDICU";

        /// <summary>
        /// BDICUT.
        /// </summary>
        public const string BDICUT = "BDICUT";

        /// <summary>
        /// BDDICJ.
        /// </summary>
        public const string BDDICJ = "BDDICJ";

        /// <summary>
        /// BDUM.
        /// </summary>
        public const string BDUM = "BDUM";
    }

    /// <inheritdoc />
    public override string TableName => "F52G11";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BDDCT", "BDDCT", JdeDataType.String, 4, true, true),
        new JdeField("BDDOC", "BDDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("BDKCO", "BDKCO", JdeDataType.String, 10, true, true),
        new JdeField("BDDGJ", "BDDGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("BDJELN", "BDJELN", JdeDataType.Numeric, null, true, true),
        new JdeField("BDLT", "BDLT", JdeDataType.String, 4, true, true),
        new JdeField("BDEXTL", "BDEXTL", JdeDataType.String, 4, true, true),
        new JdeField("BDBUCA", "BDBUCA", JdeDataType.String, 10, true, true),
        new JdeField("BDCO", "BDCO", JdeDataType.String, 10),
        new JdeField("BDMCU", "BDMCU", JdeDataType.String, 24),
        new JdeField("BDOBJ", "BDOBJ", JdeDataType.String, 12),
        new JdeField("BDSUB", "BDSUB", JdeDataType.String, 16),
        new JdeField("BDSBL", "BDSBL", JdeDataType.String, 16),
        new JdeField("BDSBLT", "BDSBLT", JdeDataType.String, 2),
        new JdeField("BDANI", "BDANI", JdeDataType.String, 58),
        new JdeField("BDAID", "BDAID", JdeDataType.String, 16),
        new JdeField("BDPN", "BDPN", JdeDataType.Numeric),
        new JdeField("BDCTRY", "BDCTRY", JdeDataType.Numeric),
        new JdeField("BDFY", "BDFY", JdeDataType.Numeric),
        new JdeField("BDCRCD", "BDCRCD", JdeDataType.String, 6),
        new JdeField("BDU", "BDU", JdeDataType.Numeric),
        new JdeField("BDAA", "BDAA", JdeDataType.Numeric),
        new JdeField("BDAA3", "BDAA3", JdeDataType.Numeric),
        new JdeField("BDITOL", "BDITOL", JdeDataType.Numeric),
        new JdeField("BDBTOL", "BDBTOL", JdeDataType.Numeric),
        new JdeField("BDEXA", "BDEXA", JdeDataType.String, 60),
        new JdeField("BDEXR", "BDEXR", JdeDataType.String, 60),
        new JdeField("BDAN8", "BDAN8", JdeDataType.Numeric),
        new JdeField("BDAHBU", "BDAHBU", JdeDataType.String, 24),
        new JdeField("BDEPGC", "BDEPGC", JdeDataType.String, 6),
        new JdeField("BDJBCD", "BDJBCD", JdeDataType.String, 12),
        new JdeField("BDJBST", "BDJBST", JdeDataType.String, 8),
        new JdeField("BDJPGC", "BDJPGC", JdeDataType.String, 6),
        new JdeField("BDSEGMID", "BDSEGMID", JdeDataType.String, 6),
        new JdeField("BDPOOLID", "BDPOOLID", JdeDataType.String, 8),
        new JdeField("BDDSVJ", "BDDSVJ", JdeDataType.Numeric),
        new JdeField("BDBC", "BDBC", JdeDataType.String, 2),
        new JdeField("BDAID5", "BDAID5", JdeDataType.String, 16),
        new JdeField("BDAID6", "BDAID6", JdeDataType.String, 16),
        new JdeField("BDRAS", "BDRAS", JdeDataType.String, 2),
        new JdeField("BDRAG", "BDRAG", JdeDataType.Numeric),
        new JdeField("BDCTF4", "BDCTF4", JdeDataType.String, 2),
        new JdeField("BDGPF1", "BDGPF1", JdeDataType.String, 2),
        new JdeField("BDFFU3", "BDFFU3", JdeDataType.String, 20),
        new JdeField("BDTXF1", "BDTXF1", JdeDataType.String, 20),
        new JdeField("BDPID", "BDPID", JdeDataType.String, 20),
        new JdeField("BDMKEY", "BDMKEY", JdeDataType.String, 30),
        new JdeField("BDUSER", "BDUSER", JdeDataType.String, 20),
        new JdeField("BDUPMJ", "BDUPMJ", JdeDataType.Numeric),
        new JdeField("BDUPMT", "BDUPMT", JdeDataType.Numeric),
        new JdeField("BDSEQ", "BDSEQ", JdeDataType.Numeric),
        new JdeField("BDICU", "BDICU", JdeDataType.Numeric),
        new JdeField("BDICUT", "BDICUT", JdeDataType.String, 4),
        new JdeField("BDDICJ", "BDDICJ", JdeDataType.Numeric),
        new JdeField("BDUM", "BDUM", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F52G11_0", "Primary Key on BDDCT, BDDOC, BDKCO, BDDGJ, BDJELN, BDLT, BDEXTL, BDBUCA", new[] { "BDDCT", "BDDOC", "BDKCO", "BDDGJ", "BDJELN", "BDLT", "BDEXTL", "BDBUCA" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F52G11_2", "Index on BDLT, BDMCU, BDOBJ, BDSUB, BDSBL, BDSBLT, BDCO, BDSEGMID, BDEPGC, BDJPGC, BDBUCA, BDAN8, BDAHBU, BDJBCD, BDJBST", new[] { "BDLT", "BDMCU", "BDOBJ", "BDSUB", "BDSBL", "BDSBLT", "BDCO", "BDSEGMID", "BDEPGC", "BDJPGC", "BDBUCA", "BDAN8", "BDAHBU", "BDJBCD", "BDJBST" }),
        new JdeIndex("F52G11_3", "Index on BDRAG, BDSEGMID, BDSEQ, BDPOOLID", new[] { "BDRAG", "BDSEGMID", "BDSEQ", "BDPOOLID" }),
        new JdeIndex("F52G11_4", "Index on BDMCU, BDOBJ, BDSUB, BDSBL, BDSBLT", new[] { "BDMCU", "BDOBJ", "BDSUB", "BDSBL", "BDSBLT" }),
        new JdeIndex("F52G11_5", "Index on BDAID", new[] { "BDAID" })
    };
}
