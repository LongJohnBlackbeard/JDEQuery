using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47082 - .
/// </summary>
public class F47082 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FYEDTY.
        /// </summary>
        public const string FYEDTY = "FYEDTY";

        /// <summary>
        /// FYEDSQ.
        /// </summary>
        public const string FYEDSQ = "FYEDSQ";

        /// <summary>
        /// FYEKCO.
        /// </summary>
        public const string FYEKCO = "FYEKCO";

        /// <summary>
        /// FYEDOC.
        /// </summary>
        public const string FYEDOC = "FYEDOC";

        /// <summary>
        /// FYEDCT.
        /// </summary>
        public const string FYEDCT = "FYEDCT";

        /// <summary>
        /// FYEDLN.
        /// </summary>
        public const string FYEDLN = "FYEDLN";

        /// <summary>
        /// FYEDST.
        /// </summary>
        public const string FYEDST = "FYEDST";

        /// <summary>
        /// FYEDFT.
        /// </summary>
        public const string FYEDFT = "FYEDFT";

        /// <summary>
        /// FYEDDT.
        /// </summary>
        public const string FYEDDT = "FYEDDT";

        /// <summary>
        /// FYEDER.
        /// </summary>
        public const string FYEDER = "FYEDER";

        /// <summary>
        /// FYEDDL.
        /// </summary>
        public const string FYEDDL = "FYEDDL";

        /// <summary>
        /// FYEDSP.
        /// </summary>
        public const string FYEDSP = "FYEDSP";

        /// <summary>
        /// FYEDBT.
        /// </summary>
        public const string FYEDBT = "FYEDBT";

        /// <summary>
        /// FYPNID.
        /// </summary>
        public const string FYPNID = "FYPNID";

        /// <summary>
        /// FYITM.
        /// </summary>
        public const string FYITM = "FYITM";

        /// <summary>
        /// FYLITM.
        /// </summary>
        public const string FYLITM = "FYLITM";

        /// <summary>
        /// FYAITM.
        /// </summary>
        public const string FYAITM = "FYAITM";

        /// <summary>
        /// FYCITM.
        /// </summary>
        public const string FYCITM = "FYCITM";

        /// <summary>
        /// FYDSC1.
        /// </summary>
        public const string FYDSC1 = "FYDSC1";

        /// <summary>
        /// FYDSC2.
        /// </summary>
        public const string FYDSC2 = "FYDSC2";

        /// <summary>
        /// FYMCU.
        /// </summary>
        public const string FYMCU = "FYMCU";

        /// <summary>
        /// FYSRP1.
        /// </summary>
        public const string FYSRP1 = "FYSRP1";

        /// <summary>
        /// FYSRP2.
        /// </summary>
        public const string FYSRP2 = "FYSRP2";

        /// <summary>
        /// FYSRP3.
        /// </summary>
        public const string FYSRP3 = "FYSRP3";

        /// <summary>
        /// FYSRP4.
        /// </summary>
        public const string FYSRP4 = "FYSRP4";

        /// <summary>
        /// FYSRP5.
        /// </summary>
        public const string FYSRP5 = "FYSRP5";

        /// <summary>
        /// FYSRP6.
        /// </summary>
        public const string FYSRP6 = "FYSRP6";

        /// <summary>
        /// FYSRP7.
        /// </summary>
        public const string FYSRP7 = "FYSRP7";

        /// <summary>
        /// FYSRP8.
        /// </summary>
        public const string FYSRP8 = "FYSRP8";

        /// <summary>
        /// FYSRP9.
        /// </summary>
        public const string FYSRP9 = "FYSRP9";

        /// <summary>
        /// FYSRP0.
        /// </summary>
        public const string FYSRP0 = "FYSRP0";

        /// <summary>
        /// FYPRP1.
        /// </summary>
        public const string FYPRP1 = "FYPRP1";

        /// <summary>
        /// FYPRP2.
        /// </summary>
        public const string FYPRP2 = "FYPRP2";

        /// <summary>
        /// FYPRP3.
        /// </summary>
        public const string FYPRP3 = "FYPRP3";

        /// <summary>
        /// FYPRP4.
        /// </summary>
        public const string FYPRP4 = "FYPRP4";

        /// <summary>
        /// FYPRP5.
        /// </summary>
        public const string FYPRP5 = "FYPRP5";

        /// <summary>
        /// FYPRP6.
        /// </summary>
        public const string FYPRP6 = "FYPRP6";

        /// <summary>
        /// FYPRP7.
        /// </summary>
        public const string FYPRP7 = "FYPRP7";

        /// <summary>
        /// FYPRP8.
        /// </summary>
        public const string FYPRP8 = "FYPRP8";

        /// <summary>
        /// FYPRP9.
        /// </summary>
        public const string FYPRP9 = "FYPRP9";

        /// <summary>
        /// FYPRP0.
        /// </summary>
        public const string FYPRP0 = "FYPRP0";

        /// <summary>
        /// FYCDCR.
        /// </summary>
        public const string FYCDCR = "FYCDCR";

        /// <summary>
        /// FYPDGR.
        /// </summary>
        public const string FYPDGR = "FYPDGR";

        /// <summary>
        /// FYDSGP.
        /// </summary>
        public const string FYDSGP = "FYDSGP";

        /// <summary>
        /// FYORIG.
        /// </summary>
        public const string FYORIG = "FYORIG";

        /// <summary>
        /// FYSLD.
        /// </summary>
        public const string FYSLD = "FYSLD";

        /// <summary>
        /// FYSTDP.
        /// </summary>
        public const string FYSTDP = "FYSTDP";

        /// <summary>
        /// FYFRMP.
        /// </summary>
        public const string FYFRMP = "FYFRMP";

        /// <summary>
        /// FYTHRP.
        /// </summary>
        public const string FYTHRP = "FYTHRP";

        /// <summary>
        /// FYSTDG.
        /// </summary>
        public const string FYSTDG = "FYSTDG";

        /// <summary>
        /// FYFRGD.
        /// </summary>
        public const string FYFRGD = "FYFRGD";

        /// <summary>
        /// FYTHGD.
        /// </summary>
        public const string FYTHGD = "FYTHGD";

        /// <summary>
        /// FYCOTY.
        /// </summary>
        public const string FYCOTY = "FYCOTY";

        /// <summary>
        /// FYIFLA.
        /// </summary>
        public const string FYIFLA = "FYIFLA";

        /// <summary>
        /// FYSHCN.
        /// </summary>
        public const string FYSHCN = "FYSHCN";

        /// <summary>
        /// FYINMG.
        /// </summary>
        public const string FYINMG = "FYINMG";

        /// <summary>
        /// FYTX.
        /// </summary>
        public const string FYTX = "FYTX";

        /// <summary>
        /// FYTAX1.
        /// </summary>
        public const string FYTAX1 = "FYTAX1";

        /// <summary>
        /// FYUPC.
        /// </summary>
        public const string FYUPC = "FYUPC";

        /// <summary>
        /// FYMERL.
        /// </summary>
        public const string FYMERL = "FYMERL";

        /// <summary>
        /// FYUOM1.
        /// </summary>
        public const string FYUOM1 = "FYUOM1";

        /// <summary>
        /// FYUOM4.
        /// </summary>
        public const string FYUOM4 = "FYUOM4";

        /// <summary>
        /// FYUWUM.
        /// </summary>
        public const string FYUWUM = "FYUWUM";

        /// <summary>
        /// FYUVM1.
        /// </summary>
        public const string FYUVM1 = "FYUVM1";

        /// <summary>
        /// FYLOTG.
        /// </summary>
        public const string FYLOTG = "FYLOTG";

        /// <summary>
        /// FYLOTP.
        /// </summary>
        public const string FYLOTP = "FYLOTP";

        /// <summary>
        /// FYCRCD.
        /// </summary>
        public const string FYCRCD = "FYCRCD";

        /// <summary>
        /// FYUOM.
        /// </summary>
        public const string FYUOM = "FYUOM";

        /// <summary>
        /// FYTRQT.
        /// </summary>
        public const string FYTRQT = "FYTRQT";

        /// <summary>
        /// FYEFTJ.
        /// </summary>
        public const string FYEFTJ = "FYEFTJ";

        /// <summary>
        /// FYEXDJ.
        /// </summary>
        public const string FYEXDJ = "FYEXDJ";

        /// <summary>
        /// FYUPRC.
        /// </summary>
        public const string FYUPRC = "FYUPRC";

        /// <summary>
        /// FYACRD.
        /// </summary>
        public const string FYACRD = "FYACRD";

        /// <summary>
        /// FYUPCN.
        /// </summary>
        public const string FYUPCN = "FYUPCN";

        /// <summary>
        /// FYSCC0.
        /// </summary>
        public const string FYSCC0 = "FYSCC0";

        /// <summary>
        /// FYUMUP.
        /// </summary>
        public const string FYUMUP = "FYUMUP";

        /// <summary>
        /// FYUMDF.
        /// </summary>
        public const string FYUMDF = "FYUMDF";

        /// <summary>
        /// FYURCD.
        /// </summary>
        public const string FYURCD = "FYURCD";

        /// <summary>
        /// FYURDT.
        /// </summary>
        public const string FYURDT = "FYURDT";

        /// <summary>
        /// FYURAT.
        /// </summary>
        public const string FYURAT = "FYURAT";

        /// <summary>
        /// FYURAB.
        /// </summary>
        public const string FYURAB = "FYURAB";

        /// <summary>
        /// FYURRF.
        /// </summary>
        public const string FYURRF = "FYURRF";

        /// <summary>
        /// FYTORG.
        /// </summary>
        public const string FYTORG = "FYTORG";

        /// <summary>
        /// FYUSER.
        /// </summary>
        public const string FYUSER = "FYUSER";

        /// <summary>
        /// FYPID.
        /// </summary>
        public const string FYPID = "FYPID";

        /// <summary>
        /// FYJOBN.
        /// </summary>
        public const string FYJOBN = "FYJOBN";

        /// <summary>
        /// FYCDCD.
        /// </summary>
        public const string FYCDCD = "FYCDCD";
    }

    /// <inheritdoc />
    public override string TableName => "F47082";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FYEDTY", "FYEDTY", JdeDataType.String, 2),
        new JdeField("FYEDSQ", "FYEDSQ", JdeDataType.Numeric),
        new JdeField("FYEKCO", "FYEKCO", JdeDataType.String, 10, true, true),
        new JdeField("FYEDOC", "FYEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("FYEDCT", "FYEDCT", JdeDataType.String, 4, true, true),
        new JdeField("FYEDLN", "FYEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("FYEDST", "FYEDST", JdeDataType.String, 12),
        new JdeField("FYEDFT", "FYEDFT", JdeDataType.String, 20),
        new JdeField("FYEDDT", "FYEDDT", JdeDataType.Numeric),
        new JdeField("FYEDER", "FYEDER", JdeDataType.String, 2),
        new JdeField("FYEDDL", "FYEDDL", JdeDataType.Numeric),
        new JdeField("FYEDSP", "FYEDSP", JdeDataType.String, 2),
        new JdeField("FYEDBT", "FYEDBT", JdeDataType.String, 30),
        new JdeField("FYPNID", "FYPNID", JdeDataType.String, 30),
        new JdeField("FYITM", "FYITM", JdeDataType.Numeric),
        new JdeField("FYLITM", "FYLITM", JdeDataType.String, 50),
        new JdeField("FYAITM", "FYAITM", JdeDataType.String, 50),
        new JdeField("FYCITM", "FYCITM", JdeDataType.String, 50),
        new JdeField("FYDSC1", "FYDSC1", JdeDataType.String, 60),
        new JdeField("FYDSC2", "FYDSC2", JdeDataType.String, 60),
        new JdeField("FYMCU", "FYMCU", JdeDataType.String, 24),
        new JdeField("FYSRP1", "FYSRP1", JdeDataType.String, 6),
        new JdeField("FYSRP2", "FYSRP2", JdeDataType.String, 6),
        new JdeField("FYSRP3", "FYSRP3", JdeDataType.String, 6),
        new JdeField("FYSRP4", "FYSRP4", JdeDataType.String, 6),
        new JdeField("FYSRP5", "FYSRP5", JdeDataType.String, 6),
        new JdeField("FYSRP6", "FYSRP6", JdeDataType.String, 12),
        new JdeField("FYSRP7", "FYSRP7", JdeDataType.String, 12),
        new JdeField("FYSRP8", "FYSRP8", JdeDataType.String, 12),
        new JdeField("FYSRP9", "FYSRP9", JdeDataType.String, 12),
        new JdeField("FYSRP0", "FYSRP0", JdeDataType.String, 12),
        new JdeField("FYPRP1", "FYPRP1", JdeDataType.String, 6),
        new JdeField("FYPRP2", "FYPRP2", JdeDataType.String, 6),
        new JdeField("FYPRP3", "FYPRP3", JdeDataType.String, 6),
        new JdeField("FYPRP4", "FYPRP4", JdeDataType.String, 6),
        new JdeField("FYPRP5", "FYPRP5", JdeDataType.String, 6),
        new JdeField("FYPRP6", "FYPRP6", JdeDataType.String, 12),
        new JdeField("FYPRP7", "FYPRP7", JdeDataType.String, 12),
        new JdeField("FYPRP8", "FYPRP8", JdeDataType.String, 12),
        new JdeField("FYPRP9", "FYPRP9", JdeDataType.String, 12),
        new JdeField("FYPRP0", "FYPRP0", JdeDataType.String, 12),
        new JdeField("FYCDCR", "FYCDCR", JdeDataType.Numeric),
        new JdeField("FYPDGR", "FYPDGR", JdeDataType.String, 6),
        new JdeField("FYDSGP", "FYDSGP", JdeDataType.String, 6),
        new JdeField("FYORIG", "FYORIG", JdeDataType.String, 6),
        new JdeField("FYSLD", "FYSLD", JdeDataType.Numeric),
        new JdeField("FYSTDP", "FYSTDP", JdeDataType.Numeric),
        new JdeField("FYFRMP", "FYFRMP", JdeDataType.Numeric),
        new JdeField("FYTHRP", "FYTHRP", JdeDataType.Numeric),
        new JdeField("FYSTDG", "FYSTDG", JdeDataType.String, 6),
        new JdeField("FYFRGD", "FYFRGD", JdeDataType.String, 6),
        new JdeField("FYTHGD", "FYTHGD", JdeDataType.String, 6),
        new JdeField("FYCOTY", "FYCOTY", JdeDataType.String, 2),
        new JdeField("FYIFLA", "FYIFLA", JdeDataType.String, 4),
        new JdeField("FYSHCN", "FYSHCN", JdeDataType.String, 6),
        new JdeField("FYINMG", "FYINMG", JdeDataType.String, 20),
        new JdeField("FYTX", "FYTX", JdeDataType.String, 2),
        new JdeField("FYTAX1", "FYTAX1", JdeDataType.String, 2),
        new JdeField("FYUPC", "FYUPC", JdeDataType.Numeric),
        new JdeField("FYMERL", "FYMERL", JdeDataType.String, 6),
        new JdeField("FYUOM1", "FYUOM1", JdeDataType.String, 4),
        new JdeField("FYUOM4", "FYUOM4", JdeDataType.String, 4),
        new JdeField("FYUWUM", "FYUWUM", JdeDataType.String, 4),
        new JdeField("FYUVM1", "FYUVM1", JdeDataType.String, 4),
        new JdeField("FYLOTG", "FYLOTG", JdeDataType.String, 6),
        new JdeField("FYLOTP", "FYLOTP", JdeDataType.Numeric),
        new JdeField("FYCRCD", "FYCRCD", JdeDataType.String, 6),
        new JdeField("FYUOM", "FYUOM", JdeDataType.String, 4),
        new JdeField("FYTRQT", "FYTRQT", JdeDataType.Numeric),
        new JdeField("FYEFTJ", "FYEFTJ", JdeDataType.Numeric),
        new JdeField("FYEXDJ", "FYEXDJ", JdeDataType.Numeric),
        new JdeField("FYUPRC", "FYUPRC", JdeDataType.Numeric),
        new JdeField("FYACRD", "FYACRD", JdeDataType.Numeric),
        new JdeField("FYUPCN", "FYUPCN", JdeDataType.String, 26),
        new JdeField("FYSCC0", "FYSCC0", JdeDataType.String, 28),
        new JdeField("FYUMUP", "FYUMUP", JdeDataType.String, 4),
        new JdeField("FYUMDF", "FYUMDF", JdeDataType.String, 4),
        new JdeField("FYURCD", "FYURCD", JdeDataType.String, 4),
        new JdeField("FYURDT", "FYURDT", JdeDataType.Numeric),
        new JdeField("FYURAT", "FYURAT", JdeDataType.Numeric),
        new JdeField("FYURAB", "FYURAB", JdeDataType.Numeric),
        new JdeField("FYURRF", "FYURRF", JdeDataType.String, 30),
        new JdeField("FYTORG", "FYTORG", JdeDataType.String, 20),
        new JdeField("FYUSER", "FYUSER", JdeDataType.String, 20),
        new JdeField("FYPID", "FYPID", JdeDataType.String, 20),
        new JdeField("FYJOBN", "FYJOBN", JdeDataType.String, 20),
        new JdeField("FYCDCD", "FYCDCD", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47082_0", "Primary Key on FYEDOC, FYEKCO, FYEDCT, FYEDLN", new[] { "FYEDOC", "FYEKCO", "FYEDCT", "FYEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
