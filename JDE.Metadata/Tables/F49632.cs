using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49632 - .
/// </summary>
public class F49632 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LBVMCU.
        /// </summary>
        public const string LBVMCU = "LBVMCU";

        /// <summary>
        /// LBLDNM.
        /// </summary>
        public const string LBLDNM = "LBLDNM";

        /// <summary>
        /// LBSHPN.
        /// </summary>
        public const string LBSHPN = "LBSHPN";

        /// <summary>
        /// LBITM.
        /// </summary>
        public const string LBITM = "LBITM";

        /// <summary>
        /// LBLOTN.
        /// </summary>
        public const string LBLOTN = "LBLOTN";

        /// <summary>
        /// LBAN8.
        /// </summary>
        public const string LBAN8 = "LBAN8";

        /// <summary>
        /// LBVEHI.
        /// </summary>
        public const string LBVEHI = "LBVEHI";

        /// <summary>
        /// LBRLNO.
        /// </summary>
        public const string LBRLNO = "LBRLNO";

        /// <summary>
        /// LBCMPN.
        /// </summary>
        public const string LBCMPN = "LBCMPN";

        /// <summary>
        /// LBLCMP.
        /// </summary>
        public const string LBLCMP = "LBLCMP";

        /// <summary>
        /// LBOSEQ.
        /// </summary>
        public const string LBOSEQ = "LBOSEQ";

        /// <summary>
        /// LBQTYL.
        /// </summary>
        public const string LBQTYL = "LBQTYL";

        /// <summary>
        /// LBUOM1.
        /// </summary>
        public const string LBUOM1 = "LBUOM1";

        /// <summary>
        /// LBACLQ.
        /// </summary>
        public const string LBACLQ = "LBACLQ";

        /// <summary>
        /// LBTRUM.
        /// </summary>
        public const string LBTRUM = "LBTRUM";

        /// <summary>
        /// LBECST.
        /// </summary>
        public const string LBECST = "LBECST";

        /// <summary>
        /// LBMCU.
        /// </summary>
        public const string LBMCU = "LBMCU";

        /// <summary>
        /// LBAMBR.
        /// </summary>
        public const string LBAMBR = "LBAMBR";

        /// <summary>
        /// LBBUM3.
        /// </summary>
        public const string LBBUM3 = "LBBUM3";

        /// <summary>
        /// LBSTOK.
        /// </summary>
        public const string LBSTOK = "LBSTOK";

        /// <summary>
        /// LBBUM4.
        /// </summary>
        public const string LBBUM4 = "LBBUM4";

        /// <summary>
        /// LBWGTR.
        /// </summary>
        public const string LBWGTR = "LBWGTR";

        /// <summary>
        /// LBBUM5.
        /// </summary>
        public const string LBBUM5 = "LBBUM5";

        /// <summary>
        /// LBVCF.
        /// </summary>
        public const string LBVCF = "LBVCF";

        /// <summary>
        /// LBTEMP.
        /// </summary>
        public const string LBTEMP = "LBTEMP";

        /// <summary>
        /// LBSTPU.
        /// </summary>
        public const string LBSTPU = "LBSTPU";

        /// <summary>
        /// LBDEND.
        /// </summary>
        public const string LBDEND = "LBDEND";

        /// <summary>
        /// LBDNTP.
        /// </summary>
        public const string LBDNTP = "LBDNTP";

        /// <summary>
        /// LBDETP.
        /// </summary>
        public const string LBDETP = "LBDETP";

        /// <summary>
        /// LBDTPU.
        /// </summary>
        public const string LBDTPU = "LBDTPU";

        /// <summary>
        /// LBURCD.
        /// </summary>
        public const string LBURCD = "LBURCD";

        /// <summary>
        /// LBURDT.
        /// </summary>
        public const string LBURDT = "LBURDT";

        /// <summary>
        /// LBURAT.
        /// </summary>
        public const string LBURAT = "LBURAT";

        /// <summary>
        /// LBURAB.
        /// </summary>
        public const string LBURAB = "LBURAB";

        /// <summary>
        /// LBURRF.
        /// </summary>
        public const string LBURRF = "LBURRF";

        /// <summary>
        /// LBUSER.
        /// </summary>
        public const string LBUSER = "LBUSER";

        /// <summary>
        /// LBPID.
        /// </summary>
        public const string LBPID = "LBPID";

        /// <summary>
        /// LBJOBN.
        /// </summary>
        public const string LBJOBN = "LBJOBN";

        /// <summary>
        /// LBUPMJ.
        /// </summary>
        public const string LBUPMJ = "LBUPMJ";

        /// <summary>
        /// LBTDAY.
        /// </summary>
        public const string LBTDAY = "LBTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F49632";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LBVMCU", "LBVMCU", JdeDataType.String, 24, true, true),
        new JdeField("LBLDNM", "LBLDNM", JdeDataType.Numeric, null, true, true),
        new JdeField("LBSHPN", "LBSHPN", JdeDataType.Numeric, null, true, true),
        new JdeField("LBITM", "LBITM", JdeDataType.Numeric, null, true, true),
        new JdeField("LBLOTN", "LBLOTN", JdeDataType.String, 60, true, true),
        new JdeField("LBAN8", "LBAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("LBVEHI", "LBVEHI", JdeDataType.String, 24, true, true),
        new JdeField("LBRLNO", "LBRLNO", JdeDataType.String, 26, true, true),
        new JdeField("LBCMPN", "LBCMPN", JdeDataType.Numeric, null, true, true),
        new JdeField("LBLCMP", "LBLCMP", JdeDataType.Numeric),
        new JdeField("LBOSEQ", "LBOSEQ", JdeDataType.Numeric),
        new JdeField("LBQTYL", "LBQTYL", JdeDataType.Numeric),
        new JdeField("LBUOM1", "LBUOM1", JdeDataType.String, 4),
        new JdeField("LBACLQ", "LBACLQ", JdeDataType.Numeric),
        new JdeField("LBTRUM", "LBTRUM", JdeDataType.String, 4),
        new JdeField("LBECST", "LBECST", JdeDataType.Numeric),
        new JdeField("LBMCU", "LBMCU", JdeDataType.String, 24),
        new JdeField("LBAMBR", "LBAMBR", JdeDataType.Numeric),
        new JdeField("LBBUM3", "LBBUM3", JdeDataType.String, 4),
        new JdeField("LBSTOK", "LBSTOK", JdeDataType.Numeric),
        new JdeField("LBBUM4", "LBBUM4", JdeDataType.String, 4),
        new JdeField("LBWGTR", "LBWGTR", JdeDataType.Numeric),
        new JdeField("LBBUM5", "LBBUM5", JdeDataType.String, 4),
        new JdeField("LBVCF", "LBVCF", JdeDataType.Numeric),
        new JdeField("LBTEMP", "LBTEMP", JdeDataType.Numeric),
        new JdeField("LBSTPU", "LBSTPU", JdeDataType.String, 2),
        new JdeField("LBDEND", "LBDEND", JdeDataType.Numeric),
        new JdeField("LBDNTP", "LBDNTP", JdeDataType.String, 2),
        new JdeField("LBDETP", "LBDETP", JdeDataType.Numeric),
        new JdeField("LBDTPU", "LBDTPU", JdeDataType.String, 2),
        new JdeField("LBURCD", "LBURCD", JdeDataType.String, 4),
        new JdeField("LBURDT", "LBURDT", JdeDataType.Numeric),
        new JdeField("LBURAT", "LBURAT", JdeDataType.Numeric),
        new JdeField("LBURAB", "LBURAB", JdeDataType.Numeric),
        new JdeField("LBURRF", "LBURRF", JdeDataType.String, 30),
        new JdeField("LBUSER", "LBUSER", JdeDataType.String, 20),
        new JdeField("LBPID", "LBPID", JdeDataType.String, 20),
        new JdeField("LBJOBN", "LBJOBN", JdeDataType.String, 20),
        new JdeField("LBUPMJ", "LBUPMJ", JdeDataType.Numeric),
        new JdeField("LBTDAY", "LBTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49632_0", "Primary Key on LBVMCU, LBLDNM, LBSHPN, LBITM, LBLOTN, LBAN8, LBVEHI, LBRLNO, LBCMPN", new[] { "LBVMCU", "LBLDNM", "LBSHPN", "LBITM", "LBLOTN", "LBAN8", "LBVEHI", "LBRLNO", "LBCMPN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F49632_2", "Index on LBVMCU, LBLDNM, LBSHPN, LBVEHI, LBRLNO, LBCMPN, LBITM, LBLOTN, LBAN8", new[] { "LBVMCU", "LBLDNM", "LBSHPN", "LBVEHI", "LBRLNO", "LBCMPN", "LBITM", "LBLOTN", "LBAN8" }),
        new JdeIndex("F49632_3", "Index on LBVMCU, LBLDNM, LBSHPN, LBITM, LBLOTN, LBAN8, LBLCMP", new[] { "LBVMCU", "LBLDNM", "LBSHPN", "LBITM", "LBLOTN", "LBAN8", "LBLCMP" })
    };
}
