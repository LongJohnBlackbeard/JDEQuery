using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F54R021 - .
/// </summary>
public class F54R021 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AA54RAN.
        /// </summary>
        public const string AA54RAN = "AA54RAN";

        /// <summary>
        /// AAMCU.
        /// </summary>
        public const string AAMCU = "AAMCU";

        /// <summary>
        /// AA54RCLS.
        /// </summary>
        public const string AA54RCLS = "AA54RCLS";

        /// <summary>
        /// AA54RUCYN.
        /// </summary>
        public const string AA54RUCYN = "AA54RUCYN";

        /// <summary>
        /// AAUSER.
        /// </summary>
        public const string AAUSER = "AAUSER";

        /// <summary>
        /// AAPID.
        /// </summary>
        public const string AAPID = "AAPID";

        /// <summary>
        /// AAUPMJ.
        /// </summary>
        public const string AAUPMJ = "AAUPMJ";

        /// <summary>
        /// AAUPMT.
        /// </summary>
        public const string AAUPMT = "AAUPMT";

        /// <summary>
        /// AAJOBN.
        /// </summary>
        public const string AAJOBN = "AAJOBN";

        /// <summary>
        /// AAMKEY.
        /// </summary>
        public const string AAMKEY = "AAMKEY";

        /// <summary>
        /// AAURCD.
        /// </summary>
        public const string AAURCD = "AAURCD";

        /// <summary>
        /// AAURDT.
        /// </summary>
        public const string AAURDT = "AAURDT";

        /// <summary>
        /// AAURAT.
        /// </summary>
        public const string AAURAT = "AAURAT";

        /// <summary>
        /// AAURAB.
        /// </summary>
        public const string AAURAB = "AAURAB";

        /// <summary>
        /// AAURRF.
        /// </summary>
        public const string AAURRF = "AAURRF";

        /// <summary>
        /// AAENTJ.
        /// </summary>
        public const string AAENTJ = "AAENTJ";

        /// <summary>
        /// AATORG.
        /// </summary>
        public const string AATORG = "AATORG";

        /// <summary>
        /// AATENT.
        /// </summary>
        public const string AATENT = "AATENT";

        /// <summary>
        /// AA54RDD00.
        /// </summary>
        public const string AA54RDD00 = "AA54RDD00";

        /// <summary>
        /// AA54RDD01.
        /// </summary>
        public const string AA54RDD01 = "AA54RDD01";

        /// <summary>
        /// AA54RDD02.
        /// </summary>
        public const string AA54RDD02 = "AA54RDD02";

        /// <summary>
        /// AA54RDD03.
        /// </summary>
        public const string AA54RDD03 = "AA54RDD03";

        /// <summary>
        /// AA54RDD04.
        /// </summary>
        public const string AA54RDD04 = "AA54RDD04";

        /// <summary>
        /// AA54RDD05.
        /// </summary>
        public const string AA54RDD05 = "AA54RDD05";

        /// <summary>
        /// AA54RDD06.
        /// </summary>
        public const string AA54RDD06 = "AA54RDD06";

        /// <summary>
        /// AA54RDD07.
        /// </summary>
        public const string AA54RDD07 = "AA54RDD07";

        /// <summary>
        /// AA54RDD08.
        /// </summary>
        public const string AA54RDD08 = "AA54RDD08";

        /// <summary>
        /// AA54RDD09.
        /// </summary>
        public const string AA54RDD09 = "AA54RDD09";

        /// <summary>
        /// AA54RDD10.
        /// </summary>
        public const string AA54RDD10 = "AA54RDD10";

        /// <summary>
        /// AA54RDD11.
        /// </summary>
        public const string AA54RDD11 = "AA54RDD11";

        /// <summary>
        /// AA54RDD12.
        /// </summary>
        public const string AA54RDD12 = "AA54RDD12";

        /// <summary>
        /// AA54RDD13.
        /// </summary>
        public const string AA54RDD13 = "AA54RDD13";

        /// <summary>
        /// AA54RDD14.
        /// </summary>
        public const string AA54RDD14 = "AA54RDD14";

        /// <summary>
        /// AA54RDD15.
        /// </summary>
        public const string AA54RDD15 = "AA54RDD15";

        /// <summary>
        /// AA54RDD16.
        /// </summary>
        public const string AA54RDD16 = "AA54RDD16";
    }

    /// <inheritdoc />
    public override string TableName => "F54R021";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AA54RAN", "AA54RAN", JdeDataType.Numeric, null, true, true),
        new JdeField("AAMCU", "AAMCU", JdeDataType.String, 24, true, true),
        new JdeField("AA54RCLS", "AA54RCLS", JdeDataType.String, 6),
        new JdeField("AA54RUCYN", "AA54RUCYN", JdeDataType.String, 2),
        new JdeField("AAUSER", "AAUSER", JdeDataType.String, 20),
        new JdeField("AAPID", "AAPID", JdeDataType.String, 20),
        new JdeField("AAUPMJ", "AAUPMJ", JdeDataType.Numeric),
        new JdeField("AAUPMT", "AAUPMT", JdeDataType.Numeric),
        new JdeField("AAJOBN", "AAJOBN", JdeDataType.String, 20),
        new JdeField("AAMKEY", "AAMKEY", JdeDataType.String, 30),
        new JdeField("AAURCD", "AAURCD", JdeDataType.String, 4),
        new JdeField("AAURDT", "AAURDT", JdeDataType.Numeric),
        new JdeField("AAURAT", "AAURAT", JdeDataType.Numeric),
        new JdeField("AAURAB", "AAURAB", JdeDataType.Numeric),
        new JdeField("AAURRF", "AAURRF", JdeDataType.String, 30),
        new JdeField("AAENTJ", "AAENTJ", JdeDataType.Numeric),
        new JdeField("AATORG", "AATORG", JdeDataType.String, 20),
        new JdeField("AATENT", "AATENT", JdeDataType.Numeric),
        new JdeField("AA54RDD00", "AA54RDD00", JdeDataType.String, 4),
        new JdeField("AA54RDD01", "AA54RDD01", JdeDataType.String, 4),
        new JdeField("AA54RDD02", "AA54RDD02", JdeDataType.String, 4),
        new JdeField("AA54RDD03", "AA54RDD03", JdeDataType.String, 4),
        new JdeField("AA54RDD04", "AA54RDD04", JdeDataType.String, 4),
        new JdeField("AA54RDD05", "AA54RDD05", JdeDataType.String, 4),
        new JdeField("AA54RDD06", "AA54RDD06", JdeDataType.String, 4),
        new JdeField("AA54RDD07", "AA54RDD07", JdeDataType.String, 4),
        new JdeField("AA54RDD08", "AA54RDD08", JdeDataType.String, 4),
        new JdeField("AA54RDD09", "AA54RDD09", JdeDataType.String, 4),
        new JdeField("AA54RDD10", "AA54RDD10", JdeDataType.String, 4),
        new JdeField("AA54RDD11", "AA54RDD11", JdeDataType.String, 4),
        new JdeField("AA54RDD12", "AA54RDD12", JdeDataType.String, 4),
        new JdeField("AA54RDD13", "AA54RDD13", JdeDataType.String, 4),
        new JdeField("AA54RDD14", "AA54RDD14", JdeDataType.String, 4),
        new JdeField("AA54RDD15", "AA54RDD15", JdeDataType.String, 4),
        new JdeField("AA54RDD16", "AA54RDD16", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F54R021_0", "Primary Key on AA54RAN, AAMCU", new[] { "AA54RAN", "AAMCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F54R021_2", "Index on AA54RAN", new[] { "AA54RAN" })
    };
}
