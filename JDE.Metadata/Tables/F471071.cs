using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F471071 - .
/// </summary>
public class F471071 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// S4EDTY.
        /// </summary>
        public const string S4EDTY = "S4EDTY";

        /// <summary>
        /// S4EDSQ.
        /// </summary>
        public const string S4EDSQ = "S4EDSQ";

        /// <summary>
        /// S4EKCO.
        /// </summary>
        public const string S4EKCO = "S4EKCO";

        /// <summary>
        /// S4EDOC.
        /// </summary>
        public const string S4EDOC = "S4EDOC";

        /// <summary>
        /// S4EDCT.
        /// </summary>
        public const string S4EDCT = "S4EDCT";

        /// <summary>
        /// S4EDLN.
        /// </summary>
        public const string S4EDLN = "S4EDLN";

        /// <summary>
        /// S4EDSP.
        /// </summary>
        public const string S4EDSP = "S4EDSP";

        /// <summary>
        /// S4EDBT.
        /// </summary>
        public const string S4EDBT = "S4EDBT";

        /// <summary>
        /// S4KCO.
        /// </summary>
        public const string S4KCO = "S4KCO";

        /// <summary>
        /// S4DOC.
        /// </summary>
        public const string S4DOC = "S4DOC";

        /// <summary>
        /// S4DCT.
        /// </summary>
        public const string S4DCT = "S4DCT";

        /// <summary>
        /// S4DOCO.
        /// </summary>
        public const string S4DOCO = "S4DOCO";

        /// <summary>
        /// S4DCTO.
        /// </summary>
        public const string S4DCTO = "S4DCTO";

        /// <summary>
        /// S4SFXO.
        /// </summary>
        public const string S4SFXO = "S4SFXO";

        /// <summary>
        /// S4LNID.
        /// </summary>
        public const string S4LNID = "S4LNID";

        /// <summary>
        /// S4MCU.
        /// </summary>
        public const string S4MCU = "S4MCU";

        /// <summary>
        /// S4AN8.
        /// </summary>
        public const string S4AN8 = "S4AN8";

        /// <summary>
        /// S4VINV.
        /// </summary>
        public const string S4VINV = "S4VINV";

        /// <summary>
        /// S4TA1.
        /// </summary>
        public const string S4TA1 = "S4TA1";

        /// <summary>
        /// S4TA2.
        /// </summary>
        public const string S4TA2 = "S4TA2";

        /// <summary>
        /// S4TA3.
        /// </summary>
        public const string S4TA3 = "S4TA3";

        /// <summary>
        /// S4TA4.
        /// </summary>
        public const string S4TA4 = "S4TA4";

        /// <summary>
        /// S4TA5.
        /// </summary>
        public const string S4TA5 = "S4TA5";

        /// <summary>
        /// S4TXR1.
        /// </summary>
        public const string S4TXR1 = "S4TXR1";

        /// <summary>
        /// S4TXR2.
        /// </summary>
        public const string S4TXR2 = "S4TXR2";

        /// <summary>
        /// S4TXR3.
        /// </summary>
        public const string S4TXR3 = "S4TXR3";

        /// <summary>
        /// S4TXR4.
        /// </summary>
        public const string S4TXR4 = "S4TXR4";

        /// <summary>
        /// S4TXR5.
        /// </summary>
        public const string S4TXR5 = "S4TXR5";

        /// <summary>
        /// S4TAXT.
        /// </summary>
        public const string S4TAXT = "S4TAXT";

        /// <summary>
        /// S4TAX2.
        /// </summary>
        public const string S4TAX2 = "S4TAX2";

        /// <summary>
        /// S4TAX3.
        /// </summary>
        public const string S4TAX3 = "S4TAX3";

        /// <summary>
        /// S4TAX4.
        /// </summary>
        public const string S4TAX4 = "S4TAX4";

        /// <summary>
        /// S4TAX5.
        /// </summary>
        public const string S4TAX5 = "S4TAX5";

        /// <summary>
        /// S4DSCT.
        /// </summary>
        public const string S4DSCT = "S4DSCT";

        /// <summary>
        /// S4PTD.
        /// </summary>
        public const string S4PTD = "S4PTD";

        /// <summary>
        /// S4DCP.
        /// </summary>
        public const string S4DCP = "S4DCP";

        /// <summary>
        /// S4DCD.
        /// </summary>
        public const string S4DCD = "S4DCD";

        /// <summary>
        /// S4NDTP.
        /// </summary>
        public const string S4NDTP = "S4NDTP";

        /// <summary>
        /// S4DDJ.
        /// </summary>
        public const string S4DDJ = "S4DDJ";

        /// <summary>
        /// S4DDU.
        /// </summary>
        public const string S4DDU = "S4DDU";

        /// <summary>
        /// S4NSP.
        /// </summary>
        public const string S4NSP = "S4NSP";

        /// <summary>
        /// S4DTPA.
        /// </summary>
        public const string S4DTPA = "S4DTPA";

        /// <summary>
        /// S4DSVJ.
        /// </summary>
        public const string S4DSVJ = "S4DSVJ";

        /// <summary>
        /// S4TORG.
        /// </summary>
        public const string S4TORG = "S4TORG";

        /// <summary>
        /// S4USER.
        /// </summary>
        public const string S4USER = "S4USER";

        /// <summary>
        /// S4PID.
        /// </summary>
        public const string S4PID = "S4PID";

        /// <summary>
        /// S4JOBN.
        /// </summary>
        public const string S4JOBN = "S4JOBN";

        /// <summary>
        /// S4UPMJ.
        /// </summary>
        public const string S4UPMJ = "S4UPMJ";

        /// <summary>
        /// S4TDAY.
        /// </summary>
        public const string S4TDAY = "S4TDAY";

        /// <summary>
        /// S4GAN8.
        /// </summary>
        public const string S4GAN8 = "S4GAN8";
    }

    /// <inheritdoc />
    public override string TableName => "F471071";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("S4EDTY", "S4EDTY", JdeDataType.String, 2),
        new JdeField("S4EDSQ", "S4EDSQ", JdeDataType.Numeric),
        new JdeField("S4EKCO", "S4EKCO", JdeDataType.String, 10, true, true),
        new JdeField("S4EDOC", "S4EDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("S4EDCT", "S4EDCT", JdeDataType.String, 4, true, true),
        new JdeField("S4EDLN", "S4EDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("S4EDSP", "S4EDSP", JdeDataType.String, 2),
        new JdeField("S4EDBT", "S4EDBT", JdeDataType.String, 30),
        new JdeField("S4KCO", "S4KCO", JdeDataType.String, 10),
        new JdeField("S4DOC", "S4DOC", JdeDataType.Numeric),
        new JdeField("S4DCT", "S4DCT", JdeDataType.String, 4),
        new JdeField("S4DOCO", "S4DOCO", JdeDataType.Numeric),
        new JdeField("S4DCTO", "S4DCTO", JdeDataType.String, 4),
        new JdeField("S4SFXO", "S4SFXO", JdeDataType.String, 6),
        new JdeField("S4LNID", "S4LNID", JdeDataType.Numeric),
        new JdeField("S4MCU", "S4MCU", JdeDataType.String, 24),
        new JdeField("S4AN8", "S4AN8", JdeDataType.Numeric),
        new JdeField("S4VINV", "S4VINV", JdeDataType.String, 50),
        new JdeField("S4TA1", "S4TA1", JdeDataType.Numeric),
        new JdeField("S4TA2", "S4TA2", JdeDataType.Numeric),
        new JdeField("S4TA3", "S4TA3", JdeDataType.Numeric),
        new JdeField("S4TA4", "S4TA4", JdeDataType.Numeric),
        new JdeField("S4TA5", "S4TA5", JdeDataType.Numeric),
        new JdeField("S4TXR1", "S4TXR1", JdeDataType.Numeric),
        new JdeField("S4TXR2", "S4TXR2", JdeDataType.Numeric),
        new JdeField("S4TXR3", "S4TXR3", JdeDataType.Numeric),
        new JdeField("S4TXR4", "S4TXR4", JdeDataType.Numeric),
        new JdeField("S4TXR5", "S4TXR5", JdeDataType.Numeric),
        new JdeField("S4TAXT", "S4TAXT", JdeDataType.Numeric),
        new JdeField("S4TAX2", "S4TAX2", JdeDataType.Numeric),
        new JdeField("S4TAX3", "S4TAX3", JdeDataType.Numeric),
        new JdeField("S4TAX4", "S4TAX4", JdeDataType.Numeric),
        new JdeField("S4TAX5", "S4TAX5", JdeDataType.Numeric),
        new JdeField("S4DSCT", "S4DSCT", JdeDataType.Numeric),
        new JdeField("S4PTD", "S4PTD", JdeDataType.String, 60),
        new JdeField("S4DCP", "S4DCP", JdeDataType.Numeric),
        new JdeField("S4DCD", "S4DCD", JdeDataType.Numeric),
        new JdeField("S4NDTP", "S4NDTP", JdeDataType.Numeric),
        new JdeField("S4DDJ", "S4DDJ", JdeDataType.Numeric),
        new JdeField("S4DDU", "S4DDU", JdeDataType.Numeric),
        new JdeField("S4NSP", "S4NSP", JdeDataType.Numeric),
        new JdeField("S4DTPA", "S4DTPA", JdeDataType.Numeric),
        new JdeField("S4DSVJ", "S4DSVJ", JdeDataType.Numeric),
        new JdeField("S4TORG", "S4TORG", JdeDataType.String, 20),
        new JdeField("S4USER", "S4USER", JdeDataType.String, 20),
        new JdeField("S4PID", "S4PID", JdeDataType.String, 20),
        new JdeField("S4JOBN", "S4JOBN", JdeDataType.String, 20),
        new JdeField("S4UPMJ", "S4UPMJ", JdeDataType.Numeric),
        new JdeField("S4TDAY", "S4TDAY", JdeDataType.Numeric),
        new JdeField("S4GAN8", "S4GAN8", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F471071_0", "Primary Key on S4EDOC, S4EDCT, S4EKCO, S4EDLN", new[] { "S4EDOC", "S4EDCT", "S4EKCO", "S4EDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
