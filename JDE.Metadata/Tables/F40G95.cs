using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40G95 - .
/// </summary>
public class F40G95 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PPUKID.
        /// </summary>
        public const string PPUKID = "PPUKID";

        /// <summary>
        /// PPPOPTYP.
        /// </summary>
        public const string PPPOPTYP = "PPPOPTYP";

        /// <summary>
        /// PPPOPHLD.
        /// </summary>
        public const string PPPOPHLD = "PPPOPHLD";

        /// <summary>
        /// PPITM.
        /// </summary>
        public const string PPITM = "PPITM";

        /// <summary>
        /// PPLITM.
        /// </summary>
        public const string PPLITM = "PPLITM";

        /// <summary>
        /// PPAITM.
        /// </summary>
        public const string PPAITM = "PPAITM";

        /// <summary>
        /// PPKCOO.
        /// </summary>
        public const string PPKCOO = "PPKCOO";

        /// <summary>
        /// PPDOCO.
        /// </summary>
        public const string PPDOCO = "PPDOCO";

        /// <summary>
        /// PPDCTO.
        /// </summary>
        public const string PPDCTO = "PPDCTO";

        /// <summary>
        /// PPLNID.
        /// </summary>
        public const string PPLNID = "PPLNID";

        /// <summary>
        /// PPSFXO.
        /// </summary>
        public const string PPSFXO = "PPSFXO";

        /// <summary>
        /// PPNLIN.
        /// </summary>
        public const string PPNLIN = "PPNLIN";

        /// <summary>
        /// PPAEXP.
        /// </summary>
        public const string PPAEXP = "PPAEXP";

        /// <summary>
        /// PPFEA.
        /// </summary>
        public const string PPFEA = "PPFEA";

        /// <summary>
        /// PPUORG.
        /// </summary>
        public const string PPUORG = "PPUORG";

        /// <summary>
        /// PPUOM.
        /// </summary>
        public const string PPUOM = "PPUOM";

        /// <summary>
        /// PPCRCD.
        /// </summary>
        public const string PPCRCD = "PPCRCD";

        /// <summary>
        /// PPUREC.
        /// </summary>
        public const string PPUREC = "PPUREC";

        /// <summary>
        /// PPADDJ.
        /// </summary>
        public const string PPADDJ = "PPADDJ";

        /// <summary>
        /// PPIVD.
        /// </summary>
        public const string PPIVD = "PPIVD";

        /// <summary>
        /// PPTRDJ.
        /// </summary>
        public const string PPTRDJ = "PPTRDJ";

        /// <summary>
        /// PPWTNUM.
        /// </summary>
        public const string PPWTNUM = "PPWTNUM";

        /// <summary>
        /// PPPRCPTF.
        /// </summary>
        public const string PPPRCPTF = "PPPRCPTF";

        /// <summary>
        /// PPCNTRTID.
        /// </summary>
        public const string PPCNTRTID = "PPCNTRTID";

        /// <summary>
        /// PPCNTRTDID.
        /// </summary>
        public const string PPCNTRTDID = "PPCNTRTDID";

        /// <summary>
        /// PPCNTRTCD.
        /// </summary>
        public const string PPCNTRTCD = "PPCNTRTCD";

        /// <summary>
        /// PPCNTRTENT.
        /// </summary>
        public const string PPCNTRTENT = "PPCNTRTENT";

        /// <summary>
        /// PPBLUID.
        /// </summary>
        public const string PPBLUID = "PPBLUID";

        /// <summary>
        /// PPBLSCD2.
        /// </summary>
        public const string PPBLSCD2 = "PPBLSCD2";

        /// <summary>
        /// PPHARPER.
        /// </summary>
        public const string PPHARPER = "PPHARPER";

        /// <summary>
        /// PPHARSFX.
        /// </summary>
        public const string PPHARSFX = "PPHARSFX";

        /// <summary>
        /// PPPOPPOOL.
        /// </summary>
        public const string PPPOPPOOL = "PPPOPPOOL";

        /// <summary>
        /// PPGEQTYP.
        /// </summary>
        public const string PPGEQTYP = "PPGEQTYP";

        /// <summary>
        /// PPGEQPCT.
        /// </summary>
        public const string PPGEQPCT = "PPGEQPCT";

        /// <summary>
        /// PPPOPASN.
        /// </summary>
        public const string PPPOPASN = "PPPOPASN";

        /// <summary>
        /// PPPOPPTC.
        /// </summary>
        public const string PPPOPPTC = "PPPOPPTC";

        /// <summary>
        /// PPPOPPAID.
        /// </summary>
        public const string PPPOPPAID = "PPPOPPAID";

        /// <summary>
        /// PPPOPVDT.
        /// </summary>
        public const string PPPOPVDT = "PPPOPVDT";

        /// <summary>
        /// PPDOC.
        /// </summary>
        public const string PPDOC = "PPDOC";

        /// <summary>
        /// PPDCT.
        /// </summary>
        public const string PPDCT = "PPDCT";

        /// <summary>
        /// PPKCO.
        /// </summary>
        public const string PPKCO = "PPKCO";

        /// <summary>
        /// PPSFX.
        /// </summary>
        public const string PPSFX = "PPSFX";

        /// <summary>
        /// PPSFXE.
        /// </summary>
        public const string PPSFXE = "PPSFXE";

        /// <summary>
        /// PPURAB.
        /// </summary>
        public const string PPURAB = "PPURAB";

        /// <summary>
        /// PPURAT.
        /// </summary>
        public const string PPURAT = "PPURAT";

        /// <summary>
        /// PPURCD.
        /// </summary>
        public const string PPURCD = "PPURCD";

        /// <summary>
        /// PPURDT.
        /// </summary>
        public const string PPURDT = "PPURDT";

        /// <summary>
        /// PPURRF.
        /// </summary>
        public const string PPURRF = "PPURRF";

        /// <summary>
        /// PPUSER.
        /// </summary>
        public const string PPUSER = "PPUSER";

        /// <summary>
        /// PPPID.
        /// </summary>
        public const string PPPID = "PPPID";

        /// <summary>
        /// PPJOBN.
        /// </summary>
        public const string PPJOBN = "PPJOBN";

        /// <summary>
        /// PPTORG.
        /// </summary>
        public const string PPTORG = "PPTORG";

        /// <summary>
        /// PPUUPMJ.
        /// </summary>
        public const string PPUUPMJ = "PPUUPMJ";

        /// <summary>
        /// PPMCU.
        /// </summary>
        public const string PPMCU = "PPMCU";
    }

    /// <inheritdoc />
    public override string TableName => "F40G95";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PPUKID", "PPUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("PPPOPTYP", "PPPOPTYP", JdeDataType.String, 2),
        new JdeField("PPPOPHLD", "PPPOPHLD", JdeDataType.String, 2),
        new JdeField("PPITM", "PPITM", JdeDataType.Numeric),
        new JdeField("PPLITM", "PPLITM", JdeDataType.String, 50),
        new JdeField("PPAITM", "PPAITM", JdeDataType.String, 50),
        new JdeField("PPKCOO", "PPKCOO", JdeDataType.String, 10),
        new JdeField("PPDOCO", "PPDOCO", JdeDataType.Numeric),
        new JdeField("PPDCTO", "PPDCTO", JdeDataType.String, 4),
        new JdeField("PPLNID", "PPLNID", JdeDataType.Numeric),
        new JdeField("PPSFXO", "PPSFXO", JdeDataType.String, 6),
        new JdeField("PPNLIN", "PPNLIN", JdeDataType.Numeric),
        new JdeField("PPAEXP", "PPAEXP", JdeDataType.Numeric),
        new JdeField("PPFEA", "PPFEA", JdeDataType.Numeric),
        new JdeField("PPUORG", "PPUORG", JdeDataType.Numeric),
        new JdeField("PPUOM", "PPUOM", JdeDataType.String, 4),
        new JdeField("PPCRCD", "PPCRCD", JdeDataType.String, 6),
        new JdeField("PPUREC", "PPUREC", JdeDataType.Numeric),
        new JdeField("PPADDJ", "PPADDJ", JdeDataType.Numeric),
        new JdeField("PPIVD", "PPIVD", JdeDataType.Numeric),
        new JdeField("PPTRDJ", "PPTRDJ", JdeDataType.Numeric),
        new JdeField("PPWTNUM", "PPWTNUM", JdeDataType.String, 60),
        new JdeField("PPPRCPTF", "PPPRCPTF", JdeDataType.String, 2),
        new JdeField("PPCNTRTID", "PPCNTRTID", JdeDataType.Numeric),
        new JdeField("PPCNTRTDID", "PPCNTRTDID", JdeDataType.Numeric),
        new JdeField("PPCNTRTCD", "PPCNTRTCD", JdeDataType.String, 24),
        new JdeField("PPCNTRTENT", "PPCNTRTENT", JdeDataType.Numeric),
        new JdeField("PPBLUID", "PPBLUID", JdeDataType.Numeric),
        new JdeField("PPBLSCD2", "PPBLSCD2", JdeDataType.String, 20),
        new JdeField("PPHARPER", "PPHARPER", JdeDataType.String, 12),
        new JdeField("PPHARSFX", "PPHARSFX", JdeDataType.String, 20),
        new JdeField("PPPOPPOOL", "PPPOPPOOL", JdeDataType.String, 16),
        new JdeField("PPGEQTYP", "PPGEQTYP", JdeDataType.String, 16),
        new JdeField("PPGEQPCT", "PPGEQPCT", JdeDataType.Numeric),
        new JdeField("PPPOPASN", "PPPOPASN", JdeDataType.String, 16),
        new JdeField("PPPOPPTC", "PPPOPPTC", JdeDataType.String, 6),
        new JdeField("PPPOPPAID", "PPPOPPAID", JdeDataType.String, 2),
        new JdeField("PPPOPVDT", "PPPOPVDT", JdeDataType.Date),
        new JdeField("PPDOC", "PPDOC", JdeDataType.Numeric),
        new JdeField("PPDCT", "PPDCT", JdeDataType.String, 4),
        new JdeField("PPKCO", "PPKCO", JdeDataType.String, 10),
        new JdeField("PPSFX", "PPSFX", JdeDataType.String, 6),
        new JdeField("PPSFXE", "PPSFXE", JdeDataType.Numeric),
        new JdeField("PPURAB", "PPURAB", JdeDataType.Numeric),
        new JdeField("PPURAT", "PPURAT", JdeDataType.Numeric),
        new JdeField("PPURCD", "PPURCD", JdeDataType.String, 4),
        new JdeField("PPURDT", "PPURDT", JdeDataType.Numeric),
        new JdeField("PPURRF", "PPURRF", JdeDataType.String, 30),
        new JdeField("PPUSER", "PPUSER", JdeDataType.String, 20),
        new JdeField("PPPID", "PPPID", JdeDataType.String, 20),
        new JdeField("PPJOBN", "PPJOBN", JdeDataType.String, 20),
        new JdeField("PPTORG", "PPTORG", JdeDataType.String, 20),
        new JdeField("PPUUPMJ", "PPUUPMJ", JdeDataType.Date),
        new JdeField("PPMCU", "PPMCU", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40G95_0", "Primary Key on PPUKID", new[] { "PPUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
