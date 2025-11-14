using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B0750 - .
/// </summary>
public class F31B0750 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OFEURID.
        /// </summary>
        public const string OFEURID = "OFEURID";

        /// <summary>
        /// OFWISSC.
        /// </summary>
        public const string OFWISSC = "OFWISSC";

        /// <summary>
        /// OFOPVYN.
        /// </summary>
        public const string OFOPVYN = "OFOPVYN";

        /// <summary>
        /// OFURAB.
        /// </summary>
        public const string OFURAB = "OFURAB";

        /// <summary>
        /// OFURAT.
        /// </summary>
        public const string OFURAT = "OFURAT";

        /// <summary>
        /// OFURCD.
        /// </summary>
        public const string OFURCD = "OFURCD";

        /// <summary>
        /// OFURDT.
        /// </summary>
        public const string OFURDT = "OFURDT";

        /// <summary>
        /// OFURRF.
        /// </summary>
        public const string OFURRF = "OFURRF";

        /// <summary>
        /// OFJOBN.
        /// </summary>
        public const string OFJOBN = "OFJOBN";

        /// <summary>
        /// OFPID.
        /// </summary>
        public const string OFPID = "OFPID";

        /// <summary>
        /// OFTDAY.
        /// </summary>
        public const string OFTDAY = "OFTDAY";

        /// <summary>
        /// OFUPMJ.
        /// </summary>
        public const string OFUPMJ = "OFUPMJ";

        /// <summary>
        /// OFUSER.
        /// </summary>
        public const string OFUSER = "OFUSER";

        /// <summary>
        /// OFWAB.
        /// </summary>
        public const string OFWAB = "OFWAB";

        /// <summary>
        /// OFWCD.
        /// </summary>
        public const string OFWCD = "OFWCD";

        /// <summary>
        /// OFWMDT.
        /// </summary>
        public const string OFWMDT = "OFWMDT";

        /// <summary>
        /// OFWNUM.
        /// </summary>
        public const string OFWNUM = "OFWNUM";

        /// <summary>
        /// OFWRF.
        /// </summary>
        public const string OFWRF = "OFWRF";
    }

    /// <inheritdoc />
    public override string TableName => "F31B0750";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OFEURID", "OFEURID", JdeDataType.Numeric, null, true, true),
        new JdeField("OFWISSC", "OFWISSC", JdeDataType.String, 12, true, true),
        new JdeField("OFOPVYN", "OFOPVYN", JdeDataType.String, 2),
        new JdeField("OFURAB", "OFURAB", JdeDataType.Numeric),
        new JdeField("OFURAT", "OFURAT", JdeDataType.Numeric),
        new JdeField("OFURCD", "OFURCD", JdeDataType.String, 4),
        new JdeField("OFURDT", "OFURDT", JdeDataType.Numeric),
        new JdeField("OFURRF", "OFURRF", JdeDataType.String, 30),
        new JdeField("OFJOBN", "OFJOBN", JdeDataType.String, 20),
        new JdeField("OFPID", "OFPID", JdeDataType.String, 20),
        new JdeField("OFTDAY", "OFTDAY", JdeDataType.Numeric),
        new JdeField("OFUPMJ", "OFUPMJ", JdeDataType.Numeric),
        new JdeField("OFUSER", "OFUSER", JdeDataType.String, 20),
        new JdeField("OFWAB", "OFWAB", JdeDataType.Numeric),
        new JdeField("OFWCD", "OFWCD", JdeDataType.String, 6),
        new JdeField("OFWMDT", "OFWMDT", JdeDataType.Numeric),
        new JdeField("OFWNUM", "OFWNUM", JdeDataType.Numeric),
        new JdeField("OFWRF", "OFWRF", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B0750_0", "Primary Key on OFEURID, OFWISSC", new[] { "OFEURID", "OFWISSC" }, isUnique: true, isPrimaryKey: true)
    };
}
