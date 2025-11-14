using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1775 - .
/// </summary>
public class F1775 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TCDOCO.
        /// </summary>
        public const string TCDOCO = "TCDOCO";

        /// <summary>
        /// TCLNID.
        /// </summary>
        public const string TCLNID = "TCLNID";

        /// <summary>
        /// TCCLNTY.
        /// </summary>
        public const string TCCLNTY = "TCCLNTY";

        /// <summary>
        /// TCITM.
        /// </summary>
        public const string TCITM = "TCITM";

        /// <summary>
        /// TCDSC1.
        /// </summary>
        public const string TCDSC1 = "TCDSC1";

        /// <summary>
        /// TCVEND.
        /// </summary>
        public const string TCVEND = "TCVEND";

        /// <summary>
        /// TCD2J.
        /// </summary>
        public const string TCD2J = "TCD2J";

        /// <summary>
        /// TCDSC2.
        /// </summary>
        public const string TCDSC2 = "TCDSC2";

        /// <summary>
        /// TCFAILCD.
        /// </summary>
        public const string TCFAILCD = "TCFAILCD";

        /// <summary>
        /// TCCOST.
        /// </summary>
        public const string TCCOST = "TCCOST";

        /// <summary>
        /// TCCRCD.
        /// </summary>
        public const string TCCRCD = "TCCRCD";

        /// <summary>
        /// TCUORG.
        /// </summary>
        public const string TCUORG = "TCUORG";

        /// <summary>
        /// TCESUNP.
        /// </summary>
        public const string TCESUNP = "TCESUNP";

        /// <summary>
        /// TCEPAAP.
        /// </summary>
        public const string TCEPAAP = "TCEPAAP";

        /// <summary>
        /// TCTRQT.
        /// </summary>
        public const string TCTRQT = "TCTRQT";

        /// <summary>
        /// TCACUNP.
        /// </summary>
        public const string TCACUNP = "TCACUNP";

        /// <summary>
        /// TCPAAP.
        /// </summary>
        public const string TCPAAP = "TCPAAP";

        /// <summary>
        /// TCFESUNP.
        /// </summary>
        public const string TCFESUNP = "TCFESUNP";

        /// <summary>
        /// TCFEPAAP.
        /// </summary>
        public const string TCFEPAAP = "TCFEPAAP";

        /// <summary>
        /// TCFACUNP.
        /// </summary>
        public const string TCFACUNP = "TCFACUNP";

        /// <summary>
        /// TCFPAAP.
        /// </summary>
        public const string TCFPAAP = "TCFPAAP";

        /// <summary>
        /// TCDTSUB.
        /// </summary>
        public const string TCDTSUB = "TCDTSUB";

        /// <summary>
        /// TCTMSUB.
        /// </summary>
        public const string TCTMSUB = "TCTMSUB";

        /// <summary>
        /// TCDTPAY.
        /// </summary>
        public const string TCDTPAY = "TCDTPAY";

        /// <summary>
        /// TCUKID.
        /// </summary>
        public const string TCUKID = "TCUKID";

        /// <summary>
        /// TCMCU.
        /// </summary>
        public const string TCMCU = "TCMCU";

        /// <summary>
        /// TCMMCU.
        /// </summary>
        public const string TCMMCU = "TCMMCU";

        /// <summary>
        /// TCDCTO.
        /// </summary>
        public const string TCDCTO = "TCDCTO";

        /// <summary>
        /// TCOPSQ.
        /// </summary>
        public const string TCOPSQ = "TCOPSQ";

        /// <summary>
        /// TCTIMB.
        /// </summary>
        public const string TCTIMB = "TCTIMB";

        /// <summary>
        /// TCPAYAB.
        /// </summary>
        public const string TCPAYAB = "TCPAYAB";

        /// <summary>
        /// TCASN4.
        /// </summary>
        public const string TCASN4 = "TCASN4";

        /// <summary>
        /// TCPMTHP.
        /// </summary>
        public const string TCPMTHP = "TCPMTHP";

        /// <summary>
        /// TCCRR.
        /// </summary>
        public const string TCCRR = "TCCRR";

        /// <summary>
        /// TCCRDC.
        /// </summary>
        public const string TCCRDC = "TCCRDC";

        /// <summary>
        /// TCCRRM.
        /// </summary>
        public const string TCCRRM = "TCCRRM";
    }

    /// <inheritdoc />
    public override string TableName => "F1775";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TCDOCO", "TCDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("TCLNID", "TCLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("TCCLNTY", "TCCLNTY", JdeDataType.String, 4),
        new JdeField("TCITM", "TCITM", JdeDataType.Numeric),
        new JdeField("TCDSC1", "TCDSC1", JdeDataType.String, 60),
        new JdeField("TCVEND", "TCVEND", JdeDataType.Numeric),
        new JdeField("TCD2J", "TCD2J", JdeDataType.Numeric),
        new JdeField("TCDSC2", "TCDSC2", JdeDataType.String, 60),
        new JdeField("TCFAILCD", "TCFAILCD", JdeDataType.String, 16),
        new JdeField("TCCOST", "TCCOST", JdeDataType.String, 6),
        new JdeField("TCCRCD", "TCCRCD", JdeDataType.String, 6),
        new JdeField("TCUORG", "TCUORG", JdeDataType.Numeric),
        new JdeField("TCESUNP", "TCESUNP", JdeDataType.Numeric),
        new JdeField("TCEPAAP", "TCEPAAP", JdeDataType.Numeric),
        new JdeField("TCTRQT", "TCTRQT", JdeDataType.Numeric),
        new JdeField("TCACUNP", "TCACUNP", JdeDataType.Numeric),
        new JdeField("TCPAAP", "TCPAAP", JdeDataType.Numeric),
        new JdeField("TCFESUNP", "TCFESUNP", JdeDataType.Numeric),
        new JdeField("TCFEPAAP", "TCFEPAAP", JdeDataType.Numeric),
        new JdeField("TCFACUNP", "TCFACUNP", JdeDataType.Numeric),
        new JdeField("TCFPAAP", "TCFPAAP", JdeDataType.Numeric),
        new JdeField("TCDTSUB", "TCDTSUB", JdeDataType.Numeric),
        new JdeField("TCTMSUB", "TCTMSUB", JdeDataType.Numeric),
        new JdeField("TCDTPAY", "TCDTPAY", JdeDataType.Numeric),
        new JdeField("TCUKID", "TCUKID", JdeDataType.Numeric),
        new JdeField("TCMCU", "TCMCU", JdeDataType.String, 24),
        new JdeField("TCMMCU", "TCMMCU", JdeDataType.String, 24),
        new JdeField("TCDCTO", "TCDCTO", JdeDataType.String, 4),
        new JdeField("TCOPSQ", "TCOPSQ", JdeDataType.Numeric),
        new JdeField("TCTIMB", "TCTIMB", JdeDataType.String, 2),
        new JdeField("TCPAYAB", "TCPAYAB", JdeDataType.String, 2),
        new JdeField("TCASN4", "TCASN4", JdeDataType.String, 16),
        new JdeField("TCPMTHP", "TCPMTHP", JdeDataType.String, 2),
        new JdeField("TCCRR", "TCCRR", JdeDataType.Numeric),
        new JdeField("TCCRDC", "TCCRDC", JdeDataType.String, 6),
        new JdeField("TCCRRM", "TCCRRM", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1775_0", "Primary Key on TCDOCO, TCLNID", new[] { "TCDOCO", "TCLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
