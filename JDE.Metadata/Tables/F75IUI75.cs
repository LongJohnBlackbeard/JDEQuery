using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75IUI75 - .
/// </summary>
public class F75IUI75 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TIMATC.
        /// </summary>
        public const string TIMATC = "TIMATC";

        /// <summary>
        /// TIDOCO.
        /// </summary>
        public const string TIDOCO = "TIDOCO";

        /// <summary>
        /// TIDCTO.
        /// </summary>
        public const string TIDCTO = "TIDCTO";

        /// <summary>
        /// TIKCOO.
        /// </summary>
        public const string TIKCOO = "TIKCOO";

        /// <summary>
        /// TISFXO.
        /// </summary>
        public const string TISFXO = "TISFXO";

        /// <summary>
        /// TILNID.
        /// </summary>
        public const string TILNID = "TILNID";

        /// <summary>
        /// TINLIN.
        /// </summary>
        public const string TINLIN = "TINLIN";

        /// <summary>
        /// TIJOBS.
        /// </summary>
        public const string TIJOBS = "TIJOBS";

        /// <summary>
        /// TIUSER.
        /// </summary>
        public const string TIUSER = "TIUSER";

        /// <summary>
        /// TISEQ.
        /// </summary>
        public const string TISEQ = "TISEQ";

        /// <summary>
        /// TITYC.
        /// </summary>
        public const string TITYC = "TITYC";

        /// <summary>
        /// TICRCD.
        /// </summary>
        public const string TICRCD = "TICRCD";

        /// <summary>
        /// TIAN8.
        /// </summary>
        public const string TIAN8 = "TIAN8";

        /// <summary>
        /// TILVLA.
        /// </summary>
        public const string TILVLA = "TILVLA";

        /// <summary>
        /// TII75TXTY.
        /// </summary>
        public const string TII75TXTY = "TII75TXTY";

        /// <summary>
        /// TIATXA.
        /// </summary>
        public const string TIATXA = "TIATXA";

        /// <summary>
        /// TII75GSTRA.
        /// </summary>
        public const string TII75GSTRA = "TII75GSTRA";

        /// <summary>
        /// TII75GSTR.
        /// </summary>
        public const string TII75GSTR = "TII75GSTR";

        /// <summary>
        /// TISTAM.
        /// </summary>
        public const string TISTAM = "TISTAM";

        /// <summary>
        /// TIUORGE1.
        /// </summary>
        public const string TIUORGE1 = "TIUORGE1";

        /// <summary>
        /// TIUPAX.
        /// </summary>
        public const string TIUPAX = "TIUPAX";

        /// <summary>
        /// TII75FRC.
        /// </summary>
        public const string TII75FRC = "TII75FRC";

        /// <summary>
        /// TII75PSP.
        /// </summary>
        public const string TII75PSP = "TII75PSP";

        /// <summary>
        /// TII75PSR.
        /// </summary>
        public const string TII75PSR = "TII75PSR";

        /// <summary>
        /// TII75RECVL.
        /// </summary>
        public const string TII75RECVL = "TII75RECVL";

        /// <summary>
        /// TII75PROVL.
        /// </summary>
        public const string TII75PROVL = "TII75PROVL";

        /// <summary>
        /// TIPID.
        /// </summary>
        public const string TIPID = "TIPID";

        /// <summary>
        /// TIJOBN.
        /// </summary>
        public const string TIJOBN = "TIJOBN";

        /// <summary>
        /// TIUPMJ.
        /// </summary>
        public const string TIUPMJ = "TIUPMJ";

        /// <summary>
        /// TIUPMT.
        /// </summary>
        public const string TIUPMT = "TIUPMT";

        /// <summary>
        /// TIYFUTDT1.
        /// </summary>
        public const string TIYFUTDT1 = "TIYFUTDT1";

        /// <summary>
        /// TIFUT6.
        /// </summary>
        public const string TIFUT6 = "TIFUT6";

        /// <summary>
        /// TIYT04.
        /// </summary>
        public const string TIYT04 = "TIYT04";

        /// <summary>
        /// TIYFLAG.
        /// </summary>
        public const string TIYFLAG = "TIYFLAG";

        /// <summary>
        /// TIYNUM1.
        /// </summary>
        public const string TIYNUM1 = "TIYNUM1";

        /// <summary>
        /// TIUITM.
        /// </summary>
        public const string TIUITM = "TIUITM";

        /// <summary>
        /// TIUORG.
        /// </summary>
        public const string TIUORG = "TIUORG";

        /// <summary>
        /// TIUOM.
        /// </summary>
        public const string TIUOM = "TIUOM";

        /// <summary>
        /// TIRMK.
        /// </summary>
        public const string TIRMK = "TIRMK";

        /// <summary>
        /// TII75IPOS.
        /// </summary>
        public const string TII75IPOS = "TII75IPOS";

        /// <summary>
        /// TII75TRCAT.
        /// </summary>
        public const string TII75TRCAT = "TII75TRCAT";
    }

    /// <inheritdoc />
    public override string TableName => "F75IUI75";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TIMATC", "TIMATC", JdeDataType.String, 2, true, true),
        new JdeField("TIDOCO", "TIDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("TIDCTO", "TIDCTO", JdeDataType.String, 4, true, true),
        new JdeField("TIKCOO", "TIKCOO", JdeDataType.String, 10, true, true),
        new JdeField("TISFXO", "TISFXO", JdeDataType.String, 6, true, true),
        new JdeField("TILNID", "TILNID", JdeDataType.Numeric, null, true, true),
        new JdeField("TINLIN", "TINLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("TIJOBS", "TIJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("TIUSER", "TIUSER", JdeDataType.String, 20, true, true),
        new JdeField("TISEQ", "TISEQ", JdeDataType.Numeric),
        new JdeField("TITYC", "TITYC", JdeDataType.String, 2),
        new JdeField("TICRCD", "TICRCD", JdeDataType.String, 6),
        new JdeField("TIAN8", "TIAN8", JdeDataType.Numeric),
        new JdeField("TILVLA", "TILVLA", JdeDataType.String, 6),
        new JdeField("TII75TXTY", "TII75TXTY", JdeDataType.String, 10),
        new JdeField("TIATXA", "TIATXA", JdeDataType.Numeric),
        new JdeField("TII75GSTRA", "TII75GSTRA", JdeDataType.String, 4),
        new JdeField("TII75GSTR", "TII75GSTR", JdeDataType.Numeric),
        new JdeField("TISTAM", "TISTAM", JdeDataType.Numeric),
        new JdeField("TIUORGE1", "TIUORGE1", JdeDataType.Numeric),
        new JdeField("TIUPAX", "TIUPAX", JdeDataType.Numeric),
        new JdeField("TII75FRC", "TII75FRC", JdeDataType.String, 2),
        new JdeField("TII75PSP", "TII75PSP", JdeDataType.Numeric),
        new JdeField("TII75PSR", "TII75PSR", JdeDataType.Numeric),
        new JdeField("TII75RECVL", "TII75RECVL", JdeDataType.Numeric),
        new JdeField("TII75PROVL", "TII75PROVL", JdeDataType.Numeric),
        new JdeField("TIPID", "TIPID", JdeDataType.String, 20),
        new JdeField("TIJOBN", "TIJOBN", JdeDataType.String, 20),
        new JdeField("TIUPMJ", "TIUPMJ", JdeDataType.Numeric),
        new JdeField("TIUPMT", "TIUPMT", JdeDataType.Numeric),
        new JdeField("TIYFUTDT1", "TIYFUTDT1", JdeDataType.Numeric),
        new JdeField("TIFUT6", "TIFUT6", JdeDataType.String, 60),
        new JdeField("TIYT04", "TIYT04", JdeDataType.String, 2),
        new JdeField("TIYFLAG", "TIYFLAG", JdeDataType.String, 2),
        new JdeField("TIYNUM1", "TIYNUM1", JdeDataType.Numeric),
        new JdeField("TIUITM", "TIUITM", JdeDataType.String, 52),
        new JdeField("TIUORG", "TIUORG", JdeDataType.Numeric),
        new JdeField("TIUOM", "TIUOM", JdeDataType.String, 4),
        new JdeField("TIRMK", "TIRMK", JdeDataType.String, 60),
        new JdeField("TII75IPOS", "TII75IPOS", JdeDataType.String, 4),
        new JdeField("TII75TRCAT", "TII75TRCAT", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75IUI75_0", "Primary Key on TIMATC, TIDOCO, TIDCTO, TIKCOO, TISFXO, TILNID, TINLIN, TIJOBS, TIUSER", new[] { "TIMATC", "TIDOCO", "TIDCTO", "TIKCOO", "TISFXO", "TILNID", "TINLIN", "TIJOBS", "TIUSER" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75IUI75_2", "Index on TIMATC, TIDOCO, TIDCTO, TIKCOO, TISFXO, TILNID, TINLIN, TIUSER", new[] { "TIMATC", "TIDOCO", "TIDCTO", "TIKCOO", "TISFXO", "TILNID", "TINLIN", "TIUSER" })
    };
}
