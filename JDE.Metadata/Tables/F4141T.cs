using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4141T - .
/// </summary>
public class F4141T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PCCYNO.
        /// </summary>
        public const string PCCYNO = "PCCYNO";

        /// <summary>
        /// PCCCCD.
        /// </summary>
        public const string PCCCCD = "PCCCCD";

        /// <summary>
        /// PCITM.
        /// </summary>
        public const string PCITM = "PCITM";

        /// <summary>
        /// PCLITM.
        /// </summary>
        public const string PCLITM = "PCLITM";

        /// <summary>
        /// PCAITM.
        /// </summary>
        public const string PCAITM = "PCAITM";

        /// <summary>
        /// PCMCU.
        /// </summary>
        public const string PCMCU = "PCMCU";

        /// <summary>
        /// PCLOCN.
        /// </summary>
        public const string PCLOCN = "PCLOCN";

        /// <summary>
        /// PCLOTN.
        /// </summary>
        public const string PCLOTN = "PCLOTN";

        /// <summary>
        /// PCSTUN.
        /// </summary>
        public const string PCSTUN = "PCSTUN";

        /// <summary>
        /// PCPNS.
        /// </summary>
        public const string PCPNS = "PCPNS";

        /// <summary>
        /// PCPMPN.
        /// </summary>
        public const string PCPMPN = "PCPMPN";

        /// <summary>
        /// PCTQOH.
        /// </summary>
        public const string PCTQOH = "PCTQOH";

        /// <summary>
        /// PCTQCT.
        /// </summary>
        public const string PCTQCT = "PCTQCT";

        /// <summary>
        /// PCSQOH.
        /// </summary>
        public const string PCSQOH = "PCSQOH";

        /// <summary>
        /// PCSQOR.
        /// </summary>
        public const string PCSQOR = "PCSQOR";

        /// <summary>
        /// PCCNTJ.
        /// </summary>
        public const string PCCNTJ = "PCCNTJ";

        /// <summary>
        /// PCCNTB.
        /// </summary>
        public const string PCCNTB = "PCCNTB";

        /// <summary>
        /// PCFFU3.
        /// </summary>
        public const string PCFFU3 = "PCFFU3";

        /// <summary>
        /// PCFFU4.
        /// </summary>
        public const string PCFFU4 = "PCFFU4";

        /// <summary>
        /// PCTFUDJ.
        /// </summary>
        public const string PCTFUDJ = "PCTFUDJ";

        /// <summary>
        /// PCURCD.
        /// </summary>
        public const string PCURCD = "PCURCD";

        /// <summary>
        /// PCURDT.
        /// </summary>
        public const string PCURDT = "PCURDT";

        /// <summary>
        /// PCURAT.
        /// </summary>
        public const string PCURAT = "PCURAT";

        /// <summary>
        /// PCURAB.
        /// </summary>
        public const string PCURAB = "PCURAB";

        /// <summary>
        /// PCURRF.
        /// </summary>
        public const string PCURRF = "PCURRF";

        /// <summary>
        /// PCUSER.
        /// </summary>
        public const string PCUSER = "PCUSER";

        /// <summary>
        /// PCPID.
        /// </summary>
        public const string PCPID = "PCPID";

        /// <summary>
        /// PCJOBN.
        /// </summary>
        public const string PCJOBN = "PCJOBN";

        /// <summary>
        /// PCUPMJ.
        /// </summary>
        public const string PCUPMJ = "PCUPMJ";

        /// <summary>
        /// PCTDAY.
        /// </summary>
        public const string PCTDAY = "PCTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4141T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PCCYNO", "PCCYNO", JdeDataType.Numeric, null, true, true),
        new JdeField("PCCCCD", "PCCCCD", JdeDataType.String, 2),
        new JdeField("PCITM", "PCITM", JdeDataType.Numeric),
        new JdeField("PCLITM", "PCLITM", JdeDataType.String, 50, true, true),
        new JdeField("PCAITM", "PCAITM", JdeDataType.String, 50),
        new JdeField("PCMCU", "PCMCU", JdeDataType.String, 24, true, true),
        new JdeField("PCLOCN", "PCLOCN", JdeDataType.String, 40, true, true),
        new JdeField("PCLOTN", "PCLOTN", JdeDataType.String, 60, true, true),
        new JdeField("PCSTUN", "PCSTUN", JdeDataType.Numeric, null, true, true),
        new JdeField("PCPNS", "PCPNS", JdeDataType.Numeric, null, true, true),
        new JdeField("PCPMPN", "PCPMPN", JdeDataType.String, 60),
        new JdeField("PCTQOH", "PCTQOH", JdeDataType.Numeric),
        new JdeField("PCTQCT", "PCTQCT", JdeDataType.Numeric),
        new JdeField("PCSQOH", "PCSQOH", JdeDataType.Numeric),
        new JdeField("PCSQOR", "PCSQOR", JdeDataType.Numeric),
        new JdeField("PCCNTJ", "PCCNTJ", JdeDataType.Numeric),
        new JdeField("PCCNTB", "PCCNTB", JdeDataType.String, 20),
        new JdeField("PCFFU3", "PCFFU3", JdeDataType.String, 20),
        new JdeField("PCFFU4", "PCFFU4", JdeDataType.Numeric),
        new JdeField("PCTFUDJ", "PCTFUDJ", JdeDataType.Numeric),
        new JdeField("PCURCD", "PCURCD", JdeDataType.String, 4),
        new JdeField("PCURDT", "PCURDT", JdeDataType.Numeric),
        new JdeField("PCURAT", "PCURAT", JdeDataType.Numeric),
        new JdeField("PCURAB", "PCURAB", JdeDataType.Numeric),
        new JdeField("PCURRF", "PCURRF", JdeDataType.String, 30),
        new JdeField("PCUSER", "PCUSER", JdeDataType.String, 20),
        new JdeField("PCPID", "PCPID", JdeDataType.String, 20),
        new JdeField("PCJOBN", "PCJOBN", JdeDataType.String, 20),
        new JdeField("PCUPMJ", "PCUPMJ", JdeDataType.Numeric),
        new JdeField("PCTDAY", "PCTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4141T_0", "Primary Key on PCCYNO, PCLITM, PCMCU, PCLOCN, PCLOTN, PCSTUN, PCPNS", new[] { "PCCYNO", "PCLITM", "PCMCU", "PCLOCN", "PCLOTN", "PCSTUN", "PCPNS" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4141T_2", "Index on PCCYNO, PCLITM, PCMCU, PCLOCN, PCLOTN, PCSTUN", new[] { "PCCYNO", "PCLITM", "PCMCU", "PCLOCN", "PCLOTN", "PCSTUN" }),
        new JdeIndex("F4141T_3", "Index on PCCYNO, PCMCU, PCLOCN, PCLOTN, PCSTUN", new[] { "PCCYNO", "PCMCU", "PCLOCN", "PCLOTN", "PCSTUN" })
    };
}
