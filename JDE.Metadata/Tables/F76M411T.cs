using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76M411T - .
/// </summary>
public class F76M411T : JdeTable
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
        /// TFM76WHTP.
        /// </summary>
        public const string TFM76WHTP = "TFM76WHTP";

        /// <summary>
        /// TFM76WCON.
        /// </summary>
        public const string TFM76WCON = "TFM76WCON";

        /// <summary>
        /// TFM76PFLG.
        /// </summary>
        public const string TFM76PFLG = "TFM76PFLG";

        /// <summary>
        /// TFM76FSTR.
        /// </summary>
        public const string TFM76FSTR = "TFM76FSTR";

        /// <summary>
        /// TFM76FDAT.
        /// </summary>
        public const string TFM76FDAT = "TFM76FDAT";

        /// <summary>
        /// TFM76FNUM.
        /// </summary>
        public const string TFM76FNUM = "TFM76FNUM";

        /// <summary>
        /// TFM76FFLG.
        /// </summary>
        public const string TFM76FFLG = "TFM76FFLG";

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
    public override string TableName => "F76M411T";

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
        new JdeField("TFM76WHTP", "TFM76WHTP", JdeDataType.String, 2, true, true),
        new JdeField("TFM76WCON", "TFM76WCON", JdeDataType.String, 6),
        new JdeField("TFM76PFLG", "TFM76PFLG", JdeDataType.String, 2),
        new JdeField("TFM76FSTR", "TFM76FSTR", JdeDataType.String, 60),
        new JdeField("TFM76FDAT", "TFM76FDAT", JdeDataType.Numeric),
        new JdeField("TFM76FNUM", "TFM76FNUM", JdeDataType.Numeric),
        new JdeField("TFM76FFLG", "TFM76FFLG", JdeDataType.String, 2),
        new JdeField("TFUSER", "TFUSER", JdeDataType.String, 20),
        new JdeField("TFPID", "TFPID", JdeDataType.String, 20),
        new JdeField("TFUPMJ", "TFUPMJ", JdeDataType.Numeric),
        new JdeField("TFUPMT", "TFUPMT", JdeDataType.Numeric),
        new JdeField("TFJOBN", "TFJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76M411T_0", "Primary Key on TFKCO, TFDOC, TFDCT, TFSFX, TFSFXE, TFM76WHTP", new[] { "TFKCO", "TFDOC", "TFDCT", "TFSFX", "TFSFXE", "TFM76WHTP" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76M411T_2", "Index on TFSFXE, TFKCO, TFDOC, TFDCT, TFSFX", new[] { "TFSFXE", "TFKCO", "TFDOC", "TFDCT", "TFSFX" }),
        new JdeIndex("F76M411T_3", "Index on TFKCO, TFDOC, TFDCT", new[] { "TFKCO", "TFDOC", "TFDCT" })
    };
}
