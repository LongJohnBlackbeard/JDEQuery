using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09J40 - .
/// </summary>
public class F09J40 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JKJVCCID.
        /// </summary>
        public const string JKJVCCID = "JKJVCCID";

        /// <summary>
        /// JKJVAN8.
        /// </summary>
        public const string JKJVAN8 = "JKJVAN8";

        /// <summary>
        /// JKJVIBU.
        /// </summary>
        public const string JKJVIBU = "JKJVIBU";

        /// <summary>
        /// JKJVNAME.
        /// </summary>
        public const string JKJVNAME = "JKJVNAME";

        /// <summary>
        /// JKEFTB.
        /// </summary>
        public const string JKEFTB = "JKEFTB";

        /// <summary>
        /// JKMCUS.
        /// </summary>
        public const string JKMCUS = "JKMCUS";

        /// <summary>
        /// JKMCU.
        /// </summary>
        public const string JKMCU = "JKMCU";

        /// <summary>
        /// JKJVAGN.
        /// </summary>
        public const string JKJVAGN = "JKJVAGN";

        /// <summary>
        /// JKJVCCDS.
        /// </summary>
        public const string JKJVCCDS = "JKJVCCDS";

        /// <summary>
        /// JKJVCCST.
        /// </summary>
        public const string JKJVCCST = "JKJVCCST";

        /// <summary>
        /// JKJVMCO.
        /// </summary>
        public const string JKJVMCO = "JKJVMCO";

        /// <summary>
        /// JKCCE.
        /// </summary>
        public const string JKCCE = "JKCCE";

        /// <summary>
        /// JKCCOR.
        /// </summary>
        public const string JKCCOR = "JKCCOR";

        /// <summary>
        /// JKCCOP.
        /// </summary>
        public const string JKCCOP = "JKCCOP";

        /// <summary>
        /// JKCCCRC.
        /// </summary>
        public const string JKCCCRC = "JKCCCRC";

        /// <summary>
        /// JKCCCDT.
        /// </summary>
        public const string JKCCCDT = "JKCCCDT";

        /// <summary>
        /// JKJVCCTI.
        /// </summary>
        public const string JKJVCCTI = "JKJVCCTI";

        /// <summary>
        /// JKURAB.
        /// </summary>
        public const string JKURAB = "JKURAB";

        /// <summary>
        /// JKURCD.
        /// </summary>
        public const string JKURCD = "JKURCD";

        /// <summary>
        /// JKURAT.
        /// </summary>
        public const string JKURAT = "JKURAT";

        /// <summary>
        /// JKURDT.
        /// </summary>
        public const string JKURDT = "JKURDT";

        /// <summary>
        /// JKURRF.
        /// </summary>
        public const string JKURRF = "JKURRF";

        /// <summary>
        /// JKJVCMNU1.
        /// </summary>
        public const string JKJVCMNU1 = "JKJVCMNU1";

        /// <summary>
        /// JKJVCMNU2.
        /// </summary>
        public const string JKJVCMNU2 = "JKJVCMNU2";

        /// <summary>
        /// JKJVCMNU3.
        /// </summary>
        public const string JKJVCMNU3 = "JKJVCMNU3";

        /// <summary>
        /// JKJVCMST1.
        /// </summary>
        public const string JKJVCMST1 = "JKJVCMST1";

        /// <summary>
        /// JKJVCMST2.
        /// </summary>
        public const string JKJVCMST2 = "JKJVCMST2";

        /// <summary>
        /// JKJVCMST3.
        /// </summary>
        public const string JKJVCMST3 = "JKJVCMST3";

        /// <summary>
        /// JKJVCMCH1.
        /// </summary>
        public const string JKJVCMCH1 = "JKJVCMCH1";

        /// <summary>
        /// JKJVCMCH2.
        /// </summary>
        public const string JKJVCMCH2 = "JKJVCMCH2";

        /// <summary>
        /// JKJVCMCH3.
        /// </summary>
        public const string JKJVCMCH3 = "JKJVCMCH3";

        /// <summary>
        /// JKJVCMDT1.
        /// </summary>
        public const string JKJVCMDT1 = "JKJVCMDT1";

        /// <summary>
        /// JKJVCMDT2.
        /// </summary>
        public const string JKJVCMDT2 = "JKJVCMDT2";

        /// <summary>
        /// JKJVCMDT3.
        /// </summary>
        public const string JKJVCMDT3 = "JKJVCMDT3";

        /// <summary>
        /// JKENTJ.
        /// </summary>
        public const string JKENTJ = "JKENTJ";

        /// <summary>
        /// JKTORG.
        /// </summary>
        public const string JKTORG = "JKTORG";

        /// <summary>
        /// JKUSER.
        /// </summary>
        public const string JKUSER = "JKUSER";

        /// <summary>
        /// JKUPMJ.
        /// </summary>
        public const string JKUPMJ = "JKUPMJ";

        /// <summary>
        /// JKUPMT.
        /// </summary>
        public const string JKUPMT = "JKUPMT";

        /// <summary>
        /// JKPID.
        /// </summary>
        public const string JKPID = "JKPID";

        /// <summary>
        /// JKMKEY.
        /// </summary>
        public const string JKMKEY = "JKMKEY";

        /// <summary>
        /// JKCCCTT.
        /// </summary>
        public const string JKCCCTT = "JKCCCTT";

        /// <summary>
        /// JKJVCCCA.
        /// </summary>
        public const string JKJVCCCA = "JKJVCCCA";

        /// <summary>
        /// JKCCCAID.
        /// </summary>
        public const string JKCCCAID = "JKCCCAID";

        /// <summary>
        /// JKJVCCAC.
        /// </summary>
        public const string JKJVCCAC = "JKJVCCAC";

        /// <summary>
        /// JKCCOAID.
        /// </summary>
        public const string JKCCOAID = "JKCCOAID";

        /// <summary>
        /// JKCCFOR.
        /// </summary>
        public const string JKCCFOR = "JKCCFOR";

        /// <summary>
        /// JKCCFOP.
        /// </summary>
        public const string JKCCFOP = "JKCCFOP";

        /// <summary>
        /// JKBCRC.
        /// </summary>
        public const string JKBCRC = "JKBCRC";

        /// <summary>
        /// JKCRCD.
        /// </summary>
        public const string JKCRCD = "JKCRCD";

        /// <summary>
        /// JKCRR.
        /// </summary>
        public const string JKCRR = "JKCRR";

        /// <summary>
        /// JKHCRR.
        /// </summary>
        public const string JKHCRR = "JKHCRR";
    }

    /// <inheritdoc />
    public override string TableName => "F09J40";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JKJVCCID", "JKJVCCID", JdeDataType.Numeric, null, true, true),
        new JdeField("JKJVAN8", "JKJVAN8", JdeDataType.Numeric),
        new JdeField("JKJVIBU", "JKJVIBU", JdeDataType.String, 24),
        new JdeField("JKJVNAME", "JKJVNAME", JdeDataType.String, 40),
        new JdeField("JKEFTB", "JKEFTB", JdeDataType.Numeric),
        new JdeField("JKMCUS", "JKMCUS", JdeDataType.String, 24),
        new JdeField("JKMCU", "JKMCU", JdeDataType.String, 24),
        new JdeField("JKJVAGN", "JKJVAGN", JdeDataType.String, 40),
        new JdeField("JKJVCCDS", "JKJVCCDS", JdeDataType.String, 160),
        new JdeField("JKJVCCST", "JKJVCCST", JdeDataType.String, 4),
        new JdeField("JKJVMCO", "JKJVMCO", JdeDataType.String, 10),
        new JdeField("JKCCE", "JKCCE", JdeDataType.String, 2),
        new JdeField("JKCCOR", "JKCCOR", JdeDataType.Numeric),
        new JdeField("JKCCOP", "JKCCOP", JdeDataType.Numeric),
        new JdeField("JKCCCRC", "JKCCCRC", JdeDataType.String, 4),
        new JdeField("JKCCCDT", "JKCCCDT", JdeDataType.Numeric),
        new JdeField("JKJVCCTI", "JKJVCCTI", JdeDataType.Numeric),
        new JdeField("JKURAB", "JKURAB", JdeDataType.Numeric),
        new JdeField("JKURCD", "JKURCD", JdeDataType.String, 4),
        new JdeField("JKURAT", "JKURAT", JdeDataType.Numeric),
        new JdeField("JKURDT", "JKURDT", JdeDataType.Numeric),
        new JdeField("JKURRF", "JKURRF", JdeDataType.String, 30),
        new JdeField("JKJVCMNU1", "JKJVCMNU1", JdeDataType.Numeric),
        new JdeField("JKJVCMNU2", "JKJVCMNU2", JdeDataType.Numeric),
        new JdeField("JKJVCMNU3", "JKJVCMNU3", JdeDataType.Numeric),
        new JdeField("JKJVCMST1", "JKJVCMST1", JdeDataType.String, 160),
        new JdeField("JKJVCMST2", "JKJVCMST2", JdeDataType.String, 160),
        new JdeField("JKJVCMST3", "JKJVCMST3", JdeDataType.String, 160),
        new JdeField("JKJVCMCH1", "JKJVCMCH1", JdeDataType.String, 2),
        new JdeField("JKJVCMCH2", "JKJVCMCH2", JdeDataType.String, 2),
        new JdeField("JKJVCMCH3", "JKJVCMCH3", JdeDataType.String, 2),
        new JdeField("JKJVCMDT1", "JKJVCMDT1", JdeDataType.Numeric),
        new JdeField("JKJVCMDT2", "JKJVCMDT2", JdeDataType.Numeric),
        new JdeField("JKJVCMDT3", "JKJVCMDT3", JdeDataType.Numeric),
        new JdeField("JKENTJ", "JKENTJ", JdeDataType.Numeric),
        new JdeField("JKTORG", "JKTORG", JdeDataType.String, 20),
        new JdeField("JKUSER", "JKUSER", JdeDataType.String, 20),
        new JdeField("JKUPMJ", "JKUPMJ", JdeDataType.Numeric),
        new JdeField("JKUPMT", "JKUPMT", JdeDataType.Numeric),
        new JdeField("JKPID", "JKPID", JdeDataType.String, 20),
        new JdeField("JKMKEY", "JKMKEY", JdeDataType.String, 30),
        new JdeField("JKCCCTT", "JKCCCTT", JdeDataType.String, 2),
        new JdeField("JKJVCCCA", "JKJVCCCA", JdeDataType.Numeric),
        new JdeField("JKCCCAID", "JKCCCAID", JdeDataType.String, 16),
        new JdeField("JKJVCCAC", "JKJVCCAC", JdeDataType.Numeric),
        new JdeField("JKCCOAID", "JKCCOAID", JdeDataType.String, 16),
        new JdeField("JKCCFOR", "JKCCFOR", JdeDataType.Numeric),
        new JdeField("JKCCFOP", "JKCCFOP", JdeDataType.Numeric),
        new JdeField("JKBCRC", "JKBCRC", JdeDataType.String, 6),
        new JdeField("JKCRCD", "JKCRCD", JdeDataType.String, 6),
        new JdeField("JKCRR", "JKCRR", JdeDataType.Numeric),
        new JdeField("JKHCRR", "JKHCRR", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09J40_0", "Primary Key on JKJVCCID", new[] { "JKJVCCID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09J40_2", "Unique Index on JKJVAN8, JKJVIBU, JKJVNAME, JKEFTB, JKMCUS, JKMCU, JKJVAGN, JKCRCD", new[] { "JKJVAN8", "JKJVIBU", "JKJVNAME", "JKEFTB", "JKMCUS", "JKMCU", "JKJVAGN", "JKCRCD" }, isUnique: true),
        new JdeIndex("F09J40_3", "Index on JKJVCCTI, JKJVCCID", new[] { "JKJVCCTI", "JKJVCCID" }),
        new JdeIndex("F09J40_4", "Index on JKJVAN8, JKJVIBU, JKJVMCO", new[] { "JKJVAN8", "JKJVIBU", "JKJVMCO" }),
        new JdeIndex("F09J40_5", "Index on JKJVAGN, JKJVCCID", new[] { "JKJVAGN", "JKJVCCID" })
    };
}
