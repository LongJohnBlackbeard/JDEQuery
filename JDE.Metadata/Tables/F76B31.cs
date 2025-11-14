using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B31 - .
/// </summary>
public class F76B31 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IMCO.
        /// </summary>
        public const string IMCO = "IMCO";

        /// <summary>
        /// IMBRINM.
        /// </summary>
        public const string IMBRINM = "IMBRINM";

        /// <summary>
        /// IMBRSSR.
        /// </summary>
        public const string IMBRSSR = "IMBRSSR";

        /// <summary>
        /// IMBRNNF.
        /// </summary>
        public const string IMBRNNF = "IMBRNNF";

        /// <summary>
        /// IMAT1.
        /// </summary>
        public const string IMAT1 = "IMAT1";

        /// <summary>
        /// IMAN8.
        /// </summary>
        public const string IMAN8 = "IMAN8";

        /// <summary>
        /// IMLID0.
        /// </summary>
        public const string IMLID0 = "IMLID0";

        /// <summary>
        /// IMLITM.
        /// </summary>
        public const string IMLITM = "IMLITM";

        /// <summary>
        /// IMA201.
        /// </summary>
        public const string IMA201 = "IMA201";

        /// <summary>
        /// IMDSC1.
        /// </summary>
        public const string IMDSC1 = "IMDSC1";

        /// <summary>
        /// IMDSC2.
        /// </summary>
        public const string IMDSC2 = "IMDSC2";

        /// <summary>
        /// IMMCU.
        /// </summary>
        public const string IMMCU = "IMMCU";

        /// <summary>
        /// IMBRCFOP.
        /// </summary>
        public const string IMBRCFOP = "IMBRCFOP";

        /// <summary>
        /// IMBRTPO.
        /// </summary>
        public const string IMBRTPO = "IMBRTPO";

        /// <summary>
        /// IMBCLF.
        /// </summary>
        public const string IMBCLF = "IMBCLF";

        /// <summary>
        /// IMUOM.
        /// </summary>
        public const string IMUOM = "IMUOM";

        /// <summary>
        /// IMUORG.
        /// </summary>
        public const string IMUORG = "IMUORG";

        /// <summary>
        /// IMLIQW.
        /// </summary>
        public const string IMLIQW = "IMLIQW";

        /// <summary>
        /// IMUPRC.
        /// </summary>
        public const string IMUPRC = "IMUPRC";

        /// <summary>
        /// IMAEXP.
        /// </summary>
        public const string IMAEXP = "IMAEXP";

        /// <summary>
        /// IMDSCT.
        /// </summary>
        public const string IMDSCT = "IMDSCT";

        /// <summary>
        /// IMBRROM.
        /// </summary>
        public const string IMBRROM = "IMBRROM";

        /// <summary>
        /// IMABCX.
        /// </summary>
        public const string IMABCX = "IMABCX";

        /// <summary>
        /// IMBFRT.
        /// </summary>
        public const string IMBFRT = "IMBFRT";

        /// <summary>
        /// IMSCRC.
        /// </summary>
        public const string IMSCRC = "IMSCRC";

        /// <summary>
        /// IMAOTH.
        /// </summary>
        public const string IMAOTH = "IMAOTH";

        /// <summary>
        /// IMTM01.
        /// </summary>
        public const string IMTM01 = "IMTM01";

        /// <summary>
        /// IMBRIPID.
        /// </summary>
        public const string IMBRIPID = "IMBRIPID";

        /// <summary>
        /// IMBRPCIPI.
        /// </summary>
        public const string IMBRPCIPI = "IMBRPCIPI";

        /// <summary>
        /// IMBIPR.
        /// </summary>
        public const string IMBIPR = "IMBIPR";

        /// <summary>
        /// IMBIPI.
        /// </summary>
        public const string IMBIPI = "IMBIPI";

        /// <summary>
        /// IMBRSTEA.
        /// </summary>
        public const string IMBRSTEA = "IMBRSTEA";

        /// <summary>
        /// IMBRSTEB.
        /// </summary>
        public const string IMBRSTEB = "IMBRSTEB";

        /// <summary>
        /// IMBRIIC.
        /// </summary>
        public const string IMBRIIC = "IMBRIIC";

        /// <summary>
        /// IMBRPICM.
        /// </summary>
        public const string IMBRPICM = "IMBRPICM";

        /// <summary>
        /// IMBBCL.
        /// </summary>
        public const string IMBBCL = "IMBBCL";

        /// <summary>
        /// IMBICP.
        /// </summary>
        public const string IMBICP = "IMBICP";

        /// <summary>
        /// IMBVIS.
        /// </summary>
        public const string IMBVIS = "IMBVIS";

        /// <summary>
        /// IMBICM.
        /// </summary>
        public const string IMBICM = "IMBICM";

        /// <summary>
        /// IMBBIR.
        /// </summary>
        public const string IMBBIR = "IMBBIR";

        /// <summary>
        /// IMBRDFIC.
        /// </summary>
        public const string IMBRDFIC = "IMBRDFIC";

        /// <summary>
        /// IMUSER.
        /// </summary>
        public const string IMUSER = "IMUSER";

        /// <summary>
        /// IMEAP.
        /// </summary>
        public const string IMEAP = "IMEAP";

        /// <summary>
        /// IMJOBN.
        /// </summary>
        public const string IMJOBN = "IMJOBN";

        /// <summary>
        /// IMUPMJ.
        /// </summary>
        public const string IMUPMJ = "IMUPMJ";

        /// <summary>
        /// IMUPMT.
        /// </summary>
        public const string IMUPMT = "IMUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B31";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IMCO", "IMCO", JdeDataType.String, 10, true, true),
        new JdeField("IMBRINM", "IMBRINM", JdeDataType.String, 2, true, true),
        new JdeField("IMBRSSR", "IMBRSSR", JdeDataType.String, 10, true, true),
        new JdeField("IMBRNNF", "IMBRNNF", JdeDataType.Numeric, null, true, true),
        new JdeField("IMAT1", "IMAT1", JdeDataType.String, 6, true, true),
        new JdeField("IMAN8", "IMAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("IMLID0", "IMLID0", JdeDataType.Numeric, null, true, true),
        new JdeField("IMLITM", "IMLITM", JdeDataType.String, 50),
        new JdeField("IMA201", "IMA201", JdeDataType.String, 4),
        new JdeField("IMDSC1", "IMDSC1", JdeDataType.String, 60),
        new JdeField("IMDSC2", "IMDSC2", JdeDataType.String, 60),
        new JdeField("IMMCU", "IMMCU", JdeDataType.String, 24),
        new JdeField("IMBRCFOP", "IMBRCFOP", JdeDataType.String, 10),
        new JdeField("IMBRTPO", "IMBRTPO", JdeDataType.String, 6),
        new JdeField("IMBCLF", "IMBCLF", JdeDataType.String, 20),
        new JdeField("IMUOM", "IMUOM", JdeDataType.String, 4),
        new JdeField("IMUORG", "IMUORG", JdeDataType.Numeric),
        new JdeField("IMLIQW", "IMLIQW", JdeDataType.Numeric),
        new JdeField("IMUPRC", "IMUPRC", JdeDataType.Numeric),
        new JdeField("IMAEXP", "IMAEXP", JdeDataType.Numeric),
        new JdeField("IMDSCT", "IMDSCT", JdeDataType.Numeric),
        new JdeField("IMBRROM", "IMBRROM", JdeDataType.String, 24),
        new JdeField("IMABCX", "IMABCX", JdeDataType.Numeric),
        new JdeField("IMBFRT", "IMBFRT", JdeDataType.Numeric),
        new JdeField("IMSCRC", "IMSCRC", JdeDataType.Numeric),
        new JdeField("IMAOTH", "IMAOTH", JdeDataType.Numeric),
        new JdeField("IMTM01", "IMTM01", JdeDataType.String, 4),
        new JdeField("IMBRIPID", "IMBRIPID", JdeDataType.String, 2),
        new JdeField("IMBRPCIPI", "IMBRPCIPI", JdeDataType.Numeric),
        new JdeField("IMBIPR", "IMBIPR", JdeDataType.Numeric),
        new JdeField("IMBIPI", "IMBIPI", JdeDataType.Numeric),
        new JdeField("IMBRSTEA", "IMBRSTEA", JdeDataType.String, 2),
        new JdeField("IMBRSTEB", "IMBRSTEB", JdeDataType.String, 2),
        new JdeField("IMBRIIC", "IMBRIIC", JdeDataType.String, 2),
        new JdeField("IMBRPICM", "IMBRPICM", JdeDataType.Numeric),
        new JdeField("IMBBCL", "IMBBCL", JdeDataType.Numeric),
        new JdeField("IMBICP", "IMBICP", JdeDataType.Numeric),
        new JdeField("IMBVIS", "IMBVIS", JdeDataType.Numeric),
        new JdeField("IMBICM", "IMBICM", JdeDataType.Numeric),
        new JdeField("IMBBIR", "IMBBIR", JdeDataType.Numeric),
        new JdeField("IMBRDFIC", "IMBRDFIC", JdeDataType.Numeric),
        new JdeField("IMUSER", "IMUSER", JdeDataType.String, 20),
        new JdeField("IMEAP", "IMEAP", JdeDataType.String, 20),
        new JdeField("IMJOBN", "IMJOBN", JdeDataType.String, 20),
        new JdeField("IMUPMJ", "IMUPMJ", JdeDataType.Numeric),
        new JdeField("IMUPMT", "IMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B31_0", "Primary Key on IMCO, IMBRINM, IMBRSSR, IMBRNNF, IMAT1, IMAN8, IMLID0", new[] { "IMCO", "IMBRINM", "IMBRSSR", "IMBRNNF", "IMAT1", "IMAN8", "IMLID0" }, isUnique: true, isPrimaryKey: true)
    };
}
