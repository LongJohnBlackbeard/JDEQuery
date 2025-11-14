using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4823 - .
/// </summary>
public class F4823 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// W0DOCO.
        /// </summary>
        public const string W0DOCO = "W0DOCO";

        /// <summary>
        /// W0DCTO.
        /// </summary>
        public const string W0DCTO = "W0DCTO";

        /// <summary>
        /// W0KCOO.
        /// </summary>
        public const string W0KCOO = "W0KCOO";

        /// <summary>
        /// W0PCTN.
        /// </summary>
        public const string W0PCTN = "W0PCTN";

        /// <summary>
        /// W0PCTT.
        /// </summary>
        public const string W0PCTT = "W0PCTT";

        /// <summary>
        /// W0PCKO.
        /// </summary>
        public const string W0PCKO = "W0PCKO";

        /// <summary>
        /// W0APPL.
        /// </summary>
        public const string W0APPL = "W0APPL";

        /// <summary>
        /// W0ADJN.
        /// </summary>
        public const string W0ADJN = "W0ADJN";

        /// <summary>
        /// W0COCH.
        /// </summary>
        public const string W0COCH = "W0COCH";

        /// <summary>
        /// W0LNID.
        /// </summary>
        public const string W0LNID = "W0LNID";

        /// <summary>
        /// W0OPIM.
        /// </summary>
        public const string W0OPIM = "W0OPIM";

        /// <summary>
        /// W0AN8O.
        /// </summary>
        public const string W0AN8O = "W0AN8O";

        /// <summary>
        /// W0AN8J.
        /// </summary>
        public const string W0AN8J = "W0AN8J";

        /// <summary>
        /// W0PTC.
        /// </summary>
        public const string W0PTC = "W0PTC";

        /// <summary>
        /// W0CO.
        /// </summary>
        public const string W0CO = "W0CO";

        /// <summary>
        /// W0MCU.
        /// </summary>
        public const string W0MCU = "W0MCU";

        /// <summary>
        /// W0SBL.
        /// </summary>
        public const string W0SBL = "W0SBL";

        /// <summary>
        /// W0SBLT.
        /// </summary>
        public const string W0SBLT = "W0SBLT";

        /// <summary>
        /// W0GLC.
        /// </summary>
        public const string W0GLC = "W0GLC";

        /// <summary>
        /// W0BTFR.
        /// </summary>
        public const string W0BTFR = "W0BTFR";

        /// <summary>
        /// W0BTDT.
        /// </summary>
        public const string W0BTDT = "W0BTDT";

        /// <summary>
        /// W0DGL.
        /// </summary>
        public const string W0DGL = "W0DGL";

        /// <summary>
        /// W0DDJ.
        /// </summary>
        public const string W0DDJ = "W0DDJ";

        /// <summary>
        /// W0DSVJ.
        /// </summary>
        public const string W0DSVJ = "W0DSVJ";

        /// <summary>
        /// W0ICU.
        /// </summary>
        public const string W0ICU = "W0ICU";

        /// <summary>
        /// W0DOCZ.
        /// </summary>
        public const string W0DOCZ = "W0DOCZ";

        /// <summary>
        /// W0DCTI.
        /// </summary>
        public const string W0DCTI = "W0DCTI";

        /// <summary>
        /// W0KCOI.
        /// </summary>
        public const string W0KCOI = "W0KCOI";

        /// <summary>
        /// W0SFX.
        /// </summary>
        public const string W0SFX = "W0SFX";

        /// <summary>
        /// W0APDT.
        /// </summary>
        public const string W0APDT = "W0APDT";

        /// <summary>
        /// W0APPO.
        /// </summary>
        public const string W0APPO = "W0APPO";

        /// <summary>
        /// W0VOID.
        /// </summary>
        public const string W0VOID = "W0VOID";

        /// <summary>
        /// W0U.
        /// </summary>
        public const string W0U = "W0U";

        /// <summary>
        /// W0UM.
        /// </summary>
        public const string W0UM = "W0UM";

        /// <summary>
        /// W0UP.
        /// </summary>
        public const string W0UP = "W0UP";

        /// <summary>
        /// W0FUP.
        /// </summary>
        public const string W0FUP = "W0FUP";

        /// <summary>
        /// W0PUHP.
        /// </summary>
        public const string W0PUHP = "W0PUHP";

        /// <summary>
        /// W0AA.
        /// </summary>
        public const string W0AA = "W0AA";

        /// <summary>
        /// W0ACR.
        /// </summary>
        public const string W0ACR = "W0ACR";

        /// <summary>
        /// W0THPD.
        /// </summary>
        public const string W0THPD = "W0THPD";

        /// <summary>
        /// W0FHPD.
        /// </summary>
        public const string W0FHPD = "W0FHPD";

        /// <summary>
        /// W0RTHP.
        /// </summary>
        public const string W0RTHP = "W0RTHP";

        /// <summary>
        /// W0PTHP.
        /// </summary>
        public const string W0PTHP = "W0PTHP";

        /// <summary>
        /// W0FTHP.
        /// </summary>
        public const string W0FTHP = "W0FTHP";

        /// <summary>
        /// W0TXA1.
        /// </summary>
        public const string W0TXA1 = "W0TXA1";

        /// <summary>
        /// W0EXR1.
        /// </summary>
        public const string W0EXR1 = "W0EXR1";

        /// <summary>
        /// W0STAM.
        /// </summary>
        public const string W0STAM = "W0STAM";

        /// <summary>
        /// W0CTAM.
        /// </summary>
        public const string W0CTAM = "W0CTAM";

        /// <summary>
        /// W0PTAM.
        /// </summary>
        public const string W0PTAM = "W0PTAM";

        /// <summary>
        /// W0FPTA.
        /// </summary>
        public const string W0FPTA = "W0FPTA";

        /// <summary>
        /// W0ATXA.
        /// </summary>
        public const string W0ATXA = "W0ATXA";

        /// <summary>
        /// W0CTXA.
        /// </summary>
        public const string W0CTXA = "W0CTXA";

        /// <summary>
        /// W0PATX.
        /// </summary>
        public const string W0PATX = "W0PATX";

        /// <summary>
        /// W0FATX.
        /// </summary>
        public const string W0FATX = "W0FATX";

        /// <summary>
        /// W0ATXN.
        /// </summary>
        public const string W0ATXN = "W0ATXN";

        /// <summary>
        /// W0CTXN.
        /// </summary>
        public const string W0CTXN = "W0CTXN";

        /// <summary>
        /// W0ADSC.
        /// </summary>
        public const string W0ADSC = "W0ADSC";

        /// <summary>
        /// W0CDS.
        /// </summary>
        public const string W0CDS = "W0CDS";

        /// <summary>
        /// W0CRRM.
        /// </summary>
        public const string W0CRRM = "W0CRRM";

        /// <summary>
        /// W0CRCD.
        /// </summary>
        public const string W0CRCD = "W0CRCD";

        /// <summary>
        /// W0CRCF.
        /// </summary>
        public const string W0CRCF = "W0CRCF";

        /// <summary>
        /// W0CRR.
        /// </summary>
        public const string W0CRR = "W0CRR";

        /// <summary>
        /// W0CRRD.
        /// </summary>
        public const string W0CRRD = "W0CRRD";

        /// <summary>
        /// W0RMK.
        /// </summary>
        public const string W0RMK = "W0RMK";

        /// <summary>
        /// W0MIVL.
        /// </summary>
        public const string W0MIVL = "W0MIVL";

        /// <summary>
        /// W0MISM.
        /// </summary>
        public const string W0MISM = "W0MISM";

        /// <summary>
        /// W0PID.
        /// </summary>
        public const string W0PID = "W0PID";

        /// <summary>
        /// W0JOBN.
        /// </summary>
        public const string W0JOBN = "W0JOBN";

        /// <summary>
        /// W0USER.
        /// </summary>
        public const string W0USER = "W0USER";

        /// <summary>
        /// W0MUPM.
        /// </summary>
        public const string W0MUPM = "W0MUPM";

        /// <summary>
        /// W0UPMT.
        /// </summary>
        public const string W0UPMT = "W0UPMT";

        /// <summary>
        /// W0VGCSF.
        /// </summary>
        public const string W0VGCSF = "W0VGCSF";

        /// <summary>
        /// W0VGCOA.
        /// </summary>
        public const string W0VGCOA = "W0VGCOA";

        /// <summary>
        /// W0VVTY.
        /// </summary>
        public const string W0VVTY = "W0VVTY";

        /// <summary>
        /// W0VVTC.
        /// </summary>
        public const string W0VVTC = "W0VVTC";
    }

    /// <inheritdoc />
    public override string TableName => "F4823";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("W0DOCO", "W0DOCO", JdeDataType.Numeric),
        new JdeField("W0DCTO", "W0DCTO", JdeDataType.String, 4),
        new JdeField("W0KCOO", "W0KCOO", JdeDataType.String, 10),
        new JdeField("W0PCTN", "W0PCTN", JdeDataType.Numeric),
        new JdeField("W0PCTT", "W0PCTT", JdeDataType.String, 4),
        new JdeField("W0PCKO", "W0PCKO", JdeDataType.String, 10),
        new JdeField("W0APPL", "W0APPL", JdeDataType.Numeric),
        new JdeField("W0ADJN", "W0ADJN", JdeDataType.Numeric),
        new JdeField("W0COCH", "W0COCH", JdeDataType.String, 6),
        new JdeField("W0LNID", "W0LNID", JdeDataType.Numeric),
        new JdeField("W0OPIM", "W0OPIM", JdeDataType.String, 30),
        new JdeField("W0AN8O", "W0AN8O", JdeDataType.Numeric),
        new JdeField("W0AN8J", "W0AN8J", JdeDataType.Numeric),
        new JdeField("W0PTC", "W0PTC", JdeDataType.String, 6),
        new JdeField("W0CO", "W0CO", JdeDataType.String, 10),
        new JdeField("W0MCU", "W0MCU", JdeDataType.String, 24),
        new JdeField("W0SBL", "W0SBL", JdeDataType.String, 16),
        new JdeField("W0SBLT", "W0SBLT", JdeDataType.String, 2),
        new JdeField("W0GLC", "W0GLC", JdeDataType.String, 8),
        new JdeField("W0BTFR", "W0BTFR", JdeDataType.Numeric),
        new JdeField("W0BTDT", "W0BTDT", JdeDataType.Numeric),
        new JdeField("W0DGL", "W0DGL", JdeDataType.Numeric),
        new JdeField("W0DDJ", "W0DDJ", JdeDataType.Numeric),
        new JdeField("W0DSVJ", "W0DSVJ", JdeDataType.Numeric),
        new JdeField("W0ICU", "W0ICU", JdeDataType.Numeric),
        new JdeField("W0DOCZ", "W0DOCZ", JdeDataType.Numeric, null, true, true),
        new JdeField("W0DCTI", "W0DCTI", JdeDataType.String, 4, true, true),
        new JdeField("W0KCOI", "W0KCOI", JdeDataType.String, 10, true, true),
        new JdeField("W0SFX", "W0SFX", JdeDataType.String, 6, true, true),
        new JdeField("W0APDT", "W0APDT", JdeDataType.Numeric),
        new JdeField("W0APPO", "W0APPO", JdeDataType.String, 2),
        new JdeField("W0VOID", "W0VOID", JdeDataType.String, 2),
        new JdeField("W0U", "W0U", JdeDataType.Numeric),
        new JdeField("W0UM", "W0UM", JdeDataType.String, 4),
        new JdeField("W0UP", "W0UP", JdeDataType.Numeric),
        new JdeField("W0FUP", "W0FUP", JdeDataType.Numeric),
        new JdeField("W0PUHP", "W0PUHP", JdeDataType.Numeric),
        new JdeField("W0AA", "W0AA", JdeDataType.Numeric),
        new JdeField("W0ACR", "W0ACR", JdeDataType.Numeric),
        new JdeField("W0THPD", "W0THPD", JdeDataType.Numeric),
        new JdeField("W0FHPD", "W0FHPD", JdeDataType.Numeric),
        new JdeField("W0RTHP", "W0RTHP", JdeDataType.Numeric),
        new JdeField("W0PTHP", "W0PTHP", JdeDataType.Numeric),
        new JdeField("W0FTHP", "W0FTHP", JdeDataType.Numeric),
        new JdeField("W0TXA1", "W0TXA1", JdeDataType.String, 20),
        new JdeField("W0EXR1", "W0EXR1", JdeDataType.String, 4),
        new JdeField("W0STAM", "W0STAM", JdeDataType.Numeric),
        new JdeField("W0CTAM", "W0CTAM", JdeDataType.Numeric),
        new JdeField("W0PTAM", "W0PTAM", JdeDataType.Numeric),
        new JdeField("W0FPTA", "W0FPTA", JdeDataType.Numeric),
        new JdeField("W0ATXA", "W0ATXA", JdeDataType.Numeric),
        new JdeField("W0CTXA", "W0CTXA", JdeDataType.Numeric),
        new JdeField("W0PATX", "W0PATX", JdeDataType.Numeric),
        new JdeField("W0FATX", "W0FATX", JdeDataType.Numeric),
        new JdeField("W0ATXN", "W0ATXN", JdeDataType.Numeric),
        new JdeField("W0CTXN", "W0CTXN", JdeDataType.Numeric),
        new JdeField("W0ADSC", "W0ADSC", JdeDataType.Numeric),
        new JdeField("W0CDS", "W0CDS", JdeDataType.Numeric),
        new JdeField("W0CRRM", "W0CRRM", JdeDataType.String, 2),
        new JdeField("W0CRCD", "W0CRCD", JdeDataType.String, 6),
        new JdeField("W0CRCF", "W0CRCF", JdeDataType.String, 6),
        new JdeField("W0CRR", "W0CRR", JdeDataType.Numeric),
        new JdeField("W0CRRD", "W0CRRD", JdeDataType.Numeric),
        new JdeField("W0RMK", "W0RMK", JdeDataType.String, 60),
        new JdeField("W0MIVL", "W0MIVL", JdeDataType.String, 2),
        new JdeField("W0MISM", "W0MISM", JdeDataType.String, 2),
        new JdeField("W0PID", "W0PID", JdeDataType.String, 20),
        new JdeField("W0JOBN", "W0JOBN", JdeDataType.String, 20),
        new JdeField("W0USER", "W0USER", JdeDataType.String, 20),
        new JdeField("W0MUPM", "W0MUPM", JdeDataType.Numeric),
        new JdeField("W0UPMT", "W0UPMT", JdeDataType.Numeric),
        new JdeField("W0VGCSF", "W0VGCSF", JdeDataType.String, 20),
        new JdeField("W0VGCOA", "W0VGCOA", JdeDataType.String, 20),
        new JdeField("W0VVTY", "W0VVTY", JdeDataType.String, 12),
        new JdeField("W0VVTC", "W0VVTC", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4823_0", "Primary Key on W0DOCZ, W0DCTI, W0KCOI, W0SFX", new[] { "W0DOCZ", "W0DCTI", "W0KCOI", "W0SFX" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4823_10", "Index on W0DOCO, W0DCTO, W0KCOO, W0COCH, W0LNID, W0APPL, W0ADJN", new[] { "W0DOCO", "W0DCTO", "W0KCOO", "W0COCH", "W0LNID", "W0APPL", "W0ADJN" }),
        new JdeIndex("F4823_11", "Index on W0DOCO, W0DCTO, W0KCOO, W0APPO", new[] { "W0DOCO", "W0DCTO", "W0KCOO", "W0APPO" }),
        new JdeIndex("F4823_2", "Index on W0ICU, W0DOCZ, W0DCTI, W0KCOI", new[] { "W0ICU", "W0DOCZ", "W0DCTI", "W0KCOI" }),
        new JdeIndex("F4823_3", "Index on W0DOCZ, W0DCTI, W0KCOI, W0ICU, W0SFX", new[] { "W0DOCZ", "W0DCTI", "W0KCOI", "W0ICU", "W0SFX" }),
        new JdeIndex("F4823_4", "Index on W0DOCO, W0DCTO, W0KCOO, W0COCH, W0LNID", new[] { "W0DOCO", "W0DCTO", "W0KCOO", "W0COCH", "W0LNID" }),
        new JdeIndex("F4823_9", "Index on W0DOCO, W0DCTO, W0KCOO, W0APPL, W0ADJN, W0COCH, W0LNID", new[] { "W0DOCO", "W0DCTO", "W0KCOO", "W0APPL", "W0ADJN", "W0COCH", "W0LNID" })
    };
}
