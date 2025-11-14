using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0411 - .
/// </summary>
public class F76B0411 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VBKCO.
        /// </summary>
        public const string VBKCO = "VBKCO";

        /// <summary>
        /// VBDOC.
        /// </summary>
        public const string VBDOC = "VBDOC";

        /// <summary>
        /// VBDCT.
        /// </summary>
        public const string VBDCT = "VBDCT";

        /// <summary>
        /// VBSFX.
        /// </summary>
        public const string VBSFX = "VBSFX";

        /// <summary>
        /// VBSFXE.
        /// </summary>
        public const string VBSFXE = "VBSFXE";

        /// <summary>
        /// VBAN8.
        /// </summary>
        public const string VBAN8 = "VBAN8";

        /// <summary>
        /// VBDDJ.
        /// </summary>
        public const string VBDDJ = "VBDDJ";

        /// <summary>
        /// VBDGJ.
        /// </summary>
        public const string VBDGJ = "VBDGJ";

        /// <summary>
        /// VBPN.
        /// </summary>
        public const string VBPN = "VBPN";

        /// <summary>
        /// VBFY.
        /// </summary>
        public const string VBFY = "VBFY";

        /// <summary>
        /// VBBRTXTT.
        /// </summary>
        public const string VBBRTXTT = "VBBRTXTT";

        /// <summary>
        /// VBBRRD.
        /// </summary>
        public const string VBBRRD = "VBBRRD";

        /// <summary>
        /// VBBRALQ.
        /// </summary>
        public const string VBBRALQ = "VBBRALQ";

        /// <summary>
        /// VBAAP.
        /// </summary>
        public const string VBAAP = "VBAAP";

        /// <summary>
        /// VBAA.
        /// </summary>
        public const string VBAA = "VBAA";

        /// <summary>
        /// VBBRAAD.
        /// </summary>
        public const string VBBRAAD = "VBBRAAD";

        /// <summary>
        /// VBMCU.
        /// </summary>
        public const string VBMCU = "VBMCU";

        /// <summary>
        /// VBGLC.
        /// </summary>
        public const string VBGLC = "VBGLC";

        /// <summary>
        /// VBAN8J.
        /// </summary>
        public const string VBAN8J = "VBAN8J";

        /// <summary>
        /// VBBRRCT.
        /// </summary>
        public const string VBBRRCT = "VBBRRCT";

        /// <summary>
        /// VBBRISS.
        /// </summary>
        public const string VBBRISS = "VBBRISS";

        /// <summary>
        /// VBBRINSS.
        /// </summary>
        public const string VBBRINSS = "VBBRINSS";

        /// <summary>
        /// VBBRTXTP.
        /// </summary>
        public const string VBBRTXTP = "VBBRTXTP";

        /// <summary>
        /// VBODCT.
        /// </summary>
        public const string VBODCT = "VBODCT";

        /// <summary>
        /// VBODOC.
        /// </summary>
        public const string VBODOC = "VBODOC";

        /// <summary>
        /// VBVINV.
        /// </summary>
        public const string VBVINV = "VBVINV";

        /// <summary>
        /// VBTAX.
        /// </summary>
        public const string VBTAX = "VBTAX";

        /// <summary>
        /// VBUSER.
        /// </summary>
        public const string VBUSER = "VBUSER";

        /// <summary>
        /// VBPID.
        /// </summary>
        public const string VBPID = "VBPID";

        /// <summary>
        /// VBJOBN.
        /// </summary>
        public const string VBJOBN = "VBJOBN";

        /// <summary>
        /// VBUPMJ.
        /// </summary>
        public const string VBUPMJ = "VBUPMJ";

        /// <summary>
        /// VBUPMT.
        /// </summary>
        public const string VBUPMT = "VBUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B0411";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VBKCO", "VBKCO", JdeDataType.String, 10, true, true),
        new JdeField("VBDOC", "VBDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("VBDCT", "VBDCT", JdeDataType.String, 4, true, true),
        new JdeField("VBSFX", "VBSFX", JdeDataType.String, 6, true, true),
        new JdeField("VBSFXE", "VBSFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("VBAN8", "VBAN8", JdeDataType.Numeric),
        new JdeField("VBDDJ", "VBDDJ", JdeDataType.Numeric),
        new JdeField("VBDGJ", "VBDGJ", JdeDataType.Numeric),
        new JdeField("VBPN", "VBPN", JdeDataType.Numeric),
        new JdeField("VBFY", "VBFY", JdeDataType.Numeric),
        new JdeField("VBBRTXTT", "VBBRTXTT", JdeDataType.Numeric),
        new JdeField("VBBRRD", "VBBRRD", JdeDataType.Numeric),
        new JdeField("VBBRALQ", "VBBRALQ", JdeDataType.Numeric),
        new JdeField("VBAAP", "VBAAP", JdeDataType.Numeric),
        new JdeField("VBAA", "VBAA", JdeDataType.Numeric),
        new JdeField("VBBRAAD", "VBBRAAD", JdeDataType.Numeric),
        new JdeField("VBMCU", "VBMCU", JdeDataType.String, 24),
        new JdeField("VBGLC", "VBGLC", JdeDataType.String, 8),
        new JdeField("VBAN8J", "VBAN8J", JdeDataType.Numeric),
        new JdeField("VBBRRCT", "VBBRRCT", JdeDataType.Numeric),
        new JdeField("VBBRISS", "VBBRISS", JdeDataType.Numeric),
        new JdeField("VBBRINSS", "VBBRINSS", JdeDataType.Numeric),
        new JdeField("VBBRTXTP", "VBBRTXTP", JdeDataType.String, 4),
        new JdeField("VBODCT", "VBODCT", JdeDataType.String, 4),
        new JdeField("VBODOC", "VBODOC", JdeDataType.Numeric),
        new JdeField("VBVINV", "VBVINV", JdeDataType.String, 50),
        new JdeField("VBTAX", "VBTAX", JdeDataType.String, 40),
        new JdeField("VBUSER", "VBUSER", JdeDataType.String, 20),
        new JdeField("VBPID", "VBPID", JdeDataType.String, 20),
        new JdeField("VBJOBN", "VBJOBN", JdeDataType.String, 20),
        new JdeField("VBUPMJ", "VBUPMJ", JdeDataType.Numeric),
        new JdeField("VBUPMT", "VBUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0411_0", "Primary Key on VBDOC, VBKCO, VBDCT, VBSFX, VBSFXE", new[] { "VBDOC", "VBKCO", "VBDCT", "VBSFX", "VBSFXE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B0411_2", "Index on VBAN8, VBFY, VBPN, VBTAX", new[] { "VBAN8", "VBFY", "VBPN", "VBTAX" })
    };
}
