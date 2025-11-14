using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1501B - .
/// </summary>
public class F1501B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NEDOCO.
        /// </summary>
        public const string NEDOCO = "NEDOCO";

        /// <summary>
        /// NELSVR.
        /// </summary>
        public const string NELSVR = "NELSVR";

        /// <summary>
        /// NEVREF.
        /// </summary>
        public const string NEVREF = "NEVREF";

        /// <summary>
        /// NEVRED.
        /// </summary>
        public const string NEVRED = "NEVRED";

        /// <summary>
        /// NEVRS.
        /// </summary>
        public const string NEVRS = "NEVRS";

        /// <summary>
        /// NEDCTO.
        /// </summary>
        public const string NEDCTO = "NEDCTO";

        /// <summary>
        /// NEDL01.
        /// </summary>
        public const string NEDL01 = "NEDL01";

        /// <summary>
        /// NEAN8.
        /// </summary>
        public const string NEAN8 = "NEAN8";

        /// <summary>
        /// NEAN8J.
        /// </summary>
        public const string NEAN8J = "NEAN8J";

        /// <summary>
        /// NEANSA.
        /// </summary>
        public const string NEANSA = "NEANSA";

        /// <summary>
        /// NEAN8B.
        /// </summary>
        public const string NEAN8B = "NEAN8B";

        /// <summary>
        /// NEAN8P.
        /// </summary>
        public const string NEAN8P = "NEAN8P";

        /// <summary>
        /// NELSST.
        /// </summary>
        public const string NELSST = "NELSST";

        /// <summary>
        /// NEPMTC.
        /// </summary>
        public const string NEPMTC = "NEPMTC";

        /// <summary>
        /// NELSCD.
        /// </summary>
        public const string NELSCD = "NELSCD";

        /// <summary>
        /// NELSET.
        /// </summary>
        public const string NELSET = "NELSET";

        /// <summary>
        /// NEOWLS.
        /// </summary>
        public const string NEOWLS = "NEOWLS";

        /// <summary>
        /// NEMGTF.
        /// </summary>
        public const string NEMGTF = "NEMGTF";

        /// <summary>
        /// NETRAR.
        /// </summary>
        public const string NETRAR = "NETRAR";

        /// <summary>
        /// NEINVP.
        /// </summary>
        public const string NEINVP = "NEINVP";

        /// <summary>
        /// NESTMP.
        /// </summary>
        public const string NESTMP = "NESTMP";

        /// <summary>
        /// NESECN.
        /// </summary>
        public const string NESECN = "NESECN";

        /// <summary>
        /// NEDSPN.
        /// </summary>
        public const string NEDSPN = "NEDSPN";

        /// <summary>
        /// NESIC.
        /// </summary>
        public const string NESIC = "NESIC";

        /// <summary>
        /// NEEFTB.
        /// </summary>
        public const string NEEFTB = "NEEFTB";

        /// <summary>
        /// NESTMB.
        /// </summary>
        public const string NESTMB = "NESTMB";

        /// <summary>
        /// NEEFTE.
        /// </summary>
        public const string NEEFTE = "NEEFTE";

        /// <summary>
        /// NEDSR.
        /// </summary>
        public const string NEDSR = "NEDSR";

        /// <summary>
        /// NEMP01.
        /// </summary>
        public const string NEMP01 = "NEMP01";

        /// <summary>
        /// NEMP02.
        /// </summary>
        public const string NEMP02 = "NEMP02";

        /// <summary>
        /// NEOLED.
        /// </summary>
        public const string NEOLED = "NEOLED";

        /// <summary>
        /// NECOMG.
        /// </summary>
        public const string NECOMG = "NECOMG";

        /// <summary>
        /// NERYRB.
        /// </summary>
        public const string NERYRB = "NERYRB";

        /// <summary>
        /// NELYRB.
        /// </summary>
        public const string NELYRB = "NELYRB";

        /// <summary>
        /// NEWTDL.
        /// </summary>
        public const string NEWTDL = "NEWTDL";

        /// <summary>
        /// NEPLNM.
        /// </summary>
        public const string NEPLNM = "NEPLNM";

        /// <summary>
        /// NESBLI.
        /// </summary>
        public const string NESBLI = "NESBLI";

        /// <summary>
        /// NECO.
        /// </summary>
        public const string NECO = "NECO";

        /// <summary>
        /// NECTRY.
        /// </summary>
        public const string NECTRY = "NECTRY";

        /// <summary>
        /// NEALP.
        /// </summary>
        public const string NEALP = "NEALP";

        /// <summary>
        /// NETOTD.
        /// </summary>
        public const string NETOTD = "NETOTD";

        /// <summary>
        /// NEAVD.
        /// </summary>
        public const string NEAVD = "NEAVD";

        /// <summary>
        /// NEDLI.
        /// </summary>
        public const string NEDLI = "NEDLI";

        /// <summary>
        /// NEDLP.
        /// </summary>
        public const string NEDLP = "NEDLP";

        /// <summary>
        /// NEURCD.
        /// </summary>
        public const string NEURCD = "NEURCD";

        /// <summary>
        /// NEURDT.
        /// </summary>
        public const string NEURDT = "NEURDT";

        /// <summary>
        /// NEURAT.
        /// </summary>
        public const string NEURAT = "NEURAT";

        /// <summary>
        /// NEURAB.
        /// </summary>
        public const string NEURAB = "NEURAB";

        /// <summary>
        /// NEOLSE.
        /// </summary>
        public const string NEOLSE = "NEOLSE";

        /// <summary>
        /// NEURRF.
        /// </summary>
        public const string NEURRF = "NEURRF";

        /// <summary>
        /// NEUSER.
        /// </summary>
        public const string NEUSER = "NEUSER";

        /// <summary>
        /// NEPID.
        /// </summary>
        public const string NEPID = "NEPID";

        /// <summary>
        /// NEUPMJ.
        /// </summary>
        public const string NEUPMJ = "NEUPMJ";

        /// <summary>
        /// NEUPMT.
        /// </summary>
        public const string NEUPMT = "NEUPMT";

        /// <summary>
        /// NEJOBN.
        /// </summary>
        public const string NEJOBN = "NEJOBN";

        /// <summary>
        /// NEENTJ.
        /// </summary>
        public const string NEENTJ = "NEENTJ";

        /// <summary>
        /// NETORG.
        /// </summary>
        public const string NETORG = "NETORG";

        /// <summary>
        /// NECRR.
        /// </summary>
        public const string NECRR = "NECRR";

        /// <summary>
        /// NEDCRF.
        /// </summary>
        public const string NEDCRF = "NEDCRF";

        /// <summary>
        /// NECRCD.
        /// </summary>
        public const string NECRCD = "NECRCD";

        /// <summary>
        /// NECRRM.
        /// </summary>
        public const string NECRRM = "NECRRM";

        /// <summary>
        /// NELELC.
        /// </summary>
        public const string NELELC = "NELELC";

        /// <summary>
        /// NELERCEO.
        /// </summary>
        public const string NELERCEO = "NELERCEO";

        /// <summary>
        /// NELEBR.
        /// </summary>
        public const string NELEBR = "NELEBR";

        /// <summary>
        /// NELEHC01.
        /// </summary>
        public const string NELEHC01 = "NELEHC01";

        /// <summary>
        /// NELEHC02.
        /// </summary>
        public const string NELEHC02 = "NELEHC02";

        /// <summary>
        /// NELEHC03.
        /// </summary>
        public const string NELEHC03 = "NELEHC03";

        /// <summary>
        /// NELEHC04.
        /// </summary>
        public const string NELEHC04 = "NELEHC04";

        /// <summary>
        /// NELEHC05.
        /// </summary>
        public const string NELEHC05 = "NELEHC05";

        /// <summary>
        /// NELEETF.
        /// </summary>
        public const string NELEETF = "NELEETF";
    }

    /// <inheritdoc />
    public override string TableName => "F1501B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NEDOCO", "NEDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("NELSVR", "NELSVR", JdeDataType.Numeric, null, true, true),
        new JdeField("NEVREF", "NEVREF", JdeDataType.Numeric),
        new JdeField("NEVRED", "NEVRED", JdeDataType.Numeric),
        new JdeField("NEVRS", "NEVRS", JdeDataType.Numeric),
        new JdeField("NEDCTO", "NEDCTO", JdeDataType.String, 4),
        new JdeField("NEDL01", "NEDL01", JdeDataType.String, 60),
        new JdeField("NEAN8", "NEAN8", JdeDataType.Numeric),
        new JdeField("NEAN8J", "NEAN8J", JdeDataType.Numeric),
        new JdeField("NEANSA", "NEANSA", JdeDataType.Numeric),
        new JdeField("NEAN8B", "NEAN8B", JdeDataType.Numeric),
        new JdeField("NEAN8P", "NEAN8P", JdeDataType.Numeric),
        new JdeField("NELSST", "NELSST", JdeDataType.String, 2),
        new JdeField("NEPMTC", "NEPMTC", JdeDataType.Numeric),
        new JdeField("NELSCD", "NELSCD", JdeDataType.String, 2),
        new JdeField("NELSET", "NELSET", JdeDataType.String, 4),
        new JdeField("NEOWLS", "NEOWLS", JdeDataType.String, 2),
        new JdeField("NEMGTF", "NEMGTF", JdeDataType.String, 2),
        new JdeField("NETRAR", "NETRAR", JdeDataType.String, 6),
        new JdeField("NEINVP", "NEINVP", JdeDataType.String, 2),
        new JdeField("NESTMP", "NESTMP", JdeDataType.String, 2),
        new JdeField("NESECN", "NESECN", JdeDataType.String, 2),
        new JdeField("NEDSPN", "NEDSPN", JdeDataType.String, 2),
        new JdeField("NESIC", "NESIC", JdeDataType.String, 20),
        new JdeField("NEEFTB", "NEEFTB", JdeDataType.Numeric),
        new JdeField("NESTMB", "NESTMB", JdeDataType.String, 2),
        new JdeField("NEEFTE", "NEEFTE", JdeDataType.Numeric),
        new JdeField("NEDSR", "NEDSR", JdeDataType.Numeric),
        new JdeField("NEMP01", "NEMP01", JdeDataType.Numeric),
        new JdeField("NEMP02", "NEMP02", JdeDataType.Numeric),
        new JdeField("NEOLED", "NEOLED", JdeDataType.Numeric),
        new JdeField("NECOMG", "NECOMG", JdeDataType.String, 20),
        new JdeField("NERYRB", "NERYRB", JdeDataType.Numeric),
        new JdeField("NELYRB", "NELYRB", JdeDataType.Numeric),
        new JdeField("NEWTDL", "NEWTDL", JdeDataType.Numeric),
        new JdeField("NEPLNM", "NEPLNM", JdeDataType.Numeric),
        new JdeField("NESBLI", "NESBLI", JdeDataType.String, 2),
        new JdeField("NECO", "NECO", JdeDataType.String, 10),
        new JdeField("NECTRY", "NECTRY", JdeDataType.Numeric),
        new JdeField("NEALP", "NEALP", JdeDataType.Numeric),
        new JdeField("NETOTD", "NETOTD", JdeDataType.Numeric),
        new JdeField("NEAVD", "NEAVD", JdeDataType.Numeric),
        new JdeField("NEDLI", "NEDLI", JdeDataType.Numeric),
        new JdeField("NEDLP", "NEDLP", JdeDataType.Numeric),
        new JdeField("NEURCD", "NEURCD", JdeDataType.String, 4),
        new JdeField("NEURDT", "NEURDT", JdeDataType.Numeric),
        new JdeField("NEURAT", "NEURAT", JdeDataType.Numeric),
        new JdeField("NEURAB", "NEURAB", JdeDataType.Numeric),
        new JdeField("NEOLSE", "NEOLSE", JdeDataType.String, 50),
        new JdeField("NEURRF", "NEURRF", JdeDataType.String, 30),
        new JdeField("NEUSER", "NEUSER", JdeDataType.String, 20),
        new JdeField("NEPID", "NEPID", JdeDataType.String, 20),
        new JdeField("NEUPMJ", "NEUPMJ", JdeDataType.Numeric),
        new JdeField("NEUPMT", "NEUPMT", JdeDataType.Numeric),
        new JdeField("NEJOBN", "NEJOBN", JdeDataType.String, 20),
        new JdeField("NEENTJ", "NEENTJ", JdeDataType.Numeric),
        new JdeField("NETORG", "NETORG", JdeDataType.String, 20),
        new JdeField("NECRR", "NECRR", JdeDataType.Numeric),
        new JdeField("NEDCRF", "NEDCRF", JdeDataType.String, 2),
        new JdeField("NECRCD", "NECRCD", JdeDataType.String, 6),
        new JdeField("NECRRM", "NECRRM", JdeDataType.String, 2),
        new JdeField("NELELC", "NELELC", JdeDataType.String, 2),
        new JdeField("NELERCEO", "NELERCEO", JdeDataType.String, 2),
        new JdeField("NELEBR", "NELEBR", JdeDataType.Numeric),
        new JdeField("NELEHC01", "NELEHC01", JdeDataType.String, 20),
        new JdeField("NELEHC02", "NELEHC02", JdeDataType.String, 20),
        new JdeField("NELEHC03", "NELEHC03", JdeDataType.String, 20),
        new JdeField("NELEHC04", "NELEHC04", JdeDataType.String, 20),
        new JdeField("NELEHC05", "NELEHC05", JdeDataType.String, 20),
        new JdeField("NELEETF", "NELEETF", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1501B_0", "Primary Key on NEDOCO, NELSVR", new[] { "NEDOCO", "NELSVR" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1501B_2", "Index on NEAN8J, NEDOCO, NELSVR", new[] { "NEAN8J", "NEDOCO", "NELSVR" }),
        new JdeIndex("F1501B_3", "Index on NEAN8, NEDOCO, NELSVR", new[] { "NEAN8", "NEDOCO", "NELSVR" }),
        new JdeIndex("F1501B_4", "Index on NEAN8P, NEDOCO, NELSVR", new[] { "NEAN8P", "NEDOCO", "NELSVR" }),
        new JdeIndex("F1501B_5", "Index on NEDOCO, SYS_NC00071$", new[] { "NEDOCO", "SYS_NC00071$" }),
        new JdeIndex("F1501B_6", "Index on NEDOCO, SYS_NC00072$", new[] { "NEDOCO", "SYS_NC00072$" }),
        new JdeIndex("F1501B_7", "Index on NEDOCO, NEVREF", new[] { "NEDOCO", "NEVREF" }),
        new JdeIndex("F1501B_8", "Index on NEANSA, NEDOCO, NELSVR", new[] { "NEANSA", "NEDOCO", "NELSVR" }),
        new JdeIndex("F1501B_9", "Index on NEOLSE", new[] { "NEOLSE" })
    };
}
