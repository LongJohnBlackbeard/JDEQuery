using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L301 - .
/// </summary>
public class FF30L301 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CMCUSN.
        /// </summary>
        public const string CMCUSN = "CMCUSN";

        /// <summary>
        /// CMFSCID.
        /// </summary>
        public const string CMFSCID = "CMFSCID";

        /// <summary>
        /// CMDFCO.
        /// </summary>
        public const string CMDFCO = "CMDFCO";

        /// <summary>
        /// CMNAMED.
        /// </summary>
        public const string CMNAMED = "CMNAMED";

        /// <summary>
        /// CMRMK.
        /// </summary>
        public const string CMRMK = "CMRMK";

        /// <summary>
        /// CMAPTS.
        /// </summary>
        public const string CMAPTS = "CMAPTS";

        /// <summary>
        /// CMCATC01.
        /// </summary>
        public const string CMCATC01 = "CMCATC01";

        /// <summary>
        /// CMCATC02.
        /// </summary>
        public const string CMCATC02 = "CMCATC02";

        /// <summary>
        /// CMCATC03.
        /// </summary>
        public const string CMCATC03 = "CMCATC03";

        /// <summary>
        /// CMCATC04.
        /// </summary>
        public const string CMCATC04 = "CMCATC04";

        /// <summary>
        /// CMCATC05.
        /// </summary>
        public const string CMCATC05 = "CMCATC05";

        /// <summary>
        /// CMCATC06.
        /// </summary>
        public const string CMCATC06 = "CMCATC06";

        /// <summary>
        /// CMCATC07.
        /// </summary>
        public const string CMCATC07 = "CMCATC07";

        /// <summary>
        /// CMCATC08.
        /// </summary>
        public const string CMCATC08 = "CMCATC08";

        /// <summary>
        /// CMCATC09.
        /// </summary>
        public const string CMCATC09 = "CMCATC09";

        /// <summary>
        /// CMCATC10.
        /// </summary>
        public const string CMCATC10 = "CMCATC10";

        /// <summary>
        /// CMCATC11.
        /// </summary>
        public const string CMCATC11 = "CMCATC11";

        /// <summary>
        /// CMCATC12.
        /// </summary>
        public const string CMCATC12 = "CMCATC12";

        /// <summary>
        /// CMCATC13.
        /// </summary>
        public const string CMCATC13 = "CMCATC13";

        /// <summary>
        /// CMCATC14.
        /// </summary>
        public const string CMCATC14 = "CMCATC14";

        /// <summary>
        /// CMCATC15.
        /// </summary>
        public const string CMCATC15 = "CMCATC15";

        /// <summary>
        /// CMCATC16.
        /// </summary>
        public const string CMCATC16 = "CMCATC16";

        /// <summary>
        /// CMCATC17.
        /// </summary>
        public const string CMCATC17 = "CMCATC17";

        /// <summary>
        /// CMCATC18.
        /// </summary>
        public const string CMCATC18 = "CMCATC18";

        /// <summary>
        /// CMCATC19.
        /// </summary>
        public const string CMCATC19 = "CMCATC19";

        /// <summary>
        /// CMCATC20.
        /// </summary>
        public const string CMCATC20 = "CMCATC20";

        /// <summary>
        /// CMCATC21.
        /// </summary>
        public const string CMCATC21 = "CMCATC21";

        /// <summary>
        /// CMCATC22.
        /// </summary>
        public const string CMCATC22 = "CMCATC22";

        /// <summary>
        /// CMCATC23.
        /// </summary>
        public const string CMCATC23 = "CMCATC23";

        /// <summary>
        /// CMCATC24.
        /// </summary>
        public const string CMCATC24 = "CMCATC24";

        /// <summary>
        /// CMCATC25.
        /// </summary>
        public const string CMCATC25 = "CMCATC25";

        /// <summary>
        /// CMCATC26.
        /// </summary>
        public const string CMCATC26 = "CMCATC26";

        /// <summary>
        /// CMCATC27.
        /// </summary>
        public const string CMCATC27 = "CMCATC27";

        /// <summary>
        /// CMCATC28.
        /// </summary>
        public const string CMCATC28 = "CMCATC28";

        /// <summary>
        /// CMCATC29.
        /// </summary>
        public const string CMCATC29 = "CMCATC29";

        /// <summary>
        /// CMCATC30.
        /// </summary>
        public const string CMCATC30 = "CMCATC30";

        /// <summary>
        /// CMURCD.
        /// </summary>
        public const string CMURCD = "CMURCD";

        /// <summary>
        /// CMURDT.
        /// </summary>
        public const string CMURDT = "CMURDT";

        /// <summary>
        /// CMURAT.
        /// </summary>
        public const string CMURAT = "CMURAT";

        /// <summary>
        /// CMURAB.
        /// </summary>
        public const string CMURAB = "CMURAB";

        /// <summary>
        /// CMURRF.
        /// </summary>
        public const string CMURRF = "CMURRF";

        /// <summary>
        /// CMUSER.
        /// </summary>
        public const string CMUSER = "CMUSER";

        /// <summary>
        /// CMPID.
        /// </summary>
        public const string CMPID = "CMPID";

        /// <summary>
        /// CMMKEY.
        /// </summary>
        public const string CMMKEY = "CMMKEY";

        /// <summary>
        /// CMUUPMJ.
        /// </summary>
        public const string CMUUPMJ = "CMUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L301";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CMCUSN", "CMCUSN", JdeDataType.Numeric, null, true, true),
        new JdeField("CMFSCID", "CMFSCID", JdeDataType.Numeric, null, true, true),
        new JdeField("CMDFCO", "CMDFCO", JdeDataType.String, 10, true, true),
        new JdeField("CMNAMED", "CMNAMED", JdeDataType.String, 80),
        new JdeField("CMRMK", "CMRMK", JdeDataType.String, 60),
        new JdeField("CMAPTS", "CMAPTS", JdeDataType.String, 2),
        new JdeField("CMCATC01", "CMCATC01", JdeDataType.String, 6),
        new JdeField("CMCATC02", "CMCATC02", JdeDataType.String, 6),
        new JdeField("CMCATC03", "CMCATC03", JdeDataType.String, 6),
        new JdeField("CMCATC04", "CMCATC04", JdeDataType.String, 6),
        new JdeField("CMCATC05", "CMCATC05", JdeDataType.String, 6),
        new JdeField("CMCATC06", "CMCATC06", JdeDataType.String, 6),
        new JdeField("CMCATC07", "CMCATC07", JdeDataType.String, 6),
        new JdeField("CMCATC08", "CMCATC08", JdeDataType.String, 6),
        new JdeField("CMCATC09", "CMCATC09", JdeDataType.String, 6),
        new JdeField("CMCATC10", "CMCATC10", JdeDataType.String, 6),
        new JdeField("CMCATC11", "CMCATC11", JdeDataType.String, 6),
        new JdeField("CMCATC12", "CMCATC12", JdeDataType.String, 6),
        new JdeField("CMCATC13", "CMCATC13", JdeDataType.String, 6),
        new JdeField("CMCATC14", "CMCATC14", JdeDataType.String, 6),
        new JdeField("CMCATC15", "CMCATC15", JdeDataType.String, 6),
        new JdeField("CMCATC16", "CMCATC16", JdeDataType.String, 6),
        new JdeField("CMCATC17", "CMCATC17", JdeDataType.String, 6),
        new JdeField("CMCATC18", "CMCATC18", JdeDataType.String, 6),
        new JdeField("CMCATC19", "CMCATC19", JdeDataType.String, 6),
        new JdeField("CMCATC20", "CMCATC20", JdeDataType.String, 6),
        new JdeField("CMCATC21", "CMCATC21", JdeDataType.String, 6),
        new JdeField("CMCATC22", "CMCATC22", JdeDataType.String, 6),
        new JdeField("CMCATC23", "CMCATC23", JdeDataType.String, 6),
        new JdeField("CMCATC24", "CMCATC24", JdeDataType.String, 6),
        new JdeField("CMCATC25", "CMCATC25", JdeDataType.String, 6),
        new JdeField("CMCATC26", "CMCATC26", JdeDataType.String, 6),
        new JdeField("CMCATC27", "CMCATC27", JdeDataType.String, 6),
        new JdeField("CMCATC28", "CMCATC28", JdeDataType.String, 6),
        new JdeField("CMCATC29", "CMCATC29", JdeDataType.String, 6),
        new JdeField("CMCATC30", "CMCATC30", JdeDataType.String, 6),
        new JdeField("CMURCD", "CMURCD", JdeDataType.String, 4),
        new JdeField("CMURDT", "CMURDT", JdeDataType.Numeric),
        new JdeField("CMURAT", "CMURAT", JdeDataType.Numeric),
        new JdeField("CMURAB", "CMURAB", JdeDataType.Numeric),
        new JdeField("CMURRF", "CMURRF", JdeDataType.String, 30),
        new JdeField("CMUSER", "CMUSER", JdeDataType.String, 20),
        new JdeField("CMPID", "CMPID", JdeDataType.String, 20),
        new JdeField("CMMKEY", "CMMKEY", JdeDataType.String, 30),
        new JdeField("CMUUPMJ", "CMUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L301_0", "Primary Key on CMCUSN, CMFSCID, CMDFCO", new[] { "CMCUSN", "CMFSCID", "CMDFCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L301_2", "Index on CMFSCID", new[] { "CMFSCID" })
    };
}
