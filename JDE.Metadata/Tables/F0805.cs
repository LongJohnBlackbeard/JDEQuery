using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0805 - .
/// </summary>
public class F0805 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EREXTSYS.
        /// </summary>
        public const string EREXTSYS = "EREXTSYS";

        /// <summary>
        /// ERENTROLE.
        /// </summary>
        public const string ERENTROLE = "ERENTROLE";

        /// <summary>
        /// ERDL01.
        /// </summary>
        public const string ERDL01 = "ERDL01";

        /// <summary>
        /// ERUSER.
        /// </summary>
        public const string ERUSER = "ERUSER";

        /// <summary>
        /// ERPID.
        /// </summary>
        public const string ERPID = "ERPID";

        /// <summary>
        /// ERJOBN.
        /// </summary>
        public const string ERJOBN = "ERJOBN";

        /// <summary>
        /// ERUPMJ.
        /// </summary>
        public const string ERUPMJ = "ERUPMJ";

        /// <summary>
        /// ERUPMT.
        /// </summary>
        public const string ERUPMT = "ERUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F0805";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EREXTSYS", "EREXTSYS", JdeDataType.String, 20, true, true),
        new JdeField("ERENTROLE", "ERENTROLE", JdeDataType.String, 60, true, true),
        new JdeField("ERDL01", "ERDL01", JdeDataType.String, 60),
        new JdeField("ERUSER", "ERUSER", JdeDataType.String, 20),
        new JdeField("ERPID", "ERPID", JdeDataType.String, 20),
        new JdeField("ERJOBN", "ERJOBN", JdeDataType.String, 20),
        new JdeField("ERUPMJ", "ERUPMJ", JdeDataType.Numeric),
        new JdeField("ERUPMT", "ERUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0805_0", "Primary Key on EREXTSYS, ERENTROLE", new[] { "EREXTSYS", "ERENTROLE" }, isUnique: true, isPrimaryKey: true)
    };
}
