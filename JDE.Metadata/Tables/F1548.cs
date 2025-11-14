using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1548 - .
/// </summary>
public class F1548 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// N1AN8.
        /// </summary>
        public const string N1AN8 = "N1AN8";

        /// <summary>
        /// N1ALPH.
        /// </summary>
        public const string N1ALPH = "N1ALPH";

        /// <summary>
        /// N1AN8J.
        /// </summary>
        public const string N1AN8J = "N1AN8J";

        /// <summary>
        /// N1DOCO.
        /// </summary>
        public const string N1DOCO = "N1DOCO";

        /// <summary>
        /// N1ICU.
        /// </summary>
        public const string N1ICU = "N1ICU";

        /// <summary>
        /// N1INDX.
        /// </summary>
        public const string N1INDX = "N1INDX";

        /// <summary>
        /// N1ESCM.
        /// </summary>
        public const string N1ESCM = "N1ESCM";

        /// <summary>
        /// N1MCU.
        /// </summary>
        public const string N1MCU = "N1MCU";

        /// <summary>
        /// N1UNIT.
        /// </summary>
        public const string N1UNIT = "N1UNIT";

        /// <summary>
        /// N1BESA.
        /// </summary>
        public const string N1BESA = "N1BESA";

        /// <summary>
        /// N1LESA.
        /// </summary>
        public const string N1LESA = "N1LESA";

        /// <summary>
        /// N1BINX.
        /// </summary>
        public const string N1BINX = "N1BINX";

        /// <summary>
        /// N1LINX.
        /// </summary>
        public const string N1LINX = "N1LINX";

        /// <summary>
        /// N1ORLS.
        /// </summary>
        public const string N1ORLS = "N1ORLS";

        /// <summary>
        /// N1CINX.
        /// </summary>
        public const string N1CINX = "N1CINX";

        /// <summary>
        /// N1GEP.
        /// </summary>
        public const string N1GEP = "N1GEP";

        /// <summary>
        /// N1EMNY.
        /// </summary>
        public const string N1EMNY = "N1EMNY";

        /// <summary>
        /// N1EMXY.
        /// </summary>
        public const string N1EMXY = "N1EMXY";

        /// <summary>
        /// N1EMXL.
        /// </summary>
        public const string N1EMXL = "N1EMXL";

        /// <summary>
        /// N1FEP.
        /// </summary>
        public const string N1FEP = "N1FEP";

        /// <summary>
        /// N1AEP.
        /// </summary>
        public const string N1AEP = "N1AEP";

        /// <summary>
        /// N1GER.
        /// </summary>
        public const string N1GER = "N1GER";

        /// <summary>
        /// N1MER.
        /// </summary>
        public const string N1MER = "N1MER";

        /// <summary>
        /// N1NER.
        /// </summary>
        public const string N1NER = "N1NER";

        /// <summary>
        /// N1NAA.
        /// </summary>
        public const string N1NAA = "N1NAA";

        /// <summary>
        /// N1NPA.
        /// </summary>
        public const string N1NPA = "N1NPA";

        /// <summary>
        /// N1RCU.
        /// </summary>
        public const string N1RCU = "N1RCU";

        /// <summary>
        /// N1DGJ.
        /// </summary>
        public const string N1DGJ = "N1DGJ";

        /// <summary>
        /// N1NPSM.
        /// </summary>
        public const string N1NPSM = "N1NPSM";

        /// <summary>
        /// N1NPSY.
        /// </summary>
        public const string N1NPSY = "N1NPSY";

        /// <summary>
        /// N1NPS#.
        /// </summary>
        public const string N1NPS_ = "N1NPS#";

        /// <summary>
        /// N1BPSM.
        /// </summary>
        public const string N1BPSM = "N1BPSM";

        /// <summary>
        /// N1BPSY.
        /// </summary>
        public const string N1BPSY = "N1BPSY";

        /// <summary>
        /// N1BPS#.
        /// </summary>
        public const string N1BPS_ = "N1BPS#";

        /// <summary>
        /// N1BPEM.
        /// </summary>
        public const string N1BPEM = "N1BPEM";

        /// <summary>
        /// N1BPEY.
        /// </summary>
        public const string N1BPEY = "N1BPEY";

        /// <summary>
        /// N1BPE#.
        /// </summary>
        public const string N1BPE_ = "N1BPE#";

        /// <summary>
        /// N1LPSM.
        /// </summary>
        public const string N1LPSM = "N1LPSM";

        /// <summary>
        /// N1LPSY.
        /// </summary>
        public const string N1LPSY = "N1LPSY";

        /// <summary>
        /// N1LPS#.
        /// </summary>
        public const string N1LPS_ = "N1LPS#";

        /// <summary>
        /// N1LPEM.
        /// </summary>
        public const string N1LPEM = "N1LPEM";

        /// <summary>
        /// N1LPEY.
        /// </summary>
        public const string N1LPEY = "N1LPEY";

        /// <summary>
        /// N1LPE#.
        /// </summary>
        public const string N1LPE_ = "N1LPE#";

        /// <summary>
        /// N1ESCL.
        /// </summary>
        public const string N1ESCL = "N1ESCL";

        /// <summary>
        /// N1BERF.
        /// </summary>
        public const string N1BERF = "N1BERF";

        /// <summary>
        /// N1BLFC.
        /// </summary>
        public const string N1BLFC = "N1BLFC";

        /// <summary>
        /// N1EFTB.
        /// </summary>
        public const string N1EFTB = "N1EFTB";

        /// <summary>
        /// N1BRCD.
        /// </summary>
        public const string N1BRCD = "N1BRCD";

        /// <summary>
        /// N1BCI.
        /// </summary>
        public const string N1BCI = "N1BCI";

        /// <summary>
        /// N1USER.
        /// </summary>
        public const string N1USER = "N1USER";

        /// <summary>
        /// N1UPMJ.
        /// </summary>
        public const string N1UPMJ = "N1UPMJ";

        /// <summary>
        /// N1PID.
        /// </summary>
        public const string N1PID = "N1PID";

        /// <summary>
        /// N1JOBN.
        /// </summary>
        public const string N1JOBN = "N1JOBN";

        /// <summary>
        /// N1AAP.
        /// </summary>
        public const string N1AAP = "N1AAP";

        /// <summary>
        /// N1PWF.
        /// </summary>
        public const string N1PWF = "N1PWF";

        /// <summary>
        /// N1PWC.
        /// </summary>
        public const string N1PWC = "N1PWC";

        /// <summary>
        /// N1PWSF.
        /// </summary>
        public const string N1PWSF = "N1PWSF";

        /// <summary>
        /// N1AESC.
        /// </summary>
        public const string N1AESC = "N1AESC";

        /// <summary>
        /// N1EESC.
        /// </summary>
        public const string N1EESC = "N1EESC";

        /// <summary>
        /// N1UNGR.
        /// </summary>
        public const string N1UNGR = "N1UNGR";

        /// <summary>
        /// N1UPMT.
        /// </summary>
        public const string N1UPMT = "N1UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1548";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("N1AN8", "N1AN8", JdeDataType.Numeric),
        new JdeField("N1ALPH", "N1ALPH", JdeDataType.String, 80),
        new JdeField("N1AN8J", "N1AN8J", JdeDataType.Numeric),
        new JdeField("N1DOCO", "N1DOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("N1ICU", "N1ICU", JdeDataType.Numeric),
        new JdeField("N1INDX", "N1INDX", JdeDataType.String, 10),
        new JdeField("N1ESCM", "N1ESCM", JdeDataType.String, 2),
        new JdeField("N1MCU", "N1MCU", JdeDataType.String, 24),
        new JdeField("N1UNIT", "N1UNIT", JdeDataType.String, 16),
        new JdeField("N1BESA", "N1BESA", JdeDataType.Numeric),
        new JdeField("N1LESA", "N1LESA", JdeDataType.Numeric),
        new JdeField("N1BINX", "N1BINX", JdeDataType.Numeric),
        new JdeField("N1LINX", "N1LINX", JdeDataType.Numeric),
        new JdeField("N1ORLS", "N1ORLS", JdeDataType.String, 2),
        new JdeField("N1CINX", "N1CINX", JdeDataType.Numeric),
        new JdeField("N1GEP", "N1GEP", JdeDataType.Numeric),
        new JdeField("N1EMNY", "N1EMNY", JdeDataType.Numeric),
        new JdeField("N1EMXY", "N1EMXY", JdeDataType.Numeric),
        new JdeField("N1EMXL", "N1EMXL", JdeDataType.Numeric),
        new JdeField("N1FEP", "N1FEP", JdeDataType.Numeric),
        new JdeField("N1AEP", "N1AEP", JdeDataType.Numeric),
        new JdeField("N1GER", "N1GER", JdeDataType.Numeric),
        new JdeField("N1MER", "N1MER", JdeDataType.Numeric),
        new JdeField("N1NER", "N1NER", JdeDataType.Numeric),
        new JdeField("N1NAA", "N1NAA", JdeDataType.Numeric),
        new JdeField("N1NPA", "N1NPA", JdeDataType.Numeric),
        new JdeField("N1RCU", "N1RCU", JdeDataType.Numeric),
        new JdeField("N1DGJ", "N1DGJ", JdeDataType.Numeric),
        new JdeField("N1NPSM", "N1NPSM", JdeDataType.Numeric),
        new JdeField("N1NPSY", "N1NPSY", JdeDataType.Numeric),
        new JdeField("N1NPS#", "N1NPS#", JdeDataType.Numeric),
        new JdeField("N1BPSM", "N1BPSM", JdeDataType.Numeric),
        new JdeField("N1BPSY", "N1BPSY", JdeDataType.Numeric),
        new JdeField("N1BPS#", "N1BPS#", JdeDataType.Numeric),
        new JdeField("N1BPEM", "N1BPEM", JdeDataType.Numeric),
        new JdeField("N1BPEY", "N1BPEY", JdeDataType.Numeric),
        new JdeField("N1BPE#", "N1BPE#", JdeDataType.Numeric),
        new JdeField("N1LPSM", "N1LPSM", JdeDataType.Numeric),
        new JdeField("N1LPSY", "N1LPSY", JdeDataType.Numeric),
        new JdeField("N1LPS#", "N1LPS#", JdeDataType.Numeric),
        new JdeField("N1LPEM", "N1LPEM", JdeDataType.Numeric),
        new JdeField("N1LPEY", "N1LPEY", JdeDataType.Numeric),
        new JdeField("N1LPE#", "N1LPE#", JdeDataType.Numeric),
        new JdeField("N1ESCL", "N1ESCL", JdeDataType.Numeric),
        new JdeField("N1BERF", "N1BERF", JdeDataType.Numeric),
        new JdeField("N1BLFC", "N1BLFC", JdeDataType.String, 2),
        new JdeField("N1EFTB", "N1EFTB", JdeDataType.Numeric),
        new JdeField("N1BRCD", "N1BRCD", JdeDataType.String, 8),
        new JdeField("N1BCI", "N1BCI", JdeDataType.Numeric),
        new JdeField("N1USER", "N1USER", JdeDataType.String, 20),
        new JdeField("N1UPMJ", "N1UPMJ", JdeDataType.Numeric),
        new JdeField("N1PID", "N1PID", JdeDataType.String, 20),
        new JdeField("N1JOBN", "N1JOBN", JdeDataType.String, 20),
        new JdeField("N1AAP", "N1AAP", JdeDataType.Numeric),
        new JdeField("N1PWF", "N1PWF", JdeDataType.Numeric),
        new JdeField("N1PWC", "N1PWC", JdeDataType.String, 2),
        new JdeField("N1PWSF", "N1PWSF", JdeDataType.Numeric),
        new JdeField("N1AESC", "N1AESC", JdeDataType.Numeric),
        new JdeField("N1EESC", "N1EESC", JdeDataType.Numeric),
        new JdeField("N1UNGR", "N1UNGR", JdeDataType.String, 2),
        new JdeField("N1UPMT", "N1UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1548_0", "Primary Key on N1DOCO", new[] { "N1DOCO" }, isUnique: true, isPrimaryKey: true)
    };
}
