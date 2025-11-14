using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I3571 - .
/// </summary>
public class F75I3571 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CWYCHL.
        /// </summary>
        public const string CWYCHL = "CWYCHL";

        /// <summary>
        /// CWMCU0.
        /// </summary>
        public const string CWMCU0 = "CWMCU0";

        /// <summary>
        /// CWYEXU.
        /// </summary>
        public const string CWYEXU = "CWYEXU";

        /// <summary>
        /// CWDOCO.
        /// </summary>
        public const string CWDOCO = "CWDOCO";

        /// <summary>
        /// CWDCTO.
        /// </summary>
        public const string CWDCTO = "CWDCTO";

        /// <summary>
        /// CWKCOO.
        /// </summary>
        public const string CWKCOO = "CWKCOO";

        /// <summary>
        /// CWMCU.
        /// </summary>
        public const string CWMCU = "CWMCU";

        /// <summary>
        /// CWLNID.
        /// </summary>
        public const string CWLNID = "CWLNID";

        /// <summary>
        /// CWITM.
        /// </summary>
        public const string CWITM = "CWITM";

        /// <summary>
        /// CWLITM.
        /// </summary>
        public const string CWLITM = "CWLITM";

        /// <summary>
        /// CWTRQT.
        /// </summary>
        public const string CWTRQT = "CWTRQT";

        /// <summary>
        /// CWUOM.
        /// </summary>
        public const string CWUOM = "CWUOM";

        /// <summary>
        /// CWPRFR.
        /// </summary>
        public const string CWPRFR = "CWPRFR";

        /// <summary>
        /// CWUMGP.
        /// </summary>
        public const string CWUMGP = "CWUMGP";

        /// <summary>
        /// CWAQTY.
        /// </summary>
        public const string CWAQTY = "CWAQTY";

        /// <summary>
        /// CWASVL.
        /// </summary>
        public const string CWASVL = "CWASVL";

        /// <summary>
        /// CWYTDU.
        /// </summary>
        public const string CWYTDU = "CWYTDU";

        /// <summary>
        /// CWDTYS.
        /// </summary>
        public const string CWDTYS = "CWDTYS";

        /// <summary>
        /// CWFLAG.
        /// </summary>
        public const string CWFLAG = "CWFLAG";

        /// <summary>
        /// CWASID.
        /// </summary>
        public const string CWASID = "CWASID";

        /// <summary>
        /// CWUFLG.
        /// </summary>
        public const string CWUFLG = "CWUFLG";

        /// <summary>
        /// CWQTY1.
        /// </summary>
        public const string CWQTY1 = "CWQTY1";

        /// <summary>
        /// CWQTY2.
        /// </summary>
        public const string CWQTY2 = "CWQTY2";

        /// <summary>
        /// CWCRCD.
        /// </summary>
        public const string CWCRCD = "CWCRCD";

        /// <summary>
        /// CWCRDC.
        /// </summary>
        public const string CWCRDC = "CWCRDC";

        /// <summary>
        /// CWYUTD.
        /// </summary>
        public const string CWYUTD = "CWYUTD";

        /// <summary>
        /// CWLFDJ.
        /// </summary>
        public const string CWLFDJ = "CWLFDJ";

        /// <summary>
        /// CWPSDJ.
        /// </summary>
        public const string CWPSDJ = "CWPSDJ";

        /// <summary>
        /// CWDT.
        /// </summary>
        public const string CWDT = "CWDT";

        /// <summary>
        /// CWDT1.
        /// </summary>
        public const string CWDT1 = "CWDT1";

        /// <summary>
        /// CWF1A.
        /// </summary>
        public const string CWF1A = "CWF1A";

        /// <summary>
        /// CWF2A.
        /// </summary>
        public const string CWF2A = "CWF2A";

        /// <summary>
        /// CWF3A.
        /// </summary>
        public const string CWF3A = "CWF3A";

        /// <summary>
        /// CWF4A.
        /// </summary>
        public const string CWF4A = "CWF4A";

        /// <summary>
        /// CWC1FU.
        /// </summary>
        public const string CWC1FU = "CWC1FU";

        /// <summary>
        /// CWC2FU.
        /// </summary>
        public const string CWC2FU = "CWC2FU";

        /// <summary>
        /// CWOPT.
        /// </summary>
        public const string CWOPT = "CWOPT";

        /// <summary>
        /// CWF1T.
        /// </summary>
        public const string CWF1T = "CWF1T";

        /// <summary>
        /// CWF2T.
        /// </summary>
        public const string CWF2T = "CWF2T";

        /// <summary>
        /// CWF3T.
        /// </summary>
        public const string CWF3T = "CWF3T";

        /// <summary>
        /// CWACC.
        /// </summary>
        public const string CWACC = "CWACC";

        /// <summary>
        /// CWANS.
        /// </summary>
        public const string CWANS = "CWANS";

        /// <summary>
        /// CWPID.
        /// </summary>
        public const string CWPID = "CWPID";

        /// <summary>
        /// CWUSER.
        /// </summary>
        public const string CWUSER = "CWUSER";

        /// <summary>
        /// CWJOBN.
        /// </summary>
        public const string CWJOBN = "CWJOBN";

        /// <summary>
        /// CWUPMJ.
        /// </summary>
        public const string CWUPMJ = "CWUPMJ";

        /// <summary>
        /// CWUPMT.
        /// </summary>
        public const string CWUPMT = "CWUPMT";

        /// <summary>
        /// CWEF01.
        /// </summary>
        public const string CWEF01 = "CWEF01";
    }

    /// <inheritdoc />
    public override string TableName => "F75I3571";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CWYCHL", "CWYCHL", JdeDataType.Numeric, null, true, true),
        new JdeField("CWMCU0", "CWMCU0", JdeDataType.String, 24, true, true),
        new JdeField("CWYEXU", "CWYEXU", JdeDataType.Numeric),
        new JdeField("CWDOCO", "CWDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("CWDCTO", "CWDCTO", JdeDataType.String, 4, true, true),
        new JdeField("CWKCOO", "CWKCOO", JdeDataType.String, 10, true, true),
        new JdeField("CWMCU", "CWMCU", JdeDataType.String, 24),
        new JdeField("CWLNID", "CWLNID", JdeDataType.Numeric),
        new JdeField("CWITM", "CWITM", JdeDataType.Numeric),
        new JdeField("CWLITM", "CWLITM", JdeDataType.String, 50),
        new JdeField("CWTRQT", "CWTRQT", JdeDataType.Numeric),
        new JdeField("CWUOM", "CWUOM", JdeDataType.String, 4),
        new JdeField("CWPRFR", "CWPRFR", JdeDataType.String, 4),
        new JdeField("CWUMGP", "CWUMGP", JdeDataType.String, 4),
        new JdeField("CWAQTY", "CWAQTY", JdeDataType.Numeric),
        new JdeField("CWASVL", "CWASVL", JdeDataType.Numeric),
        new JdeField("CWYTDU", "CWYTDU", JdeDataType.Numeric),
        new JdeField("CWDTYS", "CWDTYS", JdeDataType.String, 4),
        new JdeField("CWFLAG", "CWFLAG", JdeDataType.String, 2),
        new JdeField("CWASID", "CWASID", JdeDataType.String, 50),
        new JdeField("CWUFLG", "CWUFLG", JdeDataType.String, 2),
        new JdeField("CWQTY1", "CWQTY1", JdeDataType.Numeric),
        new JdeField("CWQTY2", "CWQTY2", JdeDataType.Numeric),
        new JdeField("CWCRCD", "CWCRCD", JdeDataType.String, 6),
        new JdeField("CWCRDC", "CWCRDC", JdeDataType.String, 6),
        new JdeField("CWYUTD", "CWYUTD", JdeDataType.Numeric),
        new JdeField("CWLFDJ", "CWLFDJ", JdeDataType.Numeric),
        new JdeField("CWPSDJ", "CWPSDJ", JdeDataType.Numeric),
        new JdeField("CWDT", "CWDT", JdeDataType.Numeric),
        new JdeField("CWDT1", "CWDT1", JdeDataType.Numeric),
        new JdeField("CWF1A", "CWF1A", JdeDataType.Numeric),
        new JdeField("CWF2A", "CWF2A", JdeDataType.Numeric),
        new JdeField("CWF3A", "CWF3A", JdeDataType.Numeric),
        new JdeField("CWF4A", "CWF4A", JdeDataType.Numeric),
        new JdeField("CWC1FU", "CWC1FU", JdeDataType.String, 2),
        new JdeField("CWC2FU", "CWC2FU", JdeDataType.String, 2),
        new JdeField("CWOPT", "CWOPT", JdeDataType.String, 2),
        new JdeField("CWF1T", "CWF1T", JdeDataType.String, 60),
        new JdeField("CWF2T", "CWF2T", JdeDataType.String, 60),
        new JdeField("CWF3T", "CWF3T", JdeDataType.String, 60),
        new JdeField("CWACC", "CWACC", JdeDataType.String, 32),
        new JdeField("CWANS", "CWANS", JdeDataType.String, 50),
        new JdeField("CWPID", "CWPID", JdeDataType.String, 20),
        new JdeField("CWUSER", "CWUSER", JdeDataType.String, 20),
        new JdeField("CWJOBN", "CWJOBN", JdeDataType.String, 20),
        new JdeField("CWUPMJ", "CWUPMJ", JdeDataType.Numeric),
        new JdeField("CWUPMT", "CWUPMT", JdeDataType.Numeric),
        new JdeField("CWEF01", "CWEF01", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I3571_0", "Primary Key on CWYCHL, CWMCU0, CWDOCO, CWDCTO, CWKCOO", new[] { "CWYCHL", "CWMCU0", "CWDOCO", "CWDCTO", "CWKCOO" }, isUnique: true, isPrimaryKey: true)
    };
}
