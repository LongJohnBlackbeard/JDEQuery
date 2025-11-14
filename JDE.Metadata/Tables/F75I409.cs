using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I409 - .
/// </summary>
public class F75I409 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VSI75RSCD.
        /// </summary>
        public const string VSI75RSCD = "VSI75RSCD";

        /// <summary>
        /// VSDSC2.
        /// </summary>
        public const string VSDSC2 = "VSDSC2";

        /// <summary>
        /// VSREMK.
        /// </summary>
        public const string VSREMK = "VSREMK";

        /// <summary>
        /// VSI75CNQY.
        /// </summary>
        public const string VSI75CNQY = "VSI75CNQY";

        /// <summary>
        /// VSYTDU.
        /// </summary>
        public const string VSYTDU = "VSYTDU";

        /// <summary>
        /// VSKCOO.
        /// </summary>
        public const string VSKCOO = "VSKCOO";

        /// <summary>
        /// VSDOCO.
        /// </summary>
        public const string VSDOCO = "VSDOCO";

        /// <summary>
        /// VSDCTO.
        /// </summary>
        public const string VSDCTO = "VSDCTO";

        /// <summary>
        /// VSKCO.
        /// </summary>
        public const string VSKCO = "VSKCO";

        /// <summary>
        /// VSDOC.
        /// </summary>
        public const string VSDOC = "VSDOC";

        /// <summary>
        /// VSDCT.
        /// </summary>
        public const string VSDCT = "VSDCT";

        /// <summary>
        /// VSMATC.
        /// </summary>
        public const string VSMATC = "VSMATC";

        /// <summary>
        /// VSLNID.
        /// </summary>
        public const string VSLNID = "VSLNID";

        /// <summary>
        /// VSLOTN.
        /// </summary>
        public const string VSLOTN = "VSLOTN";

        /// <summary>
        /// VSLOCN.
        /// </summary>
        public const string VSLOCN = "VSLOCN";

        /// <summary>
        /// VSMCU.
        /// </summary>
        public const string VSMCU = "VSMCU";

        /// <summary>
        /// VSLITM.
        /// </summary>
        public const string VSLITM = "VSLITM";

        /// <summary>
        /// VSAITM.
        /// </summary>
        public const string VSAITM = "VSAITM";

        /// <summary>
        /// VSUOM.
        /// </summary>
        public const string VSUOM = "VSUOM";

        /// <summary>
        /// VSQTYS.
        /// </summary>
        public const string VSQTYS = "VSQTYS";

        /// <summary>
        /// VSCRCD.
        /// </summary>
        public const string VSCRCD = "VSCRCD";

        /// <summary>
        /// VSAEXP.
        /// </summary>
        public const string VSAEXP = "VSAEXP";

        /// <summary>
        /// VSTORG.
        /// </summary>
        public const string VSTORG = "VSTORG";

        /// <summary>
        /// VSUSER.
        /// </summary>
        public const string VSUSER = "VSUSER";

        /// <summary>
        /// VSJOBN.
        /// </summary>
        public const string VSJOBN = "VSJOBN";

        /// <summary>
        /// VSPID.
        /// </summary>
        public const string VSPID = "VSPID";

        /// <summary>
        /// VSUPMJ.
        /// </summary>
        public const string VSUPMJ = "VSUPMJ";

        /// <summary>
        /// VSUPMT.
        /// </summary>
        public const string VSUPMT = "VSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75I409";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VSI75RSCD", "VSI75RSCD", JdeDataType.String, 10, true, true),
        new JdeField("VSDSC2", "VSDSC2", JdeDataType.String, 60),
        new JdeField("VSREMK", "VSREMK", JdeDataType.String, 60),
        new JdeField("VSI75CNQY", "VSI75CNQY", JdeDataType.Numeric),
        new JdeField("VSYTDU", "VSYTDU", JdeDataType.Numeric),
        new JdeField("VSKCOO", "VSKCOO", JdeDataType.String, 10, true, true),
        new JdeField("VSDOCO", "VSDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("VSDCTO", "VSDCTO", JdeDataType.String, 4, true, true),
        new JdeField("VSKCO", "VSKCO", JdeDataType.String, 10),
        new JdeField("VSDOC", "VSDOC", JdeDataType.Numeric),
        new JdeField("VSDCT", "VSDCT", JdeDataType.String, 4),
        new JdeField("VSMATC", "VSMATC", JdeDataType.String, 2, true, true),
        new JdeField("VSLNID", "VSLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("VSLOTN", "VSLOTN", JdeDataType.String, 60),
        new JdeField("VSLOCN", "VSLOCN", JdeDataType.String, 40),
        new JdeField("VSMCU", "VSMCU", JdeDataType.String, 24, true, true),
        new JdeField("VSLITM", "VSLITM", JdeDataType.String, 50, true, true),
        new JdeField("VSAITM", "VSAITM", JdeDataType.String, 50),
        new JdeField("VSUOM", "VSUOM", JdeDataType.String, 4),
        new JdeField("VSQTYS", "VSQTYS", JdeDataType.Numeric),
        new JdeField("VSCRCD", "VSCRCD", JdeDataType.String, 6),
        new JdeField("VSAEXP", "VSAEXP", JdeDataType.Numeric),
        new JdeField("VSTORG", "VSTORG", JdeDataType.String, 20),
        new JdeField("VSUSER", "VSUSER", JdeDataType.String, 20),
        new JdeField("VSJOBN", "VSJOBN", JdeDataType.String, 20),
        new JdeField("VSPID", "VSPID", JdeDataType.String, 20),
        new JdeField("VSUPMJ", "VSUPMJ", JdeDataType.Numeric),
        new JdeField("VSUPMT", "VSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I409_0", "Primary Key on VSI75RSCD, VSKCOO, VSDOCO, VSDCTO, VSMATC, VSLNID, VSMCU, VSLITM", new[] { "VSI75RSCD", "VSKCOO", "VSDOCO", "VSDCTO", "VSMATC", "VSLNID", "VSMCU", "VSLITM" }, isUnique: true, isPrimaryKey: true)
    };
}
