using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L703 - .
/// </summary>
public class FF30L703 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PPPPRID.
        /// </summary>
        public const string PPPPRID = "PPPPRID";

        /// <summary>
        /// PPPHID.
        /// </summary>
        public const string PPPHID = "PPPHID";

        /// <summary>
        /// PPPROID.
        /// </summary>
        public const string PPPROID = "PPPROID";

        /// <summary>
        /// PPPROSQ.
        /// </summary>
        public const string PPPROSQ = "PPPROSQ";

        /// <summary>
        /// PPCOQY.
        /// </summary>
        public const string PPCOQY = "PPCOQY";

        /// <summary>
        /// PPSPRID.
        /// </summary>
        public const string PPSPRID = "PPSPRID";

        /// <summary>
        /// PPSPFG.
        /// </summary>
        public const string PPSPFG = "PPSPFG";

        /// <summary>
        /// PPPRYP.
        /// </summary>
        public const string PPPRYP = "PPPRYP";

        /// <summary>
        /// PPRWFG.
        /// </summary>
        public const string PPRWFG = "PPRWFG";

        /// <summary>
        /// PPPRWP.
        /// </summary>
        public const string PPPRWP = "PPPRWP";

        /// <summary>
        /// PPOPFG.
        /// </summary>
        public const string PPOPFG = "PPOPFG";

        /// <summary>
        /// PPFEFG.
        /// </summary>
        public const string PPFEFG = "PPFEFG";

        /// <summary>
        /// PPPSRP.
        /// </summary>
        public const string PPPSRP = "PPPSRP";

        /// <summary>
        /// PPFSCID.
        /// </summary>
        public const string PPFSCID = "PPFSCID";

        /// <summary>
        /// PPURCD.
        /// </summary>
        public const string PPURCD = "PPURCD";

        /// <summary>
        /// PPURDT.
        /// </summary>
        public const string PPURDT = "PPURDT";

        /// <summary>
        /// PPURAT.
        /// </summary>
        public const string PPURAT = "PPURAT";

        /// <summary>
        /// PPURAB.
        /// </summary>
        public const string PPURAB = "PPURAB";

        /// <summary>
        /// PPURRF.
        /// </summary>
        public const string PPURRF = "PPURRF";

        /// <summary>
        /// PPUSER.
        /// </summary>
        public const string PPUSER = "PPUSER";

        /// <summary>
        /// PPPID.
        /// </summary>
        public const string PPPID = "PPPID";

        /// <summary>
        /// PPMKEY.
        /// </summary>
        public const string PPMKEY = "PPMKEY";

        /// <summary>
        /// PPUUPMJ.
        /// </summary>
        public const string PPUUPMJ = "PPUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L703";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PPPPRID", "PPPPRID", JdeDataType.Numeric, null, true, true),
        new JdeField("PPPHID", "PPPHID", JdeDataType.Numeric),
        new JdeField("PPPROID", "PPPROID", JdeDataType.Numeric),
        new JdeField("PPPROSQ", "PPPROSQ", JdeDataType.Numeric),
        new JdeField("PPCOQY", "PPCOQY", JdeDataType.Numeric),
        new JdeField("PPSPRID", "PPSPRID", JdeDataType.Numeric),
        new JdeField("PPSPFG", "PPSPFG", JdeDataType.String, 20),
        new JdeField("PPPRYP", "PPPRYP", JdeDataType.Numeric),
        new JdeField("PPRWFG", "PPRWFG", JdeDataType.String, 20),
        new JdeField("PPPRWP", "PPPRWP", JdeDataType.Numeric),
        new JdeField("PPOPFG", "PPOPFG", JdeDataType.String, 20),
        new JdeField("PPFEFG", "PPFEFG", JdeDataType.String, 20),
        new JdeField("PPPSRP", "PPPSRP", JdeDataType.Numeric),
        new JdeField("PPFSCID", "PPFSCID", JdeDataType.Numeric),
        new JdeField("PPURCD", "PPURCD", JdeDataType.String, 4),
        new JdeField("PPURDT", "PPURDT", JdeDataType.Numeric),
        new JdeField("PPURAT", "PPURAT", JdeDataType.Numeric),
        new JdeField("PPURAB", "PPURAB", JdeDataType.Numeric),
        new JdeField("PPURRF", "PPURRF", JdeDataType.String, 30),
        new JdeField("PPUSER", "PPUSER", JdeDataType.String, 20),
        new JdeField("PPPID", "PPPID", JdeDataType.String, 20),
        new JdeField("PPMKEY", "PPMKEY", JdeDataType.String, 30),
        new JdeField("PPUUPMJ", "PPUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L703_0", "Primary Key on PPPPRID", new[] { "PPPPRID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L703_2", "Index on PPPHID, PPPROID, PPPROSQ, PPFSCID", new[] { "PPPHID", "PPPROID", "PPPROSQ", "PPFSCID" }),
        new JdeIndex("FF30L703_3", "Index on PPPHID, PPPROSQ", new[] { "PPPHID", "PPPROSQ" }),
        new JdeIndex("FF30L703_4", "Index on PPFSCID", new[] { "PPFSCID" })
    };
}
