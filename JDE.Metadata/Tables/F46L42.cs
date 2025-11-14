using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46L42 - .
/// </summary>
public class F46L42 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCCYNO.
        /// </summary>
        public const string CCCYNO = "CCCYNO";

        /// <summary>
        /// CCTGG.
        /// </summary>
        public const string CCTGG = "CCTGG";

        /// <summary>
        /// CCITM.
        /// </summary>
        public const string CCITM = "CCITM";

        /// <summary>
        /// CCMCU.
        /// </summary>
        public const string CCMCU = "CCMCU";

        /// <summary>
        /// CCLOCN.
        /// </summary>
        public const string CCLOCN = "CCLOCN";

        /// <summary>
        /// CCLOTN.
        /// </summary>
        public const string CCLOTN = "CCLOTN";

        /// <summary>
        /// CCLPNU.
        /// </summary>
        public const string CCLPNU = "CCLPNU";

        /// <summary>
        /// CCTQCT.
        /// </summary>
        public const string CCTQCT = "CCTQCT";

        /// <summary>
        /// CCTQOH.
        /// </summary>
        public const string CCTQOH = "CCTQOH";

        /// <summary>
        /// CCUOM1.
        /// </summary>
        public const string CCUOM1 = "CCUOM1";

        /// <summary>
        /// CCSQOR.
        /// </summary>
        public const string CCSQOR = "CCSQOR";

        /// <summary>
        /// CCSQOH.
        /// </summary>
        public const string CCSQOH = "CCSQOH";

        /// <summary>
        /// CCUOM2.
        /// </summary>
        public const string CCUOM2 = "CCUOM2";

        /// <summary>
        /// CCQTY1.
        /// </summary>
        public const string CCQTY1 = "CCQTY1";

        /// <summary>
        /// CCQTY2.
        /// </summary>
        public const string CCQTY2 = "CCQTY2";

        /// <summary>
        /// CCUOM.
        /// </summary>
        public const string CCUOM = "CCUOM";

        /// <summary>
        /// CCRCDJ.
        /// </summary>
        public const string CCRCDJ = "CCRCDJ";

        /// <summary>
        /// CCMMEJ.
        /// </summary>
        public const string CCMMEJ = "CCMMEJ";

        /// <summary>
        /// CCNDTL.
        /// </summary>
        public const string CCNDTL = "CCNDTL";

        /// <summary>
        /// CCWTTY.
        /// </summary>
        public const string CCWTTY = "CCWTTY";

        /// <summary>
        /// CCSMOD.
        /// </summary>
        public const string CCSMOD = "CCSMOD";

        /// <summary>
        /// CCUSER.
        /// </summary>
        public const string CCUSER = "CCUSER";

        /// <summary>
        /// CCPID.
        /// </summary>
        public const string CCPID = "CCPID";

        /// <summary>
        /// CCJOBN.
        /// </summary>
        public const string CCJOBN = "CCJOBN";

        /// <summary>
        /// CCUPMJ.
        /// </summary>
        public const string CCUPMJ = "CCUPMJ";

        /// <summary>
        /// CCTDAY.
        /// </summary>
        public const string CCTDAY = "CCTDAY";

        /// <summary>
        /// CCLPNDC.
        /// </summary>
        public const string CCLPNDC = "CCLPNDC";
    }

    /// <inheritdoc />
    public override string TableName => "F46L42";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCCYNO", "CCCYNO", JdeDataType.Numeric, null, true, true),
        new JdeField("CCTGG", "CCTGG", JdeDataType.Numeric, null, true, true),
        new JdeField("CCITM", "CCITM", JdeDataType.Numeric, null, true, true),
        new JdeField("CCMCU", "CCMCU", JdeDataType.String, 24, true, true),
        new JdeField("CCLOCN", "CCLOCN", JdeDataType.String, 40, true, true),
        new JdeField("CCLOTN", "CCLOTN", JdeDataType.String, 60, true, true),
        new JdeField("CCLPNU", "CCLPNU", JdeDataType.String, 80, true, true),
        new JdeField("CCTQCT", "CCTQCT", JdeDataType.Numeric),
        new JdeField("CCTQOH", "CCTQOH", JdeDataType.Numeric),
        new JdeField("CCUOM1", "CCUOM1", JdeDataType.String, 4),
        new JdeField("CCSQOR", "CCSQOR", JdeDataType.Numeric),
        new JdeField("CCSQOH", "CCSQOH", JdeDataType.Numeric),
        new JdeField("CCUOM2", "CCUOM2", JdeDataType.String, 4),
        new JdeField("CCQTY1", "CCQTY1", JdeDataType.Numeric),
        new JdeField("CCQTY2", "CCQTY2", JdeDataType.Numeric),
        new JdeField("CCUOM", "CCUOM", JdeDataType.String, 4),
        new JdeField("CCRCDJ", "CCRCDJ", JdeDataType.Numeric),
        new JdeField("CCMMEJ", "CCMMEJ", JdeDataType.Numeric),
        new JdeField("CCNDTL", "CCNDTL", JdeDataType.String, 2),
        new JdeField("CCWTTY", "CCWTTY", JdeDataType.String, 2),
        new JdeField("CCSMOD", "CCSMOD", JdeDataType.String, 2),
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20),
        new JdeField("CCPID", "CCPID", JdeDataType.String, 20),
        new JdeField("CCJOBN", "CCJOBN", JdeDataType.String, 20),
        new JdeField("CCUPMJ", "CCUPMJ", JdeDataType.Numeric),
        new JdeField("CCTDAY", "CCTDAY", JdeDataType.Numeric),
        new JdeField("CCLPNDC", "CCLPNDC", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46L42_0", "Primary Key on CCCYNO, CCTGG, CCITM, CCMCU, CCLOCN, CCLOTN, CCLPNU", new[] { "CCCYNO", "CCTGG", "CCITM", "CCMCU", "CCLOCN", "CCLOTN", "CCLPNU" }, isUnique: true, isPrimaryKey: true)
    };
}
