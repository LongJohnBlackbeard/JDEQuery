using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0009 - .
/// </summary>
public class F0009 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GCSY.
        /// </summary>
        public const string GCSY = "GCSY";

        /// <summary>
        /// GCICRG.
        /// </summary>
        public const string GCICRG = "GCICRG";

        /// <summary>
        /// GCIARG.
        /// </summary>
        public const string GCIARG = "GCIARG";

        /// <summary>
        /// GCPBCO.
        /// </summary>
        public const string GCPBCO = "GCPBCO";

        /// <summary>
        /// GCALIA.
        /// </summary>
        public const string GCALIA = "GCALIA";

        /// <summary>
        /// GCSYMS.
        /// </summary>
        public const string GCSYMS = "GCSYMS";

        /// <summary>
        /// GCSYML.
        /// </summary>
        public const string GCSYML = "GCSYML";

        /// <summary>
        /// GCSYMU.
        /// </summary>
        public const string GCSYMU = "GCSYMU";

        /// <summary>
        /// GCDOT1.
        /// </summary>
        public const string GCDOT1 = "GCDOT1";

        /// <summary>
        /// GCRMR.
        /// </summary>
        public const string GCRMR = "GCRMR";

        /// <summary>
        /// GCICRR.
        /// </summary>
        public const string GCICRR = "GCICRR";

        /// <summary>
        /// GCIARR.
        /// </summary>
        public const string GCIARR = "GCIARR";

        /// <summary>
        /// GCOFFR.
        /// </summary>
        public const string GCOFFR = "GCOFFR";

        /// <summary>
        /// GCGLIN.
        /// </summary>
        public const string GCGLIN = "GCGLIN";

        /// <summary>
        /// GCAF.
        /// </summary>
        public const string GCAF = "GCAF";

        /// <summary>
        /// GCDAG.
        /// </summary>
        public const string GCDAG = "GCDAG";

        /// <summary>
        /// GCAGD.
        /// </summary>
        public const string GCAGD = "GCAGD";

        /// <summary>
        /// GCAGR1.
        /// </summary>
        public const string GCAGR1 = "GCAGR1";

        /// <summary>
        /// GCAGR2.
        /// </summary>
        public const string GCAGR2 = "GCAGR2";

        /// <summary>
        /// GCAGR3.
        /// </summary>
        public const string GCAGR3 = "GCAGR3";

        /// <summary>
        /// GCAGR4.
        /// </summary>
        public const string GCAGR4 = "GCAGR4";

        /// <summary>
        /// GCAGR5.
        /// </summary>
        public const string GCAGR5 = "GCAGR5";

        /// <summary>
        /// GCDOT2.
        /// </summary>
        public const string GCDOT2 = "GCDOT2";

        /// <summary>
        /// GCRMP.
        /// </summary>
        public const string GCRMP = "GCRMP";

        /// <summary>
        /// GCICRP.
        /// </summary>
        public const string GCICRP = "GCICRP";

        /// <summary>
        /// GCIARP.
        /// </summary>
        public const string GCIARP = "GCIARP";

        /// <summary>
        /// GCOFFP.
        /// </summary>
        public const string GCOFFP = "GCOFFP";

        /// <summary>
        /// GCDUIN.
        /// </summary>
        public const string GCDUIN = "GCDUIN";

        /// <summary>
        /// GCDUIA.
        /// </summary>
        public const string GCDUIA = "GCDUIA";

        /// <summary>
        /// GCAGP1.
        /// </summary>
        public const string GCAGP1 = "GCAGP1";

        /// <summary>
        /// GCAGP2.
        /// </summary>
        public const string GCAGP2 = "GCAGP2";

        /// <summary>
        /// GCAGP3.
        /// </summary>
        public const string GCAGP3 = "GCAGP3";

        /// <summary>
        /// GCAGP4.
        /// </summary>
        public const string GCAGP4 = "GCAGP4";

        /// <summary>
        /// GCAGP5.
        /// </summary>
        public const string GCAGP5 = "GCAGP5";

        /// <summary>
        /// GCMCS.
        /// </summary>
        public const string GCMCS = "GCMCS";

        /// <summary>
        /// GCDOT3.
        /// </summary>
        public const string GCDOT3 = "GCDOT3";

        /// <summary>
        /// GCCBR.
        /// </summary>
        public const string GCCBR = "GCCBR";

        /// <summary>
        /// GCIBCR.
        /// </summary>
        public const string GCIBCR = "GCIBCR";

        /// <summary>
        /// GCIBAR.
        /// </summary>
        public const string GCIBAR = "GCIBAR";

        /// <summary>
        /// GCICO.
        /// </summary>
        public const string GCICO = "GCICO";

        /// <summary>
        /// GCUGAP.
        /// </summary>
        public const string GCUGAP = "GCUGAP";

        /// <summary>
        /// GCUGAR.
        /// </summary>
        public const string GCUGAR = "GCUGAR";

        /// <summary>
        /// GCUGGL.
        /// </summary>
        public const string GCUGGL = "GCUGGL";

        /// <summary>
        /// GCIARF.
        /// </summary>
        public const string GCIARF = "GCIARF";

        /// <summary>
        /// GCFLEX.
        /// </summary>
        public const string GCFLEX = "GCFLEX";

        /// <summary>
        /// GCSYMF.
        /// </summary>
        public const string GCSYMF = "GCSYMF";

        /// <summary>
        /// GCSEPF.
        /// </summary>
        public const string GCSEPF = "GCSEPF";

        /// <summary>
        /// GCSEP.
        /// </summary>
        public const string GCSEP = "GCSEP";

        /// <summary>
        /// GCSPL.
        /// </summary>
        public const string GCSPL = "GCSPL";

        /// <summary>
        /// GCNNO.
        /// </summary>
        public const string GCNNO = "GCNNO";

        /// <summary>
        /// GCSYMA.
        /// </summary>
        public const string GCSYMA = "GCSYMA";

        /// <summary>
        /// GCSYMT.
        /// </summary>
        public const string GCSYMT = "GCSYMT";

        /// <summary>
        /// GCSYMN.
        /// </summary>
        public const string GCSYMN = "GCSYMN";

        /// <summary>
        /// GCEFS.
        /// </summary>
        public const string GCEFS = "GCEFS";

        /// <summary>
        /// GCEMS.
        /// </summary>
        public const string GCEMS = "GCEMS";

        /// <summary>
        /// GCEFCF.
        /// </summary>
        public const string GCEFCF = "GCEFCF";

        /// <summary>
        /// GCUSER.
        /// </summary>
        public const string GCUSER = "GCUSER";

        /// <summary>
        /// GCPID.
        /// </summary>
        public const string GCPID = "GCPID";

        /// <summary>
        /// GCJOBN.
        /// </summary>
        public const string GCJOBN = "GCJOBN";

        /// <summary>
        /// GCUPMJ.
        /// </summary>
        public const string GCUPMJ = "GCUPMJ";

        /// <summary>
        /// GCUPMT.
        /// </summary>
        public const string GCUPMT = "GCUPMT";

        /// <summary>
        /// GCGFCF1.
        /// </summary>
        public const string GCGFCF1 = "GCGFCF1";

        /// <summary>
        /// GCGFCF2.
        /// </summary>
        public const string GCGFCF2 = "GCGFCF2";

        /// <summary>
        /// GCGFCF3.
        /// </summary>
        public const string GCGFCF3 = "GCGFCF3";

        /// <summary>
        /// GCPST.
        /// </summary>
        public const string GCPST = "GCPST";

        /// <summary>
        /// GCREOP.
        /// </summary>
        public const string GCREOP = "GCREOP";
    }

    /// <inheritdoc />
    public override string TableName => "F0009";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GCSY", "GCSY", JdeDataType.String, 8, true, true),
        new JdeField("GCICRG", "GCICRG", JdeDataType.String, 2),
        new JdeField("GCIARG", "GCIARG", JdeDataType.String, 2),
        new JdeField("GCPBCO", "GCPBCO", JdeDataType.String, 2),
        new JdeField("GCALIA", "GCALIA", JdeDataType.String, 2),
        new JdeField("GCSYMS", "GCSYMS", JdeDataType.String, 2),
        new JdeField("GCSYML", "GCSYML", JdeDataType.String, 2),
        new JdeField("GCSYMU", "GCSYMU", JdeDataType.String, 2),
        new JdeField("GCDOT1", "GCDOT1", JdeDataType.String, 2),
        new JdeField("GCRMR", "GCRMR", JdeDataType.Numeric),
        new JdeField("GCICRR", "GCICRR", JdeDataType.String, 2),
        new JdeField("GCIARR", "GCIARR", JdeDataType.String, 2),
        new JdeField("GCOFFR", "GCOFFR", JdeDataType.String, 2),
        new JdeField("GCGLIN", "GCGLIN", JdeDataType.String, 2),
        new JdeField("GCAF", "GCAF", JdeDataType.Numeric),
        new JdeField("GCDAG", "GCDAG", JdeDataType.Numeric),
        new JdeField("GCAGD", "GCAGD", JdeDataType.String, 2),
        new JdeField("GCAGR1", "GCAGR1", JdeDataType.Numeric),
        new JdeField("GCAGR2", "GCAGR2", JdeDataType.Numeric),
        new JdeField("GCAGR3", "GCAGR3", JdeDataType.Numeric),
        new JdeField("GCAGR4", "GCAGR4", JdeDataType.Numeric),
        new JdeField("GCAGR5", "GCAGR5", JdeDataType.Numeric),
        new JdeField("GCDOT2", "GCDOT2", JdeDataType.String, 2),
        new JdeField("GCRMP", "GCRMP", JdeDataType.Numeric),
        new JdeField("GCICRP", "GCICRP", JdeDataType.String, 2),
        new JdeField("GCIARP", "GCIARP", JdeDataType.String, 2),
        new JdeField("GCOFFP", "GCOFFP", JdeDataType.String, 2),
        new JdeField("GCDUIN", "GCDUIN", JdeDataType.String, 2),
        new JdeField("GCDUIA", "GCDUIA", JdeDataType.String, 2),
        new JdeField("GCAGP1", "GCAGP1", JdeDataType.Numeric),
        new JdeField("GCAGP2", "GCAGP2", JdeDataType.Numeric),
        new JdeField("GCAGP3", "GCAGP3", JdeDataType.Numeric),
        new JdeField("GCAGP4", "GCAGP4", JdeDataType.Numeric),
        new JdeField("GCAGP5", "GCAGP5", JdeDataType.Numeric),
        new JdeField("GCMCS", "GCMCS", JdeDataType.Numeric),
        new JdeField("GCDOT3", "GCDOT3", JdeDataType.String, 2),
        new JdeField("GCCBR", "GCCBR", JdeDataType.Numeric),
        new JdeField("GCIBCR", "GCIBCR", JdeDataType.String, 2),
        new JdeField("GCIBAR", "GCIBAR", JdeDataType.String, 2),
        new JdeField("GCICO", "GCICO", JdeDataType.String, 2),
        new JdeField("GCUGAP", "GCUGAP", JdeDataType.String, 2),
        new JdeField("GCUGAR", "GCUGAR", JdeDataType.String, 2),
        new JdeField("GCUGGL", "GCUGGL", JdeDataType.String, 2),
        new JdeField("GCIARF", "GCIARF", JdeDataType.String, 2),
        new JdeField("GCFLEX", "GCFLEX", JdeDataType.String, 2),
        new JdeField("GCSYMF", "GCSYMF", JdeDataType.String, 2),
        new JdeField("GCSEPF", "GCSEPF", JdeDataType.String, 2),
        new JdeField("GCSEP", "GCSEP", JdeDataType.String, 2),
        new JdeField("GCSPL", "GCSPL", JdeDataType.String, 2),
        new JdeField("GCNNO", "GCNNO", JdeDataType.String, 2),
        new JdeField("GCSYMA", "GCSYMA", JdeDataType.String, 2),
        new JdeField("GCSYMT", "GCSYMT", JdeDataType.String, 2),
        new JdeField("GCSYMN", "GCSYMN", JdeDataType.String, 2),
        new JdeField("GCEFS", "GCEFS", JdeDataType.String, 2),
        new JdeField("GCEMS", "GCEMS", JdeDataType.String, 2),
        new JdeField("GCEFCF", "GCEFCF", JdeDataType.String, 2),
        new JdeField("GCUSER", "GCUSER", JdeDataType.String, 20),
        new JdeField("GCPID", "GCPID", JdeDataType.String, 20),
        new JdeField("GCJOBN", "GCJOBN", JdeDataType.String, 20),
        new JdeField("GCUPMJ", "GCUPMJ", JdeDataType.Numeric),
        new JdeField("GCUPMT", "GCUPMT", JdeDataType.Numeric),
        new JdeField("GCGFCF1", "GCGFCF1", JdeDataType.String, 2),
        new JdeField("GCGFCF2", "GCGFCF2", JdeDataType.String, 2),
        new JdeField("GCGFCF3", "GCGFCF3", JdeDataType.String, 2),
        new JdeField("GCPST", "GCPST", JdeDataType.String, 2),
        new JdeField("GCREOP", "GCREOP", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0009_0", "Primary Key on GCSY", new[] { "GCSY" }, isUnique: true, isPrimaryKey: true)
    };
}
