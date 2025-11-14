using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R4014 - .
/// </summary>
public class F74R4014 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TFPYID.
        /// </summary>
        public const string TFPYID = "TFPYID";

        /// <summary>
        /// TFRC5.
        /// </summary>
        public const string TFRC5 = "TFRC5";

        /// <summary>
        /// TFDCTM.
        /// </summary>
        public const string TFDCTM = "TFDCTM";

        /// <summary>
        /// TFDOC.
        /// </summary>
        public const string TFDOC = "TFDOC";

        /// <summary>
        /// TFDCT.
        /// </summary>
        public const string TFDCT = "TFDCT";

        /// <summary>
        /// TFKCO.
        /// </summary>
        public const string TFKCO = "TFKCO";

        /// <summary>
        /// TFSFX.
        /// </summary>
        public const string TFSFX = "TFSFX";

        /// <summary>
        /// TFSFXE.
        /// </summary>
        public const string TFSFXE = "TFSFXE";

        /// <summary>
        /// TFK74ADF.
        /// </summary>
        public const string TFK74ADF = "TFK74ADF";

        /// <summary>
        /// TFURRF.
        /// </summary>
        public const string TFURRF = "TFURRF";

        /// <summary>
        /// TFURCD.
        /// </summary>
        public const string TFURCD = "TFURCD";

        /// <summary>
        /// TFURDT.
        /// </summary>
        public const string TFURDT = "TFURDT";

        /// <summary>
        /// TFURAB.
        /// </summary>
        public const string TFURAB = "TFURAB";

        /// <summary>
        /// TFTORG.
        /// </summary>
        public const string TFTORG = "TFTORG";

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
    }

    /// <inheritdoc />
    public override string TableName => "F74R4014";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TFPYID", "TFPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("TFRC5", "TFRC5", JdeDataType.Numeric, null, true, true),
        new JdeField("TFDCTM", "TFDCTM", JdeDataType.String, 4),
        new JdeField("TFDOC", "TFDOC", JdeDataType.Numeric),
        new JdeField("TFDCT", "TFDCT", JdeDataType.String, 4),
        new JdeField("TFKCO", "TFKCO", JdeDataType.String, 10),
        new JdeField("TFSFX", "TFSFX", JdeDataType.String, 6),
        new JdeField("TFSFXE", "TFSFXE", JdeDataType.Numeric),
        new JdeField("TFK74ADF", "TFK74ADF", JdeDataType.String, 2),
        new JdeField("TFURRF", "TFURRF", JdeDataType.String, 30),
        new JdeField("TFURCD", "TFURCD", JdeDataType.String, 4),
        new JdeField("TFURDT", "TFURDT", JdeDataType.Numeric),
        new JdeField("TFURAB", "TFURAB", JdeDataType.Numeric),
        new JdeField("TFTORG", "TFTORG", JdeDataType.String, 20),
        new JdeField("TFUSER", "TFUSER", JdeDataType.String, 20),
        new JdeField("TFPID", "TFPID", JdeDataType.String, 20),
        new JdeField("TFUPMJ", "TFUPMJ", JdeDataType.Numeric),
        new JdeField("TFUPMT", "TFUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R4014_0", "Primary Key on TFPYID, TFRC5", new[] { "TFPYID", "TFRC5" }, isUnique: true, isPrimaryKey: true)
    };
}
