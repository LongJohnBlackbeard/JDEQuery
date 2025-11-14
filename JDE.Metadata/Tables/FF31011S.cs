using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF31011S - .
/// </summary>
public class FF31011S : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ERUKID.
        /// </summary>
        public const string ERUKID = "ERUKID";

        /// <summary>
        /// ERPRODF31.
        /// </summary>
        public const string ERPRODF31 = "ERPRODF31";

        /// <summary>
        /// ERTRSID.
        /// </summary>
        public const string ERTRSID = "ERTRSID";

        /// <summary>
        /// ERMTID.
        /// </summary>
        public const string ERMTID = "ERMTID";

        /// <summary>
        /// ERITM.
        /// </summary>
        public const string ERITM = "ERITM";

        /// <summary>
        /// ERLITM.
        /// </summary>
        public const string ERLITM = "ERLITM";

        /// <summary>
        /// ERAITM.
        /// </summary>
        public const string ERAITM = "ERAITM";

        /// <summary>
        /// ERSOQS.
        /// </summary>
        public const string ERSOQS = "ERSOQS";

        /// <summary>
        /// ERSOCN.
        /// </summary>
        public const string ERSOCN = "ERSOCN";

        /// <summary>
        /// ERUM.
        /// </summary>
        public const string ERUM = "ERUM";

        /// <summary>
        /// ERTRQTY.
        /// </summary>
        public const string ERTRQTY = "ERTRQTY";

        /// <summary>
        /// ERUOM.
        /// </summary>
        public const string ERUOM = "ERUOM";

        /// <summary>
        /// ERLBOM.
        /// </summary>
        public const string ERLBOM = "ERLBOM";

        /// <summary>
        /// ERKIT.
        /// </summary>
        public const string ERKIT = "ERKIT";

        /// <summary>
        /// ERLTDATE.
        /// </summary>
        public const string ERLTDATE = "ERLTDATE";

        /// <summary>
        /// ERUCNDJ.
        /// </summary>
        public const string ERUCNDJ = "ERUCNDJ";

        /// <summary>
        /// ERBRVN.
        /// </summary>
        public const string ERBRVN = "ERBRVN";

        /// <summary>
        /// ERRRVN.
        /// </summary>
        public const string ERRRVN = "ERRRVN";

        /// <summary>
        /// ERAN8.
        /// </summary>
        public const string ERAN8 = "ERAN8";

        /// <summary>
        /// ERSHFT.
        /// </summary>
        public const string ERSHFT = "ERSHFT";

        /// <summary>
        /// ERLOCN.
        /// </summary>
        public const string ERLOCN = "ERLOCN";

        /// <summary>
        /// ERLOTN.
        /// </summary>
        public const string ERLOTN = "ERLOTN";

        /// <summary>
        /// ERSLREF.
        /// </summary>
        public const string ERSLREF = "ERSLREF";

        /// <summary>
        /// ERTMODE.
        /// </summary>
        public const string ERTMODE = "ERTMODE";

        /// <summary>
        /// ERTRSTS.
        /// </summary>
        public const string ERTRSTS = "ERTRSTS";

        /// <summary>
        /// ERDFMLINE.
        /// </summary>
        public const string ERDFMLINE = "ERDFMLINE";

        /// <summary>
        /// ERDESC.
        /// </summary>
        public const string ERDESC = "ERDESC";

        /// <summary>
        /// ERDCT0.
        /// </summary>
        public const string ERDCT0 = "ERDCT0";

        /// <summary>
        /// ERDCT.
        /// </summary>
        public const string ERDCT = "ERDCT";

        /// <summary>
        /// ERMMCU.
        /// </summary>
        public const string ERMMCU = "ERMMCU";

        /// <summary>
        /// ERACTFG.
        /// </summary>
        public const string ERACTFG = "ERACTFG";

        /// <summary>
        /// ERMCU.
        /// </summary>
        public const string ERMCU = "ERMCU";

        /// <summary>
        /// ERCTS1.
        /// </summary>
        public const string ERCTS1 = "ERCTS1";

        /// <summary>
        /// ERLEDG.
        /// </summary>
        public const string ERLEDG = "ERLEDG";

        /// <summary>
        /// ERSUB.
        /// </summary>
        public const string ERSUB = "ERSUB";

        /// <summary>
        /// ERPPFG.
        /// </summary>
        public const string ERPPFG = "ERPPFG";

        /// <summary>
        /// ERCO.
        /// </summary>
        public const string ERCO = "ERCO";

        /// <summary>
        /// ERTUSER.
        /// </summary>
        public const string ERTUSER = "ERTUSER";

        /// <summary>
        /// ERCUSER.
        /// </summary>
        public const string ERCUSER = "ERCUSER";

        /// <summary>
        /// ERPID.
        /// </summary>
        public const string ERPID = "ERPID";

        /// <summary>
        /// ERUSER.
        /// </summary>
        public const string ERUSER = "ERUSER";

        /// <summary>
        /// ERMKEY.
        /// </summary>
        public const string ERMKEY = "ERMKEY";

        /// <summary>
        /// ERUUPMJ.
        /// </summary>
        public const string ERUUPMJ = "ERUUPMJ";

        /// <summary>
        /// ERURCD.
        /// </summary>
        public const string ERURCD = "ERURCD";

        /// <summary>
        /// ERURDT.
        /// </summary>
        public const string ERURDT = "ERURDT";

        /// <summary>
        /// ERURAT.
        /// </summary>
        public const string ERURAT = "ERURAT";

        /// <summary>
        /// ERURAB.
        /// </summary>
        public const string ERURAB = "ERURAB";

        /// <summary>
        /// ERURRF.
        /// </summary>
        public const string ERURRF = "ERURRF";
    }

    /// <inheritdoc />
    public override string TableName => "FF31011S";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ERUKID", "ERUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("ERPRODF31", "ERPRODF31", JdeDataType.Numeric),
        new JdeField("ERTRSID", "ERTRSID", JdeDataType.Numeric),
        new JdeField("ERMTID", "ERMTID", JdeDataType.Numeric),
        new JdeField("ERITM", "ERITM", JdeDataType.Numeric),
        new JdeField("ERLITM", "ERLITM", JdeDataType.String, 50),
        new JdeField("ERAITM", "ERAITM", JdeDataType.String, 50),
        new JdeField("ERSOQS", "ERSOQS", JdeDataType.Numeric),
        new JdeField("ERSOCN", "ERSOCN", JdeDataType.Numeric),
        new JdeField("ERUM", "ERUM", JdeDataType.String, 4),
        new JdeField("ERTRQTY", "ERTRQTY", JdeDataType.Numeric),
        new JdeField("ERUOM", "ERUOM", JdeDataType.String, 4),
        new JdeField("ERLBOM", "ERLBOM", JdeDataType.Numeric),
        new JdeField("ERKIT", "ERKIT", JdeDataType.Numeric),
        new JdeField("ERLTDATE", "ERLTDATE", JdeDataType.Date),
        new JdeField("ERUCNDJ", "ERUCNDJ", JdeDataType.Date),
        new JdeField("ERBRVN", "ERBRVN", JdeDataType.Numeric),
        new JdeField("ERRRVN", "ERRRVN", JdeDataType.Numeric),
        new JdeField("ERAN8", "ERAN8", JdeDataType.Numeric),
        new JdeField("ERSHFT", "ERSHFT", JdeDataType.String, 2),
        new JdeField("ERLOCN", "ERLOCN", JdeDataType.String, 40),
        new JdeField("ERLOTN", "ERLOTN", JdeDataType.String, 60),
        new JdeField("ERSLREF", "ERSLREF", JdeDataType.Numeric),
        new JdeField("ERTMODE", "ERTMODE", JdeDataType.String, 2),
        new JdeField("ERTRSTS", "ERTRSTS", JdeDataType.String, 4),
        new JdeField("ERDFMLINE", "ERDFMLINE", JdeDataType.String, 24),
        new JdeField("ERDESC", "ERDESC", JdeDataType.String, 60),
        new JdeField("ERDCT0", "ERDCT0", JdeDataType.String, 4),
        new JdeField("ERDCT", "ERDCT", JdeDataType.String, 4),
        new JdeField("ERMMCU", "ERMMCU", JdeDataType.String, 24),
        new JdeField("ERACTFG", "ERACTFG", JdeDataType.String, 2),
        new JdeField("ERMCU", "ERMCU", JdeDataType.String, 24),
        new JdeField("ERCTS1", "ERCTS1", JdeDataType.Numeric),
        new JdeField("ERLEDG", "ERLEDG", JdeDataType.String, 4),
        new JdeField("ERSUB", "ERSUB", JdeDataType.String, 16),
        new JdeField("ERPPFG", "ERPPFG", JdeDataType.String, 2),
        new JdeField("ERCO", "ERCO", JdeDataType.String, 10),
        new JdeField("ERTUSER", "ERTUSER", JdeDataType.String, 20),
        new JdeField("ERCUSER", "ERCUSER", JdeDataType.String, 20),
        new JdeField("ERPID", "ERPID", JdeDataType.String, 20),
        new JdeField("ERUSER", "ERUSER", JdeDataType.String, 20),
        new JdeField("ERMKEY", "ERMKEY", JdeDataType.String, 30),
        new JdeField("ERUUPMJ", "ERUUPMJ", JdeDataType.Date),
        new JdeField("ERURCD", "ERURCD", JdeDataType.String, 4),
        new JdeField("ERURDT", "ERURDT", JdeDataType.Numeric),
        new JdeField("ERURAT", "ERURAT", JdeDataType.Numeric),
        new JdeField("ERURAB", "ERURAB", JdeDataType.Numeric),
        new JdeField("ERURRF", "ERURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF31011S_0", "Primary Key on ERUKID", new[] { "ERUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF31011S_2", "Index on ERPRODF31, ERTRSID", new[] { "ERPRODF31", "ERTRSID" }),
        new JdeIndex("FF31011S_3", "Index on ERTRSID", new[] { "ERTRSID" }),
        new JdeIndex("FF31011S_4", "Index on ERPRODF31, ERMTID", new[] { "ERPRODF31", "ERMTID" })
    };
}
