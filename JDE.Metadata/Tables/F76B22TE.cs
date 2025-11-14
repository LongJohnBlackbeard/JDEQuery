using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B22TE - .
/// </summary>
public class F76B22TE : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UNB76TNF.
        /// </summary>
        public const string UNB76TNF = "UNB76TNF";

        /// <summary>
        /// UNFCO.
        /// </summary>
        public const string UNFCO = "UNFCO";

        /// <summary>
        /// UNB76LSER.
        /// </summary>
        public const string UNB76LSER = "UNB76LSER";

        /// <summary>
        /// UNB76LNFR.
        /// </summary>
        public const string UNB76LNFR = "UNB76LNFR";

        /// <summary>
        /// UNB76LNTO.
        /// </summary>
        public const string UNB76LNTO = "UNB76LNTO";

        /// <summary>
        /// UNB76UNDJ.
        /// </summary>
        public const string UNB76UNDJ = "UNB76UNDJ";

        /// <summary>
        /// UNB76UNUR.
        /// </summary>
        public const string UNB76UNUR = "UNB76UNUR";

        /// <summary>
        /// UNB76NFST.
        /// </summary>
        public const string UNB76NFST = "UNB76NFST";

        /// <summary>
        /// UNB76PRON.
        /// </summary>
        public const string UNB76PRON = "UNB76PRON";

        /// <summary>
        /// UNB76EPRD.
        /// </summary>
        public const string UNB76EPRD = "UNB76EPRD";

        /// <summary>
        /// UNB76EPRT.
        /// </summary>
        public const string UNB76EPRT = "UNB76EPRT";

        /// <summary>
        /// UNB76RSPC.
        /// </summary>
        public const string UNB76RSPC = "UNB76RSPC";

        /// <summary>
        /// UN76BXFNM.
        /// </summary>
        public const string UN76BXFNM = "UN76BXFNM";

        /// <summary>
        /// UNB76RXFNM.
        /// </summary>
        public const string UNB76RXFNM = "UNB76RXFNM";

        /// <summary>
        /// UN76BESTAT.
        /// </summary>
        public const string UN76BESTAT = "UN76BESTAT";

        /// <summary>
        /// UN76BESDT.
        /// </summary>
        public const string UN76BESDT = "UN76BESDT";

        /// <summary>
        /// UNUSER.
        /// </summary>
        public const string UNUSER = "UNUSER";

        /// <summary>
        /// UNPID.
        /// </summary>
        public const string UNPID = "UNPID";

        /// <summary>
        /// UNJOBN.
        /// </summary>
        public const string UNJOBN = "UNJOBN";

        /// <summary>
        /// UNUPMJ.
        /// </summary>
        public const string UNUPMJ = "UNUPMJ";

        /// <summary>
        /// UNUPMT.
        /// </summary>
        public const string UNUPMT = "UNUPMT";

        /// <summary>
        /// UNB76NFUT.
        /// </summary>
        public const string UNB76NFUT = "UNB76NFUT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B22TE";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UNB76TNF", "UNB76TNF", JdeDataType.String, 20, true, true),
        new JdeField("UNFCO", "UNFCO", JdeDataType.String, 10, true, true),
        new JdeField("UNB76LSER", "UNB76LSER", JdeDataType.String, 20, true, true),
        new JdeField("UNB76LNFR", "UNB76LNFR", JdeDataType.Numeric, null, true, true),
        new JdeField("UNB76LNTO", "UNB76LNTO", JdeDataType.Numeric),
        new JdeField("UNB76UNDJ", "UNB76UNDJ", JdeDataType.Numeric),
        new JdeField("UNB76UNUR", "UNB76UNUR", JdeDataType.String, 20),
        new JdeField("UNB76NFST", "UNB76NFST", JdeDataType.String, 2),
        new JdeField("UNB76PRON", "UNB76PRON", JdeDataType.Numeric),
        new JdeField("UNB76EPRD", "UNB76EPRD", JdeDataType.Numeric),
        new JdeField("UNB76EPRT", "UNB76EPRT", JdeDataType.Numeric),
        new JdeField("UNB76RSPC", "UNB76RSPC", JdeDataType.Numeric),
        new JdeField("UN76BXFNM", "UN76BXFNM", JdeDataType.String, 510),
        new JdeField("UNB76RXFNM", "UNB76RXFNM", JdeDataType.String, 510),
        new JdeField("UN76BESTAT", "UN76BESTAT", JdeDataType.String, 2),
        new JdeField("UN76BESDT", "UN76BESDT", JdeDataType.Numeric),
        new JdeField("UNUSER", "UNUSER", JdeDataType.String, 20),
        new JdeField("UNPID", "UNPID", JdeDataType.String, 20),
        new JdeField("UNJOBN", "UNJOBN", JdeDataType.String, 20),
        new JdeField("UNUPMJ", "UNUPMJ", JdeDataType.Numeric),
        new JdeField("UNUPMT", "UNUPMT", JdeDataType.Numeric),
        new JdeField("UNB76NFUT", "UNB76NFUT", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B22TE_0", "Primary Key on UNB76TNF, UNFCO, UNB76LSER, UNB76LNFR", new[] { "UNB76TNF", "UNFCO", "UNB76LSER", "UNB76LNFR" }, isUnique: true, isPrimaryKey: true)
    };
}
