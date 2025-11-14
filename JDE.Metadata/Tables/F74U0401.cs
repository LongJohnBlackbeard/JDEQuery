using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0401 - .
/// </summary>
public class F74U0401 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SACO.
        /// </summary>
        public const string SACO = "SACO";

        /// <summary>
        /// SA74USPCA.
        /// </summary>
        public const string SA74USPCA = "SA74USPCA";

        /// <summary>
        /// SA74UAAC.
        /// </summary>
        public const string SA74UAAC = "SA74UAAC";

        /// <summary>
        /// SA74UCB.
        /// </summary>
        public const string SA74UCB = "SA74UCB";

        /// <summary>
        /// SA74UFC.
        /// </summary>
        public const string SA74UFC = "SA74UFC";

        /// <summary>
        /// SA74UPOC.
        /// </summary>
        public const string SA74UPOC = "SA74UPOC";

        /// <summary>
        /// SA74UPLTD.
        /// </summary>
        public const string SA74UPLTD = "SA74UPLTD";

        /// <summary>
        /// SA74UPLTF.
        /// </summary>
        public const string SA74UPLTF = "SA74UPLTF";

        /// <summary>
        /// SA74UAC.
        /// </summary>
        public const string SA74UAC = "SA74UAC";

        /// <summary>
        /// SA74UALTD.
        /// </summary>
        public const string SA74UALTD = "SA74UALTD";

        /// <summary>
        /// SA74UALTF.
        /// </summary>
        public const string SA74UALTF = "SA74UALTF";

        /// <summary>
        /// SA74UCC.
        /// </summary>
        public const string SA74UCC = "SA74UCC";

        /// <summary>
        /// SA74UCLTD.
        /// </summary>
        public const string SA74UCLTD = "SA74UCLTD";

        /// <summary>
        /// SA74UCLTF.
        /// </summary>
        public const string SA74UCLTF = "SA74UCLTF";

        /// <summary>
        /// SA74USRU.
        /// </summary>
        public const string SA74USRU = "SA74USRU";

        /// <summary>
        /// SA74UARLTD.
        /// </summary>
        public const string SA74UARLTD = "SA74UARLTD";

        /// <summary>
        /// SA74UARLTF.
        /// </summary>
        public const string SA74UARLTF = "SA74UARLTF";

        /// <summary>
        /// SA74UCRLTD.
        /// </summary>
        public const string SA74UCRLTD = "SA74UCRLTD";

        /// <summary>
        /// SA74UCRLTF.
        /// </summary>
        public const string SA74UCRLTF = "SA74UCRLTF";

        /// <summary>
        /// SA74USMU.
        /// </summary>
        public const string SA74USMU = "SA74USMU";

        /// <summary>
        /// SA74UAMLTD.
        /// </summary>
        public const string SA74UAMLTD = "SA74UAMLTD";

        /// <summary>
        /// SA74UAMLTF.
        /// </summary>
        public const string SA74UAMLTF = "SA74UAMLTF";

        /// <summary>
        /// SA74UCMLTD.
        /// </summary>
        public const string SA74UCMLTD = "SA74UCMLTD";

        /// <summary>
        /// SA74UCMLTF.
        /// </summary>
        public const string SA74UCMLTF = "SA74UCMLTF";

        /// <summary>
        /// SA74UMCDR.
        /// </summary>
        public const string SA74UMCDR = "SA74UMCDR";

        /// <summary>
        /// SA74UMRV.
        /// </summary>
        public const string SA74UMRV = "SA74UMRV";

        /// <summary>
        /// SA74UVRB.
        /// </summary>
        public const string SA74UVRB = "SA74UVRB";

        /// <summary>
        /// SA74UAR.
        /// </summary>
        public const string SA74UAR = "SA74UAR";

        /// <summary>
        /// SA74UOC.
        /// </summary>
        public const string SA74UOC = "SA74UOC";

        /// <summary>
        /// SA74UAPVG.
        /// </summary>
        public const string SA74UAPVG = "SA74UAPVG";

        /// <summary>
        /// SA74URR.
        /// </summary>
        public const string SA74URR = "SA74URR";

        /// <summary>
        /// SA74UCE.
        /// </summary>
        public const string SA74UCE = "SA74UCE";

        /// <summary>
        /// SA74UPG.
        /// </summary>
        public const string SA74UPG = "SA74UPG";

        /// <summary>
        /// SA74UPCC1.
        /// </summary>
        public const string SA74UPCC1 = "SA74UPCC1";

        /// <summary>
        /// SA74UPCC2.
        /// </summary>
        public const string SA74UPCC2 = "SA74UPCC2";

        /// <summary>
        /// SA74UPCC3.
        /// </summary>
        public const string SA74UPCC3 = "SA74UPCC3";

        /// <summary>
        /// SA74UPCC4.
        /// </summary>
        public const string SA74UPCC4 = "SA74UPCC4";

        /// <summary>
        /// SA74UPCC5.
        /// </summary>
        public const string SA74UPCC5 = "SA74UPCC5";

        /// <summary>
        /// SAURAT.
        /// </summary>
        public const string SAURAT = "SAURAT";

        /// <summary>
        /// SAURCD.
        /// </summary>
        public const string SAURCD = "SAURCD";

        /// <summary>
        /// SAURDT.
        /// </summary>
        public const string SAURDT = "SAURDT";

        /// <summary>
        /// SAURAB.
        /// </summary>
        public const string SAURAB = "SAURAB";

        /// <summary>
        /// SAURRF.
        /// </summary>
        public const string SAURRF = "SAURRF";

        /// <summary>
        /// SAPID.
        /// </summary>
        public const string SAPID = "SAPID";

        /// <summary>
        /// SAJOBN.
        /// </summary>
        public const string SAJOBN = "SAJOBN";

        /// <summary>
        /// SAUSER.
        /// </summary>
        public const string SAUSER = "SAUSER";

        /// <summary>
        /// SAUPMJ.
        /// </summary>
        public const string SAUPMJ = "SAUPMJ";

        /// <summary>
        /// SAUPMT.
        /// </summary>
        public const string SAUPMT = "SAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74U0401";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SACO", "SACO", JdeDataType.String, 10, true, true),
        new JdeField("SA74USPCA", "SA74USPCA", JdeDataType.String, 2),
        new JdeField("SA74UAAC", "SA74UAAC", JdeDataType.String, 2),
        new JdeField("SA74UCB", "SA74UCB", JdeDataType.String, 2),
        new JdeField("SA74UFC", "SA74UFC", JdeDataType.String, 2),
        new JdeField("SA74UPOC", "SA74UPOC", JdeDataType.String, 2),
        new JdeField("SA74UPLTD", "SA74UPLTD", JdeDataType.String, 4),
        new JdeField("SA74UPLTF", "SA74UPLTF", JdeDataType.String, 4),
        new JdeField("SA74UAC", "SA74UAC", JdeDataType.String, 2),
        new JdeField("SA74UALTD", "SA74UALTD", JdeDataType.String, 4),
        new JdeField("SA74UALTF", "SA74UALTF", JdeDataType.String, 4),
        new JdeField("SA74UCC", "SA74UCC", JdeDataType.String, 2),
        new JdeField("SA74UCLTD", "SA74UCLTD", JdeDataType.String, 4),
        new JdeField("SA74UCLTF", "SA74UCLTF", JdeDataType.String, 4),
        new JdeField("SA74USRU", "SA74USRU", JdeDataType.String, 2),
        new JdeField("SA74UARLTD", "SA74UARLTD", JdeDataType.String, 4),
        new JdeField("SA74UARLTF", "SA74UARLTF", JdeDataType.String, 4),
        new JdeField("SA74UCRLTD", "SA74UCRLTD", JdeDataType.String, 4),
        new JdeField("SA74UCRLTF", "SA74UCRLTF", JdeDataType.String, 4),
        new JdeField("SA74USMU", "SA74USMU", JdeDataType.String, 2),
        new JdeField("SA74UAMLTD", "SA74UAMLTD", JdeDataType.String, 4),
        new JdeField("SA74UAMLTF", "SA74UAMLTF", JdeDataType.String, 4),
        new JdeField("SA74UCMLTD", "SA74UCMLTD", JdeDataType.String, 4),
        new JdeField("SA74UCMLTF", "SA74UCMLTF", JdeDataType.String, 4),
        new JdeField("SA74UMCDR", "SA74UMCDR", JdeDataType.Numeric),
        new JdeField("SA74UMRV", "SA74UMRV", JdeDataType.String, 2),
        new JdeField("SA74UVRB", "SA74UVRB", JdeDataType.String, 2),
        new JdeField("SA74UAR", "SA74UAR", JdeDataType.String, 2),
        new JdeField("SA74UOC", "SA74UOC", JdeDataType.String, 2),
        new JdeField("SA74UAPVG", "SA74UAPVG", JdeDataType.String, 6),
        new JdeField("SA74URR", "SA74URR", JdeDataType.String, 6),
        new JdeField("SA74UCE", "SA74UCE", JdeDataType.String, 6),
        new JdeField("SA74UPG", "SA74UPG", JdeDataType.String, 6),
        new JdeField("SA74UPCC1", "SA74UPCC1", JdeDataType.String, 6),
        new JdeField("SA74UPCC2", "SA74UPCC2", JdeDataType.String, 6),
        new JdeField("SA74UPCC3", "SA74UPCC3", JdeDataType.String, 20),
        new JdeField("SA74UPCC4", "SA74UPCC4", JdeDataType.String, 20),
        new JdeField("SA74UPCC5", "SA74UPCC5", JdeDataType.Numeric),
        new JdeField("SAURAT", "SAURAT", JdeDataType.Numeric),
        new JdeField("SAURCD", "SAURCD", JdeDataType.String, 4),
        new JdeField("SAURDT", "SAURDT", JdeDataType.Numeric),
        new JdeField("SAURAB", "SAURAB", JdeDataType.Numeric),
        new JdeField("SAURRF", "SAURRF", JdeDataType.String, 30),
        new JdeField("SAPID", "SAPID", JdeDataType.String, 20),
        new JdeField("SAJOBN", "SAJOBN", JdeDataType.String, 20),
        new JdeField("SAUSER", "SAUSER", JdeDataType.String, 20),
        new JdeField("SAUPMJ", "SAUPMJ", JdeDataType.Numeric),
        new JdeField("SAUPMT", "SAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0401_0", "Primary Key on SACO", new[] { "SACO" }, isUnique: true, isPrimaryKey: true)
    };
}
