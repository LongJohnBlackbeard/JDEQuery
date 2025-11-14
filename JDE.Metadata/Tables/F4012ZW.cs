using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4012ZW - .
/// </summary>
public class F4012ZW : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SPEKCO.
        /// </summary>
        public const string SPEKCO = "SPEKCO";

        /// <summary>
        /// SPEDOC.
        /// </summary>
        public const string SPEDOC = "SPEDOC";

        /// <summary>
        /// SPEDCT.
        /// </summary>
        public const string SPEDCT = "SPEDCT";

        /// <summary>
        /// SPSHAN.
        /// </summary>
        public const string SPSHAN = "SPSHAN";

        /// <summary>
        /// SPLITM.
        /// </summary>
        public const string SPLITM = "SPLITM";

        /// <summary>
        /// SPOKCO.
        /// </summary>
        public const string SPOKCO = "SPOKCO";

        /// <summary>
        /// SPOORN.
        /// </summary>
        public const string SPOORN = "SPOORN";

        /// <summary>
        /// SPOCTO.
        /// </summary>
        public const string SPOCTO = "SPOCTO";

        /// <summary>
        /// SPOGNO.
        /// </summary>
        public const string SPOGNO = "SPOGNO";

        /// <summary>
        /// SPNXTR.
        /// </summary>
        public const string SPNXTR = "SPNXTR";

        /// <summary>
        /// SPLTTR.
        /// </summary>
        public const string SPLTTR = "SPLTTR";

        /// <summary>
        /// SPLNID.
        /// </summary>
        public const string SPLNID = "SPLNID";

        /// <summary>
        /// SPLNTY.
        /// </summary>
        public const string SPLNTY = "SPLNTY";

        /// <summary>
        /// SPITM.
        /// </summary>
        public const string SPITM = "SPITM";

        /// <summary>
        /// SPDSC1.
        /// </summary>
        public const string SPDSC1 = "SPDSC1";

        /// <summary>
        /// SPDSC2.
        /// </summary>
        public const string SPDSC2 = "SPDSC2";

        /// <summary>
        /// SPTRDJ.
        /// </summary>
        public const string SPTRDJ = "SPTRDJ";

        /// <summary>
        /// SPDRQJ.
        /// </summary>
        public const string SPDRQJ = "SPDRQJ";

        /// <summary>
        /// SPPDDJ.
        /// </summary>
        public const string SPPDDJ = "SPPDDJ";

        /// <summary>
        /// SPAITM.
        /// </summary>
        public const string SPAITM = "SPAITM";

        /// <summary>
        /// SPMCU.
        /// </summary>
        public const string SPMCU = "SPMCU";

        /// <summary>
        /// SPAISL.
        /// </summary>
        public const string SPAISL = "SPAISL";

        /// <summary>
        /// SPBIN.
        /// </summary>
        public const string SPBIN = "SPBIN";

        /// <summary>
        /// SPLOCN.
        /// </summary>
        public const string SPLOCN = "SPLOCN";

        /// <summary>
        /// SPLOTN.
        /// </summary>
        public const string SPLOTN = "SPLOTN";

        /// <summary>
        /// SPANBY.
        /// </summary>
        public const string SPANBY = "SPANBY";

        /// <summary>
        /// SPCARS.
        /// </summary>
        public const string SPCARS = "SPCARS";

        /// <summary>
        /// SPUOM.
        /// </summary>
        public const string SPUOM = "SPUOM";

        /// <summary>
        /// SPUORG.
        /// </summary>
        public const string SPUORG = "SPUORG";

        /// <summary>
        /// SPUPRC.
        /// </summary>
        public const string SPUPRC = "SPUPRC";

        /// <summary>
        /// SPAEXP.
        /// </summary>
        public const string SPAEXP = "SPAEXP";

        /// <summary>
        /// SPUNCS.
        /// </summary>
        public const string SPUNCS = "SPUNCS";

        /// <summary>
        /// SPECST.
        /// </summary>
        public const string SPECST = "SPECST";

        /// <summary>
        /// SPUOM4.
        /// </summary>
        public const string SPUOM4 = "SPUOM4";

        /// <summary>
        /// SPITWT.
        /// </summary>
        public const string SPITWT = "SPITWT";

        /// <summary>
        /// SPWTUM.
        /// </summary>
        public const string SPWTUM = "SPWTUM";

        /// <summary>
        /// SPITVL.
        /// </summary>
        public const string SPITVL = "SPITVL";

        /// <summary>
        /// SPVLUM.
        /// </summary>
        public const string SPVLUM = "SPVLUM";

        /// <summary>
        /// SPEXR1.
        /// </summary>
        public const string SPEXR1 = "SPEXR1";

        /// <summary>
        /// SPTXA1.
        /// </summary>
        public const string SPTXA1 = "SPTXA1";

        /// <summary>
        /// SPSOQS.
        /// </summary>
        public const string SPSOQS = "SPSOQS";

        /// <summary>
        /// SPPRGR.
        /// </summary>
        public const string SPPRGR = "SPPRGR";

        /// <summary>
        /// SPCLVL.
        /// </summary>
        public const string SPCLVL = "SPCLVL";
    }

    /// <inheritdoc />
    public override string TableName => "F4012ZW";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SPEKCO", "SPEKCO", JdeDataType.String, 10, true, true),
        new JdeField("SPEDOC", "SPEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("SPEDCT", "SPEDCT", JdeDataType.String, 4, true, true),
        new JdeField("SPSHAN", "SPSHAN", JdeDataType.Numeric, null, true, true),
        new JdeField("SPLITM", "SPLITM", JdeDataType.String, 50, true, true),
        new JdeField("SPOKCO", "SPOKCO", JdeDataType.String, 10),
        new JdeField("SPOORN", "SPOORN", JdeDataType.String, 16),
        new JdeField("SPOCTO", "SPOCTO", JdeDataType.String, 4),
        new JdeField("SPOGNO", "SPOGNO", JdeDataType.Numeric),
        new JdeField("SPNXTR", "SPNXTR", JdeDataType.String, 6),
        new JdeField("SPLTTR", "SPLTTR", JdeDataType.String, 6),
        new JdeField("SPLNID", "SPLNID", JdeDataType.Numeric),
        new JdeField("SPLNTY", "SPLNTY", JdeDataType.String, 4),
        new JdeField("SPITM", "SPITM", JdeDataType.Numeric),
        new JdeField("SPDSC1", "SPDSC1", JdeDataType.String, 60),
        new JdeField("SPDSC2", "SPDSC2", JdeDataType.String, 60),
        new JdeField("SPTRDJ", "SPTRDJ", JdeDataType.Numeric),
        new JdeField("SPDRQJ", "SPDRQJ", JdeDataType.Numeric),
        new JdeField("SPPDDJ", "SPPDDJ", JdeDataType.Numeric),
        new JdeField("SPAITM", "SPAITM", JdeDataType.String, 50),
        new JdeField("SPMCU", "SPMCU", JdeDataType.String, 24),
        new JdeField("SPAISL", "SPAISL", JdeDataType.String, 16),
        new JdeField("SPBIN", "SPBIN", JdeDataType.String, 16),
        new JdeField("SPLOCN", "SPLOCN", JdeDataType.String, 40),
        new JdeField("SPLOTN", "SPLOTN", JdeDataType.String, 60),
        new JdeField("SPANBY", "SPANBY", JdeDataType.Numeric),
        new JdeField("SPCARS", "SPCARS", JdeDataType.Numeric),
        new JdeField("SPUOM", "SPUOM", JdeDataType.String, 4),
        new JdeField("SPUORG", "SPUORG", JdeDataType.Numeric),
        new JdeField("SPUPRC", "SPUPRC", JdeDataType.Numeric),
        new JdeField("SPAEXP", "SPAEXP", JdeDataType.Numeric),
        new JdeField("SPUNCS", "SPUNCS", JdeDataType.Numeric),
        new JdeField("SPECST", "SPECST", JdeDataType.Numeric),
        new JdeField("SPUOM4", "SPUOM4", JdeDataType.String, 4),
        new JdeField("SPITWT", "SPITWT", JdeDataType.Numeric),
        new JdeField("SPWTUM", "SPWTUM", JdeDataType.String, 4),
        new JdeField("SPITVL", "SPITVL", JdeDataType.Numeric),
        new JdeField("SPVLUM", "SPVLUM", JdeDataType.String, 4),
        new JdeField("SPEXR1", "SPEXR1", JdeDataType.String, 4),
        new JdeField("SPTXA1", "SPTXA1", JdeDataType.String, 20),
        new JdeField("SPSOQS", "SPSOQS", JdeDataType.Numeric),
        new JdeField("SPPRGR", "SPPRGR", JdeDataType.String, 16),
        new JdeField("SPCLVL", "SPCLVL", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4012ZW_0", "Primary Key on SPEDOC, SPEDCT, SPEKCO, SPSHAN, SPLITM", new[] { "SPEDOC", "SPEDCT", "SPEKCO", "SPSHAN", "SPLITM" }, isUnique: true, isPrimaryKey: true)
    };
}
