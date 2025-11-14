using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0690361 - .
/// </summary>
public class F0690361 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ROAN8.
        /// </summary>
        public const string ROAN8 = "ROAN8";

        /// <summary>
        /// ROPDBA.
        /// </summary>
        public const string ROPDBA = "ROPDBA";

        /// <summary>
        /// RORLOV.
        /// </summary>
        public const string RORLOV = "RORLOV";

        /// <summary>
        /// RORTAB.
        /// </summary>
        public const string RORTAB = "RORTAB";

        /// <summary>
        /// ROPID.
        /// </summary>
        public const string ROPID = "ROPID";

        /// <summary>
        /// ROUSER.
        /// </summary>
        public const string ROUSER = "ROUSER";

        /// <summary>
        /// ROUPMJ.
        /// </summary>
        public const string ROUPMJ = "ROUPMJ";

        /// <summary>
        /// ROUPMT.
        /// </summary>
        public const string ROUPMT = "ROUPMT";

        /// <summary>
        /// ROJOBN.
        /// </summary>
        public const string ROJOBN = "ROJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F0690361";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ROAN8", "ROAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ROPDBA", "ROPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("RORLOV", "RORLOV", JdeDataType.String, 2),
        new JdeField("RORTAB", "RORTAB", JdeDataType.String, 10),
        new JdeField("ROPID", "ROPID", JdeDataType.String, 20),
        new JdeField("ROUSER", "ROUSER", JdeDataType.String, 20),
        new JdeField("ROUPMJ", "ROUPMJ", JdeDataType.Numeric),
        new JdeField("ROUPMT", "ROUPMT", JdeDataType.Numeric),
        new JdeField("ROJOBN", "ROJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0690361_0", "Primary Key on ROAN8, ROPDBA", new[] { "ROAN8", "ROPDBA" }, isUnique: true, isPrimaryKey: true)
    };
}
