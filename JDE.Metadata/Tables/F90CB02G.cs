using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CB02G - .
/// </summary>
public class F90CB02G : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OGPRAN8.
        /// </summary>
        public const string OGPRAN8 = "OGPRAN8";

        /// <summary>
        /// OGOPPID.
        /// </summary>
        public const string OGOPPID = "OGOPPID";

        /// <summary>
        /// OGSTSUDT.
        /// </summary>
        public const string OGSTSUDT = "OGSTSUDT";

        /// <summary>
        /// OGACTIND.
        /// </summary>
        public const string OGACTIND = "OGACTIND";

        /// <summary>
        /// OGUSER.
        /// </summary>
        public const string OGUSER = "OGUSER";

        /// <summary>
        /// OGPID.
        /// </summary>
        public const string OGPID = "OGPID";

        /// <summary>
        /// OGVID.
        /// </summary>
        public const string OGVID = "OGVID";

        /// <summary>
        /// OGMKEY.
        /// </summary>
        public const string OGMKEY = "OGMKEY";

        /// <summary>
        /// OGUDTTM.
        /// </summary>
        public const string OGUDTTM = "OGUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CB02G";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OGPRAN8", "OGPRAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("OGOPPID", "OGOPPID", JdeDataType.Numeric, null, true, true),
        new JdeField("OGSTSUDT", "OGSTSUDT", JdeDataType.Date),
        new JdeField("OGACTIND", "OGACTIND", JdeDataType.String, 2),
        new JdeField("OGUSER", "OGUSER", JdeDataType.String, 20),
        new JdeField("OGPID", "OGPID", JdeDataType.String, 20),
        new JdeField("OGVID", "OGVID", JdeDataType.String, 20),
        new JdeField("OGMKEY", "OGMKEY", JdeDataType.String, 30),
        new JdeField("OGUDTTM", "OGUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CB02G_0", "Primary Key on OGPRAN8, OGOPPID", new[] { "OGPRAN8", "OGOPPID" }, isUnique: true, isPrimaryKey: true)
    };
}
