using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I357 - .
/// </summary>
public class F75I357 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CHYCHL.
        /// </summary>
        public const string CHYCHL = "CHYCHL";

        /// <summary>
        /// CHMCU.
        /// </summary>
        public const string CHMCU = "CHMCU";

        /// <summary>
        /// CHYEXU.
        /// </summary>
        public const string CHYEXU = "CHYEXU";

        /// <summary>
        /// CHAN8.
        /// </summary>
        public const string CHAN8 = "CHAN8";

        /// <summary>
        /// CHMCUX.
        /// </summary>
        public const string CHMCUX = "CHMCUX";

        /// <summary>
        /// CHACTB.
        /// </summary>
        public const string CHACTB = "CHACTB";

        /// <summary>
        /// CHTRDJ.
        /// </summary>
        public const string CHTRDJ = "CHTRDJ";

        /// <summary>
        /// CHPC.
        /// </summary>
        public const string CHPC = "CHPC";

        /// <summary>
        /// CHREM1.
        /// </summary>
        public const string CHREM1 = "CHREM1";

        /// <summary>
        /// CHREM2.
        /// </summary>
        public const string CHREM2 = "CHREM2";

        /// <summary>
        /// CHLTTR.
        /// </summary>
        public const string CHLTTR = "CHLTTR";

        /// <summary>
        /// CHPRFR.
        /// </summary>
        public const string CHPRFR = "CHPRFR";

        /// <summary>
        /// CHUMGP.
        /// </summary>
        public const string CHUMGP = "CHUMGP";

        /// <summary>
        /// CHAQTY.
        /// </summary>
        public const string CHAQTY = "CHAQTY";

        /// <summary>
        /// CHASVL.
        /// </summary>
        public const string CHASVL = "CHASVL";

        /// <summary>
        /// CHYTDU.
        /// </summary>
        public const string CHYTDU = "CHYTDU";

        /// <summary>
        /// CHDTYS.
        /// </summary>
        public const string CHDTYS = "CHDTYS";

        /// <summary>
        /// CHFLAG.
        /// </summary>
        public const string CHFLAG = "CHFLAG";

        /// <summary>
        /// CHASID.
        /// </summary>
        public const string CHASID = "CHASID";

        /// <summary>
        /// CHUFLG.
        /// </summary>
        public const string CHUFLG = "CHUFLG";

        /// <summary>
        /// CHQTY1.
        /// </summary>
        public const string CHQTY1 = "CHQTY1";

        /// <summary>
        /// CHQTY2.
        /// </summary>
        public const string CHQTY2 = "CHQTY2";

        /// <summary>
        /// CHCRCD.
        /// </summary>
        public const string CHCRCD = "CHCRCD";

        /// <summary>
        /// CHCRDC.
        /// </summary>
        public const string CHCRDC = "CHCRDC";

        /// <summary>
        /// CHYUTD.
        /// </summary>
        public const string CHYUTD = "CHYUTD";

        /// <summary>
        /// CHLFDJ.
        /// </summary>
        public const string CHLFDJ = "CHLFDJ";

        /// <summary>
        /// CHPSDJ.
        /// </summary>
        public const string CHPSDJ = "CHPSDJ";

        /// <summary>
        /// CHDT.
        /// </summary>
        public const string CHDT = "CHDT";

        /// <summary>
        /// CHDT1.
        /// </summary>
        public const string CHDT1 = "CHDT1";

        /// <summary>
        /// CHF1A.
        /// </summary>
        public const string CHF1A = "CHF1A";

        /// <summary>
        /// CHF2A.
        /// </summary>
        public const string CHF2A = "CHF2A";

        /// <summary>
        /// CHF3A.
        /// </summary>
        public const string CHF3A = "CHF3A";

        /// <summary>
        /// CHF4A.
        /// </summary>
        public const string CHF4A = "CHF4A";

        /// <summary>
        /// CHC1FU.
        /// </summary>
        public const string CHC1FU = "CHC1FU";

        /// <summary>
        /// CHC2FU.
        /// </summary>
        public const string CHC2FU = "CHC2FU";

        /// <summary>
        /// CHOPT.
        /// </summary>
        public const string CHOPT = "CHOPT";

        /// <summary>
        /// CHF1T.
        /// </summary>
        public const string CHF1T = "CHF1T";

        /// <summary>
        /// CHF2T.
        /// </summary>
        public const string CHF2T = "CHF2T";

        /// <summary>
        /// CHF3T.
        /// </summary>
        public const string CHF3T = "CHF3T";

        /// <summary>
        /// CHACC.
        /// </summary>
        public const string CHACC = "CHACC";

        /// <summary>
        /// CHANS.
        /// </summary>
        public const string CHANS = "CHANS";

        /// <summary>
        /// CHPID.
        /// </summary>
        public const string CHPID = "CHPID";

        /// <summary>
        /// CHUSER.
        /// </summary>
        public const string CHUSER = "CHUSER";

        /// <summary>
        /// CHJOBN.
        /// </summary>
        public const string CHJOBN = "CHJOBN";

        /// <summary>
        /// CHUPMJ.
        /// </summary>
        public const string CHUPMJ = "CHUPMJ";

        /// <summary>
        /// CHUPMT.
        /// </summary>
        public const string CHUPMT = "CHUPMT";

        /// <summary>
        /// CHEF01.
        /// </summary>
        public const string CHEF01 = "CHEF01";
    }

    /// <inheritdoc />
    public override string TableName => "F75I357";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CHYCHL", "CHYCHL", JdeDataType.Numeric, null, true, true),
        new JdeField("CHMCU", "CHMCU", JdeDataType.String, 24, true, true),
        new JdeField("CHYEXU", "CHYEXU", JdeDataType.Numeric),
        new JdeField("CHAN8", "CHAN8", JdeDataType.Numeric),
        new JdeField("CHMCUX", "CHMCUX", JdeDataType.String, 24),
        new JdeField("CHACTB", "CHACTB", JdeDataType.String, 20),
        new JdeField("CHTRDJ", "CHTRDJ", JdeDataType.Numeric),
        new JdeField("CHPC", "CHPC", JdeDataType.Numeric),
        new JdeField("CHREM1", "CHREM1", JdeDataType.String, 80),
        new JdeField("CHREM2", "CHREM2", JdeDataType.String, 80),
        new JdeField("CHLTTR", "CHLTTR", JdeDataType.String, 6),
        new JdeField("CHPRFR", "CHPRFR", JdeDataType.String, 4),
        new JdeField("CHUMGP", "CHUMGP", JdeDataType.String, 4),
        new JdeField("CHAQTY", "CHAQTY", JdeDataType.Numeric),
        new JdeField("CHASVL", "CHASVL", JdeDataType.Numeric),
        new JdeField("CHYTDU", "CHYTDU", JdeDataType.Numeric),
        new JdeField("CHDTYS", "CHDTYS", JdeDataType.String, 4),
        new JdeField("CHFLAG", "CHFLAG", JdeDataType.String, 2),
        new JdeField("CHASID", "CHASID", JdeDataType.String, 50),
        new JdeField("CHUFLG", "CHUFLG", JdeDataType.String, 2),
        new JdeField("CHQTY1", "CHQTY1", JdeDataType.Numeric),
        new JdeField("CHQTY2", "CHQTY2", JdeDataType.Numeric),
        new JdeField("CHCRCD", "CHCRCD", JdeDataType.String, 6),
        new JdeField("CHCRDC", "CHCRDC", JdeDataType.String, 6),
        new JdeField("CHYUTD", "CHYUTD", JdeDataType.Numeric),
        new JdeField("CHLFDJ", "CHLFDJ", JdeDataType.Numeric),
        new JdeField("CHPSDJ", "CHPSDJ", JdeDataType.Numeric),
        new JdeField("CHDT", "CHDT", JdeDataType.Numeric),
        new JdeField("CHDT1", "CHDT1", JdeDataType.Numeric),
        new JdeField("CHF1A", "CHF1A", JdeDataType.Numeric),
        new JdeField("CHF2A", "CHF2A", JdeDataType.Numeric),
        new JdeField("CHF3A", "CHF3A", JdeDataType.Numeric),
        new JdeField("CHF4A", "CHF4A", JdeDataType.Numeric),
        new JdeField("CHC1FU", "CHC1FU", JdeDataType.String, 2),
        new JdeField("CHC2FU", "CHC2FU", JdeDataType.String, 2),
        new JdeField("CHOPT", "CHOPT", JdeDataType.String, 2),
        new JdeField("CHF1T", "CHF1T", JdeDataType.String, 60),
        new JdeField("CHF2T", "CHF2T", JdeDataType.String, 60),
        new JdeField("CHF3T", "CHF3T", JdeDataType.String, 60),
        new JdeField("CHACC", "CHACC", JdeDataType.String, 32),
        new JdeField("CHANS", "CHANS", JdeDataType.String, 50),
        new JdeField("CHPID", "CHPID", JdeDataType.String, 20),
        new JdeField("CHUSER", "CHUSER", JdeDataType.String, 20),
        new JdeField("CHJOBN", "CHJOBN", JdeDataType.String, 20),
        new JdeField("CHUPMJ", "CHUPMJ", JdeDataType.Numeric),
        new JdeField("CHUPMT", "CHUPMT", JdeDataType.Numeric),
        new JdeField("CHEF01", "CHEF01", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I357_0", "Primary Key on CHYCHL, CHMCU", new[] { "CHYCHL", "CHMCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I357_3", "Index on CHYEXU, CHMCU, SYS_NC00048$", new[] { "CHYEXU", "CHMCU", "SYS_NC00048$" }),
        new JdeIndex("F75I357_4", "Index on CHYCHL, CHMCU, CHACTB, CHLTTR", new[] { "CHYCHL", "CHMCU", "CHACTB", "CHLTTR" }),
        new JdeIndex("F75I357_5", "Index on CHTRDJ, CHMCUX, CHMCU, CHYCHL", new[] { "CHTRDJ", "CHMCUX", "CHMCU", "CHYCHL" })
    };
}
