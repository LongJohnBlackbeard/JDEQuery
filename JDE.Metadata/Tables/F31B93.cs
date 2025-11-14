using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B93 - .
/// </summary>
public class F31B93 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WHMCU.
        /// </summary>
        public const string WHMCU = "WHMCU";

        /// <summary>
        /// WHWDOCO.
        /// </summary>
        public const string WHWDOCO = "WHWDOCO";

        /// <summary>
        /// WHWAWON.
        /// </summary>
        public const string WHWAWON = "WHWAWON";

        /// <summary>
        /// WHWODSC.
        /// </summary>
        public const string WHWODSC = "WHWODSC";

        /// <summary>
        /// WHWWOT.
        /// </summary>
        public const string WHWWOT = "WHWWOT";

        /// <summary>
        /// WHWCRTR.
        /// </summary>
        public const string WHWCRTR = "WHWCRTR";

        /// <summary>
        /// WHWODC.
        /// </summary>
        public const string WHWODC = "WHWODC";

        /// <summary>
        /// WHWODR.
        /// </summary>
        public const string WHWODR = "WHWODR";

        /// <summary>
        /// WHWWOST.
        /// </summary>
        public const string WHWWOST = "WHWWOST";

        /// <summary>
        /// WHWWOH1.
        /// </summary>
        public const string WHWWOH1 = "WHWWOH1";

        /// <summary>
        /// WHWWOH2.
        /// </summary>
        public const string WHWWOH2 = "WHWWOH2";

        /// <summary>
        /// WHWWOH3.
        /// </summary>
        public const string WHWWOH3 = "WHWWOH3";

        /// <summary>
        /// WHWWOH4.
        /// </summary>
        public const string WHWWOH4 = "WHWWOH4";

        /// <summary>
        /// WHWWOH5.
        /// </summary>
        public const string WHWWOH5 = "WHWWOH5";

        /// <summary>
        /// WHWTI.
        /// </summary>
        public const string WHWTI = "WHWTI";

        /// <summary>
        /// WHWOTN.
        /// </summary>
        public const string WHWOTN = "WHWOTN";

        /// <summary>
        /// WHWOTT.
        /// </summary>
        public const string WHWOTT = "WHWOTT";

        /// <summary>
        /// WHWOTS.
        /// </summary>
        public const string WHWOTS = "WHWOTS";

        /// <summary>
        /// WHBMEFFF.
        /// </summary>
        public const string WHBMEFFF = "WHBMEFFF";

        /// <summary>
        /// WHBMEFFT.
        /// </summary>
        public const string WHBMEFFT = "WHBMEFFT";

        /// <summary>
        /// WHWHAR.
        /// </summary>
        public const string WHWHAR = "WHWHAR";

        /// <summary>
        /// WHURAB.
        /// </summary>
        public const string WHURAB = "WHURAB";

        /// <summary>
        /// WHURAT.
        /// </summary>
        public const string WHURAT = "WHURAT";

        /// <summary>
        /// WHURCD.
        /// </summary>
        public const string WHURCD = "WHURCD";

        /// <summary>
        /// WHURDT.
        /// </summary>
        public const string WHURDT = "WHURDT";

        /// <summary>
        /// WHURRF.
        /// </summary>
        public const string WHURRF = "WHURRF";

        /// <summary>
        /// WHWMDT.
        /// </summary>
        public const string WHWMDT = "WHWMDT";

        /// <summary>
        /// WHWNUM.
        /// </summary>
        public const string WHWNUM = "WHWNUM";

        /// <summary>
        /// WHWAB.
        /// </summary>
        public const string WHWAB = "WHWAB";

        /// <summary>
        /// WHWCD.
        /// </summary>
        public const string WHWCD = "WHWCD";

        /// <summary>
        /// WHWRF.
        /// </summary>
        public const string WHWRF = "WHWRF";

        /// <summary>
        /// WHUSER.
        /// </summary>
        public const string WHUSER = "WHUSER";

        /// <summary>
        /// WHUPMJ.
        /// </summary>
        public const string WHUPMJ = "WHUPMJ";

        /// <summary>
        /// WHUPMT.
        /// </summary>
        public const string WHUPMT = "WHUPMT";

        /// <summary>
        /// WHJOBN.
        /// </summary>
        public const string WHJOBN = "WHJOBN";

        /// <summary>
        /// WHMKEY.
        /// </summary>
        public const string WHMKEY = "WHMKEY";

        /// <summary>
        /// WHPID.
        /// </summary>
        public const string WHPID = "WHPID";

        /// <summary>
        /// WHWJOBS.
        /// </summary>
        public const string WHWJOBS = "WHWJOBS";
    }

    /// <inheritdoc />
    public override string TableName => "F31B93";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WHMCU", "WHMCU", JdeDataType.String, 24, true, true),
        new JdeField("WHWDOCO", "WHWDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("WHWAWON", "WHWAWON", JdeDataType.String, 40),
        new JdeField("WHWODSC", "WHWODSC", JdeDataType.String, 60),
        new JdeField("WHWWOT", "WHWWOT", JdeDataType.String, 6),
        new JdeField("WHWCRTR", "WHWCRTR", JdeDataType.Numeric),
        new JdeField("WHWODC", "WHWODC", JdeDataType.Numeric),
        new JdeField("WHWODR", "WHWODR", JdeDataType.Numeric),
        new JdeField("WHWWOST", "WHWWOST", JdeDataType.String, 20),
        new JdeField("WHWWOH1", "WHWWOH1", JdeDataType.String, 20),
        new JdeField("WHWWOH2", "WHWWOH2", JdeDataType.String, 20),
        new JdeField("WHWWOH3", "WHWWOH3", JdeDataType.String, 20),
        new JdeField("WHWWOH4", "WHWWOH4", JdeDataType.String, 20),
        new JdeField("WHWWOH5", "WHWWOH5", JdeDataType.String, 20),
        new JdeField("WHWTI", "WHWTI", JdeDataType.String, 2),
        new JdeField("WHWOTN", "WHWOTN", JdeDataType.String, 40),
        new JdeField("WHWOTT", "WHWOTT", JdeDataType.String, 2),
        new JdeField("WHWOTS", "WHWOTS", JdeDataType.String, 2),
        new JdeField("WHBMEFFF", "WHBMEFFF", JdeDataType.Numeric),
        new JdeField("WHBMEFFT", "WHBMEFFT", JdeDataType.Numeric),
        new JdeField("WHWHAR", "WHWHAR", JdeDataType.String, 2),
        new JdeField("WHURAB", "WHURAB", JdeDataType.Numeric),
        new JdeField("WHURAT", "WHURAT", JdeDataType.Numeric),
        new JdeField("WHURCD", "WHURCD", JdeDataType.String, 4),
        new JdeField("WHURDT", "WHURDT", JdeDataType.Numeric),
        new JdeField("WHURRF", "WHURRF", JdeDataType.String, 30),
        new JdeField("WHWMDT", "WHWMDT", JdeDataType.Numeric),
        new JdeField("WHWNUM", "WHWNUM", JdeDataType.Numeric),
        new JdeField("WHWAB", "WHWAB", JdeDataType.Numeric),
        new JdeField("WHWCD", "WHWCD", JdeDataType.String, 6),
        new JdeField("WHWRF", "WHWRF", JdeDataType.String, 60),
        new JdeField("WHUSER", "WHUSER", JdeDataType.String, 20),
        new JdeField("WHUPMJ", "WHUPMJ", JdeDataType.Numeric),
        new JdeField("WHUPMT", "WHUPMT", JdeDataType.Numeric),
        new JdeField("WHJOBN", "WHJOBN", JdeDataType.String, 20),
        new JdeField("WHMKEY", "WHMKEY", JdeDataType.String, 30),
        new JdeField("WHPID", "WHPID", JdeDataType.String, 20),
        new JdeField("WHWJOBS", "WHWJOBS", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B93_0", "Primary Key on WHMCU, WHWDOCO", new[] { "WHMCU", "WHWDOCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B93_2", "Index on WHMCU, WHWAWON", new[] { "WHMCU", "WHWAWON" }),
        new JdeIndex("F31B93_3", "Index on WHWOTN, WHWOTT, WHWOTS", new[] { "WHWOTN", "WHWOTT", "WHWOTS" })
    };
}
