using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76HUI33 - .
/// </summary>
public class F76HUI33 : JdeTable
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
        /// WFH76LECO.
        /// </summary>
        public const string WFH76LECO = "WFH76LECO";

        /// <summary>
        /// WFH76LEDT.
        /// </summary>
        public const string WFH76LEDT = "WFH76LEDT";

        /// <summary>
        /// WFH76EMS.
        /// </summary>
        public const string WFH76EMS = "WFH76EMS";

        /// <summary>
        /// WFH76LENU.
        /// </summary>
        public const string WFH76LENU = "WFH76LENU";

        /// <summary>
        /// WFTXA1.
        /// </summary>
        public const string WFTXA1 = "WFTXA1";

        /// <summary>
        /// WFEXR1.
        /// </summary>
        public const string WFEXR1 = "WFEXR1";

        /// <summary>
        /// WFDIVJ.
        /// </summary>
        public const string WFDIVJ = "WFDIVJ";

        /// <summary>
        /// WFDTAI.
        /// </summary>
        public const string WFDTAI = "WFDTAI";

        /// <summary>
        /// WFH76NN.
        /// </summary>
        public const string WFH76NN = "WFH76NN";

        /// <summary>
        /// WFH76NNFR.
        /// </summary>
        public const string WFH76NNFR = "WFH76NNFR";

        /// <summary>
        /// WFH76NNTO.
        /// </summary>
        public const string WFH76NNTO = "WFH76NNTO";

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
    public override string TableName => "F76HUI33";

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
        new JdeField("WFH76LECO", "WFH76LECO", JdeDataType.String, 10),
        new JdeField("WFH76LEDT", "WFH76LEDT", JdeDataType.String, 6),
        new JdeField("WFH76EMS", "WFH76EMS", JdeDataType.String, 8),
        new JdeField("WFH76LENU", "WFH76LENU", JdeDataType.Numeric),
        new JdeField("WFTXA1", "WFTXA1", JdeDataType.String, 20),
        new JdeField("WFEXR1", "WFEXR1", JdeDataType.String, 4),
        new JdeField("WFDIVJ", "WFDIVJ", JdeDataType.Numeric),
        new JdeField("WFDTAI", "WFDTAI", JdeDataType.String, 20),
        new JdeField("WFH76NN", "WFH76NN", JdeDataType.Numeric),
        new JdeField("WFH76NNFR", "WFH76NNFR", JdeDataType.Numeric),
        new JdeField("WFH76NNTO", "WFH76NNTO", JdeDataType.Numeric),
        new JdeField("WFUPMT", "WFUPMT", JdeDataType.Numeric),
        new JdeField("WFUSER", "WFUSER", JdeDataType.String, 20),
        new JdeField("WFUPMJ", "WFUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76HUI33_0", "Primary Key on WFCTID, WFJOBS, WFCSQ", new[] { "WFCTID", "WFJOBS", "WFCSQ" }, isUnique: true, isPrimaryKey: true)
    };
}
