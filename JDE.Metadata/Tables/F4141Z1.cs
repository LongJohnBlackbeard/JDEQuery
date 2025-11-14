using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4141Z1 - .
/// </summary>
public class F4141Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SZEDUS.
        /// </summary>
        public const string SZEDUS = "SZEDUS";

        /// <summary>
        /// SZEDBT.
        /// </summary>
        public const string SZEDBT = "SZEDBT";

        /// <summary>
        /// SZEDTN.
        /// </summary>
        public const string SZEDTN = "SZEDTN";

        /// <summary>
        /// SZEDLN.
        /// </summary>
        public const string SZEDLN = "SZEDLN";

        /// <summary>
        /// SZEDCT.
        /// </summary>
        public const string SZEDCT = "SZEDCT";

        /// <summary>
        /// SZTYTN.
        /// </summary>
        public const string SZTYTN = "SZTYTN";

        /// <summary>
        /// SZEDFT.
        /// </summary>
        public const string SZEDFT = "SZEDFT";

        /// <summary>
        /// SZEDDT.
        /// </summary>
        public const string SZEDDT = "SZEDDT";

        /// <summary>
        /// SZDRIN.
        /// </summary>
        public const string SZDRIN = "SZDRIN";

        /// <summary>
        /// SZEDDL.
        /// </summary>
        public const string SZEDDL = "SZEDDL";

        /// <summary>
        /// SZEDSP.
        /// </summary>
        public const string SZEDSP = "SZEDSP";

        /// <summary>
        /// SZPNID.
        /// </summary>
        public const string SZPNID = "SZPNID";

        /// <summary>
        /// SZTNAC.
        /// </summary>
        public const string SZTNAC = "SZTNAC";

        /// <summary>
        /// SZCYNO.
        /// </summary>
        public const string SZCYNO = "SZCYNO";

        /// <summary>
        /// SZCCCD.
        /// </summary>
        public const string SZCCCD = "SZCCCD";

        /// <summary>
        /// SZITM.
        /// </summary>
        public const string SZITM = "SZITM";

        /// <summary>
        /// SZLITM.
        /// </summary>
        public const string SZLITM = "SZLITM";

        /// <summary>
        /// SZAITM.
        /// </summary>
        public const string SZAITM = "SZAITM";

        /// <summary>
        /// SZMCU.
        /// </summary>
        public const string SZMCU = "SZMCU";

        /// <summary>
        /// SZLOCN.
        /// </summary>
        public const string SZLOCN = "SZLOCN";

        /// <summary>
        /// SZLOTN.
        /// </summary>
        public const string SZLOTN = "SZLOTN";

        /// <summary>
        /// SZSTUN.
        /// </summary>
        public const string SZSTUN = "SZSTUN";

        /// <summary>
        /// SZSRP1.
        /// </summary>
        public const string SZSRP1 = "SZSRP1";

        /// <summary>
        /// SZSRP2.
        /// </summary>
        public const string SZSRP2 = "SZSRP2";

        /// <summary>
        /// SZSRP3.
        /// </summary>
        public const string SZSRP3 = "SZSRP3";

        /// <summary>
        /// SZSRP4.
        /// </summary>
        public const string SZSRP4 = "SZSRP4";

        /// <summary>
        /// SZSRP5.
        /// </summary>
        public const string SZSRP5 = "SZSRP5";

        /// <summary>
        /// SZGLPT.
        /// </summary>
        public const string SZGLPT = "SZGLPT";

        /// <summary>
        /// SZTQOH.
        /// </summary>
        public const string SZTQOH = "SZTQOH";

        /// <summary>
        /// SZTAOH.
        /// </summary>
        public const string SZTAOH = "SZTAOH";

        /// <summary>
        /// SZTQCT.
        /// </summary>
        public const string SZTQCT = "SZTQCT";

        /// <summary>
        /// SZTACT.
        /// </summary>
        public const string SZTACT = "SZTACT";

        /// <summary>
        /// SZTRQT.
        /// </summary>
        public const string SZTRQT = "SZTRQT";

        /// <summary>
        /// SZUOM.
        /// </summary>
        public const string SZUOM = "SZUOM";

        /// <summary>
        /// SZUNCS.
        /// </summary>
        public const string SZUNCS = "SZUNCS";

        /// <summary>
        /// SZCNTJ.
        /// </summary>
        public const string SZCNTJ = "SZCNTJ";

        /// <summary>
        /// SZCNTB.
        /// </summary>
        public const string SZCNTB = "SZCNTB";

        /// <summary>
        /// SZAISL.
        /// </summary>
        public const string SZAISL = "SZAISL";

        /// <summary>
        /// SZBIN.
        /// </summary>
        public const string SZBIN = "SZBIN";

        /// <summary>
        /// SZUSER.
        /// </summary>
        public const string SZUSER = "SZUSER";

        /// <summary>
        /// SZPID.
        /// </summary>
        public const string SZPID = "SZPID";

        /// <summary>
        /// SZJOBN.
        /// </summary>
        public const string SZJOBN = "SZJOBN";

        /// <summary>
        /// SZUPMJ.
        /// </summary>
        public const string SZUPMJ = "SZUPMJ";

        /// <summary>
        /// SZTDAY.
        /// </summary>
        public const string SZTDAY = "SZTDAY";

        /// <summary>
        /// SZLOT1.
        /// </summary>
        public const string SZLOT1 = "SZLOT1";

        /// <summary>
        /// SZLOT2.
        /// </summary>
        public const string SZLOT2 = "SZLOT2";

        /// <summary>
        /// SZLOT3.
        /// </summary>
        public const string SZLOT3 = "SZLOT3";

        /// <summary>
        /// SZSQOR.
        /// </summary>
        public const string SZSQOR = "SZSQOR";

        /// <summary>
        /// SZSQOH.
        /// </summary>
        public const string SZSQOH = "SZSQOH";
    }

    /// <inheritdoc />
    public override string TableName => "F4141Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SZEDUS", "SZEDUS", JdeDataType.String, 20, true, true),
        new JdeField("SZEDBT", "SZEDBT", JdeDataType.String, 30, true, true),
        new JdeField("SZEDTN", "SZEDTN", JdeDataType.String, 44, true, true),
        new JdeField("SZEDLN", "SZEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("SZEDCT", "SZEDCT", JdeDataType.String, 4),
        new JdeField("SZTYTN", "SZTYTN", JdeDataType.String, 16),
        new JdeField("SZEDFT", "SZEDFT", JdeDataType.String, 20),
        new JdeField("SZEDDT", "SZEDDT", JdeDataType.Numeric),
        new JdeField("SZDRIN", "SZDRIN", JdeDataType.String, 2),
        new JdeField("SZEDDL", "SZEDDL", JdeDataType.Numeric),
        new JdeField("SZEDSP", "SZEDSP", JdeDataType.String, 2),
        new JdeField("SZPNID", "SZPNID", JdeDataType.String, 30),
        new JdeField("SZTNAC", "SZTNAC", JdeDataType.String, 4),
        new JdeField("SZCYNO", "SZCYNO", JdeDataType.Numeric),
        new JdeField("SZCCCD", "SZCCCD", JdeDataType.String, 2),
        new JdeField("SZITM", "SZITM", JdeDataType.Numeric),
        new JdeField("SZLITM", "SZLITM", JdeDataType.String, 50),
        new JdeField("SZAITM", "SZAITM", JdeDataType.String, 50),
        new JdeField("SZMCU", "SZMCU", JdeDataType.String, 24),
        new JdeField("SZLOCN", "SZLOCN", JdeDataType.String, 40),
        new JdeField("SZLOTN", "SZLOTN", JdeDataType.String, 60),
        new JdeField("SZSTUN", "SZSTUN", JdeDataType.Numeric),
        new JdeField("SZSRP1", "SZSRP1", JdeDataType.String, 6),
        new JdeField("SZSRP2", "SZSRP2", JdeDataType.String, 6),
        new JdeField("SZSRP3", "SZSRP3", JdeDataType.String, 6),
        new JdeField("SZSRP4", "SZSRP4", JdeDataType.String, 6),
        new JdeField("SZSRP5", "SZSRP5", JdeDataType.String, 6),
        new JdeField("SZGLPT", "SZGLPT", JdeDataType.String, 8),
        new JdeField("SZTQOH", "SZTQOH", JdeDataType.Numeric),
        new JdeField("SZTAOH", "SZTAOH", JdeDataType.Numeric),
        new JdeField("SZTQCT", "SZTQCT", JdeDataType.Numeric),
        new JdeField("SZTACT", "SZTACT", JdeDataType.Numeric),
        new JdeField("SZTRQT", "SZTRQT", JdeDataType.Numeric),
        new JdeField("SZUOM", "SZUOM", JdeDataType.String, 4),
        new JdeField("SZUNCS", "SZUNCS", JdeDataType.Numeric),
        new JdeField("SZCNTJ", "SZCNTJ", JdeDataType.Numeric),
        new JdeField("SZCNTB", "SZCNTB", JdeDataType.String, 20),
        new JdeField("SZAISL", "SZAISL", JdeDataType.String, 16),
        new JdeField("SZBIN", "SZBIN", JdeDataType.String, 16),
        new JdeField("SZUSER", "SZUSER", JdeDataType.String, 20),
        new JdeField("SZPID", "SZPID", JdeDataType.String, 20),
        new JdeField("SZJOBN", "SZJOBN", JdeDataType.String, 20),
        new JdeField("SZUPMJ", "SZUPMJ", JdeDataType.Numeric),
        new JdeField("SZTDAY", "SZTDAY", JdeDataType.Numeric),
        new JdeField("SZLOT1", "SZLOT1", JdeDataType.String, 60),
        new JdeField("SZLOT2", "SZLOT2", JdeDataType.String, 60),
        new JdeField("SZLOT3", "SZLOT3", JdeDataType.String, 60),
        new JdeField("SZSQOR", "SZSQOR", JdeDataType.Numeric),
        new JdeField("SZSQOH", "SZSQOH", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4141Z1_0", "Primary Key on SZEDUS, SZEDBT, SZEDTN, SZEDLN", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
