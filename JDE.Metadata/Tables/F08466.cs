using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08466 - .
/// </summary>
public class F08466 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ERPSTCAT.
        /// </summary>
        public const string ERPSTCAT = "ERPSTCAT";

        /// <summary>
        /// ERLNGP.
        /// </summary>
        public const string ERLNGP = "ERLNGP";

        /// <summary>
        /// EREMAL.
        /// </summary>
        public const string EREMAL = "EREMAL";

        /// <summary>
        /// ERWEBURL.
        /// </summary>
        public const string ERWEBURL = "ERWEBURL";

        /// <summary>
        /// ERPID.
        /// </summary>
        public const string ERPID = "ERPID";

        /// <summary>
        /// ERUSER.
        /// </summary>
        public const string ERUSER = "ERUSER";

        /// <summary>
        /// ERMKEY.
        /// </summary>
        public const string ERMKEY = "ERMKEY";

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
    public override string TableName => "F08466";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ERPSTCAT", "ERPSTCAT", JdeDataType.String, 20, true, true),
        new JdeField("ERLNGP", "ERLNGP", JdeDataType.String, 4, true, true),
        new JdeField("EREMAL", "EREMAL", JdeDataType.String, 512),
        new JdeField("ERWEBURL", "ERWEBURL", JdeDataType.String, 512),
        new JdeField("ERPID", "ERPID", JdeDataType.String, 20),
        new JdeField("ERUSER", "ERUSER", JdeDataType.String, 20),
        new JdeField("ERMKEY", "ERMKEY", JdeDataType.String, 30),
        new JdeField("ERUPMJ", "ERUPMJ", JdeDataType.Numeric),
        new JdeField("ERUPMT", "ERUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08466_0", "Primary Key on ERPSTCAT, ERLNGP", new[] { "ERPSTCAT", "ERLNGP" }, isUnique: true, isPrimaryKey: true)
    };
}
