using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42005 - .
/// </summary>
public class F42005 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SCKCOO.
        /// </summary>
        public const string SCKCOO = "SCKCOO";

        /// <summary>
        /// SCDOCO.
        /// </summary>
        public const string SCDOCO = "SCDOCO";

        /// <summary>
        /// SCSFXO.
        /// </summary>
        public const string SCSFXO = "SCSFXO";

        /// <summary>
        /// SCDOCM.
        /// </summary>
        public const string SCDOCM = "SCDOCM";

        /// <summary>
        /// SCDLIJ.
        /// </summary>
        public const string SCDLIJ = "SCDLIJ";

        /// <summary>
        /// SCAN8.
        /// </summary>
        public const string SCAN8 = "SCAN8";

        /// <summary>
        /// SCSLSP.
        /// </summary>
        public const string SCSLSP = "SCSLSP";

        /// <summary>
        /// SCCCTY.
        /// </summary>
        public const string SCCCTY = "SCCCTY";

        /// <summary>
        /// SCRAN8.
        /// </summary>
        public const string SCRAN8 = "SCRAN8";

        /// <summary>
        /// SCCTYR.
        /// </summary>
        public const string SCCTYR = "SCCTYR";

        /// <summary>
        /// SCDCTO.
        /// </summary>
        public const string SCDCTO = "SCDCTO";

        /// <summary>
        /// SCLNID.
        /// </summary>
        public const string SCLNID = "SCLNID";

        /// <summary>
        /// SCAC01.
        /// </summary>
        public const string SCAC01 = "SCAC01";

        /// <summary>
        /// SCAC02.
        /// </summary>
        public const string SCAC02 = "SCAC02";

        /// <summary>
        /// SCAC03.
        /// </summary>
        public const string SCAC03 = "SCAC03";

        /// <summary>
        /// SCAC04.
        /// </summary>
        public const string SCAC04 = "SCAC04";

        /// <summary>
        /// SCAC05.
        /// </summary>
        public const string SCAC05 = "SCAC05";

        /// <summary>
        /// SCSRP1.
        /// </summary>
        public const string SCSRP1 = "SCSRP1";

        /// <summary>
        /// SCSRP2.
        /// </summary>
        public const string SCSRP2 = "SCSRP2";

        /// <summary>
        /// SCSRP3.
        /// </summary>
        public const string SCSRP3 = "SCSRP3";

        /// <summary>
        /// SCSRP4.
        /// </summary>
        public const string SCSRP4 = "SCSRP4";

        /// <summary>
        /// SCSRP5.
        /// </summary>
        public const string SCSRP5 = "SCSRP5";

        /// <summary>
        /// SCSPLT.
        /// </summary>
        public const string SCSPLT = "SCSPLT";

        /// <summary>
        /// SCFRTH.
        /// </summary>
        public const string SCFRTH = "SCFRTH";

        /// <summary>
        /// SCLFAC.
        /// </summary>
        public const string SCLFAC = "SCLFAC";

        /// <summary>
        /// SCAFXC.
        /// </summary>
        public const string SCAFXC = "SCAFXC";

        /// <summary>
        /// SCTOTO.
        /// </summary>
        public const string SCTOTO = "SCTOTO";

        /// <summary>
        /// SCORCS.
        /// </summary>
        public const string SCORCS = "SCORCS";

        /// <summary>
        /// SCREBT.
        /// </summary>
        public const string SCREBT = "SCREBT";

        /// <summary>
        /// SCMRGN.
        /// </summary>
        public const string SCMRGN = "SCMRGN";

        /// <summary>
        /// SCELIG.
        /// </summary>
        public const string SCELIG = "SCELIG";

        /// <summary>
        /// SCTOTL.
        /// </summary>
        public const string SCTOTL = "SCTOTL";

        /// <summary>
        /// SCLRCS.
        /// </summary>
        public const string SCLRCS = "SCLRCS";

        /// <summary>
        /// SCREBL.
        /// </summary>
        public const string SCREBL = "SCREBL";

        /// <summary>
        /// SCMRGL.
        /// </summary>
        public const string SCMRGL = "SCMRGL";

        /// <summary>
        /// SCELIL.
        /// </summary>
        public const string SCELIL = "SCELIL";

        /// <summary>
        /// SCMGM.
        /// </summary>
        public const string SCMGM = "SCMGM";

        /// <summary>
        /// SCCPCT.
        /// </summary>
        public const string SCCPCT = "SCCPCT";

        /// <summary>
        /// SCCOMA.
        /// </summary>
        public const string SCCOMA = "SCCOMA";

        /// <summary>
        /// SCCPCR.
        /// </summary>
        public const string SCCPCR = "SCCPCR";

        /// <summary>
        /// SCCOMR.
        /// </summary>
        public const string SCCOMR = "SCCOMR";

        /// <summary>
        /// SCMCU.
        /// </summary>
        public const string SCMCU = "SCMCU";

        /// <summary>
        /// SCITM.
        /// </summary>
        public const string SCITM = "SCITM";

        /// <summary>
        /// SCRPMB.
        /// </summary>
        public const string SCRPMB = "SCRPMB";

        /// <summary>
        /// SCUPMJ.
        /// </summary>
        public const string SCUPMJ = "SCUPMJ";

        /// <summary>
        /// SCCMDJ.
        /// </summary>
        public const string SCCMDJ = "SCCMDJ";

        /// <summary>
        /// SCPDCD.
        /// </summary>
        public const string SCPDCD = "SCPDCD";

        /// <summary>
        /// SCCLOJ.
        /// </summary>
        public const string SCCLOJ = "SCCLOJ";

        /// <summary>
        /// SCTDAY.
        /// </summary>
        public const string SCTDAY = "SCTDAY";

        /// <summary>
        /// SCFCA.
        /// </summary>
        public const string SCFCA = "SCFCA";

        /// <summary>
        /// SCAPUN.
        /// </summary>
        public const string SCAPUN = "SCAPUN";

        /// <summary>
        /// SCCMLN.
        /// </summary>
        public const string SCCMLN = "SCCMLN";
    }

    /// <inheritdoc />
    public override string TableName => "F42005";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SCKCOO", "SCKCOO", JdeDataType.String, 10, true, true),
        new JdeField("SCDOCO", "SCDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SCSFXO", "SCSFXO", JdeDataType.String, 6),
        new JdeField("SCDOCM", "SCDOCM", JdeDataType.Numeric),
        new JdeField("SCDLIJ", "SCDLIJ", JdeDataType.Numeric),
        new JdeField("SCAN8", "SCAN8", JdeDataType.Numeric),
        new JdeField("SCSLSP", "SCSLSP", JdeDataType.Numeric, null, true, true),
        new JdeField("SCCCTY", "SCCCTY", JdeDataType.String, 2),
        new JdeField("SCRAN8", "SCRAN8", JdeDataType.Numeric),
        new JdeField("SCCTYR", "SCCTYR", JdeDataType.String, 2),
        new JdeField("SCDCTO", "SCDCTO", JdeDataType.String, 4, true, true),
        new JdeField("SCLNID", "SCLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("SCAC01", "SCAC01", JdeDataType.String, 6),
        new JdeField("SCAC02", "SCAC02", JdeDataType.String, 6),
        new JdeField("SCAC03", "SCAC03", JdeDataType.String, 6),
        new JdeField("SCAC04", "SCAC04", JdeDataType.String, 6),
        new JdeField("SCAC05", "SCAC05", JdeDataType.String, 6),
        new JdeField("SCSRP1", "SCSRP1", JdeDataType.String, 6),
        new JdeField("SCSRP2", "SCSRP2", JdeDataType.String, 6),
        new JdeField("SCSRP3", "SCSRP3", JdeDataType.String, 6),
        new JdeField("SCSRP4", "SCSRP4", JdeDataType.String, 6),
        new JdeField("SCSRP5", "SCSRP5", JdeDataType.String, 6),
        new JdeField("SCSPLT", "SCSPLT", JdeDataType.String, 2),
        new JdeField("SCFRTH", "SCFRTH", JdeDataType.String, 6),
        new JdeField("SCLFAC", "SCLFAC", JdeDataType.Numeric),
        new JdeField("SCAFXC", "SCAFXC", JdeDataType.Numeric),
        new JdeField("SCTOTO", "SCTOTO", JdeDataType.Numeric),
        new JdeField("SCORCS", "SCORCS", JdeDataType.Numeric),
        new JdeField("SCREBT", "SCREBT", JdeDataType.Numeric),
        new JdeField("SCMRGN", "SCMRGN", JdeDataType.Numeric),
        new JdeField("SCELIG", "SCELIG", JdeDataType.Numeric),
        new JdeField("SCTOTL", "SCTOTL", JdeDataType.Numeric),
        new JdeField("SCLRCS", "SCLRCS", JdeDataType.Numeric),
        new JdeField("SCREBL", "SCREBL", JdeDataType.Numeric),
        new JdeField("SCMRGL", "SCMRGL", JdeDataType.Numeric),
        new JdeField("SCELIL", "SCELIL", JdeDataType.Numeric),
        new JdeField("SCMGM", "SCMGM", JdeDataType.Numeric),
        new JdeField("SCCPCT", "SCCPCT", JdeDataType.Numeric),
        new JdeField("SCCOMA", "SCCOMA", JdeDataType.Numeric),
        new JdeField("SCCPCR", "SCCPCR", JdeDataType.Numeric),
        new JdeField("SCCOMR", "SCCOMR", JdeDataType.Numeric),
        new JdeField("SCMCU", "SCMCU", JdeDataType.String, 24),
        new JdeField("SCITM", "SCITM", JdeDataType.Numeric),
        new JdeField("SCRPMB", "SCRPMB", JdeDataType.String, 20),
        new JdeField("SCUPMJ", "SCUPMJ", JdeDataType.Numeric),
        new JdeField("SCCMDJ", "SCCMDJ", JdeDataType.Numeric),
        new JdeField("SCPDCD", "SCPDCD", JdeDataType.String, 2),
        new JdeField("SCCLOJ", "SCCLOJ", JdeDataType.Numeric),
        new JdeField("SCTDAY", "SCTDAY", JdeDataType.Numeric),
        new JdeField("SCFCA", "SCFCA", JdeDataType.Numeric),
        new JdeField("SCAPUN", "SCAPUN", JdeDataType.Numeric),
        new JdeField("SCCMLN", "SCCMLN", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42005_0", "Primary Key on SCDOCO, SCDCTO, SCKCOO, SCLNID, SCSLSP, SCCMLN", new[] { "SCDOCO", "SCDCTO", "SCKCOO", "SCLNID", "SCSLSP", "SCCMLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F42005_2", "Index on SCKCOO, SCDOCO, SCDCTO, SCLNID", new[] { "SCKCOO", "SCDOCO", "SCDCTO", "SCLNID" })
    };
}
