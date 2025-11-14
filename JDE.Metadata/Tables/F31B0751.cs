using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B0751 - .
/// </summary>
public class F31B0751 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OLEURID.
        /// </summary>
        public const string OLEURID = "OLEURID";

        /// <summary>
        /// OLWISSC.
        /// </summary>
        public const string OLWISSC = "OLWISSC";

        /// <summary>
        /// OLSEQNUMB.
        /// </summary>
        public const string OLSEQNUMB = "OLSEQNUMB";

        /// <summary>
        /// OLWCFGID.
        /// </summary>
        public const string OLWCFGID = "OLWCFGID";

        /// <summary>
        /// OLURAB.
        /// </summary>
        public const string OLURAB = "OLURAB";

        /// <summary>
        /// OLURAT.
        /// </summary>
        public const string OLURAT = "OLURAT";

        /// <summary>
        /// OLURCD.
        /// </summary>
        public const string OLURCD = "OLURCD";

        /// <summary>
        /// OLURDT.
        /// </summary>
        public const string OLURDT = "OLURDT";

        /// <summary>
        /// OLURRF.
        /// </summary>
        public const string OLURRF = "OLURRF";

        /// <summary>
        /// OLJOBN.
        /// </summary>
        public const string OLJOBN = "OLJOBN";

        /// <summary>
        /// OLPID.
        /// </summary>
        public const string OLPID = "OLPID";

        /// <summary>
        /// OLTDAY.
        /// </summary>
        public const string OLTDAY = "OLTDAY";

        /// <summary>
        /// OLUPMJ.
        /// </summary>
        public const string OLUPMJ = "OLUPMJ";

        /// <summary>
        /// OLUSER.
        /// </summary>
        public const string OLUSER = "OLUSER";

        /// <summary>
        /// OLWAB.
        /// </summary>
        public const string OLWAB = "OLWAB";

        /// <summary>
        /// OLWCD.
        /// </summary>
        public const string OLWCD = "OLWCD";

        /// <summary>
        /// OLWMDT.
        /// </summary>
        public const string OLWMDT = "OLWMDT";

        /// <summary>
        /// OLWNUM.
        /// </summary>
        public const string OLWNUM = "OLWNUM";

        /// <summary>
        /// OLWRF.
        /// </summary>
        public const string OLWRF = "OLWRF";
    }

    /// <inheritdoc />
    public override string TableName => "F31B0751";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OLEURID", "OLEURID", JdeDataType.Numeric, null, true, true),
        new JdeField("OLWISSC", "OLWISSC", JdeDataType.String, 12, true, true),
        new JdeField("OLSEQNUMB", "OLSEQNUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("OLWCFGID", "OLWCFGID", JdeDataType.Numeric),
        new JdeField("OLURAB", "OLURAB", JdeDataType.Numeric),
        new JdeField("OLURAT", "OLURAT", JdeDataType.Numeric),
        new JdeField("OLURCD", "OLURCD", JdeDataType.String, 4),
        new JdeField("OLURDT", "OLURDT", JdeDataType.Numeric),
        new JdeField("OLURRF", "OLURRF", JdeDataType.String, 30),
        new JdeField("OLJOBN", "OLJOBN", JdeDataType.String, 20),
        new JdeField("OLPID", "OLPID", JdeDataType.String, 20),
        new JdeField("OLTDAY", "OLTDAY", JdeDataType.Numeric),
        new JdeField("OLUPMJ", "OLUPMJ", JdeDataType.Numeric),
        new JdeField("OLUSER", "OLUSER", JdeDataType.String, 20),
        new JdeField("OLWAB", "OLWAB", JdeDataType.Numeric),
        new JdeField("OLWCD", "OLWCD", JdeDataType.String, 6),
        new JdeField("OLWMDT", "OLWMDT", JdeDataType.Numeric),
        new JdeField("OLWNUM", "OLWNUM", JdeDataType.Numeric),
        new JdeField("OLWRF", "OLWRF", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B0751_0", "Primary Key on OLEURID, OLWISSC, OLSEQNUMB", new[] { "OLEURID", "OLWISSC", "OLSEQNUMB" }, isUnique: true, isPrimaryKey: true)
    };
}
