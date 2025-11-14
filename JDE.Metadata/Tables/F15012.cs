using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15012 - .
/// </summary>
public class F15012 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NSDOCO.
        /// </summary>
        public const string NSDOCO = "NSDOCO";

        /// <summary>
        /// NSDCTO.
        /// </summary>
        public const string NSDCTO = "NSDCTO";

        /// <summary>
        /// NSEPCL.
        /// </summary>
        public const string NSEPCL = "NSEPCL";

        /// <summary>
        /// NSEPGR.
        /// </summary>
        public const string NSEPGR = "NSEPGR";

        /// <summary>
        /// NSEPSG.
        /// </summary>
        public const string NSEPSG = "NSEPSG";

        /// <summary>
        /// NSDL01.
        /// </summary>
        public const string NSDL01 = "NSDL01";

        /// <summary>
        /// NSDL02.
        /// </summary>
        public const string NSDL02 = "NSDL02";

        /// <summary>
        /// NSFERT.
        /// </summary>
        public const string NSFERT = "NSFERT";

        /// <summary>
        /// NSEPOF.
        /// </summary>
        public const string NSEPOF = "NSEPOF";

        /// <summary>
        /// NSBSEX.
        /// </summary>
        public const string NSBSEX = "NSBSEX";

        /// <summary>
        /// NSBPSY.
        /// </summary>
        public const string NSBPSY = "NSBPSY";

        /// <summary>
        /// NSBPSM.
        /// </summary>
        public const string NSBPSM = "NSBPSM";

        /// <summary>
        /// NSCPFC.
        /// </summary>
        public const string NSCPFC = "NSCPFC";

        /// <summary>
        /// NSEPCP.
        /// </summary>
        public const string NSEPCP = "NSEPCP";

        /// <summary>
        /// NSGLC.
        /// </summary>
        public const string NSGLC = "NSGLC";

        /// <summary>
        /// NSBLGR.
        /// </summary>
        public const string NSBLGR = "NSBLGR";

        /// <summary>
        /// NSMCU.
        /// </summary>
        public const string NSMCU = "NSMCU";

        /// <summary>
        /// NSUNIT.
        /// </summary>
        public const string NSUNIT = "NSUNIT";

        /// <summary>
        /// NSDEAL.
        /// </summary>
        public const string NSDEAL = "NSDEAL";

        /// <summary>
        /// NSEFTB.
        /// </summary>
        public const string NSEFTB = "NSEFTB";

        /// <summary>
        /// NSEFTE.
        /// </summary>
        public const string NSEFTE = "NSEFTE";

        /// <summary>
        /// NSPCTP.
        /// </summary>
        public const string NSPCTP = "NSPCTP";

        /// <summary>
        /// NSBLFC.
        /// </summary>
        public const string NSBLFC = "NSBLFC";

        /// <summary>
        /// NSBF01.
        /// </summary>
        public const string NSBF01 = "NSBF01";

        /// <summary>
        /// NSBF02.
        /// </summary>
        public const string NSBF02 = "NSBF02";

        /// <summary>
        /// NSBF03.
        /// </summary>
        public const string NSBF03 = "NSBF03";

        /// <summary>
        /// NSBF04.
        /// </summary>
        public const string NSBF04 = "NSBF04";

        /// <summary>
        /// NSBF05.
        /// </summary>
        public const string NSBF05 = "NSBF05";

        /// <summary>
        /// NSBF06.
        /// </summary>
        public const string NSBF06 = "NSBF06";

        /// <summary>
        /// NSBF07.
        /// </summary>
        public const string NSBF07 = "NSBF07";

        /// <summary>
        /// NSBF08.
        /// </summary>
        public const string NSBF08 = "NSBF08";

        /// <summary>
        /// NSBF09.
        /// </summary>
        public const string NSBF09 = "NSBF09";

        /// <summary>
        /// NSBF10.
        /// </summary>
        public const string NSBF10 = "NSBF10";

        /// <summary>
        /// NSBF11.
        /// </summary>
        public const string NSBF11 = "NSBF11";

        /// <summary>
        /// NSBF12.
        /// </summary>
        public const string NSBF12 = "NSBF12";

        /// <summary>
        /// NSBF13.
        /// </summary>
        public const string NSBF13 = "NSBF13";

        /// <summary>
        /// NSEPCD.
        /// </summary>
        public const string NSEPCD = "NSEPCD";

        /// <summary>
        /// NSECMP.
        /// </summary>
        public const string NSECMP = "NSECMP";

        /// <summary>
        /// NSEXCD.
        /// </summary>
        public const string NSEXCD = "NSEXCD";

        /// <summary>
        /// NSBRCD.
        /// </summary>
        public const string NSBRCD = "NSBRCD";

        /// <summary>
        /// NSBRAD.
        /// </summary>
        public const string NSBRAD = "NSBRAD";

        /// <summary>
        /// NSEPLM.
        /// </summary>
        public const string NSEPLM = "NSEPLM";

        /// <summary>
        /// NSAN8J.
        /// </summary>
        public const string NSAN8J = "NSAN8J";

        /// <summary>
        /// NSTRAR.
        /// </summary>
        public const string NSTRAR = "NSTRAR";

        /// <summary>
        /// NSSEPI.
        /// </summary>
        public const string NSSEPI = "NSSEPI";

        /// <summary>
        /// NSITMG.
        /// </summary>
        public const string NSITMG = "NSITMG";

        /// <summary>
        /// NSSUSP.
        /// </summary>
        public const string NSSUSP = "NSSUSP";

        /// <summary>
        /// NSBLMN.
        /// </summary>
        public const string NSBLMN = "NSBLMN";

        /// <summary>
        /// NSBCI.
        /// </summary>
        public const string NSBCI = "NSBCI";

        /// <summary>
        /// NSCRCD.
        /// </summary>
        public const string NSCRCD = "NSCRCD";

        /// <summary>
        /// NSTXA1.
        /// </summary>
        public const string NSTXA1 = "NSTXA1";

        /// <summary>
        /// NSEXR1.
        /// </summary>
        public const string NSEXR1 = "NSEXR1";

        /// <summary>
        /// NSOCRL.
        /// </summary>
        public const string NSOCRL = "NSOCRL";

        /// <summary>
        /// NSOCPB.
        /// </summary>
        public const string NSOCPB = "NSOCPB";

        /// <summary>
        /// NSOCPE.
        /// </summary>
        public const string NSOCPE = "NSOCPE";

        /// <summary>
        /// NSFEBS.
        /// </summary>
        public const string NSFEBS = "NSFEBS";

        /// <summary>
        /// NSGPCT.
        /// </summary>
        public const string NSGPCT = "NSGPCT";

        /// <summary>
        /// NSUSER.
        /// </summary>
        public const string NSUSER = "NSUSER";

        /// <summary>
        /// NSUPMJ.
        /// </summary>
        public const string NSUPMJ = "NSUPMJ";

        /// <summary>
        /// NSPID.
        /// </summary>
        public const string NSPID = "NSPID";

        /// <summary>
        /// NSJOBN.
        /// </summary>
        public const string NSJOBN = "NSJOBN";

        /// <summary>
        /// NSCRRM.
        /// </summary>
        public const string NSCRRM = "NSCRRM";

        /// <summary>
        /// NSCTAM.
        /// </summary>
        public const string NSCTAM = "NSCTAM";

        /// <summary>
        /// NSCTXA.
        /// </summary>
        public const string NSCTXA = "NSCTXA";

        /// <summary>
        /// NSCTXN.
        /// </summary>
        public const string NSCTXN = "NSCTXN";

        /// <summary>
        /// NSBLMR.
        /// </summary>
        public const string NSBLMR = "NSBLMR";

        /// <summary>
        /// NSALCR.
        /// </summary>
        public const string NSALCR = "NSALCR";

        /// <summary>
        /// NSUNGR.
        /// </summary>
        public const string NSUNGR = "NSUNGR";

        /// <summary>
        /// NSUPMT.
        /// </summary>
        public const string NSUPMT = "NSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F15012";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NSDOCO", "NSDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("NSDCTO", "NSDCTO", JdeDataType.String, 4),
        new JdeField("NSEPCL", "NSEPCL", JdeDataType.String, 8, true, true),
        new JdeField("NSEPGR", "NSEPGR", JdeDataType.String, 6, true, true),
        new JdeField("NSEPSG", "NSEPSG", JdeDataType.String, 6, true, true),
        new JdeField("NSDL01", "NSDL01", JdeDataType.String, 60),
        new JdeField("NSDL02", "NSDL02", JdeDataType.String, 60),
        new JdeField("NSFERT", "NSFERT", JdeDataType.Numeric),
        new JdeField("NSEPOF", "NSEPOF", JdeDataType.Numeric),
        new JdeField("NSBSEX", "NSBSEX", JdeDataType.Numeric),
        new JdeField("NSBPSY", "NSBPSY", JdeDataType.Numeric),
        new JdeField("NSBPSM", "NSBPSM", JdeDataType.Numeric),
        new JdeField("NSCPFC", "NSCPFC", JdeDataType.Numeric),
        new JdeField("NSEPCP", "NSEPCP", JdeDataType.Numeric),
        new JdeField("NSGLC", "NSGLC", JdeDataType.String, 8),
        new JdeField("NSBLGR", "NSBLGR", JdeDataType.String, 24),
        new JdeField("NSMCU", "NSMCU", JdeDataType.String, 24),
        new JdeField("NSUNIT", "NSUNIT", JdeDataType.String, 16),
        new JdeField("NSDEAL", "NSDEAL", JdeDataType.String, 16),
        new JdeField("NSEFTB", "NSEFTB", JdeDataType.Numeric),
        new JdeField("NSEFTE", "NSEFTE", JdeDataType.Numeric),
        new JdeField("NSPCTP", "NSPCTP", JdeDataType.Numeric),
        new JdeField("NSBLFC", "NSBLFC", JdeDataType.String, 2),
        new JdeField("NSBF01", "NSBF01", JdeDataType.String, 2),
        new JdeField("NSBF02", "NSBF02", JdeDataType.String, 2),
        new JdeField("NSBF03", "NSBF03", JdeDataType.String, 2),
        new JdeField("NSBF04", "NSBF04", JdeDataType.String, 2),
        new JdeField("NSBF05", "NSBF05", JdeDataType.String, 2),
        new JdeField("NSBF06", "NSBF06", JdeDataType.String, 2),
        new JdeField("NSBF07", "NSBF07", JdeDataType.String, 2),
        new JdeField("NSBF08", "NSBF08", JdeDataType.String, 2),
        new JdeField("NSBF09", "NSBF09", JdeDataType.String, 2),
        new JdeField("NSBF10", "NSBF10", JdeDataType.String, 2),
        new JdeField("NSBF11", "NSBF11", JdeDataType.String, 2),
        new JdeField("NSBF12", "NSBF12", JdeDataType.String, 2),
        new JdeField("NSBF13", "NSBF13", JdeDataType.String, 2),
        new JdeField("NSEPCD", "NSEPCD", JdeDataType.String, 4),
        new JdeField("NSECMP", "NSECMP", JdeDataType.String, 2),
        new JdeField("NSEXCD", "NSEXCD", JdeDataType.String, 2),
        new JdeField("NSBRCD", "NSBRCD", JdeDataType.String, 8),
        new JdeField("NSBRAD", "NSBRAD", JdeDataType.String, 8),
        new JdeField("NSEPLM", "NSEPLM", JdeDataType.Numeric),
        new JdeField("NSAN8J", "NSAN8J", JdeDataType.Numeric),
        new JdeField("NSTRAR", "NSTRAR", JdeDataType.String, 6),
        new JdeField("NSSEPI", "NSSEPI", JdeDataType.String, 2),
        new JdeField("NSITMG", "NSITMG", JdeDataType.String, 6),
        new JdeField("NSSUSP", "NSSUSP", JdeDataType.String, 2),
        new JdeField("NSBLMN", "NSBLMN", JdeDataType.String, 2),
        new JdeField("NSBCI", "NSBCI", JdeDataType.Numeric, null, true, true),
        new JdeField("NSCRCD", "NSCRCD", JdeDataType.String, 6),
        new JdeField("NSTXA1", "NSTXA1", JdeDataType.String, 20),
        new JdeField("NSEXR1", "NSEXR1", JdeDataType.String, 4),
        new JdeField("NSOCRL", "NSOCRL", JdeDataType.String, 2),
        new JdeField("NSOCPB", "NSOCPB", JdeDataType.Numeric),
        new JdeField("NSOCPE", "NSOCPE", JdeDataType.Numeric),
        new JdeField("NSFEBS", "NSFEBS", JdeDataType.String, 2),
        new JdeField("NSGPCT", "NSGPCT", JdeDataType.Numeric),
        new JdeField("NSUSER", "NSUSER", JdeDataType.String, 20),
        new JdeField("NSUPMJ", "NSUPMJ", JdeDataType.Numeric),
        new JdeField("NSPID", "NSPID", JdeDataType.String, 20),
        new JdeField("NSJOBN", "NSJOBN", JdeDataType.String, 20),
        new JdeField("NSCRRM", "NSCRRM", JdeDataType.String, 2),
        new JdeField("NSCTAM", "NSCTAM", JdeDataType.Numeric),
        new JdeField("NSCTXA", "NSCTXA", JdeDataType.Numeric),
        new JdeField("NSCTXN", "NSCTXN", JdeDataType.Numeric),
        new JdeField("NSBLMR", "NSBLMR", JdeDataType.String, 2),
        new JdeField("NSALCR", "NSALCR", JdeDataType.String, 2),
        new JdeField("NSUNGR", "NSUNGR", JdeDataType.String, 2),
        new JdeField("NSUPMT", "NSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15012_0", "Primary Key on NSDOCO, NSEPGR, NSEPSG, NSEPCL, NSBCI", new[] { "NSDOCO", "NSEPGR", "NSEPSG", "NSEPCL", "NSBCI" }, isUnique: true, isPrimaryKey: true)
    };
}
