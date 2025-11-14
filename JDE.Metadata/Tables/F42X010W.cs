using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42X010W - .
/// </summary>
public class F42X010W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// USSNKY.
        /// </summary>
        public const string USSNKY = "USSNKY";

        /// <summary>
        /// USITM.
        /// </summary>
        public const string USITM = "USITM";

        /// <summary>
        /// US42XCSRT.
        /// </summary>
        public const string US42XCSRT = "US42XCSRT";

        /// <summary>
        /// USLNIX.
        /// </summary>
        public const string USLNIX = "USLNIX";

        /// <summary>
        /// USUORG.
        /// </summary>
        public const string USUORG = "USUORG";

        /// <summary>
        /// USUOM.
        /// </summary>
        public const string USUOM = "USUOM";

        /// <summary>
        /// USUOM4.
        /// </summary>
        public const string USUOM4 = "USUOM4";

        /// <summary>
        /// USUPRC.
        /// </summary>
        public const string USUPRC = "USUPRC";

        /// <summary>
        /// USAEXP.
        /// </summary>
        public const string USAEXP = "USAEXP";

        /// <summary>
        /// USFUP.
        /// </summary>
        public const string USFUP = "USFUP";

        /// <summary>
        /// USFEA.
        /// </summary>
        public const string USFEA = "USFEA";

        /// <summary>
        /// USTUPRC.
        /// </summary>
        public const string USTUPRC = "USTUPRC";

        /// <summary>
        /// USTAEXP.
        /// </summary>
        public const string USTAEXP = "USTAEXP";

        /// <summary>
        /// USTFUP.
        /// </summary>
        public const string USTFUP = "USTFUP";

        /// <summary>
        /// USTFEA.
        /// </summary>
        public const string USTFEA = "USTFEA";

        /// <summary>
        /// USFGY.
        /// </summary>
        public const string USFGY = "USFGY";

        /// <summary>
        /// US42XDONE.
        /// </summary>
        public const string US42XDONE = "US42XDONE";

        /// <summary>
        /// USLNID.
        /// </summary>
        public const string USLNID = "USLNID";

        /// <summary>
        /// USITMR.
        /// </summary>
        public const string USITMR = "USITMR";

        /// <summary>
        /// USKCOO.
        /// </summary>
        public const string USKCOO = "USKCOO";

        /// <summary>
        /// USCRCD.
        /// </summary>
        public const string USCRCD = "USCRCD";

        /// <summary>
        /// USMCU.
        /// </summary>
        public const string USMCU = "USMCU";

        /// <summary>
        /// USUSER.
        /// </summary>
        public const string USUSER = "USUSER";

        /// <summary>
        /// USPID.
        /// </summary>
        public const string USPID = "USPID";

        /// <summary>
        /// USJOBN.
        /// </summary>
        public const string USJOBN = "USJOBN";

        /// <summary>
        /// USUPMJ.
        /// </summary>
        public const string USUPMJ = "USUPMJ";

        /// <summary>
        /// USUPMT.
        /// </summary>
        public const string USUPMT = "USUPMT";

        /// <summary>
        /// US42XRDPD.
        /// </summary>
        public const string US42XRDPD = "US42XRDPD";

        /// <summary>
        /// USUNCS.
        /// </summary>
        public const string USUNCS = "USUNCS";

        /// <summary>
        /// USFUC.
        /// </summary>
        public const string USFUC = "USFUC";

        /// <summary>
        /// USPRMG.
        /// </summary>
        public const string USPRMG = "USPRMG";

        /// <summary>
        /// USQAVAL.
        /// </summary>
        public const string USQAVAL = "USQAVAL";
    }

    /// <inheritdoc />
    public override string TableName => "F42X010W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("USSNKY", "USSNKY", JdeDataType.String, 64, true, true),
        new JdeField("USITM", "USITM", JdeDataType.Numeric, null, true, true),
        new JdeField("US42XCSRT", "US42XCSRT", JdeDataType.String, 2, true, true),
        new JdeField("USLNIX", "USLNIX", JdeDataType.Numeric, null, true, true),
        new JdeField("USUORG", "USUORG", JdeDataType.Numeric, null, true, true),
        new JdeField("USUOM", "USUOM", JdeDataType.String, 4),
        new JdeField("USUOM4", "USUOM4", JdeDataType.String, 4),
        new JdeField("USUPRC", "USUPRC", JdeDataType.Numeric),
        new JdeField("USAEXP", "USAEXP", JdeDataType.Numeric),
        new JdeField("USFUP", "USFUP", JdeDataType.Numeric),
        new JdeField("USFEA", "USFEA", JdeDataType.Numeric),
        new JdeField("USTUPRC", "USTUPRC", JdeDataType.Numeric),
        new JdeField("USTAEXP", "USTAEXP", JdeDataType.Numeric),
        new JdeField("USTFUP", "USTFUP", JdeDataType.Numeric),
        new JdeField("USTFEA", "USTFEA", JdeDataType.Numeric),
        new JdeField("USFGY", "USFGY", JdeDataType.String, 2),
        new JdeField("US42XDONE", "US42XDONE", JdeDataType.String, 2),
        new JdeField("USLNID", "USLNID", JdeDataType.Numeric),
        new JdeField("USITMR", "USITMR", JdeDataType.Numeric),
        new JdeField("USKCOO", "USKCOO", JdeDataType.String, 10),
        new JdeField("USCRCD", "USCRCD", JdeDataType.String, 6),
        new JdeField("USMCU", "USMCU", JdeDataType.String, 24),
        new JdeField("USUSER", "USUSER", JdeDataType.String, 20),
        new JdeField("USPID", "USPID", JdeDataType.String, 20),
        new JdeField("USJOBN", "USJOBN", JdeDataType.String, 20),
        new JdeField("USUPMJ", "USUPMJ", JdeDataType.Numeric),
        new JdeField("USUPMT", "USUPMT", JdeDataType.Numeric),
        new JdeField("US42XRDPD", "US42XRDPD", JdeDataType.String, 2),
        new JdeField("USUNCS", "USUNCS", JdeDataType.Numeric),
        new JdeField("USFUC", "USFUC", JdeDataType.Numeric),
        new JdeField("USPRMG", "USPRMG", JdeDataType.Numeric),
        new JdeField("USQAVAL", "USQAVAL", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42X010W_0", "Primary Key on USSNKY, USITM, US42XCSRT, USLNIX, USUORG", new[] { "USSNKY", "USITM", "US42XCSRT", "USLNIX", "USUORG" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F42X010W_2", "Index on USSNKY, USLNIX", new[] { "USSNKY", "USLNIX" }),
        new JdeIndex("F42X010W_3", "Index on USSNKY, SYS_NC00033$", new[] { "USSNKY", "SYS_NC00033$" }),
        new JdeIndex("F42X010W_4", "Index on USSNKY, US42XDONE, USLNIX, US42XCSRT", new[] { "USSNKY", "US42XDONE", "USLNIX", "US42XCSRT" }),
        new JdeIndex("F42X010W_5", "Index on USSNKY, USLNID", new[] { "USSNKY", "USLNID" }),
        new JdeIndex("F42X010W_6", "Index on USSNKY, SYS_NC00034$", new[] { "USSNKY", "SYS_NC00034$" }),
        new JdeIndex("F42X010W_7", "Index on USSNKY, US42XCSRT, USLNIX, US42XRDPD", new[] { "USSNKY", "US42XCSRT", "USLNIX", "US42XRDPD" })
    };
}
