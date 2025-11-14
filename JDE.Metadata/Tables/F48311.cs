using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48311 - .
/// </summary>
public class F48311 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RATSKID.
        /// </summary>
        public const string RATSKID = "RATSKID";

        /// <summary>
        /// RAKCOO.
        /// </summary>
        public const string RAKCOO = "RAKCOO";

        /// <summary>
        /// RADCTO.
        /// </summary>
        public const string RADCTO = "RADCTO";

        /// <summary>
        /// RADOCO.
        /// </summary>
        public const string RADOCO = "RADOCO";

        /// <summary>
        /// RAOPSQ.
        /// </summary>
        public const string RAOPSQ = "RAOPSQ";

        /// <summary>
        /// RAOPSC.
        /// </summary>
        public const string RAOPSC = "RAOPSC";

        /// <summary>
        /// RAMCU.
        /// </summary>
        public const string RAMCU = "RAMCU";

        /// <summary>
        /// RAPRJM.
        /// </summary>
        public const string RAPRJM = "RAPRJM";

        /// <summary>
        /// RAMCUO.
        /// </summary>
        public const string RAMCUO = "RAMCUO";

        /// <summary>
        /// RATSKSTAT.
        /// </summary>
        public const string RATSKSTAT = "RATSKSTAT";

        /// <summary>
        /// RAASSN.
        /// </summary>
        public const string RAASSN = "RAASSN";

        /// <summary>
        /// RAIAVL.
        /// </summary>
        public const string RAIAVL = "RAIAVL";

        /// <summary>
        /// RAJBCD.
        /// </summary>
        public const string RAJBCD = "RAJBCD";

        /// <summary>
        /// RACMPE.
        /// </summary>
        public const string RACMPE = "RACMPE";

        /// <summary>
        /// RACMPC.
        /// </summary>
        public const string RACMPC = "RACMPC";

        /// <summary>
        /// RACMPV.
        /// </summary>
        public const string RACMPV = "RACMPV";

        /// <summary>
        /// RACPLVLFR.
        /// </summary>
        public const string RACPLVLFR = "RACPLVLFR";

        /// <summary>
        /// RACPLVLTO.
        /// </summary>
        public const string RACPLVLTO = "RACPLVLTO";

        /// <summary>
        /// RACMRQ.
        /// </summary>
        public const string RACMRQ = "RACMRQ";

        /// <summary>
        /// RARRTY.
        /// </summary>
        public const string RARRTY = "RARRTY";

        /// <summary>
        /// RARSCN.
        /// </summary>
        public const string RARSCN = "RARSCN";

        /// <summary>
        /// RADAP.
        /// </summary>
        public const string RADAP = "RADAP";

        /// <summary>
        /// RASCHSTTIME.
        /// </summary>
        public const string RASCHSTTIME = "RASCHSTTIME";

        /// <summary>
        /// RASCHENTIME.
        /// </summary>
        public const string RASCHENTIME = "RASCHENTIME";

        /// <summary>
        /// RASESD.
        /// </summary>
        public const string RASESD = "RASESD";

        /// <summary>
        /// RASEED.
        /// </summary>
        public const string RASEED = "RASEED";

        /// <summary>
        /// RASEST.
        /// </summary>
        public const string RASEST = "RASEST";

        /// <summary>
        /// RASEET.
        /// </summary>
        public const string RASEET = "RASEET";

        /// <summary>
        /// RAAHRS.
        /// </summary>
        public const string RAAHRS = "RAAHRS";

        /// <summary>
        /// RAASNP.
        /// </summary>
        public const string RAASNP = "RAASNP";

        /// <summary>
        /// RALPMD.
        /// </summary>
        public const string RALPMD = "RALPMD";

        /// <summary>
        /// RAPC.
        /// </summary>
        public const string RAPC = "RAPC";

        /// <summary>
        /// RADSC1.
        /// </summary>
        public const string RADSC1 = "RADSC1";

        /// <summary>
        /// RADSC2.
        /// </summary>
        public const string RADSC2 = "RADSC2";

        /// <summary>
        /// RAALTSKREF.
        /// </summary>
        public const string RAALTSKREF = "RAALTSKREF";

        /// <summary>
        /// RAASPRARF.
        /// </summary>
        public const string RAASPRARF = "RAASPRARF";

        /// <summary>
        /// RAAURCH1.
        /// </summary>
        public const string RAAURCH1 = "RAAURCH1";

        /// <summary>
        /// RAAURCH2.
        /// </summary>
        public const string RAAURCH2 = "RAAURCH2";

        /// <summary>
        /// RAAURCU1.
        /// </summary>
        public const string RAAURCU1 = "RAAURCU1";

        /// <summary>
        /// RAAURCU2.
        /// </summary>
        public const string RAAURCU2 = "RAAURCU2";

        /// <summary>
        /// RAAURDT1.
        /// </summary>
        public const string RAAURDT1 = "RAAURDT1";

        /// <summary>
        /// RAAURDT2.
        /// </summary>
        public const string RAAURDT2 = "RAAURDT2";

        /// <summary>
        /// RAAURMN1.
        /// </summary>
        public const string RAAURMN1 = "RAAURMN1";

        /// <summary>
        /// RAAURMN2.
        /// </summary>
        public const string RAAURMN2 = "RAAURMN2";

        /// <summary>
        /// RAAURST1.
        /// </summary>
        public const string RAAURST1 = "RAAURST1";

        /// <summary>
        /// RAAURST2.
        /// </summary>
        public const string RAAURST2 = "RAAURST2";

        /// <summary>
        /// RAAURST3.
        /// </summary>
        public const string RAAURST3 = "RAAURST3";

        /// <summary>
        /// RAAURST4.
        /// </summary>
        public const string RAAURST4 = "RAAURST4";

        /// <summary>
        /// RAAURST5.
        /// </summary>
        public const string RAAURST5 = "RAAURST5";

        /// <summary>
        /// RAAURST6.
        /// </summary>
        public const string RAAURST6 = "RAAURST6";

        /// <summary>
        /// RAAURST7.
        /// </summary>
        public const string RAAURST7 = "RAAURST7";

        /// <summary>
        /// RAURCD.
        /// </summary>
        public const string RAURCD = "RAURCD";

        /// <summary>
        /// RAURDT.
        /// </summary>
        public const string RAURDT = "RAURDT";

        /// <summary>
        /// RAURAT.
        /// </summary>
        public const string RAURAT = "RAURAT";

        /// <summary>
        /// RAURAB.
        /// </summary>
        public const string RAURAB = "RAURAB";

        /// <summary>
        /// RAURRF.
        /// </summary>
        public const string RAURRF = "RAURRF";

        /// <summary>
        /// RAUSER.
        /// </summary>
        public const string RAUSER = "RAUSER";

        /// <summary>
        /// RAPID.
        /// </summary>
        public const string RAPID = "RAPID";

        /// <summary>
        /// RAJOBN.
        /// </summary>
        public const string RAJOBN = "RAJOBN";

        /// <summary>
        /// RAUPMJ.
        /// </summary>
        public const string RAUPMJ = "RAUPMJ";

        /// <summary>
        /// RAUPMT.
        /// </summary>
        public const string RAUPMT = "RAUPMT";

        /// <summary>
        /// RAANSA.
        /// </summary>
        public const string RAANSA = "RAANSA";

        /// <summary>
        /// RAANPA.
        /// </summary>
        public const string RAANPA = "RAANPA";

        /// <summary>
        /// RASHFT.
        /// </summary>
        public const string RASHFT = "RASHFT";

        /// <summary>
        /// RAWSCHP.
        /// </summary>
        public const string RAWSCHP = "RAWSCHP";

        /// <summary>
        /// RATSKID2.
        /// </summary>
        public const string RATSKID2 = "RATSKID2";
    }

    /// <inheritdoc />
    public override string TableName => "F48311";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RATSKID", "RATSKID", JdeDataType.Numeric, null, true, true),
        new JdeField("RAKCOO", "RAKCOO", JdeDataType.String, 10),
        new JdeField("RADCTO", "RADCTO", JdeDataType.String, 4),
        new JdeField("RADOCO", "RADOCO", JdeDataType.Numeric),
        new JdeField("RAOPSQ", "RAOPSQ", JdeDataType.Numeric),
        new JdeField("RAOPSC", "RAOPSC", JdeDataType.String, 4),
        new JdeField("RAMCU", "RAMCU", JdeDataType.String, 24),
        new JdeField("RAPRJM", "RAPRJM", JdeDataType.Numeric),
        new JdeField("RAMCUO", "RAMCUO", JdeDataType.String, 24),
        new JdeField("RATSKSTAT", "RATSKSTAT", JdeDataType.String, 6),
        new JdeField("RAASSN", "RAASSN", JdeDataType.String, 20),
        new JdeField("RAIAVL", "RAIAVL", JdeDataType.String, 2),
        new JdeField("RAJBCD", "RAJBCD", JdeDataType.String, 12),
        new JdeField("RACMPE", "RACMPE", JdeDataType.String, 6),
        new JdeField("RACMPC", "RACMPC", JdeDataType.String, 20),
        new JdeField("RACMPV", "RACMPV", JdeDataType.Numeric),
        new JdeField("RACPLVLFR", "RACPLVLFR", JdeDataType.Numeric),
        new JdeField("RACPLVLTO", "RACPLVLTO", JdeDataType.Numeric),
        new JdeField("RACMRQ", "RACMRQ", JdeDataType.String, 2),
        new JdeField("RARRTY", "RARRTY", JdeDataType.String, 4),
        new JdeField("RARSCN", "RARSCN", JdeDataType.Numeric),
        new JdeField("RADAP", "RADAP", JdeDataType.Numeric),
        new JdeField("RASCHSTTIME", "RASCHSTTIME", JdeDataType.Numeric),
        new JdeField("RASCHENTIME", "RASCHENTIME", JdeDataType.Numeric),
        new JdeField("RASESD", "RASESD", JdeDataType.Numeric),
        new JdeField("RASEED", "RASEED", JdeDataType.Numeric),
        new JdeField("RASEST", "RASEST", JdeDataType.Numeric),
        new JdeField("RASEET", "RASEET", JdeDataType.Numeric),
        new JdeField("RAAHRS", "RAAHRS", JdeDataType.Numeric),
        new JdeField("RAASNP", "RAASNP", JdeDataType.Numeric),
        new JdeField("RALPMD", "RALPMD", JdeDataType.String, 2),
        new JdeField("RAPC", "RAPC", JdeDataType.Numeric),
        new JdeField("RADSC1", "RADSC1", JdeDataType.String, 60),
        new JdeField("RADSC2", "RADSC2", JdeDataType.String, 60),
        new JdeField("RAALTSKREF", "RAALTSKREF", JdeDataType.String, 50),
        new JdeField("RAASPRARF", "RAASPRARF", JdeDataType.String, 2),
        new JdeField("RAAURCH1", "RAAURCH1", JdeDataType.String, 2),
        new JdeField("RAAURCH2", "RAAURCH2", JdeDataType.String, 2),
        new JdeField("RAAURCU1", "RAAURCU1", JdeDataType.Numeric),
        new JdeField("RAAURCU2", "RAAURCU2", JdeDataType.Numeric),
        new JdeField("RAAURDT1", "RAAURDT1", JdeDataType.Numeric),
        new JdeField("RAAURDT2", "RAAURDT2", JdeDataType.Numeric),
        new JdeField("RAAURMN1", "RAAURMN1", JdeDataType.Numeric),
        new JdeField("RAAURMN2", "RAAURMN2", JdeDataType.Numeric),
        new JdeField("RAAURST1", "RAAURST1", JdeDataType.String, 10),
        new JdeField("RAAURST2", "RAAURST2", JdeDataType.String, 10),
        new JdeField("RAAURST3", "RAAURST3", JdeDataType.String, 30),
        new JdeField("RAAURST4", "RAAURST4", JdeDataType.String, 30),
        new JdeField("RAAURST5", "RAAURST5", JdeDataType.String, 30),
        new JdeField("RAAURST6", "RAAURST6", JdeDataType.String, 30),
        new JdeField("RAAURST7", "RAAURST7", JdeDataType.String, 60),
        new JdeField("RAURCD", "RAURCD", JdeDataType.String, 4),
        new JdeField("RAURDT", "RAURDT", JdeDataType.Numeric),
        new JdeField("RAURAT", "RAURAT", JdeDataType.Numeric),
        new JdeField("RAURAB", "RAURAB", JdeDataType.Numeric),
        new JdeField("RAURRF", "RAURRF", JdeDataType.String, 30),
        new JdeField("RAUSER", "RAUSER", JdeDataType.String, 20),
        new JdeField("RAPID", "RAPID", JdeDataType.String, 20),
        new JdeField("RAJOBN", "RAJOBN", JdeDataType.String, 20),
        new JdeField("RAUPMJ", "RAUPMJ", JdeDataType.Numeric),
        new JdeField("RAUPMT", "RAUPMT", JdeDataType.Numeric),
        new JdeField("RAANSA", "RAANSA", JdeDataType.Numeric),
        new JdeField("RAANPA", "RAANPA", JdeDataType.Numeric),
        new JdeField("RASHFT", "RASHFT", JdeDataType.String, 2),
        new JdeField("RAWSCHP", "RAWSCHP", JdeDataType.String, 2),
        new JdeField("RATSKID2", "RATSKID2", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48311_0", "Primary Key on RATSKID", new[] { "RATSKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F48311_2", "Index on RARRTY, RARSCN, RADOCO, RAOPSQ, RAOPSC, RAMCU", new[] { "RARRTY", "RARSCN", "RADOCO", "RAOPSQ", "RAOPSC", "RAMCU" }),
        new JdeIndex("F48311_3", "Index on RADOCO, RAOPSQ, RAOPSC, RAMCU", new[] { "RADOCO", "RAOPSQ", "RAOPSC", "RAMCU" }),
        new JdeIndex("F48311_4", "Index on RARRTY, RARSCN, RAIAVL, RASESD, RASCHSTTIME, RALPMD, RASEED", new[] { "RARRTY", "RARSCN", "RAIAVL", "RASESD", "RASCHSTTIME", "RALPMD", "RASEED" }),
        new JdeIndex("F48311_5", "Index on RAPRJM, RADOCO, RAOPSQ, RAOPSC, RAMCU", new[] { "RAPRJM", "RADOCO", "RAOPSQ", "RAOPSC", "RAMCU" }),
        new JdeIndex("F48311_6", "Index on RARRTY, RARSCN, RASEED, RASESD", new[] { "RARRTY", "RARSCN", "RASEED", "RASESD" }),
        new JdeIndex("F48311_7", "Index on RARRTY, RADOCO, RAOPSQ, RAOPSC, RAMCU, SYS_NC00067$, RATSKID", new[] { "RARRTY", "RADOCO", "RAOPSQ", "RAOPSC", "RAMCU", "SYS_NC00067$", "RATSKID" }),
        new JdeIndex("F48311_8", "Index on RAANSA, RASESD, RAWSCHP", new[] { "RAANSA", "RASESD", "RAWSCHP" })
    };
}
