using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CB02C - .
/// </summary>
public class F90CB02C : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OCOPPID.
        /// </summary>
        public const string OCOPPID = "OCOPPID";

        /// <summary>
        /// OCCMAN8.
        /// </summary>
        public const string OCCMAN8 = "OCCMAN8";

        /// <summary>
        /// OCSTSUDT.
        /// </summary>
        public const string OCSTSUDT = "OCSTSUDT";

        /// <summary>
        /// OCACTIND.
        /// </summary>
        public const string OCACTIND = "OCACTIND";

        /// <summary>
        /// OCUSER.
        /// </summary>
        public const string OCUSER = "OCUSER";

        /// <summary>
        /// OCPID.
        /// </summary>
        public const string OCPID = "OCPID";

        /// <summary>
        /// OCVID.
        /// </summary>
        public const string OCVID = "OCVID";

        /// <summary>
        /// OCMKEY.
        /// </summary>
        public const string OCMKEY = "OCMKEY";

        /// <summary>
        /// OCUDTTM.
        /// </summary>
        public const string OCUDTTM = "OCUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CB02C";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OCOPPID", "OCOPPID", JdeDataType.Numeric, null, true, true),
        new JdeField("OCCMAN8", "OCCMAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("OCSTSUDT", "OCSTSUDT", JdeDataType.Date),
        new JdeField("OCACTIND", "OCACTIND", JdeDataType.String, 2),
        new JdeField("OCUSER", "OCUSER", JdeDataType.String, 20),
        new JdeField("OCPID", "OCPID", JdeDataType.String, 20),
        new JdeField("OCVID", "OCVID", JdeDataType.String, 20),
        new JdeField("OCMKEY", "OCMKEY", JdeDataType.String, 30),
        new JdeField("OCUDTTM", "OCUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CB02C_0", "Primary Key on OCOPPID, OCCMAN8", new[] { "OCOPPID", "OCCMAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CB02C_2", "Index on OCCMAN8, OCOPPID", new[] { "OCCMAN8", "OCOPPID" })
    };
}
