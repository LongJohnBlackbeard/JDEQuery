using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75A0201 - .
/// </summary>
public class F75A0201 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TFAN8.
        /// </summary>
        public const string TFAN8 = "TFAN8";

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
        /// TFDCTM.
        /// </summary>
        public const string TFDCTM = "TFDCTM";

        /// <summary>
        /// TFDOCM.
        /// </summary>
        public const string TFDOCM = "TFDOCM";

        /// <summary>
        /// TFSFXM.
        /// </summary>
        public const string TFSFXM = "TFSFXM";

        /// <summary>
        /// TFDOCO.
        /// </summary>
        public const string TFDOCO = "TFDOCO";

        /// <summary>
        /// TFURDT.
        /// </summary>
        public const string TFURDT = "TFURDT";

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
        /// TFUSER.
        /// </summary>
        public const string TFUSER = "TFUSER";

        /// <summary>
        /// TFPID.
        /// </summary>
        public const string TFPID = "TFPID";

        /// <summary>
        /// TFJOBN.
        /// </summary>
        public const string TFJOBN = "TFJOBN";

        /// <summary>
        /// TFUPMJ.
        /// </summary>
        public const string TFUPMJ = "TFUPMJ";

        /// <summary>
        /// TFUPMT.
        /// </summary>
        public const string TFUPMT = "TFUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75A0201";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TFAN8", "TFAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("TFDCT", "TFDCT", JdeDataType.String, 4, true, true),
        new JdeField("TFDOC", "TFDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("TFKCO", "TFKCO", JdeDataType.String, 10, true, true),
        new JdeField("TFSFX", "TFSFX", JdeDataType.String, 6, true, true),
        new JdeField("TFDCTM", "TFDCTM", JdeDataType.String, 4, true, true),
        new JdeField("TFDOCM", "TFDOCM", JdeDataType.Numeric, null, true, true),
        new JdeField("TFSFXM", "TFSFXM", JdeDataType.String, 6, true, true),
        new JdeField("TFDOCO", "TFDOCO", JdeDataType.Numeric),
        new JdeField("TFURDT", "TFURDT", JdeDataType.Numeric),
        new JdeField("TFURAT", "TFURAT", JdeDataType.Numeric),
        new JdeField("TFURAB", "TFURAB", JdeDataType.Numeric),
        new JdeField("TFURRF", "TFURRF", JdeDataType.String, 30),
        new JdeField("TFUSER", "TFUSER", JdeDataType.String, 20),
        new JdeField("TFPID", "TFPID", JdeDataType.String, 20),
        new JdeField("TFJOBN", "TFJOBN", JdeDataType.String, 20),
        new JdeField("TFUPMJ", "TFUPMJ", JdeDataType.Numeric),
        new JdeField("TFUPMT", "TFUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75A0201_0", "Primary Key on TFAN8, TFDCT, TFDOC, TFKCO, TFSFX, TFDCTM, TFDOCM, TFSFXM", new[] { "TFAN8", "TFDCT", "TFDOC", "TFKCO", "TFSFX", "TFDCTM", "TFDOCM", "TFSFXM" }, isUnique: true, isPrimaryKey: true)
    };
}
