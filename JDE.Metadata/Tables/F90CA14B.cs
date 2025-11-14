using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA14B - .
/// </summary>
public class F90CA14B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TBTERRID.
        /// </summary>
        public const string TBTERRID = "TBTERRID";

        /// <summary>
        /// TBCNDRKY.
        /// </summary>
        public const string TBCNDRKY = "TBCNDRKY";

        /// <summary>
        /// TBSTSUDT.
        /// </summary>
        public const string TBSTSUDT = "TBSTSUDT";

        /// <summary>
        /// TBACTIND.
        /// </summary>
        public const string TBACTIND = "TBACTIND";

        /// <summary>
        /// TBUSER.
        /// </summary>
        public const string TBUSER = "TBUSER";

        /// <summary>
        /// TBPID.
        /// </summary>
        public const string TBPID = "TBPID";

        /// <summary>
        /// TBVID.
        /// </summary>
        public const string TBVID = "TBVID";

        /// <summary>
        /// TBMKEY.
        /// </summary>
        public const string TBMKEY = "TBMKEY";

        /// <summary>
        /// TBUDTTM.
        /// </summary>
        public const string TBUDTTM = "TBUDTTM";

        /// <summary>
        /// TBENTDBY.
        /// </summary>
        public const string TBENTDBY = "TBENTDBY";

        /// <summary>
        /// TBEDATE.
        /// </summary>
        public const string TBEDATE = "TBEDATE";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA14B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TBTERRID", "TBTERRID", JdeDataType.Numeric, null, true, true),
        new JdeField("TBCNDRKY", "TBCNDRKY", JdeDataType.String, 20, true, true),
        new JdeField("TBSTSUDT", "TBSTSUDT", JdeDataType.Date),
        new JdeField("TBACTIND", "TBACTIND", JdeDataType.String, 2),
        new JdeField("TBUSER", "TBUSER", JdeDataType.String, 20),
        new JdeField("TBPID", "TBPID", JdeDataType.String, 20),
        new JdeField("TBVID", "TBVID", JdeDataType.String, 20),
        new JdeField("TBMKEY", "TBMKEY", JdeDataType.String, 30),
        new JdeField("TBUDTTM", "TBUDTTM", JdeDataType.Date),
        new JdeField("TBENTDBY", "TBENTDBY", JdeDataType.Numeric),
        new JdeField("TBEDATE", "TBEDATE", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA14B_0", "Primary Key on TBTERRID, TBCNDRKY", new[] { "TBTERRID", "TBCNDRKY" }, isUnique: true, isPrimaryKey: true)
    };
}
