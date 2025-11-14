using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA61E - .
/// </summary>
public class F90CA61E : JdeTable
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
        /// ACOPPID.
        /// </summary>
        public const string ACOPPID = "ACOPPID";

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
    public override string TableName => "F90CA61E";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ACACTIVID", "ACACTIVID", JdeDataType.String, 72, true, true),
        new JdeField("ACOPPID", "ACOPPID", JdeDataType.Numeric, null, true, true),
        new JdeField("ACUDTTM", "ACUDTTM", JdeDataType.Date),
        new JdeField("ACUSER", "ACUSER", JdeDataType.String, 20),
        new JdeField("ACEDATE", "ACEDATE", JdeDataType.Date),
        new JdeField("ACMKEY", "ACMKEY", JdeDataType.String, 30),
        new JdeField("ACENTDBY", "ACENTDBY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA61E_0", "Primary Key on ACACTIVID, ACOPPID", new[] { "ACACTIVID", "ACOPPID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CA61E_2", "Index on ACOPPID", new[] { "ACOPPID" })
    };
}
