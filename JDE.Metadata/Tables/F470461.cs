using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F470461 - .
/// </summary>
public class F470461 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// S3EDTY.
        /// </summary>
        public const string S3EDTY = "S3EDTY";

        /// <summary>
        /// S3EDSQ.
        /// </summary>
        public const string S3EDSQ = "S3EDSQ";

        /// <summary>
        /// S3EKCO.
        /// </summary>
        public const string S3EKCO = "S3EKCO";

        /// <summary>
        /// S3EDOC.
        /// </summary>
        public const string S3EDOC = "S3EDOC";

        /// <summary>
        /// S3EDCT.
        /// </summary>
        public const string S3EDCT = "S3EDCT";

        /// <summary>
        /// S3EDLN.
        /// </summary>
        public const string S3EDLN = "S3EDLN";

        /// <summary>
        /// S3EDSP.
        /// </summary>
        public const string S3EDSP = "S3EDSP";

        /// <summary>
        /// S3EDBT.
        /// </summary>
        public const string S3EDBT = "S3EDBT";

        /// <summary>
        /// S3KCO.
        /// </summary>
        public const string S3KCO = "S3KCO";

        /// <summary>
        /// S3DOC.
        /// </summary>
        public const string S3DOC = "S3DOC";

        /// <summary>
        /// S3DCT.
        /// </summary>
        public const string S3DCT = "S3DCT";

        /// <summary>
        /// S3DOCO.
        /// </summary>
        public const string S3DOCO = "S3DOCO";

        /// <summary>
        /// S3DCTO.
        /// </summary>
        public const string S3DCTO = "S3DCTO";

        /// <summary>
        /// S3SFXO.
        /// </summary>
        public const string S3SFXO = "S3SFXO";

        /// <summary>
        /// S3MCU.
        /// </summary>
        public const string S3MCU = "S3MCU";

        /// <summary>
        /// S3AN8.
        /// </summary>
        public const string S3AN8 = "S3AN8";

        /// <summary>
        /// S3TAX.
        /// </summary>
        public const string S3TAX = "S3TAX";

        /// <summary>
        /// S3TAXC.
        /// </summary>
        public const string S3TAXC = "S3TAXC";

        /// <summary>
        /// S3TX1.
        /// </summary>
        public const string S3TX1 = "S3TX1";

        /// <summary>
        /// S3TX2.
        /// </summary>
        public const string S3TX2 = "S3TX2";

        /// <summary>
        /// S3TA1.
        /// </summary>
        public const string S3TA1 = "S3TA1";

        /// <summary>
        /// S3TA2.
        /// </summary>
        public const string S3TA2 = "S3TA2";

        /// <summary>
        /// S3TA3.
        /// </summary>
        public const string S3TA3 = "S3TA3";

        /// <summary>
        /// S3TA4.
        /// </summary>
        public const string S3TA4 = "S3TA4";

        /// <summary>
        /// S3TA5.
        /// </summary>
        public const string S3TA5 = "S3TA5";

        /// <summary>
        /// S3TXR1.
        /// </summary>
        public const string S3TXR1 = "S3TXR1";

        /// <summary>
        /// S3TXR2.
        /// </summary>
        public const string S3TXR2 = "S3TXR2";

        /// <summary>
        /// S3TXR3.
        /// </summary>
        public const string S3TXR3 = "S3TXR3";

        /// <summary>
        /// S3TXR4.
        /// </summary>
        public const string S3TXR4 = "S3TXR4";

        /// <summary>
        /// S3TXR5.
        /// </summary>
        public const string S3TXR5 = "S3TXR5";

        /// <summary>
        /// S3TAXT.
        /// </summary>
        public const string S3TAXT = "S3TAXT";

        /// <summary>
        /// S3TAX2.
        /// </summary>
        public const string S3TAX2 = "S3TAX2";

        /// <summary>
        /// S3TAX3.
        /// </summary>
        public const string S3TAX3 = "S3TAX3";

        /// <summary>
        /// S3TAX4.
        /// </summary>
        public const string S3TAX4 = "S3TAX4";

        /// <summary>
        /// S3TAX5.
        /// </summary>
        public const string S3TAX5 = "S3TAX5";

        /// <summary>
        /// S3NAID.
        /// </summary>
        public const string S3NAID = "S3NAID";

        /// <summary>
        /// S3MLNM.
        /// </summary>
        public const string S3MLNM = "S3MLNM";

        /// <summary>
        /// S3PTD.
        /// </summary>
        public const string S3PTD = "S3PTD";

        /// <summary>
        /// S3DCP.
        /// </summary>
        public const string S3DCP = "S3DCP";

        /// <summary>
        /// S3DCD.
        /// </summary>
        public const string S3DCD = "S3DCD";

        /// <summary>
        /// S3NDTP.
        /// </summary>
        public const string S3NDTP = "S3NDTP";

        /// <summary>
        /// S3DDU.
        /// </summary>
        public const string S3DDU = "S3DDU";

        /// <summary>
        /// S3DSCT.
        /// </summary>
        public const string S3DSCT = "S3DSCT";

        /// <summary>
        /// S3NSP.
        /// </summary>
        public const string S3NSP = "S3NSP";

        /// <summary>
        /// S3DTPA.
        /// </summary>
        public const string S3DTPA = "S3DTPA";

        /// <summary>
        /// S3DDJ.
        /// </summary>
        public const string S3DDJ = "S3DDJ";

        /// <summary>
        /// S3AG.
        /// </summary>
        public const string S3AG = "S3AG";

        /// <summary>
        /// S3AAP.
        /// </summary>
        public const string S3AAP = "S3AAP";

        /// <summary>
        /// S3ADSC.
        /// </summary>
        public const string S3ADSC = "S3ADSC";

        /// <summary>
        /// S3ATXN.
        /// </summary>
        public const string S3ATXN = "S3ATXN";

        /// <summary>
        /// S3ATXA.
        /// </summary>
        public const string S3ATXA = "S3ATXA";

        /// <summary>
        /// S3STAM.
        /// </summary>
        public const string S3STAM = "S3STAM";

        /// <summary>
        /// S3ACR.
        /// </summary>
        public const string S3ACR = "S3ACR";

        /// <summary>
        /// S3FAP.
        /// </summary>
        public const string S3FAP = "S3FAP";

        /// <summary>
        /// S3CDS.
        /// </summary>
        public const string S3CDS = "S3CDS";

        /// <summary>
        /// S3CTXN.
        /// </summary>
        public const string S3CTXN = "S3CTXN";

        /// <summary>
        /// S3CTXA.
        /// </summary>
        public const string S3CTXA = "S3CTXA";

        /// <summary>
        /// S3CTAM.
        /// </summary>
        public const string S3CTAM = "S3CTAM";

        /// <summary>
        /// S3DSVJ.
        /// </summary>
        public const string S3DSVJ = "S3DSVJ";

        /// <summary>
        /// S3IVD.
        /// </summary>
        public const string S3IVD = "S3IVD";

        /// <summary>
        /// S3TORG.
        /// </summary>
        public const string S3TORG = "S3TORG";

        /// <summary>
        /// S3USER.
        /// </summary>
        public const string S3USER = "S3USER";

        /// <summary>
        /// S3PID.
        /// </summary>
        public const string S3PID = "S3PID";

        /// <summary>
        /// S3JOBN.
        /// </summary>
        public const string S3JOBN = "S3JOBN";

        /// <summary>
        /// S3UPMJ.
        /// </summary>
        public const string S3UPMJ = "S3UPMJ";

        /// <summary>
        /// S3TDAY.
        /// </summary>
        public const string S3TDAY = "S3TDAY";

        /// <summary>
        /// S3GAN8.
        /// </summary>
        public const string S3GAN8 = "S3GAN8";
    }

    /// <inheritdoc />
    public override string TableName => "F470461";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("S3EDTY", "S3EDTY", JdeDataType.String, 2),
        new JdeField("S3EDSQ", "S3EDSQ", JdeDataType.Numeric),
        new JdeField("S3EKCO", "S3EKCO", JdeDataType.String, 10, true, true),
        new JdeField("S3EDOC", "S3EDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("S3EDCT", "S3EDCT", JdeDataType.String, 4, true, true),
        new JdeField("S3EDLN", "S3EDLN", JdeDataType.Numeric),
        new JdeField("S3EDSP", "S3EDSP", JdeDataType.String, 2),
        new JdeField("S3EDBT", "S3EDBT", JdeDataType.String, 30),
        new JdeField("S3KCO", "S3KCO", JdeDataType.String, 10),
        new JdeField("S3DOC", "S3DOC", JdeDataType.Numeric),
        new JdeField("S3DCT", "S3DCT", JdeDataType.String, 4),
        new JdeField("S3DOCO", "S3DOCO", JdeDataType.Numeric),
        new JdeField("S3DCTO", "S3DCTO", JdeDataType.String, 4),
        new JdeField("S3SFXO", "S3SFXO", JdeDataType.String, 6),
        new JdeField("S3MCU", "S3MCU", JdeDataType.String, 24),
        new JdeField("S3AN8", "S3AN8", JdeDataType.Numeric),
        new JdeField("S3TAX", "S3TAX", JdeDataType.String, 40),
        new JdeField("S3TAXC", "S3TAXC", JdeDataType.String, 2),
        new JdeField("S3TX1", "S3TX1", JdeDataType.String, 32),
        new JdeField("S3TX2", "S3TX2", JdeDataType.String, 40),
        new JdeField("S3TA1", "S3TA1", JdeDataType.Numeric),
        new JdeField("S3TA2", "S3TA2", JdeDataType.Numeric),
        new JdeField("S3TA3", "S3TA3", JdeDataType.Numeric),
        new JdeField("S3TA4", "S3TA4", JdeDataType.Numeric),
        new JdeField("S3TA5", "S3TA5", JdeDataType.Numeric),
        new JdeField("S3TXR1", "S3TXR1", JdeDataType.Numeric),
        new JdeField("S3TXR2", "S3TXR2", JdeDataType.Numeric),
        new JdeField("S3TXR3", "S3TXR3", JdeDataType.Numeric),
        new JdeField("S3TXR4", "S3TXR4", JdeDataType.Numeric),
        new JdeField("S3TXR5", "S3TXR5", JdeDataType.Numeric),
        new JdeField("S3TAXT", "S3TAXT", JdeDataType.Numeric),
        new JdeField("S3TAX2", "S3TAX2", JdeDataType.Numeric),
        new JdeField("S3TAX3", "S3TAX3", JdeDataType.Numeric),
        new JdeField("S3TAX4", "S3TAX4", JdeDataType.Numeric),
        new JdeField("S3TAX5", "S3TAX5", JdeDataType.Numeric),
        new JdeField("S3NAID", "S3NAID", JdeDataType.String, 2),
        new JdeField("S3MLNM", "S3MLNM", JdeDataType.String, 80),
        new JdeField("S3PTD", "S3PTD", JdeDataType.String, 60),
        new JdeField("S3DCP", "S3DCP", JdeDataType.Numeric),
        new JdeField("S3DCD", "S3DCD", JdeDataType.Numeric),
        new JdeField("S3NDTP", "S3NDTP", JdeDataType.Numeric),
        new JdeField("S3DDU", "S3DDU", JdeDataType.Numeric),
        new JdeField("S3DSCT", "S3DSCT", JdeDataType.Numeric),
        new JdeField("S3NSP", "S3NSP", JdeDataType.Numeric),
        new JdeField("S3DTPA", "S3DTPA", JdeDataType.Numeric),
        new JdeField("S3DDJ", "S3DDJ", JdeDataType.Numeric),
        new JdeField("S3AG", "S3AG", JdeDataType.Numeric),
        new JdeField("S3AAP", "S3AAP", JdeDataType.Numeric),
        new JdeField("S3ADSC", "S3ADSC", JdeDataType.Numeric),
        new JdeField("S3ATXN", "S3ATXN", JdeDataType.Numeric),
        new JdeField("S3ATXA", "S3ATXA", JdeDataType.Numeric),
        new JdeField("S3STAM", "S3STAM", JdeDataType.Numeric),
        new JdeField("S3ACR", "S3ACR", JdeDataType.Numeric),
        new JdeField("S3FAP", "S3FAP", JdeDataType.Numeric),
        new JdeField("S3CDS", "S3CDS", JdeDataType.Numeric),
        new JdeField("S3CTXN", "S3CTXN", JdeDataType.Numeric),
        new JdeField("S3CTXA", "S3CTXA", JdeDataType.Numeric),
        new JdeField("S3CTAM", "S3CTAM", JdeDataType.Numeric),
        new JdeField("S3DSVJ", "S3DSVJ", JdeDataType.Numeric),
        new JdeField("S3IVD", "S3IVD", JdeDataType.Numeric),
        new JdeField("S3TORG", "S3TORG", JdeDataType.String, 20),
        new JdeField("S3USER", "S3USER", JdeDataType.String, 20),
        new JdeField("S3PID", "S3PID", JdeDataType.String, 20),
        new JdeField("S3JOBN", "S3JOBN", JdeDataType.String, 20),
        new JdeField("S3UPMJ", "S3UPMJ", JdeDataType.Numeric),
        new JdeField("S3TDAY", "S3TDAY", JdeDataType.Numeric),
        new JdeField("S3GAN8", "S3GAN8", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F470461_0", "Primary Key on S3EDOC, S3EDCT, S3EKCO", new[] { "S3EDOC", "S3EDCT", "S3EKCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F470461_2", "Index on S3DOC", new[] { "S3DOC" })
    };
}
