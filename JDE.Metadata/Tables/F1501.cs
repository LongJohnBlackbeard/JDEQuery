using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1501 - .
/// </summary>
public class F1501 : JdeTable
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
        /// NEDCTO.
        /// </summary>
        public const string NEDCTO = "NEDCTO";

        /// <summary>
        /// NEMCU.
        /// </summary>
        public const string NEMCU = "NEMCU";

        /// <summary>
        /// NEUNIT.
        /// </summary>
        public const string NEUNIT = "NEUNIT";

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
        /// NEAN8A.
        /// </summary>
        public const string NEAN8A = "NEAN8A";

        /// <summary>
        /// NEAN8S.
        /// </summary>
        public const string NEAN8S = "NEAN8S";

        /// <summary>
        /// NEANSA.
        /// </summary>
        public const string NEANSA = "NEANSA";

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
        /// NESIC.
        /// </summary>
        public const string NESIC = "NESIC";

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
        /// NESTMB.
        /// </summary>
        public const string NESTMB = "NESTMB";

        /// <summary>
        /// NEALP.
        /// </summary>
        public const string NEALP = "NEALP";

        /// <summary>
        /// NEWTDL.
        /// </summary>
        public const string NEWTDL = "NEWTDL";

        /// <summary>
        /// NETOTD.
        /// </summary>
        public const string NETOTD = "NETOTD";

        /// <summary>
        /// NEAVD.
        /// </summary>
        public const string NEAVD = "NEAVD";

        /// <summary>
        /// NEMCUS.
        /// </summary>
        public const string NEMCUS = "NEMCUS";

        /// <summary>
        /// NESMCU.
        /// </summary>
        public const string NESMCU = "NESMCU";

        /// <summary>
        /// NESIC2.
        /// </summary>
        public const string NESIC2 = "NESIC2";

        /// <summary>
        /// NECTRY.
        /// </summary>
        public const string NECTRY = "NECTRY";

        /// <summary>
        /// NEEFTB.
        /// </summary>
        public const string NEEFTB = "NEEFTB";

        /// <summary>
        /// NEEFTE.
        /// </summary>
        public const string NEEFTE = "NEEFTE";

        /// <summary>
        /// NEDSR.
        /// </summary>
        public const string NEDSR = "NEDSR";

        /// <summary>
        /// NEMIDT.
        /// </summary>
        public const string NEMIDT = "NEMIDT";

        /// <summary>
        /// NESPAD.
        /// </summary>
        public const string NESPAD = "NESPAD";

        /// <summary>
        /// NEMODT.
        /// </summary>
        public const string NEMODT = "NEMODT";

        /// <summary>
        /// NESBDT.
        /// </summary>
        public const string NESBDT = "NESBDT";

        /// <summary>
        /// NEDLI.
        /// </summary>
        public const string NEDLI = "NEDLI";

        /// <summary>
        /// NEDLP.
        /// </summary>
        public const string NEDLP = "NEDLP";

        /// <summary>
        /// NEMP01.
        /// </summary>
        public const string NEMP01 = "NEMP01";

        /// <summary>
        /// NEMP02.
        /// </summary>
        public const string NEMP02 = "NEMP02";

        /// <summary>
        /// NERNTA.
        /// </summary>
        public const string NERNTA = "NERNTA";

        /// <summary>
        /// NEUSEA.
        /// </summary>
        public const string NEUSEA = "NEUSEA";

        /// <summary>
        /// NERM01.
        /// </summary>
        public const string NERM01 = "NERM01";

        /// <summary>
        /// NERM02.
        /// </summary>
        public const string NERM02 = "NERM02";

        /// <summary>
        /// NERM03.
        /// </summary>
        public const string NERM03 = "NERM03";

        /// <summary>
        /// NERM04.
        /// </summary>
        public const string NERM04 = "NERM04";

        /// <summary>
        /// NERM05.
        /// </summary>
        public const string NERM05 = "NERM05";

        /// <summary>
        /// NERM06.
        /// </summary>
        public const string NERM06 = "NERM06";

        /// <summary>
        /// NERM07.
        /// </summary>
        public const string NERM07 = "NERM07";

        /// <summary>
        /// NERM08.
        /// </summary>
        public const string NERM08 = "NERM08";

        /// <summary>
        /// NERM09.
        /// </summary>
        public const string NERM09 = "NERM09";

        /// <summary>
        /// NERM10.
        /// </summary>
        public const string NERM10 = "NERM10";

        /// <summary>
        /// NESOCD.
        /// </summary>
        public const string NESOCD = "NESOCD";

        /// <summary>
        /// NEXPCD.
        /// </summary>
        public const string NEXPCD = "NEXPCD";

        /// <summary>
        /// NEESCD.
        /// </summary>
        public const string NEESCD = "NEESCD";

        /// <summary>
        /// NEUSER.
        /// </summary>
        public const string NEUSER = "NEUSER";

        /// <summary>
        /// NEUPMJ.
        /// </summary>
        public const string NEUPMJ = "NEUPMJ";

        /// <summary>
        /// NEPID.
        /// </summary>
        public const string NEPID = "NEPID";

        /// <summary>
        /// NEJOBN.
        /// </summary>
        public const string NEJOBN = "NEJOBN";

        /// <summary>
        /// NERYRB.
        /// </summary>
        public const string NERYRB = "NERYRB";

        /// <summary>
        /// NELYRB.
        /// </summary>
        public const string NELYRB = "NELYRB";

        /// <summary>
        /// NEAN8B.
        /// </summary>
        public const string NEAN8B = "NEAN8B";

        /// <summary>
        /// NECO.
        /// </summary>
        public const string NECO = "NECO";

        /// <summary>
        /// NEOLSE.
        /// </summary>
        public const string NEOLSE = "NEOLSE";

        /// <summary>
        /// NEDBUI.
        /// </summary>
        public const string NEDBUI = "NEDBUI";

        /// <summary>
        /// NEPLNM.
        /// </summary>
        public const string NEPLNM = "NEPLNM";

        /// <summary>
        /// NESPND.
        /// </summary>
        public const string NESPND = "NESPND";

        /// <summary>
        /// NEUPMT.
        /// </summary>
        public const string NEUPMT = "NEUPMT";

        /// <summary>
        /// NESBLI.
        /// </summary>
        public const string NESBLI = "NESBLI";
    }

    /// <inheritdoc />
    public override string TableName => "F1501";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NEDOCO", "NEDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("NEDCTO", "NEDCTO", JdeDataType.String, 4),
        new JdeField("NEMCU", "NEMCU", JdeDataType.String, 24, true, true),
        new JdeField("NEUNIT", "NEUNIT", JdeDataType.String, 16, true, true),
        new JdeField("NEDL01", "NEDL01", JdeDataType.String, 60),
        new JdeField("NEAN8", "NEAN8", JdeDataType.Numeric),
        new JdeField("NEAN8J", "NEAN8J", JdeDataType.Numeric),
        new JdeField("NEAN8A", "NEAN8A", JdeDataType.Numeric),
        new JdeField("NEAN8S", "NEAN8S", JdeDataType.Numeric),
        new JdeField("NEANSA", "NEANSA", JdeDataType.Numeric),
        new JdeField("NEAN8P", "NEAN8P", JdeDataType.Numeric),
        new JdeField("NELSST", "NELSST", JdeDataType.String, 2),
        new JdeField("NEPMTC", "NEPMTC", JdeDataType.Numeric),
        new JdeField("NELSCD", "NELSCD", JdeDataType.String, 2),
        new JdeField("NELSET", "NELSET", JdeDataType.String, 4),
        new JdeField("NEOWLS", "NEOWLS", JdeDataType.String, 2),
        new JdeField("NESIC", "NESIC", JdeDataType.String, 20),
        new JdeField("NEMGTF", "NEMGTF", JdeDataType.String, 2),
        new JdeField("NETRAR", "NETRAR", JdeDataType.String, 6),
        new JdeField("NEINVP", "NEINVP", JdeDataType.String, 2),
        new JdeField("NESTMP", "NESTMP", JdeDataType.String, 2),
        new JdeField("NESECN", "NESECN", JdeDataType.String, 2),
        new JdeField("NEDSPN", "NEDSPN", JdeDataType.String, 2),
        new JdeField("NESTMB", "NESTMB", JdeDataType.String, 2),
        new JdeField("NEALP", "NEALP", JdeDataType.Numeric),
        new JdeField("NEWTDL", "NEWTDL", JdeDataType.Numeric),
        new JdeField("NETOTD", "NETOTD", JdeDataType.Numeric),
        new JdeField("NEAVD", "NEAVD", JdeDataType.Numeric),
        new JdeField("NEMCUS", "NEMCUS", JdeDataType.String, 24),
        new JdeField("NESMCU", "NESMCU", JdeDataType.String, 24),
        new JdeField("NESIC2", "NESIC2", JdeDataType.String, 20),
        new JdeField("NECTRY", "NECTRY", JdeDataType.Numeric),
        new JdeField("NEEFTB", "NEEFTB", JdeDataType.Numeric),
        new JdeField("NEEFTE", "NEEFTE", JdeDataType.Numeric),
        new JdeField("NEDSR", "NEDSR", JdeDataType.Numeric),
        new JdeField("NEMIDT", "NEMIDT", JdeDataType.Numeric),
        new JdeField("NESPAD", "NESPAD", JdeDataType.Numeric),
        new JdeField("NEMODT", "NEMODT", JdeDataType.Numeric),
        new JdeField("NESBDT", "NESBDT", JdeDataType.Numeric),
        new JdeField("NEDLI", "NEDLI", JdeDataType.Numeric),
        new JdeField("NEDLP", "NEDLP", JdeDataType.Numeric),
        new JdeField("NEMP01", "NEMP01", JdeDataType.Numeric),
        new JdeField("NEMP02", "NEMP02", JdeDataType.Numeric),
        new JdeField("NERNTA", "NERNTA", JdeDataType.Numeric),
        new JdeField("NEUSEA", "NEUSEA", JdeDataType.Numeric),
        new JdeField("NERM01", "NERM01", JdeDataType.String, 6),
        new JdeField("NERM02", "NERM02", JdeDataType.String, 6),
        new JdeField("NERM03", "NERM03", JdeDataType.String, 6),
        new JdeField("NERM04", "NERM04", JdeDataType.String, 6),
        new JdeField("NERM05", "NERM05", JdeDataType.String, 6),
        new JdeField("NERM06", "NERM06", JdeDataType.String, 6),
        new JdeField("NERM07", "NERM07", JdeDataType.String, 6),
        new JdeField("NERM08", "NERM08", JdeDataType.String, 6),
        new JdeField("NERM09", "NERM09", JdeDataType.String, 6),
        new JdeField("NERM10", "NERM10", JdeDataType.String, 6),
        new JdeField("NESOCD", "NESOCD", JdeDataType.String, 2),
        new JdeField("NEXPCD", "NEXPCD", JdeDataType.String, 2),
        new JdeField("NEESCD", "NEESCD", JdeDataType.String, 2),
        new JdeField("NEUSER", "NEUSER", JdeDataType.String, 20),
        new JdeField("NEUPMJ", "NEUPMJ", JdeDataType.Numeric),
        new JdeField("NEPID", "NEPID", JdeDataType.String, 20),
        new JdeField("NEJOBN", "NEJOBN", JdeDataType.String, 20),
        new JdeField("NERYRB", "NERYRB", JdeDataType.Numeric),
        new JdeField("NELYRB", "NELYRB", JdeDataType.Numeric),
        new JdeField("NEAN8B", "NEAN8B", JdeDataType.Numeric),
        new JdeField("NECO", "NECO", JdeDataType.String, 10),
        new JdeField("NEOLSE", "NEOLSE", JdeDataType.String, 50),
        new JdeField("NEDBUI", "NEDBUI", JdeDataType.String, 2),
        new JdeField("NEPLNM", "NEPLNM", JdeDataType.Numeric),
        new JdeField("NESPND", "NESPND", JdeDataType.Numeric),
        new JdeField("NEUPMT", "NEUPMT", JdeDataType.Numeric),
        new JdeField("NESBLI", "NESBLI", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1501_0", "Primary Key on NEDOCO, NEMCU, NEUNIT", new[] { "NEDOCO", "NEMCU", "NEUNIT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1501_2", "Index on NEAN8", new[] { "NEAN8" }),
        new JdeIndex("F1501_3", "Index on NEAN8J", new[] { "NEAN8J" })
    };
}
