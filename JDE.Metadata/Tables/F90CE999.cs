using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CE999 - .
/// </summary>
public class F90CE999 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AUSLTNID.
        /// </summary>
        public const string AUSLTNID = "AUSLTNID";

        /// <summary>
        /// AULIBNAME.
        /// </summary>
        public const string AULIBNAME = "AULIBNAME";

        /// <summary>
        /// AUEDATE.
        /// </summary>
        public const string AUEDATE = "AUEDATE";

        /// <summary>
        /// AUUDTTM.
        /// </summary>
        public const string AUUDTTM = "AUUDTTM";

        /// <summary>
        /// AUMKEY.
        /// </summary>
        public const string AUMKEY = "AUMKEY";

        /// <summary>
        /// AUUSER.
        /// </summary>
        public const string AUUSER = "AUUSER";

        /// <summary>
        /// AUENTDBY.
        /// </summary>
        public const string AUENTDBY = "AUENTDBY";
    }

    /// <inheritdoc />
    public override string TableName => "F90CE999";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AUSLTNID", "AUSLTNID", JdeDataType.Numeric, null, true, true),
        new JdeField("AULIBNAME", "AULIBNAME", JdeDataType.String, 60),
        new JdeField("AUEDATE", "AUEDATE", JdeDataType.Date),
        new JdeField("AUUDTTM", "AUUDTTM", JdeDataType.Date),
        new JdeField("AUMKEY", "AUMKEY", JdeDataType.String, 30),
        new JdeField("AUUSER", "AUUSER", JdeDataType.String, 20),
        new JdeField("AUENTDBY", "AUENTDBY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CE999_0", "Primary Key on AUSLTNID", new[] { "AUSLTNID" }, isUnique: true, isPrimaryKey: true)
    };
}
