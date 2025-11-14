using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I322E - .
/// </summary>
public class F75I322E : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Q3KCOO.
        /// </summary>
        public const string Q3KCOO = "Q3KCOO";

        /// <summary>
        /// Q3DOCO.
        /// </summary>
        public const string Q3DOCO = "Q3DOCO";

        /// <summary>
        /// Q3DCTO.
        /// </summary>
        public const string Q3DCTO = "Q3DCTO";

        /// <summary>
        /// Q3LNID.
        /// </summary>
        public const string Q3LNID = "Q3LNID";

        /// <summary>
        /// Q3SFXO.
        /// </summary>
        public const string Q3SFXO = "Q3SFXO";

        /// <summary>
        /// Q3MCU.
        /// </summary>
        public const string Q3MCU = "Q3MCU";

        /// <summary>
        /// Q3LOCN.
        /// </summary>
        public const string Q3LOCN = "Q3LOCN";

        /// <summary>
        /// Q3LOTN.
        /// </summary>
        public const string Q3LOTN = "Q3LOTN";

        /// <summary>
        /// Q3CO.
        /// </summary>
        public const string Q3CO = "Q3CO";

        /// <summary>
        /// Q3AN8.
        /// </summary>
        public const string Q3AN8 = "Q3AN8";

        /// <summary>
        /// Q3IVD.
        /// </summary>
        public const string Q3IVD = "Q3IVD";

        /// <summary>
        /// Q3ITM.
        /// </summary>
        public const string Q3ITM = "Q3ITM";

        /// <summary>
        /// Q3LITM.
        /// </summary>
        public const string Q3LITM = "Q3LITM";

        /// <summary>
        /// Q3AITM.
        /// </summary>
        public const string Q3AITM = "Q3AITM";

        /// <summary>
        /// Q3STKT.
        /// </summary>
        public const string Q3STKT = "Q3STKT";

        /// <summary>
        /// Q3UORG.
        /// </summary>
        public const string Q3UORG = "Q3UORG";

        /// <summary>
        /// Q3SOQS.
        /// </summary>
        public const string Q3SOQS = "Q3SOQS";

        /// <summary>
        /// Q3UPRC.
        /// </summary>
        public const string Q3UPRC = "Q3UPRC";

        /// <summary>
        /// Q3AEXP.
        /// </summary>
        public const string Q3AEXP = "Q3AEXP";

        /// <summary>
        /// Q3DCPER.
        /// </summary>
        public const string Q3DCPER = "Q3DCPER";

        /// <summary>
        /// Q3DCVD.
        /// </summary>
        public const string Q3DCVD = "Q3DCVD";

        /// <summary>
        /// Q3YTDU.
        /// </summary>
        public const string Q3YTDU = "Q3YTDU";

        /// <summary>
        /// Q3YODT.
        /// </summary>
        public const string Q3YODT = "Q3YODT";

        /// <summary>
        /// Q3AA.
        /// </summary>
        public const string Q3AA = "Q3AA";

        /// <summary>
        /// Q3LPRC.
        /// </summary>
        public const string Q3LPRC = "Q3LPRC";

        /// <summary>
        /// Q3KCO.
        /// </summary>
        public const string Q3KCO = "Q3KCO";

        /// <summary>
        /// Q3DOC.
        /// </summary>
        public const string Q3DOC = "Q3DOC";

        /// <summary>
        /// Q3YCHN.
        /// </summary>
        public const string Q3YCHN = "Q3YCHN";

        /// <summary>
        /// Q3DCT.
        /// </summary>
        public const string Q3DCT = "Q3DCT";

        /// <summary>
        /// Q3EUSE.
        /// </summary>
        public const string Q3EUSE = "Q3EUSE";

        /// <summary>
        /// Q3USER.
        /// </summary>
        public const string Q3USER = "Q3USER";

        /// <summary>
        /// Q3PID.
        /// </summary>
        public const string Q3PID = "Q3PID";

        /// <summary>
        /// Q3JOBN.
        /// </summary>
        public const string Q3JOBN = "Q3JOBN";

        /// <summary>
        /// Q3UPMJ.
        /// </summary>
        public const string Q3UPMJ = "Q3UPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F75I322E";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Q3KCOO", "Q3KCOO", JdeDataType.String, 10),
        new JdeField("Q3DOCO", "Q3DOCO", JdeDataType.Numeric),
        new JdeField("Q3DCTO", "Q3DCTO", JdeDataType.String, 4),
        new JdeField("Q3LNID", "Q3LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("Q3SFXO", "Q3SFXO", JdeDataType.String, 6),
        new JdeField("Q3MCU", "Q3MCU", JdeDataType.String, 24),
        new JdeField("Q3LOCN", "Q3LOCN", JdeDataType.String, 40),
        new JdeField("Q3LOTN", "Q3LOTN", JdeDataType.String, 60),
        new JdeField("Q3CO", "Q3CO", JdeDataType.String, 10),
        new JdeField("Q3AN8", "Q3AN8", JdeDataType.Numeric),
        new JdeField("Q3IVD", "Q3IVD", JdeDataType.Numeric),
        new JdeField("Q3ITM", "Q3ITM", JdeDataType.Numeric),
        new JdeField("Q3LITM", "Q3LITM", JdeDataType.String, 50),
        new JdeField("Q3AITM", "Q3AITM", JdeDataType.String, 50),
        new JdeField("Q3STKT", "Q3STKT", JdeDataType.String, 2),
        new JdeField("Q3UORG", "Q3UORG", JdeDataType.Numeric),
        new JdeField("Q3SOQS", "Q3SOQS", JdeDataType.Numeric),
        new JdeField("Q3UPRC", "Q3UPRC", JdeDataType.Numeric),
        new JdeField("Q3AEXP", "Q3AEXP", JdeDataType.Numeric),
        new JdeField("Q3DCPER", "Q3DCPER", JdeDataType.Numeric),
        new JdeField("Q3DCVD", "Q3DCVD", JdeDataType.Numeric),
        new JdeField("Q3YTDU", "Q3YTDU", JdeDataType.Numeric),
        new JdeField("Q3YODT", "Q3YODT", JdeDataType.Numeric),
        new JdeField("Q3AA", "Q3AA", JdeDataType.Numeric),
        new JdeField("Q3LPRC", "Q3LPRC", JdeDataType.Numeric),
        new JdeField("Q3KCO", "Q3KCO", JdeDataType.String, 10, true, true),
        new JdeField("Q3DOC", "Q3DOC", JdeDataType.Numeric, null, true, true),
        new JdeField("Q3YCHN", "Q3YCHN", JdeDataType.String, 40),
        new JdeField("Q3DCT", "Q3DCT", JdeDataType.String, 4, true, true),
        new JdeField("Q3EUSE", "Q3EUSE", JdeDataType.String, 6),
        new JdeField("Q3USER", "Q3USER", JdeDataType.String, 20),
        new JdeField("Q3PID", "Q3PID", JdeDataType.String, 20),
        new JdeField("Q3JOBN", "Q3JOBN", JdeDataType.String, 20),
        new JdeField("Q3UPMJ", "Q3UPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I322E_0", "Primary Key on Q3KCO, Q3DOC, Q3DCT, Q3LNID", new[] { "Q3KCO", "Q3DOC", "Q3DCT", "Q3LNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I322E_2", "Index on Q3KCO, Q3DOC, Q3DCT, Q3YCHN", new[] { "Q3KCO", "Q3DOC", "Q3DCT", "Q3YCHN" })
    };
}
