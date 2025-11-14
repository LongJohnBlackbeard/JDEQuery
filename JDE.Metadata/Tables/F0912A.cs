using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0912A - .
/// </summary>
public class F0912A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RIHST.
        /// </summary>
        public const string RIHST = "RIHST";

        /// <summary>
        /// RIALOC.
        /// </summary>
        public const string RIALOC = "RIALOC";

        /// <summary>
        /// RIRFAC.
        /// </summary>
        public const string RIRFAC = "RIRFAC";

        /// <summary>
        /// RISEN.
        /// </summary>
        public const string RISEN = "RISEN";

        /// <summary>
        /// RIFCC.
        /// </summary>
        public const string RIFCC = "RIFCC";

        /// <summary>
        /// RIFROM.
        /// </summary>
        public const string RIFROM = "RIFROM";

        /// <summary>
        /// RITHRU.
        /// </summary>
        public const string RITHRU = "RITHRU";

        /// <summary>
        /// RIMY.
        /// </summary>
        public const string RIMY = "RIMY";

        /// <summary>
        /// RIUSER.
        /// </summary>
        public const string RIUSER = "RIUSER";

        /// <summary>
        /// RIAID.
        /// </summary>
        public const string RIAID = "RIAID";

        /// <summary>
        /// RIANI.
        /// </summary>
        public const string RIANI = "RIANI";

        /// <summary>
        /// RICO.
        /// </summary>
        public const string RICO = "RICO";

        /// <summary>
        /// RILT.
        /// </summary>
        public const string RILT = "RILT";

        /// <summary>
        /// RISBL.
        /// </summary>
        public const string RISBL = "RISBL";

        /// <summary>
        /// RIAM.
        /// </summary>
        public const string RIAM = "RIAM";

        /// <summary>
        /// RIGLC.
        /// </summary>
        public const string RIGLC = "RIGLC";

        /// <summary>
        /// RIR1.
        /// </summary>
        public const string RIR1 = "RIR1";

        /// <summary>
        /// RIR2.
        /// </summary>
        public const string RIR2 = "RIR2";

        /// <summary>
        /// RIDCT.
        /// </summary>
        public const string RIDCT = "RIDCT";

        /// <summary>
        /// RIDOC.
        /// </summary>
        public const string RIDOC = "RIDOC";

        /// <summary>
        /// RISFX.
        /// </summary>
        public const string RISFX = "RISFX";

        /// <summary>
        /// RIASID.
        /// </summary>
        public const string RIASID = "RIASID";

        /// <summary>
        /// RIDGJ.
        /// </summary>
        public const string RIDGJ = "RIDGJ";

        /// <summary>
        /// RIDSVJ.
        /// </summary>
        public const string RIDSVJ = "RIDSVJ";

        /// <summary>
        /// RIEXA.
        /// </summary>
        public const string RIEXA = "RIEXA";

        /// <summary>
        /// RIEXR.
        /// </summary>
        public const string RIEXR = "RIEXR";

        /// <summary>
        /// RIAA.
        /// </summary>
        public const string RIAA = "RIAA";

        /// <summary>
        /// RIU.
        /// </summary>
        public const string RIU = "RIU";

        /// <summary>
        /// RIJELN.
        /// </summary>
        public const string RIJELN = "RIJELN";

        /// <summary>
        /// RIRE.
        /// </summary>
        public const string RIRE = "RIRE";

        /// <summary>
        /// RIDOI.
        /// </summary>
        public const string RIDOI = "RIDOI";

        /// <summary>
        /// RIBC.
        /// </summary>
        public const string RIBC = "RIBC";

        /// <summary>
        /// RIFY.
        /// </summary>
        public const string RIFY = "RIFY";

        /// <summary>
        /// RIPN.
        /// </summary>
        public const string RIPN = "RIPN";

        /// <summary>
        /// RICTRY.
        /// </summary>
        public const string RICTRY = "RICTRY";

        /// <summary>
        /// RIRF.
        /// </summary>
        public const string RIRF = "RIRF";

        /// <summary>
        /// RIFLT.
        /// </summary>
        public const string RIFLT = "RIFLT";

        /// <summary>
        /// RIFPN.
        /// </summary>
        public const string RIFPN = "RIFPN";

        /// <summary>
        /// RIFFY.
        /// </summary>
        public const string RIFFY = "RIFFY";

        /// <summary>
        /// RIFCTY.
        /// </summary>
        public const string RIFCTY = "RIFCTY";

        /// <summary>
        /// RIFSBL.
        /// </summary>
        public const string RIFSBL = "RIFSBL";

        /// <summary>
        /// RISLK.
        /// </summary>
        public const string RISLK = "RISLK";

        /// <summary>
        /// RIMCU.
        /// </summary>
        public const string RIMCU = "RIMCU";

        /// <summary>
        /// RIOBJ.
        /// </summary>
        public const string RIOBJ = "RIOBJ";

        /// <summary>
        /// RISUB.
        /// </summary>
        public const string RISUB = "RISUB";

        /// <summary>
        /// RIFSUB.
        /// </summary>
        public const string RIFSUB = "RIFSUB";

        /// <summary>
        /// RISUBT.
        /// </summary>
        public const string RISUBT = "RISUBT";

        /// <summary>
        /// RIBCF.
        /// </summary>
        public const string RIBCF = "RIBCF";

        /// <summary>
        /// RIBCTO.
        /// </summary>
        public const string RIBCTO = "RIBCTO";

        /// <summary>
        /// RIOBJT.
        /// </summary>
        public const string RIOBJT = "RIOBJT";

        /// <summary>
        /// RIOBJF.
        /// </summary>
        public const string RIOBJF = "RIOBJF";

        /// <summary>
        /// RIFCO.
        /// </summary>
        public const string RIFCO = "RIFCO";

        /// <summary>
        /// RISBLT.
        /// </summary>
        public const string RISBLT = "RISBLT";

        /// <summary>
        /// RICCS.
        /// </summary>
        public const string RICCS = "RICCS";

        /// <summary>
        /// RIOBS.
        /// </summary>
        public const string RIOBS = "RIOBS";

        /// <summary>
        /// RISUBS.
        /// </summary>
        public const string RISUBS = "RISUBS";

        /// <summary>
        /// RISSBL.
        /// </summary>
        public const string RISSBL = "RISSBL";

        /// <summary>
        /// RISDTE.
        /// </summary>
        public const string RISDTE = "RISDTE";

        /// <summary>
        /// RIPID.
        /// </summary>
        public const string RIPID = "RIPID";

        /// <summary>
        /// RIUPMJ.
        /// </summary>
        public const string RIUPMJ = "RIUPMJ";

        /// <summary>
        /// RIJOBN.
        /// </summary>
        public const string RIJOBN = "RIJOBN";

        /// <summary>
        /// RIUPMT.
        /// </summary>
        public const string RIUPMT = "RIUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F0912A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RIHST", "RIHST", JdeDataType.String, 2),
        new JdeField("RIALOC", "RIALOC", JdeDataType.String, 2),
        new JdeField("RIRFAC", "RIRFAC", JdeDataType.Numeric),
        new JdeField("RISEN", "RISEN", JdeDataType.Numeric),
        new JdeField("RIFCC", "RIFCC", JdeDataType.String, 24),
        new JdeField("RIFROM", "RIFROM", JdeDataType.String, 30),
        new JdeField("RITHRU", "RITHRU", JdeDataType.String, 30),
        new JdeField("RIMY", "RIMY", JdeDataType.String, 2),
        new JdeField("RIUSER", "RIUSER", JdeDataType.String, 20),
        new JdeField("RIAID", "RIAID", JdeDataType.String, 16),
        new JdeField("RIANI", "RIANI", JdeDataType.String, 58),
        new JdeField("RICO", "RICO", JdeDataType.String, 10, true, true),
        new JdeField("RILT", "RILT", JdeDataType.String, 4),
        new JdeField("RISBL", "RISBL", JdeDataType.String, 16),
        new JdeField("RIAM", "RIAM", JdeDataType.String, 2),
        new JdeField("RIGLC", "RIGLC", JdeDataType.String, 8),
        new JdeField("RIR1", "RIR1", JdeDataType.String, 16),
        new JdeField("RIR2", "RIR2", JdeDataType.String, 16),
        new JdeField("RIDCT", "RIDCT", JdeDataType.String, 4, true, true),
        new JdeField("RIDOC", "RIDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("RISFX", "RISFX", JdeDataType.String, 6),
        new JdeField("RIASID", "RIASID", JdeDataType.String, 50),
        new JdeField("RIDGJ", "RIDGJ", JdeDataType.Numeric),
        new JdeField("RIDSVJ", "RIDSVJ", JdeDataType.Numeric),
        new JdeField("RIEXA", "RIEXA", JdeDataType.String, 60),
        new JdeField("RIEXR", "RIEXR", JdeDataType.String, 60),
        new JdeField("RIAA", "RIAA", JdeDataType.Numeric),
        new JdeField("RIU", "RIU", JdeDataType.Numeric),
        new JdeField("RIJELN", "RIJELN", JdeDataType.Numeric, null, true, true),
        new JdeField("RIRE", "RIRE", JdeDataType.String, 2),
        new JdeField("RIDOI", "RIDOI", JdeDataType.Numeric),
        new JdeField("RIBC", "RIBC", JdeDataType.String, 2),
        new JdeField("RIFY", "RIFY", JdeDataType.Numeric),
        new JdeField("RIPN", "RIPN", JdeDataType.Numeric),
        new JdeField("RICTRY", "RICTRY", JdeDataType.Numeric),
        new JdeField("RIRF", "RIRF", JdeDataType.String, 4),
        new JdeField("RIFLT", "RIFLT", JdeDataType.String, 4),
        new JdeField("RIFPN", "RIFPN", JdeDataType.Numeric),
        new JdeField("RIFFY", "RIFFY", JdeDataType.Numeric),
        new JdeField("RIFCTY", "RIFCTY", JdeDataType.Numeric),
        new JdeField("RIFSBL", "RIFSBL", JdeDataType.String, 16),
        new JdeField("RISLK", "RISLK", JdeDataType.String, 2),
        new JdeField("RIMCU", "RIMCU", JdeDataType.String, 24),
        new JdeField("RIOBJ", "RIOBJ", JdeDataType.String, 12),
        new JdeField("RISUB", "RISUB", JdeDataType.String, 16),
        new JdeField("RIFSUB", "RIFSUB", JdeDataType.String, 16),
        new JdeField("RISUBT", "RISUBT", JdeDataType.String, 16),
        new JdeField("RIBCF", "RIBCF", JdeDataType.String, 2),
        new JdeField("RIBCTO", "RIBCTO", JdeDataType.String, 2),
        new JdeField("RIOBJT", "RIOBJT", JdeDataType.String, 12),
        new JdeField("RIOBJF", "RIOBJF", JdeDataType.String, 12),
        new JdeField("RIFCO", "RIFCO", JdeDataType.String, 10),
        new JdeField("RISBLT", "RISBLT", JdeDataType.String, 2),
        new JdeField("RICCS", "RICCS", JdeDataType.String, 2),
        new JdeField("RIOBS", "RIOBS", JdeDataType.String, 2),
        new JdeField("RISUBS", "RISUBS", JdeDataType.String, 2),
        new JdeField("RISSBL", "RISSBL", JdeDataType.String, 2),
        new JdeField("RISDTE", "RISDTE", JdeDataType.Numeric),
        new JdeField("RIPID", "RIPID", JdeDataType.String, 20),
        new JdeField("RIUPMJ", "RIUPMJ", JdeDataType.Numeric),
        new JdeField("RIJOBN", "RIJOBN", JdeDataType.String, 20),
        new JdeField("RIUPMT", "RIUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0912A_0", "Primary Key on RIDCT, RIDOC, RICO, RIJELN", new[] { "RIDCT", "RIDOC", "RICO", "RIJELN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0912A_2", "Index on RIDCT, RIDOC", new[] { "RIDCT", "RIDOC" }),
        new JdeIndex("F0912A_3", "Index on RIDCT, RIDOC, RICO", new[] { "RIDCT", "RIDOC", "RICO" })
    };
}
