using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW11 - .
/// </summary>
public class FCW11 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WPITM.
        /// </summary>
        public const string WPITM = "WPITM";

        /// <summary>
        /// WPEV01.
        /// </summary>
        public const string WPEV01 = "WPEV01";

        /// <summary>
        /// WPMCU.
        /// </summary>
        public const string WPMCU = "WPMCU";

        /// <summary>
        /// WPLOCN.
        /// </summary>
        public const string WPLOCN = "WPLOCN";

        /// <summary>
        /// WPLOTN.
        /// </summary>
        public const string WPLOTN = "WPLOTN";

        /// <summary>
        /// WPAN8.
        /// </summary>
        public const string WPAN8 = "WPAN8";

        /// <summary>
        /// WPIGID.
        /// </summary>
        public const string WPIGID = "WPIGID";

        /// <summary>
        /// WPCGID.
        /// </summary>
        public const string WPCGID = "WPCGID";

        /// <summary>
        /// WPLOTG.
        /// </summary>
        public const string WPLOTG = "WPLOTG";

        /// <summary>
        /// WPFRMP.
        /// </summary>
        public const string WPFRMP = "WPFRMP";

        /// <summary>
        /// WPCRCD.
        /// </summary>
        public const string WPCRCD = "WPCRCD";

        /// <summary>
        /// WPUOM.
        /// </summary>
        public const string WPUOM = "WPUOM";

        /// <summary>
        /// WPEFTJ.
        /// </summary>
        public const string WPEFTJ = "WPEFTJ";

        /// <summary>
        /// WPEXDJ.
        /// </summary>
        public const string WPEXDJ = "WPEXDJ";

        /// <summary>
        /// WPUPRC.
        /// </summary>
        public const string WPUPRC = "WPUPRC";

        /// <summary>
        /// WPACRD.
        /// </summary>
        public const string WPACRD = "WPACRD";

        /// <summary>
        /// WPBSCD.
        /// </summary>
        public const string WPBSCD = "WPBSCD";

        /// <summary>
        /// WPLEDG.
        /// </summary>
        public const string WPLEDG = "WPLEDG";

        /// <summary>
        /// WPFVTR.
        /// </summary>
        public const string WPFVTR = "WPFVTR";

        /// <summary>
        /// WPFRMN.
        /// </summary>
        public const string WPFRMN = "WPFRMN";

        /// <summary>
        /// WPURCD.
        /// </summary>
        public const string WPURCD = "WPURCD";

        /// <summary>
        /// WPURDT.
        /// </summary>
        public const string WPURDT = "WPURDT";

        /// <summary>
        /// WPURAT.
        /// </summary>
        public const string WPURAT = "WPURAT";

        /// <summary>
        /// WPURAB.
        /// </summary>
        public const string WPURAB = "WPURAB";

        /// <summary>
        /// WPURRF.
        /// </summary>
        public const string WPURRF = "WPURRF";

        /// <summary>
        /// WPUPMJ.
        /// </summary>
        public const string WPUPMJ = "WPUPMJ";

        /// <summary>
        /// WPTDAY.
        /// </summary>
        public const string WPTDAY = "WPTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "FCW11";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WPITM", "WPITM", JdeDataType.Numeric, null, true, true),
        new JdeField("WPEV01", "WPEV01", JdeDataType.String, 2, true, true),
        new JdeField("WPMCU", "WPMCU", JdeDataType.String, 24, true, true),
        new JdeField("WPLOCN", "WPLOCN", JdeDataType.String, 40, true, true),
        new JdeField("WPLOTN", "WPLOTN", JdeDataType.String, 60, true, true),
        new JdeField("WPAN8", "WPAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("WPIGID", "WPIGID", JdeDataType.Numeric, null, true, true),
        new JdeField("WPCGID", "WPCGID", JdeDataType.Numeric, null, true, true),
        new JdeField("WPLOTG", "WPLOTG", JdeDataType.String, 6, true, true),
        new JdeField("WPFRMP", "WPFRMP", JdeDataType.Numeric, null, true, true),
        new JdeField("WPCRCD", "WPCRCD", JdeDataType.String, 6, true, true),
        new JdeField("WPUOM", "WPUOM", JdeDataType.String, 4, true, true),
        new JdeField("WPEFTJ", "WPEFTJ", JdeDataType.Numeric),
        new JdeField("WPEXDJ", "WPEXDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("WPUPRC", "WPUPRC", JdeDataType.Numeric),
        new JdeField("WPACRD", "WPACRD", JdeDataType.Numeric),
        new JdeField("WPBSCD", "WPBSCD", JdeDataType.String, 2),
        new JdeField("WPLEDG", "WPLEDG", JdeDataType.String, 4),
        new JdeField("WPFVTR", "WPFVTR", JdeDataType.Numeric),
        new JdeField("WPFRMN", "WPFRMN", JdeDataType.String, 20),
        new JdeField("WPURCD", "WPURCD", JdeDataType.String, 4),
        new JdeField("WPURDT", "WPURDT", JdeDataType.Numeric),
        new JdeField("WPURAT", "WPURAT", JdeDataType.Numeric),
        new JdeField("WPURAB", "WPURAB", JdeDataType.Numeric),
        new JdeField("WPURRF", "WPURRF", JdeDataType.String, 30),
        new JdeField("WPUPMJ", "WPUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("WPTDAY", "WPTDAY", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW11_0", "Primary Key on WPITM, WPEV01, WPMCU, WPLOCN, WPLOTN, WPAN8, WPIGID, WPCGID, WPLOTG, WPFRMP, WPCRCD, WPUOM, WPEXDJ, WPUPMJ, WPTDAY", new[] { "WPITM", "WPEV01", "WPMCU", "WPLOCN", "WPLOTN", "WPAN8", "WPIGID", "WPCGID", "WPLOTG", "WPFRMP", "WPCRCD", "WPUOM", "WPEXDJ", "WPUPMJ", "WPTDAY" }, isUnique: true, isPrimaryKey: true)
    };
}
