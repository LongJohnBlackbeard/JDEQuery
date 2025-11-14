using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW963 - .
/// </summary>
public class FCW963 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ACJOBS.
        /// </summary>
        public const string ACJOBS = "ACJOBS";

        /// <summary>
        /// ACUKID.
        /// </summary>
        public const string ACUKID = "ACUKID";

        /// <summary>
        /// ACITM.
        /// </summary>
        public const string ACITM = "ACITM";

        /// <summary>
        /// ACLITM.
        /// </summary>
        public const string ACLITM = "ACLITM";

        /// <summary>
        /// ACAITM.
        /// </summary>
        public const string ACAITM = "ACAITM";

        /// <summary>
        /// ACMCU.
        /// </summary>
        public const string ACMCU = "ACMCU";

        /// <summary>
        /// ACDSC1.
        /// </summary>
        public const string ACDSC1 = "ACDSC1";

        /// <summary>
        /// ACTRQT.
        /// </summary>
        public const string ACTRQT = "ACTRQT";

        /// <summary>
        /// ACSOQS.
        /// </summary>
        public const string ACSOQS = "ACSOQS";

        /// <summary>
        /// ACUSER.
        /// </summary>
        public const string ACUSER = "ACUSER";

        /// <summary>
        /// ACPID.
        /// </summary>
        public const string ACPID = "ACPID";

        /// <summary>
        /// ACJOBN.
        /// </summary>
        public const string ACJOBN = "ACJOBN";

        /// <summary>
        /// ACUPMJ.
        /// </summary>
        public const string ACUPMJ = "ACUPMJ";

        /// <summary>
        /// ACUPMT.
        /// </summary>
        public const string ACUPMT = "ACUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "FCW963";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ACJOBS", "ACJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("ACUKID", "ACUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("ACITM", "ACITM", JdeDataType.Numeric, null, true, true),
        new JdeField("ACLITM", "ACLITM", JdeDataType.String, 50),
        new JdeField("ACAITM", "ACAITM", JdeDataType.String, 50),
        new JdeField("ACMCU", "ACMCU", JdeDataType.String, 24, true, true),
        new JdeField("ACDSC1", "ACDSC1", JdeDataType.String, 60),
        new JdeField("ACTRQT", "ACTRQT", JdeDataType.Numeric),
        new JdeField("ACSOQS", "ACSOQS", JdeDataType.Numeric),
        new JdeField("ACUSER", "ACUSER", JdeDataType.String, 20),
        new JdeField("ACPID", "ACPID", JdeDataType.String, 20),
        new JdeField("ACJOBN", "ACJOBN", JdeDataType.String, 20),
        new JdeField("ACUPMJ", "ACUPMJ", JdeDataType.Numeric),
        new JdeField("ACUPMT", "ACUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW963_0", "Primary Key on ACJOBS, ACUKID, ACITM, ACMCU", new[] { "ACJOBS", "ACUKID", "ACITM", "ACMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
