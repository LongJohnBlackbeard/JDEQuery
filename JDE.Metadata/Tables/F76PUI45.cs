using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76PUI45 - .
/// </summary>
public class F76PUI45 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFCTID.
        /// </summary>
        public const string WFCTID = "WFCTID";

        /// <summary>
        /// WFJOBS.
        /// </summary>
        public const string WFJOBS = "WFJOBS";

        /// <summary>
        /// WFCSQ.
        /// </summary>
        public const string WFCSQ = "WFCSQ";

        /// <summary>
        /// WFKCO.
        /// </summary>
        public const string WFKCO = "WFKCO";

        /// <summary>
        /// WFDCT.
        /// </summary>
        public const string WFDCT = "WFDCT";

        /// <summary>
        /// WFDOC.
        /// </summary>
        public const string WFDOC = "WFDOC";

        /// <summary>
        /// WFSFX.
        /// </summary>
        public const string WFSFX = "WFSFX";

        /// <summary>
        /// WFSFXE.
        /// </summary>
        public const string WFSFXE = "WFSFXE";

        /// <summary>
        /// WFDCTA.
        /// </summary>
        public const string WFDCTA = "WFDCTA";

        /// <summary>
        /// WFDTAI.
        /// </summary>
        public const string WFDTAI = "WFDTAI";

        /// <summary>
        /// WFTXA1.
        /// </summary>
        public const string WFTXA1 = "WFTXA1";

        /// <summary>
        /// WFUPMT.
        /// </summary>
        public const string WFUPMT = "WFUPMT";

        /// <summary>
        /// WFUSER.
        /// </summary>
        public const string WFUSER = "WFUSER";

        /// <summary>
        /// WFUPMJ.
        /// </summary>
        public const string WFUPMJ = "WFUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F76PUI45";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFCTID", "WFCTID", JdeDataType.String, 30, true, true),
        new JdeField("WFJOBS", "WFJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WFCSQ", "WFCSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("WFKCO", "WFKCO", JdeDataType.String, 10),
        new JdeField("WFDCT", "WFDCT", JdeDataType.String, 4),
        new JdeField("WFDOC", "WFDOC", JdeDataType.Numeric),
        new JdeField("WFSFX", "WFSFX", JdeDataType.String, 6),
        new JdeField("WFSFXE", "WFSFXE", JdeDataType.Numeric),
        new JdeField("WFDCTA", "WFDCTA", JdeDataType.String, 4),
        new JdeField("WFDTAI", "WFDTAI", JdeDataType.String, 20),
        new JdeField("WFTXA1", "WFTXA1", JdeDataType.String, 20),
        new JdeField("WFUPMT", "WFUPMT", JdeDataType.Numeric),
        new JdeField("WFUSER", "WFUSER", JdeDataType.String, 20),
        new JdeField("WFUPMJ", "WFUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76PUI45_0", "Primary Key on WFCTID, WFJOBS, WFCSQ", new[] { "WFCTID", "WFJOBS", "WFCSQ" }, isUnique: true, isPrimaryKey: true)
    };
}
