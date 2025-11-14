using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F34X110W - .
/// </summary>
public class F34X110W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ILUSER.
        /// </summary>
        public const string ILUSER = "ILUSER";

        /// <summary>
        /// ILJOBS.
        /// </summary>
        public const string ILJOBS = "ILJOBS";

        /// <summary>
        /// ILITM.
        /// </summary>
        public const string ILITM = "ILITM";

        /// <summary>
        /// ILMCU.
        /// </summary>
        public const string ILMCU = "ILMCU";

        /// <summary>
        /// ILTFLA.
        /// </summary>
        public const string ILTFLA = "ILTFLA";

        /// <summary>
        /// ILSTDP.
        /// </summary>
        public const string ILSTDP = "ILSTDP";

        /// <summary>
        /// ILOT1Y.
        /// </summary>
        public const string ILOT1Y = "ILOT1Y";

        /// <summary>
        /// ILSTKT.
        /// </summary>
        public const string ILSTKT = "ILSTKT";

        /// <summary>
        /// ILUOM1.
        /// </summary>
        public const string ILUOM1 = "ILUOM1";

        /// <summary>
        /// ILANPL.
        /// </summary>
        public const string ILANPL = "ILANPL";

        /// <summary>
        /// ILSAFE.
        /// </summary>
        public const string ILSAFE = "ILSAFE";

        /// <summary>
        /// ILPNYN.
        /// </summary>
        public const string ILPNYN = "ILPNYN";

        /// <summary>
        /// ILMPSP.
        /// </summary>
        public const string ILMPSP = "ILMPSP";

        /// <summary>
        /// ILMTF1.
        /// </summary>
        public const string ILMTF1 = "ILMTF1";

        /// <summary>
        /// ILMTF2.
        /// </summary>
        public const string ILMTF2 = "ILMTF2";

        /// <summary>
        /// ILMTF3.
        /// </summary>
        public const string ILMTF3 = "ILMTF3";

        /// <summary>
        /// ILUOM2.
        /// </summary>
        public const string ILUOM2 = "ILUOM2";

        /// <summary>
        /// ILUOM3.
        /// </summary>
        public const string ILUOM3 = "ILUOM3";

        /// <summary>
        /// ILUOM4.
        /// </summary>
        public const string ILUOM4 = "ILUOM4";

        /// <summary>
        /// ILUOM6.
        /// </summary>
        public const string ILUOM6 = "ILUOM6";

        /// <summary>
        /// ILUOM8.
        /// </summary>
        public const string ILUOM8 = "ILUOM8";

        /// <summary>
        /// ILLEDD.
        /// </summary>
        public const string ILLEDD = "ILLEDD";

        /// <summary>
        /// ILPEFD.
        /// </summary>
        public const string ILPEFD = "ILPEFD";

        /// <summary>
        /// ILLTLV.
        /// </summary>
        public const string ILLTLV = "ILLTLV";

        /// <summary>
        /// ILLTPU.
        /// </summary>
        public const string ILLTPU = "ILLTPU";

        /// <summary>
        /// ILOPC.
        /// </summary>
        public const string ILOPC = "ILOPC";

        /// <summary>
        /// ILOPV.
        /// </summary>
        public const string ILOPV = "ILOPV";

        /// <summary>
        /// ILLTMF.
        /// </summary>
        public const string ILLTMF = "ILLTMF";

        /// <summary>
        /// ILLTCM.
        /// </summary>
        public const string ILLTCM = "ILLTCM";

        /// <summary>
        /// ILMRPP.
        /// </summary>
        public const string ILMRPP = "ILMRPP";

        /// <summary>
        /// IL34XMMSGS.
        /// </summary>
        public const string IL34XMMSGS = "IL34XMMSGS";

        /// <summary>
        /// ILUPMJ.
        /// </summary>
        public const string ILUPMJ = "ILUPMJ";

        /// <summary>
        /// IL34XCCMP.
        /// </summary>
        public const string IL34XCCMP = "IL34XCCMP";

        /// <summary>
        /// ILLBOM.
        /// </summary>
        public const string ILLBOM = "ILLBOM";

        /// <summary>
        /// IL34XWFL.
        /// </summary>
        public const string IL34XWFL = "IL34XWFL";
    }

    /// <inheritdoc />
    public override string TableName => "F34X110W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ILUSER", "ILUSER", JdeDataType.String, 20, true, true),
        new JdeField("ILJOBS", "ILJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("ILITM", "ILITM", JdeDataType.Numeric, null, true, true),
        new JdeField("ILMCU", "ILMCU", JdeDataType.String, 24, true, true),
        new JdeField("ILTFLA", "ILTFLA", JdeDataType.String, 4),
        new JdeField("ILSTDP", "ILSTDP", JdeDataType.Numeric),
        new JdeField("ILOT1Y", "ILOT1Y", JdeDataType.String, 2),
        new JdeField("ILSTKT", "ILSTKT", JdeDataType.String, 2),
        new JdeField("ILUOM1", "ILUOM1", JdeDataType.String, 4),
        new JdeField("ILANPL", "ILANPL", JdeDataType.Numeric),
        new JdeField("ILSAFE", "ILSAFE", JdeDataType.Numeric),
        new JdeField("ILPNYN", "ILPNYN", JdeDataType.String, 2),
        new JdeField("ILMPSP", "ILMPSP", JdeDataType.String, 2),
        new JdeField("ILMTF1", "ILMTF1", JdeDataType.Numeric),
        new JdeField("ILMTF2", "ILMTF2", JdeDataType.Numeric),
        new JdeField("ILMTF3", "ILMTF3", JdeDataType.Numeric),
        new JdeField("ILUOM2", "ILUOM2", JdeDataType.String, 4),
        new JdeField("ILUOM3", "ILUOM3", JdeDataType.String, 4),
        new JdeField("ILUOM4", "ILUOM4", JdeDataType.String, 4),
        new JdeField("ILUOM6", "ILUOM6", JdeDataType.String, 4),
        new JdeField("ILUOM8", "ILUOM8", JdeDataType.String, 4),
        new JdeField("ILLEDD", "ILLEDD", JdeDataType.Numeric),
        new JdeField("ILPEFD", "ILPEFD", JdeDataType.Numeric),
        new JdeField("ILLTLV", "ILLTLV", JdeDataType.Numeric),
        new JdeField("ILLTPU", "ILLTPU", JdeDataType.Numeric),
        new JdeField("ILOPC", "ILOPC", JdeDataType.String, 2),
        new JdeField("ILOPV", "ILOPV", JdeDataType.Numeric),
        new JdeField("ILLTMF", "ILLTMF", JdeDataType.Numeric),
        new JdeField("ILLTCM", "ILLTCM", JdeDataType.Numeric),
        new JdeField("ILMRPP", "ILMRPP", JdeDataType.String, 2),
        new JdeField("IL34XMMSGS", "IL34XMMSGS", JdeDataType.String, 2),
        new JdeField("ILUPMJ", "ILUPMJ", JdeDataType.Numeric),
        new JdeField("IL34XCCMP", "IL34XCCMP", JdeDataType.String, 2),
        new JdeField("ILLBOM", "ILLBOM", JdeDataType.Numeric),
        new JdeField("IL34XWFL", "IL34XWFL", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F34X110W_0", "Primary Key on ILUSER, ILJOBS, ILITM, ILMCU", new[] { "ILUSER", "ILJOBS", "ILITM", "ILMCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F34X110W_2", "Index on ILUSER, ILJOBS, ILUPMJ", new[] { "ILUSER", "ILJOBS", "ILUPMJ" })
    };
}
