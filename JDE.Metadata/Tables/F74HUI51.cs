using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74HUI51 - .
/// </summary>
public class F74HUI51 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFJOBS.
        /// </summary>
        public const string WFJOBS = "WFJOBS";

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
        /// WFK74FLEN.
        /// </summary>
        public const string WFK74FLEN = "WFK74FLEN";

        /// <summary>
        /// WFINT04.
        /// </summary>
        public const string WFINT04 = "WFINT04";

        /// <summary>
        /// WFEMID.
        /// </summary>
        public const string WFEMID = "WFEMID";

        /// <summary>
        /// WFUSER.
        /// </summary>
        public const string WFUSER = "WFUSER";

        /// <summary>
        /// WFPID.
        /// </summary>
        public const string WFPID = "WFPID";

        /// <summary>
        /// WFJOBN.
        /// </summary>
        public const string WFJOBN = "WFJOBN";

        /// <summary>
        /// WFUPMJ.
        /// </summary>
        public const string WFUPMJ = "WFUPMJ";

        /// <summary>
        /// WFUPMT.
        /// </summary>
        public const string WFUPMT = "WFUPMT";

        /// <summary>
        /// WFH74FUTDT.
        /// </summary>
        public const string WFH74FUTDT = "WFH74FUTDT";

        /// <summary>
        /// WFH74FUTNM.
        /// </summary>
        public const string WFH74FUTNM = "WFH74FUTNM";

        /// <summary>
        /// WFFUT6.
        /// </summary>
        public const string WFFUT6 = "WFFUT6";

        /// <summary>
        /// WFX2.
        /// </summary>
        public const string WFX2 = "WFX2";

        /// <summary>
        /// WFH74FUTCH.
        /// </summary>
        public const string WFH74FUTCH = "WFH74FUTCH";
    }

    /// <inheritdoc />
    public override string TableName => "F74HUI51";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFJOBS", "WFJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WFKCO", "WFKCO", JdeDataType.String, 10, true, true),
        new JdeField("WFDCT", "WFDCT", JdeDataType.String, 4, true, true),
        new JdeField("WFDOC", "WFDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("WFK74FLEN", "WFK74FLEN", JdeDataType.String, 50),
        new JdeField("WFINT04", "WFINT04", JdeDataType.Numeric),
        new JdeField("WFEMID", "WFEMID", JdeDataType.String, 20),
        new JdeField("WFUSER", "WFUSER", JdeDataType.String, 20, true, true),
        new JdeField("WFPID", "WFPID", JdeDataType.String, 20),
        new JdeField("WFJOBN", "WFJOBN", JdeDataType.String, 20),
        new JdeField("WFUPMJ", "WFUPMJ", JdeDataType.Numeric),
        new JdeField("WFUPMT", "WFUPMT", JdeDataType.Numeric),
        new JdeField("WFH74FUTDT", "WFH74FUTDT", JdeDataType.Numeric),
        new JdeField("WFH74FUTNM", "WFH74FUTNM", JdeDataType.Numeric),
        new JdeField("WFFUT6", "WFFUT6", JdeDataType.String, 60),
        new JdeField("WFX2", "WFX2", JdeDataType.String, 2),
        new JdeField("WFH74FUTCH", "WFH74FUTCH", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74HUI51_0", "Primary Key on WFJOBS, WFUSER, WFKCO, WFDCT, WFDOC", new[] { "WFJOBS", "WFUSER", "WFKCO", "WFDCT", "WFDOC" }, isUnique: true, isPrimaryKey: true)
    };
}
