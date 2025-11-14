using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CE01D - .
/// </summary>
public class F90CE01D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SPSLTNID.
        /// </summary>
        public const string SPSLTNID = "SPSLTNID";

        /// <summary>
        /// SPITM.
        /// </summary>
        public const string SPITM = "SPITM";

        /// <summary>
        /// SPSETID.
        /// </summary>
        public const string SPSETID = "SPSETID";

        /// <summary>
        /// SPENTDBY.
        /// </summary>
        public const string SPENTDBY = "SPENTDBY";

        /// <summary>
        /// SPEDATE.
        /// </summary>
        public const string SPEDATE = "SPEDATE";

        /// <summary>
        /// SPUSER.
        /// </summary>
        public const string SPUSER = "SPUSER";

        /// <summary>
        /// SPUDTTM.
        /// </summary>
        public const string SPUDTTM = "SPUDTTM";

        /// <summary>
        /// SPMKEY.
        /// </summary>
        public const string SPMKEY = "SPMKEY";
    }

    /// <inheritdoc />
    public override string TableName => "F90CE01D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SPSLTNID", "SPSLTNID", JdeDataType.Numeric, null, true, true),
        new JdeField("SPITM", "SPITM", JdeDataType.Numeric, null, true, true),
        new JdeField("SPSETID", "SPSETID", JdeDataType.String, 10),
        new JdeField("SPENTDBY", "SPENTDBY", JdeDataType.Numeric),
        new JdeField("SPEDATE", "SPEDATE", JdeDataType.Date),
        new JdeField("SPUSER", "SPUSER", JdeDataType.String, 20),
        new JdeField("SPUDTTM", "SPUDTTM", JdeDataType.Date),
        new JdeField("SPMKEY", "SPMKEY", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CE01D_0", "Primary Key on SPSLTNID, SPITM", new[] { "SPSLTNID", "SPITM" }, isUnique: true, isPrimaryKey: true)
    };
}
