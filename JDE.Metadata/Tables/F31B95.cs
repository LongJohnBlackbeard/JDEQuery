using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B95 - .
/// </summary>
public class F31B95 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OVWCFGID.
        /// </summary>
        public const string OVWCFGID = "OVWCFGID";

        /// <summary>
        /// OVTSTRSNM.
        /// </summary>
        public const string OVTSTRSNM = "OVTSTRSNM";

        /// <summary>
        /// OVQABLRUL.
        /// </summary>
        public const string OVQABLRUL = "OVQABLRUL";

        /// <summary>
        /// OVQARMVF.
        /// </summary>
        public const string OVQARMVF = "OVQARMVF";

        /// <summary>
        /// OVURCD.
        /// </summary>
        public const string OVURCD = "OVURCD";

        /// <summary>
        /// OVURAT.
        /// </summary>
        public const string OVURAT = "OVURAT";

        /// <summary>
        /// OVURRF.
        /// </summary>
        public const string OVURRF = "OVURRF";

        /// <summary>
        /// OVURAB.
        /// </summary>
        public const string OVURAB = "OVURAB";

        /// <summary>
        /// OVURDT.
        /// </summary>
        public const string OVURDT = "OVURDT";

        /// <summary>
        /// OVUSER.
        /// </summary>
        public const string OVUSER = "OVUSER";

        /// <summary>
        /// OVPID.
        /// </summary>
        public const string OVPID = "OVPID";

        /// <summary>
        /// OVUPMJ.
        /// </summary>
        public const string OVUPMJ = "OVUPMJ";

        /// <summary>
        /// OVTDAY.
        /// </summary>
        public const string OVTDAY = "OVTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F31B95";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OVWCFGID", "OVWCFGID", JdeDataType.Numeric, null, true, true),
        new JdeField("OVTSTRSNM", "OVTSTRSNM", JdeDataType.String, 60, true, true),
        new JdeField("OVQABLRUL", "OVQABLRUL", JdeDataType.String, 10),
        new JdeField("OVQARMVF", "OVQARMVF", JdeDataType.String, 2),
        new JdeField("OVURCD", "OVURCD", JdeDataType.String, 4),
        new JdeField("OVURAT", "OVURAT", JdeDataType.Numeric),
        new JdeField("OVURRF", "OVURRF", JdeDataType.String, 30),
        new JdeField("OVURAB", "OVURAB", JdeDataType.Numeric),
        new JdeField("OVURDT", "OVURDT", JdeDataType.Numeric),
        new JdeField("OVUSER", "OVUSER", JdeDataType.String, 20),
        new JdeField("OVPID", "OVPID", JdeDataType.String, 20),
        new JdeField("OVUPMJ", "OVUPMJ", JdeDataType.Numeric),
        new JdeField("OVTDAY", "OVTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B95_0", "Primary Key on OVWCFGID, OVTSTRSNM", new[] { "OVWCFGID", "OVTSTRSNM" }, isUnique: true, isPrimaryKey: true)
    };
}
