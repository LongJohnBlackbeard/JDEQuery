using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06106 - .
/// </summary>
public class F06106 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YMAN8.
        /// </summary>
        public const string YMAN8 = "YMAN8";

        /// <summary>
        /// YMEXR.
        /// </summary>
        public const string YMEXR = "YMEXR";

        /// <summary>
        /// YMPDBA.
        /// </summary>
        public const string YMPDBA = "YMPDBA";

        /// <summary>
        /// YMDISO.
        /// </summary>
        public const string YMDISO = "YMDISO";

        /// <summary>
        /// YMPGRP.
        /// </summary>
        public const string YMPGRP = "YMPGRP";

        /// <summary>
        /// YMPSDT.
        /// </summary>
        public const string YMPSDT = "YMPSDT";

        /// <summary>
        /// YMPTDT.
        /// </summary>
        public const string YMPTDT = "YMPTDT";

        /// <summary>
        /// YMSFLG.
        /// </summary>
        public const string YMSFLG = "YMSFLG";

        /// <summary>
        /// YMDTAB.
        /// </summary>
        public const string YMDTAB = "YMDTAB";

        /// <summary>
        /// YMPB.
        /// </summary>
        public const string YMPB = "YMPB";

        /// <summary>
        /// YMDESQ.
        /// </summary>
        public const string YMDESQ = "YMDESQ";

        /// <summary>
        /// YMSHFT.
        /// </summary>
        public const string YMSHFT = "YMSHFT";

        /// <summary>
        /// YMAM.
        /// </summary>
        public const string YMAM = "YMAM";

        /// <summary>
        /// YMMCU.
        /// </summary>
        public const string YMMCU = "YMMCU";

        /// <summary>
        /// YMOBJ.
        /// </summary>
        public const string YMOBJ = "YMOBJ";

        /// <summary>
        /// YMSUB.
        /// </summary>
        public const string YMSUB = "YMSUB";

        /// <summary>
        /// YMSBL.
        /// </summary>
        public const string YMSBL = "YMSBL";

        /// <summary>
        /// YMTARA.
        /// </summary>
        public const string YMTARA = "YMTARA";

        /// <summary>
        /// YMWCMP.
        /// </summary>
        public const string YMWCMP = "YMWCMP";

        /// <summary>
        /// YMLMTH.
        /// </summary>
        public const string YMLMTH = "YMLMTH";

        /// <summary>
        /// YMLF.
        /// </summary>
        public const string YMLF = "YMLF";

        /// <summary>
        /// YMPHRW.
        /// </summary>
        public const string YMPHRW = "YMPHRW";

        /// <summary>
        /// YMPCUN.
        /// </summary>
        public const string YMPCUN = "YMPCUN";

        /// <summary>
        /// YMUM.
        /// </summary>
        public const string YMUM = "YMUM";

        /// <summary>
        /// YMPHRT.
        /// </summary>
        public const string YMPHRT = "YMPHRT";

        /// <summary>
        /// YMPPRT.
        /// </summary>
        public const string YMPPRT = "YMPPRT";

        /// <summary>
        /// YMBHRT.
        /// </summary>
        public const string YMBHRT = "YMBHRT";

        /// <summary>
        /// YMPBRT.
        /// </summary>
        public const string YMPBRT = "YMPBRT";

        /// <summary>
        /// YMBDRT.
        /// </summary>
        public const string YMBDRT = "YMBDRT";

        /// <summary>
        /// YMB2RT.
        /// </summary>
        public const string YMB2RT = "YMB2RT";

        /// <summary>
        /// YMRBOB.
        /// </summary>
        public const string YMRBOB = "YMRBOB";

        /// <summary>
        /// YMRBO2.
        /// </summary>
        public const string YMRBO2 = "YMRBO2";

        /// <summary>
        /// YMRTAM.
        /// </summary>
        public const string YMRTAM = "YMRTAM";

        /// <summary>
        /// YMPAYM.
        /// </summary>
        public const string YMPAYM = "YMPAYM";

        /// <summary>
        /// YMSHD.
        /// </summary>
        public const string YMSHD = "YMSHD";

        /// <summary>
        /// YMCMTH.
        /// </summary>
        public const string YMCMTH = "YMCMTH";

        /// <summary>
        /// YMGPA.
        /// </summary>
        public const string YMGPA = "YMGPA";

        /// <summary>
        /// YMPPDL.
        /// </summary>
        public const string YMPPDL = "YMPPDL";

        /// <summary>
        /// YMMDL.
        /// </summary>
        public const string YMMDL = "YMMDL";

        /// <summary>
        /// YMADL.
        /// </summary>
        public const string YMADL = "YMADL";

        /// <summary>
        /// YMPPPL.
        /// </summary>
        public const string YMPPPL = "YMPPPL";

        /// <summary>
        /// YMNP.
        /// </summary>
        public const string YMNP = "YMNP";

        /// <summary>
        /// YMAD.
        /// </summary>
        public const string YMAD = "YMAD";

        /// <summary>
        /// YMAI.
        /// </summary>
        public const string YMAI = "YMAI";

        /// <summary>
        /// YMLD.
        /// </summary>
        public const string YMLD = "YMLD";

        /// <summary>
        /// YMSEC$.
        /// </summary>
        public const string YMSEC_ = "YMSEC$";

        /// <summary>
        /// YMANN8.
        /// </summary>
        public const string YMANN8 = "YMANN8";

        /// <summary>
        /// YMDEP1.
        /// </summary>
        public const string YMDEP1 = "YMDEP1";

        /// <summary>
        /// YMDEP2.
        /// </summary>
        public const string YMDEP2 = "YMDEP2";

        /// <summary>
        /// YMDEP3.
        /// </summary>
        public const string YMDEP3 = "YMDEP3";

        /// <summary>
        /// YMDEP4.
        /// </summary>
        public const string YMDEP4 = "YMDEP4";

        /// <summary>
        /// YMDEP5.
        /// </summary>
        public const string YMDEP5 = "YMDEP5";

        /// <summary>
        /// YMDEP6.
        /// </summary>
        public const string YMDEP6 = "YMDEP6";

        /// <summary>
        /// YMP001.
        /// </summary>
        public const string YMP001 = "YMP001";

        /// <summary>
        /// YMP002.
        /// </summary>
        public const string YMP002 = "YMP002";

        /// <summary>
        /// YMP003.
        /// </summary>
        public const string YMP003 = "YMP003";

        /// <summary>
        /// YMP004.
        /// </summary>
        public const string YMP004 = "YMP004";

        /// <summary>
        /// YMJBCD.
        /// </summary>
        public const string YMJBCD = "YMJBCD";

        /// <summary>
        /// YMJBST.
        /// </summary>
        public const string YMJBST = "YMJBST";

        /// <summary>
        /// YMHMIN.
        /// </summary>
        public const string YMHMIN = "YMHMIN";

        /// <summary>
        /// YMHMAX.
        /// </summary>
        public const string YMHMAX = "YMHMAX";

        /// <summary>
        /// YMWET.
        /// </summary>
        public const string YMWET = "YMWET";

        /// <summary>
        /// YMEQCG.
        /// </summary>
        public const string YMEQCG = "YMEQCG";

        /// <summary>
        /// YMEQHR.
        /// </summary>
        public const string YMEQHR = "YMEQHR";

        /// <summary>
        /// YMERC.
        /// </summary>
        public const string YMERC = "YMERC";

        /// <summary>
        /// YMQOBJ.
        /// </summary>
        public const string YMQOBJ = "YMQOBJ";

        /// <summary>
        /// YMEQRT.
        /// </summary>
        public const string YMEQRT = "YMEQRT";

        /// <summary>
        /// YMPDED.
        /// </summary>
        public const string YMPDED = "YMPDED";

        /// <summary>
        /// YMDGRP.
        /// </summary>
        public const string YMDGRP = "YMDGRP";

        /// <summary>
        /// YMDPRI.
        /// </summary>
        public const string YMDPRI = "YMDPRI";

        /// <summary>
        /// YMARRR.
        /// </summary>
        public const string YMARRR = "YMARRR";

        /// <summary>
        /// YMQDL.
        /// </summary>
        public const string YMQDL = "YMQDL";

        /// <summary>
        /// YMDW.
        /// </summary>
        public const string YMDW = "YMDW";

        /// <summary>
        /// YMPRTR.
        /// </summary>
        public const string YMPRTR = "YMPRTR";

        /// <summary>
        /// YMSBLT.
        /// </summary>
        public const string YMSBLT = "YMSBLT";

        /// <summary>
        /// YMAAF.
        /// </summary>
        public const string YMAAF = "YMAAF";

        /// <summary>
        /// YMDAAF.
        /// </summary>
        public const string YMDAAF = "YMDAAF";

        /// <summary>
        /// YMACEQ.
        /// </summary>
        public const string YMACEQ = "YMACEQ";

        /// <summary>
        /// YMALHR.
        /// </summary>
        public const string YMALHR = "YMALHR";

        /// <summary>
        /// YMUN.
        /// </summary>
        public const string YMUN = "YMUN";

        /// <summary>
        /// YMAMTS.
        /// </summary>
        public const string YMAMTS = "YMAMTS";

        /// <summary>
        /// YMSADL.
        /// </summary>
        public const string YMSADL = "YMSADL";

        /// <summary>
        /// YMWR01.
        /// </summary>
        public const string YMWR01 = "YMWR01";

        /// <summary>
        /// YMCOVA.
        /// </summary>
        public const string YMCOVA = "YMCOVA";

        /// <summary>
        /// YMZOVR.
        /// </summary>
        public const string YMZOVR = "YMZOVR";

        /// <summary>
        /// YMCMAX.
        /// </summary>
        public const string YMCMAX = "YMCMAX";

        /// <summary>
        /// YMUAMT.
        /// </summary>
        public const string YMUAMT = "YMUAMT";

        /// <summary>
        /// YMAR1Y.
        /// </summary>
        public const string YMAR1Y = "YMAR1Y";

        /// <summary>
        /// YMARSY.
        /// </summary>
        public const string YMARSY = "YMARSY";

        /// <summary>
        /// YMRTAB.
        /// </summary>
        public const string YMRTAB = "YMRTAB";

        /// <summary>
        /// YMCTAB.
        /// </summary>
        public const string YMCTAB = "YMCTAB";

        /// <summary>
        /// YMRCCD.
        /// </summary>
        public const string YMRCCD = "YMRCCD";

        /// <summary>
        /// YMPCNO.
        /// </summary>
        public const string YMPCNO = "YMPCNO";

        /// <summary>
        /// YMODBA.
        /// </summary>
        public const string YMODBA = "YMODBA";

        /// <summary>
        /// YMUDBA.
        /// </summary>
        public const string YMUDBA = "YMUDBA";

        /// <summary>
        /// YMGVCH.
        /// </summary>
        public const string YMGVCH = "YMGVCH";

        /// <summary>
        /// YMPLAN.
        /// </summary>
        public const string YMPLAN = "YMPLAN";

        /// <summary>
        /// YMAOPT.
        /// </summary>
        public const string YMAOPT = "YMAOPT";

        /// <summary>
        /// YMUSER.
        /// </summary>
        public const string YMUSER = "YMUSER";

        /// <summary>
        /// YMPID.
        /// </summary>
        public const string YMPID = "YMPID";

        /// <summary>
        /// YMUPMJ.
        /// </summary>
        public const string YMUPMJ = "YMUPMJ";

        /// <summary>
        /// YMPOS.
        /// </summary>
        public const string YMPOS = "YMPOS";

        /// <summary>
        /// YMHMCU.
        /// </summary>
        public const string YMHMCU = "YMHMCU";

        /// <summary>
        /// YMTSKID.
        /// </summary>
        public const string YMTSKID = "YMTSKID";

        /// <summary>
        /// YMDEFR.
        /// </summary>
        public const string YMDEFR = "YMDEFR";
    }

    /// <inheritdoc />
    public override string TableName => "F06106";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YMAN8", "YMAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YMEXR", "YMEXR", JdeDataType.String, 60),
        new JdeField("YMPDBA", "YMPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("YMDISO", "YMDISO", JdeDataType.String, 2),
        new JdeField("YMPGRP", "YMPGRP", JdeDataType.String, 4),
        new JdeField("YMPSDT", "YMPSDT", JdeDataType.Numeric, null, true, true),
        new JdeField("YMPTDT", "YMPTDT", JdeDataType.Numeric),
        new JdeField("YMSFLG", "YMSFLG", JdeDataType.String, 2),
        new JdeField("YMDTAB", "YMDTAB", JdeDataType.String, 10),
        new JdeField("YMPB", "YMPB", JdeDataType.String, 2),
        new JdeField("YMDESQ", "YMDESQ", JdeDataType.String, 2),
        new JdeField("YMSHFT", "YMSHFT", JdeDataType.String, 2),
        new JdeField("YMAM", "YMAM", JdeDataType.String, 2),
        new JdeField("YMMCU", "YMMCU", JdeDataType.String, 24),
        new JdeField("YMOBJ", "YMOBJ", JdeDataType.String, 12),
        new JdeField("YMSUB", "YMSUB", JdeDataType.String, 16),
        new JdeField("YMSBL", "YMSBL", JdeDataType.String, 16),
        new JdeField("YMTARA", "YMTARA", JdeDataType.String, 20),
        new JdeField("YMWCMP", "YMWCMP", JdeDataType.String, 8),
        new JdeField("YMLMTH", "YMLMTH", JdeDataType.String, 2),
        new JdeField("YMLF", "YMLF", JdeDataType.Numeric),
        new JdeField("YMPHRW", "YMPHRW", JdeDataType.Numeric),
        new JdeField("YMPCUN", "YMPCUN", JdeDataType.Numeric),
        new JdeField("YMUM", "YMUM", JdeDataType.String, 4),
        new JdeField("YMPHRT", "YMPHRT", JdeDataType.Numeric),
        new JdeField("YMPPRT", "YMPPRT", JdeDataType.Numeric),
        new JdeField("YMBHRT", "YMBHRT", JdeDataType.Numeric),
        new JdeField("YMPBRT", "YMPBRT", JdeDataType.Numeric),
        new JdeField("YMBDRT", "YMBDRT", JdeDataType.Numeric),
        new JdeField("YMB2RT", "YMB2RT", JdeDataType.Numeric),
        new JdeField("YMRBOB", "YMRBOB", JdeDataType.String, 12),
        new JdeField("YMRBO2", "YMRBO2", JdeDataType.String, 12),
        new JdeField("YMRTAM", "YMRTAM", JdeDataType.Numeric),
        new JdeField("YMPAYM", "YMPAYM", JdeDataType.Numeric),
        new JdeField("YMSHD", "YMSHD", JdeDataType.Numeric),
        new JdeField("YMCMTH", "YMCMTH", JdeDataType.String, 2),
        new JdeField("YMGPA", "YMGPA", JdeDataType.Numeric),
        new JdeField("YMPPDL", "YMPPDL", JdeDataType.Numeric),
        new JdeField("YMMDL", "YMMDL", JdeDataType.Numeric),
        new JdeField("YMADL", "YMADL", JdeDataType.Numeric),
        new JdeField("YMPPPL", "YMPPPL", JdeDataType.Numeric),
        new JdeField("YMNP", "YMNP", JdeDataType.Numeric),
        new JdeField("YMAD", "YMAD", JdeDataType.Numeric),
        new JdeField("YMAI", "YMAI", JdeDataType.String, 2),
        new JdeField("YMLD", "YMLD", JdeDataType.String, 2),
        new JdeField("YMSEC$", "YMSEC$", JdeDataType.String, 2),
        new JdeField("YMANN8", "YMANN8", JdeDataType.Numeric),
        new JdeField("YMDEP1", "YMDEP1", JdeDataType.String, 2),
        new JdeField("YMDEP2", "YMDEP2", JdeDataType.String, 2),
        new JdeField("YMDEP3", "YMDEP3", JdeDataType.String, 2),
        new JdeField("YMDEP4", "YMDEP4", JdeDataType.String, 2),
        new JdeField("YMDEP5", "YMDEP5", JdeDataType.String, 2),
        new JdeField("YMDEP6", "YMDEP6", JdeDataType.String, 2),
        new JdeField("YMP001", "YMP001", JdeDataType.String, 6),
        new JdeField("YMP002", "YMP002", JdeDataType.String, 6),
        new JdeField("YMP003", "YMP003", JdeDataType.String, 6),
        new JdeField("YMP004", "YMP004", JdeDataType.String, 6),
        new JdeField("YMJBCD", "YMJBCD", JdeDataType.String, 12),
        new JdeField("YMJBST", "YMJBST", JdeDataType.String, 8),
        new JdeField("YMHMIN", "YMHMIN", JdeDataType.Numeric),
        new JdeField("YMHMAX", "YMHMAX", JdeDataType.Numeric),
        new JdeField("YMWET", "YMWET", JdeDataType.String, 2),
        new JdeField("YMEQCG", "YMEQCG", JdeDataType.String, 18),
        new JdeField("YMEQHR", "YMEQHR", JdeDataType.Numeric),
        new JdeField("YMERC", "YMERC", JdeDataType.String, 4),
        new JdeField("YMQOBJ", "YMQOBJ", JdeDataType.String, 12),
        new JdeField("YMEQRT", "YMEQRT", JdeDataType.Numeric),
        new JdeField("YMPDED", "YMPDED", JdeDataType.Numeric),
        new JdeField("YMDGRP", "YMDGRP", JdeDataType.String, 4),
        new JdeField("YMDPRI", "YMDPRI", JdeDataType.Numeric),
        new JdeField("YMARRR", "YMARRR", JdeDataType.String, 2),
        new JdeField("YMQDL", "YMQDL", JdeDataType.Numeric),
        new JdeField("YMDW", "YMDW", JdeDataType.String, 2),
        new JdeField("YMPRTR", "YMPRTR", JdeDataType.Numeric, null, true, true),
        new JdeField("YMSBLT", "YMSBLT", JdeDataType.String, 2),
        new JdeField("YMAAF", "YMAAF", JdeDataType.String, 2),
        new JdeField("YMDAAF", "YMDAAF", JdeDataType.String, 2),
        new JdeField("YMACEQ", "YMACEQ", JdeDataType.Numeric),
        new JdeField("YMALHR", "YMALHR", JdeDataType.Numeric),
        new JdeField("YMUN", "YMUN", JdeDataType.String, 12),
        new JdeField("YMAMTS", "YMAMTS", JdeDataType.Numeric),
        new JdeField("YMSADL", "YMSADL", JdeDataType.Numeric),
        new JdeField("YMWR01", "YMWR01", JdeDataType.String, 8),
        new JdeField("YMCOVA", "YMCOVA", JdeDataType.Numeric),
        new JdeField("YMZOVR", "YMZOVR", JdeDataType.String, 2),
        new JdeField("YMCMAX", "YMCMAX", JdeDataType.Numeric),
        new JdeField("YMUAMT", "YMUAMT", JdeDataType.Numeric),
        new JdeField("YMAR1Y", "YMAR1Y", JdeDataType.String, 2),
        new JdeField("YMARSY", "YMARSY", JdeDataType.String, 2),
        new JdeField("YMRTAB", "YMRTAB", JdeDataType.String, 10),
        new JdeField("YMCTAB", "YMCTAB", JdeDataType.String, 10),
        new JdeField("YMRCCD", "YMRCCD", JdeDataType.String, 2),
        new JdeField("YMPCNO", "YMPCNO", JdeDataType.Numeric),
        new JdeField("YMODBA", "YMODBA", JdeDataType.String, 2),
        new JdeField("YMUDBA", "YMUDBA", JdeDataType.String, 2),
        new JdeField("YMGVCH", "YMGVCH", JdeDataType.String, 2),
        new JdeField("YMPLAN", "YMPLAN", JdeDataType.String, 16),
        new JdeField("YMAOPT", "YMAOPT", JdeDataType.String, 6),
        new JdeField("YMUSER", "YMUSER", JdeDataType.String, 20),
        new JdeField("YMPID", "YMPID", JdeDataType.String, 20),
        new JdeField("YMUPMJ", "YMUPMJ", JdeDataType.Numeric),
        new JdeField("YMPOS", "YMPOS", JdeDataType.String, 16),
        new JdeField("YMHMCU", "YMHMCU", JdeDataType.String, 24),
        new JdeField("YMTSKID", "YMTSKID", JdeDataType.Numeric),
        new JdeField("YMDEFR", "YMDEFR", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06106_0", "Primary Key on YMAN8, YMPDBA, YMPSDT, YMPRTR", new[] { "YMAN8", "YMPDBA", "YMPSDT", "YMPRTR" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F06106_10", "Index on YMAN8, YMPDBA, YMPSDT, YMPTDT", new[] { "YMAN8", "YMPDBA", "YMPSDT", "YMPTDT" }),
        new JdeIndex("F06106_2", "Index on YMAN8, YMPDBA, YMPRTR", new[] { "YMAN8", "YMPDBA", "YMPRTR" }),
        new JdeIndex("F06106_3", "Index on YMAN8, YMPDBA, YMDISO", new[] { "YMAN8", "YMPDBA", "YMDISO" }),
        new JdeIndex("F06106_5", "Index on YMPDBA, YMAN8, YMPSDT", new[] { "YMPDBA", "YMAN8", "YMPSDT" }),
        new JdeIndex("F06106_6", "Index on YMAN8, YMDPRI, YMPDBA", new[] { "YMAN8", "YMDPRI", "YMPDBA" }),
        new JdeIndex("F06106_8", "Index on YMAN8, YMDISO, YMHMCU, YMJBCD, YMJBST", new[] { "YMAN8", "YMDISO", "YMHMCU", "YMJBCD", "YMJBST" }),
        new JdeIndex("F06106_9", "Index on YMAN8, YMPDBA, YMPTDT", new[] { "YMAN8", "YMPDBA", "YMPTDT" })
    };
}
