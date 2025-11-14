using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F704200 - .
/// </summary>
public class F704200 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FVKCO.
        /// </summary>
        public const string FVKCO = "FVKCO";

        /// <summary>
        /// FVDCT.
        /// </summary>
        public const string FVDCT = "FVDCT";

        /// <summary>
        /// FVDOC.
        /// </summary>
        public const string FVDOC = "FVDOC";

        /// <summary>
        /// FVSFX.
        /// </summary>
        public const string FVSFX = "FVSFX";

        /// <summary>
        /// FVSFXE.
        /// </summary>
        public const string FVSFXE = "FVSFXE";

        /// <summary>
        /// FVGL01.
        /// </summary>
        public const string FVGL01 = "FVGL01";

        /// <summary>
        /// FVK70RENB.
        /// </summary>
        public const string FVK70RENB = "FVK70RENB";

        /// <summary>
        /// FVK70EXNB.
        /// </summary>
        public const string FVK70EXNB = "FVK70EXNB";

        /// <summary>
        /// FVK70MTHD.
        /// </summary>
        public const string FVK70MTHD = "FVK70MTHD";

        /// <summary>
        /// FVK70RSTA.
        /// </summary>
        public const string FVK70RSTA = "FVK70RSTA";

        /// <summary>
        /// FVICUT.
        /// </summary>
        public const string FVICUT = "FVICUT";

        /// <summary>
        /// FVICU.
        /// </summary>
        public const string FVICU = "FVICU";

        /// <summary>
        /// FVKCOG.
        /// </summary>
        public const string FVKCOG = "FVKCOG";

        /// <summary>
        /// FVDCTG.
        /// </summary>
        public const string FVDCTG = "FVDCTG";

        /// <summary>
        /// FVDOCG.
        /// </summary>
        public const string FVDOCG = "FVDOCG";

        /// <summary>
        /// FVJELN.
        /// </summary>
        public const string FVJELN = "FVJELN";

        /// <summary>
        /// FVDGJ.
        /// </summary>
        public const string FVDGJ = "FVDGJ";

        /// <summary>
        /// FVCRCD.
        /// </summary>
        public const string FVCRCD = "FVCRCD";

        /// <summary>
        /// FVAA.
        /// </summary>
        public const string FVAA = "FVAA";

        /// <summary>
        /// FVFAA.
        /// </summary>
        public const string FVFAA = "FVFAA";

        /// <summary>
        /// FVAID.
        /// </summary>
        public const string FVAID = "FVAID";

        /// <summary>
        /// FVPYID.
        /// </summary>
        public const string FVPYID = "FVPYID";

        /// <summary>
        /// FVRC5.
        /// </summary>
        public const string FVRC5 = "FVRC5";

        /// <summary>
        /// FVK70RFLG.
        /// </summary>
        public const string FVK70RFLG = "FVK70RFLG";

        /// <summary>
        /// FVDTEJ.
        /// </summary>
        public const string FVDTEJ = "FVDTEJ";

        /// <summary>
        /// FVUSER.
        /// </summary>
        public const string FVUSER = "FVUSER";

        /// <summary>
        /// FVPID.
        /// </summary>
        public const string FVPID = "FVPID";

        /// <summary>
        /// FVJOBN.
        /// </summary>
        public const string FVJOBN = "FVJOBN";

        /// <summary>
        /// FVUPMJ.
        /// </summary>
        public const string FVUPMJ = "FVUPMJ";

        /// <summary>
        /// FVUPMT.
        /// </summary>
        public const string FVUPMT = "FVUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F704200";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FVKCO", "FVKCO", JdeDataType.String, 10, true, true),
        new JdeField("FVDCT", "FVDCT", JdeDataType.String, 4, true, true),
        new JdeField("FVDOC", "FVDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("FVSFX", "FVSFX", JdeDataType.String, 6, true, true),
        new JdeField("FVSFXE", "FVSFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("FVGL01", "FVGL01", JdeDataType.String, 8, true, true),
        new JdeField("FVK70RENB", "FVK70RENB", JdeDataType.Numeric, null, true, true),
        new JdeField("FVK70EXNB", "FVK70EXNB", JdeDataType.Numeric),
        new JdeField("FVK70MTHD", "FVK70MTHD", JdeDataType.String, 2),
        new JdeField("FVK70RSTA", "FVK70RSTA", JdeDataType.String, 2),
        new JdeField("FVICUT", "FVICUT", JdeDataType.String, 4),
        new JdeField("FVICU", "FVICU", JdeDataType.Numeric),
        new JdeField("FVKCOG", "FVKCOG", JdeDataType.String, 10),
        new JdeField("FVDCTG", "FVDCTG", JdeDataType.String, 4),
        new JdeField("FVDOCG", "FVDOCG", JdeDataType.Numeric),
        new JdeField("FVJELN", "FVJELN", JdeDataType.Numeric),
        new JdeField("FVDGJ", "FVDGJ", JdeDataType.Numeric),
        new JdeField("FVCRCD", "FVCRCD", JdeDataType.String, 6),
        new JdeField("FVAA", "FVAA", JdeDataType.Numeric),
        new JdeField("FVFAA", "FVFAA", JdeDataType.Numeric),
        new JdeField("FVAID", "FVAID", JdeDataType.String, 16),
        new JdeField("FVPYID", "FVPYID", JdeDataType.Numeric),
        new JdeField("FVRC5", "FVRC5", JdeDataType.Numeric),
        new JdeField("FVK70RFLG", "FVK70RFLG", JdeDataType.String, 2),
        new JdeField("FVDTEJ", "FVDTEJ", JdeDataType.Numeric),
        new JdeField("FVUSER", "FVUSER", JdeDataType.String, 20),
        new JdeField("FVPID", "FVPID", JdeDataType.String, 20),
        new JdeField("FVJOBN", "FVJOBN", JdeDataType.String, 20),
        new JdeField("FVUPMJ", "FVUPMJ", JdeDataType.Numeric),
        new JdeField("FVUPMT", "FVUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F704200_0", "Primary Key on FVKCO, FVDCT, FVDOC, FVSFX, FVSFXE, FVGL01, FVK70RENB", new[] { "FVKCO", "FVDCT", "FVDOC", "FVSFX", "FVSFXE", "FVGL01", "FVK70RENB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F704200_2", "Index on SYS_NC00031$", new[] { "SYS_NC00031$" }),
        new JdeIndex("F704200_3", "Index on FVKCO, FVDCT, FVDOC, FVSFX, FVSFXE, FVGL01, SYS_NC00032$", new[] { "FVKCO", "FVDCT", "FVDOC", "FVSFX", "FVSFXE", "FVGL01", "SYS_NC00032$" })
    };
}
