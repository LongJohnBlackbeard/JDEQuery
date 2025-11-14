using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0039 - .
/// </summary>
public class F0039 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GNGNDC.
        /// </summary>
        public const string GNGNDC = "GNGNDC";

        /// <summary>
        /// GNGNDT.
        /// </summary>
        public const string GNGNDT = "GNGNDT";

        /// <summary>
        /// GNBKMK.
        /// </summary>
        public const string GNBKMK = "GNBKMK";

        /// <summary>
        /// GNOSEQ.
        /// </summary>
        public const string GNOSEQ = "GNOSEQ";

        /// <summary>
        /// GNTOC.
        /// </summary>
        public const string GNTOC = "GNTOC";

        /// <summary>
        /// GNDLRP.
        /// </summary>
        public const string GNDLRP = "GNDLRP";

        /// <summary>
        /// GNTXSB.
        /// </summary>
        public const string GNTXSB = "GNTXSB";

        /// <summary>
        /// GNULNG.
        /// </summary>
        public const string GNULNG = "GNULNG";

        /// <summary>
        /// GNGN01.
        /// </summary>
        public const string GNGN01 = "GNGN01";

        /// <summary>
        /// GNMODS.
        /// </summary>
        public const string GNMODS = "GNMODS";

        /// <summary>
        /// GNPMFG.
        /// </summary>
        public const string GNPMFG = "GNPMFG";

        /// <summary>
        /// GNOLFG.
        /// </summary>
        public const string GNOLFG = "GNOLFG";

        /// <summary>
        /// GNCWIM.
        /// </summary>
        public const string GNCWIM = "GNCWIM";

        /// <summary>
        /// GNBGTG.
        /// </summary>
        public const string GNBGTG = "GNBGTG";

        /// <summary>
        /// GNEDTG.
        /// </summary>
        public const string GNEDTG = "GNEDTG";

        /// <summary>
        /// GNURCD.
        /// </summary>
        public const string GNURCD = "GNURCD";

        /// <summary>
        /// GNURDT.
        /// </summary>
        public const string GNURDT = "GNURDT";

        /// <summary>
        /// GNURAT.
        /// </summary>
        public const string GNURAT = "GNURAT";

        /// <summary>
        /// GNURAB.
        /// </summary>
        public const string GNURAB = "GNURAB";

        /// <summary>
        /// GNURRF.
        /// </summary>
        public const string GNURRF = "GNURRF";

        /// <summary>
        /// GNUSER.
        /// </summary>
        public const string GNUSER = "GNUSER";

        /// <summary>
        /// GNPID.
        /// </summary>
        public const string GNPID = "GNPID";

        /// <summary>
        /// GNJOBN.
        /// </summary>
        public const string GNJOBN = "GNJOBN";

        /// <summary>
        /// GNUPMJ.
        /// </summary>
        public const string GNUPMJ = "GNUPMJ";

        /// <summary>
        /// GNUPMT.
        /// </summary>
        public const string GNUPMT = "GNUPMT";

        /// <summary>
        /// GNPAFR.
        /// </summary>
        public const string GNPAFR = "GNPAFR";

        /// <summary>
        /// GNBPF2.
        /// </summary>
        public const string GNBPF2 = "GNBPF2";

        /// <summary>
        /// GNFCNM.
        /// </summary>
        public const string GNFCNM = "GNFCNM";
    }

    /// <inheritdoc />
    public override string TableName => "F0039";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GNGNDC", "GNGNDC", JdeDataType.String, 20, true, true),
        new JdeField("GNGNDT", "GNGNDT", JdeDataType.String, 4, true, true),
        new JdeField("GNBKMK", "GNBKMK", JdeDataType.String, 80, true, true),
        new JdeField("GNOSEQ", "GNOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("GNTOC", "GNTOC", JdeDataType.String, 2),
        new JdeField("GNDLRP", "GNDLRP", JdeDataType.String, 2),
        new JdeField("GNTXSB", "GNTXSB", JdeDataType.String, 2),
        new JdeField("GNULNG", "GNULNG", JdeDataType.String, 2),
        new JdeField("GNGN01", "GNGN01", JdeDataType.String, 20),
        new JdeField("GNMODS", "GNMODS", JdeDataType.String, 4),
        new JdeField("GNPMFG", "GNPMFG", JdeDataType.String, 2),
        new JdeField("GNOLFG", "GNOLFG", JdeDataType.String, 2),
        new JdeField("GNCWIM", "GNCWIM", JdeDataType.String, 2),
        new JdeField("GNBGTG", "GNBGTG", JdeDataType.String, 6),
        new JdeField("GNEDTG", "GNEDTG", JdeDataType.String, 6),
        new JdeField("GNURCD", "GNURCD", JdeDataType.String, 4),
        new JdeField("GNURDT", "GNURDT", JdeDataType.Numeric),
        new JdeField("GNURAT", "GNURAT", JdeDataType.Numeric),
        new JdeField("GNURAB", "GNURAB", JdeDataType.Numeric),
        new JdeField("GNURRF", "GNURRF", JdeDataType.String, 30),
        new JdeField("GNUSER", "GNUSER", JdeDataType.String, 20),
        new JdeField("GNPID", "GNPID", JdeDataType.String, 20),
        new JdeField("GNJOBN", "GNJOBN", JdeDataType.String, 20),
        new JdeField("GNUPMJ", "GNUPMJ", JdeDataType.Numeric),
        new JdeField("GNUPMT", "GNUPMT", JdeDataType.Numeric),
        new JdeField("GNPAFR", "GNPAFR", JdeDataType.String, 2),
        new JdeField("GNBPF2", "GNBPF2", JdeDataType.String, 6),
        new JdeField("GNFCNM", "GNFCNM", JdeDataType.String, 64)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0039_0", "Primary Key on GNGNDC, GNGNDT, GNBKMK, GNOSEQ", new[] { "GNGNDC", "GNGNDT", "GNBKMK", "GNOSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0039_2", "Index on GNGNDC, GNGNDT, GNDLRP, GNBPF2, GNBKMK, GNOSEQ", new[] { "GNGNDC", "GNGNDT", "GNDLRP", "GNBPF2", "GNBKMK", "GNOSEQ" })
    };
}
