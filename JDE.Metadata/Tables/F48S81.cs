using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48S81 - .
/// </summary>
public class F48S81 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CMSEGMID.
        /// </summary>
        public const string CMSEGMID = "CMSEGMID";

        /// <summary>
        /// CMEFTB.
        /// </summary>
        public const string CMEFTB = "CMEFTB";

        /// <summary>
        /// CMBUCA.
        /// </summary>
        public const string CMBUCA = "CMBUCA";

        /// <summary>
        /// CMBCOM.
        /// </summary>
        public const string CMBCOM = "CMBCOM";

        /// <summary>
        /// CMABUC.
        /// </summary>
        public const string CMABUC = "CMABUC";

        /// <summary>
        /// CMILEL.
        /// </summary>
        public const string CMILEL = "CMILEL";

        /// <summary>
        /// CMUSER.
        /// </summary>
        public const string CMUSER = "CMUSER";

        /// <summary>
        /// CMPID.
        /// </summary>
        public const string CMPID = "CMPID";

        /// <summary>
        /// CMJOBN.
        /// </summary>
        public const string CMJOBN = "CMJOBN";

        /// <summary>
        /// CMUPMJ.
        /// </summary>
        public const string CMUPMJ = "CMUPMJ";

        /// <summary>
        /// CMUPMT.
        /// </summary>
        public const string CMUPMT = "CMUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F48S81";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CMSEGMID", "CMSEGMID", JdeDataType.String, 6, true, true),
        new JdeField("CMEFTB", "CMEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("CMBUCA", "CMBUCA", JdeDataType.String, 10, true, true),
        new JdeField("CMBCOM", "CMBCOM", JdeDataType.String, 6, true, true),
        new JdeField("CMABUC", "CMABUC", JdeDataType.String, 10, true, true),
        new JdeField("CMILEL", "CMILEL", JdeDataType.String, 2),
        new JdeField("CMUSER", "CMUSER", JdeDataType.String, 20),
        new JdeField("CMPID", "CMPID", JdeDataType.String, 20),
        new JdeField("CMJOBN", "CMJOBN", JdeDataType.String, 20),
        new JdeField("CMUPMJ", "CMUPMJ", JdeDataType.Numeric),
        new JdeField("CMUPMT", "CMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48S81_0", "Primary Key on CMSEGMID, CMEFTB, CMBUCA, CMBCOM, CMABUC", new[] { "CMSEGMID", "CMEFTB", "CMBUCA", "CMBCOM", "CMABUC" }, isUnique: true, isPrimaryKey: true)
    };
}
