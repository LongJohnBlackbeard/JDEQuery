using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CF14A - .
/// </summary>
public class F90CF14A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCRATSTITM.
        /// </summary>
        public const string CCRATSTITM = "CCRATSTITM";

        /// <summary>
        /// CCRTSTID.
        /// </summary>
        public const string CCRTSTID = "CCRTSTID";

        /// <summary>
        /// CCRATVAL.
        /// </summary>
        public const string CCRATVAL = "CCRATVAL";

        /// <summary>
        /// CCRATESCR.
        /// </summary>
        public const string CCRATESCR = "CCRATESCR";

        /// <summary>
        /// CCUSER.
        /// </summary>
        public const string CCUSER = "CCUSER";

        /// <summary>
        /// CCUDTTM.
        /// </summary>
        public const string CCUDTTM = "CCUDTTM";

        /// <summary>
        /// CCJOBN.
        /// </summary>
        public const string CCJOBN = "CCJOBN";

        /// <summary>
        /// CCMKEY.
        /// </summary>
        public const string CCMKEY = "CCMKEY";
    }

    /// <inheritdoc />
    public override string TableName => "F90CF14A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCRATSTITM", "CCRATSTITM", JdeDataType.Numeric, null, true, true),
        new JdeField("CCRTSTID", "CCRTSTID", JdeDataType.Numeric),
        new JdeField("CCRATVAL", "CCRATVAL", JdeDataType.String, 80),
        new JdeField("CCRATESCR", "CCRATESCR", JdeDataType.Numeric),
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20),
        new JdeField("CCUDTTM", "CCUDTTM", JdeDataType.Date),
        new JdeField("CCJOBN", "CCJOBN", JdeDataType.String, 20),
        new JdeField("CCMKEY", "CCMKEY", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CF14A_0", "Primary Key on CCRATSTITM", new[] { "CCRATSTITM" }, isUnique: true, isPrimaryKey: true)
    };
}
