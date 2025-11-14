using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA180 - .
/// </summary>
public class F90CA180 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TAUKID.
        /// </summary>
        public const string TAUKID = "TAUKID";

        /// <summary>
        /// TATERRID.
        /// </summary>
        public const string TATERRID = "TATERRID";

        /// <summary>
        /// TACOMDATE.
        /// </summary>
        public const string TACOMDATE = "TACOMDATE";

        /// <summary>
        /// TAEDATE.
        /// </summary>
        public const string TAEDATE = "TAEDATE";

        /// <summary>
        /// TASTSUDT.
        /// </summary>
        public const string TASTSUDT = "TASTSUDT";

        /// <summary>
        /// TAACTIND.
        /// </summary>
        public const string TAACTIND = "TAACTIND";

        /// <summary>
        /// TAUSER.
        /// </summary>
        public const string TAUSER = "TAUSER";

        /// <summary>
        /// TAPID.
        /// </summary>
        public const string TAPID = "TAPID";

        /// <summary>
        /// TAVID.
        /// </summary>
        public const string TAVID = "TAVID";

        /// <summary>
        /// TAMKEY.
        /// </summary>
        public const string TAMKEY = "TAMKEY";

        /// <summary>
        /// TAUDTTM.
        /// </summary>
        public const string TAUDTTM = "TAUDTTM";

        /// <summary>
        /// TAENTDBY.
        /// </summary>
        public const string TAENTDBY = "TAENTDBY";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA180";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TAUKID", "TAUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("TATERRID", "TATERRID", JdeDataType.Numeric, null, true, true),
        new JdeField("TACOMDATE", "TACOMDATE", JdeDataType.Date),
        new JdeField("TAEDATE", "TAEDATE", JdeDataType.Date),
        new JdeField("TASTSUDT", "TASTSUDT", JdeDataType.Date),
        new JdeField("TAACTIND", "TAACTIND", JdeDataType.String, 2),
        new JdeField("TAUSER", "TAUSER", JdeDataType.String, 20),
        new JdeField("TAPID", "TAPID", JdeDataType.String, 20),
        new JdeField("TAVID", "TAVID", JdeDataType.String, 20),
        new JdeField("TAMKEY", "TAMKEY", JdeDataType.String, 30),
        new JdeField("TAUDTTM", "TAUDTTM", JdeDataType.Date),
        new JdeField("TAENTDBY", "TAENTDBY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA180_0", "Primary Key on TATERRID, TAUKID", new[] { "TATERRID", "TAUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CA180_2", "Index on TACOMDATE", new[] { "TACOMDATE" })
    };
}
