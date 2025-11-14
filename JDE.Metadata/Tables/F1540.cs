using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1540 - .
/// </summary>
public class F1540 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NRDOCO.
        /// </summary>
        public const string NRDOCO = "NRDOCO";

        /// <summary>
        /// NRDCTO.
        /// </summary>
        public const string NRDCTO = "NRDCTO";

        /// <summary>
        /// NRMCU.
        /// </summary>
        public const string NRMCU = "NRMCU";

        /// <summary>
        /// NRPRDC.
        /// </summary>
        public const string NRPRDC = "NRPRDC";

        /// <summary>
        /// NRCTRY.
        /// </summary>
        public const string NRCTRY = "NRCTRY";

        /// <summary>
        /// NRYR.
        /// </summary>
        public const string NRYR = "NRYR";

        /// <summary>
        /// NRRPRD.
        /// </summary>
        public const string NRRPRD = "NRRPRD";

        /// <summary>
        /// NRLIN.
        /// </summary>
        public const string NRLIN = "NRLIN";

        /// <summary>
        /// NRDTRT.
        /// </summary>
        public const string NRDTRT = "NRDTRT";

        /// <summary>
        /// NRDTSR.
        /// </summary>
        public const string NRDTSR = "NRDTSR";

        /// <summary>
        /// NRICU.
        /// </summary>
        public const string NRICU = "NRICU";

        /// <summary>
        /// NRICUT.
        /// </summary>
        public const string NRICUT = "NRICUT";

        /// <summary>
        /// NRDIC.
        /// </summary>
        public const string NRDIC = "NRDIC";

        /// <summary>
        /// NRANRP.
        /// </summary>
        public const string NRANRP = "NRANRP";

        /// <summary>
        /// NRUNIT.
        /// </summary>
        public const string NRUNIT = "NRUNIT";

        /// <summary>
        /// NRMCUS.
        /// </summary>
        public const string NRMCUS = "NRMCUS";

        /// <summary>
        /// NRAN8.
        /// </summary>
        public const string NRAN8 = "NRAN8";

        /// <summary>
        /// NRPSLS.
        /// </summary>
        public const string NRPSLS = "NRPSLS";

        /// <summary>
        /// NRU.
        /// </summary>
        public const string NRU = "NRU";

        /// <summary>
        /// NRDL01.
        /// </summary>
        public const string NRDL01 = "NRDL01";

        /// <summary>
        /// NRSADJ.
        /// </summary>
        public const string NRSADJ = "NRSADJ";

        /// <summary>
        /// NRSATY.
        /// </summary>
        public const string NRSATY = "NRSATY";

        /// <summary>
        /// NRUSER.
        /// </summary>
        public const string NRUSER = "NRUSER";

        /// <summary>
        /// NRUPMJ.
        /// </summary>
        public const string NRUPMJ = "NRUPMJ";

        /// <summary>
        /// NRPID.
        /// </summary>
        public const string NRPID = "NRPID";

        /// <summary>
        /// NRJOBN.
        /// </summary>
        public const string NRJOBN = "NRJOBN";

        /// <summary>
        /// NRDBAN.
        /// </summary>
        public const string NRDBAN = "NRDBAN";

        /// <summary>
        /// NRSOSS.
        /// </summary>
        public const string NRSOSS = "NRSOSS";

        /// <summary>
        /// NRSOIC.
        /// </summary>
        public const string NRSOIC = "NRSOIC";

        /// <summary>
        /// NRSRTY.
        /// </summary>
        public const string NRSRTY = "NRSRTY";

        /// <summary>
        /// NRSUSA.
        /// </summary>
        public const string NRSUSA = "NRSUSA";

        /// <summary>
        /// NRDSLD.
        /// </summary>
        public const string NRDSLD = "NRDSLD";

        /// <summary>
        /// NRLTRC.
        /// </summary>
        public const string NRLTRC = "NRLTRC";

        /// <summary>
        /// NRDLTR.
        /// </summary>
        public const string NRDLTR = "NRDLTR";

        /// <summary>
        /// NRULI.
        /// </summary>
        public const string NRULI = "NRULI";

        /// <summary>
        /// NRRM11.
        /// </summary>
        public const string NRRM11 = "NRRM11";

        /// <summary>
        /// NRRM12.
        /// </summary>
        public const string NRRM12 = "NRRM12";

        /// <summary>
        /// NRRM13.
        /// </summary>
        public const string NRRM13 = "NRRM13";

        /// <summary>
        /// NRRM14.
        /// </summary>
        public const string NRRM14 = "NRRM14";

        /// <summary>
        /// NRRM15.
        /// </summary>
        public const string NRRM15 = "NRRM15";

        /// <summary>
        /// NRUPMT.
        /// </summary>
        public const string NRUPMT = "NRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1540";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NRDOCO", "NRDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("NRDCTO", "NRDCTO", JdeDataType.String, 4),
        new JdeField("NRMCU", "NRMCU", JdeDataType.String, 24, true, true),
        new JdeField("NRPRDC", "NRPRDC", JdeDataType.String, 8, true, true),
        new JdeField("NRCTRY", "NRCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("NRYR", "NRYR", JdeDataType.Numeric, null, true, true),
        new JdeField("NRRPRD", "NRRPRD", JdeDataType.Numeric, null, true, true),
        new JdeField("NRLIN", "NRLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("NRDTRT", "NRDTRT", JdeDataType.Numeric),
        new JdeField("NRDTSR", "NRDTSR", JdeDataType.Numeric),
        new JdeField("NRICU", "NRICU", JdeDataType.Numeric),
        new JdeField("NRICUT", "NRICUT", JdeDataType.String, 4),
        new JdeField("NRDIC", "NRDIC", JdeDataType.Numeric),
        new JdeField("NRANRP", "NRANRP", JdeDataType.String, 2),
        new JdeField("NRUNIT", "NRUNIT", JdeDataType.String, 16, true, true),
        new JdeField("NRMCUS", "NRMCUS", JdeDataType.String, 24),
        new JdeField("NRAN8", "NRAN8", JdeDataType.Numeric),
        new JdeField("NRPSLS", "NRPSLS", JdeDataType.Numeric),
        new JdeField("NRU", "NRU", JdeDataType.Numeric),
        new JdeField("NRDL01", "NRDL01", JdeDataType.String, 60),
        new JdeField("NRSADJ", "NRSADJ", JdeDataType.String, 2),
        new JdeField("NRSATY", "NRSATY", JdeDataType.String, 2),
        new JdeField("NRUSER", "NRUSER", JdeDataType.String, 20),
        new JdeField("NRUPMJ", "NRUPMJ", JdeDataType.Numeric),
        new JdeField("NRPID", "NRPID", JdeDataType.String, 20),
        new JdeField("NRJOBN", "NRJOBN", JdeDataType.String, 20),
        new JdeField("NRDBAN", "NRDBAN", JdeDataType.Numeric, null, true, true),
        new JdeField("NRSOSS", "NRSOSS", JdeDataType.String, 2),
        new JdeField("NRSOIC", "NRSOIC", JdeDataType.String, 2),
        new JdeField("NRSRTY", "NRSRTY", JdeDataType.String, 2),
        new JdeField("NRSUSA", "NRSUSA", JdeDataType.Numeric),
        new JdeField("NRDSLD", "NRDSLD", JdeDataType.Numeric),
        new JdeField("NRLTRC", "NRLTRC", JdeDataType.String, 4),
        new JdeField("NRDLTR", "NRDLTR", JdeDataType.Numeric),
        new JdeField("NRULI", "NRULI", JdeDataType.String, 16),
        new JdeField("NRRM11", "NRRM11", JdeDataType.String, 8),
        new JdeField("NRRM12", "NRRM12", JdeDataType.String, 8),
        new JdeField("NRRM13", "NRRM13", JdeDataType.String, 8),
        new JdeField("NRRM14", "NRRM14", JdeDataType.String, 8),
        new JdeField("NRRM15", "NRRM15", JdeDataType.String, 8),
        new JdeField("NRUPMT", "NRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1540_0", "Primary Key on NRDOCO, NRMCU, NRUNIT, NRDBAN, NRPRDC, NRCTRY, NRYR, NRRPRD, NRLIN", new[] { "NRDOCO", "NRMCU", "NRUNIT", "NRDBAN", "NRPRDC", "NRCTRY", "NRYR", "NRRPRD", "NRLIN" }, isUnique: true, isPrimaryKey: true)
    };
}
