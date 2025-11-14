using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08368 - .
/// </summary>
public class F08368 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DBTSTN.
        /// </summary>
        public const string DBTSTN = "DBTSTN";

        /// <summary>
        /// DBTSTY.
        /// </summary>
        public const string DBTSTY = "DBTSTY";

        /// <summary>
        /// DBHMCO.
        /// </summary>
        public const string DBHMCO = "DBHMCO";

        /// <summary>
        /// DBTAXX.
        /// </summary>
        public const string DBTAXX = "DBTAXX";

        /// <summary>
        /// DBHCEE.
        /// </summary>
        public const string DBHCEE = "DBHCEE";

        /// <summary>
        /// DBNHCE.
        /// </summary>
        public const string DBNHCE = "DBNHCE";

        /// <summary>
        /// DBADPH.
        /// </summary>
        public const string DBADPH = "DBADPH";

        /// <summary>
        /// DBADP.
        /// </summary>
        public const string DBADP = "DBADP";

        /// <summary>
        /// DBACPH.
        /// </summary>
        public const string DBACPH = "DBACPH";

        /// <summary>
        /// DBACP.
        /// </summary>
        public const string DBACP = "DBACP";

        /// <summary>
        /// DBDISC.
        /// </summary>
        public const string DBDISC = "DBDISC";

        /// <summary>
        /// DBDIS1.
        /// </summary>
        public const string DBDIS1 = "DBDIS1";

        /// <summary>
        /// DBDT2A.
        /// </summary>
        public const string DBDT2A = "DBDT2A";

        /// <summary>
        /// DBDT2B.
        /// </summary>
        public const string DBDT2B = "DBDT2B";

        /// <summary>
        /// DBCVRG.
        /// </summary>
        public const string DBCVRG = "DBCVRG";
    }

    /// <inheritdoc />
    public override string TableName => "F08368";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DBTSTN", "DBTSTN", JdeDataType.String, 16, true, true),
        new JdeField("DBTSTY", "DBTSTY", JdeDataType.Numeric, null, true, true),
        new JdeField("DBHMCO", "DBHMCO", JdeDataType.String, 10, true, true),
        new JdeField("DBTAXX", "DBTAXX", JdeDataType.String, 40),
        new JdeField("DBHCEE", "DBHCEE", JdeDataType.Numeric),
        new JdeField("DBNHCE", "DBNHCE", JdeDataType.Numeric),
        new JdeField("DBADPH", "DBADPH", JdeDataType.Numeric),
        new JdeField("DBADP", "DBADP", JdeDataType.Numeric),
        new JdeField("DBACPH", "DBACPH", JdeDataType.Numeric),
        new JdeField("DBACP", "DBACP", JdeDataType.Numeric),
        new JdeField("DBDISC", "DBDISC", JdeDataType.String, 2),
        new JdeField("DBDIS1", "DBDIS1", JdeDataType.String, 2),
        new JdeField("DBDT2A", "DBDT2A", JdeDataType.String, 2),
        new JdeField("DBDT2B", "DBDT2B", JdeDataType.String, 2),
        new JdeField("DBCVRG", "DBCVRG", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08368_0", "Primary Key on DBTSTN, DBTSTY, DBHMCO", new[] { "DBTSTN", "DBTSTY", "DBHMCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08368_2", "Index on DBTSTN, DBTSTY, DBTAXX", new[] { "DBTSTN", "DBTSTY", "DBTAXX" })
    };
}
