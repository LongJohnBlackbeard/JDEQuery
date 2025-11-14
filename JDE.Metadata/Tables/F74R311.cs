using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R311 - .
/// </summary>
public class F74R311 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DEDCT.
        /// </summary>
        public const string DEDCT = "DEDCT";

        /// <summary>
        /// DEDOC.
        /// </summary>
        public const string DEDOC = "DEDOC";

        /// <summary>
        /// DEKCO.
        /// </summary>
        public const string DEKCO = "DEKCO";

        /// <summary>
        /// DESFX.
        /// </summary>
        public const string DESFX = "DESFX";

        /// <summary>
        /// DER74RN.
        /// </summary>
        public const string DER74RN = "DER74RN";

        /// <summary>
        /// DEPYID.
        /// </summary>
        public const string DEPYID = "DEPYID";

        /// <summary>
        /// DERC5.
        /// </summary>
        public const string DERC5 = "DERC5";

        /// <summary>
        /// DEDCTG.
        /// </summary>
        public const string DEDCTG = "DEDCTG";

        /// <summary>
        /// DEDOCG.
        /// </summary>
        public const string DEDOCG = "DEDOCG";

        /// <summary>
        /// DEKCOG.
        /// </summary>
        public const string DEKCOG = "DEKCOG";

        /// <summary>
        /// DEDGJ.
        /// </summary>
        public const string DEDGJ = "DEDGJ";

        /// <summary>
        /// DEJELD.
        /// </summary>
        public const string DEJELD = "DEJELD";

        /// <summary>
        /// DEJELF.
        /// </summary>
        public const string DEJELF = "DEJELF";

        /// <summary>
        /// DER74AT.
        /// </summary>
        public const string DER74AT = "DER74AT";

        /// <summary>
        /// DER74TPA.
        /// </summary>
        public const string DER74TPA = "DER74TPA";

        /// <summary>
        /// DER74TI.
        /// </summary>
        public const string DER74TI = "DER74TI";

        /// <summary>
        /// DER74TFA.
        /// </summary>
        public const string DER74TFA = "DER74TFA";

        /// <summary>
        /// DER74TFP.
        /// </summary>
        public const string DER74TFP = "DER74TFP";

        /// <summary>
        /// DER74FTI.
        /// </summary>
        public const string DER74FTI = "DER74FTI";

        /// <summary>
        /// DEBCRC.
        /// </summary>
        public const string DEBCRC = "DEBCRC";

        /// <summary>
        /// DECRRM.
        /// </summary>
        public const string DECRRM = "DECRRM";

        /// <summary>
        /// DECRCD.
        /// </summary>
        public const string DECRCD = "DECRCD";

        /// <summary>
        /// DECRR.
        /// </summary>
        public const string DECRR = "DECRR";

        /// <summary>
        /// DERREF.
        /// </summary>
        public const string DERREF = "DERREF";

        /// <summary>
        /// DEICU.
        /// </summary>
        public const string DEICU = "DEICU";

        /// <summary>
        /// DEICUT.
        /// </summary>
        public const string DEICUT = "DEICUT";

        /// <summary>
        /// DERPD.
        /// </summary>
        public const string DERPD = "DERPD";

        /// <summary>
        /// DECKNU.
        /// </summary>
        public const string DECKNU = "DECKNU";

        /// <summary>
        /// DEAN8.
        /// </summary>
        public const string DEAN8 = "DEAN8";

        /// <summary>
        /// DETXA1.
        /// </summary>
        public const string DETXA1 = "DETXA1";

        /// <summary>
        /// DER74BOK.
        /// </summary>
        public const string DER74BOK = "DER74BOK";

        /// <summary>
        /// DER74ATX.
        /// </summary>
        public const string DER74ATX = "DER74ATX";

        /// <summary>
        /// DER74TXP.
        /// </summary>
        public const string DER74TXP = "DER74TXP";

        /// <summary>
        /// DER74TXI.
        /// </summary>
        public const string DER74TXI = "DER74TXI";

        /// <summary>
        /// DER74FTX.
        /// </summary>
        public const string DER74FTX = "DER74FTX";

        /// <summary>
        /// DER74FXP.
        /// </summary>
        public const string DER74FXP = "DER74FXP";

        /// <summary>
        /// DER74FXI.
        /// </summary>
        public const string DER74FXI = "DER74FXI";

        /// <summary>
        /// DEDMTJ.
        /// </summary>
        public const string DEDMTJ = "DEDMTJ";

        /// <summary>
        /// DECO.
        /// </summary>
        public const string DECO = "DECO";

        /// <summary>
        /// DEVOD.
        /// </summary>
        public const string DEVOD = "DEVOD";

        /// <summary>
        /// DEURAT.
        /// </summary>
        public const string DEURAT = "DEURAT";

        /// <summary>
        /// DEURC1.
        /// </summary>
        public const string DEURC1 = "DEURC1";

        /// <summary>
        /// DEURAB.
        /// </summary>
        public const string DEURAB = "DEURAB";

        /// <summary>
        /// DEURRF.
        /// </summary>
        public const string DEURRF = "DEURRF";

        /// <summary>
        /// DEURDT.
        /// </summary>
        public const string DEURDT = "DEURDT";

        /// <summary>
        /// DETORG.
        /// </summary>
        public const string DETORG = "DETORG";

        /// <summary>
        /// DEPID.
        /// </summary>
        public const string DEPID = "DEPID";

        /// <summary>
        /// DEJOBN.
        /// </summary>
        public const string DEJOBN = "DEJOBN";

        /// <summary>
        /// DEUSER.
        /// </summary>
        public const string DEUSER = "DEUSER";

        /// <summary>
        /// DEUPMJ.
        /// </summary>
        public const string DEUPMJ = "DEUPMJ";

        /// <summary>
        /// DEUPMT.
        /// </summary>
        public const string DEUPMT = "DEUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74R311";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DEDCT", "DEDCT", JdeDataType.String, 4, true, true),
        new JdeField("DEDOC", "DEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("DEKCO", "DEKCO", JdeDataType.String, 10, true, true),
        new JdeField("DESFX", "DESFX", JdeDataType.String, 6, true, true),
        new JdeField("DER74RN", "DER74RN", JdeDataType.Numeric, null, true, true),
        new JdeField("DEPYID", "DEPYID", JdeDataType.Numeric),
        new JdeField("DERC5", "DERC5", JdeDataType.Numeric),
        new JdeField("DEDCTG", "DEDCTG", JdeDataType.String, 4),
        new JdeField("DEDOCG", "DEDOCG", JdeDataType.Numeric),
        new JdeField("DEKCOG", "DEKCOG", JdeDataType.String, 10),
        new JdeField("DEDGJ", "DEDGJ", JdeDataType.Numeric),
        new JdeField("DEJELD", "DEJELD", JdeDataType.Numeric),
        new JdeField("DEJELF", "DEJELF", JdeDataType.Numeric),
        new JdeField("DER74AT", "DER74AT", JdeDataType.Numeric),
        new JdeField("DER74TPA", "DER74TPA", JdeDataType.Numeric),
        new JdeField("DER74TI", "DER74TI", JdeDataType.Numeric),
        new JdeField("DER74TFA", "DER74TFA", JdeDataType.Numeric),
        new JdeField("DER74TFP", "DER74TFP", JdeDataType.Numeric),
        new JdeField("DER74FTI", "DER74FTI", JdeDataType.Numeric),
        new JdeField("DEBCRC", "DEBCRC", JdeDataType.String, 6),
        new JdeField("DECRRM", "DECRRM", JdeDataType.String, 2),
        new JdeField("DECRCD", "DECRCD", JdeDataType.String, 6),
        new JdeField("DECRR", "DECRR", JdeDataType.Numeric),
        new JdeField("DERREF", "DERREF", JdeDataType.String, 50),
        new JdeField("DEICU", "DEICU", JdeDataType.Numeric),
        new JdeField("DEICUT", "DEICUT", JdeDataType.String, 4),
        new JdeField("DERPD", "DERPD", JdeDataType.Numeric),
        new JdeField("DECKNU", "DECKNU", JdeDataType.String, 50),
        new JdeField("DEAN8", "DEAN8", JdeDataType.Numeric),
        new JdeField("DETXA1", "DETXA1", JdeDataType.String, 20),
        new JdeField("DER74BOK", "DER74BOK", JdeDataType.String, 4),
        new JdeField("DER74ATX", "DER74ATX", JdeDataType.Numeric),
        new JdeField("DER74TXP", "DER74TXP", JdeDataType.Numeric),
        new JdeField("DER74TXI", "DER74TXI", JdeDataType.Numeric),
        new JdeField("DER74FTX", "DER74FTX", JdeDataType.Numeric),
        new JdeField("DER74FXP", "DER74FXP", JdeDataType.Numeric),
        new JdeField("DER74FXI", "DER74FXI", JdeDataType.Numeric),
        new JdeField("DEDMTJ", "DEDMTJ", JdeDataType.Numeric),
        new JdeField("DECO", "DECO", JdeDataType.String, 10),
        new JdeField("DEVOD", "DEVOD", JdeDataType.String, 2),
        new JdeField("DEURAT", "DEURAT", JdeDataType.Numeric),
        new JdeField("DEURC1", "DEURC1", JdeDataType.String, 6),
        new JdeField("DEURAB", "DEURAB", JdeDataType.Numeric),
        new JdeField("DEURRF", "DEURRF", JdeDataType.String, 30),
        new JdeField("DEURDT", "DEURDT", JdeDataType.Numeric),
        new JdeField("DETORG", "DETORG", JdeDataType.String, 20),
        new JdeField("DEPID", "DEPID", JdeDataType.String, 20),
        new JdeField("DEJOBN", "DEJOBN", JdeDataType.String, 20),
        new JdeField("DEUSER", "DEUSER", JdeDataType.String, 20),
        new JdeField("DEUPMJ", "DEUPMJ", JdeDataType.Numeric),
        new JdeField("DEUPMT", "DEUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R311_0", "Primary Key on DEKCO, DEDCT, DEDOC, DESFX, DER74RN", new[] { "DEKCO", "DEDCT", "DEDOC", "DESFX", "DER74RN" }, isUnique: true, isPrimaryKey: true)
    };
}
