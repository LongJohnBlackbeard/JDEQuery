using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07822 - .
/// </summary>
public class F07822 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JIIDYE.
        /// </summary>
        public const string JIIDYE = "JIIDYE";

        /// <summary>
        /// JIDTEY.
        /// </summary>
        public const string JIDTEY = "JIDTEY";

        /// <summary>
        /// JIHMCO.
        /// </summary>
        public const string JIHMCO = "JIHMCO";

        /// <summary>
        /// JITAXX.
        /// </summary>
        public const string JITAXX = "JITAXX";

        /// <summary>
        /// JIOTAX.
        /// </summary>
        public const string JIOTAX = "JIOTAX";

        /// <summary>
        /// JIW2RT.
        /// </summary>
        public const string JIW2RT = "JIW2RT";

        /// <summary>
        /// JITFYE.
        /// </summary>
        public const string JITFYE = "JITFYE";

        /// <summary>
        /// JITWYE.
        /// </summary>
        public const string JITWYE = "JITWYE";

        /// <summary>
        /// JIDTCF.
        /// </summary>
        public const string JIDTCF = "JIDTCF";

        /// <summary>
        /// JIETAX.
        /// </summary>
        public const string JIETAX = "JIETAX";

        /// <summary>
        /// JIHMCU.
        /// </summary>
        public const string JIHMCU = "JIHMCU";

        /// <summary>
        /// JIALTP.
        /// </summary>
        public const string JIALTP = "JIALTP";

        /// <summary>
        /// JIEARN.
        /// </summary>
        public const string JIEARN = "JIEARN";

        /// <summary>
        /// JIFDWG.
        /// </summary>
        public const string JIFDWG = "JIFDWG";

        /// <summary>
        /// JIFDAJ.
        /// </summary>
        public const string JIFDAJ = "JIFDAJ";

        /// <summary>
        /// JIFDTX.
        /// </summary>
        public const string JIFDTX = "JIFDTX";

        /// <summary>
        /// JIOAWG.
        /// </summary>
        public const string JIOAWG = "JIOAWG";

        /// <summary>
        /// JIOAAJ.
        /// </summary>
        public const string JIOAAJ = "JIOAAJ";

        /// <summary>
        /// JIOATX.
        /// </summary>
        public const string JIOATX = "JIOATX";

        /// <summary>
        /// JIMCWG.
        /// </summary>
        public const string JIMCWG = "JIMCWG";

        /// <summary>
        /// JIMCAJ.
        /// </summary>
        public const string JIMCAJ = "JIMCAJ";

        /// <summary>
        /// JIMCT.
        /// </summary>
        public const string JIMCT = "JIMCT";

        /// <summary>
        /// JIOATP.
        /// </summary>
        public const string JIOATP = "JIOATP";

        /// <summary>
        /// JIBX16.
        /// </summary>
        public const string JIBX16 = "JIBX16";

        /// <summary>
        /// JIBX17.
        /// </summary>
        public const string JIBX17 = "JIBX17";

        /// <summary>
        /// JIBX18.
        /// </summary>
        public const string JIBX18 = "JIBX18";

        /// <summary>
        /// JIBX20.
        /// </summary>
        public const string JIBX20 = "JIBX20";

        /// <summary>
        /// JIBX21.
        /// </summary>
        public const string JIBX21 = "JIBX21";

        /// <summary>
        /// JIBX22.
        /// </summary>
        public const string JIBX22 = "JIBX22";

        /// <summary>
        /// JIBX23.
        /// </summary>
        public const string JIBX23 = "JIBX23";

        /// <summary>
        /// JITX3S.
        /// </summary>
        public const string JITX3S = "JITX3S";

        /// <summary>
        /// JIFW96.
        /// </summary>
        public const string JIFW96 = "JIFW96";

        /// <summary>
        /// JIAR96.
        /// </summary>
        public const string JIAR96 = "JIAR96";

        /// <summary>
        /// JISW96.
        /// </summary>
        public const string JISW96 = "JISW96";

        /// <summary>
        /// JILW96.
        /// </summary>
        public const string JILW96 = "JILW96";

        /// <summary>
        /// JIFBAM.
        /// </summary>
        public const string JIFBAM = "JIFBAM";

        /// <summary>
        /// JIDFCP.
        /// </summary>
        public const string JIDFCP = "JIDFCP";

        /// <summary>
        /// JINQN4.
        /// </summary>
        public const string JINQN4 = "JINQN4";

        /// <summary>
        /// JIDEPC.
        /// </summary>
        public const string JIDEPC = "JIDEPC";

        /// <summary>
        /// JIGTLA.
        /// </summary>
        public const string JIGTLA = "JIGTLA";

        /// <summary>
        /// JINC1W.
        /// </summary>
        public const string JINC1W = "JINC1W";

        /// <summary>
        /// JINC1T.
        /// </summary>
        public const string JINC1T = "JINC1T";

        /// <summary>
        /// JINC2W.
        /// </summary>
        public const string JINC2W = "JINC2W";

        /// <summary>
        /// JINC2T.
        /// </summary>
        public const string JINC2T = "JINC2T";

        /// <summary>
        /// JINC16.
        /// </summary>
        public const string JINC16 = "JINC16";

        /// <summary>
        /// JINC17.
        /// </summary>
        public const string JINC17 = "JINC17";

        /// <summary>
        /// JIUPMJ.
        /// </summary>
        public const string JIUPMJ = "JIUPMJ";

        /// <summary>
        /// JIUPMT.
        /// </summary>
        public const string JIUPMT = "JIUPMT";

        /// <summary>
        /// JIPID.
        /// </summary>
        public const string JIPID = "JIPID";

        /// <summary>
        /// JIJOBN.
        /// </summary>
        public const string JIJOBN = "JIJOBN";

        /// <summary>
        /// JIUSER.
        /// </summary>
        public const string JIUSER = "JIUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F07822";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JIIDYE", "JIIDYE", JdeDataType.String, 20, true, true),
        new JdeField("JIDTEY", "JIDTEY", JdeDataType.Numeric, null, true, true),
        new JdeField("JIHMCO", "JIHMCO", JdeDataType.String, 10, true, true),
        new JdeField("JITAXX", "JITAXX", JdeDataType.String, 40, true, true),
        new JdeField("JIOTAX", "JIOTAX", JdeDataType.String, 40),
        new JdeField("JIW2RT", "JIW2RT", JdeDataType.String, 2, true, true),
        new JdeField("JITFYE", "JITFYE", JdeDataType.String, 2, true, true),
        new JdeField("JITWYE", "JITWYE", JdeDataType.String, 2, true, true),
        new JdeField("JIDTCF", "JIDTCF", JdeDataType.Numeric, null, true, true),
        new JdeField("JIETAX", "JIETAX", JdeDataType.String, 40),
        new JdeField("JIHMCU", "JIHMCU", JdeDataType.String, 24),
        new JdeField("JIALTP", "JIALTP", JdeDataType.Numeric),
        new JdeField("JIEARN", "JIEARN", JdeDataType.Numeric),
        new JdeField("JIFDWG", "JIFDWG", JdeDataType.Numeric),
        new JdeField("JIFDAJ", "JIFDAJ", JdeDataType.Numeric),
        new JdeField("JIFDTX", "JIFDTX", JdeDataType.Numeric),
        new JdeField("JIOAWG", "JIOAWG", JdeDataType.Numeric),
        new JdeField("JIOAAJ", "JIOAAJ", JdeDataType.Numeric),
        new JdeField("JIOATX", "JIOATX", JdeDataType.Numeric),
        new JdeField("JIMCWG", "JIMCWG", JdeDataType.Numeric),
        new JdeField("JIMCAJ", "JIMCAJ", JdeDataType.Numeric),
        new JdeField("JIMCT", "JIMCT", JdeDataType.Numeric),
        new JdeField("JIOATP", "JIOATP", JdeDataType.Numeric),
        new JdeField("JIBX16", "JIBX16", JdeDataType.Numeric),
        new JdeField("JIBX17", "JIBX17", JdeDataType.Numeric),
        new JdeField("JIBX18", "JIBX18", JdeDataType.Numeric),
        new JdeField("JIBX20", "JIBX20", JdeDataType.Numeric),
        new JdeField("JIBX21", "JIBX21", JdeDataType.Numeric),
        new JdeField("JIBX22", "JIBX22", JdeDataType.Numeric),
        new JdeField("JIBX23", "JIBX23", JdeDataType.Numeric),
        new JdeField("JITX3S", "JITX3S", JdeDataType.Numeric),
        new JdeField("JIFW96", "JIFW96", JdeDataType.Numeric),
        new JdeField("JIAR96", "JIAR96", JdeDataType.Numeric),
        new JdeField("JISW96", "JISW96", JdeDataType.Numeric),
        new JdeField("JILW96", "JILW96", JdeDataType.Numeric),
        new JdeField("JIFBAM", "JIFBAM", JdeDataType.Numeric),
        new JdeField("JIDFCP", "JIDFCP", JdeDataType.Numeric),
        new JdeField("JINQN4", "JINQN4", JdeDataType.Numeric),
        new JdeField("JIDEPC", "JIDEPC", JdeDataType.Numeric),
        new JdeField("JIGTLA", "JIGTLA", JdeDataType.Numeric),
        new JdeField("JINC1W", "JINC1W", JdeDataType.Numeric),
        new JdeField("JINC1T", "JINC1T", JdeDataType.Numeric),
        new JdeField("JINC2W", "JINC2W", JdeDataType.Numeric),
        new JdeField("JINC2T", "JINC2T", JdeDataType.Numeric),
        new JdeField("JINC16", "JINC16", JdeDataType.Numeric),
        new JdeField("JINC17", "JINC17", JdeDataType.Numeric),
        new JdeField("JIUPMJ", "JIUPMJ", JdeDataType.Numeric),
        new JdeField("JIUPMT", "JIUPMT", JdeDataType.Numeric),
        new JdeField("JIPID", "JIPID", JdeDataType.String, 20),
        new JdeField("JIJOBN", "JIJOBN", JdeDataType.String, 20),
        new JdeField("JIUSER", "JIUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07822_0", "Primary Key on JIIDYE, JIDTEY, JITAXX, JIHMCO, JITFYE, JITWYE, JIDTCF, JIW2RT", new[] { "JIIDYE", "JIDTEY", "JITAXX", "JIHMCO", "JITFYE", "JITWYE", "JIDTCF", "JIW2RT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F07822_2", "Index on JIIDYE, JIDTEY, JIHMCO", new[] { "JIIDYE", "JIDTEY", "JIHMCO" })
    };
}
