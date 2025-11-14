using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75T032 - .
/// </summary>
public class F75T032 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DBMCU.
        /// </summary>
        public const string DBMCU = "DBMCU";

        /// <summary>
        /// DB75TDSI.
        /// </summary>
        public const string DB75TDSI = "DB75TDSI";

        /// <summary>
        /// DBUSER.
        /// </summary>
        public const string DBUSER = "DBUSER";

        /// <summary>
        /// DBPID.
        /// </summary>
        public const string DBPID = "DBPID";

        /// <summary>
        /// DBJOBN.
        /// </summary>
        public const string DBJOBN = "DBJOBN";

        /// <summary>
        /// DBUPMJ.
        /// </summary>
        public const string DBUPMJ = "DBUPMJ";

        /// <summary>
        /// DBUPMT.
        /// </summary>
        public const string DBUPMT = "DBUPMT";

        /// <summary>
        /// DBYFUTDT.
        /// </summary>
        public const string DBYFUTDT = "DBYFUTDT";

        /// <summary>
        /// DBFFU4.
        /// </summary>
        public const string DBFFU4 = "DBFFU4";

        /// <summary>
        /// DBFUT3.
        /// </summary>
        public const string DBFUT3 = "DBFUT3";

        /// <summary>
        /// DBX2.
        /// </summary>
        public const string DBX2 = "DBX2";

        /// <summary>
        /// DBFUTCH1.
        /// </summary>
        public const string DBFUTCH1 = "DBFUTCH1";
    }

    /// <inheritdoc />
    public override string TableName => "F75T032";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DBMCU", "DBMCU", JdeDataType.String, 24, true, true),
        new JdeField("DB75TDSI", "DB75TDSI", JdeDataType.String, 10),
        new JdeField("DBUSER", "DBUSER", JdeDataType.String, 20),
        new JdeField("DBPID", "DBPID", JdeDataType.String, 20),
        new JdeField("DBJOBN", "DBJOBN", JdeDataType.String, 20),
        new JdeField("DBUPMJ", "DBUPMJ", JdeDataType.Numeric),
        new JdeField("DBUPMT", "DBUPMT", JdeDataType.Numeric),
        new JdeField("DBYFUTDT", "DBYFUTDT", JdeDataType.Numeric),
        new JdeField("DBFFU4", "DBFFU4", JdeDataType.Numeric),
        new JdeField("DBFUT3", "DBFUT3", JdeDataType.String, 60),
        new JdeField("DBX2", "DBX2", JdeDataType.String, 2),
        new JdeField("DBFUTCH1", "DBFUTCH1", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75T032_0", "Primary Key on DBMCU", new[] { "DBMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
