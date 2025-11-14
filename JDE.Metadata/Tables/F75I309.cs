using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I309 - .
/// </summary>
public class F75I309 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CSI75RSCD.
        /// </summary>
        public const string CSI75RSCD = "CSI75RSCD";

        /// <summary>
        /// CSDSC2.
        /// </summary>
        public const string CSDSC2 = "CSDSC2";

        /// <summary>
        /// CSREMK.
        /// </summary>
        public const string CSREMK = "CSREMK";

        /// <summary>
        /// CSI75CNQY.
        /// </summary>
        public const string CSI75CNQY = "CSI75CNQY";

        /// <summary>
        /// CSI75BED.
        /// </summary>
        public const string CSI75BED = "CSI75BED";

        /// <summary>
        /// CSI75CESS.
        /// </summary>
        public const string CSI75CESS = "CSI75CESS";

        /// <summary>
        /// CSI75AED.
        /// </summary>
        public const string CSI75AED = "CSI75AED";

        /// <summary>
        /// CSI75SED.
        /// </summary>
        public const string CSI75SED = "CSI75SED";

        /// <summary>
        /// CSI75FTX1.
        /// </summary>
        public const string CSI75FTX1 = "CSI75FTX1";

        /// <summary>
        /// CSI75FTX2.
        /// </summary>
        public const string CSI75FTX2 = "CSI75FTX2";

        /// <summary>
        /// CSYTDU.
        /// </summary>
        public const string CSYTDU = "CSYTDU";

        /// <summary>
        /// CSKCOO.
        /// </summary>
        public const string CSKCOO = "CSKCOO";

        /// <summary>
        /// CSDOCO.
        /// </summary>
        public const string CSDOCO = "CSDOCO";

        /// <summary>
        /// CSDCTO.
        /// </summary>
        public const string CSDCTO = "CSDCTO";

        /// <summary>
        /// CSKCO.
        /// </summary>
        public const string CSKCO = "CSKCO";

        /// <summary>
        /// CSDOC.
        /// </summary>
        public const string CSDOC = "CSDOC";

        /// <summary>
        /// CSDCT.
        /// </summary>
        public const string CSDCT = "CSDCT";

        /// <summary>
        /// CSLNID.
        /// </summary>
        public const string CSLNID = "CSLNID";

        /// <summary>
        /// CSLOTN.
        /// </summary>
        public const string CSLOTN = "CSLOTN";

        /// <summary>
        /// CSLOCN.
        /// </summary>
        public const string CSLOCN = "CSLOCN";

        /// <summary>
        /// CSMCU.
        /// </summary>
        public const string CSMCU = "CSMCU";

        /// <summary>
        /// CSMATC.
        /// </summary>
        public const string CSMATC = "CSMATC";

        /// <summary>
        /// CSAN8.
        /// </summary>
        public const string CSAN8 = "CSAN8";

        /// <summary>
        /// CSLITM.
        /// </summary>
        public const string CSLITM = "CSLITM";

        /// <summary>
        /// CSAITM.
        /// </summary>
        public const string CSAITM = "CSAITM";

        /// <summary>
        /// CSUOM.
        /// </summary>
        public const string CSUOM = "CSUOM";

        /// <summary>
        /// CSCRCD.
        /// </summary>
        public const string CSCRCD = "CSCRCD";

        /// <summary>
        /// CSQTYS.
        /// </summary>
        public const string CSQTYS = "CSQTYS";

        /// <summary>
        /// CSUORG.
        /// </summary>
        public const string CSUORG = "CSUORG";

        /// <summary>
        /// CSSOQS.
        /// </summary>
        public const string CSSOQS = "CSSOQS";

        /// <summary>
        /// CSUPRC.
        /// </summary>
        public const string CSUPRC = "CSUPRC";

        /// <summary>
        /// CSAEXP.
        /// </summary>
        public const string CSAEXP = "CSAEXP";

        /// <summary>
        /// CSAST.
        /// </summary>
        public const string CSAST = "CSAST";

        /// <summary>
        /// CSI75TXTY.
        /// </summary>
        public const string CSI75TXTY = "CSI75TXTY";

        /// <summary>
        /// CSDSC1.
        /// </summary>
        public const string CSDSC1 = "CSDSC1";

        /// <summary>
        /// CSIVD.
        /// </summary>
        public const string CSIVD = "CSIVD";

        /// <summary>
        /// CSDGL.
        /// </summary>
        public const string CSDGL = "CSDGL";

        /// <summary>
        /// CSTORG.
        /// </summary>
        public const string CSTORG = "CSTORG";

        /// <summary>
        /// CSUSER.
        /// </summary>
        public const string CSUSER = "CSUSER";

        /// <summary>
        /// CSJOBN.
        /// </summary>
        public const string CSJOBN = "CSJOBN";

        /// <summary>
        /// CSPID.
        /// </summary>
        public const string CSPID = "CSPID";

        /// <summary>
        /// CSUPMJ.
        /// </summary>
        public const string CSUPMJ = "CSUPMJ";

        /// <summary>
        /// CSUPMT.
        /// </summary>
        public const string CSUPMT = "CSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75I309";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CSI75RSCD", "CSI75RSCD", JdeDataType.String, 10, true, true),
        new JdeField("CSDSC2", "CSDSC2", JdeDataType.String, 60),
        new JdeField("CSREMK", "CSREMK", JdeDataType.String, 60),
        new JdeField("CSI75CNQY", "CSI75CNQY", JdeDataType.Numeric),
        new JdeField("CSI75BED", "CSI75BED", JdeDataType.Numeric),
        new JdeField("CSI75CESS", "CSI75CESS", JdeDataType.Numeric),
        new JdeField("CSI75AED", "CSI75AED", JdeDataType.Numeric),
        new JdeField("CSI75SED", "CSI75SED", JdeDataType.Numeric),
        new JdeField("CSI75FTX1", "CSI75FTX1", JdeDataType.Numeric),
        new JdeField("CSI75FTX2", "CSI75FTX2", JdeDataType.Numeric),
        new JdeField("CSYTDU", "CSYTDU", JdeDataType.Numeric),
        new JdeField("CSKCOO", "CSKCOO", JdeDataType.String, 10, true, true),
        new JdeField("CSDOCO", "CSDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("CSDCTO", "CSDCTO", JdeDataType.String, 4, true, true),
        new JdeField("CSKCO", "CSKCO", JdeDataType.String, 10),
        new JdeField("CSDOC", "CSDOC", JdeDataType.Numeric),
        new JdeField("CSDCT", "CSDCT", JdeDataType.String, 4),
        new JdeField("CSLNID", "CSLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("CSLOTN", "CSLOTN", JdeDataType.String, 60),
        new JdeField("CSLOCN", "CSLOCN", JdeDataType.String, 40),
        new JdeField("CSMCU", "CSMCU", JdeDataType.String, 24, true, true),
        new JdeField("CSMATC", "CSMATC", JdeDataType.String, 2),
        new JdeField("CSAN8", "CSAN8", JdeDataType.Numeric),
        new JdeField("CSLITM", "CSLITM", JdeDataType.String, 50, true, true),
        new JdeField("CSAITM", "CSAITM", JdeDataType.String, 50),
        new JdeField("CSUOM", "CSUOM", JdeDataType.String, 4),
        new JdeField("CSCRCD", "CSCRCD", JdeDataType.String, 6),
        new JdeField("CSQTYS", "CSQTYS", JdeDataType.Numeric),
        new JdeField("CSUORG", "CSUORG", JdeDataType.Numeric),
        new JdeField("CSSOQS", "CSSOQS", JdeDataType.Numeric),
        new JdeField("CSUPRC", "CSUPRC", JdeDataType.Numeric),
        new JdeField("CSAEXP", "CSAEXP", JdeDataType.Numeric),
        new JdeField("CSAST", "CSAST", JdeDataType.String, 16),
        new JdeField("CSI75TXTY", "CSI75TXTY", JdeDataType.String, 10),
        new JdeField("CSDSC1", "CSDSC1", JdeDataType.String, 60),
        new JdeField("CSIVD", "CSIVD", JdeDataType.Numeric),
        new JdeField("CSDGL", "CSDGL", JdeDataType.Numeric),
        new JdeField("CSTORG", "CSTORG", JdeDataType.String, 20),
        new JdeField("CSUSER", "CSUSER", JdeDataType.String, 20),
        new JdeField("CSJOBN", "CSJOBN", JdeDataType.String, 20),
        new JdeField("CSPID", "CSPID", JdeDataType.String, 20),
        new JdeField("CSUPMJ", "CSUPMJ", JdeDataType.Numeric),
        new JdeField("CSUPMT", "CSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I309_0", "Primary Key on CSI75RSCD, CSKCOO, CSDOCO, CSDCTO, CSLNID, CSMCU, CSLITM", new[] { "CSI75RSCD", "CSKCOO", "CSDOCO", "CSDCTO", "CSLNID", "CSMCU", "CSLITM" }, isUnique: true, isPrimaryKey: true)
    };
}
