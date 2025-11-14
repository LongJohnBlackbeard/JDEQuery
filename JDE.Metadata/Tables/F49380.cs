using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49380 - .
/// </summary>
public class F49380 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SUORGN.
        /// </summary>
        public const string SUORGN = "SUORGN";

        /// <summary>
        /// SUSLN.
        /// </summary>
        public const string SUSLN = "SUSLN";

        /// <summary>
        /// SUVMCU.
        /// </summary>
        public const string SUVMCU = "SUVMCU";

        /// <summary>
        /// SULDNM.
        /// </summary>
        public const string SULDNM = "SULDNM";

        /// <summary>
        /// SUTRPL.
        /// </summary>
        public const string SUTRPL = "SUTRPL";

        /// <summary>
        /// SUSHPN.
        /// </summary>
        public const string SUSHPN = "SUSHPN";

        /// <summary>
        /// SUPVEH.
        /// </summary>
        public const string SUPVEH = "SUPVEH";

        /// <summary>
        /// SUADDJ.
        /// </summary>
        public const string SUADDJ = "SUADDJ";

        /// <summary>
        /// SUURCD.
        /// </summary>
        public const string SUURCD = "SUURCD";

        /// <summary>
        /// SUURDT.
        /// </summary>
        public const string SUURDT = "SUURDT";

        /// <summary>
        /// SUURAT.
        /// </summary>
        public const string SUURAT = "SUURAT";

        /// <summary>
        /// SUURAB.
        /// </summary>
        public const string SUURAB = "SUURAB";

        /// <summary>
        /// SUURRF.
        /// </summary>
        public const string SUURRF = "SUURRF";

        /// <summary>
        /// SUUSER.
        /// </summary>
        public const string SUUSER = "SUUSER";

        /// <summary>
        /// SUPID.
        /// </summary>
        public const string SUPID = "SUPID";

        /// <summary>
        /// SUJOBN.
        /// </summary>
        public const string SUJOBN = "SUJOBN";

        /// <summary>
        /// SUUPMJ.
        /// </summary>
        public const string SUUPMJ = "SUUPMJ";

        /// <summary>
        /// SUTDAY.
        /// </summary>
        public const string SUTDAY = "SUTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F49380";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SUORGN", "SUORGN", JdeDataType.Numeric, null, true, true),
        new JdeField("SUSLN", "SUSLN", JdeDataType.Numeric, null, true, true),
        new JdeField("SUVMCU", "SUVMCU", JdeDataType.String, 24),
        new JdeField("SULDNM", "SULDNM", JdeDataType.Numeric),
        new JdeField("SUTRPL", "SUTRPL", JdeDataType.Numeric),
        new JdeField("SUSHPN", "SUSHPN", JdeDataType.Numeric),
        new JdeField("SUPVEH", "SUPVEH", JdeDataType.String, 24),
        new JdeField("SUADDJ", "SUADDJ", JdeDataType.Numeric),
        new JdeField("SUURCD", "SUURCD", JdeDataType.String, 4),
        new JdeField("SUURDT", "SUURDT", JdeDataType.Numeric),
        new JdeField("SUURAT", "SUURAT", JdeDataType.Numeric),
        new JdeField("SUURAB", "SUURAB", JdeDataType.Numeric),
        new JdeField("SUURRF", "SUURRF", JdeDataType.String, 30),
        new JdeField("SUUSER", "SUUSER", JdeDataType.String, 20),
        new JdeField("SUPID", "SUPID", JdeDataType.String, 20),
        new JdeField("SUJOBN", "SUJOBN", JdeDataType.String, 20),
        new JdeField("SUUPMJ", "SUUPMJ", JdeDataType.Numeric),
        new JdeField("SUTDAY", "SUTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49380_0", "Primary Key on SUORGN, SUSLN", new[] { "SUORGN", "SUSLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F49380_2", "Index on SUVMCU, SULDNM, SUTRPL, SUSLN", new[] { "SUVMCU", "SULDNM", "SUTRPL", "SUSLN" }),
        new JdeIndex("F49380_3", "Index on SUVMCU, SULDNM, SUSLN", new[] { "SUVMCU", "SULDNM", "SUSLN" }),
        new JdeIndex("F49380_5", "Index on SUSHPN, SUSLN", new[] { "SUSHPN", "SUSLN" })
    };
}
