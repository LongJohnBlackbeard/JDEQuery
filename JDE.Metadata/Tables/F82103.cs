using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F82103 - .
/// </summary>
public class F82103 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// A2QRYG.
        /// </summary>
        public const string A2QRYG = "A2QRYG";

        /// <summary>
        /// A2QRYN.
        /// </summary>
        public const string A2QRYN = "A2QRYN";

        /// <summary>
        /// A2SQNA.
        /// </summary>
        public const string A2SQNA = "A2SQNA";

        /// <summary>
        /// A2OFD.
        /// </summary>
        public const string A2OFD = "A2OFD";

        /// <summary>
        /// A2OFDI.
        /// </summary>
        public const string A2OFDI = "A2OFDI";

        /// <summary>
        /// A2DSCR.
        /// </summary>
        public const string A2DSCR = "A2DSCR";

        /// <summary>
        /// A2DTAS.
        /// </summary>
        public const string A2DTAS = "A2DTAS";

        /// <summary>
        /// A2OFDS.
        /// </summary>
        public const string A2OFDS = "A2OFDS";

        /// <summary>
        /// A2DTAD.
        /// </summary>
        public const string A2DTAD = "A2DTAD";

        /// <summary>
        /// A2CDEC.
        /// </summary>
        public const string A2CDEC = "A2CDEC";

        /// <summary>
        /// A2PDEC.
        /// </summary>
        public const string A2PDEC = "A2PDEC";

        /// <summary>
        /// A2OSCL.
        /// </summary>
        public const string A2OSCL = "A2OSCL";

        /// <summary>
        /// A2DTAT.
        /// </summary>
        public const string A2DTAT = "A2DTAT";

        /// <summary>
        /// A2EC.
        /// </summary>
        public const string A2EC = "A2EC";

        /// <summary>
        /// A2EDWR.
        /// </summary>
        public const string A2EDWR = "A2EDWR";

        /// <summary>
        /// A2FFMT.
        /// </summary>
        public const string A2FFMT = "A2FFMT";

        /// <summary>
        /// A2LR.
        /// </summary>
        public const string A2LR = "A2LR";

        /// <summary>
        /// A2SY.
        /// </summary>
        public const string A2SY = "A2SY";

        /// <summary>
        /// A2RT.
        /// </summary>
        public const string A2RT = "A2RT";

        /// <summary>
        /// A2CHF.
        /// </summary>
        public const string A2CHF = "A2CHF";

        /// <summary>
        /// A2CHFI.
        /// </summary>
        public const string A2CHFI = "A2CHFI";

        /// <summary>
        /// A2SVFL.
        /// </summary>
        public const string A2SVFL = "A2SVFL";

        /// <summary>
        /// A2CH1.
        /// </summary>
        public const string A2CH1 = "A2CH1";

        /// <summary>
        /// A2CH2.
        /// </summary>
        public const string A2CH2 = "A2CH2";

        /// <summary>
        /// A2CH3.
        /// </summary>
        public const string A2CH3 = "A2CH3";

        /// <summary>
        /// A2CSP.
        /// </summary>
        public const string A2CSP = "A2CSP";

        /// <summary>
        /// A2RNO.
        /// </summary>
        public const string A2RNO = "A2RNO";

        /// <summary>
        /// A2CNO.
        /// </summary>
        public const string A2CNO = "A2CNO";

        /// <summary>
        /// A2MSIZ.
        /// </summary>
        public const string A2MSIZ = "A2MSIZ";

        /// <summary>
        /// A2PWHN.
        /// </summary>
        public const string A2PWHN = "A2PWHN";

        /// <summary>
        /// A2SPCH.
        /// </summary>
        public const string A2SPCH = "A2SPCH";

        /// <summary>
        /// A2WL.
        /// </summary>
        public const string A2WL = "A2WL";

        /// <summary>
        /// A2DS#.
        /// </summary>
        public const string A2DS_ = "A2DS#";
    }

    /// <inheritdoc />
    public override string TableName => "F82103";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("A2QRYG", "A2QRYG", JdeDataType.String, 20, true, true),
        new JdeField("A2QRYN", "A2QRYN", JdeDataType.String, 20, true, true),
        new JdeField("A2SQNA", "A2SQNA", JdeDataType.Numeric, null, true, true),
        new JdeField("A2OFD", "A2OFD", JdeDataType.String, 20),
        new JdeField("A2OFDI", "A2OFDI", JdeDataType.Numeric),
        new JdeField("A2DSCR", "A2DSCR", JdeDataType.String, 80),
        new JdeField("A2DTAS", "A2DTAS", JdeDataType.Numeric),
        new JdeField("A2OFDS", "A2OFDS", JdeDataType.Numeric),
        new JdeField("A2DTAD", "A2DTAD", JdeDataType.Numeric),
        new JdeField("A2CDEC", "A2CDEC", JdeDataType.String, 2),
        new JdeField("A2PDEC", "A2PDEC", JdeDataType.Numeric),
        new JdeField("A2OSCL", "A2OSCL", JdeDataType.Numeric),
        new JdeField("A2DTAT", "A2DTAT", JdeDataType.String, 2),
        new JdeField("A2EC", "A2EC", JdeDataType.String, 2),
        new JdeField("A2EDWR", "A2EDWR", JdeDataType.String, 60),
        new JdeField("A2FFMT", "A2FFMT", JdeDataType.String, 6),
        new JdeField("A2LR", "A2LR", JdeDataType.String, 2),
        new JdeField("A2SY", "A2SY", JdeDataType.String, 8),
        new JdeField("A2RT", "A2RT", JdeDataType.String, 4),
        new JdeField("A2CHF", "A2CHF", JdeDataType.String, 20),
        new JdeField("A2CHFI", "A2CHFI", JdeDataType.Numeric),
        new JdeField("A2SVFL", "A2SVFL", JdeDataType.String, 20),
        new JdeField("A2CH1", "A2CH1", JdeDataType.String, 40),
        new JdeField("A2CH2", "A2CH2", JdeDataType.String, 40),
        new JdeField("A2CH3", "A2CH3", JdeDataType.String, 40),
        new JdeField("A2CSP", "A2CSP", JdeDataType.Numeric),
        new JdeField("A2RNO", "A2RNO", JdeDataType.Numeric),
        new JdeField("A2CNO", "A2CNO", JdeDataType.Numeric),
        new JdeField("A2MSIZ", "A2MSIZ", JdeDataType.Numeric),
        new JdeField("A2PWHN", "A2PWHN", JdeDataType.String, 2),
        new JdeField("A2SPCH", "A2SPCH", JdeDataType.String, 2),
        new JdeField("A2WL", "A2WL", JdeDataType.String, 2),
        new JdeField("A2DS#", "A2DS#", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F82103_0", "Primary Key on A2QRYG, A2QRYN, A2SQNA", new[] { "A2QRYG", "A2QRYN", "A2SQNA" }, isUnique: true, isPrimaryKey: true)
    };
}
