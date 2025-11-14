using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42X020W - .
/// </summary>
public class F42X020W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// XCSNKY.
        /// </summary>
        public const string XCSNKY = "XCSNKY";

        /// <summary>
        /// XC42XCSRT.
        /// </summary>
        public const string XC42XCSRT = "XC42XCSRT";

        /// <summary>
        /// XCITM.
        /// </summary>
        public const string XCITM = "XCITM";

        /// <summary>
        /// XCLNIX.
        /// </summary>
        public const string XCLNIX = "XCLNIX";

        /// <summary>
        /// XCUORG.
        /// </summary>
        public const string XCUORG = "XCUORG";

        /// <summary>
        /// XCUOM.
        /// </summary>
        public const string XCUOM = "XCUOM";

        /// <summary>
        /// XCUPRC.
        /// </summary>
        public const string XCUPRC = "XCUPRC";

        /// <summary>
        /// XCTUPRC.
        /// </summary>
        public const string XCTUPRC = "XCTUPRC";

        /// <summary>
        /// XCFUP.
        /// </summary>
        public const string XCFUP = "XCFUP";

        /// <summary>
        /// XCTFUP.
        /// </summary>
        public const string XCTFUP = "XCTFUP";

        /// <summary>
        /// XC42XRDCT.
        /// </summary>
        public const string XC42XRDCT = "XC42XRDCT";

        /// <summary>
        /// XC42XCSDR.
        /// </summary>
        public const string XC42XCSDR = "XC42XCSDR";

        /// <summary>
        /// XC42XCSRS.
        /// </summary>
        public const string XC42XCSRS = "XC42XCSRS";

        /// <summary>
        /// XCITMR.
        /// </summary>
        public const string XCITMR = "XCITMR";

        /// <summary>
        /// XCUSER.
        /// </summary>
        public const string XCUSER = "XCUSER";

        /// <summary>
        /// XCPID.
        /// </summary>
        public const string XCPID = "XCPID";

        /// <summary>
        /// XCJOBN.
        /// </summary>
        public const string XCJOBN = "XCJOBN";

        /// <summary>
        /// XCUPMJ.
        /// </summary>
        public const string XCUPMJ = "XCUPMJ";

        /// <summary>
        /// XCUPMT.
        /// </summary>
        public const string XCUPMT = "XCUPMT";

        /// <summary>
        /// XCUNCS.
        /// </summary>
        public const string XCUNCS = "XCUNCS";

        /// <summary>
        /// XCFUC.
        /// </summary>
        public const string XCFUC = "XCFUC";

        /// <summary>
        /// XCPRMG.
        /// </summary>
        public const string XCPRMG = "XCPRMG";

        /// <summary>
        /// XCQAVAL.
        /// </summary>
        public const string XCQAVAL = "XCQAVAL";

        /// <summary>
        /// XCMCU.
        /// </summary>
        public const string XCMCU = "XCMCU";
    }

    /// <inheritdoc />
    public override string TableName => "F42X020W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("XCSNKY", "XCSNKY", JdeDataType.String, 64, true, true),
        new JdeField("XC42XCSRT", "XC42XCSRT", JdeDataType.String, 2, true, true),
        new JdeField("XCITM", "XCITM", JdeDataType.Numeric, null, true, true),
        new JdeField("XCLNIX", "XCLNIX", JdeDataType.Numeric),
        new JdeField("XCUORG", "XCUORG", JdeDataType.Numeric),
        new JdeField("XCUOM", "XCUOM", JdeDataType.String, 4),
        new JdeField("XCUPRC", "XCUPRC", JdeDataType.Numeric),
        new JdeField("XCTUPRC", "XCTUPRC", JdeDataType.Numeric),
        new JdeField("XCFUP", "XCFUP", JdeDataType.Numeric),
        new JdeField("XCTFUP", "XCTFUP", JdeDataType.Numeric),
        new JdeField("XC42XRDCT", "XC42XRDCT", JdeDataType.Numeric),
        new JdeField("XC42XCSDR", "XC42XCSDR", JdeDataType.String, 2),
        new JdeField("XC42XCSRS", "XC42XCSRS", JdeDataType.String, 2),
        new JdeField("XCITMR", "XCITMR", JdeDataType.Numeric),
        new JdeField("XCUSER", "XCUSER", JdeDataType.String, 20),
        new JdeField("XCPID", "XCPID", JdeDataType.String, 20),
        new JdeField("XCJOBN", "XCJOBN", JdeDataType.String, 20),
        new JdeField("XCUPMJ", "XCUPMJ", JdeDataType.Numeric),
        new JdeField("XCUPMT", "XCUPMT", JdeDataType.Numeric),
        new JdeField("XCUNCS", "XCUNCS", JdeDataType.Numeric),
        new JdeField("XCFUC", "XCFUC", JdeDataType.Numeric),
        new JdeField("XCPRMG", "XCPRMG", JdeDataType.Numeric),
        new JdeField("XCQAVAL", "XCQAVAL", JdeDataType.Numeric),
        new JdeField("XCMCU", "XCMCU", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42X020W_0", "Primary Key on XCSNKY, XC42XCSRT, XCITM", new[] { "XCSNKY", "XC42XCSRT", "XCITM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F42X020W_2", "Index on XCSNKY, XC42XCSRS, SYS_NC00025$", new[] { "XCSNKY", "XC42XCSRS", "SYS_NC00025$" }),
        new JdeIndex("F42X020W_3", "Index on XCSNKY, XC42XCSDR", new[] { "XCSNKY", "XC42XCSDR" }),
        new JdeIndex("F42X020W_4", "Index on XCSNKY, XC42XCSRT, SYS_NC00025$", new[] { "XCSNKY", "XC42XCSRT", "SYS_NC00025$" })
    };
}
