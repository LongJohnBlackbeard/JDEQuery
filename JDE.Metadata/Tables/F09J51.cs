using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09J51 - .
/// </summary>
public class F09J51 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ODJVOM.
        /// </summary>
        public const string ODJVOM = "ODJVOM";

        /// <summary>
        /// ODJVLNID.
        /// </summary>
        public const string ODJVLNID = "ODJVLNID";

        /// <summary>
        /// ODEFTB.
        /// </summary>
        public const string ODEFTB = "ODEFTB";

        /// <summary>
        /// ODEFTE.
        /// </summary>
        public const string ODEFTE = "ODEFTE";

        /// <summary>
        /// ODCRCD.
        /// </summary>
        public const string ODCRCD = "ODCRCD";

        /// <summary>
        /// ODJVODD2.
        /// </summary>
        public const string ODJVODD2 = "ODJVODD2";

        /// <summary>
        /// ODJVOBA.
        /// </summary>
        public const string ODJVOBA = "ODJVOBA";

        /// <summary>
        /// ODJVSTFRM.
        /// </summary>
        public const string ODJVSTFRM = "ODJVSTFRM";

        /// <summary>
        /// ODJVOBY.
        /// </summary>
        public const string ODJVOBY = "ODJVOBY";

        /// <summary>
        /// ODMT.
        /// </summary>
        public const string ODMT = "ODMT";

        /// <summary>
        /// ODJVEIX.
        /// </summary>
        public const string ODJVEIX = "ODJVEIX";

        /// <summary>
        /// ODJVOVN.
        /// </summary>
        public const string ODJVOVN = "ODJVOVN";

        /// <summary>
        /// ODJVOFP.
        /// </summary>
        public const string ODJVOFP = "ODJVOFP";

        /// <summary>
        /// ODJVOB.
        /// </summary>
        public const string ODJVOB = "ODJVOB";

        /// <summary>
        /// ODJVOMIN.
        /// </summary>
        public const string ODJVOMIN = "ODJVOMIN";

        /// <summary>
        /// ODJVSOR.
        /// </summary>
        public const string ODJVSOR = "ODJVSOR";

        /// <summary>
        /// ODJVAGN.
        /// </summary>
        public const string ODJVAGN = "ODJVAGN";

        /// <summary>
        /// ODMCU.
        /// </summary>
        public const string ODMCU = "ODMCU";

        /// <summary>
        /// ODOBJ.
        /// </summary>
        public const string ODOBJ = "ODOBJ";

        /// <summary>
        /// ODSUB.
        /// </summary>
        public const string ODSUB = "ODSUB";

        /// <summary>
        /// ODJVORAF.
        /// </summary>
        public const string ODJVORAF = "ODJVORAF";

        /// <summary>
        /// ODJVDDE.
        /// </summary>
        public const string ODJVDDE = "ODJVDDE";

        /// <summary>
        /// ODJVRMK.
        /// </summary>
        public const string ODJVRMK = "ODJVRMK";

        /// <summary>
        /// ODJVINUSR.
        /// </summary>
        public const string ODJVINUSR = "ODJVINUSR";

        /// <summary>
        /// ODOHMCU.
        /// </summary>
        public const string ODOHMCU = "ODOHMCU";

        /// <summary>
        /// ODOHOBJ.
        /// </summary>
        public const string ODOHOBJ = "ODOHOBJ";

        /// <summary>
        /// ODOHSUB.
        /// </summary>
        public const string ODOHSUB = "ODOHSUB";

        /// <summary>
        /// ODFUCNM.
        /// </summary>
        public const string ODFUCNM = "ODFUCNM";

        /// <summary>
        /// ODOBNM.
        /// </summary>
        public const string ODOBNM = "ODOBNM";

        /// <summary>
        /// ODOHMCC1.
        /// </summary>
        public const string ODOHMCC1 = "ODOHMCC1";

        /// <summary>
        /// ODOHMCC2.
        /// </summary>
        public const string ODOHMCC2 = "ODOHMCC2";

        /// <summary>
        /// ODOHMCC3.
        /// </summary>
        public const string ODOHMCC3 = "ODOHMCC3";

        /// <summary>
        /// ODOHMCC4.
        /// </summary>
        public const string ODOHMCC4 = "ODOHMCC4";

        /// <summary>
        /// ODOHMCC5.
        /// </summary>
        public const string ODOHMCC5 = "ODOHMCC5";

        /// <summary>
        /// ODOHMCC6.
        /// </summary>
        public const string ODOHMCC6 = "ODOHMCC6";

        /// <summary>
        /// ODOHMCC7.
        /// </summary>
        public const string ODOHMCC7 = "ODOHMCC7";

        /// <summary>
        /// ODOHMCC8.
        /// </summary>
        public const string ODOHMCC8 = "ODOHMCC8";

        /// <summary>
        /// ODOHMCC9.
        /// </summary>
        public const string ODOHMCC9 = "ODOHMCC9";

        /// <summary>
        /// ODOHMCC10.
        /// </summary>
        public const string ODOHMCC10 = "ODOHMCC10";

        /// <summary>
        /// ODTORG.
        /// </summary>
        public const string ODTORG = "ODTORG";

        /// <summary>
        /// ODENTJ.
        /// </summary>
        public const string ODENTJ = "ODENTJ";

        /// <summary>
        /// ODUSER.
        /// </summary>
        public const string ODUSER = "ODUSER";

        /// <summary>
        /// ODUPMJ.
        /// </summary>
        public const string ODUPMJ = "ODUPMJ";

        /// <summary>
        /// ODUPMT.
        /// </summary>
        public const string ODUPMT = "ODUPMT";

        /// <summary>
        /// ODPID.
        /// </summary>
        public const string ODPID = "ODPID";

        /// <summary>
        /// ODMKEY.
        /// </summary>
        public const string ODMKEY = "ODMKEY";

        /// <summary>
        /// ODJVCNU1.
        /// </summary>
        public const string ODJVCNU1 = "ODJVCNU1";

        /// <summary>
        /// ODJVCNU2.
        /// </summary>
        public const string ODJVCNU2 = "ODJVCNU2";

        /// <summary>
        /// ODJVCNU3.
        /// </summary>
        public const string ODJVCNU3 = "ODJVCNU3";

        /// <summary>
        /// ODJVCST1.
        /// </summary>
        public const string ODJVCST1 = "ODJVCST1";

        /// <summary>
        /// ODJVCST2.
        /// </summary>
        public const string ODJVCST2 = "ODJVCST2";

        /// <summary>
        /// ODJVCST3.
        /// </summary>
        public const string ODJVCST3 = "ODJVCST3";

        /// <summary>
        /// ODJVCCH1.
        /// </summary>
        public const string ODJVCCH1 = "ODJVCCH1";

        /// <summary>
        /// ODJVCCH2.
        /// </summary>
        public const string ODJVCCH2 = "ODJVCCH2";

        /// <summary>
        /// ODJVCCH3.
        /// </summary>
        public const string ODJVCCH3 = "ODJVCCH3";

        /// <summary>
        /// ODJVCDT1.
        /// </summary>
        public const string ODJVCDT1 = "ODJVCDT1";

        /// <summary>
        /// ODJVCDT2.
        /// </summary>
        public const string ODJVCDT2 = "ODJVCDT2";

        /// <summary>
        /// ODJVCDT3.
        /// </summary>
        public const string ODJVCDT3 = "ODJVCDT3";

        /// <summary>
        /// ODURATM01.
        /// </summary>
        public const string ODURATM01 = "ODURATM01";

        /// <summary>
        /// ODURATM02.
        /// </summary>
        public const string ODURATM02 = "ODURATM02";

        /// <summary>
        /// ODURATM03.
        /// </summary>
        public const string ODURATM03 = "ODURATM03";

        /// <summary>
        /// ODURATM04.
        /// </summary>
        public const string ODURATM04 = "ODURATM04";

        /// <summary>
        /// ODURATM05.
        /// </summary>
        public const string ODURATM05 = "ODURATM05";

        /// <summary>
        /// ODURCDM01.
        /// </summary>
        public const string ODURCDM01 = "ODURCDM01";

        /// <summary>
        /// ODURCDM02.
        /// </summary>
        public const string ODURCDM02 = "ODURCDM02";

        /// <summary>
        /// ODURCDM03.
        /// </summary>
        public const string ODURCDM03 = "ODURCDM03";

        /// <summary>
        /// ODURCDM04.
        /// </summary>
        public const string ODURCDM04 = "ODURCDM04";

        /// <summary>
        /// ODURCDM05.
        /// </summary>
        public const string ODURCDM05 = "ODURCDM05";

        /// <summary>
        /// ODURDTM01.
        /// </summary>
        public const string ODURDTM01 = "ODURDTM01";

        /// <summary>
        /// ODURDTM02.
        /// </summary>
        public const string ODURDTM02 = "ODURDTM02";

        /// <summary>
        /// ODURDTM03.
        /// </summary>
        public const string ODURDTM03 = "ODURDTM03";

        /// <summary>
        /// ODURDTM04.
        /// </summary>
        public const string ODURDTM04 = "ODURDTM04";

        /// <summary>
        /// ODURDTM05.
        /// </summary>
        public const string ODURDTM05 = "ODURDTM05";

        /// <summary>
        /// ODURNUMM01.
        /// </summary>
        public const string ODURNUMM01 = "ODURNUMM01";

        /// <summary>
        /// ODURNUMM02.
        /// </summary>
        public const string ODURNUMM02 = "ODURNUMM02";

        /// <summary>
        /// ODURNUMM03.
        /// </summary>
        public const string ODURNUMM03 = "ODURNUMM03";

        /// <summary>
        /// ODURNUMM04.
        /// </summary>
        public const string ODURNUMM04 = "ODURNUMM04";

        /// <summary>
        /// ODURNUMM05.
        /// </summary>
        public const string ODURNUMM05 = "ODURNUMM05";

        /// <summary>
        /// ODURRFM01.
        /// </summary>
        public const string ODURRFM01 = "ODURRFM01";

        /// <summary>
        /// ODURRFM02.
        /// </summary>
        public const string ODURRFM02 = "ODURRFM02";

        /// <summary>
        /// ODURRFM03.
        /// </summary>
        public const string ODURRFM03 = "ODURRFM03";

        /// <summary>
        /// ODURRFM04.
        /// </summary>
        public const string ODURRFM04 = "ODURRFM04";

        /// <summary>
        /// ODURRFM05.
        /// </summary>
        public const string ODURRFM05 = "ODURRFM05";

        /// <summary>
        /// ODURSTM01.
        /// </summary>
        public const string ODURSTM01 = "ODURSTM01";

        /// <summary>
        /// ODURSTM02.
        /// </summary>
        public const string ODURSTM02 = "ODURSTM02";

        /// <summary>
        /// ODURSTM03.
        /// </summary>
        public const string ODURSTM03 = "ODURSTM03";

        /// <summary>
        /// ODURSTM04.
        /// </summary>
        public const string ODURSTM04 = "ODURSTM04";

        /// <summary>
        /// ODURSTM05.
        /// </summary>
        public const string ODURSTM05 = "ODURSTM05";
    }

    /// <inheritdoc />
    public override string TableName => "F09J51";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ODJVOM", "ODJVOM", JdeDataType.String, 4, true, true),
        new JdeField("ODJVLNID", "ODJVLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("ODEFTB", "ODEFTB", JdeDataType.Numeric),
        new JdeField("ODEFTE", "ODEFTE", JdeDataType.Numeric),
        new JdeField("ODCRCD", "ODCRCD", JdeDataType.String, 6),
        new JdeField("ODJVODD2", "ODJVODD2", JdeDataType.String, 160),
        new JdeField("ODJVOBA", "ODJVOBA", JdeDataType.Numeric),
        new JdeField("ODJVSTFRM", "ODJVSTFRM", JdeDataType.String, 2),
        new JdeField("ODJVOBY", "ODJVOBY", JdeDataType.Numeric),
        new JdeField("ODMT", "ODMT", JdeDataType.Numeric),
        new JdeField("ODJVEIX", "ODJVEIX", JdeDataType.String, 10),
        new JdeField("ODJVOVN", "ODJVOVN", JdeDataType.String, 40, true, true),
        new JdeField("ODJVOFP", "ODJVOFP", JdeDataType.Numeric),
        new JdeField("ODJVOB", "ODJVOB", JdeDataType.String, 4),
        new JdeField("ODJVOMIN", "ODJVOMIN", JdeDataType.Numeric),
        new JdeField("ODJVSOR", "ODJVSOR", JdeDataType.String, 2),
        new JdeField("ODJVAGN", "ODJVAGN", JdeDataType.String, 40),
        new JdeField("ODMCU", "ODMCU", JdeDataType.String, 24),
        new JdeField("ODOBJ", "ODOBJ", JdeDataType.String, 12),
        new JdeField("ODSUB", "ODSUB", JdeDataType.String, 16),
        new JdeField("ODJVORAF", "ODJVORAF", JdeDataType.String, 2),
        new JdeField("ODJVDDE", "ODJVDDE", JdeDataType.Numeric),
        new JdeField("ODJVRMK", "ODJVRMK", JdeDataType.String, 160),
        new JdeField("ODJVINUSR", "ODJVINUSR", JdeDataType.String, 20),
        new JdeField("ODOHMCU", "ODOHMCU", JdeDataType.String, 24),
        new JdeField("ODOHOBJ", "ODOHOBJ", JdeDataType.String, 12),
        new JdeField("ODOHSUB", "ODOHSUB", JdeDataType.String, 16),
        new JdeField("ODFUCNM", "ODFUCNM", JdeDataType.String, 64),
        new JdeField("ODOBNM", "ODOBNM", JdeDataType.String, 20),
        new JdeField("ODOHMCC1", "ODOHMCC1", JdeDataType.String, 20),
        new JdeField("ODOHMCC2", "ODOHMCC2", JdeDataType.String, 20),
        new JdeField("ODOHMCC3", "ODOHMCC3", JdeDataType.String, 20),
        new JdeField("ODOHMCC4", "ODOHMCC4", JdeDataType.String, 20),
        new JdeField("ODOHMCC5", "ODOHMCC5", JdeDataType.String, 20),
        new JdeField("ODOHMCC6", "ODOHMCC6", JdeDataType.String, 20),
        new JdeField("ODOHMCC7", "ODOHMCC7", JdeDataType.String, 20),
        new JdeField("ODOHMCC8", "ODOHMCC8", JdeDataType.String, 20),
        new JdeField("ODOHMCC9", "ODOHMCC9", JdeDataType.String, 20),
        new JdeField("ODOHMCC10", "ODOHMCC10", JdeDataType.String, 20),
        new JdeField("ODTORG", "ODTORG", JdeDataType.String, 20),
        new JdeField("ODENTJ", "ODENTJ", JdeDataType.Numeric),
        new JdeField("ODUSER", "ODUSER", JdeDataType.String, 20),
        new JdeField("ODUPMJ", "ODUPMJ", JdeDataType.Numeric),
        new JdeField("ODUPMT", "ODUPMT", JdeDataType.Numeric),
        new JdeField("ODPID", "ODPID", JdeDataType.String, 20),
        new JdeField("ODMKEY", "ODMKEY", JdeDataType.String, 30),
        new JdeField("ODJVCNU1", "ODJVCNU1", JdeDataType.Numeric),
        new JdeField("ODJVCNU2", "ODJVCNU2", JdeDataType.Numeric),
        new JdeField("ODJVCNU3", "ODJVCNU3", JdeDataType.Numeric),
        new JdeField("ODJVCST1", "ODJVCST1", JdeDataType.String, 160),
        new JdeField("ODJVCST2", "ODJVCST2", JdeDataType.String, 160),
        new JdeField("ODJVCST3", "ODJVCST3", JdeDataType.String, 160),
        new JdeField("ODJVCCH1", "ODJVCCH1", JdeDataType.String, 2),
        new JdeField("ODJVCCH2", "ODJVCCH2", JdeDataType.String, 2),
        new JdeField("ODJVCCH3", "ODJVCCH3", JdeDataType.String, 2),
        new JdeField("ODJVCDT1", "ODJVCDT1", JdeDataType.Numeric),
        new JdeField("ODJVCDT2", "ODJVCDT2", JdeDataType.Numeric),
        new JdeField("ODJVCDT3", "ODJVCDT3", JdeDataType.Numeric),
        new JdeField("ODURATM01", "ODURATM01", JdeDataType.Numeric),
        new JdeField("ODURATM02", "ODURATM02", JdeDataType.Numeric),
        new JdeField("ODURATM03", "ODURATM03", JdeDataType.Numeric),
        new JdeField("ODURATM04", "ODURATM04", JdeDataType.Numeric),
        new JdeField("ODURATM05", "ODURATM05", JdeDataType.Numeric),
        new JdeField("ODURCDM01", "ODURCDM01", JdeDataType.String, 20),
        new JdeField("ODURCDM02", "ODURCDM02", JdeDataType.String, 20),
        new JdeField("ODURCDM03", "ODURCDM03", JdeDataType.String, 20),
        new JdeField("ODURCDM04", "ODURCDM04", JdeDataType.String, 20),
        new JdeField("ODURCDM05", "ODURCDM05", JdeDataType.String, 20),
        new JdeField("ODURDTM01", "ODURDTM01", JdeDataType.Numeric),
        new JdeField("ODURDTM02", "ODURDTM02", JdeDataType.Numeric),
        new JdeField("ODURDTM03", "ODURDTM03", JdeDataType.Numeric),
        new JdeField("ODURDTM04", "ODURDTM04", JdeDataType.Numeric),
        new JdeField("ODURDTM05", "ODURDTM05", JdeDataType.Numeric),
        new JdeField("ODURNUMM01", "ODURNUMM01", JdeDataType.Numeric),
        new JdeField("ODURNUMM02", "ODURNUMM02", JdeDataType.Numeric),
        new JdeField("ODURNUMM03", "ODURNUMM03", JdeDataType.Numeric),
        new JdeField("ODURNUMM04", "ODURNUMM04", JdeDataType.Numeric),
        new JdeField("ODURNUMM05", "ODURNUMM05", JdeDataType.Numeric),
        new JdeField("ODURRFM01", "ODURRFM01", JdeDataType.String, 30),
        new JdeField("ODURRFM02", "ODURRFM02", JdeDataType.String, 30),
        new JdeField("ODURRFM03", "ODURRFM03", JdeDataType.String, 30),
        new JdeField("ODURRFM04", "ODURRFM04", JdeDataType.String, 30),
        new JdeField("ODURRFM05", "ODURRFM05", JdeDataType.String, 30),
        new JdeField("ODURSTM01", "ODURSTM01", JdeDataType.String, 160),
        new JdeField("ODURSTM02", "ODURSTM02", JdeDataType.String, 160),
        new JdeField("ODURSTM03", "ODURSTM03", JdeDataType.String, 160),
        new JdeField("ODURSTM04", "ODURSTM04", JdeDataType.String, 160),
        new JdeField("ODURSTM05", "ODURSTM05", JdeDataType.String, 160)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09J51_0", "Primary Key on ODJVOVN, ODJVOM, ODJVLNID", new[] { "ODJVOVN", "ODJVOM", "ODJVLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09J51_2", "Index on ODJVOVN, SYS_NC00089$", new[] { "ODJVOVN", "SYS_NC00089$" })
    };
}
