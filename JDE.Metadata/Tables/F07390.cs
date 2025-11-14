using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07390 - .
/// </summary>
public class F07390 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ROPDBA.
        /// </summary>
        public const string ROPDBA = "ROPDBA";

        /// <summary>
        /// RODL01.
        /// </summary>
        public const string RODL01 = "RODL01";

        /// <summary>
        /// ROSVH.
        /// </summary>
        public const string ROSVH = "ROSVH";

        /// <summary>
        /// RORTAB.
        /// </summary>
        public const string RORTAB = "RORTAB";

        /// <summary>
        /// RODTAB.
        /// </summary>
        public const string RODTAB = "RODTAB";

        /// <summary>
        /// RODISO.
        /// </summary>
        public const string RODISO = "RODISO";

        /// <summary>
        /// RONPER.
        /// </summary>
        public const string RONPER = "RONPER";

        /// <summary>
        /// RODBAL.
        /// </summary>
        public const string RODBAL = "RODBAL";

        /// <summary>
        /// ROEXA.
        /// </summary>
        public const string ROEXA = "ROEXA";

        /// <summary>
        /// ROCMAX.
        /// </summary>
        public const string ROCMAX = "ROCMAX";

        /// <summary>
        /// ROJOBN.
        /// </summary>
        public const string ROJOBN = "ROJOBN";

        /// <summary>
        /// ROUSER.
        /// </summary>
        public const string ROUSER = "ROUSER";

        /// <summary>
        /// ROPID.
        /// </summary>
        public const string ROPID = "ROPID";

        /// <summary>
        /// ROUPMJ.
        /// </summary>
        public const string ROUPMJ = "ROUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F07390";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ROPDBA", "ROPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("RODL01", "RODL01", JdeDataType.String, 60, true, true),
        new JdeField("ROSVH", "ROSVH", JdeDataType.String, 2),
        new JdeField("RORTAB", "RORTAB", JdeDataType.String, 10),
        new JdeField("RODTAB", "RODTAB", JdeDataType.String, 10),
        new JdeField("RODISO", "RODISO", JdeDataType.String, 2),
        new JdeField("RONPER", "RONPER", JdeDataType.String, 2),
        new JdeField("RODBAL", "RODBAL", JdeDataType.String, 2),
        new JdeField("ROEXA", "ROEXA", JdeDataType.String, 60),
        new JdeField("ROCMAX", "ROCMAX", JdeDataType.Numeric),
        new JdeField("ROJOBN", "ROJOBN", JdeDataType.String, 20),
        new JdeField("ROUSER", "ROUSER", JdeDataType.String, 20),
        new JdeField("ROPID", "ROPID", JdeDataType.String, 20),
        new JdeField("ROUPMJ", "ROUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07390_0", "Primary Key on ROPDBA, RODL01", new[] { "ROPDBA", "RODL01" }, isUnique: true, isPrimaryKey: true)
    };
}
