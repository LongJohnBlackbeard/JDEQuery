using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0901WS - .
/// </summary>
public class F0901WS : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WSSRCHWRD.
        /// </summary>
        public const string WSSRCHWRD = "WSSRCHWRD";

        /// <summary>
        /// WSAID.
        /// </summary>
        public const string WSAID = "WSAID";

        /// <summary>
        /// WSANI.
        /// </summary>
        public const string WSANI = "WSANI";

        /// <summary>
        /// WSSY.
        /// </summary>
        public const string WSSY = "WSSY";
    }

    /// <inheritdoc />
    public override string TableName => "F0901WS";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WSSRCHWRD", "WSSRCHWRD", JdeDataType.String, 80, true, true),
        new JdeField("WSAID", "WSAID", JdeDataType.String, 16, true, true),
        new JdeField("WSANI", "WSANI", JdeDataType.String, 58),
        new JdeField("WSSY", "WSSY", JdeDataType.String, 8, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0901WS_0", "Primary Key on WSSRCHWRD, WSAID, WSSY", new[] { "WSSRCHWRD", "WSAID", "WSSY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0901WS_3", "Index on WSSRCHWRD, WSAID", new[] { "WSSRCHWRD", "WSAID" }),
        new JdeIndex("F0901WS_4", "Index on WSSY", new[] { "WSSY" })
    };
}
