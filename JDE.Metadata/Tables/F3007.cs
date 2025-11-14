using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3007 - .
/// </summary>
public class F3007 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WUMCU.
        /// </summary>
        public const string WUMCU = "WUMCU";

        /// <summary>
        /// WUYR.
        /// </summary>
        public const string WUYR = "WUYR";

        /// <summary>
        /// WUMT.
        /// </summary>
        public const string WUMT = "WUMT";

        /// <summary>
        /// WUMMCU.
        /// </summary>
        public const string WUMMCU = "WUMMCU";

        /// <summary>
        /// WUUM.
        /// </summary>
        public const string WUUM = "WUUM";

        /// <summary>
        /// WUSTYL.
        /// </summary>
        public const string WUSTYL = "WUSTYL";

        /// <summary>
        /// WUSHFT.
        /// </summary>
        public const string WUSHFT = "WUSHFT";

        /// <summary>
        /// WUWORE.
        /// </summary>
        public const string WUWORE = "WUWORE";

        /// <summary>
        /// WUWORU.
        /// </summary>
        public const string WUWORU = "WUWORU";

        /// <summary>
        /// WURU01.
        /// </summary>
        public const string WURU01 = "WURU01";

        /// <summary>
        /// WURU02.
        /// </summary>
        public const string WURU02 = "WURU02";

        /// <summary>
        /// WURU03.
        /// </summary>
        public const string WURU03 = "WURU03";

        /// <summary>
        /// WURU04.
        /// </summary>
        public const string WURU04 = "WURU04";

        /// <summary>
        /// WURU05.
        /// </summary>
        public const string WURU05 = "WURU05";

        /// <summary>
        /// WURU06.
        /// </summary>
        public const string WURU06 = "WURU06";

        /// <summary>
        /// WURU07.
        /// </summary>
        public const string WURU07 = "WURU07";

        /// <summary>
        /// WURU08.
        /// </summary>
        public const string WURU08 = "WURU08";

        /// <summary>
        /// WURU09.
        /// </summary>
        public const string WURU09 = "WURU09";

        /// <summary>
        /// WURU10.
        /// </summary>
        public const string WURU10 = "WURU10";

        /// <summary>
        /// WURU11.
        /// </summary>
        public const string WURU11 = "WURU11";

        /// <summary>
        /// WURU12.
        /// </summary>
        public const string WURU12 = "WURU12";

        /// <summary>
        /// WURU13.
        /// </summary>
        public const string WURU13 = "WURU13";

        /// <summary>
        /// WURU14.
        /// </summary>
        public const string WURU14 = "WURU14";

        /// <summary>
        /// WURU15.
        /// </summary>
        public const string WURU15 = "WURU15";

        /// <summary>
        /// WURU16.
        /// </summary>
        public const string WURU16 = "WURU16";

        /// <summary>
        /// WURU17.
        /// </summary>
        public const string WURU17 = "WURU17";

        /// <summary>
        /// WURU18.
        /// </summary>
        public const string WURU18 = "WURU18";

        /// <summary>
        /// WURU19.
        /// </summary>
        public const string WURU19 = "WURU19";

        /// <summary>
        /// WURU20.
        /// </summary>
        public const string WURU20 = "WURU20";

        /// <summary>
        /// WURU21.
        /// </summary>
        public const string WURU21 = "WURU21";

        /// <summary>
        /// WURU22.
        /// </summary>
        public const string WURU22 = "WURU22";

        /// <summary>
        /// WURU23.
        /// </summary>
        public const string WURU23 = "WURU23";

        /// <summary>
        /// WURU24.
        /// </summary>
        public const string WURU24 = "WURU24";

        /// <summary>
        /// WURU25.
        /// </summary>
        public const string WURU25 = "WURU25";

        /// <summary>
        /// WURU26.
        /// </summary>
        public const string WURU26 = "WURU26";

        /// <summary>
        /// WURU27.
        /// </summary>
        public const string WURU27 = "WURU27";

        /// <summary>
        /// WURU28.
        /// </summary>
        public const string WURU28 = "WURU28";

        /// <summary>
        /// WURU29.
        /// </summary>
        public const string WURU29 = "WURU29";

        /// <summary>
        /// WURU30.
        /// </summary>
        public const string WURU30 = "WURU30";

        /// <summary>
        /// WURU31.
        /// </summary>
        public const string WURU31 = "WURU31";

        /// <summary>
        /// WUPID.
        /// </summary>
        public const string WUPID = "WUPID";

        /// <summary>
        /// WUJOBN.
        /// </summary>
        public const string WUJOBN = "WUJOBN";

        /// <summary>
        /// WUUSER.
        /// </summary>
        public const string WUUSER = "WUUSER";

        /// <summary>
        /// WUUPMJ.
        /// </summary>
        public const string WUUPMJ = "WUUPMJ";

        /// <summary>
        /// WUTDAY.
        /// </summary>
        public const string WUTDAY = "WUTDAY";

        /// <summary>
        /// WUCTRY.
        /// </summary>
        public const string WUCTRY = "WUCTRY";
    }

    /// <inheritdoc />
    public override string TableName => "F3007";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WUMCU", "WUMCU", JdeDataType.String, 24, true, true),
        new JdeField("WUYR", "WUYR", JdeDataType.Numeric, null, true, true),
        new JdeField("WUMT", "WUMT", JdeDataType.Numeric, null, true, true),
        new JdeField("WUMMCU", "WUMMCU", JdeDataType.String, 24, true, true),
        new JdeField("WUUM", "WUUM", JdeDataType.String, 4, true, true),
        new JdeField("WUSTYL", "WUSTYL", JdeDataType.String, 4, true, true),
        new JdeField("WUSHFT", "WUSHFT", JdeDataType.String, 2, true, true),
        new JdeField("WUWORE", "WUWORE", JdeDataType.Numeric),
        new JdeField("WUWORU", "WUWORU", JdeDataType.Numeric),
        new JdeField("WURU01", "WURU01", JdeDataType.Numeric),
        new JdeField("WURU02", "WURU02", JdeDataType.Numeric),
        new JdeField("WURU03", "WURU03", JdeDataType.Numeric),
        new JdeField("WURU04", "WURU04", JdeDataType.Numeric),
        new JdeField("WURU05", "WURU05", JdeDataType.Numeric),
        new JdeField("WURU06", "WURU06", JdeDataType.Numeric),
        new JdeField("WURU07", "WURU07", JdeDataType.Numeric),
        new JdeField("WURU08", "WURU08", JdeDataType.Numeric),
        new JdeField("WURU09", "WURU09", JdeDataType.Numeric),
        new JdeField("WURU10", "WURU10", JdeDataType.Numeric),
        new JdeField("WURU11", "WURU11", JdeDataType.Numeric),
        new JdeField("WURU12", "WURU12", JdeDataType.Numeric),
        new JdeField("WURU13", "WURU13", JdeDataType.Numeric),
        new JdeField("WURU14", "WURU14", JdeDataType.Numeric),
        new JdeField("WURU15", "WURU15", JdeDataType.Numeric),
        new JdeField("WURU16", "WURU16", JdeDataType.Numeric),
        new JdeField("WURU17", "WURU17", JdeDataType.Numeric),
        new JdeField("WURU18", "WURU18", JdeDataType.Numeric),
        new JdeField("WURU19", "WURU19", JdeDataType.Numeric),
        new JdeField("WURU20", "WURU20", JdeDataType.Numeric),
        new JdeField("WURU21", "WURU21", JdeDataType.Numeric),
        new JdeField("WURU22", "WURU22", JdeDataType.Numeric),
        new JdeField("WURU23", "WURU23", JdeDataType.Numeric),
        new JdeField("WURU24", "WURU24", JdeDataType.Numeric),
        new JdeField("WURU25", "WURU25", JdeDataType.Numeric),
        new JdeField("WURU26", "WURU26", JdeDataType.Numeric),
        new JdeField("WURU27", "WURU27", JdeDataType.Numeric),
        new JdeField("WURU28", "WURU28", JdeDataType.Numeric),
        new JdeField("WURU29", "WURU29", JdeDataType.Numeric),
        new JdeField("WURU30", "WURU30", JdeDataType.Numeric),
        new JdeField("WURU31", "WURU31", JdeDataType.Numeric),
        new JdeField("WUPID", "WUPID", JdeDataType.String, 20),
        new JdeField("WUJOBN", "WUJOBN", JdeDataType.String, 20),
        new JdeField("WUUSER", "WUUSER", JdeDataType.String, 20),
        new JdeField("WUUPMJ", "WUUPMJ", JdeDataType.Numeric),
        new JdeField("WUTDAY", "WUTDAY", JdeDataType.Numeric),
        new JdeField("WUCTRY", "WUCTRY", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3007_0", "Primary Key on WUMCU, WUCTRY, WUYR, WUMT, WUMMCU, WUUM, WUSTYL, WUSHFT", new[] { "WUMCU", "WUCTRY", "WUYR", "WUMT", "WUMMCU", "WUUM", "WUSTYL", "WUSHFT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3007_2", "Index on WUMMCU, WUMCU, WUUM, WUYR, WUMT, WUSTYL, WUSHFT", new[] { "WUMMCU", "WUMCU", "WUUM", "WUYR", "WUMT", "WUSTYL", "WUSHFT" }),
        new JdeIndex("F3007_3", "Index on WUMMCU, WUMCU, WUYR, WUMT, WUUM, WUSHFT", new[] { "WUMMCU", "WUMCU", "WUYR", "WUMT", "WUUM", "WUSHFT" }),
        new JdeIndex("F3007_4", "Index on WUMMCU, WUMCU, WUUM, WUSHFT, WUYR, WUMT", new[] { "WUMMCU", "WUMCU", "WUUM", "WUSHFT", "WUYR", "WUMT" }),
        new JdeIndex("F3007_5", "Index on WUMMCU, WUMCU, WUYR, WUMT, WUSHFT", new[] { "WUMMCU", "WUMCU", "WUYR", "WUMT", "WUSHFT" }),
        new JdeIndex("F3007_6", "Index on WUMMCU, WUMCU, WUMT, WUSHFT, WUYR", new[] { "WUMMCU", "WUMCU", "WUMT", "WUSHFT", "WUYR" }),
        new JdeIndex("F3007_7", "Index on WUMMCU, WUMCU, WUSHFT, WUYR, WUMT", new[] { "WUMMCU", "WUMCU", "WUSHFT", "WUYR", "WUMT" })
    };
}
