using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I411 - .
/// </summary>
public class F75I411 : JdeTable
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
        /// TFDOC.
        /// </summary>
        public const string TFDOC = "TFDOC";

        /// <summary>
        /// TFDCT.
        /// </summary>
        public const string TFDCT = "TFDCT";

        /// <summary>
        /// TFSFX.
        /// </summary>
        public const string TFSFX = "TFSFX";

        /// <summary>
        /// TFSFXE.
        /// </summary>
        public const string TFSFXE = "TFSFXE";

        /// <summary>
        /// TFAN8.
        /// </summary>
        public const string TFAN8 = "TFAN8";

        /// <summary>
        /// TFYTYP.
        /// </summary>
        public const string TFYTYP = "TFYTYP";

        /// <summary>
        /// TFI75WCTY.
        /// </summary>
        public const string TFI75WCTY = "TFI75WCTY";

        /// <summary>
        /// TFI75AST.
        /// </summary>
        public const string TFI75AST = "TFI75AST";

        /// <summary>
        /// TFI75RP.
        /// </summary>
        public const string TFI75RP = "TFI75RP";

        /// <summary>
        /// TFI75ORST.
        /// </summary>
        public const string TFI75ORST = "TFI75ORST";

        /// <summary>
        /// TFOKCO.
        /// </summary>
        public const string TFOKCO = "TFOKCO";

        /// <summary>
        /// TFODCT.
        /// </summary>
        public const string TFODCT = "TFODCT";

        /// <summary>
        /// TFODOC.
        /// </summary>
        public const string TFODOC = "TFODOC";

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
    public override string TableName => "F75I411";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TFKCO", "TFKCO", JdeDataType.String, 10, true, true),
        new JdeField("TFDOC", "TFDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("TFDCT", "TFDCT", JdeDataType.String, 4, true, true),
        new JdeField("TFSFX", "TFSFX", JdeDataType.String, 6, true, true),
        new JdeField("TFSFXE", "TFSFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("TFAN8", "TFAN8", JdeDataType.Numeric),
        new JdeField("TFYTYP", "TFYTYP", JdeDataType.String, 2),
        new JdeField("TFI75WCTY", "TFI75WCTY", JdeDataType.String, 2),
        new JdeField("TFI75AST", "TFI75AST", JdeDataType.String, 2),
        new JdeField("TFI75RP", "TFI75RP", JdeDataType.String, 2),
        new JdeField("TFI75ORST", "TFI75ORST", JdeDataType.String, 6),
        new JdeField("TFOKCO", "TFOKCO", JdeDataType.String, 10),
        new JdeField("TFODCT", "TFODCT", JdeDataType.String, 4),
        new JdeField("TFODOC", "TFODOC", JdeDataType.Numeric),
        new JdeField("TFUSER", "TFUSER", JdeDataType.String, 20),
        new JdeField("TFPID", "TFPID", JdeDataType.String, 20),
        new JdeField("TFUPMJ", "TFUPMJ", JdeDataType.Numeric),
        new JdeField("TFUPMT", "TFUPMT", JdeDataType.Numeric),
        new JdeField("TFJOBN", "TFJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I411_0", "Primary Key on TFKCO, TFDOC, TFDCT, TFSFX, TFSFXE", new[] { "TFKCO", "TFDOC", "TFDCT", "TFSFX", "TFSFXE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I411_2", "Index on TFOKCO, TFODCT, TFODOC", new[] { "TFOKCO", "TFODCT", "TFODOC" })
    };
}
