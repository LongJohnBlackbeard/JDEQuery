using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09330 - .
/// </summary>
public class F09330 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RTRPSTN.
        /// </summary>
        public const string RTRPSTN = "RTRPSTN";

        /// <summary>
        /// RTRPSTD.
        /// </summary>
        public const string RTRPSTD = "RTRPSTD";

        /// <summary>
        /// RTLINN.
        /// </summary>
        public const string RTLINN = "RTLINN";

        /// <summary>
        /// RTRSTN.
        /// </summary>
        public const string RTRSTN = "RTRSTN";

        /// <summary>
        /// RTRPRID.
        /// </summary>
        public const string RTRPRID = "RTRPRID";

        /// <summary>
        /// RTRIDDS.
        /// </summary>
        public const string RTRIDDS = "RTRIDDS";

        /// <summary>
        /// RTRPCOL01.
        /// </summary>
        public const string RTRPCOL01 = "RTRPCOL01";

        /// <summary>
        /// RTRPCOL02.
        /// </summary>
        public const string RTRPCOL02 = "RTRPCOL02";

        /// <summary>
        /// RTRPCOL03.
        /// </summary>
        public const string RTRPCOL03 = "RTRPCOL03";

        /// <summary>
        /// RTRPCOL04.
        /// </summary>
        public const string RTRPCOL04 = "RTRPCOL04";

        /// <summary>
        /// RTRPCOL05.
        /// </summary>
        public const string RTRPCOL05 = "RTRPCOL05";

        /// <summary>
        /// RTRPCOL06.
        /// </summary>
        public const string RTRPCOL06 = "RTRPCOL06";

        /// <summary>
        /// RTRPCOL07.
        /// </summary>
        public const string RTRPCOL07 = "RTRPCOL07";

        /// <summary>
        /// RTRPCOL08.
        /// </summary>
        public const string RTRPCOL08 = "RTRPCOL08";

        /// <summary>
        /// RTRPCOL09.
        /// </summary>
        public const string RTRPCOL09 = "RTRPCOL09";

        /// <summary>
        /// RTRPCOL10.
        /// </summary>
        public const string RTRPCOL10 = "RTRPCOL10";

        /// <summary>
        /// RTRPCOL11.
        /// </summary>
        public const string RTRPCOL11 = "RTRPCOL11";

        /// <summary>
        /// RTRPCOL12.
        /// </summary>
        public const string RTRPCOL12 = "RTRPCOL12";

        /// <summary>
        /// RTRPCOL13.
        /// </summary>
        public const string RTRPCOL13 = "RTRPCOL13";

        /// <summary>
        /// RTRPCOL14.
        /// </summary>
        public const string RTRPCOL14 = "RTRPCOL14";

        /// <summary>
        /// RTRPCOL15.
        /// </summary>
        public const string RTRPCOL15 = "RTRPCOL15";

        /// <summary>
        /// RTRPCOL16.
        /// </summary>
        public const string RTRPCOL16 = "RTRPCOL16";

        /// <summary>
        /// RTRPCOL17.
        /// </summary>
        public const string RTRPCOL17 = "RTRPCOL17";

        /// <summary>
        /// RTRPCOL18.
        /// </summary>
        public const string RTRPCOL18 = "RTRPCOL18";

        /// <summary>
        /// RTRPCOL19.
        /// </summary>
        public const string RTRPCOL19 = "RTRPCOL19";

        /// <summary>
        /// RTRPCOL20.
        /// </summary>
        public const string RTRPCOL20 = "RTRPCOL20";

        /// <summary>
        /// RTRPCOL21.
        /// </summary>
        public const string RTRPCOL21 = "RTRPCOL21";

        /// <summary>
        /// RTRPCOL22.
        /// </summary>
        public const string RTRPCOL22 = "RTRPCOL22";

        /// <summary>
        /// RTRPCOL23.
        /// </summary>
        public const string RTRPCOL23 = "RTRPCOL23";

        /// <summary>
        /// RTRPCOL24.
        /// </summary>
        public const string RTRPCOL24 = "RTRPCOL24";

        /// <summary>
        /// RTRPCOL25.
        /// </summary>
        public const string RTRPCOL25 = "RTRPCOL25";

        /// <summary>
        /// RTSTMSG.
        /// </summary>
        public const string RTSTMSG = "RTSTMSG";

        /// <summary>
        /// RTFRCC1.
        /// </summary>
        public const string RTFRCC1 = "RTFRCC1";

        /// <summary>
        /// RTFRCC2.
        /// </summary>
        public const string RTFRCC2 = "RTFRCC2";

        /// <summary>
        /// RTFRCC3.
        /// </summary>
        public const string RTFRCC3 = "RTFRCC3";

        /// <summary>
        /// RTFRCC4.
        /// </summary>
        public const string RTFRCC4 = "RTFRCC4";

        /// <summary>
        /// RTFRCC5.
        /// </summary>
        public const string RTFRCC5 = "RTFRCC5";

        /// <summary>
        /// RTWOBNM.
        /// </summary>
        public const string RTWOBNM = "RTWOBNM";

        /// <summary>
        /// RTRPNU1.
        /// </summary>
        public const string RTRPNU1 = "RTRPNU1";

        /// <summary>
        /// RTRPNU2.
        /// </summary>
        public const string RTRPNU2 = "RTRPNU2";

        /// <summary>
        /// RTRPNU3.
        /// </summary>
        public const string RTRPNU3 = "RTRPNU3";

        /// <summary>
        /// RTRPST1.
        /// </summary>
        public const string RTRPST1 = "RTRPST1";

        /// <summary>
        /// RTRPST2.
        /// </summary>
        public const string RTRPST2 = "RTRPST2";

        /// <summary>
        /// RTRPST3.
        /// </summary>
        public const string RTRPST3 = "RTRPST3";

        /// <summary>
        /// RTRPCT1.
        /// </summary>
        public const string RTRPCT1 = "RTRPCT1";

        /// <summary>
        /// RTRPCT2.
        /// </summary>
        public const string RTRPCT2 = "RTRPCT2";

        /// <summary>
        /// RTRPCT3.
        /// </summary>
        public const string RTRPCT3 = "RTRPCT3";

        /// <summary>
        /// RTRPDT1.
        /// </summary>
        public const string RTRPDT1 = "RTRPDT1";

        /// <summary>
        /// RTRPDT2.
        /// </summary>
        public const string RTRPDT2 = "RTRPDT2";

        /// <summary>
        /// RTRPDT3.
        /// </summary>
        public const string RTRPDT3 = "RTRPDT3";

        /// <summary>
        /// RTCRTBY.
        /// </summary>
        public const string RTCRTBY = "RTCRTBY";

        /// <summary>
        /// RTUSER.
        /// </summary>
        public const string RTUSER = "RTUSER";

        /// <summary>
        /// RTPID.
        /// </summary>
        public const string RTPID = "RTPID";

        /// <summary>
        /// RTJOBN.
        /// </summary>
        public const string RTJOBN = "RTJOBN";

        /// <summary>
        /// RTUPMJ.
        /// </summary>
        public const string RTUPMJ = "RTUPMJ";

        /// <summary>
        /// RTUPMT.
        /// </summary>
        public const string RTUPMT = "RTUPMT";

        /// <summary>
        /// RTLVERS.
        /// </summary>
        public const string RTLVERS = "RTLVERS";

        /// <summary>
        /// RTLODR.
        /// </summary>
        public const string RTLODR = "RTLODR";

        /// <summary>
        /// RTGAIGF.
        /// </summary>
        public const string RTGAIGF = "RTGAIGF";

        /// <summary>
        /// RTRWCF.
        /// </summary>
        public const string RTRWCF = "RTRWCF";

        /// <summary>
        /// RTRWRSF.
        /// </summary>
        public const string RTRWRSF = "RTRWRSF";

        /// <summary>
        /// RTSSNF.
        /// </summary>
        public const string RTSSNF = "RTSSNF";

        /// <summary>
        /// RTSSNT.
        /// </summary>
        public const string RTSSNT = "RTSSNT";

        /// <summary>
        /// RTSISF.
        /// </summary>
        public const string RTSISF = "RTSISF";

        /// <summary>
        /// RTRDCCF.
        /// </summary>
        public const string RTRDCCF = "RTRDCCF";
    }

    /// <inheritdoc />
    public override string TableName => "F09330";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RTRPSTN", "RTRPSTN", JdeDataType.String, 40, true, true),
        new JdeField("RTRPSTD", "RTRPSTD", JdeDataType.String, 160),
        new JdeField("RTLINN", "RTLINN", JdeDataType.Numeric, null, true, true),
        new JdeField("RTRSTN", "RTRSTN", JdeDataType.String, 40),
        new JdeField("RTRPRID", "RTRPRID", JdeDataType.Numeric, null, true, true),
        new JdeField("RTRIDDS", "RTRIDDS", JdeDataType.String, 160),
        new JdeField("RTRPCOL01", "RTRPCOL01", JdeDataType.String, 40),
        new JdeField("RTRPCOL02", "RTRPCOL02", JdeDataType.String, 40),
        new JdeField("RTRPCOL03", "RTRPCOL03", JdeDataType.String, 40),
        new JdeField("RTRPCOL04", "RTRPCOL04", JdeDataType.String, 40),
        new JdeField("RTRPCOL05", "RTRPCOL05", JdeDataType.String, 40),
        new JdeField("RTRPCOL06", "RTRPCOL06", JdeDataType.String, 40),
        new JdeField("RTRPCOL07", "RTRPCOL07", JdeDataType.String, 40),
        new JdeField("RTRPCOL08", "RTRPCOL08", JdeDataType.String, 40),
        new JdeField("RTRPCOL09", "RTRPCOL09", JdeDataType.String, 40),
        new JdeField("RTRPCOL10", "RTRPCOL10", JdeDataType.String, 40),
        new JdeField("RTRPCOL11", "RTRPCOL11", JdeDataType.String, 40),
        new JdeField("RTRPCOL12", "RTRPCOL12", JdeDataType.String, 40),
        new JdeField("RTRPCOL13", "RTRPCOL13", JdeDataType.String, 40),
        new JdeField("RTRPCOL14", "RTRPCOL14", JdeDataType.String, 40),
        new JdeField("RTRPCOL15", "RTRPCOL15", JdeDataType.String, 40),
        new JdeField("RTRPCOL16", "RTRPCOL16", JdeDataType.String, 40),
        new JdeField("RTRPCOL17", "RTRPCOL17", JdeDataType.String, 40),
        new JdeField("RTRPCOL18", "RTRPCOL18", JdeDataType.String, 40),
        new JdeField("RTRPCOL19", "RTRPCOL19", JdeDataType.String, 40),
        new JdeField("RTRPCOL20", "RTRPCOL20", JdeDataType.String, 40),
        new JdeField("RTRPCOL21", "RTRPCOL21", JdeDataType.String, 40),
        new JdeField("RTRPCOL22", "RTRPCOL22", JdeDataType.String, 40),
        new JdeField("RTRPCOL23", "RTRPCOL23", JdeDataType.String, 40),
        new JdeField("RTRPCOL24", "RTRPCOL24", JdeDataType.String, 40),
        new JdeField("RTRPCOL25", "RTRPCOL25", JdeDataType.String, 40),
        new JdeField("RTSTMSG", "RTSTMSG", JdeDataType.String, 4),
        new JdeField("RTFRCC1", "RTFRCC1", JdeDataType.String, 20),
        new JdeField("RTFRCC2", "RTFRCC2", JdeDataType.String, 20),
        new JdeField("RTFRCC3", "RTFRCC3", JdeDataType.String, 20),
        new JdeField("RTFRCC4", "RTFRCC4", JdeDataType.String, 20),
        new JdeField("RTFRCC5", "RTFRCC5", JdeDataType.String, 20),
        new JdeField("RTWOBNM", "RTWOBNM", JdeDataType.String, 60),
        new JdeField("RTRPNU1", "RTRPNU1", JdeDataType.Numeric),
        new JdeField("RTRPNU2", "RTRPNU2", JdeDataType.Numeric),
        new JdeField("RTRPNU3", "RTRPNU3", JdeDataType.Numeric),
        new JdeField("RTRPST1", "RTRPST1", JdeDataType.String, 160),
        new JdeField("RTRPST2", "RTRPST2", JdeDataType.String, 160),
        new JdeField("RTRPST3", "RTRPST3", JdeDataType.String, 160),
        new JdeField("RTRPCT1", "RTRPCT1", JdeDataType.String, 2),
        new JdeField("RTRPCT2", "RTRPCT2", JdeDataType.String, 2),
        new JdeField("RTRPCT3", "RTRPCT3", JdeDataType.String, 2),
        new JdeField("RTRPDT1", "RTRPDT1", JdeDataType.Numeric),
        new JdeField("RTRPDT2", "RTRPDT2", JdeDataType.Numeric),
        new JdeField("RTRPDT3", "RTRPDT3", JdeDataType.Numeric),
        new JdeField("RTCRTBY", "RTCRTBY", JdeDataType.String, 20),
        new JdeField("RTUSER", "RTUSER", JdeDataType.String, 20),
        new JdeField("RTPID", "RTPID", JdeDataType.String, 20),
        new JdeField("RTJOBN", "RTJOBN", JdeDataType.String, 20),
        new JdeField("RTUPMJ", "RTUPMJ", JdeDataType.Numeric),
        new JdeField("RTUPMT", "RTUPMT", JdeDataType.Numeric),
        new JdeField("RTLVERS", "RTLVERS", JdeDataType.String, 40),
        new JdeField("RTLODR", "RTLODR", JdeDataType.String, 2),
        new JdeField("RTGAIGF", "RTGAIGF", JdeDataType.String, 2),
        new JdeField("RTRWCF", "RTRWCF", JdeDataType.String, 2),
        new JdeField("RTRWRSF", "RTRWRSF", JdeDataType.String, 2),
        new JdeField("RTSSNF", "RTSSNF", JdeDataType.Numeric),
        new JdeField("RTSSNT", "RTSSNT", JdeDataType.Numeric),
        new JdeField("RTSISF", "RTSISF", JdeDataType.String, 2),
        new JdeField("RTRDCCF", "RTRDCCF", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09330_0", "Primary Key on RTRPSTN, RTRPRID, RTLINN", new[] { "RTRPSTN", "RTRPRID", "RTLINN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09330_2", "Index on RTRPRID, RTRPSTN, RTLINN", new[] { "RTRPRID", "RTRPSTN", "RTLINN" }),
        new JdeIndex("F09330_3", "Index on RTRPSTN", new[] { "RTRPSTN" }),
        new JdeIndex("F09330_4", "Index on RTRPSTN, RTRPRID", new[] { "RTRPSTN", "RTRPRID" })
    };
}
