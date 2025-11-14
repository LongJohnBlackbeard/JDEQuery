using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3712 - .
/// </summary>
public class F3712 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SDBSNBR.
        /// </summary>
        public const string SDBSNBR = "SDBSNBR";

        /// <summary>
        /// SDWOPID.
        /// </summary>
        public const string SDWOPID = "SDWOPID";

        /// <summary>
        /// SDWDOCO.
        /// </summary>
        public const string SDWDOCO = "SDWDOCO";

        /// <summary>
        /// SDASNBR.
        /// </summary>
        public const string SDASNBR = "SDASNBR";

        /// <summary>
        /// SDSMPTYP.
        /// </summary>
        public const string SDSMPTYP = "SDSMPTYP";

        /// <summary>
        /// SDSCNSL.
        /// </summary>
        public const string SDSCNSL = "SDSCNSL";

        /// <summary>
        /// SDSMPSTS.
        /// </summary>
        public const string SDSMPSTS = "SDSMPSTS";

        /// <summary>
        /// SDDLAB.
        /// </summary>
        public const string SDDLAB = "SDDLAB";

        /// <summary>
        /// SDSMPMTHD.
        /// </summary>
        public const string SDSMPMTHD = "SDSMPMTHD";

        /// <summary>
        /// SDSCUKID.
        /// </summary>
        public const string SDSCUKID = "SDSCUKID";

        /// <summary>
        /// SDSMPCLSR.
        /// </summary>
        public const string SDSMPCLSR = "SDSMPCLSR";

        /// <summary>
        /// SDNBRCNTR.
        /// </summary>
        public const string SDNBRCNTR = "SDNBRCNTR";

        /// <summary>
        /// SDBQSSZ.
        /// </summary>
        public const string SDBQSSZ = "SDBQSSZ";

        /// <summary>
        /// SDQUM.
        /// </summary>
        public const string SDQUM = "SDQUM";

        /// <summary>
        /// SDSMPLR.
        /// </summary>
        public const string SDSMPLR = "SDSMPLR";

        /// <summary>
        /// SDUSMPDT.
        /// </summary>
        public const string SDUSMPDT = "SDUSMPDT";

        /// <summary>
        /// SDUSRQDT.
        /// </summary>
        public const string SDUSRQDT = "SDUSRQDT";

        /// <summary>
        /// SDWTBID.
        /// </summary>
        public const string SDWTBID = "SDWTBID";

        /// <summary>
        /// SDBNCHID.
        /// </summary>
        public const string SDBNCHID = "SDBNCHID";

        /// <summary>
        /// SDCWLOTN.
        /// </summary>
        public const string SDCWLOTN = "SDCWLOTN";

        /// <summary>
        /// SDCWVID.
        /// </summary>
        public const string SDCWVID = "SDCWVID";

        /// <summary>
        /// SDCMCU.
        /// </summary>
        public const string SDCMCU = "SDCMCU";

        /// <summary>
        /// SDWMDT.
        /// </summary>
        public const string SDWMDT = "SDWMDT";

        /// <summary>
        /// SDWNUM.
        /// </summary>
        public const string SDWNUM = "SDWNUM";

        /// <summary>
        /// SDWAB.
        /// </summary>
        public const string SDWAB = "SDWAB";

        /// <summary>
        /// SDWCD.
        /// </summary>
        public const string SDWCD = "SDWCD";

        /// <summary>
        /// SDWRF.
        /// </summary>
        public const string SDWRF = "SDWRF";

        /// <summary>
        /// SDURAT.
        /// </summary>
        public const string SDURAT = "SDURAT";

        /// <summary>
        /// SDURCD.
        /// </summary>
        public const string SDURCD = "SDURCD";

        /// <summary>
        /// SDURDT.
        /// </summary>
        public const string SDURDT = "SDURDT";

        /// <summary>
        /// SDURRF.
        /// </summary>
        public const string SDURRF = "SDURRF";

        /// <summary>
        /// SDURAB.
        /// </summary>
        public const string SDURAB = "SDURAB";

        /// <summary>
        /// SDUSER.
        /// </summary>
        public const string SDUSER = "SDUSER";

        /// <summary>
        /// SDPID.
        /// </summary>
        public const string SDPID = "SDPID";

        /// <summary>
        /// SDTDAY.
        /// </summary>
        public const string SDTDAY = "SDTDAY";

        /// <summary>
        /// SDUPMJ.
        /// </summary>
        public const string SDUPMJ = "SDUPMJ";

        /// <summary>
        /// SDJOBN.
        /// </summary>
        public const string SDJOBN = "SDJOBN";

        /// <summary>
        /// SDWVTY.
        /// </summary>
        public const string SDWVTY = "SDWVTY";
    }

    /// <inheritdoc />
    public override string TableName => "F3712";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SDBSNBR", "SDBSNBR", JdeDataType.Numeric, null, true, true),
        new JdeField("SDWOPID", "SDWOPID", JdeDataType.Numeric),
        new JdeField("SDWDOCO", "SDWDOCO", JdeDataType.Numeric),
        new JdeField("SDASNBR", "SDASNBR", JdeDataType.String, 40),
        new JdeField("SDSMPTYP", "SDSMPTYP", JdeDataType.String, 4),
        new JdeField("SDSCNSL", "SDSCNSL", JdeDataType.String, 2),
        new JdeField("SDSMPSTS", "SDSMPSTS", JdeDataType.String, 6),
        new JdeField("SDDLAB", "SDDLAB", JdeDataType.Numeric),
        new JdeField("SDSMPMTHD", "SDSMPMTHD", JdeDataType.String, 20),
        new JdeField("SDSCUKID", "SDSCUKID", JdeDataType.Numeric),
        new JdeField("SDSMPCLSR", "SDSMPCLSR", JdeDataType.String, 20),
        new JdeField("SDNBRCNTR", "SDNBRCNTR", JdeDataType.Numeric),
        new JdeField("SDBQSSZ", "SDBQSSZ", JdeDataType.Numeric),
        new JdeField("SDQUM", "SDQUM", JdeDataType.String, 6),
        new JdeField("SDSMPLR", "SDSMPLR", JdeDataType.String, 20),
        new JdeField("SDUSMPDT", "SDUSMPDT", JdeDataType.Date),
        new JdeField("SDUSRQDT", "SDUSRQDT", JdeDataType.Date),
        new JdeField("SDWTBID", "SDWTBID", JdeDataType.Numeric),
        new JdeField("SDBNCHID", "SDBNCHID", JdeDataType.Numeric),
        new JdeField("SDCWLOTN", "SDCWLOTN", JdeDataType.String, 60),
        new JdeField("SDCWVID", "SDCWVID", JdeDataType.Numeric),
        new JdeField("SDCMCU", "SDCMCU", JdeDataType.String, 24),
        new JdeField("SDWMDT", "SDWMDT", JdeDataType.Numeric),
        new JdeField("SDWNUM", "SDWNUM", JdeDataType.Numeric),
        new JdeField("SDWAB", "SDWAB", JdeDataType.Numeric),
        new JdeField("SDWCD", "SDWCD", JdeDataType.String, 6),
        new JdeField("SDWRF", "SDWRF", JdeDataType.String, 60),
        new JdeField("SDURAT", "SDURAT", JdeDataType.Numeric),
        new JdeField("SDURCD", "SDURCD", JdeDataType.String, 4),
        new JdeField("SDURDT", "SDURDT", JdeDataType.Numeric),
        new JdeField("SDURRF", "SDURRF", JdeDataType.String, 30),
        new JdeField("SDURAB", "SDURAB", JdeDataType.Numeric),
        new JdeField("SDUSER", "SDUSER", JdeDataType.String, 20),
        new JdeField("SDPID", "SDPID", JdeDataType.String, 20),
        new JdeField("SDTDAY", "SDTDAY", JdeDataType.Numeric),
        new JdeField("SDUPMJ", "SDUPMJ", JdeDataType.Numeric),
        new JdeField("SDJOBN", "SDJOBN", JdeDataType.String, 20),
        new JdeField("SDWVTY", "SDWVTY", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3712_0", "Primary Key on SDBSNBR", new[] { "SDBSNBR" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3712_2", "Index on SDSCUKID", new[] { "SDSCUKID" }),
        new JdeIndex("F3712_3", "Index on SDWOPID, SDCWVID, SDCWLOTN", new[] { "SDWOPID", "SDCWVID", "SDCWLOTN" }),
        new JdeIndex("F3712_4", "Index on SDASNBR", new[] { "SDASNBR" })
    };
}
