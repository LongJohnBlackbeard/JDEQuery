using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA60E - .
/// </summary>
public class F90CA60E : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ACACTIVID.
        /// </summary>
        public const string ACACTIVID = "ACACTIVID";

        /// <summary>
        /// ACLEADID.
        /// </summary>
        public const string ACLEADID = "ACLEADID";

        /// <summary>
        /// ACUDTTM.
        /// </summary>
        public const string ACUDTTM = "ACUDTTM";

        /// <summary>
        /// ACUSER.
        /// </summary>
        public const string ACUSER = "ACUSER";

        /// <summary>
        /// ACEDATE.
        /// </summary>
        public const string ACEDATE = "ACEDATE";

        /// <summary>
        /// ACMKEY.
        /// </summary>
        public const string ACMKEY = "ACMKEY";

        /// <summary>
        /// ACENTDBY.
        /// </summary>
        public const string ACENTDBY = "ACENTDBY";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA60E";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ACACTIVID", "ACACTIVID", JdeDataType.String, 72, true, true),
        new JdeField("ACLEADID", "ACLEADID", JdeDataType.Numeric, null, true, true),
        new JdeField("ACUDTTM", "ACUDTTM", JdeDataType.Date),
        new JdeField("ACUSER", "ACUSER", JdeDataType.String, 20),
        new JdeField("ACEDATE", "ACEDATE", JdeDataType.Date),
        new JdeField("ACMKEY", "ACMKEY", JdeDataType.String, 30),
        new JdeField("ACENTDBY", "ACENTDBY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA60E_0", "Primary Key on ACACTIVID, ACLEADID", new[] { "ACACTIVID", "ACLEADID" }, isUnique: true, isPrimaryKey: true)
    };
}
