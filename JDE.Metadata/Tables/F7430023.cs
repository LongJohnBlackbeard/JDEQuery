using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7430023 - .
/// </summary>
public class F7430023 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LDK74LECO.
        /// </summary>
        public const string LDK74LECO = "LDK74LECO";

        /// <summary>
        /// LDK74LEDT.
        /// </summary>
        public const string LDK74LEDT = "LDK74LEDT";

        /// <summary>
        /// LDK74IDFR.
        /// </summary>
        public const string LDK74IDFR = "LDK74IDFR";

        /// <summary>
        /// LDUSER.
        /// </summary>
        public const string LDUSER = "LDUSER";

        /// <summary>
        /// LDPID.
        /// </summary>
        public const string LDPID = "LDPID";

        /// <summary>
        /// LDJOBN.
        /// </summary>
        public const string LDJOBN = "LDJOBN";

        /// <summary>
        /// LDUPMT.
        /// </summary>
        public const string LDUPMT = "LDUPMT";

        /// <summary>
        /// LDUPMJ.
        /// </summary>
        public const string LDUPMJ = "LDUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F7430023";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LDK74LECO", "LDK74LECO", JdeDataType.String, 10, true, true),
        new JdeField("LDK74LEDT", "LDK74LEDT", JdeDataType.String, 10, true, true),
        new JdeField("LDK74IDFR", "LDK74IDFR", JdeDataType.String, 6),
        new JdeField("LDUSER", "LDUSER", JdeDataType.String, 20),
        new JdeField("LDPID", "LDPID", JdeDataType.String, 20),
        new JdeField("LDJOBN", "LDJOBN", JdeDataType.String, 20),
        new JdeField("LDUPMT", "LDUPMT", JdeDataType.Numeric),
        new JdeField("LDUPMJ", "LDUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7430023_0", "Primary Key on LDK74LECO, LDK74LEDT", new[] { "LDK74LECO", "LDK74LEDT" }, isUnique: true, isPrimaryKey: true)
    };
}
