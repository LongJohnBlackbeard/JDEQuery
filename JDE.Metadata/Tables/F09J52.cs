using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09J52 - .
/// </summary>
public class F09J52 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OSJVOVN.
        /// </summary>
        public const string OSJVOVN = "OSJVOVN";

        /// <summary>
        /// OSJVOM.
        /// </summary>
        public const string OSJVOM = "OSJVOM";

        /// <summary>
        /// OSJVLNID.
        /// </summary>
        public const string OSJVLNID = "OSJVLNID";

        /// <summary>
        /// OSJVSTLN.
        /// </summary>
        public const string OSJVSTLN = "OSJVSTLN";

        /// <summary>
        /// OSJVSTFRM.
        /// </summary>
        public const string OSJVSTFRM = "OSJVSTFRM";

        /// <summary>
        /// OSJVBUSTS.
        /// </summary>
        public const string OSJVBUSTS = "OSJVBUSTS";

        /// <summary>
        /// OSJVADR.
        /// </summary>
        public const string OSJVADR = "OSJVADR";

        /// <summary>
        /// OSJVNOCP.
        /// </summary>
        public const string OSJVNOCP = "OSJVNOCP";

        /// <summary>
        /// OSCRCD.
        /// </summary>
        public const string OSCRCD = "OSCRCD";

        /// <summary>
        /// OSTORG.
        /// </summary>
        public const string OSTORG = "OSTORG";

        /// <summary>
        /// OSENTJ.
        /// </summary>
        public const string OSENTJ = "OSENTJ";

        /// <summary>
        /// OSUSER.
        /// </summary>
        public const string OSUSER = "OSUSER";

        /// <summary>
        /// OSUPMT.
        /// </summary>
        public const string OSUPMT = "OSUPMT";

        /// <summary>
        /// OSUPMJ.
        /// </summary>
        public const string OSUPMJ = "OSUPMJ";

        /// <summary>
        /// OSPID.
        /// </summary>
        public const string OSPID = "OSPID";

        /// <summary>
        /// OSMKEY.
        /// </summary>
        public const string OSMKEY = "OSMKEY";

        /// <summary>
        /// OSJVENU1.
        /// </summary>
        public const string OSJVENU1 = "OSJVENU1";

        /// <summary>
        /// OSJVENU2.
        /// </summary>
        public const string OSJVENU2 = "OSJVENU2";

        /// <summary>
        /// OSJVENU3.
        /// </summary>
        public const string OSJVENU3 = "OSJVENU3";

        /// <summary>
        /// OSJVEST1.
        /// </summary>
        public const string OSJVEST1 = "OSJVEST1";

        /// <summary>
        /// OSJVEST2.
        /// </summary>
        public const string OSJVEST2 = "OSJVEST2";

        /// <summary>
        /// OSJVEST3.
        /// </summary>
        public const string OSJVEST3 = "OSJVEST3";

        /// <summary>
        /// OSJVECH1.
        /// </summary>
        public const string OSJVECH1 = "OSJVECH1";

        /// <summary>
        /// OSJVECH2.
        /// </summary>
        public const string OSJVECH2 = "OSJVECH2";

        /// <summary>
        /// OSJVECH3.
        /// </summary>
        public const string OSJVECH3 = "OSJVECH3";

        /// <summary>
        /// OSJVEDT1.
        /// </summary>
        public const string OSJVEDT1 = "OSJVEDT1";

        /// <summary>
        /// OSJVEDT2.
        /// </summary>
        public const string OSJVEDT2 = "OSJVEDT2";

        /// <summary>
        /// OSJVEDT3.
        /// </summary>
        public const string OSJVEDT3 = "OSJVEDT3";

        /// <summary>
        /// OSURATD01.
        /// </summary>
        public const string OSURATD01 = "OSURATD01";

        /// <summary>
        /// OSURATD02.
        /// </summary>
        public const string OSURATD02 = "OSURATD02";

        /// <summary>
        /// OSURATD03.
        /// </summary>
        public const string OSURATD03 = "OSURATD03";

        /// <summary>
        /// OSURATD04.
        /// </summary>
        public const string OSURATD04 = "OSURATD04";

        /// <summary>
        /// OSURATD05.
        /// </summary>
        public const string OSURATD05 = "OSURATD05";

        /// <summary>
        /// OSURCDD01.
        /// </summary>
        public const string OSURCDD01 = "OSURCDD01";

        /// <summary>
        /// OSURCDD02.
        /// </summary>
        public const string OSURCDD02 = "OSURCDD02";

        /// <summary>
        /// OSURCDD03.
        /// </summary>
        public const string OSURCDD03 = "OSURCDD03";

        /// <summary>
        /// OSURCDD04.
        /// </summary>
        public const string OSURCDD04 = "OSURCDD04";

        /// <summary>
        /// OSURCDD05.
        /// </summary>
        public const string OSURCDD05 = "OSURCDD05";

        /// <summary>
        /// OSURDTD01.
        /// </summary>
        public const string OSURDTD01 = "OSURDTD01";

        /// <summary>
        /// OSURDTD02.
        /// </summary>
        public const string OSURDTD02 = "OSURDTD02";

        /// <summary>
        /// OSURDTD03.
        /// </summary>
        public const string OSURDTD03 = "OSURDTD03";

        /// <summary>
        /// OSURDTD04.
        /// </summary>
        public const string OSURDTD04 = "OSURDTD04";

        /// <summary>
        /// OSURDTD05.
        /// </summary>
        public const string OSURDTD05 = "OSURDTD05";

        /// <summary>
        /// OSURNUMD01.
        /// </summary>
        public const string OSURNUMD01 = "OSURNUMD01";

        /// <summary>
        /// OSURNUMD02.
        /// </summary>
        public const string OSURNUMD02 = "OSURNUMD02";

        /// <summary>
        /// OSURNUMD03.
        /// </summary>
        public const string OSURNUMD03 = "OSURNUMD03";

        /// <summary>
        /// OSURNUMD04.
        /// </summary>
        public const string OSURNUMD04 = "OSURNUMD04";

        /// <summary>
        /// OSURNUMD05.
        /// </summary>
        public const string OSURNUMD05 = "OSURNUMD05";

        /// <summary>
        /// OSURRFD01.
        /// </summary>
        public const string OSURRFD01 = "OSURRFD01";

        /// <summary>
        /// OSURRFD02.
        /// </summary>
        public const string OSURRFD02 = "OSURRFD02";

        /// <summary>
        /// OSURRFD03.
        /// </summary>
        public const string OSURRFD03 = "OSURRFD03";

        /// <summary>
        /// OSURRFD04.
        /// </summary>
        public const string OSURRFD04 = "OSURRFD04";

        /// <summary>
        /// OSURRFD05.
        /// </summary>
        public const string OSURRFD05 = "OSURRFD05";

        /// <summary>
        /// OSURSTD01.
        /// </summary>
        public const string OSURSTD01 = "OSURSTD01";

        /// <summary>
        /// OSURSTD02.
        /// </summary>
        public const string OSURSTD02 = "OSURSTD02";

        /// <summary>
        /// OSURSTD03.
        /// </summary>
        public const string OSURSTD03 = "OSURSTD03";

        /// <summary>
        /// OSURSTD04.
        /// </summary>
        public const string OSURSTD04 = "OSURSTD04";

        /// <summary>
        /// OSURSTD05.
        /// </summary>
        public const string OSURSTD05 = "OSURSTD05";
    }

    /// <inheritdoc />
    public override string TableName => "F09J52";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OSJVOVN", "OSJVOVN", JdeDataType.String, 40, true, true),
        new JdeField("OSJVOM", "OSJVOM", JdeDataType.String, 4, true, true),
        new JdeField("OSJVLNID", "OSJVLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("OSJVSTLN", "OSJVSTLN", JdeDataType.Numeric, null, true, true),
        new JdeField("OSJVSTFRM", "OSJVSTFRM", JdeDataType.String, 2),
        new JdeField("OSJVBUSTS", "OSJVBUSTS", JdeDataType.String, 6),
        new JdeField("OSJVADR", "OSJVADR", JdeDataType.Numeric),
        new JdeField("OSJVNOCP", "OSJVNOCP", JdeDataType.Numeric),
        new JdeField("OSCRCD", "OSCRCD", JdeDataType.String, 6),
        new JdeField("OSTORG", "OSTORG", JdeDataType.String, 20),
        new JdeField("OSENTJ", "OSENTJ", JdeDataType.Numeric),
        new JdeField("OSUSER", "OSUSER", JdeDataType.String, 20),
        new JdeField("OSUPMT", "OSUPMT", JdeDataType.Numeric),
        new JdeField("OSUPMJ", "OSUPMJ", JdeDataType.Numeric),
        new JdeField("OSPID", "OSPID", JdeDataType.String, 20),
        new JdeField("OSMKEY", "OSMKEY", JdeDataType.String, 30),
        new JdeField("OSJVENU1", "OSJVENU1", JdeDataType.Numeric),
        new JdeField("OSJVENU2", "OSJVENU2", JdeDataType.Numeric),
        new JdeField("OSJVENU3", "OSJVENU3", JdeDataType.Numeric),
        new JdeField("OSJVEST1", "OSJVEST1", JdeDataType.String, 160),
        new JdeField("OSJVEST2", "OSJVEST2", JdeDataType.String, 160),
        new JdeField("OSJVEST3", "OSJVEST3", JdeDataType.String, 160),
        new JdeField("OSJVECH1", "OSJVECH1", JdeDataType.String, 2),
        new JdeField("OSJVECH2", "OSJVECH2", JdeDataType.String, 2),
        new JdeField("OSJVECH3", "OSJVECH3", JdeDataType.String, 2),
        new JdeField("OSJVEDT1", "OSJVEDT1", JdeDataType.Numeric),
        new JdeField("OSJVEDT2", "OSJVEDT2", JdeDataType.Numeric),
        new JdeField("OSJVEDT3", "OSJVEDT3", JdeDataType.Numeric),
        new JdeField("OSURATD01", "OSURATD01", JdeDataType.Numeric),
        new JdeField("OSURATD02", "OSURATD02", JdeDataType.Numeric),
        new JdeField("OSURATD03", "OSURATD03", JdeDataType.Numeric),
        new JdeField("OSURATD04", "OSURATD04", JdeDataType.Numeric),
        new JdeField("OSURATD05", "OSURATD05", JdeDataType.Numeric),
        new JdeField("OSURCDD01", "OSURCDD01", JdeDataType.String, 20),
        new JdeField("OSURCDD02", "OSURCDD02", JdeDataType.String, 20),
        new JdeField("OSURCDD03", "OSURCDD03", JdeDataType.String, 20),
        new JdeField("OSURCDD04", "OSURCDD04", JdeDataType.String, 20),
        new JdeField("OSURCDD05", "OSURCDD05", JdeDataType.String, 20),
        new JdeField("OSURDTD01", "OSURDTD01", JdeDataType.Numeric),
        new JdeField("OSURDTD02", "OSURDTD02", JdeDataType.Numeric),
        new JdeField("OSURDTD03", "OSURDTD03", JdeDataType.Numeric),
        new JdeField("OSURDTD04", "OSURDTD04", JdeDataType.Numeric),
        new JdeField("OSURDTD05", "OSURDTD05", JdeDataType.Numeric),
        new JdeField("OSURNUMD01", "OSURNUMD01", JdeDataType.Numeric),
        new JdeField("OSURNUMD02", "OSURNUMD02", JdeDataType.Numeric),
        new JdeField("OSURNUMD03", "OSURNUMD03", JdeDataType.Numeric),
        new JdeField("OSURNUMD04", "OSURNUMD04", JdeDataType.Numeric),
        new JdeField("OSURNUMD05", "OSURNUMD05", JdeDataType.Numeric),
        new JdeField("OSURRFD01", "OSURRFD01", JdeDataType.String, 30),
        new JdeField("OSURRFD02", "OSURRFD02", JdeDataType.String, 30),
        new JdeField("OSURRFD03", "OSURRFD03", JdeDataType.String, 30),
        new JdeField("OSURRFD04", "OSURRFD04", JdeDataType.String, 30),
        new JdeField("OSURRFD05", "OSURRFD05", JdeDataType.String, 30),
        new JdeField("OSURSTD01", "OSURSTD01", JdeDataType.String, 160),
        new JdeField("OSURSTD02", "OSURSTD02", JdeDataType.String, 160),
        new JdeField("OSURSTD03", "OSURSTD03", JdeDataType.String, 160),
        new JdeField("OSURSTD04", "OSURSTD04", JdeDataType.String, 160),
        new JdeField("OSURSTD05", "OSURSTD05", JdeDataType.String, 160)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09J52_0", "Primary Key on OSJVOVN, OSJVOM, OSJVLNID, OSJVSTLN", new[] { "OSJVOVN", "OSJVOM", "OSJVLNID", "OSJVSTLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09J52_2", "Index on OSJVOVN, OSJVOM, OSJVLNID", new[] { "OSJVOVN", "OSJVOM", "OSJVLNID" }),
        new JdeIndex("F09J52_3", "Index on OSJVOVN, OSJVOM, OSJVLNID, OSJVBUSTS", new[] { "OSJVOVN", "OSJVOM", "OSJVLNID", "OSJVBUSTS" })
    };
}
