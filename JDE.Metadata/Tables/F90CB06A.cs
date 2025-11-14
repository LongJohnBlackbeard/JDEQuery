using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CB06A - .
/// </summary>
public class F90CB06A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FOFCID.
        /// </summary>
        public const string FOFCID = "FOFCID";

        /// <summary>
        /// FOOPPID.
        /// </summary>
        public const string FOOPPID = "FOOPPID";

        /// <summary>
        /// FOACTIND.
        /// </summary>
        public const string FOACTIND = "FOACTIND";

        /// <summary>
        /// FOSTSUDT.
        /// </summary>
        public const string FOSTSUDT = "FOSTSUDT";

        /// <summary>
        /// FOUSER.
        /// </summary>
        public const string FOUSER = "FOUSER";

        /// <summary>
        /// FOPID.
        /// </summary>
        public const string FOPID = "FOPID";

        /// <summary>
        /// FOVID.
        /// </summary>
        public const string FOVID = "FOVID";

        /// <summary>
        /// FOMKEY.
        /// </summary>
        public const string FOMKEY = "FOMKEY";

        /// <summary>
        /// FOUDTTM.
        /// </summary>
        public const string FOUDTTM = "FOUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CB06A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FOFCID", "FOFCID", JdeDataType.Numeric, null, true, true),
        new JdeField("FOOPPID", "FOOPPID", JdeDataType.Numeric, null, true, true),
        new JdeField("FOACTIND", "FOACTIND", JdeDataType.String, 2),
        new JdeField("FOSTSUDT", "FOSTSUDT", JdeDataType.Date),
        new JdeField("FOUSER", "FOUSER", JdeDataType.String, 20),
        new JdeField("FOPID", "FOPID", JdeDataType.String, 20),
        new JdeField("FOVID", "FOVID", JdeDataType.String, 20),
        new JdeField("FOMKEY", "FOMKEY", JdeDataType.String, 30),
        new JdeField("FOUDTTM", "FOUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CB06A_0", "Primary Key on FOFCID, FOOPPID", new[] { "FOFCID", "FOOPPID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CB06A_2", "Index on FOOPPID, FOFCID", new[] { "FOOPPID", "FOFCID" })
    };
}
