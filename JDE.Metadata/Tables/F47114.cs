using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47114 - .
/// </summary>
public class F47114 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Z4EDTY.
        /// </summary>
        public const string Z4EDTY = "Z4EDTY";

        /// <summary>
        /// Z4EDSQ.
        /// </summary>
        public const string Z4EDSQ = "Z4EDSQ";

        /// <summary>
        /// Z4EKCO.
        /// </summary>
        public const string Z4EKCO = "Z4EKCO";

        /// <summary>
        /// Z4EDOC.
        /// </summary>
        public const string Z4EDOC = "Z4EDOC";

        /// <summary>
        /// Z4EDCT.
        /// </summary>
        public const string Z4EDCT = "Z4EDCT";

        /// <summary>
        /// Z4EDLN.
        /// </summary>
        public const string Z4EDLN = "Z4EDLN";

        /// <summary>
        /// Z4EDSP.
        /// </summary>
        public const string Z4EDSP = "Z4EDSP";

        /// <summary>
        /// Z4EDBT.
        /// </summary>
        public const string Z4EDBT = "Z4EDBT";

        /// <summary>
        /// Z4DEPN.
        /// </summary>
        public const string Z4DEPN = "Z4DEPN";

        /// <summary>
        /// Z4LNID.
        /// </summary>
        public const string Z4LNID = "Z4LNID";

        /// <summary>
        /// Z4SEQN.
        /// </summary>
        public const string Z4SEQN = "Z4SEQN";

        /// <summary>
        /// Z4DOCM.
        /// </summary>
        public const string Z4DOCM = "Z4DOCM";

        /// <summary>
        /// Z4DCTM.
        /// </summary>
        public const string Z4DCTM = "Z4DCTM";

        /// <summary>
        /// Z4KCO.
        /// </summary>
        public const string Z4KCO = "Z4KCO";

        /// <summary>
        /// Z4DOC.
        /// </summary>
        public const string Z4DOC = "Z4DOC";

        /// <summary>
        /// Z4DCT.
        /// </summary>
        public const string Z4DCT = "Z4DCT";

        /// <summary>
        /// Z4SFX.
        /// </summary>
        public const string Z4SFX = "Z4SFX";

        /// <summary>
        /// Z4RMK.
        /// </summary>
        public const string Z4RMK = "Z4RMK";

        /// <summary>
        /// Z4AG.
        /// </summary>
        public const string Z4AG = "Z4AG";

        /// <summary>
        /// Z4ADSA.
        /// </summary>
        public const string Z4ADSA = "Z4ADSA";

        /// <summary>
        /// Z4ACR.
        /// </summary>
        public const string Z4ACR = "Z4ACR";

        /// <summary>
        /// Z4CDSA.
        /// </summary>
        public const string Z4CDSA = "Z4CDSA";

        /// <summary>
        /// Z4PKCO.
        /// </summary>
        public const string Z4PKCO = "Z4PKCO";

        /// <summary>
        /// Z4PO.
        /// </summary>
        public const string Z4PO = "Z4PO";

        /// <summary>
        /// Z4PDCT.
        /// </summary>
        public const string Z4PDCT = "Z4PDCT";

        /// <summary>
        /// Z4DCTO.
        /// </summary>
        public const string Z4DCTO = "Z4DCTO";

        /// <summary>
        /// Z4CO.
        /// </summary>
        public const string Z4CO = "Z4CO";

        /// <summary>
        /// Z4CTL.
        /// </summary>
        public const string Z4CTL = "Z4CTL";

        /// <summary>
        /// Z4TRTC.
        /// </summary>
        public const string Z4TRTC = "Z4TRTC";

        /// <summary>
        /// Z4RP1.
        /// </summary>
        public const string Z4RP1 = "Z4RP1";

        /// <summary>
        /// Z4RP2.
        /// </summary>
        public const string Z4RP2 = "Z4RP2";

        /// <summary>
        /// Z4RP3.
        /// </summary>
        public const string Z4RP3 = "Z4RP3";

        /// <summary>
        /// Z4URCD.
        /// </summary>
        public const string Z4URCD = "Z4URCD";

        /// <summary>
        /// Z4URDT.
        /// </summary>
        public const string Z4URDT = "Z4URDT";

        /// <summary>
        /// Z4URAT.
        /// </summary>
        public const string Z4URAT = "Z4URAT";

        /// <summary>
        /// Z4URAB.
        /// </summary>
        public const string Z4URAB = "Z4URAB";

        /// <summary>
        /// Z4URRF.
        /// </summary>
        public const string Z4URRF = "Z4URRF";

        /// <summary>
        /// Z4TORG.
        /// </summary>
        public const string Z4TORG = "Z4TORG";

        /// <summary>
        /// Z4USER.
        /// </summary>
        public const string Z4USER = "Z4USER";

        /// <summary>
        /// Z4PID.
        /// </summary>
        public const string Z4PID = "Z4PID";

        /// <summary>
        /// Z4JOBN.
        /// </summary>
        public const string Z4JOBN = "Z4JOBN";

        /// <summary>
        /// Z4UPMJ.
        /// </summary>
        public const string Z4UPMJ = "Z4UPMJ";

        /// <summary>
        /// Z4TDAY.
        /// </summary>
        public const string Z4TDAY = "Z4TDAY";

        /// <summary>
        /// Z4SHPN.
        /// </summary>
        public const string Z4SHPN = "Z4SHPN";

        /// <summary>
        /// Z4RMR1.
        /// </summary>
        public const string Z4RMR1 = "Z4RMR1";
    }

    /// <inheritdoc />
    public override string TableName => "F47114";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Z4EDTY", "Z4EDTY", JdeDataType.String, 2),
        new JdeField("Z4EDSQ", "Z4EDSQ", JdeDataType.Numeric),
        new JdeField("Z4EKCO", "Z4EKCO", JdeDataType.String, 10, true, true),
        new JdeField("Z4EDOC", "Z4EDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("Z4EDCT", "Z4EDCT", JdeDataType.String, 4, true, true),
        new JdeField("Z4EDLN", "Z4EDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("Z4EDSP", "Z4EDSP", JdeDataType.String, 2),
        new JdeField("Z4EDBT", "Z4EDBT", JdeDataType.String, 30),
        new JdeField("Z4DEPN", "Z4DEPN", JdeDataType.String, 60, true, true),
        new JdeField("Z4LNID", "Z4LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("Z4SEQN", "Z4SEQN", JdeDataType.Numeric, null, true, true),
        new JdeField("Z4DOCM", "Z4DOCM", JdeDataType.Numeric),
        new JdeField("Z4DCTM", "Z4DCTM", JdeDataType.String, 4),
        new JdeField("Z4KCO", "Z4KCO", JdeDataType.String, 10),
        new JdeField("Z4DOC", "Z4DOC", JdeDataType.Numeric),
        new JdeField("Z4DCT", "Z4DCT", JdeDataType.String, 4),
        new JdeField("Z4SFX", "Z4SFX", JdeDataType.String, 6),
        new JdeField("Z4RMK", "Z4RMK", JdeDataType.String, 60),
        new JdeField("Z4AG", "Z4AG", JdeDataType.Numeric),
        new JdeField("Z4ADSA", "Z4ADSA", JdeDataType.Numeric),
        new JdeField("Z4ACR", "Z4ACR", JdeDataType.Numeric),
        new JdeField("Z4CDSA", "Z4CDSA", JdeDataType.Numeric),
        new JdeField("Z4PKCO", "Z4PKCO", JdeDataType.String, 10),
        new JdeField("Z4PO", "Z4PO", JdeDataType.String, 16),
        new JdeField("Z4PDCT", "Z4PDCT", JdeDataType.String, 4),
        new JdeField("Z4DCTO", "Z4DCTO", JdeDataType.String, 4),
        new JdeField("Z4CO", "Z4CO", JdeDataType.String, 10),
        new JdeField("Z4CTL", "Z4CTL", JdeDataType.String, 26),
        new JdeField("Z4TRTC", "Z4TRTC", JdeDataType.String, 2),
        new JdeField("Z4RP1", "Z4RP1", JdeDataType.String, 2),
        new JdeField("Z4RP2", "Z4RP2", JdeDataType.String, 2),
        new JdeField("Z4RP3", "Z4RP3", JdeDataType.String, 2),
        new JdeField("Z4URCD", "Z4URCD", JdeDataType.String, 4),
        new JdeField("Z4URDT", "Z4URDT", JdeDataType.Numeric),
        new JdeField("Z4URAT", "Z4URAT", JdeDataType.Numeric),
        new JdeField("Z4URAB", "Z4URAB", JdeDataType.Numeric),
        new JdeField("Z4URRF", "Z4URRF", JdeDataType.String, 30),
        new JdeField("Z4TORG", "Z4TORG", JdeDataType.String, 20),
        new JdeField("Z4USER", "Z4USER", JdeDataType.String, 20),
        new JdeField("Z4PID", "Z4PID", JdeDataType.String, 20),
        new JdeField("Z4JOBN", "Z4JOBN", JdeDataType.String, 20),
        new JdeField("Z4UPMJ", "Z4UPMJ", JdeDataType.Numeric),
        new JdeField("Z4TDAY", "Z4TDAY", JdeDataType.Numeric),
        new JdeField("Z4SHPN", "Z4SHPN", JdeDataType.Numeric),
        new JdeField("Z4RMR1", "Z4RMR1", JdeDataType.String, 100)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47114_0", "Primary Key on Z4EDOC, Z4EDCT, Z4EKCO, Z4EDLN, Z4DEPN, Z4LNID, Z4SEQN", new[] { "Z4EDOC", "Z4EDCT", "Z4EKCO", "Z4EDLN", "Z4DEPN", "Z4LNID", "Z4SEQN" }, isUnique: true, isPrimaryKey: true)
    };
}
