using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74Y0101 - .
/// </summary>
public class F74Y0101 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RIAN8.
        /// </summary>
        public const string RIAN8 = "RIAN8";

        /// <summary>
        /// RIAD1I.
        /// </summary>
        public const string RIAD1I = "RIAD1I";

        /// <summary>
        /// RIAD2I.
        /// </summary>
        public const string RIAD2I = "RIAD2I";

        /// <summary>
        /// RISEX.
        /// </summary>
        public const string RISEX = "RISEX";

        /// <summary>
        /// RIDOB.
        /// </summary>
        public const string RIDOB = "RIDOB";

        /// <summary>
        /// RIIRLN.
        /// </summary>
        public const string RIIRLN = "RIIRLN";

        /// <summary>
        /// RIIRPN.
        /// </summary>
        public const string RIIRPN = "RIIRPN";

        /// <summary>
        /// RIURCD.
        /// </summary>
        public const string RIURCD = "RIURCD";

        /// <summary>
        /// RIURDT.
        /// </summary>
        public const string RIURDT = "RIURDT";

        /// <summary>
        /// RIURAT.
        /// </summary>
        public const string RIURAT = "RIURAT";

        /// <summary>
        /// RIURRF.
        /// </summary>
        public const string RIURRF = "RIURRF";

        /// <summary>
        /// RIUSER.
        /// </summary>
        public const string RIUSER = "RIUSER";

        /// <summary>
        /// RIPID.
        /// </summary>
        public const string RIPID = "RIPID";

        /// <summary>
        /// RIJOBN.
        /// </summary>
        public const string RIJOBN = "RIJOBN";

        /// <summary>
        /// RIUPMJ.
        /// </summary>
        public const string RIUPMJ = "RIUPMJ";

        /// <summary>
        /// RITDAY.
        /// </summary>
        public const string RITDAY = "RITDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F74Y0101";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RIAN8", "RIAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("RIAD1I", "RIAD1I", JdeDataType.String, 80),
        new JdeField("RIAD2I", "RIAD2I", JdeDataType.String, 80),
        new JdeField("RISEX", "RISEX", JdeDataType.String, 2),
        new JdeField("RIDOB", "RIDOB", JdeDataType.Numeric),
        new JdeField("RIIRLN", "RIIRLN", JdeDataType.String, 60),
        new JdeField("RIIRPN", "RIIRPN", JdeDataType.String, 6),
        new JdeField("RIURCD", "RIURCD", JdeDataType.String, 4),
        new JdeField("RIURDT", "RIURDT", JdeDataType.Numeric),
        new JdeField("RIURAT", "RIURAT", JdeDataType.Numeric),
        new JdeField("RIURRF", "RIURRF", JdeDataType.String, 30),
        new JdeField("RIUSER", "RIUSER", JdeDataType.String, 20),
        new JdeField("RIPID", "RIPID", JdeDataType.String, 20),
        new JdeField("RIJOBN", "RIJOBN", JdeDataType.String, 20),
        new JdeField("RIUPMJ", "RIUPMJ", JdeDataType.Numeric),
        new JdeField("RITDAY", "RITDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74Y0101_0", "Primary Key on RIAN8", new[] { "RIAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
