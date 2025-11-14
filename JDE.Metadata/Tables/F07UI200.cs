using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07UI200 - .
/// </summary>
public class F07UI200 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// THVER.
        /// </summary>
        public const string THVER = "THVER";

        /// <summary>
        /// THJOBN.
        /// </summary>
        public const string THJOBN = "THJOBN";

        /// <summary>
        /// THUSER.
        /// </summary>
        public const string THUSER = "THUSER";

        /// <summary>
        /// THAN8.
        /// </summary>
        public const string THAN8 = "THAN8";

        /// <summary>
        /// THPRTR.
        /// </summary>
        public const string THPRTR = "THPRTR";

        /// <summary>
        /// THPALF.
        /// </summary>
        public const string THPALF = "THPALF";

        /// <summary>
        /// THRCCD.
        /// </summary>
        public const string THRCCD = "THRCCD";

        /// <summary>
        /// THCKCN.
        /// </summary>
        public const string THCKCN = "THCKCN";

        /// <summary>
        /// THAM.
        /// </summary>
        public const string THAM = "THAM";

        /// <summary>
        /// THCO.
        /// </summary>
        public const string THCO = "THCO";

        /// <summary>
        /// THHMCO.
        /// </summary>
        public const string THHMCO = "THHMCO";

        /// <summary>
        /// THHMCU.
        /// </summary>
        public const string THHMCU = "THHMCU";

        /// <summary>
        /// THMCU.
        /// </summary>
        public const string THMCU = "THMCU";

        /// <summary>
        /// THOBJ.
        /// </summary>
        public const string THOBJ = "THOBJ";

        /// <summary>
        /// THSUB.
        /// </summary>
        public const string THSUB = "THSUB";

        /// <summary>
        /// THRCO.
        /// </summary>
        public const string THRCO = "THRCO";

        /// <summary>
        /// THGMCU.
        /// </summary>
        public const string THGMCU = "THGMCU";

        /// <summary>
        /// THGOBJ.
        /// </summary>
        public const string THGOBJ = "THGOBJ";

        /// <summary>
        /// THGSUB.
        /// </summary>
        public const string THGSUB = "THGSUB";

        /// <summary>
        /// THSBL.
        /// </summary>
        public const string THSBL = "THSBL";

        /// <summary>
        /// THSBLT.
        /// </summary>
        public const string THSBLT = "THSBLT";

        /// <summary>
        /// THWR01.
        /// </summary>
        public const string THWR01 = "THWR01";

        /// <summary>
        /// THMCUO.
        /// </summary>
        public const string THMCUO = "THMCUO";

        /// <summary>
        /// THMAIL.
        /// </summary>
        public const string THMAIL = "THMAIL";

        /// <summary>
        /// THPHRW.
        /// </summary>
        public const string THPHRW = "THPHRW";

        /// <summary>
        /// THOPSQ.
        /// </summary>
        public const string THOPSQ = "THOPSQ";

        /// <summary>
        /// THRILT.
        /// </summary>
        public const string THRILT = "THRILT";

        /// <summary>
        /// THITM.
        /// </summary>
        public const string THITM = "THITM";

        /// <summary>
        /// THPCUN.
        /// </summary>
        public const string THPCUN = "THPCUN";

        /// <summary>
        /// THUM.
        /// </summary>
        public const string THUM = "THUM";

        /// <summary>
        /// THPHRT.
        /// </summary>
        public const string THPHRT = "THPHRT";

        /// <summary>
        /// THPPRT.
        /// </summary>
        public const string THPPRT = "THPPRT";

        /// <summary>
        /// THBHRT.
        /// </summary>
        public const string THBHRT = "THBHRT";

        /// <summary>
        /// THPBRT.
        /// </summary>
        public const string THPBRT = "THPBRT";

        /// <summary>
        /// THBDRT.
        /// </summary>
        public const string THBDRT = "THBDRT";

        /// <summary>
        /// THSHRT.
        /// </summary>
        public const string THSHRT = "THSHRT";

        /// <summary>
        /// THSHFT.
        /// </summary>
        public const string THSHFT = "THSHFT";

        /// <summary>
        /// THSHD.
        /// </summary>
        public const string THSHD = "THSHD";

        /// <summary>
        /// THPAYM.
        /// </summary>
        public const string THPAYM = "THPAYM";

        /// <summary>
        /// THLD.
        /// </summary>
        public const string THLD = "THLD";

        /// <summary>
        /// THGPA.
        /// </summary>
        public const string THGPA = "THGPA";

        /// <summary>
        /// THDPA.
        /// </summary>
        public const string THDPA = "THDPA";

        /// <summary>
        /// THRCPY.
        /// </summary>
        public const string THRCPY = "THRCPY";

        /// <summary>
        /// THSAMT.
        /// </summary>
        public const string THSAMT = "THSAMT";

        /// <summary>
        /// THUN.
        /// </summary>
        public const string THUN = "THUN";

        /// <summary>
        /// THJBCD.
        /// </summary>
        public const string THJBCD = "THJBCD";

        /// <summary>
        /// THJBST.
        /// </summary>
        public const string THJBST = "THJBST";

        /// <summary>
        /// THWST.
        /// </summary>
        public const string THWST = "THWST";

        /// <summary>
        /// THWCNT.
        /// </summary>
        public const string THWCNT = "THWCNT";

        /// <summary>
        /// THWCTY.
        /// </summary>
        public const string THWCTY = "THWCTY";

        /// <summary>
        /// THWCMP.
        /// </summary>
        public const string THWCMP = "THWCMP";

        /// <summary>
        /// THWET.
        /// </summary>
        public const string THWET = "THWET";

        /// <summary>
        /// THGENA.
        /// </summary>
        public const string THGENA = "THGENA";

        /// <summary>
        /// THWCAM.
        /// </summary>
        public const string THWCAM = "THWCAM";

        /// <summary>
        /// THWCMB.
        /// </summary>
        public const string THWCMB = "THWCMB";

        /// <summary>
        /// THGENB.
        /// </summary>
        public const string THGENB = "THGENB";

        /// <summary>
        /// THWCMO.
        /// </summary>
        public const string THWCMO = "THWCMO";

        /// <summary>
        /// THGENO.
        /// </summary>
        public const string THGENO = "THGENO";

        /// <summary>
        /// THWCMX.
        /// </summary>
        public const string THWCMX = "THWCMX";

        /// <summary>
        /// THGENX.
        /// </summary>
        public const string THGENX = "THGENX";

        /// <summary>
        /// THWCBN.
        /// </summary>
        public const string THWCBN = "THWCBN";

        /// <summary>
        /// THHMO.
        /// </summary>
        public const string THHMO = "THHMO";

        /// <summary>
        /// THPDBA.
        /// </summary>
        public const string THPDBA = "THPDBA";

        /// <summary>
        /// THPB.
        /// </summary>
        public const string THPB = "THPB";

        /// <summary>
        /// THDEDM.
        /// </summary>
        public const string THDEDM = "THDEDM";

        /// <summary>
        /// THSALY.
        /// </summary>
        public const string THSALY = "THSALY";

        /// <summary>
        /// THNMTH.
        /// </summary>
        public const string THNMTH = "THNMTH";

        /// <summary>
        /// THPFRQ.
        /// </summary>
        public const string THPFRQ = "THPFRQ";

        /// <summary>
        /// THFY.
        /// </summary>
        public const string THFY = "THFY";

        /// <summary>
        /// THDGL.
        /// </summary>
        public const string THDGL = "THDGL";

        /// <summary>
        /// THPN.
        /// </summary>
        public const string THPN = "THPN";

        /// <summary>
        /// THDWK.
        /// </summary>
        public const string THDWK = "THDWK";

        /// <summary>
        /// THDW.
        /// </summary>
        public const string THDW = "THDW";

        /// <summary>
        /// THPPED.
        /// </summary>
        public const string THPPED = "THPPED";

        /// <summary>
        /// THPPP.
        /// </summary>
        public const string THPPP = "THPPP";

        /// <summary>
        /// THDTBT.
        /// </summary>
        public const string THDTBT = "THDTBT";

        /// <summary>
        /// THTCDE.
        /// </summary>
        public const string THTCDE = "THTCDE";

        /// <summary>
        /// THEQCO.
        /// </summary>
        public const string THEQCO = "THEQCO";

        /// <summary>
        /// THEQWO.
        /// </summary>
        public const string THEQWO = "THEQWO";

        /// <summary>
        /// THEQCG.
        /// </summary>
        public const string THEQCG = "THEQCG";

        /// <summary>
        /// THQOBJ.
        /// </summary>
        public const string THQOBJ = "THQOBJ";

        /// <summary>
        /// THERC.
        /// </summary>
        public const string THERC = "THERC";

        /// <summary>
        /// THEQRT.
        /// </summary>
        public const string THEQRT = "THEQRT";

        /// <summary>
        /// THEQGR.
        /// </summary>
        public const string THEQGR = "THEQGR";

        /// <summary>
        /// THEQHR.
        /// </summary>
        public const string THEQHR = "THEQHR";

        /// <summary>
        /// THEXR.
        /// </summary>
        public const string THEXR = "THEXR";

        /// <summary>
        /// THP001.
        /// </summary>
        public const string THP001 = "THP001";

        /// <summary>
        /// THP002.
        /// </summary>
        public const string THP002 = "THP002";

        /// <summary>
        /// THP003.
        /// </summary>
        public const string THP003 = "THP003";

        /// <summary>
        /// THP004.
        /// </summary>
        public const string THP004 = "THP004";

        /// <summary>
        /// THCMMT.
        /// </summary>
        public const string THCMMT = "THCMMT";

        /// <summary>
        /// THCKDT.
        /// </summary>
        public const string THCKDT = "THCKDT";

        /// <summary>
        /// THUAMT.
        /// </summary>
        public const string THUAMT = "THUAMT";

        /// <summary>
        /// THRTWC.
        /// </summary>
        public const string THRTWC = "THRTWC";

        /// <summary>
        /// THGENR.
        /// </summary>
        public const string THGENR = "THGENR";

        /// <summary>
        /// THCKCS.
        /// </summary>
        public const string THCKCS = "THCKCS";

        /// <summary>
        /// THGICU.
        /// </summary>
        public const string THGICU = "THGICU";

        /// <summary>
        /// THAID.
        /// </summary>
        public const string THAID = "THAID";

        /// <summary>
        /// THCMTH.
        /// </summary>
        public const string THCMTH = "THCMTH";

        /// <summary>
        /// THALT0.
        /// </summary>
        public const string THALT0 = "THALT0";

        /// <summary>
        /// THPOS.
        /// </summary>
        public const string THPOS = "THPOS";
    }

    /// <inheritdoc />
    public override string TableName => "F07UI200";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("THVER", "THVER", JdeDataType.String, 20, true, true),
        new JdeField("THJOBN", "THJOBN", JdeDataType.String, 20, true, true),
        new JdeField("THUSER", "THUSER", JdeDataType.String, 20, true, true),
        new JdeField("THAN8", "THAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("THPRTR", "THPRTR", JdeDataType.Numeric, null, true, true),
        new JdeField("THPALF", "THPALF", JdeDataType.String, 24),
        new JdeField("THRCCD", "THRCCD", JdeDataType.String, 2),
        new JdeField("THCKCN", "THCKCN", JdeDataType.Numeric),
        new JdeField("THAM", "THAM", JdeDataType.String, 2),
        new JdeField("THCO", "THCO", JdeDataType.String, 10),
        new JdeField("THHMCO", "THHMCO", JdeDataType.String, 10),
        new JdeField("THHMCU", "THHMCU", JdeDataType.String, 24),
        new JdeField("THMCU", "THMCU", JdeDataType.String, 24),
        new JdeField("THOBJ", "THOBJ", JdeDataType.String, 12),
        new JdeField("THSUB", "THSUB", JdeDataType.String, 16),
        new JdeField("THRCO", "THRCO", JdeDataType.String, 10),
        new JdeField("THGMCU", "THGMCU", JdeDataType.String, 24),
        new JdeField("THGOBJ", "THGOBJ", JdeDataType.String, 12),
        new JdeField("THGSUB", "THGSUB", JdeDataType.String, 16),
        new JdeField("THSBL", "THSBL", JdeDataType.String, 16),
        new JdeField("THSBLT", "THSBLT", JdeDataType.String, 2),
        new JdeField("THWR01", "THWR01", JdeDataType.String, 8),
        new JdeField("THMCUO", "THMCUO", JdeDataType.String, 24),
        new JdeField("THMAIL", "THMAIL", JdeDataType.String, 20),
        new JdeField("THPHRW", "THPHRW", JdeDataType.Numeric),
        new JdeField("THOPSQ", "THOPSQ", JdeDataType.Numeric),
        new JdeField("THRILT", "THRILT", JdeDataType.String, 2),
        new JdeField("THITM", "THITM", JdeDataType.Numeric),
        new JdeField("THPCUN", "THPCUN", JdeDataType.Numeric),
        new JdeField("THUM", "THUM", JdeDataType.String, 4),
        new JdeField("THPHRT", "THPHRT", JdeDataType.Numeric),
        new JdeField("THPPRT", "THPPRT", JdeDataType.Numeric),
        new JdeField("THBHRT", "THBHRT", JdeDataType.Numeric),
        new JdeField("THPBRT", "THPBRT", JdeDataType.Numeric),
        new JdeField("THBDRT", "THBDRT", JdeDataType.Numeric),
        new JdeField("THSHRT", "THSHRT", JdeDataType.Numeric),
        new JdeField("THSHFT", "THSHFT", JdeDataType.String, 2),
        new JdeField("THSHD", "THSHD", JdeDataType.Numeric),
        new JdeField("THPAYM", "THPAYM", JdeDataType.Numeric),
        new JdeField("THLD", "THLD", JdeDataType.String, 2),
        new JdeField("THGPA", "THGPA", JdeDataType.Numeric),
        new JdeField("THDPA", "THDPA", JdeDataType.Numeric),
        new JdeField("THRCPY", "THRCPY", JdeDataType.Numeric),
        new JdeField("THSAMT", "THSAMT", JdeDataType.Numeric),
        new JdeField("THUN", "THUN", JdeDataType.String, 12),
        new JdeField("THJBCD", "THJBCD", JdeDataType.String, 12),
        new JdeField("THJBST", "THJBST", JdeDataType.String, 8),
        new JdeField("THWST", "THWST", JdeDataType.Numeric),
        new JdeField("THWCNT", "THWCNT", JdeDataType.Numeric),
        new JdeField("THWCTY", "THWCTY", JdeDataType.Numeric),
        new JdeField("THWCMP", "THWCMP", JdeDataType.String, 8),
        new JdeField("THWET", "THWET", JdeDataType.String, 2),
        new JdeField("THGENA", "THGENA", JdeDataType.Numeric),
        new JdeField("THWCAM", "THWCAM", JdeDataType.Numeric),
        new JdeField("THWCMB", "THWCMB", JdeDataType.Numeric),
        new JdeField("THGENB", "THGENB", JdeDataType.Numeric),
        new JdeField("THWCMO", "THWCMO", JdeDataType.Numeric),
        new JdeField("THGENO", "THGENO", JdeDataType.Numeric),
        new JdeField("THWCMX", "THWCMX", JdeDataType.Numeric),
        new JdeField("THGENX", "THGENX", JdeDataType.Numeric),
        new JdeField("THWCBN", "THWCBN", JdeDataType.Numeric),
        new JdeField("THHMO", "THHMO", JdeDataType.Numeric),
        new JdeField("THPDBA", "THPDBA", JdeDataType.Numeric),
        new JdeField("THPB", "THPB", JdeDataType.String, 2),
        new JdeField("THDEDM", "THDEDM", JdeDataType.String, 2),
        new JdeField("THSALY", "THSALY", JdeDataType.String, 2),
        new JdeField("THNMTH", "THNMTH", JdeDataType.String, 2),
        new JdeField("THPFRQ", "THPFRQ", JdeDataType.String, 2),
        new JdeField("THFY", "THFY", JdeDataType.Numeric),
        new JdeField("THDGL", "THDGL", JdeDataType.Numeric),
        new JdeField("THPN", "THPN", JdeDataType.Numeric),
        new JdeField("THDWK", "THDWK", JdeDataType.Numeric, null, true, true),
        new JdeField("THDW", "THDW", JdeDataType.String, 2),
        new JdeField("THPPED", "THPPED", JdeDataType.Numeric),
        new JdeField("THPPP", "THPPP", JdeDataType.String, 2),
        new JdeField("THDTBT", "THDTBT", JdeDataType.Numeric),
        new JdeField("THTCDE", "THTCDE", JdeDataType.Numeric),
        new JdeField("THEQCO", "THEQCO", JdeDataType.String, 10),
        new JdeField("THEQWO", "THEQWO", JdeDataType.String, 18),
        new JdeField("THEQCG", "THEQCG", JdeDataType.String, 18),
        new JdeField("THQOBJ", "THQOBJ", JdeDataType.String, 12),
        new JdeField("THERC", "THERC", JdeDataType.String, 4),
        new JdeField("THEQRT", "THEQRT", JdeDataType.Numeric),
        new JdeField("THEQGR", "THEQGR", JdeDataType.Numeric),
        new JdeField("THEQHR", "THEQHR", JdeDataType.Numeric),
        new JdeField("THEXR", "THEXR", JdeDataType.String, 60),
        new JdeField("THP001", "THP001", JdeDataType.String, 6),
        new JdeField("THP002", "THP002", JdeDataType.String, 6),
        new JdeField("THP003", "THP003", JdeDataType.String, 6),
        new JdeField("THP004", "THP004", JdeDataType.String, 6),
        new JdeField("THCMMT", "THCMMT", JdeDataType.String, 2),
        new JdeField("THCKDT", "THCKDT", JdeDataType.Numeric),
        new JdeField("THUAMT", "THUAMT", JdeDataType.Numeric),
        new JdeField("THRTWC", "THRTWC", JdeDataType.Numeric),
        new JdeField("THGENR", "THGENR", JdeDataType.Numeric),
        new JdeField("THCKCS", "THCKCS", JdeDataType.String, 30),
        new JdeField("THGICU", "THGICU", JdeDataType.Numeric),
        new JdeField("THAID", "THAID", JdeDataType.String, 16),
        new JdeField("THCMTH", "THCMTH", JdeDataType.String, 2),
        new JdeField("THALT0", "THALT0", JdeDataType.String, 2),
        new JdeField("THPOS", "THPOS", JdeDataType.String, 16)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07UI200_0", "Primary Key on THVER, THJOBN, THUSER, THAN8, THPRTR, THDWK", new[] { "THVER", "THJOBN", "THUSER", "THAN8", "THPRTR", "THDWK" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F07UI200_2", "Index on THMCU, THPPED, THPALF, THAN8, THJBCD, THJBST", new[] { "THMCU", "THPPED", "THPALF", "THAN8", "THJBCD", "THJBST" }),
        new JdeIndex("F07UI200_3", "Index on THMCU, THUN, THJBCD, THJBST", new[] { "THMCU", "THUN", "THJBCD", "THJBST" }),
        new JdeIndex("F07UI200_4", "Index on THMCU, THWET, THWCMP, THPALF, THAN8", new[] { "THMCU", "THWET", "THWCMP", "THPALF", "THAN8" }),
        new JdeIndex("F07UI200_5", "Index on THMCU, THWET, THPALF, THAN8", new[] { "THMCU", "THWET", "THPALF", "THAN8" })
    };
}
