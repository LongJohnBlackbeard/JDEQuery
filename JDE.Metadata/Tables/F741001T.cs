using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F741001T - .
/// </summary>
public class F741001T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ATAN8.
        /// </summary>
        public const string ATAN8 = "ATAN8";

        /// <summary>
        /// ATK74VC.
        /// </summary>
        public const string ATK74VC = "ATK74VC";

        /// <summary>
        /// ATUSER.
        /// </summary>
        public const string ATUSER = "ATUSER";

        /// <summary>
        /// ATPID.
        /// </summary>
        public const string ATPID = "ATPID";

        /// <summary>
        /// ATJOBN.
        /// </summary>
        public const string ATJOBN = "ATJOBN";

        /// <summary>
        /// ATUPMJ.
        /// </summary>
        public const string ATUPMJ = "ATUPMJ";

        /// <summary>
        /// ATUPMT.
        /// </summary>
        public const string ATUPMT = "ATUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F741001T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ATAN8", "ATAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ATK74VC", "ATK74VC", JdeDataType.String, 6),
        new JdeField("ATUSER", "ATUSER", JdeDataType.String, 20),
        new JdeField("ATPID", "ATPID", JdeDataType.String, 20),
        new JdeField("ATJOBN", "ATJOBN", JdeDataType.String, 20),
        new JdeField("ATUPMJ", "ATUPMJ", JdeDataType.Numeric),
        new JdeField("ATUPMT", "ATUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F741001T_0", "Primary Key on ATAN8", new[] { "ATAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
