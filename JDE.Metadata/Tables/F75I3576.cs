using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I3576 - .
/// </summary>
public class F75I3576 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SWDOCO.
        /// </summary>
        public const string SWDOCO = "SWDOCO";

        /// <summary>
        /// SWDCTO.
        /// </summary>
        public const string SWDCTO = "SWDCTO";

        /// <summary>
        /// SWKCOO.
        /// </summary>
        public const string SWKCOO = "SWKCOO";

        /// <summary>
        /// SWLNID.
        /// </summary>
        public const string SWLNID = "SWLNID";

        /// <summary>
        /// SWMCU.
        /// </summary>
        public const string SWMCU = "SWMCU";

        /// <summary>
        /// SWRORN.
        /// </summary>
        public const string SWRORN = "SWRORN";

        /// <summary>
        /// SWRCTO.
        /// </summary>
        public const string SWRCTO = "SWRCTO";

        /// <summary>
        /// SWRKCO.
        /// </summary>
        public const string SWRKCO = "SWRKCO";

        /// <summary>
        /// SWRLLN.
        /// </summary>
        public const string SWRLLN = "SWRLLN";

        /// <summary>
        /// SWODOC.
        /// </summary>
        public const string SWODOC = "SWODOC";

        /// <summary>
        /// SWODCT.
        /// </summary>
        public const string SWODCT = "SWODCT";

        /// <summary>
        /// SWITM.
        /// </summary>
        public const string SWITM = "SWITM";

        /// <summary>
        /// SWTRQT.
        /// </summary>
        public const string SWTRQT = "SWTRQT";

        /// <summary>
        /// SWUOM.
        /// </summary>
        public const string SWUOM = "SWUOM";

        /// <summary>
        /// SWPRFR.
        /// </summary>
        public const string SWPRFR = "SWPRFR";

        /// <summary>
        /// SWUMGP.
        /// </summary>
        public const string SWUMGP = "SWUMGP";

        /// <summary>
        /// SWAQTY.
        /// </summary>
        public const string SWAQTY = "SWAQTY";

        /// <summary>
        /// SWASVL.
        /// </summary>
        public const string SWASVL = "SWASVL";

        /// <summary>
        /// SWYTDU.
        /// </summary>
        public const string SWYTDU = "SWYTDU";

        /// <summary>
        /// SWDTYS.
        /// </summary>
        public const string SWDTYS = "SWDTYS";

        /// <summary>
        /// SWFLAG.
        /// </summary>
        public const string SWFLAG = "SWFLAG";

        /// <summary>
        /// SWASID.
        /// </summary>
        public const string SWASID = "SWASID";

        /// <summary>
        /// SWUFLG.
        /// </summary>
        public const string SWUFLG = "SWUFLG";

        /// <summary>
        /// SWQTY1.
        /// </summary>
        public const string SWQTY1 = "SWQTY1";

        /// <summary>
        /// SWQTY2.
        /// </summary>
        public const string SWQTY2 = "SWQTY2";

        /// <summary>
        /// SWCRCD.
        /// </summary>
        public const string SWCRCD = "SWCRCD";

        /// <summary>
        /// SWCRDC.
        /// </summary>
        public const string SWCRDC = "SWCRDC";

        /// <summary>
        /// SWYUTD.
        /// </summary>
        public const string SWYUTD = "SWYUTD";

        /// <summary>
        /// SWLFDJ.
        /// </summary>
        public const string SWLFDJ = "SWLFDJ";

        /// <summary>
        /// SWPSDJ.
        /// </summary>
        public const string SWPSDJ = "SWPSDJ";

        /// <summary>
        /// SWDT.
        /// </summary>
        public const string SWDT = "SWDT";

        /// <summary>
        /// SWDT1.
        /// </summary>
        public const string SWDT1 = "SWDT1";

        /// <summary>
        /// SWF1A.
        /// </summary>
        public const string SWF1A = "SWF1A";

        /// <summary>
        /// SWF2A.
        /// </summary>
        public const string SWF2A = "SWF2A";

        /// <summary>
        /// SWF3A.
        /// </summary>
        public const string SWF3A = "SWF3A";

        /// <summary>
        /// SWF4A.
        /// </summary>
        public const string SWF4A = "SWF4A";

        /// <summary>
        /// SWC1FU.
        /// </summary>
        public const string SWC1FU = "SWC1FU";

        /// <summary>
        /// SWC2FU.
        /// </summary>
        public const string SWC2FU = "SWC2FU";

        /// <summary>
        /// SWOPT.
        /// </summary>
        public const string SWOPT = "SWOPT";

        /// <summary>
        /// SWF1T.
        /// </summary>
        public const string SWF1T = "SWF1T";

        /// <summary>
        /// SWF2T.
        /// </summary>
        public const string SWF2T = "SWF2T";

        /// <summary>
        /// SWF3T.
        /// </summary>
        public const string SWF3T = "SWF3T";

        /// <summary>
        /// SWACC.
        /// </summary>
        public const string SWACC = "SWACC";

        /// <summary>
        /// SWANS.
        /// </summary>
        public const string SWANS = "SWANS";

        /// <summary>
        /// SWPID.
        /// </summary>
        public const string SWPID = "SWPID";

        /// <summary>
        /// SWUSER.
        /// </summary>
        public const string SWUSER = "SWUSER";

        /// <summary>
        /// SWJOBN.
        /// </summary>
        public const string SWJOBN = "SWJOBN";

        /// <summary>
        /// SWUPMJ.
        /// </summary>
        public const string SWUPMJ = "SWUPMJ";

        /// <summary>
        /// SWUPMT.
        /// </summary>
        public const string SWUPMT = "SWUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75I3576";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SWDOCO", "SWDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SWDCTO", "SWDCTO", JdeDataType.String, 4, true, true),
        new JdeField("SWKCOO", "SWKCOO", JdeDataType.String, 10, true, true),
        new JdeField("SWLNID", "SWLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("SWMCU", "SWMCU", JdeDataType.String, 24),
        new JdeField("SWRORN", "SWRORN", JdeDataType.String, 16),
        new JdeField("SWRCTO", "SWRCTO", JdeDataType.String, 4),
        new JdeField("SWRKCO", "SWRKCO", JdeDataType.String, 10),
        new JdeField("SWRLLN", "SWRLLN", JdeDataType.Numeric),
        new JdeField("SWODOC", "SWODOC", JdeDataType.Numeric),
        new JdeField("SWODCT", "SWODCT", JdeDataType.String, 4),
        new JdeField("SWITM", "SWITM", JdeDataType.Numeric),
        new JdeField("SWTRQT", "SWTRQT", JdeDataType.Numeric),
        new JdeField("SWUOM", "SWUOM", JdeDataType.String, 4),
        new JdeField("SWPRFR", "SWPRFR", JdeDataType.String, 4),
        new JdeField("SWUMGP", "SWUMGP", JdeDataType.String, 4),
        new JdeField("SWAQTY", "SWAQTY", JdeDataType.Numeric),
        new JdeField("SWASVL", "SWASVL", JdeDataType.Numeric),
        new JdeField("SWYTDU", "SWYTDU", JdeDataType.Numeric),
        new JdeField("SWDTYS", "SWDTYS", JdeDataType.String, 4),
        new JdeField("SWFLAG", "SWFLAG", JdeDataType.String, 2),
        new JdeField("SWASID", "SWASID", JdeDataType.String, 50),
        new JdeField("SWUFLG", "SWUFLG", JdeDataType.String, 2),
        new JdeField("SWQTY1", "SWQTY1", JdeDataType.Numeric),
        new JdeField("SWQTY2", "SWQTY2", JdeDataType.Numeric),
        new JdeField("SWCRCD", "SWCRCD", JdeDataType.String, 6),
        new JdeField("SWCRDC", "SWCRDC", JdeDataType.String, 6),
        new JdeField("SWYUTD", "SWYUTD", JdeDataType.Numeric),
        new JdeField("SWLFDJ", "SWLFDJ", JdeDataType.Numeric),
        new JdeField("SWPSDJ", "SWPSDJ", JdeDataType.Numeric),
        new JdeField("SWDT", "SWDT", JdeDataType.Numeric),
        new JdeField("SWDT1", "SWDT1", JdeDataType.Numeric),
        new JdeField("SWF1A", "SWF1A", JdeDataType.Numeric),
        new JdeField("SWF2A", "SWF2A", JdeDataType.Numeric),
        new JdeField("SWF3A", "SWF3A", JdeDataType.Numeric),
        new JdeField("SWF4A", "SWF4A", JdeDataType.Numeric),
        new JdeField("SWC1FU", "SWC1FU", JdeDataType.String, 2),
        new JdeField("SWC2FU", "SWC2FU", JdeDataType.String, 2),
        new JdeField("SWOPT", "SWOPT", JdeDataType.String, 2),
        new JdeField("SWF1T", "SWF1T", JdeDataType.String, 60),
        new JdeField("SWF2T", "SWF2T", JdeDataType.String, 60),
        new JdeField("SWF3T", "SWF3T", JdeDataType.String, 60),
        new JdeField("SWACC", "SWACC", JdeDataType.String, 32),
        new JdeField("SWANS", "SWANS", JdeDataType.String, 50),
        new JdeField("SWPID", "SWPID", JdeDataType.String, 20),
        new JdeField("SWUSER", "SWUSER", JdeDataType.String, 20),
        new JdeField("SWJOBN", "SWJOBN", JdeDataType.String, 20),
        new JdeField("SWUPMJ", "SWUPMJ", JdeDataType.Numeric),
        new JdeField("SWUPMT", "SWUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I3576_0", "Primary Key on SWDOCO, SWDCTO, SWKCOO, SWLNID", new[] { "SWDOCO", "SWDCTO", "SWKCOO", "SWLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I3576_2", "Index on SWRORN, SWRCTO, SWRKCO, SWRLLN", new[] { "SWRORN", "SWRCTO", "SWRKCO", "SWRLLN" })
    };
}
