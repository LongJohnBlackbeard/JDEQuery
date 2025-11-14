using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76V305 - .
/// </summary>
public class F76V305 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ROV76FOCR.
        /// </summary>
        public const string ROV76FOCR = "ROV76FOCR";

        /// <summary>
        /// ROV76FOCD.
        /// </summary>
        public const string ROV76FOCD = "ROV76FOCD";

        /// <summary>
        /// ROSEQ.
        /// </summary>
        public const string ROSEQ = "ROSEQ";

        /// <summary>
        /// ROUSER.
        /// </summary>
        public const string ROUSER = "ROUSER";

        /// <summary>
        /// ROPID.
        /// </summary>
        public const string ROPID = "ROPID";

        /// <summary>
        /// ROJOBN.
        /// </summary>
        public const string ROJOBN = "ROJOBN";

        /// <summary>
        /// ROUPMJ.
        /// </summary>
        public const string ROUPMJ = "ROUPMJ";

        /// <summary>
        /// ROUPMT.
        /// </summary>
        public const string ROUPMT = "ROUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76V305";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ROV76FOCR", "ROV76FOCR", JdeDataType.String, 8, true, true),
        new JdeField("ROV76FOCD", "ROV76FOCD", JdeDataType.String, 200),
        new JdeField("ROSEQ", "ROSEQ", JdeDataType.Numeric),
        new JdeField("ROUSER", "ROUSER", JdeDataType.String, 20),
        new JdeField("ROPID", "ROPID", JdeDataType.String, 20),
        new JdeField("ROJOBN", "ROJOBN", JdeDataType.String, 20),
        new JdeField("ROUPMJ", "ROUPMJ", JdeDataType.Numeric),
        new JdeField("ROUPMT", "ROUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76V305_0", "Primary Key on ROV76FOCR", new[] { "ROV76FOCR" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76V305_2", "Index on ROSEQ", new[] { "ROSEQ" })
    };
}
