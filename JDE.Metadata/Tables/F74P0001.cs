using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74P0001 - .
/// </summary>
public class F74P0001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ETEFT.
        /// </summary>
        public const string ETEFT = "ETEFT";

        /// <summary>
        /// ETP74ETNO.
        /// </summary>
        public const string ETP74ETNO = "ETP74ETNO";

        /// <summary>
        /// ETUSER.
        /// </summary>
        public const string ETUSER = "ETUSER";

        /// <summary>
        /// ETPID.
        /// </summary>
        public const string ETPID = "ETPID";

        /// <summary>
        /// ETUPMJ.
        /// </summary>
        public const string ETUPMJ = "ETUPMJ";

        /// <summary>
        /// ETUPMT.
        /// </summary>
        public const string ETUPMT = "ETUPMT";

        /// <summary>
        /// ETJOBN.
        /// </summary>
        public const string ETJOBN = "ETJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74P0001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ETEFT", "ETEFT", JdeDataType.Numeric, null, true, true),
        new JdeField("ETP74ETNO", "ETP74ETNO", JdeDataType.String, 60),
        new JdeField("ETUSER", "ETUSER", JdeDataType.String, 20),
        new JdeField("ETPID", "ETPID", JdeDataType.String, 20),
        new JdeField("ETUPMJ", "ETUPMJ", JdeDataType.Numeric),
        new JdeField("ETUPMT", "ETUPMT", JdeDataType.Numeric),
        new JdeField("ETJOBN", "ETJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74P0001_0", "Primary Key on ETEFT", new[] { "ETEFT" }, isUnique: true, isPrimaryKey: true)
    };
}
