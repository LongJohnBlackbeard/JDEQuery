using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1525 - .
/// </summary>
public class F1525 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// N0FETP.
        /// </summary>
        public const string N0FETP = "N0FETP";

        /// <summary>
        /// N0DOCO.
        /// </summary>
        public const string N0DOCO = "N0DOCO";

        /// <summary>
        /// N0AN8.
        /// </summary>
        public const string N0AN8 = "N0AN8";

        /// <summary>
        /// N0MCU.
        /// </summary>
        public const string N0MCU = "N0MCU";

        /// <summary>
        /// N0GLC.
        /// </summary>
        public const string N0GLC = "N0GLC";

        /// <summary>
        /// N0AGSN.
        /// </summary>
        public const string N0AGSN = "N0AGSN";

        /// <summary>
        /// N0FFC.
        /// </summary>
        public const string N0FFC = "N0FFC";

        /// <summary>
        /// N0AG.
        /// </summary>
        public const string N0AG = "N0AG";

        /// <summary>
        /// N0FERT.
        /// </summary>
        public const string N0FERT = "N0FERT";

        /// <summary>
        /// N0RTSC.
        /// </summary>
        public const string N0RTSC = "N0RTSC";

        /// <summary>
        /// N0AAPF.
        /// </summary>
        public const string N0AAPF = "N0AAPF";

        /// <summary>
        /// N0BRCD.
        /// </summary>
        public const string N0BRCD = "N0BRCD";

        /// <summary>
        /// N0FISD.
        /// </summary>
        public const string N0FISD = "N0FISD";

        /// <summary>
        /// N0NGP.
        /// </summary>
        public const string N0NGP = "N0NGP";

        /// <summary>
        /// N0GPT.
        /// </summary>
        public const string N0GPT = "N0GPT";

        /// <summary>
        /// N0RSDC.
        /// </summary>
        public const string N0RSDC = "N0RSDC";

        /// <summary>
        /// N0MXP.
        /// </summary>
        public const string N0MXP = "N0MXP";

        /// <summary>
        /// N0MPT.
        /// </summary>
        public const string N0MPT = "N0MPT";

        /// <summary>
        /// N0CMXA.
        /// </summary>
        public const string N0CMXA = "N0CMXA";

        /// <summary>
        /// N0CMXP.
        /// </summary>
        public const string N0CMXP = "N0CMXP";

        /// <summary>
        /// N0HMXA.
        /// </summary>
        public const string N0HMXA = "N0HMXA";

        /// <summary>
        /// N0HMXP.
        /// </summary>
        public const string N0HMXP = "N0HMXP";

        /// <summary>
        /// N0COPF.
        /// </summary>
        public const string N0COPF = "N0COPF";

        /// <summary>
        /// N0EFTB.
        /// </summary>
        public const string N0EFTB = "N0EFTB";

        /// <summary>
        /// N0EFTE.
        /// </summary>
        public const string N0EFTE = "N0EFTE";

        /// <summary>
        /// N0BCI.
        /// </summary>
        public const string N0BCI = "N0BCI";

        /// <summary>
        /// N0RAIF.
        /// </summary>
        public const string N0RAIF = "N0RAIF";

        /// <summary>
        /// N0PPCF.
        /// </summary>
        public const string N0PPCF = "N0PPCF";

        /// <summary>
        /// N0SLEV.
        /// </summary>
        public const string N0SLEV = "N0SLEV";

        /// <summary>
        /// N0USER.
        /// </summary>
        public const string N0USER = "N0USER";

        /// <summary>
        /// N0PID.
        /// </summary>
        public const string N0PID = "N0PID";

        /// <summary>
        /// N0UPMJ.
        /// </summary>
        public const string N0UPMJ = "N0UPMJ";

        /// <summary>
        /// N0JOBN.
        /// </summary>
        public const string N0JOBN = "N0JOBN";

        /// <summary>
        /// N0PTC.
        /// </summary>
        public const string N0PTC = "N0PTC";

        /// <summary>
        /// N0TXA1.
        /// </summary>
        public const string N0TXA1 = "N0TXA1";

        /// <summary>
        /// N0EXR1.
        /// </summary>
        public const string N0EXR1 = "N0EXR1";

        /// <summary>
        /// N0UPMT.
        /// </summary>
        public const string N0UPMT = "N0UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1525";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("N0FETP", "N0FETP", JdeDataType.String, 6, true, true),
        new JdeField("N0DOCO", "N0DOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("N0AN8", "N0AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("N0MCU", "N0MCU", JdeDataType.String, 24, true, true),
        new JdeField("N0GLC", "N0GLC", JdeDataType.String, 8, true, true),
        new JdeField("N0AGSN", "N0AGSN", JdeDataType.Numeric, null, true, true),
        new JdeField("N0FFC", "N0FFC", JdeDataType.String, 2),
        new JdeField("N0AG", "N0AG", JdeDataType.Numeric),
        new JdeField("N0FERT", "N0FERT", JdeDataType.Numeric),
        new JdeField("N0RTSC", "N0RTSC", JdeDataType.String, 2),
        new JdeField("N0AAPF", "N0AAPF", JdeDataType.String, 2),
        new JdeField("N0BRCD", "N0BRCD", JdeDataType.String, 8),
        new JdeField("N0FISD", "N0FISD", JdeDataType.String, 2),
        new JdeField("N0NGP", "N0NGP", JdeDataType.Numeric),
        new JdeField("N0GPT", "N0GPT", JdeDataType.String, 2),
        new JdeField("N0RSDC", "N0RSDC", JdeDataType.String, 2),
        new JdeField("N0MXP", "N0MXP", JdeDataType.Numeric),
        new JdeField("N0MPT", "N0MPT", JdeDataType.String, 2),
        new JdeField("N0CMXA", "N0CMXA", JdeDataType.Numeric),
        new JdeField("N0CMXP", "N0CMXP", JdeDataType.Numeric),
        new JdeField("N0HMXA", "N0HMXA", JdeDataType.Numeric),
        new JdeField("N0HMXP", "N0HMXP", JdeDataType.Numeric),
        new JdeField("N0COPF", "N0COPF", JdeDataType.String, 2),
        new JdeField("N0EFTB", "N0EFTB", JdeDataType.Numeric),
        new JdeField("N0EFTE", "N0EFTE", JdeDataType.Numeric),
        new JdeField("N0BCI", "N0BCI", JdeDataType.Numeric, null, true, true),
        new JdeField("N0RAIF", "N0RAIF", JdeDataType.String, 2),
        new JdeField("N0PPCF", "N0PPCF", JdeDataType.String, 2),
        new JdeField("N0SLEV", "N0SLEV", JdeDataType.Numeric),
        new JdeField("N0USER", "N0USER", JdeDataType.String, 20),
        new JdeField("N0PID", "N0PID", JdeDataType.String, 20),
        new JdeField("N0UPMJ", "N0UPMJ", JdeDataType.Numeric),
        new JdeField("N0JOBN", "N0JOBN", JdeDataType.String, 20),
        new JdeField("N0PTC", "N0PTC", JdeDataType.String, 6),
        new JdeField("N0TXA1", "N0TXA1", JdeDataType.String, 20),
        new JdeField("N0EXR1", "N0EXR1", JdeDataType.String, 4),
        new JdeField("N0UPMT", "N0UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1525_0", "Primary Key on N0FETP, N0DOCO, N0AN8, N0MCU, N0GLC, N0AGSN, N0BCI", new[] { "N0FETP", "N0DOCO", "N0AN8", "N0MCU", "N0GLC", "N0AGSN", "N0BCI" }, isUnique: true, isPrimaryKey: true)
    };
}
