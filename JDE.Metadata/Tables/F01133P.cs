using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F01133P - .
/// </summary>
public class F01133P : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZSMBDS.
        /// </summary>
        public const string ZSMBDS = "ZSMBDS";

        /// <summary>
        /// ZSOBNM.
        /// </summary>
        public const string ZSOBNM = "ZSOBNM";

        /// <summary>
        /// ZSFMNM.
        /// </summary>
        public const string ZSFMNM = "ZSFMNM";

        /// <summary>
        /// ZSVER.
        /// </summary>
        public const string ZSVER = "ZSVER";

        /// <summary>
        /// ZSUSER.
        /// </summary>
        public const string ZSUSER = "ZSUSER";

        /// <summary>
        /// ZSJOBN.
        /// </summary>
        public const string ZSJOBN = "ZSJOBN";

        /// <summary>
        /// ZSPID.
        /// </summary>
        public const string ZSPID = "ZSPID";

        /// <summary>
        /// ZSUPMJ.
        /// </summary>
        public const string ZSUPMJ = "ZSUPMJ";

        /// <summary>
        /// ZSTDAY.
        /// </summary>
        public const string ZSTDAY = "ZSTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F01133P";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZSMBDS", "ZSMBDS", JdeDataType.String, 4, true, true),
        new JdeField("ZSOBNM", "ZSOBNM", JdeDataType.String, 20),
        new JdeField("ZSFMNM", "ZSFMNM", JdeDataType.String, 20),
        new JdeField("ZSVER", "ZSVER", JdeDataType.String, 20),
        new JdeField("ZSUSER", "ZSUSER", JdeDataType.String, 20),
        new JdeField("ZSJOBN", "ZSJOBN", JdeDataType.String, 20),
        new JdeField("ZSPID", "ZSPID", JdeDataType.String, 20),
        new JdeField("ZSUPMJ", "ZSUPMJ", JdeDataType.Numeric),
        new JdeField("ZSTDAY", "ZSTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F01133P_0", "Primary Key on ZSMBDS", new[] { "ZSMBDS" }, isUnique: true, isPrimaryKey: true)
    };
}
