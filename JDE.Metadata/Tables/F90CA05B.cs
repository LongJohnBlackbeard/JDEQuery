using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA05B - .
/// </summary>
public class F90CA05B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PBPRAN8.
        /// </summary>
        public const string PBPRAN8 = "PBPRAN8";

        /// <summary>
        /// PBITM.
        /// </summary>
        public const string PBITM = "PBITM";

        /// <summary>
        /// PBSTSUDT.
        /// </summary>
        public const string PBSTSUDT = "PBSTSUDT";

        /// <summary>
        /// PBACTIND.
        /// </summary>
        public const string PBACTIND = "PBACTIND";

        /// <summary>
        /// PBUSER.
        /// </summary>
        public const string PBUSER = "PBUSER";

        /// <summary>
        /// PBPID.
        /// </summary>
        public const string PBPID = "PBPID";

        /// <summary>
        /// PBVID.
        /// </summary>
        public const string PBVID = "PBVID";

        /// <summary>
        /// PBMKEY.
        /// </summary>
        public const string PBMKEY = "PBMKEY";

        /// <summary>
        /// PBUDTTM.
        /// </summary>
        public const string PBUDTTM = "PBUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA05B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PBPRAN8", "PBPRAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PBITM", "PBITM", JdeDataType.Numeric, null, true, true),
        new JdeField("PBSTSUDT", "PBSTSUDT", JdeDataType.Date),
        new JdeField("PBACTIND", "PBACTIND", JdeDataType.String, 2),
        new JdeField("PBUSER", "PBUSER", JdeDataType.String, 20),
        new JdeField("PBPID", "PBPID", JdeDataType.String, 20),
        new JdeField("PBVID", "PBVID", JdeDataType.String, 20),
        new JdeField("PBMKEY", "PBMKEY", JdeDataType.String, 30),
        new JdeField("PBUDTTM", "PBUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA05B_0", "Primary Key on PBPRAN8, PBITM", new[] { "PBPRAN8", "PBITM" }, isUnique: true, isPrimaryKey: true)
    };
}
