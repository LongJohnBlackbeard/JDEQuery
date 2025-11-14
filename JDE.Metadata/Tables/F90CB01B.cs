using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CB01B - .
/// </summary>
public class F90CB01B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LTLEADID.
        /// </summary>
        public const string LTLEADID = "LTLEADID";

        /// <summary>
        /// LTACTVID.
        /// </summary>
        public const string LTACTVID = "LTACTVID";

        /// <summary>
        /// LTSTSUDT.
        /// </summary>
        public const string LTSTSUDT = "LTSTSUDT";

        /// <summary>
        /// LTACTIND.
        /// </summary>
        public const string LTACTIND = "LTACTIND";

        /// <summary>
        /// LTUSER.
        /// </summary>
        public const string LTUSER = "LTUSER";

        /// <summary>
        /// LTPID.
        /// </summary>
        public const string LTPID = "LTPID";

        /// <summary>
        /// LTVID.
        /// </summary>
        public const string LTVID = "LTVID";

        /// <summary>
        /// LTMKEY.
        /// </summary>
        public const string LTMKEY = "LTMKEY";

        /// <summary>
        /// LTUDTTM.
        /// </summary>
        public const string LTUDTTM = "LTUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CB01B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LTLEADID", "LTLEADID", JdeDataType.Numeric, null, true, true),
        new JdeField("LTACTVID", "LTACTVID", JdeDataType.Numeric, null, true, true),
        new JdeField("LTSTSUDT", "LTSTSUDT", JdeDataType.Date),
        new JdeField("LTACTIND", "LTACTIND", JdeDataType.String, 2),
        new JdeField("LTUSER", "LTUSER", JdeDataType.String, 20),
        new JdeField("LTPID", "LTPID", JdeDataType.String, 20),
        new JdeField("LTVID", "LTVID", JdeDataType.String, 20),
        new JdeField("LTMKEY", "LTMKEY", JdeDataType.String, 30),
        new JdeField("LTUDTTM", "LTUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CB01B_0", "Primary Key on LTLEADID, LTACTVID", new[] { "LTLEADID", "LTACTVID" }, isUnique: true, isPrimaryKey: true)
    };
}
