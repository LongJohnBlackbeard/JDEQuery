using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I824 - .
/// </summary>
public class F75I824 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PCI75RSCD.
        /// </summary>
        public const string PCI75RSCD = "PCI75RSCD";

        /// <summary>
        /// PCDL01.
        /// </summary>
        public const string PCDL01 = "PCDL01";

        /// <summary>
        /// PCI75RMRK.
        /// </summary>
        public const string PCI75RMRK = "PCI75RMRK";

        /// <summary>
        /// PCKCOO.
        /// </summary>
        public const string PCKCOO = "PCKCOO";

        /// <summary>
        /// PCDOCO.
        /// </summary>
        public const string PCDOCO = "PCDOCO";

        /// <summary>
        /// PCDCTO.
        /// </summary>
        public const string PCDCTO = "PCDCTO";

        /// <summary>
        /// PCLNID.
        /// </summary>
        public const string PCLNID = "PCLNID";

        /// <summary>
        /// PCNLIN.
        /// </summary>
        public const string PCNLIN = "PCNLIN";

        /// <summary>
        /// PCMCU.
        /// </summary>
        public const string PCMCU = "PCMCU";

        /// <summary>
        /// PCLITM.
        /// </summary>
        public const string PCLITM = "PCLITM";

        /// <summary>
        /// PCITM.
        /// </summary>
        public const string PCITM = "PCITM";

        /// <summary>
        /// PCI75CNQY.
        /// </summary>
        public const string PCI75CNQY = "PCI75CNQY";

        /// <summary>
        /// PCI75CGSTA.
        /// </summary>
        public const string PCI75CGSTA = "PCI75CGSTA";

        /// <summary>
        /// PCI75SGSTA.
        /// </summary>
        public const string PCI75SGSTA = "PCI75SGSTA";

        /// <summary>
        /// PCI75IGSTA.
        /// </summary>
        public const string PCI75IGSTA = "PCI75IGSTA";

        /// <summary>
        /// PCYTDU.
        /// </summary>
        public const string PCYTDU = "PCYTDU";

        /// <summary>
        /// PCLOTN.
        /// </summary>
        public const string PCLOTN = "PCLOTN";

        /// <summary>
        /// PCLOCN.
        /// </summary>
        public const string PCLOCN = "PCLOCN";

        /// <summary>
        /// PCMATC.
        /// </summary>
        public const string PCMATC = "PCMATC";

        /// <summary>
        /// PCAN8.
        /// </summary>
        public const string PCAN8 = "PCAN8";

        /// <summary>
        /// PCUOM.
        /// </summary>
        public const string PCUOM = "PCUOM";

        /// <summary>
        /// PCBCRC.
        /// </summary>
        public const string PCBCRC = "PCBCRC";

        /// <summary>
        /// PCCRR.
        /// </summary>
        public const string PCCRR = "PCCRR";

        /// <summary>
        /// PCI75QTYS.
        /// </summary>
        public const string PCI75QTYS = "PCI75QTYS";

        /// <summary>
        /// PCDGL.
        /// </summary>
        public const string PCDGL = "PCDGL";

        /// <summary>
        /// PCI75PRFL.
        /// </summary>
        public const string PCI75PRFL = "PCI75PRFL";

        /// <summary>
        /// PCUSER.
        /// </summary>
        public const string PCUSER = "PCUSER";

        /// <summary>
        /// PCPID.
        /// </summary>
        public const string PCPID = "PCPID";

        /// <summary>
        /// PCJOBN.
        /// </summary>
        public const string PCJOBN = "PCJOBN";

        /// <summary>
        /// PCUPMJ.
        /// </summary>
        public const string PCUPMJ = "PCUPMJ";

        /// <summary>
        /// PCUPMT.
        /// </summary>
        public const string PCUPMT = "PCUPMT";

        /// <summary>
        /// PCYFUTDT1.
        /// </summary>
        public const string PCYFUTDT1 = "PCYFUTDT1";

        /// <summary>
        /// PCFUT6.
        /// </summary>
        public const string PCFUT6 = "PCFUT6";

        /// <summary>
        /// PCYT04.
        /// </summary>
        public const string PCYT04 = "PCYT04";

        /// <summary>
        /// PCYFLAG.
        /// </summary>
        public const string PCYFLAG = "PCYFLAG";

        /// <summary>
        /// PCYNUM1.
        /// </summary>
        public const string PCYNUM1 = "PCYNUM1";

        /// <summary>
        /// PCICU.
        /// </summary>
        public const string PCICU = "PCICU";

        /// <summary>
        /// PCICUT.
        /// </summary>
        public const string PCICUT = "PCICUT";

        /// <summary>
        /// PCI75CESSA.
        /// </summary>
        public const string PCI75CESSA = "PCI75CESSA";

        /// <summary>
        /// PCI75ATX1A.
        /// </summary>
        public const string PCI75ATX1A = "PCI75ATX1A";

        /// <summary>
        /// PCI75ATX2A.
        /// </summary>
        public const string PCI75ATX2A = "PCI75ATX2A";

        /// <summary>
        /// PCI75ATX3A.
        /// </summary>
        public const string PCI75ATX3A = "PCI75ATX3A";

        /// <summary>
        /// PCI75AT4A.
        /// </summary>
        public const string PCI75AT4A = "PCI75AT4A";
    }

    /// <inheritdoc />
    public override string TableName => "F75I824";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PCI75RSCD", "PCI75RSCD", JdeDataType.String, 10, true, true),
        new JdeField("PCDL01", "PCDL01", JdeDataType.String, 60),
        new JdeField("PCI75RMRK", "PCI75RMRK", JdeDataType.String, 120),
        new JdeField("PCKCOO", "PCKCOO", JdeDataType.String, 10, true, true),
        new JdeField("PCDOCO", "PCDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PCDCTO", "PCDCTO", JdeDataType.String, 4, true, true),
        new JdeField("PCLNID", "PCLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PCNLIN", "PCNLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("PCMCU", "PCMCU", JdeDataType.String, 24),
        new JdeField("PCLITM", "PCLITM", JdeDataType.String, 50),
        new JdeField("PCITM", "PCITM", JdeDataType.Numeric),
        new JdeField("PCI75CNQY", "PCI75CNQY", JdeDataType.Numeric),
        new JdeField("PCI75CGSTA", "PCI75CGSTA", JdeDataType.Numeric),
        new JdeField("PCI75SGSTA", "PCI75SGSTA", JdeDataType.Numeric),
        new JdeField("PCI75IGSTA", "PCI75IGSTA", JdeDataType.Numeric),
        new JdeField("PCYTDU", "PCYTDU", JdeDataType.Numeric),
        new JdeField("PCLOTN", "PCLOTN", JdeDataType.String, 60),
        new JdeField("PCLOCN", "PCLOCN", JdeDataType.String, 40),
        new JdeField("PCMATC", "PCMATC", JdeDataType.String, 2),
        new JdeField("PCAN8", "PCAN8", JdeDataType.Numeric),
        new JdeField("PCUOM", "PCUOM", JdeDataType.String, 4),
        new JdeField("PCBCRC", "PCBCRC", JdeDataType.String, 6),
        new JdeField("PCCRR", "PCCRR", JdeDataType.Numeric),
        new JdeField("PCI75QTYS", "PCI75QTYS", JdeDataType.Numeric),
        new JdeField("PCDGL", "PCDGL", JdeDataType.Numeric),
        new JdeField("PCI75PRFL", "PCI75PRFL", JdeDataType.String, 2),
        new JdeField("PCUSER", "PCUSER", JdeDataType.String, 20),
        new JdeField("PCPID", "PCPID", JdeDataType.String, 20),
        new JdeField("PCJOBN", "PCJOBN", JdeDataType.String, 20),
        new JdeField("PCUPMJ", "PCUPMJ", JdeDataType.Numeric),
        new JdeField("PCUPMT", "PCUPMT", JdeDataType.Numeric),
        new JdeField("PCYFUTDT1", "PCYFUTDT1", JdeDataType.Numeric),
        new JdeField("PCFUT6", "PCFUT6", JdeDataType.String, 60),
        new JdeField("PCYT04", "PCYT04", JdeDataType.String, 2),
        new JdeField("PCYFLAG", "PCYFLAG", JdeDataType.String, 2),
        new JdeField("PCYNUM1", "PCYNUM1", JdeDataType.Numeric),
        new JdeField("PCICU", "PCICU", JdeDataType.Numeric),
        new JdeField("PCICUT", "PCICUT", JdeDataType.String, 4),
        new JdeField("PCI75CESSA", "PCI75CESSA", JdeDataType.Numeric),
        new JdeField("PCI75ATX1A", "PCI75ATX1A", JdeDataType.Numeric),
        new JdeField("PCI75ATX2A", "PCI75ATX2A", JdeDataType.Numeric),
        new JdeField("PCI75ATX3A", "PCI75ATX3A", JdeDataType.Numeric),
        new JdeField("PCI75AT4A", "PCI75AT4A", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I824_0", "Primary Key on PCI75RSCD, PCKCOO, PCDOCO, PCDCTO, PCLNID, PCNLIN", new[] { "PCI75RSCD", "PCKCOO", "PCDOCO", "PCDCTO", "PCLNID", "PCNLIN" }, isUnique: true, isPrimaryKey: true)
    };
}
