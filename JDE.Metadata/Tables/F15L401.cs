using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15L401 - .
/// </summary>
public class F15L401 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SFMCU.
        /// </summary>
        public const string SFMCU = "SFMCU";

        /// <summary>
        /// SFRVNB.
        /// </summary>
        public const string SFRVNB = "SFRVNB";

        /// <summary>
        /// SFSFDN.
        /// </summary>
        public const string SFSFDN = "SFSFDN";

        /// <summary>
        /// SFECMP.
        /// </summary>
        public const string SFECMP = "SFECMP";

        /// <summary>
        /// SFGLMD.
        /// </summary>
        public const string SFGLMD = "SFGLMD";

        /// <summary>
        /// SFMCUS.
        /// </summary>
        public const string SFMCUS = "SFMCUS";

        /// <summary>
        /// SFUNIT.
        /// </summary>
        public const string SFUNIT = "SFUNIT";

        /// <summary>
        /// SFCENTYR.
        /// </summary>
        public const string SFCENTYR = "SFCENTYR";

        /// <summary>
        /// SFARDEFID.
        /// </summary>
        public const string SFARDEFID = "SFARDEFID";

        /// <summary>
        /// SFCPVA.
        /// </summary>
        public const string SFCPVA = "SFCPVA";

        /// <summary>
        /// SFCAPA.
        /// </summary>
        public const string SFCAPA = "SFCAPA";

        /// <summary>
        /// SFGLAA01.
        /// </summary>
        public const string SFGLAA01 = "SFGLAA01";

        /// <summary>
        /// SFGLAA02.
        /// </summary>
        public const string SFGLAA02 = "SFGLAA02";

        /// <summary>
        /// SFGLAA03.
        /// </summary>
        public const string SFGLAA03 = "SFGLAA03";

        /// <summary>
        /// SFGLAA04.
        /// </summary>
        public const string SFGLAA04 = "SFGLAA04";

        /// <summary>
        /// SFGLAA05.
        /// </summary>
        public const string SFGLAA05 = "SFGLAA05";

        /// <summary>
        /// SFGLAA06.
        /// </summary>
        public const string SFGLAA06 = "SFGLAA06";

        /// <summary>
        /// SFGLAA07.
        /// </summary>
        public const string SFGLAA07 = "SFGLAA07";

        /// <summary>
        /// SFGLAA08.
        /// </summary>
        public const string SFGLAA08 = "SFGLAA08";

        /// <summary>
        /// SFGLAA09.
        /// </summary>
        public const string SFGLAA09 = "SFGLAA09";

        /// <summary>
        /// SFGLAA10.
        /// </summary>
        public const string SFGLAA10 = "SFGLAA10";

        /// <summary>
        /// SFGLAA11.
        /// </summary>
        public const string SFGLAA11 = "SFGLAA11";

        /// <summary>
        /// SFGLAA12.
        /// </summary>
        public const string SFGLAA12 = "SFGLAA12";

        /// <summary>
        /// SFGLOA01.
        /// </summary>
        public const string SFGLOA01 = "SFGLOA01";

        /// <summary>
        /// SFGLOA02.
        /// </summary>
        public const string SFGLOA02 = "SFGLOA02";

        /// <summary>
        /// SFGLOA03.
        /// </summary>
        public const string SFGLOA03 = "SFGLOA03";

        /// <summary>
        /// SFGLOA04.
        /// </summary>
        public const string SFGLOA04 = "SFGLOA04";

        /// <summary>
        /// SFGLOA05.
        /// </summary>
        public const string SFGLOA05 = "SFGLOA05";

        /// <summary>
        /// SFGLOA06.
        /// </summary>
        public const string SFGLOA06 = "SFGLOA06";

        /// <summary>
        /// SFGLOA07.
        /// </summary>
        public const string SFGLOA07 = "SFGLOA07";

        /// <summary>
        /// SFGLOA08.
        /// </summary>
        public const string SFGLOA08 = "SFGLOA08";

        /// <summary>
        /// SFGLOA09.
        /// </summary>
        public const string SFGLOA09 = "SFGLOA09";

        /// <summary>
        /// SFGLOA10.
        /// </summary>
        public const string SFGLOA10 = "SFGLOA10";

        /// <summary>
        /// SFGLOA11.
        /// </summary>
        public const string SFGLOA11 = "SFGLOA11";

        /// <summary>
        /// SFGLOA12.
        /// </summary>
        public const string SFGLOA12 = "SFGLOA12";

        /// <summary>
        /// SFUSER.
        /// </summary>
        public const string SFUSER = "SFUSER";

        /// <summary>
        /// SFPID.
        /// </summary>
        public const string SFPID = "SFPID";

        /// <summary>
        /// SFMKEY.
        /// </summary>
        public const string SFMKEY = "SFMKEY";

        /// <summary>
        /// SFUPMJ.
        /// </summary>
        public const string SFUPMJ = "SFUPMJ";

        /// <summary>
        /// SFUPMT.
        /// </summary>
        public const string SFUPMT = "SFUPMT";

        /// <summary>
        /// SFTORG.
        /// </summary>
        public const string SFTORG = "SFTORG";

        /// <summary>
        /// SFENTJ.
        /// </summary>
        public const string SFENTJ = "SFENTJ";

        /// <summary>
        /// SFAREFODO.
        /// </summary>
        public const string SFAREFODO = "SFAREFODO";

        /// <summary>
        /// SFOCCROA.
        /// </summary>
        public const string SFOCCROA = "SFOCCROA";

        /// <summary>
        /// SFDENMTUA.
        /// </summary>
        public const string SFDENMTUA = "SFDENMTUA";

        /// <summary>
        /// SFEFTB.
        /// </summary>
        public const string SFEFTB = "SFEFTB";

        /// <summary>
        /// SFEFTE.
        /// </summary>
        public const string SFEFTE = "SFEFTE";

        /// <summary>
        /// SFCAPBAT.
        /// </summary>
        public const string SFCAPBAT = "SFCAPBAT";

        /// <summary>
        /// SFSFDM.
        /// </summary>
        public const string SFSFDM = "SFSFDM";

        /// <summary>
        /// SFAM01.
        /// </summary>
        public const string SFAM01 = "SFAM01";

        /// <summary>
        /// SFARTY.
        /// </summary>
        public const string SFARTY = "SFARTY";
    }

    /// <inheritdoc />
    public override string TableName => "F15L401";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SFMCU", "SFMCU", JdeDataType.String, 24, true, true),
        new JdeField("SFRVNB", "SFRVNB", JdeDataType.Numeric, null, true, true),
        new JdeField("SFSFDN", "SFSFDN", JdeDataType.String, 20, true, true),
        new JdeField("SFECMP", "SFECMP", JdeDataType.String, 2, true, true),
        new JdeField("SFGLMD", "SFGLMD", JdeDataType.String, 2, true, true),
        new JdeField("SFMCUS", "SFMCUS", JdeDataType.String, 24, true, true),
        new JdeField("SFUNIT", "SFUNIT", JdeDataType.String, 16, true, true),
        new JdeField("SFCENTYR", "SFCENTYR", JdeDataType.Numeric, null, true, true),
        new JdeField("SFARDEFID", "SFARDEFID", JdeDataType.String, 20),
        new JdeField("SFCPVA", "SFCPVA", JdeDataType.Numeric),
        new JdeField("SFCAPA", "SFCAPA", JdeDataType.Numeric),
        new JdeField("SFGLAA01", "SFGLAA01", JdeDataType.Numeric),
        new JdeField("SFGLAA02", "SFGLAA02", JdeDataType.Numeric),
        new JdeField("SFGLAA03", "SFGLAA03", JdeDataType.Numeric),
        new JdeField("SFGLAA04", "SFGLAA04", JdeDataType.Numeric),
        new JdeField("SFGLAA05", "SFGLAA05", JdeDataType.Numeric),
        new JdeField("SFGLAA06", "SFGLAA06", JdeDataType.Numeric),
        new JdeField("SFGLAA07", "SFGLAA07", JdeDataType.Numeric),
        new JdeField("SFGLAA08", "SFGLAA08", JdeDataType.Numeric),
        new JdeField("SFGLAA09", "SFGLAA09", JdeDataType.Numeric),
        new JdeField("SFGLAA10", "SFGLAA10", JdeDataType.Numeric),
        new JdeField("SFGLAA11", "SFGLAA11", JdeDataType.Numeric),
        new JdeField("SFGLAA12", "SFGLAA12", JdeDataType.Numeric),
        new JdeField("SFGLOA01", "SFGLOA01", JdeDataType.Numeric),
        new JdeField("SFGLOA02", "SFGLOA02", JdeDataType.Numeric),
        new JdeField("SFGLOA03", "SFGLOA03", JdeDataType.Numeric),
        new JdeField("SFGLOA04", "SFGLOA04", JdeDataType.Numeric),
        new JdeField("SFGLOA05", "SFGLOA05", JdeDataType.Numeric),
        new JdeField("SFGLOA06", "SFGLOA06", JdeDataType.Numeric),
        new JdeField("SFGLOA07", "SFGLOA07", JdeDataType.Numeric),
        new JdeField("SFGLOA08", "SFGLOA08", JdeDataType.Numeric),
        new JdeField("SFGLOA09", "SFGLOA09", JdeDataType.Numeric),
        new JdeField("SFGLOA10", "SFGLOA10", JdeDataType.Numeric),
        new JdeField("SFGLOA11", "SFGLOA11", JdeDataType.Numeric),
        new JdeField("SFGLOA12", "SFGLOA12", JdeDataType.Numeric),
        new JdeField("SFUSER", "SFUSER", JdeDataType.String, 20),
        new JdeField("SFPID", "SFPID", JdeDataType.String, 20),
        new JdeField("SFMKEY", "SFMKEY", JdeDataType.String, 30),
        new JdeField("SFUPMJ", "SFUPMJ", JdeDataType.Numeric),
        new JdeField("SFUPMT", "SFUPMT", JdeDataType.Numeric),
        new JdeField("SFTORG", "SFTORG", JdeDataType.String, 20),
        new JdeField("SFENTJ", "SFENTJ", JdeDataType.Numeric),
        new JdeField("SFAREFODO", "SFAREFODO", JdeDataType.String, 2),
        new JdeField("SFOCCROA", "SFOCCROA", JdeDataType.String, 2, true, true),
        new JdeField("SFDENMTUA", "SFDENMTUA", JdeDataType.Numeric),
        new JdeField("SFEFTB", "SFEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("SFEFTE", "SFEFTE", JdeDataType.Numeric, null, true, true),
        new JdeField("SFCAPBAT", "SFCAPBAT", JdeDataType.Numeric),
        new JdeField("SFSFDM", "SFSFDM", JdeDataType.String, 2),
        new JdeField("SFAM01", "SFAM01", JdeDataType.String, 6),
        new JdeField("SFARTY", "SFARTY", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15L401_0", "Primary Key on SFMCU, SFRVNB, SFMCUS, SFUNIT, SFSFDN, SFECMP, SFGLMD, SFOCCROA, SFCENTYR, SFEFTB, SFEFTE", new[] { "SFMCU", "SFRVNB", "SFMCUS", "SFUNIT", "SFSFDN", "SFECMP", "SFGLMD", "SFOCCROA", "SFCENTYR", "SFEFTB", "SFEFTE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F15L401_2", "Index on SFMCU, SFRVNB", new[] { "SFMCU", "SFRVNB" })
    };
}
