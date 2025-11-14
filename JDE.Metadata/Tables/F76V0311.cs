using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76V0311 - .
/// </summary>
public class F76V0311 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TFKCO.
        /// </summary>
        public const string TFKCO = "TFKCO";

        /// <summary>
        /// TFDCT.
        /// </summary>
        public const string TFDCT = "TFDCT";

        /// <summary>
        /// TFDOC.
        /// </summary>
        public const string TFDOC = "TFDOC";

        /// <summary>
        /// TFAN8.
        /// </summary>
        public const string TFAN8 = "TFAN8";

        /// <summary>
        /// TFURC1.
        /// </summary>
        public const string TFURC1 = "TFURC1";

        /// <summary>
        /// TFURCD.
        /// </summary>
        public const string TFURCD = "TFURCD";

        /// <summary>
        /// TFURDT.
        /// </summary>
        public const string TFURDT = "TFURDT";

        /// <summary>
        /// TFURRF.
        /// </summary>
        public const string TFURRF = "TFURRF";

        /// <summary>
        /// TFV76EXPN.
        /// </summary>
        public const string TFV76EXPN = "TFV76EXPN";

        /// <summary>
        /// TFPID.
        /// </summary>
        public const string TFPID = "TFPID";

        /// <summary>
        /// TFUSER.
        /// </summary>
        public const string TFUSER = "TFUSER";

        /// <summary>
        /// TFJOBN.
        /// </summary>
        public const string TFJOBN = "TFJOBN";

        /// <summary>
        /// TFUPMT.
        /// </summary>
        public const string TFUPMT = "TFUPMT";

        /// <summary>
        /// TFUPMJ.
        /// </summary>
        public const string TFUPMJ = "TFUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F76V0311";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TFKCO", "TFKCO", JdeDataType.String, 10, true, true),
        new JdeField("TFDCT", "TFDCT", JdeDataType.String, 4, true, true),
        new JdeField("TFDOC", "TFDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("TFAN8", "TFAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("TFURC1", "TFURC1", JdeDataType.String, 6),
        new JdeField("TFURCD", "TFURCD", JdeDataType.String, 4),
        new JdeField("TFURDT", "TFURDT", JdeDataType.Numeric),
        new JdeField("TFURRF", "TFURRF", JdeDataType.String, 30),
        new JdeField("TFV76EXPN", "TFV76EXPN", JdeDataType.String, 50),
        new JdeField("TFPID", "TFPID", JdeDataType.String, 20),
        new JdeField("TFUSER", "TFUSER", JdeDataType.String, 20),
        new JdeField("TFJOBN", "TFJOBN", JdeDataType.String, 20),
        new JdeField("TFUPMT", "TFUPMT", JdeDataType.Numeric),
        new JdeField("TFUPMJ", "TFUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76V0311_0", "Primary Key on TFKCO, TFDCT, TFDOC, TFAN8", new[] { "TFKCO", "TFDCT", "TFDOC", "TFAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
