using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF31113 - .
/// </summary>
public class FF31113 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LDUKID.
        /// </summary>
        public const string LDUKID = "LDUKID";

        /// <summary>
        /// LDYST.
        /// </summary>
        public const string LDYST = "LDYST";

        /// <summary>
        /// LDPRODF31.
        /// </summary>
        public const string LDPRODF31 = "LDPRODF31";

        /// <summary>
        /// LDTRSID.
        /// </summary>
        public const string LDTRSID = "LDTRSID";

        /// <summary>
        /// LDMTID.
        /// </summary>
        public const string LDMTID = "LDMTID";

        /// <summary>
        /// LDAN8.
        /// </summary>
        public const string LDAN8 = "LDAN8";

        /// <summary>
        /// LDKIT.
        /// </summary>
        public const string LDKIT = "LDKIT";

        /// <summary>
        /// LDITM.
        /// </summary>
        public const string LDITM = "LDITM";

        /// <summary>
        /// LDLITM.
        /// </summary>
        public const string LDLITM = "LDLITM";

        /// <summary>
        /// LDAITM.
        /// </summary>
        public const string LDAITM = "LDAITM";

        /// <summary>
        /// LDMMCU.
        /// </summary>
        public const string LDMMCU = "LDMMCU";

        /// <summary>
        /// LDMCU.
        /// </summary>
        public const string LDMCU = "LDMCU";

        /// <summary>
        /// LDDFMLINE.
        /// </summary>
        public const string LDDFMLINE = "LDDFMLINE";

        /// <summary>
        /// LDOPSQ.
        /// </summary>
        public const string LDOPSQ = "LDOPSQ";

        /// <summary>
        /// LDOPSC.
        /// </summary>
        public const string LDOPSC = "LDOPSC";

        /// <summary>
        /// LDTYR.
        /// </summary>
        public const string LDTYR = "LDTYR";

        /// <summary>
        /// LDDCT.
        /// </summary>
        public const string LDDCT = "LDDCT";

        /// <summary>
        /// LDLTDATE.
        /// </summary>
        public const string LDLTDATE = "LDLTDATE";

        /// <summary>
        /// LDUCNDJ.
        /// </summary>
        public const string LDUCNDJ = "LDUCNDJ";

        /// <summary>
        /// LDLTSTTIME.
        /// </summary>
        public const string LDLTSTTIME = "LDLTSTTIME";

        /// <summary>
        /// LDLTENTIME.
        /// </summary>
        public const string LDLTENTIME = "LDLTENTIME";

        /// <summary>
        /// LDSHFT.
        /// </summary>
        public const string LDSHFT = "LDSHFT";

        /// <summary>
        /// LDHRT.
        /// </summary>
        public const string LDHRT = "LDHRT";

        /// <summary>
        /// LDHRW.
        /// </summary>
        public const string LDHRW = "LDHRW";

        /// <summary>
        /// LDGPAY.
        /// </summary>
        public const string LDGPAY = "LDGPAY";

        /// <summary>
        /// LDSOQS.
        /// </summary>
        public const string LDSOQS = "LDSOQS";

        /// <summary>
        /// LDSOCN.
        /// </summary>
        public const string LDSOCN = "LDSOCN";

        /// <summary>
        /// LDUOM.
        /// </summary>
        public const string LDUOM = "LDUOM";

        /// <summary>
        /// LDSUMR.
        /// </summary>
        public const string LDSUMR = "LDSUMR";

        /// <summary>
        /// LDSTH.
        /// </summary>
        public const string LDSTH = "LDSTH";

        /// <summary>
        /// LDRCD.
        /// </summary>
        public const string LDRCD = "LDRCD";

        /// <summary>
        /// LDLINE.
        /// </summary>
        public const string LDLINE = "LDLINE";

        /// <summary>
        /// LDVEND.
        /// </summary>
        public const string LDVEND = "LDVEND";

        /// <summary>
        /// LDRKCO.
        /// </summary>
        public const string LDRKCO = "LDRKCO";

        /// <summary>
        /// LDRORN.
        /// </summary>
        public const string LDRORN = "LDRORN";

        /// <summary>
        /// LDRCTO.
        /// </summary>
        public const string LDRCTO = "LDRCTO";

        /// <summary>
        /// LDWMCU.
        /// </summary>
        public const string LDWMCU = "LDWMCU";

        /// <summary>
        /// LDCOST.
        /// </summary>
        public const string LDCOST = "LDCOST";

        /// <summary>
        /// LDNUMB.
        /// </summary>
        public const string LDNUMB = "LDNUMB";

        /// <summary>
        /// LDTUSER.
        /// </summary>
        public const string LDTUSER = "LDTUSER";

        /// <summary>
        /// LDCUSER.
        /// </summary>
        public const string LDCUSER = "LDCUSER";

        /// <summary>
        /// LDURCD.
        /// </summary>
        public const string LDURCD = "LDURCD";

        /// <summary>
        /// LDURDT.
        /// </summary>
        public const string LDURDT = "LDURDT";

        /// <summary>
        /// LDURAT.
        /// </summary>
        public const string LDURAT = "LDURAT";

        /// <summary>
        /// LDURAB.
        /// </summary>
        public const string LDURAB = "LDURAB";

        /// <summary>
        /// LDURRF.
        /// </summary>
        public const string LDURRF = "LDURRF";

        /// <summary>
        /// LDUSER.
        /// </summary>
        public const string LDUSER = "LDUSER";

        /// <summary>
        /// LDPID.
        /// </summary>
        public const string LDPID = "LDPID";

        /// <summary>
        /// LDMKEY.
        /// </summary>
        public const string LDMKEY = "LDMKEY";

        /// <summary>
        /// LDUUPMJ.
        /// </summary>
        public const string LDUUPMJ = "LDUUPMJ";

        /// <summary>
        /// LDU.
        /// </summary>
        public const string LDU = "LDU";

        /// <summary>
        /// LDAA.
        /// </summary>
        public const string LDAA = "LDAA";

        /// <summary>
        /// LDTRSTS.
        /// </summary>
        public const string LDTRSTS = "LDTRSTS";

        /// <summary>
        /// LDLEANUNIT.
        /// </summary>
        public const string LDLEANUNIT = "LDLEANUNIT";

        /// <summary>
        /// LDLEANAMT.
        /// </summary>
        public const string LDLEANAMT = "LDLEANAMT";

        /// <summary>
        /// LDHRSWRK.
        /// </summary>
        public const string LDHRSWRK = "LDHRSWRK";

        /// <summary>
        /// LDAMTGPAY.
        /// </summary>
        public const string LDAMTGPAY = "LDAMTGPAY";
    }

    /// <inheritdoc />
    public override string TableName => "FF31113";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LDUKID", "LDUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("LDYST", "LDYST", JdeDataType.String, 2),
        new JdeField("LDPRODF31", "LDPRODF31", JdeDataType.Numeric),
        new JdeField("LDTRSID", "LDTRSID", JdeDataType.Numeric),
        new JdeField("LDMTID", "LDMTID", JdeDataType.Numeric),
        new JdeField("LDAN8", "LDAN8", JdeDataType.Numeric),
        new JdeField("LDKIT", "LDKIT", JdeDataType.Numeric),
        new JdeField("LDITM", "LDITM", JdeDataType.Numeric),
        new JdeField("LDLITM", "LDLITM", JdeDataType.String, 50),
        new JdeField("LDAITM", "LDAITM", JdeDataType.String, 50),
        new JdeField("LDMMCU", "LDMMCU", JdeDataType.String, 24),
        new JdeField("LDMCU", "LDMCU", JdeDataType.String, 24),
        new JdeField("LDDFMLINE", "LDDFMLINE", JdeDataType.String, 24),
        new JdeField("LDOPSQ", "LDOPSQ", JdeDataType.Numeric),
        new JdeField("LDOPSC", "LDOPSC", JdeDataType.String, 4),
        new JdeField("LDTYR", "LDTYR", JdeDataType.String, 2),
        new JdeField("LDDCT", "LDDCT", JdeDataType.String, 4),
        new JdeField("LDLTDATE", "LDLTDATE", JdeDataType.Date),
        new JdeField("LDUCNDJ", "LDUCNDJ", JdeDataType.Date),
        new JdeField("LDLTSTTIME", "LDLTSTTIME", JdeDataType.Date),
        new JdeField("LDLTENTIME", "LDLTENTIME", JdeDataType.Date),
        new JdeField("LDSHFT", "LDSHFT", JdeDataType.String, 2),
        new JdeField("LDHRT", "LDHRT", JdeDataType.Numeric),
        new JdeField("LDHRW", "LDHRW", JdeDataType.Numeric),
        new JdeField("LDGPAY", "LDGPAY", JdeDataType.Numeric),
        new JdeField("LDSOQS", "LDSOQS", JdeDataType.Numeric),
        new JdeField("LDSOCN", "LDSOCN", JdeDataType.Numeric),
        new JdeField("LDUOM", "LDUOM", JdeDataType.String, 4),
        new JdeField("LDSUMR", "LDSUMR", JdeDataType.String, 2),
        new JdeField("LDSTH", "LDSTH", JdeDataType.Numeric),
        new JdeField("LDRCD", "LDRCD", JdeDataType.String, 6),
        new JdeField("LDLINE", "LDLINE", JdeDataType.String, 24),
        new JdeField("LDVEND", "LDVEND", JdeDataType.Numeric),
        new JdeField("LDRKCO", "LDRKCO", JdeDataType.String, 10),
        new JdeField("LDRORN", "LDRORN", JdeDataType.String, 16),
        new JdeField("LDRCTO", "LDRCTO", JdeDataType.String, 4),
        new JdeField("LDWMCU", "LDWMCU", JdeDataType.String, 24),
        new JdeField("LDCOST", "LDCOST", JdeDataType.String, 6),
        new JdeField("LDNUMB", "LDNUMB", JdeDataType.Numeric),
        new JdeField("LDTUSER", "LDTUSER", JdeDataType.String, 20),
        new JdeField("LDCUSER", "LDCUSER", JdeDataType.String, 20),
        new JdeField("LDURCD", "LDURCD", JdeDataType.String, 4),
        new JdeField("LDURDT", "LDURDT", JdeDataType.Numeric),
        new JdeField("LDURAT", "LDURAT", JdeDataType.Numeric),
        new JdeField("LDURAB", "LDURAB", JdeDataType.Numeric),
        new JdeField("LDURRF", "LDURRF", JdeDataType.String, 30),
        new JdeField("LDUSER", "LDUSER", JdeDataType.String, 20),
        new JdeField("LDPID", "LDPID", JdeDataType.String, 20),
        new JdeField("LDMKEY", "LDMKEY", JdeDataType.String, 30),
        new JdeField("LDUUPMJ", "LDUUPMJ", JdeDataType.Date),
        new JdeField("LDU", "LDU", JdeDataType.Numeric),
        new JdeField("LDAA", "LDAA", JdeDataType.Numeric),
        new JdeField("LDTRSTS", "LDTRSTS", JdeDataType.String, 4),
        new JdeField("LDLEANUNIT", "LDLEANUNIT", JdeDataType.Numeric),
        new JdeField("LDLEANAMT", "LDLEANAMT", JdeDataType.Numeric),
        new JdeField("LDHRSWRK", "LDHRSWRK", JdeDataType.Numeric),
        new JdeField("LDAMTGPAY", "LDAMTGPAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF31113_0", "Primary Key on LDUKID", new[] { "LDUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF31113_2", "Index on LDPRODF31, LDTRSID, LDOPSQ, LDOPSC, LDMCU, LDTYR", new[] { "LDPRODF31", "LDTRSID", "LDOPSQ", "LDOPSC", "LDMCU", "LDTYR" }),
        new JdeIndex("FF31113_3", "Index on LDYST, LDPRODF31, LDTRSID, LDOPSQ, LDOPSC, LDMCU, LDTYR", new[] { "LDYST", "LDPRODF31", "LDTRSID", "LDOPSQ", "LDOPSC", "LDMCU", "LDTYR" }),
        new JdeIndex("FF31113_4", "Index on LDPRODF31, LDMTID", new[] { "LDPRODF31", "LDMTID" })
    };
}
