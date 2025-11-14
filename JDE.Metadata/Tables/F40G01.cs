using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40G01 - .
/// </summary>
public class F40G01 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GFAN8FARM.
        /// </summary>
        public const string GFAN8FARM = "GFAN8FARM";

        /// <summary>
        /// GFFARMCODE.
        /// </summary>
        public const string GFFARMCODE = "GFFARMCODE";

        /// <summary>
        /// GFFARMNAME.
        /// </summary>
        public const string GFFARMNAME = "GFFARMNAME";

        /// <summary>
        /// GFOWNID.
        /// </summary>
        public const string GFOWNID = "GFOWNID";

        /// <summary>
        /// GFFARMTYPE.
        /// </summary>
        public const string GFFARMTYPE = "GFFARMTYPE";

        /// <summary>
        /// GFOMCU.
        /// </summary>
        public const string GFOMCU = "GFOMCU";

        /// <summary>
        /// GFFSTATUS.
        /// </summary>
        public const string GFFSTATUS = "GFFSTATUS";

        /// <summary>
        /// GFGRCMPCD.
        /// </summary>
        public const string GFGRCMPCD = "GFGRCMPCD";

        /// <summary>
        /// GFAN8GR.
        /// </summary>
        public const string GFAN8GR = "GFAN8GR";

        /// <summary>
        /// GFAN8BR.
        /// </summary>
        public const string GFAN8BR = "GFAN8BR";

        /// <summary>
        /// GFAN8CR.
        /// </summary>
        public const string GFAN8CR = "GFAN8CR";

        /// <summary>
        /// GFGEOCST.
        /// </summary>
        public const string GFGEOCST = "GFGEOCST";

        /// <summary>
        /// GFGOAID.
        /// </summary>
        public const string GFGOAID = "GFGOAID";

        /// <summary>
        /// GFAPPID.
        /// </summary>
        public const string GFAPPID = "GFAPPID";

        /// <summary>
        /// GFGREGION.
        /// </summary>
        public const string GFGREGION = "GFGREGION";

        /// <summary>
        /// GFGDISTR.
        /// </summary>
        public const string GFGDISTR = "GFGDISTR";

        /// <summary>
        /// GFSITEC.
        /// </summary>
        public const string GFSITEC = "GFSITEC";

        /// <summary>
        /// GFSITEP.
        /// </summary>
        public const string GFSITEP = "GFSITEP";

        /// <summary>
        /// GFCONTUOM.
        /// </summary>
        public const string GFCONTUOM = "GFCONTUOM";

        /// <summary>
        /// GFAPPLLAT.
        /// </summary>
        public const string GFAPPLLAT = "GFAPPLLAT";

        /// <summary>
        /// GFGOAREA.
        /// </summary>
        public const string GFGOAREA = "GFGOAREA";

        /// <summary>
        /// GFQTYLOAD.
        /// </summary>
        public const string GFQTYLOAD = "GFQTYLOAD";

        /// <summary>
        /// GFFARM01.
        /// </summary>
        public const string GFFARM01 = "GFFARM01";

        /// <summary>
        /// GFFARM02.
        /// </summary>
        public const string GFFARM02 = "GFFARM02";

        /// <summary>
        /// GFFARM03.
        /// </summary>
        public const string GFFARM03 = "GFFARM03";

        /// <summary>
        /// GFFARM04.
        /// </summary>
        public const string GFFARM04 = "GFFARM04";

        /// <summary>
        /// GFFARM05.
        /// </summary>
        public const string GFFARM05 = "GFFARM05";

        /// <summary>
        /// GFFARM06.
        /// </summary>
        public const string GFFARM06 = "GFFARM06";

        /// <summary>
        /// GFFARM07.
        /// </summary>
        public const string GFFARM07 = "GFFARM07";

        /// <summary>
        /// GFFARM08.
        /// </summary>
        public const string GFFARM08 = "GFFARM08";

        /// <summary>
        /// GFFARM09.
        /// </summary>
        public const string GFFARM09 = "GFFARM09";

        /// <summary>
        /// GFFARM10.
        /// </summary>
        public const string GFFARM10 = "GFFARM10";

        /// <summary>
        /// GFFARM11.
        /// </summary>
        public const string GFFARM11 = "GFFARM11";

        /// <summary>
        /// GFFARM12.
        /// </summary>
        public const string GFFARM12 = "GFFARM12";

        /// <summary>
        /// GFFARM13.
        /// </summary>
        public const string GFFARM13 = "GFFARM13";

        /// <summary>
        /// GFFARM14.
        /// </summary>
        public const string GFFARM14 = "GFFARM14";

        /// <summary>
        /// GFFARM15.
        /// </summary>
        public const string GFFARM15 = "GFFARM15";

        /// <summary>
        /// GFCFARM01.
        /// </summary>
        public const string GFCFARM01 = "GFCFARM01";

        /// <summary>
        /// GFCFARM02.
        /// </summary>
        public const string GFCFARM02 = "GFCFARM02";

        /// <summary>
        /// GFCFARM03.
        /// </summary>
        public const string GFCFARM03 = "GFCFARM03";

        /// <summary>
        /// GFCFARM04.
        /// </summary>
        public const string GFCFARM04 = "GFCFARM04";

        /// <summary>
        /// GFCFARM05.
        /// </summary>
        public const string GFCFARM05 = "GFCFARM05";

        /// <summary>
        /// GFFNUM01.
        /// </summary>
        public const string GFFNUM01 = "GFFNUM01";

        /// <summary>
        /// GFFNUM02.
        /// </summary>
        public const string GFFNUM02 = "GFFNUM02";

        /// <summary>
        /// GFFNUM03.
        /// </summary>
        public const string GFFNUM03 = "GFFNUM03";

        /// <summary>
        /// GFFNUM04.
        /// </summary>
        public const string GFFNUM04 = "GFFNUM04";

        /// <summary>
        /// GFFNUM05.
        /// </summary>
        public const string GFFNUM05 = "GFFNUM05";

        /// <summary>
        /// GFFDATE1.
        /// </summary>
        public const string GFFDATE1 = "GFFDATE1";

        /// <summary>
        /// GFFDATE2.
        /// </summary>
        public const string GFFDATE2 = "GFFDATE2";

        /// <summary>
        /// GFFDATE3.
        /// </summary>
        public const string GFFDATE3 = "GFFDATE3";

        /// <summary>
        /// GFFDATE4.
        /// </summary>
        public const string GFFDATE4 = "GFFDATE4";

        /// <summary>
        /// GFURCD.
        /// </summary>
        public const string GFURCD = "GFURCD";

        /// <summary>
        /// GFURDT.
        /// </summary>
        public const string GFURDT = "GFURDT";

        /// <summary>
        /// GFURRF.
        /// </summary>
        public const string GFURRF = "GFURRF";

        /// <summary>
        /// GFURAT.
        /// </summary>
        public const string GFURAT = "GFURAT";

        /// <summary>
        /// GFURAB.
        /// </summary>
        public const string GFURAB = "GFURAB";

        /// <summary>
        /// GFPID.
        /// </summary>
        public const string GFPID = "GFPID";

        /// <summary>
        /// GFTORG.
        /// </summary>
        public const string GFTORG = "GFTORG";

        /// <summary>
        /// GFUSER.
        /// </summary>
        public const string GFUSER = "GFUSER";

        /// <summary>
        /// GFJOBN.
        /// </summary>
        public const string GFJOBN = "GFJOBN";

        /// <summary>
        /// GFUUPMJ.
        /// </summary>
        public const string GFUUPMJ = "GFUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F40G01";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GFAN8FARM", "GFAN8FARM", JdeDataType.Numeric, null, true, true),
        new JdeField("GFFARMCODE", "GFFARMCODE", JdeDataType.String, 16),
        new JdeField("GFFARMNAME", "GFFARMNAME", JdeDataType.String, 80),
        new JdeField("GFOWNID", "GFOWNID", JdeDataType.String, 2),
        new JdeField("GFFARMTYPE", "GFFARMTYPE", JdeDataType.String, 2),
        new JdeField("GFOMCU", "GFOMCU", JdeDataType.String, 24),
        new JdeField("GFFSTATUS", "GFFSTATUS", JdeDataType.String, 2),
        new JdeField("GFGRCMPCD", "GFGRCMPCD", JdeDataType.String, 20),
        new JdeField("GFAN8GR", "GFAN8GR", JdeDataType.Numeric),
        new JdeField("GFAN8BR", "GFAN8BR", JdeDataType.Numeric),
        new JdeField("GFAN8CR", "GFAN8CR", JdeDataType.Numeric),
        new JdeField("GFGEOCST", "GFGEOCST", JdeDataType.String, 6),
        new JdeField("GFGOAID", "GFGOAID", JdeDataType.Numeric),
        new JdeField("GFAPPID", "GFAPPID", JdeDataType.Numeric),
        new JdeField("GFGREGION", "GFGREGION", JdeDataType.String, 20),
        new JdeField("GFGDISTR", "GFGDISTR", JdeDataType.String, 20),
        new JdeField("GFSITEC", "GFSITEC", JdeDataType.String, 24),
        new JdeField("GFSITEP", "GFSITEP", JdeDataType.String, 24),
        new JdeField("GFCONTUOM", "GFCONTUOM", JdeDataType.String, 4),
        new JdeField("GFAPPLLAT", "GFAPPLLAT", JdeDataType.String, 16),
        new JdeField("GFGOAREA", "GFGOAREA", JdeDataType.String, 8),
        new JdeField("GFQTYLOAD", "GFQTYLOAD", JdeDataType.Numeric),
        new JdeField("GFFARM01", "GFFARM01", JdeDataType.String, 6),
        new JdeField("GFFARM02", "GFFARM02", JdeDataType.String, 6),
        new JdeField("GFFARM03", "GFFARM03", JdeDataType.String, 6),
        new JdeField("GFFARM04", "GFFARM04", JdeDataType.String, 6),
        new JdeField("GFFARM05", "GFFARM05", JdeDataType.String, 6),
        new JdeField("GFFARM06", "GFFARM06", JdeDataType.String, 16),
        new JdeField("GFFARM07", "GFFARM07", JdeDataType.String, 16),
        new JdeField("GFFARM08", "GFFARM08", JdeDataType.String, 16),
        new JdeField("GFFARM09", "GFFARM09", JdeDataType.String, 16),
        new JdeField("GFFARM10", "GFFARM10", JdeDataType.String, 16),
        new JdeField("GFFARM11", "GFFARM11", JdeDataType.String, 20),
        new JdeField("GFFARM12", "GFFARM12", JdeDataType.String, 20),
        new JdeField("GFFARM13", "GFFARM13", JdeDataType.String, 20),
        new JdeField("GFFARM14", "GFFARM14", JdeDataType.String, 20),
        new JdeField("GFFARM15", "GFFARM15", JdeDataType.String, 20),
        new JdeField("GFCFARM01", "GFCFARM01", JdeDataType.String, 2),
        new JdeField("GFCFARM02", "GFCFARM02", JdeDataType.String, 2),
        new JdeField("GFCFARM03", "GFCFARM03", JdeDataType.String, 2),
        new JdeField("GFCFARM04", "GFCFARM04", JdeDataType.String, 2),
        new JdeField("GFCFARM05", "GFCFARM05", JdeDataType.String, 2),
        new JdeField("GFFNUM01", "GFFNUM01", JdeDataType.Numeric),
        new JdeField("GFFNUM02", "GFFNUM02", JdeDataType.Numeric),
        new JdeField("GFFNUM03", "GFFNUM03", JdeDataType.Numeric),
        new JdeField("GFFNUM04", "GFFNUM04", JdeDataType.Numeric),
        new JdeField("GFFNUM05", "GFFNUM05", JdeDataType.Numeric),
        new JdeField("GFFDATE1", "GFFDATE1", JdeDataType.Date),
        new JdeField("GFFDATE2", "GFFDATE2", JdeDataType.Date),
        new JdeField("GFFDATE3", "GFFDATE3", JdeDataType.Date),
        new JdeField("GFFDATE4", "GFFDATE4", JdeDataType.Date),
        new JdeField("GFURCD", "GFURCD", JdeDataType.String, 4),
        new JdeField("GFURDT", "GFURDT", JdeDataType.Numeric),
        new JdeField("GFURRF", "GFURRF", JdeDataType.String, 30),
        new JdeField("GFURAT", "GFURAT", JdeDataType.Numeric),
        new JdeField("GFURAB", "GFURAB", JdeDataType.Numeric),
        new JdeField("GFPID", "GFPID", JdeDataType.String, 20),
        new JdeField("GFTORG", "GFTORG", JdeDataType.String, 20),
        new JdeField("GFUSER", "GFUSER", JdeDataType.String, 20),
        new JdeField("GFJOBN", "GFJOBN", JdeDataType.String, 20),
        new JdeField("GFUUPMJ", "GFUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40G01_0", "Primary Key on GFAN8FARM", new[] { "GFAN8FARM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40G01_2", "Index on GFFARMCODE", new[] { "GFFARMCODE" })
    };
}
