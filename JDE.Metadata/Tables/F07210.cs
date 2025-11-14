using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07210 - .
/// </summary>
public class F07210 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YDPAYD.
        /// </summary>
        public const string YDPAYD = "YDPAYD";

        /// <summary>
        /// YDPATY.
        /// </summary>
        public const string YDPATY = "YDPATY";

        /// <summary>
        /// YDDEFINT.
        /// </summary>
        public const string YDDEFINT = "YDDEFINT";

        /// <summary>
        /// YDPIPF.
        /// </summary>
        public const string YDPIPF = "YDPIPF";

        /// <summary>
        /// YDCHKDTOFF.
        /// </summary>
        public const string YDCHKDTOFF = "YDCHKDTOFF";

        /// <summary>
        /// YDPPST.
        /// </summary>
        public const string YDPPST = "YDPPST";

        /// <summary>
        /// YDCHKS.
        /// </summary>
        public const string YDCHKS = "YDCHKS";

        /// <summary>
        /// YDCKAS.
        /// </summary>
        public const string YDCKAS = "YDCKAS";

        /// <summary>
        /// YDADEF.
        /// </summary>
        public const string YDADEF = "YDADEF";

        /// <summary>
        /// YDADAS.
        /// </summary>
        public const string YDADAS = "YDADAS";

        /// <summary>
        /// YDAATS.
        /// </summary>
        public const string YDAATS = "YDAATS";

        /// <summary>
        /// YDJEST.
        /// </summary>
        public const string YDJEST = "YDJEST";

        /// <summary>
        /// YDROST.
        /// </summary>
        public const string YDROST = "YDROST";

        /// <summary>
        /// YDFUST.
        /// </summary>
        public const string YDFUST = "YDFUST";

        /// <summary>
        /// YDASF.
        /// </summary>
        public const string YDASF = "YDASF";

        /// <summary>
        /// YDYST1.
        /// </summary>
        public const string YDYST1 = "YDYST1";

        /// <summary>
        /// YDTTGR.
        /// </summary>
        public const string YDTTGR = "YDTTGR";

        /// <summary>
        /// YDTTNT.
        /// </summary>
        public const string YDTTNT = "YDTTNT";

        /// <summary>
        /// YDTTDE.
        /// </summary>
        public const string YDTTDE = "YDTTDE";

        /// <summary>
        /// YDTTHS.
        /// </summary>
        public const string YDTTHS = "YDTTHS";

        /// <summary>
        /// YDNPYM.
        /// </summary>
        public const string YDNPYM = "YDNPYM";

        /// <summary>
        /// YDNCKS.
        /// </summary>
        public const string YDNCKS = "YDNCKS";

        /// <summary>
        /// YDNCIC.
        /// </summary>
        public const string YDNCIC = "YDNCIC";

        /// <summary>
        /// YDNMIC.
        /// </summary>
        public const string YDNMIC = "YDNMIC";

        /// <summary>
        /// YDNAUD.
        /// </summary>
        public const string YDNAUD = "YDNAUD";

        /// <summary>
        /// YDNVOI.
        /// </summary>
        public const string YDNVOI = "YDNVOI";

        /// <summary>
        /// YDTNEP.
        /// </summary>
        public const string YDTNEP = "YDTNEP";

        /// <summary>
        /// YDPCCT.
        /// </summary>
        public const string YDPCCT = "YDPCCT";

        /// <summary>
        /// YDVERS.
        /// </summary>
        public const string YDVERS = "YDVERS";

        /// <summary>
        /// YDPCCD.
        /// </summary>
        public const string YDPCCD = "YDPCCD";

        /// <summary>
        /// YDDTEY.
        /// </summary>
        public const string YDDTEY = "YDDTEY";

        /// <summary>
        /// YDPPED.
        /// </summary>
        public const string YDPPED = "YDPPED";

        /// <summary>
        /// YDEFTB.
        /// </summary>
        public const string YDEFTB = "YDEFTB";

        /// <summary>
        /// YDEFTE.
        /// </summary>
        public const string YDEFTE = "YDEFTE";

        /// <summary>
        /// YDPPNB.
        /// </summary>
        public const string YDPPNB = "YDPPNB";

        /// <summary>
        /// YDNMAX.
        /// </summary>
        public const string YDNMAX = "YDNMAX";

        /// <summary>
        /// YDDNMN.
        /// </summary>
        public const string YDDNMN = "YDDNMN";

        /// <summary>
        /// YDPPMB.
        /// </summary>
        public const string YDPPMB = "YDPPMB";

        /// <summary>
        /// YDCCPR.
        /// </summary>
        public const string YDCCPR = "YDCCPR";

        /// <summary>
        /// YDCCUF.
        /// </summary>
        public const string YDCCUF = "YDCCUF";

        /// <summary>
        /// YDWCUF.
        /// </summary>
        public const string YDWCUF = "YDWCUF";

        /// <summary>
        /// YDGPOR.
        /// </summary>
        public const string YDGPOR = "YDGPOR";

        /// <summary>
        /// YDODBA.
        /// </summary>
        public const string YDODBA = "YDODBA";

        /// <summary>
        /// YDPYMH.
        /// </summary>
        public const string YDPYMH = "YDPYMH";

        /// <summary>
        /// YDADOF.
        /// </summary>
        public const string YDADOF = "YDADOF";

        /// <summary>
        /// YDADRF.
        /// </summary>
        public const string YDADRF = "YDADRF";

        /// <summary>
        /// YDWHRW.
        /// </summary>
        public const string YDWHRW = "YDWHRW";

        /// <summary>
        /// YDBHRW.
        /// </summary>
        public const string YDBHRW = "YDBHRW";

        /// <summary>
        /// YDSHRW.
        /// </summary>
        public const string YDSHRW = "YDSHRW";

        /// <summary>
        /// YDMHRW.
        /// </summary>
        public const string YDMHRW = "YDMHRW";

        /// <summary>
        /// YDOHRW.
        /// </summary>
        public const string YDOHRW = "YDOHRW";

        /// <summary>
        /// YDPPM1.
        /// </summary>
        public const string YDPPM1 = "YDPPM1";

        /// <summary>
        /// YDPPM2.
        /// </summary>
        public const string YDPPM2 = "YDPPM2";

        /// <summary>
        /// YDPPM3.
        /// </summary>
        public const string YDPPM3 = "YDPPM3";

        /// <summary>
        /// YDPPM4.
        /// </summary>
        public const string YDPPM4 = "YDPPM4";

        /// <summary>
        /// YDPPM5.
        /// </summary>
        public const string YDPPM5 = "YDPPM5";

        /// <summary>
        /// YDPPM6.
        /// </summary>
        public const string YDPPM6 = "YDPPM6";

        /// <summary>
        /// YDCO.
        /// </summary>
        public const string YDCO = "YDCO";

        /// <summary>
        /// YDCYGR.
        /// </summary>
        public const string YDCYGR = "YDCYGR";

        /// <summary>
        /// YDPCGT.
        /// </summary>
        public const string YDPCGT = "YDPCGT";

        /// <summary>
        /// YDGLBA.
        /// </summary>
        public const string YDGLBA = "YDGLBA";

        /// <summary>
        /// YDJCTY.
        /// </summary>
        public const string YDJCTY = "YDJCTY";

        /// <summary>
        /// YDAGDT.
        /// </summary>
        public const string YDAGDT = "YDAGDT";

        /// <summary>
        /// YDACCF.
        /// </summary>
        public const string YDACCF = "YDACCF";

        /// <summary>
        /// YDVER9.
        /// </summary>
        public const string YDVER9 = "YDVER9";

        /// <summary>
        /// YDSEQC.
        /// </summary>
        public const string YDSEQC = "YDSEQC";

        /// <summary>
        /// YDICU.
        /// </summary>
        public const string YDICU = "YDICU";

        /// <summary>
        /// YDPEF1.
        /// </summary>
        public const string YDPEF1 = "YDPEF1";

        /// <summary>
        /// YDADDT.
        /// </summary>
        public const string YDADDT = "YDADDT";

        /// <summary>
        /// YDCKDT.
        /// </summary>
        public const string YDCKDT = "YDCKDT";

        /// <summary>
        /// YDBCHK.
        /// </summary>
        public const string YDBCHK = "YDBCHK";

        /// <summary>
        /// YDBADV.
        /// </summary>
        public const string YDBADV = "YDBADV";

        /// <summary>
        /// YDMIPA.
        /// </summary>
        public const string YDMIPA = "YDMIPA";

        /// <summary>
        /// YDCAUT.
        /// </summary>
        public const string YDCAUT = "YDCAUT";

        /// <summary>
        /// YDOVBA.
        /// </summary>
        public const string YDOVBA = "YDOVBA";

        /// <summary>
        /// YDVICU.
        /// </summary>
        public const string YDVICU = "YDVICU";

        /// <summary>
        /// YDARST.
        /// </summary>
        public const string YDARST = "YDARST";

        /// <summary>
        /// YDCKPG.
        /// </summary>
        public const string YDCKPG = "YDCKPG";

        /// <summary>
        /// YDCKVE.
        /// </summary>
        public const string YDCKVE = "YDCKVE";

        /// <summary>
        /// YDCAPG.
        /// </summary>
        public const string YDCAPG = "YDCAPG";

        /// <summary>
        /// YDCAVE.
        /// </summary>
        public const string YDCAVE = "YDCAVE";

        /// <summary>
        /// YDCSNL.
        /// </summary>
        public const string YDCSNL = "YDCSNL";

        /// <summary>
        /// YDADPG.
        /// </summary>
        public const string YDADPG = "YDADPG";

        /// <summary>
        /// YDADVE.
        /// </summary>
        public const string YDADVE = "YDADVE";

        /// <summary>
        /// YDAAPG.
        /// </summary>
        public const string YDAAPG = "YDAAPG";

        /// <summary>
        /// YDAAVE.
        /// </summary>
        public const string YDAAVE = "YDAAVE";

        /// <summary>
        /// YDADNL.
        /// </summary>
        public const string YDADNL = "YDADNL";

        /// <summary>
        /// YDDAPG.
        /// </summary>
        public const string YDDAPG = "YDDAPG";

        /// <summary>
        /// YDDAVE.
        /// </summary>
        public const string YDDAVE = "YDDAVE";

        /// <summary>
        /// YDCTRY.
        /// </summary>
        public const string YDCTRY = "YDCTRY";

        /// <summary>
        /// YDLVBL.
        /// </summary>
        public const string YDLVBL = "YDLVBL";

        /// <summary>
        /// YDADPT.
        /// </summary>
        public const string YDADPT = "YDADPT";

        /// <summary>
        /// YDADPK.
        /// </summary>
        public const string YDADPK = "YDADPK";

        /// <summary>
        /// YDPJVC.
        /// </summary>
        public const string YDPJVC = "YDPJVC";

        /// <summary>
        /// YDUPMJ.
        /// </summary>
        public const string YDUPMJ = "YDUPMJ";

        /// <summary>
        /// YDUPMT.
        /// </summary>
        public const string YDUPMT = "YDUPMT";

        /// <summary>
        /// YDPID.
        /// </summary>
        public const string YDPID = "YDPID";

        /// <summary>
        /// YDJOBN.
        /// </summary>
        public const string YDJOBN = "YDJOBN";

        /// <summary>
        /// YDUSER.
        /// </summary>
        public const string YDUSER = "YDUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F07210";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YDPAYD", "YDPAYD", JdeDataType.String, 20, true, true),
        new JdeField("YDPATY", "YDPATY", JdeDataType.String, 2),
        new JdeField("YDDEFINT", "YDDEFINT", JdeDataType.String, 2),
        new JdeField("YDPIPF", "YDPIPF", JdeDataType.String, 2),
        new JdeField("YDCHKDTOFF", "YDCHKDTOFF", JdeDataType.Numeric),
        new JdeField("YDPPST", "YDPPST", JdeDataType.String, 2),
        new JdeField("YDCHKS", "YDCHKS", JdeDataType.String, 2),
        new JdeField("YDCKAS", "YDCKAS", JdeDataType.String, 2),
        new JdeField("YDADEF", "YDADEF", JdeDataType.String, 2),
        new JdeField("YDADAS", "YDADAS", JdeDataType.String, 2),
        new JdeField("YDAATS", "YDAATS", JdeDataType.String, 2),
        new JdeField("YDJEST", "YDJEST", JdeDataType.String, 2),
        new JdeField("YDROST", "YDROST", JdeDataType.String, 2),
        new JdeField("YDFUST", "YDFUST", JdeDataType.String, 2),
        new JdeField("YDASF", "YDASF", JdeDataType.String, 2),
        new JdeField("YDYST1", "YDYST1", JdeDataType.String, 2),
        new JdeField("YDTTGR", "YDTTGR", JdeDataType.Numeric),
        new JdeField("YDTTNT", "YDTTNT", JdeDataType.Numeric),
        new JdeField("YDTTDE", "YDTTDE", JdeDataType.Numeric),
        new JdeField("YDTTHS", "YDTTHS", JdeDataType.Numeric),
        new JdeField("YDNPYM", "YDNPYM", JdeDataType.Numeric),
        new JdeField("YDNCKS", "YDNCKS", JdeDataType.Numeric),
        new JdeField("YDNCIC", "YDNCIC", JdeDataType.Numeric),
        new JdeField("YDNMIC", "YDNMIC", JdeDataType.Numeric),
        new JdeField("YDNAUD", "YDNAUD", JdeDataType.Numeric),
        new JdeField("YDNVOI", "YDNVOI", JdeDataType.Numeric),
        new JdeField("YDTNEP", "YDTNEP", JdeDataType.Numeric),
        new JdeField("YDPCCT", "YDPCCT", JdeDataType.Numeric),
        new JdeField("YDVERS", "YDVERS", JdeDataType.String, 20),
        new JdeField("YDPCCD", "YDPCCD", JdeDataType.String, 10),
        new JdeField("YDDTEY", "YDDTEY", JdeDataType.Numeric),
        new JdeField("YDPPED", "YDPPED", JdeDataType.Numeric),
        new JdeField("YDEFTB", "YDEFTB", JdeDataType.Numeric),
        new JdeField("YDEFTE", "YDEFTE", JdeDataType.Numeric),
        new JdeField("YDPPNB", "YDPPNB", JdeDataType.String, 6),
        new JdeField("YDNMAX", "YDNMAX", JdeDataType.Numeric),
        new JdeField("YDDNMN", "YDDNMN", JdeDataType.Numeric),
        new JdeField("YDPPMB", "YDPPMB", JdeDataType.String, 2),
        new JdeField("YDCCPR", "YDCCPR", JdeDataType.String, 6),
        new JdeField("YDCCUF", "YDCCUF", JdeDataType.String, 2),
        new JdeField("YDWCUF", "YDWCUF", JdeDataType.String, 2),
        new JdeField("YDGPOR", "YDGPOR", JdeDataType.String, 2),
        new JdeField("YDODBA", "YDODBA", JdeDataType.String, 2),
        new JdeField("YDPYMH", "YDPYMH", JdeDataType.String, 2),
        new JdeField("YDADOF", "YDADOF", JdeDataType.String, 2),
        new JdeField("YDADRF", "YDADRF", JdeDataType.String, 2),
        new JdeField("YDWHRW", "YDWHRW", JdeDataType.Numeric),
        new JdeField("YDBHRW", "YDBHRW", JdeDataType.Numeric),
        new JdeField("YDSHRW", "YDSHRW", JdeDataType.Numeric),
        new JdeField("YDMHRW", "YDMHRW", JdeDataType.Numeric),
        new JdeField("YDOHRW", "YDOHRW", JdeDataType.Numeric),
        new JdeField("YDPPM1", "YDPPM1", JdeDataType.String, 2),
        new JdeField("YDPPM2", "YDPPM2", JdeDataType.String, 2),
        new JdeField("YDPPM3", "YDPPM3", JdeDataType.String, 2),
        new JdeField("YDPPM4", "YDPPM4", JdeDataType.String, 2),
        new JdeField("YDPPM5", "YDPPM5", JdeDataType.String, 2),
        new JdeField("YDPPM6", "YDPPM6", JdeDataType.String, 2),
        new JdeField("YDCO", "YDCO", JdeDataType.String, 10),
        new JdeField("YDCYGR", "YDCYGR", JdeDataType.String, 4),
        new JdeField("YDPCGT", "YDPCGT", JdeDataType.String, 2),
        new JdeField("YDGLBA", "YDGLBA", JdeDataType.String, 16),
        new JdeField("YDJCTY", "YDJCTY", JdeDataType.String, 2),
        new JdeField("YDAGDT", "YDAGDT", JdeDataType.Numeric),
        new JdeField("YDACCF", "YDACCF", JdeDataType.Numeric),
        new JdeField("YDVER9", "YDVER9", JdeDataType.String, 20),
        new JdeField("YDSEQC", "YDSEQC", JdeDataType.String, 2),
        new JdeField("YDICU", "YDICU", JdeDataType.Numeric),
        new JdeField("YDPEF1", "YDPEF1", JdeDataType.String, 2),
        new JdeField("YDADDT", "YDADDT", JdeDataType.Numeric),
        new JdeField("YDCKDT", "YDCKDT", JdeDataType.Numeric),
        new JdeField("YDBCHK", "YDBCHK", JdeDataType.String, 16),
        new JdeField("YDBADV", "YDBADV", JdeDataType.Numeric),
        new JdeField("YDMIPA", "YDMIPA", JdeDataType.String, 2),
        new JdeField("YDCAUT", "YDCAUT", JdeDataType.String, 2),
        new JdeField("YDOVBA", "YDOVBA", JdeDataType.String, 16),
        new JdeField("YDVICU", "YDVICU", JdeDataType.Numeric),
        new JdeField("YDARST", "YDARST", JdeDataType.String, 2),
        new JdeField("YDCKPG", "YDCKPG", JdeDataType.String, 20),
        new JdeField("YDCKVE", "YDCKVE", JdeDataType.String, 20),
        new JdeField("YDCAPG", "YDCAPG", JdeDataType.String, 20),
        new JdeField("YDCAVE", "YDCAVE", JdeDataType.String, 20),
        new JdeField("YDCSNL", "YDCSNL", JdeDataType.Numeric),
        new JdeField("YDADPG", "YDADPG", JdeDataType.String, 20),
        new JdeField("YDADVE", "YDADVE", JdeDataType.String, 20),
        new JdeField("YDAAPG", "YDAAPG", JdeDataType.String, 20),
        new JdeField("YDAAVE", "YDAAVE", JdeDataType.String, 20),
        new JdeField("YDADNL", "YDADNL", JdeDataType.Numeric),
        new JdeField("YDDAPG", "YDDAPG", JdeDataType.String, 20),
        new JdeField("YDDAVE", "YDDAVE", JdeDataType.String, 20),
        new JdeField("YDCTRY", "YDCTRY", JdeDataType.Numeric),
        new JdeField("YDLVBL", "YDLVBL", JdeDataType.String, 2),
        new JdeField("YDADPT", "YDADPT", JdeDataType.String, 2),
        new JdeField("YDADPK", "YDADPK", JdeDataType.String, 2),
        new JdeField("YDPJVC", "YDPJVC", JdeDataType.Numeric),
        new JdeField("YDUPMJ", "YDUPMJ", JdeDataType.Numeric),
        new JdeField("YDUPMT", "YDUPMT", JdeDataType.Numeric),
        new JdeField("YDPID", "YDPID", JdeDataType.String, 20),
        new JdeField("YDJOBN", "YDJOBN", JdeDataType.String, 20),
        new JdeField("YDUSER", "YDUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07210_0", "Primary Key on YDPAYD", new[] { "YDPAYD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F07210_2", "Index on YDICU", new[] { "YDICU" }),
        new JdeIndex("F07210_3", "Index on YDVICU", new[] { "YDVICU" })
    };
}
