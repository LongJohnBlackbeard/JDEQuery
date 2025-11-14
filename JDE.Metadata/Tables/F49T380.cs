using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49T380 - .
/// </summary>
public class F49T380 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SOORGN.
        /// </summary>
        public const string SOORGN = "SOORGN";

        /// <summary>
        /// SOSLN.
        /// </summary>
        public const string SOSLN = "SOSLN";

        /// <summary>
        /// SOOTBSHPN.
        /// </summary>
        public const string SOOTBSHPN = "SOOTBSHPN";

        /// <summary>
        /// SOOTDOMAIN.
        /// </summary>
        public const string SOOTDOMAIN = "SOOTDOMAIN";

        /// <summary>
        /// SOOTEQUNUM.
        /// </summary>
        public const string SOOTEQUNUM = "SOOTEQUNUM";

        /// <summary>
        /// SOADDJ.
        /// </summary>
        public const string SOADDJ = "SOADDJ";

        /// <summary>
        /// SOURCD.
        /// </summary>
        public const string SOURCD = "SOURCD";

        /// <summary>
        /// SOURDT.
        /// </summary>
        public const string SOURDT = "SOURDT";

        /// <summary>
        /// SOURAT.
        /// </summary>
        public const string SOURAT = "SOURAT";

        /// <summary>
        /// SOURAB.
        /// </summary>
        public const string SOURAB = "SOURAB";

        /// <summary>
        /// SOURRF.
        /// </summary>
        public const string SOURRF = "SOURRF";

        /// <summary>
        /// SOUSER.
        /// </summary>
        public const string SOUSER = "SOUSER";

        /// <summary>
        /// SOPID.
        /// </summary>
        public const string SOPID = "SOPID";

        /// <summary>
        /// SOJOBN.
        /// </summary>
        public const string SOJOBN = "SOJOBN";

        /// <summary>
        /// SOUUPMJ.
        /// </summary>
        public const string SOUUPMJ = "SOUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F49T380";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SOORGN", "SOORGN", JdeDataType.Numeric, null, true, true),
        new JdeField("SOSLN", "SOSLN", JdeDataType.Numeric, null, true, true),
        new JdeField("SOOTBSHPN", "SOOTBSHPN", JdeDataType.String, 100),
        new JdeField("SOOTDOMAIN", "SOOTDOMAIN", JdeDataType.String, 100),
        new JdeField("SOOTEQUNUM", "SOOTEQUNUM", JdeDataType.String, 100),
        new JdeField("SOADDJ", "SOADDJ", JdeDataType.Numeric),
        new JdeField("SOURCD", "SOURCD", JdeDataType.String, 4),
        new JdeField("SOURDT", "SOURDT", JdeDataType.Numeric),
        new JdeField("SOURAT", "SOURAT", JdeDataType.Numeric),
        new JdeField("SOURAB", "SOURAB", JdeDataType.Numeric),
        new JdeField("SOURRF", "SOURRF", JdeDataType.String, 30),
        new JdeField("SOUSER", "SOUSER", JdeDataType.String, 20),
        new JdeField("SOPID", "SOPID", JdeDataType.String, 20),
        new JdeField("SOJOBN", "SOJOBN", JdeDataType.String, 20),
        new JdeField("SOUUPMJ", "SOUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49T380_0", "Primary Key on SOORGN, SOSLN", new[] { "SOORGN", "SOSLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F49T380_2", "Index on SOOTBSHPN", new[] { "SOOTBSHPN" })
    };
}
