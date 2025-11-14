using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B3010 - .
/// </summary>
public class F76B3010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IPKIT.
        /// </summary>
        public const string IPKIT = "IPKIT";

        /// <summary>
        /// IPKITL.
        /// </summary>
        public const string IPKITL = "IPKITL";

        /// <summary>
        /// IPMMCU.
        /// </summary>
        public const string IPMMCU = "IPMMCU";

        /// <summary>
        /// IPRITM.
        /// </summary>
        public const string IPRITM = "IPRITM";

        /// <summary>
        /// IPUOM.
        /// </summary>
        public const string IPUOM = "IPUOM";

        /// <summary>
        /// IPITM.
        /// </summary>
        public const string IPITM = "IPITM";

        /// <summary>
        /// IPLITM.
        /// </summary>
        public const string IPLITM = "IPLITM";

        /// <summary>
        /// IPCMCU.
        /// </summary>
        public const string IPCMCU = "IPCMCU";

        /// <summary>
        /// IPUM.
        /// </summary>
        public const string IPUM = "IPUM";

        /// <summary>
        /// IPQNTY.
        /// </summary>
        public const string IPQNTY = "IPQNTY";

        /// <summary>
        /// IPSCRP.
        /// </summary>
        public const string IPSCRP = "IPSCRP";

        /// <summary>
        /// IPEFFF.
        /// </summary>
        public const string IPEFFF = "IPEFFF";

        /// <summary>
        /// IPEFFT.
        /// </summary>
        public const string IPEFFT = "IPEFFT";

        /// <summary>
        /// IPTBM.
        /// </summary>
        public const string IPTBM = "IPTBM";

        /// <summary>
        /// IPBQTY.
        /// </summary>
        public const string IPBQTY = "IPBQTY";

        /// <summary>
        /// IPOPSQ.
        /// </summary>
        public const string IPOPSQ = "IPOPSQ";

        /// <summary>
        /// IPCOBY.
        /// </summary>
        public const string IPCOBY = "IPCOBY";

        /// <summary>
        /// IPCPNB.
        /// </summary>
        public const string IPCPNB = "IPCPNB";

        /// <summary>
        /// IPRDOR.
        /// </summary>
        public const string IPRDOR = "IPRDOR";

        /// <summary>
        /// IPUSER.
        /// </summary>
        public const string IPUSER = "IPUSER";

        /// <summary>
        /// IPPID.
        /// </summary>
        public const string IPPID = "IPPID";

        /// <summary>
        /// IPJOBN.
        /// </summary>
        public const string IPJOBN = "IPJOBN";

        /// <summary>
        /// IPUPMJ.
        /// </summary>
        public const string IPUPMJ = "IPUPMJ";

        /// <summary>
        /// IPUPMT.
        /// </summary>
        public const string IPUPMT = "IPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B3010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IPKIT", "IPKIT", JdeDataType.Numeric, null, true, true),
        new JdeField("IPKITL", "IPKITL", JdeDataType.String, 50),
        new JdeField("IPMMCU", "IPMMCU", JdeDataType.String, 24, true, true),
        new JdeField("IPRITM", "IPRITM", JdeDataType.Numeric),
        new JdeField("IPUOM", "IPUOM", JdeDataType.String, 4),
        new JdeField("IPITM", "IPITM", JdeDataType.Numeric, null, true, true),
        new JdeField("IPLITM", "IPLITM", JdeDataType.String, 50),
        new JdeField("IPCMCU", "IPCMCU", JdeDataType.String, 24, true, true),
        new JdeField("IPUM", "IPUM", JdeDataType.String, 4),
        new JdeField("IPQNTY", "IPQNTY", JdeDataType.Numeric),
        new JdeField("IPSCRP", "IPSCRP", JdeDataType.Numeric),
        new JdeField("IPEFFF", "IPEFFF", JdeDataType.Numeric),
        new JdeField("IPEFFT", "IPEFFT", JdeDataType.Numeric),
        new JdeField("IPTBM", "IPTBM", JdeDataType.String, 6, true, true),
        new JdeField("IPBQTY", "IPBQTY", JdeDataType.Numeric, null, true, true),
        new JdeField("IPOPSQ", "IPOPSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("IPCOBY", "IPCOBY", JdeDataType.String, 2),
        new JdeField("IPCPNB", "IPCPNB", JdeDataType.Numeric, null, true, true),
        new JdeField("IPRDOR", "IPRDOR", JdeDataType.String, 2),
        new JdeField("IPUSER", "IPUSER", JdeDataType.String, 20),
        new JdeField("IPPID", "IPPID", JdeDataType.String, 20),
        new JdeField("IPJOBN", "IPJOBN", JdeDataType.String, 20),
        new JdeField("IPUPMJ", "IPUPMJ", JdeDataType.Numeric),
        new JdeField("IPUPMT", "IPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B3010_0", "Primary Key on IPKIT, IPMMCU, IPTBM, IPBQTY, IPOPSQ, IPCPNB, IPITM, IPCMCU", new[] { "IPKIT", "IPMMCU", "IPTBM", "IPBQTY", "IPOPSQ", "IPCPNB", "IPITM", "IPCMCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B3010_2", "Index on IPKIT, IPMMCU, IPITM, IPCMCU, IPTBM, IPCPNB", new[] { "IPKIT", "IPMMCU", "IPITM", "IPCMCU", "IPTBM", "IPCPNB" })
    };
}
