using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A8017 - .
/// </summary>
public class F76A8017 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TFHDC.
        /// </summary>
        public const string TFHDC = "TFHDC";

        /// <summary>
        /// TFCKC.
        /// </summary>
        public const string TFCKC = "TFCKC";

        /// <summary>
        /// TFDCT.
        /// </summary>
        public const string TFDCT = "TFDCT";

        /// <summary>
        /// TFDOC.
        /// </summary>
        public const string TFDOC = "TFDOC";

        /// <summary>
        /// TFKCO.
        /// </summary>
        public const string TFKCO = "TFKCO";

        /// <summary>
        /// TFSFX.
        /// </summary>
        public const string TFSFX = "TFSFX";

        /// <summary>
        /// TFURDT.
        /// </summary>
        public const string TFURDT = "TFURDT";

        /// <summary>
        /// TFURCD.
        /// </summary>
        public const string TFURCD = "TFURCD";

        /// <summary>
        /// TFURAT.
        /// </summary>
        public const string TFURAT = "TFURAT";

        /// <summary>
        /// TFURAB.
        /// </summary>
        public const string TFURAB = "TFURAB";

        /// <summary>
        /// TFURRF.
        /// </summary>
        public const string TFURRF = "TFURRF";

        /// <summary>
        /// TFURRC.
        /// </summary>
        public const string TFURRC = "TFURRC";

        /// <summary>
        /// TFURR.
        /// </summary>
        public const string TFURR = "TFURR";

        /// <summary>
        /// TFUSER.
        /// </summary>
        public const string TFUSER = "TFUSER";

        /// <summary>
        /// TFPID.
        /// </summary>
        public const string TFPID = "TFPID";

        /// <summary>
        /// TFUPMJ.
        /// </summary>
        public const string TFUPMJ = "TFUPMJ";

        /// <summary>
        /// TFUPMT.
        /// </summary>
        public const string TFUPMT = "TFUPMT";

        /// <summary>
        /// TFJOBN.
        /// </summary>
        public const string TFJOBN = "TFJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F76A8017";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TFHDC", "TFHDC", JdeDataType.Numeric, null, true, true),
        new JdeField("TFCKC", "TFCKC", JdeDataType.Numeric, null, true, true),
        new JdeField("TFDCT", "TFDCT", JdeDataType.String, 4, true, true),
        new JdeField("TFDOC", "TFDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("TFKCO", "TFKCO", JdeDataType.String, 10, true, true),
        new JdeField("TFSFX", "TFSFX", JdeDataType.String, 6, true, true),
        new JdeField("TFURDT", "TFURDT", JdeDataType.Numeric),
        new JdeField("TFURCD", "TFURCD", JdeDataType.String, 4),
        new JdeField("TFURAT", "TFURAT", JdeDataType.Numeric),
        new JdeField("TFURAB", "TFURAB", JdeDataType.Numeric),
        new JdeField("TFURRF", "TFURRF", JdeDataType.String, 30),
        new JdeField("TFURRC", "TFURRC", JdeDataType.String, 4),
        new JdeField("TFURR", "TFURR", JdeDataType.Numeric),
        new JdeField("TFUSER", "TFUSER", JdeDataType.String, 20),
        new JdeField("TFPID", "TFPID", JdeDataType.String, 20),
        new JdeField("TFUPMJ", "TFUPMJ", JdeDataType.Numeric),
        new JdeField("TFUPMT", "TFUPMT", JdeDataType.Numeric),
        new JdeField("TFJOBN", "TFJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A8017_0", "Primary Key on TFHDC, TFCKC, TFDCT, TFDOC, TFKCO, TFSFX", new[] { "TFHDC", "TFCKC", "TFDCT", "TFDOC", "TFKCO", "TFSFX" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76A8017_2", "Index on TFDCT, TFDOC, TFKCO, TFSFX", new[] { "TFDCT", "TFDOC", "TFKCO", "TFSFX" })
    };
}
