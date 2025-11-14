using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1501BZ1 - .
/// </summary>
public class F1501BZ1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LMEDUS.
        /// </summary>
        public const string LMEDUS = "LMEDUS";

        /// <summary>
        /// LMEDBT.
        /// </summary>
        public const string LMEDBT = "LMEDBT";

        /// <summary>
        /// LMEDTN.
        /// </summary>
        public const string LMEDTN = "LMEDTN";

        /// <summary>
        /// LMEDLN.
        /// </summary>
        public const string LMEDLN = "LMEDLN";

        /// <summary>
        /// LMEDCT.
        /// </summary>
        public const string LMEDCT = "LMEDCT";

        /// <summary>
        /// LMTYTN.
        /// </summary>
        public const string LMTYTN = "LMTYTN";

        /// <summary>
        /// LMEDFT.
        /// </summary>
        public const string LMEDFT = "LMEDFT";

        /// <summary>
        /// LMEDDT.
        /// </summary>
        public const string LMEDDT = "LMEDDT";

        /// <summary>
        /// LMDRIN.
        /// </summary>
        public const string LMDRIN = "LMDRIN";

        /// <summary>
        /// LMEDDL.
        /// </summary>
        public const string LMEDDL = "LMEDDL";

        /// <summary>
        /// LMEDSP.
        /// </summary>
        public const string LMEDSP = "LMEDSP";

        /// <summary>
        /// LMPNID.
        /// </summary>
        public const string LMPNID = "LMPNID";

        /// <summary>
        /// LMTNAC.
        /// </summary>
        public const string LMTNAC = "LMTNAC";

        /// <summary>
        /// LMUSER.
        /// </summary>
        public const string LMUSER = "LMUSER";

        /// <summary>
        /// LMPID.
        /// </summary>
        public const string LMPID = "LMPID";

        /// <summary>
        /// LMJOBN.
        /// </summary>
        public const string LMJOBN = "LMJOBN";

        /// <summary>
        /// LMUPMJ.
        /// </summary>
        public const string LMUPMJ = "LMUPMJ";

        /// <summary>
        /// LMTDAY.
        /// </summary>
        public const string LMTDAY = "LMTDAY";

        /// <summary>
        /// LMDOCO.
        /// </summary>
        public const string LMDOCO = "LMDOCO";

        /// <summary>
        /// LMLSVR.
        /// </summary>
        public const string LMLSVR = "LMLSVR";

        /// <summary>
        /// LMVREF.
        /// </summary>
        public const string LMVREF = "LMVREF";

        /// <summary>
        /// LMVRED.
        /// </summary>
        public const string LMVRED = "LMVRED";

        /// <summary>
        /// LMVRS.
        /// </summary>
        public const string LMVRS = "LMVRS";

        /// <summary>
        /// LMDCTO.
        /// </summary>
        public const string LMDCTO = "LMDCTO";

        /// <summary>
        /// LMDL01.
        /// </summary>
        public const string LMDL01 = "LMDL01";

        /// <summary>
        /// LMAN8.
        /// </summary>
        public const string LMAN8 = "LMAN8";

        /// <summary>
        /// LMAN8J.
        /// </summary>
        public const string LMAN8J = "LMAN8J";

        /// <summary>
        /// LMANSA.
        /// </summary>
        public const string LMANSA = "LMANSA";

        /// <summary>
        /// LMAN8B.
        /// </summary>
        public const string LMAN8B = "LMAN8B";

        /// <summary>
        /// LMAN8P.
        /// </summary>
        public const string LMAN8P = "LMAN8P";

        /// <summary>
        /// LMLSST.
        /// </summary>
        public const string LMLSST = "LMLSST";

        /// <summary>
        /// LMPMTC.
        /// </summary>
        public const string LMPMTC = "LMPMTC";

        /// <summary>
        /// LMLSCD.
        /// </summary>
        public const string LMLSCD = "LMLSCD";

        /// <summary>
        /// LMLSET.
        /// </summary>
        public const string LMLSET = "LMLSET";

        /// <summary>
        /// LMOWLS.
        /// </summary>
        public const string LMOWLS = "LMOWLS";

        /// <summary>
        /// LMMGTF.
        /// </summary>
        public const string LMMGTF = "LMMGTF";

        /// <summary>
        /// LMTRAR.
        /// </summary>
        public const string LMTRAR = "LMTRAR";

        /// <summary>
        /// LMINVP.
        /// </summary>
        public const string LMINVP = "LMINVP";

        /// <summary>
        /// LMSTMP.
        /// </summary>
        public const string LMSTMP = "LMSTMP";

        /// <summary>
        /// LMSECN.
        /// </summary>
        public const string LMSECN = "LMSECN";

        /// <summary>
        /// LMDSPN.
        /// </summary>
        public const string LMDSPN = "LMDSPN";

        /// <summary>
        /// LMSIC.
        /// </summary>
        public const string LMSIC = "LMSIC";

        /// <summary>
        /// LMEFTB.
        /// </summary>
        public const string LMEFTB = "LMEFTB";

        /// <summary>
        /// LMSTMB.
        /// </summary>
        public const string LMSTMB = "LMSTMB";

        /// <summary>
        /// LMEFTE.
        /// </summary>
        public const string LMEFTE = "LMEFTE";

        /// <summary>
        /// LMDSR.
        /// </summary>
        public const string LMDSR = "LMDSR";

        /// <summary>
        /// LMMP01.
        /// </summary>
        public const string LMMP01 = "LMMP01";

        /// <summary>
        /// LMMP02.
        /// </summary>
        public const string LMMP02 = "LMMP02";

        /// <summary>
        /// LMOLED.
        /// </summary>
        public const string LMOLED = "LMOLED";

        /// <summary>
        /// LMCOMG.
        /// </summary>
        public const string LMCOMG = "LMCOMG";

        /// <summary>
        /// LMRYRB.
        /// </summary>
        public const string LMRYRB = "LMRYRB";

        /// <summary>
        /// LMLYRB.
        /// </summary>
        public const string LMLYRB = "LMLYRB";

        /// <summary>
        /// LMWTDL.
        /// </summary>
        public const string LMWTDL = "LMWTDL";

        /// <summary>
        /// LMPLNM.
        /// </summary>
        public const string LMPLNM = "LMPLNM";

        /// <summary>
        /// LMSBLI.
        /// </summary>
        public const string LMSBLI = "LMSBLI";

        /// <summary>
        /// LMCO.
        /// </summary>
        public const string LMCO = "LMCO";

        /// <summary>
        /// LMCTRY.
        /// </summary>
        public const string LMCTRY = "LMCTRY";

        /// <summary>
        /// LMALP.
        /// </summary>
        public const string LMALP = "LMALP";

        /// <summary>
        /// LMTOTD.
        /// </summary>
        public const string LMTOTD = "LMTOTD";

        /// <summary>
        /// LMAVD.
        /// </summary>
        public const string LMAVD = "LMAVD";

        /// <summary>
        /// LMDLI.
        /// </summary>
        public const string LMDLI = "LMDLI";

        /// <summary>
        /// LMDLP.
        /// </summary>
        public const string LMDLP = "LMDLP";

        /// <summary>
        /// LMURCD.
        /// </summary>
        public const string LMURCD = "LMURCD";

        /// <summary>
        /// LMURDT.
        /// </summary>
        public const string LMURDT = "LMURDT";

        /// <summary>
        /// LMURAT.
        /// </summary>
        public const string LMURAT = "LMURAT";

        /// <summary>
        /// LMURAB.
        /// </summary>
        public const string LMURAB = "LMURAB";

        /// <summary>
        /// LMOLSE.
        /// </summary>
        public const string LMOLSE = "LMOLSE";

        /// <summary>
        /// LMURRF.
        /// </summary>
        public const string LMURRF = "LMURRF";

        /// <summary>
        /// LMENTJ.
        /// </summary>
        public const string LMENTJ = "LMENTJ";

        /// <summary>
        /// LMTORG.
        /// </summary>
        public const string LMTORG = "LMTORG";

        /// <summary>
        /// LMCRR.
        /// </summary>
        public const string LMCRR = "LMCRR";

        /// <summary>
        /// LMDCRF.
        /// </summary>
        public const string LMDCRF = "LMDCRF";

        /// <summary>
        /// LMCRCD.
        /// </summary>
        public const string LMCRCD = "LMCRCD";

        /// <summary>
        /// LMCRRM.
        /// </summary>
        public const string LMCRRM = "LMCRRM";

        /// <summary>
        /// LMLELC.
        /// </summary>
        public const string LMLELC = "LMLELC";

        /// <summary>
        /// LMLERCEO.
        /// </summary>
        public const string LMLERCEO = "LMLERCEO";

        /// <summary>
        /// LMLEBR.
        /// </summary>
        public const string LMLEBR = "LMLEBR";

        /// <summary>
        /// LMLEHC01.
        /// </summary>
        public const string LMLEHC01 = "LMLEHC01";

        /// <summary>
        /// LMLEHC02.
        /// </summary>
        public const string LMLEHC02 = "LMLEHC02";

        /// <summary>
        /// LMLEHC03.
        /// </summary>
        public const string LMLEHC03 = "LMLEHC03";

        /// <summary>
        /// LMLEHC04.
        /// </summary>
        public const string LMLEHC04 = "LMLEHC04";

        /// <summary>
        /// LMLEHC05.
        /// </summary>
        public const string LMLEHC05 = "LMLEHC05";

        /// <summary>
        /// LMLEETF.
        /// </summary>
        public const string LMLEETF = "LMLEETF";
    }

    /// <inheritdoc />
    public override string TableName => "F1501BZ1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LMEDUS", "LMEDUS", JdeDataType.String, 20, true, true),
        new JdeField("LMEDBT", "LMEDBT", JdeDataType.String, 30, true, true),
        new JdeField("LMEDTN", "LMEDTN", JdeDataType.String, 44, true, true),
        new JdeField("LMEDLN", "LMEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("LMEDCT", "LMEDCT", JdeDataType.String, 4),
        new JdeField("LMTYTN", "LMTYTN", JdeDataType.String, 16),
        new JdeField("LMEDFT", "LMEDFT", JdeDataType.String, 20),
        new JdeField("LMEDDT", "LMEDDT", JdeDataType.Numeric),
        new JdeField("LMDRIN", "LMDRIN", JdeDataType.String, 2),
        new JdeField("LMEDDL", "LMEDDL", JdeDataType.Numeric),
        new JdeField("LMEDSP", "LMEDSP", JdeDataType.String, 2),
        new JdeField("LMPNID", "LMPNID", JdeDataType.String, 30),
        new JdeField("LMTNAC", "LMTNAC", JdeDataType.String, 4),
        new JdeField("LMUSER", "LMUSER", JdeDataType.String, 20),
        new JdeField("LMPID", "LMPID", JdeDataType.String, 20),
        new JdeField("LMJOBN", "LMJOBN", JdeDataType.String, 20),
        new JdeField("LMUPMJ", "LMUPMJ", JdeDataType.Numeric),
        new JdeField("LMTDAY", "LMTDAY", JdeDataType.Numeric),
        new JdeField("LMDOCO", "LMDOCO", JdeDataType.Numeric),
        new JdeField("LMLSVR", "LMLSVR", JdeDataType.Numeric),
        new JdeField("LMVREF", "LMVREF", JdeDataType.Numeric),
        new JdeField("LMVRED", "LMVRED", JdeDataType.Numeric),
        new JdeField("LMVRS", "LMVRS", JdeDataType.Numeric),
        new JdeField("LMDCTO", "LMDCTO", JdeDataType.String, 4),
        new JdeField("LMDL01", "LMDL01", JdeDataType.String, 60),
        new JdeField("LMAN8", "LMAN8", JdeDataType.Numeric),
        new JdeField("LMAN8J", "LMAN8J", JdeDataType.Numeric),
        new JdeField("LMANSA", "LMANSA", JdeDataType.Numeric),
        new JdeField("LMAN8B", "LMAN8B", JdeDataType.Numeric),
        new JdeField("LMAN8P", "LMAN8P", JdeDataType.Numeric),
        new JdeField("LMLSST", "LMLSST", JdeDataType.String, 2),
        new JdeField("LMPMTC", "LMPMTC", JdeDataType.Numeric),
        new JdeField("LMLSCD", "LMLSCD", JdeDataType.String, 2),
        new JdeField("LMLSET", "LMLSET", JdeDataType.String, 4),
        new JdeField("LMOWLS", "LMOWLS", JdeDataType.String, 2),
        new JdeField("LMMGTF", "LMMGTF", JdeDataType.String, 2),
        new JdeField("LMTRAR", "LMTRAR", JdeDataType.String, 6),
        new JdeField("LMINVP", "LMINVP", JdeDataType.String, 2),
        new JdeField("LMSTMP", "LMSTMP", JdeDataType.String, 2),
        new JdeField("LMSECN", "LMSECN", JdeDataType.String, 2),
        new JdeField("LMDSPN", "LMDSPN", JdeDataType.String, 2),
        new JdeField("LMSIC", "LMSIC", JdeDataType.String, 20),
        new JdeField("LMEFTB", "LMEFTB", JdeDataType.Numeric),
        new JdeField("LMSTMB", "LMSTMB", JdeDataType.String, 2),
        new JdeField("LMEFTE", "LMEFTE", JdeDataType.Numeric),
        new JdeField("LMDSR", "LMDSR", JdeDataType.Numeric),
        new JdeField("LMMP01", "LMMP01", JdeDataType.Numeric),
        new JdeField("LMMP02", "LMMP02", JdeDataType.Numeric),
        new JdeField("LMOLED", "LMOLED", JdeDataType.Numeric),
        new JdeField("LMCOMG", "LMCOMG", JdeDataType.String, 20),
        new JdeField("LMRYRB", "LMRYRB", JdeDataType.Numeric),
        new JdeField("LMLYRB", "LMLYRB", JdeDataType.Numeric),
        new JdeField("LMWTDL", "LMWTDL", JdeDataType.Numeric),
        new JdeField("LMPLNM", "LMPLNM", JdeDataType.Numeric),
        new JdeField("LMSBLI", "LMSBLI", JdeDataType.String, 2),
        new JdeField("LMCO", "LMCO", JdeDataType.String, 10),
        new JdeField("LMCTRY", "LMCTRY", JdeDataType.Numeric),
        new JdeField("LMALP", "LMALP", JdeDataType.Numeric),
        new JdeField("LMTOTD", "LMTOTD", JdeDataType.Numeric),
        new JdeField("LMAVD", "LMAVD", JdeDataType.Numeric),
        new JdeField("LMDLI", "LMDLI", JdeDataType.Numeric),
        new JdeField("LMDLP", "LMDLP", JdeDataType.Numeric),
        new JdeField("LMURCD", "LMURCD", JdeDataType.String, 4),
        new JdeField("LMURDT", "LMURDT", JdeDataType.Numeric),
        new JdeField("LMURAT", "LMURAT", JdeDataType.Numeric),
        new JdeField("LMURAB", "LMURAB", JdeDataType.Numeric),
        new JdeField("LMOLSE", "LMOLSE", JdeDataType.String, 50),
        new JdeField("LMURRF", "LMURRF", JdeDataType.String, 30),
        new JdeField("LMENTJ", "LMENTJ", JdeDataType.Numeric),
        new JdeField("LMTORG", "LMTORG", JdeDataType.String, 20),
        new JdeField("LMCRR", "LMCRR", JdeDataType.Numeric),
        new JdeField("LMDCRF", "LMDCRF", JdeDataType.String, 2),
        new JdeField("LMCRCD", "LMCRCD", JdeDataType.String, 6),
        new JdeField("LMCRRM", "LMCRRM", JdeDataType.String, 2),
        new JdeField("LMLELC", "LMLELC", JdeDataType.String, 2),
        new JdeField("LMLERCEO", "LMLERCEO", JdeDataType.String, 2),
        new JdeField("LMLEBR", "LMLEBR", JdeDataType.Numeric),
        new JdeField("LMLEHC01", "LMLEHC01", JdeDataType.String, 20),
        new JdeField("LMLEHC02", "LMLEHC02", JdeDataType.String, 20),
        new JdeField("LMLEHC03", "LMLEHC03", JdeDataType.String, 20),
        new JdeField("LMLEHC04", "LMLEHC04", JdeDataType.String, 20),
        new JdeField("LMLEHC05", "LMLEHC05", JdeDataType.String, 20),
        new JdeField("LMLEETF", "LMLEETF", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1501BZ1_0", "Primary Key on LMEDUS, LMEDBT, LMEDTN, LMEDLN", new[] { "LMEDUS", "LMEDBT", "LMEDTN", "LMEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
