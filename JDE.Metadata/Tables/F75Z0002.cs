using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75Z0002 - .
/// </summary>
public class F75Z0002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Z2AN8.
        /// </summary>
        public const string Z2AN8 = "Z2AN8";

        /// <summary>
        /// Z2CKCN.
        /// </summary>
        public const string Z2CKCN = "Z2CKCN";

        /// <summary>
        /// Z2IRDNUM.
        /// </summary>
        public const string Z2IRDNUM = "Z2IRDNUM";

        /// <summary>
        /// Z2IRDNUME.
        /// </summary>
        public const string Z2IRDNUME = "Z2IRDNUME";

        /// <summary>
        /// Z2TAXCDEP.
        /// </summary>
        public const string Z2TAXCDEP = "Z2TAXCDEP";

        /// <summary>
        /// Z2TAXCDES.
        /// </summary>
        public const string Z2TAXCDES = "Z2TAXCDES";

        /// <summary>
        /// Z2DGJ.
        /// </summary>
        public const string Z2DGJ = "Z2DGJ";

        /// <summary>
        /// Z2PFRQ.
        /// </summary>
        public const string Z2PFRQ = "Z2PFRQ";

        /// <summary>
        /// Z2GTXBLE.
        /// </summary>
        public const string Z2GTXBLE = "Z2GTXBLE";

        /// <summary>
        /// Z2EARNNL.
        /// </summary>
        public const string Z2EARNNL = "Z2EARNNL";

        /// <summary>
        /// Z2SUPTAXL.
        /// </summary>
        public const string Z2SUPTAXL = "Z2SUPTAXL";

        /// <summary>
        /// Z2SUPTAXH.
        /// </summary>
        public const string Z2SUPTAXH = "Z2SUPTAXH";

        /// <summary>
        /// Z2SPAGR01.
        /// </summary>
        public const string Z2SPAGR01 = "Z2SPAGR01";

        /// <summary>
        /// Z2SPAGR02.
        /// </summary>
        public const string Z2SPAGR02 = "Z2SPAGR02";

        /// <summary>
        /// Z2SPAGR03.
        /// </summary>
        public const string Z2SPAGR03 = "Z2SPAGR03";

        /// <summary>
        /// Z2SPAGR04.
        /// </summary>
        public const string Z2SPAGR04 = "Z2SPAGR04";

        /// <summary>
        /// Z2SPAGR05.
        /// </summary>
        public const string Z2SPAGR05 = "Z2SPAGR05";

        /// <summary>
        /// Z2SPAGR06.
        /// </summary>
        public const string Z2SPAGR06 = "Z2SPAGR06";

        /// <summary>
        /// Z2TOTPAYE.
        /// </summary>
        public const string Z2TOTPAYE = "Z2TOTPAYE";

        /// <summary>
        /// Z2STUDLND.
        /// </summary>
        public const string Z2STUDLND = "Z2STUDLND";

        /// <summary>
        /// Z2ERNPTAX.
        /// </summary>
        public const string Z2ERNPTAX = "Z2ERNPTAX";

        /// <summary>
        /// Z2CHLDSD.
        /// </summary>
        public const string Z2CHLDSD = "Z2CHLDSD";

        /// <summary>
        /// Z2FAMASST.
        /// </summary>
        public const string Z2FAMASST = "Z2FAMASST";

        /// <summary>
        /// Z2SPATX01.
        /// </summary>
        public const string Z2SPATX01 = "Z2SPATX01";

        /// <summary>
        /// Z2SPATX02.
        /// </summary>
        public const string Z2SPATX02 = "Z2SPATX02";

        /// <summary>
        /// Z2SPATX03.
        /// </summary>
        public const string Z2SPATX03 = "Z2SPATX03";

        /// <summary>
        /// Z2CHLDSVC.
        /// </summary>
        public const string Z2CHLDSVC = "Z2CHLDSVC";

        /// <summary>
        /// Z2LUMPSF.
        /// </summary>
        public const string Z2LUMPSF = "Z2LUMPSF";

        /// <summary>
        /// Z2IRDDR.
        /// </summary>
        public const string Z2IRDDR = "Z2IRDDR";

        /// <summary>
        /// Z2UPMJ.
        /// </summary>
        public const string Z2UPMJ = "Z2UPMJ";

        /// <summary>
        /// Z2UPMT.
        /// </summary>
        public const string Z2UPMT = "Z2UPMT";

        /// <summary>
        /// Z2PID.
        /// </summary>
        public const string Z2PID = "Z2PID";

        /// <summary>
        /// Z2USER.
        /// </summary>
        public const string Z2USER = "Z2USER";

        /// <summary>
        /// Z2JOBN.
        /// </summary>
        public const string Z2JOBN = "Z2JOBN";

        /// <summary>
        /// Z2KDED.
        /// </summary>
        public const string Z2KDED = "Z2KDED";

        /// <summary>
        /// Z2KCON.
        /// </summary>
        public const string Z2KCON = "Z2KCON";
    }

    /// <inheritdoc />
    public override string TableName => "F75Z0002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Z2AN8", "Z2AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("Z2CKCN", "Z2CKCN", JdeDataType.Numeric, null, true, true),
        new JdeField("Z2IRDNUM", "Z2IRDNUM", JdeDataType.Numeric),
        new JdeField("Z2IRDNUME", "Z2IRDNUME", JdeDataType.Numeric),
        new JdeField("Z2TAXCDEP", "Z2TAXCDEP", JdeDataType.String, 6),
        new JdeField("Z2TAXCDES", "Z2TAXCDES", JdeDataType.String, 6),
        new JdeField("Z2DGJ", "Z2DGJ", JdeDataType.Numeric),
        new JdeField("Z2PFRQ", "Z2PFRQ", JdeDataType.String, 2),
        new JdeField("Z2GTXBLE", "Z2GTXBLE", JdeDataType.Numeric),
        new JdeField("Z2EARNNL", "Z2EARNNL", JdeDataType.Numeric),
        new JdeField("Z2SUPTAXL", "Z2SUPTAXL", JdeDataType.Numeric),
        new JdeField("Z2SUPTAXH", "Z2SUPTAXH", JdeDataType.Numeric),
        new JdeField("Z2SPAGR01", "Z2SPAGR01", JdeDataType.Numeric),
        new JdeField("Z2SPAGR02", "Z2SPAGR02", JdeDataType.Numeric),
        new JdeField("Z2SPAGR03", "Z2SPAGR03", JdeDataType.Numeric),
        new JdeField("Z2SPAGR04", "Z2SPAGR04", JdeDataType.Numeric),
        new JdeField("Z2SPAGR05", "Z2SPAGR05", JdeDataType.Numeric),
        new JdeField("Z2SPAGR06", "Z2SPAGR06", JdeDataType.Numeric),
        new JdeField("Z2TOTPAYE", "Z2TOTPAYE", JdeDataType.Numeric),
        new JdeField("Z2STUDLND", "Z2STUDLND", JdeDataType.Numeric),
        new JdeField("Z2ERNPTAX", "Z2ERNPTAX", JdeDataType.Numeric),
        new JdeField("Z2CHLDSD", "Z2CHLDSD", JdeDataType.Numeric),
        new JdeField("Z2FAMASST", "Z2FAMASST", JdeDataType.Numeric),
        new JdeField("Z2SPATX01", "Z2SPATX01", JdeDataType.Numeric),
        new JdeField("Z2SPATX02", "Z2SPATX02", JdeDataType.Numeric),
        new JdeField("Z2SPATX03", "Z2SPATX03", JdeDataType.Numeric),
        new JdeField("Z2CHLDSVC", "Z2CHLDSVC", JdeDataType.String, 2),
        new JdeField("Z2LUMPSF", "Z2LUMPSF", JdeDataType.String, 2),
        new JdeField("Z2IRDDR", "Z2IRDDR", JdeDataType.Numeric),
        new JdeField("Z2UPMJ", "Z2UPMJ", JdeDataType.Numeric),
        new JdeField("Z2UPMT", "Z2UPMT", JdeDataType.Numeric),
        new JdeField("Z2PID", "Z2PID", JdeDataType.String, 20),
        new JdeField("Z2USER", "Z2USER", JdeDataType.String, 20),
        new JdeField("Z2JOBN", "Z2JOBN", JdeDataType.String, 20),
        new JdeField("Z2KDED", "Z2KDED", JdeDataType.Numeric),
        new JdeField("Z2KCON", "Z2KCON", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75Z0002_0", "Primary Key on Z2AN8, Z2CKCN", new[] { "Z2AN8", "Z2CKCN" }, isUnique: true, isPrimaryKey: true)
    };
}
