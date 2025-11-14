using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D300 - .
/// </summary>
public class F80D300 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DBDBC.
        /// </summary>
        public const string DBDBC = "DBDBC";

        /// <summary>
        /// DBDFCC.
        /// </summary>
        public const string DBDFCC = "DBDFCC";

        /// <summary>
        /// DBDTPN.
        /// </summary>
        public const string DBDTPN = "DBDTPN";

        /// <summary>
        /// DBSBC.
        /// </summary>
        public const string DBSBC = "DBSBC";

        /// <summary>
        /// DBMDLIMIT.
        /// </summary>
        public const string DBMDLIMIT = "DBMDLIMIT";

        /// <summary>
        /// DBURCD.
        /// </summary>
        public const string DBURCD = "DBURCD";

        /// <summary>
        /// DBURDT.
        /// </summary>
        public const string DBURDT = "DBURDT";

        /// <summary>
        /// DBURAT.
        /// </summary>
        public const string DBURAT = "DBURAT";

        /// <summary>
        /// DBURAB.
        /// </summary>
        public const string DBURAB = "DBURAB";

        /// <summary>
        /// DBURRF.
        /// </summary>
        public const string DBURRF = "DBURRF";

        /// <summary>
        /// DBUSER.
        /// </summary>
        public const string DBUSER = "DBUSER";

        /// <summary>
        /// DBMKEY.
        /// </summary>
        public const string DBMKEY = "DBMKEY";

        /// <summary>
        /// DBPID.
        /// </summary>
        public const string DBPID = "DBPID";

        /// <summary>
        /// DBUUPMJ.
        /// </summary>
        public const string DBUUPMJ = "DBUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F80D300";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DBDBC", "DBDBC", JdeDataType.String, 12, true, true),
        new JdeField("DBDFCC", "DBDFCC", JdeDataType.String, 6),
        new JdeField("DBDTPN", "DBDTPN", JdeDataType.String, 2),
        new JdeField("DBSBC", "DBSBC", JdeDataType.String, 8),
        new JdeField("DBMDLIMIT", "DBMDLIMIT", JdeDataType.Numeric),
        new JdeField("DBURCD", "DBURCD", JdeDataType.String, 4),
        new JdeField("DBURDT", "DBURDT", JdeDataType.Numeric),
        new JdeField("DBURAT", "DBURAT", JdeDataType.Numeric),
        new JdeField("DBURAB", "DBURAB", JdeDataType.Numeric),
        new JdeField("DBURRF", "DBURRF", JdeDataType.String, 30),
        new JdeField("DBUSER", "DBUSER", JdeDataType.String, 20),
        new JdeField("DBMKEY", "DBMKEY", JdeDataType.String, 30),
        new JdeField("DBPID", "DBPID", JdeDataType.String, 20),
        new JdeField("DBUUPMJ", "DBUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D300_0", "Primary Key on DBDBC", new[] { "DBDBC" }, isUnique: true, isPrimaryKey: true)
    };
}
