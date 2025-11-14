using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06210 - .
/// </summary>
public class F06210 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YDPRID.
        /// </summary>
        public const string YDPRID = "YDPRID";

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
        /// YDCO.
        /// </summary>
        public const string YDCO = "YDCO";

        /// <summary>
        /// YDPPED.
        /// </summary>
        public const string YDPPED = "YDPPED";

        /// <summary>
        /// YDPCTC.
        /// </summary>
        public const string YDPCTC = "YDPCTC";

        /// <summary>
        /// YDJCTY.
        /// </summary>
        public const string YDJCTY = "YDJCTY";

        /// <summary>
        /// YDEFTB.
        /// </summary>
        public const string YDEFTB = "YDEFTB";

        /// <summary>
        /// YDEFTE.
        /// </summary>
        public const string YDEFTE = "YDEFTE";

        /// <summary>
        /// YDCKDT.
        /// </summary>
        public const string YDCKDT = "YDCKDT";

        /// <summary>
        /// YDAGDT.
        /// </summary>
        public const string YDAGDT = "YDAGDT";

        /// <summary>
        /// YDGLBA.
        /// </summary>
        public const string YDGLBA = "YDGLBA";

        /// <summary>
        /// YDCYGR.
        /// </summary>
        public const string YDCYGR = "YDCYGR";

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
        /// YDAHRW.
        /// </summary>
        public const string YDAHRW = "YDAHRW";

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
        /// YDACCF.
        /// </summary>
        public const string YDACCF = "YDACCF";

        /// <summary>
        /// YDVER1.
        /// </summary>
        public const string YDVER1 = "YDVER1";

        /// <summary>
        /// YDVER2.
        /// </summary>
        public const string YDVER2 = "YDVER2";

        /// <summary>
        /// YDVER3.
        /// </summary>
        public const string YDVER3 = "YDVER3";

        /// <summary>
        /// YDVER4.
        /// </summary>
        public const string YDVER4 = "YDVER4";

        /// <summary>
        /// YDVER5.
        /// </summary>
        public const string YDVER5 = "YDVER5";

        /// <summary>
        /// YDVER6.
        /// </summary>
        public const string YDVER6 = "YDVER6";

        /// <summary>
        /// YDVER7.
        /// </summary>
        public const string YDVER7 = "YDVER7";

        /// <summary>
        /// YDVER8.
        /// </summary>
        public const string YDVER8 = "YDVER8";

        /// <summary>
        /// YDVER9.
        /// </summary>
        public const string YDVER9 = "YDVER9";

        /// <summary>
        /// YDSEQC.
        /// </summary>
        public const string YDSEQC = "YDSEQC";

        /// <summary>
        /// YDNMAX.
        /// </summary>
        public const string YDNMAX = "YDNMAX";

        /// <summary>
        /// YDPPST.
        /// </summary>
        public const string YDPPST = "YDPPST";

        /// <summary>
        /// YDCKST.
        /// </summary>
        public const string YDCKST = "YDCKST";

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
        /// YDYST1.
        /// </summary>
        public const string YDYST1 = "YDYST1";

        /// <summary>
        /// YDYST2.
        /// </summary>
        public const string YDYST2 = "YDYST2";

        /// <summary>
        /// YDYST3.
        /// </summary>
        public const string YDYST3 = "YDYST3";

        /// <summary>
        /// YDICU.
        /// </summary>
        public const string YDICU = "YDICU";

        /// <summary>
        /// YDDNMN.
        /// </summary>
        public const string YDDNMN = "YDDNMN";

        /// <summary>
        /// YDPYDT.
        /// </summary>
        public const string YDPYDT = "YDPYDT";

        /// <summary>
        /// YDPCCT.
        /// </summary>
        public const string YDPCCT = "YDPCCT";

        /// <summary>
        /// YDPPMB.
        /// </summary>
        public const string YDPPMB = "YDPPMB";

        /// <summary>
        /// YDRNUM.
        /// </summary>
        public const string YDRNUM = "YDRNUM";

        /// <summary>
        /// YDPYMH.
        /// </summary>
        public const string YDPYMH = "YDPYMH";

        /// <summary>
        /// YDMANB.
        /// </summary>
        public const string YDMANB = "YDMANB";

        /// <summary>
        /// YDCCPR.
        /// </summary>
        public const string YDCCPR = "YDCCPR";

        /// <summary>
        /// YDDL02.
        /// </summary>
        public const string YDDL02 = "YDDL02";

        /// <summary>
        /// YDADOF.
        /// </summary>
        public const string YDADOF = "YDADOF";

        /// <summary>
        /// YDMNAF.
        /// </summary>
        public const string YDMNAF = "YDMNAF";

        /// <summary>
        /// YDADRF.
        /// </summary>
        public const string YDADRF = "YDADRF";

        /// <summary>
        /// YDARST.
        /// </summary>
        public const string YDARST = "YDARST";

        /// <summary>
        /// YDPEF1.
        /// </summary>
        public const string YDPEF1 = "YDPEF1";

        /// <summary>
        /// YDPEF2.
        /// </summary>
        public const string YDPEF2 = "YDPEF2";

        /// <summary>
        /// YDPEF3.
        /// </summary>
        public const string YDPEF3 = "YDPEF3";

        /// <summary>
        /// YDPEF4.
        /// </summary>
        public const string YDPEF4 = "YDPEF4";

        /// <summary>
        /// YDPEF5.
        /// </summary>
        public const string YDPEF5 = "YDPEF5";

        /// <summary>
        /// YDPCGT.
        /// </summary>
        public const string YDPCGT = "YDPCGT";

        /// <summary>
        /// YDCKPF.
        /// </summary>
        public const string YDCKPF = "YDCKPF";

        /// <summary>
        /// YDASF.
        /// </summary>
        public const string YDASF = "YDASF";

        /// <summary>
        /// YDCCUF.
        /// </summary>
        public const string YDCCUF = "YDCCUF";

        /// <summary>
        /// YDWCUF.
        /// </summary>
        public const string YDWCUF = "YDWCUF";

        /// <summary>
        /// YDADEF.
        /// </summary>
        public const string YDADEF = "YDADEF";

        /// <summary>
        /// YDADDT.
        /// </summary>
        public const string YDADDT = "YDADDT";

        /// <summary>
        /// YDADPC.
        /// </summary>
        public const string YDADPC = "YDADPC";

        /// <summary>
        /// YDADPO.
        /// </summary>
        public const string YDADPO = "YDADPO";

        /// <summary>
        /// YDGPOR.
        /// </summary>
        public const string YDGPOR = "YDGPOR";

        /// <summary>
        /// YDELCT.
        /// </summary>
        public const string YDELCT = "YDELCT";

        /// <summary>
        /// YDACUS.
        /// </summary>
        public const string YDACUS = "YDACUS";

        /// <summary>
        /// YDODBA.
        /// </summary>
        public const string YDODBA = "YDODBA";

        /// <summary>
        /// YDVICU.
        /// </summary>
        public const string YDVICU = "YDVICU";

        /// <summary>
        /// YDDTSP.
        /// </summary>
        public const string YDDTSP = "YDDTSP";

        /// <summary>
        /// YDUSER.
        /// </summary>
        public const string YDUSER = "YDUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F06210";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YDPRID", "YDPRID", JdeDataType.Numeric, null, true, true),
        new JdeField("YDVERS", "YDVERS", JdeDataType.String, 20),
        new JdeField("YDPCCD", "YDPCCD", JdeDataType.String, 10),
        new JdeField("YDDTEY", "YDDTEY", JdeDataType.Numeric),
        new JdeField("YDCO", "YDCO", JdeDataType.String, 10),
        new JdeField("YDPPED", "YDPPED", JdeDataType.Numeric),
        new JdeField("YDPCTC", "YDPCTC", JdeDataType.String, 2),
        new JdeField("YDJCTY", "YDJCTY", JdeDataType.String, 2),
        new JdeField("YDEFTB", "YDEFTB", JdeDataType.Numeric),
        new JdeField("YDEFTE", "YDEFTE", JdeDataType.Numeric),
        new JdeField("YDCKDT", "YDCKDT", JdeDataType.Numeric),
        new JdeField("YDAGDT", "YDAGDT", JdeDataType.Numeric),
        new JdeField("YDGLBA", "YDGLBA", JdeDataType.String, 16),
        new JdeField("YDCYGR", "YDCYGR", JdeDataType.String, 4),
        new JdeField("YDWHRW", "YDWHRW", JdeDataType.Numeric),
        new JdeField("YDBHRW", "YDBHRW", JdeDataType.Numeric),
        new JdeField("YDSHRW", "YDSHRW", JdeDataType.Numeric),
        new JdeField("YDMHRW", "YDMHRW", JdeDataType.Numeric),
        new JdeField("YDAHRW", "YDAHRW", JdeDataType.Numeric),
        new JdeField("YDOHRW", "YDOHRW", JdeDataType.Numeric),
        new JdeField("YDPPM1", "YDPPM1", JdeDataType.String, 2),
        new JdeField("YDPPM2", "YDPPM2", JdeDataType.String, 2),
        new JdeField("YDPPM3", "YDPPM3", JdeDataType.String, 2),
        new JdeField("YDPPM4", "YDPPM4", JdeDataType.String, 2),
        new JdeField("YDPPM5", "YDPPM5", JdeDataType.String, 2),
        new JdeField("YDPPM6", "YDPPM6", JdeDataType.String, 2),
        new JdeField("YDACCF", "YDACCF", JdeDataType.Numeric),
        new JdeField("YDVER1", "YDVER1", JdeDataType.String, 20),
        new JdeField("YDVER2", "YDVER2", JdeDataType.String, 20),
        new JdeField("YDVER3", "YDVER3", JdeDataType.String, 20),
        new JdeField("YDVER4", "YDVER4", JdeDataType.String, 20),
        new JdeField("YDVER5", "YDVER5", JdeDataType.String, 20),
        new JdeField("YDVER6", "YDVER6", JdeDataType.String, 20),
        new JdeField("YDVER7", "YDVER7", JdeDataType.String, 20),
        new JdeField("YDVER8", "YDVER8", JdeDataType.String, 20),
        new JdeField("YDVER9", "YDVER9", JdeDataType.String, 20),
        new JdeField("YDSEQC", "YDSEQC", JdeDataType.String, 2),
        new JdeField("YDNMAX", "YDNMAX", JdeDataType.Numeric),
        new JdeField("YDPPST", "YDPPST", JdeDataType.String, 2),
        new JdeField("YDCKST", "YDCKST", JdeDataType.String, 2),
        new JdeField("YDJEST", "YDJEST", JdeDataType.String, 2),
        new JdeField("YDROST", "YDROST", JdeDataType.String, 2),
        new JdeField("YDFUST", "YDFUST", JdeDataType.String, 2),
        new JdeField("YDYST1", "YDYST1", JdeDataType.String, 2),
        new JdeField("YDYST2", "YDYST2", JdeDataType.String, 2),
        new JdeField("YDYST3", "YDYST3", JdeDataType.String, 2),
        new JdeField("YDICU", "YDICU", JdeDataType.Numeric),
        new JdeField("YDDNMN", "YDDNMN", JdeDataType.Numeric),
        new JdeField("YDPYDT", "YDPYDT", JdeDataType.Numeric),
        new JdeField("YDPCCT", "YDPCCT", JdeDataType.Numeric),
        new JdeField("YDPPMB", "YDPPMB", JdeDataType.String, 2),
        new JdeField("YDRNUM", "YDRNUM", JdeDataType.Numeric),
        new JdeField("YDPYMH", "YDPYMH", JdeDataType.String, 2),
        new JdeField("YDMANB", "YDMANB", JdeDataType.String, 2),
        new JdeField("YDCCPR", "YDCCPR", JdeDataType.String, 6),
        new JdeField("YDDL02", "YDDL02", JdeDataType.String, 60),
        new JdeField("YDADOF", "YDADOF", JdeDataType.String, 2),
        new JdeField("YDMNAF", "YDMNAF", JdeDataType.String, 2),
        new JdeField("YDADRF", "YDADRF", JdeDataType.String, 2),
        new JdeField("YDARST", "YDARST", JdeDataType.String, 2),
        new JdeField("YDPEF1", "YDPEF1", JdeDataType.String, 2),
        new JdeField("YDPEF2", "YDPEF2", JdeDataType.String, 2),
        new JdeField("YDPEF3", "YDPEF3", JdeDataType.String, 2),
        new JdeField("YDPEF4", "YDPEF4", JdeDataType.String, 2),
        new JdeField("YDPEF5", "YDPEF5", JdeDataType.String, 2),
        new JdeField("YDPCGT", "YDPCGT", JdeDataType.String, 2),
        new JdeField("YDCKPF", "YDCKPF", JdeDataType.String, 2),
        new JdeField("YDASF", "YDASF", JdeDataType.String, 2),
        new JdeField("YDCCUF", "YDCCUF", JdeDataType.String, 2),
        new JdeField("YDWCUF", "YDWCUF", JdeDataType.String, 2),
        new JdeField("YDADEF", "YDADEF", JdeDataType.String, 2),
        new JdeField("YDADDT", "YDADDT", JdeDataType.Numeric),
        new JdeField("YDADPC", "YDADPC", JdeDataType.String, 2),
        new JdeField("YDADPO", "YDADPO", JdeDataType.String, 2),
        new JdeField("YDGPOR", "YDGPOR", JdeDataType.String, 2),
        new JdeField("YDELCT", "YDELCT", JdeDataType.String, 2),
        new JdeField("YDACUS", "YDACUS", JdeDataType.Numeric),
        new JdeField("YDODBA", "YDODBA", JdeDataType.String, 2),
        new JdeField("YDVICU", "YDVICU", JdeDataType.Numeric),
        new JdeField("YDDTSP", "YDDTSP", JdeDataType.Numeric),
        new JdeField("YDUSER", "YDUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06210_0", "Primary Key on YDPRID", new[] { "YDPRID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F06210_2", "Index on YDICU", new[] { "YDICU" }),
        new JdeIndex("F06210_3", "Index on YDVERS", new[] { "YDVERS" })
    };
}
