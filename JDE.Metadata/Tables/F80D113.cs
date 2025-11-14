using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D113 - .
/// </summary>
public class F80D113 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PMPRCSID.
        /// </summary>
        public const string PMPRCSID = "PMPRCSID";

        /// <summary>
        /// PMDESCPR.
        /// </summary>
        public const string PMDESCPR = "PMDESCPR";

        /// <summary>
        /// PMEFSTDT.
        /// </summary>
        public const string PMEFSTDT = "PMEFSTDT";

        /// <summary>
        /// PMEFEDDT.
        /// </summary>
        public const string PMEFEDDT = "PMEFEDDT";

        /// <summary>
        /// PMSTFLG.
        /// </summary>
        public const string PMSTFLG = "PMSTFLG";

        /// <summary>
        /// PMOSTP.
        /// </summary>
        public const string PMOSTP = "PMOSTP";

        /// <summary>
        /// PMPA8.
        /// </summary>
        public const string PMPA8 = "PMPA8";

        /// <summary>
        /// PMROFLG.
        /// </summary>
        public const string PMROFLG = "PMROFLG";

        /// <summary>
        /// PMDTCRTD.
        /// </summary>
        public const string PMDTCRTD = "PMDTCRTD";

        /// <summary>
        /// PMUSER.
        /// </summary>
        public const string PMUSER = "PMUSER";

        /// <summary>
        /// PMPID.
        /// </summary>
        public const string PMPID = "PMPID";

        /// <summary>
        /// PMMKEY.
        /// </summary>
        public const string PMMKEY = "PMMKEY";

        /// <summary>
        /// PMUTIME.
        /// </summary>
        public const string PMUTIME = "PMUTIME";

        /// <summary>
        /// PMURCD.
        /// </summary>
        public const string PMURCD = "PMURCD";

        /// <summary>
        /// PMURDT.
        /// </summary>
        public const string PMURDT = "PMURDT";

        /// <summary>
        /// PMURAB.
        /// </summary>
        public const string PMURAB = "PMURAB";

        /// <summary>
        /// PMURRF.
        /// </summary>
        public const string PMURRF = "PMURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F80D113";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PMPRCSID", "PMPRCSID", JdeDataType.String, 40, true, true),
        new JdeField("PMDESCPR", "PMDESCPR", JdeDataType.String, 60),
        new JdeField("PMEFSTDT", "PMEFSTDT", JdeDataType.Numeric),
        new JdeField("PMEFEDDT", "PMEFEDDT", JdeDataType.Numeric),
        new JdeField("PMSTFLG", "PMSTFLG", JdeDataType.String, 2),
        new JdeField("PMOSTP", "PMOSTP", JdeDataType.String, 6),
        new JdeField("PMPA8", "PMPA8", JdeDataType.Numeric),
        new JdeField("PMROFLG", "PMROFLG", JdeDataType.String, 2),
        new JdeField("PMDTCRTD", "PMDTCRTD", JdeDataType.Numeric),
        new JdeField("PMUSER", "PMUSER", JdeDataType.String, 20),
        new JdeField("PMPID", "PMPID", JdeDataType.String, 20),
        new JdeField("PMMKEY", "PMMKEY", JdeDataType.String, 30),
        new JdeField("PMUTIME", "PMUTIME", JdeDataType.Date),
        new JdeField("PMURCD", "PMURCD", JdeDataType.String, 4),
        new JdeField("PMURDT", "PMURDT", JdeDataType.Numeric),
        new JdeField("PMURAB", "PMURAB", JdeDataType.Numeric),
        new JdeField("PMURRF", "PMURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D113_0", "Primary Key on PMPRCSID", new[] { "PMPRCSID" }, isUnique: true, isPrimaryKey: true)
    };
}
