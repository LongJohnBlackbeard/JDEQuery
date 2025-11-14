using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4072 - .
/// </summary>
public class F4072 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ADAST.
        /// </summary>
        public const string ADAST = "ADAST";

        /// <summary>
        /// ADITM.
        /// </summary>
        public const string ADITM = "ADITM";

        /// <summary>
        /// ADLITM.
        /// </summary>
        public const string ADLITM = "ADLITM";

        /// <summary>
        /// ADAITM.
        /// </summary>
        public const string ADAITM = "ADAITM";

        /// <summary>
        /// ADAN8.
        /// </summary>
        public const string ADAN8 = "ADAN8";

        /// <summary>
        /// ADIGID.
        /// </summary>
        public const string ADIGID = "ADIGID";

        /// <summary>
        /// ADCGID.
        /// </summary>
        public const string ADCGID = "ADCGID";

        /// <summary>
        /// ADOGID.
        /// </summary>
        public const string ADOGID = "ADOGID";

        /// <summary>
        /// ADCRCD.
        /// </summary>
        public const string ADCRCD = "ADCRCD";

        /// <summary>
        /// ADUOM.
        /// </summary>
        public const string ADUOM = "ADUOM";

        /// <summary>
        /// ADMNQ.
        /// </summary>
        public const string ADMNQ = "ADMNQ";

        /// <summary>
        /// ADEFTJ.
        /// </summary>
        public const string ADEFTJ = "ADEFTJ";

        /// <summary>
        /// ADEXDJ.
        /// </summary>
        public const string ADEXDJ = "ADEXDJ";

        /// <summary>
        /// ADBSCD.
        /// </summary>
        public const string ADBSCD = "ADBSCD";

        /// <summary>
        /// ADLEDG.
        /// </summary>
        public const string ADLEDG = "ADLEDG";

        /// <summary>
        /// ADFRMN.
        /// </summary>
        public const string ADFRMN = "ADFRMN";

        /// <summary>
        /// ADFVTR.
        /// </summary>
        public const string ADFVTR = "ADFVTR";

        /// <summary>
        /// ADFGY.
        /// </summary>
        public const string ADFGY = "ADFGY";

        /// <summary>
        /// ADATID.
        /// </summary>
        public const string ADATID = "ADATID";

        /// <summary>
        /// ADURCD.
        /// </summary>
        public const string ADURCD = "ADURCD";

        /// <summary>
        /// ADURDT.
        /// </summary>
        public const string ADURDT = "ADURDT";

        /// <summary>
        /// ADURAT.
        /// </summary>
        public const string ADURAT = "ADURAT";

        /// <summary>
        /// ADURAB.
        /// </summary>
        public const string ADURAB = "ADURAB";

        /// <summary>
        /// ADURRF.
        /// </summary>
        public const string ADURRF = "ADURRF";

        /// <summary>
        /// ADNBRORD.
        /// </summary>
        public const string ADNBRORD = "ADNBRORD";

        /// <summary>
        /// ADUOMVID.
        /// </summary>
        public const string ADUOMVID = "ADUOMVID";

        /// <summary>
        /// ADFVUM.
        /// </summary>
        public const string ADFVUM = "ADFVUM";

        /// <summary>
        /// ADPARTFG.
        /// </summary>
        public const string ADPARTFG = "ADPARTFG";

        /// <summary>
        /// ADAPRS.
        /// </summary>
        public const string ADAPRS = "ADAPRS";

        /// <summary>
        /// ADUSER.
        /// </summary>
        public const string ADUSER = "ADUSER";

        /// <summary>
        /// ADPID.
        /// </summary>
        public const string ADPID = "ADPID";

        /// <summary>
        /// ADJOBN.
        /// </summary>
        public const string ADJOBN = "ADJOBN";

        /// <summary>
        /// ADUPMJ.
        /// </summary>
        public const string ADUPMJ = "ADUPMJ";

        /// <summary>
        /// ADTDAY.
        /// </summary>
        public const string ADTDAY = "ADTDAY";

        /// <summary>
        /// ADBKTPID.
        /// </summary>
        public const string ADBKTPID = "ADBKTPID";

        /// <summary>
        /// ADCRCDVID.
        /// </summary>
        public const string ADCRCDVID = "ADCRCDVID";

        /// <summary>
        /// ADRULENAME.
        /// </summary>
        public const string ADRULENAME = "ADRULENAME";
    }

    /// <inheritdoc />
    public override string TableName => "F4072";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ADAST", "ADAST", JdeDataType.String, 16, true, true),
        new JdeField("ADITM", "ADITM", JdeDataType.Numeric, null, true, true),
        new JdeField("ADLITM", "ADLITM", JdeDataType.String, 50),
        new JdeField("ADAITM", "ADAITM", JdeDataType.String, 50),
        new JdeField("ADAN8", "ADAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ADIGID", "ADIGID", JdeDataType.Numeric, null, true, true),
        new JdeField("ADCGID", "ADCGID", JdeDataType.Numeric, null, true, true),
        new JdeField("ADOGID", "ADOGID", JdeDataType.Numeric, null, true, true),
        new JdeField("ADCRCD", "ADCRCD", JdeDataType.String, 6, true, true),
        new JdeField("ADUOM", "ADUOM", JdeDataType.String, 4, true, true),
        new JdeField("ADMNQ", "ADMNQ", JdeDataType.Numeric, null, true, true),
        new JdeField("ADEFTJ", "ADEFTJ", JdeDataType.Numeric),
        new JdeField("ADEXDJ", "ADEXDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("ADBSCD", "ADBSCD", JdeDataType.String, 2),
        new JdeField("ADLEDG", "ADLEDG", JdeDataType.String, 4),
        new JdeField("ADFRMN", "ADFRMN", JdeDataType.String, 20),
        new JdeField("ADFVTR", "ADFVTR", JdeDataType.Numeric),
        new JdeField("ADFGY", "ADFGY", JdeDataType.String, 2),
        new JdeField("ADATID", "ADATID", JdeDataType.Numeric),
        new JdeField("ADURCD", "ADURCD", JdeDataType.String, 4),
        new JdeField("ADURDT", "ADURDT", JdeDataType.Numeric),
        new JdeField("ADURAT", "ADURAT", JdeDataType.Numeric),
        new JdeField("ADURAB", "ADURAB", JdeDataType.Numeric),
        new JdeField("ADURRF", "ADURRF", JdeDataType.String, 30),
        new JdeField("ADNBRORD", "ADNBRORD", JdeDataType.Numeric),
        new JdeField("ADUOMVID", "ADUOMVID", JdeDataType.String, 4),
        new JdeField("ADFVUM", "ADFVUM", JdeDataType.String, 4),
        new JdeField("ADPARTFG", "ADPARTFG", JdeDataType.String, 2),
        new JdeField("ADAPRS", "ADAPRS", JdeDataType.String, 2),
        new JdeField("ADUSER", "ADUSER", JdeDataType.String, 20),
        new JdeField("ADPID", "ADPID", JdeDataType.String, 20),
        new JdeField("ADJOBN", "ADJOBN", JdeDataType.String, 20),
        new JdeField("ADUPMJ", "ADUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("ADTDAY", "ADTDAY", JdeDataType.Numeric, null, true, true),
        new JdeField("ADBKTPID", "ADBKTPID", JdeDataType.Numeric),
        new JdeField("ADCRCDVID", "ADCRCDVID", JdeDataType.String, 6),
        new JdeField("ADRULENAME", "ADRULENAME", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4072_0", "Primary Key on ADITM, ADAST, ADAN8, ADIGID, ADCGID, ADOGID, ADCRCD, ADUOM, ADMNQ, ADEXDJ, ADUPMJ, ADTDAY", new[] { "ADITM", "ADAST", "ADAN8", "ADIGID", "ADCGID", "ADOGID", "ADCRCD", "ADUOM", "ADMNQ", "ADEXDJ", "ADUPMJ", "ADTDAY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4072_2", "Index on ADAST, ADITM, ADCRCD, ADUOM, ADMNQ, ADEXDJ, ADIGID, ADCGID", new[] { "ADAST", "ADITM", "ADCRCD", "ADUOM", "ADMNQ", "ADEXDJ", "ADIGID", "ADCGID" }),
        new JdeIndex("F4072_3", "Index on ADAST, ADATID", new[] { "ADAST", "ADATID" }),
        new JdeIndex("F4072_4", "Index on ADAST, ADITM, ADAN8, ADIGID, ADOGID, ADCGID, ADCRCD, ADUOM, SYS_NC00038$, ADEXDJ", new[] { "ADAST", "ADITM", "ADAN8", "ADIGID", "ADOGID", "ADCGID", "ADCRCD", "ADUOM", "SYS_NC00038$", "ADEXDJ" }),
        new JdeIndex("F4072_5", "Index on ADAST, ADITM, ADAN8, ADIGID, ADCGID, ADOGID, ADCRCD, ADUOM, ADMNQ, ADEXDJ, ADPID", new[] { "ADAST", "ADITM", "ADAN8", "ADIGID", "ADCGID", "ADOGID", "ADCRCD", "ADUOM", "ADMNQ", "ADEXDJ", "ADPID" }),
        new JdeIndex("F4072_6", "Index on ADBKTPID, SYS_NC00038$", new[] { "ADBKTPID", "SYS_NC00038$" }),
        new JdeIndex("F4072_7", "Index on ADAN8", new[] { "ADAN8" })
    };
}
