using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA64E - .
/// </summary>
public class F90CA64E : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ACDOCO.
        /// </summary>
        public const string ACDOCO = "ACDOCO";

        /// <summary>
        /// ACSTAW.
        /// </summary>
        public const string ACSTAW = "ACSTAW";

        /// <summary>
        /// ACACTIVID.
        /// </summary>
        public const string ACACTIVID = "ACACTIVID";

        /// <summary>
        /// ACUSER.
        /// </summary>
        public const string ACUSER = "ACUSER";

        /// <summary>
        /// ACDTEE.
        /// </summary>
        public const string ACDTEE = "ACDTEE";

        /// <summary>
        /// ACUDTTM.
        /// </summary>
        public const string ACUDTTM = "ACUDTTM";

        /// <summary>
        /// ACMKEY.
        /// </summary>
        public const string ACMKEY = "ACMKEY";

        /// <summary>
        /// ACENTRD.
        /// </summary>
        public const string ACENTRD = "ACENTRD";

        /// <summary>
        /// ACSTSUDT.
        /// </summary>
        public const string ACSTSUDT = "ACSTSUDT";

        /// <summary>
        /// ACACTIND.
        /// </summary>
        public const string ACACTIND = "ACACTIND";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA64E";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ACDOCO", "ACDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("ACSTAW", "ACSTAW", JdeDataType.String, 2, true, true),
        new JdeField("ACACTIVID", "ACACTIVID", JdeDataType.String, 72, true, true),
        new JdeField("ACUSER", "ACUSER", JdeDataType.String, 20),
        new JdeField("ACDTEE", "ACDTEE", JdeDataType.Date),
        new JdeField("ACUDTTM", "ACUDTTM", JdeDataType.Date),
        new JdeField("ACMKEY", "ACMKEY", JdeDataType.String, 30),
        new JdeField("ACENTRD", "ACENTRD", JdeDataType.Numeric),
        new JdeField("ACSTSUDT", "ACSTSUDT", JdeDataType.Date),
        new JdeField("ACACTIND", "ACACTIND", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA64E_0", "Primary Key on ACDOCO, ACSTAW, ACACTIVID", new[] { "ACDOCO", "ACSTAW", "ACACTIVID" }, isUnique: true, isPrimaryKey: true)
    };
}
