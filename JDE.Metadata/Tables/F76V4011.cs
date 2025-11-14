using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76V4011 - .
/// </summary>
public class F76V4011 : JdeTable
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
        /// TFAN8.
        /// </summary>
        public const string TFAN8 = "TFAN8";

        /// <summary>
        /// TFV76ISLR.
        /// </summary>
        public const string TFV76ISLR = "TFV76ISLR";

        /// <summary>
        /// TFV76MUNW.
        /// </summary>
        public const string TFV76MUNW = "TFV76MUNW";

        /// <summary>
        /// TFV76VATW.
        /// </summary>
        public const string TFV76VATW = "TFV76VATW";

        /// <summary>
        /// TFV76ICNV.
        /// </summary>
        public const string TFV76ICNV = "TFV76ICNV";

        /// <summary>
        /// TFV76ISFC.
        /// </summary>
        public const string TFV76ISFC = "TFV76ISFC";

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

        /// <summary>
        /// TFJOBN.
        /// </summary>
        public const string TFJOBN = "TFJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F76V4011";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TFKCO", "TFKCO", JdeDataType.String, 10, true, true),
        new JdeField("TFDOC", "TFDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("TFDCT", "TFDCT", JdeDataType.String, 4, true, true),
        new JdeField("TFSFX", "TFSFX", JdeDataType.String, 6, true, true),
        new JdeField("TFAN8", "TFAN8", JdeDataType.Numeric),
        new JdeField("TFV76ISLR", "TFV76ISLR", JdeDataType.String, 6),
        new JdeField("TFV76MUNW", "TFV76MUNW", JdeDataType.String, 2),
        new JdeField("TFV76VATW", "TFV76VATW", JdeDataType.String, 6),
        new JdeField("TFV76ICNV", "TFV76ICNV", JdeDataType.String, 20),
        new JdeField("TFV76ISFC", "TFV76ISFC", JdeDataType.String, 2),
        new JdeField("TFTORG", "TFTORG", JdeDataType.String, 20),
        new JdeField("TFUSER", "TFUSER", JdeDataType.String, 20),
        new JdeField("TFPID", "TFPID", JdeDataType.String, 20),
        new JdeField("TFUPMJ", "TFUPMJ", JdeDataType.Numeric),
        new JdeField("TFUPMT", "TFUPMT", JdeDataType.Numeric),
        new JdeField("TFJOBN", "TFJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76V4011_0", "Primary Key on TFKCO, TFDOC, TFDCT, TFSFX", new[] { "TFKCO", "TFDOC", "TFDCT", "TFSFX" }, isUnique: true, isPrimaryKey: true)
    };
}
