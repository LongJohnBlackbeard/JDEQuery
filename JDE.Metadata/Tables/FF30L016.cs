using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L016 - .
/// </summary>
public class FF30L016 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DBTERM.
        /// </summary>
        public const string DBTERM = "DBTERM";

        /// <summary>
        /// DBFSCID.
        /// </summary>
        public const string DBFSCID = "DBFSCID";

        /// <summary>
        /// DBDFMCU.
        /// </summary>
        public const string DBDFMCU = "DBDFMCU";

        /// <summary>
        /// DBUSER.
        /// </summary>
        public const string DBUSER = "DBUSER";

        /// <summary>
        /// DBPID.
        /// </summary>
        public const string DBPID = "DBPID";

        /// <summary>
        /// DBMKEY.
        /// </summary>
        public const string DBMKEY = "DBMKEY";

        /// <summary>
        /// DBUUPMJ.
        /// </summary>
        public const string DBUUPMJ = "DBUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L016";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DBTERM", "DBTERM", JdeDataType.String, 20, true, true),
        new JdeField("DBFSCID", "DBFSCID", JdeDataType.Numeric),
        new JdeField("DBDFMCU", "DBDFMCU", JdeDataType.String, 24),
        new JdeField("DBUSER", "DBUSER", JdeDataType.String, 20),
        new JdeField("DBPID", "DBPID", JdeDataType.String, 20),
        new JdeField("DBMKEY", "DBMKEY", JdeDataType.String, 30),
        new JdeField("DBUUPMJ", "DBUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L016_0", "Primary Key on DBTERM", new[] { "DBTERM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L016_2", "Index on DBFSCID", new[] { "DBFSCID" })
    };
}
