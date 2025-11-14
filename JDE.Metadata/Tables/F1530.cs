using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1530 - .
/// </summary>
public class F1530 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NGEPCL.
        /// </summary>
        public const string NGEPCL = "NGEPCL";

        /// <summary>
        /// NGGFLG.
        /// </summary>
        public const string NGGFLG = "NGGFLG";

        /// <summary>
        /// NGMCU.
        /// </summary>
        public const string NGMCU = "NGMCU";

        /// <summary>
        /// NGOBJ.
        /// </summary>
        public const string NGOBJ = "NGOBJ";

        /// <summary>
        /// NGSUB.
        /// </summary>
        public const string NGSUB = "NGSUB";

        /// <summary>
        /// NGMCU2.
        /// </summary>
        public const string NGMCU2 = "NGMCU2";

        /// <summary>
        /// NGOBJ2.
        /// </summary>
        public const string NGOBJ2 = "NGOBJ2";

        /// <summary>
        /// NGSUB2.
        /// </summary>
        public const string NGSUB2 = "NGSUB2";

        /// <summary>
        /// NGAID.
        /// </summary>
        public const string NGAID = "NGAID";

        /// <summary>
        /// NGEFTB.
        /// </summary>
        public const string NGEFTB = "NGEFTB";

        /// <summary>
        /// NGEFTE.
        /// </summary>
        public const string NGEFTE = "NGEFTE";

        /// <summary>
        /// NGUSER.
        /// </summary>
        public const string NGUSER = "NGUSER";

        /// <summary>
        /// NGUPMJ.
        /// </summary>
        public const string NGUPMJ = "NGUPMJ";

        /// <summary>
        /// NGPID.
        /// </summary>
        public const string NGPID = "NGPID";

        /// <summary>
        /// NGJOBN.
        /// </summary>
        public const string NGJOBN = "NGJOBN";

        /// <summary>
        /// NGCLAF.
        /// </summary>
        public const string NGCLAF = "NGCLAF";

        /// <summary>
        /// NGUPMT.
        /// </summary>
        public const string NGUPMT = "NGUPMT";

        /// <summary>
        /// NGMCUSEC.
        /// </summary>
        public const string NGMCUSEC = "NGMCUSEC";

        /// <summary>
        /// NGVPCTGU.
        /// </summary>
        public const string NGVPCTGU = "NGVPCTGU";

        /// <summary>
        /// NGOCTYPE.
        /// </summary>
        public const string NGOCTYPE = "NGOCTYPE";

        /// <summary>
        /// NGGPCT.
        /// </summary>
        public const string NGGPCT = "NGGPCT";

        /// <summary>
        /// NGELRD.
        /// </summary>
        public const string NGELRD = "NGELRD";

        /// <summary>
        /// NGFERT.
        /// </summary>
        public const string NGFERT = "NGFERT";

        /// <summary>
        /// NGFEBS.
        /// </summary>
        public const string NGFEBS = "NGFEBS";

        /// <summary>
        /// NGBRAD.
        /// </summary>
        public const string NGBRAD = "NGBRAD";

        /// <summary>
        /// NGRMK.
        /// </summary>
        public const string NGRMK = "NGRMK";

        /// <summary>
        /// NGAFPL.
        /// </summary>
        public const string NGAFPL = "NGAFPL";

        /// <summary>
        /// NGSTCAP.
        /// </summary>
        public const string NGSTCAP = "NGSTCAP";

        /// <summary>
        /// NGLTGRP.
        /// </summary>
        public const string NGLTGRP = "NGLTGRP";

        /// <summary>
        /// NGEPMCU.
        /// </summary>
        public const string NGEPMCU = "NGEPMCU";

        /// <summary>
        /// NGAPLYCAP.
        /// </summary>
        public const string NGAPLYCAP = "NGAPLYCAP";

        /// <summary>
        /// NGCAPID.
        /// </summary>
        public const string NGCAPID = "NGCAPID";

        /// <summary>
        /// NGCAPEFF.
        /// </summary>
        public const string NGCAPEFF = "NGCAPEFF";

        /// <summary>
        /// NGCAPEND.
        /// </summary>
        public const string NGCAPEND = "NGCAPEND";
    }

    /// <inheritdoc />
    public override string TableName => "F1530";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NGEPCL", "NGEPCL", JdeDataType.String, 8, true, true),
        new JdeField("NGGFLG", "NGGFLG", JdeDataType.String, 2),
        new JdeField("NGMCU", "NGMCU", JdeDataType.String, 24, true, true),
        new JdeField("NGOBJ", "NGOBJ", JdeDataType.String, 12, true, true),
        new JdeField("NGSUB", "NGSUB", JdeDataType.String, 16, true, true),
        new JdeField("NGMCU2", "NGMCU2", JdeDataType.String, 24),
        new JdeField("NGOBJ2", "NGOBJ2", JdeDataType.String, 12),
        new JdeField("NGSUB2", "NGSUB2", JdeDataType.String, 16),
        new JdeField("NGAID", "NGAID", JdeDataType.String, 16),
        new JdeField("NGEFTB", "NGEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("NGEFTE", "NGEFTE", JdeDataType.Numeric, null, true, true),
        new JdeField("NGUSER", "NGUSER", JdeDataType.String, 20),
        new JdeField("NGUPMJ", "NGUPMJ", JdeDataType.Numeric),
        new JdeField("NGPID", "NGPID", JdeDataType.String, 20),
        new JdeField("NGJOBN", "NGJOBN", JdeDataType.String, 20),
        new JdeField("NGCLAF", "NGCLAF", JdeDataType.Numeric),
        new JdeField("NGUPMT", "NGUPMT", JdeDataType.Numeric),
        new JdeField("NGMCUSEC", "NGMCUSEC", JdeDataType.String, 24),
        new JdeField("NGVPCTGU", "NGVPCTGU", JdeDataType.Numeric),
        new JdeField("NGOCTYPE", "NGOCTYPE", JdeDataType.String, 2),
        new JdeField("NGGPCT", "NGGPCT", JdeDataType.Numeric),
        new JdeField("NGELRD", "NGELRD", JdeDataType.String, 2),
        new JdeField("NGFERT", "NGFERT", JdeDataType.Numeric),
        new JdeField("NGFEBS", "NGFEBS", JdeDataType.String, 2),
        new JdeField("NGBRAD", "NGBRAD", JdeDataType.String, 8),
        new JdeField("NGRMK", "NGRMK", JdeDataType.String, 60),
        new JdeField("NGAFPL", "NGAFPL", JdeDataType.String, 2),
        new JdeField("NGSTCAP", "NGSTCAP", JdeDataType.String, 2),
        new JdeField("NGLTGRP", "NGLTGRP", JdeDataType.String, 30),
        new JdeField("NGEPMCU", "NGEPMCU", JdeDataType.String, 24, true, true),
        new JdeField("NGAPLYCAP", "NGAPLYCAP", JdeDataType.String, 2),
        new JdeField("NGCAPID", "NGCAPID", JdeDataType.String, 20),
        new JdeField("NGCAPEFF", "NGCAPEFF", JdeDataType.Numeric),
        new JdeField("NGCAPEND", "NGCAPEND", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1530_0", "Primary Key on NGEPCL, NGMCU, NGOBJ, NGSUB, NGEPMCU, NGEFTB, NGEFTE", new[] { "NGEPCL", "NGMCU", "NGOBJ", "NGSUB", "NGEPMCU", "NGEFTB", "NGEFTE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1530_2", "Index on NGMCU, NGOBJ, NGSUB", new[] { "NGMCU", "NGOBJ", "NGSUB" })
    };
}
