using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F01RS11W - .
/// </summary>
public class F01RS11W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TDSESSID.
        /// </summary>
        public const string TDSESSID = "TDSESSID";

        /// <summary>
        /// TDRLTYPE.
        /// </summary>
        public const string TDRLTYPE = "TDRLTYPE";

        /// <summary>
        /// TDRSTVC.
        /// </summary>
        public const string TDRSTVC = "TDRSTVC";

        /// <summary>
        /// TDRSTVP.
        /// </summary>
        public const string TDRSTVP = "TDRSTVP";

        /// <summary>
        /// TDPRSSEQ.
        /// </summary>
        public const string TDPRSSEQ = "TDPRSSEQ";

        /// <summary>
        /// TDLVDT.
        /// </summary>
        public const string TDLVDT = "TDLVDT";

        /// <summary>
        /// TDLNGTASK1.
        /// </summary>
        public const string TDLNGTASK1 = "TDLNGTASK1";

        /// <summary>
        /// TDLNGTASK2.
        /// </summary>
        public const string TDLNGTASK2 = "TDLNGTASK2";

        /// <summary>
        /// TDLNGTASK3.
        /// </summary>
        public const string TDLNGTASK3 = "TDLNGTASK3";

        /// <summary>
        /// TDLNGTASK4.
        /// </summary>
        public const string TDLNGTASK4 = "TDLNGTASK4";

        /// <summary>
        /// TDLNGTASK5.
        /// </summary>
        public const string TDLNGTASK5 = "TDLNGTASK5";

        /// <summary>
        /// TDLNGTASK6.
        /// </summary>
        public const string TDLNGTASK6 = "TDLNGTASK6";

        /// <summary>
        /// TDLNGTASK7.
        /// </summary>
        public const string TDLNGTASK7 = "TDLNGTASK7";

        /// <summary>
        /// TDLNGP1.
        /// </summary>
        public const string TDLNGP1 = "TDLNGP1";

        /// <summary>
        /// TDLNGP2.
        /// </summary>
        public const string TDLNGP2 = "TDLNGP2";

        /// <summary>
        /// TDTASKTYPE.
        /// </summary>
        public const string TDTASKTYPE = "TDTASKTYPE";

        /// <summary>
        /// TDOBNM.
        /// </summary>
        public const string TDOBNM = "TDOBNM";

        /// <summary>
        /// TDFMNM.
        /// </summary>
        public const string TDFMNM = "TDFMNM";

        /// <summary>
        /// TDVER.
        /// </summary>
        public const string TDVER = "TDVER";

        /// <summary>
        /// TDRCCODE.
        /// </summary>
        public const string TDRCCODE = "TDRCCODE";

        /// <summary>
        /// TDRCCODETP.
        /// </summary>
        public const string TDRCCODETP = "TDRCCODETP";

        /// <summary>
        /// TDOPCD.
        /// </summary>
        public const string TDOPCD = "TDOPCD";

        /// <summary>
        /// TDSY.
        /// </summary>
        public const string TDSY = "TDSY";

        /// <summary>
        /// TDSYR.
        /// </summary>
        public const string TDSYR = "TDSYR";

        /// <summary>
        /// TDROLE1.
        /// </summary>
        public const string TDROLE1 = "TDROLE1";

        /// <summary>
        /// TDROLE2.
        /// </summary>
        public const string TDROLE2 = "TDROLE2";

        /// <summary>
        /// TDROLE3.
        /// </summary>
        public const string TDROLE3 = "TDROLE3";

        /// <summary>
        /// TDROLE4.
        /// </summary>
        public const string TDROLE4 = "TDROLE4";

        /// <summary>
        /// TDROLE5.
        /// </summary>
        public const string TDROLE5 = "TDROLE5";

        /// <summary>
        /// TDROLE6.
        /// </summary>
        public const string TDROLE6 = "TDROLE6";

        /// <summary>
        /// TDROLE7.
        /// </summary>
        public const string TDROLE7 = "TDROLE7";

        /// <summary>
        /// TDROLE8.
        /// </summary>
        public const string TDROLE8 = "TDROLE8";

        /// <summary>
        /// TDROLE9.
        /// </summary>
        public const string TDROLE9 = "TDROLE9";

        /// <summary>
        /// TDROLE10.
        /// </summary>
        public const string TDROLE10 = "TDROLE10";

        /// <summary>
        /// TDROLE11.
        /// </summary>
        public const string TDROLE11 = "TDROLE11";

        /// <summary>
        /// TDROLE12.
        /// </summary>
        public const string TDROLE12 = "TDROLE12";

        /// <summary>
        /// TDROLE13.
        /// </summary>
        public const string TDROLE13 = "TDROLE13";

        /// <summary>
        /// TDROLE14.
        /// </summary>
        public const string TDROLE14 = "TDROLE14";

        /// <summary>
        /// TDROLE15.
        /// </summary>
        public const string TDROLE15 = "TDROLE15";

        /// <summary>
        /// TDROLE16.
        /// </summary>
        public const string TDROLE16 = "TDROLE16";

        /// <summary>
        /// TDROLE17.
        /// </summary>
        public const string TDROLE17 = "TDROLE17";

        /// <summary>
        /// TDROLE18.
        /// </summary>
        public const string TDROLE18 = "TDROLE18";

        /// <summary>
        /// TDROLE19.
        /// </summary>
        public const string TDROLE19 = "TDROLE19";

        /// <summary>
        /// TDROLE20.
        /// </summary>
        public const string TDROLE20 = "TDROLE20";

        /// <summary>
        /// TDTASKID.
        /// </summary>
        public const string TDTASKID = "TDTASKID";

        /// <summary>
        /// TDTASKNM.
        /// </summary>
        public const string TDTASKNM = "TDTASKNM";

        /// <summary>
        /// TDLNGTASK.
        /// </summary>
        public const string TDLNGTASK = "TDLNGTASK";

        /// <summary>
        /// TDPARNTTSK.
        /// </summary>
        public const string TDPARNTTSK = "TDPARNTTSK";

        /// <summary>
        /// TDCHILDTSK.
        /// </summary>
        public const string TDCHILDTSK = "TDCHILDTSK";
    }

    /// <inheritdoc />
    public override string TableName => "F01RS11W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TDSESSID", "TDSESSID", JdeDataType.String, 64, true, true),
        new JdeField("TDRLTYPE", "TDRLTYPE", JdeDataType.String, 10, true, true),
        new JdeField("TDRSTVC", "TDRSTVC", JdeDataType.Numeric, null, true, true),
        new JdeField("TDRSTVP", "TDRSTVP", JdeDataType.Numeric),
        new JdeField("TDPRSSEQ", "TDPRSSEQ", JdeDataType.Numeric),
        new JdeField("TDLVDT", "TDLVDT", JdeDataType.Numeric),
        new JdeField("TDLNGTASK1", "TDLNGTASK1", JdeDataType.String, 160),
        new JdeField("TDLNGTASK2", "TDLNGTASK2", JdeDataType.String, 160),
        new JdeField("TDLNGTASK3", "TDLNGTASK3", JdeDataType.String, 160),
        new JdeField("TDLNGTASK4", "TDLNGTASK4", JdeDataType.String, 160),
        new JdeField("TDLNGTASK5", "TDLNGTASK5", JdeDataType.String, 160),
        new JdeField("TDLNGTASK6", "TDLNGTASK6", JdeDataType.String, 160),
        new JdeField("TDLNGTASK7", "TDLNGTASK7", JdeDataType.String, 160),
        new JdeField("TDLNGP1", "TDLNGP1", JdeDataType.String, 4),
        new JdeField("TDLNGP2", "TDLNGP2", JdeDataType.String, 4),
        new JdeField("TDTASKTYPE", "TDTASKTYPE", JdeDataType.String, 4),
        new JdeField("TDOBNM", "TDOBNM", JdeDataType.String, 20),
        new JdeField("TDFMNM", "TDFMNM", JdeDataType.String, 20),
        new JdeField("TDVER", "TDVER", JdeDataType.String, 20),
        new JdeField("TDRCCODE", "TDRCCODE", JdeDataType.String, 8),
        new JdeField("TDRCCODETP", "TDRCCODETP", JdeDataType.String, 4),
        new JdeField("TDOPCD", "TDOPCD", JdeDataType.String, 2),
        new JdeField("TDSY", "TDSY", JdeDataType.String, 8),
        new JdeField("TDSYR", "TDSYR", JdeDataType.String, 8),
        new JdeField("TDROLE1", "TDROLE1", JdeDataType.String, 72),
        new JdeField("TDROLE2", "TDROLE2", JdeDataType.String, 72),
        new JdeField("TDROLE3", "TDROLE3", JdeDataType.String, 72),
        new JdeField("TDROLE4", "TDROLE4", JdeDataType.String, 72),
        new JdeField("TDROLE5", "TDROLE5", JdeDataType.String, 72),
        new JdeField("TDROLE6", "TDROLE6", JdeDataType.String, 72),
        new JdeField("TDROLE7", "TDROLE7", JdeDataType.String, 72),
        new JdeField("TDROLE8", "TDROLE8", JdeDataType.String, 72),
        new JdeField("TDROLE9", "TDROLE9", JdeDataType.String, 72),
        new JdeField("TDROLE10", "TDROLE10", JdeDataType.String, 72),
        new JdeField("TDROLE11", "TDROLE11", JdeDataType.String, 72),
        new JdeField("TDROLE12", "TDROLE12", JdeDataType.String, 72),
        new JdeField("TDROLE13", "TDROLE13", JdeDataType.String, 72),
        new JdeField("TDROLE14", "TDROLE14", JdeDataType.String, 72),
        new JdeField("TDROLE15", "TDROLE15", JdeDataType.String, 72),
        new JdeField("TDROLE16", "TDROLE16", JdeDataType.String, 72),
        new JdeField("TDROLE17", "TDROLE17", JdeDataType.String, 72),
        new JdeField("TDROLE18", "TDROLE18", JdeDataType.String, 72),
        new JdeField("TDROLE19", "TDROLE19", JdeDataType.String, 72),
        new JdeField("TDROLE20", "TDROLE20", JdeDataType.String, 72),
        new JdeField("TDTASKID", "TDTASKID", JdeDataType.String, 72),
        new JdeField("TDTASKNM", "TDTASKNM", JdeDataType.String, 80),
        new JdeField("TDLNGTASK", "TDLNGTASK", JdeDataType.String, 160),
        new JdeField("TDPARNTTSK", "TDPARNTTSK", JdeDataType.String, 72),
        new JdeField("TDCHILDTSK", "TDCHILDTSK", JdeDataType.String, 72)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F01RS11W_0", "Primary Key on TDSESSID, TDRLTYPE, TDRSTVC", new[] { "TDSESSID", "TDRLTYPE", "TDRSTVC" }, isUnique: true, isPrimaryKey: true)
    };
}
