using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B12TE - .
/// </summary>
public class F76B12TE : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SLBNNF.
        /// </summary>
        public const string SLBNNF = "SLBNNF";

        /// <summary>
        /// SLBSER.
        /// </summary>
        public const string SLBSER = "SLBSER";

        /// <summary>
        /// SLDCT.
        /// </summary>
        public const string SLDCT = "SLDCT";

        /// <summary>
        /// SLN001.
        /// </summary>
        public const string SLN001 = "SLN001";

        /// <summary>
        /// SLRC5.
        /// </summary>
        public const string SLRC5 = "SLRC5";

        /// <summary>
        /// SLB76EMTY.
        /// </summary>
        public const string SLB76EMTY = "SLB76EMTY";

        /// <summary>
        /// SLB76NFST.
        /// </summary>
        public const string SLB76NFST = "SLB76NFST";

        /// <summary>
        /// SLB76SACT.
        /// </summary>
        public const string SLB76SACT = "SLB76SACT";

        /// <summary>
        /// SLB76PRON.
        /// </summary>
        public const string SLB76PRON = "SLB76PRON";

        /// <summary>
        /// SLB76TNF.
        /// </summary>
        public const string SLB76TNF = "SLB76TNF";

        /// <summary>
        /// SLB76LSER.
        /// </summary>
        public const string SLB76LSER = "SLB76LSER";

        /// <summary>
        /// SLB76LNUM.
        /// </summary>
        public const string SLB76LNUM = "SLB76LNUM";

        /// <summary>
        /// SLFCO.
        /// </summary>
        public const string SLFCO = "SLFCO";

        /// <summary>
        /// SLB76AKEY.
        /// </summary>
        public const string SLB76AKEY = "SLB76AKEY";

        /// <summary>
        /// SLB76EPRD.
        /// </summary>
        public const string SLB76EPRD = "SLB76EPRD";

        /// <summary>
        /// SLB76EPRT.
        /// </summary>
        public const string SLB76EPRT = "SLB76EPRT";

        /// <summary>
        /// SLB76CAND.
        /// </summary>
        public const string SLB76CAND = "SLB76CAND";

        /// <summary>
        /// SLB76CANT.
        /// </summary>
        public const string SLB76CANT = "SLB76CANT";

        /// <summary>
        /// SLB76CONR.
        /// </summary>
        public const string SLB76CONR = "SLB76CONR";

        /// <summary>
        /// SLB76RSPC.
        /// </summary>
        public const string SLB76RSPC = "SLB76RSPC";

        /// <summary>
        /// SLB76ERN.
        /// </summary>
        public const string SLB76ERN = "SLB76ERN";

        /// <summary>
        /// SLB76DPEN.
        /// </summary>
        public const string SLB76DPEN = "SLB76DPEN";

        /// <summary>
        /// SLB76DPED.
        /// </summary>
        public const string SLB76DPED = "SLB76DPED";

        /// <summary>
        /// SLB76DPET.
        /// </summary>
        public const string SLB76DPET = "SLB76DPET";

        /// <summary>
        /// SLB76FSCN.
        /// </summary>
        public const string SLB76FSCN = "SLB76FSCN";

        /// <summary>
        /// SLB76FSCS.
        /// </summary>
        public const string SLB76FSCS = "SLB76FSCS";

        /// <summary>
        /// SL76BXFNM.
        /// </summary>
        public const string SL76BXFNM = "SL76BXFNM";

        /// <summary>
        /// SL76BDFNM.
        /// </summary>
        public const string SL76BDFNM = "SL76BDFNM";

        /// <summary>
        /// SL76BESTAT.
        /// </summary>
        public const string SL76BESTAT = "SL76BESTAT";

        /// <summary>
        /// SL76BESDT.
        /// </summary>
        public const string SL76BESDT = "SL76BESDT";

        /// <summary>
        /// SLUSER.
        /// </summary>
        public const string SLUSER = "SLUSER";

        /// <summary>
        /// SLPID.
        /// </summary>
        public const string SLPID = "SLPID";

        /// <summary>
        /// SLJOBN.
        /// </summary>
        public const string SLJOBN = "SLJOBN";

        /// <summary>
        /// SLUPMJ.
        /// </summary>
        public const string SLUPMJ = "SLUPMJ";

        /// <summary>
        /// SLUPMT.
        /// </summary>
        public const string SLUPMT = "SLUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B12TE";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SLBNNF", "SLBNNF", JdeDataType.Numeric, null, true, true),
        new JdeField("SLBSER", "SLBSER", JdeDataType.String, 4, true, true),
        new JdeField("SLDCT", "SLDCT", JdeDataType.String, 4, true, true),
        new JdeField("SLN001", "SLN001", JdeDataType.Numeric, null, true, true),
        new JdeField("SLRC5", "SLRC5", JdeDataType.Numeric, null, true, true),
        new JdeField("SLB76EMTY", "SLB76EMTY", JdeDataType.String, 2),
        new JdeField("SLB76NFST", "SLB76NFST", JdeDataType.String, 2),
        new JdeField("SLB76SACT", "SLB76SACT", JdeDataType.String, 2),
        new JdeField("SLB76PRON", "SLB76PRON", JdeDataType.Numeric),
        new JdeField("SLB76TNF", "SLB76TNF", JdeDataType.String, 20),
        new JdeField("SLB76LSER", "SLB76LSER", JdeDataType.String, 20),
        new JdeField("SLB76LNUM", "SLB76LNUM", JdeDataType.Numeric),
        new JdeField("SLFCO", "SLFCO", JdeDataType.String, 10),
        new JdeField("SLB76AKEY", "SLB76AKEY", JdeDataType.String, 88),
        new JdeField("SLB76EPRD", "SLB76EPRD", JdeDataType.Numeric),
        new JdeField("SLB76EPRT", "SLB76EPRT", JdeDataType.Numeric),
        new JdeField("SLB76CAND", "SLB76CAND", JdeDataType.Numeric),
        new JdeField("SLB76CANT", "SLB76CANT", JdeDataType.Numeric),
        new JdeField("SLB76CONR", "SLB76CONR", JdeDataType.String, 20),
        new JdeField("SLB76RSPC", "SLB76RSPC", JdeDataType.Numeric),
        new JdeField("SLB76ERN", "SLB76ERN", JdeDataType.String, 60),
        new JdeField("SLB76DPEN", "SLB76DPEN", JdeDataType.Numeric),
        new JdeField("SLB76DPED", "SLB76DPED", JdeDataType.Numeric),
        new JdeField("SLB76DPET", "SLB76DPET", JdeDataType.Numeric),
        new JdeField("SLB76FSCN", "SLB76FSCN", JdeDataType.Numeric),
        new JdeField("SLB76FSCS", "SLB76FSCS", JdeDataType.String, 4),
        new JdeField("SL76BXFNM", "SL76BXFNM", JdeDataType.String, 510),
        new JdeField("SL76BDFNM", "SL76BDFNM", JdeDataType.String, 510),
        new JdeField("SL76BESTAT", "SL76BESTAT", JdeDataType.String, 2),
        new JdeField("SL76BESDT", "SL76BESDT", JdeDataType.Numeric),
        new JdeField("SLUSER", "SLUSER", JdeDataType.String, 20),
        new JdeField("SLPID", "SLPID", JdeDataType.String, 20),
        new JdeField("SLJOBN", "SLJOBN", JdeDataType.String, 20),
        new JdeField("SLUPMJ", "SLUPMJ", JdeDataType.Numeric),
        new JdeField("SLUPMT", "SLUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B12TE_0", "Primary Key on SLBNNF, SLBSER, SLDCT, SLN001, SLRC5", new[] { "SLBNNF", "SLBSER", "SLDCT", "SLN001", "SLRC5" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B12TE_2", "Index on SLB76AKEY, SLB76SACT, SLBNNF, SLBSER, SLDCT, SLN001", new[] { "SLB76AKEY", "SLB76SACT", "SLBNNF", "SLBSER", "SLDCT", "SLN001" }),
        new JdeIndex("F76B12TE_3", "Index on SLBNNF, SLBSER, SLDCT, SLN001, SLB76SACT", new[] { "SLBNNF", "SLBSER", "SLDCT", "SLN001", "SLB76SACT" })
    };
}
