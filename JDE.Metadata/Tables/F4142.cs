using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4142 - .
/// </summary>
public class F4142 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CTCYNO.
        /// </summary>
        public const string CTCYNO = "CTCYNO";

        /// <summary>
        /// CTTGG.
        /// </summary>
        public const string CTTGG = "CTTGG";

        /// <summary>
        /// CTITM.
        /// </summary>
        public const string CTITM = "CTITM";

        /// <summary>
        /// CTMCU.
        /// </summary>
        public const string CTMCU = "CTMCU";

        /// <summary>
        /// CTLOCN.
        /// </summary>
        public const string CTLOCN = "CTLOCN";

        /// <summary>
        /// CTLOTN.
        /// </summary>
        public const string CTLOTN = "CTLOTN";

        /// <summary>
        /// CTSTUN.
        /// </summary>
        public const string CTSTUN = "CTSTUN";

        /// <summary>
        /// CTLDSQ.
        /// </summary>
        public const string CTLDSQ = "CTLDSQ";

        /// <summary>
        /// CTSEQ2.
        /// </summary>
        public const string CTSEQ2 = "CTSEQ2";

        /// <summary>
        /// CTTQCT.
        /// </summary>
        public const string CTTQCT = "CTTQCT";

        /// <summary>
        /// CTTQOH.
        /// </summary>
        public const string CTTQOH = "CTTQOH";

        /// <summary>
        /// CTPPL1.
        /// </summary>
        public const string CTPPL1 = "CTPPL1";

        /// <summary>
        /// CTUOM1.
        /// </summary>
        public const string CTUOM1 = "CTUOM1";

        /// <summary>
        /// CTQTY1.
        /// </summary>
        public const string CTQTY1 = "CTQTY1";

        /// <summary>
        /// CTUOM2.
        /// </summary>
        public const string CTUOM2 = "CTUOM2";

        /// <summary>
        /// CTQTY2.
        /// </summary>
        public const string CTQTY2 = "CTQTY2";

        /// <summary>
        /// CTUML1.
        /// </summary>
        public const string CTUML1 = "CTUML1";

        /// <summary>
        /// CTEQL1.
        /// </summary>
        public const string CTEQL1 = "CTEQL1";

        /// <summary>
        /// CTUML2.
        /// </summary>
        public const string CTUML2 = "CTUML2";

        /// <summary>
        /// CTEQL2.
        /// </summary>
        public const string CTEQL2 = "CTEQL2";

        /// <summary>
        /// CTUML3.
        /// </summary>
        public const string CTUML3 = "CTUML3";

        /// <summary>
        /// CTEQL3.
        /// </summary>
        public const string CTEQL3 = "CTEQL3";

        /// <summary>
        /// CTUML4.
        /// </summary>
        public const string CTUML4 = "CTUML4";

        /// <summary>
        /// CTEQL4.
        /// </summary>
        public const string CTEQL4 = "CTEQL4";

        /// <summary>
        /// CTUML5.
        /// </summary>
        public const string CTUML5 = "CTUML5";

        /// <summary>
        /// CTEQL5.
        /// </summary>
        public const string CTEQL5 = "CTEQL5";

        /// <summary>
        /// CTRCDJ.
        /// </summary>
        public const string CTRCDJ = "CTRCDJ";

        /// <summary>
        /// CTMMEJ.
        /// </summary>
        public const string CTMMEJ = "CTMMEJ";

        /// <summary>
        /// CTNDTL.
        /// </summary>
        public const string CTNDTL = "CTNDTL";

        /// <summary>
        /// CTWTTY.
        /// </summary>
        public const string CTWTTY = "CTWTTY";

        /// <summary>
        /// CTSMOD.
        /// </summary>
        public const string CTSMOD = "CTSMOD";

        /// <summary>
        /// CTUSER.
        /// </summary>
        public const string CTUSER = "CTUSER";

        /// <summary>
        /// CTPID.
        /// </summary>
        public const string CTPID = "CTPID";

        /// <summary>
        /// CTJOBN.
        /// </summary>
        public const string CTJOBN = "CTJOBN";

        /// <summary>
        /// CTUPMJ.
        /// </summary>
        public const string CTUPMJ = "CTUPMJ";

        /// <summary>
        /// CTTDAY.
        /// </summary>
        public const string CTTDAY = "CTTDAY";

        /// <summary>
        /// CTSQOR.
        /// </summary>
        public const string CTSQOR = "CTSQOR";

        /// <summary>
        /// CTUOM.
        /// </summary>
        public const string CTUOM = "CTUOM";

        /// <summary>
        /// CTSQOH.
        /// </summary>
        public const string CTSQOH = "CTSQOH";

        /// <summary>
        /// CTUM.
        /// </summary>
        public const string CTUM = "CTUM";
    }

    /// <inheritdoc />
    public override string TableName => "F4142";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CTCYNO", "CTCYNO", JdeDataType.Numeric, null, true, true),
        new JdeField("CTTGG", "CTTGG", JdeDataType.Numeric, null, true, true),
        new JdeField("CTITM", "CTITM", JdeDataType.Numeric, null, true, true),
        new JdeField("CTMCU", "CTMCU", JdeDataType.String, 24, true, true),
        new JdeField("CTLOCN", "CTLOCN", JdeDataType.String, 40, true, true),
        new JdeField("CTLOTN", "CTLOTN", JdeDataType.String, 60, true, true),
        new JdeField("CTSTUN", "CTSTUN", JdeDataType.Numeric),
        new JdeField("CTLDSQ", "CTLDSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("CTSEQ2", "CTSEQ2", JdeDataType.Numeric, null, true, true),
        new JdeField("CTTQCT", "CTTQCT", JdeDataType.Numeric),
        new JdeField("CTTQOH", "CTTQOH", JdeDataType.Numeric),
        new JdeField("CTPPL1", "CTPPL1", JdeDataType.Numeric),
        new JdeField("CTUOM1", "CTUOM1", JdeDataType.String, 4),
        new JdeField("CTQTY1", "CTQTY1", JdeDataType.Numeric),
        new JdeField("CTUOM2", "CTUOM2", JdeDataType.String, 4),
        new JdeField("CTQTY2", "CTQTY2", JdeDataType.Numeric),
        new JdeField("CTUML1", "CTUML1", JdeDataType.String, 4),
        new JdeField("CTEQL1", "CTEQL1", JdeDataType.String, 10),
        new JdeField("CTUML2", "CTUML2", JdeDataType.String, 4),
        new JdeField("CTEQL2", "CTEQL2", JdeDataType.String, 10),
        new JdeField("CTUML3", "CTUML3", JdeDataType.String, 4),
        new JdeField("CTEQL3", "CTEQL3", JdeDataType.String, 10),
        new JdeField("CTUML4", "CTUML4", JdeDataType.String, 4),
        new JdeField("CTEQL4", "CTEQL4", JdeDataType.String, 10),
        new JdeField("CTUML5", "CTUML5", JdeDataType.String, 4),
        new JdeField("CTEQL5", "CTEQL5", JdeDataType.String, 10),
        new JdeField("CTRCDJ", "CTRCDJ", JdeDataType.Numeric),
        new JdeField("CTMMEJ", "CTMMEJ", JdeDataType.Numeric),
        new JdeField("CTNDTL", "CTNDTL", JdeDataType.String, 2),
        new JdeField("CTWTTY", "CTWTTY", JdeDataType.String, 2),
        new JdeField("CTSMOD", "CTSMOD", JdeDataType.String, 2),
        new JdeField("CTUSER", "CTUSER", JdeDataType.String, 20),
        new JdeField("CTPID", "CTPID", JdeDataType.String, 20),
        new JdeField("CTJOBN", "CTJOBN", JdeDataType.String, 20),
        new JdeField("CTUPMJ", "CTUPMJ", JdeDataType.Numeric),
        new JdeField("CTTDAY", "CTTDAY", JdeDataType.Numeric),
        new JdeField("CTSQOR", "CTSQOR", JdeDataType.Numeric),
        new JdeField("CTUOM", "CTUOM", JdeDataType.String, 4),
        new JdeField("CTSQOH", "CTSQOH", JdeDataType.Numeric),
        new JdeField("CTUM", "CTUM", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4142_0", "Primary Key on CTCYNO, CTTGG, CTITM, CTMCU, CTLOCN, CTLOTN, CTLDSQ, CTSEQ2", new[] { "CTCYNO", "CTTGG", "CTITM", "CTMCU", "CTLOCN", "CTLOTN", "CTLDSQ", "CTSEQ2" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4142_2", "Index on CTITM, CTMCU, CTLOCN, CTLOTN", new[] { "CTITM", "CTMCU", "CTLOCN", "CTLOTN" }),
        new JdeIndex("F4142_3", "Index on CTCYNO, CTITM, CTMCU, CTLOCN, CTLOTN, CTLDSQ", new[] { "CTCYNO", "CTITM", "CTMCU", "CTLOCN", "CTLOTN", "CTLDSQ" })
    };
}
